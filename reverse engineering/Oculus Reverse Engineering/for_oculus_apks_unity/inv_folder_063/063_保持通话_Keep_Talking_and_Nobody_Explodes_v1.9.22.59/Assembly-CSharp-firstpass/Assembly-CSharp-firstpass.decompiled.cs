using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class NativeShare
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AndroidJavaClass m_ajc;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static AndroidJavaObject m_context;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private string subject;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string text;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string title;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string targetPackage;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string targetClass;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<string> files;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<string> mimes;

	[Token(Token = "0x17000001")]
	private static AndroidJavaClass AJC
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xEBB654", Offset = "0xEBB654", VA = "0xEBB654")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	private static AndroidJavaObject Context
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0xEBB730", Offset = "0xEBB730", VA = "0xEBB730")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xEBB548", Offset = "0xEBB548", VA = "0xEBB548")]
	public NativeShare()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xEBB8E0", Offset = "0xEBB8E0", VA = "0xEBB8E0")]
	public NativeShare SetSubject(string subject)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xEBB8EC", Offset = "0xEBB8EC", VA = "0xEBB8EC")]
	public NativeShare SetText(string text)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xEBB8F8", Offset = "0xEBB8F8", VA = "0xEBB8F8")]
	public NativeShare SetTitle(string title)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xEBB904", Offset = "0xEBB904", VA = "0xEBB904")]
	public NativeShare SetTarget(string androidPackageName, [Optional] string androidClassName)
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xEBB99C", Offset = "0xEBB99C", VA = "0xEBB99C")]
	public NativeShare AddFile(string filePath, [Optional] string mime)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xEBBB1C", Offset = "0xEBBB1C", VA = "0xEBBB1C")]
	public void Share()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xEBBEDC", Offset = "0xEBBEDC", VA = "0xEBBEDC")]
	public static bool TargetExists(string androidPackageName, [Optional] string androidClassName)
	{
		return default(bool);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xEBC0E8", Offset = "0xEBC0E8", VA = "0xEBC0E8")]
	public static bool FindTarget(out string androidPackageName, out string androidClassName, string packageNameRegex, [Optional] string classNameRegex)
	{
		return default(bool);
	}
}
namespace Valve.VR
{
	[Token(Token = "0x2000003")]
	public struct IVRSystem
	{
		[Token(Token = "0x2000004")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DC98", Offset = "0x78DC98")]
		internal delegate void _GetRecommendedRenderTargetSize(ref uint pnWidth, ref uint pnHeight);

		[Token(Token = "0x2000005")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DCAC", Offset = "0x78DCAC")]
		internal delegate HmdMatrix44_t _GetProjectionMatrix(EVREye eEye, float fNearZ, float fFarZ);

		[Token(Token = "0x2000006")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DCC0", Offset = "0x78DCC0")]
		internal delegate void _GetProjectionRaw(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom);

		[Token(Token = "0x2000007")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DCD4", Offset = "0x78DCD4")]
		internal delegate bool _ComputeDistortion(EVREye eEye, float fU, float fV, ref DistortionCoordinates_t pDistortionCoordinates);

		[Token(Token = "0x2000008")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DCE8", Offset = "0x78DCE8")]
		internal delegate HmdMatrix34_t _GetEyeToHeadTransform(EVREye eEye);

		[Token(Token = "0x2000009")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DCFC", Offset = "0x78DCFC")]
		internal delegate bool _GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter);

		[Token(Token = "0x200000A")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DD10", Offset = "0x78DD10")]
		internal delegate int _GetD3D9AdapterIndex();

		[Token(Token = "0x200000B")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DD24", Offset = "0x78DD24")]
		internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex);

		[Token(Token = "0x200000C")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DD38", Offset = "0x78DD38")]
		internal delegate void _GetOutputDevice(ref ulong pnDevice, ETextureType textureType);

		[Token(Token = "0x200000D")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DD4C", Offset = "0x78DD4C")]
		internal delegate bool _IsDisplayOnDesktop();

		[Token(Token = "0x200000E")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DD60", Offset = "0x78DD60")]
		internal delegate bool _SetDisplayVisibility(bool bIsVisibleOnDesktop);

		[Token(Token = "0x200000F")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DD74", Offset = "0x78DD74")]
		internal delegate void _GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, [In][Out] TrackedDevicePose_t[] pTrackedDevicePoseArray, uint unTrackedDevicePoseArrayCount);

		[Token(Token = "0x2000010")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DD88", Offset = "0x78DD88")]
		internal delegate void _ResetSeatedZeroPose();

		[Token(Token = "0x2000011")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DD9C", Offset = "0x78DD9C")]
		internal delegate HmdMatrix34_t _GetSeatedZeroPoseToStandingAbsoluteTrackingPose();

		[Token(Token = "0x2000012")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DDB0", Offset = "0x78DDB0")]
		internal delegate HmdMatrix34_t _GetRawZeroPoseToStandingAbsoluteTrackingPose();

		[Token(Token = "0x2000013")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DDC4", Offset = "0x78DDC4")]
		internal delegate uint _GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass eTrackedDeviceClass, [In][Out] uint[] punTrackedDeviceIndexArray, uint unTrackedDeviceIndexArrayCount, uint unRelativeToTrackedDeviceIndex);

		[Token(Token = "0x2000014")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DDD8", Offset = "0x78DDD8")]
		internal delegate EDeviceActivityLevel _GetTrackedDeviceActivityLevel(uint unDeviceId);

		[Token(Token = "0x2000015")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DDEC", Offset = "0x78DDEC")]
		internal delegate void _ApplyTransform(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform);

		[Token(Token = "0x2000016")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DE00", Offset = "0x78DE00")]
		internal delegate uint _GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole unDeviceType);

		[Token(Token = "0x2000017")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DE14", Offset = "0x78DE14")]
		internal delegate ETrackedControllerRole _GetControllerRoleForTrackedDeviceIndex(uint unDeviceIndex);

		[Token(Token = "0x2000018")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DE28", Offset = "0x78DE28")]
		internal delegate ETrackedDeviceClass _GetTrackedDeviceClass(uint unDeviceIndex);

		[Token(Token = "0x2000019")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DE3C", Offset = "0x78DE3C")]
		internal delegate bool _IsTrackedDeviceConnected(uint unDeviceIndex);

		[Token(Token = "0x200001A")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DE50", Offset = "0x78DE50")]
		internal delegate bool _GetBoolTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);

		[Token(Token = "0x200001B")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DE64", Offset = "0x78DE64")]
		internal delegate float _GetFloatTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);

		[Token(Token = "0x200001C")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DE78", Offset = "0x78DE78")]
		internal delegate int _GetInt32TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);

		[Token(Token = "0x200001D")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DE8C", Offset = "0x78DE8C")]
		internal delegate ulong _GetUint64TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);

		[Token(Token = "0x200001E")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DEA0", Offset = "0x78DEA0")]
		internal delegate HmdMatrix34_t _GetMatrix34TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);

		[Token(Token = "0x200001F")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DEB4", Offset = "0x78DEB4")]
		internal delegate uint _GetStringTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError);

		[Token(Token = "0x2000020")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DEC8", Offset = "0x78DEC8")]
		internal delegate IntPtr _GetPropErrorNameFromEnum(ETrackedPropertyError error);

		[Token(Token = "0x2000021")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DEDC", Offset = "0x78DEDC")]
		internal delegate bool _PollNextEvent(ref VREvent_t pEvent, uint uncbVREvent);

		[Token(Token = "0x2000022")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DEF0", Offset = "0x78DEF0")]
		internal delegate bool _PollNextEventWithPose(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose);

		[Token(Token = "0x2000023")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DF04", Offset = "0x78DF04")]
		internal delegate IntPtr _GetEventTypeNameFromEnum(EVREventType eType);

		[Token(Token = "0x2000024")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DF18", Offset = "0x78DF18")]
		internal delegate HiddenAreaMesh_t _GetHiddenAreaMesh(EVREye eEye, EHiddenAreaMeshType type);

		[Token(Token = "0x2000025")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DF2C", Offset = "0x78DF2C")]
		internal delegate bool _GetControllerState(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize);

		[Token(Token = "0x2000026")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DF40", Offset = "0x78DF40")]
		internal delegate bool _GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose);

		[Token(Token = "0x2000027")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DF54", Offset = "0x78DF54")]
		internal delegate void _TriggerHapticPulse(uint unControllerDeviceIndex, uint unAxisId, char usDurationMicroSec);

		[Token(Token = "0x2000028")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DF68", Offset = "0x78DF68")]
		internal delegate IntPtr _GetButtonIdNameFromEnum(EVRButtonId eButtonId);

		[Token(Token = "0x2000029")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DF7C", Offset = "0x78DF7C")]
		internal delegate IntPtr _GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType);

		[Token(Token = "0x200002A")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DF90", Offset = "0x78DF90")]
		internal delegate bool _CaptureInputFocus();

		[Token(Token = "0x200002B")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DFA4", Offset = "0x78DFA4")]
		internal delegate void _ReleaseInputFocus();

		[Token(Token = "0x200002C")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DFB8", Offset = "0x78DFB8")]
		internal delegate bool _IsInputFocusCapturedByAnotherProcess();

		[Token(Token = "0x200002D")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DFCC", Offset = "0x78DFCC")]
		internal delegate uint _DriverDebugRequest(uint unDeviceIndex, string pchRequest, string pchResponseBuffer, uint unResponseBufferSize);

		[Token(Token = "0x200002E")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DFE0", Offset = "0x78DFE0")]
		internal delegate EVRFirmwareError _PerformFirmwareUpdate(uint unDeviceIndex);

		[Token(Token = "0x200002F")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78DFF4", Offset = "0x78DFF4")]
		internal delegate void _AcknowledgeQuit_Exiting();

		[Token(Token = "0x2000030")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E008", Offset = "0x78E008")]
		internal delegate void _AcknowledgeQuit_UserPrompt();

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _GetRecommendedRenderTargetSize GetRecommendedRenderTargetSize;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _GetProjectionMatrix GetProjectionMatrix;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _GetProjectionRaw GetProjectionRaw;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal _ComputeDistortion ComputeDistortion;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal _GetEyeToHeadTransform GetEyeToHeadTransform;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal _GetTimeSinceLastVsync GetTimeSinceLastVsync;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal _GetD3D9AdapterIndex GetD3D9AdapterIndex;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal _GetDXGIOutputInfo GetDXGIOutputInfo;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal _GetOutputDevice GetOutputDevice;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal _IsDisplayOnDesktop IsDisplayOnDesktop;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal _SetDisplayVisibility SetDisplayVisibility;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal _GetDeviceToAbsoluteTrackingPose GetDeviceToAbsoluteTrackingPose;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal _ResetSeatedZeroPose ResetSeatedZeroPose;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal _GetSeatedZeroPoseToStandingAbsoluteTrackingPose GetSeatedZeroPoseToStandingAbsoluteTrackingPose;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal _GetRawZeroPoseToStandingAbsoluteTrackingPose GetRawZeroPoseToStandingAbsoluteTrackingPose;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal _GetSortedTrackedDeviceIndicesOfClass GetSortedTrackedDeviceIndicesOfClass;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal _GetTrackedDeviceActivityLevel GetTrackedDeviceActivityLevel;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal _ApplyTransform ApplyTransform;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal _GetTrackedDeviceIndexForControllerRole GetTrackedDeviceIndexForControllerRole;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal _GetControllerRoleForTrackedDeviceIndex GetControllerRoleForTrackedDeviceIndex;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		internal _GetTrackedDeviceClass GetTrackedDeviceClass;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal _IsTrackedDeviceConnected IsTrackedDeviceConnected;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		internal _GetBoolTrackedDeviceProperty GetBoolTrackedDeviceProperty;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal _GetFloatTrackedDeviceProperty GetFloatTrackedDeviceProperty;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal _GetInt32TrackedDeviceProperty GetInt32TrackedDeviceProperty;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		internal _GetUint64TrackedDeviceProperty GetUint64TrackedDeviceProperty;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		internal _GetMatrix34TrackedDeviceProperty GetMatrix34TrackedDeviceProperty;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		internal _GetStringTrackedDeviceProperty GetStringTrackedDeviceProperty;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		internal _GetPropErrorNameFromEnum GetPropErrorNameFromEnum;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		internal _PollNextEvent PollNextEvent;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		internal _PollNextEventWithPose PollNextEventWithPose;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		internal _GetEventTypeNameFromEnum GetEventTypeNameFromEnum;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		internal _GetHiddenAreaMesh GetHiddenAreaMesh;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		internal _GetControllerState GetControllerState;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		internal _GetControllerStateWithPose GetControllerStateWithPose;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		internal _TriggerHapticPulse TriggerHapticPulse;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		internal _GetButtonIdNameFromEnum GetButtonIdNameFromEnum;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		internal _GetControllerAxisTypeNameFromEnum GetControllerAxisTypeNameFromEnum;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		internal _CaptureInputFocus CaptureInputFocus;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		internal _ReleaseInputFocus ReleaseInputFocus;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal _IsInputFocusCapturedByAnotherProcess IsInputFocusCapturedByAnotherProcess;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		internal _DriverDebugRequest DriverDebugRequest;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		internal _PerformFirmwareUpdate PerformFirmwareUpdate;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		internal _AcknowledgeQuit_Exiting AcknowledgeQuit_Exiting;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		internal _AcknowledgeQuit_UserPrompt AcknowledgeQuit_UserPrompt;
	}
	[Token(Token = "0x2000031")]
	public struct IVRExtendedDisplay
	{
		[Token(Token = "0x2000032")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E01C", Offset = "0x78E01C")]
		internal delegate void _GetWindowBounds(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight);

		[Token(Token = "0x2000033")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E030", Offset = "0x78E030")]
		internal delegate void _GetEyeOutputViewport(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight);

		[Token(Token = "0x2000034")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E044", Offset = "0x78E044")]
		internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex, ref int pnAdapterOutputIndex);

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _GetWindowBounds GetWindowBounds;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _GetEyeOutputViewport GetEyeOutputViewport;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _GetDXGIOutputInfo GetDXGIOutputInfo;
	}
	[Token(Token = "0x2000035")]
	public struct IVRTrackedCamera
	{
		[Token(Token = "0x2000036")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E058", Offset = "0x78E058")]
		internal delegate IntPtr _GetCameraErrorNameFromEnum(EVRTrackedCameraError eCameraError);

		[Token(Token = "0x2000037")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E06C", Offset = "0x78E06C")]
		internal delegate EVRTrackedCameraError _HasCamera(uint nDeviceIndex, ref bool pHasCamera);

		[Token(Token = "0x2000038")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E080", Offset = "0x78E080")]
		internal delegate EVRTrackedCameraError _GetCameraFrameSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref uint pnWidth, ref uint pnHeight, ref uint pnFrameBufferSize);

		[Token(Token = "0x2000039")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E094", Offset = "0x78E094")]
		internal delegate EVRTrackedCameraError _GetCameraIntrinsics(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref HmdVector2_t pFocalLength, ref HmdVector2_t pCenter);

		[Token(Token = "0x200003A")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E0A8", Offset = "0x78E0A8")]
		internal delegate EVRTrackedCameraError _GetCameraProjection(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, float flZNear, float flZFar, ref HmdMatrix44_t pProjection);

		[Token(Token = "0x200003B")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E0BC", Offset = "0x78E0BC")]
		internal delegate EVRTrackedCameraError _AcquireVideoStreamingService(uint nDeviceIndex, ref ulong pHandle);

		[Token(Token = "0x200003C")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E0D0", Offset = "0x78E0D0")]
		internal delegate EVRTrackedCameraError _ReleaseVideoStreamingService(ulong hTrackedCamera);

		[Token(Token = "0x200003D")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E0E4", Offset = "0x78E0E4")]
		internal delegate EVRTrackedCameraError _GetVideoStreamFrameBuffer(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pFrameBuffer, uint nFrameBufferSize, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize);

		[Token(Token = "0x200003E")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E0F8", Offset = "0x78E0F8")]
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref VRTextureBounds_t pTextureBounds, ref uint pnWidth, ref uint pnHeight);

		[Token(Token = "0x200003F")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E10C", Offset = "0x78E10C")]
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureD3D11(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize);

		[Token(Token = "0x2000040")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E120", Offset = "0x78E120")]
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureGL(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, ref uint pglTextureId, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize);

		[Token(Token = "0x2000041")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E134", Offset = "0x78E134")]
		internal delegate EVRTrackedCameraError _ReleaseVideoStreamTextureGL(ulong hTrackedCamera, uint glTextureId);

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _GetCameraErrorNameFromEnum GetCameraErrorNameFromEnum;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _HasCamera HasCamera;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _GetCameraFrameSize GetCameraFrameSize;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal _GetCameraIntrinsics GetCameraIntrinsics;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal _GetCameraProjection GetCameraProjection;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal _AcquireVideoStreamingService AcquireVideoStreamingService;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal _ReleaseVideoStreamingService ReleaseVideoStreamingService;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal _GetVideoStreamFrameBuffer GetVideoStreamFrameBuffer;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal _GetVideoStreamTextureSize GetVideoStreamTextureSize;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal _GetVideoStreamTextureD3D11 GetVideoStreamTextureD3D11;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal _GetVideoStreamTextureGL GetVideoStreamTextureGL;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal _ReleaseVideoStreamTextureGL ReleaseVideoStreamTextureGL;
	}
	[Token(Token = "0x2000042")]
	public struct IVRApplications
	{
		[Token(Token = "0x2000043")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E148", Offset = "0x78E148")]
		internal delegate EVRApplicationError _AddApplicationManifest(string pchApplicationManifestFullPath, bool bTemporary);

		[Token(Token = "0x2000044")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E15C", Offset = "0x78E15C")]
		internal delegate EVRApplicationError _RemoveApplicationManifest(string pchApplicationManifestFullPath);

		[Token(Token = "0x2000045")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E170", Offset = "0x78E170")]
		internal delegate bool _IsApplicationInstalled(string pchAppKey);

		[Token(Token = "0x2000046")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E184", Offset = "0x78E184")]
		internal delegate uint _GetApplicationCount();

		[Token(Token = "0x2000047")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E198", Offset = "0x78E198")]
		internal delegate EVRApplicationError _GetApplicationKeyByIndex(uint unApplicationIndex, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen);

		[Token(Token = "0x2000048")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E1AC", Offset = "0x78E1AC")]
		internal delegate EVRApplicationError _GetApplicationKeyByProcessId(uint unProcessId, string pchAppKeyBuffer, uint unAppKeyBufferLen);

		[Token(Token = "0x2000049")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E1C0", Offset = "0x78E1C0")]
		internal delegate EVRApplicationError _LaunchApplication(string pchAppKey);

		[Token(Token = "0x200004A")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E1D4", Offset = "0x78E1D4")]
		internal delegate EVRApplicationError _LaunchTemplateApplication(string pchTemplateAppKey, string pchNewAppKey, [In][Out] AppOverrideKeys_t[] pKeys, uint unKeys);

		[Token(Token = "0x200004B")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E1E8", Offset = "0x78E1E8")]
		internal delegate EVRApplicationError _LaunchApplicationFromMimeType(string pchMimeType, string pchArgs);

		[Token(Token = "0x200004C")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E1FC", Offset = "0x78E1FC")]
		internal delegate EVRApplicationError _LaunchDashboardOverlay(string pchAppKey);

		[Token(Token = "0x200004D")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E210", Offset = "0x78E210")]
		internal delegate bool _CancelApplicationLaunch(string pchAppKey);

		[Token(Token = "0x200004E")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E224", Offset = "0x78E224")]
		internal delegate EVRApplicationError _IdentifyApplication(uint unProcessId, string pchAppKey);

		[Token(Token = "0x200004F")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E238", Offset = "0x78E238")]
		internal delegate uint _GetApplicationProcessId(string pchAppKey);

		[Token(Token = "0x2000050")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E24C", Offset = "0x78E24C")]
		internal delegate IntPtr _GetApplicationsErrorNameFromEnum(EVRApplicationError error);

		[Token(Token = "0x2000051")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E260", Offset = "0x78E260")]
		internal delegate uint _GetApplicationPropertyString(string pchAppKey, EVRApplicationProperty eProperty, StringBuilder pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError);

		[Token(Token = "0x2000052")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E274", Offset = "0x78E274")]
		internal delegate bool _GetApplicationPropertyBool(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError);

		[Token(Token = "0x2000053")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E288", Offset = "0x78E288")]
		internal delegate ulong _GetApplicationPropertyUint64(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError);

		[Token(Token = "0x2000054")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E29C", Offset = "0x78E29C")]
		internal delegate EVRApplicationError _SetApplicationAutoLaunch(string pchAppKey, bool bAutoLaunch);

		[Token(Token = "0x2000055")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E2B0", Offset = "0x78E2B0")]
		internal delegate bool _GetApplicationAutoLaunch(string pchAppKey);

		[Token(Token = "0x2000056")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E2C4", Offset = "0x78E2C4")]
		internal delegate EVRApplicationError _SetDefaultApplicationForMimeType(string pchAppKey, string pchMimeType);

		[Token(Token = "0x2000057")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E2D8", Offset = "0x78E2D8")]
		internal delegate bool _GetDefaultApplicationForMimeType(string pchMimeType, string pchAppKeyBuffer, uint unAppKeyBufferLen);

		[Token(Token = "0x2000058")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E2EC", Offset = "0x78E2EC")]
		internal delegate bool _GetApplicationSupportedMimeTypes(string pchAppKey, string pchMimeTypesBuffer, uint unMimeTypesBuffer);

		[Token(Token = "0x2000059")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E300", Offset = "0x78E300")]
		internal delegate uint _GetApplicationsThatSupportMimeType(string pchMimeType, string pchAppKeysThatSupportBuffer, uint unAppKeysThatSupportBuffer);

		[Token(Token = "0x200005A")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E314", Offset = "0x78E314")]
		internal delegate uint _GetApplicationLaunchArguments(uint unHandle, string pchArgs, uint unArgs);

		[Token(Token = "0x200005B")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E328", Offset = "0x78E328")]
		internal delegate EVRApplicationError _GetStartingApplication(string pchAppKeyBuffer, uint unAppKeyBufferLen);

		[Token(Token = "0x200005C")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E33C", Offset = "0x78E33C")]
		internal delegate EVRApplicationTransitionState _GetTransitionState();

		[Token(Token = "0x200005D")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E350", Offset = "0x78E350")]
		internal delegate EVRApplicationError _PerformApplicationPrelaunchCheck(string pchAppKey);

		[Token(Token = "0x200005E")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E364", Offset = "0x78E364")]
		internal delegate IntPtr _GetApplicationsTransitionStateNameFromEnum(EVRApplicationTransitionState state);

		[Token(Token = "0x200005F")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E378", Offset = "0x78E378")]
		internal delegate bool _IsQuitUserPromptRequested();

		[Token(Token = "0x2000060")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E38C", Offset = "0x78E38C")]
		internal delegate EVRApplicationError _LaunchInternalProcess(string pchBinaryPath, string pchArguments, string pchWorkingDirectory);

		[Token(Token = "0x2000061")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E3A0", Offset = "0x78E3A0")]
		internal delegate uint _GetCurrentSceneProcessId();

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _AddApplicationManifest AddApplicationManifest;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _RemoveApplicationManifest RemoveApplicationManifest;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _IsApplicationInstalled IsApplicationInstalled;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal _GetApplicationCount GetApplicationCount;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal _GetApplicationKeyByIndex GetApplicationKeyByIndex;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal _GetApplicationKeyByProcessId GetApplicationKeyByProcessId;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal _LaunchApplication LaunchApplication;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal _LaunchTemplateApplication LaunchTemplateApplication;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal _LaunchApplicationFromMimeType LaunchApplicationFromMimeType;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal _LaunchDashboardOverlay LaunchDashboardOverlay;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal _CancelApplicationLaunch CancelApplicationLaunch;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal _IdentifyApplication IdentifyApplication;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal _GetApplicationProcessId GetApplicationProcessId;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal _GetApplicationsErrorNameFromEnum GetApplicationsErrorNameFromEnum;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal _GetApplicationPropertyString GetApplicationPropertyString;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal _GetApplicationPropertyBool GetApplicationPropertyBool;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal _GetApplicationPropertyUint64 GetApplicationPropertyUint64;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal _SetApplicationAutoLaunch SetApplicationAutoLaunch;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal _GetApplicationAutoLaunch GetApplicationAutoLaunch;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal _SetDefaultApplicationForMimeType SetDefaultApplicationForMimeType;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		internal _GetDefaultApplicationForMimeType GetDefaultApplicationForMimeType;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal _GetApplicationSupportedMimeTypes GetApplicationSupportedMimeTypes;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		internal _GetApplicationsThatSupportMimeType GetApplicationsThatSupportMimeType;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal _GetApplicationLaunchArguments GetApplicationLaunchArguments;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal _GetStartingApplication GetStartingApplication;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		internal _GetTransitionState GetTransitionState;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		internal _PerformApplicationPrelaunchCheck PerformApplicationPrelaunchCheck;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		internal _GetApplicationsTransitionStateNameFromEnum GetApplicationsTransitionStateNameFromEnum;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		internal _IsQuitUserPromptRequested IsQuitUserPromptRequested;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		internal _LaunchInternalProcess LaunchInternalProcess;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		internal _GetCurrentSceneProcessId GetCurrentSceneProcessId;
	}
	[Token(Token = "0x2000062")]
	public struct IVRChaperone
	{
		[Token(Token = "0x2000063")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E3B4", Offset = "0x78E3B4")]
		internal delegate ChaperoneCalibrationState _GetCalibrationState();

		[Token(Token = "0x2000064")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E3C8", Offset = "0x78E3C8")]
		internal delegate bool _GetPlayAreaSize(ref float pSizeX, ref float pSizeZ);

		[Token(Token = "0x2000065")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E3DC", Offset = "0x78E3DC")]
		internal delegate bool _GetPlayAreaRect(ref HmdQuad_t rect);

		[Token(Token = "0x2000066")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E3F0", Offset = "0x78E3F0")]
		internal delegate void _ReloadInfo();

		[Token(Token = "0x2000067")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E404", Offset = "0x78E404")]
		internal delegate void _SetSceneColor(HmdColor_t color);

		[Token(Token = "0x2000068")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E418", Offset = "0x78E418")]
		internal delegate void _GetBoundsColor(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor);

		[Token(Token = "0x2000069")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E42C", Offset = "0x78E42C")]
		internal delegate bool _AreBoundsVisible();

		[Token(Token = "0x200006A")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E440", Offset = "0x78E440")]
		internal delegate void _ForceBoundsVisible(bool bForce);

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _GetCalibrationState GetCalibrationState;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _GetPlayAreaSize GetPlayAreaSize;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _GetPlayAreaRect GetPlayAreaRect;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal _ReloadInfo ReloadInfo;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal _SetSceneColor SetSceneColor;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal _GetBoundsColor GetBoundsColor;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal _AreBoundsVisible AreBoundsVisible;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal _ForceBoundsVisible ForceBoundsVisible;
	}
	[Token(Token = "0x200006B")]
	public struct IVRChaperoneSetup
	{
		[Token(Token = "0x200006C")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E454", Offset = "0x78E454")]
		internal delegate bool _CommitWorkingCopy(EChaperoneConfigFile configFile);

		[Token(Token = "0x200006D")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E468", Offset = "0x78E468")]
		internal delegate void _RevertWorkingCopy();

		[Token(Token = "0x200006E")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E47C", Offset = "0x78E47C")]
		internal delegate bool _GetWorkingPlayAreaSize(ref float pSizeX, ref float pSizeZ);

		[Token(Token = "0x200006F")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E490", Offset = "0x78E490")]
		internal delegate bool _GetWorkingPlayAreaRect(ref HmdQuad_t rect);

		[Token(Token = "0x2000070")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E4A4", Offset = "0x78E4A4")]
		internal delegate bool _GetWorkingCollisionBoundsInfo([In][Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount);

		[Token(Token = "0x2000071")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E4B8", Offset = "0x78E4B8")]
		internal delegate bool _GetLiveCollisionBoundsInfo([In][Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount);

		[Token(Token = "0x2000072")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E4CC", Offset = "0x78E4CC")]
		internal delegate bool _GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose);

		[Token(Token = "0x2000073")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E4E0", Offset = "0x78E4E0")]
		internal delegate bool _GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose);

		[Token(Token = "0x2000074")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E4F4", Offset = "0x78E4F4")]
		internal delegate void _SetWorkingPlayAreaSize(float sizeX, float sizeZ);

		[Token(Token = "0x2000075")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E508", Offset = "0x78E508")]
		internal delegate void _SetWorkingCollisionBoundsInfo([In][Out] HmdQuad_t[] pQuadsBuffer, uint unQuadsCount);

		[Token(Token = "0x2000076")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E51C", Offset = "0x78E51C")]
		internal delegate void _SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose);

		[Token(Token = "0x2000077")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E530", Offset = "0x78E530")]
		internal delegate void _SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose);

		[Token(Token = "0x2000078")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E544", Offset = "0x78E544")]
		internal delegate void _ReloadFromDisk(EChaperoneConfigFile configFile);

		[Token(Token = "0x2000079")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E558", Offset = "0x78E558")]
		internal delegate bool _GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose);

		[Token(Token = "0x200007A")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E56C", Offset = "0x78E56C")]
		internal delegate void _SetWorkingCollisionBoundsTagsInfo([In][Out] byte[] pTagsBuffer, uint unTagCount);

		[Token(Token = "0x200007B")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E580", Offset = "0x78E580")]
		internal delegate bool _GetLiveCollisionBoundsTagsInfo([In][Out] byte[] pTagsBuffer, ref uint punTagCount);

		[Token(Token = "0x200007C")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E594", Offset = "0x78E594")]
		internal delegate bool _SetWorkingPhysicalBoundsInfo([In][Out] HmdQuad_t[] pQuadsBuffer, uint unQuadsCount);

		[Token(Token = "0x200007D")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E5A8", Offset = "0x78E5A8")]
		internal delegate bool _GetLivePhysicalBoundsInfo([In][Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount);

		[Token(Token = "0x200007E")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E5BC", Offset = "0x78E5BC")]
		internal delegate bool _ExportLiveToBuffer(StringBuilder pBuffer, ref uint pnBufferLength);

		[Token(Token = "0x200007F")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E5D0", Offset = "0x78E5D0")]
		internal delegate bool _ImportFromBufferToWorking(string pBuffer, uint nImportFlags);

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _CommitWorkingCopy CommitWorkingCopy;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _RevertWorkingCopy RevertWorkingCopy;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _GetWorkingPlayAreaSize GetWorkingPlayAreaSize;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal _GetWorkingPlayAreaRect GetWorkingPlayAreaRect;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal _GetWorkingCollisionBoundsInfo GetWorkingCollisionBoundsInfo;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal _GetLiveCollisionBoundsInfo GetLiveCollisionBoundsInfo;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal _GetWorkingSeatedZeroPoseToRawTrackingPose GetWorkingSeatedZeroPoseToRawTrackingPose;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal _GetWorkingStandingZeroPoseToRawTrackingPose GetWorkingStandingZeroPoseToRawTrackingPose;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal _SetWorkingPlayAreaSize SetWorkingPlayAreaSize;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal _SetWorkingCollisionBoundsInfo SetWorkingCollisionBoundsInfo;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal _SetWorkingSeatedZeroPoseToRawTrackingPose SetWorkingSeatedZeroPoseToRawTrackingPose;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal _SetWorkingStandingZeroPoseToRawTrackingPose SetWorkingStandingZeroPoseToRawTrackingPose;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal _ReloadFromDisk ReloadFromDisk;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal _GetLiveSeatedZeroPoseToRawTrackingPose GetLiveSeatedZeroPoseToRawTrackingPose;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal _SetWorkingCollisionBoundsTagsInfo SetWorkingCollisionBoundsTagsInfo;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal _GetLiveCollisionBoundsTagsInfo GetLiveCollisionBoundsTagsInfo;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal _SetWorkingPhysicalBoundsInfo SetWorkingPhysicalBoundsInfo;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal _GetLivePhysicalBoundsInfo GetLivePhysicalBoundsInfo;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal _ExportLiveToBuffer ExportLiveToBuffer;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal _ImportFromBufferToWorking ImportFromBufferToWorking;
	}
	[Token(Token = "0x2000080")]
	public struct IVRCompositor
	{
		[Token(Token = "0x2000081")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E5E4", Offset = "0x78E5E4")]
		internal delegate void _SetTrackingSpace(ETrackingUniverseOrigin eOrigin);

		[Token(Token = "0x2000082")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E5F8", Offset = "0x78E5F8")]
		internal delegate ETrackingUniverseOrigin _GetTrackingSpace();

		[Token(Token = "0x2000083")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E60C", Offset = "0x78E60C")]
		internal delegate EVRCompositorError _WaitGetPoses([In][Out] TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, [In][Out] TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount);

		[Token(Token = "0x2000084")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E620", Offset = "0x78E620")]
		internal delegate EVRCompositorError _GetLastPoses([In][Out] TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, [In][Out] TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount);

		[Token(Token = "0x2000085")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E634", Offset = "0x78E634")]
		internal delegate EVRCompositorError _GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose);

		[Token(Token = "0x2000086")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E648", Offset = "0x78E648")]
		internal delegate EVRCompositorError _Submit(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags);

		[Token(Token = "0x2000087")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E65C", Offset = "0x78E65C")]
		internal delegate void _ClearLastSubmittedFrame();

		[Token(Token = "0x2000088")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E670", Offset = "0x78E670")]
		internal delegate void _PostPresentHandoff();

		[Token(Token = "0x2000089")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E684", Offset = "0x78E684")]
		internal delegate bool _GetFrameTiming(ref Compositor_FrameTiming pTiming, uint unFramesAgo);

		[Token(Token = "0x200008A")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E698", Offset = "0x78E698")]
		internal delegate uint _GetFrameTimings(ref Compositor_FrameTiming pTiming, uint nFrames);

		[Token(Token = "0x200008B")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E6AC", Offset = "0x78E6AC")]
		internal delegate float _GetFrameTimeRemaining();

		[Token(Token = "0x200008C")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E6C0", Offset = "0x78E6C0")]
		internal delegate void _GetCumulativeStats(ref Compositor_CumulativeStats pStats, uint nStatsSizeInBytes);

		[Token(Token = "0x200008D")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E6D4", Offset = "0x78E6D4")]
		internal delegate void _FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground);

		[Token(Token = "0x200008E")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E6E8", Offset = "0x78E6E8")]
		internal delegate HmdColor_t _GetCurrentFadeColor(bool bBackground);

		[Token(Token = "0x200008F")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E6FC", Offset = "0x78E6FC")]
		internal delegate void _FadeGrid(float fSeconds, bool bFadeIn);

		[Token(Token = "0x2000090")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E710", Offset = "0x78E710")]
		internal delegate float _GetCurrentGridAlpha();

		[Token(Token = "0x2000091")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E724", Offset = "0x78E724")]
		internal delegate EVRCompositorError _SetSkyboxOverride([In][Out] Texture_t[] pTextures, uint unTextureCount);

		[Token(Token = "0x2000092")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E738", Offset = "0x78E738")]
		internal delegate void _ClearSkyboxOverride();

		[Token(Token = "0x2000093")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E74C", Offset = "0x78E74C")]
		internal delegate void _CompositorBringToFront();

		[Token(Token = "0x2000094")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E760", Offset = "0x78E760")]
		internal delegate void _CompositorGoToBack();

		[Token(Token = "0x2000095")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E774", Offset = "0x78E774")]
		internal delegate void _CompositorQuit();

		[Token(Token = "0x2000096")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E788", Offset = "0x78E788")]
		internal delegate bool _IsFullscreen();

		[Token(Token = "0x2000097")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E79C", Offset = "0x78E79C")]
		internal delegate uint _GetCurrentSceneFocusProcess();

		[Token(Token = "0x2000098")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E7B0", Offset = "0x78E7B0")]
		internal delegate uint _GetLastFrameRenderer();

		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E7C4", Offset = "0x78E7C4")]
		internal delegate bool _CanRenderScene();

		[Token(Token = "0x200009A")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E7D8", Offset = "0x78E7D8")]
		internal delegate void _ShowMirrorWindow();

		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E7EC", Offset = "0x78E7EC")]
		internal delegate void _HideMirrorWindow();

		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E800", Offset = "0x78E800")]
		internal delegate bool _IsMirrorWindowVisible();

		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E814", Offset = "0x78E814")]
		internal delegate void _CompositorDumpImages();

		[Token(Token = "0x200009E")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E828", Offset = "0x78E828")]
		internal delegate bool _ShouldAppRenderWithLowResources();

		[Token(Token = "0x200009F")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E83C", Offset = "0x78E83C")]
		internal delegate void _ForceInterleavedReprojectionOn(bool bOverride);

		[Token(Token = "0x20000A0")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E850", Offset = "0x78E850")]
		internal delegate void _ForceReconnectProcess();

		[Token(Token = "0x20000A1")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E864", Offset = "0x78E864")]
		internal delegate void _SuspendRendering(bool bSuspend);

		[Token(Token = "0x20000A2")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E878", Offset = "0x78E878")]
		internal delegate EVRCompositorError _GetMirrorTextureD3D11(EVREye eEye, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView);

		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E88C", Offset = "0x78E88C")]
		internal delegate void _ReleaseMirrorTextureD3D11(IntPtr pD3D11ShaderResourceView);

		[Token(Token = "0x20000A4")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E8A0", Offset = "0x78E8A0")]
		internal delegate EVRCompositorError _GetMirrorTextureGL(EVREye eEye, ref uint pglTextureId, IntPtr pglSharedTextureHandle);

		[Token(Token = "0x20000A5")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E8B4", Offset = "0x78E8B4")]
		internal delegate bool _ReleaseSharedGLTexture(uint glTextureId, IntPtr glSharedTextureHandle);

		[Token(Token = "0x20000A6")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E8C8", Offset = "0x78E8C8")]
		internal delegate void _LockGLSharedTextureForAccess(IntPtr glSharedTextureHandle);

		[Token(Token = "0x20000A7")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E8DC", Offset = "0x78E8DC")]
		internal delegate void _UnlockGLSharedTextureForAccess(IntPtr glSharedTextureHandle);

		[Token(Token = "0x20000A8")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E8F0", Offset = "0x78E8F0")]
		internal delegate uint _GetVulkanInstanceExtensionsRequired(StringBuilder pchValue, uint unBufferSize);

		[Token(Token = "0x20000A9")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E904", Offset = "0x78E904")]
		internal delegate uint _GetVulkanDeviceExtensionsRequired(IntPtr pPhysicalDevice, StringBuilder pchValue, uint unBufferSize);

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _SetTrackingSpace SetTrackingSpace;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _GetTrackingSpace GetTrackingSpace;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _WaitGetPoses WaitGetPoses;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal _GetLastPoses GetLastPoses;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal _GetLastPoseForTrackedDeviceIndex GetLastPoseForTrackedDeviceIndex;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal _Submit Submit;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal _ClearLastSubmittedFrame ClearLastSubmittedFrame;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal _PostPresentHandoff PostPresentHandoff;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal _GetFrameTiming GetFrameTiming;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal _GetFrameTimings GetFrameTimings;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal _GetFrameTimeRemaining GetFrameTimeRemaining;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal _GetCumulativeStats GetCumulativeStats;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal _FadeToColor FadeToColor;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal _GetCurrentFadeColor GetCurrentFadeColor;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal _FadeGrid FadeGrid;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal _GetCurrentGridAlpha GetCurrentGridAlpha;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal _SetSkyboxOverride SetSkyboxOverride;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal _ClearSkyboxOverride ClearSkyboxOverride;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal _CompositorBringToFront CompositorBringToFront;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal _CompositorGoToBack CompositorGoToBack;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		internal _CompositorQuit CompositorQuit;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal _IsFullscreen IsFullscreen;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		internal _GetCurrentSceneFocusProcess GetCurrentSceneFocusProcess;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal _GetLastFrameRenderer GetLastFrameRenderer;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal _CanRenderScene CanRenderScene;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		internal _ShowMirrorWindow ShowMirrorWindow;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		internal _HideMirrorWindow HideMirrorWindow;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		internal _IsMirrorWindowVisible IsMirrorWindowVisible;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		internal _CompositorDumpImages CompositorDumpImages;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		internal _ShouldAppRenderWithLowResources ShouldAppRenderWithLowResources;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		internal _ForceInterleavedReprojectionOn ForceInterleavedReprojectionOn;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		internal _ForceReconnectProcess ForceReconnectProcess;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		internal _SuspendRendering SuspendRendering;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		internal _GetMirrorTextureD3D11 GetMirrorTextureD3D11;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		internal _ReleaseMirrorTextureD3D11 ReleaseMirrorTextureD3D11;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		internal _GetMirrorTextureGL GetMirrorTextureGL;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		internal _ReleaseSharedGLTexture ReleaseSharedGLTexture;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		internal _LockGLSharedTextureForAccess LockGLSharedTextureForAccess;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		internal _UnlockGLSharedTextureForAccess UnlockGLSharedTextureForAccess;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		internal _GetVulkanInstanceExtensionsRequired GetVulkanInstanceExtensionsRequired;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal _GetVulkanDeviceExtensionsRequired GetVulkanDeviceExtensionsRequired;
	}
	[Token(Token = "0x20000AA")]
	public struct IVROverlay
	{
		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E918", Offset = "0x78E918")]
		internal delegate EVROverlayError _FindOverlay(string pchOverlayKey, ref ulong pOverlayHandle);

		[Token(Token = "0x20000AC")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E92C", Offset = "0x78E92C")]
		internal delegate EVROverlayError _CreateOverlay(string pchOverlayKey, string pchOverlayName, ref ulong pOverlayHandle);

		[Token(Token = "0x20000AD")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E940", Offset = "0x78E940")]
		internal delegate EVROverlayError _DestroyOverlay(ulong ulOverlayHandle);

		[Token(Token = "0x20000AE")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E954", Offset = "0x78E954")]
		internal delegate EVROverlayError _SetHighQualityOverlay(ulong ulOverlayHandle);

		[Token(Token = "0x20000AF")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E968", Offset = "0x78E968")]
		internal delegate ulong _GetHighQualityOverlay();

		[Token(Token = "0x20000B0")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E97C", Offset = "0x78E97C")]
		internal delegate uint _GetOverlayKey(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError);

		[Token(Token = "0x20000B1")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E990", Offset = "0x78E990")]
		internal delegate uint _GetOverlayName(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError);

		[Token(Token = "0x20000B2")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E9A4", Offset = "0x78E9A4")]
		internal delegate EVROverlayError _SetOverlayName(ulong ulOverlayHandle, string pchName);

		[Token(Token = "0x20000B3")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E9B8", Offset = "0x78E9B8")]
		internal delegate EVROverlayError _GetOverlayImageData(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight);

		[Token(Token = "0x20000B4")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E9CC", Offset = "0x78E9CC")]
		internal delegate IntPtr _GetOverlayErrorNameFromEnum(EVROverlayError error);

		[Token(Token = "0x20000B5")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E9E0", Offset = "0x78E9E0")]
		internal delegate EVROverlayError _SetOverlayRenderingPid(ulong ulOverlayHandle, uint unPID);

		[Token(Token = "0x20000B6")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78E9F4", Offset = "0x78E9F4")]
		internal delegate uint _GetOverlayRenderingPid(ulong ulOverlayHandle);

		[Token(Token = "0x20000B7")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EA08", Offset = "0x78EA08")]
		internal delegate EVROverlayError _SetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, bool bEnabled);

		[Token(Token = "0x20000B8")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EA1C", Offset = "0x78EA1C")]
		internal delegate EVROverlayError _GetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, ref bool pbEnabled);

		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EA30", Offset = "0x78EA30")]
		internal delegate EVROverlayError _SetOverlayColor(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue);

		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EA44", Offset = "0x78EA44")]
		internal delegate EVROverlayError _GetOverlayColor(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue);

		[Token(Token = "0x20000BB")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EA58", Offset = "0x78EA58")]
		internal delegate EVROverlayError _SetOverlayAlpha(ulong ulOverlayHandle, float fAlpha);

		[Token(Token = "0x20000BC")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EA6C", Offset = "0x78EA6C")]
		internal delegate EVROverlayError _GetOverlayAlpha(ulong ulOverlayHandle, ref float pfAlpha);

		[Token(Token = "0x20000BD")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EA80", Offset = "0x78EA80")]
		internal delegate EVROverlayError _SetOverlayTexelAspect(ulong ulOverlayHandle, float fTexelAspect);

		[Token(Token = "0x20000BE")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EA94", Offset = "0x78EA94")]
		internal delegate EVROverlayError _GetOverlayTexelAspect(ulong ulOverlayHandle, ref float pfTexelAspect);

		[Token(Token = "0x20000BF")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EAA8", Offset = "0x78EAA8")]
		internal delegate EVROverlayError _SetOverlaySortOrder(ulong ulOverlayHandle, uint unSortOrder);

		[Token(Token = "0x20000C0")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EABC", Offset = "0x78EABC")]
		internal delegate EVROverlayError _GetOverlaySortOrder(ulong ulOverlayHandle, ref uint punSortOrder);

		[Token(Token = "0x20000C1")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EAD0", Offset = "0x78EAD0")]
		internal delegate EVROverlayError _SetOverlayWidthInMeters(ulong ulOverlayHandle, float fWidthInMeters);

		[Token(Token = "0x20000C2")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EAE4", Offset = "0x78EAE4")]
		internal delegate EVROverlayError _GetOverlayWidthInMeters(ulong ulOverlayHandle, ref float pfWidthInMeters);

		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EAF8", Offset = "0x78EAF8")]
		internal delegate EVROverlayError _SetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, float fMinDistanceInMeters, float fMaxDistanceInMeters);

		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EB0C", Offset = "0x78EB0C")]
		internal delegate EVROverlayError _GetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, ref float pfMinDistanceInMeters, ref float pfMaxDistanceInMeters);

		[Token(Token = "0x20000C5")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EB20", Offset = "0x78EB20")]
		internal delegate EVROverlayError _SetOverlayTextureColorSpace(ulong ulOverlayHandle, EColorSpace eTextureColorSpace);

		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EB34", Offset = "0x78EB34")]
		internal delegate EVROverlayError _GetOverlayTextureColorSpace(ulong ulOverlayHandle, ref EColorSpace peTextureColorSpace);

		[Token(Token = "0x20000C7")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EB48", Offset = "0x78EB48")]
		internal delegate EVROverlayError _SetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds);

		[Token(Token = "0x20000C8")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EB5C", Offset = "0x78EB5C")]
		internal delegate EVROverlayError _GetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds);

		[Token(Token = "0x20000C9")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EB70", Offset = "0x78EB70")]
		internal delegate uint _GetOverlayRenderModel(ulong ulOverlayHandle, string pchValue, uint unBufferSize, ref HmdColor_t pColor, ref EVROverlayError pError);

		[Token(Token = "0x20000CA")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EB84", Offset = "0x78EB84")]
		internal delegate EVROverlayError _SetOverlayRenderModel(ulong ulOverlayHandle, string pchRenderModel, ref HmdColor_t pColor);

		[Token(Token = "0x20000CB")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EB98", Offset = "0x78EB98")]
		internal delegate EVROverlayError _GetOverlayTransformType(ulong ulOverlayHandle, ref VROverlayTransformType peTransformType);

		[Token(Token = "0x20000CC")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EBAC", Offset = "0x78EBAC")]
		internal delegate EVROverlayError _SetOverlayTransformAbsolute(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform);

		[Token(Token = "0x20000CD")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EBC0", Offset = "0x78EBC0")]
		internal delegate EVROverlayError _GetOverlayTransformAbsolute(ulong ulOverlayHandle, ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform);

		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EBD4", Offset = "0x78EBD4")]
		internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, uint unTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform);

		[Token(Token = "0x20000CF")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EBE8", Offset = "0x78EBE8")]
		internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform);

		[Token(Token = "0x20000D0")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EBFC", Offset = "0x78EBFC")]
		internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, uint unDeviceIndex, string pchComponentName);

		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EC10", Offset = "0x78EC10")]
		internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, ref uint punDeviceIndex, string pchComponentName, uint unComponentNameSize);

		[Token(Token = "0x20000D2")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EC24", Offset = "0x78EC24")]
		internal delegate EVROverlayError _GetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ref ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform);

		[Token(Token = "0x20000D3")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EC38", Offset = "0x78EC38")]
		internal delegate EVROverlayError _SetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform);

		[Token(Token = "0x20000D4")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EC4C", Offset = "0x78EC4C")]
		internal delegate EVROverlayError _ShowOverlay(ulong ulOverlayHandle);

		[Token(Token = "0x20000D5")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EC60", Offset = "0x78EC60")]
		internal delegate EVROverlayError _HideOverlay(ulong ulOverlayHandle);

		[Token(Token = "0x20000D6")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EC74", Offset = "0x78EC74")]
		internal delegate bool _IsOverlayVisible(ulong ulOverlayHandle);

		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EC88", Offset = "0x78EC88")]
		internal delegate EVROverlayError _GetTransformForOverlayCoordinates(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, HmdVector2_t coordinatesInOverlay, ref HmdMatrix34_t pmatTransform);

		[Token(Token = "0x20000D8")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EC9C", Offset = "0x78EC9C")]
		internal delegate bool _PollNextOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pEvent, uint uncbVREvent);

		[Token(Token = "0x20000D9")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78ECB0", Offset = "0x78ECB0")]
		internal delegate EVROverlayError _GetOverlayInputMethod(ulong ulOverlayHandle, ref VROverlayInputMethod peInputMethod);

		[Token(Token = "0x20000DA")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78ECC4", Offset = "0x78ECC4")]
		internal delegate EVROverlayError _SetOverlayInputMethod(ulong ulOverlayHandle, VROverlayInputMethod eInputMethod);

		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78ECD8", Offset = "0x78ECD8")]
		internal delegate EVROverlayError _GetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale);

		[Token(Token = "0x20000DC")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78ECEC", Offset = "0x78ECEC")]
		internal delegate EVROverlayError _SetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale);

		[Token(Token = "0x20000DD")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78ED00", Offset = "0x78ED00")]
		internal delegate bool _ComputeOverlayIntersection(ulong ulOverlayHandle, ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults);

		[Token(Token = "0x20000DE")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78ED14", Offset = "0x78ED14")]
		internal delegate bool _HandleControllerOverlayInteractionAsMouse(ulong ulOverlayHandle, uint unControllerDeviceIndex);

		[Token(Token = "0x20000DF")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78ED28", Offset = "0x78ED28")]
		internal delegate bool _IsHoverTargetOverlay(ulong ulOverlayHandle);

		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78ED3C", Offset = "0x78ED3C")]
		internal delegate ulong _GetGamepadFocusOverlay();

		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78ED50", Offset = "0x78ED50")]
		internal delegate EVROverlayError _SetGamepadFocusOverlay(ulong ulNewFocusOverlay);

		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78ED64", Offset = "0x78ED64")]
		internal delegate EVROverlayError _SetOverlayNeighbor(EOverlayDirection eDirection, ulong ulFrom, ulong ulTo);

		[Token(Token = "0x20000E3")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78ED78", Offset = "0x78ED78")]
		internal delegate EVROverlayError _MoveGamepadFocusToNeighbor(EOverlayDirection eDirection, ulong ulFrom);

		[Token(Token = "0x20000E4")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78ED8C", Offset = "0x78ED8C")]
		internal delegate EVROverlayError _SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture);

		[Token(Token = "0x20000E5")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EDA0", Offset = "0x78EDA0")]
		internal delegate EVROverlayError _ClearOverlayTexture(ulong ulOverlayHandle);

		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EDB4", Offset = "0x78EDB4")]
		internal delegate EVROverlayError _SetOverlayRaw(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unDepth);

		[Token(Token = "0x20000E7")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EDC8", Offset = "0x78EDC8")]
		internal delegate EVROverlayError _SetOverlayFromFile(ulong ulOverlayHandle, string pchFilePath);

		[Token(Token = "0x20000E8")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EDDC", Offset = "0x78EDDC")]
		internal delegate EVROverlayError _GetOverlayTexture(ulong ulOverlayHandle, ref IntPtr pNativeTextureHandle, IntPtr pNativeTextureRef, ref uint pWidth, ref uint pHeight, ref uint pNativeFormat, ref ETextureType pAPIType, ref EColorSpace pColorSpace, ref VRTextureBounds_t pTextureBounds);

		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EDF0", Offset = "0x78EDF0")]
		internal delegate EVROverlayError _ReleaseNativeOverlayHandle(ulong ulOverlayHandle, IntPtr pNativeTextureHandle);

		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EE04", Offset = "0x78EE04")]
		internal delegate EVROverlayError _GetOverlayTextureSize(ulong ulOverlayHandle, ref uint pWidth, ref uint pHeight);

		[Token(Token = "0x20000EB")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EE18", Offset = "0x78EE18")]
		internal delegate EVROverlayError _CreateDashboardOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle);

		[Token(Token = "0x20000EC")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EE2C", Offset = "0x78EE2C")]
		internal delegate bool _IsDashboardVisible();

		[Token(Token = "0x20000ED")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EE40", Offset = "0x78EE40")]
		internal delegate bool _IsActiveDashboardOverlay(ulong ulOverlayHandle);

		[Token(Token = "0x20000EE")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EE54", Offset = "0x78EE54")]
		internal delegate EVROverlayError _SetDashboardOverlaySceneProcess(ulong ulOverlayHandle, uint unProcessId);

		[Token(Token = "0x20000EF")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EE68", Offset = "0x78EE68")]
		internal delegate EVROverlayError _GetDashboardOverlaySceneProcess(ulong ulOverlayHandle, ref uint punProcessId);

		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EE7C", Offset = "0x78EE7C")]
		internal delegate void _ShowDashboard(string pchOverlayToShow);

		[Token(Token = "0x20000F1")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EE90", Offset = "0x78EE90")]
		internal delegate uint _GetPrimaryDashboardDevice();

		[Token(Token = "0x20000F2")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EEA4", Offset = "0x78EEA4")]
		internal delegate EVROverlayError _ShowKeyboard(int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue);

		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EEB8", Offset = "0x78EEB8")]
		internal delegate EVROverlayError _ShowKeyboardForOverlay(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue);

		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EECC", Offset = "0x78EECC")]
		internal delegate uint _GetKeyboardText(StringBuilder pchText, uint cchText);

		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EEE0", Offset = "0x78EEE0")]
		internal delegate void _HideKeyboard();

		[Token(Token = "0x20000F6")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EEF4", Offset = "0x78EEF4")]
		internal delegate void _SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform);

		[Token(Token = "0x20000F7")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EF08", Offset = "0x78EF08")]
		internal delegate void _SetKeyboardPositionForOverlay(ulong ulOverlayHandle, HmdRect2_t avoidRect);

		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EF1C", Offset = "0x78EF1C")]
		internal delegate EVROverlayError _SetOverlayIntersectionMask(ulong ulOverlayHandle, ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives, uint unNumMaskPrimitives, uint unPrimitiveSize);

		[Token(Token = "0x20000F9")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EF30", Offset = "0x78EF30")]
		internal delegate EVROverlayError _GetOverlayFlags(ulong ulOverlayHandle, ref uint pFlags);

		[Token(Token = "0x20000FA")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EF44", Offset = "0x78EF44")]
		internal delegate VRMessageOverlayResponse _ShowMessageOverlay(string pchText, string pchCaption, string pchButton0Text, string pchButton1Text, string pchButton2Text, string pchButton3Text);

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _FindOverlay FindOverlay;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _CreateOverlay CreateOverlay;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _DestroyOverlay DestroyOverlay;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal _SetHighQualityOverlay SetHighQualityOverlay;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal _GetHighQualityOverlay GetHighQualityOverlay;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal _GetOverlayKey GetOverlayKey;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal _GetOverlayName GetOverlayName;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal _SetOverlayName SetOverlayName;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal _GetOverlayImageData GetOverlayImageData;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal _GetOverlayErrorNameFromEnum GetOverlayErrorNameFromEnum;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal _SetOverlayRenderingPid SetOverlayRenderingPid;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal _GetOverlayRenderingPid GetOverlayRenderingPid;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal _SetOverlayFlag SetOverlayFlag;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal _GetOverlayFlag GetOverlayFlag;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal _SetOverlayColor SetOverlayColor;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal _GetOverlayColor GetOverlayColor;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal _SetOverlayAlpha SetOverlayAlpha;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal _GetOverlayAlpha GetOverlayAlpha;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal _SetOverlayTexelAspect SetOverlayTexelAspect;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal _GetOverlayTexelAspect GetOverlayTexelAspect;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		internal _SetOverlaySortOrder SetOverlaySortOrder;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal _GetOverlaySortOrder GetOverlaySortOrder;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		internal _SetOverlayWidthInMeters SetOverlayWidthInMeters;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal _GetOverlayWidthInMeters GetOverlayWidthInMeters;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal _SetOverlayAutoCurveDistanceRangeInMeters SetOverlayAutoCurveDistanceRangeInMeters;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		internal _GetOverlayAutoCurveDistanceRangeInMeters GetOverlayAutoCurveDistanceRangeInMeters;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		internal _SetOverlayTextureColorSpace SetOverlayTextureColorSpace;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		internal _GetOverlayTextureColorSpace GetOverlayTextureColorSpace;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		internal _SetOverlayTextureBounds SetOverlayTextureBounds;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		internal _GetOverlayTextureBounds GetOverlayTextureBounds;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		internal _GetOverlayRenderModel GetOverlayRenderModel;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		internal _SetOverlayRenderModel SetOverlayRenderModel;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		internal _GetOverlayTransformType GetOverlayTransformType;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		internal _SetOverlayTransformAbsolute SetOverlayTransformAbsolute;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		internal _GetOverlayTransformAbsolute GetOverlayTransformAbsolute;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		internal _SetOverlayTransformTrackedDeviceRelative SetOverlayTransformTrackedDeviceRelative;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		internal _GetOverlayTransformTrackedDeviceRelative GetOverlayTransformTrackedDeviceRelative;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		internal _SetOverlayTransformTrackedDeviceComponent SetOverlayTransformTrackedDeviceComponent;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		internal _GetOverlayTransformTrackedDeviceComponent GetOverlayTransformTrackedDeviceComponent;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		internal _GetOverlayTransformOverlayRelative GetOverlayTransformOverlayRelative;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal _SetOverlayTransformOverlayRelative SetOverlayTransformOverlayRelative;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		internal _ShowOverlay ShowOverlay;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		internal _HideOverlay HideOverlay;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		internal _IsOverlayVisible IsOverlayVisible;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		internal _GetTransformForOverlayCoordinates GetTransformForOverlayCoordinates;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		internal _PollNextOverlayEvent PollNextOverlayEvent;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		internal _GetOverlayInputMethod GetOverlayInputMethod;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		internal _SetOverlayInputMethod SetOverlayInputMethod;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		internal _GetOverlayMouseScale GetOverlayMouseScale;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		internal _SetOverlayMouseScale SetOverlayMouseScale;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		internal _ComputeOverlayIntersection ComputeOverlayIntersection;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		internal _HandleControllerOverlayInteractionAsMouse HandleControllerOverlayInteractionAsMouse;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		internal _IsHoverTargetOverlay IsHoverTargetOverlay;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		internal _GetGamepadFocusOverlay GetGamepadFocusOverlay;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		internal _SetGamepadFocusOverlay SetGamepadFocusOverlay;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		internal _SetOverlayNeighbor SetOverlayNeighbor;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		internal _MoveGamepadFocusToNeighbor MoveGamepadFocusToNeighbor;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		internal _SetOverlayTexture SetOverlayTexture;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		internal _ClearOverlayTexture ClearOverlayTexture;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		internal _SetOverlayRaw SetOverlayRaw;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		internal _SetOverlayFromFile SetOverlayFromFile;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		internal _GetOverlayTexture GetOverlayTexture;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		internal _ReleaseNativeOverlayHandle ReleaseNativeOverlayHandle;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		internal _GetOverlayTextureSize GetOverlayTextureSize;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		internal _CreateDashboardOverlay CreateDashboardOverlay;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		internal _IsDashboardVisible IsDashboardVisible;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		internal _IsActiveDashboardOverlay IsActiveDashboardOverlay;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		internal _SetDashboardOverlaySceneProcess SetDashboardOverlaySceneProcess;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		internal _GetDashboardOverlaySceneProcess GetDashboardOverlaySceneProcess;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		internal _ShowDashboard ShowDashboard;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		internal _GetPrimaryDashboardDevice GetPrimaryDashboardDevice;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		internal _ShowKeyboard ShowKeyboard;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		internal _ShowKeyboardForOverlay ShowKeyboardForOverlay;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		internal _GetKeyboardText GetKeyboardText;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		internal _HideKeyboard HideKeyboard;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		internal _SetKeyboardTransformAbsolute SetKeyboardTransformAbsolute;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		internal _SetKeyboardPositionForOverlay SetKeyboardPositionForOverlay;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		internal _SetOverlayIntersectionMask SetOverlayIntersectionMask;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		internal _GetOverlayFlags GetOverlayFlags;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		internal _ShowMessageOverlay ShowMessageOverlay;
	}
	[Token(Token = "0x20000FB")]
	public struct IVRRenderModels
	{
		[Token(Token = "0x20000FC")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EF58", Offset = "0x78EF58")]
		internal delegate EVRRenderModelError _LoadRenderModel_Async(string pchRenderModelName, ref IntPtr ppRenderModel);

		[Token(Token = "0x20000FD")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EF6C", Offset = "0x78EF6C")]
		internal delegate void _FreeRenderModel(IntPtr pRenderModel);

		[Token(Token = "0x20000FE")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EF80", Offset = "0x78EF80")]
		internal delegate EVRRenderModelError _LoadTexture_Async(int textureId, ref IntPtr ppTexture);

		[Token(Token = "0x20000FF")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EF94", Offset = "0x78EF94")]
		internal delegate void _FreeTexture(IntPtr pTexture);

		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EFA8", Offset = "0x78EFA8")]
		internal delegate EVRRenderModelError _LoadTextureD3D11_Async(int textureId, IntPtr pD3D11Device, ref IntPtr ppD3D11Texture2D);

		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EFBC", Offset = "0x78EFBC")]
		internal delegate EVRRenderModelError _LoadIntoTextureD3D11_Async(int textureId, IntPtr pDstTexture);

		[Token(Token = "0x2000102")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EFD0", Offset = "0x78EFD0")]
		internal delegate void _FreeTextureD3D11(IntPtr pD3D11Texture2D);

		[Token(Token = "0x2000103")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EFE4", Offset = "0x78EFE4")]
		internal delegate uint _GetRenderModelName(uint unRenderModelIndex, StringBuilder pchRenderModelName, uint unRenderModelNameLen);

		[Token(Token = "0x2000104")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78EFF8", Offset = "0x78EFF8")]
		internal delegate uint _GetRenderModelCount();

		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F00C", Offset = "0x78F00C")]
		internal delegate uint _GetComponentCount(string pchRenderModelName);

		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F020", Offset = "0x78F020")]
		internal delegate uint _GetComponentName(string pchRenderModelName, uint unComponentIndex, StringBuilder pchComponentName, uint unComponentNameLen);

		[Token(Token = "0x2000107")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F034", Offset = "0x78F034")]
		internal delegate ulong _GetComponentButtonMask(string pchRenderModelName, string pchComponentName);

		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F048", Offset = "0x78F048")]
		internal delegate uint _GetComponentRenderModelName(string pchRenderModelName, string pchComponentName, StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen);

		[Token(Token = "0x2000109")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F05C", Offset = "0x78F05C")]
		internal delegate bool _GetComponentState(string pchRenderModelName, string pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState);

		[Token(Token = "0x200010A")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F070", Offset = "0x78F070")]
		internal delegate bool _RenderModelHasComponent(string pchRenderModelName, string pchComponentName);

		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F084", Offset = "0x78F084")]
		internal delegate uint _GetRenderModelThumbnailURL(string pchRenderModelName, StringBuilder pchThumbnailURL, uint unThumbnailURLLen, ref EVRRenderModelError peError);

		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F098", Offset = "0x78F098")]
		internal delegate uint _GetRenderModelOriginalPath(string pchRenderModelName, StringBuilder pchOriginalPath, uint unOriginalPathLen, ref EVRRenderModelError peError);

		[Token(Token = "0x200010D")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F0AC", Offset = "0x78F0AC")]
		internal delegate IntPtr _GetRenderModelErrorNameFromEnum(EVRRenderModelError error);

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _LoadRenderModel_Async LoadRenderModel_Async;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _FreeRenderModel FreeRenderModel;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _LoadTexture_Async LoadTexture_Async;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal _FreeTexture FreeTexture;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal _LoadTextureD3D11_Async LoadTextureD3D11_Async;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal _LoadIntoTextureD3D11_Async LoadIntoTextureD3D11_Async;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal _FreeTextureD3D11 FreeTextureD3D11;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal _GetRenderModelName GetRenderModelName;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal _GetRenderModelCount GetRenderModelCount;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal _GetComponentCount GetComponentCount;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal _GetComponentName GetComponentName;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal _GetComponentButtonMask GetComponentButtonMask;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal _GetComponentRenderModelName GetComponentRenderModelName;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal _GetComponentState GetComponentState;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal _RenderModelHasComponent RenderModelHasComponent;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal _GetRenderModelThumbnailURL GetRenderModelThumbnailURL;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal _GetRenderModelOriginalPath GetRenderModelOriginalPath;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal _GetRenderModelErrorNameFromEnum GetRenderModelErrorNameFromEnum;
	}
	[Token(Token = "0x200010E")]
	public struct IVRNotifications
	{
		[Token(Token = "0x200010F")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F0C0", Offset = "0x78F0C0")]
		internal delegate EVRNotificationError _CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, string pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId);

		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F0D4", Offset = "0x78F0D4")]
		internal delegate EVRNotificationError _RemoveNotification(uint notificationId);

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _CreateNotification CreateNotification;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _RemoveNotification RemoveNotification;
	}
	[Token(Token = "0x2000111")]
	public struct IVRSettings
	{
		[Token(Token = "0x2000112")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F0E8", Offset = "0x78F0E8")]
		internal delegate IntPtr _GetSettingsErrorNameFromEnum(EVRSettingsError eError);

		[Token(Token = "0x2000113")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F0FC", Offset = "0x78F0FC")]
		internal delegate bool _Sync(bool bForce, ref EVRSettingsError peError);

		[Token(Token = "0x2000114")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F110", Offset = "0x78F110")]
		internal delegate void _SetBool(string pchSection, string pchSettingsKey, bool bValue, ref EVRSettingsError peError);

		[Token(Token = "0x2000115")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F124", Offset = "0x78F124")]
		internal delegate void _SetInt32(string pchSection, string pchSettingsKey, int nValue, ref EVRSettingsError peError);

		[Token(Token = "0x2000116")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F138", Offset = "0x78F138")]
		internal delegate void _SetFloat(string pchSection, string pchSettingsKey, float flValue, ref EVRSettingsError peError);

		[Token(Token = "0x2000117")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F14C", Offset = "0x78F14C")]
		internal delegate void _SetString(string pchSection, string pchSettingsKey, string pchValue, ref EVRSettingsError peError);

		[Token(Token = "0x2000118")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F160", Offset = "0x78F160")]
		internal delegate bool _GetBool(string pchSection, string pchSettingsKey, ref EVRSettingsError peError);

		[Token(Token = "0x2000119")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F174", Offset = "0x78F174")]
		internal delegate int _GetInt32(string pchSection, string pchSettingsKey, ref EVRSettingsError peError);

		[Token(Token = "0x200011A")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F188", Offset = "0x78F188")]
		internal delegate float _GetFloat(string pchSection, string pchSettingsKey, ref EVRSettingsError peError);

		[Token(Token = "0x200011B")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F19C", Offset = "0x78F19C")]
		internal delegate void _GetString(string pchSection, string pchSettingsKey, StringBuilder pchValue, uint unValueLen, ref EVRSettingsError peError);

		[Token(Token = "0x200011C")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F1B0", Offset = "0x78F1B0")]
		internal delegate void _RemoveSection(string pchSection, ref EVRSettingsError peError);

		[Token(Token = "0x200011D")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F1C4", Offset = "0x78F1C4")]
		internal delegate void _RemoveKeyInSection(string pchSection, string pchSettingsKey, ref EVRSettingsError peError);

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _GetSettingsErrorNameFromEnum GetSettingsErrorNameFromEnum;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _Sync Sync;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _SetBool SetBool;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal _SetInt32 SetInt32;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal _SetFloat SetFloat;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal _SetString SetString;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal _GetBool GetBool;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal _GetInt32 GetInt32;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal _GetFloat GetFloat;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal _GetString GetString;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal _RemoveSection RemoveSection;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal _RemoveKeyInSection RemoveKeyInSection;
	}
	[Token(Token = "0x200011E")]
	public struct IVRScreenshots
	{
		[Token(Token = "0x200011F")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F1D8", Offset = "0x78F1D8")]
		internal delegate EVRScreenshotError _RequestScreenshot(ref uint pOutScreenshotHandle, EVRScreenshotType type, string pchPreviewFilename, string pchVRFilename);

		[Token(Token = "0x2000120")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F1EC", Offset = "0x78F1EC")]
		internal delegate EVRScreenshotError _HookScreenshot([In][Out] EVRScreenshotType[] pSupportedTypes, int numTypes);

		[Token(Token = "0x2000121")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F200", Offset = "0x78F200")]
		internal delegate EVRScreenshotType _GetScreenshotPropertyType(uint screenshotHandle, ref EVRScreenshotError pError);

		[Token(Token = "0x2000122")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F214", Offset = "0x78F214")]
		internal delegate uint _GetScreenshotPropertyFilename(uint screenshotHandle, EVRScreenshotPropertyFilenames filenameType, StringBuilder pchFilename, uint cchFilename, ref EVRScreenshotError pError);

		[Token(Token = "0x2000123")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F228", Offset = "0x78F228")]
		internal delegate EVRScreenshotError _UpdateScreenshotProgress(uint screenshotHandle, float flProgress);

		[Token(Token = "0x2000124")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F23C", Offset = "0x78F23C")]
		internal delegate EVRScreenshotError _TakeStereoScreenshot(ref uint pOutScreenshotHandle, string pchPreviewFilename, string pchVRFilename);

		[Token(Token = "0x2000125")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F250", Offset = "0x78F250")]
		internal delegate EVRScreenshotError _SubmitScreenshot(uint screenshotHandle, EVRScreenshotType type, string pchSourcePreviewFilename, string pchSourceVRFilename);

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _RequestScreenshot RequestScreenshot;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _HookScreenshot HookScreenshot;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _GetScreenshotPropertyType GetScreenshotPropertyType;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal _GetScreenshotPropertyFilename GetScreenshotPropertyFilename;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal _UpdateScreenshotProgress UpdateScreenshotProgress;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal _TakeStereoScreenshot TakeStereoScreenshot;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal _SubmitScreenshot SubmitScreenshot;
	}
	[Token(Token = "0x2000126")]
	public struct IVRResources
	{
		[Token(Token = "0x2000127")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F264", Offset = "0x78F264")]
		internal delegate uint _LoadSharedResource(string pchResourceName, string pchBuffer, uint unBufferLen);

		[Token(Token = "0x2000128")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F278", Offset = "0x78F278")]
		internal delegate uint _GetResourceFullPath(string pchResourceName, string pchResourceTypeDirectory, string pchPathBuffer, uint unBufferLen);

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _LoadSharedResource LoadSharedResource;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _GetResourceFullPath GetResourceFullPath;
	}
	[Token(Token = "0x2000129")]
	public struct IVRDriverManager
	{
		[Token(Token = "0x200012A")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F28C", Offset = "0x78F28C")]
		internal delegate uint _GetDriverCount();

		[Token(Token = "0x200012B")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F2A0", Offset = "0x78F2A0")]
		internal delegate uint _GetDriverName(uint nDriver, StringBuilder pchValue, uint unBufferSize);

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _GetDriverCount GetDriverCount;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _GetDriverName GetDriverName;
	}
	[Token(Token = "0x200012C")]
	public class CVRSystem
	{
		[Token(Token = "0x200012D")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F2B4", Offset = "0x78F2B4")]
		internal delegate bool _PollNextEventPacked(ref VREvent_t_Packed pEvent, uint uncbVREvent);

		[StructLayout(2)]
		[Token(Token = "0x200012E")]
		private struct PollNextEventUnion
		{
			[Token(Token = "0x4000126")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IVRSystem._PollNextEvent pPollNextEvent;

			[Token(Token = "0x4000127")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public _PollNextEventPacked pPollNextEventPacked;
		}

		[Token(Token = "0x200012F")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F2C8", Offset = "0x78F2C8")]
		internal delegate bool _GetControllerStatePacked(uint unControllerDeviceIndex, ref VRControllerState_t_Packed pControllerState, uint unControllerStateSize);

		[StructLayout(2)]
		[Token(Token = "0x2000130")]
		private struct GetControllerStateUnion
		{
			[Token(Token = "0x4000128")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IVRSystem._GetControllerState pGetControllerState;

			[Token(Token = "0x4000129")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public _GetControllerStatePacked pGetControllerStatePacked;
		}

		[Token(Token = "0x2000131")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F2DC", Offset = "0x78F2DC")]
		internal delegate bool _GetControllerStateWithPosePacked(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t_Packed pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose);

		[StructLayout(2)]
		[Token(Token = "0x2000132")]
		private struct GetControllerStateWithPoseUnion
		{
			[Token(Token = "0x400012A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IVRSystem._GetControllerStateWithPose pGetControllerStateWithPose;

			[Token(Token = "0x400012B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public _GetControllerStateWithPosePacked pGetControllerStateWithPosePacked;
		}

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRSystem FnTable;

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xED44B8", Offset = "0xED44B8", VA = "0xED44B8")]
		internal CVRSystem(IntPtr pInterface)
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xED4614", Offset = "0xED4614", VA = "0xED4614")]
		public void GetRecommendedRenderTargetSize(ref uint pnWidth, ref uint pnHeight)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xED4660", Offset = "0xED4660", VA = "0xED4660")]
		public HmdMatrix44_t GetProjectionMatrix(EVREye eEye, float fNearZ, float fFarZ)
		{
			return default(HmdMatrix44_t);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xED46D8", Offset = "0xED46D8", VA = "0xED46D8")]
		public void GetProjectionRaw(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xED474C", Offset = "0xED474C", VA = "0xED474C")]
		public bool ComputeDistortion(EVREye eEye, float fU, float fV, ref DistortionCoordinates_t pDistortionCoordinates)
		{
			return default(bool);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xED47A8", Offset = "0xED47A8", VA = "0xED47A8")]
		public HmdMatrix34_t GetEyeToHeadTransform(EVREye eEye)
		{
			return default(HmdMatrix34_t);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xED4808", Offset = "0xED4808", VA = "0xED4808")]
		public bool GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xED4854", Offset = "0xED4854", VA = "0xED4854")]
		public int GetD3D9AdapterIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xED4880", Offset = "0xED4880", VA = "0xED4880")]
		public void GetDXGIOutputInfo(ref int pnAdapterIndex)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xED48B8", Offset = "0xED48B8", VA = "0xED48B8")]
		public void GetOutputDevice(ref ulong pnDevice, ETextureType textureType)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xED4900", Offset = "0xED4900", VA = "0xED4900")]
		public bool IsDisplayOnDesktop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xED492C", Offset = "0xED492C", VA = "0xED492C")]
		public bool SetDisplayVisibility(bool bIsVisibleOnDesktop)
		{
			return default(bool);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xED4960", Offset = "0xED4960", VA = "0xED4960")]
		public void GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, TrackedDevicePose_t[] pTrackedDevicePoseArray)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xED49C0", Offset = "0xED49C0", VA = "0xED49C0")]
		public void ResetSeatedZeroPose()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xED49EC", Offset = "0xED49EC", VA = "0xED49EC")]
		public HmdMatrix34_t GetSeatedZeroPoseToStandingAbsoluteTrackingPose()
		{
			return default(HmdMatrix34_t);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xED4A3C", Offset = "0xED4A3C", VA = "0xED4A3C")]
		public HmdMatrix34_t GetRawZeroPoseToStandingAbsoluteTrackingPose()
		{
			return default(HmdMatrix34_t);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xED4A8C", Offset = "0xED4A8C", VA = "0xED4A8C")]
		public uint GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass eTrackedDeviceClass, uint[] punTrackedDeviceIndexArray, uint unRelativeToTrackedDeviceIndex)
		{
			return default(uint);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xED4AE4", Offset = "0xED4AE4", VA = "0xED4AE4")]
		public EDeviceActivityLevel GetTrackedDeviceActivityLevel(uint unDeviceId)
		{
			return default(EDeviceActivityLevel);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xED4B18", Offset = "0xED4B18", VA = "0xED4B18")]
		public void ApplyTransform(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xED4B64", Offset = "0xED4B64", VA = "0xED4B64")]
		public uint GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole unDeviceType)
		{
			return default(uint);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xED4B98", Offset = "0xED4B98", VA = "0xED4B98")]
		public ETrackedControllerRole GetControllerRoleForTrackedDeviceIndex(uint unDeviceIndex)
		{
			return default(ETrackedControllerRole);
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xED4BCC", Offset = "0xED4BCC", VA = "0xED4BCC")]
		public ETrackedDeviceClass GetTrackedDeviceClass(uint unDeviceIndex)
		{
			return default(ETrackedDeviceClass);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xED4C00", Offset = "0xED4C00", VA = "0xED4C00")]
		public bool IsTrackedDeviceConnected(uint unDeviceIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xED4C34", Offset = "0xED4C34", VA = "0xED4C34")]
		public bool GetBoolTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			return default(bool);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xED4C80", Offset = "0xED4C80", VA = "0xED4C80")]
		public float GetFloatTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			return default(float);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xED4CCC", Offset = "0xED4CCC", VA = "0xED4CCC")]
		public int GetInt32TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			return default(int);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xED4D18", Offset = "0xED4D18", VA = "0xED4D18")]
		public ulong GetUint64TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xED4D64", Offset = "0xED4D64", VA = "0xED4D64")]
		public HmdMatrix34_t GetMatrix34TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			return default(HmdMatrix34_t);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xED4DDC", Offset = "0xED4DDC", VA = "0xED4DDC")]
		public uint GetStringTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError)
		{
			return default(uint);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xED4E40", Offset = "0xED4E40", VA = "0xED4E40")]
		public string GetPropErrorNameFromEnum(ETrackedPropertyError error)
		{
			return null;
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xED4EDC", Offset = "0xED4EDC", VA = "0xED4EDC")]
		public bool PollNextEvent(ref VREvent_t pEvent, uint uncbVREvent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xED52B0", Offset = "0xED52B0", VA = "0xED52B0")]
		public bool PollNextEventWithPose(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose)
		{
			return default(bool);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xED530C", Offset = "0xED530C", VA = "0xED530C")]
		public string GetEventTypeNameFromEnum(EVREventType eType)
		{
			return null;
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xED53A8", Offset = "0xED53A8", VA = "0xED53A8")]
		public HiddenAreaMesh_t GetHiddenAreaMesh(EVREye eEye, EHiddenAreaMeshType type)
		{
			return default(HiddenAreaMesh_t);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xED53EC", Offset = "0xED53EC", VA = "0xED53EC")]
		public bool GetControllerState(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xED5818", Offset = "0xED5818", VA = "0xED5818")]
		public bool GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose)
		{
			return default(bool);
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xED5CA0", Offset = "0xED5CA0", VA = "0xED5CA0")]
		public void TriggerHapticPulse(uint unControllerDeviceIndex, uint unAxisId, char usDurationMicroSec)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xED5CEC", Offset = "0xED5CEC", VA = "0xED5CEC")]
		public string GetButtonIdNameFromEnum(EVRButtonId eButtonId)
		{
			return null;
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xED5D88", Offset = "0xED5D88", VA = "0xED5D88")]
		public string GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType)
		{
			return null;
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xED5E24", Offset = "0xED5E24", VA = "0xED5E24")]
		public bool CaptureInputFocus()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xED5E50", Offset = "0xED5E50", VA = "0xED5E50")]
		public void ReleaseInputFocus()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xED5E7C", Offset = "0xED5E7C", VA = "0xED5E7C")]
		public bool IsInputFocusCapturedByAnotherProcess()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xED5EA8", Offset = "0xED5EA8", VA = "0xED5EA8")]
		public uint DriverDebugRequest(uint unDeviceIndex, string pchRequest, string pchResponseBuffer, uint unResponseBufferSize)
		{
			return default(uint);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xED5F04", Offset = "0xED5F04", VA = "0xED5F04")]
		public EVRFirmwareError PerformFirmwareUpdate(uint unDeviceIndex)
		{
			return default(EVRFirmwareError);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xED5F38", Offset = "0xED5F38", VA = "0xED5F38")]
		public void AcknowledgeQuit_Exiting()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xED5F64", Offset = "0xED5F64", VA = "0xED5F64")]
		public void AcknowledgeQuit_UserPrompt()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class CVRExtendedDisplay
	{
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRExtendedDisplay FnTable;

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xED07C0", Offset = "0xED07C0", VA = "0xED07C0")]
		internal CVRExtendedDisplay(IntPtr pInterface)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xED091C", Offset = "0xED091C", VA = "0xED091C")]
		public void GetWindowBounds(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xED0988", Offset = "0xED0988", VA = "0xED0988")]
		public void GetEyeOutputViewport(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xED09FC", Offset = "0xED09FC", VA = "0xED09FC")]
		public void GetDXGIOutputInfo(ref int pnAdapterIndex, ref int pnAdapterOutputIndex)
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class CVRTrackedCamera
	{
		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRTrackedCamera FnTable;

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xED65EC", Offset = "0xED65EC", VA = "0xED65EC")]
		internal CVRTrackedCamera(IntPtr pInterface)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xED6748", Offset = "0xED6748", VA = "0xED6748")]
		public string GetCameraErrorNameFromEnum(EVRTrackedCameraError eCameraError)
		{
			return null;
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xED67E4", Offset = "0xED67E4", VA = "0xED67E4")]
		public EVRTrackedCameraError HasCamera(uint nDeviceIndex, ref bool pHasCamera)
		{
			return default(EVRTrackedCameraError);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xED682C", Offset = "0xED682C", VA = "0xED682C")]
		public EVRTrackedCameraError GetCameraFrameSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref uint pnWidth, ref uint pnHeight, ref uint pnFrameBufferSize)
		{
			return default(EVRTrackedCameraError);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xED689C", Offset = "0xED689C", VA = "0xED689C")]
		public EVRTrackedCameraError GetCameraIntrinsics(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref HmdVector2_t pFocalLength, ref HmdVector2_t pCenter)
		{
			return default(EVRTrackedCameraError);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xED68F8", Offset = "0xED68F8", VA = "0xED68F8")]
		public EVRTrackedCameraError GetCameraProjection(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, float flZNear, float flZFar, ref HmdMatrix44_t pProjection)
		{
			return default(EVRTrackedCameraError);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xED695C", Offset = "0xED695C", VA = "0xED695C")]
		public EVRTrackedCameraError AcquireVideoStreamingService(uint nDeviceIndex, ref ulong pHandle)
		{
			return default(EVRTrackedCameraError);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xED69A4", Offset = "0xED69A4", VA = "0xED69A4")]
		public EVRTrackedCameraError ReleaseVideoStreamingService(ulong hTrackedCamera)
		{
			return default(EVRTrackedCameraError);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xED69D8", Offset = "0xED69D8", VA = "0xED69D8")]
		public EVRTrackedCameraError GetVideoStreamFrameBuffer(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pFrameBuffer, uint nFrameBufferSize, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize)
		{
			return default(EVRTrackedCameraError);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xED6A4C", Offset = "0xED6A4C", VA = "0xED6A4C")]
		public EVRTrackedCameraError GetVideoStreamTextureSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref VRTextureBounds_t pTextureBounds, ref uint pnWidth, ref uint pnHeight)
		{
			return default(EVRTrackedCameraError);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xED6AB8", Offset = "0xED6AB8", VA = "0xED6AB8")]
		public EVRTrackedCameraError GetVideoStreamTextureD3D11(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize)
		{
			return default(EVRTrackedCameraError);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xED6B2C", Offset = "0xED6B2C", VA = "0xED6B2C")]
		public EVRTrackedCameraError GetVideoStreamTextureGL(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, ref uint pglTextureId, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize)
		{
			return default(EVRTrackedCameraError);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xED6B94", Offset = "0xED6B94", VA = "0xED6B94")]
		public EVRTrackedCameraError ReleaseVideoStreamTextureGL(ulong hTrackedCamera, uint glTextureId)
		{
			return default(EVRTrackedCameraError);
		}
	}
	[Token(Token = "0x2000135")]
	public class CVRApplications
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRApplications FnTable;

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xEBF458", Offset = "0xEBF458", VA = "0xEBF458")]
		internal CVRApplications(IntPtr pInterface)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xEBF5B4", Offset = "0xEBF5B4", VA = "0xEBF5B4")]
		public EVRApplicationError AddApplicationManifest(string pchApplicationManifestFullPath, bool bTemporary)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xEBF9CC", Offset = "0xEBF9CC", VA = "0xEBF9CC")]
		public EVRApplicationError RemoveApplicationManifest(string pchApplicationManifestFullPath)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xEBFD98", Offset = "0xEBFD98", VA = "0xEBFD98")]
		public bool IsApplicationInstalled(string pchAppKey)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xEC0164", Offset = "0xEC0164", VA = "0xEC0164")]
		public uint GetApplicationCount()
		{
			return default(uint);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xEC0388", Offset = "0xEC0388", VA = "0xEC0388")]
		public EVRApplicationError GetApplicationKeyByIndex(uint unApplicationIndex, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xEC0620", Offset = "0xEC0620", VA = "0xEC0620")]
		public EVRApplicationError GetApplicationKeyByProcessId(uint unProcessId, string pchAppKeyBuffer, uint unAppKeyBufferLen)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xEC08B8", Offset = "0xEC08B8", VA = "0xEC08B8")]
		public EVRApplicationError LaunchApplication(string pchAppKey)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xEC0C84", Offset = "0xEC0C84", VA = "0xEC0C84")]
		public EVRApplicationError LaunchTemplateApplication(string pchTemplateAppKey, string pchNewAppKey, AppOverrideKeys_t[] pKeys)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xEC10FC", Offset = "0xEC10FC", VA = "0xEC10FC")]
		public EVRApplicationError LaunchApplicationFromMimeType(string pchMimeType, string pchArgs)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xEC1508", Offset = "0xEC1508", VA = "0xEC1508")]
		public EVRApplicationError LaunchDashboardOverlay(string pchAppKey)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xEC18D4", Offset = "0xEC18D4", VA = "0xEC18D4")]
		public bool CancelApplicationLaunch(string pchAppKey)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xEC1CA0", Offset = "0xEC1CA0", VA = "0xEC1CA0")]
		public EVRApplicationError IdentifyApplication(uint unProcessId, string pchAppKey)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xEC1F18", Offset = "0xEC1F18", VA = "0xEC1F18")]
		public uint GetApplicationProcessId(string pchAppKey)
		{
			return default(uint);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xEC22E4", Offset = "0xEC22E4", VA = "0xEC22E4")]
		public string GetApplicationsErrorNameFromEnum(EVRApplicationError error)
		{
			return null;
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xEC2590", Offset = "0xEC2590", VA = "0xEC2590")]
		public uint GetApplicationPropertyString(string pchAppKey, EVRApplicationProperty eProperty, StringBuilder pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError)
		{
			return default(uint);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xEC2A38", Offset = "0xEC2A38", VA = "0xEC2A38")]
		public bool GetApplicationPropertyBool(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xEC2E70", Offset = "0xEC2E70", VA = "0xEC2E70")]
		public ulong GetApplicationPropertyUint64(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError)
		{
			return default(ulong);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xEC32A8", Offset = "0xEC32A8", VA = "0xEC32A8")]
		public EVRApplicationError SetApplicationAutoLaunch(string pchAppKey, bool bAutoLaunch)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xEC36C0", Offset = "0xEC36C0", VA = "0xEC36C0")]
		public bool GetApplicationAutoLaunch(string pchAppKey)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xEC3A8C", Offset = "0xEC3A8C", VA = "0xEC3A8C")]
		public EVRApplicationError SetDefaultApplicationForMimeType(string pchAppKey, string pchMimeType)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xEC3E98", Offset = "0xEC3E98", VA = "0xEC3E98")]
		public bool GetDefaultApplicationForMimeType(string pchMimeType, string pchAppKeyBuffer, uint unAppKeyBufferLen)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xEC42D0", Offset = "0xEC42D0", VA = "0xEC42D0")]
		public bool GetApplicationSupportedMimeTypes(string pchAppKey, string pchMimeTypesBuffer, uint unMimeTypesBuffer)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xEC4708", Offset = "0xEC4708", VA = "0xEC4708")]
		public uint GetApplicationsThatSupportMimeType(string pchMimeType, string pchAppKeysThatSupportBuffer, uint unAppKeysThatSupportBuffer)
		{
			return default(uint);
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xEC4B40", Offset = "0xEC4B40", VA = "0xEC4B40")]
		public uint GetApplicationLaunchArguments(uint unHandle, string pchArgs, uint unArgs)
		{
			return default(uint);
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xEC4DD8", Offset = "0xEC4DD8", VA = "0xEC4DD8")]
		public EVRApplicationError GetStartingApplication(string pchAppKeyBuffer, uint unAppKeyBufferLen)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xEC51E4", Offset = "0xEC51E4", VA = "0xEC51E4")]
		public EVRApplicationTransitionState GetTransitionState()
		{
			return default(EVRApplicationTransitionState);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xEC5408", Offset = "0xEC5408", VA = "0xEC5408")]
		public EVRApplicationError PerformApplicationPrelaunchCheck(string pchAppKey)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xEC57D4", Offset = "0xEC57D4", VA = "0xEC57D4")]
		public string GetApplicationsTransitionStateNameFromEnum(EVRApplicationTransitionState state)
		{
			return null;
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xEC5A80", Offset = "0xEC5A80", VA = "0xEC5A80")]
		public bool IsQuitUserPromptRequested()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xEC5CA4", Offset = "0xEC5CA4", VA = "0xEC5CA4")]
		public EVRApplicationError LaunchInternalProcess(string pchBinaryPath, string pchArguments, string pchWorkingDirectory)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xEC60DC", Offset = "0xEC60DC", VA = "0xEC60DC")]
		public uint GetCurrentSceneProcessId()
		{
			return default(uint);
		}
	}
	[Token(Token = "0x2000136")]
	public class CVRChaperone
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRChaperone FnTable;

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xEC6300", Offset = "0xEC6300", VA = "0xEC6300")]
		internal CVRChaperone(IntPtr pInterface)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xEC645C", Offset = "0xEC645C", VA = "0xEC645C")]
		public ChaperoneCalibrationState GetCalibrationState()
		{
			return default(ChaperoneCalibrationState);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xEC6680", Offset = "0xEC6680", VA = "0xEC6680")]
		public bool GetPlayAreaSize(ref float pSizeX, ref float pSizeZ)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xEC6900", Offset = "0xEC6900", VA = "0xEC6900")]
		public bool GetPlayAreaRect(ref HmdQuad_t rect)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xEC6B44", Offset = "0xEC6B44", VA = "0xEC6B44")]
		public void ReloadInfo()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xEC6D68", Offset = "0xEC6D68", VA = "0xEC6D68")]
		public void SetSceneColor(HmdColor_t color)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xEC7034", Offset = "0xEC7034", VA = "0xEC7034")]
		public void GetBoundsColor(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xEC7300", Offset = "0xEC7300", VA = "0xEC7300")]
		public bool AreBoundsVisible()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xEC7524", Offset = "0xEC7524", VA = "0xEC7524")]
		public void ForceBoundsVisible(bool bForce)
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class CVRChaperoneSetup
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRChaperoneSetup FnTable;

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xEC7770", Offset = "0xEC7770", VA = "0xEC7770")]
		internal CVRChaperoneSetup(IntPtr pInterface)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xEC78CC", Offset = "0xEC78CC", VA = "0xEC78CC")]
		public bool CommitWorkingCopy(EChaperoneConfigFile configFile)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xEC7B10", Offset = "0xEC7B10", VA = "0xEC7B10")]
		public void RevertWorkingCopy()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xEC7D34", Offset = "0xEC7D34", VA = "0xEC7D34")]
		public bool GetWorkingPlayAreaSize(ref float pSizeX, ref float pSizeZ)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xEC7FB4", Offset = "0xEC7FB4", VA = "0xEC7FB4")]
		public bool GetWorkingPlayAreaRect(ref HmdQuad_t rect)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xEC81F8", Offset = "0xEC81F8", VA = "0xEC81F8")]
		public bool GetWorkingCollisionBoundsInfo(out HmdQuad_t[] pQuadsBuffer)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xEC86A8", Offset = "0xEC86A8", VA = "0xEC86A8")]
		public bool GetLiveCollisionBoundsInfo(out HmdQuad_t[] pQuadsBuffer)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xEC8B58", Offset = "0xEC8B58", VA = "0xEC8B58")]
		public bool GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xEC8D9C", Offset = "0xEC8D9C", VA = "0xEC8D9C")]
		public bool GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xEC8FE0", Offset = "0xEC8FE0", VA = "0xEC8FE0")]
		public void SetWorkingPlayAreaSize(float sizeX, float sizeZ)
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xEC9258", Offset = "0xEC9258", VA = "0xEC9258")]
		public void SetWorkingCollisionBoundsInfo(HmdQuad_t[] pQuadsBuffer)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xEC9660", Offset = "0xEC9660", VA = "0xEC9660")]
		public void SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xEC98A4", Offset = "0xEC98A4", VA = "0xEC98A4")]
		public void SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xEC9AE8", Offset = "0xEC9AE8", VA = "0xEC9AE8")]
		public void ReloadFromDisk(EChaperoneConfigFile configFile)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xEC9D2C", Offset = "0xEC9D2C", VA = "0xEC9D2C")]
		public bool GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xEC9F70", Offset = "0xEC9F70", VA = "0xEC9F70")]
		public void SetWorkingCollisionBoundsTagsInfo(byte[] pTagsBuffer)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xECA378", Offset = "0xECA378", VA = "0xECA378")]
		public bool GetLiveCollisionBoundsTagsInfo(out byte[] pTagsBuffer)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xECA828", Offset = "0xECA828", VA = "0xECA828")]
		public bool SetWorkingPhysicalBoundsInfo(HmdQuad_t[] pQuadsBuffer)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xECAC30", Offset = "0xECAC30", VA = "0xECAC30")]
		public bool GetLivePhysicalBoundsInfo(out HmdQuad_t[] pQuadsBuffer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xECB0E0", Offset = "0xECB0E0", VA = "0xECB0E0")]
		public bool ExportLiveToBuffer(StringBuilder pBuffer, ref uint pnBufferLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xECB4F0", Offset = "0xECB4F0", VA = "0xECB4F0")]
		public bool ImportFromBufferToWorking(string pBuffer, uint nImportFlags)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000138")]
	public class CVRCompositor
	{
		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRCompositor FnTable;

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xECB8FC", Offset = "0xECB8FC", VA = "0xECB8FC")]
		internal CVRCompositor(IntPtr pInterface)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xECBA58", Offset = "0xECBA58", VA = "0xECBA58")]
		public void SetTrackingSpace(ETrackingUniverseOrigin eOrigin)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xECBA8C", Offset = "0xECBA8C", VA = "0xECBA8C")]
		public ETrackingUniverseOrigin GetTrackingSpace()
		{
			return default(ETrackingUniverseOrigin);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xECBCB0", Offset = "0xECBCB0", VA = "0xECBCB0")]
		public EVRCompositorError WaitGetPoses(TrackedDevicePose_t[] pRenderPoseArray, TrackedDevicePose_t[] pGamePoseArray)
		{
			return default(EVRCompositorError);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xECBD0C", Offset = "0xECBD0C", VA = "0xECBD0C")]
		public EVRCompositorError GetLastPoses(TrackedDevicePose_t[] pRenderPoseArray, TrackedDevicePose_t[] pGamePoseArray)
		{
			return default(EVRCompositorError);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xECC188", Offset = "0xECC188", VA = "0xECC188")]
		public EVRCompositorError GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose)
		{
			return default(EVRCompositorError);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xECC420", Offset = "0xECC420", VA = "0xECC420")]
		public EVRCompositorError Submit(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags)
		{
			return default(EVRCompositorError);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xECC47C", Offset = "0xECC47C", VA = "0xECC47C")]
		public void ClearLastSubmittedFrame()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xECC6A0", Offset = "0xECC6A0", VA = "0xECC6A0")]
		public void PostPresentHandoff()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xECC6CC", Offset = "0xECC6CC", VA = "0xECC6CC")]
		public bool GetFrameTiming(ref Compositor_FrameTiming pTiming, uint unFramesAgo)
		{
			return default(bool);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xECC944", Offset = "0xECC944", VA = "0xECC944")]
		public uint GetFrameTimings(ref Compositor_FrameTiming pTiming, uint nFrames)
		{
			return default(uint);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xECCBBC", Offset = "0xECCBBC", VA = "0xECCBBC")]
		public float GetFrameTimeRemaining()
		{
			return default(float);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xECCDE0", Offset = "0xECCDE0", VA = "0xECCDE0")]
		public void GetCumulativeStats(ref Compositor_CumulativeStats pStats, uint nStatsSizeInBytes)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xECD058", Offset = "0xECD058", VA = "0xECD058")]
		public void FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xECD380", Offset = "0xECD380", VA = "0xECD380")]
		public HmdColor_t GetCurrentFadeColor(bool bBackground)
		{
			return default(HmdColor_t);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xECD5C8", Offset = "0xECD5C8", VA = "0xECD5C8")]
		public void FadeGrid(float fSeconds, bool bFadeIn)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xECD848", Offset = "0xECD848", VA = "0xECD848")]
		public float GetCurrentGridAlpha()
		{
			return default(float);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xECDA6C", Offset = "0xECDA6C", VA = "0xECDA6C")]
		public EVRCompositorError SetSkyboxOverride(Texture_t[] pTextures)
		{
			return default(EVRCompositorError);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xECDAAC", Offset = "0xECDAAC", VA = "0xECDAAC")]
		public void ClearSkyboxOverride()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xECDCD0", Offset = "0xECDCD0", VA = "0xECDCD0")]
		public void CompositorBringToFront()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xECDEF4", Offset = "0xECDEF4", VA = "0xECDEF4")]
		public void CompositorGoToBack()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xECE118", Offset = "0xECE118", VA = "0xECE118")]
		public void CompositorQuit()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xECE33C", Offset = "0xECE33C", VA = "0xECE33C")]
		public bool IsFullscreen()
		{
			return default(bool);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xECE560", Offset = "0xECE560", VA = "0xECE560")]
		public uint GetCurrentSceneFocusProcess()
		{
			return default(uint);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xECE784", Offset = "0xECE784", VA = "0xECE784")]
		public uint GetLastFrameRenderer()
		{
			return default(uint);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xECE9A8", Offset = "0xECE9A8", VA = "0xECE9A8")]
		public bool CanRenderScene()
		{
			return default(bool);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xECEBCC", Offset = "0xECEBCC", VA = "0xECEBCC")]
		public void ShowMirrorWindow()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xECEBF8", Offset = "0xECEBF8", VA = "0xECEBF8")]
		public void HideMirrorWindow()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xECEE1C", Offset = "0xECEE1C", VA = "0xECEE1C")]
		public bool IsMirrorWindowVisible()
		{
			return default(bool);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xECF040", Offset = "0xECF040", VA = "0xECF040")]
		public void CompositorDumpImages()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xECF264", Offset = "0xECF264", VA = "0xECF264")]
		public bool ShouldAppRenderWithLowResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xECF290", Offset = "0xECF290", VA = "0xECF290")]
		public void ForceInterleavedReprojectionOn(bool bOverride)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xECF4DC", Offset = "0xECF4DC", VA = "0xECF4DC")]
		public void ForceReconnectProcess()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xECF700", Offset = "0xECF700", VA = "0xECF700")]
		public void SuspendRendering(bool bSuspend)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xECF734", Offset = "0xECF734", VA = "0xECF734")]
		public EVRCompositorError GetMirrorTextureD3D11(EVREye eEye, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView)
		{
			return default(EVRCompositorError);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xECF9CC", Offset = "0xECF9CC", VA = "0xECF9CC")]
		public void ReleaseMirrorTextureD3D11(IntPtr pD3D11ShaderResourceView)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xECFA00", Offset = "0xECFA00", VA = "0xECFA00")]
		public EVRCompositorError GetMirrorTextureGL(EVREye eEye, ref uint pglTextureId, IntPtr pglSharedTextureHandle)
		{
			return default(EVRCompositorError);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xECFC9C", Offset = "0xECFC9C", VA = "0xECFC9C")]
		public bool ReleaseSharedGLTexture(uint glTextureId, IntPtr glSharedTextureHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xECFCE0", Offset = "0xECFCE0", VA = "0xECFCE0")]
		public void LockGLSharedTextureForAccess(IntPtr glSharedTextureHandle)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xECFF24", Offset = "0xECFF24", VA = "0xECFF24")]
		public void UnlockGLSharedTextureForAccess(IntPtr glSharedTextureHandle)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xECFF58", Offset = "0xECFF58", VA = "0xECFF58")]
		public uint GetVulkanInstanceExtensionsRequired(StringBuilder pchValue, uint unBufferSize)
		{
			return default(uint);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xED0364", Offset = "0xED0364", VA = "0xED0364")]
		public uint GetVulkanDeviceExtensionsRequired(IntPtr pPhysicalDevice, StringBuilder pchValue, uint unBufferSize)
		{
			return default(uint);
		}
	}
	[Token(Token = "0x2000139")]
	public class CVROverlay
	{
		[Token(Token = "0x200013A")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F2F0", Offset = "0x78F2F0")]
		internal delegate bool _PollNextOverlayEventPacked(ulong ulOverlayHandle, ref VREvent_t_Packed pEvent, uint uncbVREvent);

		[StructLayout(2)]
		[Token(Token = "0x200013B")]
		private struct PollNextOverlayEventUnion
		{
			[Token(Token = "0x4000133")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IVROverlay._PollNextOverlayEvent pPollNextOverlayEvent;

			[Token(Token = "0x4000134")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public _PollNextOverlayEventPacked pPollNextOverlayEventPacked;
		}

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVROverlay FnTable;

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xED0C48", Offset = "0xED0C48", VA = "0xED0C48")]
		internal CVROverlay(IntPtr pInterface)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xED0DA4", Offset = "0xED0DA4", VA = "0xED0DA4")]
		public EVROverlayError FindOverlay(string pchOverlayKey, ref ulong pOverlayHandle)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xED0DEC", Offset = "0xED0DEC", VA = "0xED0DEC")]
		public EVROverlayError CreateOverlay(string pchOverlayKey, string pchOverlayName, ref ulong pOverlayHandle)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xED0E3C", Offset = "0xED0E3C", VA = "0xED0E3C")]
		public EVROverlayError DestroyOverlay(ulong ulOverlayHandle)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xED0E70", Offset = "0xED0E70", VA = "0xED0E70")]
		public EVROverlayError SetHighQualityOverlay(ulong ulOverlayHandle)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xED0EA4", Offset = "0xED0EA4", VA = "0xED0EA4")]
		public ulong GetHighQualityOverlay()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xED0ED0", Offset = "0xED0ED0", VA = "0xED0ED0")]
		public uint GetOverlayKey(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError)
		{
			return default(uint);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xED0F2C", Offset = "0xED0F2C", VA = "0xED0F2C")]
		public uint GetOverlayName(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError)
		{
			return default(uint);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xED0F88", Offset = "0xED0F88", VA = "0xED0F88")]
		public EVROverlayError SetOverlayName(ulong ulOverlayHandle, string pchName)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xED0FCC", Offset = "0xED0FCC", VA = "0xED0FCC")]
		public EVROverlayError GetOverlayImageData(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xED1038", Offset = "0xED1038", VA = "0xED1038")]
		public string GetOverlayErrorNameFromEnum(EVROverlayError error)
		{
			return null;
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xED10D4", Offset = "0xED10D4", VA = "0xED10D4")]
		public EVROverlayError SetOverlayRenderingPid(ulong ulOverlayHandle, uint unPID)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xED1118", Offset = "0xED1118", VA = "0xED1118")]
		public uint GetOverlayRenderingPid(ulong ulOverlayHandle)
		{
			return default(uint);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xED114C", Offset = "0xED114C", VA = "0xED114C")]
		public EVROverlayError SetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, bool bEnabled)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xED1198", Offset = "0xED1198", VA = "0xED1198")]
		public EVROverlayError GetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, ref bool pbEnabled)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xED11E8", Offset = "0xED11E8", VA = "0xED11E8")]
		public EVROverlayError SetOverlayColor(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xED1244", Offset = "0xED1244", VA = "0xED1244")]
		public EVROverlayError GetOverlayColor(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xED12AC", Offset = "0xED12AC", VA = "0xED12AC")]
		public EVROverlayError SetOverlayAlpha(ulong ulOverlayHandle, float fAlpha)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xED12F0", Offset = "0xED12F0", VA = "0xED12F0")]
		public EVROverlayError GetOverlayAlpha(ulong ulOverlayHandle, ref float pfAlpha)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xED1338", Offset = "0xED1338", VA = "0xED1338")]
		public EVROverlayError SetOverlayTexelAspect(ulong ulOverlayHandle, float fTexelAspect)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xED137C", Offset = "0xED137C", VA = "0xED137C")]
		public EVROverlayError GetOverlayTexelAspect(ulong ulOverlayHandle, ref float pfTexelAspect)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xED13C4", Offset = "0xED13C4", VA = "0xED13C4")]
		public EVROverlayError SetOverlaySortOrder(ulong ulOverlayHandle, uint unSortOrder)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xED1408", Offset = "0xED1408", VA = "0xED1408")]
		public EVROverlayError GetOverlaySortOrder(ulong ulOverlayHandle, ref uint punSortOrder)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xED1450", Offset = "0xED1450", VA = "0xED1450")]
		public EVROverlayError SetOverlayWidthInMeters(ulong ulOverlayHandle, float fWidthInMeters)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xED1494", Offset = "0xED1494", VA = "0xED1494")]
		public EVROverlayError GetOverlayWidthInMeters(ulong ulOverlayHandle, ref float pfWidthInMeters)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xED14DC", Offset = "0xED14DC", VA = "0xED14DC")]
		public EVROverlayError SetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, float fMinDistanceInMeters, float fMaxDistanceInMeters)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xED1528", Offset = "0xED1528", VA = "0xED1528")]
		public EVROverlayError GetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, ref float pfMinDistanceInMeters, ref float pfMaxDistanceInMeters)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xED157C", Offset = "0xED157C", VA = "0xED157C")]
		public EVROverlayError SetOverlayTextureColorSpace(ulong ulOverlayHandle, EColorSpace eTextureColorSpace)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xED15C0", Offset = "0xED15C0", VA = "0xED15C0")]
		public EVROverlayError GetOverlayTextureColorSpace(ulong ulOverlayHandle, ref EColorSpace peTextureColorSpace)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xED1604", Offset = "0xED1604", VA = "0xED1604")]
		public EVROverlayError SetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xED1648", Offset = "0xED1648", VA = "0xED1648")]
		public EVROverlayError GetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xED168C", Offset = "0xED168C", VA = "0xED168C")]
		public uint GetOverlayRenderModel(ulong ulOverlayHandle, string pchValue, uint unBufferSize, ref HmdColor_t pColor, ref EVROverlayError pError)
		{
			return default(uint);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xED16F0", Offset = "0xED16F0", VA = "0xED16F0")]
		public EVROverlayError SetOverlayRenderModel(ulong ulOverlayHandle, string pchRenderModel, ref HmdColor_t pColor)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xED173C", Offset = "0xED173C", VA = "0xED173C")]
		public EVROverlayError GetOverlayTransformType(ulong ulOverlayHandle, ref VROverlayTransformType peTransformType)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xED1780", Offset = "0xED1780", VA = "0xED1780")]
		public EVROverlayError SetOverlayTransformAbsolute(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xED17CC", Offset = "0xED17CC", VA = "0xED17CC")]
		public EVROverlayError GetOverlayTransformAbsolute(ulong ulOverlayHandle, ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xED1818", Offset = "0xED1818", VA = "0xED1818")]
		public EVROverlayError SetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, uint unTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xED1864", Offset = "0xED1864", VA = "0xED1864")]
		public EVROverlayError GetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xED18B4", Offset = "0xED18B4", VA = "0xED18B4")]
		public EVROverlayError SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, uint unDeviceIndex, string pchComponentName)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xED1900", Offset = "0xED1900", VA = "0xED1900")]
		public EVROverlayError GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, ref uint punDeviceIndex, string pchComponentName, uint unComponentNameSize)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xED1960", Offset = "0xED1960", VA = "0xED1960")]
		public EVROverlayError GetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ref ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xED19B0", Offset = "0xED19B0", VA = "0xED19B0")]
		public EVROverlayError SetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xED19FC", Offset = "0xED19FC", VA = "0xED19FC")]
		public EVROverlayError ShowOverlay(ulong ulOverlayHandle)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xED1A30", Offset = "0xED1A30", VA = "0xED1A30")]
		public EVROverlayError HideOverlay(ulong ulOverlayHandle)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xED1A64", Offset = "0xED1A64", VA = "0xED1A64")]
		public bool IsOverlayVisible(ulong ulOverlayHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xED1A98", Offset = "0xED1A98", VA = "0xED1A98")]
		public EVROverlayError GetTransformForOverlayCoordinates(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, HmdVector2_t coordinatesInOverlay, ref HmdMatrix34_t pmatTransform)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xED1AFC", Offset = "0xED1AFC", VA = "0xED1AFC")]
		public bool PollNextOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pEvent, uint uncbVREvent)
		{
			return default(bool);
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xED1EFC", Offset = "0xED1EFC", VA = "0xED1EFC")]
		public EVROverlayError GetOverlayInputMethod(ulong ulOverlayHandle, ref VROverlayInputMethod peInputMethod)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xED1F40", Offset = "0xED1F40", VA = "0xED1F40")]
		public EVROverlayError SetOverlayInputMethod(ulong ulOverlayHandle, VROverlayInputMethod eInputMethod)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xED1F84", Offset = "0xED1F84", VA = "0xED1F84")]
		public EVROverlayError GetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xED1FC8", Offset = "0xED1FC8", VA = "0xED1FC8")]
		public EVROverlayError SetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xED200C", Offset = "0xED200C", VA = "0xED200C")]
		public bool ComputeOverlayIntersection(ulong ulOverlayHandle, ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults)
		{
			return default(bool);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xED2058", Offset = "0xED2058", VA = "0xED2058")]
		public bool HandleControllerOverlayInteractionAsMouse(ulong ulOverlayHandle, uint unControllerDeviceIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xED209C", Offset = "0xED209C", VA = "0xED209C")]
		public bool IsHoverTargetOverlay(ulong ulOverlayHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xED20D0", Offset = "0xED20D0", VA = "0xED20D0")]
		public ulong GetGamepadFocusOverlay()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xED20FC", Offset = "0xED20FC", VA = "0xED20FC")]
		public EVROverlayError SetGamepadFocusOverlay(ulong ulNewFocusOverlay)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xED2130", Offset = "0xED2130", VA = "0xED2130")]
		public EVROverlayError SetOverlayNeighbor(EOverlayDirection eDirection, ulong ulFrom, ulong ulTo)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xED217C", Offset = "0xED217C", VA = "0xED217C")]
		public EVROverlayError MoveGamepadFocusToNeighbor(EOverlayDirection eDirection, ulong ulFrom)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xED21C0", Offset = "0xED21C0", VA = "0xED21C0")]
		public EVROverlayError SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xED2204", Offset = "0xED2204", VA = "0xED2204")]
		public EVROverlayError ClearOverlayTexture(ulong ulOverlayHandle)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xED2238", Offset = "0xED2238", VA = "0xED2238")]
		public EVROverlayError SetOverlayRaw(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unDepth)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xED229C", Offset = "0xED229C", VA = "0xED229C")]
		public EVROverlayError SetOverlayFromFile(ulong ulOverlayHandle, string pchFilePath)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xED22E0", Offset = "0xED22E0", VA = "0xED22E0")]
		public EVROverlayError GetOverlayTexture(ulong ulOverlayHandle, ref IntPtr pNativeTextureHandle, IntPtr pNativeTextureRef, ref uint pWidth, ref uint pHeight, ref uint pNativeFormat, ref ETextureType pAPIType, ref EColorSpace pColorSpace, ref VRTextureBounds_t pTextureBounds)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xED2378", Offset = "0xED2378", VA = "0xED2378")]
		public EVROverlayError ReleaseNativeOverlayHandle(ulong ulOverlayHandle, IntPtr pNativeTextureHandle)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xED23BC", Offset = "0xED23BC", VA = "0xED23BC")]
		public EVROverlayError GetOverlayTextureSize(ulong ulOverlayHandle, ref uint pWidth, ref uint pHeight)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xED2410", Offset = "0xED2410", VA = "0xED2410")]
		public EVROverlayError CreateDashboardOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xED2474", Offset = "0xED2474", VA = "0xED2474")]
		public bool IsDashboardVisible()
		{
			return default(bool);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xED24A0", Offset = "0xED24A0", VA = "0xED24A0")]
		public bool IsActiveDashboardOverlay(ulong ulOverlayHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xED24D4", Offset = "0xED24D4", VA = "0xED24D4")]
		public EVROverlayError SetDashboardOverlaySceneProcess(ulong ulOverlayHandle, uint unProcessId)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xED2518", Offset = "0xED2518", VA = "0xED2518")]
		public EVROverlayError GetDashboardOverlaySceneProcess(ulong ulOverlayHandle, ref uint punProcessId)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xED2560", Offset = "0xED2560", VA = "0xED2560")]
		public void ShowDashboard(string pchOverlayToShow)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xED2594", Offset = "0xED2594", VA = "0xED2594")]
		public uint GetPrimaryDashboardDevice()
		{
			return default(uint);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xED25C0", Offset = "0xED25C0", VA = "0xED25C0")]
		public EVROverlayError ShowKeyboard(int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xED263C", Offset = "0xED263C", VA = "0xED263C")]
		public EVROverlayError ShowKeyboardForOverlay(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xED26C4", Offset = "0xED26C4", VA = "0xED26C4")]
		public uint GetKeyboardText(StringBuilder pchText, uint cchText)
		{
			return default(uint);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xED2708", Offset = "0xED2708", VA = "0xED2708")]
		public void HideKeyboard()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xED2734", Offset = "0xED2734", VA = "0xED2734")]
		public void SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xED2778", Offset = "0xED2778", VA = "0xED2778")]
		public void SetKeyboardPositionForOverlay(ulong ulOverlayHandle, HmdRect2_t avoidRect)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xED27DC", Offset = "0xED27DC", VA = "0xED27DC")]
		public EVROverlayError SetOverlayIntersectionMask(ulong ulOverlayHandle, ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives, uint unNumMaskPrimitives, uint unPrimitiveSize)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xED2838", Offset = "0xED2838", VA = "0xED2838")]
		public EVROverlayError GetOverlayFlags(ulong ulOverlayHandle, ref uint pFlags)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xED2880", Offset = "0xED2880", VA = "0xED2880")]
		public VRMessageOverlayResponse ShowMessageOverlay(string pchText, string pchCaption, string pchButton0Text, string pchButton1Text, string pchButton2Text, string pchButton3Text)
		{
			return default(VRMessageOverlayResponse);
		}
	}
	[Token(Token = "0x200013C")]
	public class CVRRenderModels
	{
		[Token(Token = "0x200013D")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x78F304", Offset = "0x78F304")]
		internal delegate bool _GetComponentStatePacked(string pchRenderModelName, string pchComponentName, ref VRControllerState_t_Packed pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState);

		[StructLayout(2)]
		[Token(Token = "0x200013E")]
		private struct GetComponentStateUnion
		{
			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IVRRenderModels._GetComponentState pGetComponentState;

			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public _GetComponentStatePacked pGetComponentStatePacked;
		}

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRRenderModels FnTable;

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xED2B10", Offset = "0xED2B10", VA = "0xED2B10")]
		internal CVRRenderModels(IntPtr pInterface)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xED2C6C", Offset = "0xED2C6C", VA = "0xED2C6C")]
		public EVRRenderModelError LoadRenderModel_Async(string pchRenderModelName, ref IntPtr ppRenderModel)
		{
			return default(EVRRenderModelError);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xED2CB0", Offset = "0xED2CB0", VA = "0xED2CB0")]
		public void FreeRenderModel(IntPtr pRenderModel)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xED2CE4", Offset = "0xED2CE4", VA = "0xED2CE4")]
		public EVRRenderModelError LoadTexture_Async(int textureId, ref IntPtr ppTexture)
		{
			return default(EVRRenderModelError);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xED2D28", Offset = "0xED2D28", VA = "0xED2D28")]
		public void FreeTexture(IntPtr pTexture)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xED2D5C", Offset = "0xED2D5C", VA = "0xED2D5C")]
		public EVRRenderModelError LoadTextureD3D11_Async(int textureId, IntPtr pD3D11Device, ref IntPtr ppD3D11Texture2D)
		{
			return default(EVRRenderModelError);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xED2DA8", Offset = "0xED2DA8", VA = "0xED2DA8")]
		public EVRRenderModelError LoadIntoTextureD3D11_Async(int textureId, IntPtr pDstTexture)
		{
			return default(EVRRenderModelError);
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xED2DEC", Offset = "0xED2DEC", VA = "0xED2DEC")]
		public void FreeTextureD3D11(IntPtr pD3D11Texture2D)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xED2E20", Offset = "0xED2E20", VA = "0xED2E20")]
		public uint GetRenderModelName(uint unRenderModelIndex, StringBuilder pchRenderModelName, uint unRenderModelNameLen)
		{
			return default(uint);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xED2E6C", Offset = "0xED2E6C", VA = "0xED2E6C")]
		public uint GetRenderModelCount()
		{
			return default(uint);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xED2E98", Offset = "0xED2E98", VA = "0xED2E98")]
		public uint GetComponentCount(string pchRenderModelName)
		{
			return default(uint);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xED2ECC", Offset = "0xED2ECC", VA = "0xED2ECC")]
		public uint GetComponentName(string pchRenderModelName, uint unComponentIndex, StringBuilder pchComponentName, uint unComponentNameLen)
		{
			return default(uint);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xED2F28", Offset = "0xED2F28", VA = "0xED2F28")]
		public ulong GetComponentButtonMask(string pchRenderModelName, string pchComponentName)
		{
			return default(ulong);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xED2F6C", Offset = "0xED2F6C", VA = "0xED2F6C")]
		public uint GetComponentRenderModelName(string pchRenderModelName, string pchComponentName, StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen)
		{
			return default(uint);
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xED2FC8", Offset = "0xED2FC8", VA = "0xED2FC8")]
		public bool GetComponentState(string pchRenderModelName, string pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState)
		{
			return default(bool);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xED3570", Offset = "0xED3570", VA = "0xED3570")]
		public bool RenderModelHasComponent(string pchRenderModelName, string pchComponentName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xED35B4", Offset = "0xED35B4", VA = "0xED35B4")]
		public uint GetRenderModelThumbnailURL(string pchRenderModelName, StringBuilder pchThumbnailURL, uint unThumbnailURLLen, ref EVRRenderModelError peError)
		{
			return default(uint);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xED3610", Offset = "0xED3610", VA = "0xED3610")]
		public uint GetRenderModelOriginalPath(string pchRenderModelName, StringBuilder pchOriginalPath, uint unOriginalPathLen, ref EVRRenderModelError peError)
		{
			return default(uint);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xED366C", Offset = "0xED366C", VA = "0xED366C")]
		public string GetRenderModelErrorNameFromEnum(EVRRenderModelError error)
		{
			return null;
		}
	}
	[Token(Token = "0x200013F")]
	public class CVRNotifications
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRNotifications FnTable;

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xED0A48", Offset = "0xED0A48", VA = "0xED0A48")]
		internal CVRNotifications(IntPtr pInterface)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xED0B94", Offset = "0xED0B94", VA = "0xED0B94")]
		public EVRNotificationError CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, string pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId)
		{
			return default(EVRNotificationError);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xED0C14", Offset = "0xED0C14", VA = "0xED0C14")]
		public EVRNotificationError RemoveNotification(uint notificationId)
		{
			return default(EVRNotificationError);
		}
	}
	[Token(Token = "0x2000140")]
	public class CVRSettings
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRSettings FnTable;

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xED3F34", Offset = "0xED3F34", VA = "0xED3F34")]
		internal CVRSettings(IntPtr pInterface)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xED4090", Offset = "0xED4090", VA = "0xED4090")]
		public string GetSettingsErrorNameFromEnum(EVRSettingsError eError)
		{
			return null;
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xED412C", Offset = "0xED412C", VA = "0xED412C")]
		public bool Sync(bool bForce, ref EVRSettingsError peError)
		{
			return default(bool);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xED4170", Offset = "0xED4170", VA = "0xED4170")]
		public void SetBool(string pchSection, string pchSettingsKey, bool bValue, ref EVRSettingsError peError)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xED41CC", Offset = "0xED41CC", VA = "0xED41CC")]
		public void SetInt32(string pchSection, string pchSettingsKey, int nValue, ref EVRSettingsError peError)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xED4228", Offset = "0xED4228", VA = "0xED4228")]
		public void SetFloat(string pchSection, string pchSettingsKey, float flValue, ref EVRSettingsError peError)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xED4284", Offset = "0xED4284", VA = "0xED4284")]
		public void SetString(string pchSection, string pchSettingsKey, string pchValue, ref EVRSettingsError peError)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xED42E0", Offset = "0xED42E0", VA = "0xED42E0")]
		public bool GetBool(string pchSection, string pchSettingsKey, ref EVRSettingsError peError)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xED432C", Offset = "0xED432C", VA = "0xED432C")]
		public int GetInt32(string pchSection, string pchSettingsKey, ref EVRSettingsError peError)
		{
			return default(int);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xED4378", Offset = "0xED4378", VA = "0xED4378")]
		public float GetFloat(string pchSection, string pchSettingsKey, ref EVRSettingsError peError)
		{
			return default(float);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xED43C4", Offset = "0xED43C4", VA = "0xED43C4")]
		public void GetString(string pchSection, string pchSettingsKey, StringBuilder pchValue, uint unValueLen, ref EVRSettingsError peError)
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xED4428", Offset = "0xED4428", VA = "0xED4428")]
		public void RemoveSection(string pchSection, ref EVRSettingsError peError)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xED446C", Offset = "0xED446C", VA = "0xED446C")]
		public void RemoveKeyInSection(string pchSection, string pchSettingsKey, ref EVRSettingsError peError)
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class CVRScreenshots
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRScreenshots FnTable;

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xED3B98", Offset = "0xED3B98", VA = "0xED3B98")]
		internal CVRScreenshots(IntPtr pInterface)
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xED3CFC", Offset = "0xED3CFC", VA = "0xED3CFC")]
		public EVRScreenshotError RequestScreenshot(ref uint pOutScreenshotHandle, EVRScreenshotType type, string pchPreviewFilename, string pchVRFilename)
		{
			return default(EVRScreenshotError);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xED3D5C", Offset = "0xED3D5C", VA = "0xED3D5C")]
		public EVRScreenshotError HookScreenshot(EVRScreenshotType[] pSupportedTypes)
		{
			return default(EVRScreenshotError);
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xED3D9C", Offset = "0xED3D9C", VA = "0xED3D9C")]
		public EVRScreenshotType GetScreenshotPropertyType(uint screenshotHandle, ref EVRScreenshotError pError)
		{
			return default(EVRScreenshotType);
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xED3DE0", Offset = "0xED3DE0", VA = "0xED3DE0")]
		public uint GetScreenshotPropertyFilename(uint screenshotHandle, EVRScreenshotPropertyFilenames filenameType, StringBuilder pchFilename, uint cchFilename, ref EVRScreenshotError pError)
		{
			return default(uint);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xED3E44", Offset = "0xED3E44", VA = "0xED3E44")]
		public EVRScreenshotError UpdateScreenshotProgress(uint screenshotHandle, float flProgress)
		{
			return default(EVRScreenshotError);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xED3E88", Offset = "0xED3E88", VA = "0xED3E88")]
		public EVRScreenshotError TakeStereoScreenshot(ref uint pOutScreenshotHandle, string pchPreviewFilename, string pchVRFilename)
		{
			return default(EVRScreenshotError);
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xED3ED8", Offset = "0xED3ED8", VA = "0xED3ED8")]
		public EVRScreenshotError SubmitScreenshot(uint screenshotHandle, EVRScreenshotType type, string pchSourcePreviewFilename, string pchSourceVRFilename)
		{
			return default(EVRScreenshotError);
		}
	}
	[Token(Token = "0x2000142")]
	public class CVRResources
	{
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRResources FnTable;

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xED39A4", Offset = "0xED39A4", VA = "0xED39A4")]
		internal CVRResources(IntPtr pInterface)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xED3AF0", Offset = "0xED3AF0", VA = "0xED3AF0")]
		public uint LoadSharedResource(string pchResourceName, string pchBuffer, uint unBufferLen)
		{
			return default(uint);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xED3B3C", Offset = "0xED3B3C", VA = "0xED3B3C")]
		public uint GetResourceFullPath(string pchResourceName, string pchResourceTypeDirectory, string pchPathBuffer, uint unBufferLen)
		{
			return default(uint);
		}
	}
	[Token(Token = "0x2000143")]
	public class CVRDriverManager
	{
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRDriverManager FnTable;

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xED05FC", Offset = "0xED05FC", VA = "0xED05FC")]
		internal CVRDriverManager(IntPtr pInterface)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xED0748", Offset = "0xED0748", VA = "0xED0748")]
		public uint GetDriverCount()
		{
			return default(uint);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xED0774", Offset = "0xED0774", VA = "0xED0774")]
		public uint GetDriverName(uint nDriver, StringBuilder pchValue, uint unBufferSize)
		{
			return default(uint);
		}
	}
	[Token(Token = "0x2000144")]
	public class OpenVRInterop
	{
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x18A6FA4", Offset = "0x18A6FA4", VA = "0x18A6FA4")]
		public OpenVRInterop()
		{
		}

		[PreserveSig]
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x18A581C", Offset = "0x18A581C", VA = "0x18A581C")]
		internal static extern uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType);

		[PreserveSig]
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x18A58C8", Offset = "0x18A58C8", VA = "0x18A58C8")]
		internal static extern void ShutdownInternal();

		[PreserveSig]
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x18A5954", Offset = "0x18A5954", VA = "0x18A5954")]
		internal static extern bool IsHmdPresent();

		[PreserveSig]
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x18A59E8", Offset = "0x18A59E8", VA = "0x18A59E8")]
		internal static extern bool IsRuntimeInstalled();

		[PreserveSig]
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x18A5AF4", Offset = "0x18A5AF4", VA = "0x18A5AF4")]
		internal static extern IntPtr GetStringForHmdError(EVRInitError error);

		[PreserveSig]
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x18A5B90", Offset = "0x18A5B90", VA = "0x18A5B90")]
		internal static extern IntPtr GetGenericInterface([In] string pchInterfaceVersion, ref EVRInitError peError);

		[PreserveSig]
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x18A5C54", Offset = "0x18A5C54", VA = "0x18A5C54")]
		internal static extern bool IsInterfaceVersionValid([In] string pchInterfaceVersion);

		[PreserveSig]
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x18A5D0C", Offset = "0x18A5D0C", VA = "0x18A5D0C")]
		internal static extern uint GetInitToken();
	}
	[Token(Token = "0x2000145")]
	public enum EVREye
	{
		[Token(Token = "0x400013E")]
		Eye_Left,
		[Token(Token = "0x400013F")]
		Eye_Right
	}
	[Token(Token = "0x2000146")]
	public enum ETextureType
	{
		[Token(Token = "0x4000141")]
		DirectX,
		[Token(Token = "0x4000142")]
		OpenGL,
		[Token(Token = "0x4000143")]
		Vulkan,
		[Token(Token = "0x4000144")]
		IOSurface,
		[Token(Token = "0x4000145")]
		DirectX12
	}
	[Token(Token = "0x2000147")]
	public enum EColorSpace
	{
		[Token(Token = "0x4000147")]
		Auto,
		[Token(Token = "0x4000148")]
		Gamma,
		[Token(Token = "0x4000149")]
		Linear
	}
	[Token(Token = "0x2000148")]
	public enum ETrackingResult
	{
		[Token(Token = "0x400014B")]
		Uninitialized = 1,
		[Token(Token = "0x400014C")]
		Calibrating_InProgress = 100,
		[Token(Token = "0x400014D")]
		Calibrating_OutOfRange = 101,
		[Token(Token = "0x400014E")]
		Running_OK = 200,
		[Token(Token = "0x400014F")]
		Running_OutOfRange = 201
	}
	[Token(Token = "0x2000149")]
	public enum ETrackedDeviceClass
	{
		[Token(Token = "0x4000151")]
		Invalid,
		[Token(Token = "0x4000152")]
		HMD,
		[Token(Token = "0x4000153")]
		Controller,
		[Token(Token = "0x4000154")]
		GenericTracker,
		[Token(Token = "0x4000155")]
		TrackingReference,
		[Token(Token = "0x4000156")]
		DisplayRedirect
	}
	[Token(Token = "0x200014A")]
	public enum ETrackedControllerRole
	{
		[Token(Token = "0x4000158")]
		Invalid,
		[Token(Token = "0x4000159")]
		LeftHand,
		[Token(Token = "0x400015A")]
		RightHand
	}
	[Token(Token = "0x200014B")]
	public enum ETrackingUniverseOrigin
	{
		[Token(Token = "0x400015C")]
		TrackingUniverseSeated,
		[Token(Token = "0x400015D")]
		TrackingUniverseStanding,
		[Token(Token = "0x400015E")]
		TrackingUniverseRawAndUncalibrated
	}
	[Token(Token = "0x200014C")]
	public enum ETrackedDeviceProperty
	{
		[Token(Token = "0x4000160")]
		Prop_Invalid = 0,
		[Token(Token = "0x4000161")]
		Prop_TrackingSystemName_String = 1000,
		[Token(Token = "0x4000162")]
		Prop_ModelNumber_String = 1001,
		[Token(Token = "0x4000163")]
		Prop_SerialNumber_String = 1002,
		[Token(Token = "0x4000164")]
		Prop_RenderModelName_String = 1003,
		[Token(Token = "0x4000165")]
		Prop_WillDriftInYaw_Bool = 1004,
		[Token(Token = "0x4000166")]
		Prop_ManufacturerName_String = 1005,
		[Token(Token = "0x4000167")]
		Prop_TrackingFirmwareVersion_String = 1006,
		[Token(Token = "0x4000168")]
		Prop_HardwareRevision_String = 1007,
		[Token(Token = "0x4000169")]
		Prop_AllWirelessDongleDescriptions_String = 1008,
		[Token(Token = "0x400016A")]
		Prop_ConnectedWirelessDongle_String = 1009,
		[Token(Token = "0x400016B")]
		Prop_DeviceIsWireless_Bool = 1010,
		[Token(Token = "0x400016C")]
		Prop_DeviceIsCharging_Bool = 1011,
		[Token(Token = "0x400016D")]
		Prop_DeviceBatteryPercentage_Float = 1012,
		[Token(Token = "0x400016E")]
		Prop_StatusDisplayTransform_Matrix34 = 1013,
		[Token(Token = "0x400016F")]
		Prop_Firmware_UpdateAvailable_Bool = 1014,
		[Token(Token = "0x4000170")]
		Prop_Firmware_ManualUpdate_Bool = 1015,
		[Token(Token = "0x4000171")]
		Prop_Firmware_ManualUpdateURL_String = 1016,
		[Token(Token = "0x4000172")]
		Prop_HardwareRevision_Uint64 = 1017,
		[Token(Token = "0x4000173")]
		Prop_FirmwareVersion_Uint64 = 1018,
		[Token(Token = "0x4000174")]
		Prop_FPGAVersion_Uint64 = 1019,
		[Token(Token = "0x4000175")]
		Prop_VRCVersion_Uint64 = 1020,
		[Token(Token = "0x4000176")]
		Prop_RadioVersion_Uint64 = 1021,
		[Token(Token = "0x4000177")]
		Prop_DongleVersion_Uint64 = 1022,
		[Token(Token = "0x4000178")]
		Prop_BlockServerShutdown_Bool = 1023,
		[Token(Token = "0x4000179")]
		Prop_CanUnifyCoordinateSystemWithHmd_Bool = 1024,
		[Token(Token = "0x400017A")]
		Prop_ContainsProximitySensor_Bool = 1025,
		[Token(Token = "0x400017B")]
		Prop_DeviceProvidesBatteryStatus_Bool = 1026,
		[Token(Token = "0x400017C")]
		Prop_DeviceCanPowerOff_Bool = 1027,
		[Token(Token = "0x400017D")]
		Prop_Firmware_ProgrammingTarget_String = 1028,
		[Token(Token = "0x400017E")]
		Prop_DeviceClass_Int32 = 1029,
		[Token(Token = "0x400017F")]
		Prop_HasCamera_Bool = 1030,
		[Token(Token = "0x4000180")]
		Prop_DriverVersion_String = 1031,
		[Token(Token = "0x4000181")]
		Prop_Firmware_ForceUpdateRequired_Bool = 1032,
		[Token(Token = "0x4000182")]
		Prop_ViveSystemButtonFixRequired_Bool = 1033,
		[Token(Token = "0x4000183")]
		Prop_ParentDriver_Uint64 = 1034,
		[Token(Token = "0x4000184")]
		Prop_ResourceRoot_String = 1035,
		[Token(Token = "0x4000185")]
		Prop_ReportsTimeSinceVSync_Bool = 2000,
		[Token(Token = "0x4000186")]
		Prop_SecondsFromVsyncToPhotons_Float = 2001,
		[Token(Token = "0x4000187")]
		Prop_DisplayFrequency_Float = 2002,
		[Token(Token = "0x4000188")]
		Prop_UserIpdMeters_Float = 2003,
		[Token(Token = "0x4000189")]
		Prop_CurrentUniverseId_Uint64 = 2004,
		[Token(Token = "0x400018A")]
		Prop_PreviousUniverseId_Uint64 = 2005,
		[Token(Token = "0x400018B")]
		Prop_DisplayFirmwareVersion_Uint64 = 2006,
		[Token(Token = "0x400018C")]
		Prop_IsOnDesktop_Bool = 2007,
		[Token(Token = "0x400018D")]
		Prop_DisplayMCType_Int32 = 2008,
		[Token(Token = "0x400018E")]
		Prop_DisplayMCOffset_Float = 2009,
		[Token(Token = "0x400018F")]
		Prop_DisplayMCScale_Float = 2010,
		[Token(Token = "0x4000190")]
		Prop_EdidVendorID_Int32 = 2011,
		[Token(Token = "0x4000191")]
		Prop_DisplayMCImageLeft_String = 2012,
		[Token(Token = "0x4000192")]
		Prop_DisplayMCImageRight_String = 2013,
		[Token(Token = "0x4000193")]
		Prop_DisplayGCBlackClamp_Float = 2014,
		[Token(Token = "0x4000194")]
		Prop_EdidProductID_Int32 = 2015,
		[Token(Token = "0x4000195")]
		Prop_CameraToHeadTransform_Matrix34 = 2016,
		[Token(Token = "0x4000196")]
		Prop_DisplayGCType_Int32 = 2017,
		[Token(Token = "0x4000197")]
		Prop_DisplayGCOffset_Float = 2018,
		[Token(Token = "0x4000198")]
		Prop_DisplayGCScale_Float = 2019,
		[Token(Token = "0x4000199")]
		Prop_DisplayGCPrescale_Float = 2020,
		[Token(Token = "0x400019A")]
		Prop_DisplayGCImage_String = 2021,
		[Token(Token = "0x400019B")]
		Prop_LensCenterLeftU_Float = 2022,
		[Token(Token = "0x400019C")]
		Prop_LensCenterLeftV_Float = 2023,
		[Token(Token = "0x400019D")]
		Prop_LensCenterRightU_Float = 2024,
		[Token(Token = "0x400019E")]
		Prop_LensCenterRightV_Float = 2025,
		[Token(Token = "0x400019F")]
		Prop_UserHeadToEyeDepthMeters_Float = 2026,
		[Token(Token = "0x40001A0")]
		Prop_CameraFirmwareVersion_Uint64 = 2027,
		[Token(Token = "0x40001A1")]
		Prop_CameraFirmwareDescription_String = 2028,
		[Token(Token = "0x40001A2")]
		Prop_DisplayFPGAVersion_Uint64 = 2029,
		[Token(Token = "0x40001A3")]
		Prop_DisplayBootloaderVersion_Uint64 = 2030,
		[Token(Token = "0x40001A4")]
		Prop_DisplayHardwareVersion_Uint64 = 2031,
		[Token(Token = "0x40001A5")]
		Prop_AudioFirmwareVersion_Uint64 = 2032,
		[Token(Token = "0x40001A6")]
		Prop_CameraCompatibilityMode_Int32 = 2033,
		[Token(Token = "0x40001A7")]
		Prop_ScreenshotHorizontalFieldOfViewDegrees_Float = 2034,
		[Token(Token = "0x40001A8")]
		Prop_ScreenshotVerticalFieldOfViewDegrees_Float = 2035,
		[Token(Token = "0x40001A9")]
		Prop_DisplaySuppressed_Bool = 2036,
		[Token(Token = "0x40001AA")]
		Prop_DisplayAllowNightMode_Bool = 2037,
		[Token(Token = "0x40001AB")]
		Prop_DisplayMCImageWidth_Int32 = 2038,
		[Token(Token = "0x40001AC")]
		Prop_DisplayMCImageHeight_Int32 = 2039,
		[Token(Token = "0x40001AD")]
		Prop_DisplayMCImageNumChannels_Int32 = 2040,
		[Token(Token = "0x40001AE")]
		Prop_DisplayMCImageData_Binary = 2041,
		[Token(Token = "0x40001AF")]
		Prop_SecondsFromPhotonsToVblank_Float = 2042,
		[Token(Token = "0x40001B0")]
		Prop_DriverDirectModeSendsVsyncEvents_Bool = 2043,
		[Token(Token = "0x40001B1")]
		Prop_DisplayDebugMode_Bool = 2044,
		[Token(Token = "0x40001B2")]
		Prop_GraphicsAdapterLuid_Uint64 = 2045,
		[Token(Token = "0x40001B3")]
		Prop_AttachedDeviceId_String = 3000,
		[Token(Token = "0x40001B4")]
		Prop_SupportedButtons_Uint64 = 3001,
		[Token(Token = "0x40001B5")]
		Prop_Axis0Type_Int32 = 3002,
		[Token(Token = "0x40001B6")]
		Prop_Axis1Type_Int32 = 3003,
		[Token(Token = "0x40001B7")]
		Prop_Axis2Type_Int32 = 3004,
		[Token(Token = "0x40001B8")]
		Prop_Axis3Type_Int32 = 3005,
		[Token(Token = "0x40001B9")]
		Prop_Axis4Type_Int32 = 3006,
		[Token(Token = "0x40001BA")]
		Prop_ControllerRoleHint_Int32 = 3007,
		[Token(Token = "0x40001BB")]
		Prop_FieldOfViewLeftDegrees_Float = 4000,
		[Token(Token = "0x40001BC")]
		Prop_FieldOfViewRightDegrees_Float = 4001,
		[Token(Token = "0x40001BD")]
		Prop_FieldOfViewTopDegrees_Float = 4002,
		[Token(Token = "0x40001BE")]
		Prop_FieldOfViewBottomDegrees_Float = 4003,
		[Token(Token = "0x40001BF")]
		Prop_TrackingRangeMinimumMeters_Float = 4004,
		[Token(Token = "0x40001C0")]
		Prop_TrackingRangeMaximumMeters_Float = 4005,
		[Token(Token = "0x40001C1")]
		Prop_ModeLabel_String = 4006,
		[Token(Token = "0x40001C2")]
		Prop_IconPathName_String = 5000,
		[Token(Token = "0x40001C3")]
		Prop_NamedIconPathDeviceOff_String = 5001,
		[Token(Token = "0x40001C4")]
		Prop_NamedIconPathDeviceSearching_String = 5002,
		[Token(Token = "0x40001C5")]
		Prop_NamedIconPathDeviceSearchingAlert_String = 5003,
		[Token(Token = "0x40001C6")]
		Prop_NamedIconPathDeviceReady_String = 5004,
		[Token(Token = "0x40001C7")]
		Prop_NamedIconPathDeviceReadyAlert_String = 5005,
		[Token(Token = "0x40001C8")]
		Prop_NamedIconPathDeviceNotReady_String = 5006,
		[Token(Token = "0x40001C9")]
		Prop_NamedIconPathDeviceStandby_String = 5007,
		[Token(Token = "0x40001CA")]
		Prop_NamedIconPathDeviceAlertLow_String = 5008,
		[Token(Token = "0x40001CB")]
		Prop_DisplayHiddenArea_Binary_Start = 5100,
		[Token(Token = "0x40001CC")]
		Prop_DisplayHiddenArea_Binary_End = 5150,
		[Token(Token = "0x40001CD")]
		Prop_UserConfigPath_String = 6000,
		[Token(Token = "0x40001CE")]
		Prop_InstallPath_String = 6001,
		[Token(Token = "0x40001CF")]
		Prop_HasDisplayComponent_Bool = 6002,
		[Token(Token = "0x40001D0")]
		Prop_HasControllerComponent_Bool = 6003,
		[Token(Token = "0x40001D1")]
		Prop_HasCameraComponent_Bool = 6004,
		[Token(Token = "0x40001D2")]
		Prop_HasDriverDirectModeComponent_Bool = 6005,
		[Token(Token = "0x40001D3")]
		Prop_HasVirtualDisplayComponent_Bool = 6006,
		[Token(Token = "0x40001D4")]
		Prop_VendorSpecific_Reserved_Start = 10000,
		[Token(Token = "0x40001D5")]
		Prop_VendorSpecific_Reserved_End = 10999
	}
	[Token(Token = "0x200014D")]
	public enum ETrackedPropertyError
	{
		[Token(Token = "0x40001D7")]
		TrackedProp_Success,
		[Token(Token = "0x40001D8")]
		TrackedProp_WrongDataType,
		[Token(Token = "0x40001D9")]
		TrackedProp_WrongDeviceClass,
		[Token(Token = "0x40001DA")]
		TrackedProp_BufferTooSmall,
		[Token(Token = "0x40001DB")]
		TrackedProp_UnknownProperty,
		[Token(Token = "0x40001DC")]
		TrackedProp_InvalidDevice,
		[Token(Token = "0x40001DD")]
		TrackedProp_CouldNotContactServer,
		[Token(Token = "0x40001DE")]
		TrackedProp_ValueNotProvidedByDevice,
		[Token(Token = "0x40001DF")]
		TrackedProp_StringExceedsMaximumLength,
		[Token(Token = "0x40001E0")]
		TrackedProp_NotYetAvailable,
		[Token(Token = "0x40001E1")]
		TrackedProp_PermissionDenied,
		[Token(Token = "0x40001E2")]
		TrackedProp_InvalidOperation
	}
	[Token(Token = "0x200014E")]
	public enum EVRSubmitFlags
	{
		[Token(Token = "0x40001E4")]
		Submit_Default = 0,
		[Token(Token = "0x40001E5")]
		Submit_LensDistortionAlreadyApplied = 1,
		[Token(Token = "0x40001E6")]
		Submit_GlRenderBuffer = 2,
		[Token(Token = "0x40001E7")]
		Submit_Reserved = 4
	}
	[Token(Token = "0x200014F")]
	public enum EVRState
	{
		[Token(Token = "0x40001E9")]
		Undefined = -1,
		[Token(Token = "0x40001EA")]
		Off,
		[Token(Token = "0x40001EB")]
		Searching,
		[Token(Token = "0x40001EC")]
		Searching_Alert,
		[Token(Token = "0x40001ED")]
		Ready,
		[Token(Token = "0x40001EE")]
		Ready_Alert,
		[Token(Token = "0x40001EF")]
		NotReady,
		[Token(Token = "0x40001F0")]
		Standby,
		[Token(Token = "0x40001F1")]
		Ready_Alert_Low
	}
	[Token(Token = "0x2000150")]
	public enum EVREventType
	{
		[Token(Token = "0x40001F3")]
		VREvent_None = 0,
		[Token(Token = "0x40001F4")]
		VREvent_TrackedDeviceActivated = 100,
		[Token(Token = "0x40001F5")]
		VREvent_TrackedDeviceDeactivated = 101,
		[Token(Token = "0x40001F6")]
		VREvent_TrackedDeviceUpdated = 102,
		[Token(Token = "0x40001F7")]
		VREvent_TrackedDeviceUserInteractionStarted = 103,
		[Token(Token = "0x40001F8")]
		VREvent_TrackedDeviceUserInteractionEnded = 104,
		[Token(Token = "0x40001F9")]
		VREvent_IpdChanged = 105,
		[Token(Token = "0x40001FA")]
		VREvent_EnterStandbyMode = 106,
		[Token(Token = "0x40001FB")]
		VREvent_LeaveStandbyMode = 107,
		[Token(Token = "0x40001FC")]
		VREvent_TrackedDeviceRoleChanged = 108,
		[Token(Token = "0x40001FD")]
		VREvent_WatchdogWakeUpRequested = 109,
		[Token(Token = "0x40001FE")]
		VREvent_LensDistortionChanged = 110,
		[Token(Token = "0x40001FF")]
		VREvent_PropertyChanged = 111,
		[Token(Token = "0x4000200")]
		VREvent_ButtonPress = 200,
		[Token(Token = "0x4000201")]
		VREvent_ButtonUnpress = 201,
		[Token(Token = "0x4000202")]
		VREvent_ButtonTouch = 202,
		[Token(Token = "0x4000203")]
		VREvent_ButtonUntouch = 203,
		[Token(Token = "0x4000204")]
		VREvent_MouseMove = 300,
		[Token(Token = "0x4000205")]
		VREvent_MouseButtonDown = 301,
		[Token(Token = "0x4000206")]
		VREvent_MouseButtonUp = 302,
		[Token(Token = "0x4000207")]
		VREvent_FocusEnter = 303,
		[Token(Token = "0x4000208")]
		VREvent_FocusLeave = 304,
		[Token(Token = "0x4000209")]
		VREvent_Scroll = 305,
		[Token(Token = "0x400020A")]
		VREvent_TouchPadMove = 306,
		[Token(Token = "0x400020B")]
		VREvent_OverlayFocusChanged = 307,
		[Token(Token = "0x400020C")]
		VREvent_InputFocusCaptured = 400,
		[Token(Token = "0x400020D")]
		VREvent_InputFocusReleased = 401,
		[Token(Token = "0x400020E")]
		VREvent_SceneFocusLost = 402,
		[Token(Token = "0x400020F")]
		VREvent_SceneFocusGained = 403,
		[Token(Token = "0x4000210")]
		VREvent_SceneApplicationChanged = 404,
		[Token(Token = "0x4000211")]
		VREvent_SceneFocusChanged = 405,
		[Token(Token = "0x4000212")]
		VREvent_InputFocusChanged = 406,
		[Token(Token = "0x4000213")]
		VREvent_SceneApplicationSecondaryRenderingStarted = 407,
		[Token(Token = "0x4000214")]
		VREvent_HideRenderModels = 410,
		[Token(Token = "0x4000215")]
		VREvent_ShowRenderModels = 411,
		[Token(Token = "0x4000216")]
		VREvent_OverlayShown = 500,
		[Token(Token = "0x4000217")]
		VREvent_OverlayHidden = 501,
		[Token(Token = "0x4000218")]
		VREvent_DashboardActivated = 502,
		[Token(Token = "0x4000219")]
		VREvent_DashboardDeactivated = 503,
		[Token(Token = "0x400021A")]
		VREvent_DashboardThumbSelected = 504,
		[Token(Token = "0x400021B")]
		VREvent_DashboardRequested = 505,
		[Token(Token = "0x400021C")]
		VREvent_ResetDashboard = 506,
		[Token(Token = "0x400021D")]
		VREvent_RenderToast = 507,
		[Token(Token = "0x400021E")]
		VREvent_ImageLoaded = 508,
		[Token(Token = "0x400021F")]
		VREvent_ShowKeyboard = 509,
		[Token(Token = "0x4000220")]
		VREvent_HideKeyboard = 510,
		[Token(Token = "0x4000221")]
		VREvent_OverlayGamepadFocusGained = 511,
		[Token(Token = "0x4000222")]
		VREvent_OverlayGamepadFocusLost = 512,
		[Token(Token = "0x4000223")]
		VREvent_OverlaySharedTextureChanged = 513,
		[Token(Token = "0x4000224")]
		VREvent_DashboardGuideButtonDown = 514,
		[Token(Token = "0x4000225")]
		VREvent_DashboardGuideButtonUp = 515,
		[Token(Token = "0x4000226")]
		VREvent_ScreenshotTriggered = 516,
		[Token(Token = "0x4000227")]
		VREvent_ImageFailed = 517,
		[Token(Token = "0x4000228")]
		VREvent_DashboardOverlayCreated = 518,
		[Token(Token = "0x4000229")]
		VREvent_RequestScreenshot = 520,
		[Token(Token = "0x400022A")]
		VREvent_ScreenshotTaken = 521,
		[Token(Token = "0x400022B")]
		VREvent_ScreenshotFailed = 522,
		[Token(Token = "0x400022C")]
		VREvent_SubmitScreenshotToDashboard = 523,
		[Token(Token = "0x400022D")]
		VREvent_ScreenshotProgressToDashboard = 524,
		[Token(Token = "0x400022E")]
		VREvent_PrimaryDashboardDeviceChanged = 525,
		[Token(Token = "0x400022F")]
		VREvent_Notification_Shown = 600,
		[Token(Token = "0x4000230")]
		VREvent_Notification_Hidden = 601,
		[Token(Token = "0x4000231")]
		VREvent_Notification_BeginInteraction = 602,
		[Token(Token = "0x4000232")]
		VREvent_Notification_Destroyed = 603,
		[Token(Token = "0x4000233")]
		VREvent_Quit = 700,
		[Token(Token = "0x4000234")]
		VREvent_ProcessQuit = 701,
		[Token(Token = "0x4000235")]
		VREvent_QuitAborted_UserPrompt = 702,
		[Token(Token = "0x4000236")]
		VREvent_QuitAcknowledged = 703,
		[Token(Token = "0x4000237")]
		VREvent_DriverRequestedQuit = 704,
		[Token(Token = "0x4000238")]
		VREvent_ChaperoneDataHasChanged = 800,
		[Token(Token = "0x4000239")]
		VREvent_ChaperoneUniverseHasChanged = 801,
		[Token(Token = "0x400023A")]
		VREvent_ChaperoneTempDataHasChanged = 802,
		[Token(Token = "0x400023B")]
		VREvent_ChaperoneSettingsHaveChanged = 803,
		[Token(Token = "0x400023C")]
		VREvent_SeatedZeroPoseReset = 804,
		[Token(Token = "0x400023D")]
		VREvent_AudioSettingsHaveChanged = 820,
		[Token(Token = "0x400023E")]
		VREvent_BackgroundSettingHasChanged = 850,
		[Token(Token = "0x400023F")]
		VREvent_CameraSettingsHaveChanged = 851,
		[Token(Token = "0x4000240")]
		VREvent_ReprojectionSettingHasChanged = 852,
		[Token(Token = "0x4000241")]
		VREvent_ModelSkinSettingsHaveChanged = 853,
		[Token(Token = "0x4000242")]
		VREvent_EnvironmentSettingsHaveChanged = 854,
		[Token(Token = "0x4000243")]
		VREvent_PowerSettingsHaveChanged = 855,
		[Token(Token = "0x4000244")]
		VREvent_EnableHomeAppSettingsHaveChanged = 856,
		[Token(Token = "0x4000245")]
		VREvent_StatusUpdate = 900,
		[Token(Token = "0x4000246")]
		VREvent_MCImageUpdated = 1000,
		[Token(Token = "0x4000247")]
		VREvent_FirmwareUpdateStarted = 1100,
		[Token(Token = "0x4000248")]
		VREvent_FirmwareUpdateFinished = 1101,
		[Token(Token = "0x4000249")]
		VREvent_KeyboardClosed = 1200,
		[Token(Token = "0x400024A")]
		VREvent_KeyboardCharInput = 1201,
		[Token(Token = "0x400024B")]
		VREvent_KeyboardDone = 1202,
		[Token(Token = "0x400024C")]
		VREvent_ApplicationTransitionStarted = 1300,
		[Token(Token = "0x400024D")]
		VREvent_ApplicationTransitionAborted = 1301,
		[Token(Token = "0x400024E")]
		VREvent_ApplicationTransitionNewAppStarted = 1302,
		[Token(Token = "0x400024F")]
		VREvent_ApplicationListUpdated = 1303,
		[Token(Token = "0x4000250")]
		VREvent_ApplicationMimeTypeLoad = 1304,
		[Token(Token = "0x4000251")]
		VREvent_ApplicationTransitionNewAppLaunchComplete = 1305,
		[Token(Token = "0x4000252")]
		VREvent_ProcessConnected = 1306,
		[Token(Token = "0x4000253")]
		VREvent_ProcessDisconnected = 1307,
		[Token(Token = "0x4000254")]
		VREvent_Compositor_MirrorWindowShown = 1400,
		[Token(Token = "0x4000255")]
		VREvent_Compositor_MirrorWindowHidden = 1401,
		[Token(Token = "0x4000256")]
		VREvent_Compositor_ChaperoneBoundsShown = 1410,
		[Token(Token = "0x4000257")]
		VREvent_Compositor_ChaperoneBoundsHidden = 1411,
		[Token(Token = "0x4000258")]
		VREvent_TrackedCamera_StartVideoStream = 1500,
		[Token(Token = "0x4000259")]
		VREvent_TrackedCamera_StopVideoStream = 1501,
		[Token(Token = "0x400025A")]
		VREvent_TrackedCamera_PauseVideoStream = 1502,
		[Token(Token = "0x400025B")]
		VREvent_TrackedCamera_ResumeVideoStream = 1503,
		[Token(Token = "0x400025C")]
		VREvent_TrackedCamera_EditingSurface = 1550,
		[Token(Token = "0x400025D")]
		VREvent_PerformanceTest_EnableCapture = 1600,
		[Token(Token = "0x400025E")]
		VREvent_PerformanceTest_DisableCapture = 1601,
		[Token(Token = "0x400025F")]
		VREvent_PerformanceTest_FidelityLevel = 1602,
		[Token(Token = "0x4000260")]
		VREvent_MessageOverlay_Closed = 1650,
		[Token(Token = "0x4000261")]
		VREvent_VendorSpecific_Reserved_Start = 10000,
		[Token(Token = "0x4000262")]
		VREvent_VendorSpecific_Reserved_End = 19999
	}
	[Token(Token = "0x2000151")]
	public enum EDeviceActivityLevel
	{
		[Token(Token = "0x4000264")]
		k_EDeviceActivityLevel_Unknown = -1,
		[Token(Token = "0x4000265")]
		k_EDeviceActivityLevel_Idle,
		[Token(Token = "0x4000266")]
		k_EDeviceActivityLevel_UserInteraction,
		[Token(Token = "0x4000267")]
		k_EDeviceActivityLevel_UserInteraction_Timeout,
		[Token(Token = "0x4000268")]
		k_EDeviceActivityLevel_Standby
	}
	[Token(Token = "0x2000152")]
	public enum EVRButtonId
	{
		[Token(Token = "0x400026A")]
		k_EButton_System = 0,
		[Token(Token = "0x400026B")]
		k_EButton_ApplicationMenu = 1,
		[Token(Token = "0x400026C")]
		k_EButton_Grip = 2,
		[Token(Token = "0x400026D")]
		k_EButton_DPad_Left = 3,
		[Token(Token = "0x400026E")]
		k_EButton_DPad_Up = 4,
		[Token(Token = "0x400026F")]
		k_EButton_DPad_Right = 5,
		[Token(Token = "0x4000270")]
		k_EButton_DPad_Down = 6,
		[Token(Token = "0x4000271")]
		k_EButton_A = 7,
		[Token(Token = "0x4000272")]
		k_EButton_ProximitySensor = 31,
		[Token(Token = "0x4000273")]
		k_EButton_Axis0 = 32,
		[Token(Token = "0x4000274")]
		k_EButton_Axis1 = 33,
		[Token(Token = "0x4000275")]
		k_EButton_Axis2 = 34,
		[Token(Token = "0x4000276")]
		k_EButton_Axis3 = 35,
		[Token(Token = "0x4000277")]
		k_EButton_Axis4 = 36,
		[Token(Token = "0x4000278")]
		k_EButton_SteamVR_Touchpad = 32,
		[Token(Token = "0x4000279")]
		k_EButton_SteamVR_Trigger = 33,
		[Token(Token = "0x400027A")]
		k_EButton_Dashboard_Back = 2,
		[Token(Token = "0x400027B")]
		k_EButton_Max = 64
	}
	[Token(Token = "0x2000153")]
	public enum EVRMouseButton
	{
		[Token(Token = "0x400027D")]
		Left = 1,
		[Token(Token = "0x400027E")]
		Right = 2,
		[Token(Token = "0x400027F")]
		Middle = 4
	}
	[Token(Token = "0x2000154")]
	public enum EHiddenAreaMeshType
	{
		[Token(Token = "0x4000281")]
		k_eHiddenAreaMesh_Standard,
		[Token(Token = "0x4000282")]
		k_eHiddenAreaMesh_Inverse,
		[Token(Token = "0x4000283")]
		k_eHiddenAreaMesh_LineLoop,
		[Token(Token = "0x4000284")]
		k_eHiddenAreaMesh_Max
	}
	[Token(Token = "0x2000155")]
	public enum EVRControllerAxisType
	{
		[Token(Token = "0x4000286")]
		k_eControllerAxis_None,
		[Token(Token = "0x4000287")]
		k_eControllerAxis_TrackPad,
		[Token(Token = "0x4000288")]
		k_eControllerAxis_Joystick,
		[Token(Token = "0x4000289")]
		k_eControllerAxis_Trigger
	}
	[Token(Token = "0x2000156")]
	public enum EVRControllerEventOutputType
	{
		[Token(Token = "0x400028B")]
		ControllerEventOutput_OSEvents,
		[Token(Token = "0x400028C")]
		ControllerEventOutput_VREvents
	}
	[Token(Token = "0x2000157")]
	public enum ECollisionBoundsStyle
	{
		[Token(Token = "0x400028E")]
		COLLISION_BOUNDS_STYLE_BEGINNER,
		[Token(Token = "0x400028F")]
		COLLISION_BOUNDS_STYLE_INTERMEDIATE,
		[Token(Token = "0x4000290")]
		COLLISION_BOUNDS_STYLE_SQUARES,
		[Token(Token = "0x4000291")]
		COLLISION_BOUNDS_STYLE_ADVANCED,
		[Token(Token = "0x4000292")]
		COLLISION_BOUNDS_STYLE_NONE,
		[Token(Token = "0x4000293")]
		COLLISION_BOUNDS_STYLE_COUNT
	}
	[Token(Token = "0x2000158")]
	public enum EVROverlayError
	{
		[Token(Token = "0x4000295")]
		None = 0,
		[Token(Token = "0x4000296")]
		UnknownOverlay = 10,
		[Token(Token = "0x4000297")]
		InvalidHandle = 11,
		[Token(Token = "0x4000298")]
		PermissionDenied = 12,
		[Token(Token = "0x4000299")]
		OverlayLimitExceeded = 13,
		[Token(Token = "0x400029A")]
		WrongVisibilityType = 14,
		[Token(Token = "0x400029B")]
		KeyTooLong = 15,
		[Token(Token = "0x400029C")]
		NameTooLong = 16,
		[Token(Token = "0x400029D")]
		KeyInUse = 17,
		[Token(Token = "0x400029E")]
		WrongTransformType = 18,
		[Token(Token = "0x400029F")]
		InvalidTrackedDevice = 19,
		[Token(Token = "0x40002A0")]
		InvalidParameter = 20,
		[Token(Token = "0x40002A1")]
		ThumbnailCantBeDestroyed = 21,
		[Token(Token = "0x40002A2")]
		ArrayTooSmall = 22,
		[Token(Token = "0x40002A3")]
		RequestFailed = 23,
		[Token(Token = "0x40002A4")]
		InvalidTexture = 24,
		[Token(Token = "0x40002A5")]
		UnableToLoadFile = 25,
		[Token(Token = "0x40002A6")]
		KeyboardAlreadyInUse = 26,
		[Token(Token = "0x40002A7")]
		NoNeighbor = 27,
		[Token(Token = "0x40002A8")]
		TooManyMaskPrimitives = 29,
		[Token(Token = "0x40002A9")]
		BadMaskPrimitive = 30
	}
	[Token(Token = "0x2000159")]
	public enum EVRApplicationType
	{
		[Token(Token = "0x40002AB")]
		VRApplication_Other,
		[Token(Token = "0x40002AC")]
		VRApplication_Scene,
		[Token(Token = "0x40002AD")]
		VRApplication_Overlay,
		[Token(Token = "0x40002AE")]
		VRApplication_Background,
		[Token(Token = "0x40002AF")]
		VRApplication_Utility,
		[Token(Token = "0x40002B0")]
		VRApplication_VRMonitor,
		[Token(Token = "0x40002B1")]
		VRApplication_SteamWatchdog,
		[Token(Token = "0x40002B2")]
		VRApplication_Bootstrapper,
		[Token(Token = "0x40002B3")]
		VRApplication_Max
	}
	[Token(Token = "0x200015A")]
	public enum EVRFirmwareError
	{
		[Token(Token = "0x40002B5")]
		None,
		[Token(Token = "0x40002B6")]
		Success,
		[Token(Token = "0x40002B7")]
		Fail
	}
	[Token(Token = "0x200015B")]
	public enum EVRNotificationError
	{
		[Token(Token = "0x40002B9")]
		OK = 0,
		[Token(Token = "0x40002BA")]
		InvalidNotificationId = 100,
		[Token(Token = "0x40002BB")]
		NotificationQueueFull = 101,
		[Token(Token = "0x40002BC")]
		InvalidOverlayHandle = 102,
		[Token(Token = "0x40002BD")]
		SystemWithUserValueAlreadyExists = 103
	}
	[Token(Token = "0x200015C")]
	public enum EVRInitError
	{
		[Token(Token = "0x40002BF")]
		None = 0,
		[Token(Token = "0x40002C0")]
		Unknown = 1,
		[Token(Token = "0x40002C1")]
		Init_InstallationNotFound = 100,
		[Token(Token = "0x40002C2")]
		Init_InstallationCorrupt = 101,
		[Token(Token = "0x40002C3")]
		Init_VRClientDLLNotFound = 102,
		[Token(Token = "0x40002C4")]
		Init_FileNotFound = 103,
		[Token(Token = "0x40002C5")]
		Init_FactoryNotFound = 104,
		[Token(Token = "0x40002C6")]
		Init_InterfaceNotFound = 105,
		[Token(Token = "0x40002C7")]
		Init_InvalidInterface = 106,
		[Token(Token = "0x40002C8")]
		Init_UserConfigDirectoryInvalid = 107,
		[Token(Token = "0x40002C9")]
		Init_HmdNotFound = 108,
		[Token(Token = "0x40002CA")]
		Init_NotInitialized = 109,
		[Token(Token = "0x40002CB")]
		Init_PathRegistryNotFound = 110,
		[Token(Token = "0x40002CC")]
		Init_NoConfigPath = 111,
		[Token(Token = "0x40002CD")]
		Init_NoLogPath = 112,
		[Token(Token = "0x40002CE")]
		Init_PathRegistryNotWritable = 113,
		[Token(Token = "0x40002CF")]
		Init_AppInfoInitFailed = 114,
		[Token(Token = "0x40002D0")]
		Init_Retry = 115,
		[Token(Token = "0x40002D1")]
		Init_InitCanceledByUser = 116,
		[Token(Token = "0x40002D2")]
		Init_AnotherAppLaunching = 117,
		[Token(Token = "0x40002D3")]
		Init_SettingsInitFailed = 118,
		[Token(Token = "0x40002D4")]
		Init_ShuttingDown = 119,
		[Token(Token = "0x40002D5")]
		Init_TooManyObjects = 120,
		[Token(Token = "0x40002D6")]
		Init_NoServerForBackgroundApp = 121,
		[Token(Token = "0x40002D7")]
		Init_NotSupportedWithCompositor = 122,
		[Token(Token = "0x40002D8")]
		Init_NotAvailableToUtilityApps = 123,
		[Token(Token = "0x40002D9")]
		Init_Internal = 124,
		[Token(Token = "0x40002DA")]
		Init_HmdDriverIdIsNone = 125,
		[Token(Token = "0x40002DB")]
		Init_HmdNotFoundPresenceFailed = 126,
		[Token(Token = "0x40002DC")]
		Init_VRMonitorNotFound = 127,
		[Token(Token = "0x40002DD")]
		Init_VRMonitorStartupFailed = 128,
		[Token(Token = "0x40002DE")]
		Init_LowPowerWatchdogNotSupported = 129,
		[Token(Token = "0x40002DF")]
		Init_InvalidApplicationType = 130,
		[Token(Token = "0x40002E0")]
		Init_NotAvailableToWatchdogApps = 131,
		[Token(Token = "0x40002E1")]
		Init_WatchdogDisabledInSettings = 132,
		[Token(Token = "0x40002E2")]
		Init_VRDashboardNotFound = 133,
		[Token(Token = "0x40002E3")]
		Init_VRDashboardStartupFailed = 134,
		[Token(Token = "0x40002E4")]
		Init_VRHomeNotFound = 135,
		[Token(Token = "0x40002E5")]
		Init_VRHomeStartupFailed = 136,
		[Token(Token = "0x40002E6")]
		Driver_Failed = 200,
		[Token(Token = "0x40002E7")]
		Driver_Unknown = 201,
		[Token(Token = "0x40002E8")]
		Driver_HmdUnknown = 202,
		[Token(Token = "0x40002E9")]
		Driver_NotLoaded = 203,
		[Token(Token = "0x40002EA")]
		Driver_RuntimeOutOfDate = 204,
		[Token(Token = "0x40002EB")]
		Driver_HmdInUse = 205,
		[Token(Token = "0x40002EC")]
		Driver_NotCalibrated = 206,
		[Token(Token = "0x40002ED")]
		Driver_CalibrationInvalid = 207,
		[Token(Token = "0x40002EE")]
		Driver_HmdDisplayNotFound = 208,
		[Token(Token = "0x40002EF")]
		Driver_TrackedDeviceInterfaceUnknown = 209,
		[Token(Token = "0x40002F0")]
		Driver_HmdDriverIdOutOfBounds = 211,
		[Token(Token = "0x40002F1")]
		Driver_HmdDisplayMirrored = 212,
		[Token(Token = "0x40002F2")]
		IPC_ServerInitFailed = 300,
		[Token(Token = "0x40002F3")]
		IPC_ConnectFailed = 301,
		[Token(Token = "0x40002F4")]
		IPC_SharedStateInitFailed = 302,
		[Token(Token = "0x40002F5")]
		IPC_CompositorInitFailed = 303,
		[Token(Token = "0x40002F6")]
		IPC_MutexInitFailed = 304,
		[Token(Token = "0x40002F7")]
		IPC_Failed = 305,
		[Token(Token = "0x40002F8")]
		IPC_CompositorConnectFailed = 306,
		[Token(Token = "0x40002F9")]
		IPC_CompositorInvalidConnectResponse = 307,
		[Token(Token = "0x40002FA")]
		IPC_ConnectFailedAfterMultipleAttempts = 308,
		[Token(Token = "0x40002FB")]
		Compositor_Failed = 400,
		[Token(Token = "0x40002FC")]
		Compositor_D3D11HardwareRequired = 401,
		[Token(Token = "0x40002FD")]
		Compositor_FirmwareRequiresUpdate = 402,
		[Token(Token = "0x40002FE")]
		Compositor_OverlayInitFailed = 403,
		[Token(Token = "0x40002FF")]
		Compositor_ScreenshotsInitFailed = 404,
		[Token(Token = "0x4000300")]
		Compositor_UnableToCreateDevice = 405,
		[Token(Token = "0x4000301")]
		VendorSpecific_UnableToConnectToOculusRuntime = 1000,
		[Token(Token = "0x4000302")]
		VendorSpecific_HmdFound_CantOpenDevice = 1101,
		[Token(Token = "0x4000303")]
		VendorSpecific_HmdFound_UnableToRequestConfigStart = 1102,
		[Token(Token = "0x4000304")]
		VendorSpecific_HmdFound_NoStoredConfig = 1103,
		[Token(Token = "0x4000305")]
		VendorSpecific_HmdFound_ConfigTooBig = 1104,
		[Token(Token = "0x4000306")]
		VendorSpecific_HmdFound_ConfigTooSmall = 1105,
		[Token(Token = "0x4000307")]
		VendorSpecific_HmdFound_UnableToInitZLib = 1106,
		[Token(Token = "0x4000308")]
		VendorSpecific_HmdFound_CantReadFirmwareVersion = 1107,
		[Token(Token = "0x4000309")]
		VendorSpecific_HmdFound_UnableToSendUserDataStart = 1108,
		[Token(Token = "0x400030A")]
		VendorSpecific_HmdFound_UnableToGetUserDataStart = 1109,
		[Token(Token = "0x400030B")]
		VendorSpecific_HmdFound_UnableToGetUserDataNext = 1110,
		[Token(Token = "0x400030C")]
		VendorSpecific_HmdFound_UserDataAddressRange = 1111,
		[Token(Token = "0x400030D")]
		VendorSpecific_HmdFound_UserDataError = 1112,
		[Token(Token = "0x400030E")]
		VendorSpecific_HmdFound_ConfigFailedSanityCheck = 1113,
		[Token(Token = "0x400030F")]
		Steam_SteamInstallationNotFound = 2000
	}
	[Token(Token = "0x200015D")]
	public enum EVRScreenshotType
	{
		[Token(Token = "0x4000311")]
		None,
		[Token(Token = "0x4000312")]
		Mono,
		[Token(Token = "0x4000313")]
		Stereo,
		[Token(Token = "0x4000314")]
		Cubemap,
		[Token(Token = "0x4000315")]
		MonoPanorama,
		[Token(Token = "0x4000316")]
		StereoPanorama
	}
	[Token(Token = "0x200015E")]
	public enum EVRScreenshotPropertyFilenames
	{
		[Token(Token = "0x4000318")]
		Preview,
		[Token(Token = "0x4000319")]
		VR
	}
	[Token(Token = "0x200015F")]
	public enum EVRTrackedCameraError
	{
		[Token(Token = "0x400031B")]
		None = 0,
		[Token(Token = "0x400031C")]
		OperationFailed = 100,
		[Token(Token = "0x400031D")]
		InvalidHandle = 101,
		[Token(Token = "0x400031E")]
		InvalidFrameHeaderVersion = 102,
		[Token(Token = "0x400031F")]
		OutOfHandles = 103,
		[Token(Token = "0x4000320")]
		IPCFailure = 104,
		[Token(Token = "0x4000321")]
		NotSupportedForThisDevice = 105,
		[Token(Token = "0x4000322")]
		SharedMemoryFailure = 106,
		[Token(Token = "0x4000323")]
		FrameBufferingFailure = 107,
		[Token(Token = "0x4000324")]
		StreamSetupFailure = 108,
		[Token(Token = "0x4000325")]
		InvalidGLTextureId = 109,
		[Token(Token = "0x4000326")]
		InvalidSharedTextureHandle = 110,
		[Token(Token = "0x4000327")]
		FailedToGetGLTextureId = 111,
		[Token(Token = "0x4000328")]
		SharedTextureFailure = 112,
		[Token(Token = "0x4000329")]
		NoFrameAvailable = 113,
		[Token(Token = "0x400032A")]
		InvalidArgument = 114,
		[Token(Token = "0x400032B")]
		InvalidFrameBufferSize = 115
	}
	[Token(Token = "0x2000160")]
	public enum EVRTrackedCameraFrameType
	{
		[Token(Token = "0x400032D")]
		Distorted,
		[Token(Token = "0x400032E")]
		Undistorted,
		[Token(Token = "0x400032F")]
		MaximumUndistorted,
		[Token(Token = "0x4000330")]
		MAX_CAMERA_FRAME_TYPES
	}
	[Token(Token = "0x2000161")]
	public enum EVRApplicationError
	{
		[Token(Token = "0x4000332")]
		None = 0,
		[Token(Token = "0x4000333")]
		AppKeyAlreadyExists = 100,
		[Token(Token = "0x4000334")]
		NoManifest = 101,
		[Token(Token = "0x4000335")]
		NoApplication = 102,
		[Token(Token = "0x4000336")]
		InvalidIndex = 103,
		[Token(Token = "0x4000337")]
		UnknownApplication = 104,
		[Token(Token = "0x4000338")]
		IPCFailed = 105,
		[Token(Token = "0x4000339")]
		ApplicationAlreadyRunning = 106,
		[Token(Token = "0x400033A")]
		InvalidManifest = 107,
		[Token(Token = "0x400033B")]
		InvalidApplication = 108,
		[Token(Token = "0x400033C")]
		LaunchFailed = 109,
		[Token(Token = "0x400033D")]
		ApplicationAlreadyStarting = 110,
		[Token(Token = "0x400033E")]
		LaunchInProgress = 111,
		[Token(Token = "0x400033F")]
		OldApplicationQuitting = 112,
		[Token(Token = "0x4000340")]
		TransitionAborted = 113,
		[Token(Token = "0x4000341")]
		IsTemplate = 114,
		[Token(Token = "0x4000342")]
		BufferTooSmall = 200,
		[Token(Token = "0x4000343")]
		PropertyNotSet = 201,
		[Token(Token = "0x4000344")]
		UnknownProperty = 202,
		[Token(Token = "0x4000345")]
		InvalidParameter = 203
	}
	[Token(Token = "0x2000162")]
	public enum EVRApplicationProperty
	{
		[Token(Token = "0x4000347")]
		Name_String = 0,
		[Token(Token = "0x4000348")]
		LaunchType_String = 11,
		[Token(Token = "0x4000349")]
		WorkingDirectory_String = 12,
		[Token(Token = "0x400034A")]
		BinaryPath_String = 13,
		[Token(Token = "0x400034B")]
		Arguments_String = 14,
		[Token(Token = "0x400034C")]
		URL_String = 15,
		[Token(Token = "0x400034D")]
		Description_String = 50,
		[Token(Token = "0x400034E")]
		NewsURL_String = 51,
		[Token(Token = "0x400034F")]
		ImagePath_String = 52,
		[Token(Token = "0x4000350")]
		Source_String = 53,
		[Token(Token = "0x4000351")]
		IsDashboardOverlay_Bool = 60,
		[Token(Token = "0x4000352")]
		IsTemplate_Bool = 61,
		[Token(Token = "0x4000353")]
		IsInstanced_Bool = 62,
		[Token(Token = "0x4000354")]
		IsInternal_Bool = 63,
		[Token(Token = "0x4000355")]
		LastLaunchTime_Uint64 = 70
	}
	[Token(Token = "0x2000163")]
	public enum EVRApplicationTransitionState
	{
		[Token(Token = "0x4000357")]
		VRApplicationTransition_None = 0,
		[Token(Token = "0x4000358")]
		VRApplicationTransition_OldAppQuitSent = 10,
		[Token(Token = "0x4000359")]
		VRApplicationTransition_WaitingForExternalLaunch = 11,
		[Token(Token = "0x400035A")]
		VRApplicationTransition_NewAppLaunched = 20
	}
	[Token(Token = "0x2000164")]
	public enum ChaperoneCalibrationState
	{
		[Token(Token = "0x400035C")]
		OK = 1,
		[Token(Token = "0x400035D")]
		Warning = 100,
		[Token(Token = "0x400035E")]
		Warning_BaseStationMayHaveMoved = 101,
		[Token(Token = "0x400035F")]
		Warning_BaseStationRemoved = 102,
		[Token(Token = "0x4000360")]
		Warning_SeatedBoundsInvalid = 103,
		[Token(Token = "0x4000361")]
		Error = 200,
		[Token(Token = "0x4000362")]
		Error_BaseStationUninitialized = 201,
		[Token(Token = "0x4000363")]
		Error_BaseStationConflict = 202,
		[Token(Token = "0x4000364")]
		Error_PlayAreaInvalid = 203,
		[Token(Token = "0x4000365")]
		Error_CollisionBoundsInvalid = 204
	}
	[Token(Token = "0x2000165")]
	public enum EChaperoneConfigFile
	{
		[Token(Token = "0x4000367")]
		Live = 1,
		[Token(Token = "0x4000368")]
		Temp
	}
	[Token(Token = "0x2000166")]
	public enum EChaperoneImportFlags
	{
		[Token(Token = "0x400036A")]
		EChaperoneImport_BoundsOnly = 1
	}
	[Token(Token = "0x2000167")]
	public enum EVRCompositorError
	{
		[Token(Token = "0x400036C")]
		None = 0,
		[Token(Token = "0x400036D")]
		RequestFailed = 1,
		[Token(Token = "0x400036E")]
		IncompatibleVersion = 100,
		[Token(Token = "0x400036F")]
		DoNotHaveFocus = 101,
		[Token(Token = "0x4000370")]
		InvalidTexture = 102,
		[Token(Token = "0x4000371")]
		IsNotSceneApplication = 103,
		[Token(Token = "0x4000372")]
		TextureIsOnWrongDevice = 104,
		[Token(Token = "0x4000373")]
		TextureUsesUnsupportedFormat = 105,
		[Token(Token = "0x4000374")]
		SharedTexturesNotSupported = 106,
		[Token(Token = "0x4000375")]
		IndexOutOfRange = 107,
		[Token(Token = "0x4000376")]
		AlreadySubmitted = 108,
		[Token(Token = "0x4000377")]
		InvalidBounds = 109
	}
	[Token(Token = "0x2000168")]
	public enum VROverlayInputMethod
	{
		[Token(Token = "0x4000379")]
		None,
		[Token(Token = "0x400037A")]
		Mouse
	}
	[Token(Token = "0x2000169")]
	public enum VROverlayTransformType
	{
		[Token(Token = "0x400037C")]
		VROverlayTransform_Absolute,
		[Token(Token = "0x400037D")]
		VROverlayTransform_TrackedDeviceRelative,
		[Token(Token = "0x400037E")]
		VROverlayTransform_SystemOverlay,
		[Token(Token = "0x400037F")]
		VROverlayTransform_TrackedComponent
	}
	[Token(Token = "0x200016A")]
	public enum VROverlayFlags
	{
		[Token(Token = "0x4000381")]
		None,
		[Token(Token = "0x4000382")]
		Curved,
		[Token(Token = "0x4000383")]
		RGSS4X,
		[Token(Token = "0x4000384")]
		NoDashboardTab,
		[Token(Token = "0x4000385")]
		AcceptsGamepadEvents,
		[Token(Token = "0x4000386")]
		ShowGamepadFocus,
		[Token(Token = "0x4000387")]
		SendVRScrollEvents,
		[Token(Token = "0x4000388")]
		SendVRTouchpadEvents,
		[Token(Token = "0x4000389")]
		ShowTouchPadScrollWheel,
		[Token(Token = "0x400038A")]
		TransferOwnershipToInternalProcess,
		[Token(Token = "0x400038B")]
		SideBySide_Parallel,
		[Token(Token = "0x400038C")]
		SideBySide_Crossed,
		[Token(Token = "0x400038D")]
		Panorama,
		[Token(Token = "0x400038E")]
		StereoPanorama,
		[Token(Token = "0x400038F")]
		SortWithNonSceneOverlays,
		[Token(Token = "0x4000390")]
		VisibleInDashboard
	}
	[Token(Token = "0x200016B")]
	public enum VRMessageOverlayResponse
	{
		[Token(Token = "0x4000392")]
		ButtonPress_0,
		[Token(Token = "0x4000393")]
		ButtonPress_1,
		[Token(Token = "0x4000394")]
		ButtonPress_2,
		[Token(Token = "0x4000395")]
		ButtonPress_3,
		[Token(Token = "0x4000396")]
		CouldntFindSystemOverlay,
		[Token(Token = "0x4000397")]
		CouldntFindOrCreateClientOverlay,
		[Token(Token = "0x4000398")]
		ApplicationQuit
	}
	[Token(Token = "0x200016C")]
	public enum EGamepadTextInputMode
	{
		[Token(Token = "0x400039A")]
		k_EGamepadTextInputModeNormal,
		[Token(Token = "0x400039B")]
		k_EGamepadTextInputModePassword,
		[Token(Token = "0x400039C")]
		k_EGamepadTextInputModeSubmit
	}
	[Token(Token = "0x200016D")]
	public enum EGamepadTextInputLineMode
	{
		[Token(Token = "0x400039E")]
		k_EGamepadTextInputLineModeSingleLine,
		[Token(Token = "0x400039F")]
		k_EGamepadTextInputLineModeMultipleLines
	}
	[Token(Token = "0x200016E")]
	public enum EOverlayDirection
	{
		[Token(Token = "0x40003A1")]
		Up,
		[Token(Token = "0x40003A2")]
		Down,
		[Token(Token = "0x40003A3")]
		Left,
		[Token(Token = "0x40003A4")]
		Right,
		[Token(Token = "0x40003A5")]
		Count
	}
	[Token(Token = "0x200016F")]
	public enum EVROverlayIntersectionMaskPrimitiveType
	{
		[Token(Token = "0x40003A7")]
		OverlayIntersectionPrimitiveType_Rectangle,
		[Token(Token = "0x40003A8")]
		OverlayIntersectionPrimitiveType_Circle
	}
	[Token(Token = "0x2000170")]
	public enum EVRRenderModelError
	{
		[Token(Token = "0x40003AA")]
		None = 0,
		[Token(Token = "0x40003AB")]
		Loading = 100,
		[Token(Token = "0x40003AC")]
		NotSupported = 200,
		[Token(Token = "0x40003AD")]
		InvalidArg = 300,
		[Token(Token = "0x40003AE")]
		InvalidModel = 301,
		[Token(Token = "0x40003AF")]
		NoShapes = 302,
		[Token(Token = "0x40003B0")]
		MultipleShapes = 303,
		[Token(Token = "0x40003B1")]
		TooManyVertices = 304,
		[Token(Token = "0x40003B2")]
		MultipleTextures = 305,
		[Token(Token = "0x40003B3")]
		BufferTooSmall = 306,
		[Token(Token = "0x40003B4")]
		NotEnoughNormals = 307,
		[Token(Token = "0x40003B5")]
		NotEnoughTexCoords = 308,
		[Token(Token = "0x40003B6")]
		InvalidTexture = 400
	}
	[Token(Token = "0x2000171")]
	public enum EVRComponentProperty
	{
		[Token(Token = "0x40003B8")]
		IsStatic = 1,
		[Token(Token = "0x40003B9")]
		IsVisible = 2,
		[Token(Token = "0x40003BA")]
		IsTouched = 4,
		[Token(Token = "0x40003BB")]
		IsPressed = 8,
		[Token(Token = "0x40003BC")]
		IsScrolled = 0x10
	}
	[Token(Token = "0x2000172")]
	public enum EVRNotificationType
	{
		[Token(Token = "0x40003BE")]
		Transient,
		[Token(Token = "0x40003BF")]
		Persistent,
		[Token(Token = "0x40003C0")]
		Transient_SystemWithUserValue
	}
	[Token(Token = "0x2000173")]
	public enum EVRNotificationStyle
	{
		[Token(Token = "0x40003C2")]
		None = 0,
		[Token(Token = "0x40003C3")]
		Application = 100,
		[Token(Token = "0x40003C4")]
		Contact_Disabled = 200,
		[Token(Token = "0x40003C5")]
		Contact_Enabled = 201,
		[Token(Token = "0x40003C6")]
		Contact_Active = 202
	}
	[Token(Token = "0x2000174")]
	public enum EVRSettingsError
	{
		[Token(Token = "0x40003C8")]
		None,
		[Token(Token = "0x40003C9")]
		IPCFailed,
		[Token(Token = "0x40003CA")]
		WriteFailed,
		[Token(Token = "0x40003CB")]
		ReadFailed,
		[Token(Token = "0x40003CC")]
		JsonParseFailed,
		[Token(Token = "0x40003CD")]
		UnsetSettingHasNoDefault
	}
	[Token(Token = "0x2000175")]
	public enum EVRScreenshotError
	{
		[Token(Token = "0x40003CF")]
		None = 0,
		[Token(Token = "0x40003D0")]
		RequestFailed = 1,
		[Token(Token = "0x40003D1")]
		IncompatibleVersion = 100,
		[Token(Token = "0x40003D2")]
		NotFound = 101,
		[Token(Token = "0x40003D3")]
		BufferTooSmall = 102,
		[Token(Token = "0x40003D4")]
		ScreenshotAlreadyInProgress = 108
	}
	[StructLayout(2)]
	[Token(Token = "0x2000176")]
	public struct VREvent_Data_t
	{
		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Reserved_t reserved;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Controller_t controller;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Mouse_t mouse;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Scroll_t scroll;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Process_t process;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Notification_t notification;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Overlay_t overlay;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Status_t status;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Ipd_t ipd;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Chaperone_t chaperone;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_PerformanceTest_t performanceTest;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_TouchPadMove_t touchPadMove;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_SeatedZeroPoseReset_t seatedZeroPoseReset;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Screenshot_t screenshot;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_ScreenshotProgress_t screenshotProgress;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_ApplicationLaunch_t applicationLaunch;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_EditingCameraSurface_t cameraSurface;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_MessageOverlay_t messageOverlay;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Keyboard_t keyboard;
	}
	[StructLayout(2)]
	[Token(Token = "0x2000177")]
	public struct VROverlayIntersectionMaskPrimitive_Data_t
	{
		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntersectionMaskRectangle_t m_Rectangle;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntersectionMaskCircle_t m_Circle;
	}
	[Token(Token = "0x2000178")]
	public struct HmdMatrix34_t
	{
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m0;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float m1;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float m2;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float m3;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float m4;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float m5;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m6;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float m7;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m8;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float m9;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m10;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m11;
	}
	[Token(Token = "0x2000179")]
	public struct HmdMatrix44_t
	{
		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m0;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float m1;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float m2;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float m3;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float m4;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float m5;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m6;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float m7;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m8;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float m9;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m10;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m11;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m12;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float m13;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float m14;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float m15;
	}
	[Token(Token = "0x200017A")]
	public struct HmdVector3_t
	{
		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float v0;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float v1;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float v2;
	}
	[Token(Token = "0x200017B")]
	public struct HmdVector4_t
	{
		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float v0;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float v1;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float v2;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float v3;
	}
	[Token(Token = "0x200017C")]
	public struct HmdVector3d_t
	{
		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double v0;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double v1;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double v2;
	}
	[Token(Token = "0x200017D")]
	public struct HmdVector2_t
	{
		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float v0;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float v1;
	}
	[Token(Token = "0x200017E")]
	public struct HmdQuaternion_t
	{
		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double w;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double x;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double y;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double z;
	}
	[Token(Token = "0x200017F")]
	public struct HmdColor_t
	{
		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float r;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float g;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float b;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float a;
	}
	[Token(Token = "0x2000180")]
	public struct HmdQuad_t
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HmdVector3_t vCorners0;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public HmdVector3_t vCorners1;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HmdVector3_t vCorners2;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public HmdVector3_t vCorners3;
	}
	[Token(Token = "0x2000181")]
	public struct HmdRect2_t
	{
		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HmdVector2_t vTopLeft;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public HmdVector2_t vBottomRight;
	}
	[Token(Token = "0x2000182")]
	public struct DistortionCoordinates_t
	{
		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float rfRed0;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float rfRed1;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float rfGreen0;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float rfGreen1;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float rfBlue0;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float rfBlue1;
	}
	[Token(Token = "0x2000183")]
	public struct Texture_t
	{
		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ETextureType eType;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public EColorSpace eColorSpace;
	}
	[Token(Token = "0x2000184")]
	public struct TrackedDevicePose_t
	{
		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HmdMatrix34_t mDeviceToAbsoluteTracking;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HmdVector3_t vVelocity;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public HmdVector3_t vAngularVelocity;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ETrackingResult eTrackingResult;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bPoseIsValid;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool bDeviceIsConnected;
	}
	[Token(Token = "0x2000185")]
	public struct VRTextureBounds_t
	{
		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float uMin;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float vMin;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float uMax;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float vMax;
	}
	[Token(Token = "0x2000186")]
	public struct VRVulkanTextureData_t
	{
		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nImage;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr m_pDevice;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr m_pPhysicalDevice;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr m_pInstance;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntPtr m_pQueue;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint m_nQueueFamilyIndex;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public uint m_nWidth;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public uint m_nHeight;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public uint m_nFormat;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public uint m_nSampleCount;
	}
	[Token(Token = "0x2000187")]
	public struct D3D12TextureData_t
	{
		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr m_pResource;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr m_pCommandQueue;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_nNodeMask;
	}
	[Token(Token = "0x2000188")]
	public struct VREvent_Controller_t
	{
		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint button;
	}
	[Token(Token = "0x2000189")]
	public struct VREvent_Mouse_t
	{
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint button;
	}
	[Token(Token = "0x200018A")]
	public struct VREvent_Scroll_t
	{
		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float xdelta;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float ydelta;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint repeatCount;
	}
	[Token(Token = "0x200018B")]
	public struct VREvent_TouchPadMove_t
	{
		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool bFingerDown;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float flSecondsFingerDown;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float fValueXFirst;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float fValueYFirst;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float fValueXRaw;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float fValueYRaw;
	}
	[Token(Token = "0x200018C")]
	public struct VREvent_Notification_t
	{
		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong ulUserValue;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint notificationId;
	}
	[Token(Token = "0x200018D")]
	public struct VREvent_Process_t
	{
		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint pid;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint oldPid;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool bForced;
	}
	[Token(Token = "0x200018E")]
	public struct VREvent_Overlay_t
	{
		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong overlayHandle;
	}
	[Token(Token = "0x200018F")]
	public struct VREvent_Status_t
	{
		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint statusState;
	}
	[Token(Token = "0x2000190")]
	public struct VREvent_Keyboard_t
	{
		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte cNewInput0;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte cNewInput1;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public byte cNewInput2;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte cNewInput3;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public byte cNewInput4;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public byte cNewInput5;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public byte cNewInput6;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		public byte cNewInput7;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong uUserValue;
	}
	[Token(Token = "0x2000191")]
	public struct VREvent_Ipd_t
	{
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float ipdMeters;
	}
	[Token(Token = "0x2000192")]
	public struct VREvent_Chaperone_t
	{
		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nPreviousUniverse;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_nCurrentUniverse;
	}
	[Token(Token = "0x2000193")]
	public struct VREvent_Reserved_t
	{
		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong reserved0;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong reserved1;
	}
	[Token(Token = "0x2000194")]
	public struct VREvent_PerformanceTest_t
	{
		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_nFidelityLevel;
	}
	[Token(Token = "0x2000195")]
	public struct VREvent_SeatedZeroPoseReset_t
	{
		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool bResetBySystemMenu;
	}
	[Token(Token = "0x2000196")]
	public struct VREvent_Screenshot_t
	{
		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint handle;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint type;
	}
	[Token(Token = "0x2000197")]
	public struct VREvent_ScreenshotProgress_t
	{
		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float progress;
	}
	[Token(Token = "0x2000198")]
	public struct VREvent_ApplicationLaunch_t
	{
		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint pid;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint unArgsHandle;
	}
	[Token(Token = "0x2000199")]
	public struct VREvent_EditingCameraSurface_t
	{
		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong overlayHandle;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint nVisualMode;
	}
	[Token(Token = "0x200019A")]
	public struct VREvent_MessageOverlay_t
	{
		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint unVRMessageOverlayResponse;
	}
	[Token(Token = "0x200019B")]
	public struct VREvent_Property_t
	{
		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong container;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ETrackedDeviceProperty prop;
	}
	[Token(Token = "0x200019C")]
	public struct VREvent_t
	{
		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint eventType;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint trackedDeviceIndex;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float eventAgeSeconds;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public VREvent_Data_t data;
	}
	[Token(Token = "0x200019D")]
	public struct VREvent_t_Packed
	{
		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint eventType;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint trackedDeviceIndex;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float eventAgeSeconds;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public VREvent_Data_t data;

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x18A71DC", Offset = "0x18A71DC", VA = "0x18A71DC")]
		public VREvent_t_Packed(VREvent_t unpacked)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x18A7248", Offset = "0x18A7248", VA = "0x18A7248")]
		public void Unpack(ref VREvent_t unpacked)
		{
		}
	}
	[Token(Token = "0x200019E")]
	public struct HiddenAreaMesh_t
	{
		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr pVertexData;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unTriangleCount;
	}
	[Token(Token = "0x200019F")]
	public struct VRControllerAxis_t
	{
		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;
	}
	[Token(Token = "0x20001A0")]
	public struct VRControllerState_t
	{
		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint unPacketNum;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong ulButtonPressed;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ulong ulButtonTouched;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRControllerAxis_t rAxis0;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VRControllerAxis_t rAxis1;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VRControllerAxis_t rAxis2;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public VRControllerAxis_t rAxis3;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public VRControllerAxis_t rAxis4;
	}
	[Token(Token = "0x20001A1")]
	public struct VRControllerState_t_Packed
	{
		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint unPacketNum;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ulong ulButtonPressed;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ulong ulButtonTouched;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public VRControllerAxis_t rAxis0;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public VRControllerAxis_t rAxis1;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public VRControllerAxis_t rAxis2;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public VRControllerAxis_t rAxis3;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public VRControllerAxis_t rAxis4;

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x18A7130", Offset = "0x18A7130", VA = "0x18A7130")]
		public VRControllerState_t_Packed(VRControllerState_t unpacked)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x18A71D4", Offset = "0x18A71D4", VA = "0x18A71D4")]
		public void Unpack(ref VRControllerState_t unpacked)
		{
		}
	}
	[Token(Token = "0x20001A2")]
	public struct Compositor_OverlaySettings
	{
		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint size;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool curved;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public bool antialias;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float scale;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float distance;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float alpha;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float uOffset;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float vOffset;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float uScale;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float vScale;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float gridDivs;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float gridWidth;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float gridScale;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HmdMatrix44_t transform;
	}
	[Token(Token = "0x20001A3")]
	public struct CameraVideoStreamFrameHeader_t
	{
		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EVRTrackedCameraFrameType eFrameType;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint nWidth;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint nHeight;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint nBytesPerPixel;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint nFrameSequence;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public TrackedDevicePose_t standingTrackedDevicePose;
	}
	[Token(Token = "0x20001A4")]
	public struct AppOverrideKeys_t
	{
		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr pchKey;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr pchValue;
	}
	[Token(Token = "0x20001A5")]
	public struct Compositor_FrameTiming
	{
		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_nSize;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_nFrameIndex;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_nNumFramePresents;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_nNumMisPresented;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_nNumDroppedFrames;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint m_nReprojectionFlags;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double m_flSystemTimeInSeconds;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m_flPreSubmitGpuMs;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float m_flPostSubmitGpuMs;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m_flTotalRenderGpuMs;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m_flCompositorRenderGpuMs;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_flCompositorRenderCpuMs;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float m_flCompositorIdleCpuMs;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float m_flClientFrameIntervalMs;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float m_flPresentCallCpuMs;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float m_flWaitForPresentCpuMs;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float m_flSubmitFrameMs;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float m_flWaitGetPosesCalledMs;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float m_flNewPosesReadyMs;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float m_flNewFrameReadyMs;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float m_flCompositorUpdateStartMs;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float m_flCompositorUpdateEndMs;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float m_flCompositorRenderStartMs;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TrackedDevicePose_t m_HmdPose;
	}
	[Token(Token = "0x20001A6")]
	public struct Compositor_CumulativeStats
	{
		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_nPid;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_nNumFramePresents;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_nNumDroppedFrames;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_nNumReprojectedFrames;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_nNumFramePresentsOnStartup;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint m_nNumDroppedFramesOnStartup;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint m_nNumReprojectedFramesOnStartup;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint m_nNumLoading;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint m_nNumFramePresentsLoading;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public uint m_nNumDroppedFramesLoading;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint m_nNumReprojectedFramesLoading;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public uint m_nNumTimedOut;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public uint m_nNumFramePresentsTimedOut;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public uint m_nNumDroppedFramesTimedOut;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public uint m_nNumReprojectedFramesTimedOut;
	}
	[Token(Token = "0x20001A7")]
	public struct VROverlayIntersectionParams_t
	{
		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HmdVector3_t vSource;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public HmdVector3_t vDirection;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ETrackingUniverseOrigin eOrigin;
	}
	[Token(Token = "0x20001A8")]
	public struct VROverlayIntersectionResults_t
	{
		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HmdVector3_t vPoint;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public HmdVector3_t vNormal;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HmdVector2_t vUVs;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fDistance;
	}
	[Token(Token = "0x20001A9")]
	public struct IntersectionMaskRectangle_t
	{
		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m_flTopLeftX;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float m_flTopLeftY;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float m_flWidth;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float m_flHeight;
	}
	[Token(Token = "0x20001AA")]
	public struct IntersectionMaskCircle_t
	{
		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m_flCenterX;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float m_flCenterY;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float m_flRadius;
	}
	[Token(Token = "0x20001AB")]
	public struct VROverlayIntersectionMaskPrimitive_t
	{
		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EVROverlayIntersectionMaskPrimitiveType m_nPrimitiveType;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public VROverlayIntersectionMaskPrimitive_Data_t m_Primitive;
	}
	[Token(Token = "0x20001AC")]
	public struct RenderModel_ComponentState_t
	{
		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HmdMatrix34_t mTrackingToComponentRenderModel;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HmdMatrix34_t mTrackingToComponentLocal;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public uint uProperties;
	}
	[Token(Token = "0x20001AD")]
	public struct RenderModel_Vertex_t
	{
		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HmdVector3_t vPosition;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public HmdVector3_t vNormal;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rfTextureCoord0;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rfTextureCoord1;
	}
	[Token(Token = "0x20001AE")]
	public struct RenderModel_TextureMap_t
	{
		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public char unWidth;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public char unHeight;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr rubTextureMapData;
	}
	[Token(Token = "0x20001AF")]
	public struct RenderModel_TextureMap_t_Packed
	{
		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public char unWidth;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public char unHeight;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr rubTextureMapData;

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x18A70A0", Offset = "0x18A70A0", VA = "0x18A70A0")]
		public RenderModel_TextureMap_t_Packed(RenderModel_TextureMap_t unpacked)
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x18A70D0", Offset = "0x18A70D0", VA = "0x18A70D0")]
		public void Unpack(ref RenderModel_TextureMap_t unpacked)
		{
		}
	}
	[Token(Token = "0x20001B0")]
	public struct RenderModel_t
	{
		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr rVertexData;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unVertexCount;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr rIndexData;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint unTriangleCount;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int diffuseTextureId;
	}
	[Token(Token = "0x20001B1")]
	public struct RenderModel_t_Packed
	{
		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr rVertexData;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unVertexCount;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public IntPtr rIndexData;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint unTriangleCount;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int diffuseTextureId;

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x18A6FAC", Offset = "0x18A6FAC", VA = "0x18A6FAC")]
		public RenderModel_t_Packed(RenderModel_t unpacked)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x18A6FFC", Offset = "0x18A6FFC", VA = "0x18A6FFC")]
		public void Unpack(ref RenderModel_t unpacked)
		{
		}
	}
	[Token(Token = "0x20001B2")]
	public struct RenderModel_ControllerMode_State_t
	{
		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool bScrollWheelVisible;
	}
	[Token(Token = "0x20001B3")]
	public struct NotificationBitmap_t
	{
		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr m_pImageData;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nWidth;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_nHeight;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nBytesPerPixel;
	}
	[Token(Token = "0x20001B4")]
	public struct COpenVRContext
	{
		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr m_pVRSystem;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr m_pVRChaperone;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr m_pVRChaperoneSetup;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr m_pVRCompositor;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntPtr m_pVROverlay;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr m_pVRResources;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IntPtr m_pVRRenderModels;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IntPtr m_pVRExtendedDisplay;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IntPtr m_pVRSettings;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IntPtr m_pVRApplications;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public IntPtr m_pVRTrackedCamera;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IntPtr m_pVRScreenshots;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public IntPtr m_pVRDriverManager;
	}
	[Token(Token = "0x20001B5")]
	public class OpenVR
	{
		[Token(Token = "0x20001B6")]
		private class COpenVRContext
		{
			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private CVRSystem m_pVRSystem;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private CVRChaperone m_pVRChaperone;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private CVRChaperoneSetup m_pVRChaperoneSetup;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private CVRCompositor m_pVRCompositor;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private CVROverlay m_pVROverlay;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private CVRRenderModels m_pVRRenderModels;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private CVRExtendedDisplay m_pVRExtendedDisplay;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private CVRSettings m_pVRSettings;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private CVRApplications m_pVRApplications;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private CVRScreenshots m_pVRScreenshots;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private CVRTrackedCamera m_pVRTrackedCamera;

			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x18A5F48", Offset = "0x18A5F48", VA = "0x18A5F48")]
			public COpenVRContext()
			{
			}

			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x18A6E68", Offset = "0x18A6E68", VA = "0x18A6E68")]
			public void Clear()
			{
			}

			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x18A6EE8", Offset = "0x18A6EE8", VA = "0x18A6EE8")]
			private void CheckClear()
			{
			}

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x18A5FE8", Offset = "0x18A5FE8", VA = "0x18A5FE8")]
			public CVRSystem VRSystem()
			{
				return null;
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x18A6128", Offset = "0x18A6128", VA = "0x18A6128")]
			public CVRChaperone VRChaperone()
			{
				return null;
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x18A6268", Offset = "0x18A6268", VA = "0x18A6268")]
			public CVRChaperoneSetup VRChaperoneSetup()
			{
				return null;
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x18A63A8", Offset = "0x18A63A8", VA = "0x18A63A8")]
			public CVRCompositor VRCompositor()
			{
				return null;
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x18A64E8", Offset = "0x18A64E8", VA = "0x18A64E8")]
			public CVROverlay VROverlay()
			{
				return null;
			}

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x18A6628", Offset = "0x18A6628", VA = "0x18A6628")]
			public CVRRenderModels VRRenderModels()
			{
				return null;
			}

			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x18A6768", Offset = "0x18A6768", VA = "0x18A6768")]
			public CVRExtendedDisplay VRExtendedDisplay()
			{
				return null;
			}

			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x18A68A8", Offset = "0x18A68A8", VA = "0x18A68A8")]
			public CVRSettings VRSettings()
			{
				return null;
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x18A69E8", Offset = "0x18A69E8", VA = "0x18A69E8")]
			public CVRApplications VRApplications()
			{
				return null;
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x18A6B28", Offset = "0x18A6B28", VA = "0x18A6B28")]
			public CVRScreenshots VRScreenshots()
			{
				return null;
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x18A6C68", Offset = "0x18A6C68", VA = "0x18A6C68")]
			public CVRTrackedCamera VRTrackedCamera()
			{
				return null;
			}
		}

		[Token(Token = "0x4000500")]
		public const uint k_nDriverNone = uint.MaxValue;

		[Token(Token = "0x4000501")]
		public const uint k_unMaxDriverDebugResponseSize = 32768u;

		[Token(Token = "0x4000502")]
		public const uint k_unTrackedDeviceIndex_Hmd = 0u;

		[Token(Token = "0x4000503")]
		public const uint k_unMaxTrackedDeviceCount = 16u;

		[Token(Token = "0x4000504")]
		public const uint k_unTrackedDeviceIndexOther = 4294967294u;

		[Token(Token = "0x4000505")]
		public const uint k_unTrackedDeviceIndexInvalid = uint.MaxValue;

		[Token(Token = "0x4000506")]
		public const ulong k_ulInvalidPropertyContainer = 0uL;

		[Token(Token = "0x4000507")]
		public const uint k_unInvalidPropertyTag = 0u;

		[Token(Token = "0x4000508")]
		public const uint k_unFloatPropertyTag = 1u;

		[Token(Token = "0x4000509")]
		public const uint k_unInt32PropertyTag = 2u;

		[Token(Token = "0x400050A")]
		public const uint k_unUint64PropertyTag = 3u;

		[Token(Token = "0x400050B")]
		public const uint k_unBoolPropertyTag = 4u;

		[Token(Token = "0x400050C")]
		public const uint k_unStringPropertyTag = 5u;

		[Token(Token = "0x400050D")]
		public const uint k_unHmdMatrix34PropertyTag = 20u;

		[Token(Token = "0x400050E")]
		public const uint k_unHmdMatrix44PropertyTag = 21u;

		[Token(Token = "0x400050F")]
		public const uint k_unHmdVector3PropertyTag = 22u;

		[Token(Token = "0x4000510")]
		public const uint k_unHmdVector4PropertyTag = 23u;

		[Token(Token = "0x4000511")]
		public const uint k_unHiddenAreaPropertyTag = 30u;

		[Token(Token = "0x4000512")]
		public const uint k_unOpenVRInternalReserved_Start = 1000u;

		[Token(Token = "0x4000513")]
		public const uint k_unOpenVRInternalReserved_End = 10000u;

		[Token(Token = "0x4000514")]
		public const uint k_unMaxPropertyStringSize = 32768u;

		[Token(Token = "0x4000515")]
		public const uint k_unControllerStateAxisCount = 5u;

		[Token(Token = "0x4000516")]
		public const ulong k_ulOverlayHandleInvalid = 0uL;

		[Token(Token = "0x4000517")]
		public const uint k_unScreenshotHandleInvalid = 0u;

		[Token(Token = "0x4000518")]
		public const string IVRSystem_Version = "IVRSystem_016";

		[Token(Token = "0x4000519")]
		public const string IVRExtendedDisplay_Version = "IVRExtendedDisplay_001";

		[Token(Token = "0x400051A")]
		public const string IVRTrackedCamera_Version = "IVRTrackedCamera_003";

		[Token(Token = "0x400051B")]
		public const uint k_unMaxApplicationKeyLength = 128u;

		[Token(Token = "0x400051C")]
		public const string k_pch_MimeType_HomeApp = "vr/home";

		[Token(Token = "0x400051D")]
		public const string k_pch_MimeType_GameTheater = "vr/game_theater";

		[Token(Token = "0x400051E")]
		public const string IVRApplications_Version = "IVRApplications_006";

		[Token(Token = "0x400051F")]
		public const string IVRChaperone_Version = "IVRChaperone_003";

		[Token(Token = "0x4000520")]
		public const string IVRChaperoneSetup_Version = "IVRChaperoneSetup_005";

		[Token(Token = "0x4000521")]
		public const string IVRCompositor_Version = "IVRCompositor_020";

		[Token(Token = "0x4000522")]
		public const uint k_unVROverlayMaxKeyLength = 128u;

		[Token(Token = "0x4000523")]
		public const uint k_unVROverlayMaxNameLength = 128u;

		[Token(Token = "0x4000524")]
		public const uint k_unMaxOverlayCount = 64u;

		[Token(Token = "0x4000525")]
		public const uint k_unMaxOverlayIntersectionMaskPrimitivesCount = 32u;

		[Token(Token = "0x4000526")]
		public const string IVROverlay_Version = "IVROverlay_016";

		[Token(Token = "0x4000527")]
		public const string k_pch_Controller_Component_GDC2015 = "gdc2015";

		[Token(Token = "0x4000528")]
		public const string k_pch_Controller_Component_Base = "base";

		[Token(Token = "0x4000529")]
		public const string k_pch_Controller_Component_Tip = "tip";

		[Token(Token = "0x400052A")]
		public const string k_pch_Controller_Component_HandGrip = "handgrip";

		[Token(Token = "0x400052B")]
		public const string k_pch_Controller_Component_Status = "status";

		[Token(Token = "0x400052C")]
		public const string IVRRenderModels_Version = "IVRRenderModels_005";

		[Token(Token = "0x400052D")]
		public const uint k_unNotificationTextMaxSize = 256u;

		[Token(Token = "0x400052E")]
		public const string IVRNotifications_Version = "IVRNotifications_002";

		[Token(Token = "0x400052F")]
		public const uint k_unMaxSettingsKeyLength = 128u;

		[Token(Token = "0x4000530")]
		public const string IVRSettings_Version = "IVRSettings_002";

		[Token(Token = "0x4000531")]
		public const string k_pch_SteamVR_Section = "steamvr";

		[Token(Token = "0x4000532")]
		public const string k_pch_SteamVR_RequireHmd_String = "requireHmd";

		[Token(Token = "0x4000533")]
		public const string k_pch_SteamVR_ForcedDriverKey_String = "forcedDriver";

		[Token(Token = "0x4000534")]
		public const string k_pch_SteamVR_ForcedHmdKey_String = "forcedHmd";

		[Token(Token = "0x4000535")]
		public const string k_pch_SteamVR_DisplayDebug_Bool = "displayDebug";

		[Token(Token = "0x4000536")]
		public const string k_pch_SteamVR_DebugProcessPipe_String = "debugProcessPipe";

		[Token(Token = "0x4000537")]
		public const string k_pch_SteamVR_DisplayDebugX_Int32 = "displayDebugX";

		[Token(Token = "0x4000538")]
		public const string k_pch_SteamVR_DisplayDebugY_Int32 = "displayDebugY";

		[Token(Token = "0x4000539")]
		public const string k_pch_SteamVR_SendSystemButtonToAllApps_Bool = "sendSystemButtonToAllApps";

		[Token(Token = "0x400053A")]
		public const string k_pch_SteamVR_LogLevel_Int32 = "loglevel";

		[Token(Token = "0x400053B")]
		public const string k_pch_SteamVR_IPD_Float = "ipd";

		[Token(Token = "0x400053C")]
		public const string k_pch_SteamVR_Background_String = "background";

		[Token(Token = "0x400053D")]
		public const string k_pch_SteamVR_BackgroundUseDomeProjection_Bool = "backgroundUseDomeProjection";

		[Token(Token = "0x400053E")]
		public const string k_pch_SteamVR_BackgroundCameraHeight_Float = "backgroundCameraHeight";

		[Token(Token = "0x400053F")]
		public const string k_pch_SteamVR_BackgroundDomeRadius_Float = "backgroundDomeRadius";

		[Token(Token = "0x4000540")]
		public const string k_pch_SteamVR_GridColor_String = "gridColor";

		[Token(Token = "0x4000541")]
		public const string k_pch_SteamVR_PlayAreaColor_String = "playAreaColor";

		[Token(Token = "0x4000542")]
		public const string k_pch_SteamVR_ShowStage_Bool = "showStage";

		[Token(Token = "0x4000543")]
		public const string k_pch_SteamVR_ActivateMultipleDrivers_Bool = "activateMultipleDrivers";

		[Token(Token = "0x4000544")]
		public const string k_pch_SteamVR_DirectMode_Bool = "directMode";

		[Token(Token = "0x4000545")]
		public const string k_pch_SteamVR_DirectModeEdidVid_Int32 = "directModeEdidVid";

		[Token(Token = "0x4000546")]
		public const string k_pch_SteamVR_DirectModeEdidPid_Int32 = "directModeEdidPid";

		[Token(Token = "0x4000547")]
		public const string k_pch_SteamVR_UsingSpeakers_Bool = "usingSpeakers";

		[Token(Token = "0x4000548")]
		public const string k_pch_SteamVR_SpeakersForwardYawOffsetDegrees_Float = "speakersForwardYawOffsetDegrees";

		[Token(Token = "0x4000549")]
		public const string k_pch_SteamVR_BaseStationPowerManagement_Bool = "basestationPowerManagement";

		[Token(Token = "0x400054A")]
		public const string k_pch_SteamVR_NeverKillProcesses_Bool = "neverKillProcesses";

		[Token(Token = "0x400054B")]
		public const string k_pch_SteamVR_SupersampleScale_Float = "supersampleScale";

		[Token(Token = "0x400054C")]
		public const string k_pch_SteamVR_AllowAsyncReprojection_Bool = "allowAsyncReprojection";

		[Token(Token = "0x400054D")]
		public const string k_pch_SteamVR_AllowReprojection_Bool = "allowInterleavedReprojection";

		[Token(Token = "0x400054E")]
		public const string k_pch_SteamVR_ForceReprojection_Bool = "forceReprojection";

		[Token(Token = "0x400054F")]
		public const string k_pch_SteamVR_ForceFadeOnBadTracking_Bool = "forceFadeOnBadTracking";

		[Token(Token = "0x4000550")]
		public const string k_pch_SteamVR_DefaultMirrorView_Int32 = "defaultMirrorView";

		[Token(Token = "0x4000551")]
		public const string k_pch_SteamVR_ShowMirrorView_Bool = "showMirrorView";

		[Token(Token = "0x4000552")]
		public const string k_pch_SteamVR_MirrorViewGeometry_String = "mirrorViewGeometry";

		[Token(Token = "0x4000553")]
		public const string k_pch_SteamVR_StartMonitorFromAppLaunch = "startMonitorFromAppLaunch";

		[Token(Token = "0x4000554")]
		public const string k_pch_SteamVR_StartCompositorFromAppLaunch_Bool = "startCompositorFromAppLaunch";

		[Token(Token = "0x4000555")]
		public const string k_pch_SteamVR_StartDashboardFromAppLaunch_Bool = "startDashboardFromAppLaunch";

		[Token(Token = "0x4000556")]
		public const string k_pch_SteamVR_StartOverlayAppsFromDashboard_Bool = "startOverlayAppsFromDashboard";

		[Token(Token = "0x4000557")]
		public const string k_pch_SteamVR_EnableHomeApp = "enableHomeApp";

		[Token(Token = "0x4000558")]
		public const string k_pch_SteamVR_CycleBackgroundImageTimeSec_Int32 = "CycleBackgroundImageTimeSec";

		[Token(Token = "0x4000559")]
		public const string k_pch_SteamVR_RetailDemo_Bool = "retailDemo";

		[Token(Token = "0x400055A")]
		public const string k_pch_SteamVR_IpdOffset_Float = "ipdOffset";

		[Token(Token = "0x400055B")]
		public const string k_pch_SteamVR_AllowSupersampleFiltering_Bool = "allowSupersampleFiltering";

		[Token(Token = "0x400055C")]
		public const string k_pch_Lighthouse_Section = "driver_lighthouse";

		[Token(Token = "0x400055D")]
		public const string k_pch_Lighthouse_DisableIMU_Bool = "disableimu";

		[Token(Token = "0x400055E")]
		public const string k_pch_Lighthouse_UseDisambiguation_String = "usedisambiguation";

		[Token(Token = "0x400055F")]
		public const string k_pch_Lighthouse_DisambiguationDebug_Int32 = "disambiguationdebug";

		[Token(Token = "0x4000560")]
		public const string k_pch_Lighthouse_PrimaryBasestation_Int32 = "primarybasestation";

		[Token(Token = "0x4000561")]
		public const string k_pch_Lighthouse_DBHistory_Bool = "dbhistory";

		[Token(Token = "0x4000562")]
		public const string k_pch_Null_Section = "driver_null";

		[Token(Token = "0x4000563")]
		public const string k_pch_Null_SerialNumber_String = "serialNumber";

		[Token(Token = "0x4000564")]
		public const string k_pch_Null_ModelNumber_String = "modelNumber";

		[Token(Token = "0x4000565")]
		public const string k_pch_Null_WindowX_Int32 = "windowX";

		[Token(Token = "0x4000566")]
		public const string k_pch_Null_WindowY_Int32 = "windowY";

		[Token(Token = "0x4000567")]
		public const string k_pch_Null_WindowWidth_Int32 = "windowWidth";

		[Token(Token = "0x4000568")]
		public const string k_pch_Null_WindowHeight_Int32 = "windowHeight";

		[Token(Token = "0x4000569")]
		public const string k_pch_Null_RenderWidth_Int32 = "renderWidth";

		[Token(Token = "0x400056A")]
		public const string k_pch_Null_RenderHeight_Int32 = "renderHeight";

		[Token(Token = "0x400056B")]
		public const string k_pch_Null_SecondsFromVsyncToPhotons_Float = "secondsFromVsyncToPhotons";

		[Token(Token = "0x400056C")]
		public const string k_pch_Null_DisplayFrequency_Float = "displayFrequency";

		[Token(Token = "0x400056D")]
		public const string k_pch_UserInterface_Section = "userinterface";

		[Token(Token = "0x400056E")]
		public const string k_pch_UserInterface_StatusAlwaysOnTop_Bool = "StatusAlwaysOnTop";

		[Token(Token = "0x400056F")]
		public const string k_pch_UserInterface_MinimizeToTray_Bool = "MinimizeToTray";

		[Token(Token = "0x4000570")]
		public const string k_pch_UserInterface_Screenshots_Bool = "screenshots";

		[Token(Token = "0x4000571")]
		public const string k_pch_UserInterface_ScreenshotType_Int = "screenshotType";

		[Token(Token = "0x4000572")]
		public const string k_pch_Notifications_Section = "notifications";

		[Token(Token = "0x4000573")]
		public const string k_pch_Notifications_DoNotDisturb_Bool = "DoNotDisturb";

		[Token(Token = "0x4000574")]
		public const string k_pch_Keyboard_Section = "keyboard";

		[Token(Token = "0x4000575")]
		public const string k_pch_Keyboard_TutorialCompletions = "TutorialCompletions";

		[Token(Token = "0x4000576")]
		public const string k_pch_Keyboard_ScaleX = "ScaleX";

		[Token(Token = "0x4000577")]
		public const string k_pch_Keyboard_ScaleY = "ScaleY";

		[Token(Token = "0x4000578")]
		public const string k_pch_Keyboard_OffsetLeftX = "OffsetLeftX";

		[Token(Token = "0x4000579")]
		public const string k_pch_Keyboard_OffsetRightX = "OffsetRightX";

		[Token(Token = "0x400057A")]
		public const string k_pch_Keyboard_OffsetY = "OffsetY";

		[Token(Token = "0x400057B")]
		public const string k_pch_Keyboard_Smoothing = "Smoothing";

		[Token(Token = "0x400057C")]
		public const string k_pch_Perf_Section = "perfcheck";

		[Token(Token = "0x400057D")]
		public const string k_pch_Perf_HeuristicActive_Bool = "heuristicActive";

		[Token(Token = "0x400057E")]
		public const string k_pch_Perf_NotifyInHMD_Bool = "warnInHMD";

		[Token(Token = "0x400057F")]
		public const string k_pch_Perf_NotifyOnlyOnce_Bool = "warnOnlyOnce";

		[Token(Token = "0x4000580")]
		public const string k_pch_Perf_AllowTimingStore_Bool = "allowTimingStore";

		[Token(Token = "0x4000581")]
		public const string k_pch_Perf_SaveTimingsOnExit_Bool = "saveTimingsOnExit";

		[Token(Token = "0x4000582")]
		public const string k_pch_Perf_TestData_Float = "perfTestData";

		[Token(Token = "0x4000583")]
		public const string k_pch_Perf_LinuxGPUProfiling_Bool = "linuxGPUProfiling";

		[Token(Token = "0x4000584")]
		public const string k_pch_CollisionBounds_Section = "collisionBounds";

		[Token(Token = "0x4000585")]
		public const string k_pch_CollisionBounds_Style_Int32 = "CollisionBoundsStyle";

		[Token(Token = "0x4000586")]
		public const string k_pch_CollisionBounds_GroundPerimeterOn_Bool = "CollisionBoundsGroundPerimeterOn";

		[Token(Token = "0x4000587")]
		public const string k_pch_CollisionBounds_CenterMarkerOn_Bool = "CollisionBoundsCenterMarkerOn";

		[Token(Token = "0x4000588")]
		public const string k_pch_CollisionBounds_PlaySpaceOn_Bool = "CollisionBoundsPlaySpaceOn";

		[Token(Token = "0x4000589")]
		public const string k_pch_CollisionBounds_FadeDistance_Float = "CollisionBoundsFadeDistance";

		[Token(Token = "0x400058A")]
		public const string k_pch_CollisionBounds_ColorGammaR_Int32 = "CollisionBoundsColorGammaR";

		[Token(Token = "0x400058B")]
		public const string k_pch_CollisionBounds_ColorGammaG_Int32 = "CollisionBoundsColorGammaG";

		[Token(Token = "0x400058C")]
		public const string k_pch_CollisionBounds_ColorGammaB_Int32 = "CollisionBoundsColorGammaB";

		[Token(Token = "0x400058D")]
		public const string k_pch_CollisionBounds_ColorGammaA_Int32 = "CollisionBoundsColorGammaA";

		[Token(Token = "0x400058E")]
		public const string k_pch_Camera_Section = "camera";

		[Token(Token = "0x400058F")]
		public const string k_pch_Camera_EnableCamera_Bool = "enableCamera";

		[Token(Token = "0x4000590")]
		public const string k_pch_Camera_EnableCameraInDashboard_Bool = "enableCameraInDashboard";

		[Token(Token = "0x4000591")]
		public const string k_pch_Camera_EnableCameraForCollisionBounds_Bool = "enableCameraForCollisionBounds";

		[Token(Token = "0x4000592")]
		public const string k_pch_Camera_EnableCameraForRoomView_Bool = "enableCameraForRoomView";

		[Token(Token = "0x4000593")]
		public const string k_pch_Camera_BoundsColorGammaR_Int32 = "cameraBoundsColorGammaR";

		[Token(Token = "0x4000594")]
		public const string k_pch_Camera_BoundsColorGammaG_Int32 = "cameraBoundsColorGammaG";

		[Token(Token = "0x4000595")]
		public const string k_pch_Camera_BoundsColorGammaB_Int32 = "cameraBoundsColorGammaB";

		[Token(Token = "0x4000596")]
		public const string k_pch_Camera_BoundsColorGammaA_Int32 = "cameraBoundsColorGammaA";

		[Token(Token = "0x4000597")]
		public const string k_pch_Camera_BoundsStrength_Int32 = "cameraBoundsStrength";

		[Token(Token = "0x4000598")]
		public const string k_pch_audio_Section = "audio";

		[Token(Token = "0x4000599")]
		public const string k_pch_audio_OnPlaybackDevice_String = "onPlaybackDevice";

		[Token(Token = "0x400059A")]
		public const string k_pch_audio_OnRecordDevice_String = "onRecordDevice";

		[Token(Token = "0x400059B")]
		public const string k_pch_audio_OnPlaybackMirrorDevice_String = "onPlaybackMirrorDevice";

		[Token(Token = "0x400059C")]
		public const string k_pch_audio_OffPlaybackDevice_String = "offPlaybackDevice";

		[Token(Token = "0x400059D")]
		public const string k_pch_audio_OffRecordDevice_String = "offRecordDevice";

		[Token(Token = "0x400059E")]
		public const string k_pch_audio_VIVEHDMIGain = "viveHDMIGain";

		[Token(Token = "0x400059F")]
		public const string k_pch_Power_Section = "power";

		[Token(Token = "0x40005A0")]
		public const string k_pch_Power_PowerOffOnExit_Bool = "powerOffOnExit";

		[Token(Token = "0x40005A1")]
		public const string k_pch_Power_TurnOffScreensTimeout_Float = "turnOffScreensTimeout";

		[Token(Token = "0x40005A2")]
		public const string k_pch_Power_TurnOffControllersTimeout_Float = "turnOffControllersTimeout";

		[Token(Token = "0x40005A3")]
		public const string k_pch_Power_ReturnToWatchdogTimeout_Float = "returnToWatchdogTimeout";

		[Token(Token = "0x40005A4")]
		public const string k_pch_Power_AutoLaunchSteamVROnButtonPress = "autoLaunchSteamVROnButtonPress";

		[Token(Token = "0x40005A5")]
		public const string k_pch_Dashboard_Section = "dashboard";

		[Token(Token = "0x40005A6")]
		public const string k_pch_Dashboard_EnableDashboard_Bool = "enableDashboard";

		[Token(Token = "0x40005A7")]
		public const string k_pch_Dashboard_ArcadeMode_Bool = "arcadeMode";

		[Token(Token = "0x40005A8")]
		public const string k_pch_modelskin_Section = "modelskins";

		[Token(Token = "0x40005A9")]
		public const string k_pch_Driver_Enable_Bool = "enable";

		[Token(Token = "0x40005AA")]
		public const string IVRScreenshots_Version = "IVRScreenshots_001";

		[Token(Token = "0x40005AB")]
		public const string IVRResources_Version = "IVRResources_001";

		[Token(Token = "0x40005AC")]
		public const string IVRDriverManager_Version = "IVRDriverManager_001";

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x78F318", Offset = "0x78F318")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x78F318", Offset = "0x78F318")]
		private static uint <VRToken>k__BackingField;

		[Token(Token = "0x40005AE")]
		private const string FnTable_Prefix = "FnTable:";

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static COpenVRContext _OpenVRInternal_ModuleContext;

		[Token(Token = "0x17000003")]
		private static uint VRToken
		{
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x18A5D94", Offset = "0x18A5D94", VA = "0x18A5D94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x78F354", Offset = "0x78F354")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x18A5DFC", Offset = "0x18A5DFC", VA = "0x18A5DFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x78F364", Offset = "0x78F364")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		private static COpenVRContext OpenVRInternal_ModuleContext
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x18A5E68", Offset = "0x18A5E68", VA = "0x18A5E68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public static CVRSystem System
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x18A5F78", Offset = "0x18A5F78", VA = "0x18A5F78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public static CVRChaperone Chaperone
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x18A60B8", Offset = "0x18A60B8", VA = "0x18A60B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		public static CVRChaperoneSetup ChaperoneSetup
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x18A61F8", Offset = "0x18A61F8", VA = "0x18A61F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		public static CVRCompositor Compositor
		{
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x18A6338", Offset = "0x18A6338", VA = "0x18A6338")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static CVROverlay Overlay
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x18A6478", Offset = "0x18A6478", VA = "0x18A6478")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		public static CVRRenderModels RenderModels
		{
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x18A65B8", Offset = "0x18A65B8", VA = "0x18A65B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		public static CVRExtendedDisplay ExtendedDisplay
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x18A66F8", Offset = "0x18A66F8", VA = "0x18A66F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		public static CVRSettings Settings
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x18A6838", Offset = "0x18A6838", VA = "0x18A6838")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public static CVRApplications Applications
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x18A6978", Offset = "0x18A6978", VA = "0x18A6978")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		public static CVRScreenshots Screenshots
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x18A6AB8", Offset = "0x18A6AB8", VA = "0x18A6AB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public static CVRTrackedCamera TrackedCamera
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x18A6BF8", Offset = "0x18A6BF8", VA = "0x18A6BF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x18A5810", Offset = "0x18A5810", VA = "0x18A5810")]
		public OpenVR()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x18A5818", Offset = "0x18A5818", VA = "0x18A5818")]
		public static uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType)
		{
			return default(uint);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x18A58C4", Offset = "0x18A58C4", VA = "0x18A58C4")]
		public static void ShutdownInternal()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x18A5950", Offset = "0x18A5950", VA = "0x18A5950")]
		public static bool IsHmdPresent()
		{
			return default(bool);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x18A59E4", Offset = "0x18A59E4", VA = "0x18A59E4")]
		public static bool IsRuntimeInstalled()
		{
			return default(bool);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x18A5A78", Offset = "0x18A5A78", VA = "0x18A5A78")]
		public static string GetStringForHmdError(EVRInitError error)
		{
			return null;
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x18A5B8C", Offset = "0x18A5B8C", VA = "0x18A5B8C")]
		public static IntPtr GetGenericInterface(string pchInterfaceVersion, ref EVRInitError peError)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x18A5C50", Offset = "0x18A5C50", VA = "0x18A5C50")]
		public static bool IsInterfaceVersionValid(string pchInterfaceVersion)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x18A5D08", Offset = "0x18A5D08", VA = "0x18A5D08")]
		public static uint GetInitToken()
		{
			return default(uint);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x18A6D38", Offset = "0x18A6D38", VA = "0x18A6D38")]
		public static CVRSystem Init(ref EVRInitError peError, EVRApplicationType eApplicationType = EVRApplicationType.VRApplication_Scene)
		{
			return null;
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x18A6E88", Offset = "0x18A6E88", VA = "0x18A6E88")]
		public static void Shutdown()
		{
		}
	}
}
namespace RelationsInspector.Backend.AutoBackend
{
	[Token(Token = "0x20001B7")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x78F374", Offset = "0x78F374")]
	public class AutoBackendAttribute : Attribute
	{
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xEBC3D8", Offset = "0xEBC3D8", VA = "0xEBC3D8")]
		public AutoBackendAttribute()
		{
		}
	}
	[Token(Token = "0x20001B8")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x78F388", Offset = "0x78F388")]
	public class RelatedAttribute : Attribute
	{
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xEBC3E0", Offset = "0xEBC3E0", VA = "0xEBC3E0")]
		public RelatedAttribute()
		{
		}
	}
	[Token(Token = "0x20001B9")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x78F39C", Offset = "0x78F39C")]
	public class RelatingAttribute : Attribute
	{
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xEBC3E8", Offset = "0xEBC3E8", VA = "0xEBC3E8")]
		public RelatingAttribute()
		{
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x20001BA")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x78F3B0", Offset = "0x78F3B0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x78F3B0", Offset = "0x78F3B0")]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x20001BB")]
		public enum BlurType
		{
			[Token(Token = "0x40005C3")]
			StandardGauss,
			[Token(Token = "0x40005C4")]
			SgxGauss
		}

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x78F448", Offset = "0x78F448")]
		public float amount;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x78F460", Offset = "0x78F460")]
		public int downsample;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x78F478", Offset = "0x78F478")]
		public float blurSize;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x78F490", Offset = "0x78F490")]
		public int blurIterations;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BlurType blurType;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader blurShader;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material blurMaterial;

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xEBC3F0", Offset = "0xEBC3F0", VA = "0xEBC3F0")]
		public BlurOptimized()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xEBC48C", Offset = "0xEBC48C", VA = "0xEBC48C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xEBCB70", Offset = "0xEBCB70", VA = "0xEBCB70")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xEBCC28", Offset = "0xEBCC28", VA = "0xEBCC28")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
	[Token(Token = "0x20001BC")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x78F4A8", Offset = "0x78F4A8")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x78F4F4", Offset = "0x78F4F4")]
		public float amount;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture textureRamp;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x78F50C", Offset = "0x78F50C")]
		public float rampOffset;

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xEBD098", Offset = "0xEBD098", VA = "0xEBD098")]
		public Grayscale()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xEBD0A8", Offset = "0xEBD0A8", VA = "0xEBD0A8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
	[Token(Token = "0x20001BD")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x78F524", Offset = "0x78F524")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x78F524", Offset = "0x78F524")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x17000010")]
		protected Material material
		{
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0xEBD1E8", Offset = "0xEBD1E8", VA = "0xEBD1E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xEBD0A0", Offset = "0xEBD0A0", VA = "0xEBD0A0")]
		public ImageEffectBase()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xEBD2B0", Offset = "0xEBD2B0", VA = "0xEBD2B0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xEBD374", Offset = "0xEBD374", VA = "0xEBD374", Slot = "5")]
		protected virtual void OnDisable()
		{
		}
	}
	[Token(Token = "0x20001BE")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x78F5AC", Offset = "0x78F5AC")]
	public class ImageEffects
	{
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xEBD42C", Offset = "0xEBD42C", VA = "0xEBD42C")]
		public ImageEffects()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xEBD434", Offset = "0xEBD434", VA = "0xEBD434")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xEBD6C8", Offset = "0xEBD6C8", VA = "0xEBD6C8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x78F5E4", Offset = "0x78F5E4")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xEBD744", Offset = "0xEBD744", VA = "0xEBD744")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x78F61C", Offset = "0x78F61C")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}
	}
	[Token(Token = "0x20001BF")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x78F654", Offset = "0x78F654")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Material> createdMaterials;

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xEBC410", Offset = "0xEBC410", VA = "0xEBC410")]
		public PostEffectsBase()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xEBC620", Offset = "0xEBC620", VA = "0xEBC620")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xEBD7F4", Offset = "0xEBD7F4", VA = "0xEBD7F4")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xEBDA20", Offset = "0xEBDA20", VA = "0xEBDA20")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xEBDA2C", Offset = "0xEBDA2C", VA = "0xEBDA2C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xEBDA30", Offset = "0xEBDA30", VA = "0xEBDA30")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xEBDB24", Offset = "0xEBDB24", VA = "0xEBDB24")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xEBDB2C", Offset = "0xEBDB2C", VA = "0xEBDB2C", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xEBDC08", Offset = "0xEBDC08", VA = "0xEBDC08")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xEBC4DC", Offset = "0xEBC4DC", VA = "0xEBC4DC")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xEBDC14", Offset = "0xEBDC14", VA = "0xEBDC14")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xEBDC70", Offset = "0xEBDC70", VA = "0xEBDC70")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xEBCA9C", Offset = "0xEBCA9C", VA = "0xEBCA9C")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xEBDC78", Offset = "0xEBDC78", VA = "0xEBDC78")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xEBD7C8", Offset = "0xEBD7C8", VA = "0xEBD7C8")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xEBDF1C", Offset = "0xEBDF1C", VA = "0xEBDF1C")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}
	}
	[Token(Token = "0x20001C0")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x78F6C8", Offset = "0x78F6C8")]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x6000610")]
		[Address(RVA = "0xEBE338", Offset = "0xEBE338", VA = "0xEBE338")]
		public PostEffectsHelper()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xEBE340", Offset = "0xEBE340", VA = "0xEBE340")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xEBE3B0", Offset = "0xEBE3B0", VA = "0xEBE3B0")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xEBE67C", Offset = "0xEBE67C", VA = "0xEBE67C")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xEBEA98", Offset = "0xEBEA98", VA = "0xEBEA98")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}
	}
	[Token(Token = "0x20001C1")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x78F73C", Offset = "0x78F73C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x78F73C", Offset = "0x78F73C")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x20001C2")]
		public enum AberrationMode
		{
			[Token(Token = "0x40005DD")]
			Simple,
			[Token(Token = "0x40005DE")]
			Advanced
		}

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AberrationMode mode;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float chromaticAberration;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float axialAberration;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float blur;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float blurSpread;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float luminanceDependency;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float blurDistance;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader vignetteShader;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader separableBlurShader;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader chromAberrationShader;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xEBEC8C", Offset = "0xEBEC8C", VA = "0xEBEC8C")]
		public VignetteAndChromaticAberration()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xEBECC0", Offset = "0xEBECC0", VA = "0xEBECC0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xEBED3C", Offset = "0xEBED3C", VA = "0xEBED3C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
