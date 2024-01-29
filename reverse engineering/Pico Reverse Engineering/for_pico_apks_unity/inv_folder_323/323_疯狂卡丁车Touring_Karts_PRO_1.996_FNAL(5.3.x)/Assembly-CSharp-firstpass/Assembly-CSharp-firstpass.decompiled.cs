using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class LogitechGSDK
{
	[PreserveSig]
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1C26968", Offset = "0x1C26968", VA = "0x1C26968")]
	public static extern bool LogiSteeringInitialize(bool ignoreXInputControllers);

	[PreserveSig]
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1C269EC", Offset = "0x1C269EC", VA = "0x1C269EC")]
	public static extern bool LogiUpdate();

	[PreserveSig]
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1C26A64", Offset = "0x1C26A64", VA = "0x1C26A64")]
	public static extern bool LogiIsDeviceConnected(int index, int deviceType);

	[PreserveSig]
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1C26AF8", Offset = "0x1C26AF8", VA = "0x1C26AF8")]
	public static extern bool LogiSetOperatingRange(int index, int range);
}
[Token(Token = "0x2000003")]
public class NewBehaviourScript : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text devText;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int tmInitRes;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool[] bDevFFBStarted;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1C27794", Offset = "0x1C27794", VA = "0x1C27794")]
	private void Start()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1C278E8", Offset = "0x1C278E8", VA = "0x1C278E8")]
	private void DisplayInputState(Thrustmaster_FFB_SDK.ScePadData padData, Thrustmaster_FFB_SDK.tm_vendor_extra_input_data vendorExData, int devClass)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1C29C98", Offset = "0x1C29C98", VA = "0x1C29C98")]
	private void Update()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1C2B6A8", Offset = "0x1C2B6A8", VA = "0x1C2B6A8")]
	public NewBehaviourScript()
	{
	}
}
[Token(Token = "0x2000004")]
public class Thrustmaster_FFB_SDK
{
	[Token(Token = "0x2000005")]
	public struct tm_vendor_extra_input_data
	{
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte[] pushEncoder;
	}

