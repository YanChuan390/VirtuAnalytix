using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000002")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x19C6B24", Offset = "0x19C6B24", VA = "0x19C6B24")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x19C6DB4", Offset = "0x19C6DB4", VA = "0x19C6DB4")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x19C6F34", Offset = "0x19C6F34", VA = "0x19C6F34")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x19C6FB4", Offset = "0x19C6FB4", VA = "0x19C6FB4", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x19C709C", Offset = "0x19C709C", VA = "0x19C709C", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x19C7144", Offset = "0x19C7144", VA = "0x19C7144")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x2000003")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x19C71B0", Offset = "0x19C71B0", VA = "0x19C71B0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x19C71B4", Offset = "0x19C71B4", VA = "0x19C71B4")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x19C729C", Offset = "0x19C729C", VA = "0x19C729C")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x19C7384", Offset = "0x19C7384", VA = "0x19C7384")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x19C746C", Offset = "0x19C746C", VA = "0x19C746C")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x19C7554", Offset = "0x19C7554", VA = "0x19C7554")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x19C763C", Offset = "0x19C763C", VA = "0x19C763C")]
		public void Update()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x19C7640", Offset = "0x19C7640", VA = "0x19C7640")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x20000B2")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x40004FD")]
			Hardware,
			[Token(Token = "0x40004FE")]
			Touch
		}

		[Token(Token = "0x20000B3")]
		public class VirtualAxis
		{
			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D6CF4", Offset = "0x8D6CF4")]
			private string <name>k__BackingField;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D6D04", Offset = "0x8D6D04")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x1700006B")]
			public string name
			{
				[Token(Token = "0x60005C0")]
				[Address(RVA = "0x19C8590", Offset = "0x19C8590", VA = "0x19C8590")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBA20", Offset = "0x8DBA20")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005C1")]
				[Address(RVA = "0x19C8598", Offset = "0x19C8598", VA = "0x19C8598")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBA30", Offset = "0x8DBA30")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006C")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x60005C2")]
				[Address(RVA = "0x19C85A0", Offset = "0x19C85A0", VA = "0x19C85A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBA40", Offset = "0x8DBA40")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005C3")]
				[Address(RVA = "0x19C85A8", Offset = "0x19C85A8", VA = "0x19C85A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBA50", Offset = "0x8DBA50")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public float GetValue
			{
				[Token(Token = "0x60005C8")]
				[Address(RVA = "0x19C85FC", Offset = "0x19C85FC", VA = "0x19C85FC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700006E")]
			public float GetValueRaw
			{
				[Token(Token = "0x60005C9")]
				[Address(RVA = "0x19C8604", Offset = "0x19C8604", VA = "0x19C8604")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x19C6C90", Offset = "0x19C6C90", VA = "0x19C6C90")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x19C85B4", Offset = "0x19C85B4", VA = "0x19C85B4")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x19C6F4C", Offset = "0x19C6F4C", VA = "0x19C6F4C")]
			public void Remove()
			{
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x19C85F4", Offset = "0x19C85F4", VA = "0x19C85F4")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x20000B4")]
		public class VirtualButton
		{
			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D6D14", Offset = "0x8D6D14")]
			private string <name>k__BackingField;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D6D24", Offset = "0x8D6D24")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x1700006F")]
			public string name
			{
				[Token(Token = "0x60005CA")]
				[Address(RVA = "0x19C860C", Offset = "0x19C860C", VA = "0x19C860C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBA60", Offset = "0x8DBA60")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005CB")]
				[Address(RVA = "0x19C8614", Offset = "0x19C8614", VA = "0x19C8614")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBA70", Offset = "0x8DBA70")]
				private set
				{
				}
			}

			[Token(Token = "0x17000070")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x60005CC")]
				[Address(RVA = "0x19C861C", Offset = "0x19C861C", VA = "0x19C861C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBA80", Offset = "0x8DBA80")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005CD")]
				[Address(RVA = "0x19C8624", Offset = "0x19C8624", VA = "0x19C8624")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBA90", Offset = "0x8DBA90")]
				private set
				{
				}
			}

			[Token(Token = "0x17000071")]
			public bool GetButton
			{
				[Token(Token = "0x60005D3")]
				[Address(RVA = "0x19C8784", Offset = "0x19C8784", VA = "0x19C8784")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000072")]
			public bool GetButtonDown
			{
				[Token(Token = "0x60005D4")]
				[Address(RVA = "0x19C878C", Offset = "0x19C878C", VA = "0x19C878C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000073")]
			public bool GetButtonUp
			{
				[Token(Token = "0x60005D5")]
				[Address(RVA = "0x19C87BC", Offset = "0x19C87BC", VA = "0x19C87BC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x19C8630", Offset = "0x19C8630", VA = "0x19C8630")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x19C866C", Offset = "0x19C866C", VA = "0x19C866C")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x19C86B4", Offset = "0x19C86B4", VA = "0x19C86B4")]
			public void Pressed()
			{
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x19C86F0", Offset = "0x19C86F0", VA = "0x19C86F0")]
			public void Released()
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x19C871C", Offset = "0x19C871C", VA = "0x19C871C")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x17000001")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x19C8210", Offset = "0x19C8210", VA = "0x19C8210")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x19C7648", Offset = "0x19C7648", VA = "0x19C7648")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x19C76E8", Offset = "0x19C76E8", VA = "0x19C76E8")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x19C6C18", Offset = "0x19C6C18", VA = "0x19C6C18")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x19C7800", Offset = "0x19C7800", VA = "0x19C7800")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x19C6CC4", Offset = "0x19C6CC4", VA = "0x19C6CC4")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x19C7A08", Offset = "0x19C7A08", VA = "0x19C7A08")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x19C7BA8", Offset = "0x19C7BA8", VA = "0x19C7BA8")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x19C7CF8", Offset = "0x19C7CF8", VA = "0x19C7CF8")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x19C6D3C", Offset = "0x19C6D3C", VA = "0x19C6D3C")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x19C7E9C", Offset = "0x19C7E9C", VA = "0x19C7E9C")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x19C7F94", Offset = "0x19C7F94", VA = "0x19C7F94")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x19C7F04", Offset = "0x19C7F04", VA = "0x19C7F04")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x19C7FFC", Offset = "0x19C7FFC", VA = "0x19C7FFC")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x19C807C", Offset = "0x19C807C", VA = "0x19C807C")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x19C80FC", Offset = "0x19C80FC", VA = "0x19C80FC")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x19C721C", Offset = "0x19C721C", VA = "0x19C721C")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x19C7304", Offset = "0x19C7304", VA = "0x19C7304")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x19C73EC", Offset = "0x19C73EC", VA = "0x19C73EC")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x19C75BC", Offset = "0x19C75BC", VA = "0x19C75BC")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x19C74D4", Offset = "0x19C74D4", VA = "0x19C74D4")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x19C817C", Offset = "0x19C817C", VA = "0x19C817C")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x19C828C", Offset = "0x19C828C", VA = "0x19C828C")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x19C8388", Offset = "0x19C8388", VA = "0x19C8388")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x19C8490", Offset = "0x19C8490", VA = "0x19C8490")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000005")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x19C87EC", Offset = "0x19C87EC", VA = "0x19C87EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x19C87F0", Offset = "0x19C87F0", VA = "0x19C87F0")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x19C8870", Offset = "0x19C8870", VA = "0x19C8870")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x20000B5")]
		public enum AxisOption
		{
			[Token(Token = "0x4000508")]
			Both,
			[Token(Token = "0x4000509")]
			OnlyHorizontal,
			[Token(Token = "0x400050A")]
			OnlyVertical
		}

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x19C8878", Offset = "0x19C8878", VA = "0x19C8878")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x19C89F4", Offset = "0x19C89F4", VA = "0x19C89F4")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x19C88B8", Offset = "0x19C88B8", VA = "0x19C88B8")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x19C8AE4", Offset = "0x19C8AE4", VA = "0x19C8AE4", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x19C8CA4", Offset = "0x19C8CA4", VA = "0x19C8CA4", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x19C8CEC", Offset = "0x19C8CEC", VA = "0x19C8CEC", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x19C8CF0", Offset = "0x19C8CF0", VA = "0x19C8CF0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x19C8D40", Offset = "0x19C8D40", VA = "0x19C8D40")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000007")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x19C8DB0", Offset = "0x19C8DB0", VA = "0x19C8DB0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x19C8DB8", Offset = "0x19C8DB8", VA = "0x19C8DB8")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x19C8DC0", Offset = "0x19C8DC0", VA = "0x19C8DC0")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x19C902C", Offset = "0x19C902C", VA = "0x19C902C")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x20000B6")]
		public enum AxisOptions
		{
			[Token(Token = "0x400050C")]
			ForwardAxis,
			[Token(Token = "0x400050D")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x20000B7")]
		public class AxisMapping
		{
			[Token(Token = "0x2000112")]
			public enum MappingType
			{
				[Token(Token = "0x4000759")]
				NamedAxis,
				[Token(Token = "0x400075A")]
				MousePositionX,
				[Token(Token = "0x400075B")]
				MousePositionY,
				[Token(Token = "0x400075C")]
				MousePositionZ
			}

			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x19C9EDC", Offset = "0x19C9EDC", VA = "0x19C9EDC")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x19C9B68", Offset = "0x19C9B68", VA = "0x19C9B68")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x19C9C28", Offset = "0x19C9C28", VA = "0x19C9C28")]
		private void Update()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x19C9EB4", Offset = "0x19C9EB4", VA = "0x19C9EB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x19C9ECC", Offset = "0x19C9ECC", VA = "0x19C9ECC")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8D1A48", Offset = "0x8D1A48")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x20000B8")]
		public enum AxisOption
		{
			[Token(Token = "0x4000511")]
			Both,
			[Token(Token = "0x4000512")]
			OnlyHorizontal,
			[Token(Token = "0x4000513")]
			OnlyVertical
		}

		[Token(Token = "0x20000B9")]
		public enum ControlStyle
		{
			[Token(Token = "0x4000515")]
			Absolute,
			[Token(Token = "0x4000516")]
			Relative,
			[Token(Token = "0x4000517")]
			Swipe
		}

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x19C9EE4", Offset = "0x19C9EE4", VA = "0x19C9EE4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x19C9F68", Offset = "0x19C9F68", VA = "0x19C9F68")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x19CA0A4", Offset = "0x19CA0A4", VA = "0x19CA0A4")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x19CA110", Offset = "0x19CA110", VA = "0x19CA110", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x19CA1C0", Offset = "0x19CA1C0", VA = "0x19CA1C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x19CA394", Offset = "0x19CA394", VA = "0x19CA394", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x19CA40C", Offset = "0x19CA40C", VA = "0x19CA40C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x19CA500", Offset = "0x19CA500", VA = "0x19CA500")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D29B4", Offset = "0x8D29B4")]
		private Vector3 <virtualMousePosition>k__BackingField;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x17000002")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x19CA578", Offset = "0x19CA578", VA = "0x19CA578")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D9C54", Offset = "0x8D9C54")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x19CA584", Offset = "0x19CA584", VA = "0x19CA584")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D9C64", Offset = "0x8D9C64")]
			private set
			{
			}
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x19C7798", Offset = "0x19C7798", VA = "0x19C7798")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x19C7878", Offset = "0x19C7878", VA = "0x19C7878")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x19C78E0", Offset = "0x19C78E0", VA = "0x19C78E0")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x19C7A80", Offset = "0x19C7A80", VA = "0x19C7A80")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x19C7C60", Offset = "0x19C7C60", VA = "0x19C7C60")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x19C7D70", Offset = "0x19C7D70", VA = "0x19C7D70")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x19C7E08", Offset = "0x19C7E08", VA = "0x19C7E08")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x19C833C", Offset = "0x19C833C", VA = "0x19C833C")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x19C843C", Offset = "0x19C843C", VA = "0x19C843C")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x19C8540", Offset = "0x19C8540", VA = "0x19C8540")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x600004F")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x6000050")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x6000051")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x6000052")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x6000053")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x6000054")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x6000055")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x6000056")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x6000057")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x6000058")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x6000059")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x19C97E0", Offset = "0x19C97E0", VA = "0x19C97E0")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x200000B")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x19C9034", Offset = "0x19C9034", VA = "0x19C9034")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x19C90C8", Offset = "0x19C90C8", VA = "0x19C90C8")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x19C9154", Offset = "0x19C9154", VA = "0x19C9154", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x19C91F0", Offset = "0x19C91F0", VA = "0x19C91F0", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x19C92A8", Offset = "0x19C92A8", VA = "0x19C92A8", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x19C9354", Offset = "0x19C9354", VA = "0x19C9354", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x19C93F4", Offset = "0x19C93F4", VA = "0x19C93F4", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x19C9494", Offset = "0x19C9494", VA = "0x19C9494", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x19C9530", Offset = "0x19C9530", VA = "0x19C9530", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x19C95D8", Offset = "0x19C95D8", VA = "0x19C95D8", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x19C9688", Offset = "0x19C9688", VA = "0x19C9688", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x19C9738", Offset = "0x19C9738", VA = "0x19C9738", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x19C97D4", Offset = "0x19C97D4", VA = "0x19C97D4", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x19C76E0", Offset = "0x19C76E0", VA = "0x19C76E0")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x19C98A0", Offset = "0x19C98A0", VA = "0x19C98A0", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x19C98B4", Offset = "0x19C98B4", VA = "0x19C98B4", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x19C98C0", Offset = "0x19C98C0", VA = "0x19C98C0", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x19C98CC", Offset = "0x19C98CC", VA = "0x19C98CC", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x19C98D8", Offset = "0x19C98D8", VA = "0x19C98D8", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x19C9944", Offset = "0x19C9944", VA = "0x19C9944", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x19C99B0", Offset = "0x19C99B0", VA = "0x19C99B0", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x19C9A1C", Offset = "0x19C9A1C", VA = "0x19C9A1C", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x19C9A88", Offset = "0x19C9A88", VA = "0x19C9A88", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x19C9AF4", Offset = "0x19C9AF4", VA = "0x19C9AF4", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x19C9B60", Offset = "0x19C9B60", VA = "0x19C9B60", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x19C76E4", Offset = "0x19C76E4", VA = "0x19C76E4")]
		public StandaloneInput()
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x200000D")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BA")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000519")]
			Update,
			[Token(Token = "0x400051A")]
			FixedUpdate,
			[Token(Token = "0x400051B")]
			LateUpdate,
			[Token(Token = "0x400051C")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D29C4", Offset = "0x8D29C4")]
		public bool smoothFollow;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D29FC", Offset = "0x8D29FC")]
		public float rotationSensitivity;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D2A34", Offset = "0x8D2A34")]
		public float distance;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D2A6C", Offset = "0x8D2A6C")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D2AA4", Offset = "0x8D2AA4")]
		public float blockedOffset;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2ABC", Offset = "0x8D2ABC")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2ACC", Offset = "0x8D2ACC")]
		private float <y>k__BackingField;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2ADC", Offset = "0x8D2ADC")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000003")]
		public float x
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x11E308C", Offset = "0x11E308C", VA = "0x11E308C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D9C74", Offset = "0x8D9C74")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x11E3094", Offset = "0x11E3094", VA = "0x11E3094")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D9C84", Offset = "0x8D9C84")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public float y
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x11E309C", Offset = "0x11E309C", VA = "0x11E309C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D9C94", Offset = "0x8D9C94")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x11E30A4", Offset = "0x11E30A4", VA = "0x11E30A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D9CA4", Offset = "0x8D9CA4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float distanceTarget
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x11E30AC", Offset = "0x11E30AC", VA = "0x11E30AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D9CB4", Offset = "0x8D9CB4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x11E30B4", Offset = "0x11E30B4", VA = "0x11E30B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D9CC4", Offset = "0x8D9CC4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		private float zoomAdd
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x11E3B1C", Offset = "0x11E3B1C", VA = "0x11E3B1C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x11E30BC", Offset = "0x11E30BC", VA = "0x11E30BC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x11E31D8", Offset = "0x11E31D8", VA = "0x11E31D8", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x11E3234", Offset = "0x11E3234", VA = "0x11E3234", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x11E329C", Offset = "0x11E329C", VA = "0x11E329C", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x11E3300", Offset = "0x11E3300", VA = "0x11E3300")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x11E320C", Offset = "0x11E320C", VA = "0x11E320C")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x11E3480", Offset = "0x11E3480", VA = "0x11E3480")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x11E3A6C", Offset = "0x11E3A6C", VA = "0x11E3A6C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x11E3B90", Offset = "0x11E3B90", VA = "0x11E3B90")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x11E3CA0", Offset = "0x11E3CA0", VA = "0x11E3CA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x11E3CD8", Offset = "0x11E3CD8", VA = "0x11E3CD8")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x11E3E90", Offset = "0x11E3E90", VA = "0x11E3E90")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x11E3F40", Offset = "0x11E3F40", VA = "0x11E3F40")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public enum Axis
	{
		[Token(Token = "0x400005B")]
		X,
		[Token(Token = "0x400005C")]
		Y,
		[Token(Token = "0x400005D")]
		Z
	}
	[Token(Token = "0x2000010")]
	public class AxisTools
	{
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x11DC294", Offset = "0x11DC294", VA = "0x11DC294")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x11DC34C", Offset = "0x11DC34C", VA = "0x11DC34C")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x11DC3F8", Offset = "0x11DC3F8", VA = "0x11DC3F8")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x11DC5DC", Offset = "0x11DC5DC", VA = "0x11DC5DC")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x11DC514", Offset = "0x11DC514", VA = "0x11DC514")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x11DC6F8", Offset = "0x11DC6F8", VA = "0x11DC6F8")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x11DC924", Offset = "0x11DC924", VA = "0x11DC924")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000011")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x20000BB")]
		public class LimbOrientation
		{
			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x11DCBEC", Offset = "0x11DCBEC", VA = "0x11DCBEC")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000007")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x11DC978", Offset = "0x11DC978", VA = "0x11DC978")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x11DCC64", Offset = "0x11DCC64", VA = "0x11DCC64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x11DC92C", Offset = "0x11DC92C", VA = "0x11DC92C")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000012")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x20000BC")]
		public enum BoneType
		{
			[Token(Token = "0x4000521")]
			Unassigned,
			[Token(Token = "0x4000522")]
			Spine,
			[Token(Token = "0x4000523")]
			Head,
			[Token(Token = "0x4000524")]
			Arm,
			[Token(Token = "0x4000525")]
			Leg,
			[Token(Token = "0x4000526")]
			Tail,
			[Token(Token = "0x4000527")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x20000BD")]
		public enum BoneSide
		{
			[Token(Token = "0x4000529")]
			Center,
			[Token(Token = "0x400052A")]
			Left,
			[Token(Token = "0x400052B")]
			Right
		}

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x11DCED8", Offset = "0x11DCED8", VA = "0x11DCED8")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x11DD1D8", Offset = "0x11DD1D8", VA = "0x11DD1D8")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x11DD428", Offset = "0x11DD428", VA = "0x11DD428")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x11DD4AC", Offset = "0x11DD4AC", VA = "0x11DD4AC")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x11DD558", Offset = "0x11DD558", VA = "0x11DD558")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x11DD088", Offset = "0x11DD088", VA = "0x11DD088")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x11DD388", Offset = "0x11DD388", VA = "0x11DD388")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x11DDD98", Offset = "0x11DDD98", VA = "0x11DDD98")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x11DDBB0", Offset = "0x11DDBB0", VA = "0x11DDBB0")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x11DDCA4", Offset = "0x11DDCA4", VA = "0x11DDCA4")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x11DD778", Offset = "0x11DD778", VA = "0x11DD778")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x11DD82C", Offset = "0x11DD82C", VA = "0x11DD82C")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x11DD8E0", Offset = "0x11DD8E0", VA = "0x11DD8E0")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x11DD994", Offset = "0x11DD994", VA = "0x11DD994")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x11DDA48", Offset = "0x11DDA48", VA = "0x11DDA48")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x11DDAFC", Offset = "0x11DDAFC", VA = "0x11DDAFC")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x11DDFAC", Offset = "0x11DDFAC", VA = "0x11DDFAC")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x11DD68C", Offset = "0x11DD68C", VA = "0x11DD68C")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x11DDF1C", Offset = "0x11DDF1C", VA = "0x11DDF1C")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x11DE01C", Offset = "0x11DE01C", VA = "0x11DE01C")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x11DE0F4", Offset = "0x11DE0F4", VA = "0x11DE0F4")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x11DDEA0", Offset = "0x11DDEA0", VA = "0x11DDEA0")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x11DDE28", Offset = "0x11DDE28", VA = "0x11DDE28")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000013")]
	public class BipedReferences
	{
		[Token(Token = "0x20000BE")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x17000074")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60005D9")]
				[Address(RVA = "0x11E3084", Offset = "0x11E3084", VA = "0x11E3084")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x98F5B4", Offset = "0x98F5B4", VA = "0x98F5B4")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000009")]
		public virtual bool isFilled
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x11DFC68", Offset = "0x11DFC68", VA = "0x11DFC68", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		public bool isEmpty
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x11E0054", Offset = "0x11E0054", VA = "0x11E0054")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x11E0064", Offset = "0x11E0064", VA = "0x11E0064", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x11E0490", Offset = "0x11E0490", VA = "0x11E0490", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x11E08C8", Offset = "0x11E08C8", VA = "0x11E08C8")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x11E0ED8", Offset = "0x11E0ED8", VA = "0x11E0ED8")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x11E0B14", Offset = "0x11E0B14", VA = "0x11E0B14")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x11E1688", Offset = "0x11E1688", VA = "0x11E1688")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x11E177C", Offset = "0x11E177C", VA = "0x11E177C")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x11E1CD4", Offset = "0x11E1CD4", VA = "0x11E1CD4")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x11E1AD8", Offset = "0x11E1AD8", VA = "0x11E1AD8")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x11E1950", Offset = "0x11E1950", VA = "0x11E1950")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x11E181C", Offset = "0x11E181C", VA = "0x11E181C")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x11E1BDC", Offset = "0x11E1BDC", VA = "0x11E1BDC")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x11E1DD0", Offset = "0x11E1DD0", VA = "0x11E1DD0")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x11E2870", Offset = "0x11E2870", VA = "0x11E2870")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x11E2354", Offset = "0x11E2354", VA = "0x11E2354")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x11E2B64", Offset = "0x11E2B64", VA = "0x11E2B64")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x11E2694", Offset = "0x11E2694", VA = "0x11E2694")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x11E2B6C", Offset = "0x11E2B6C", VA = "0x11E2B6C")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x11E2B74", Offset = "0x11E2B74", VA = "0x11E2B74")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x11E2D34", Offset = "0x11E2D34", VA = "0x11E2D34")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x11E2F4C", Offset = "0x11E2F4C", VA = "0x11E2F4C")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x11E0AA4", Offset = "0x11E0AA4", VA = "0x11E0AA4")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x11E3F5C", Offset = "0x11E3F5C", VA = "0x11E3F5C")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x11E3F64", Offset = "0x11E3F64", VA = "0x11E3F64")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x11E40A4", Offset = "0x11E40A4", VA = "0x11E40A4")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class Hierarchy
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x19C2094", Offset = "0x19C2094", VA = "0x19C2094")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x19C2294", Offset = "0x19C2294", VA = "0x19C2294")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x19C212C", Offset = "0x19C212C", VA = "0x19C212C")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x19C23B8", Offset = "0x19C23B8", VA = "0x19C23B8")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x19C24DC", Offset = "0x19C24DC", VA = "0x19C24DC")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x19C2784", Offset = "0x19C2784", VA = "0x19C2784")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x19C28A0", Offset = "0x19C28A0", VA = "0x19C28A0")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x19C2A28", Offset = "0x19C2A28", VA = "0x19C2A28")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x19C2DBC", Offset = "0x19C2DBC", VA = "0x19C2DBC")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x19C2BA8", Offset = "0x19C2BA8", VA = "0x19C2BA8")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x19C2F5C", Offset = "0x19C2F5C", VA = "0x19C2F5C")]
		public Hierarchy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000017")]
	public enum InterpolationMode
	{
		[Token(Token = "0x4000089")]
		None,
		[Token(Token = "0x400008A")]
		InOutCubic,
		[Token(Token = "0x400008B")]
		InOutQuintic,
		[Token(Token = "0x400008C")]
		InOutSine,
		[Token(Token = "0x400008D")]
		InQuintic,
		[Token(Token = "0x400008E")]
		InQuartic,
		[Token(Token = "0x400008F")]
		InCubic,
		[Token(Token = "0x4000090")]
		InQuadratic,
		[Token(Token = "0x4000091")]
		InElastic,
		[Token(Token = "0x4000092")]
		InElasticSmall,
		[Token(Token = "0x4000093")]
		InElasticBig,
		[Token(Token = "0x4000094")]
		InSine,
		[Token(Token = "0x4000095")]
		InBack,
		[Token(Token = "0x4000096")]
		OutQuintic,
		[Token(Token = "0x4000097")]
		OutQuartic,
		[Token(Token = "0x4000098")]
		OutCubic,
		[Token(Token = "0x4000099")]
		OutInCubic,
		[Token(Token = "0x400009A")]
		OutInQuartic,
		[Token(Token = "0x400009B")]
		OutElastic,
		[Token(Token = "0x400009C")]
		OutElasticSmall,
		[Token(Token = "0x400009D")]
		OutElasticBig,
		[Token(Token = "0x400009E")]
		OutSine,
		[Token(Token = "0x400009F")]
		OutBack,
		[Token(Token = "0x40000A0")]
		OutBackCubic,
		[Token(Token = "0x40000A1")]
		OutBackQuartic,
		[Token(Token = "0x40000A2")]
		BackInCubic,
		[Token(Token = "0x40000A3")]
		BackInQuartic
	}
	[Token(Token = "0x2000018")]
	public class Interp
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x19C2F64", Offset = "0x19C2F64", VA = "0x19C2F64")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x19C39CC", Offset = "0x19C39CC", VA = "0x19C39CC")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x19C3AD4", Offset = "0x19C3AD4", VA = "0x19C3AD4")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x19C32D0", Offset = "0x19C32D0", VA = "0x19C32D0")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x19C32DC", Offset = "0x19C32DC", VA = "0x19C32DC")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x19C3300", Offset = "0x19C3300", VA = "0x19C3300")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x19C333C", Offset = "0x19C333C", VA = "0x19C333C")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x19C3354", Offset = "0x19C3354", VA = "0x19C3354")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x19C3368", Offset = "0x19C3368", VA = "0x19C3368")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x19C337C", Offset = "0x19C337C", VA = "0x19C337C")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x19C338C", Offset = "0x19C338C", VA = "0x19C338C")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x19C33D4", Offset = "0x19C33D4", VA = "0x19C33D4")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x19C340C", Offset = "0x19C340C", VA = "0x19C340C")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x19C3434", Offset = "0x19C3434", VA = "0x19C3434")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x19C3BD0", Offset = "0x19C3BD0", VA = "0x19C3BD0")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x19C3468", Offset = "0x19C3468", VA = "0x19C3468")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x19C3490", Offset = "0x19C3490", VA = "0x19C3490")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x19C34C0", Offset = "0x19C34C0", VA = "0x19C34C0")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x19C34F4", Offset = "0x19C34F4", VA = "0x19C34F4")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x19C3538", Offset = "0x19C3538", VA = "0x19C3538")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x19C359C", Offset = "0x19C359C", VA = "0x19C359C")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x19C3600", Offset = "0x19C3600", VA = "0x19C3600")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x19C3654", Offset = "0x19C3654", VA = "0x19C3654")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x19C36A8", Offset = "0x19C36A8", VA = "0x19C36A8")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x19C3740", Offset = "0x19C3740", VA = "0x19C3740")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x19C37D4", Offset = "0x19C37D4", VA = "0x19C37D4")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x19C3C04", Offset = "0x19C3C04", VA = "0x19C3C04")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x19C3878", Offset = "0x19C3878", VA = "0x19C3878")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x19C395C", Offset = "0x19C395C", VA = "0x19C395C")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x19C398C", Offset = "0x19C398C", VA = "0x19C398C")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x19C3CEC", Offset = "0x19C3CEC", VA = "0x19C3CEC")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x19C3CF4", Offset = "0x19C3CF4", VA = "0x19C3CF4")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x19C3D64", Offset = "0x19C3D64", VA = "0x19C3D64")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200001A")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x19C3DD4", Offset = "0x19C3DD4", VA = "0x19C3DD4")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x19C3E2C", Offset = "0x19C3E2C", VA = "0x19C3E2C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x19C3EF8", Offset = "0x19C3EF8", VA = "0x19C3EF8")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x19C3E44", Offset = "0x19C3E44", VA = "0x19C3E44")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x19C3F10", Offset = "0x19C3F10", VA = "0x19C3F10")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x19C3FB4", Offset = "0x19C3FB4", VA = "0x19C3FB4")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x19C3FE0", Offset = "0x19C3FE0", VA = "0x19C3FE0")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x19C4030", Offset = "0x19C4030", VA = "0x19C4030")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x19C409C", Offset = "0x19C409C", VA = "0x19C409C")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x19C4190", Offset = "0x19C4190", VA = "0x19C4190")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x19C4268", Offset = "0x19C4268", VA = "0x19C4268")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x19C42C8", Offset = "0x19C42C8", VA = "0x19C42C8")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200001B")]
	public static class QuaTools
	{
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x19C42F8", Offset = "0x19C42F8", VA = "0x19C42F8")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x19C4444", Offset = "0x19C4444", VA = "0x19C4444")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x19C4590", Offset = "0x19C4590", VA = "0x19C4590")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x19C46A4", Offset = "0x19C46A4", VA = "0x19C46A4")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x19C47B8", Offset = "0x19C47B8", VA = "0x19C47B8")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x19C4944", Offset = "0x19C4944", VA = "0x19C4944")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x19C4A14", Offset = "0x19C4A14", VA = "0x19C4A14")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x19C4B68", Offset = "0x19C4B68", VA = "0x19C4B68")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x19C4DEC", Offset = "0x19C4DEC", VA = "0x19C4DEC")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x19C5000", Offset = "0x19C5000", VA = "0x19C5000")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x19C0F7C", Offset = "0x19C0F7C", VA = "0x19C0F7C")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x200001C")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700000B")]
		public static T instance
		{
			[Token(Token = "0x6000109")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010A")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600010B")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D2AFC", Offset = "0x8D2AFC")]
		public bool fixTransforms;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000C")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x19C52B8", Offset = "0x19C52B8", VA = "0x19C52B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000D")]
		private bool isAnimated
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x19C55B4", Offset = "0x19C55B4", VA = "0x19C55B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x19C5180", Offset = "0x19C5180", VA = "0x19C5180")]
		public void Disable()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x19C5218", Offset = "0x19C5218", VA = "0x19C5218", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x19C521C", Offset = "0x19C521C", VA = "0x19C521C", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x19C5220", Offset = "0x19C5220", VA = "0x19C5220", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x19C5224", Offset = "0x19C5224", VA = "0x19C5224")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x19C52B4", Offset = "0x19C52B4", VA = "0x19C52B4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x19C525C", Offset = "0x19C525C", VA = "0x19C525C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x19C5568", Offset = "0x19C5568", VA = "0x19C5568")]
		private void Update()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x19C53A8", Offset = "0x19C53A8", VA = "0x19C53A8")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x19C5670", Offset = "0x19C5670", VA = "0x19C5670")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x19C56CC", Offset = "0x19C56CC", VA = "0x19C56CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x19C5728", Offset = "0x19C5728", VA = "0x19C5728")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x19C5770", Offset = "0x19C5770", VA = "0x19C5770")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x19C5780", Offset = "0x19C5780", VA = "0x19C5780")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x19C5838", Offset = "0x19C5838", VA = "0x19C5838")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x19C58F0", Offset = "0x19C58F0", VA = "0x19C58F0")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x19C59A8", Offset = "0x19C59A8", VA = "0x19C59A8")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public static class V3Tools
	{
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x19C59B0", Offset = "0x19C59B0", VA = "0x19C59B0")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x19C5AA8", Offset = "0x19C5AA8", VA = "0x19C5AA8")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x19C5BA0", Offset = "0x19C5BA0", VA = "0x19C5BA0")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x19C5C98", Offset = "0x19C5C98", VA = "0x19C5C98")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x19C5D98", Offset = "0x19C5D98", VA = "0x19C5D98")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x19C5FD4", Offset = "0x19C5FD4", VA = "0x19C5FD4")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x19C6224", Offset = "0x19C6224", VA = "0x19C6224")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x19C6424", Offset = "0x19C6424", VA = "0x19C6424")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000020")]
	public static class Warning
	{
		[Token(Token = "0x20000BF")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x19C6600", Offset = "0x19C6600", VA = "0x19C6600")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x19C6A2C", Offset = "0x19C6A2C", VA = "0x19C6A2C")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000021")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x11E40D8", Offset = "0x11E40D8", VA = "0x11E40D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x11E415C", Offset = "0x11E415C", VA = "0x11E415C")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D2B34", Offset = "0x8D2B34")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x11E4164", Offset = "0x11E4164", VA = "0x11E4164")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x11E426C", Offset = "0x11E426C", VA = "0x11E426C")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D2B6C", Offset = "0x8D2B6C")]
		public AimPoser aimPoser;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D2BA4", Offset = "0x8D2BA4")]
		public AimIK aim;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D2BDC", Offset = "0x8D2BDC")]
		public LookAtIK lookAt;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D2C14", Offset = "0x8D2C14")]
		public Animator animator;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D2C4C", Offset = "0x8D2C4C")]
		public float crossfadeTime;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D2C84", Offset = "0x8D2C84")]
		public float minAimDistance;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x10FEB24", Offset = "0x10FEB24", VA = "0x10FEB24")]
		private void Start()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x10FEB68", Offset = "0x10FEB68", VA = "0x10FEB68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x10FECBC", Offset = "0x10FECBC", VA = "0x10FECBC")]
		private void Pose()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x10FEEB8", Offset = "0x10FEEB8", VA = "0x10FEEB8")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x10FF1F8", Offset = "0x10FF1F8", VA = "0x10FF1F8")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x10FF2D0", Offset = "0x10FF2D0", VA = "0x10FF2D0")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1100058", Offset = "0x1100058", VA = "0x1100058")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x11002BC", Offset = "0x11002BC", VA = "0x11002BC")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x110050C", Offset = "0x110050C", VA = "0x110050C")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8D2CBC", Offset = "0x8D2CBC")]
		public Animator animator;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8D2CF4", Offset = "0x8D2CF4")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D2D2C", Offset = "0x8D2D2C")]
		public float lookAtWeight;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D2D44", Offset = "0x8D2D44")]
		public float lookAtBodyWeight;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D2D5C", Offset = "0x8D2D5C")]
		public float lookAtHeadWeight;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D2D74", Offset = "0x8D2D74")]
		public float lookAtEyesWeight;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D2D8C", Offset = "0x8D2D8C")]
		public float lookAtClampWeight;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D2DA4", Offset = "0x8D2DA4")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D2DBC", Offset = "0x8D2DBC")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8D2DD4", Offset = "0x8D2DD4")]
		public Transform footTargetBiped;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D2E0C", Offset = "0x8D2E0C")]
		public float footPositionWeight;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D2E24", Offset = "0x8D2E24")]
		public float footRotationWeight;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8D2E3C", Offset = "0x8D2E3C")]
		public Transform handTargetBiped;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D2E74", Offset = "0x8D2E74")]
		public float handPositionWeight;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D2E8C", Offset = "0x8D2E8C")]
		public float handRotationWeight;

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x11E5DDC", Offset = "0x11E5DDC", VA = "0x11E5DDC")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x11E6288", Offset = "0x11E6288", VA = "0x11E6288")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x11EFF58", Offset = "0x11EFF58", VA = "0x11EFF58")]
		private void Update()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x11F098C", Offset = "0x11F098C", VA = "0x11F098C")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x11F0674", Offset = "0x11F0674", VA = "0x11F0674")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x11F0B34", Offset = "0x11F0B34", VA = "0x11F0B34")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x1700000E")]
		public Vector3 inputVector
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x11F0B60", Offset = "0x11F0B60", VA = "0x11F0B60")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x11F0C00", Offset = "0x11F0C00", VA = "0x11F0C00")]
		private void Update()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x11F0E98", Offset = "0x11F0E98", VA = "0x11F0E98")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2944", Offset = "0x8D2944")]
		private sealed class <Step>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x17000075")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005E1")]
				[Address(RVA = "0x11F1AD4", Offset = "0x11F1AD4", VA = "0x11F1AD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000076")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005E3")]
				[Address(RVA = "0x11F1B3C", Offset = "0x11F1B3C", VA = "0x11F1B3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x11F1764", Offset = "0x11F1764", VA = "0x11F1764")]
			[DebuggerHidden]
			public <Step>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x11F17C0", Offset = "0x11F17C0", VA = "0x11F17C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x11F17C4", Offset = "0x11F17C4", VA = "0x11F17C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x11F1ADC", Offset = "0x11F1ADC", VA = "0x11F1ADC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ParticleSystem sand;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IK ik;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float stepProgress;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lastStepTime;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit hit;

		[Token(Token = "0x1700000F")]
		public bool isStepping
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x11F0EAC", Offset = "0x11F0EAC", VA = "0x11F0EAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		public Vector3 position
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x11F0B00", Offset = "0x11F0B00", VA = "0x11F0B00")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x11F0EC0", Offset = "0x11F0EC0", VA = "0x11F0EC0")]
			set
			{
			}
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x11F0F10", Offset = "0x11F0F10", VA = "0x11F0F10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x11F10CC", Offset = "0x11F10CC", VA = "0x11F10CC")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x11F149C", Offset = "0x11F149C", VA = "0x11F149C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x11F16B8", Offset = "0x11F16B8", VA = "0x11F16B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D9D44", Offset = "0x8D9D44")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x11F1790", Offset = "0x11F1790", VA = "0x11F1790")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x11F1B44", Offset = "0x11F1B44", VA = "0x11F1B44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x11F1BF0", Offset = "0x11F1BF0", VA = "0x11F1BF0")]
		private void Update()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x11F1E84", Offset = "0x11F1E84", VA = "0x11F1E84")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C1")]
		public struct Warp
		{
			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6D34", Offset = "0x8D6D34")]
			public int animationLayer;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6D6C", Offset = "0x8D6D6C")]
			public string animationState;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6DA4", Offset = "0x8D6DA4")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6DDC", Offset = "0x8D6DDC")]
			public Transform warpFrom;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6E14", Offset = "0x8D6E14")]
			public Transform warpTo;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6E4C", Offset = "0x8D6E4C")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000C2")]
		public enum EffectorMode
		{
			[Token(Token = "0x400053A")]
			PositionOffset,
			[Token(Token = "0x400053B")]
			Position
		}

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D2EA4", Offset = "0x8D2EA4")]
		public Animator animator;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D2EDC", Offset = "0x8D2EDC")]
		public EffectorMode effectorMode;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8D2F14", Offset = "0x8D2F14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D2F14", Offset = "0x8D2F14")]
		public Warp[] warps;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x11E42E4", Offset = "0x11E42E4", VA = "0x11E42E4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x11E4310", Offset = "0x11E4310", VA = "0x11E4310")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x11E4518", Offset = "0x11E4518", VA = "0x11E4518", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x11E48CC", Offset = "0x11E48CC", VA = "0x11E48CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x11E496C", Offset = "0x11E496C", VA = "0x11E496C")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8D1ABC", Offset = "0x8D1ABC")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x11E4974", Offset = "0x11E4974", VA = "0x11E4974", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x11E49CC", Offset = "0x11E49CC", VA = "0x11E49CC")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x11E4C04", Offset = "0x11E4C04", VA = "0x11E4C04", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x11E4E68", Offset = "0x11E4E68", VA = "0x11E4E68")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8D1B20", Offset = "0x8D1B20")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8D1B20", Offset = "0x8D1B20")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D2F64", Offset = "0x8D2F64")]
		public float headLookWeight;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x11E4E7C", Offset = "0x11E4E7C", VA = "0x11E4E7C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x11E4FE8", Offset = "0x11E4FE8", VA = "0x11E4FE8", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x11E505C", Offset = "0x11E505C", VA = "0x11E505C")]
		private void Read()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x11E51B4", Offset = "0x11E51B4", VA = "0x11E51B4")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x11E51FC", Offset = "0x11E51FC", VA = "0x11E51FC")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x11E57F4", Offset = "0x11E57F4", VA = "0x11E57F4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x11E55B8", Offset = "0x11E55B8", VA = "0x11E55B8")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x11E5B4C", Offset = "0x11E5B4C", VA = "0x11E5B4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x11E5C44", Offset = "0x11E5C44", VA = "0x11E5C44")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8D1BAC", Offset = "0x8D1BAC")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x11E7288", Offset = "0x11E7288", VA = "0x11E7288", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x11E72E8", Offset = "0x11E72E8", VA = "0x11E72E8", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x11E75AC", Offset = "0x11E75AC", VA = "0x11E75AC")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x11E7764", Offset = "0x11E7764", VA = "0x11E7764")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8D1C10", Offset = "0x8D1C10")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CameraController cam;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x17000011")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x11E8598", Offset = "0x11E8598", VA = "0x11E8598")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000012")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x11E8638", Offset = "0x11E8638", VA = "0x11E8638")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x11E82E4", Offset = "0x11E82E4", VA = "0x11E82E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x11E8354", Offset = "0x11E8354", VA = "0x11E8354")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x11E86D8", Offset = "0x11E86D8", VA = "0x11E86D8")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D2F8C", Offset = "0x8D2F8C")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x11EAD08", Offset = "0x11EAD08", VA = "0x11EAD08", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x11EB2EC", Offset = "0x11EB2EC", VA = "0x11EB2EC")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x11EB2F4", Offset = "0x11EB2F4", VA = "0x11EB2F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x11EB394", Offset = "0x11EB394", VA = "0x11EB394")]
		private void Update()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x11EB810", Offset = "0x11EB810", VA = "0x11EB810")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x11EB8BC", Offset = "0x11EB8BC", VA = "0x11EB8BC")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C3")]
		public class Limb
		{
			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x11EBA90", Offset = "0x11EBA90", VA = "0x11EBA90")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x11EBBC4", Offset = "0x11EBBC4", VA = "0x11EBBC4")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x11EB944", Offset = "0x11EB944", VA = "0x11EB944")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x11EBB14", Offset = "0x11EBB14", VA = "0x11EBB14")]
		private void Start()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x11EBBB0", Offset = "0x11EBBB0", VA = "0x11EBBB0")]
		private void Update()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x11EBBB4", Offset = "0x11EBBB4", VA = "0x11EBBB4")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x11EBBD4", Offset = "0x11EBBD4", VA = "0x11EBBD4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x11EBC40", Offset = "0x11EBC40", VA = "0x11EBC40")]
		private void Update()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x11EBD18", Offset = "0x11EBD18", VA = "0x11EBD18")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D2FA4", Offset = "0x8D2FA4")]
		public Transform target;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D2FDC", Offset = "0x8D2FDC")]
		public Transform pin;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3014", Offset = "0x8D3014")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D304C", Offset = "0x8D304C")]
		public AimIK aim;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3084", Offset = "0x8D3084")]
		public float weight;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D30BC", Offset = "0x8D30BC")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D30F4", Offset = "0x8D30F4")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x11EBD20", Offset = "0x11EBD20", VA = "0x11EBD20")]
		private void Start()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x11EBD78", Offset = "0x11EBD78", VA = "0x11EBD78")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x11EBF14", Offset = "0x11EBF14", VA = "0x11EBF14")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x11EBF1C", Offset = "0x11EBF1C", VA = "0x11EBF1C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x11EBFDC", Offset = "0x11EBFDC", VA = "0x11EBFDC")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x11EC068", Offset = "0x11EC068", VA = "0x11EC068")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x11EC4FC", Offset = "0x11EC4FC", VA = "0x11EC4FC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x11EC5F4", Offset = "0x11EC5F4", VA = "0x11EC5F4")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D312C", Offset = "0x8D312C")]
		public float aimWeight;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D3144", Offset = "0x8D3144")]
		public float sightWeight;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D315C", Offset = "0x8D315C")]
		public float maxAngle;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform gunTarget;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AimIK gunAim;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Recoil recoil;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D31E8", Offset = "0x8D31E8")]
		private float cameraRecoilWeight;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool updateFrame;

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x11EC5FC", Offset = "0x11EC5FC", VA = "0x11EC5FC")]
		private void Start()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x11EC75C", Offset = "0x11EC75C", VA = "0x11EC75C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x11EC768", Offset = "0x11EC768", VA = "0x11EC768")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x11ECAA8", Offset = "0x11ECAA8", VA = "0x11ECAA8")]
		private void Aiming()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x11ECC7C", Offset = "0x11ECC7C", VA = "0x11ECC7C")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x11EC82C", Offset = "0x11EC82C", VA = "0x11EC82C")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x11ED688", Offset = "0x11ED688", VA = "0x11ED688")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8D1C74", Offset = "0x8D1C74")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8D1C74", Offset = "0x8D1C74")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D3228", Offset = "0x8D3228")]
		public float walkSpeed;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x11ED6A8", Offset = "0x11ED6A8", VA = "0x11ED6A8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x11ED718", Offset = "0x11ED718", VA = "0x11ED718")]
		private void Update()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x11ED83C", Offset = "0x11ED83C", VA = "0x11ED83C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x11ED8EC", Offset = "0x11ED8EC", VA = "0x11ED8EC")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReaction hitReaction;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x11EDC80", Offset = "0x11EDC80", VA = "0x11EDC80")]
		private void Update()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x11EDE40", Offset = "0x11EDE40", VA = "0x11EDE40")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x11EE004", Offset = "0x11EE004", VA = "0x11EE004")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x11EE3A8", Offset = "0x11EE3A8", VA = "0x11EE3A8")]
		private void Start()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x11EE554", Offset = "0x11EE554", VA = "0x11EE554")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x11EE910", Offset = "0x11EE910", VA = "0x11EE910")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x11EE920", Offset = "0x11EE920", VA = "0x11EE920")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x11EEA54", Offset = "0x11EEA54", VA = "0x11EEA54")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x11EEBA4", Offset = "0x11EEBA4", VA = "0x11EEBA4")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x11EEBAC", Offset = "0x11EEBAC", VA = "0x11EEBAC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x11EF27C", Offset = "0x11EF27C", VA = "0x11EF27C")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8D1D00", Offset = "0x8D1D00")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3260", Offset = "0x8D3260")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D32AC", Offset = "0x8D32AC")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x11EF284", Offset = "0x11EF284", VA = "0x11EF284")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x11EF2DC", Offset = "0x11EF2DC", VA = "0x11EF2DC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x11EF5E8", Offset = "0x11EF5E8", VA = "0x11EF5E8")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C4")]
		public class Partner
		{
			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x17000077")]
			private Transform neck
			{
				[Token(Token = "0x60005E8")]
				[Address(RVA = "0x11EFEEC", Offset = "0x11EFEEC", VA = "0x11EFEEC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x11EF624", Offset = "0x11EF624", VA = "0x11EF624")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x11EF6A4", Offset = "0x11EF6A4", VA = "0x11EF6A4")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x11EFD10", Offset = "0x11EFD10", VA = "0x11EFD10")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x11EFF44", Offset = "0x11EFF44", VA = "0x11EFF44")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x11EF5F0", Offset = "0x11EF5F0", VA = "0x11EF5F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x11EF644", Offset = "0x11EF644", VA = "0x11EF644")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x11EFD00", Offset = "0x11EFD00", VA = "0x11EFD00")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C5")]
		public enum Mode
		{
			[Token(Token = "0x400054B")]
			Position,
			[Token(Token = "0x400054C")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x20000C6")]
		public class Absorber
		{
			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6E84", Offset = "0x8D6E84")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6EBC", Offset = "0x8D6EBC")]
			public float weight;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x11F1FEC", Offset = "0x11F1FEC", VA = "0x11F1FEC")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x11F21CC", Offset = "0x11F21CC", VA = "0x11F21CC")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x11F2208", Offset = "0x11F2208", VA = "0x11F2208")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x11F23B8", Offset = "0x11F23B8", VA = "0x11F23B8")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x11F25DC", Offset = "0x11F25DC", VA = "0x11F25DC")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D32F8", Offset = "0x8D32F8")]
		public Mode mode;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3330", Offset = "0x8D3330")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3368", Offset = "0x8D3368")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D33A0", Offset = "0x8D33A0")]
		public float falloffSpeed;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x11F1E8C", Offset = "0x11F1E8C", VA = "0x11F1E8C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x11F1F60", Offset = "0x11F1F60", VA = "0x11F1F60")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x11F20C0", Offset = "0x11F20C0", VA = "0x11F20C0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x11F2330", Offset = "0x11F2330", VA = "0x11F2330")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x11F24C8", Offset = "0x11F24C8", VA = "0x11F24C8", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x11F25CC", Offset = "0x11F25CC", VA = "0x11F25CC")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x11F265C", Offset = "0x11F265C", VA = "0x11F265C")]
		private void Start()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x11F26D4", Offset = "0x11F26D4", VA = "0x11F26D4")]
		private void Update()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x11F2788", Offset = "0x11F2788", VA = "0x11F2788")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x11F28E8", Offset = "0x11F28E8", VA = "0x11F28E8")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C7")]
		public class EffectorLink
		{
			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x11F2C30", Offset = "0x11F2C30", VA = "0x11F2C30")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x11F28FC", Offset = "0x11F28FC", VA = "0x11F28FC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x11F29FC", Offset = "0x11F29FC", VA = "0x11F29FC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x11F2C28", Offset = "0x11F2C28", VA = "0x11F2C28")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8D1D64", Offset = "0x8D1D64")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D33D8", Offset = "0x8D33D8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D33D8", Offset = "0x8D33D8")]
		public float weight;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D342C", Offset = "0x8D342C")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3464", Offset = "0x8D3464")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D34B0", Offset = "0x8D34B0")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform leftHandTarget;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform rightHandTarget;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform leftFootTarget;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform headTarget;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x11F2C40", Offset = "0x11F2C40", VA = "0x11F2C40")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x11F2F7C", Offset = "0x11F2F7C", VA = "0x11F2F7C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x11F36CC", Offset = "0x11F36CC", VA = "0x11F36CC")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x17000013")]
		private bool holding
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x11F3A10", Offset = "0x11F3A10", VA = "0x11F3A10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x11F3750", Offset = "0x11F3750", VA = "0x11F3750")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001A8")]
		protected abstract void RotatePivot();

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x11F3A30", Offset = "0x11F3A30", VA = "0x11F3A30")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x11F3B98", Offset = "0x11F3B98", VA = "0x11F3B98")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x11F3D14", Offset = "0x11F3D14", VA = "0x11F3D14")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x11F3DF4", Offset = "0x11F3DF4", VA = "0x11F3DF4")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x11F3F20", Offset = "0x11F3F20", VA = "0x11F3F20")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x11F4130", Offset = "0x11F4130", VA = "0x11F4130")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x11F42D0", Offset = "0x11F42D0", VA = "0x11F42D0")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x11F42E4", Offset = "0x11F42E4", VA = "0x11F42E4", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x11F44D8", Offset = "0x11F44D8", VA = "0x11F44D8")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x11F44EC", Offset = "0x11F44EC", VA = "0x11F44EC", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x11F4698", Offset = "0x11F4698", VA = "0x11F4698")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x10FE32C", Offset = "0x10FE32C", VA = "0x10FE32C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x10FE404", Offset = "0x10FE404", VA = "0x10FE404")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x10FE5AC", Offset = "0x10FE5AC", VA = "0x10FE5AC")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8D1DC8", Offset = "0x8D1DC8")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x10FE5B4", Offset = "0x10FE5B4", VA = "0x10FE5B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x10FE60C", Offset = "0x10FE60C", VA = "0x10FE60C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x10FE668", Offset = "0x10FE668", VA = "0x10FE668")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x10FE740", Offset = "0x10FE740", VA = "0x10FE740")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x20000C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2954", Offset = "0x8D2954")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x17000078")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005F4")]
				[Address(RVA = "0x10FEAB4", Offset = "0x10FEAB4", VA = "0x10FEAB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000079")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005F6")]
				[Address(RVA = "0x10FEB1C", Offset = "0x10FEB1C", VA = "0x10FEB1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x10FE8D0", Offset = "0x10FE8D0", VA = "0x10FE8D0")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x10FE90C", Offset = "0x10FE90C", VA = "0x10FE90C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x10FE910", Offset = "0x10FE910", VA = "0x10FE910", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x10FEABC", Offset = "0x10FEABC", VA = "0x10FEABC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x10FE750", Offset = "0x10FE750", VA = "0x10FE750")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x10FE808", Offset = "0x10FE808", VA = "0x10FE808")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x10FE850", Offset = "0x10FE850", VA = "0x10FE850")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D9DA8", Offset = "0x8D9DA8")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x10FE8FC", Offset = "0x10FE8FC", VA = "0x10FE8FC")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8D1E2C", Offset = "0x8D1E2C")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x20000C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2964", Offset = "0x8D2964")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x1700007A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005FA")]
				[Address(RVA = "0x10FFFE8", Offset = "0x10FFFE8", VA = "0x10FFFE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005FC")]
				[Address(RVA = "0x1100050", Offset = "0x1100050", VA = "0x1100050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x10FFE90", Offset = "0x10FFE90", VA = "0x10FFE90")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x10FFEC4", Offset = "0x10FFEC4", VA = "0x10FFEC4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x10FFEC8", Offset = "0x10FFEC8", VA = "0x10FFEC8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x10FFFF0", Offset = "0x10FFFF0", VA = "0x10FFFF0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x10FFD70", Offset = "0x10FFD70", VA = "0x10FFD70")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x10FFE20", Offset = "0x10FFE20", VA = "0x10FFE20")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D9E0C", Offset = "0x8D9E0C")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x10FFEBC", Offset = "0x10FFEBC", VA = "0x10FFEBC")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000CA")]
		public class EffectorLink
		{
			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x11005F8", Offset = "0x11005F8", VA = "0x11005F8")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x1101280", Offset = "0x1101280", VA = "0x1101280")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x1100938", Offset = "0x1100938", VA = "0x1100938")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x1101368", Offset = "0x1101368", VA = "0x1101368")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x1101504", Offset = "0x1101504", VA = "0x1101504")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x11015A0", Offset = "0x11015A0", VA = "0x11015A0")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x1101638", Offset = "0x1101638", VA = "0x1101638")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x1101118", Offset = "0x1101118", VA = "0x1101118")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x11016D0", Offset = "0x11016D0", VA = "0x11016D0")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1100580", Offset = "0x1100580", VA = "0x1100580")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x11008CC", Offset = "0x11008CC", VA = "0x11008CC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1101050", Offset = "0x1101050", VA = "0x1101050")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1101278", Offset = "0x1101278", VA = "0x1101278")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D359C", Offset = "0x8D359C")]
		public Transform to;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D35D4", Offset = "0x8D35D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D35D4", Offset = "0x8D35D4")]
		public float transferMotion;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1101704", Offset = "0x1101704", VA = "0x1101704")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1101740", Offset = "0x1101740", VA = "0x1101740")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1101898", Offset = "0x1101898", VA = "0x1101898")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3628", Offset = "0x8D3628")]
		public Transform leftHandTarget;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1101A58", Offset = "0x1101A58", VA = "0x1101A58")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1101C10", Offset = "0x1101C10", VA = "0x1101C10")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1101EAC", Offset = "0x1101EAC", VA = "0x1101EAC")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1101F78", Offset = "0x1101F78", VA = "0x1101F78")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1102070", Offset = "0x1102070", VA = "0x1102070")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x11022A8", Offset = "0x11022A8", VA = "0x11022A8", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1102720", Offset = "0x1102720", VA = "0x1102720")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1102978", Offset = "0x1102978", VA = "0x1102978")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x11ED8FC", Offset = "0x11ED8FC", VA = "0x11ED8FC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x11EDBF8", Offset = "0x11EDBF8", VA = "0x11EDBF8")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x11EDC78", Offset = "0x11EDC78", VA = "0x11EDC78")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x20000CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2974", Offset = "0x8D2974")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x1700007C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000609")]
				[Address(RVA = "0x10FE2BC", Offset = "0x10FE2BC", VA = "0x10FE2BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600060B")]
				[Address(RVA = "0x10FE324", Offset = "0x10FE324", VA = "0x10FE324", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0x10FE158", Offset = "0x10FE158", VA = "0x10FE158")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x10FE184", Offset = "0x10FE184", VA = "0x10FE184", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000608")]
			[Address(RVA = "0x10FE188", Offset = "0x10FE188", VA = "0x10FE188", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x10FE2C4", Offset = "0x10FE2C4", VA = "0x10FE2C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x11F46AC", Offset = "0x11F46AC", VA = "0x11F46AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x11F4838", Offset = "0x11F4838", VA = "0x11F4838")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x11F47C8", Offset = "0x11F47C8", VA = "0x11F47C8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D9E70", Offset = "0x8D9E70")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x11F4A60", Offset = "0x11F4A60", VA = "0x11F4A60")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x11F4B44", Offset = "0x11F4B44", VA = "0x11F4B44")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x11F4C24", Offset = "0x11F4C24", VA = "0x11F4C24")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D3690", Offset = "0x8D3690")]
		public float weight;

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x11E5CA4", Offset = "0x11E5CA4", VA = "0x11E5CA4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x11E5D10", Offset = "0x11E5D10", VA = "0x11E5D10")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x11E5DCC", Offset = "0x11E5DCC", VA = "0x11E5DCC")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000CC")]
		public class Part
		{
			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x1101924", Offset = "0x1101924", VA = "0x1101924")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x1101A50", Offset = "0x1101A50", VA = "0x1101A50")]
			public Part()
			{
			}
		}

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x11018AC", Offset = "0x11018AC", VA = "0x11018AC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1101A48", Offset = "0x1101A48", VA = "0x1101A48")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReactionVRIK hitReaction;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x11EE014", Offset = "0x11EE014", VA = "0x11EE014")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x11EE1D4", Offset = "0x11EE1D4", VA = "0x11EE1D4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x11EE398", Offset = "0x11EE398", VA = "0x11EE398")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D36C8", Offset = "0x8D36C8")]
		public VRIK ik;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3700", Offset = "0x8D3700")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3738", Offset = "0x8D3738")]
		public Transform headTracker;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3770", Offset = "0x8D3770")]
		public Transform bodyTracker;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D37A8", Offset = "0x8D37A8")]
		public Transform leftHandTracker;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D37E0", Offset = "0x8D37E0")]
		public Transform rightHandTracker;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3818", Offset = "0x8D3818")]
		public Transform leftFootTracker;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3850", Offset = "0x8D3850")]
		public Transform rightFootTracker;

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x11029D4", Offset = "0x11029D4", VA = "0x11029D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1102A10", Offset = "0x1102A10", VA = "0x1102A10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8D9ED4", Offset = "0x8D9ED4")]
		private void Calibrate()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1102A44", Offset = "0x1102A44", VA = "0x1102A44")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1102A4C", Offset = "0x1102A4C", VA = "0x1102A4C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1102AA8", Offset = "0x1102AA8", VA = "0x1102AA8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1102CBC", Offset = "0x1102CBC", VA = "0x1102CBC")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x17000014")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x11E62CC", Offset = "0x11E62CC", VA = "0x11E62CC", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x11E62A8", Offset = "0x11E62A8", VA = "0x11E62A8", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x11E62D4", Offset = "0x11E62D4", VA = "0x11E62D4")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x11E6398", Offset = "0x11E6398", VA = "0x11E6398", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x11E65F0", Offset = "0x11E65F0", VA = "0x11E65F0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x11E6860", Offset = "0x11E6860", VA = "0x11E6860", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x11E6600", Offset = "0x11E6600", VA = "0x11E6600")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x11E6870", Offset = "0x11E6870", VA = "0x11E6870")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8D1E90", Offset = "0x8D1E90")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x11E6888", Offset = "0x11E6888", VA = "0x11E6888", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x11E68E8", Offset = "0x11E68E8", VA = "0x11E68E8", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x11E6A14", Offset = "0x11E6A14", VA = "0x11E6A14")]
		private void Update()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x11E6B90", Offset = "0x11E6B90", VA = "0x11E6B90")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8D1EF4", Offset = "0x8D1EF4")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D38E8", Offset = "0x8D38E8")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x40001EA")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40001EB")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x17000015")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x11E6C48", Offset = "0x11E6C48", VA = "0x11E6C48", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x11E6BA8", Offset = "0x11E6BA8", VA = "0x11E6BA8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x11E6C2C", Offset = "0x11E6C2C", VA = "0x11E6C2C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x11E6D38", Offset = "0x11E6D38", VA = "0x11E6D38", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x11E70B0", Offset = "0x11E70B0", VA = "0x11E70B0")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x11E7264", Offset = "0x11E7264", VA = "0x11E7264")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8D1F58", Offset = "0x8D1F58")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8D1F58", Offset = "0x8D1F58")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D392C", Offset = "0x8D392C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D392C", Offset = "0x8D392C")]
		public Transform gravityTarget;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D398C", Offset = "0x8D398C")]
		[SerializeField]
		protected float gravityMultiplier;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40001F7")]
		protected const float half = 0.5f;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60001FB")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x11E7788", Offset = "0x11E7788", VA = "0x11E7788")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x11E790C", Offset = "0x11E790C", VA = "0x11E790C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x11E7AA4", Offset = "0x11E7AA4", VA = "0x11E7AA4", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x11E7D1C", Offset = "0x11E7D1C", VA = "0x11E7D1C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x11E7DE0", Offset = "0x11E7DE0", VA = "0x11E7DE0")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x11E7FC8", Offset = "0x11E7FC8", VA = "0x11E7FC8")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x11E8178", Offset = "0x11E8178", VA = "0x11E8178")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x11E819C", Offset = "0x11E819C", VA = "0x11E819C")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x11E81C0", Offset = "0x11E81C0", VA = "0x11E81C0")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x11E82C4", Offset = "0x11E82C4", VA = "0x11E82C4")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x20000CD")]
		public enum MoveMode
		{
			[Token(Token = "0x4000576")]
			Directional,
			[Token(Token = "0x4000577")]
			Strafe
		}

		[Token(Token = "0x20000CE")]
		public struct AnimState
		{
			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;
		}

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D3A28", Offset = "0x8D3A28")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D3A60", Offset = "0x8D3A60")]
		public MoveMode moveMode;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D3A98", Offset = "0x8D3A98")]
		public bool lookInCameraDirection;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D3AD0", Offset = "0x8D3AD0")]
		public float airSpeed;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airControl;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float jumpPower;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D3B08", Offset = "0x8D3B08")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float wallRunMaxLength;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D3B54", Offset = "0x8D3B54")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D3B8C", Offset = "0x8D3B8C")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AnimState animState;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		protected Vector3 moveDirection;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Animator animator;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3 normal;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 platformVelocity;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private RaycastHit hit;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private float jumpLeg;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private float jumpEndTime;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private float forwardMlp;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private float groundDistance;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float lastAirTime;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float stickyForce;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private float wallRunWeight;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private bool fixedFrame;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private float wallRunEndTime;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Vector3 gravity;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private float velocityY;

		[Token(Token = "0x17000016")]
		public bool onGround
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x11E86E0", Offset = "0x11E86E0", VA = "0x11E86E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D9F0C", Offset = "0x8D9F0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x11E86E8", Offset = "0x11E86E8", VA = "0x11E86E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D9F1C", Offset = "0x8D9F1C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x11E86F4", Offset = "0x11E86F4", VA = "0x11E86F4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x11E8878", Offset = "0x11E8878", VA = "0x11E8878")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x11E8908", Offset = "0x11E8908", VA = "0x11E8908", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x11E8A44", Offset = "0x11E8A44", VA = "0x11E8A44")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x11E9970", Offset = "0x11E9970", VA = "0x11E9970", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x11E9CEC", Offset = "0x11E9CEC", VA = "0x11E9CEC", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x11E8F68", Offset = "0x11E8F68", VA = "0x11E8F68")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x11E9DCC", Offset = "0x11E9DCC", VA = "0x11E9DCC")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x11EA3BC", Offset = "0x11EA3BC", VA = "0x11EA3BC")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x11E9A4C", Offset = "0x11E9A4C", VA = "0x11E9A4C")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x11EA45C", Offset = "0x11EA45C", VA = "0x11EA45C", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x11EA8CC", Offset = "0x11EA8CC", VA = "0x11EA8CC")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x11EAA58", Offset = "0x11EAA58", VA = "0x11EAA58", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x11E9550", Offset = "0x11E9550", VA = "0x11E9550")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x11EABEC", Offset = "0x11EABEC", VA = "0x11EABEC")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8D1FE4", Offset = "0x8D1FE4")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000CF")]
		public enum RotationMode
		{
			[Token(Token = "0x400057F")]
			Smooth,
			[Token(Token = "0x4000580")]
			Linear
		}

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3B9C", Offset = "0x8D3B9C")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3BE8", Offset = "0x8D3BE8")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3C34", Offset = "0x8D3C34")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3C80", Offset = "0x8D3C80")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3CCC", Offset = "0x8D3CCC")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3D18", Offset = "0x8D3D18")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D3D64", Offset = "0x8D3D64")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x17000017")]
		public bool isGrounded
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x10FF2E4", Offset = "0x10FF2E4", VA = "0x10FF2E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D9F2C", Offset = "0x8D9F2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x10FF2EC", Offset = "0x10FF2EC", VA = "0x10FF2EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D9F3C", Offset = "0x8D9F3C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x10FF2F8", Offset = "0x10FF2F8", VA = "0x10FF2F8")]
		private void Start()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x10FF380", Offset = "0x10FF380", VA = "0x10FF380")]
		private void Update()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x10FFA7C", Offset = "0x10FFA7C", VA = "0x10FFA7C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x10FF3D4", Offset = "0x10FF3D4", VA = "0x10FF3D4")]
		private void Rotate()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x10FF7D4", Offset = "0x10FF7D4", VA = "0x10FF7D4")]
		private void Move()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x10FFAB8", Offset = "0x10FFAB8", VA = "0x10FFAB8")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x10FFBB0", Offset = "0x10FFBB0", VA = "0x10FFBB0")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x10FFC50", Offset = "0x10FFC50", VA = "0x10FFC50")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1102078", Offset = "0x1102078", VA = "0x1102078", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x110227C", Offset = "0x110227C", VA = "0x110227C")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x20000D0")]
		public struct State
		{
			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x110299C", Offset = "0x110299C", VA = "0x110299C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x11023BC", Offset = "0x11023BC", VA = "0x11023BC", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1102298", Offset = "0x1102298", VA = "0x1102298")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x11E5C60", Offset = "0x11E5C60", VA = "0x11E5C60")]
		private void Update()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x11E5C9C", Offset = "0x11E5C9C", VA = "0x11E5C9C")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x10FFC78", Offset = "0x10FFC78", VA = "0x10FFC78")]
		private void Update()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x10FFCAC", Offset = "0x10FFCAC", VA = "0x10FFCAC")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x10FFD5C", Offset = "0x10FFD5C", VA = "0x10FFD5C")]
		public SlowMo()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D2048", Offset = "0x8D2048")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D2048", Offset = "0x8D2048")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1104700", Offset = "0x1104700", VA = "0x1104700")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8D9F4C", Offset = "0x8D9F4C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x110474C", Offset = "0x110474C", VA = "0x110474C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8D9F84", Offset = "0x8D9F84")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1104798", Offset = "0x1104798", VA = "0x1104798")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8D9FBC", Offset = "0x8D9FBC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x11047E4", Offset = "0x11047E4", VA = "0x11047E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8D9FF4", Offset = "0x8D9FF4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1104830", Offset = "0x1104830", VA = "0x1104830")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x11048CC", Offset = "0x11048CC", VA = "0x11048CC")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x11048EC", Offset = "0x11048EC", VA = "0x11048EC")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x110491C", Offset = "0x110491C", VA = "0x110491C")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x110494C", Offset = "0x110494C", VA = "0x110494C")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x110498C", Offset = "0x110498C", VA = "0x110498C")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x11049D0", Offset = "0x11049D0", VA = "0x11049D0")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x11049F4", Offset = "0x11049F4", VA = "0x11049F4")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1104A18", Offset = "0x1104A18", VA = "0x1104A18")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1104A40", Offset = "0x1104A40", VA = "0x1104A40")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1104A6C", Offset = "0x1104A6C", VA = "0x1104A6C")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1104A98", Offset = "0x1104A98", VA = "0x1104A98")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1104850", Offset = "0x1104850", VA = "0x1104850")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1104AC0", Offset = "0x1104AC0", VA = "0x1104AC0")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1104ACC", Offset = "0x1104ACC", VA = "0x1104ACC")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1104AD8", Offset = "0x1104AD8", VA = "0x1104AD8")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1104DC0", Offset = "0x1104DC0", VA = "0x1104DC0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1104E68", Offset = "0x1104E68", VA = "0x1104E68", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x11051B0", Offset = "0x11051B0", VA = "0x11051B0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1105698", Offset = "0x1105698", VA = "0x1105698")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x11056CC", Offset = "0x11056CC", VA = "0x11056CC")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005E")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000018")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x1104C78", Offset = "0x1104C78", VA = "0x1104C78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x1105898", Offset = "0x1105898", VA = "0x1105898")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1105038", Offset = "0x1105038", VA = "0x1105038")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1105750", Offset = "0x1105750", VA = "0x1105750")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005F")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700001A")]
		public bool isValid
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x1105E98", Offset = "0x1105E98", VA = "0x1105E98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000249")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1105F08", Offset = "0x1105F08", VA = "0x1105F08")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1105F10", Offset = "0x1105F10", VA = "0x1105F10", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x110601C", Offset = "0x110601C", VA = "0x110601C")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1106024", Offset = "0x1106024", VA = "0x1106024")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000061")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x1700001B")]
		private bool positionChanged
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x11061EC", Offset = "0x11061EC", VA = "0x11061EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1106050", Offset = "0x1106050", VA = "0x1106050", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x11062A8", Offset = "0x11062A8", VA = "0x11062A8")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x11062B0", Offset = "0x11062B0", VA = "0x11062B0")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000062")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x11062DC", Offset = "0x11062DC", VA = "0x11062DC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1106404", Offset = "0x1106404", VA = "0x1106404")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x110640C", Offset = "0x110640C", VA = "0x110640C")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x1700001C")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x11065D8", Offset = "0x11065D8", VA = "0x11065D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1106438", Offset = "0x1106438", VA = "0x1106438", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x11066A8", Offset = "0x11066A8", VA = "0x11066A8")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x11066B0", Offset = "0x11066B0", VA = "0x11066B0")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class Constraints
	{
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D3DB4", Offset = "0x8D3DB4")]
		public float positionWeight;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D3DCC", Offset = "0x8D3DCC")]
		public float rotationWeight;

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x11066DC", Offset = "0x11066DC", VA = "0x11066DC")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x110515C", Offset = "0x110515C", VA = "0x110515C")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1105338", Offset = "0x1105338", VA = "0x1105338")]
		public void Update()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1105A64", Offset = "0x1105A64", VA = "0x1105A64")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x20000D1")]
		public enum DOF
		{
			[Token(Token = "0x4000587")]
			One,
			[Token(Token = "0x4000588")]
			Three
		}

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3DE4", Offset = "0x8D3DE4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D3DE4", Offset = "0x8D3DE4")]
		public float weight;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3E38", Offset = "0x8D3E38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D3E38", Offset = "0x8D3E38")]
		public float rotationWeight;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3E8C", Offset = "0x8D3E8C")]
		public DOF rotationDOF;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3EC4", Offset = "0x8D3EC4")]
		public Transform bone1;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3EFC", Offset = "0x8D3EFC")]
		public Transform bone2;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3F34", Offset = "0x8D3F34")]
		public Transform bone3;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3F6C", Offset = "0x8D3F6C")]
		public Transform tip;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3FA4", Offset = "0x8D3FA4")]
		public Transform target;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D3FDC", Offset = "0x8D3FDC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x1700001D")]
		public bool initiated
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x110D8A8", Offset = "0x110D8A8", VA = "0x110D8A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DA02C", Offset = "0x8DA02C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x110D8B0", Offset = "0x110D8B0", VA = "0x110D8B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DA03C", Offset = "0x8DA03C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x110D8BC", Offset = "0x110D8BC", VA = "0x110D8BC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x110D8DC", Offset = "0x110D8DC", VA = "0x110D8DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x110D8FC", Offset = "0x110D8FC", VA = "0x110D8FC")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x110D91C", Offset = "0x110D91C", VA = "0x110D91C")]
			set
			{
			}
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x110D93C", Offset = "0x110D93C", VA = "0x110D93C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x110DA3C", Offset = "0x110DA3C", VA = "0x110DA3C")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x110DE50", Offset = "0x110DE50", VA = "0x110DE50")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x110DF20", Offset = "0x110DF20", VA = "0x110DF20")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x110E2D4", Offset = "0x110E2D4", VA = "0x110E2D4")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D3FEC", Offset = "0x8D3FEC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D3FEC", Offset = "0x8D3FEC")]
		public float weight;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D4040", Offset = "0x8D4040")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000020")]
		public bool initiated
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x110E2E4", Offset = "0x110E2E4", VA = "0x110E2E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DA04C", Offset = "0x8DA04C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x110E2EC", Offset = "0x110E2EC", VA = "0x110E2EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DA05C", Offset = "0x8DA05C")]
			private set
			{
			}
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x110E2F8", Offset = "0x110E2F8", VA = "0x110E2F8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x110E380", Offset = "0x110E380", VA = "0x110E380")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA06C", Offset = "0x8DA06C")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x110E6A4", Offset = "0x110E6A4", VA = "0x110E6A4")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x110E814", Offset = "0x110E814", VA = "0x110E814")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x110E59C", Offset = "0x110E59C", VA = "0x110E59C")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x110E97C", Offset = "0x110E97C", VA = "0x110E97C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x110EA3C", Offset = "0x110EA3C", VA = "0x110EA3C")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x110EAC0", Offset = "0x110EAC0", VA = "0x110EAC0")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x110EB28", Offset = "0x110EB28", VA = "0x110EB28", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x110EB2C", Offset = "0x110EB2C", VA = "0x110EB2C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x110EB30", Offset = "0x110EB30", VA = "0x110EB30")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x20000D2")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4050", Offset = "0x8D4050")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D4050", Offset = "0x8D4050")]
		public float weight;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D40A4", Offset = "0x8D40A4")]
		public Grounding solver;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected bool initiated;

		[Token(Token = "0x6000275")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x110FB64", Offset = "0x110FB64", VA = "0x110FB64")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x110FE38", Offset = "0x110FE38", VA = "0x110FE38")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x110FCA8", Offset = "0x110FCA8", VA = "0x110FCA8")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x110FE6C", Offset = "0x110FE6C", VA = "0x110FE6C")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027A")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600027B")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1110074", Offset = "0x1110074", VA = "0x1110074")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D20A8", Offset = "0x8D20A8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D20A8", Offset = "0x8D20A8")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D40DC", Offset = "0x8D40DC")]
		public BipedIK ik;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4114", Offset = "0x8D4114")]
		public float spineBend;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D414C", Offset = "0x8D414C")]
		public float spineSpeed;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1110338", Offset = "0x1110338", VA = "0x1110338", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA0A4", Offset = "0x8DA0A4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1110384", Offset = "0x1110384", VA = "0x1110384", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA0DC", Offset = "0x8DA0DC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x11103D0", Offset = "0x11103D0", VA = "0x11103D0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1110454", Offset = "0x1110454", VA = "0x1110454")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1110504", Offset = "0x1110504", VA = "0x1110504")]
		private void Update()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x11105B8", Offset = "0x11105B8", VA = "0x11105B8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1110870", Offset = "0x1110870", VA = "0x1110870")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x11108C4", Offset = "0x11108C4", VA = "0x11108C4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1110E18", Offset = "0x1110E18", VA = "0x1110E18")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1110EEC", Offset = "0x1110EEC", VA = "0x1110EEC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x111107C", Offset = "0x111107C", VA = "0x111107C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x11111EC", Offset = "0x11111EC", VA = "0x11111EC")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D2108", Offset = "0x8D2108")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D2108", Offset = "0x8D2108")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000D3")]
		public class SpineEffector
		{
			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6F04", Offset = "0x8D6F04")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6F3C", Offset = "0x8D6F3C")]
			public float horizontalWeight;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6F74", Offset = "0x8D6F74")]
			public float verticalWeight;

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x1112060", Offset = "0x1112060", VA = "0x1112060")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x1112070", Offset = "0x1112070", VA = "0x1112070")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4184", Offset = "0x8D4184")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D41BC", Offset = "0x8D41BC")]
		public float spineBend;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D41F4", Offset = "0x8D41F4")]
		public float spineSpeed;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x111126C", Offset = "0x111126C", VA = "0x111126C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA114", Offset = "0x8DA114")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x11112B8", Offset = "0x11112B8", VA = "0x11112B8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA14C", Offset = "0x8DA14C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1111304", Offset = "0x1111304", VA = "0x1111304", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA184", Offset = "0x8DA184")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1111350", Offset = "0x1111350", VA = "0x1111350", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x11113D4", Offset = "0x11113D4", VA = "0x11113D4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x111146C", Offset = "0x111146C", VA = "0x111146C")]
		private void Update()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x111172C", Offset = "0x111172C", VA = "0x111172C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1111738", Offset = "0x1111738", VA = "0x1111738")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1111528", Offset = "0x1111528", VA = "0x1111528")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1111744", Offset = "0x1111744", VA = "0x1111744")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1111BE8", Offset = "0x1111BE8", VA = "0x1111BE8")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1111DA8", Offset = "0x1111DA8", VA = "0x1111DA8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1111EE0", Offset = "0x1111EE0", VA = "0x1111EE0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1111FE0", Offset = "0x1111FE0", VA = "0x1111FE0")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D2168", Offset = "0x8D2168")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D2168", Offset = "0x8D2168")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D422C", Offset = "0x8D422C")]
		public Transform pelvis;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4264", Offset = "0x8D4264")]
		public Transform characterRoot;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D429C", Offset = "0x8D429C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D429C", Offset = "0x8D429C")]
		public float rootRotationWeight;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D42F0", Offset = "0x8D42F0")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4328", Offset = "0x8D4328")]
		public float maxRootRotationAngle;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x11120B8", Offset = "0x11120B8", VA = "0x11120B8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA1BC", Offset = "0x8DA1BC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1112104", Offset = "0x1112104", VA = "0x1112104", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA1F4", Offset = "0x8DA1F4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1112150", Offset = "0x1112150", VA = "0x1112150", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x111216C", Offset = "0x111216C", VA = "0x111216C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x111235C", Offset = "0x111235C", VA = "0x111235C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x111245C", Offset = "0x111245C", VA = "0x111245C")]
		private void Update()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x111288C", Offset = "0x111288C", VA = "0x111288C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1112C58", Offset = "0x1112C58", VA = "0x1112C58")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1112ECC", Offset = "0x1112ECC", VA = "0x1112ECC")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x11131EC", Offset = "0x11131EC", VA = "0x11131EC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1113378", Offset = "0x1113378", VA = "0x1113378")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1113540", Offset = "0x1113540", VA = "0x1113540")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D21C8", Offset = "0x8D21C8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D21C8", Offset = "0x8D21C8")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x20000D4")]
		public struct Foot
		{
			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x99C880", Offset = "0x99C880", VA = "0x99C880")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4360", Offset = "0x8D4360")]
		public Grounding forelegSolver;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4398", Offset = "0x8D4398")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D4398", Offset = "0x8D4398")]
		public float rootRotationWeight;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D43EC", Offset = "0x8D43EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D43EC", Offset = "0x8D43EC")]
		public float minRootRotation;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4444", Offset = "0x8D4444")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D4444", Offset = "0x8D4444")]
		public float maxRootRotation;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D449C", Offset = "0x8D449C")]
		public float rootRotationSpeed;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D44D4", Offset = "0x8D44D4")]
		public float maxLegOffset;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D450C", Offset = "0x8D450C")]
		public float maxForeLegOffset;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4544", Offset = "0x8D4544")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D4544", Offset = "0x8D4544")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4598", Offset = "0x8D4598")]
		public Transform characterRoot;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D45D0", Offset = "0x8D45D0")]
		public Transform pelvis;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4608", Offset = "0x8D4608")]
		public Transform lastSpineBone;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4640", Offset = "0x8D4640")]
		public Transform head;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x11135C0", Offset = "0x11135C0", VA = "0x11135C0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA22C", Offset = "0x8DA22C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x111360C", Offset = "0x111360C", VA = "0x111360C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA264", Offset = "0x8DA264")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1113658", Offset = "0x1113658", VA = "0x1113658", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1113694", Offset = "0x1113694", VA = "0x1113694")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x11137C4", Offset = "0x11137C4", VA = "0x11137C4")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1113984", Offset = "0x1113984", VA = "0x1113984")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x11139EC", Offset = "0x11139EC", VA = "0x11139EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x1113AA4", Offset = "0x1113AA4", VA = "0x1113AA4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1113D90", Offset = "0x1113D90", VA = "0x1113D90")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x11140B4", Offset = "0x11140B4", VA = "0x11140B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1114200", Offset = "0x1114200", VA = "0x1114200")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1114590", Offset = "0x1114590", VA = "0x1114590")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1114D88", Offset = "0x1114D88", VA = "0x1114D88")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1115048", Offset = "0x1115048", VA = "0x1115048")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x11151A8", Offset = "0x11151A8", VA = "0x11151A8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1115484", Offset = "0x1115484", VA = "0x1115484")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x11154BC", Offset = "0x11154BC", VA = "0x11154BC")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x111567C", Offset = "0x111567C", VA = "0x111567C")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200006C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D2228", Offset = "0x8D2228")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4688", Offset = "0x8D4688")]
		public VRIK ik;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x15B0E20", Offset = "0x15B0E20", VA = "0x15B0E20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA29C", Offset = "0x8DA29C")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x15B0E24", Offset = "0x15B0E24", VA = "0x15B0E24", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA2D4", Offset = "0x8DA2D4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x15B0E28", Offset = "0x15B0E28", VA = "0x15B0E28", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA30C", Offset = "0x8DA30C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x15B0E2C", Offset = "0x15B0E2C", VA = "0x15B0E2C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x15B0EC8", Offset = "0x15B0EC8", VA = "0x15B0EC8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x15B0F60", Offset = "0x15B0F60", VA = "0x15B0F60")]
		private void Update()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x15B1014", Offset = "0x15B1014", VA = "0x15B1014")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x15B1474", Offset = "0x15B1474", VA = "0x15B1474")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x15B1978", Offset = "0x15B1978", VA = "0x15B1978")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x15B1A80", Offset = "0x15B1A80", VA = "0x15B1A80")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x15B1C80", Offset = "0x15B1C80", VA = "0x15B1C80")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x15B1DB8", Offset = "0x15B1DB8", VA = "0x15B1DB8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x15B1F08", Offset = "0x15B1F08", VA = "0x15B1F08")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006D")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x20000D5")]
		public enum Quality
		{
			[Token(Token = "0x4000591")]
			Fastest,
			[Token(Token = "0x4000592")]
			Simple,
			[Token(Token = "0x4000593")]
			Best
		}

		[Token(Token = "0x20000D6")]
		public class Leg
		{
			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D6FAC", Offset = "0x8D6FAC")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D6FBC", Offset = "0x8D6FBC")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D6FCC", Offset = "0x8D6FCC")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D6FDC", Offset = "0x8D6FDC")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D6FEC", Offset = "0x8D6FEC")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D6FFC", Offset = "0x8D6FFC")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D700C", Offset = "0x8D700C")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x1700007E")]
			public bool isGrounded
			{
				[Token(Token = "0x6000615")]
				[Address(RVA = "0x15B3A08", Offset = "0x15B3A08", VA = "0x15B3A08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBBE0", Offset = "0x8DBBE0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000616")]
				[Address(RVA = "0x15B3A10", Offset = "0x15B3A10", VA = "0x15B3A10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBBF0", Offset = "0x8DBBF0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007F")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000617")]
				[Address(RVA = "0x15B3A1C", Offset = "0x15B3A1C", VA = "0x15B3A1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBC00", Offset = "0x8DBC00")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000618")]
				[Address(RVA = "0x15B3A28", Offset = "0x15B3A28", VA = "0x15B3A28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBC10", Offset = "0x8DBC10")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public bool initiated
			{
				[Token(Token = "0x6000619")]
				[Address(RVA = "0x15B3A34", Offset = "0x15B3A34", VA = "0x15B3A34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBC20", Offset = "0x8DBC20")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600061A")]
				[Address(RVA = "0x15B3A3C", Offset = "0x15B3A3C", VA = "0x15B3A3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBC30", Offset = "0x8DBC30")]
				private set
				{
				}
			}

			[Token(Token = "0x17000081")]
			public float heightFromGround
			{
				[Token(Token = "0x600061B")]
				[Address(RVA = "0x15B3A48", Offset = "0x15B3A48", VA = "0x15B3A48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBC40", Offset = "0x8DBC40")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600061C")]
				[Address(RVA = "0x15B3A50", Offset = "0x15B3A50", VA = "0x15B3A50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBC50", Offset = "0x8DBC50")]
				private set
				{
				}
			}

			[Token(Token = "0x17000082")]
			public Vector3 velocity
			{
				[Token(Token = "0x600061D")]
				[Address(RVA = "0x15B3A58", Offset = "0x15B3A58", VA = "0x15B3A58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBC60", Offset = "0x8DBC60")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600061E")]
				[Address(RVA = "0x15B3A64", Offset = "0x15B3A64", VA = "0x15B3A64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBC70", Offset = "0x8DBC70")]
				private set
				{
				}
			}

			[Token(Token = "0x17000083")]
			public Transform transform
			{
				[Token(Token = "0x600061F")]
				[Address(RVA = "0x15B3A70", Offset = "0x15B3A70", VA = "0x15B3A70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBC80", Offset = "0x8DBC80")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000620")]
				[Address(RVA = "0x15B3A78", Offset = "0x15B3A78", VA = "0x15B3A78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBC90", Offset = "0x8DBC90")]
				private set
				{
				}
			}

			[Token(Token = "0x17000084")]
			public float IKOffset
			{
				[Token(Token = "0x6000621")]
				[Address(RVA = "0x15B3A80", Offset = "0x15B3A80", VA = "0x15B3A80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBCA0", Offset = "0x8DBCA0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000622")]
				[Address(RVA = "0x15B3A88", Offset = "0x15B3A88", VA = "0x15B3A88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBCB0", Offset = "0x8DBCB0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000085")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000627")]
				[Address(RVA = "0x15B4408", Offset = "0x15B4408", VA = "0x15B4408")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000086")]
			private float rootYOffset
			{
				[Token(Token = "0x6000630")]
				[Address(RVA = "0x15B46FC", Offset = "0x15B46FC", VA = "0x15B46FC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x15B2630", Offset = "0x15B2630", VA = "0x15B2630")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000624")]
			[Address(RVA = "0x15B3A90", Offset = "0x15B3A90", VA = "0x15B3A90")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000625")]
			[Address(RVA = "0x15B34E0", Offset = "0x15B34E0", VA = "0x15B34E0")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000626")]
			[Address(RVA = "0x15B273C", Offset = "0x15B273C", VA = "0x15B273C")]
			public void Process()
			{
			}

			[Token(Token = "0x6000628")]
			[Address(RVA = "0x15B40A0", Offset = "0x15B40A0", VA = "0x15B40A0")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x15B3ADC", Offset = "0x15B3ADC", VA = "0x15B3ADC")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x15B4588", Offset = "0x15B4588", VA = "0x15B4588")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x15B3D30", Offset = "0x15B3D30", VA = "0x15B3D30")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x15B3E38", Offset = "0x15B3E38", VA = "0x15B3E38")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x15B4684", Offset = "0x15B4684", VA = "0x15B4684")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0x15B4494", Offset = "0x15B4494", VA = "0x15B4494")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x15B4830", Offset = "0x15B4830", VA = "0x15B4830")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x15B2580", Offset = "0x15B2580", VA = "0x15B2580")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x20000D7")]
		public class Pelvis
		{
			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D701C", Offset = "0x8D701C")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D702C", Offset = "0x8D702C")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x17000087")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x6000632")]
				[Address(RVA = "0x15B4920", Offset = "0x15B4920", VA = "0x15B4920")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBCC0", Offset = "0x8DBCC0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000633")]
				[Address(RVA = "0x15B492C", Offset = "0x15B492C", VA = "0x15B492C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBCD0", Offset = "0x8DBCD0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000088")]
			public float heightOffset
			{
				[Token(Token = "0x6000634")]
				[Address(RVA = "0x15B4938", Offset = "0x15B4938", VA = "0x15B4938")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBCE0", Offset = "0x8DBCE0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000635")]
				[Address(RVA = "0x15B4940", Offset = "0x15B4940", VA = "0x15B4940")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBCF0", Offset = "0x8DBCF0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0x15B2714", Offset = "0x15B2714", VA = "0x15B2714")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0x15B3430", Offset = "0x15B3430", VA = "0x15B3430")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0x15B4948", Offset = "0x15B4948", VA = "0x15B4948")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0x15B2FAC", Offset = "0x15B2FAC", VA = "0x15B2FAC")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0x15B2628", Offset = "0x15B2628", VA = "0x15B2628")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D46C0", Offset = "0x8D46C0")]
		public LayerMask layers;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D46F8", Offset = "0x8D46F8")]
		public float maxStep;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4730", Offset = "0x8D4730")]
		public float heightOffset;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4768", Offset = "0x8D4768")]
		public float footSpeed;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D47A0", Offset = "0x8D47A0")]
		public float footRadius;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D47D8", Offset = "0x8D47D8")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4824", Offset = "0x8D4824")]
		public float prediction;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D485C", Offset = "0x8D485C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D485C", Offset = "0x8D485C")]
		public float footRotationWeight;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D48B0", Offset = "0x8D48B0")]
		public float footRotationSpeed;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D48E8", Offset = "0x8D48E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D48E8", Offset = "0x8D48E8")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4940", Offset = "0x8D4940")]
		public bool rotateSolver;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4978", Offset = "0x8D4978")]
		public float pelvisSpeed;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D49B0", Offset = "0x8D49B0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D49B0", Offset = "0x8D49B0")]
		public float pelvisDamper;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4A04", Offset = "0x8D4A04")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4A3C", Offset = "0x8D4A3C")]
		public float liftPelvisWeight;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4A74", Offset = "0x8D4A74")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4AAC", Offset = "0x8D4AAC")]
		public Quality quality;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D4AE4", Offset = "0x8D4AE4")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D4AF4", Offset = "0x8D4AF4")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D4B04", Offset = "0x8D4B04")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D4B14", Offset = "0x8D4B14")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D4B24", Offset = "0x8D4B24")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000021")]
		public Leg[] legs
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x15B1F68", Offset = "0x15B1F68", VA = "0x15B1F68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DA344", Offset = "0x8DA344")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x15B1F70", Offset = "0x15B1F70", VA = "0x15B1F70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DA354", Offset = "0x8DA354")]
			private set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x15B1F78", Offset = "0x15B1F78", VA = "0x15B1F78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DA364", Offset = "0x8DA364")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x15B1F80", Offset = "0x15B1F80", VA = "0x15B1F80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DA374", Offset = "0x8DA374")]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public bool isGrounded
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x15B1F88", Offset = "0x15B1F88", VA = "0x15B1F88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DA384", Offset = "0x8DA384")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x15B1F90", Offset = "0x15B1F90", VA = "0x15B1F90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DA394", Offset = "0x8DA394")]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public Transform root
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x15B1F9C", Offset = "0x15B1F9C", VA = "0x15B1F9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DA3A4", Offset = "0x8DA3A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x15B1FA4", Offset = "0x15B1FA4", VA = "0x15B1FA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DA3B4", Offset = "0x8DA3B4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x15B1FAC", Offset = "0x15B1FAC", VA = "0x15B1FAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DA3C4", Offset = "0x8DA3C4")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x15B1FC4", Offset = "0x15B1FC4", VA = "0x15B1FC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DA3D4", Offset = "0x8DA3D4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public bool rootGrounded
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x15B1FE4", Offset = "0x15B1FE4", VA = "0x15B1FE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000027")]
		public Vector3 up
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x15B2418", Offset = "0x15B2418", VA = "0x15B2418")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000028")]
		private bool useRootRotation
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x15B3594", Offset = "0x15B3594", VA = "0x15B3594")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x15B2038", Offset = "0x15B2038", VA = "0x15B2038")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x15B24A4", Offset = "0x15B24A4", VA = "0x15B24A4")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x15B1214", Offset = "0x15B1214", VA = "0x15B1214")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x15B1710", Offset = "0x15B1710", VA = "0x15B1710")]
		public void Update()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x15B3218", Offset = "0x15B3218", VA = "0x15B3218")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x15B0E44", Offset = "0x15B0E44", VA = "0x15B0E44")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x15B2724", Offset = "0x15B2724", VA = "0x15B2724")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x15B3664", Offset = "0x15B3664", VA = "0x15B3664")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x15B37CC", Offset = "0x15B37CC", VA = "0x15B37CC")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x15B38D0", Offset = "0x15B38D0", VA = "0x15B38D0")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x15B39C0", Offset = "0x15B39C0", VA = "0x15B39C0")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D2260", Offset = "0x8D2260")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D2260", Offset = "0x8D2260")]
	public class AimIK : IK
	{
		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1103C14", Offset = "0x1103C14", VA = "0x1103C14", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA3E4", Offset = "0x8DA3E4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1103C60", Offset = "0x1103C60", VA = "0x1103C60", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA41C", Offset = "0x8DA41C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1103CAC", Offset = "0x1103CAC", VA = "0x1103CAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA454", Offset = "0x8DA454")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1103CF8", Offset = "0x1103CF8", VA = "0x1103CF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA48C", Offset = "0x8DA48C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1103D44", Offset = "0x1103D44", VA = "0x1103D44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA4C4", Offset = "0x8DA4C4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1103D90", Offset = "0x1103D90", VA = "0x1103D90", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1103D98", Offset = "0x1103D98", VA = "0x1103D98")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D22C0", Offset = "0x8D22C0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D22C0", Offset = "0x8D22C0")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1105CF8", Offset = "0x1105CF8", VA = "0x1105CF8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA4FC", Offset = "0x8DA4FC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1105D44", Offset = "0x1105D44", VA = "0x1105D44", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA534", Offset = "0x8DA534")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1105D90", Offset = "0x1105D90", VA = "0x1105D90")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA56C", Offset = "0x8DA56C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1105DDC", Offset = "0x1105DDC", VA = "0x1105DDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA5A4", Offset = "0x8DA5A4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1105E28", Offset = "0x1105E28", VA = "0x1105E28", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1105E30", Offset = "0x1105E30", VA = "0x1105E30")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D2320", Offset = "0x8D2320")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D2320", Offset = "0x8D2320")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x110674C", Offset = "0x110674C", VA = "0x110674C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA5DC", Offset = "0x8DA5DC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1106798", Offset = "0x1106798", VA = "0x1106798", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA614", Offset = "0x8DA614")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x11067E4", Offset = "0x11067E4", VA = "0x11067E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA64C", Offset = "0x8DA64C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1106830", Offset = "0x1106830", VA = "0x1106830")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA684", Offset = "0x8DA684")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x110687C", Offset = "0x110687C", VA = "0x110687C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1106884", Offset = "0x1106884", VA = "0x1106884")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D2380", Offset = "0x8D2380")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D2380", Offset = "0x8D2380")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1106F04", Offset = "0x1106F04", VA = "0x1106F04", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA6BC", Offset = "0x8DA6BC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1106F50", Offset = "0x1106F50", VA = "0x1106F50", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA6F4", Offset = "0x8DA6F4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1106F9C", Offset = "0x1106F9C", VA = "0x1106F9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA72C", Offset = "0x8DA72C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1106FE8", Offset = "0x1106FE8", VA = "0x1106FE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA764", Offset = "0x8DA764")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1107034", Offset = "0x1107034", VA = "0x1107034", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x110703C", Offset = "0x110703C", VA = "0x110703C")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D23E0", Offset = "0x8D23E0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D23E0", Offset = "0x8D23E0")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x110EB98", Offset = "0x110EB98", VA = "0x110EB98", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA79C", Offset = "0x8DA79C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x110EBE4", Offset = "0x110EBE4", VA = "0x110EBE4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA7D4", Offset = "0x8DA7D4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x110EC30", Offset = "0x110EC30", VA = "0x110EC30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA80C", Offset = "0x8DA80C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x110EC7C", Offset = "0x110EC7C", VA = "0x110EC7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA844", Offset = "0x8DA844")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x110ECC8", Offset = "0x110ECC8", VA = "0x110ECC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA87C", Offset = "0x8DA87C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x110ED14", Offset = "0x110ED14", VA = "0x110ED14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA8B4", Offset = "0x8DA8B4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x110ED60", Offset = "0x110ED60", VA = "0x110ED60")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x110ED84", Offset = "0x110ED84", VA = "0x110ED84", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x110ED8C", Offset = "0x110ED8C", VA = "0x110ED8C")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x110EF48", Offset = "0x110EF48", VA = "0x110EF48")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x110F29C", Offset = "0x110F29C", VA = "0x110F29C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA8EC", Offset = "0x8DA8EC")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x110F2BC", Offset = "0x110F2BC", VA = "0x110F2BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA924", Offset = "0x8DA924")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x110F398", Offset = "0x110F398", VA = "0x110F398")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000300")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x15B7434", Offset = "0x15B7434", VA = "0x15B7434", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x15B7520", Offset = "0x15B7520", VA = "0x15B7520", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x15B76DC", Offset = "0x15B76DC", VA = "0x15B76DC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000304")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000305")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x15B773C", Offset = "0x15B773C", VA = "0x15B773C")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4B34", Offset = "0x8D4B34")]
		public IK[] IKComponents;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4B6C", Offset = "0x8D4B6C")]
		public Animator animator;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000029")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x15BA69C", Offset = "0x15BA69C", VA = "0x15BA69C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x15BA738", Offset = "0x15BA738", VA = "0x15BA738")]
		private void Start()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x15BA7A8", Offset = "0x15BA7A8", VA = "0x15BA7A8")]
		private void Update()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x15BA864", Offset = "0x15BA864", VA = "0x15BA864")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x15BA8A0", Offset = "0x15BA8A0", VA = "0x15BA8A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x15BA7DC", Offset = "0x15BA7DC", VA = "0x15BA7DC")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x15BA92C", Offset = "0x15BA92C", VA = "0x15BA92C")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D2440", Offset = "0x8D2440")]
	public class LegIK : IK
	{
		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1313BB4", Offset = "0x1313BB4", VA = "0x1313BB4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA95C", Offset = "0x8DA95C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1313C20", Offset = "0x1313C20", VA = "0x1313C20", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA994", Offset = "0x8DA994")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1313C8C", Offset = "0x1313C8C", VA = "0x1313C8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DA9CC", Offset = "0x8DA9CC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1313CD8", Offset = "0x1313CD8", VA = "0x1313CD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DAA04", Offset = "0x8DAA04")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1313D24", Offset = "0x1313D24", VA = "0x1313D24", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1313D2C", Offset = "0x1313D2C", VA = "0x1313D2C")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D2478", Offset = "0x8D2478")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D2478", Offset = "0x8D2478")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1313D94", Offset = "0x1313D94", VA = "0x1313D94", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DAA3C", Offset = "0x8DAA3C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1313DE0", Offset = "0x1313DE0", VA = "0x1313DE0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DAA74", Offset = "0x8DAA74")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1313E2C", Offset = "0x1313E2C", VA = "0x1313E2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DAAAC", Offset = "0x8DAAAC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1313E78", Offset = "0x1313E78", VA = "0x1313E78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DAAE4", Offset = "0x8DAAE4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1313EC4", Offset = "0x1313EC4", VA = "0x1313EC4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1313ECC", Offset = "0x1313ECC", VA = "0x1313ECC")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D24D8", Offset = "0x8D24D8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D24D8", Offset = "0x8D24D8")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1313F34", Offset = "0x1313F34", VA = "0x1313F34", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DAB1C", Offset = "0x8DAB1C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1313F80", Offset = "0x1313F80", VA = "0x1313F80", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DAB54", Offset = "0x8DAB54")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1313FCC", Offset = "0x1313FCC", VA = "0x1313FCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DAB8C", Offset = "0x8DAB8C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1314018", Offset = "0x1314018", VA = "0x1314018")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DABC4", Offset = "0x8DABC4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1314064", Offset = "0x1314064", VA = "0x1314064", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x131406C", Offset = "0x131406C", VA = "0x131406C")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D2538", Offset = "0x8D2538")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D2538", Offset = "0x8D2538")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x19BE0AC", Offset = "0x19BE0AC", VA = "0x19BE0AC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DABFC", Offset = "0x8DABFC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x19BE0F8", Offset = "0x19BE0F8", VA = "0x19BE0F8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DAC34", Offset = "0x8DAC34")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x19BE144", Offset = "0x19BE144", VA = "0x19BE144")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DAC6C", Offset = "0x8DAC6C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x19BE190", Offset = "0x19BE190", VA = "0x19BE190")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DACA4", Offset = "0x8DACA4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x19BE1DC", Offset = "0x19BE1DC", VA = "0x19BE1DC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x19BE1E4", Offset = "0x19BE1E4", VA = "0x19BE1E4")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D2598", Offset = "0x8D2598")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x20000D8")]
		public class References
		{
			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform chest;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform neck;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform leftShoulder;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Transform rightShoulder;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Transform leftThigh;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Transform leftCalf;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Transform leftFoot;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Transform leftToes;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public Transform rightThigh;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Transform rightCalf;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Transform rightFoot;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public Transform rightToes;

			[Token(Token = "0x17000089")]
			public bool isFilled
			{
				[Token(Token = "0x600063C")]
				[Address(RVA = "0x19BF6CC", Offset = "0x19BF6CC", VA = "0x19BF6CC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008A")]
			public bool isEmpty
			{
				[Token(Token = "0x600063D")]
				[Address(RVA = "0x19BF250", Offset = "0x19BF250", VA = "0x19BF250")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x19BFAB8", Offset = "0x19BFAB8", VA = "0x19BFAB8")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600063E")]
			[Address(RVA = "0x19BEE3C", Offset = "0x19BEE3C", VA = "0x19BEE3C")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x600063F")]
			[Address(RVA = "0x19BFAB0", Offset = "0x19BFAB0", VA = "0x19BFAB0")]
			public References()
			{
			}
		}

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x8D4BA4", Offset = "0x8D4BA4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4BA4", Offset = "0x8D4BA4")]
		public References references;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4C20", Offset = "0x8D4C20")]
		public IKSolverVR solver;

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x19BECF0", Offset = "0x19BECF0", VA = "0x19BECF0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DACDC", Offset = "0x8DACDC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x19BED5C", Offset = "0x19BED5C", VA = "0x19BED5C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DAD14", Offset = "0x8DAD14")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x19BEDC8", Offset = "0x19BEDC8", VA = "0x19BEDC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DAD4C", Offset = "0x8DAD4C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x19BEE14", Offset = "0x19BEE14", VA = "0x19BEE14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DAD84", Offset = "0x8DAD84")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x19BF1AC", Offset = "0x19BF1AC", VA = "0x19BF1AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DADBC", Offset = "0x8DADBC")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x19BF1D4", Offset = "0x19BF1D4", VA = "0x19BF1D4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x19BF1DC", Offset = "0x19BF1DC", VA = "0x19BF1DC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x19BFA28", Offset = "0x19BFA28", VA = "0x19BFA28")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007A")]
	public class FABRIKChain
	{
		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D4C58", Offset = "0x8D4C58")]
		public float pull;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D4C70", Offset = "0x8D4C70")]
		public float pin;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x11068EC", Offset = "0x11068EC", VA = "0x11068EC")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x11069B4", Offset = "0x11069B4", VA = "0x11069B4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x11069D4", Offset = "0x11069D4", VA = "0x11069D4")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1106DA4", Offset = "0x1106DA4", VA = "0x1106DA4")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1106AA8", Offset = "0x1106AA8", VA = "0x1106AA8")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1106E9C", Offset = "0x1106E9C", VA = "0x1106E9C")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x11070A4", Offset = "0x11070A4", VA = "0x11070A4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x110760C", Offset = "0x110760C", VA = "0x110760C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x11077CC", Offset = "0x11077CC", VA = "0x11077CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x11078C4", Offset = "0x11078C4", VA = "0x11078C4")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D9")]
		public class BendBone
		{
			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D703C", Offset = "0x8D703C")]
			public Transform transform;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7074", Offset = "0x8D7074")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7074", Offset = "0x8D7074")]
			public float weight;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000640")]
			[Address(RVA = "0x110A8F4", Offset = "0x110A8F4", VA = "0x110A8F4")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x110A974", Offset = "0x110A974", VA = "0x110A974")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x1108084", Offset = "0x1108084", VA = "0x1108084")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x1108488", Offset = "0x1108488", VA = "0x1108488")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4C88", Offset = "0x8D4C88")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8D4CC0", Offset = "0x8D4CC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4CC0", Offset = "0x8D4CC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D4CC0", Offset = "0x8D4CC0")]
		public float positionWeight;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4D38", Offset = "0x8D4D38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D4D38", Offset = "0x8D4D38")]
		public float bodyWeight;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4D8C", Offset = "0x8D4D8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D4D8C", Offset = "0x8D4D8C")]
		public float thighWeight;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4DE0", Offset = "0x8D4DE0")]
		public bool handsPullBody;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8D4E18", Offset = "0x8D4E18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4E18", Offset = "0x8D4E18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D4E18", Offset = "0x8D4E18")]
		public float rotationWeight;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4E90", Offset = "0x8D4E90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D4E90", Offset = "0x8D4E90")]
		public float bodyClampWeight;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4EE4", Offset = "0x8D4EE4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D4EE4", Offset = "0x8D4EE4")]
		public float headClampWeight;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4F38", Offset = "0x8D4F38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D4F38", Offset = "0x8D4F38")]
		public float bendWeight;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4F8C", Offset = "0x8D4F8C")]
		public BendBone[] bendBones;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8D4FC4", Offset = "0x8D4FC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D4FC4", Offset = "0x8D4FC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D4FC4", Offset = "0x8D4FC4")]
		public float CCDWeight;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D503C", Offset = "0x8D503C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D503C", Offset = "0x8D503C")]
		public float roll;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5090", Offset = "0x8D5090")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5090", Offset = "0x8D5090")]
		public float damper;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D50E8", Offset = "0x8D50E8")]
		public Transform[] CCDBones;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8D5120", Offset = "0x8D5120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5120", Offset = "0x8D5120")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5120", Offset = "0x8D5120")]
		public float postStretchWeight;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5198", Offset = "0x8D5198")]
		public float maxStretch;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D51D0", Offset = "0x8D51D0")]
		public float stretchDamper;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5208", Offset = "0x8D5208")]
		public bool fixHead;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5240", Offset = "0x8D5240")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8D5278", Offset = "0x8D5278")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D52B0", Offset = "0x8D52B0")]
		public float chestDirectionWeight;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x11078CC", Offset = "0x11078CC", VA = "0x11078CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1107BFC", Offset = "0x1107BFC", VA = "0x1107BFC")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x11080BC", Offset = "0x11080BC", VA = "0x11080BC")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x11084B0", Offset = "0x11084B0", VA = "0x11084B0")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1108E28", Offset = "0x1108E28", VA = "0x1108E28")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1109174", Offset = "0x1109174", VA = "0x1109174")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1109510", Offset = "0x1109510", VA = "0x1109510")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1109F7C", Offset = "0x1109F7C", VA = "0x1109F7C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1108B54", Offset = "0x1108B54", VA = "0x1108B54")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x110A18C", Offset = "0x110A18C", VA = "0x110A18C")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1109E38", Offset = "0x1109E38", VA = "0x1109E38")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1109C9C", Offset = "0x1109C9C", VA = "0x1109C9C")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x110A4F8", Offset = "0x110A4F8", VA = "0x110A4F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x110A778", Offset = "0x110A778", VA = "0x110A778")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007D")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x20000DA")]
		public class ChildConstraint
		{
			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D70E8", Offset = "0x8D70E8")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D70F8", Offset = "0x8D70F8")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x1700008B")]
			public float nominalDistance
			{
				[Token(Token = "0x6000644")]
				[Address(RVA = "0x110D838", Offset = "0x110D838", VA = "0x110D838")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBD00", Offset = "0x8DBD00")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000645")]
				[Address(RVA = "0x110D840", Offset = "0x110D840", VA = "0x110D840")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBD10", Offset = "0x8DBD10")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008C")]
			public bool isRigid
			{
				[Token(Token = "0x6000646")]
				[Address(RVA = "0x110D848", Offset = "0x110D848", VA = "0x110D848")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBD20", Offset = "0x8DBD20")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000647")]
				[Address(RVA = "0x110D850", Offset = "0x110D850", VA = "0x110D850")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBD30", Offset = "0x8DBD30")]
				private set
				{
				}
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x110D85C", Offset = "0x110D85C", VA = "0x110D85C")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0x110B5BC", Offset = "0x110B5BC", VA = "0x110B5BC")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0x110BAFC", Offset = "0x110BAFC", VA = "0x110BAFC")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0x110D534", Offset = "0x110D534", VA = "0x110D534")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DB")]
		public enum Smoothing
		{
			[Token(Token = "0x40005D0")]
			None,
			[Token(Token = "0x40005D1")]
			Exponential,
			[Token(Token = "0x40005D2")]
			Cubic
		}

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D52C8", Offset = "0x8D52C8")]
		public float pin;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D52E0", Offset = "0x8D52E0")]
		public float pull;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D52F8", Offset = "0x8D52F8")]
		public float push;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5310", Offset = "0x8D5310")]
		public float pushParent;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5328", Offset = "0x8D5328")]
		public float reach;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x4000331")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x110AA18", Offset = "0x110AA18", VA = "0x110AA18")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x110AAE4", Offset = "0x110AAE4", VA = "0x110AAE4")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x110ABF0", Offset = "0x110ABF0", VA = "0x110ABF0")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x110AD14", Offset = "0x110AD14", VA = "0x110AD14")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x110ADF0", Offset = "0x110ADF0", VA = "0x110ADF0")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x110AEF4", Offset = "0x110AEF4", VA = "0x110AEF4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x110B614", Offset = "0x110B614", VA = "0x110B614")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x110B084", Offset = "0x110B084", VA = "0x110B084")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x110BD00", Offset = "0x110BD00", VA = "0x110BD00")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x110C0A4", Offset = "0x110C0A4", VA = "0x110C0A4")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x110C488", Offset = "0x110C488", VA = "0x110C488")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x110CA0C", Offset = "0x110CA0C", VA = "0x110CA0C")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x110CFDC", Offset = "0x110CFDC", VA = "0x110CFDC")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x110D274", Offset = "0x110D274", VA = "0x110D274")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x110CED4", Offset = "0x110CED4", VA = "0x110CED4")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x110C7F4", Offset = "0x110C7F4", VA = "0x110C7F4")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x110CE5C", Offset = "0x110CE5C", VA = "0x110CE5C")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x110D35C", Offset = "0x110D35C", VA = "0x110D35C")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x110CD7C", Offset = "0x110CD7C", VA = "0x110CD7C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x110D15C", Offset = "0x110D15C", VA = "0x110D15C")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007E")]
	public class IKConstraintBend
	{
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5340", Offset = "0x8D5340")]
		public float weight;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D5358", Offset = "0x8D5358")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700002A")]
		public bool initiated
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x15B790C", Offset = "0x15B790C", VA = "0x15B790C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DADF4", Offset = "0x8DADF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x15B7914", Offset = "0x15B7914", VA = "0x15B7914")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAE04", Offset = "0x8DAE04")]
			private set
			{
			}
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x15B7744", Offset = "0x15B7744", VA = "0x15B7744")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x15B7920", Offset = "0x15B7920", VA = "0x15B7920")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x15B79A4", Offset = "0x15B79A4", VA = "0x15B79A4")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x15B7A50", Offset = "0x15B7A50", VA = "0x15B7A50")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x15B7A5C", Offset = "0x15B7A5C", VA = "0x15B7A5C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x15B7F84", Offset = "0x15B7F84", VA = "0x15B7F84")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x15B81B4", Offset = "0x15B81B4", VA = "0x15B81B4")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x15B8650", Offset = "0x15B8650", VA = "0x15B8650")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x15B7D54", Offset = "0x15B7D54", VA = "0x15B7D54")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x15B7E6C", Offset = "0x15B7E6C", VA = "0x15B7E6C")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public class IKEffector
	{
		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5368", Offset = "0x8D5368")]
		public float positionWeight;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5380", Offset = "0x8D5380")]
		public float rotationWeight;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D5398", Offset = "0x8D5398")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D53A8", Offset = "0x8D53A8")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x1700002B")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x15B8D00", Offset = "0x15B8D00", VA = "0x15B8D00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAE14", Offset = "0x8DAE14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x15B8D08", Offset = "0x15B8D08", VA = "0x15B8D08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAE24", Offset = "0x8DAE24")]
			private set
			{
			}
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x15B8C98", Offset = "0x15B8C98", VA = "0x15B8C98")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x15B8D14", Offset = "0x15B8D14", VA = "0x15B8D14")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x15B8DE8", Offset = "0x15B8DE8", VA = "0x15B8DE8")]
		public IKEffector()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x15B8F24", Offset = "0x15B8F24", VA = "0x15B8F24")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x15B907C", Offset = "0x15B907C", VA = "0x15B907C")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x15B936C", Offset = "0x15B936C", VA = "0x15B936C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x15B95F8", Offset = "0x15B95F8", VA = "0x15B95F8")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x15B9730", Offset = "0x15B9730", VA = "0x15B9730")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x15B97DC", Offset = "0x15B97DC", VA = "0x15B97DC")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x15B9E1C", Offset = "0x15B9E1C", VA = "0x15B9E1C")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x15B9E8C", Offset = "0x15B9E8C", VA = "0x15B9E8C")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x15BA098", Offset = "0x15BA098", VA = "0x15BA098")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x15BA3CC", Offset = "0x15BA3CC", VA = "0x15BA3CC")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000DC")]
		public class BoneMap
		{
			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x1700008D")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x600064D")]
				[Address(RVA = "0x15BAB9C", Offset = "0x15BAB9C", VA = "0x15BAB9C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008E")]
			public bool isNodeBone
			{
				[Token(Token = "0x6000650")]
				[Address(RVA = "0x15BAD08", Offset = "0x15BAD08", VA = "0x15BAD08")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008F")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000664")]
				[Address(RVA = "0x15BB2E0", Offset = "0x15BB2E0", VA = "0x15BB2E0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600064C")]
			[Address(RVA = "0x15BAB74", Offset = "0x15BAB74", VA = "0x15BAB74")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x15BAC68", Offset = "0x15BAC68", VA = "0x15BAC68")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x15BACB8", Offset = "0x15BACB8", VA = "0x15BACB8")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x15BAD18", Offset = "0x15BAD18", VA = "0x15BAD18")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x15BAE00", Offset = "0x15BAE00", VA = "0x15BAE00")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0x15BAE08", Offset = "0x15BAE08", VA = "0x15BAE08")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x15BAF98", Offset = "0x15BAF98", VA = "0x15BAF98")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x15BB0A4", Offset = "0x15BB0A4", VA = "0x15BB0A4")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x15BB130", Offset = "0x15BB130", VA = "0x15BB130")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x15BB504", Offset = "0x15BB504", VA = "0x15BB504")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x15BB53C", Offset = "0x15BB53C", VA = "0x15BB53C")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x15BB574", Offset = "0x15BB574", VA = "0x15BB574")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x15BB59C", Offset = "0x15BB59C", VA = "0x15BB59C")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x15BB6C4", Offset = "0x15BB6C4", VA = "0x15BB6C4")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x15BB9FC", Offset = "0x15BB9FC", VA = "0x15BB9FC")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x15BBA2C", Offset = "0x15BBA2C", VA = "0x15BBA2C")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0x15BBBC4", Offset = "0x15BBBC4", VA = "0x15BBBC4")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x15BBC34", Offset = "0x15BBC34", VA = "0x15BBC34")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x15BBE78", Offset = "0x15BBE78", VA = "0x15BBE78")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x15BC0A0", Offset = "0x15BC0A0", VA = "0x15BC0A0")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0x15BC1B8", Offset = "0x15BC1B8", VA = "0x15BC1B8")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x15BB804", Offset = "0x15BB804", VA = "0x15BB804")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x15BC348", Offset = "0x15BC348", VA = "0x15BC348")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x15BA934", Offset = "0x15BA934", VA = "0x15BA934", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x15BA93C", Offset = "0x15BA93C", VA = "0x15BA93C", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x15BA940", Offset = "0x15BA940", VA = "0x15BA940")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x15BAA64", Offset = "0x15BAA64", VA = "0x15BAA64")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x15BAB6C", Offset = "0x15BAB6C", VA = "0x15BAB6C")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D53C0", Offset = "0x8D53C0")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x15BC364", Offset = "0x15BC364", VA = "0x15BC364", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x15BC404", Offset = "0x15BC404", VA = "0x15BC404")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x15BC488", Offset = "0x15BC488", VA = "0x15BC488")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x15BC520", Offset = "0x15BC520", VA = "0x15BC520")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x15BC538", Offset = "0x15BC538", VA = "0x15BC538")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x15BC554", Offset = "0x15BC554", VA = "0x15BC554", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x15BC5F0", Offset = "0x15BC5F0", VA = "0x15BC5F0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x15BC608", Offset = "0x15BC608", VA = "0x15BC608")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000DD")]
		public enum BoneMapType
		{
			[Token(Token = "0x40005EA")]
			Parent,
			[Token(Token = "0x40005EB")]
			Bone1,
			[Token(Token = "0x40005EC")]
			Bone2,
			[Token(Token = "0x40005ED")]
			Bone3
		}

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D53D8", Offset = "0x8D53D8")]
		public float maintainRotationWeight;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D53F0", Offset = "0x8D53F0")]
		public float weight;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x15BC62C", Offset = "0x15BC62C", VA = "0x15BC62C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x15BC6B0", Offset = "0x15BC6B0", VA = "0x15BC6B0")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x15BC784", Offset = "0x15BC784", VA = "0x15BC784")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x15BCAD8", Offset = "0x15BCAD8", VA = "0x15BCAD8")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x15BCBD8", Offset = "0x15BCBD8", VA = "0x15BCBD8")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x15BCD04", Offset = "0x15BCD04", VA = "0x15BCD04")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x15BCD10", Offset = "0x15BCD10", VA = "0x15BCD10")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x15BCDB8", Offset = "0x15BCDB8", VA = "0x15BCDB8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x15BCE70", Offset = "0x15BCE70", VA = "0x15BCE70", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x15BD0E0", Offset = "0x15BD0E0", VA = "0x15BD0E0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x15BD198", Offset = "0x15BD198", VA = "0x15BD198")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5408", Offset = "0x8D5408")]
		public int iterations;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5420", Offset = "0x8D5420")]
		public float twistWeight;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x15BD300", Offset = "0x15BD300", VA = "0x15BD300", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x15BD5F0", Offset = "0x15BD5F0", VA = "0x15BD5F0")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x15BD70C", Offset = "0x15BD70C", VA = "0x15BD70C")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x15BD864", Offset = "0x15BD864", VA = "0x15BD864")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x15BD874", Offset = "0x15BD874", VA = "0x15BD874")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x15BD8DC", Offset = "0x15BD8DC", VA = "0x15BD8DC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x15BD95C", Offset = "0x15BD95C", VA = "0x15BD95C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x15BDFB0", Offset = "0x15BDFB0", VA = "0x15BDFB0")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x15BDFE8", Offset = "0x15BDFE8", VA = "0x15BDFE8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x15BE2C8", Offset = "0x15BE2C8", VA = "0x15BE2C8")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x15BE674", Offset = "0x15BE674", VA = "0x15BE674")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x15BE760", Offset = "0x15BE760", VA = "0x15BE760")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x15BE828", Offset = "0x15BE828", VA = "0x15BE828")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000DE")]
		public class Point
		{
			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7108", Offset = "0x8D7108")]
			public float weight;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x15C0348", Offset = "0x15C0348", VA = "0x15C0348")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x15C0398", Offset = "0x15C0398", VA = "0x15C0398")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x15C0520", Offset = "0x15C0520", VA = "0x15C0520")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x15C0558", Offset = "0x15C0558", VA = "0x15C0558")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x15C0590", Offset = "0x15C0590", VA = "0x15C0590")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x15C05E0", Offset = "0x15C05E0", VA = "0x15C05E0")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x15BFE1C", Offset = "0x15BFE1C", VA = "0x15BFE1C")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DF")]
		public class Bone : Point
		{
			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x17000090")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600066D")]
				[Address(RVA = "0x15BF3EC", Offset = "0x15BF3EC", VA = "0x15BF3EC")]
				get
				{
					return null;
				}
				[Token(Token = "0x600066E")]
				[Address(RVA = "0x15BF4E0", Offset = "0x15BF4E0", VA = "0x15BF4E0")]
				set
				{
				}
			}

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x15BF568", Offset = "0x15BF568", VA = "0x15BF568")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x15BF828", Offset = "0x15BF828", VA = "0x15BF828")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000671")]
			[Address(RVA = "0x15BFB08", Offset = "0x15BFB08", VA = "0x15BFB08")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x15BFD70", Offset = "0x15BFD70", VA = "0x15BFD70")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x15BFD98", Offset = "0x15BFD98", VA = "0x15BFD98")]
			public Bone()
			{
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x15BFE9C", Offset = "0x15BFE9C", VA = "0x15BFE9C")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x15BFF34", Offset = "0x15BFF34", VA = "0x15BFF34")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E0")]
		public class Node : Point
		{
			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x15C02E4", Offset = "0x15C02E4", VA = "0x15C02E4")]
			public Node()
			{
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x15C02E8", Offset = "0x15C02E8", VA = "0x15C02E8")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x15C0310", Offset = "0x15C0310", VA = "0x15C0310")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000E1")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000E2")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5448", Offset = "0x8D5448")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5448", Offset = "0x8D5448")]
		public float IKPositionWeight;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D549C", Offset = "0x8D549C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x1700002C")]
		public bool initiated
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x15BEE3C", Offset = "0x15BEE3C", VA = "0x15BEE3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAE34", Offset = "0x8DAE34")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x15BEE44", Offset = "0x15BEE44", VA = "0x15BEE44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAE44", Offset = "0x8DAE44")]
			private set
			{
			}
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x15BEB08", Offset = "0x15BEB08", VA = "0x15BEB08")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600039B")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x15B7590", Offset = "0x15B7590", VA = "0x15B7590")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x15B74B8", Offset = "0x15B74B8", VA = "0x15B74B8")]
		public void Update()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x15BED90", Offset = "0x15BED90", VA = "0x15BED90", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x15BED9C", Offset = "0x15BED9C", VA = "0x15BED9C")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x15BEDA8", Offset = "0x15BEDA8", VA = "0x15BEDA8")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x15BEDB0", Offset = "0x15BEDB0", VA = "0x15BEDB0")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x15BEE34", Offset = "0x15BEE34", VA = "0x15BEE34")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60003A6")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60003A7")]
		public abstract void FixTransforms();

		[Token(Token = "0x60003A8")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60003A9")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60003AA")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x15BEE50", Offset = "0x15BEE50", VA = "0x15BEE50")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x15BEE68", Offset = "0x15BEE68", VA = "0x15BEE68")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x15BEFA4", Offset = "0x15BEFA4", VA = "0x15BEFA4")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x15BF050", Offset = "0x15BF050", VA = "0x15BF050")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x15BF3D4", Offset = "0x15BF3D4", VA = "0x15BF3D4")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000085")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D54E4", Offset = "0x8D54E4")]
		public float poleWeight;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D54FC", Offset = "0x8D54FC")]
		public float clampWeight;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5514", Offset = "0x8D5514")]
		public int clampSmoothing;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700002D")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x15C0768", Offset = "0x15C0768", VA = "0x15C0768")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002E")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x15C0834", Offset = "0x15C0834", VA = "0x15C0834")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002F")]
		protected override int minBones
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x15C15A4", Offset = "0x15C15A4", VA = "0x15C15A4", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000030")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x15C1B48", Offset = "0x15C1B48", VA = "0x15C1B48", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x15C0668", Offset = "0x15C0668", VA = "0x15C0668")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x15C0900", Offset = "0x15C0900", VA = "0x15C0900", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x15C0B80", Offset = "0x15C0B80", VA = "0x15C0B80", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x15C14F0", Offset = "0x15C14F0", VA = "0x15C14F0")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x15C1118", Offset = "0x15C1118", VA = "0x15C1118")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x15C15AC", Offset = "0x15C15AC", VA = "0x15C15AC")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x15C1BBC", Offset = "0x15C1BBC", VA = "0x15C1BBC")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x15C1C54", Offset = "0x15C1C54", VA = "0x15C1C54")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x15C1D04", Offset = "0x15C1D04", VA = "0x15C1D04", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x15C1D88", Offset = "0x15C1D88", VA = "0x15C1D88", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x15C2084", Offset = "0x15C2084", VA = "0x15C2084")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x15C27D8", Offset = "0x15C27D8", VA = "0x15C27D8")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000087")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000031")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x15C3A08", Offset = "0x15C3A08", VA = "0x15C3A08", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x15C27E0", Offset = "0x15C27E0", VA = "0x15C27E0")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x15C2F28", Offset = "0x15C2F28", VA = "0x15C2F28")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x15C3060", Offset = "0x15C3060", VA = "0x15C3060", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x15C30F8", Offset = "0x15C30F8", VA = "0x15C30F8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x15C36A0", Offset = "0x15C36A0", VA = "0x15C36A0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x15C3A10", Offset = "0x15C3A10", VA = "0x15C3A10")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x15C28B4", Offset = "0x15C28B4", VA = "0x15C28B4")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x15C300C", Offset = "0x15C300C", VA = "0x15C300C")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x15C39AC", Offset = "0x15C39AC", VA = "0x15C39AC")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x15C2D50", Offset = "0x15C2D50", VA = "0x15C2D50")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x15C4250", Offset = "0x15C4250", VA = "0x15C4250")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x15C4360", Offset = "0x15C4360", VA = "0x15C4360")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x15C448C", Offset = "0x15C448C", VA = "0x15C448C")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x15C45A4", Offset = "0x15C45A4", VA = "0x15C45A4")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x15C3408", Offset = "0x15C3408", VA = "0x15C3408")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x15C3554", Offset = "0x15C3554", VA = "0x15C3554")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x15C4790", Offset = "0x15C4790", VA = "0x15C4790")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x15C3CC8", Offset = "0x15C3CC8", VA = "0x15C3CC8")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x15C2FFC", Offset = "0x15C2FFC", VA = "0x15C2FFC")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x15C4EF8", Offset = "0x15C4EF8", VA = "0x15C4EF8")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x15C4964", Offset = "0x15C4964", VA = "0x15C4964")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x15C3B28", Offset = "0x15C3B28", VA = "0x15C3B28")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x15C3C04", Offset = "0x15C3C04", VA = "0x15C3C04")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x15C4FC4", Offset = "0x15C4FC4", VA = "0x15C4FC4")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000088")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D552C", Offset = "0x8D552C")]
		public float rootPin;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x15C503C", Offset = "0x15C503C", VA = "0x15C503C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x15C5908", Offset = "0x15C5908", VA = "0x15C5908", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x15C59A0", Offset = "0x15C59A0", VA = "0x15C59A0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x15C5A40", Offset = "0x15C5A40", VA = "0x15C5A40", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x15C5B40", Offset = "0x15C5B40", VA = "0x15C5B40")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x15C5BDC", Offset = "0x15C5BDC", VA = "0x15C5BDC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x15C6144", Offset = "0x15C6144", VA = "0x15C6144", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x15C6344", Offset = "0x15C6344", VA = "0x15C6344", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x15C61F4", Offset = "0x15C61F4", VA = "0x15C61F4")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x15C5E10", Offset = "0x15C5E10", VA = "0x15C5E10")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x15C63DC", Offset = "0x15C63DC", VA = "0x15C63DC")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000089")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5544", Offset = "0x8D5544")]
		public int iterations;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x15C6454", Offset = "0x15C6454", VA = "0x15C6454")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x15C6548", Offset = "0x15C6548", VA = "0x15C6548")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x15C65A4", Offset = "0x15C65A4", VA = "0x15C65A4")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x15B8C3C", Offset = "0x15B8C3C", VA = "0x15B8C3C")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x15B7CD4", Offset = "0x15B7CD4", VA = "0x15B7CD4")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x15C66D8", Offset = "0x15C66D8", VA = "0x15C66D8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x15C6860", Offset = "0x15C6860", VA = "0x15C6860", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x15C69D4", Offset = "0x15C69D4", VA = "0x15C69D4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x15C6BD4", Offset = "0x15C6BD4", VA = "0x15C6BD4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x15C6CA4", Offset = "0x15C6CA4", VA = "0x15C6CA4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x15C6D80", Offset = "0x15C6D80", VA = "0x15C6D80", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x15C6EF0", Offset = "0x15C6EF0", VA = "0x15C6EF0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x15C70A8", Offset = "0x15C70A8", VA = "0x15C70A8", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x15C72E4", Offset = "0x15C72E4", VA = "0x15C72E4", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x15C75A4", Offset = "0x15C75A4", VA = "0x15C75A4", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x15C75E8", Offset = "0x15C75E8", VA = "0x15C75E8", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x15C76CC", Offset = "0x15C76CC", VA = "0x15C76CC")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008A")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40003AE")]
		Body,
		[Token(Token = "0x40003AF")]
		LeftShoulder,
		[Token(Token = "0x40003B0")]
		RightShoulder,
		[Token(Token = "0x40003B1")]
		LeftThigh,
		[Token(Token = "0x40003B2")]
		RightThigh,
		[Token(Token = "0x40003B3")]
		LeftHand,
		[Token(Token = "0x40003B4")]
		RightHand,
		[Token(Token = "0x40003B5")]
		LeftFoot,
		[Token(Token = "0x40003B6")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x200008B")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40003B8")]
		LeftArm,
		[Token(Token = "0x40003B9")]
		RightArm,
		[Token(Token = "0x40003BA")]
		LeftLeg,
		[Token(Token = "0x40003BB")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x200008C")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D555C", Offset = "0x8D555C")]
		public float spineStiffness;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5574", Offset = "0x8D5574")]
		public float pullBodyVertical;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D558C", Offset = "0x8D558C")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D55A4", Offset = "0x8D55A4")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000032")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x15FF3D0", Offset = "0x15FF3D0", VA = "0x15FF3D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x15FF518", Offset = "0x15FF518", VA = "0x15FF518")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x15FF520", Offset = "0x15FF520", VA = "0x15FF520")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x15FF528", Offset = "0x15FF528", VA = "0x15FF528")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x15FF530", Offset = "0x15FF530", VA = "0x15FF530")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x15FF538", Offset = "0x15FF538", VA = "0x15FF538")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x15FF540", Offset = "0x15FF540", VA = "0x15FF540")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x15FF548", Offset = "0x15FF548", VA = "0x15FF548")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x15FF550", Offset = "0x15FF550", VA = "0x15FF550")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x15FF558", Offset = "0x15FF558", VA = "0x15FF558")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x15FF590", Offset = "0x15FF590", VA = "0x15FF590")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x15FF5C8", Offset = "0x15FF5C8", VA = "0x15FF5C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x15FF600", Offset = "0x15FF600", VA = "0x15FF600")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x15FF638", Offset = "0x15FF638", VA = "0x15FF638")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x15FF66C", Offset = "0x15FF66C", VA = "0x15FF66C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x15FF6A4", Offset = "0x15FF6A4", VA = "0x15FF6A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x15FF6DC", Offset = "0x15FF6DC", VA = "0x15FF6DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x15FF714", Offset = "0x15FF714", VA = "0x15FF714")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x16016DC", Offset = "0x16016DC", VA = "0x16016DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAE54", Offset = "0x8DAE54")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x16016E8", Offset = "0x16016E8", VA = "0x16016E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAE64", Offset = "0x8DAE64")]
			private set
			{
			}
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x15FF748", Offset = "0x15FF748", VA = "0x15FF748")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x15FF854", Offset = "0x15FF854", VA = "0x15FF854")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x15FF79C", Offset = "0x15FF79C", VA = "0x15FF79C")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x15FF930", Offset = "0x15FF930", VA = "0x15FF930")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x15FF3D8", Offset = "0x15FF3D8", VA = "0x15FF3D8")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x15FFA00", Offset = "0x15FFA00", VA = "0x15FFA00")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x15FFAB8", Offset = "0x15FFAB8", VA = "0x15FFAB8")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x15FFB6C", Offset = "0x15FFB6C", VA = "0x15FFB6C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x15FFC20", Offset = "0x15FFC20", VA = "0x15FFC20")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x15FFC28", Offset = "0x15FFC28", VA = "0x15FFC28")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x15FFC5C", Offset = "0x15FFC5C", VA = "0x15FFC5C")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x15FFD24", Offset = "0x15FFD24", VA = "0x15FFD24", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x15FFEB8", Offset = "0x15FFEB8", VA = "0x15FFEB8")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1600FF4", Offset = "0x1600FF4", VA = "0x1600FF4")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1601488", Offset = "0x1601488", VA = "0x1601488")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x16014E8", Offset = "0x16014E8", VA = "0x16014E8")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1601308", Offset = "0x1601308", VA = "0x1601308")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x16013C8", Offset = "0x16013C8", VA = "0x16013C8")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x16016F4", Offset = "0x16016F4", VA = "0x16016F4")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x16017D0", Offset = "0x16017D0", VA = "0x16017D0", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x160191C", Offset = "0x160191C", VA = "0x160191C")]
		private void PullBody()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1601AAC", Offset = "0x1601AAC", VA = "0x1601AAC")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1601CAC", Offset = "0x1601CAC", VA = "0x1601CAC")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1601EAC", Offset = "0x1601EAC", VA = "0x1601EAC", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x16021E4", Offset = "0x16021E4", VA = "0x16021E4", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x16022E8", Offset = "0x16022E8", VA = "0x16022E8")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008D")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000045")]
		protected virtual int minBones
		{
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x1602B3C", Offset = "0x1602B3C", VA = "0x1602B3C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000046")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x1602B44", Offset = "0x1602B44", VA = "0x1602B44", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x1602B4C", Offset = "0x1602B4C", VA = "0x1602B4C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x16030DC", Offset = "0x16030DC", VA = "0x16030DC", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000049")]
		protected float positionOffset
		{
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x1603210", Offset = "0x1603210", VA = "0x1603210")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x16022F8", Offset = "0x16022F8", VA = "0x16022F8")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x160248C", Offset = "0x160248C", VA = "0x160248C")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x16025C8", Offset = "0x16025C8", VA = "0x16025C8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1602634", Offset = "0x1602634", VA = "0x1602634", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x16026B4", Offset = "0x16026B4", VA = "0x16026B4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1602A40", Offset = "0x1602A40", VA = "0x1602A40", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1602A48", Offset = "0x1602A48", VA = "0x1602A48", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1602B54", Offset = "0x1602B54", VA = "0x1602B54", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1602B58", Offset = "0x1602B58", VA = "0x1602B58", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1602B5C", Offset = "0x1602B5C", VA = "0x1602B5C")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x16032D4", Offset = "0x16032D4", VA = "0x16032D4")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1603678", Offset = "0x1603678", VA = "0x1603678")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x160392C", Offset = "0x160392C", VA = "0x160392C")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008E")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D55B4", Offset = "0x8D55B4")]
		public float IKRotationWeight;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x160399C", Offset = "0x160399C", VA = "0x160399C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1603D10", Offset = "0x1603D10", VA = "0x1603D10")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1603D80", Offset = "0x1603D80", VA = "0x1603D80", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1603EDC", Offset = "0x1603EDC", VA = "0x1603EDC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1604074", Offset = "0x1604074", VA = "0x1604074", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x16040D0", Offset = "0x16040D0", VA = "0x16040D0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1604140", Offset = "0x1604140", VA = "0x1604140", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x16044A4", Offset = "0x16044A4", VA = "0x16044A4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x16044D0", Offset = "0x16044D0", VA = "0x16044D0")]
		private void Solve()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x16041A4", Offset = "0x16041A4", VA = "0x16041A4")]
		private void Read()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x16045D0", Offset = "0x16045D0", VA = "0x16045D0")]
		private void Write()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1604AF4", Offset = "0x1604AF4", VA = "0x1604AF4")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008F")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20000E3")]
		public enum BendModifier
		{
			[Token(Token = "0x40005FE")]
			Animation,
			[Token(Token = "0x40005FF")]
			Target,
			[Token(Token = "0x4000600")]
			Parent,
			[Token(Token = "0x4000601")]
			Arm,
			[Token(Token = "0x4000602")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x99C988", Offset = "0x99C988", VA = "0x99C988")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D55CC", Offset = "0x8D55CC")]
		public float maintainRotationWeight;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D55E4", Offset = "0x8D55E4")]
		public float bendModifierWeight;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x1700004A")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x16063F8", Offset = "0x16063F8", VA = "0x16063F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1604CF4", Offset = "0x1604CF4", VA = "0x1604CF4")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1604D44", Offset = "0x1604D44", VA = "0x1604D44")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1604E58", Offset = "0x1604E58", VA = "0x1604E58", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x16054C8", Offset = "0x16054C8", VA = "0x16054C8", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x16060A4", Offset = "0x16060A4", VA = "0x16060A4", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x16061EC", Offset = "0x16061EC", VA = "0x16061EC")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1606370", Offset = "0x1606370", VA = "0x1606370")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x16051D4", Offset = "0x16051D4", VA = "0x16051D4")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x16055F4", Offset = "0x16055F4", VA = "0x16055F4")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000090")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000E5")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x17000091")]
			public Vector3 forward
			{
				[Token(Token = "0x6000686")]
				[Address(RVA = "0x16082B4", Offset = "0x16082B4", VA = "0x16082B4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x1608A00", Offset = "0x1608A00", VA = "0x1608A00")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x1607650", Offset = "0x1607650", VA = "0x1607650")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000684")]
			[Address(RVA = "0x160798C", Offset = "0x160798C", VA = "0x160798C")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000685")]
			[Address(RVA = "0x16086B8", Offset = "0x16086B8", VA = "0x16086B8")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D55FC", Offset = "0x8D55FC")]
		public float bodyWeight;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5614", Offset = "0x8D5614")]
		public float headWeight;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D562C", Offset = "0x8D562C")]
		public float eyesWeight;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5644", Offset = "0x8D5644")]
		public float clampWeight;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D565C", Offset = "0x8D565C")]
		public float clampWeightHead;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5674", Offset = "0x8D5674")]
		public float clampWeightEyes;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D568C", Offset = "0x8D568C")]
		public int clampSmoothing;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] headForwards;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x1700004B")]
		private bool spineIsValid
		{
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x1606DB4", Offset = "0x1606DB4", VA = "0x1606DB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004C")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x1606F8C", Offset = "0x1606F8C", VA = "0x1606F8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		private bool headIsValid
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x1606E98", Offset = "0x1606E98", VA = "0x1606E98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		private bool headIsEmpty
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x1606FB0", Offset = "0x1606FB0", VA = "0x1606FB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		private bool eyesIsValid
		{
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x1606EA8", Offset = "0x1606EA8", VA = "0x1606EA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000050")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x160702C", Offset = "0x160702C", VA = "0x160702C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1606474", Offset = "0x1606474", VA = "0x1606474")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x16064F8", Offset = "0x16064F8", VA = "0x16064F8")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x16065A4", Offset = "0x16065A4", VA = "0x16065A4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x160666C", Offset = "0x160666C", VA = "0x160666C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1606758", Offset = "0x1606758", VA = "0x1606758")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1606864", Offset = "0x1606864", VA = "0x1606864")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x16069AC", Offset = "0x16069AC", VA = "0x16069AC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1606ADC", Offset = "0x1606ADC", VA = "0x1606ADC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1606C20", Offset = "0x1606C20", VA = "0x1606C20", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1607050", Offset = "0x1607050", VA = "0x1607050", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1607288", Offset = "0x1607288", VA = "0x1607288", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1607428", Offset = "0x1607428", VA = "0x1607428")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x160767C", Offset = "0x160767C", VA = "0x160767C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1607AC8", Offset = "0x1607AC8", VA = "0x1607AC8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1607BCC", Offset = "0x1607BCC", VA = "0x1607BCC")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1607DF8", Offset = "0x1607DF8", VA = "0x1607DF8")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1608054", Offset = "0x1608054", VA = "0x1608054")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1608380", Offset = "0x1608380", VA = "0x1608380")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x16074D8", Offset = "0x16074D8", VA = "0x16074D8")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1608820", Offset = "0x1608820", VA = "0x1608820")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000091")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000E6")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000687")]
			[Address(RVA = "0x1609FD8", Offset = "0x1609FD8", VA = "0x1609FD8")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0x160AB80", Offset = "0x160AB80", VA = "0x160AB80")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x1604D8C", Offset = "0x1604D8C", VA = "0x1604D8C")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x160AC48", Offset = "0x160AC48", VA = "0x160AC48")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D56A4", Offset = "0x8D56A4")]
		public float IKRotationWeight;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1608A08", Offset = "0x1608A08", VA = "0x1608A08")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1608BF8", Offset = "0x1608BF8", VA = "0x1608BF8")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1608DAC", Offset = "0x1608DAC", VA = "0x1608DAC")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1608DB8", Offset = "0x1608DB8", VA = "0x1608DB8")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1608E3C", Offset = "0x1608E3C", VA = "0x1608E3C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1608E48", Offset = "0x1608E48", VA = "0x1608E48")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1608E50", Offset = "0x1608E50", VA = "0x1608E50", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1608F54", Offset = "0x1608F54", VA = "0x1608F54", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1609074", Offset = "0x1609074", VA = "0x1609074", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x16090C0", Offset = "0x16090C0", VA = "0x16090C0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1609120", Offset = "0x1609120", VA = "0x1609120", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x16094FC", Offset = "0x16094FC", VA = "0x16094FC")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1609554", Offset = "0x1609554", VA = "0x1609554")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1609AFC", Offset = "0x1609AFC", VA = "0x1609AFC")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1609D14", Offset = "0x1609D14", VA = "0x1609D14", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1609ED0", Offset = "0x1609ED0", VA = "0x1609ED0")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1609E4C", Offset = "0x1609E4C", VA = "0x1609E4C")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x160A178", Offset = "0x160A178", VA = "0x160A178", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x160AC3C", Offset = "0x160AC3C", VA = "0x160AC3C", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x160AC40", Offset = "0x160AC40", VA = "0x160AC40", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x160AC44", Offset = "0x160AC44", VA = "0x160AC44", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x160A884", Offset = "0x160A884", VA = "0x160A884")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1606260", Offset = "0x1606260", VA = "0x1606260")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000092")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000E7")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000113")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x400075E")]
				YawPitch,
				[Token(Token = "0x400075F")]
				FromTo
			}

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7120", Offset = "0x8D7120")]
			public Transform target;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7158", Offset = "0x8D7158")]
			public Transform bendGoal;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7190", Offset = "0x8D7190")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7190", Offset = "0x8D7190")]
			public float positionWeight;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D71E4", Offset = "0x8D71E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D71E4", Offset = "0x8D71E4")]
			public float rotationWeight;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7238", Offset = "0x8D7238")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7270", Offset = "0x8D7270")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7270", Offset = "0x8D7270")]
			public float shoulderRotationWeight;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D72C4", Offset = "0x8D72C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D72C4", Offset = "0x8D72C4")]
			public float bendGoalWeight;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7318", Offset = "0x8D7318")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7318", Offset = "0x8D7318")]
			public float swivelOffset;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7374", Offset = "0x8D7374")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D73AC", Offset = "0x8D73AC")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D73E4", Offset = "0x8D73E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D73E4", Offset = "0x8D73E4")]
			public float armLengthMlp;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D743C", Offset = "0x8D743C")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D74B4", Offset = "0x8D74B4")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D74C4", Offset = "0x8D74C4")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000621")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x4000622")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000092")]
			public Vector3 position
			{
				[Token(Token = "0x600068B")]
				[Address(RVA = "0x1612440", Offset = "0x1612440", VA = "0x1612440")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBD40", Offset = "0x8DBD40")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600068C")]
				[Address(RVA = "0x161244C", Offset = "0x161244C", VA = "0x161244C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBD50", Offset = "0x8DBD50")]
				private set
				{
				}
			}

			[Token(Token = "0x17000093")]
			public Quaternion rotation
			{
				[Token(Token = "0x600068D")]
				[Address(RVA = "0x1612458", Offset = "0x1612458", VA = "0x1612458")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBD60", Offset = "0x8DBD60")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600068E")]
				[Address(RVA = "0x1612464", Offset = "0x1612464", VA = "0x1612464")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBD70", Offset = "0x8DBD70")]
				private set
				{
				}
			}

			[Token(Token = "0x17000094")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600068F")]
				[Address(RVA = "0x1612470", Offset = "0x1612470", VA = "0x1612470")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000690")]
				[Address(RVA = "0x16124A4", Offset = "0x16124A4", VA = "0x16124A4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000096")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000691")]
				[Address(RVA = "0x16124DC", Offset = "0x16124DC", VA = "0x16124DC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000097")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000692")]
				[Address(RVA = "0x1612514", Offset = "0x1612514", VA = "0x1612514")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x161254C", Offset = "0x161254C", VA = "0x161254C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x1612CCC", Offset = "0x1612CCC", VA = "0x1612CCC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x1612EC0", Offset = "0x1612EC0", VA = "0x1612EC0", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x1612F6C", Offset = "0x1612F6C", VA = "0x1612F6C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x161076C", Offset = "0x161076C", VA = "0x161076C")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0x1613BB8", Offset = "0x1613BB8", VA = "0x1613BB8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x1613C28", Offset = "0x1613C28", VA = "0x1613C28", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x1613384", Offset = "0x1613384", VA = "0x1613384")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x161345C", Offset = "0x161345C", VA = "0x161345C")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x1613E48", Offset = "0x1613E48", VA = "0x1613E48")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x1612254", Offset = "0x1612254", VA = "0x1612254")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E8")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D74D4", Offset = "0x8D74D4")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D74E4", Offset = "0x8D74E4")]
			private float <mag>k__BackingField;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x17000098")]
			public float sqrMag
			{
				[Token(Token = "0x60006A3")]
				[Address(RVA = "0x1614008", Offset = "0x1614008", VA = "0x1614008")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBD80", Offset = "0x8DBD80")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006A4")]
				[Address(RVA = "0x1614010", Offset = "0x1614010", VA = "0x1614010")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBD90", Offset = "0x8DBD90")]
				private set
				{
				}
			}

			[Token(Token = "0x17000099")]
			public float mag
			{
				[Token(Token = "0x60006A5")]
				[Address(RVA = "0x1614018", Offset = "0x1614018", VA = "0x1614018")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBDA0", Offset = "0x8DBDA0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006A6")]
				[Address(RVA = "0x1614020", Offset = "0x1614020", VA = "0x1614020")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBDB0", Offset = "0x8DBDB0")]
				private set
				{
				}
			}

			[Token(Token = "0x600069E")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index);

			[Token(Token = "0x600069F")]
			public abstract void PreSolve();

			[Token(Token = "0x60006A0")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x60006A1")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x60006A2")]
			public abstract void ResetOffsets();

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x1604A2C", Offset = "0x1604A2C", VA = "0x1604A2C")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x1614028", Offset = "0x1614028", VA = "0x1614028")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x1614194", Offset = "0x1614194", VA = "0x1614194")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x1614240", Offset = "0x1614240", VA = "0x1614240")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x161057C", Offset = "0x161057C", VA = "0x161057C")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x1613A14", Offset = "0x1613A14", VA = "0x1613A14")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x1614294", Offset = "0x1614294", VA = "0x1614294")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x16143D8", Offset = "0x16143D8", VA = "0x16143D8")]
			public void Visualize()
			{
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x1613F70", Offset = "0x1613F70", VA = "0x1613F70")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E9")]
		public class Footstep
		{
			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D7504", Offset = "0x8D7504")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x1700009A")]
			public bool isStepping
			{
				[Token(Token = "0x60006B0")]
				[Address(RVA = "0x1614400", Offset = "0x1614400", VA = "0x1614400")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700009B")]
			public float stepProgress
			{
				[Token(Token = "0x60006B1")]
				[Address(RVA = "0x1614414", Offset = "0x1614414", VA = "0x1614414")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBDC0", Offset = "0x8DBDC0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006B2")]
				[Address(RVA = "0x161441C", Offset = "0x161441C", VA = "0x161441C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBDD0", Offset = "0x8DBDD0")]
				private set
				{
				}
			}

			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x1614424", Offset = "0x1614424", VA = "0x1614424")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x1614554", Offset = "0x1614554", VA = "0x1614554")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x1614684", Offset = "0x1614684", VA = "0x1614684")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x1614784", Offset = "0x1614784", VA = "0x1614784")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x161495C", Offset = "0x161495C", VA = "0x161495C")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x1614B48", Offset = "0x1614B48", VA = "0x1614B48")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EA")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7514", Offset = "0x8D7514")]
			public Transform target;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D754C", Offset = "0x8D754C")]
			public Transform bendGoal;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7584", Offset = "0x8D7584")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7584", Offset = "0x8D7584")]
			public float positionWeight;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D75D8", Offset = "0x8D75D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D75D8", Offset = "0x8D75D8")]
			public float rotationWeight;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D762C", Offset = "0x8D762C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D762C", Offset = "0x8D762C")]
			public float bendGoalWeight;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7680", Offset = "0x8D7680")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7680", Offset = "0x8D7680")]
			public float swivelOffset;

			[NonSerialized]
			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D773C", Offset = "0x8D773C")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D774C", Offset = "0x8D774C")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D775C", Offset = "0x8D775C")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D776C", Offset = "0x8D776C")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Vector3 footPosition;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Quaternion footRotation;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 bendNormal;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x1700009C")]
			public Vector3 position
			{
				[Token(Token = "0x60006B9")]
				[Address(RVA = "0x1614D64", Offset = "0x1614D64", VA = "0x1614D64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBDE0", Offset = "0x8DBDE0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006BA")]
				[Address(RVA = "0x1614D70", Offset = "0x1614D70", VA = "0x1614D70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBDF0", Offset = "0x8DBDF0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009D")]
			public Quaternion rotation
			{
				[Token(Token = "0x60006BB")]
				[Address(RVA = "0x1614D7C", Offset = "0x1614D7C", VA = "0x1614D7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBE00", Offset = "0x8DBE00")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006BC")]
				[Address(RVA = "0x1614D88", Offset = "0x1614D88", VA = "0x1614D88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBE10", Offset = "0x8DBE10")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009E")]
			public bool hasToes
			{
				[Token(Token = "0x60006BD")]
				[Address(RVA = "0x1614D94", Offset = "0x1614D94", VA = "0x1614D94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBE20", Offset = "0x8DBE20")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006BE")]
				[Address(RVA = "0x1614D9C", Offset = "0x1614D9C", VA = "0x1614D9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBE30", Offset = "0x8DBE30")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009F")]
			public VirtualBone thigh
			{
				[Token(Token = "0x60006BF")]
				[Address(RVA = "0x1614DA8", Offset = "0x1614DA8", VA = "0x1614DA8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A0")]
			private VirtualBone calf
			{
				[Token(Token = "0x60006C0")]
				[Address(RVA = "0x1614DDC", Offset = "0x1614DDC", VA = "0x1614DDC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A1")]
			private VirtualBone foot
			{
				[Token(Token = "0x60006C1")]
				[Address(RVA = "0x1614E14", Offset = "0x1614E14", VA = "0x1614E14")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A2")]
			private VirtualBone toes
			{
				[Token(Token = "0x60006C2")]
				[Address(RVA = "0x1614E4C", Offset = "0x1614E4C", VA = "0x1614E4C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x60006C3")]
				[Address(RVA = "0x161053C", Offset = "0x161053C", VA = "0x161053C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A4")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x60006C4")]
				[Address(RVA = "0x1614E84", Offset = "0x1614E84", VA = "0x1614E84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBE40", Offset = "0x8DBE40")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006C5")]
				[Address(RVA = "0x1614E90", Offset = "0x1614E90", VA = "0x1614E90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBE50", Offset = "0x8DBE50")]
				private set
				{
				}
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x1614E9C", Offset = "0x1614E9C", VA = "0x1614E9C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x1615364", Offset = "0x1615364", VA = "0x1615364", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x1615A44", Offset = "0x1615A44", VA = "0x1615A44", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x1615940", Offset = "0x1615940", VA = "0x1615940")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x1615718", Offset = "0x1615718", VA = "0x1615718")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x16046E8", Offset = "0x16046E8", VA = "0x16046E8")]
			public void Solve()
			{
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x1615FE8", Offset = "0x1615FE8", VA = "0x1615FE8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x16160F0", Offset = "0x16160F0", VA = "0x16160F0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x1604C48", Offset = "0x1604C48", VA = "0x1604C48")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EB")]
		public class Locomotion
		{
			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D777C", Offset = "0x8D777C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D777C", Offset = "0x8D777C")]
			public float weight;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D77D0", Offset = "0x8D77D0")]
			public float footDistance;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7808", Offset = "0x8D7808")]
			public float stepThreshold;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7840", Offset = "0x8D7840")]
			public float angleThreshold;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7878", Offset = "0x8D7878")]
			public float comAngleMlp;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D78B0", Offset = "0x8D78B0")]
			public float maxVelocity;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D78E8", Offset = "0x8D78E8")]
			public float velocityFactor;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7920", Offset = "0x8D7920")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7920", Offset = "0x8D7920")]
			public float maxLegStretch;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7978", Offset = "0x8D7978")]
			public float rootSpeed;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D79B0", Offset = "0x8D79B0")]
			public float stepSpeed;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D79E8", Offset = "0x8D79E8")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7A20", Offset = "0x8D7A20")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7A58", Offset = "0x8D7A58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7A58", Offset = "0x8D7A58")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7AB0", Offset = "0x8D7AB0")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7AE8", Offset = "0x8D7AE8")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7B20", Offset = "0x8D7B20")]
			public Vector3 offset;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7B98", Offset = "0x8D7B98")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7BD0", Offset = "0x8D7BD0")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D7C08", Offset = "0x8D7C08")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x170000A5")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x60006CF")]
				[Address(RVA = "0x16161A0", Offset = "0x16161A0", VA = "0x16161A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBE60", Offset = "0x8DBE60")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006D0")]
				[Address(RVA = "0x16161AC", Offset = "0x16161AC", VA = "0x16161AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBE70", Offset = "0x8DBE70")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60006D6")]
				[Address(RVA = "0x16165AC", Offset = "0x16165AC", VA = "0x16165AC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A7")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60006D7")]
				[Address(RVA = "0x16165EC", Offset = "0x16165EC", VA = "0x16165EC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A8")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60006D8")]
				[Address(RVA = "0x1616630", Offset = "0x1616630", VA = "0x1616630")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000A9")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60006D9")]
				[Address(RVA = "0x1616670", Offset = "0x1616670", VA = "0x1616670")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x160ED68", Offset = "0x160ED68", VA = "0x160ED68")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x160CE08", Offset = "0x160CE08", VA = "0x160CE08")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x160C270", Offset = "0x160C270", VA = "0x160C270")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x160C0C0", Offset = "0x160C0C0", VA = "0x160C0C0")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x160F060", Offset = "0x160F060", VA = "0x160F060")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x16161B8", Offset = "0x16161B8", VA = "0x16161B8")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x161635C", Offset = "0x161635C", VA = "0x161635C")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x16163E0", Offset = "0x16163E0", VA = "0x16163E0")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x161235C", Offset = "0x161235C", VA = "0x161235C")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EC")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7C18", Offset = "0x8D7C18")]
			public Transform headTarget;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7C50", Offset = "0x8D7C50")]
			public Transform pelvisTarget;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7C88", Offset = "0x8D7C88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7C88", Offset = "0x8D7C88")]
			public float positionWeight;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7CDC", Offset = "0x8D7CDC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7CDC", Offset = "0x8D7CDC")]
			public float rotationWeight;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7D30", Offset = "0x8D7D30")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7D30", Offset = "0x8D7D30")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7D84", Offset = "0x8D7D84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7D84", Offset = "0x8D7D84")]
			public float pelvisRotationWeight;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7DD8", Offset = "0x8D7DD8")]
			public Transform chestGoal;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7E10", Offset = "0x8D7E10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7E10", Offset = "0x8D7E10")]
			public float chestGoalWeight;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7E64", Offset = "0x8D7E64")]
			public float minHeadHeight;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7E9C", Offset = "0x8D7E9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7E9C", Offset = "0x8D7E9C")]
			public float bodyPosStiffness;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7EF0", Offset = "0x8D7EF0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7EF0", Offset = "0x8D7EF0")]
			public float bodyRotStiffness;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7F44", Offset = "0x8D7F44")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8D7F44", Offset = "0x8D7F44")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7F44", Offset = "0x8D7F44")]
			public float neckStiffness;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7FBC", Offset = "0x8D7FBC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7FBC", Offset = "0x8D7FBC")]
			public float rotateChestByHands;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8010", Offset = "0x8D8010")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8010", Offset = "0x8D8010")]
			public float chestClampWeight;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8064", Offset = "0x8D8064")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8064", Offset = "0x8D8064")]
			public float headClampWeight;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D80B8", Offset = "0x8D80B8")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D80F0", Offset = "0x8D80F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D80F0", Offset = "0x8D80F0")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8144", Offset = "0x8D8144")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8144", Offset = "0x8D8144")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D827C", Offset = "0x8D827C")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private Quaternion headRotation;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private int pelvisIndex;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private int spineIndex;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
			private int chestIndex;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private int neckIndex;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private int headIndex;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private float length;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
			private bool hasChest;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1ED")]
			private bool hasNeck;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private float headHeight;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private float sizeMlp;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private Vector3 chestForward;

			[Token(Token = "0x170000AA")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x60006DE")]
				[Address(RVA = "0x1304CC0", Offset = "0x1304CC0", VA = "0x1304CC0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AB")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x60006DF")]
				[Address(RVA = "0x1304D00", Offset = "0x1304D00", VA = "0x1304D00")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			public VirtualBone chest
			{
				[Token(Token = "0x60006E0")]
				[Address(RVA = "0x1304D40", Offset = "0x1304D40", VA = "0x1304D40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AD")]
			private VirtualBone neck
			{
				[Token(Token = "0x60006E1")]
				[Address(RVA = "0x1304D94", Offset = "0x1304D94", VA = "0x1304D94")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			public VirtualBone head
			{
				[Token(Token = "0x60006E2")]
				[Address(RVA = "0x1304DD4", Offset = "0x1304DD4", VA = "0x1304DD4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x60006E3")]
				[Address(RVA = "0x1304E14", Offset = "0x1304E14", VA = "0x1304E14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBE80", Offset = "0x8DBE80")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006E4")]
				[Address(RVA = "0x1304E28", Offset = "0x1304E28", VA = "0x1304E28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBE90", Offset = "0x8DBE90")]
				private set
				{
				}
			}

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x1304E3C", Offset = "0x1304E3C", VA = "0x1304E3C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x1305934", Offset = "0x1305934", VA = "0x1305934", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x1305B08", Offset = "0x1305B08", VA = "0x1305B08", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x130602C", Offset = "0x130602C", VA = "0x130602C")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x13065E0", Offset = "0x13065E0", VA = "0x13065E0")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x1306F7C", Offset = "0x1306F7C", VA = "0x1306F7C")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x13077A8", Offset = "0x13077A8", VA = "0x13077A8")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x1308534", Offset = "0x1308534", VA = "0x1308534", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x1308710", Offset = "0x1308710", VA = "0x1308710", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x130625C", Offset = "0x130625C", VA = "0x130625C")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x13073D8", Offset = "0x13073D8", VA = "0x13073D8")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x1306B70", Offset = "0x1306B70", VA = "0x1306B70")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x1308808", Offset = "0x1308808", VA = "0x1308808")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x130755C", Offset = "0x130755C", VA = "0x130755C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x1307170", Offset = "0x1307170", VA = "0x1307170")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x1308D1C", Offset = "0x1308D1C", VA = "0x1308D1C")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000ED")]
		public enum PositionOffset
		{
			[Token(Token = "0x400069C")]
			Pelvis,
			[Token(Token = "0x400069D")]
			Chest,
			[Token(Token = "0x400069E")]
			Head,
			[Token(Token = "0x400069F")]
			LeftHand,
			[Token(Token = "0x40006A0")]
			RightHand,
			[Token(Token = "0x40006A1")]
			LeftFoot,
			[Token(Token = "0x40006A2")]
			RightFoot,
			[Token(Token = "0x40006A3")]
			LeftHeel,
			[Token(Token = "0x40006A4")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000EE")]
		public enum RotationOffset
		{
			[Token(Token = "0x40006A6")]
			Pelvis,
			[Token(Token = "0x40006A7")]
			Chest,
			[Token(Token = "0x40006A8")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000EF")]
		public class VirtualBone
		{
			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x1305898", Offset = "0x1305898", VA = "0x1305898")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x1305914", Offset = "0x1305914", VA = "0x1305914")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x1308EBC", Offset = "0x1308EBC", VA = "0x1308EBC")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x130914C", Offset = "0x130914C", VA = "0x130914C")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x1308B34", Offset = "0x1308B34", VA = "0x1308B34")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x1309438", Offset = "0x1309438", VA = "0x1309438")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x1309670", Offset = "0x1309670", VA = "0x1309670")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x13098A4", Offset = "0x13098A4", VA = "0x13098A4")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x1307F88", Offset = "0x1307F88", VA = "0x1307F88")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x130995C", Offset = "0x130995C", VA = "0x130995C")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x1307B48", Offset = "0x1307B48", VA = "0x1307B48")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x1309B74", Offset = "0x1309B74", VA = "0x1309B74")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x1309C7C", Offset = "0x1309C7C", VA = "0x1309C7C")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D56BC", Offset = "0x8D56BC")]
		public bool plantFeet;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D56F4", Offset = "0x8D56F4")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5704", Offset = "0x8D5704")]
		public Spine spine;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D573C", Offset = "0x8D573C")]
		public Arm leftArm;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5774", Offset = "0x8D5774")]
		public Arm rightArm;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D57AC", Offset = "0x8D57AC")]
		public Leg leftLeg;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D57E4", Offset = "0x8D57E4")]
		public Leg rightLeg;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D581C", Offset = "0x8D581C")]
		public Locomotion locomotion;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Leg[] legs;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Arm[] arms;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 headPosition;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastOffset;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 debugPos1;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 debugPos2;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos3;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000051")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x1612098", Offset = "0x1612098", VA = "0x1612098")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAE74", Offset = "0x8DAE74")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x16120A0", Offset = "0x16120A0", VA = "0x16120A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAE84", Offset = "0x8DAE84")]
			private set
			{
			}
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x160AC50", Offset = "0x160AC50", VA = "0x160AC50")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x160B044", Offset = "0x160B044", VA = "0x160B044")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x160AEEC", Offset = "0x160AEEC", VA = "0x160AEEC")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x160BA28", Offset = "0x160BA28", VA = "0x160BA28")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x160BD04", Offset = "0x160BD04", VA = "0x160BD04")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x160BDA8", Offset = "0x160BDA8", VA = "0x160BDA8")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x160BF3C", Offset = "0x160BF3C", VA = "0x160BF3C")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x160C648", Offset = "0x160C648", VA = "0x160C648")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x160D07C", Offset = "0x160D07C", VA = "0x160D07C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x160D1F0", Offset = "0x160D1F0", VA = "0x160D1F0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x160D38C", Offset = "0x160D38C", VA = "0x160D38C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x160D400", Offset = "0x160D400", VA = "0x160D400", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x160D474", Offset = "0x160D474", VA = "0x160D474", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x160D688", Offset = "0x160D688", VA = "0x160D688")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x160B2DC", Offset = "0x160B2DC", VA = "0x160B2DC")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x160B4B4", Offset = "0x160B4B4", VA = "0x160B4B4")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x160B904", Offset = "0x160B904", VA = "0x160B904")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x160C7A8", Offset = "0x160C7A8", VA = "0x160C7A8")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x160D968", Offset = "0x160D968", VA = "0x160D968", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x160D9A0", Offset = "0x160D9A0", VA = "0x160D9A0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x160EAF4", Offset = "0x160EAF4", VA = "0x160EAF4")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x160C910", Offset = "0x160C910", VA = "0x160C910")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x160DA00", Offset = "0x160DA00", VA = "0x160DA00")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x160ECDC", Offset = "0x160ECDC", VA = "0x160ECDC")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x160ED24", Offset = "0x160ED24", VA = "0x160ED24")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x160E9AC", Offset = "0x160E9AC", VA = "0x160E9AC")]
		private void Write()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x1611A98", Offset = "0x1611A98", VA = "0x1611A98")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x16120A8", Offset = "0x16120A8", VA = "0x16120A8")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5854", Offset = "0x8D5854")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5854", Offset = "0x8D5854")]
		public float weight;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D58A8", Offset = "0x8D58A8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D58A8", Offset = "0x8D58A8")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D58FC", Offset = "0x8D58FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D58FC", Offset = "0x8D58FC")]
		public float twistAngleOffset;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 axis;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform parent;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform child;

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x19BE24C", Offset = "0x19BE24C", VA = "0x19BE24C")]
		public void Relax()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x19BE62C", Offset = "0x19BE62C", VA = "0x19BE62C")]
		private void Start()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x19BEA48", Offset = "0x19BEA48", VA = "0x19BEA48")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x19BEAD0", Offset = "0x19BEAD0", VA = "0x19BEAD0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x19BEB58", Offset = "0x19BEB58", VA = "0x19BEB58")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x19BEC5C", Offset = "0x19BEC5C", VA = "0x19BEC5C")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000094")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D5958", Offset = "0x8D5958")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D5968", Offset = "0x8D5968")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D5978", Offset = "0x8D5978")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x17000052")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x130A5A0", Offset = "0x130A5A0", VA = "0x130A5A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAE94", Offset = "0x8DAE94")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x130A5A8", Offset = "0x130A5A8", VA = "0x130A5A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAEA4", Offset = "0x8DAEA4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public bool isPaused
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x130A5B0", Offset = "0x130A5B0", VA = "0x130A5B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAEB4", Offset = "0x8DAEB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x130A5B8", Offset = "0x130A5B8", VA = "0x130A5B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAEC4", Offset = "0x8DAEC4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x130A5C4", Offset = "0x130A5C4", VA = "0x130A5C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAED4", Offset = "0x8DAED4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x130A5CC", Offset = "0x130A5CC", VA = "0x130A5CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAEE4", Offset = "0x8DAEE4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public bool inInteraction
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x130A5D4", Offset = "0x130A5D4", VA = "0x130A5D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		public float progress
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x130CE94", Offset = "0x130CE94", VA = "0x130CE94")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x130A644", Offset = "0x130A644", VA = "0x130A644")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x130A6C8", Offset = "0x130A6C8", VA = "0x130A6C8")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x130A76C", Offset = "0x130A76C", VA = "0x130A76C")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x130A8AC", Offset = "0x130A8AC", VA = "0x130A8AC")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x130ACB0", Offset = "0x130ACB0", VA = "0x130ACB0")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x130B070", Offset = "0x130B070", VA = "0x130B070")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x130B0C4", Offset = "0x130B0C4", VA = "0x130B0C4")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x130BC04", Offset = "0x130BC04", VA = "0x130BC04")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x130C6E4", Offset = "0x130C6E4", VA = "0x130C6E4")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x130C90C", Offset = "0x130C90C", VA = "0x130C90C")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x130CD40", Offset = "0x130CD40", VA = "0x130CD40")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x130D37C", Offset = "0x130D37C", VA = "0x130D37C")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000095")]
	public class InteractionLookAt
	{
		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5988", Offset = "0x8D5988")]
		public LookAtIK ik;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D59C0", Offset = "0x8D59C0")]
		public float lerpSpeed;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D59F8", Offset = "0x8D59F8")]
		public float weightSpeed;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x130D5E0", Offset = "0x130D5E0", VA = "0x130D5E0")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x130D758", Offset = "0x130D758", VA = "0x130D758")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x130D800", Offset = "0x130D800", VA = "0x130D800")]
		public void Update()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x130DA44", Offset = "0x130DA44", VA = "0x130DA44")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x130DB3C", Offset = "0x130DB3C", VA = "0x130DB3C")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x130DC08", Offset = "0x130DC08", VA = "0x130DC08")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D25D0", Offset = "0x8D25D0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D25D0", Offset = "0x8D25D0")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F0")]
		public class InteractionEvent
		{
			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D828C", Offset = "0x8D828C")]
			public float time;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D82C4", Offset = "0x8D82C4")]
			public bool pause;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D82FC", Offset = "0x8D82FC")]
			public bool pickUp;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8334", Offset = "0x8D8334")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D836C", Offset = "0x8D836C")]
			public Message[] messages;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D83A4", Offset = "0x8D83A4")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x130CED0", Offset = "0x130CED0", VA = "0x130CED0")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x130EEA8", Offset = "0x130EEA8", VA = "0x130EEA8")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F1")]
		public class Message
		{
			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D83DC", Offset = "0x8D83DC")]
			public string function;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8414", Offset = "0x8D8414")]
			public GameObject recipient;

			[Token(Token = "0x40006B8")]
			private const string empty = "";

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x130EDB8", Offset = "0x130EDB8", VA = "0x130EDB8")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x130EEB0", Offset = "0x130EEB0", VA = "0x130EEB0")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F2")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D844C", Offset = "0x8D844C")]
			public Animator animator;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8484", Offset = "0x8D8484")]
			public Animation animation;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D84BC", Offset = "0x8D84BC")]
			public string animationState;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D84F4", Offset = "0x8D84F4")]
			public float crossfadeTime;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D852C", Offset = "0x8D852C")]
			public int layer;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8564", Offset = "0x8D8564")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40006BF")]
			private const string empty = "";

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x130EB18", Offset = "0x130EB18", VA = "0x130EB18")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x130EC0C", Offset = "0x130EC0C", VA = "0x130EC0C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000708")]
			[Address(RVA = "0x130ECC4", Offset = "0x130ECC4", VA = "0x130ECC4")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x130EDA4", Offset = "0x130EDA4", VA = "0x130EDA4")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F3")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x2000114")]
			public enum Type
			{
				[Token(Token = "0x4000761")]
				PositionWeight,
				[Token(Token = "0x4000762")]
				RotationWeight,
				[Token(Token = "0x4000763")]
				PositionOffsetX,
				[Token(Token = "0x4000764")]
				PositionOffsetY,
				[Token(Token = "0x4000765")]
				PositionOffsetZ,
				[Token(Token = "0x4000766")]
				Pull,
				[Token(Token = "0x4000767")]
				Reach,
				[Token(Token = "0x4000768")]
				RotateBoneWeight,
				[Token(Token = "0x4000769")]
				Push,
				[Token(Token = "0x400076A")]
				PushParent,
				[Token(Token = "0x400076B")]
				PoserWeight
			}

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D859C", Offset = "0x8D859C")]
			public Type type;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D85D4", Offset = "0x8D85D4")]
			public AnimationCurve curve;

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x130E314", Offset = "0x130E314", VA = "0x130E314")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x130EEC8", Offset = "0x130EEC8", VA = "0x130EEC8")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F4")]
		public class Multiplier
		{
			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D860C", Offset = "0x8D860C")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8644", Offset = "0x8D8644")]
			public float multiplier;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D867C", Offset = "0x8D867C")]
			public WeightCurve.Type result;

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x130E978", Offset = "0x130E978", VA = "0x130E978")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x130EEB8", Offset = "0x130EEB8", VA = "0x130EEB8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5A40", Offset = "0x8D5A40")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5A78", Offset = "0x8D5A78")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5AB0", Offset = "0x8D5AB0")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D5AE8", Offset = "0x8D5AE8")]
		private float <length>k__BackingField;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D5AF8", Offset = "0x8D5AF8")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000057")]
		public float length
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x130DDE4", Offset = "0x130DDE4", VA = "0x130DDE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DB044", Offset = "0x8DB044")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x130DDEC", Offset = "0x130DDEC", VA = "0x130DDEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DB054", Offset = "0x8DB054")]
			private set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x130DDF4", Offset = "0x130DDF4", VA = "0x130DDF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DB064", Offset = "0x8DB064")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x130DDFC", Offset = "0x130DDFC", VA = "0x130DDFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DB074", Offset = "0x8DB074")]
			private set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x130E018", Offset = "0x130E018", VA = "0x130E018")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x130D250", Offset = "0x130D250", VA = "0x130D250")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x130DC1C", Offset = "0x130DC1C", VA = "0x130DC1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DAEF4", Offset = "0x8DAEF4")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x130DC68", Offset = "0x130DC68", VA = "0x130DC68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DAF2C", Offset = "0x8DAF2C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x130DCB4", Offset = "0x130DCB4", VA = "0x130DCB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DAF64", Offset = "0x8DAF64")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x130DD00", Offset = "0x130DD00", VA = "0x130DD00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DAF9C", Offset = "0x8DAF9C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x130DD4C", Offset = "0x130DD4C", VA = "0x130DD4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DAFD4", Offset = "0x8DAFD4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x130DD98", Offset = "0x130DD98", VA = "0x130DD98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB00C", Offset = "0x8DB00C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x130DE04", Offset = "0x130DE04", VA = "0x130DE04")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x130E0A8", Offset = "0x130E0A8", VA = "0x130E0A8")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x130B62C", Offset = "0x130B62C", VA = "0x130B62C")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x130E22C", Offset = "0x130E22C", VA = "0x130E22C")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x130B4E0", Offset = "0x130B4E0", VA = "0x130B4E0")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x130B624", Offset = "0x130B624", VA = "0x130B624")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x130C2C8", Offset = "0x130C2C8", VA = "0x130C2C8")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x130CB18", Offset = "0x130CB18", VA = "0x130CB18")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x130E9B4", Offset = "0x130E9B4", VA = "0x130E9B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x130E330", Offset = "0x130E330", VA = "0x130E330")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x130E234", Offset = "0x130E234", VA = "0x130E234")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x130E910", Offset = "0x130E910", VA = "0x130E910")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x130E9B8", Offset = "0x130E9B8", VA = "0x130E9B8")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x130EA20", Offset = "0x130EA20", VA = "0x130EA20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB084", Offset = "0x8DB084")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x130EA6C", Offset = "0x130EA6C", VA = "0x130EA6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB0BC", Offset = "0x8DB0BC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x130EAB8", Offset = "0x130EAB8", VA = "0x130EAB8")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D2630", Offset = "0x8D2630")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D2630", Offset = "0x8D2630")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000F5")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000F6")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5B08", Offset = "0x8D5B08")]
		public string targetTag;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5B40", Offset = "0x8D5B40")]
		public float fadeInTime;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5B78", Offset = "0x8D5B78")]
		public float speed;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5BB0", Offset = "0x8D5BB0")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D5BE8", Offset = "0x8D5BE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5BE8", Offset = "0x8D5BE8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8D5BE8", Offset = "0x8D5BE8")]
		public Collider characterCollider;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5C6C", Offset = "0x8D5C6C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8D5C6C", Offset = "0x8D5C6C")]
		public Transform FPSCamera;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5CCC", Offset = "0x8D5CCC")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5D04", Offset = "0x8D5D04")]
		public float camRaycastDistance;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D5D3C", Offset = "0x8D5D3C")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8D5D4C", Offset = "0x8D5D4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5D4C", Offset = "0x8D5D4C")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5DAC", Offset = "0x8D5DAC")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x1700005B")]
		public bool inInteraction
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x130F098", Offset = "0x130F098", VA = "0x130F098")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x1310CB0", Offset = "0x1310CB0", VA = "0x1310CB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x1310CB8", Offset = "0x1310CB8", VA = "0x1310CB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x1310CC0", Offset = "0x1310CC0", VA = "0x1310CC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DB244", Offset = "0x8DB244")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x1310CC8", Offset = "0x1310CC8", VA = "0x1310CC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DB254", Offset = "0x8DB254")]
			private set
			{
			}
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x130EED0", Offset = "0x130EED0", VA = "0x130EED0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB0F4", Offset = "0x8DB0F4")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x130EF1C", Offset = "0x130EF1C", VA = "0x130EF1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB12C", Offset = "0x8DB12C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x130EF68", Offset = "0x130EF68", VA = "0x130EF68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB164", Offset = "0x8DB164")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x130EFB4", Offset = "0x130EFB4", VA = "0x130EFB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB19C", Offset = "0x8DB19C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x130F000", Offset = "0x130F000", VA = "0x130F000")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB1D4", Offset = "0x8DB1D4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x130F04C", Offset = "0x130F04C", VA = "0x130F04C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB20C", Offset = "0x8DB20C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x130F228", Offset = "0x130F228", VA = "0x130F228")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x130F2F4", Offset = "0x130F2F4", VA = "0x130F2F4")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x130F3C0", Offset = "0x130F3C0", VA = "0x130F3C0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x130F46C", Offset = "0x130F46C", VA = "0x130F46C")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x130F564", Offset = "0x130F564", VA = "0x130F564")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x130F680", Offset = "0x130F680", VA = "0x130F680")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x130F710", Offset = "0x130F710", VA = "0x130F710")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x130F7A0", Offset = "0x130F7A0", VA = "0x130F7A0")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x130F830", Offset = "0x130F830", VA = "0x130F830")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x130F8A4", Offset = "0x130F8A4", VA = "0x130F8A4")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x130F918", Offset = "0x130F918", VA = "0x130F918")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x130F980", Offset = "0x130F980", VA = "0x130F980")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x130FA0C", Offset = "0x130FA0C", VA = "0x130FA0C")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x130FAC0", Offset = "0x130FAC0", VA = "0x130FAC0")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x130FBA4", Offset = "0x130FBA4", VA = "0x130FBA4")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x130FE48", Offset = "0x130FE48", VA = "0x130FE48")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1310020", Offset = "0x1310020", VA = "0x1310020")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1310294", Offset = "0x1310294", VA = "0x1310294")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1310588", Offset = "0x1310588", VA = "0x1310588")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x13105CC", Offset = "0x13105CC", VA = "0x13105CC")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1310644", Offset = "0x1310644", VA = "0x1310644")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1310764", Offset = "0x1310764", VA = "0x1310764")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x13108DC", Offset = "0x13108DC", VA = "0x13108DC")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1310B84", Offset = "0x1310B84", VA = "0x1310B84")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1310394", Offset = "0x1310394", VA = "0x1310394")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1310CD0", Offset = "0x1310CD0", VA = "0x1310CD0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1311384", Offset = "0x1311384", VA = "0x1311384")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x13113A4", Offset = "0x13113A4", VA = "0x13113A4")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x13113C0", Offset = "0x13113C0", VA = "0x13113C0")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x13113DC", Offset = "0x13113DC", VA = "0x13113DC")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x131143C", Offset = "0x131143C", VA = "0x131143C")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1311558", Offset = "0x1311558", VA = "0x1311558")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1311654", Offset = "0x1311654", VA = "0x1311654")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x13119B4", Offset = "0x13119B4", VA = "0x13119B4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1311AA0", Offset = "0x1311AA0", VA = "0x1311AA0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1311CEC", Offset = "0x1311CEC", VA = "0x1311CEC")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x13110FC", Offset = "0x13110FC", VA = "0x13110FC")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1311E2C", Offset = "0x1311E2C", VA = "0x1311E2C")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1311F58", Offset = "0x1311F58", VA = "0x1311F58")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1312014", Offset = "0x1312014", VA = "0x1312014")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1312110", Offset = "0x1312110", VA = "0x1312110")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1312128", Offset = "0x1312128", VA = "0x1312128")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x130F144", Offset = "0x130F144", VA = "0x130F144")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x130FD44", Offset = "0x130FD44", VA = "0x130FD44")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1312418", Offset = "0x1312418", VA = "0x1312418")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB264", Offset = "0x8DB264")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1312464", Offset = "0x1312464", VA = "0x1312464")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB29C", Offset = "0x8DB29C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x13124B0", Offset = "0x13124B0", VA = "0x13124B0")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D2690", Offset = "0x8D2690")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D2690", Offset = "0x8D2690")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F7")]
		public class Multiplier
		{
			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D86B4", Offset = "0x8D86B4")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D86EC", Offset = "0x8D86EC")]
			public float multiplier;

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x1312C50", Offset = "0x1312C50", VA = "0x1312C50")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5DE4", Offset = "0x8D5DE4")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5E1C", Offset = "0x8D5E1C")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5E54", Offset = "0x8D5E54")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5E8C", Offset = "0x8D5E8C")]
		public Transform pivot;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5EC4", Offset = "0x8D5EC4")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5EFC", Offset = "0x8D5EFC")]
		public float twistWeight;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5F34", Offset = "0x8D5F34")]
		public float swingWeight;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5F6C", Offset = "0x8D5F6C")]
		public bool rotateOnce;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1312964", Offset = "0x1312964", VA = "0x1312964")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB2D4", Offset = "0x8DB2D4")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x13129B0", Offset = "0x13129B0", VA = "0x13129B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB30C", Offset = "0x8DB30C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x13129FC", Offset = "0x13129FC", VA = "0x13129FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB344", Offset = "0x8DB344")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1312A48", Offset = "0x1312A48", VA = "0x1312A48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB37C", Offset = "0x8DB37C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1312A94", Offset = "0x1312A94", VA = "0x1312A94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB3B4", Offset = "0x8DB3B4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1312AE0", Offset = "0x1312AE0", VA = "0x1312AE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB3EC", Offset = "0x8DB3EC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x130E2A4", Offset = "0x130E2A4", VA = "0x130E2A4")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x130D2E0", Offset = "0x130D2E0", VA = "0x130D2E0")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x130B6E0", Offset = "0x130B6E0", VA = "0x130B6E0")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1312B2C", Offset = "0x1312B2C", VA = "0x1312B2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB424", Offset = "0x8DB424")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1312B78", Offset = "0x1312B78", VA = "0x1312B78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB45C", Offset = "0x8DB45C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1312BC4", Offset = "0x1312BC4", VA = "0x1312BC4")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D26F0", Offset = "0x8D26F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D26F0", Offset = "0x8D26F0")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F8")]
		public class CharacterPosition
		{
			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8724", Offset = "0x8D8724")]
			public bool use;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D875C", Offset = "0x8D875C")]
			public Vector2 offset;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8794", Offset = "0x8D8794")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8794", Offset = "0x8D8794")]
			public float angleOffset;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D87F0", Offset = "0x8D87F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D87F0", Offset = "0x8D87F0")]
			public float maxAngle;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8848", Offset = "0x8D8848")]
			public float radius;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8880", Offset = "0x8D8880")]
			public bool orbit;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D88B8", Offset = "0x8D88B8")]
			public bool fixYAxis;

			[Token(Token = "0x170000B0")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000717")]
				[Address(RVA = "0x13133D8", Offset = "0x13133D8", VA = "0x13133D8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B1")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000718")]
				[Address(RVA = "0x1313414", Offset = "0x1313414", VA = "0x1313414")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000719")]
			[Address(RVA = "0x131350C", Offset = "0x131350C", VA = "0x131350C")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600071A")]
			[Address(RVA = "0x1313B88", Offset = "0x1313B88", VA = "0x1313B88")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F9")]
		public class CameraPosition
		{
			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D88F0", Offset = "0x8D88F0")]
			public Collider lookAtTarget;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8928", Offset = "0x8D8928")]
			public Vector3 direction;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8960", Offset = "0x8D8960")]
			public float maxDistance;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8998", Offset = "0x8D8998")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8998", Offset = "0x8D8998")]
			public float maxAngle;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D89F0", Offset = "0x8D89F0")]
			public bool fixYAxis;

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x1312EC4", Offset = "0x1312EC4", VA = "0x1312EC4")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x131306C", Offset = "0x131306C", VA = "0x131306C")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x131334C", Offset = "0x131334C", VA = "0x131334C")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FA")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x2000115")]
			public class Interaction
			{
				[Token(Token = "0x400076C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D989C", Offset = "0x8D989C")]
				public InteractionObject interactionObject;

				[Token(Token = "0x400076D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D98D4", Offset = "0x8D98D4")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000784")]
				[Address(RVA = "0x1313BAC", Offset = "0x1313BAC", VA = "0x1313BAC")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8A98", Offset = "0x8D8A98")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8AD0", Offset = "0x8D8AD0")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8B08", Offset = "0x8D8B08")]
			public Interaction[] interactions;

			[Token(Token = "0x600071E")]
			[Address(RVA = "0x1312D40", Offset = "0x1312D40", VA = "0x1312D40")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0x1313B9C", Offset = "0x1313B9C", VA = "0x1313B9C")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5FA4", Offset = "0x8D5FA4")]
		public Range[] ranges;

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1312C58", Offset = "0x1312C58", VA = "0x1312C58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB494", Offset = "0x8DB494")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1312CA4", Offset = "0x1312CA4", VA = "0x1312CA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB4CC", Offset = "0x8DB4CC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1312CF0", Offset = "0x1312CF0", VA = "0x1312CF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB504", Offset = "0x8DB504")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1312D3C", Offset = "0x1312D3C", VA = "0x1312D3C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x13117F8", Offset = "0x13117F8", VA = "0x13117F8")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1312E64", Offset = "0x1312E64", VA = "0x1312E64")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000FB")]
		public class Map
		{
			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000720")]
			[Address(RVA = "0x110F708", Offset = "0x110F708", VA = "0x110F708")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000721")]
			[Address(RVA = "0x110FB0C", Offset = "0x110FB0C", VA = "0x110FB0C")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x110FAC0", Offset = "0x110FAC0", VA = "0x110FAC0")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x110F8B8", Offset = "0x110F8B8", VA = "0x110F8B8")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x110F420", Offset = "0x110F420", VA = "0x110F420", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB53C", Offset = "0x8DB53C")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x110F7AC", Offset = "0x110F7AC", VA = "0x110F7AC", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x110F7B0", Offset = "0x110F7B0", VA = "0x110F7B0", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x110FA58", Offset = "0x110FA58", VA = "0x110FA58", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x110F744", Offset = "0x110F744", VA = "0x110F744")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x110F668", Offset = "0x110F668", VA = "0x110F668")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x110FB5C", Offset = "0x110FB5C", VA = "0x110FB5C")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _poseRoot;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] children;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x15B49A8", Offset = "0x15B49A8", VA = "0x15B49A8", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x15B4A60", Offset = "0x15B4A60", VA = "0x15B4A60", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x15B4C18", Offset = "0x15B4C18", VA = "0x15B4C18", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x15B4D14", Offset = "0x15B4D14", VA = "0x15B4D14", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x15B4ABC", Offset = "0x15B4ABC", VA = "0x15B4ABC")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x15B50C4", Offset = "0x15B50C4", VA = "0x15B50C4")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5FDC", Offset = "0x8D5FDC")]
		public float weight;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5FF4", Offset = "0x8D5FF4")]
		public float localRotationWeight;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D600C", Offset = "0x8D600C")]
		public float localPositionWeight;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x600052F")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000530")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000531")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000532")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1315290", Offset = "0x1315290", VA = "0x1315290", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x13152E4", Offset = "0x13152E4", VA = "0x13152E4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1315320", Offset = "0x1315320", VA = "0x1315320", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1315338", Offset = "0x1315338", VA = "0x1315338")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8D2750", Offset = "0x8D2750")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000FC")]
		public class Rigidbone
		{
			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000724")]
			[Address(RVA = "0x13158BC", Offset = "0x13158BC", VA = "0x13158BC")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x13164C8", Offset = "0x13164C8", VA = "0x13164C8")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000726")]
			[Address(RVA = "0x13162AC", Offset = "0x13162AC", VA = "0x13162AC")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000FD")]
		public class Child
		{
			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000727")]
			[Address(RVA = "0x1315A18", Offset = "0x1315A18", VA = "0x1315A18")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x1316664", Offset = "0x1316664", VA = "0x1316664")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0x1316614", Offset = "0x1316614", VA = "0x1316614")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000FE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2984", Offset = "0x8D2984")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000B2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600072D")]
				[Address(RVA = "0x1316C44", Offset = "0x1316C44", VA = "0x1316C44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600072F")]
				[Address(RVA = "0x1316CAC", Offset = "0x1316CAC", VA = "0x1316CAC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x1315A78", Offset = "0x1315A78", VA = "0x1315A78")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x13169FC", Offset = "0x13169FC", VA = "0x13169FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x1316A00", Offset = "0x1316A00", VA = "0x1316A00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x1316C4C", Offset = "0x1316C4C", VA = "0x1316C4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6024", Offset = "0x8D6024")]
		public IK ik;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D605C", Offset = "0x8D605C")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6094", Offset = "0x8D6094")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D60CC", Offset = "0x8D60CC")]
		public float applyVelocity;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6104", Offset = "0x8D6104")]
		public float applyAngularVelocity;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x1700005E")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x1315380", Offset = "0x1315380", VA = "0x1315380")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		private bool ikUsed
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x1315E64", Offset = "0x1315E64", VA = "0x1315E64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1315348", Offset = "0x1315348", VA = "0x1315348")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x13153F8", Offset = "0x13153F8", VA = "0x13153F8")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1315528", Offset = "0x1315528", VA = "0x1315528")]
		public void Start()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x13154B8", Offset = "0x13154B8", VA = "0x13154B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8DB574", Offset = "0x8DB574")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1315AA4", Offset = "0x1315AA4", VA = "0x1315AA4")]
		private void Update()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1315CF0", Offset = "0x1315CF0", VA = "0x1315CF0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1315DA8", Offset = "0x1315DA8", VA = "0x1315DA8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1315FE8", Offset = "0x1315FE8", VA = "0x1315FE8")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1315E28", Offset = "0x1315E28", VA = "0x1315E28")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1315FA4", Offset = "0x1315FA4", VA = "0x1315FA4")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1316084", Offset = "0x1316084", VA = "0x1316084")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x131601C", Offset = "0x131601C", VA = "0x131601C")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1315450", Offset = "0x1315450", VA = "0x1315450")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1315D30", Offset = "0x1315D30", VA = "0x1315D30")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x131682C", Offset = "0x131682C", VA = "0x131682C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1316930", Offset = "0x1316930", VA = "0x1316930")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000060")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x1318514", Offset = "0x1318514", VA = "0x1318514")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000061")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x1318550", Offset = "0x1318550", VA = "0x1318550")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x131819C", Offset = "0x131819C", VA = "0x131819C")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x13181E0", Offset = "0x13181E0", VA = "0x13181E0")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x131846C", Offset = "0x131846C", VA = "0x131846C")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x13184DC", Offset = "0x13184DC", VA = "0x13184DC")]
		public void Disable()
		{
		}

		[Token(Token = "0x600054F")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x131837C", Offset = "0x131837C", VA = "0x131837C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1318620", Offset = "0x1318620", VA = "0x1318620")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1318624", Offset = "0x1318624", VA = "0x1318624")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1318658", Offset = "0x1318658", VA = "0x1318658")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x131873C", Offset = "0x131873C", VA = "0x131873C")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x13189B8", Offset = "0x13189B8", VA = "0x13189B8")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1318A74", Offset = "0x1318A74", VA = "0x1318A74")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D27B4", Offset = "0x8D27B4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D27B4", Offset = "0x8D27B4")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D614C", Offset = "0x8D614C")]
		public float limit;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D6168", Offset = "0x8D6168")]
		public float twistLimit;

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1318AEC", Offset = "0x1318AEC", VA = "0x1318AEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB5D8", Offset = "0x8DB5D8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1318B38", Offset = "0x1318B38", VA = "0x1318B38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB610", Offset = "0x8DB610")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1318B84", Offset = "0x1318B84", VA = "0x1318B84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB648", Offset = "0x8DB648")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1318BD0", Offset = "0x1318BD0", VA = "0x1318BD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB680", Offset = "0x8DB680")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1318C1C", Offset = "0x1318C1C", VA = "0x1318C1C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1318CD4", Offset = "0x1318CD4", VA = "0x1318CD4")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1318F1C", Offset = "0x1318F1C", VA = "0x1318F1C")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D2814", Offset = "0x8D2814")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D2814", Offset = "0x8D2814")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1318F2C", Offset = "0x1318F2C", VA = "0x1318F2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB6B8", Offset = "0x8DB6B8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1318F78", Offset = "0x1318F78", VA = "0x1318F78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB6F0", Offset = "0x8DB6F0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1318FC4", Offset = "0x1318FC4", VA = "0x1318FC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB728", Offset = "0x8DB728")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1319010", Offset = "0x1319010", VA = "0x1319010")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB760", Offset = "0x8DB760")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x131905C", Offset = "0x131905C", VA = "0x131905C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1319084", Offset = "0x1319084", VA = "0x1319084")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1319384", Offset = "0x1319384", VA = "0x1319384")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D2874", Offset = "0x8D2874")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D2874", Offset = "0x8D2874")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000FF")]
		public class ReachCone
		{
			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000B4")]
			public Vector3 o
			{
				[Token(Token = "0x6000730")]
				[Address(RVA = "0x131B32C", Offset = "0x131B32C", VA = "0x131B32C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B5")]
			public Vector3 a
			{
				[Token(Token = "0x6000731")]
				[Address(RVA = "0x131B364", Offset = "0x131B364", VA = "0x131B364")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B6")]
			public Vector3 b
			{
				[Token(Token = "0x6000732")]
				[Address(RVA = "0x131B3A0", Offset = "0x131B3A0", VA = "0x131B3A0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B7")]
			public Vector3 c
			{
				[Token(Token = "0x6000733")]
				[Address(RVA = "0x131B3DC", Offset = "0x131B3DC", VA = "0x131B3DC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B8")]
			public bool isValid
			{
				[Token(Token = "0x6000735")]
				[Address(RVA = "0x131A490", Offset = "0x131A490", VA = "0x131A490")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x131AADC", Offset = "0x131AADC", VA = "0x131AADC")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x131AC3C", Offset = "0x131AC3C", VA = "0x131AC3C")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000100")]
		public class LimitPoint
		{
			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x131A4A0", Offset = "0x131A4A0", VA = "0x131A4A0")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D6194", Offset = "0x8D6194")]
		public float twistLimit;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D61B0", Offset = "0x8D61B0")]
		public int smoothIterations;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x131940C", Offset = "0x131940C", VA = "0x131940C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB798", Offset = "0x8DB798")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1319458", Offset = "0x1319458", VA = "0x1319458")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB7D0", Offset = "0x8DB7D0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x13194A4", Offset = "0x13194A4", VA = "0x13194A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB808", Offset = "0x8DB808")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x13194F0", Offset = "0x13194F0", VA = "0x13194F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB840", Offset = "0x8DB840")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x131953C", Offset = "0x131953C", VA = "0x131953C")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1319A24", Offset = "0x1319A24", VA = "0x1319A24", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1319B1C", Offset = "0x1319B1C", VA = "0x1319B1C")]
		private void Start()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x131A0DC", Offset = "0x131A0DC", VA = "0x131A0DC")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x13195DC", Offset = "0x13195DC", VA = "0x13195DC")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x131A524", Offset = "0x131A524", VA = "0x131A524")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x131ADFC", Offset = "0x131ADFC", VA = "0x131ADFC")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x131AE40", Offset = "0x131AE40", VA = "0x131AE40")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x131AF88", Offset = "0x131AF88", VA = "0x131AF88")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1319DA0", Offset = "0x1319DA0", VA = "0x1319DA0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x131B118", Offset = "0x131B118", VA = "0x131B118")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x131B2C8", Offset = "0x131B2C8", VA = "0x131B2C8")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D28D4", Offset = "0x8D28D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D28D4", Offset = "0x8D28D4")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D6270", Offset = "0x8D6270")]
		public float twistLimit;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x131B418", Offset = "0x131B418", VA = "0x131B418")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB878", Offset = "0x8DB878")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x131B464", Offset = "0x131B464", VA = "0x131B464")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB8B0", Offset = "0x8DB8B0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x131B4B0", Offset = "0x131B4B0", VA = "0x131B4B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB8E8", Offset = "0x8DB8E8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x131B4FC", Offset = "0x131B4FC", VA = "0x131B4FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DB920", Offset = "0x8DB920")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x131B548", Offset = "0x131B548", VA = "0x131B548")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x131B564", Offset = "0x131B564", VA = "0x131B564", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x131B61C", Offset = "0x131B61C", VA = "0x131B61C")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x131B948", Offset = "0x131B948", VA = "0x131B948")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D62C4", Offset = "0x8D62C4")]
		public AimIK ik;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D62FC", Offset = "0x8D62FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D62FC", Offset = "0x8D62FC")]
		public float weight;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D6350", Offset = "0x8D6350")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6350", Offset = "0x8D6350")]
		public Transform target;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D63B0", Offset = "0x8D63B0")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D63E8", Offset = "0x8D63E8")]
		public float weightSmoothTime;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D6420", Offset = "0x8D6420")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6420", Offset = "0x8D6420")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6480", Offset = "0x8D6480")]
		public float maxRadiansDelta;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D64B8", Offset = "0x8D64B8")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D64F0", Offset = "0x8D64F0")]
		public float slerpSpeed;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6528", Offset = "0x8D6528")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6560", Offset = "0x8D6560")]
		public float minDistance;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6598", Offset = "0x8D6598")]
		public Vector3 offset;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D65D0", Offset = "0x8D65D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D65D0", Offset = "0x8D65D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D65D0", Offset = "0x8D65D0")]
		public float maxRootAngle;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D664C", Offset = "0x8D664C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D664C", Offset = "0x8D664C")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D66AC", Offset = "0x8D66AC")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform lastTarget;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float switchWeight;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float switchWeightV;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float weightV;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 dir;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x17000062")]
		private Vector3 pivot
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x1102E30", Offset = "0x1102E30", VA = "0x1102E30")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1102D34", Offset = "0x1102D34", VA = "0x1102D34")]
		private void Start()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1102F7C", Offset = "0x1102F7C", VA = "0x1102F7C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1103698", Offset = "0x1103698", VA = "0x1103698")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1103834", Offset = "0x1103834", VA = "0x1103834")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1103B50", Offset = "0x1103B50", VA = "0x1103B50")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000101")]
		public class Pose
		{
			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000738")]
			[Address(RVA = "0x1103E00", Offset = "0x1103E00", VA = "0x1103E00")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000739")]
			[Address(RVA = "0x1104100", Offset = "0x1104100", VA = "0x1104100")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0x1104108", Offset = "0x1104108", VA = "0x1104108")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x10FF0B0", Offset = "0x10FF0B0", VA = "0x10FF0B0")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x10FF18C", Offset = "0x10FF18C", VA = "0x10FF18C")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1104098", Offset = "0x1104098", VA = "0x1104098")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000102")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000116")]
			public class EffectorLink
			{
				[Token(Token = "0x400076E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D990C", Offset = "0x8D990C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400076F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9944", Offset = "0x8D9944")]
				public float weight;

				[Token(Token = "0x6000785")]
				[Address(RVA = "0x11046F8", Offset = "0x11046F8", VA = "0x11046F8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8B40", Offset = "0x8D8B40")]
			public Transform transform;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8B78", Offset = "0x8D8B78")]
			public Transform relativeTo;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8BB0", Offset = "0x8D8BB0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8BE8", Offset = "0x8D8BE8")]
			public float verticalWeight;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8C20", Offset = "0x8D8C20")]
			public float horizontalWeight;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8C58", Offset = "0x8D8C58")]
			public float speed;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x600073B")]
			[Address(RVA = "0x1104264", Offset = "0x1104264", VA = "0x1104264")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x600073C")]
			[Address(RVA = "0x11046D0", Offset = "0x11046D0", VA = "0x11046D0")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0x11046E0", Offset = "0x11046E0", VA = "0x11046E0")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D66E4", Offset = "0x8D66E4")]
		public Body[] bodies;

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1104124", Offset = "0x1104124", VA = "0x1104124", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x11046C8", Offset = "0x11046C8", VA = "0x11046C8")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D671C", Offset = "0x8D671C")]
		public float tiltSpeed;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6754", Offset = "0x8D6754")]
		public float tiltSensitivity;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D678C", Offset = "0x8D678C")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D67C4", Offset = "0x8D67C4")]
		public OffsetPose poseRight;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1105A6C", Offset = "0x1105A6C", VA = "0x1105A6C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1105AB4", Offset = "0x1105AB4", VA = "0x1105AB4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1105CE4", Offset = "0x1105CE4", VA = "0x1105CE4")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000103")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8C90", Offset = "0x8D8C90")]
			public string name;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8CC8", Offset = "0x8D8CC8")]
			public Collider collider;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8D00", Offset = "0x8D8D00")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D8D4C", Offset = "0x8D8D4C")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D8D5C", Offset = "0x8D8D5C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D8D6C", Offset = "0x8D8D6C")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D8D7C", Offset = "0x8D8D7C")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000B9")]
			public bool inProgress
			{
				[Token(Token = "0x600073E")]
				[Address(RVA = "0x15B5188", Offset = "0x15B5188", VA = "0x15B5188")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000BA")]
			protected float crossFader
			{
				[Token(Token = "0x600073F")]
				[Address(RVA = "0x15B5730", Offset = "0x15B5730", VA = "0x15B5730")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBEF0", Offset = "0x8DBEF0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000740")]
				[Address(RVA = "0x15B5738", Offset = "0x15B5738", VA = "0x15B5738")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBF00", Offset = "0x8DBF00")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BB")]
			protected float timer
			{
				[Token(Token = "0x6000741")]
				[Address(RVA = "0x15B5740", Offset = "0x15B5740", VA = "0x15B5740")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBF10", Offset = "0x8DBF10")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000742")]
				[Address(RVA = "0x15B5748", Offset = "0x15B5748", VA = "0x15B5748")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBF20", Offset = "0x8DBF20")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BC")]
			protected Vector3 force
			{
				[Token(Token = "0x6000743")]
				[Address(RVA = "0x15B5750", Offset = "0x15B5750", VA = "0x15B5750")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBF30", Offset = "0x8DBF30")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000744")]
				[Address(RVA = "0x15B575C", Offset = "0x15B575C", VA = "0x15B575C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBF40", Offset = "0x8DBF40")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BD")]
			protected Vector3 point
			{
				[Token(Token = "0x6000745")]
				[Address(RVA = "0x15B5768", Offset = "0x15B5768", VA = "0x15B5768")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBF50", Offset = "0x8DBF50")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000746")]
				[Address(RVA = "0x15B5774", Offset = "0x15B5774", VA = "0x15B5774")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBF60", Offset = "0x8DBF60")]
				private set
				{
				}
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0x15B55FC", Offset = "0x15B55FC", VA = "0x15B55FC")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000748")]
			[Address(RVA = "0x15B5270", Offset = "0x15B5270", VA = "0x15B5270")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000749")]
			protected abstract float GetLength();

			[Token(Token = "0x600074A")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600074B")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x600074C")]
			[Address(RVA = "0x15B5780", Offset = "0x15B5780", VA = "0x15B5780")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000104")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000117")]
			public class EffectorLink
			{
				[Token(Token = "0x4000770")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D997C", Offset = "0x8D997C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000771")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D99B4", Offset = "0x8D99B4")]
				public float weight;

				[Token(Token = "0x4000772")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000773")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000786")]
				[Address(RVA = "0x15B60EC", Offset = "0x15B60EC", VA = "0x15B60EC")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000787")]
				[Address(RVA = "0x15B5EE0", Offset = "0x15B5EE0", VA = "0x15B5EE0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000788")]
				[Address(RVA = "0x15B6228", Offset = "0x15B6228", VA = "0x15B6228")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8D8C", Offset = "0x8D8D8C")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8DC4", Offset = "0x8D8DC4")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8DFC", Offset = "0x8D8DFC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600074D")]
			[Address(RVA = "0x15B5CFC", Offset = "0x15B5CFC", VA = "0x15B5CFC", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0x15B5E74", Offset = "0x15B5E74", VA = "0x15B5E74", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0x15B5EF4", Offset = "0x15B5EF4", VA = "0x15B5EF4", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000750")]
			[Address(RVA = "0x15B6214", Offset = "0x15B6214", VA = "0x15B6214")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000105")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000118")]
			public class BoneLink
			{
				[Token(Token = "0x4000774")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D99EC", Offset = "0x8D99EC")]
				public Transform bone;

				[Token(Token = "0x4000775")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9A24", Offset = "0x8D9A24")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D9A24", Offset = "0x8D9A24")]
				public float weight;

				[Token(Token = "0x4000776")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000777")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000789")]
				[Address(RVA = "0x15B5B04", Offset = "0x15B5B04", VA = "0x15B5B04")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600078A")]
				[Address(RVA = "0x15B589C", Offset = "0x15B589C", VA = "0x15B589C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600078B")]
				[Address(RVA = "0x15B5C74", Offset = "0x15B5C74", VA = "0x15B5C74")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8E34", Offset = "0x8D8E34")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8E6C", Offset = "0x8D8E6C")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000751")]
			[Address(RVA = "0x15B5794", Offset = "0x15B5794", VA = "0x15B5794", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000752")]
			[Address(RVA = "0x15B5838", Offset = "0x15B5838", VA = "0x15B5838", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000753")]
			[Address(RVA = "0x15B58A8", Offset = "0x15B58A8", VA = "0x15B58A8", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0x15B5C60", Offset = "0x15B5C60", VA = "0x15B5C60")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D67FC", Offset = "0x8D67FC")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6834", Offset = "0x8D6834")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x17000063")]
		public bool inProgress
		{
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x15B50CC", Offset = "0x15B50CC", VA = "0x15B50CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x15B519C", Offset = "0x15B519C", VA = "0x15B519C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x15B53BC", Offset = "0x15B53BC", VA = "0x15B53BC")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x15B5728", Offset = "0x15B5728", VA = "0x15B5728")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x2000106")]
		public abstract class Offset
		{
			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8EA4", Offset = "0x8D8EA4")]
			public string name;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8EDC", Offset = "0x8D8EDC")]
			public Collider collider;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8F14", Offset = "0x8D8F14")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D8F60", Offset = "0x8D8F60")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D8F70", Offset = "0x8D8F70")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D8F80", Offset = "0x8D8F80")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D8F90", Offset = "0x8D8F90")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000BE")]
			protected float crossFader
			{
				[Token(Token = "0x6000755")]
				[Address(RVA = "0x15B67E0", Offset = "0x15B67E0", VA = "0x15B67E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBF70", Offset = "0x8DBF70")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000756")]
				[Address(RVA = "0x15B67E8", Offset = "0x15B67E8", VA = "0x15B67E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBF80", Offset = "0x8DBF80")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BF")]
			protected float timer
			{
				[Token(Token = "0x6000757")]
				[Address(RVA = "0x15B67F0", Offset = "0x15B67F0", VA = "0x15B67F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBF90", Offset = "0x8DBF90")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000758")]
				[Address(RVA = "0x15B67F8", Offset = "0x15B67F8", VA = "0x15B67F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBFA0", Offset = "0x8DBFA0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C0")]
			protected Vector3 force
			{
				[Token(Token = "0x6000759")]
				[Address(RVA = "0x15B6800", Offset = "0x15B6800", VA = "0x15B6800")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBFB0", Offset = "0x8DBFB0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600075A")]
				[Address(RVA = "0x15B680C", Offset = "0x15B680C", VA = "0x15B680C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBFC0", Offset = "0x8DBFC0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C1")]
			protected Vector3 point
			{
				[Token(Token = "0x600075B")]
				[Address(RVA = "0x15B6818", Offset = "0x15B6818", VA = "0x15B6818")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBFD0", Offset = "0x8DBFD0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600075C")]
				[Address(RVA = "0x15B6824", Offset = "0x15B6824", VA = "0x15B6824")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DBFE0", Offset = "0x8DBFE0")]
				private set
				{
				}
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0x15B6698", Offset = "0x15B6698", VA = "0x15B6698")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x15B62FC", Offset = "0x15B62FC", VA = "0x15B62FC")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600075F")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000760")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000761")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000762")]
			[Address(RVA = "0x15B6830", Offset = "0x15B6830", VA = "0x15B6830")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000107")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000119")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000778")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9A78", Offset = "0x8D9A78")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000779")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9AB0", Offset = "0x8D9AB0")]
				public float weight;

				[Token(Token = "0x400077A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400077B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600078C")]
				[Address(RVA = "0x15B6CEC", Offset = "0x15B6CEC", VA = "0x15B6CEC")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600078D")]
				[Address(RVA = "0x15B6AA8", Offset = "0x15B6AA8", VA = "0x15B6AA8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600078E")]
				[Address(RVA = "0x15B6E08", Offset = "0x15B6E08", VA = "0x15B6E08")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8FA0", Offset = "0x8D8FA0")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8FD8", Offset = "0x8D8FD8")]
			public int upDirCurveIndex;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9010", Offset = "0x8D9010")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000763")]
			[Address(RVA = "0x15B6844", Offset = "0x15B6844", VA = "0x15B6844", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0x15B6A3C", Offset = "0x15B6A3C", VA = "0x15B6A3C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000765")]
			[Address(RVA = "0x15B6ABC", Offset = "0x15B6ABC", VA = "0x15B6ABC", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0x15B6DEC", Offset = "0x15B6DEC", VA = "0x15B6DEC")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000108")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x200011A")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x400077C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9AE8", Offset = "0x8D9AE8")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x400077D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9B20", Offset = "0x8D9B20")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D9B20", Offset = "0x8D9B20")]
				public float weight;

				[Token(Token = "0x400077E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x400077F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x600078F")]
				[Address(RVA = "0x15B7270", Offset = "0x15B7270", VA = "0x15B7270")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000790")]
				[Address(RVA = "0x15B6F58", Offset = "0x15B6F58", VA = "0x15B6F58")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000791")]
				[Address(RVA = "0x15B73AC", Offset = "0x15B73AC", VA = "0x15B73AC")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9048", Offset = "0x8D9048")]
			public int curveIndex;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9080", Offset = "0x8D9080")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000767")]
			[Address(RVA = "0x15B6E10", Offset = "0x15B6E10", VA = "0x15B6E10", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0x15B6EF4", Offset = "0x15B6EF4", VA = "0x15B6EF4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000769")]
			[Address(RVA = "0x15B6F64", Offset = "0x15B6F64", VA = "0x15B6F64", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0x15B7398", Offset = "0x15B7398", VA = "0x15B7398")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D686C", Offset = "0x8D686C")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D68A4", Offset = "0x8D68A4")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x15B6230", Offset = "0x15B6230", VA = "0x15B6230", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x15B6450", Offset = "0x15B6450", VA = "0x15B6450")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x15B67D8", Offset = "0x15B67D8", VA = "0x15B67D8")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000109")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x200011B")]
			public class EffectorLink
			{
				[Token(Token = "0x4000780")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9B74", Offset = "0x8D9B74")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000781")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9BAC", Offset = "0x8D9BAC")]
				public float weight;

				[Token(Token = "0x6000792")]
				[Address(RVA = "0x130A598", Offset = "0x130A598", VA = "0x130A598")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D90B8", Offset = "0x8D90B8")]
			public Transform transform;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D90F0", Offset = "0x8D90F0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9128", Offset = "0x8D9128")]
			public float speed;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9160", Offset = "0x8D9160")]
			public float acceleration;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9198", Offset = "0x8D9198")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D9198", Offset = "0x8D9198")]
			public float matchVelocity;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D91EC", Offset = "0x8D91EC")]
			public float gravity;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x1309F68", Offset = "0x1309F68", VA = "0x1309F68")]
			public void Reset()
			{
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0x130A128", Offset = "0x130A128", VA = "0x130A128")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600076D")]
			[Address(RVA = "0x130A57C", Offset = "0x130A57C", VA = "0x130A57C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D68DC", Offset = "0x8D68DC")]
		public Body[] bodies;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6914", Offset = "0x8D6914")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1309EF0", Offset = "0x1309EF0", VA = "0x1309EF0")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x130A044", Offset = "0x130A044", VA = "0x130A044", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x130A55C", Offset = "0x130A55C", VA = "0x130A55C")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010A")]
		public class OffsetLimits
		{
			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9224", Offset = "0x8D9224")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D925C", Offset = "0x8D925C")]
			public float spring;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9294", Offset = "0x8D9294")]
			public bool x;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D92CC", Offset = "0x8D92CC")]
			public bool y;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9304", Offset = "0x8D9304")]
			public bool z;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D933C", Offset = "0x8D933C")]
			public float minX;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9374", Offset = "0x8D9374")]
			public float maxX;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D93AC", Offset = "0x8D93AC")]
			public float minY;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D93E4", Offset = "0x8D93E4")]
			public float maxY;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D941C", Offset = "0x8D941C")]
			public float minZ;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9454", Offset = "0x8D9454")]
			public float maxZ;

			[Token(Token = "0x600076E")]
			[Address(RVA = "0x13142A8", Offset = "0x13142A8", VA = "0x13142A8")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600076F")]
			[Address(RVA = "0x13147B0", Offset = "0x13147B0", VA = "0x13147B0")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000770")]
			[Address(RVA = "0x13147E0", Offset = "0x13147E0", VA = "0x13147E0")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0x13148B8", Offset = "0x13148B8", VA = "0x13148B8")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2994", Offset = "0x8D2994")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000C2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000775")]
				[Address(RVA = "0x1314740", Offset = "0x1314740", VA = "0x1314740", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000777")]
				[Address(RVA = "0x13147A8", Offset = "0x13147A8", VA = "0x13147A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x1314170", Offset = "0x1314170", VA = "0x1314170")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x1314600", Offset = "0x1314600", VA = "0x1314600", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x1314604", Offset = "0x1314604", VA = "0x1314604", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x1314748", Offset = "0x1314748", VA = "0x1314748", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D694C", Offset = "0x8D694C")]
		public float weight;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6984", Offset = "0x8D6984")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x17000064")]
		protected float deltaTime
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x130A0FC", Offset = "0x130A0FC", VA = "0x130A0FC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000596")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x13140D4", Offset = "0x13140D4", VA = "0x13140D4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1314100", Offset = "0x1314100", VA = "0x1314100")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8DB958", Offset = "0x8DB958")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x131419C", Offset = "0x131419C", VA = "0x131419C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x130A4A0", Offset = "0x130A4A0", VA = "0x130A4A0")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1314508", Offset = "0x1314508", VA = "0x1314508", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x130A56C", Offset = "0x130A56C", VA = "0x130A56C")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D29A4", Offset = "0x8D29A4")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000C4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600077B")]
				[Address(RVA = "0x1314D08", Offset = "0x1314D08", VA = "0x1314D08", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600077D")]
				[Address(RVA = "0x1314D70", Offset = "0x1314D70", VA = "0x1314D70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0x1314988", Offset = "0x1314988", VA = "0x1314988")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0x1314BC8", Offset = "0x1314BC8", VA = "0x1314BC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600077A")]
			[Address(RVA = "0x1314BCC", Offset = "0x1314BCC", VA = "0x1314BCC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600077C")]
			[Address(RVA = "0x1314D10", Offset = "0x1314D10", VA = "0x1314D10", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D69BC", Offset = "0x8D69BC")]
		public float weight;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D69F4", Offset = "0x8D69F4")]
		public VRIK ik;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x17000065")]
		protected float deltaTime
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x13148C0", Offset = "0x13148C0", VA = "0x13148C0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600059E")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x13148EC", Offset = "0x13148EC", VA = "0x13148EC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1314918", Offset = "0x1314918", VA = "0x1314918")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8DB9BC", Offset = "0x8DB9BC")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x13149B4", Offset = "0x13149B4", VA = "0x13149B4")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1314AC0", Offset = "0x1314AC0", VA = "0x1314AC0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1314BB8", Offset = "0x1314BB8", VA = "0x1314BB8")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010D")]
		public class EffectorLink
		{
			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x600077E")]
			[Address(RVA = "0x1314E38", Offset = "0x1314E38", VA = "0x1314E38")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x600077F")]
			[Address(RVA = "0x1315288", Offset = "0x1315288", VA = "0x1315288")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1314D78", Offset = "0x1314D78", VA = "0x1314D78")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1315170", Offset = "0x1315170", VA = "0x1315170")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1315228", Offset = "0x1315228", VA = "0x1315228")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200010E")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x200011C")]
			public class EffectorLink
			{
				[Token(Token = "0x4000782")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9BE4", Offset = "0x8D9BE4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000783")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9C1C", Offset = "0x8D9C1C")]
				public float weight;

				[Token(Token = "0x6000793")]
				[Address(RVA = "0x1318194", Offset = "0x1318194", VA = "0x1318194")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D948C", Offset = "0x8D948C")]
			public Vector3 offset;

			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D94C4", Offset = "0x8D94C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D94C4", Offset = "0x8D94C4")]
			public float additivity;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9518", Offset = "0x8D9518")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9550", Offset = "0x8D9550")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000780")]
			[Address(RVA = "0x1316EDC", Offset = "0x1316EDC", VA = "0x1316EDC")]
			public void Start()
			{
			}

			[Token(Token = "0x6000781")]
			[Address(RVA = "0x1317A6C", Offset = "0x1317A6C", VA = "0x1317A6C")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000782")]
			[Address(RVA = "0x1318180", Offset = "0x1318180", VA = "0x1318180")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010F")]
		public enum Handedness
		{
			[Token(Token = "0x4000749")]
			Right,
			[Token(Token = "0x400074A")]
			Left
		}

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6A2C", Offset = "0x8D6A2C")]
		public AimIK aimIK;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6A64", Offset = "0x8D6A64")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6A9C", Offset = "0x8D6A9C")]
		public Handedness handedness;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6AD4", Offset = "0x8D6AD4")]
		public bool twoHanded;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6B0C", Offset = "0x8D6B0C")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6B44", Offset = "0x8D6B44")]
		public float magnitudeRandom;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6B7C", Offset = "0x8D6B7C")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6BB4", Offset = "0x8D6BB4")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6BEC", Offset = "0x8D6BEC")]
		public float blendTime;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8D6C24", Offset = "0x8D6C24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6C24", Offset = "0x8D6C24")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x17000066")]
		public bool isFinished
		{
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x1316CB4", Offset = "0x1316CB4", VA = "0x1316CB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x1317D20", Offset = "0x1317D20", VA = "0x1317D20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x1317D60", Offset = "0x1317D60", VA = "0x1317D60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		private Transform primaryHand
		{
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x1317CE0", Offset = "0x1317CE0", VA = "0x1317CE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x1317D00", Offset = "0x1317D00", VA = "0x1317D00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1316CE4", Offset = "0x1316CE4", VA = "0x1316CE4")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1316D10", Offset = "0x1316D10", VA = "0x1316D10")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1316F8C", Offset = "0x1316F8C", VA = "0x1316F8C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1317DA0", Offset = "0x1317DA0", VA = "0x1317DA0")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1317EF8", Offset = "0x1317EF8", VA = "0x1317EF8")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1317F34", Offset = "0x1317F34", VA = "0x1317F34", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x13180CC", Offset = "0x13180CC", VA = "0x13180CC")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6C84", Offset = "0x8D6C84")]
		public float weight;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6CBC", Offset = "0x8D6CBC")]
		public float offset;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x131B954", Offset = "0x131B954", VA = "0x131B954")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x131BA28", Offset = "0x131BA28", VA = "0x131BA28")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x131BB14", Offset = "0x131BB14", VA = "0x131BB14")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x131BF5C", Offset = "0x131BF5C", VA = "0x131BF5C")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x131BF94", Offset = "0x131BF94", VA = "0x131BF94")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x131C08C", Offset = "0x131C08C", VA = "0x131C08C")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x2000110")]
		public class Settings
		{
			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9588", Offset = "0x8D9588")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D95C0", Offset = "0x8D95C0")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D95F8", Offset = "0x8D95F8")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9630", Offset = "0x8D9630")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9668", Offset = "0x8D9668")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D96A0", Offset = "0x8D96A0")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D96D8", Offset = "0x8D96D8")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9710", Offset = "0x8D9710")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8D9748", Offset = "0x8D9748")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9748", Offset = "0x8D9748")]
			public Vector3 headOffset;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9798", Offset = "0x8D9798")]
			public Vector3 handOffset;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D97D0", Offset = "0x8D97D0")]
			public float footForwardOffset;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9808", Offset = "0x8D9808")]
			public float footInwardOffset;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9840", Offset = "0x8D9840")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D9840", Offset = "0x8D9840")]
			public float footHeadingOffset;

			[Token(Token = "0x6000783")]
			[Address(RVA = "0x19C19EC", Offset = "0x19C19EC", VA = "0x19C19EC")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x19BFF04", Offset = "0x19BFF04", VA = "0x19BFF04")]
		public static void Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x19C10EC", Offset = "0x19C10EC", VA = "0x19C10EC")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvisTarget;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftFootTarget;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightFootTarget;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 pelvisTargetRight;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x19C1AD4", Offset = "0x19C1AD4", VA = "0x19C1AD4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x19C18AC", Offset = "0x19C18AC", VA = "0x19C18AC")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x19C1BA8", Offset = "0x19C1BA8", VA = "0x19C1BA8")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x19C1F94", Offset = "0x19C1F94", VA = "0x19C1F94")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x19C208C", Offset = "0x19C208C", VA = "0x19C208C")]
		public VRIKRootController()
		{
		}
	}
}
