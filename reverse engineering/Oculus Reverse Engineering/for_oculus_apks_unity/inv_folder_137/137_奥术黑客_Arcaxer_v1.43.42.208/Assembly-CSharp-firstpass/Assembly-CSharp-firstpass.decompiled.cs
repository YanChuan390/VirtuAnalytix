using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Serialization;
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
		[Address(RVA = "0xBF371C", Offset = "0xBF371C", VA = "0xBF371C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0xBF396C", Offset = "0xBF396C", VA = "0xBF396C")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0xBF3AE8", Offset = "0xBF3AE8", VA = "0xBF3AE8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xBF3B58", Offset = "0xBF3B58", VA = "0xBF3B58", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xBF3C24", Offset = "0xBF3C24", VA = "0xBF3C24", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xBF3C88", Offset = "0xBF3C88", VA = "0xBF3C88")]
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
		[Address(RVA = "0xBF3CEC", Offset = "0xBF3CEC", VA = "0xBF3CEC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xBF3CF0", Offset = "0xBF3CF0", VA = "0xBF3CF0")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xBF3DB8", Offset = "0xBF3DB8", VA = "0xBF3DB8")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xBF3E80", Offset = "0xBF3E80", VA = "0xBF3E80")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xBF3F48", Offset = "0xBF3F48", VA = "0xBF3F48")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xBF4010", Offset = "0xBF4010", VA = "0xBF4010")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xBF40D8", Offset = "0xBF40D8", VA = "0xBF40D8")]
		public void Update()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xBF40DC", Offset = "0xBF40DC", VA = "0xBF40DC")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x2000005")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x400000C")]
			Hardware,
			[Token(Token = "0x400000D")]
			Touch
		}

		[Token(Token = "0x2000006")]
		public class VirtualAxis
		{
			[Token(Token = "0x400000F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x17000002")]
			public string name
			{
				[Token(Token = "0x6000028")]
				[Address(RVA = "0xBF4E64", Offset = "0xBF4E64", VA = "0xBF4E64")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000029")]
				[Address(RVA = "0xBF4E6C", Offset = "0xBF4E6C", VA = "0xBF4E6C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000003")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x600002A")]
				[Address(RVA = "0xBF4E74", Offset = "0xBF4E74", VA = "0xBF4E74")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600002B")]
				[Address(RVA = "0xBF4E7C", Offset = "0xBF4E7C", VA = "0xBF4E7C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000004")]
			public float GetValue
			{
				[Token(Token = "0x6000030")]
				[Address(RVA = "0xBF4EC4", Offset = "0xBF4EC4", VA = "0xBF4EC4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000005")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000031")]
				[Address(RVA = "0xBF4ECC", Offset = "0xBF4ECC", VA = "0xBF4ECC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600002C")]
			[Address(RVA = "0xBF386C", Offset = "0xBF386C", VA = "0xBF386C")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x600002D")]
			[Address(RVA = "0xBF4E88", Offset = "0xBF4E88", VA = "0xBF4E88")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x600002E")]
			[Address(RVA = "0xBF3B00", Offset = "0xBF3B00", VA = "0xBF3B00")]
			public void Remove()
			{
			}

			[Token(Token = "0x600002F")]
			[Address(RVA = "0xBF4EBC", Offset = "0xBF4EBC", VA = "0xBF4EBC")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000007")]
		public class VirtualButton
		{
			[Token(Token = "0x4000013")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x4000014")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x4000015")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x17000006")]
			public string name
			{
				[Token(Token = "0x6000032")]
				[Address(RVA = "0xBF4ED4", Offset = "0xBF4ED4", VA = "0xBF4ED4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000033")]
				[Address(RVA = "0xBF4EDC", Offset = "0xBF4EDC", VA = "0xBF4EDC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000007")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000034")]
				[Address(RVA = "0xBF4EE4", Offset = "0xBF4EE4", VA = "0xBF4EE4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000035")]
				[Address(RVA = "0xBF4EEC", Offset = "0xBF4EEC", VA = "0xBF4EEC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000008")]
			public bool GetButton
			{
				[Token(Token = "0x600003B")]
				[Address(RVA = "0xBF5010", Offset = "0xBF5010", VA = "0xBF5010")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000009")]
			public bool GetButtonDown
			{
				[Token(Token = "0x600003C")]
				[Address(RVA = "0xBF5018", Offset = "0xBF5018", VA = "0xBF5018")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700000A")]
			public bool GetButtonUp
			{
				[Token(Token = "0x600003D")]
				[Address(RVA = "0xBF503C", Offset = "0xBF503C", VA = "0xBF503C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000036")]
			[Address(RVA = "0xBF4EF8", Offset = "0xBF4EF8", VA = "0xBF4EF8")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x6000037")]
			[Address(RVA = "0xBF4F30", Offset = "0xBF4F30", VA = "0xBF4F30")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000038")]
			[Address(RVA = "0xBF4F6C", Offset = "0xBF4F6C", VA = "0xBF4F6C")]
			public void Pressed()
			{
			}

			[Token(Token = "0x6000039")]
			[Address(RVA = "0xBF4F98", Offset = "0xBF4F98", VA = "0xBF4F98")]
			public void Released()
			{
			}

			[Token(Token = "0x600003A")]
			[Address(RVA = "0xBF4FB8", Offset = "0xBF4FB8", VA = "0xBF4FB8")]
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
			[Address(RVA = "0xBF4C90", Offset = "0xBF4C90", VA = "0xBF4C90")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xBF40E4", Offset = "0xBF40E4", VA = "0xBF40E4")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xBF4198", Offset = "0xBF4198", VA = "0xBF4198")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xBF3804", Offset = "0xBF3804", VA = "0xBF3804")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xBF4280", Offset = "0xBF4280", VA = "0xBF4280")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xBF389C", Offset = "0xBF389C", VA = "0xBF389C")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xBF44C8", Offset = "0xBF44C8", VA = "0xBF44C8")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xBF46B8", Offset = "0xBF46B8", VA = "0xBF46B8")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xBF4800", Offset = "0xBF4800", VA = "0xBF4800")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xBF3904", Offset = "0xBF3904", VA = "0xBF3904")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xBF498C", Offset = "0xBF498C", VA = "0xBF498C")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xBF4A64", Offset = "0xBF4A64", VA = "0xBF4A64")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xBF49E4", Offset = "0xBF49E4", VA = "0xBF49E4")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xBF4ABC", Offset = "0xBF4ABC", VA = "0xBF4ABC")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xBF4B2C", Offset = "0xBF4B2C", VA = "0xBF4B2C")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xBF4B9C", Offset = "0xBF4B9C", VA = "0xBF4B9C")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xBF3D48", Offset = "0xBF3D48", VA = "0xBF3D48")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xBF3E10", Offset = "0xBF3E10", VA = "0xBF3E10")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xBF3ED8", Offset = "0xBF3ED8", VA = "0xBF3ED8")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xBF4068", Offset = "0xBF4068", VA = "0xBF4068")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xBF3FA0", Offset = "0xBF3FA0", VA = "0xBF3FA0")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xBF4C0C", Offset = "0xBF4C0C", VA = "0xBF4C0C")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xBF4CFC", Offset = "0xBF4CFC", VA = "0xBF4CFC")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xBF4D74", Offset = "0xBF4D74", VA = "0xBF4D74")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xBF4DEC", Offset = "0xBF4DEC", VA = "0xBF4DEC")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xBF5060", Offset = "0xBF5060", VA = "0xBF5060")]
		private void Update()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xBF5064", Offset = "0xBF5064", VA = "0xBF5064")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xBF50D4", Offset = "0xBF50D4", VA = "0xBF50D4")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x200000A")]
		public enum AxisOption
		{
			[Token(Token = "0x4000021")]
			Both,
			[Token(Token = "0x4000022")]
			OnlyHorizontal,
			[Token(Token = "0x4000023")]
			OnlyVertical
		}

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xBF50DC", Offset = "0xBF50DC", VA = "0xBF50DC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xBF5234", Offset = "0xBF5234", VA = "0xBF5234")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xBF5110", Offset = "0xBF5110", VA = "0xBF5110")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xBF5294", Offset = "0xBF5294", VA = "0xBF5294", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xBF53E0", Offset = "0xBF53E0", VA = "0xBF53E0", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xBF541C", Offset = "0xBF541C", VA = "0xBF541C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xBF5420", Offset = "0xBF5420", VA = "0xBF5420")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xBF5460", Offset = "0xBF5460", VA = "0xBF5460")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x200000B")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x6000049")]
		[Address(RVA = "0xBF54DC", Offset = "0xBF54DC", VA = "0xBF54DC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xBF54E4", Offset = "0xBF54E4", VA = "0xBF54E4")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xBF54EC", Offset = "0xBF54EC", VA = "0xBF54EC")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xBF57E4", Offset = "0xBF57E4", VA = "0xBF57E4")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x200000D")]
		public enum AxisOptions
		{
			[Token(Token = "0x400002A")]
			ForwardAxis,
			[Token(Token = "0x400002B")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x200000E")]
		public class AxisMapping
		{
			[Token(Token = "0x200000F")]
			public enum MappingType
			{
				[Token(Token = "0x400002F")]
				NamedAxis,
				[Token(Token = "0x4000030")]
				MousePositionX,
				[Token(Token = "0x4000031")]
				MousePositionY,
				[Token(Token = "0x4000032")]
				MousePositionZ
			}

			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x6000051")]
			[Address(RVA = "0xBF5B24", Offset = "0xBF5B24", VA = "0xBF5B24")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xBF57EC", Offset = "0xBF57EC", VA = "0xBF57EC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xBF58AC", Offset = "0xBF58AC", VA = "0xBF58AC")]
		private void Update()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xBF5AFC", Offset = "0xBF5AFC", VA = "0xBF5AFC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xBF5B14", Offset = "0xBF5B14", VA = "0xBF5B14")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000010")]
	[RequireComponent(typeof(Image))]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000011")]
		public enum AxisOption
		{
			[Token(Token = "0x4000046")]
			Both,
			[Token(Token = "0x4000047")]
			OnlyHorizontal,
			[Token(Token = "0x4000048")]
			OnlyVertical
		}

		[Token(Token = "0x2000012")]
		public enum ControlStyle
		{
			[Token(Token = "0x400004A")]
			Absolute,
			[Token(Token = "0x400004B")]
			Relative,
			[Token(Token = "0x400004C")]
			Swipe
		}

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xBF5B2C", Offset = "0xBF5B2C", VA = "0xBF5B2C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xBF5BA8", Offset = "0xBF5BA8", VA = "0xBF5BA8")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xBF5CCC", Offset = "0xBF5CCC", VA = "0xBF5CCC")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xBF5DCC", Offset = "0xBF5DCC", VA = "0xBF5DCC", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xBF5E04", Offset = "0xBF5E04", VA = "0xBF5E04")]
		private void Update()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xBF5FDC", Offset = "0xBF5FDC", VA = "0xBF5FDC", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xBF603C", Offset = "0xBF603C", VA = "0xBF603C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xBF60FC", Offset = "0xBF60FC", VA = "0xBF60FC")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x1700000B")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xBF6180", Offset = "0xBF6180", VA = "0xBF6180")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0xBF618C", Offset = "0xBF618C", VA = "0xBF618C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xBF4228", Offset = "0xBF4228", VA = "0xBF4228")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xBF42E8", Offset = "0xBF42E8", VA = "0xBF42E8")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xBF4340", Offset = "0xBF4340", VA = "0xBF4340")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xBF4530", Offset = "0xBF4530", VA = "0xBF4530")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xBF4770", Offset = "0xBF4770", VA = "0xBF4770")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xBF4868", Offset = "0xBF4868", VA = "0xBF4868")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xBF48F8", Offset = "0xBF48F8", VA = "0xBF48F8")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xBF4D6C", Offset = "0xBF4D6C", VA = "0xBF4D6C")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xBF4DE4", Offset = "0xBF4DE4", VA = "0xBF4DE4")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xBF4E5C", Offset = "0xBF4E5C", VA = "0xBF4E5C")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x6000066")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x6000067")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x6000068")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x6000069")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x600006A")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x600006B")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x600006C")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x600006D")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x600006E")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x600006F")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x6000070")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xBF6198", Offset = "0xBF6198", VA = "0xBF6198")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x2000014")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0xBF629C", Offset = "0xBF629C", VA = "0xBF629C")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xBF6334", Offset = "0xBF6334", VA = "0xBF6334")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xBF63C4", Offset = "0xBF63C4", VA = "0xBF63C4", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xBF645C", Offset = "0xBF645C", VA = "0xBF645C", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xBF6510", Offset = "0xBF6510", VA = "0xBF6510", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xBF65B8", Offset = "0xBF65B8", VA = "0xBF65B8", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xBF6654", Offset = "0xBF6654", VA = "0xBF6654", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xBF66F0", Offset = "0xBF66F0", VA = "0xBF66F0", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xBF6788", Offset = "0xBF6788", VA = "0xBF6788", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xBF682C", Offset = "0xBF682C", VA = "0xBF682C", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xBF68D8", Offset = "0xBF68D8", VA = "0xBF68D8", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xBF6984", Offset = "0xBF6984", VA = "0xBF6984", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xBF6A1C", Offset = "0xBF6A1C", VA = "0xBF6A1C", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xBF4190", Offset = "0xBF4190", VA = "0xBF4190")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000080")]
		[Address(RVA = "0xBF6A28", Offset = "0xBF6A28", VA = "0xBF6A28", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xBF6A3C", Offset = "0xBF6A3C", VA = "0xBF6A3C", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xBF6A48", Offset = "0xBF6A48", VA = "0xBF6A48", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xBF6A54", Offset = "0xBF6A54", VA = "0xBF6A54", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xBF6A60", Offset = "0xBF6A60", VA = "0xBF6A60", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xBF6AB0", Offset = "0xBF6AB0", VA = "0xBF6AB0", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xBF6B00", Offset = "0xBF6B00", VA = "0xBF6B00", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xBF6B50", Offset = "0xBF6B50", VA = "0xBF6B50", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xBF6BA0", Offset = "0xBF6BA0", VA = "0xBF6BA0", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xBF6BF0", Offset = "0xBF6BF0", VA = "0xBF6BF0", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xBF6C40", Offset = "0xBF6C40", VA = "0xBF6C40", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xBF4194", Offset = "0xBF4194", VA = "0xBF4194")]
		public StandaloneInput()
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000016")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000017")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000077")]
			Update,
			[Token(Token = "0x4000078")]
			FixedUpdate,
			[Token(Token = "0x4000079")]
			LateUpdate,
			[Token(Token = "0x400007A")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Header("Position")]
		public bool smoothFollow;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Rotation")]
		public float rotationSensitivity;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Distance")]
		public float distance;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Header("Blocking")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		public float blockedOffset;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x1700000C")]
		public float x
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0xBF6C48", Offset = "0xBF6C48", VA = "0xBF6C48")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600008D")]
			[Address(RVA = "0xBF6C50", Offset = "0xBF6C50", VA = "0xBF6C50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public float y
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0xBF6C58", Offset = "0xBF6C58", VA = "0xBF6C58")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600008F")]
			[Address(RVA = "0xBF6C60", Offset = "0xBF6C60", VA = "0xBF6C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public float distanceTarget
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0xBF6C68", Offset = "0xBF6C68", VA = "0xBF6C68")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0xBF6C70", Offset = "0xBF6C70", VA = "0xBF6C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		private float zoomAdd
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0xBF7640", Offset = "0xBF7640", VA = "0xBF7640")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xBF6C78", Offset = "0xBF6C78", VA = "0xBF6C78", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xBF6DA0", Offset = "0xBF6DA0", VA = "0xBF6DA0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xBF6DE8", Offset = "0xBF6DE8", VA = "0xBF6DE8", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xBF6E40", Offset = "0xBF6E40", VA = "0xBF6E40", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xBF6E98", Offset = "0xBF6E98", VA = "0xBF6E98")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xBF6DCC", Offset = "0xBF6DCC", VA = "0xBF6DCC")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xBF7024", Offset = "0xBF7024", VA = "0xBF7024")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xBF7604", Offset = "0xBF7604", VA = "0xBF7604")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xBF76AC", Offset = "0xBF76AC", VA = "0xBF76AC")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xBF776C", Offset = "0xBF776C", VA = "0xBF776C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xBF7798", Offset = "0xBF7798", VA = "0xBF7798")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xBF79BC", Offset = "0xBF79BC", VA = "0xBF79BC")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xBF79F8", Offset = "0xBF79F8", VA = "0xBF79F8")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	public enum Axis
	{
		[Token(Token = "0x4000081")]
		X,
		[Token(Token = "0x4000082")]
		Y,
		[Token(Token = "0x4000083")]
		Z
	}
	[Token(Token = "0x200001A")]
	public class AxisTools
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xBF7A14", Offset = "0xBF7A14", VA = "0xBF7A14")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xBF7AF4", Offset = "0xBF7AF4", VA = "0xBF7AF4")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xBF7B2C", Offset = "0xBF7B2C", VA = "0xBF7B2C")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xBF7C74", Offset = "0xBF7C74", VA = "0xBF7C74")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xBF7C28", Offset = "0xBF7C28", VA = "0xBF7C28")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xBF7D70", Offset = "0xBF7D70", VA = "0xBF7D70")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xBF8198", Offset = "0xBF8198", VA = "0xBF8198")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001B")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x200001C")]
		public class LimbOrientation
		{
			[Token(Token = "0x4000088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x400008A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x60000AA")]
			[Address(RVA = "0xBF8494", Offset = "0xBF8494", VA = "0xBF8494")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000010")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0xBF81E0", Offset = "0xBF81E0", VA = "0xBF81E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0xBF8508", Offset = "0xBF8508", VA = "0xBF8508")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xBF81A0", Offset = "0xBF81A0", VA = "0xBF81A0")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x200001D")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x200001E")]
		public enum BoneType
		{
			[Token(Token = "0x400009E")]
			Unassigned,
			[Token(Token = "0x400009F")]
			Spine,
			[Token(Token = "0x40000A0")]
			Head,
			[Token(Token = "0x40000A1")]
			Arm,
			[Token(Token = "0x40000A2")]
			Leg,
			[Token(Token = "0x40000A3")]
			Tail,
			[Token(Token = "0x40000A4")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x200001F")]
		public enum BoneSide
		{
			[Token(Token = "0x40000A6")]
			Center,
			[Token(Token = "0x40000A7")]
			Left,
			[Token(Token = "0x40000A8")]
			Right
		}

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xBF87BC", Offset = "0xBF87BC", VA = "0xBF87BC")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xBF8A80", Offset = "0xBF8A80", VA = "0xBF8A80")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xBF8CB4", Offset = "0xBF8CB4", VA = "0xBF8CB4")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xBF8D28", Offset = "0xBF8D28", VA = "0xBF8D28")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xBF8DBC", Offset = "0xBF8DBC", VA = "0xBF8DBC")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xBF8968", Offset = "0xBF8968", VA = "0xBF8968")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xBF8C2C", Offset = "0xBF8C2C", VA = "0xBF8C2C")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xBF94F4", Offset = "0xBF94F4", VA = "0xBF94F4")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xBF934C", Offset = "0xBF934C", VA = "0xBF934C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xBF9420", Offset = "0xBF9420", VA = "0xBF9420")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xBF8FA4", Offset = "0xBF8FA4", VA = "0xBF8FA4")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xBF9040", Offset = "0xBF9040", VA = "0xBF9040")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xBF90DC", Offset = "0xBF90DC", VA = "0xBF90DC")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xBF9178", Offset = "0xBF9178", VA = "0xBF9178")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xBF9214", Offset = "0xBF9214", VA = "0xBF9214")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xBF92B0", Offset = "0xBF92B0", VA = "0xBF92B0")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xBF96DC", Offset = "0xBF96DC", VA = "0xBF96DC")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xBF8ED0", Offset = "0xBF8ED0", VA = "0xBF8ED0")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xBF9658", Offset = "0xBF9658", VA = "0xBF9658")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xBF973C", Offset = "0xBF973C", VA = "0xBF973C")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xBF97FC", Offset = "0xBF97FC", VA = "0xBF97FC")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xBF95E4", Offset = "0xBF95E4", VA = "0xBF95E4")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xBF9574", Offset = "0xBF9574", VA = "0xBF9574")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000020")]
	public class BipedReferences
	{
		[Token(Token = "0x2000021")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40000BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40000BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x17000014")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60000DC")]
				[Address(RVA = "0xBFF110", Offset = "0xBFF110", VA = "0xBFF110")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60000DB")]
			[Address(RVA = "0xBFF0FC", Offset = "0xBFF0FC", VA = "0xBFF0FC")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000012")]
		public virtual bool isFilled
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xBFB7F4", Offset = "0xBFB7F4", VA = "0xBFB7F4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		public bool isEmpty
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0xBFBB50", Offset = "0xBFBB50", VA = "0xBFBB50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xBFBB60", Offset = "0xBFBB60", VA = "0xBFBB60", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xBFBEEC", Offset = "0xBFBEEC", VA = "0xBFBEEC", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xBFC27C", Offset = "0xBFC27C", VA = "0xBFC27C")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xBFC8A0", Offset = "0xBFC8A0", VA = "0xBFC8A0")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xBFC4DC", Offset = "0xBFC4DC", VA = "0xBFC4DC")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xBFD09C", Offset = "0xBFD09C", VA = "0xBFD09C")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xBFD17C", Offset = "0xBFD17C", VA = "0xBFD17C")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xBFDBF4", Offset = "0xBFDBF4", VA = "0xBFDBF4")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xBFDA14", Offset = "0xBFDA14", VA = "0xBFDA14")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xBFD7B4", Offset = "0xBFD7B4", VA = "0xBFD7B4")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xBFD218", Offset = "0xBFD218", VA = "0xBFD218")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xBFDB08", Offset = "0xBFDB08", VA = "0xBFDB08")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xBFDCD4", Offset = "0xBFDCD4", VA = "0xBFDCD4")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xBFE794", Offset = "0xBFE794", VA = "0xBFE794")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xBFE254", Offset = "0xBFE254", VA = "0xBFE254")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xBFEA68", Offset = "0xBFEA68", VA = "0xBFEA68")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xBFE5A8", Offset = "0xBFE5A8", VA = "0xBFE5A8")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xBFEA70", Offset = "0xBFEA70", VA = "0xBFEA70")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xBFEA78", Offset = "0xBFEA78", VA = "0xBFEA78")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xBFEC2C", Offset = "0xBFEC2C", VA = "0xBFEC2C")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xBFF094", Offset = "0xBFF094", VA = "0xBFF094")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xBFC474", Offset = "0xBFC474", VA = "0xBFC474")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xBFF118", Offset = "0xBFF118", VA = "0xBFF118")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xBFF120", Offset = "0xBFF120", VA = "0xBFF120")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xBFF218", Offset = "0xBFF218", VA = "0xBFF218")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class Hierarchy
	{
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xBFF010", Offset = "0xBFF010", VA = "0xBFF010")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xBFEF04", Offset = "0xBFEF04", VA = "0xBFEF04")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xBFD2F4", Offset = "0xBFD2F4", VA = "0xBFD2F4")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xBFD904", Offset = "0xBFD904", VA = "0xBFD904")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xBFD574", Offset = "0xBFD574", VA = "0xBFD574")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xBFF228", Offset = "0xBFF228", VA = "0xBFF228")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xBFD424", Offset = "0xBFD424", VA = "0xBFD424")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xBFF31C", Offset = "0xBFF31C", VA = "0xBFF31C")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xBFF688", Offset = "0xBFF688", VA = "0xBFF688")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xBFF480", Offset = "0xBFF480", VA = "0xBFF480")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xBFF810", Offset = "0xBFF810", VA = "0xBFF810")]
		public Hierarchy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000025")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000C0")]
		None,
		[Token(Token = "0x40000C1")]
		InOutCubic,
		[Token(Token = "0x40000C2")]
		InOutQuintic,
		[Token(Token = "0x40000C3")]
		InOutSine,
		[Token(Token = "0x40000C4")]
		InQuintic,
		[Token(Token = "0x40000C5")]
		InQuartic,
		[Token(Token = "0x40000C6")]
		InCubic,
		[Token(Token = "0x40000C7")]
		InQuadratic,
		[Token(Token = "0x40000C8")]
		InElastic,
		[Token(Token = "0x40000C9")]
		InElasticSmall,
		[Token(Token = "0x40000CA")]
		InElasticBig,
		[Token(Token = "0x40000CB")]
		InSine,
		[Token(Token = "0x40000CC")]
		InBack,
		[Token(Token = "0x40000CD")]
		OutQuintic,
		[Token(Token = "0x40000CE")]
		OutQuartic,
		[Token(Token = "0x40000CF")]
		OutCubic,
		[Token(Token = "0x40000D0")]
		OutInCubic,
		[Token(Token = "0x40000D1")]
		OutInQuartic,
		[Token(Token = "0x40000D2")]
		OutElastic,
		[Token(Token = "0x40000D3")]
		OutElasticSmall,
		[Token(Token = "0x40000D4")]
		OutElasticBig,
		[Token(Token = "0x40000D5")]
		OutSine,
		[Token(Token = "0x40000D6")]
		OutBack,
		[Token(Token = "0x40000D7")]
		OutBackCubic,
		[Token(Token = "0x40000D8")]
		OutBackQuartic,
		[Token(Token = "0x40000D9")]
		BackInCubic,
		[Token(Token = "0x40000DA")]
		BackInQuartic
	}
	[Token(Token = "0x2000026")]
	public class Interp
	{
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xBFF818", Offset = "0xBFF818", VA = "0xBFF818")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xC001A0", Offset = "0xC001A0", VA = "0xC001A0")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xC00210", Offset = "0xC00210", VA = "0xC00210")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xBFFC18", Offset = "0xBFFC18", VA = "0xBFFC18")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xBFFC24", Offset = "0xBFFC24", VA = "0xBFFC24")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xBFFC48", Offset = "0xBFFC48", VA = "0xBFFC48")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xBFFC84", Offset = "0xBFFC84", VA = "0xBFFC84")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xBFFC9C", Offset = "0xBFFC9C", VA = "0xBFFC9C")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xBFFCB0", Offset = "0xBFFCB0", VA = "0xBFFCB0")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xBFFCC4", Offset = "0xBFFCC4", VA = "0xBFFCC4")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xBFFCD4", Offset = "0xBFFCD4", VA = "0xBFFCD4")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xBFFD1C", Offset = "0xBFFD1C", VA = "0xBFFD1C")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xBFFD54", Offset = "0xBFFD54", VA = "0xBFFD54")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xBFFD7C", Offset = "0xBFFD7C", VA = "0xBFFD7C")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xC00280", Offset = "0xC00280", VA = "0xC00280")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xBFFDB0", Offset = "0xBFFDB0", VA = "0xBFFDB0")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xBFFDD8", Offset = "0xBFFDD8", VA = "0xBFFDD8")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xBFFE08", Offset = "0xBFFE08", VA = "0xBFFE08")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xBFFE3C", Offset = "0xBFFE3C", VA = "0xBFFE3C")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xBFFE80", Offset = "0xBFFE80", VA = "0xBFFE80")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xBFFEE4", Offset = "0xBFFEE4", VA = "0xBFFEE4")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xBFFF48", Offset = "0xBFFF48", VA = "0xBFFF48")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xBFFF9C", Offset = "0xBFFF9C", VA = "0xBFFF9C")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xBFFFF0", Offset = "0xBFFFF0", VA = "0xBFFFF0")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xC00028", Offset = "0xC00028", VA = "0xC00028")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xC0005C", Offset = "0xC0005C", VA = "0xC0005C")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xC002B4", Offset = "0xC002B4", VA = "0xC002B4")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xC000A0", Offset = "0xC000A0", VA = "0xC000A0")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xC00130", Offset = "0xC00130", VA = "0xC00130")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xC00160", Offset = "0xC00160", VA = "0xC00160")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xC00344", Offset = "0xC00344", VA = "0xC00344")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xC0034C", Offset = "0xC0034C", VA = "0xC0034C")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xC003B4", Offset = "0xC003B4", VA = "0xC003B4")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000028")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x600010C")]
		[Address(RVA = "0xC0041C", Offset = "0xC0041C", VA = "0xC0041C")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xC00468", Offset = "0xC00468", VA = "0xC00468")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xC00524", Offset = "0xC00524", VA = "0xC00524")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xC0047C", Offset = "0xC0047C", VA = "0xC0047C")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xC00538", Offset = "0xC00538", VA = "0xC00538")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xC005C8", Offset = "0xC005C8", VA = "0xC005C8")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xC005F0", Offset = "0xC005F0", VA = "0xC005F0")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xC0063C", Offset = "0xC0063C", VA = "0xC0063C")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xC006A4", Offset = "0xC006A4", VA = "0xC006A4")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xC007F8", Offset = "0xC007F8", VA = "0xC007F8")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xC00930", Offset = "0xC00930", VA = "0xC00930")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xC00988", Offset = "0xC00988", VA = "0xC00988")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000029")]
	public static class QuaTools
	{
		[Token(Token = "0x6000118")]
		[Address(RVA = "0xC009AC", Offset = "0xC009AC", VA = "0xC009AC")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xC009F8", Offset = "0xC009F8", VA = "0xC009F8")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xC00A44", Offset = "0xC00A44", VA = "0xC00A44")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xC00B48", Offset = "0xC00B48", VA = "0xC00B48")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xC00C4C", Offset = "0xC00C4C", VA = "0xC00C4C")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xC00D60", Offset = "0xC00D60", VA = "0xC00D60")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xC00E08", Offset = "0xC00E08", VA = "0xC00E08")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xC00F14", Offset = "0xC00F14", VA = "0xC00F14")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xC0107C", Offset = "0xC0107C", VA = "0xC0107C")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xC01260", Offset = "0xC01260", VA = "0xC01260")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xC01330", Offset = "0xC01330", VA = "0xC01330")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x200002A")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000015")]
		public static T instance
		{
			[Token(Token = "0x6000123")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000124")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000125")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000016")]
		private bool animatePhysics
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0xC015D0", Offset = "0xC015D0", VA = "0xC015D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		private bool isAnimated
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0xC01890", Offset = "0xC01890", VA = "0xC01890")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xC014B4", Offset = "0xC014B4", VA = "0xC014B4")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xC01548", Offset = "0xC01548", VA = "0xC01548", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xC0154C", Offset = "0xC0154C", VA = "0xC0154C", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xC01550", Offset = "0xC01550", VA = "0xC01550", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xC01554", Offset = "0xC01554", VA = "0xC01554")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xC015CC", Offset = "0xC015CC", VA = "0xC015CC")]
		private void Start()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xC0157C", Offset = "0xC0157C", VA = "0xC0157C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xC01854", Offset = "0xC01854", VA = "0xC01854")]
		private void Update()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xC0169C", Offset = "0xC0169C", VA = "0xC0169C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xC01928", Offset = "0xC01928", VA = "0xC01928")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xC01974", Offset = "0xC01974", VA = "0xC01974")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xC019C0", Offset = "0xC019C0", VA = "0xC019C0")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xC019F8", Offset = "0xC019F8", VA = "0xC019F8")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xC01A08", Offset = "0xC01A08", VA = "0xC01A08")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xC01ABC", Offset = "0xC01ABC", VA = "0xC01ABC")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xC01B70", Offset = "0xC01B70", VA = "0xC01B70")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xC01C24", Offset = "0xC01C24", VA = "0xC01C24")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public static class V3Tools
	{
		[Token(Token = "0x6000139")]
		[Address(RVA = "0xC01C2C", Offset = "0xC01C2C", VA = "0xC01C2C")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xC01C88", Offset = "0xC01C88", VA = "0xC01C88")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xC01CC0", Offset = "0xC01CC0", VA = "0xC01CC0")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xC01E10", Offset = "0xC01E10", VA = "0xC01E10")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xC01F8C", Offset = "0xC01F8C", VA = "0xC01F8C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xC021DC", Offset = "0xC021DC", VA = "0xC021DC")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xC02434", Offset = "0xC02434", VA = "0xC02434")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xC025E0", Offset = "0xC025E0", VA = "0xC025E0")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200002E")]
	public static class Warning
	{
		[Token(Token = "0x200002F")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xC027D8", Offset = "0xC027D8", VA = "0xC027D8")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xBFCFE8", Offset = "0xBFCFE8", VA = "0xBFCFE8")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000030")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xC02954", Offset = "0xC02954", VA = "0xC02954")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xC029D4", Offset = "0xC029D4", VA = "0xC029D4")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The direction of the animated weapon swing in character space. Tweak this value to adjust the aiming.")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xC029DC", Offset = "0xC029DC", VA = "0xC029DC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xC02A48", Offset = "0xC02A48", VA = "0xC02A48")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xC02AA8", Offset = "0xC02AA8", VA = "0xC02AA8")]
		private void Start()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xC02AE0", Offset = "0xC02AE0", VA = "0xC02AE0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xC02C2C", Offset = "0xC02C2C", VA = "0xC02C2C")]
		private void Pose()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xC02D9C", Offset = "0xC02D9C", VA = "0xC02D9C")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xC02F80", Offset = "0xC02F80", VA = "0xC02F80")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xC03010", Offset = "0xC03010", VA = "0xC03010")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xC03024", Offset = "0xC03024", VA = "0xC03024")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xC03190", Offset = "0xC03190", VA = "0xC03190")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xC0338C", Offset = "0xC0338C", VA = "0xC0338C")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LargeHeader("References")]
		public Animator animator;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[LargeHeader("Look At")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float lookAtWeight;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float lookAtClampWeight;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[LargeHeader("Foot")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float footPositionWeight;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[LargeHeader("Hand")]
		public Transform handTargetBiped;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float handPositionWeight;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float handRotationWeight;

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xC033BC", Offset = "0xC033BC", VA = "0xC033BC")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xC037E8", Offset = "0xC037E8", VA = "0xC037E8")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xC03808", Offset = "0xC03808", VA = "0xC03808")]
		private void Update()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xC04124", Offset = "0xC04124", VA = "0xC04124")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xC03EA0", Offset = "0xC03EA0", VA = "0xC03EA0")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xC04234", Offset = "0xC04234", VA = "0xC04234")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x17000018")]
		public Vector3 inputVector
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0xC04260", Offset = "0xC04260", VA = "0xC04260")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xC042E0", Offset = "0xC042E0", VA = "0xC042E0")]
		private void Update()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xC04624", Offset = "0xC04624", VA = "0xC04624")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class <Step>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000132")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000133")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000134")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x1700001B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000168")]
				[Address(RVA = "0xC05014", Offset = "0xC05014", VA = "0xC05014", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600016A")]
				[Address(RVA = "0xC0505C", Offset = "0xC0505C", VA = "0xC0505C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000165")]
			[Address(RVA = "0xC04D38", Offset = "0xC04D38", VA = "0xC04D38")]
			[DebuggerHidden]
			public <Step>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x6000166")]
			[Address(RVA = "0xC04D90", Offset = "0xC04D90", VA = "0xC04D90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000167")]
			[Address(RVA = "0xC04D94", Offset = "0xC04D94", VA = "0xC04D94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000169")]
			[Address(RVA = "0xC0501C", Offset = "0xC0501C", VA = "0xC0501C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ParticleSystem sand;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IK ik;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float stepProgress;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lastStepTime;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit hit;

		[Token(Token = "0x17000019")]
		public bool isStepping
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0xC04638", Offset = "0xC04638", VA = "0xC04638")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		public Vector3 position
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0xC04204", Offset = "0xC04204", VA = "0xC04204")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600015F")]
			[Address(RVA = "0xC0464C", Offset = "0xC0464C", VA = "0xC0464C")]
			set
			{
			}
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xC04698", Offset = "0xC04698", VA = "0xC04698")]
		private void Start()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xC047D8", Offset = "0xC047D8", VA = "0xC047D8")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xC04A78", Offset = "0xC04A78", VA = "0xC04A78")]
		private void Update()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xC04C94", Offset = "0xC04C94", VA = "0xC04C94")]
		[IteratorStateMachine(typeof(<Step>d__24))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xC04D60", Offset = "0xC04D60", VA = "0xC04D60")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xC05064", Offset = "0xC05064", VA = "0xC05064")]
		private void Start()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xC05130", Offset = "0xC05130", VA = "0xC05130")]
		private void Update()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xC053A4", Offset = "0xC053A4", VA = "0xC053A4")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200003B")]
		public struct Warp
		{
			[Token(Token = "0x400013D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			[Token(Token = "0x400013E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			[Token(Token = "0x4000142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x200003C")]
		public enum EffectorMode
		{
			[Token(Token = "0x4000144")]
			PositionOffset,
			[Token(Token = "0x4000145")]
			Position
		}

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public EffectorMode effectorMode;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		[Space(10f)]
		public Warp[] warps;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xC053AC", Offset = "0xC053AC", VA = "0xC053AC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xC053CC", Offset = "0xC053CC", VA = "0xC053CC")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xC055E4", Offset = "0xC055E4", VA = "0xC055E4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xC0589C", Offset = "0xC0589C", VA = "0xC0589C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xC05930", Offset = "0xC05930", VA = "0xC05930")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[RequireComponent(typeof(Animator))]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xC05938", Offset = "0xC05938", VA = "0xC05938", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xC05988", Offset = "0xC05988", VA = "0xC05988")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xC05B90", Offset = "0xC05B90", VA = "0xC05B90", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xC05DB8", Offset = "0xC05DB8", VA = "0xC05DB8")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	[RequireComponent(typeof(AimIK))]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float headLookWeight;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xC05DCC", Offset = "0xC05DCC", VA = "0xC05DCC", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xC05F60", Offset = "0xC05F60", VA = "0xC05F60", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xC05FC8", Offset = "0xC05FC8", VA = "0xC05FC8")]
		private void Read()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xC06100", Offset = "0xC06100", VA = "0xC06100")]
		private void AimIK()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xC0615C", Offset = "0xC0615C", VA = "0xC0615C")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xC067A4", Offset = "0xC067A4", VA = "0xC067A4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xC065B8", Offset = "0xC065B8", VA = "0xC065B8")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xC06A48", Offset = "0xC06A48", VA = "0xC06A48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xC06B54", Offset = "0xC06B54", VA = "0xC06B54")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xC06B70", Offset = "0xC06B70", VA = "0xC06B70", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xC06BCC", Offset = "0xC06BCC", VA = "0xC06BCC", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xC06F08", Offset = "0xC06F08", VA = "0xC06F08")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xC06FF8", Offset = "0xC06FF8", VA = "0xC06FF8")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[RequireComponent(typeof(AnimatorController3rdPerson))]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CameraController cam;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x1700001D")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0xC0725C", Offset = "0xC0725C", VA = "0xC0725C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700001E")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0xC072DC", Offset = "0xC072DC", VA = "0xC072DC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xC07000", Offset = "0xC07000", VA = "0xC07000")]
		private void Start()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xC07068", Offset = "0xC07068", VA = "0xC07068")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xC0735C", Offset = "0xC0735C", VA = "0xC0735C")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xC07364", Offset = "0xC07364", VA = "0xC07364", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xC077C0", Offset = "0xC077C0", VA = "0xC077C0")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xC077C8", Offset = "0xC077C8", VA = "0xC077C8")]
		private void Start()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xC0786C", Offset = "0xC0786C", VA = "0xC0786C")]
		private void Update()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xC07CC8", Offset = "0xC07CC8", VA = "0xC07CC8")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xC07D68", Offset = "0xC07D68", VA = "0xC07D68")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000044")]
		public class Limb
		{
			[Token(Token = "0x400017A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x6000193")]
			[Address(RVA = "0xC07EFC", Offset = "0xC07EFC", VA = "0xC07EFC")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000194")]
			[Address(RVA = "0xC08020", Offset = "0xC08020", VA = "0xC08020")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xC07DD8", Offset = "0xC07DD8", VA = "0xC07DD8")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xC07F74", Offset = "0xC07F74", VA = "0xC07F74")]
		private void Start()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xC0800C", Offset = "0xC0800C", VA = "0xC0800C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xC08010", Offset = "0xC08010", VA = "0xC08010")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xC08030", Offset = "0xC08030", VA = "0xC08030")]
		private void Start()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xC08098", Offset = "0xC08098", VA = "0xC08098")]
		private void Update()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xC08160", Offset = "0xC08160", VA = "0xC08160")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The target we want to hit")]
		public Transform target;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The pin Transform is used to reference the exact hit point in the animation (used by AimIK to aim the upper body to follow the target).In Legacy and Generic modes you can just create and position a reference point in your animating software and include it in the FBX. Then in Unity if you added a GameObject with the exact same name under the character's root, it would be animated to the required position.In Humanoid mode however, Mecanim loses track of any Transform that does not belong to the avatar, so in this case the pin point has to be manually set inside the Unity Editor.")]
		public Transform pin;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Full Body Biped IK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The Aim IK component. Aim IK is ust used for following the target slightly with the body.")]
		public AimIK aim;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The effector type of the punching hand")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Weight of aiming the body to follow the target")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xC08168", Offset = "0xC08168", VA = "0xC08168")]
		private void Start()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xC081B8", Offset = "0xC081B8", VA = "0xC081B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xC08350", Offset = "0xC08350", VA = "0xC08350")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xC08358", Offset = "0xC08358", VA = "0xC08358")]
		private void Awake()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xC08428", Offset = "0xC08428", VA = "0xC08428")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xC084A8", Offset = "0xC084A8", VA = "0xC084A8")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xC088F0", Offset = "0xC088F0", VA = "0xC088F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xC089FC", Offset = "0xC089FC", VA = "0xC089FC")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float aimWeight;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float sightWeight;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 180f)]
		public float maxAngle;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform gunTarget;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AimIK gunAim;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Recoil recoil;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Range(0f, 1f)]
		private float cameraRecoilWeight;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool updateFrame;

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xC08A04", Offset = "0xC08A04", VA = "0xC08A04")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xC08B64", Offset = "0xC08B64", VA = "0xC08B64")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xC08B70", Offset = "0xC08B70", VA = "0xC08B70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xC08E30", Offset = "0xC08E30", VA = "0xC08E30")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xC08F80", Offset = "0xC08F80", VA = "0xC08F80")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xC08C34", Offset = "0xC08C34", VA = "0xC08C34")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xC09C04", Offset = "0xC09C04", VA = "0xC09C04")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[RequireComponent(typeof(FPSAiming))]
	[RequireComponent(typeof(Animator))]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xC09C24", Offset = "0xC09C24", VA = "0xC09C24")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xC09CA0", Offset = "0xC09CA0", VA = "0xC09CA0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xC09D9C", Offset = "0xC09D9C", VA = "0xC09D9C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xC09E48", Offset = "0xC09E48", VA = "0xC09E48")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReaction hitReaction;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xC09E58", Offset = "0xC09E58", VA = "0xC09E58")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xC09F9C", Offset = "0xC09F9C", VA = "0xC09F9C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xC0A100", Offset = "0xC0A100", VA = "0xC0A100")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xC0A110", Offset = "0xC0A110", VA = "0xC0A110")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xC0A2DC", Offset = "0xC0A2DC", VA = "0xC0A2DC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xC0A6EC", Offset = "0xC0A6EC", VA = "0xC0A6EC")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xC0A6FC", Offset = "0xC0A6FC", VA = "0xC0A6FC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xC0A7E4", Offset = "0xC0A7E4", VA = "0xC0A7E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xC0A8D0", Offset = "0xC0A8D0", VA = "0xC0A8D0")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xC0A8D8", Offset = "0xC0A8D8", VA = "0xC0A8D8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xC0ADD8", Offset = "0xC0ADD8", VA = "0xC0ADD8")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[RequireComponent(typeof(InteractionSystem))]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The object to interact to")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("The effectors to interact with")]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xC0ADE0", Offset = "0xC0ADE0", VA = "0xC0ADE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xC0AE30", Offset = "0xC0AE30", VA = "0xC0AE30")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xC0B0DC", Offset = "0xC0B0DC", VA = "0xC0B0DC")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000050")]
		public class Partner
		{
			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x40001BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x1700001F")]
			private Transform neck
			{
				[Token(Token = "0x60001BE")]
				[Address(RVA = "0xC0B8E8", Offset = "0xC0B8E8", VA = "0xC0B8E8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001BC")]
			[Address(RVA = "0xC0B10C", Offset = "0xC0B10C", VA = "0xC0B10C")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60001BD")]
			[Address(RVA = "0xC0B188", Offset = "0xC0B188", VA = "0xC0B188")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60001BF")]
			[Address(RVA = "0xC0B780", Offset = "0xC0B780", VA = "0xC0B780")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60001C0")]
			[Address(RVA = "0xC0B934", Offset = "0xC0B934", VA = "0xC0B934")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xC0B0E4", Offset = "0xC0B0E4", VA = "0xC0B0E4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xC0B12C", Offset = "0xC0B12C", VA = "0xC0B12C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xC0B770", Offset = "0xC0B770", VA = "0xC0B770")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000052")]
		public enum Mode
		{
			[Token(Token = "0x40001CF")]
			Position,
			[Token(Token = "0x40001D0")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x2000053")]
		public class Absorber
		{
			[Token(Token = "0x40001D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40001D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight;

			[Token(Token = "0x40001D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x40001D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x40001D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x60001C7")]
			[Address(RVA = "0xC0BAAC", Offset = "0xC0BAAC", VA = "0xC0BAAC")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xC0BC80", Offset = "0xC0BC80", VA = "0xC0BC80")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x60001C9")]
			[Address(RVA = "0xC0BCA4", Offset = "0xC0BCA4", VA = "0xC0BCA4")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xC0BDB4", Offset = "0xC0BDB4", VA = "0xC0BDB4")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x60001CB")]
			[Address(RVA = "0xC0BF4C", Offset = "0xC0BF4C", VA = "0xC0BF4C")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Use either effector position, position weight, rotation, rotationWeight or positionOffset and rotating the bone directly.")]
		public Mode mode;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Array containing the absorbers")]
		public Absorber[] absorbers;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xC0B948", Offset = "0xC0B948", VA = "0xC0B948", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xC0BA2C", Offset = "0xC0BA2C", VA = "0xC0BA2C")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xC0BB74", Offset = "0xC0BB74", VA = "0xC0BB74", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xC0BD38", Offset = "0xC0BD38", VA = "0xC0BD38")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xC0BE24", Offset = "0xC0BE24", VA = "0xC0BE24", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xC0BF3C", Offset = "0xC0BF3C", VA = "0xC0BF3C")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xC0BFAC", Offset = "0xC0BFAC", VA = "0xC0BFAC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xC0C01C", Offset = "0xC0C01C", VA = "0xC0C01C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xC0C0EC", Offset = "0xC0C0EC", VA = "0xC0C0EC")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xC0C234", Offset = "0xC0C234", VA = "0xC0C234")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000056")]
		public class EffectorLink
		{
			[Token(Token = "0x40001DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40001E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x40001E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x60001D3")]
			[Address(RVA = "0xC0C4B4", Offset = "0xC0C4B4", VA = "0xC0C4B4")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xC0C248", Offset = "0xC0C248", VA = "0xC0C248", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xC0C334", Offset = "0xC0C334", VA = "0xC0C334", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xC0C4AC", Offset = "0xC0C4AC", VA = "0xC0C4AC")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight of this script.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform leftHandTarget;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform rightHandTarget;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform leftFootTarget;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform headTarget;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xC0C4C4", Offset = "0xC0C4C4", VA = "0xC0C4C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xC0C7C4", Offset = "0xC0C7C4", VA = "0xC0C7C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xC0CFC0", Offset = "0xC0CFC0", VA = "0xC0CFC0")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x17000020")]
		private bool holding
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0xC0D240", Offset = "0xC0D240", VA = "0xC0D240")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xC0D02C", Offset = "0xC0D02C", VA = "0xC0D02C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001D8")]
		protected abstract void RotatePivot();

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xC0D260", Offset = "0xC0D260", VA = "0xC0D260")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xC0D420", Offset = "0xC0D420", VA = "0xC0D420")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xC0D590", Offset = "0xC0D590", VA = "0xC0D590")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xC0D660", Offset = "0xC0D660", VA = "0xC0D660")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xC0D780", Offset = "0xC0D780", VA = "0xC0D780")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xC0D8F4", Offset = "0xC0D8F4", VA = "0xC0D8F4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xC0DAF0", Offset = "0xC0DAF0", VA = "0xC0DAF0")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xC0DB04", Offset = "0xC0DB04", VA = "0xC0DB04", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xC0DCE4", Offset = "0xC0DCE4", VA = "0xC0DCE4")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xC0DCF8", Offset = "0xC0DCF8", VA = "0xC0DCF8", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xC0DE0C", Offset = "0xC0DE0C", VA = "0xC0DE0C")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xC0DE20", Offset = "0xC0DE20", VA = "0xC0DE20")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xC0DEB8", Offset = "0xC0DEB8", VA = "0xC0DEB8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xC0DFD0", Offset = "0xC0DFD0", VA = "0xC0DFD0")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[RequireComponent(typeof(Recoil))]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xC0DFD8", Offset = "0xC0DFD8", VA = "0xC0DFD8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xC0E028", Offset = "0xC0E028", VA = "0xC0E028")]
		private void Update()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xC0E074", Offset = "0xC0E074", VA = "0xC0E074")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xC0E10C", Offset = "0xC0E10C", VA = "0xC0E10C")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x400020A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x17000021")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001F3")]
				[Address(RVA = "0xC0E44C", Offset = "0xC0E44C", VA = "0xC0E44C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000022")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001F5")]
				[Address(RVA = "0xC0E494", Offset = "0xC0E494", VA = "0xC0E494", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0xC0E280", Offset = "0xC0E280", VA = "0xC0E280")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0xC0E2B8", Offset = "0xC0E2B8", VA = "0xC0E2B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xC0E2BC", Offset = "0xC0E2BC", VA = "0xC0E2BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001F4")]
			[Address(RVA = "0xC0E454", Offset = "0xC0E454", VA = "0xC0E454", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xC0E11C", Offset = "0xC0E11C", VA = "0xC0E11C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xC0E1CC", Offset = "0xC0E1CC", VA = "0xC0E1CC")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xC0E208", Offset = "0xC0E208", VA = "0xC0E208")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xC0E2A8", Offset = "0xC0E2A8", VA = "0xC0E2A8")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[RequireComponent(typeof(Animator))]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400020E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x17000023")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001FC")]
				[Address(RVA = "0xC0E708", Offset = "0xC0E708", VA = "0xC0E708", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000024")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001FE")]
				[Address(RVA = "0xC0E750", Offset = "0xC0E750", VA = "0xC0E750", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001F9")]
			[Address(RVA = "0xC0E5AC", Offset = "0xC0E5AC", VA = "0xC0E5AC")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60001FA")]
			[Address(RVA = "0xC0E5DC", Offset = "0xC0E5DC", VA = "0xC0E5DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001FB")]
			[Address(RVA = "0xC0E5E0", Offset = "0xC0E5E0", VA = "0xC0E5E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001FD")]
			[Address(RVA = "0xC0E710", Offset = "0xC0E710", VA = "0xC0E710", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xC0E49C", Offset = "0xC0E49C", VA = "0xC0E49C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xC0E544", Offset = "0xC0E544", VA = "0xC0E544")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xC0E5D4", Offset = "0xC0E5D4", VA = "0xC0E5D4")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000062")]
		public class EffectorLink
		{
			[Token(Token = "0x4000213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x4000218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x4000219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x6000203")]
			[Address(RVA = "0xC0E7BC", Offset = "0xC0E7BC", VA = "0xC0E7BC")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000204")]
			[Address(RVA = "0xC0F2F8", Offset = "0xC0F2F8", VA = "0xC0F2F8")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000205")]
			[Address(RVA = "0xC0EB80", Offset = "0xC0EB80", VA = "0xC0EB80")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000206")]
			[Address(RVA = "0xC0F3D4", Offset = "0xC0F3D4", VA = "0xC0F3D4")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000207")]
			[Address(RVA = "0xC0F4B8", Offset = "0xC0F4B8", VA = "0xC0F4B8")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000208")]
			[Address(RVA = "0xC0F544", Offset = "0xC0F544", VA = "0xC0F544")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000209")]
			[Address(RVA = "0xC0F5CC", Offset = "0xC0F5CC", VA = "0xC0F5CC")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600020A")]
			[Address(RVA = "0xC0F138", Offset = "0xC0F138", VA = "0xC0F138")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600020B")]
			[Address(RVA = "0xC0F654", Offset = "0xC0F654", VA = "0xC0F654")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xC0E758", Offset = "0xC0E758", VA = "0xC0E758")]
		private void Start()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xC0EB20", Offset = "0xC0EB20", VA = "0xC0EB20")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xC0F088", Offset = "0xC0F088", VA = "0xC0F088")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xC0F2F0", Offset = "0xC0F2F0", VA = "0xC0F2F0")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Transform to transfer motion to.")]
		public Transform to;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The amount of motion to transfer.")]
		[Range(0f, 1f)]
		public float transferMotion;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xC0F688", Offset = "0xC0F688", VA = "0xC0F688")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xC0F6B8", Offset = "0xC0F6B8", VA = "0xC0F6B8")]
		private void Update()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xC0F768", Offset = "0xC0F768", VA = "0xC0F768")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xC0F77C", Offset = "0xC0F77C", VA = "0xC0F77C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xC0F960", Offset = "0xC0F960", VA = "0xC0F960")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xC0FBFC", Offset = "0xC0FBFC", VA = "0xC0FBFC")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xC0FCC4", Offset = "0xC0FCC4", VA = "0xC0FCC4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xC0FDD0", Offset = "0xC0FDD0", VA = "0xC0FDD0")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xC0FDD8", Offset = "0xC0FDD8", VA = "0xC0FDD8", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xC10230", Offset = "0xC10230", VA = "0xC10230")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xC103F8", Offset = "0xC103F8", VA = "0xC103F8")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xC1042C", Offset = "0xC1042C", VA = "0xC1042C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xC10634", Offset = "0xC10634", VA = "0xC10634")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xC106A0", Offset = "0xC106A0", VA = "0xC106A0")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x17000025")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000223")]
				[Address(RVA = "0xC10DEC", Offset = "0xC10DEC", VA = "0xC10DEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000026")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000225")]
				[Address(RVA = "0xC10E34", Offset = "0xC10E34", VA = "0xC10E34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000220")]
			[Address(RVA = "0xC10A80", Offset = "0xC10A80", VA = "0xC10A80")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000221")]
			[Address(RVA = "0xC10C70", Offset = "0xC10C70", VA = "0xC10C70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0xC10C74", Offset = "0xC10C74", VA = "0xC10C74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000224")]
			[Address(RVA = "0xC10DF4", Offset = "0xC10DF4", VA = "0xC10DF4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xC106A8", Offset = "0xC106A8", VA = "0xC106A8")]
		private void Start()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xC107CC", Offset = "0xC107CC", VA = "0xC107CC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xC10764", Offset = "0xC10764", VA = "0xC10764")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xC10AA8", Offset = "0xC10AA8", VA = "0xC10AA8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xC10B80", Offset = "0xC10B80", VA = "0xC10B80")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xC10C54", Offset = "0xC10C54", VA = "0xC10C54")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xC10E3C", Offset = "0xC10E3C", VA = "0xC10E3C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xC10EA4", Offset = "0xC10EA4", VA = "0xC10EA4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xC10F50", Offset = "0xC10F50", VA = "0xC10F50")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200006B")]
		public class Part
		{
			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x600022B")]
			[Address(RVA = "0xC10FC4", Offset = "0xC10FC4", VA = "0xC10FC4")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x600022C")]
			[Address(RVA = "0xC110E4", Offset = "0xC110E4", VA = "0xC110E4")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xC10F60", Offset = "0xC10F60", VA = "0xC10F60")]
		private void Update()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xC110DC", Offset = "0xC110DC", VA = "0xC110DC")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReactionVRIK hitReaction;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xC110EC", Offset = "0xC110EC", VA = "0xC110EC")]
		private void Update()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xC11230", Offset = "0xC11230", VA = "0xC11230")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xC11394", Offset = "0xC11394", VA = "0xC11394")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the VRIK component on the avatar.")]
		public VRIK ik;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The settings for VRIK calibration.")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The HMD.")]
		public Transform headTracker;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("(Optional) A tracker placed anywhere on the body of the player, preferrably close to the pelvis, on the belt area.")]
		public Transform bodyTracker;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's left hand.")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's right hand.")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's left leg.")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's right leg.")]
		public Transform rightFootTracker;

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xC113A4", Offset = "0xC113A4", VA = "0xC113A4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xC113D0", Offset = "0xC113D0", VA = "0xC113D0")]
		[ContextMenu("Calibrate")]
		private void Calibrate()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xC11400", Offset = "0xC11400", VA = "0xC11400")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xC11408", Offset = "0xC11408", VA = "0xC11408")]
		private void Start()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xC11458", Offset = "0xC11458", VA = "0xC11458")]
		private void Update()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xC11630", Offset = "0xC11630", VA = "0xC11630")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x17000027")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0xC116A8", Offset = "0xC116A8", VA = "0xC116A8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xC11688", Offset = "0xC11688", VA = "0xC11688", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xC116B0", Offset = "0xC116B0", VA = "0xC116B0")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xC11710", Offset = "0xC11710", VA = "0xC11710", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xC1197C", Offset = "0xC1197C", VA = "0xC1197C", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xC11BC0", Offset = "0xC11BC0", VA = "0xC11BC0", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xC1198C", Offset = "0xC1198C", VA = "0xC1198C")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xC11BD0", Offset = "0xC11BD0", VA = "0xC11BD0")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xC11BE8", Offset = "0xC11BE8", VA = "0xC11BE8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xC11C40", Offset = "0xC11C40", VA = "0xC11C40", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xC11CD0", Offset = "0xC11CD0", VA = "0xC11CD0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xC11DF4", Offset = "0xC11DF4", VA = "0xC11DF4")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Range(0.1f, 3f)]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x4000268")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000269")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x17000028")]
		public override bool animationGrounded
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0xC11EA4", Offset = "0xC11EA4", VA = "0xC11EA4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xC11E0C", Offset = "0xC11E0C", VA = "0xC11E0C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xC11E88", Offset = "0xC11E88", VA = "0xC11E88", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xC11F98", Offset = "0xC11F98", VA = "0xC11F98", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xC1232C", Offset = "0xC1232C", VA = "0xC1232C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xC12454", Offset = "0xC12454", VA = "0xC12454")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Base Parameters")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		public Transform gravityTarget;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		protected float gravityMultiplier;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x4000275")]
		protected const float half = 0.5f;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x6000248")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xC12478", Offset = "0xC12478", VA = "0xC12478")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xC12664", Offset = "0xC12664", VA = "0xC12664", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xC12814", Offset = "0xC12814", VA = "0xC12814", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xC129B4", Offset = "0xC129B4", VA = "0xC129B4")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xC12A14", Offset = "0xC12A14", VA = "0xC12A14")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xC12B78", Offset = "0xC12B78", VA = "0xC12B78")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xC12D7C", Offset = "0xC12D7C", VA = "0xC12D7C")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xC12DA0", Offset = "0xC12DA0", VA = "0xC12DA0")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xC12DC4", Offset = "0xC12DC4", VA = "0xC12DC4")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xC12F10", Offset = "0xC12F10", VA = "0xC12F10")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000074")]
		public enum MoveMode
		{
			[Token(Token = "0x40002AD")]
			Directional,
			[Token(Token = "0x40002AE")]
			Strafe
		}

		[Token(Token = "0x2000075")]
		public struct AnimState
		{
			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x40002B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x40002B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x40002B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;
		}

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Movement")]
		public MoveMode moveMode;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Header("Rotation")]
		public bool lookInCameraDirection;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Header("Jumping and Falling")]
		public float airSpeed;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airControl;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float jumpPower;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[Header("Wall Running")]
		private LayerMask wallRunLayers;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float wallRunMaxLength;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AnimState animState;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		protected Vector3 moveDirection;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Animator animator;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3 normal;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 platformVelocity;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private RaycastHit hit;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private float jumpLeg;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private float jumpEndTime;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private float forwardMlp;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private float groundDistance;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float lastAirTime;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float stickyForce;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 wallNormal;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private float wallRunWeight;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float lastWallRunWeight;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private bool fixedFrame;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private float wallRunEndTime;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Vector3 gravity;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private float velocityY;

		[Token(Token = "0x17000029")]
		public bool onGround
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0xC12F30", Offset = "0xC12F30", VA = "0xC12F30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000254")]
			[Address(RVA = "0xC12F38", Offset = "0xC12F38", VA = "0xC12F38")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xC12F44", Offset = "0xC12F44", VA = "0xC12F44", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xC13118", Offset = "0xC13118", VA = "0xC13118")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xC1319C", Offset = "0xC1319C", VA = "0xC1319C", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xC1324C", Offset = "0xC1324C", VA = "0xC1324C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xC141FC", Offset = "0xC141FC", VA = "0xC141FC", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xC14670", Offset = "0xC14670", VA = "0xC14670", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xC13824", Offset = "0xC13824", VA = "0xC13824")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xC14748", Offset = "0xC14748", VA = "0xC14748")]
		private void WallRun()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xC14DD4", Offset = "0xC14DD4", VA = "0xC14DD4")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xC14288", Offset = "0xC14288", VA = "0xC14288")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xC14EC4", Offset = "0xC14EC4", VA = "0xC14EC4", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xC15344", Offset = "0xC15344", VA = "0xC15344")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xC1546C", Offset = "0xC1546C", VA = "0xC1546C", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xC13C9C", Offset = "0xC13C9C", VA = "0xC13C9C")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xC1559C", Offset = "0xC1559C", VA = "0xC1559C")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[RequireComponent(typeof(Animator))]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000077")]
		public enum RotationMode
		{
			[Token(Token = "0x40002C3")]
			Smooth,
			[Token(Token = "0x40002C4")]
			Linear
		}

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The component that updates the camera.")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Acceleration of movement.")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Turning speed.")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Tooltip("Smooth or linear rotation.")]
		private RotationMode rotationMode;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x1700002A")]
		public bool isGrounded
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0xC1569C", Offset = "0xC1569C", VA = "0xC1569C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000265")]
			[Address(RVA = "0xC156A4", Offset = "0xC156A4", VA = "0xC156A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xC156B0", Offset = "0xC156B0", VA = "0xC156B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xC15744", Offset = "0xC15744", VA = "0xC15744")]
		private void Update()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xC15D5C", Offset = "0xC15D5C", VA = "0xC15D5C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xC1578C", Offset = "0xC1578C", VA = "0xC1578C")]
		private void Rotate()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xC15AF4", Offset = "0xC15AF4", VA = "0xC15AF4")]
		private void Move()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xC15D8C", Offset = "0xC15D8C", VA = "0xC15D8C")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xC15E24", Offset = "0xC15E24", VA = "0xC15E24")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xC15EA4", Offset = "0xC15EA4", VA = "0xC15EA4")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xC15ECC", Offset = "0xC15ECC", VA = "0xC15ECC", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xC16088", Offset = "0xC16088", VA = "0xC16088")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x200007A")]
		public struct State
		{
			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x40002CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xC160A4", Offset = "0xC160A4", VA = "0xC160A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xC0FEEC", Offset = "0xC0FEEC", VA = "0xC0FEEC", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xC1041C", Offset = "0xC1041C", VA = "0xC1041C")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x6000273")]
		[Address(RVA = "0xC160D0", Offset = "0xC160D0", VA = "0xC160D0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xC16108", Offset = "0xC16108", VA = "0xC16108")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xC16110", Offset = "0xC16110", VA = "0xC16110")]
		private void Update()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xC16138", Offset = "0xC16138", VA = "0xC16138")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xC161DC", Offset = "0xC161DC", VA = "0xC161DC")]
		public SlowMo()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200007D")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xC161F0", Offset = "0xC161F0", VA = "0xC161F0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xC16234", Offset = "0xC16234", VA = "0xC16234")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xC16278", Offset = "0xC16278", VA = "0xC16278")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xC162BC", Offset = "0xC162BC", VA = "0xC162BC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xC16300", Offset = "0xC16300", VA = "0xC16300")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xC16398", Offset = "0xC16398", VA = "0xC16398")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xC163B4", Offset = "0xC163B4", VA = "0xC163B4")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xC163E0", Offset = "0xC163E0", VA = "0xC163E0")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xC1640C", Offset = "0xC1640C", VA = "0xC1640C")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xC16448", Offset = "0xC16448", VA = "0xC16448")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xC16488", Offset = "0xC16488", VA = "0xC16488")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xC164A8", Offset = "0xC164A8", VA = "0xC164A8")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xC164C8", Offset = "0xC164C8", VA = "0xC164C8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xC164EC", Offset = "0xC164EC", VA = "0xC164EC")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xC16514", Offset = "0xC16514", VA = "0xC16514")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xC1653C", Offset = "0xC1653C", VA = "0xC1653C")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xC1631C", Offset = "0xC1631C", VA = "0xC1631C")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xC16560", Offset = "0xC16560", VA = "0xC16560")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xC1656C", Offset = "0xC1656C", VA = "0xC1656C")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xC16578", Offset = "0xC16578", VA = "0xC16578")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xC167E4", Offset = "0xC167E4", VA = "0xC167E4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xC16880", Offset = "0xC16880", VA = "0xC16880", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xC16BA8", Offset = "0xC16BA8", VA = "0xC16BA8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xC17014", Offset = "0xC17014", VA = "0xC17014")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xC1703C", Offset = "0xC1703C", VA = "0xC1703C")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007E")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700002B")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0xC166B4", Offset = "0xC166B4", VA = "0xC166B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0xC1725C", Offset = "0xC1725C", VA = "0xC1725C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xC16A38", Offset = "0xC16A38", VA = "0xC16A38")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xC170D0", Offset = "0xC170D0", VA = "0xC170D0")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public abstract class Constraint
	{
		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700002D")]
		public bool isValid
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0xC17418", Offset = "0xC17418", VA = "0xC17418")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000296")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xC17478", Offset = "0xC17478", VA = "0xC17478")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xC17480", Offset = "0xC17480", VA = "0xC17480", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xC17518", Offset = "0xC17518", VA = "0xC17518")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xC17520", Offset = "0xC17520", VA = "0xC17520")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x1700002E")]
		private bool positionChanged
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0xC1764C", Offset = "0xC1764C", VA = "0xC1764C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xC17548", Offset = "0xC17548", VA = "0xC17548", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xC176A8", Offset = "0xC176A8", VA = "0xC176A8")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xC176B0", Offset = "0xC176B0", VA = "0xC176B0")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xC176D8", Offset = "0xC176D8", VA = "0xC176D8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xC17754", Offset = "0xC17754", VA = "0xC17754")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xC1775C", Offset = "0xC1775C", VA = "0xC1775C")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x1700002F")]
		private bool rotationChanged
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0xC17888", Offset = "0xC17888", VA = "0xC17888")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xC17784", Offset = "0xC17784", VA = "0xC17784", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xC178E0", Offset = "0xC178E0", VA = "0xC178E0")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xC178E8", Offset = "0xC178E8", VA = "0xC178E8")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public class Constraints
	{
		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xC17910", Offset = "0xC17910", VA = "0xC17910")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xC16B58", Offset = "0xC16B58", VA = "0xC16B58")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xC16D1C", Offset = "0xC16D1C", VA = "0xC16D1C")]
		public void Update()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xC17410", Offset = "0xC17410", VA = "0xC17410")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000085")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000086")]
		public enum DOF
		{
			[Token(Token = "0x4000308")]
			One,
			[Token(Token = "0x4000309")]
			Three
		}

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Master Weight for the finger.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public DOF rotationDOF;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x17000030")]
		public bool initiated
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0xC17970", Offset = "0xC17970", VA = "0xC17970")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0xC17978", Offset = "0xC17978", VA = "0xC17978")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0xC17984", Offset = "0xC17984", VA = "0xC17984")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0xC179A4", Offset = "0xC179A4", VA = "0xC179A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0xC179C4", Offset = "0xC179C4", VA = "0xC179C4")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0xC179E4", Offset = "0xC179E4", VA = "0xC179E4")]
			set
			{
			}
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xC17A04", Offset = "0xC17A04", VA = "0xC17A04")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xC17AF0", Offset = "0xC17AF0", VA = "0xC17AF0")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xC17E8C", Offset = "0xC17E8C", VA = "0xC17E8C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xC17F4C", Offset = "0xC17F4C", VA = "0xC17F4C")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xC182F0", Offset = "0xC182F0", VA = "0xC182F0")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The master weight for all fingers.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x17000033")]
		public bool initiated
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0xC18300", Offset = "0xC18300", VA = "0xC18300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0xC18308", Offset = "0xC18308", VA = "0xC18308")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xC18314", Offset = "0xC18314", VA = "0xC18314")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xC18388", Offset = "0xC18388", VA = "0xC18388")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xC18694", Offset = "0xC18694", VA = "0xC18694")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xC18800", Offset = "0xC18800", VA = "0xC18800")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xC185AC", Offset = "0xC185AC", VA = "0xC185AC")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xC18964", Offset = "0xC18964", VA = "0xC18964", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xC18A0C", Offset = "0xC18A0C", VA = "0xC18A0C")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xC18A7C", Offset = "0xC18A7C", VA = "0xC18A7C")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xC18AD8", Offset = "0xC18AD8", VA = "0xC18AD8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xC18ADC", Offset = "0xC18ADC", VA = "0xC18ADC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xC18AE0", Offset = "0xC18AE0", VA = "0xC18AE0")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000089")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected bool initiated;

		[Token(Token = "0x60002C2")]
		public abstract void ResetPosition();

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xC18B40", Offset = "0xC18B40", VA = "0xC18B40")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xC18DF0", Offset = "0xC18DF0", VA = "0xC18DF0")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xC18C04", Offset = "0xC18C04", VA = "0xC18C04")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xC18E18", Offset = "0xC18E18", VA = "0xC18E18")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C7")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60002C8")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xC18F8C", Offset = "0xC18F8C", VA = "0xC18F8C")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xC190D4", Offset = "0xC190D4", VA = "0xC190D4", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xC19118", Offset = "0xC19118", VA = "0xC19118", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xC1915C", Offset = "0xC1915C", VA = "0xC1915C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xC191C8", Offset = "0xC191C8", VA = "0xC191C8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xC19268", Offset = "0xC19268", VA = "0xC19268")]
		private void Update()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xC192BC", Offset = "0xC192BC", VA = "0xC192BC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xC195C0", Offset = "0xC195C0", VA = "0xC195C0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xC19600", Offset = "0xC19600", VA = "0xC19600")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xC19A60", Offset = "0xC19A60", VA = "0xC19A60")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xC19B20", Offset = "0xC19B20", VA = "0xC19B20")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xC19CF0", Offset = "0xC19CF0", VA = "0xC19CF0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xC19E98", Offset = "0xC19E98", VA = "0xC19E98")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x200008C")]
		public class SpineEffector
		{
			[Token(Token = "0x4000322")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000323")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight;

			[Token(Token = "0x4000324")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;

			[Token(Token = "0x60002E8")]
			[Address(RVA = "0xC1C018", Offset = "0xC1C018", VA = "0xC1C018")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60002E9")]
			[Address(RVA = "0xC1C028", Offset = "0xC1C028", VA = "0xC1C028")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xC1AF24", Offset = "0xC1AF24", VA = "0xC1AF24")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xC1AF68", Offset = "0xC1AF68", VA = "0xC1AF68", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xC1AFAC", Offset = "0xC1AFAC", VA = "0xC1AFAC", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xC1AFF0", Offset = "0xC1AFF0", VA = "0xC1AFF0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xC1B0D0", Offset = "0xC1B0D0", VA = "0xC1B0D0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xC1B158", Offset = "0xC1B158", VA = "0xC1B158")]
		private void Update()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xC1B3C8", Offset = "0xC1B3C8", VA = "0xC1B3C8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xC1B3D4", Offset = "0xC1B3D4", VA = "0xC1B3D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xC1B1B4", Offset = "0xC1B1B4", VA = "0xC1B1B4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xC1B654", Offset = "0xC1B654", VA = "0xC1B654")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xC1BBBC", Offset = "0xC1BBBC", VA = "0xC1BBBC")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xC1BD40", Offset = "0xC1BD40", VA = "0xC1BD40")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xC1BE74", Offset = "0xC1BE74", VA = "0xC1BE74")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xC1BF88", Offset = "0xC1BF88", VA = "0xC1BF88")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xC1C06C", Offset = "0xC1C06C", VA = "0xC1C06C", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xC1C0B0", Offset = "0xC1C0B0", VA = "0xC1C0B0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xC1C0F4", Offset = "0xC1C0F4", VA = "0xC1C0F4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xC1C10C", Offset = "0xC1C10C", VA = "0xC1C10C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xC1C318", Offset = "0xC1C318", VA = "0xC1C318")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xC1C3F8", Offset = "0xC1C3F8", VA = "0xC1C3F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xC1CA20", Offset = "0xC1CA20", VA = "0xC1CA20")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xC1CE58", Offset = "0xC1CE58", VA = "0xC1CE58")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xC1D004", Offset = "0xC1D004", VA = "0xC1D004")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xC1D38C", Offset = "0xC1D38C", VA = "0xC1D38C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xC1D560", Offset = "0xC1D560", VA = "0xC1D560")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xC1D764", Offset = "0xC1D764", VA = "0xC1D764")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x200008F")]
		public struct Foot
		{
			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x400034F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x6000308")]
			[Address(RVA = "0xC1E288", Offset = "0xC1E288", VA = "0xC1E288")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		[Range(-90f, 0f)]
		public float minRootRotation;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 90f)]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		public float maxRootRotation;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("The head (optional, if you intend to maintain it's rotation).")]
		public Transform head;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xC1D7F4", Offset = "0xC1D7F4", VA = "0xC1D7F4", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xC1D838", Offset = "0xC1D838", VA = "0xC1D838", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xC1D87C", Offset = "0xC1D87C", VA = "0xC1D87C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xC1D8A4", Offset = "0xC1D8A4", VA = "0xC1D8A4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xC1D9A8", Offset = "0xC1D9A8", VA = "0xC1D9A8")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xC1DB8C", Offset = "0xC1DB8C", VA = "0xC1DB8C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xC1DBF0", Offset = "0xC1DBF0", VA = "0xC1DBF0")]
		private void Update()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xC1DC48", Offset = "0xC1DC48", VA = "0xC1DC48")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xC1DF34", Offset = "0xC1DF34", VA = "0xC1DF34")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xC1E2BC", Offset = "0xC1E2BC", VA = "0xC1E2BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xC1E34C", Offset = "0xC1E34C", VA = "0xC1E34C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xC1E64C", Offset = "0xC1E64C", VA = "0xC1E64C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xC1ED0C", Offset = "0xC1ED0C", VA = "0xC1ED0C")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xC1EFC4", Offset = "0xC1EFC4", VA = "0xC1EFC4")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xC1F0F8", Offset = "0xC1F0F8", VA = "0xC1F0F8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xC1F3C0", Offset = "0xC1F3C0", VA = "0xC1F3C0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xC1F3F0", Offset = "0xC1F3F0", VA = "0xC1F3F0")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xC1F5EC", Offset = "0xC1F5EC", VA = "0xC1F5EC")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder VRIK")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the VRIK componet.")]
		public VRIK ik;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xC1F760", Offset = "0xC1F760", VA = "0xC1F760")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xC1F764", Offset = "0xC1F764", VA = "0xC1F764", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xC1F768", Offset = "0xC1F768", VA = "0xC1F768", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xC1F76C", Offset = "0xC1F76C", VA = "0xC1F76C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xC1F784", Offset = "0xC1F784", VA = "0xC1F784")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xC1F80C", Offset = "0xC1F80C", VA = "0xC1F80C")]
		private void Update()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xC1F860", Offset = "0xC1F860", VA = "0xC1F860")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xC1FA98", Offset = "0xC1FA98", VA = "0xC1FA98")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xC1FC8C", Offset = "0xC1FC8C", VA = "0xC1FC8C")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xC1FD10", Offset = "0xC1FD10", VA = "0xC1FD10")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xC1FFAC", Offset = "0xC1FFAC", VA = "0xC1FFAC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xC200E0", Offset = "0xC200E0", VA = "0xC200E0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xC20278", Offset = "0xC20278", VA = "0xC20278")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000091")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000092")]
		public enum Quality
		{
			[Token(Token = "0x400036C")]
			Fastest,
			[Token(Token = "0x400036D")]
			Simple,
			[Token(Token = "0x400036E")]
			Best
		}

		[Token(Token = "0x2000093")]
		public class Leg
		{
			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x1700003C")]
			public bool isGrounded
			{
				[Token(Token = "0x600032E")]
				[Address(RVA = "0xC21618", Offset = "0xC21618", VA = "0xC21618")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600032F")]
				[Address(RVA = "0xC21620", Offset = "0xC21620", VA = "0xC21620")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700003D")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000330")]
				[Address(RVA = "0xC2162C", Offset = "0xC2162C", VA = "0xC2162C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000331")]
				[Address(RVA = "0xC21638", Offset = "0xC21638", VA = "0xC21638")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700003E")]
			public bool initiated
			{
				[Token(Token = "0x6000332")]
				[Address(RVA = "0xC21644", Offset = "0xC21644", VA = "0xC21644")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000333")]
				[Address(RVA = "0xC2164C", Offset = "0xC2164C", VA = "0xC2164C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700003F")]
			public float heightFromGround
			{
				[Token(Token = "0x6000334")]
				[Address(RVA = "0xC21658", Offset = "0xC21658", VA = "0xC21658")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000335")]
				[Address(RVA = "0xC21660", Offset = "0xC21660", VA = "0xC21660")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000040")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000336")]
				[Address(RVA = "0xC21668", Offset = "0xC21668", VA = "0xC21668")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000337")]
				[Address(RVA = "0xC21674", Offset = "0xC21674", VA = "0xC21674")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000041")]
			public Transform transform
			{
				[Token(Token = "0x6000338")]
				[Address(RVA = "0xC21680", Offset = "0xC21680", VA = "0xC21680")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000339")]
				[Address(RVA = "0xC21688", Offset = "0xC21688", VA = "0xC21688")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000042")]
			public float IKOffset
			{
				[Token(Token = "0x600033A")]
				[Address(RVA = "0xC21690", Offset = "0xC21690", VA = "0xC21690")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600033B")]
				[Address(RVA = "0xC21698", Offset = "0xC21698", VA = "0xC21698")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000043")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000340")]
				[Address(RVA = "0xC21C5C", Offset = "0xC21C5C", VA = "0xC21C5C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000044")]
			private float rootYOffset
			{
				[Token(Token = "0x6000349")]
				[Address(RVA = "0xC21DD0", Offset = "0xC21DD0", VA = "0xC21DD0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600033C")]
			[Address(RVA = "0xC207F0", Offset = "0xC207F0", VA = "0xC207F0")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x600033D")]
			[Address(RVA = "0xC216A0", Offset = "0xC216A0", VA = "0xC216A0")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600033E")]
			[Address(RVA = "0xC21288", Offset = "0xC21288", VA = "0xC21288")]
			public void Reset()
			{
			}

			[Token(Token = "0x600033F")]
			[Address(RVA = "0xC208E0", Offset = "0xC208E0", VA = "0xC208E0")]
			public void Process()
			{
			}

			[Token(Token = "0x6000341")]
			[Address(RVA = "0xC219DC", Offset = "0xC219DC", VA = "0xC219DC")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000342")]
			[Address(RVA = "0xC216E0", Offset = "0xC216E0", VA = "0xC216E0")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000343")]
			[Address(RVA = "0xC21CF0", Offset = "0xC21CF0", VA = "0xC21CF0")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000344")]
			[Address(RVA = "0xC21840", Offset = "0xC21840", VA = "0xC21840")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000345")]
			[Address(RVA = "0xC218C0", Offset = "0xC218C0", VA = "0xC218C0")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000346")]
			[Address(RVA = "0xC21D5C", Offset = "0xC21D5C", VA = "0xC21D5C")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000347")]
			[Address(RVA = "0xC21C90", Offset = "0xC21C90", VA = "0xC21C90")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000348")]
			[Address(RVA = "0xC21E74", Offset = "0xC21E74", VA = "0xC21E74")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600034A")]
			[Address(RVA = "0xC20750", Offset = "0xC20750", VA = "0xC20750")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000094")]
		public class Pelvis
		{
			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x17000045")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x600034B")]
				[Address(RVA = "0xC22024", Offset = "0xC22024", VA = "0xC22024")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600034C")]
				[Address(RVA = "0xC22030", Offset = "0xC22030", VA = "0xC22030")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000046")]
			public float heightOffset
			{
				[Token(Token = "0x600034D")]
				[Address(RVA = "0xC2203C", Offset = "0xC2203C", VA = "0xC2203C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600034E")]
				[Address(RVA = "0xC22044", Offset = "0xC22044", VA = "0xC22044")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600034F")]
			[Address(RVA = "0xC208B8", Offset = "0xC208B8", VA = "0xC208B8")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000350")]
			[Address(RVA = "0xC211F4", Offset = "0xC211F4", VA = "0xC211F4")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000351")]
			[Address(RVA = "0xC2204C", Offset = "0xC2204C", VA = "0xC2204C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000352")]
			[Address(RVA = "0xC21008", Offset = "0xC21008", VA = "0xC21008")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000353")]
			[Address(RVA = "0xC207E8", Offset = "0xC207E8", VA = "0xC207E8")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Offset of the foot center along character forward axis.")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		public float footRotationWeight;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 90f)]
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		public float pelvisDamper;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Quality quality;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000034")]
		public Leg[] legs
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0xC202D0", Offset = "0xC202D0", VA = "0xC202D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000317")]
			[Address(RVA = "0xC202D8", Offset = "0xC202D8", VA = "0xC202D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0xC202E0", Offset = "0xC202E0", VA = "0xC202E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000319")]
			[Address(RVA = "0xC202E8", Offset = "0xC202E8", VA = "0xC202E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public bool isGrounded
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0xC202F0", Offset = "0xC202F0", VA = "0xC202F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600031B")]
			[Address(RVA = "0xC202F8", Offset = "0xC202F8", VA = "0xC202F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public Transform root
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0xC20304", Offset = "0xC20304", VA = "0xC20304")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600031D")]
			[Address(RVA = "0xC2030C", Offset = "0xC2030C", VA = "0xC2030C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0xC20314", Offset = "0xC20314", VA = "0xC20314")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x600031F")]
			[Address(RVA = "0xC2032C", Offset = "0xC2032C", VA = "0xC2032C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0xC2034C", Offset = "0xC2034C", VA = "0xC2034C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003A")]
		public Vector3 up
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0xC205EC", Offset = "0xC205EC", VA = "0xC205EC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003B")]
		private bool useRootRotation
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0xC2131C", Offset = "0xC2131C", VA = "0xC2131C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xC20394", Offset = "0xC20394", VA = "0xC20394")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xC20654", Offset = "0xC20654", VA = "0xC20654")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xC1B3E0", Offset = "0xC1B3E0", VA = "0xC1B3E0")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xC1B9C8", Offset = "0xC1B9C8", VA = "0xC1B9C8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xC1C8A8", Offset = "0xC1C8A8", VA = "0xC1C8A8")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xC1B058", Offset = "0xC1B058", VA = "0xC1B058")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xC208C8", Offset = "0xC208C8", VA = "0xC208C8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xC213D0", Offset = "0xC213D0", VA = "0xC213D0")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xC21454", Offset = "0xC21454", VA = "0xC21454")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xC215A8", Offset = "0xC215A8", VA = "0xC215A8")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xC1F718", Offset = "0xC1F718", VA = "0xC1F718")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	public class AimIK : IK
	{
		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xC220A0", Offset = "0xC220A0", VA = "0xC220A0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xC220E4", Offset = "0xC220E4", VA = "0xC220E4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xC22128", Offset = "0xC22128", VA = "0xC22128")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xC2216C", Offset = "0xC2216C", VA = "0xC2216C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xC221B0", Offset = "0xC221B0", VA = "0xC221B0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xC221F4", Offset = "0xC221F4", VA = "0xC221F4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xC221FC", Offset = "0xC221FC", VA = "0xC221FC")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xC2226C", Offset = "0xC2226C", VA = "0xC2226C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xC222B0", Offset = "0xC222B0", VA = "0xC222B0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xC222F4", Offset = "0xC222F4", VA = "0xC222F4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xC22338", Offset = "0xC22338", VA = "0xC22338")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xC2237C", Offset = "0xC2237C", VA = "0xC2237C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xC22384", Offset = "0xC22384", VA = "0xC22384")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xC223EC", Offset = "0xC223EC", VA = "0xC223EC", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xC22430", Offset = "0xC22430", VA = "0xC22430", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xC22474", Offset = "0xC22474", VA = "0xC22474")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xC224B8", Offset = "0xC224B8", VA = "0xC224B8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xC224FC", Offset = "0xC224FC", VA = "0xC224FC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xC22504", Offset = "0xC22504", VA = "0xC22504")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000098")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xC2256C", Offset = "0xC2256C", VA = "0xC2256C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xC225B0", Offset = "0xC225B0", VA = "0xC225B0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xC225F4", Offset = "0xC225F4", VA = "0xC225F4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xC22638", Offset = "0xC22638", VA = "0xC22638")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xC2267C", Offset = "0xC2267C", VA = "0xC2267C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xC22684", Offset = "0xC22684", VA = "0xC22684")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000099")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xC226EC", Offset = "0xC226EC", VA = "0xC226EC", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xC22730", Offset = "0xC22730", VA = "0xC22730", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xC22774", Offset = "0xC22774", VA = "0xC22774")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xC227B8", Offset = "0xC227B8", VA = "0xC227B8")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xC227FC", Offset = "0xC227FC", VA = "0xC227FC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xC22840", Offset = "0xC22840", VA = "0xC22840")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xC22884", Offset = "0xC22884", VA = "0xC22884")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xC228A8", Offset = "0xC228A8", VA = "0xC228A8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xC228B0", Offset = "0xC228B0", VA = "0xC228B0")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xC22A6C", Offset = "0xC22A6C", VA = "0xC22A6C")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xC22F1C", Offset = "0xC22F1C", VA = "0xC22F1C")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xC22F3C", Offset = "0xC22F3C", VA = "0xC22F3C")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xC23014", Offset = "0xC23014", VA = "0xC23014")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x600037A")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xC230AC", Offset = "0xC230AC", VA = "0xC230AC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xC23124", Offset = "0xC23124", VA = "0xC23124", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xC23194", Offset = "0xC23194", VA = "0xC23194", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600037E")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600037F")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xC22264", Offset = "0xC22264", VA = "0xC22264")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000047")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0xC231E4", Offset = "0xC231E4", VA = "0xC231E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xC23270", Offset = "0xC23270", VA = "0xC23270")]
		private void Start()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xC232D4", Offset = "0xC232D4", VA = "0xC232D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xC23374", Offset = "0xC23374", VA = "0xC23374")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xC233A0", Offset = "0xC233A0", VA = "0xC233A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xC232F8", Offset = "0xC232F8", VA = "0xC232F8")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xC23424", Offset = "0xC23424", VA = "0xC23424")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200009C")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xC2342C", Offset = "0xC2342C", VA = "0xC2342C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xC23494", Offset = "0xC23494", VA = "0xC23494", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xC234FC", Offset = "0xC234FC", VA = "0xC234FC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xC23540", Offset = "0xC23540", VA = "0xC23540")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xC23584", Offset = "0xC23584", VA = "0xC23584", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xC2358C", Offset = "0xC2358C", VA = "0xC2358C")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xC235F4", Offset = "0xC235F4", VA = "0xC235F4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xC23638", Offset = "0xC23638", VA = "0xC23638", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xC2367C", Offset = "0xC2367C", VA = "0xC2367C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xC236C0", Offset = "0xC236C0", VA = "0xC236C0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xC23704", Offset = "0xC23704", VA = "0xC23704", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xC2370C", Offset = "0xC2370C", VA = "0xC2370C")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page8.html")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xC23774", Offset = "0xC23774", VA = "0xC23774", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xC237B8", Offset = "0xC237B8", VA = "0xC237B8", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xC237FC", Offset = "0xC237FC", VA = "0xC237FC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xC23840", Offset = "0xC23840", VA = "0xC23840")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xC23884", Offset = "0xC23884", VA = "0xC23884", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xC2388C", Offset = "0xC2388C", VA = "0xC2388C")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xC238F4", Offset = "0xC238F4", VA = "0xC238F4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xC23938", Offset = "0xC23938", VA = "0xC23938", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xC2397C", Offset = "0xC2397C", VA = "0xC2397C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xC239C0", Offset = "0xC239C0", VA = "0xC239C0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xC23A04", Offset = "0xC23A04", VA = "0xC23A04", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xC23A0C", Offset = "0xC23A0C", VA = "0xC23A0C")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x20000A1")]
		public class References
		{
			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform chest;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform neck;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform leftShoulder;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Transform rightShoulder;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Transform leftThigh;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Transform leftCalf;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Transform leftFoot;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Transform leftToes;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public Transform rightThigh;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Transform rightCalf;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Transform rightFoot;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public Transform rightToes;

			[Token(Token = "0x17000048")]
			public bool isFilled
			{
				[Token(Token = "0x60003A9")]
				[Address(RVA = "0xC24388", Offset = "0xC24388", VA = "0xC24388")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000049")]
			public bool isEmpty
			{
				[Token(Token = "0x60003AA")]
				[Address(RVA = "0xC23FCC", Offset = "0xC23FCC", VA = "0xC23FCC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60003A8")]
			[Address(RVA = "0xC246F4", Offset = "0xC246F4", VA = "0xC246F4")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60003AB")]
			[Address(RVA = "0xC23BA4", Offset = "0xC23BA4", VA = "0xC23BA4")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60003AC")]
			[Address(RVA = "0xC246EC", Offset = "0xC246EC", VA = "0xC246EC")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character.")]
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		public References references;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xC23A74", Offset = "0xC23A74", VA = "0xC23A74", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xC23ADC", Offset = "0xC23ADC", VA = "0xC23ADC", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xC23B44", Offset = "0xC23B44", VA = "0xC23B44")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xC23B88", Offset = "0xC23B88", VA = "0xC23B88")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xC23F30", Offset = "0xC23F30", VA = "0xC23F30")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xC23F58", Offset = "0xC23F58", VA = "0xC23F58", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xC23F60", Offset = "0xC23F60", VA = "0xC23F60", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xC24654", Offset = "0xC24654", VA = "0xC24654")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A2")]
	public class FABRIKChain
	{
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xC24B30", Offset = "0xC24B30", VA = "0xC24B30")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xC24BF4", Offset = "0xC24BF4", VA = "0xC24BF4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xC24C14", Offset = "0xC24C14", VA = "0xC24C14")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xC24E68", Offset = "0xC24E68", VA = "0xC24E68")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xC24CD4", Offset = "0xC24CD4", VA = "0xC24CD4")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xC24F4C", Offset = "0xC24F4C", VA = "0xC24F4C")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xC24FAC", Offset = "0xC24FAC", VA = "0xC24FAC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xC25448", Offset = "0xC25448", VA = "0xC25448")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xC255DC", Offset = "0xC255DC", VA = "0xC255DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xC256E8", Offset = "0xC256E8", VA = "0xC256E8")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A5")]
		public class BendBone
		{
			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight of rotating this bone.")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60003C5")]
			[Address(RVA = "0xC28840", Offset = "0xC28840", VA = "0xC28840")]
			public BendBone()
			{
			}

			[Token(Token = "0x60003C6")]
			[Address(RVA = "0xC288A0", Offset = "0xC288A0", VA = "0xC288A0")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60003C7")]
			[Address(RVA = "0xC25F50", Offset = "0xC25F50", VA = "0xC25F50")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60003C8")]
			[Address(RVA = "0xC26320", Offset = "0xC26320", VA = "0xC26320")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("Master weight for positioning the head.")]
		[LargeHeader("Position")]
		public float positionWeight;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The weight of moving the body along with the head")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The weight of moving the thighs along with the head")]
		[Range(0f, 1f)]
		public float thighWeight;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The weight of rotating the head bone after solving")]
		[LargeHeader("Rotation")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the body")]
		public float bodyClampWeight;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the head")]
		public float headClampWeight;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		[Range(0f, 1f)]
		public float bendWeight;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[LargeHeader("CCD")]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[Range(0f, 1f)]
		public float CCDWeight;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The weight of rolling the bones in towards the target")]
		[Range(0f, 1f)]
		public float roll;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1000f)]
		[Tooltip("Smoothing the CCD effect.")]
		public float damper;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		[LargeHeader("Stretching")]
		public float postStretchWeight;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float chestDirectionWeight;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xC256F0", Offset = "0xC256F0", VA = "0xC256F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xC25ADC", Offset = "0xC25ADC", VA = "0xC25ADC")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xC25F7C", Offset = "0xC25F7C", VA = "0xC25F7C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xC26348", Offset = "0xC26348", VA = "0xC26348")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xC26C44", Offset = "0xC26C44", VA = "0xC26C44")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xC2703C", Offset = "0xC2703C", VA = "0xC2703C")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xC2744C", Offset = "0xC2744C", VA = "0xC2744C")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xC27DC4", Offset = "0xC27DC4", VA = "0xC27DC4")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xC26988", Offset = "0xC26988", VA = "0xC26988")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xC28000", Offset = "0xC28000", VA = "0xC28000")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xC27CE4", Offset = "0xC27CE4", VA = "0xC27CE4")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xC27BE4", Offset = "0xC27BE4", VA = "0xC27BE4")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xC28360", Offset = "0xC28360", VA = "0xC28360")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xC28698", Offset = "0xC28698", VA = "0xC28698")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A6")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x20000A7")]
		public class ChildConstraint
		{
			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x1700004A")]
			public float nominalDistance
			{
				[Token(Token = "0x60003DD")]
				[Address(RVA = "0xC2B84C", Offset = "0xC2B84C", VA = "0xC2B84C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60003DE")]
				[Address(RVA = "0xC2B854", Offset = "0xC2B854", VA = "0xC2B854")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700004B")]
			public bool isRigid
			{
				[Token(Token = "0x60003DF")]
				[Address(RVA = "0xC2B85C", Offset = "0xC2B85C", VA = "0xC2B85C")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003E0")]
				[Address(RVA = "0xC2B864", Offset = "0xC2B864", VA = "0xC2B864")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60003E1")]
			[Address(RVA = "0xC2B870", Offset = "0xC2B870", VA = "0xC2B870")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60003E2")]
			[Address(RVA = "0xC29560", Offset = "0xC29560", VA = "0xC29560")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60003E3")]
			[Address(RVA = "0xC29C04", Offset = "0xC29C04", VA = "0xC29C04")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60003E4")]
			[Address(RVA = "0xC2B610", Offset = "0xC2B610", VA = "0xC2B610")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A8")]
		public enum Smoothing
		{
			[Token(Token = "0x400040B")]
			None,
			[Token(Token = "0x400040C")]
			Exponential,
			[Token(Token = "0x400040D")]
			Cubic
		}

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float push;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(-1f, 1f)]
		public float pushParent;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float reach;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x40003FF")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xC2891C", Offset = "0xC2891C", VA = "0xC2891C")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xC28A84", Offset = "0xC28A84", VA = "0xC28A84")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xC28BB8", Offset = "0xC28BB8", VA = "0xC28BB8")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xC28CD0", Offset = "0xC28CD0", VA = "0xC28CD0")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xC28D8C", Offset = "0xC28D8C", VA = "0xC28D8C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xC28E98", Offset = "0xC28E98", VA = "0xC28E98")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xC29820", Offset = "0xC29820", VA = "0xC29820")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xC29004", Offset = "0xC29004", VA = "0xC29004")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xC29DE8", Offset = "0xC29DE8", VA = "0xC29DE8")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xC2A07C", Offset = "0xC2A07C", VA = "0xC2A07C")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xC2A34C", Offset = "0xC2A34C", VA = "0xC2A34C")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xC2AD14", Offset = "0xC2AD14", VA = "0xC2AD14")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xC2B20C", Offset = "0xC2B20C", VA = "0xC2B20C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xC2B40C", Offset = "0xC2B40C", VA = "0xC2B40C")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xC2B0F8", Offset = "0xC2B0F8", VA = "0xC2B0F8")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xC2ABB4", Offset = "0xC2ABB4", VA = "0xC2ABB4")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xC2B094", Offset = "0xC2B094", VA = "0xC2B094")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xC2B4E8", Offset = "0xC2B4E8", VA = "0xC2B4E8")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xC2AFC0", Offset = "0xC2AFC0", VA = "0xC2AFC0")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xC2B310", Offset = "0xC2B310", VA = "0xC2B310")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A9")]
	public class IKConstraintBend
	{
		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x1700004C")]
		public bool initiated
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0xC2BA88", Offset = "0xC2BA88", VA = "0xC2BA88")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0xC2BA90", Offset = "0xC2BA90", VA = "0xC2BA90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xC2B8B0", Offset = "0xC2B8B0", VA = "0xC2B8B0")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xC28A18", Offset = "0xC28A18", VA = "0xC28A18")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xC2BA9C", Offset = "0xC2BA9C", VA = "0xC2BA9C")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xC295B4", Offset = "0xC295B4", VA = "0xC295B4")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xC295C0", Offset = "0xC295C0", VA = "0xC295C0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xC2BC70", Offset = "0xC2BC70", VA = "0xC2BC70")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xC2BFBC", Offset = "0xC2BFBC", VA = "0xC2BFBC")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xC2A584", Offset = "0xC2A584", VA = "0xC2A584")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xC2BB28", Offset = "0xC2BB28", VA = "0xC2BB28")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xC2BBCC", Offset = "0xC2BBCC", VA = "0xC2BBCC")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000AA")]
	public class IKEffector
	{
		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x1700004D")]
		public bool isEndEffector
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0xC2C384", Offset = "0xC2C384", VA = "0xC2C384")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0xC2C38C", Offset = "0xC2C38C", VA = "0xC2C38C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xC28304", Offset = "0xC28304", VA = "0xC28304")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xC2C398", Offset = "0xC2C398", VA = "0xC2C398")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xC2C41C", Offset = "0xC2C41C", VA = "0xC2C41C")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xC2C5BC", Offset = "0xC2C5BC", VA = "0xC2C5BC")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xC2C778", Offset = "0xC2C778", VA = "0xC2C778")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xC2CA6C", Offset = "0xC2CA6C", VA = "0xC2CA6C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xC2CD0C", Offset = "0xC2CD0C", VA = "0xC2CD0C")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xC2CE2C", Offset = "0xC2CE2C", VA = "0xC2CE2C")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xC2CEC8", Offset = "0xC2CEC8", VA = "0xC2CEC8")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xC2D57C", Offset = "0xC2D57C", VA = "0xC2D57C")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xC2D5D4", Offset = "0xC2D5D4", VA = "0xC2D5D4")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xC2D7A8", Offset = "0xC2D7A8", VA = "0xC2D7A8")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xC2DA04", Offset = "0xC2DA04", VA = "0xC2DA04")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000AB")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000AC")]
		public class BoneMap
		{
			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x1700004E")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x6000406")]
				[Address(RVA = "0xC2DFC0", Offset = "0xC2DFC0", VA = "0xC2DFC0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700004F")]
			public bool isNodeBone
			{
				[Token(Token = "0x6000409")]
				[Address(RVA = "0xC2E078", Offset = "0xC2E078", VA = "0xC2E078")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000050")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x600041D")]
				[Address(RVA = "0xC2E434", Offset = "0xC2E434", VA = "0xC2E434")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000405")]
			[Address(RVA = "0xC2DF24", Offset = "0xC2DF24", VA = "0xC2DF24")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000407")]
			[Address(RVA = "0xC2DFF0", Offset = "0xC2DFF0", VA = "0xC2DFF0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000408")]
			[Address(RVA = "0xC2E034", Offset = "0xC2E034", VA = "0xC2E034")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x600040A")]
			[Address(RVA = "0xC2E088", Offset = "0xC2E088", VA = "0xC2E088")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0xC2E15C", Offset = "0xC2E15C", VA = "0xC2E15C")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x600040C")]
			[Address(RVA = "0xC2E164", Offset = "0xC2E164", VA = "0xC2E164")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0xC2E230", Offset = "0xC2E230", VA = "0xC2E230")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x600040E")]
			[Address(RVA = "0xC2E29C", Offset = "0xC2E29C", VA = "0xC2E29C")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x600040F")]
			[Address(RVA = "0xC2E324", Offset = "0xC2E324", VA = "0xC2E324")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000410")]
			[Address(RVA = "0xC2E59C", Offset = "0xC2E59C", VA = "0xC2E59C")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000411")]
			[Address(RVA = "0xC2E5C8", Offset = "0xC2E5C8", VA = "0xC2E5C8")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000412")]
			[Address(RVA = "0xC2E5F4", Offset = "0xC2E5F4", VA = "0xC2E5F4")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0xC2E61C", Offset = "0xC2E61C", VA = "0xC2E61C")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000414")]
			[Address(RVA = "0xC2E72C", Offset = "0xC2E72C", VA = "0xC2E72C")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0xC2E8B0", Offset = "0xC2E8B0", VA = "0xC2E8B0")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000416")]
			[Address(RVA = "0xC2E8D4", Offset = "0xC2E8D4", VA = "0xC2E8D4")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000417")]
			[Address(RVA = "0xC2E9F4", Offset = "0xC2E9F4", VA = "0xC2E9F4")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000418")]
			[Address(RVA = "0xC2EA58", Offset = "0xC2EA58", VA = "0xC2EA58")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000419")]
			[Address(RVA = "0xC2EBD8", Offset = "0xC2EBD8", VA = "0xC2EBD8")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x600041A")]
			[Address(RVA = "0xC2ED58", Offset = "0xC2ED58", VA = "0xC2ED58")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x600041B")]
			[Address(RVA = "0xC2EDD4", Offset = "0xC2EDD4", VA = "0xC2EDD4")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600041C")]
			[Address(RVA = "0xC2E7A0", Offset = "0xC2E7A0", VA = "0xC2E7A0")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600041E")]
			[Address(RVA = "0xC2EEF0", Offset = "0xC2EEF0", VA = "0xC2EEF0")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xC2DCC0", Offset = "0xC2DCC0", VA = "0xC2DCC0", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xC2DCC8", Offset = "0xC2DCC8", VA = "0xC2DCC8", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xC2DCCC", Offset = "0xC2DCCC", VA = "0xC2DCCC")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xC2DE08", Offset = "0xC2DE08", VA = "0xC2DE08")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xC2DF1C", Offset = "0xC2DF1C", VA = "0xC2DF1C")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AD")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xC2EF0C", Offset = "0xC2EF0C", VA = "0xC2EF0C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xC2EFA8", Offset = "0xC2EFA8", VA = "0xC2EFA8")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xC2F02C", Offset = "0xC2F02C", VA = "0xC2F02C")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xC2F0C4", Offset = "0xC2F0C4", VA = "0xC2F0C4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xC2F0DC", Offset = "0xC2F0DC", VA = "0xC2F0DC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xC2F0F8", Offset = "0xC2F0F8", VA = "0xC2F0F8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xC2F184", Offset = "0xC2F184", VA = "0xC2F184")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xC2F19C", Offset = "0xC2F19C", VA = "0xC2F19C")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AE")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000AF")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000463")]
			Parent,
			[Token(Token = "0x4000464")]
			Bone1,
			[Token(Token = "0x4000465")]
			Bone2,
			[Token(Token = "0x4000466")]
			Bone3
		}

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xC2F1C0", Offset = "0xC2F1C0", VA = "0xC2F1C0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xC2F234", Offset = "0xC2F234", VA = "0xC2F234")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xC2F2FC", Offset = "0xC2F2FC", VA = "0xC2F2FC")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xC2F5B4", Offset = "0xC2F5B4", VA = "0xC2F5B4")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xC2F6C8", Offset = "0xC2F6C8", VA = "0xC2F6C8")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xC2F808", Offset = "0xC2F808", VA = "0xC2F808")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xC2F814", Offset = "0xC2F814", VA = "0xC2F814")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xC2F8AC", Offset = "0xC2F8AC", VA = "0xC2F8AC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xC2F954", Offset = "0xC2F954", VA = "0xC2F954", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xC2FBB0", Offset = "0xC2FBB0", VA = "0xC2FBB0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xC2FC10", Offset = "0xC2FC10", VA = "0xC2FC10")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(1f, 3f)]
		public int iterations;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float twistWeight;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xC2FD54", Offset = "0xC2FD54", VA = "0xC2FD54", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xC30074", Offset = "0xC30074", VA = "0xC30074")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xC301B0", Offset = "0xC301B0", VA = "0xC301B0")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xC30320", Offset = "0xC30320", VA = "0xC30320")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xC30330", Offset = "0xC30330", VA = "0xC30330")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xC3038C", Offset = "0xC3038C", VA = "0xC3038C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xC30404", Offset = "0xC30404", VA = "0xC30404", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xC30A18", Offset = "0xC30A18", VA = "0xC30A18")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xC30A50", Offset = "0xC30A50", VA = "0xC30A50")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xC30CB4", Offset = "0xC30CB4", VA = "0xC30CB4")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xC30FD4", Offset = "0xC30FD4", VA = "0xC30FD4")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xC310B4", Offset = "0xC310B4", VA = "0xC310B4")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xC31168", Offset = "0xC31168", VA = "0xC31168")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000B2")]
		public class Point
		{
			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000455")]
			[Address(RVA = "0xC31A30", Offset = "0xC31A30", VA = "0xC31A30")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0xC31A74", Offset = "0xC31A74", VA = "0xC31A74")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0xC31B54", Offset = "0xC31B54", VA = "0xC31B54")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0xC31B80", Offset = "0xC31B80", VA = "0xC31B80")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0xC31BAC", Offset = "0xC31BAC", VA = "0xC31BAC")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0xC31BF0", Offset = "0xC31BF0", VA = "0xC31BF0")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0xC31C34", Offset = "0xC31C34", VA = "0xC31C34")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B3")]
		public class Bone : Point
		{
			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x17000052")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600045C")]
				[Address(RVA = "0xC31C94", Offset = "0xC31C94", VA = "0xC31C94")]
				get
				{
					return null;
				}
				[Token(Token = "0x600045D")]
				[Address(RVA = "0xC31D74", Offset = "0xC31D74", VA = "0xC31D74")]
				set
				{
				}
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0xC31DEC", Offset = "0xC31DEC", VA = "0xC31DEC")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0xC32058", Offset = "0xC32058", VA = "0xC32058")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0xC32314", Offset = "0xC32314", VA = "0xC32314")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0xC32508", Offset = "0xC32508", VA = "0xC32508")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0xC32530", Offset = "0xC32530", VA = "0xC32530")]
			public Bone()
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0xC3259C", Offset = "0xC3259C", VA = "0xC3259C")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0xC32614", Offset = "0xC32614", VA = "0xC32614")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B4")]
		public class Node : Point
		{
			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000465")]
			[Address(RVA = "0xC3269C", Offset = "0xC3269C", VA = "0xC3269C")]
			public Node()
			{
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0xC326A0", Offset = "0xC326A0", VA = "0xC326A0")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0xC326C4", Offset = "0xC326C4", VA = "0xC326C4")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000B5")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000B6")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The positional or the master weight of the solver.")]
		[Range(0f, 1f)]
		public float IKPositionWeight;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		protected Transform root;

		[Token(Token = "0x17000051")]
		public bool initiated
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0xC3163C", Offset = "0xC3163C", VA = "0xC3163C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000449")]
			[Address(RVA = "0xC31644", Offset = "0xC31644", VA = "0xC31644")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xC313A4", Offset = "0xC313A4", VA = "0xC313A4")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000440")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xC31418", Offset = "0xC31418", VA = "0xC31418")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xC31588", Offset = "0xC31588", VA = "0xC31588")]
		public void Update()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xC315F8", Offset = "0xC315F8", VA = "0xC315F8", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xC31604", Offset = "0xC31604", VA = "0xC31604")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xC31610", Offset = "0xC31610", VA = "0xC31610")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xC31618", Offset = "0xC31618", VA = "0xC31618")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xC31634", Offset = "0xC31634", VA = "0xC31634")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x600044A")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x600044B")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x600044C")]
		public abstract void FixTransforms();

		[Token(Token = "0x600044D")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x600044E")]
		protected abstract void OnInitiate();

		[Token(Token = "0x600044F")]
		protected abstract void OnUpdate();

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xC31650", Offset = "0xC31650", VA = "0xC31650")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xC31668", Offset = "0xC31668", VA = "0xC31668")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xC3178C", Offset = "0xC3178C", VA = "0xC3178C")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xC31824", Offset = "0xC31824", VA = "0xC31824")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xC31A18", Offset = "0xC31A18", VA = "0xC31A18")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B7")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float poleWeight;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000053")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000471")]
			[Address(RVA = "0xC32A4C", Offset = "0xC32A4C", VA = "0xC32A4C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000054")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0xC32A7C", Offset = "0xC32A7C", VA = "0xC32A7C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000055")]
		protected override int minBones
		{
			[Token(Token = "0x6000475")]
			[Address(RVA = "0xC336B0", Offset = "0xC336B0", VA = "0xC336B0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000056")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0xC33BF0", Offset = "0xC33BF0", VA = "0xC33BF0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xC32914", Offset = "0xC32914", VA = "0xC32914")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xC32AAC", Offset = "0xC32AAC", VA = "0xC32AAC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xC32D38", Offset = "0xC32D38", VA = "0xC32D38", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xC33608", Offset = "0xC33608", VA = "0xC33608")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xC332A4", Offset = "0xC332A4", VA = "0xC332A4")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xC336B8", Offset = "0xC336B8", VA = "0xC336B8")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xC33C50", Offset = "0xC33C50", VA = "0xC33C50")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B8")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xC33D64", Offset = "0xC33D64", VA = "0xC33D64")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xC33DD4", Offset = "0xC33DD4", VA = "0xC33DD4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xC342C8", Offset = "0xC342C8", VA = "0xC342C8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xC3499C", Offset = "0xC3499C", VA = "0xC3499C")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xC3502C", Offset = "0xC3502C", VA = "0xC3502C")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B9")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000057")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0xC35FF8", Offset = "0xC35FF8", VA = "0xC35FF8", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xC35030", Offset = "0xC35030", VA = "0xC35030")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xC35610", Offset = "0xC35610", VA = "0xC35610")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xC35740", Offset = "0xC35740", VA = "0xC35740", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xC357C8", Offset = "0xC357C8", VA = "0xC357C8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xC35CC0", Offset = "0xC35CC0", VA = "0xC35CC0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xC36000", Offset = "0xC36000", VA = "0xC36000")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xC35108", Offset = "0xC35108", VA = "0xC35108")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xC356F8", Offset = "0xC356F8", VA = "0xC356F8")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xC35FB0", Offset = "0xC35FB0", VA = "0xC35FB0")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xC354A4", Offset = "0xC354A4", VA = "0xC354A4")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xC366AC", Offset = "0xC366AC", VA = "0xC366AC")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xC36714", Offset = "0xC36714", VA = "0xC36714")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xC367E4", Offset = "0xC367E4", VA = "0xC367E4")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xC368AC", Offset = "0xC368AC", VA = "0xC368AC")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xC35A38", Offset = "0xC35A38", VA = "0xC35A38")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xC35B7C", Offset = "0xC35B7C", VA = "0xC35B7C")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xC3699C", Offset = "0xC3699C", VA = "0xC3699C")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xC3629C", Offset = "0xC3629C", VA = "0xC3629C")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xC356E8", Offset = "0xC356E8", VA = "0xC356E8")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xC3700C", Offset = "0xC3700C", VA = "0xC3700C")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xC36B5C", Offset = "0xC36B5C", VA = "0xC36B5C")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xC3611C", Offset = "0xC3611C", VA = "0xC3611C")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xC361EC", Offset = "0xC361EC", VA = "0xC361EC")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xC370C4", Offset = "0xC370C4", VA = "0xC370C4")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BA")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float rootPin;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xC37144", Offset = "0xC37144", VA = "0xC37144", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xC37798", Offset = "0xC37798", VA = "0xC37798", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xC37824", Offset = "0xC37824", VA = "0xC37824", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xC378B8", Offset = "0xC378B8", VA = "0xC378B8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xC379A0", Offset = "0xC379A0", VA = "0xC379A0")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xC37A30", Offset = "0xC37A30", VA = "0xC37A30", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xC37E30", Offset = "0xC37E30", VA = "0xC37E30", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xC38008", Offset = "0xC38008", VA = "0xC38008", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xC37ED0", Offset = "0xC37ED0", VA = "0xC37ED0")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xC37C08", Offset = "0xC37C08", VA = "0xC37C08")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xC3808C", Offset = "0xC3808C", VA = "0xC3808C")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BB")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 10f)]
		public int iterations;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xC380FC", Offset = "0xC380FC", VA = "0xC380FC")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xC381D8", Offset = "0xC381D8", VA = "0xC381D8")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xC38220", Offset = "0xC38220", VA = "0xC38220")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xC2E6DC", Offset = "0xC2E6DC", VA = "0xC2E6DC")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xC2DF4C", Offset = "0xC2DF4C", VA = "0xC2DF4C")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xC38334", Offset = "0xC38334", VA = "0xC38334", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xC384AC", Offset = "0xC384AC", VA = "0xC384AC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xC38608", Offset = "0xC38608", VA = "0xC38608", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xC38808", Offset = "0xC38808", VA = "0xC38808", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xC388D8", Offset = "0xC388D8", VA = "0xC388D8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xC389B4", Offset = "0xC389B4", VA = "0xC389B4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xC38B14", Offset = "0xC38B14", VA = "0xC38B14", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xC38CB0", Offset = "0xC38CB0", VA = "0xC38CB0", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xC38EE4", Offset = "0xC38EE4", VA = "0xC38EE4", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xC391C4", Offset = "0xC391C4", VA = "0xC391C4", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xC391FC", Offset = "0xC391FC", VA = "0xC391FC", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xC392D4", Offset = "0xC392D4", VA = "0xC392D4")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BC")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40004B4")]
		Body,
		[Token(Token = "0x40004B5")]
		LeftShoulder,
		[Token(Token = "0x40004B6")]
		RightShoulder,
		[Token(Token = "0x40004B7")]
		LeftThigh,
		[Token(Token = "0x40004B8")]
		RightThigh,
		[Token(Token = "0x40004B9")]
		LeftHand,
		[Token(Token = "0x40004BA")]
		RightHand,
		[Token(Token = "0x40004BB")]
		LeftFoot,
		[Token(Token = "0x40004BC")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x20000BD")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40004BE")]
		LeftArm,
		[Token(Token = "0x40004BF")]
		RightArm,
		[Token(Token = "0x40004C0")]
		LeftLeg,
		[Token(Token = "0x40004C1")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x20000BE")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Range(0f, 1f)]
		public float spineStiffness;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[Range(-1f, 1f)]
		public float pullBodyVertical;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000058")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0xC393EC", Offset = "0xC393EC", VA = "0xC393EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0xC3952C", Offset = "0xC3952C", VA = "0xC3952C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0xC39534", Offset = "0xC39534", VA = "0xC39534")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0xC3953C", Offset = "0xC3953C", VA = "0xC3953C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0xC39544", Offset = "0xC39544", VA = "0xC39544")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0xC3954C", Offset = "0xC3954C", VA = "0xC3954C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0xC39554", Offset = "0xC39554", VA = "0xC39554")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0xC3955C", Offset = "0xC3955C", VA = "0xC3955C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0xC39564", Offset = "0xC39564", VA = "0xC39564")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0xC3956C", Offset = "0xC3956C", VA = "0xC3956C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0xC39598", Offset = "0xC39598", VA = "0xC39598")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0xC395C4", Offset = "0xC395C4", VA = "0xC395C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0xC395F0", Offset = "0xC395F0", VA = "0xC395F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0xC3961C", Offset = "0xC3961C", VA = "0xC3961C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0xC39644", Offset = "0xC39644", VA = "0xC39644")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0xC39670", Offset = "0xC39670", VA = "0xC39670")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0xC3969C", Offset = "0xC3969C", VA = "0xC3969C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0xC396C8", Offset = "0xC396C8", VA = "0xC396C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0xC3B460", Offset = "0xC3B460", VA = "0xC3B460")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0xC3B46C", Offset = "0xC3B46C", VA = "0xC3B46C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xC396F0", Offset = "0xC396F0", VA = "0xC396F0")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xC397F0", Offset = "0xC397F0", VA = "0xC397F0")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xC39740", Offset = "0xC39740", VA = "0xC39740")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xC39868", Offset = "0xC39868", VA = "0xC39868")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xC393F4", Offset = "0xC393F4", VA = "0xC393F4")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xC39930", Offset = "0xC39930", VA = "0xC39930")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xC399E0", Offset = "0xC399E0", VA = "0xC399E0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xC39A8C", Offset = "0xC39A8C", VA = "0xC39A8C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xC39B38", Offset = "0xC39B38", VA = "0xC39B38")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xC39B40", Offset = "0xC39B40", VA = "0xC39B40")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xC39B68", Offset = "0xC39B68", VA = "0xC39B68")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xC39C28", Offset = "0xC39C28", VA = "0xC39C28", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xC39DB8", Offset = "0xC39DB8", VA = "0xC39DB8")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xC3AD5C", Offset = "0xC3AD5C", VA = "0xC3AD5C")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xC3B30C", Offset = "0xC3B30C", VA = "0xC3B30C")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xC3B368", Offset = "0xC3B368", VA = "0xC3B368")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xC3B1AC", Offset = "0xC3B1AC", VA = "0xC3B1AC")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xC3B25C", Offset = "0xC3B25C", VA = "0xC3B25C")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xC3B478", Offset = "0xC3B478", VA = "0xC3B478")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xC3B53C", Offset = "0xC3B53C", VA = "0xC3B53C", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xC3B60C", Offset = "0xC3B60C", VA = "0xC3B60C")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xC3B728", Offset = "0xC3B728", VA = "0xC3B728")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xC3B8B8", Offset = "0xC3B8B8", VA = "0xC3B8B8")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xC3BA30", Offset = "0xC3BA30", VA = "0xC3BA30", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xC3BC90", Offset = "0xC3BC90", VA = "0xC3BC90", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xC3BD08", Offset = "0xC3BD08", VA = "0xC3BD08")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BF")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x1700006B")]
		protected virtual int minBones
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0xC3C530", Offset = "0xC3C530", VA = "0xC3C530", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006C")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0xC3C538", Offset = "0xC3C538", VA = "0xC3C538", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006D")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0xC3C540", Offset = "0xC3C540", VA = "0xC3C540", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006E")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0xC3C550", Offset = "0xC3C550", VA = "0xC3C550", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006F")]
		protected float positionOffset
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0xC34954", Offset = "0xC34954", VA = "0xC34954")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xC3BD14", Offset = "0xC3BD14", VA = "0xC3BD14")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xC3BE90", Offset = "0xC3BE90", VA = "0xC3BE90")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xC3BFBC", Offset = "0xC3BFBC", VA = "0xC3BFBC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xC3C018", Offset = "0xC3C018", VA = "0xC3C018", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xC3C088", Offset = "0xC3C088", VA = "0xC3C088", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xC3C44C", Offset = "0xC3C44C", VA = "0xC3C44C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xC3C454", Offset = "0xC3C454", VA = "0xC3C454", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xC3C548", Offset = "0xC3C548", VA = "0xC3C548", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xC3C54C", Offset = "0xC3C54C", VA = "0xC3C54C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xC33E40", Offset = "0xC33E40", VA = "0xC33E40")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xC345A8", Offset = "0xC345A8", VA = "0xC345A8")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xC3C60C", Offset = "0xC3C60C", VA = "0xC3C60C")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xC33CF0", Offset = "0xC33CF0", VA = "0xC33CF0")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C0")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xC3C8A0", Offset = "0xC3C8A0", VA = "0xC3C8A0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xC3CBFC", Offset = "0xC3CBFC", VA = "0xC3CBFC")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xC3CC5C", Offset = "0xC3CC5C", VA = "0xC3CC5C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xC3CDA0", Offset = "0xC3CDA0", VA = "0xC3CDA0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xC3CF00", Offset = "0xC3CF00", VA = "0xC3CF00", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xC3CF40", Offset = "0xC3CF40", VA = "0xC3CF40", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xC3CF90", Offset = "0xC3CF90", VA = "0xC3CF90", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xC3D2E8", Offset = "0xC3D2E8", VA = "0xC3D2E8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xC3D308", Offset = "0xC3D308", VA = "0xC3D308")]
		private void Solve()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xC3CFE8", Offset = "0xC3CFE8", VA = "0xC3CFE8")]
		private void Read()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xC3D38C", Offset = "0xC3D38C", VA = "0xC3D38C")]
		private void Write()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xC3D498", Offset = "0xC3D498", VA = "0xC3D498")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C1")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20000C2")]
		public enum BendModifier
		{
			[Token(Token = "0x40004EC")]
			Animation,
			[Token(Token = "0x40004ED")]
			Target,
			[Token(Token = "0x40004EE")]
			Parent,
			[Token(Token = "0x40004EF")]
			Arm,
			[Token(Token = "0x40004F0")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20000C3")]
		public struct AxisDirection
		{
			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x600050B")]
			[Address(RVA = "0xC3E8C8", Offset = "0xC3E8C8", VA = "0xC3E8C8")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float bendModifierWeight;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000070")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0xC3E8AC", Offset = "0xC3E8AC", VA = "0xC3E8AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xC3D62C", Offset = "0xC3D62C", VA = "0xC3D62C")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xC3D670", Offset = "0xC3D670", VA = "0xC3D670")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xC3D6B0", Offset = "0xC3D6B0", VA = "0xC3D6B0", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xC3DBF0", Offset = "0xC3DBF0", VA = "0xC3DBF0", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xC3E710", Offset = "0xC3E710", VA = "0xC3E710", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xC3E7B8", Offset = "0xC3E7B8", VA = "0xC3E7B8")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xC3E828", Offset = "0xC3E828", VA = "0xC3E828")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xC3DA04", Offset = "0xC3DA04", VA = "0xC3DA04")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xC3DCAC", Offset = "0xC3DCAC", VA = "0xC3DCAC")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000C4")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000C5")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x17000077")]
			public Vector3 forward
			{
				[Token(Token = "0x600052A")]
				[Address(RVA = "0xC40A74", Offset = "0xC40A74", VA = "0xC40A74")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000526")]
			[Address(RVA = "0xC40850", Offset = "0xC40850", VA = "0xC40850")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000527")]
			[Address(RVA = "0xC40858", Offset = "0xC40858", VA = "0xC40858")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000528")]
			[Address(RVA = "0xC40880", Offset = "0xC40880", VA = "0xC40880")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000529")]
			[Address(RVA = "0xC4096C", Offset = "0xC4096C", VA = "0xC4096C")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(0f, 1f)]
		public float headWeight;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float eyesWeight;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Range(0f, 1f)]
		public float clampWeightHead;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(0f, 1f)]
		public float clampWeightEyes;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] headForwards;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x17000071")]
		private bool spineIsValid
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0xC3EFC8", Offset = "0xC3EFC8", VA = "0xC3EFC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000072")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0xC3F170", Offset = "0xC3F170", VA = "0xC3F170")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000073")]
		private bool headIsValid
		{
			[Token(Token = "0x600051D")]
			[Address(RVA = "0xC3F094", Offset = "0xC3F094", VA = "0xC3F094")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000074")]
		private bool headIsEmpty
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0xC3F194", Offset = "0xC3F194", VA = "0xC3F194")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000075")]
		private bool eyesIsValid
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0xC3F0A4", Offset = "0xC3F0A4", VA = "0xC3F0A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000076")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0xC3F200", Offset = "0xC3F200", VA = "0xC3F200")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xC3EA64", Offset = "0xC3EA64", VA = "0xC3EA64")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xC3EA80", Offset = "0xC3EA80", VA = "0xC3EA80")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xC3EAAC", Offset = "0xC3EAAC", VA = "0xC3EAAC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xC3EAE4", Offset = "0xC3EAE4", VA = "0xC3EAE4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xC3EB2C", Offset = "0xC3EB2C", VA = "0xC3EB2C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xC3EB84", Offset = "0xC3EB84", VA = "0xC3EB84")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xC3EBF4", Offset = "0xC3EBF4", VA = "0xC3EBF4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xC3ED00", Offset = "0xC3ED00", VA = "0xC3ED00", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xC3EE20", Offset = "0xC3EE20", VA = "0xC3EE20", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xC3F224", Offset = "0xC3F224", VA = "0xC3F224", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xC3F43C", Offset = "0xC3F43C", VA = "0xC3F43C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xC3F59C", Offset = "0xC3F59C", VA = "0xC3F59C")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xC3F7B8", Offset = "0xC3F7B8", VA = "0xC3F7B8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xC3FA4C", Offset = "0xC3FA4C", VA = "0xC3FA4C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xC3FB10", Offset = "0xC3FB10", VA = "0xC3FB10")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xC3FD34", Offset = "0xC3FD34", VA = "0xC3FD34")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xC40084", Offset = "0xC40084", VA = "0xC40084")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xC40320", Offset = "0xC40320", VA = "0xC40320")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xC3F648", Offset = "0xC3F648", VA = "0xC3F648")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xC40638", Offset = "0xC40638", VA = "0xC40638")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C6")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000C7")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000542")]
			[Address(RVA = "0xC41D40", Offset = "0xC41D40", VA = "0xC41D40")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000543")]
			[Address(RVA = "0xC4260C", Offset = "0xC4260C", VA = "0xC4260C")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0xC42428", Offset = "0xC42428", VA = "0xC42428")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0xC427D0", Offset = "0xC427D0", VA = "0xC427D0")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xC40AA4", Offset = "0xC40AA4", VA = "0xC40AA4")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xC40C38", Offset = "0xC40C38", VA = "0xC40C38")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xC40DB8", Offset = "0xC40DB8", VA = "0xC40DB8")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xC40DC4", Offset = "0xC40DC4", VA = "0xC40DC4")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xC40DE0", Offset = "0xC40DE0", VA = "0xC40DE0")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xC40DEC", Offset = "0xC40DEC", VA = "0xC40DEC")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xC40DF4", Offset = "0xC40DF4", VA = "0xC40DF4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xC40EE0", Offset = "0xC40EE0", VA = "0xC40EE0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xC40FD8", Offset = "0xC40FD8", VA = "0xC40FD8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xC41018", Offset = "0xC41018", VA = "0xC41018", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xC41068", Offset = "0xC41068", VA = "0xC41068", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xC4140C", Offset = "0xC4140C", VA = "0xC4140C")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xC41458", Offset = "0xC41458", VA = "0xC41458")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xC4194C", Offset = "0xC4194C", VA = "0xC4194C")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xC41AA4", Offset = "0xC41AA4", VA = "0xC41AA4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xC41C50", Offset = "0xC41C50", VA = "0xC41C50")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xC41BD0", Offset = "0xC41BD0", VA = "0xC41BD0")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xC41E30", Offset = "0xC41E30", VA = "0xC41E30", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xC4269C", Offset = "0xC4269C", VA = "0xC4269C", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xC426A0", Offset = "0xC426A0", VA = "0xC426A0", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xC426A4", Offset = "0xC426A4", VA = "0xC426A4", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xC42458", Offset = "0xC42458", VA = "0xC42458")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xC426A8", Offset = "0xC426A8", VA = "0xC426A8")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C8")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000C9")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x20000CA")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x400054C")]
				YawPitch,
				[Token(Token = "0x400054D")]
				FromTo
			}

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The hand target")]
			public Transform target;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the hand target.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the hand target")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("The weight of shoulder rotation")]
			[Range(0f, 1f)]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Tooltip("Angular offset of the elbow bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation.")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation.")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("Use this to make the arm shorter/longer.")]
			[Range(0.01f, 2f)]
			public float armLengthMlp;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Evaluates stretching of the arm by target distance relative to arm length. Value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length).")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000549")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x400054A")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000079")]
			public Vector3 position
			{
				[Token(Token = "0x6000564")]
				[Address(RVA = "0xC4A238", Offset = "0xC4A238", VA = "0xC4A238")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000565")]
				[Address(RVA = "0xC4A244", Offset = "0xC4A244", VA = "0xC4A244")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007A")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000566")]
				[Address(RVA = "0xC4A250", Offset = "0xC4A250", VA = "0xC4A250")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000567")]
				[Address(RVA = "0xC4A25C", Offset = "0xC4A25C", VA = "0xC4A25C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007B")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000568")]
				[Address(RVA = "0xC4A268", Offset = "0xC4A268", VA = "0xC4A268")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000569")]
				[Address(RVA = "0xC4A290", Offset = "0xC4A290", VA = "0xC4A290")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600056A")]
				[Address(RVA = "0xC4A2BC", Offset = "0xC4A2BC", VA = "0xC4A2BC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			private VirtualBone hand
			{
				[Token(Token = "0x600056B")]
				[Address(RVA = "0xC4A2E8", Offset = "0xC4A2E8", VA = "0xC4A2E8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600056C")]
			[Address(RVA = "0xC4A314", Offset = "0xC4A314", VA = "0xC4A314", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600056D")]
			[Address(RVA = "0xC4AA40", Offset = "0xC4AA40", VA = "0xC4AA40", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0xC4ACEC", Offset = "0xC4ACEC", VA = "0xC4ACEC", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0xC4AD10", Offset = "0xC4AD10", VA = "0xC4AD10")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0xC481FC", Offset = "0xC481FC", VA = "0xC481FC")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0xC4BCAC", Offset = "0xC4BCAC", VA = "0xC4BCAC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000572")]
			[Address(RVA = "0xC4BD04", Offset = "0xC4BD04", VA = "0xC4BD04", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000573")]
			[Address(RVA = "0xC4B060", Offset = "0xC4B060", VA = "0xC4B060")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000574")]
			[Address(RVA = "0xC4B268", Offset = "0xC4B268", VA = "0xC4B268")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000575")]
			[Address(RVA = "0xC4BF10", Offset = "0xC4BF10", VA = "0xC4BF10")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000576")]
			[Address(RVA = "0xC49F8C", Offset = "0xC49F8C", VA = "0xC49F8C")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CB")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x1700007F")]
			public float sqrMag
			{
				[Token(Token = "0x600057C")]
				[Address(RVA = "0xC4C0C0", Offset = "0xC4C0C0", VA = "0xC4C0C0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600057D")]
				[Address(RVA = "0xC4C0C8", Offset = "0xC4C0C8", VA = "0xC4C0C8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public float mag
			{
				[Token(Token = "0x600057E")]
				[Address(RVA = "0xC4C0D0", Offset = "0xC4C0D0", VA = "0xC4C0D0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600057F")]
				[Address(RVA = "0xC4C0D8", Offset = "0xC4C0D8", VA = "0xC4C0D8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000577")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index);

			[Token(Token = "0x6000578")]
			public abstract void PreSolve();

			[Token(Token = "0x6000579")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x600057A")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x600057B")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000580")]
			[Address(RVA = "0xC460E8", Offset = "0xC460E8", VA = "0xC460E8")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000581")]
			[Address(RVA = "0xC4C240", Offset = "0xC4C240", VA = "0xC4C240")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000582")]
			[Address(RVA = "0xC4C2C8", Offset = "0xC4C2C8", VA = "0xC4C2C8")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0xC4C4CC", Offset = "0xC4C4CC", VA = "0xC4C4CC")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000584")]
			[Address(RVA = "0xC47D90", Offset = "0xC47D90", VA = "0xC47D90")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000585")]
			[Address(RVA = "0xC4BB48", Offset = "0xC4BB48", VA = "0xC4BB48")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000586")]
			[Address(RVA = "0xC4C514", Offset = "0xC4C514", VA = "0xC4C514")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000587")]
			[Address(RVA = "0xC4C638", Offset = "0xC4C638", VA = "0xC4C638")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000588")]
			[Address(RVA = "0xC4C028", Offset = "0xC4C028", VA = "0xC4C028")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CC")]
		public class Footstep
		{
			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x17000081")]
			public bool isStepping
			{
				[Token(Token = "0x6000589")]
				[Address(RVA = "0xC4C64C", Offset = "0xC4C64C", VA = "0xC4C64C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000082")]
			public float stepProgress
			{
				[Token(Token = "0x600058A")]
				[Address(RVA = "0xC4C660", Offset = "0xC4C660", VA = "0xC4C660")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600058B")]
				[Address(RVA = "0xC4C668", Offset = "0xC4C668", VA = "0xC4C668")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600058C")]
			[Address(RVA = "0xC4C670", Offset = "0xC4C670", VA = "0xC4C670")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x600058D")]
			[Address(RVA = "0xC4C770", Offset = "0xC4C770", VA = "0xC4C770")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600058E")]
			[Address(RVA = "0xC4C84C", Offset = "0xC4C84C", VA = "0xC4C84C")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600058F")]
			[Address(RVA = "0xC4C8FC", Offset = "0xC4C8FC", VA = "0xC4C8FC")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000590")]
			[Address(RVA = "0xC4CB04", Offset = "0xC4CB04", VA = "0xC4CB04")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000591")]
			[Address(RVA = "0xC4CCE8", Offset = "0xC4CCE8", VA = "0xC4CCE8")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CD")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The toe/foot target.")]
			public Transform target;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the toe/foot target.")]
			public float positionWeight;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the toe/foot target.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Angular offset of the knee bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[NonSerialized]
			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Vector3 footPosition;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Quaternion footRotation;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 bendNormal;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x17000083")]
			public Vector3 position
			{
				[Token(Token = "0x6000592")]
				[Address(RVA = "0xC4CE5C", Offset = "0xC4CE5C", VA = "0xC4CE5C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000593")]
				[Address(RVA = "0xC4CE68", Offset = "0xC4CE68", VA = "0xC4CE68")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000084")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000594")]
				[Address(RVA = "0xC4CE74", Offset = "0xC4CE74", VA = "0xC4CE74")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000595")]
				[Address(RVA = "0xC4CE80", Offset = "0xC4CE80", VA = "0xC4CE80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000085")]
			public bool hasToes
			{
				[Token(Token = "0x6000596")]
				[Address(RVA = "0xC4CE8C", Offset = "0xC4CE8C", VA = "0xC4CE8C")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000597")]
				[Address(RVA = "0xC4CE94", Offset = "0xC4CE94", VA = "0xC4CE94")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000086")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000598")]
				[Address(RVA = "0xC4CEA0", Offset = "0xC4CEA0", VA = "0xC4CEA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000599")]
				[Address(RVA = "0xC4CEC8", Offset = "0xC4CEC8", VA = "0xC4CEC8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000088")]
			private VirtualBone foot
			{
				[Token(Token = "0x600059A")]
				[Address(RVA = "0xC4CEF4", Offset = "0xC4CEF4", VA = "0xC4CEF4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000089")]
			private VirtualBone toes
			{
				[Token(Token = "0x600059B")]
				[Address(RVA = "0xC4CF20", Offset = "0xC4CF20", VA = "0xC4CF20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x600059C")]
				[Address(RVA = "0xC47C6C", Offset = "0xC47C6C", VA = "0xC47C6C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x600059D")]
				[Address(RVA = "0xC4CF4C", Offset = "0xC4CF4C", VA = "0xC4CF4C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600059E")]
				[Address(RVA = "0xC4CF58", Offset = "0xC4CF58", VA = "0xC4CF58")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600059F")]
			[Address(RVA = "0xC4CF64", Offset = "0xC4CF64", VA = "0xC4CF64", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0xC4D3F8", Offset = "0xC4D3F8", VA = "0xC4D3F8", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0xC4D9CC", Offset = "0xC4D9CC", VA = "0xC4D9CC", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0xC4D97C", Offset = "0xC4D97C", VA = "0xC4D97C")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0xC4D740", Offset = "0xC4D740", VA = "0xC4D740")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0xC47EB4", Offset = "0xC47EB4", VA = "0xC47EB4")]
			public void Solve()
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0xC4DE98", Offset = "0xC4DE98", VA = "0xC4DE98", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xC4DF94", Offset = "0xC4DF94", VA = "0xC4DF94", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0xC4A0D0", Offset = "0xC4A0D0", VA = "0xC4A0D0")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CE")]
		public class Locomotion
		{
			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Range(0f, 1f)]
			[Tooltip("Used for blending in/out of procedural locomotion.")]
			public float weight;

			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance;

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold;

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Range(0.9f, 1f)]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			public float maxLegStretch;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The speed of steps.")]
			public float stepSpeed;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Range(0f, 180f)]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Called when the left foot has finished a step.")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Called when the right foot has finished a step")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x1700008C")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x60005A8")]
				[Address(RVA = "0xC4E074", Offset = "0xC4E074", VA = "0xC4E074")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005A9")]
				[Address(RVA = "0xC4E080", Offset = "0xC4E080", VA = "0xC4E080")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700008D")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60005AF")]
				[Address(RVA = "0xC4E490", Offset = "0xC4E490", VA = "0xC4E490")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008E")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60005B0")]
				[Address(RVA = "0xC4E4C4", Offset = "0xC4E4C4", VA = "0xC4E4C4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008F")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60005B1")]
				[Address(RVA = "0xC4E4FC", Offset = "0xC4E4FC", VA = "0xC4E4FC")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000090")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60005B2")]
				[Address(RVA = "0xC4E530", Offset = "0xC4E530", VA = "0xC4E530")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0xC46198", Offset = "0xC46198", VA = "0xC46198")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xC44304", Offset = "0xC44304", VA = "0xC44304")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0xC43814", Offset = "0xC43814", VA = "0xC43814")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60005AD")]
			[Address(RVA = "0xC4375C", Offset = "0xC4375C", VA = "0xC4375C")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60005AE")]
			[Address(RVA = "0xC46954", Offset = "0xC46954", VA = "0xC46954")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x60005B3")]
			[Address(RVA = "0xC4E0C0", Offset = "0xC4E0C0", VA = "0xC4E0C0")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0xC4E274", Offset = "0xC4E274", VA = "0xC4E274")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60005B5")]
			[Address(RVA = "0xC4E2E0", Offset = "0xC4E2E0", VA = "0xC4E2E0")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0xC4A14C", Offset = "0xC4A14C", VA = "0xC4A14C")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CF")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The head target.")]
			public Transform headTarget;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The pelvis target, useful with seated rigs.")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the head target.")]
			public float positionWeight;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the head target.")]
			public float rotationWeight;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the pelvis target.")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Rotational weight of the pelvis target.")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the chest target.")]
			public float chestGoalWeight;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Range(0f, 1f)]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			public float bodyPosStiffness;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			[Range(0f, 1f)]
			public float bodyRotStiffness;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[FormerlySerializedAs("chestRotationWeight")]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[Range(0f, 1f)]
			public float neckStiffness;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			[Range(0f, 1f)]
			public float rotateChestByHands;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("Clamps chest rotation.")]
			[Range(0f, 1f)]
			public float chestClampWeight;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Clamps head rotation.")]
			[Range(0f, 1f)]
			public float headClampWeight;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Range(0f, 1f)]
			[Tooltip("How much will the pelvis maintain it's animated position?")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Range(0f, 180f)]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private Quaternion headRotation;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private int pelvisIndex;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private int spineIndex;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
			private int chestIndex;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private int neckIndex;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private int headIndex;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private float length;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
			private bool hasChest;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1ED")]
			private bool hasNeck;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private float headHeight;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private float sizeMlp;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private Vector3 chestForward;

			[Token(Token = "0x17000091")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x60005B7")]
				[Address(RVA = "0xC444E8", Offset = "0xC444E8", VA = "0xC444E8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x60005B8")]
				[Address(RVA = "0xC4E568", Offset = "0xC4E568", VA = "0xC4E568")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000093")]
			public VirtualBone chest
			{
				[Token(Token = "0x60005B9")]
				[Address(RVA = "0xC481B4", Offset = "0xC481B4", VA = "0xC481B4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000094")]
			private VirtualBone neck
			{
				[Token(Token = "0x60005BA")]
				[Address(RVA = "0xC4E59C", Offset = "0xC4E59C", VA = "0xC4E59C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			public VirtualBone head
			{
				[Token(Token = "0x60005BB")]
				[Address(RVA = "0xC4E08C", Offset = "0xC4E08C", VA = "0xC4E08C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000096")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x60005BC")]
				[Address(RVA = "0xC4E5D0", Offset = "0xC4E5D0", VA = "0xC4E5D0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60005BD")]
				[Address(RVA = "0xC4E5E4", Offset = "0xC4E5E4", VA = "0xC4E5E4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0xC4E5F8", Offset = "0xC4E5F8", VA = "0xC4E5F8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xC4F1DC", Offset = "0xC4F1DC", VA = "0xC4F1DC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0xC4F388", Offset = "0xC4F388", VA = "0xC4F388", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0xC4F988", Offset = "0xC4F988", VA = "0xC4F988")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0xC4648C", Offset = "0xC4648C", VA = "0xC4648C")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0xC503B4", Offset = "0xC503B4", VA = "0xC503B4")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0xC509BC", Offset = "0xC509BC", VA = "0xC509BC")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0xC50FC0", Offset = "0xC50FC0", VA = "0xC50FC0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0xC51190", Offset = "0xC51190", VA = "0xC51190", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0xC4FBCC", Offset = "0xC4FBCC", VA = "0xC4FBCC")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0xC47CA0", Offset = "0xC47CA0", VA = "0xC47CA0")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0xC4FFBC", Offset = "0xC4FFBC", VA = "0xC4FFBC")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0xC51260", Offset = "0xC51260", VA = "0xC51260")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0xC507C0", Offset = "0xC507C0", VA = "0xC507C0")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0xC505A8", Offset = "0xC505A8", VA = "0xC505A8")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0xC49E80", Offset = "0xC49E80", VA = "0xC49E80")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D0")]
		public enum PositionOffset
		{
			[Token(Token = "0x40005C7")]
			Pelvis,
			[Token(Token = "0x40005C8")]
			Chest,
			[Token(Token = "0x40005C9")]
			Head,
			[Token(Token = "0x40005CA")]
			LeftHand,
			[Token(Token = "0x40005CB")]
			RightHand,
			[Token(Token = "0x40005CC")]
			LeftFoot,
			[Token(Token = "0x40005CD")]
			RightFoot,
			[Token(Token = "0x40005CE")]
			LeftHeel,
			[Token(Token = "0x40005CF")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000D1")]
		public enum RotationOffset
		{
			[Token(Token = "0x40005D1")]
			Pelvis,
			[Token(Token = "0x40005D2")]
			Chest,
			[Token(Token = "0x40005D3")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000D2")]
		public class VirtualBone
		{
			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x60005CE")]
			[Address(RVA = "0xC46058", Offset = "0xC46058", VA = "0xC46058")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0xC460C8", Offset = "0xC460C8", VA = "0xC460C8")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0xC51500", Offset = "0xC51500", VA = "0xC51500")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0xC4C0E0", Offset = "0xC4C0E0", VA = "0xC4C0E0")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0xC4C35C", Offset = "0xC4C35C", VA = "0xC4C35C")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0xC51700", Offset = "0xC51700", VA = "0xC51700")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0xC4B0E0", Offset = "0xC4B0E0", VA = "0xC4B0E0")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0xC518A8", Offset = "0xC518A8", VA = "0xC518A8")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0xC4B764", Offset = "0xC4B764", VA = "0xC4B764")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0xC5194C", Offset = "0xC5194C", VA = "0xC5194C")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0xC50C64", Offset = "0xC50C64", VA = "0xC50C64")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0xC51AA4", Offset = "0xC51AA4", VA = "0xC51AA4")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0xC51BB8", Offset = "0xC51BB8", VA = "0xC51BB8")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Tooltip("If true, will keep the toes planted even if head target is out of reach.")]
		public bool plantFeet;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Tooltip("The spine solver.")]
		public Spine spine;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("The left arm solver.")]
		public Arm leftArm;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Tooltip("The right arm solver.")]
		public Arm rightArm;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Tooltip("The left leg solver.")]
		public Leg leftLeg;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Tooltip("The right leg solver.")]
		public Leg rightLeg;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("The procedural locomotion solver.")]
		public Locomotion locomotion;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Leg[] legs;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Arm[] arms;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 headPosition;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastOffset;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 debugPos1;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 debugPos2;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos3;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000078")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0xC49C4C", Offset = "0xC49C4C", VA = "0xC49C4C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000560")]
			[Address(RVA = "0xC49C54", Offset = "0xC49C54", VA = "0xC49C54")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xC427D8", Offset = "0xC427D8", VA = "0xC427D8")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xC42BB8", Offset = "0xC42BB8", VA = "0xC42BB8")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xC42A6C", Offset = "0xC42A6C", VA = "0xC42A6C")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xC433E0", Offset = "0xC433E0", VA = "0xC433E0")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xC43524", Offset = "0xC43524", VA = "0xC43524")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xC43564", Offset = "0xC43564", VA = "0xC43564")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xC43688", Offset = "0xC43688", VA = "0xC43688")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xC43BDC", Offset = "0xC43BDC", VA = "0xC43BDC")]
		public void Reset()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xC4451C", Offset = "0xC4451C", VA = "0xC4451C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xC44670", Offset = "0xC44670", VA = "0xC44670", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xC447E8", Offset = "0xC447E8", VA = "0xC447E8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xC44858", Offset = "0xC44858", VA = "0xC44858", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xC448C8", Offset = "0xC448C8", VA = "0xC448C8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xC44AC4", Offset = "0xC44AC4", VA = "0xC44AC4")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xC42EA0", Offset = "0xC42EA0", VA = "0xC42EA0")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xC42F84", Offset = "0xC42F84", VA = "0xC42F84")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xC432CC", Offset = "0xC432CC", VA = "0xC432CC")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xC43CD4", Offset = "0xC43CD4", VA = "0xC43CD4")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xC44D34", Offset = "0xC44D34", VA = "0xC44D34", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xC44D60", Offset = "0xC44D60", VA = "0xC44D60", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xC45E20", Offset = "0xC45E20", VA = "0xC45E20")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xC43E24", Offset = "0xC43E24", VA = "0xC43E24")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xC44DB8", Offset = "0xC44DB8", VA = "0xC44DB8")]
		private void Solve()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xC45FE4", Offset = "0xC45FE4", VA = "0xC45FE4")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xC46020", Offset = "0xC46020", VA = "0xC46020")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xC45CEC", Offset = "0xC45CEC", VA = "0xC45CEC")]
		private void Write()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xC49580", Offset = "0xC49580", VA = "0xC49580")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xC49C5C", Offset = "0xC49C5C", VA = "0xC49C5C")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		public float weight;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		public float parentChildCrossfade;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(-180f, 180f)]
		[Tooltip("Rotation offset around the twist axis.")]
		public float twistAngleOffset;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 twistAxis;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 axis;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform parent;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform child;

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xC51D6C", Offset = "0xC51D6C", VA = "0xC51D6C")]
		public void Relax()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xC521B0", Offset = "0xC521B0", VA = "0xC521B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xC52500", Offset = "0xC52500", VA = "0xC52500")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xC52578", Offset = "0xC52578", VA = "0xC52578")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xC525F0", Offset = "0xC525F0", VA = "0xC525F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xC52708", Offset = "0xC52708", VA = "0xC52708")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D4")]
	public class InteractionEffector
	{
		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x17000097")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0xC527A8", Offset = "0xC527A8", VA = "0xC527A8")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0xC527B0", Offset = "0xC527B0", VA = "0xC527B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public bool isPaused
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0xC527B8", Offset = "0xC527B8", VA = "0xC527B8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0xC527C0", Offset = "0xC527C0", VA = "0xC527C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0xC527CC", Offset = "0xC527CC", VA = "0xC527CC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0xC527D4", Offset = "0xC527D4", VA = "0xC527D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public bool inInteraction
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0xC527DC", Offset = "0xC527DC", VA = "0xC527DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009B")]
		public float progress
		{
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0xC53FD0", Offset = "0xC53FD0", VA = "0xC53FD0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xC5283C", Offset = "0xC5283C", VA = "0xC5283C")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xC528CC", Offset = "0xC528CC", VA = "0xC528CC")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xC52960", Offset = "0xC52960", VA = "0xC52960")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xC52A94", Offset = "0xC52A94", VA = "0xC52A94")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xC52DD8", Offset = "0xC52DD8", VA = "0xC52DD8")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xC52EF8", Offset = "0xC52EF8", VA = "0xC52EF8")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xC52F4C", Offset = "0xC52F4C", VA = "0xC52F4C")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xC533EC", Offset = "0xC533EC", VA = "0xC533EC")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xC53A3C", Offset = "0xC53A3C", VA = "0xC53A3C")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xC53C60", Offset = "0xC53C60", VA = "0xC53C60")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xC53E84", Offset = "0xC53E84", VA = "0xC53E84")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xC54000", Offset = "0xC54000", VA = "0xC54000")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D5")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xC54244", Offset = "0xC54244", VA = "0xC54244")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xC54354", Offset = "0xC54354", VA = "0xC54354")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xC543EC", Offset = "0xC543EC", VA = "0xC543EC")]
		public void Update()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xC545DC", Offset = "0xC545DC", VA = "0xC545DC")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xC54684", Offset = "0xC54684", VA = "0xC54684")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xC54730", Offset = "0xC54730", VA = "0xC54730")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D7")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000617")]
			[Address(RVA = "0xC55CE8", Offset = "0xC55CE8", VA = "0xC55CE8")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000618")]
			[Address(RVA = "0xC55F80", Offset = "0xC55F80", VA = "0xC55F80")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D8")]
		public class Message
		{
			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The name of the function called.")]
			public string function;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			[Token(Token = "0x4000620")]
			private const string empty = "";

			[Token(Token = "0x6000619")]
			[Address(RVA = "0xC55E88", Offset = "0xC55E88", VA = "0xC55E88")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x600061A")]
			[Address(RVA = "0xC55F88", Offset = "0xC55F88", VA = "0xC55F88")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D9")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The name of the animation state.")]
			public string animationState;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000627")]
			private const string empty = "";

			[Token(Token = "0x600061B")]
			[Address(RVA = "0xC55DAC", Offset = "0xC55DAC", VA = "0xC55DAC")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x600061C")]
			[Address(RVA = "0xC55F90", Offset = "0xC55F90", VA = "0xC55F90")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0xC56040", Offset = "0xC56040", VA = "0xC56040")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x600061E")]
			[Address(RVA = "0xC56118", Offset = "0xC56118", VA = "0xC56118")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DA")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20000DB")]
			public enum Type
			{
				[Token(Token = "0x400062B")]
				PositionWeight,
				[Token(Token = "0x400062C")]
				RotationWeight,
				[Token(Token = "0x400062D")]
				PositionOffsetX,
				[Token(Token = "0x400062E")]
				PositionOffsetY,
				[Token(Token = "0x400062F")]
				PositionOffsetZ,
				[Token(Token = "0x4000630")]
				Pull,
				[Token(Token = "0x4000631")]
				Reach,
				[Token(Token = "0x4000632")]
				RotateBoneWeight,
				[Token(Token = "0x4000633")]
				Push,
				[Token(Token = "0x4000634")]
				PushParent,
				[Token(Token = "0x4000635")]
				PoserWeight
			}

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			[Token(Token = "0x600061F")]
			[Address(RVA = "0xC553D4", Offset = "0xC553D4", VA = "0xC553D4")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0xC5612C", Offset = "0xC5612C", VA = "0xC5612C")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DC")]
		public class Multiplier
		{
			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000621")]
			[Address(RVA = "0xC5596C", Offset = "0xC5596C", VA = "0xC5596C")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000622")]
			[Address(RVA = "0xC56134", Offset = "0xC56134", VA = "0xC56134")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700009C")]
		public float length
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0xC548DC", Offset = "0xC548DC", VA = "0xC548DC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000602")]
			[Address(RVA = "0xC548E4", Offset = "0xC548E4", VA = "0xC548E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0xC548EC", Offset = "0xC548EC", VA = "0xC548EC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000604")]
			[Address(RVA = "0xC548F4", Offset = "0xC548F4", VA = "0xC548F4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000606")]
			[Address(RVA = "0xC54B2C", Offset = "0xC54B2C", VA = "0xC54B2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public Transform targetsRoot
		{
			[Token(Token = "0x600060E")]
			[Address(RVA = "0xC54AAC", Offset = "0xC54AAC", VA = "0xC54AAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xC54744", Offset = "0xC54744", VA = "0xC54744")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xC54788", Offset = "0xC54788", VA = "0xC54788")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xC547CC", Offset = "0xC547CC", VA = "0xC547CC")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xC54810", Offset = "0xC54810", VA = "0xC54810")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xC54854", Offset = "0xC54854", VA = "0xC54854")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xC54898", Offset = "0xC54898", VA = "0xC54898")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xC548FC", Offset = "0xC548FC", VA = "0xC548FC")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xC54BAC", Offset = "0xC54BAC", VA = "0xC54BAC")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xC54D24", Offset = "0xC54D24", VA = "0xC54D24")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xC54DB8", Offset = "0xC54DB8", VA = "0xC54DB8")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xC54DC0", Offset = "0xC54DC0", VA = "0xC54DC0")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xC54F60", Offset = "0xC54F60", VA = "0xC54F60")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xC54F68", Offset = "0xC54F68", VA = "0xC54F68")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xC5599C", Offset = "0xC5599C", VA = "0xC5599C")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xC55BA8", Offset = "0xC55BA8", VA = "0xC55BA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xC553F0", Offset = "0xC553F0", VA = "0xC553F0")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xC54EFC", Offset = "0xC54EFC", VA = "0xC54EFC")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xC55910", Offset = "0xC55910", VA = "0xC55910")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xC55BAC", Offset = "0xC55BAC", VA = "0xC55BAC")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xC55C08", Offset = "0xC55C08", VA = "0xC55C08")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xC55C4C", Offset = "0xC55C4C", VA = "0xC55C4C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xC55C90", Offset = "0xC55C90", VA = "0xC55C90")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000DE")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000DF")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The master speed for all interactions.")]
		public float speed;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("collider")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[Header("Triggering")]
		public Collider characterCollider;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("camera")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		public Transform FPSCamera;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Space(10f)]
		[Tooltip("Reference to the FBBIK component.")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x170000A0")]
		public bool inInteraction
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0xC562DC", Offset = "0xC562DC", VA = "0xC562DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A1")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000643")]
			[Address(RVA = "0xC57D34", Offset = "0xC57D34", VA = "0xC57D34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000644")]
			[Address(RVA = "0xC57D3C", Offset = "0xC57D3C", VA = "0xC57D3C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000645")]
			[Address(RVA = "0xC57D44", Offset = "0xC57D44", VA = "0xC57D44")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000646")]
			[Address(RVA = "0xC57D4C", Offset = "0xC57D4C", VA = "0xC57D4C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xC56144", Offset = "0xC56144", VA = "0xC56144")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xC56188", Offset = "0xC56188", VA = "0xC56188")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xC561CC", Offset = "0xC561CC", VA = "0xC561CC")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xC56210", Offset = "0xC56210", VA = "0xC56210")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xC56254", Offset = "0xC56254", VA = "0xC56254")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xC56298", Offset = "0xC56298", VA = "0xC56298")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xC56458", Offset = "0xC56458", VA = "0xC56458")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xC56514", Offset = "0xC56514", VA = "0xC56514")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xC565D0", Offset = "0xC565D0", VA = "0xC565D0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xC5666C", Offset = "0xC5666C", VA = "0xC5666C")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xC56754", Offset = "0xC56754", VA = "0xC56754")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xC56850", Offset = "0xC56850", VA = "0xC56850")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xC568D8", Offset = "0xC568D8", VA = "0xC568D8")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xC56960", Offset = "0xC56960", VA = "0xC56960")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xC569E8", Offset = "0xC569E8", VA = "0xC569E8")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xC56A54", Offset = "0xC56A54", VA = "0xC56A54")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xC56AC0", Offset = "0xC56AC0", VA = "0xC56AC0")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xC56B20", Offset = "0xC56B20", VA = "0xC56B20")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xC56BA0", Offset = "0xC56BA0", VA = "0xC56BA0")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xC56C28", Offset = "0xC56C28", VA = "0xC56C28")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xC56CE0", Offset = "0xC56CE0", VA = "0xC56CE0")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xC56F70", Offset = "0xC56F70", VA = "0xC56F70")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xC5712C", Offset = "0xC5712C", VA = "0xC5712C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xC57394", Offset = "0xC57394", VA = "0xC57394")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xC57620", Offset = "0xC57620", VA = "0xC57620")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xC57658", Offset = "0xC57658", VA = "0xC57658")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xC576B8", Offset = "0xC576B8", VA = "0xC576B8")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xC577C0", Offset = "0xC577C0", VA = "0xC577C0")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xC579A0", Offset = "0xC579A0", VA = "0xC579A0")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xC57C14", Offset = "0xC57C14", VA = "0xC57C14")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xC5747C", Offset = "0xC5747C", VA = "0xC5747C")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xC57D54", Offset = "0xC57D54", VA = "0xC57D54", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xC58580", Offset = "0xC58580", VA = "0xC58580")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xC585A0", Offset = "0xC585A0", VA = "0xC585A0")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xC585BC", Offset = "0xC585BC", VA = "0xC585BC")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xC585D8", Offset = "0xC585D8", VA = "0xC585D8")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xC5862C", Offset = "0xC5862C", VA = "0xC5862C")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xC58798", Offset = "0xC58798", VA = "0xC58798")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xC58894", Offset = "0xC58894", VA = "0xC58894")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xC58BF0", Offset = "0xC58BF0", VA = "0xC58BF0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xC58CD4", Offset = "0xC58CD4", VA = "0xC58CD4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xC58FB8", Offset = "0xC58FB8", VA = "0xC58FB8")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xC58338", Offset = "0xC58338", VA = "0xC58338")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xC590E8", Offset = "0xC590E8", VA = "0xC590E8")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xC591FC", Offset = "0xC591FC", VA = "0xC591FC")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xC592A8", Offset = "0xC592A8", VA = "0xC592A8")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xC59390", Offset = "0xC59390", VA = "0xC59390")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xC593A8", Offset = "0xC593A8", VA = "0xC593A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xC56378", Offset = "0xC56378", VA = "0xC56378")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xC56E5C", Offset = "0xC56E5C", VA = "0xC56E5C")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xC59790", Offset = "0xC59790", VA = "0xC59790")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xC597D4", Offset = "0xC597D4", VA = "0xC597D4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xC59818", Offset = "0xC59818", VA = "0xC59818")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E1")]
		public class Multiplier
		{
			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x6000671")]
			[Address(RVA = "0xC5A5A8", Offset = "0xC5A5A8", VA = "0xC5A5A8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xC59DE8", Offset = "0xC59DE8", VA = "0xC59DE8")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xC59E2C", Offset = "0xC59E2C", VA = "0xC59E2C")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xC59E70", Offset = "0xC59E70", VA = "0xC59E70")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xC59EB4", Offset = "0xC59EB4", VA = "0xC59EB4")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xC59EF8", Offset = "0xC59EF8", VA = "0xC59EF8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xC59F3C", Offset = "0xC59F3C", VA = "0xC59F3C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xC55370", Offset = "0xC55370", VA = "0xC55370")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xC59F80", Offset = "0xC59F80", VA = "0xC59F80")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xC5A00C", Offset = "0xC5A00C", VA = "0xC5A00C")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xC5A4B0", Offset = "0xC5A4B0", VA = "0xC5A4B0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xC5A4F4", Offset = "0xC5A4F4", VA = "0xC5A4F4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xC5A538", Offset = "0xC5A538", VA = "0xC5A538")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E3")]
		public class CharacterPosition
		{
			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Angle offset from the default forward direction.")]
			[Range(-180f, 180f)]
			public float angleOffset;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			[Range(0f, 180f)]
			public float maxAngle;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("If true, will rotate the trigger around it's Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;

			[Token(Token = "0x170000A3")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000678")]
				[Address(RVA = "0xC5A788", Offset = "0xC5A788", VA = "0xC5A788")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A4")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000679")]
				[Address(RVA = "0xC5A794", Offset = "0xC5A794", VA = "0xC5A794")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0xC5A854", Offset = "0xC5A854", VA = "0xC5A854")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0xC5AFB8", Offset = "0xC5AFB8", VA = "0xC5AFB8")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		public class CameraPosition
		{
			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("What the camera should be looking at to trigger the interaction?")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			[Range(0f, 180f)]
			public float maxAngle;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;

			[Token(Token = "0x600067C")]
			[Address(RVA = "0xC5AFCC", Offset = "0xC5AFCC", VA = "0xC5AFCC")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0xC5B144", Offset = "0xC5B144", VA = "0xC5B144")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600067E")]
			[Address(RVA = "0xC5B44C", Offset = "0xC5B44C", VA = "0xC5B44C")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E5")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20000E6")]
			public class Interaction
			{
				[Token(Token = "0x400066F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000670")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000681")]
				[Address(RVA = "0xC5B4D0", Offset = "0xC5B4D0", VA = "0xC5B4D0")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The range for the character's position and rotation.")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The range for the character camera's position and rotation.")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions;

			[Token(Token = "0x600067F")]
			[Address(RVA = "0xC5A680", Offset = "0xC5A680", VA = "0xC5A680")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0xC5B4C0", Offset = "0xC5B4C0", VA = "0xC5B4C0")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xC5A5B0", Offset = "0xC5A5B0", VA = "0xC5A5B0")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xC5A5F4", Offset = "0xC5A5F4", VA = "0xC5A5F4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xC5A638", Offset = "0xC5A638", VA = "0xC5A638")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xC5A67C", Offset = "0xC5A67C", VA = "0xC5A67C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xC58A3C", Offset = "0xC58A3C", VA = "0xC58A3C")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xC5A730", Offset = "0xC5A730", VA = "0xC5A730")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000E8")]
		public class Map
		{
			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000689")]
			[Address(RVA = "0xC5B7C4", Offset = "0xC5B7C4", VA = "0xC5B7C4")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0xC5BB00", Offset = "0xC5BB00", VA = "0xC5BB00")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0xC5BAC0", Offset = "0xC5BAC0", VA = "0xC5BAC0")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0xC5B944", Offset = "0xC5B944", VA = "0xC5B944")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xC5B4D8", Offset = "0xC5B4D8", VA = "0xC5B4D8", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xC5B850", Offset = "0xC5B850", VA = "0xC5B850", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xC5B854", Offset = "0xC5B854", VA = "0xC5B854", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xC5BA64", Offset = "0xC5BA64", VA = "0xC5BA64", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xC5B7F4", Offset = "0xC5B7F4", VA = "0xC5B7F4")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xC5B730", Offset = "0xC5B730", VA = "0xC5B730")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xC5BB44", Offset = "0xC5BB44", VA = "0xC5BB44")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _poseRoot;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] children;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xC5BB64", Offset = "0xC5BB64", VA = "0xC5BB64", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xC5BC24", Offset = "0xC5BC24", VA = "0xC5BC24", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xC5BDC8", Offset = "0xC5BDC8", VA = "0xC5BDC8", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xC5BEB0", Offset = "0xC5BEB0", VA = "0xC5BEB0", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xC5BC78", Offset = "0xC5BC78", VA = "0xC5BC78")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xC5C1E0", Offset = "0xC5C1E0", VA = "0xC5C1E0")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float localRotationWeight;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float localPositionWeight;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000693")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000694")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000695")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000696")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xC5C1F0", Offset = "0xC5C1F0", VA = "0xC5C1F0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xC5C234", Offset = "0xC5C234", VA = "0xC5C234", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xC5C260", Offset = "0xC5C260", VA = "0xC5C260", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xC5BB54", Offset = "0xC5BB54", VA = "0xC5BB54")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	[RequireComponent(typeof(Animator))]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000EC")]
		public class Rigidbone
		{
			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0xC5C820", Offset = "0xC5C820", VA = "0xC5C820")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0xC5D368", Offset = "0xC5D368", VA = "0xC5D368")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0xC5D128", Offset = "0xC5D128", VA = "0xC5D128")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000ED")]
		public class Child
		{
			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0xC5C974", Offset = "0xC5C974", VA = "0xC5C974")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0xC5D480", Offset = "0xC5D480", VA = "0xC5D480")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0xC5D43C", Offset = "0xC5D43C", VA = "0xC5D43C")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000EE")]
		[CompilerGenerated]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000A7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006B6")]
				[Address(RVA = "0xC5D984", Offset = "0xC5D984", VA = "0xC5D984", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006B8")]
				[Address(RVA = "0xC5D9CC", Offset = "0xC5D9CC", VA = "0xC5D9CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006B3")]
			[Address(RVA = "0xC5C9D0", Offset = "0xC5C9D0", VA = "0xC5C9D0")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0xC5D7A0", Offset = "0xC5D7A0", VA = "0xC5D7A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0xC5D7A4", Offset = "0xC5D7A4", VA = "0xC5D7A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0xC5D98C", Offset = "0xC5D98C", VA = "0xC5D98C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x170000A5")]
		private bool isRagdoll
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0xC5C2A4", Offset = "0xC5C2A4", VA = "0xC5C2A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A6")]
		private bool ikUsed
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0xC5CD5C", Offset = "0xC5CD5C", VA = "0xC5CD5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xC5C278", Offset = "0xC5C278", VA = "0xC5C278")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xC5C308", Offset = "0xC5C308", VA = "0xC5C308")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xC5C414", Offset = "0xC5C414", VA = "0xC5C414")]
		public void Start()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xC5C3AC", Offset = "0xC5C3AC", VA = "0xC5C3AC")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xC5C9F8", Offset = "0xC5C9F8", VA = "0xC5C9F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xC5CC20", Offset = "0xC5CC20", VA = "0xC5CC20")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xC5CCC0", Offset = "0xC5CCC0", VA = "0xC5CCC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xC5CEB0", Offset = "0xC5CEB0", VA = "0xC5CEB0")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xC5CD30", Offset = "0xC5CD30", VA = "0xC5CD30")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xC5CE7C", Offset = "0xC5CE7C", VA = "0xC5CE7C")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xC5CF30", Offset = "0xC5CF30", VA = "0xC5CF30")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xC5CED4", Offset = "0xC5CED4", VA = "0xC5CED4")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xC5C350", Offset = "0xC5C350", VA = "0xC5C350")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xC5CC54", Offset = "0xC5CC54", VA = "0xC5CC54")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xC5D590", Offset = "0xC5D590", VA = "0xC5D590")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xC5D6A8", Offset = "0xC5D6A8", VA = "0xC5D6A8")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x170000A9")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0xC5DD50", Offset = "0xC5DD50", VA = "0xC5DD50")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000AA")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0xC5DD5C", Offset = "0xC5DD5C", VA = "0xC5DD5C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xC5D9D4", Offset = "0xC5D9D4", VA = "0xC5D9D4")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xC5DA0C", Offset = "0xC5DA0C", VA = "0xC5DA0C")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xC5DCC0", Offset = "0xC5DCC0", VA = "0xC5DCC0")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xC5DD24", Offset = "0xC5DD24", VA = "0xC5DD24")]
		public void Disable()
		{
		}

		[Token(Token = "0x60006BF")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xC5DBC4", Offset = "0xC5DBC4", VA = "0xC5DBC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xC5DD8C", Offset = "0xC5DD8C", VA = "0xC5DD8C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xC5DD90", Offset = "0xC5DD90", VA = "0xC5DD90")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xC5DDB8", Offset = "0xC5DDB8", VA = "0xC5DDB8")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xC5DE8C", Offset = "0xC5DE8C", VA = "0xC5DE8C")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xC5E0E4", Offset = "0xC5E0E4", VA = "0xC5E0E4")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xC5E238", Offset = "0xC5E238", VA = "0xC5E238")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float limit;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xC5E298", Offset = "0xC5E298", VA = "0xC5E298")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xC5E2DC", Offset = "0xC5E2DC", VA = "0xC5E2DC")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xC5E320", Offset = "0xC5E320", VA = "0xC5E320")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xC5E364", Offset = "0xC5E364", VA = "0xC5E364")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xC5E3A8", Offset = "0xC5E3A8", VA = "0xC5E3A8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xC5E3E0", Offset = "0xC5E3E0", VA = "0xC5E3E0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xC5E704", Offset = "0xC5E704", VA = "0xC5E704")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xC5E714", Offset = "0xC5E714", VA = "0xC5E714")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xC5E758", Offset = "0xC5E758", VA = "0xC5E758")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xC5E79C", Offset = "0xC5E79C", VA = "0xC5E79C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xC5E7E0", Offset = "0xC5E7E0", VA = "0xC5E7E0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xC5E824", Offset = "0xC5E824", VA = "0xC5E824", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xC5E840", Offset = "0xC5E840", VA = "0xC5E840")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xC5EA88", Offset = "0xC5EA88", VA = "0xC5EA88")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000F3")]
		public class ReachCone
		{
			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000AB")]
			public Vector3 o
			{
				[Token(Token = "0x60006E5")]
				[Address(RVA = "0xC6081C", Offset = "0xC6081C", VA = "0xC6081C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AC")]
			public Vector3 a
			{
				[Token(Token = "0x60006E6")]
				[Address(RVA = "0xC60848", Offset = "0xC60848", VA = "0xC60848")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AD")]
			public Vector3 b
			{
				[Token(Token = "0x60006E7")]
				[Address(RVA = "0xC60878", Offset = "0xC60878", VA = "0xC60878")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AE")]
			public Vector3 c
			{
				[Token(Token = "0x60006E8")]
				[Address(RVA = "0xC608A8", Offset = "0xC608A8", VA = "0xC608A8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AF")]
			public bool isValid
			{
				[Token(Token = "0x60006EA")]
				[Address(RVA = "0xC5FD64", Offset = "0xC5FD64", VA = "0xC5FD64")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0xC60208", Offset = "0xC60208", VA = "0xC60208")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0xC6036C", Offset = "0xC6036C", VA = "0xC6036C")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F4")]
		public class LimitPoint
		{
			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0xC5FD74", Offset = "0xC5FD74", VA = "0xC5FD74")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 3f)]
		public int smoothIterations;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		public ReachCone[] reachCones;

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xC5EAEC", Offset = "0xC5EAEC", VA = "0xC5EAEC")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xC5EB30", Offset = "0xC5EB30", VA = "0xC5EB30")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xC5EB74", Offset = "0xC5EB74", VA = "0xC5EB74")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xC5EBB8", Offset = "0xC5EBB8", VA = "0xC5EBB8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xC5EBFC", Offset = "0xC5EBFC", VA = "0xC5EBFC")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xC5F234", Offset = "0xC5F234", VA = "0xC5F234", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xC5F2BC", Offset = "0xC5F2BC", VA = "0xC5F2BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xC5F89C", Offset = "0xC5F89C", VA = "0xC5F89C")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xC5EC88", Offset = "0xC5EC88", VA = "0xC5EC88")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xC5FDD8", Offset = "0xC5FDD8", VA = "0xC5FDD8")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xC605E0", Offset = "0xC605E0", VA = "0xC605E0")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xC60628", Offset = "0xC60628", VA = "0xC60628")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xC60688", Offset = "0xC60688", VA = "0xC60688")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xC5F5F8", Offset = "0xC5F5F8", VA = "0xC5F5F8")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xC606F4", Offset = "0xC606F4", VA = "0xC606F4")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xC607C0", Offset = "0xC607C0", VA = "0xC607C0")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		public AnimationCurve spline;

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xC608D8", Offset = "0xC608D8", VA = "0xC608D8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xC6091C", Offset = "0xC6091C", VA = "0xC6091C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xC60960", Offset = "0xC60960", VA = "0xC60960")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xC609A4", Offset = "0xC609A4", VA = "0xC609A4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xC609E8", Offset = "0xC609E8", VA = "0xC609E8")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xC60A04", Offset = "0xC60A04", VA = "0xC60A04", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xC60A3C", Offset = "0xC60A3C", VA = "0xC60A3C")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xC60DE8", Offset = "0xC60DE8", VA = "0xC60DE8")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("Master weight of the IK solver.")]
		public float weight;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		[Header("Target Smoothing")]
		public Transform target;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		[Header("Turning Towards The Target")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Range(0f, 180f)]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		[Header("RootRotation")]
		public float maxRootAngle;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		[Header("Mode")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform lastTarget;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float switchWeight;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float switchWeightV;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float weightV;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 dir;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000B0")]
		private Vector3 pivot
		{
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0xC60E70", Offset = "0xC60E70", VA = "0xC60E70")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xC60DF4", Offset = "0xC60DF4", VA = "0xC60DF4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xC60EF4", Offset = "0xC60EF4", VA = "0xC60EF4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xC61404", Offset = "0xC61404", VA = "0xC61404")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xC61588", Offset = "0xC61588", VA = "0xC61588")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xC617D4", Offset = "0xC617D4", VA = "0xC617D4")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F8")]
		public class Pose
		{
			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0xC61974", Offset = "0xC61974", VA = "0xC61974")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0xC61EE4", Offset = "0xC61EE4", VA = "0xC61EE4")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0xC61EEC", Offset = "0xC61EEC", VA = "0xC61EEC")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xC618A4", Offset = "0xC618A4", VA = "0xC618A4")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xC61E24", Offset = "0xC61E24", VA = "0xC61E24")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xC61E84", Offset = "0xC61E84", VA = "0xC61E84")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FA")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000FB")]
			public class EffectorLink
			{
				[Token(Token = "0x40006E3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006E4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000706")]
				[Address(RVA = "0xC623B0", Offset = "0xC623B0", VA = "0xC623B0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000703")]
			[Address(RVA = "0xC62058", Offset = "0xC62058", VA = "0xC62058")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0xC62388", Offset = "0xC62388", VA = "0xC62388")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0xC62398", Offset = "0xC62398", VA = "0xC62398")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xC61F08", Offset = "0xC61F08", VA = "0xC61F08", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xC62368", Offset = "0xC62368", VA = "0xC62368")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xC623B8", Offset = "0xC623B8", VA = "0xC623B8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xC62420", Offset = "0xC62420", VA = "0xC62420", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xC626C0", Offset = "0xC626C0", VA = "0xC626C0")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FE")]
		public abstract class HitPoint
		{
			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000B2")]
			public bool inProgress
			{
				[Token(Token = "0x600070E")]
				[Address(RVA = "0xC62778", Offset = "0xC62778", VA = "0xC62778")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000B3")]
			protected float crossFader
			{
				[Token(Token = "0x600070F")]
				[Address(RVA = "0xC62C78", Offset = "0xC62C78", VA = "0xC62C78")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000710")]
				[Address(RVA = "0xC62C80", Offset = "0xC62C80", VA = "0xC62C80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B4")]
			protected float timer
			{
				[Token(Token = "0x6000711")]
				[Address(RVA = "0xC62C88", Offset = "0xC62C88", VA = "0xC62C88")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000712")]
				[Address(RVA = "0xC62C90", Offset = "0xC62C90", VA = "0xC62C90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B5")]
			protected Vector3 force
			{
				[Token(Token = "0x6000713")]
				[Address(RVA = "0xC62C98", Offset = "0xC62C98", VA = "0xC62C98")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000714")]
				[Address(RVA = "0xC62CA4", Offset = "0xC62CA4", VA = "0xC62CA4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B6")]
			protected Vector3 point
			{
				[Token(Token = "0x6000715")]
				[Address(RVA = "0xC62CB0", Offset = "0xC62CB0", VA = "0xC62CB0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000716")]
				[Address(RVA = "0xC62CBC", Offset = "0xC62CBC", VA = "0xC62CBC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000717")]
			[Address(RVA = "0xC62B40", Offset = "0xC62B40", VA = "0xC62B40")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000718")]
			[Address(RVA = "0xC6284C", Offset = "0xC6284C", VA = "0xC6284C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000719")]
			protected abstract float GetLength();

			[Token(Token = "0x600071A")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600071B")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x600071C")]
			[Address(RVA = "0xC62CC8", Offset = "0xC62CC8", VA = "0xC62CC8")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FF")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000100")]
			public class EffectorLink
			{
				[Token(Token = "0x40006FA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006FB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x40006FC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40006FD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000721")]
				[Address(RVA = "0xC62FFC", Offset = "0xC62FFC", VA = "0xC62FFC")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000722")]
				[Address(RVA = "0xC62E58", Offset = "0xC62E58", VA = "0xC62E58")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000723")]
				[Address(RVA = "0xC630AC", Offset = "0xC630AC", VA = "0xC630AC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600071D")]
			[Address(RVA = "0xC62CDC", Offset = "0xC62CDC", VA = "0xC62CDC", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600071E")]
			[Address(RVA = "0xC62DF8", Offset = "0xC62DF8", VA = "0xC62DF8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0xC62E6C", Offset = "0xC62E6C", VA = "0xC62E6C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000720")]
			[Address(RVA = "0xC63098", Offset = "0xC63098", VA = "0xC63098")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000101")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000102")]
			public class BoneLink
			{
				[Token(Token = "0x4000701")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				[Token(Token = "0x4000702")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Token(Token = "0x4000703")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000704")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000728")]
				[Address(RVA = "0xC6336C", Offset = "0xC6336C", VA = "0xC6336C")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000729")]
				[Address(RVA = "0xC63198", Offset = "0xC63198", VA = "0xC63198")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600072A")]
				[Address(RVA = "0xC6350C", Offset = "0xC6350C", VA = "0xC6350C")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000724")]
			[Address(RVA = "0xC630B4", Offset = "0xC630B4", VA = "0xC630B4", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0xC63140", Offset = "0xC63140", VA = "0xC63140", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000726")]
			[Address(RVA = "0xC631A4", Offset = "0xC631A4", VA = "0xC631A4", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000727")]
			[Address(RVA = "0xC634F8", Offset = "0xC634F8", VA = "0xC634F8")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000B1")]
		public bool inProgress
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0xC626DC", Offset = "0xC626DC", VA = "0xC626DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xC6278C", Offset = "0xC6278C", VA = "0xC6278C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xC62924", Offset = "0xC62924", VA = "0xC62924")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xC62C68", Offset = "0xC62C68", VA = "0xC62C68")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x2000104")]
		public abstract class Offset
		{
			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000B7")]
			protected float crossFader
			{
				[Token(Token = "0x600072E")]
				[Address(RVA = "0xC63A7C", Offset = "0xC63A7C", VA = "0xC63A7C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600072F")]
				[Address(RVA = "0xC63A84", Offset = "0xC63A84", VA = "0xC63A84")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B8")]
			protected float timer
			{
				[Token(Token = "0x6000730")]
				[Address(RVA = "0xC63A8C", Offset = "0xC63A8C", VA = "0xC63A8C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000731")]
				[Address(RVA = "0xC63A94", Offset = "0xC63A94", VA = "0xC63A94")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B9")]
			protected Vector3 force
			{
				[Token(Token = "0x6000732")]
				[Address(RVA = "0xC63A9C", Offset = "0xC63A9C", VA = "0xC63A9C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000733")]
				[Address(RVA = "0xC63AA8", Offset = "0xC63AA8", VA = "0xC63AA8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000BA")]
			protected Vector3 point
			{
				[Token(Token = "0x6000734")]
				[Address(RVA = "0xC63AB4", Offset = "0xC63AB4", VA = "0xC63AB4")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000735")]
				[Address(RVA = "0xC63AC0", Offset = "0xC63AC0", VA = "0xC63AC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0xC6392C", Offset = "0xC6392C", VA = "0xC6392C")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0xC63628", Offset = "0xC63628", VA = "0xC63628")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000738")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000739")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600073A")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x600073B")]
			[Address(RVA = "0xC63ACC", Offset = "0xC63ACC", VA = "0xC63ACC")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000105")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000106")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000715")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000716")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x4000717")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000718")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000740")]
				[Address(RVA = "0xC63EB0", Offset = "0xC63EB0", VA = "0xC63EB0")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000741")]
				[Address(RVA = "0xC63CD4", Offset = "0xC63CD4", VA = "0xC63CD4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000742")]
				[Address(RVA = "0xC63F44", Offset = "0xC63F44", VA = "0xC63F44")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600073C")]
			[Address(RVA = "0xC63AE0", Offset = "0xC63AE0", VA = "0xC63AE0", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0xC63C74", Offset = "0xC63C74", VA = "0xC63C74", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600073E")]
			[Address(RVA = "0xC63CE8", Offset = "0xC63CE8", VA = "0xC63CE8", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600073F")]
			[Address(RVA = "0xC63F28", Offset = "0xC63F28", VA = "0xC63F28")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000107")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000108")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x400071C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x400071D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Token(Token = "0x400071E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x400071F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000747")]
				[Address(RVA = "0xC64304", Offset = "0xC64304", VA = "0xC64304")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000748")]
				[Address(RVA = "0xC6407C", Offset = "0xC6407C", VA = "0xC6407C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000749")]
				[Address(RVA = "0xC64420", Offset = "0xC64420", VA = "0xC64420")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public int curveIndex;

			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000743")]
			[Address(RVA = "0xC63F4C", Offset = "0xC63F4C", VA = "0xC63F4C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0xC64024", Offset = "0xC64024", VA = "0xC64024", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0xC64088", Offset = "0xC64088", VA = "0xC64088", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0xC6440C", Offset = "0xC6440C", VA = "0xC6440C")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xC63570", Offset = "0xC63570", VA = "0xC63570", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xC63708", Offset = "0xC63708", VA = "0xC63708")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xC63A5C", Offset = "0xC63A5C", VA = "0xC63A5C")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200010A")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x200010B")]
			public class EffectorLink
			{
				[Token(Token = "0x400072D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400072E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000750")]
				[Address(RVA = "0xC649E8", Offset = "0xC649E8", VA = "0xC649E8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Matching target velocity")]
			[Range(0f, 1f)]
			public float matchVelocity;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("gravity applied to the Body")]
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

			[Token(Token = "0x600074D")]
			[Address(RVA = "0xC644F0", Offset = "0xC644F0", VA = "0xC644F0")]
			public void Reset()
			{
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0xC64670", Offset = "0xC64670", VA = "0xC64670")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0xC649CC", Offset = "0xC649CC", VA = "0xC649CC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The array of Bodies")]
		public Body[] bodies;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits;

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xC64484", Offset = "0xC64484", VA = "0xC64484")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xC645CC", Offset = "0xC645CC", VA = "0xC645CC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xC649BC", Offset = "0xC649BC", VA = "0xC649BC")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010D")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("The limits")]
			public float minX;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The limits")]
			public float maxX;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The limits")]
			public float minY;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The limits")]
			public float maxY;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The limits")]
			public float minZ;

			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The limits")]
			public float maxZ;

			[Token(Token = "0x6000759")]
			[Address(RVA = "0xC64B54", Offset = "0xC64B54", VA = "0xC64B54")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0xC64DC4", Offset = "0xC64DC4", VA = "0xC64DC4")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0xC64E34", Offset = "0xC64E34", VA = "0xC64E34")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0xC64E7C", Offset = "0xC64E7C", VA = "0xC64E7C")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x200010E")]
		[CompilerGenerated]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000BC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000760")]
				[Address(RVA = "0xC64FD8", Offset = "0xC64FD8", VA = "0xC64FD8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000762")]
				[Address(RVA = "0xC65020", Offset = "0xC65020", VA = "0xC65020", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0xC64A58", Offset = "0xC64A58", VA = "0xC64A58")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0xC64E84", Offset = "0xC64E84", VA = "0xC64E84", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0xC64E88", Offset = "0xC64E88", VA = "0xC64E88", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000761")]
			[Address(RVA = "0xC64FE0", Offset = "0xC64FE0", VA = "0xC64FE0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000BB")]
		protected float deltaTime
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0xC62038", Offset = "0xC62038", VA = "0xC62038")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000752")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xC62400", Offset = "0xC62400", VA = "0xC62400", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xC649F0", Offset = "0xC649F0", VA = "0xC649F0")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xC64A80", Offset = "0xC64A80", VA = "0xC64A80")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xC64914", Offset = "0xC64914", VA = "0xC64914")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xC64CB8", Offset = "0xC64CB8", VA = "0xC64CB8", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xC62378", Offset = "0xC62378", VA = "0xC62378")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000110")]
		[CompilerGenerated]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000BF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600076D")]
				[Address(RVA = "0xC6542C", Offset = "0xC6542C", VA = "0xC6542C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600076F")]
				[Address(RVA = "0xC65474", Offset = "0xC65474", VA = "0xC65474", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0xC650D0", Offset = "0xC650D0", VA = "0xC650D0")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0xC652D8", Offset = "0xC652D8", VA = "0xC652D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0xC652DC", Offset = "0xC652DC", VA = "0xC652DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0xC65434", Offset = "0xC65434", VA = "0xC65434", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000BE")]
		protected float deltaTime
		{
			[Token(Token = "0x6000763")]
			[Address(RVA = "0xC65028", Offset = "0xC65028", VA = "0xC65028")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000764")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xC65048", Offset = "0xC65048", VA = "0xC65048", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xC65068", Offset = "0xC65068", VA = "0xC65068")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xC650F8", Offset = "0xC650F8", VA = "0xC650F8")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xC651CC", Offset = "0xC651CC", VA = "0xC651CC", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xC63A6C", Offset = "0xC63A6C", VA = "0xC63A6C")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000112")]
		public class EffectorLink
		{
			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000773")]
			[Address(RVA = "0xC6547C", Offset = "0xC6547C", VA = "0xC6547C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0xC657C8", Offset = "0xC657C8", VA = "0xC657C8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xC6260C", Offset = "0xC6260C", VA = "0xC6260C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xC656CC", Offset = "0xC656CC", VA = "0xC656CC")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xC65770", Offset = "0xC65770", VA = "0xC65770")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000114")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x2000115")]
			public class EffectorLink
			{
				[Token(Token = "0x4000768")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000769")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000784")]
				[Address(RVA = "0xC66B1C", Offset = "0xC66B1C", VA = "0xC66B1C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			[Range(0f, 1f)]
			public float additivity;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000781")]
			[Address(RVA = "0xC6596C", Offset = "0xC6596C", VA = "0xC6596C")]
			public void Start()
			{
			}

			[Token(Token = "0x6000782")]
			[Address(RVA = "0xC664C8", Offset = "0xC664C8", VA = "0xC664C8")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000783")]
			[Address(RVA = "0xC66B08", Offset = "0xC66B08", VA = "0xC66B08")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000116")]
		public enum Handedness
		{
			[Token(Token = "0x400076B")]
			Right,
			[Token(Token = "0x400076C")]
			Left
		}

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		[Space(10f)]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000C1")]
		public bool isFinished
		{
			[Token(Token = "0x6000775")]
			[Address(RVA = "0xC657D0", Offset = "0xC657D0", VA = "0xC657D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C2")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0xC666CC", Offset = "0xC666CC", VA = "0xC666CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x600077C")]
			[Address(RVA = "0xC66708", Offset = "0xC66708", VA = "0xC66708")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		private Transform primaryHand
		{
			[Token(Token = "0x600077D")]
			[Address(RVA = "0xC66694", Offset = "0xC66694", VA = "0xC66694")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		private Transform secondaryHand
		{
			[Token(Token = "0x600077E")]
			[Address(RVA = "0xC666B0", Offset = "0xC666B0", VA = "0xC666B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xC657F4", Offset = "0xC657F4", VA = "0xC657F4")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xC65820", Offset = "0xC65820", VA = "0xC65820")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xC65A40", Offset = "0xC65A40", VA = "0xC65A40", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xC66744", Offset = "0xC66744", VA = "0xC66744")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xC6685C", Offset = "0xC6685C", VA = "0xC6685C")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xC668AC", Offset = "0xC668AC", VA = "0xC668AC", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xC66A7C", Offset = "0xC66A7C", VA = "0xC66A7C")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xC66B24", Offset = "0xC66B24", VA = "0xC66B24")]
		private void Start()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0xC66C14", Offset = "0xC66C14", VA = "0xC66C14")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0xC66CF0", Offset = "0xC66CF0", VA = "0xC66CF0")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xC670F4", Offset = "0xC670F4", VA = "0xC670F4")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xC67128", Offset = "0xC67128", VA = "0xC67128")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xC67234", Offset = "0xC67234", VA = "0xC67234")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x2000119")]
		public class Settings
		{
			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Local axis of the body tracker towards the player's forward direction.")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("Local axis of the body tracker towards the up direction.")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Local axis of the foot trackers towards the player's forward direction.")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			[Space(10f)]
			public Vector3 headOffset;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			[Range(-180f, 180f)]
			public float footHeadingOffset;

			[Token(Token = "0x600078D")]
			[Address(RVA = "0xC689EC", Offset = "0xC689EC", VA = "0xC689EC")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xC67248", Offset = "0xC67248", VA = "0xC67248")]
		public static void Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xC68244", Offset = "0xC68244", VA = "0xC68244")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvisTarget;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftFootTarget;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightFootTarget;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 pelvisTargetRight;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xC68BE0", Offset = "0xC68BE0", VA = "0xC68BE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xC688FC", Offset = "0xC688FC", VA = "0xC688FC")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xC68CD0", Offset = "0xC68CD0", VA = "0xC68CD0")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xC68FB8", Offset = "0xC68FB8", VA = "0xC68FB8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xC690C4", Offset = "0xC690C4", VA = "0xC690C4")]
		public VRIKRootController()
		{
		}
	}
}