	[Token(Token = "0x2000006")]
	public struct ScePadAnalogStick
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte x;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte y;
	}

	[Token(Token = "0x2000007")]
	public struct ScePadAnalogButtons
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte l2;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte r2;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] padding;
	}

	[Token(Token = "0x2000008")]
	public struct SceFQuaternion
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float w;
	}

	[Token(Token = "0x2000009")]
	public struct SceFVector3
	{
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;
	}

	[Token(Token = "0x200000A")]
	public struct ScePadTouch
	{
		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short x;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public short y;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public byte id;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] reserve;
	}

	[Token(Token = "0x200000B")]
	public struct ScePadTouchData
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte touchNum;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] reserve;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint reserve1;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ScePadTouch[] touch;
	}

	[Token(Token = "0x200000C")]
	public struct ScePadExtensionUnitData
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint extensionUnitId;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] reserve;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte dataLength;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte[] data;
	}

	[Token(Token = "0x200000D")]
	public struct ScePadData
	{
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint buttons;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ScePadAnalogStick leftStick;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public ScePadAnalogStick rightStick;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ScePadAnalogButtons analogButtons;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SceFQuaternion orientation;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SceFVector3 acceleration;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public SceFVector3 angularVelocity;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ScePadTouchData touchData;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public byte connected;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public ulong timestamp;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ScePadExtensionUnitData extensionUnitData;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public byte connectedCount;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public byte[] reserve;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public byte deviceUniqueDataLen;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public byte[] deviceUniqueData;
	}

	[Token(Token = "0x200000E")]
	public struct GSetFxFloat
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint flags;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int duration;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float direction;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int startDelay;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int triggerButtonId;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int triggerRepeatInterval;
	}

	[Token(Token = "0x200000F")]
	public struct GEnvFloat
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint impulseTime;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float impulseLevel;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint fadeTime;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float fadeLevel;
	}

	[Token(Token = "0x2000010")]
	public struct GConstantForceEffect_Float
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GSetFxFloat setFx;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GEnvFloat enveloppe;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float magnitude;
	}

	[Token(Token = "0x2000011")]
	public enum TM_PERIODIC_TYPE_FX
	{
		[Token(Token = "0x400003A")]
		TM_PERIODIC_SQUARE,
		[Token(Token = "0x400003B")]
		TM_PERIODIC_TRIANGLE,
		[Token(Token = "0x400003C")]
		TM_PERIODIC_SINE,
		[Token(Token = "0x400003D")]
		TM_PERIODIC_SAWUP,
		[Token(Token = "0x400003E")]
		TM_PERIODIC_SAWDOWN
	}

	[Token(Token = "0x2000012")]
	public struct GPeriodicEffect_Float
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GSetFxFloat setFx;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GEnvFloat enveloppe;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TM_PERIODIC_TYPE_FX type;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float magnitude;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float offset;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float phase;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public uint period;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float dutyCycle;
	}

	[Token(Token = "0x2000013")]
	public struct GCondFloat
	{
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float PosK;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float NegK;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float Offset;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float Deadband;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float PosSat;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float NegSat;
	}

	[Token(Token = "0x2000014")]
	public enum TM_CONDITIONAL_TYPE_FX
	{
		[Token(Token = "0x400004E")]
		TM_CONDITIONAL_SPRING,
		[Token(Token = "0x400004F")]
		TM_CONDITIONAL_DAMPER
	}

	[Token(Token = "0x2000015")]
	public struct GConditionalEffect_Float
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GSetFxFloat setFx;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TM_CONDITIONAL_TYPE_FX type;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public GCondFloat x;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public GCondFloat y;
	}

	[PreserveSig]
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1C27850", Offset = "0x1C27850", VA = "0x1C27850")]
	public static extern int module_init(uint nVersionLib, uint ulDeviceTypeFilter, byte threadsCpuMask);

	[PreserveSig]
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1C2ABA8", Offset = "0x1C2ABA8", VA = "0x1C2ABA8")]
	public static extern int is_device_ready(int dev_id);

	[PreserveSig]
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1C2B2AC", Offset = "0x1C2B2AC", VA = "0x1C2B2AC")]
	public static extern uint get_caps(int dev_id);

	[PreserveSig]
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1C2AC28", Offset = "0x1C2AC28", VA = "0x1C2AC28")]
	public static extern ushort get_product_id(int dev_id, byte[] name, int sizeOfName);

	[PreserveSig]
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1C2B32C", Offset = "0x1C2B32C", VA = "0x1C2B32C")]
	public static extern int get_ps4_user_id(int dev_id);

	[PreserveSig]
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1C2B22C", Offset = "0x1C2B22C", VA = "0x1C2B22C")]
	public static extern int sce_get_device_class(int dev_id);

	[PreserveSig]
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1C2B3AC", Offset = "0x1C2B3AC", VA = "0x1C2B3AC")]
	public static extern uint get_serial_id(int dev_id);

	[PreserveSig]
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1C2B42C", Offset = "0x1C2B42C", VA = "0x1C2B42C")]
	public static extern uint get_CSFFB_revision(int dev_id);

	[PreserveSig]
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1C2B0F4", Offset = "0x1C2B0F4", VA = "0x1C2B0F4")]
	public static extern int sce_pad_read_state(int dev_id, ScePadData pData, tm_vendor_extra_input_data pVendorExtraData);

	[PreserveSig]
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1C2B4AC", Offset = "0x1C2B4AC", VA = "0x1C2B4AC")]
	public static extern int GGetWheelAngle(int dev_id);

	[PreserveSig]
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1C2B528", Offset = "0x1C2B528", VA = "0x1C2B528")]
	public static extern int GGetMinWheelAngle(int dev_id);

	[PreserveSig]
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1C2B5A8", Offset = "0x1C2B5A8", VA = "0x1C2B5A8")]
	public static extern int GGetMaxWheelAngle(int dev_id);

	[PreserveSig]
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1C2B628", Offset = "0x1C2B628", VA = "0x1C2B628")]
	public static extern int GGetEffectSlots(int dev_id);

	[PreserveSig]
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1C2ACC4", Offset = "0x1C2ACC4", VA = "0x1C2ACC4")]
	public static extern bool GSetDeviceGain_Float(int dev_id, float gain);

	[PreserveSig]
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1C2AFCC", Offset = "0x1C2AFCC", VA = "0x1C2AFCC")]
	public static extern void GEnableDefaultSpring(int dev_id, int enable);

	[PreserveSig]
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1C2B05C", Offset = "0x1C2B05C", VA = "0x1C2B05C")]
	public static extern bool GSetDefaultSpringK_Float(int dev_id, float k);

	[PreserveSig]
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1C2ADF4", Offset = "0x1C2ADF4", VA = "0x1C2ADF4")]
	public static extern void GSetEffectState(int dev_id, byte effect_slot, byte flags, byte loop_count);

	[PreserveSig]
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1C2AE9C", Offset = "0x1C2AE9C", VA = "0x1C2AE9C")]
	public static extern int GSetConstantForce_Float(int dev_id, uint effect_slot, GConstantForceEffect_Float pEffect);

	[PreserveSig]
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1C2AD5C", Offset = "0x1C2AD5C", VA = "0x1C2AD5C")]
	public static extern int GSetPeriodicEffect_Float(int dev_id, uint effect_slot, GPeriodicEffect_Float pEffect);

	[PreserveSig]
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1C2AF34", Offset = "0x1C2AF34", VA = "0x1C2AF34")]
	public static extern int GSetConditionalEffect_Float(int dev_id, uint effect_slot, GConditionalEffect_Float pEffect);
}
[Token(Token = "0x2000016")]
internal class Simtools
{
	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string Roll;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string Pitch;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string Yaw;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string Heave;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string Sway;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string Surge;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string Extra1;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string Extra2;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string Extra3;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1C2C014", Offset = "0x1C2C014", VA = "0x1C2C014")]
	public Simtools()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1C2C104", Offset = "0x1C2C104", VA = "0x1C2C104")]
	public Simtools(string Roll, string Pitch, string Yaw, string Heave, string Sway, string Surge, string Extra1, string Extra2, string Extra3)
	{
	}
}
[Token(Token = "0x2000017")]
public class QuPlaySimtools : MonoBehaviour
{
	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77163C", Offset = "0x77163C")]
	private sealed class <QuSimtools_Start>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public QuPlaySimtools <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x1C2E4CC", Offset = "0x1C2E4CC", VA = "0x1C2E4CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x1C2E514", Offset = "0x1C2E514", VA = "0x1C2E514", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1C2C274", Offset = "0x1C2C274", VA = "0x1C2C274")]
		[DebuggerHidden]
		public <QuSimtools_Start>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1C2E104", Offset = "0x1C2E104", VA = "0x1C2E104", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1C2E108", Offset = "0x1C2E108", VA = "0x1C2E108", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1C2E4D4", Offset = "0x1C2E4D4", VA = "0x1C2E4D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string IP;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int port;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IPEndPoint remoteEndPoint;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static UdpClient client;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Simtools simtools;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1C2BE78", Offset = "0x1C2BE78", VA = "0x1C2BE78")]
	private void Start()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1C2C01C", Offset = "0x1C2C01C", VA = "0x1C2C01C")]
	public static void QuSimtools_SendTelemetry(string Roll, string Pitch, string Yaw, string Heave, string Sway, string Surge, string Extra1, string Extra2, string Extra3)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1C2C1F4", Offset = "0x1C2C1F4", VA = "0x1C2C1F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7719CC", Offset = "0x7719CC")]
	private IEnumerator QuSimtools_Start()
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1C2C2A0", Offset = "0x1C2C2A0", VA = "0x1C2C2A0")]
	public QuPlaySimtools()
	{
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x77164C", Offset = "0x77164C")]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1C23038", Offset = "0x1C23038", VA = "0x1C23038")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1C230E4", Offset = "0x1C230E4", VA = "0x1C230E4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1C234F0", Offset = "0x1C234F0", VA = "0x1C234F0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1C23974", Offset = "0x1C23974", VA = "0x1C23974")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x200001B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7716B4", Offset = "0x7716B4")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x4000072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x17000003")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000033")]
				[Address(RVA = "0x1C2DBEC", Offset = "0x1C2DBEC", VA = "0x1C2DBEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000004")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000035")]
				[Address(RVA = "0x1C2DC34", Offset = "0x1C2DC34", VA = "0x1C2DC34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000030")]
			[Address(RVA = "0x1C25360", Offset = "0x1C25360", VA = "0x1C25360")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000031")]
			[Address(RVA = "0x1C2D6CC", Offset = "0x1C2D6CC", VA = "0x1C2D6CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000032")]
			[Address(RVA = "0x1C2D6D0", Offset = "0x1C2D6D0", VA = "0x1C2D6D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000034")]
			[Address(RVA = "0x1C2DBF4", Offset = "0x1C2DBF4", VA = "0x1C2DBF4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1C252E0", Offset = "0x1C252E0", VA = "0x1C252E0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x771A84", Offset = "0x771A84")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1C2538C", Offset = "0x1C2538C", VA = "0x1C2538C")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1C254B0", Offset = "0x1C254B0", VA = "0x1C254B0")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x200001D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7716C4", Offset = "0x7716C4")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000076")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x17000005")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600003B")]
				[Address(RVA = "0x1C2DFB4", Offset = "0x1C2DFB4", VA = "0x1C2DFB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000006")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600003D")]
				[Address(RVA = "0x1C2DFFC", Offset = "0x1C2DFFC", VA = "0x1C2DFFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000038")]
			[Address(RVA = "0x1C25538", Offset = "0x1C25538", VA = "0x1C25538")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000039")]
			[Address(RVA = "0x1C2DC3C", Offset = "0x1C2DC3C", VA = "0x1C2DC3C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600003A")]
			[Address(RVA = "0x1C2DC40", Offset = "0x1C2DC40", VA = "0x1C2DC40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600003C")]
			[Address(RVA = "0x1C2DFBC", Offset = "0x1C2DFBC", VA = "0x1C2DFBC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1C254B8", Offset = "0x1C254B8", VA = "0x1C254B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x771B3C", Offset = "0x771B3C")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1C25564", Offset = "0x1C25564", VA = "0x1C25564")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1C25574", Offset = "0x1C25574", VA = "0x1C25574")]
		private void Start()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1C255D8", Offset = "0x1C255D8", VA = "0x1C255D8")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1C25664", Offset = "0x1C25664", VA = "0x1C25664")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1C25674", Offset = "0x1C25674", VA = "0x1C25674")]
		private void Start()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1C256F0", Offset = "0x1C256F0", VA = "0x1C256F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1C258AC", Offset = "0x1C258AC", VA = "0x1C258AC")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1C258D8", Offset = "0x1C258D8", VA = "0x1C258D8")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1C262D8", Offset = "0x1C262D8", VA = "0x1C262D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1C26454", Offset = "0x1C26454", VA = "0x1C26454")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1C2B6B0", Offset = "0x1C2B6B0", VA = "0x1C2B6B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1C2B810", Offset = "0x1C2B810", VA = "0x1C2B810")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1C2C30C", Offset = "0x1C2C30C", VA = "0x1C2C30C")]
		private void Start()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1C2C3C8", Offset = "0x1C2C3C8", VA = "0x1C2C3C8")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1C2D268", Offset = "0x1C2D268", VA = "0x1C2D268")]
		private void Start()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1C2D2CC", Offset = "0x1C2D2CC", VA = "0x1C2D2CC")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1C2D540", Offset = "0x1C2D540", VA = "0x1C2D540")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000024")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1C23DF4", Offset = "0x1C23DF4", VA = "0x1C23DF4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1C240D0", Offset = "0x1C240D0", VA = "0x1C240D0")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1C24280", Offset = "0x1C24280", VA = "0x1C24280")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1C24308", Offset = "0x1C24308", VA = "0x1C24308", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1C243D0", Offset = "0x1C243D0", VA = "0x1C243D0", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1C24424", Offset = "0x1C24424", VA = "0x1C24424")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1C2449C", Offset = "0x1C2449C", VA = "0x1C2449C")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1C2458C", Offset = "0x1C2458C", VA = "0x1C2458C")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1C2467C", Offset = "0x1C2467C", VA = "0x1C2467C")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1C2476C", Offset = "0x1C2476C", VA = "0x1C2476C")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1C2485C", Offset = "0x1C2485C", VA = "0x1C2485C")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1C2494C", Offset = "0x1C2494C", VA = "0x1C2494C")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x2000027")]
		public class VirtualAxis
		{
			[Token(Token = "0x4000092")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77175C", Offset = "0x77175C")]
			private string <name>k__BackingField;

			[Token(Token = "0x4000093")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x4000094")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77176C", Offset = "0x77176C")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x17000007")]
			public string name
			{
				[Token(Token = "0x600006B")]
				[Address(RVA = "0x1C2D5D4", Offset = "0x1C2D5D4", VA = "0x1C2D5D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x771BF4", Offset = "0x771BF4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600006C")]
				[Address(RVA = "0x1C2D5DC", Offset = "0x1C2D5DC", VA = "0x1C2D5DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x771C04", Offset = "0x771C04")]
				private set
				{
				}
			}

			[Token(Token = "0x17000008")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x600006D")]
				[Address(RVA = "0x1C2D5E4", Offset = "0x1C2D5E4", VA = "0x1C2D5E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x771C14", Offset = "0x771C14")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600006E")]
				[Address(RVA = "0x1C2D5EC", Offset = "0x1C2D5EC", VA = "0x1C2D5EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x771C24", Offset = "0x771C24")]
				private set
				{
				}
			}

			[Token(Token = "0x17000009")]
			public float GetValue
			{
				[Token(Token = "0x6000073")]
				[Address(RVA = "0x1C2D64C", Offset = "0x1C2D64C", VA = "0x1C2D64C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600006F")]
			[Address(RVA = "0x1C23F98", Offset = "0x1C23F98", VA = "0x1C23F98")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x6000070")]
			[Address(RVA = "0x1C2D5F8", Offset = "0x1C2D5F8", VA = "0x1C2D5F8")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000071")]
			[Address(RVA = "0x1C2429C", Offset = "0x1C2429C", VA = "0x1C2429C")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000072")]
			[Address(RVA = "0x1C2D644", Offset = "0x1C2D644", VA = "0x1C2D644")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000028")]
		public class VirtualButton
		{
			[Token(Token = "0x4000095")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77177C", Offset = "0x77177C")]
			private string <name>k__BackingField;

			[Token(Token = "0x4000096")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77178C", Offset = "0x77178C")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x4000097")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x4000098")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x4000099")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x1700000A")]
			public string name
			{
				[Token(Token = "0x6000074")]
				[Address(RVA = "0x1C2D654", Offset = "0x1C2D654", VA = "0x1C2D654")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x771C34", Offset = "0x771C34")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000075")]
				[Address(RVA = "0x1C2D65C", Offset = "0x1C2D65C", VA = "0x1C2D65C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x771C44", Offset = "0x771C44")]
				private set
				{
				}
			}

			[Token(Token = "0x1700000B")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000076")]
				[Address(RVA = "0x1C2D664", Offset = "0x1C2D664", VA = "0x1C2D664")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x771C54", Offset = "0x771C54")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000077")]
				[Address(RVA = "0x1C2D66C", Offset = "0x1C2D66C", VA = "0x1C2D66C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x771C64", Offset = "0x771C64")]
				private set
				{
				}
			}

			[Token(Token = "0x6000078")]
			[Address(RVA = "0x1C27050", Offset = "0x1C27050", VA = "0x1C27050")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x6000079")]
			[Address(RVA = "0x1C2D678", Offset = "0x1C2D678", VA = "0x1C2D678")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x600007A")]
			[Address(RVA = "0x1C272A4", Offset = "0x1C272A4", VA = "0x1C272A4")]
			public void Pressed()
			{
			}

			[Token(Token = "0x600007B")]
			[Address(RVA = "0x1C27390", Offset = "0x1C27390", VA = "0x1C27390")]
			public void Released()
			{
			}
		}

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1C24954", Offset = "0x1C24954", VA = "0x1C24954")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1C23F1C", Offset = "0x1C23F1C", VA = "0x1C23F1C")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1C23FD8", Offset = "0x1C23FD8", VA = "0x1C23FD8")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1C24BE8", Offset = "0x1C24BE8", VA = "0x1C24BE8")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1C24DC4", Offset = "0x1C24DC4", VA = "0x1C24DC4")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1C24054", Offset = "0x1C24054", VA = "0x1C24054")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1C24FC8", Offset = "0x1C24FC8", VA = "0x1C24FC8")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1C25034", Offset = "0x1C25034", VA = "0x1C25034")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1C24508", Offset = "0x1C24508", VA = "0x1C24508")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1C245F8", Offset = "0x1C245F8", VA = "0x1C245F8")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1C246E8", Offset = "0x1C246E8", VA = "0x1C246E8")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1C248C8", Offset = "0x1C248C8", VA = "0x1C248C8")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1C247D8", Offset = "0x1C247D8", VA = "0x1C247D8")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1C250C0", Offset = "0x1C250C0", VA = "0x1C250C0")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1C25154", Offset = "0x1C25154", VA = "0x1C25154")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1C251D8", Offset = "0x1C251D8", VA = "0x1C251D8")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1C2525C", Offset = "0x1C2525C", VA = "0x1C2525C")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1C26470", Offset = "0x1C26470", VA = "0x1C26470")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1C264F4", Offset = "0x1C264F4", VA = "0x1C264F4")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x200002B")]
		public enum AxisOption
		{
			[Token(Token = "0x40000A5")]
			Both,
			[Token(Token = "0x40000A6")]
			OnlyHorizontal,
			[Token(Token = "0x40000A7")]
			OnlyVertical
		}

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1C264FC", Offset = "0x1C264FC", VA = "0x1C264FC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1C26678", Offset = "0x1C26678", VA = "0x1C26678")]
		private void Start()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1C266B4", Offset = "0x1C266B4", VA = "0x1C266B4")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1C26500", Offset = "0x1C26500", VA = "0x1C26500")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1C26718", Offset = "0x1C26718", VA = "0x1C26718", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1C2683C", Offset = "0x1C2683C", VA = "0x1C2683C", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1C26884", Offset = "0x1C26884", VA = "0x1C26884", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1C26888", Offset = "0x1C26888", VA = "0x1C26888")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1C268D8", Offset = "0x1C268D8", VA = "0x1C268D8")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1C26BD0", Offset = "0x1C26BD0", VA = "0x1C26BD0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1C26BE0", Offset = "0x1C26BE0", VA = "0x1C26BE0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1C26BD8", Offset = "0x1C26BD8", VA = "0x1C26BD8")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1C26CF4", Offset = "0x1C26CF4", VA = "0x1C26CF4")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1C26F98", Offset = "0x1C26F98", VA = "0x1C26F98")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x200002E")]
		public enum AxisOptions
		{
			[Token(Token = "0x40000AE")]
			ForwardAxis,
			[Token(Token = "0x40000AF")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x200002F")]
		public class AxisMapping
		{
			[Token(Token = "0x2000030")]
			public enum MappingType
			{
				[Token(Token = "0x40000B3")]
				NamedAxis,
				[Token(Token = "0x40000B4")]
				MousePositionX,
				[Token(Token = "0x40000B5")]
				MousePositionY,
				[Token(Token = "0x40000B6")]
				MousePositionZ
			}

			[Token(Token = "0x40000B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x40000B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x6000090")]
			[Address(RVA = "0x1C2E51C", Offset = "0x1C2E51C", VA = "0x1C2E51C")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1C2C978", Offset = "0x1C2C978", VA = "0x1C2C978")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1C2CA5C", Offset = "0x1C2CA5C", VA = "0x1C2CA5C")]
		private void Update()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1C2CC6C", Offset = "0x1C2CC6C", VA = "0x1C2CC6C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1C2CC88", Offset = "0x1C2CC88", VA = "0x1C2CC88")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7716E4", Offset = "0x7716E4")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000032")]
		public enum AxisOption
		{
			[Token(Token = "0x40000CA")]
			Both,
			[Token(Token = "0x40000CB")]
			OnlyHorizontal,
			[Token(Token = "0x40000CC")]
			OnlyVertical
		}

		[Token(Token = "0x2000033")]
		public enum ControlStyle
		{
			[Token(Token = "0x40000CE")]
			Absolute,
			[Token(Token = "0x40000CF")]
			Relative,
			[Token(Token = "0x40000D0")]
			Swipe
		}

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1C2CC98", Offset = "0x1C2CC98", VA = "0x1C2CC98")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1C2CE14", Offset = "0x1C2CE14", VA = "0x1C2CE14")]
		private void Start()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1C2CC9C", Offset = "0x1C2CC9C", VA = "0x1C2CC9C")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1C2CEA8", Offset = "0x1C2CEA8", VA = "0x1C2CEA8")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1C2CF14", Offset = "0x1C2CF14", VA = "0x1C2CF14", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1C2CF50", Offset = "0x1C2CF50", VA = "0x1C2CF50")]
		private void Update()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1C2D094", Offset = "0x1C2D094", VA = "0x1C2D094", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1C2D0C8", Offset = "0x1C2D0C8", VA = "0x1C2D0C8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1C2D1B8", Offset = "0x1C2D1B8", VA = "0x1C2D1B8")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77179C", Offset = "0x77179C")]
		private Vector3 <virtualMousePosition>k__BackingField;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x1700000C")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x1C2D250", Offset = "0x1C2D250", VA = "0x1C2D250")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x771C74", Offset = "0x771C74")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x1C2D25C", Offset = "0x1C2D25C", VA = "0x1C2D25C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x771C84", Offset = "0x771C84")]
			private set
			{
			}
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1C24A24", Offset = "0x1C24A24", VA = "0x1C24A24")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1C24A88", Offset = "0x1C24A88", VA = "0x1C24A88")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1C24C64", Offset = "0x1C24C64", VA = "0x1C24C64")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1C24E84", Offset = "0x1C24E84", VA = "0x1C24E84")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1C24F24", Offset = "0x1C24F24", VA = "0x1C24F24")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1C251D0", Offset = "0x1C251D0", VA = "0x1C251D0")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1C25254", Offset = "0x1C25254", VA = "0x1C25254")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1C252D8", Offset = "0x1C252D8", VA = "0x1C252D8")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x60000A4")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x60000A5")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x60000A6")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x60000A7")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x60000A8")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x60000A9")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x60000AA")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1C27660", Offset = "0x1C27660", VA = "0x1C27660")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x2000035")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1C26FA0", Offset = "0x1C26FA0", VA = "0x1C26FA0")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1C27098", Offset = "0x1C27098", VA = "0x1C27098")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1C27140", Offset = "0x1C27140", VA = "0x1C27140", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1C271E4", Offset = "0x1C271E4", VA = "0x1C271E4", Slot = "5")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1C272DC", Offset = "0x1C272DC", VA = "0x1C272DC", Slot = "6")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1C273BC", Offset = "0x1C273BC", VA = "0x1C273BC", Slot = "7")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1C27464", Offset = "0x1C27464", VA = "0x1C27464", Slot = "8")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1C2750C", Offset = "0x1C2750C", VA = "0x1C2750C", Slot = "9")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1C275B0", Offset = "0x1C275B0", VA = "0x1C275B0", Slot = "10")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1C24A1C", Offset = "0x1C24A1C", VA = "0x1C24A1C")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1C2C3D0", Offset = "0x1C2C3D0", VA = "0x1C2C3D0", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1C2C3E4", Offset = "0x1C2C3E4", VA = "0x1C2C3E4", Slot = "5")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1C2C438", Offset = "0x1C2C438", VA = "0x1C2C438", Slot = "6")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1C2C48C", Offset = "0x1C2C48C", VA = "0x1C2C48C", Slot = "7")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1C2C4E0", Offset = "0x1C2C4E0", VA = "0x1C2C4E0", Slot = "8")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1C2C534", Offset = "0x1C2C534", VA = "0x1C2C534", Slot = "9")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1C2C588", Offset = "0x1C2C588", VA = "0x1C2C588", Slot = "10")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1C24A20", Offset = "0x1C24A20", VA = "0x1C24A20")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Cameras
{
	[Token(Token = "0x2000037")]
	public abstract class AbstractTargetFollower : MonoBehaviour
	{
		[Token(Token = "0x2000038")]
		public enum UpdateType
		{
			[Token(Token = "0x40000DA")]
			FixedUpdate,
			[Token(Token = "0x40000DB")]
			LateUpdate,
			[Token(Token = "0x40000DC")]
			ManualUpdate
		}

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform m_Target;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_AutoTargetPlayer;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private UpdateType m_UpdateType;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Rigidbody targetRigidbody;

		[Token(Token = "0x1700000D")]
		public Transform Target
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x1C23020", Offset = "0x1C23020", VA = "0x1C23020")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1C22C0C", Offset = "0x1C22C0C", VA = "0x1C22C0C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1C22DA0", Offset = "0x1C22DA0", VA = "0x1C22DA0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1C22E70", Offset = "0x1C22E70", VA = "0x1C22E70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1C22F44", Offset = "0x1C22F44", VA = "0x1C22F44")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x60000C2")]
		protected abstract void FollowTarget(float deltaTime);

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1C22CD0", Offset = "0x1C22CD0", VA = "0x1C22CD0")]
		public void FindAndTargetPlayer()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1C23018", Offset = "0x1C23018", VA = "0x1C23018", Slot = "6")]
		public virtual void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1C23028", Offset = "0x1C23028", VA = "0x1C23028")]
		protected AbstractTargetFollower()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[ExecuteInEditMode]
	public class AutoCam : PivotBasedCameraRig
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_RollSpeed;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_FollowVelocity;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool m_FollowTilt;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_SpinTurnLimit;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_TargetVelocityLowerLimit;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SmoothTurnTime;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_LastFlatAngle;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float m_CurrentTurnAmount;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_TurnSpeedVelocityChange;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 m_RollUp;

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1C23988", Offset = "0x1C23988", VA = "0x1C23988", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1C23D7C", Offset = "0x1C23D7C", VA = "0x1C23D7C")]
		public AutoCam()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class FreeLookCam : PivotBasedCameraRig
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77186C", Offset = "0x77186C")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_TurnSmoothing;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_TiltMax;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_TiltMin;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_LockCursor;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool m_VerticalAutoReturn;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_LookAngle;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_TiltAngle;

		[Token(Token = "0x40000F2")]
		private const float k_LookDistance = 100f;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 m_PivotEulers;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion m_PivotTargetRot;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion m_TransformTargetRot;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1C258E8", Offset = "0x1C258E8", VA = "0x1C258E8", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1C25A40", Offset = "0x1C25A40", VA = "0x1C25A40")]
		protected void Update()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1C25D84", Offset = "0x1C25D84", VA = "0x1C25D84")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1C25DA8", Offset = "0x1C25DA8", VA = "0x1C25DA8", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1C25AA0", Offset = "0x1C25AA0", VA = "0x1C25AA0")]
		private void HandleRotationMovement()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1C25EFC", Offset = "0x1C25EFC", VA = "0x1C25EFC")]
		public FreeLookCam()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class HandHeldCam : LookatTarget
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SwaySpeed;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_BaseSwayAmount;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_TrackingSwayAmount;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77192C", Offset = "0x77192C")]
		private float m_TrackingBias;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1C25F24", Offset = "0x1C25F24", VA = "0x1C25F24", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1C26298", Offset = "0x1C26298", VA = "0x1C26298")]
		public HandHeldCam()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class LookatTarget : AbstractTargetFollower
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 m_RotationRange;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_FollowSpeed;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Vector3 m_FollowVelocity;

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1C26B8C", Offset = "0x1C26B8C", VA = "0x1C26B8C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1C26060", Offset = "0x1C26060", VA = "0x1C26060", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1C262C0", Offset = "0x1C262C0", VA = "0x1C262C0")]
		public LookatTarget()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public abstract class PivotBasedCameraRig : AbstractTargetFollower
	{
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Transform m_Cam;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Transform m_Pivot;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Vector3 m_LastTargetPosition;

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1C259A8", Offset = "0x1C259A8", VA = "0x1C259A8", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1C23DE4", Offset = "0x1C23DE4", VA = "0x1C23DE4")]
		protected PivotBasedCameraRig()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class ProtectCameraFromWallClip : MonoBehaviour
	{
		[Token(Token = "0x200003F")]
		public class RayHitComparer : IComparer
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x1C2E004", Offset = "0x1C2E004", VA = "0x1C2E004", Slot = "4")]
			public int Compare(object x, object y)
			{
				return default(int);
			}

			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x1C2B948", Offset = "0x1C2B948", VA = "0x1C2B948")]
			public RayHitComparer()
			{
			}
		}

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float clipMoveTime;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float returnTime;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sphereCastRadius;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool visualiseInEditor;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float closestDistance;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77198C", Offset = "0x77198C")]
		private bool <protecting>k__BackingField;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string dontClipTag;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_Cam;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_Pivot;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_OriginalDist;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_MoveVelocity;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_CurrentDist;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Ray m_Ray;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit[] m_Hits;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RayHitComparer m_RayHitComparer;

		[Token(Token = "0x1700000E")]
		public bool protecting
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x1C2B820", Offset = "0x1C2B820", VA = "0x1C2B820")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x771C94", Offset = "0x771C94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x1C2B828", Offset = "0x1C2B828", VA = "0x1C2B828")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x771CA4", Offset = "0x771CA4")]
			private set
			{
			}
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1C2B834", Offset = "0x1C2B834", VA = "0x1C2B834")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1C2B950", Offset = "0x1C2B950", VA = "0x1C2B950")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1C2BDF4", Offset = "0x1C2BDF4", VA = "0x1C2BDF4")]
		public ProtectCameraFromWallClip()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class TargetFieldOfView : AbstractTargetFollower
	{
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_FovAdjustTime;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_ZoomAmountMultiplier;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_IncludeEffectsInSize;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_BoundSize;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_FovAdjustVelocity;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_Cam;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform m_LastTarget;

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1C2C5DC", Offset = "0x1C2C5DC", VA = "0x1C2C5DC", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1C2C838", Offset = "0x1C2C838", VA = "0x1C2C838", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1C2C920", Offset = "0x1C2C920", VA = "0x1C2C920", Slot = "6")]
		public override void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1C2C658", Offset = "0x1C2C658", VA = "0x1C2C658")]
		public static float MaxBoundsExtent(Transform obj, bool includeEffects)
		{
			return default(float);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1C2C95C", Offset = "0x1C2C95C", VA = "0x1C2C95C")]
		public TargetFieldOfView()
		{
		}
	}
}
