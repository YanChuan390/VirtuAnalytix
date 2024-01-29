using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using PlayFab.Internal;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.CrossPlatformInput.PlatformSpecific;

[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
[assembly: AssemblyVersion("0.0.0.0")]
[module: UnverifiableCode]
namespace PlayFab
{
	public class PlayFabAndroidPlugin
	{
		private static bool Initted;

		private static AndroidJavaClass AndroidPlugin;

		private static AndroidJavaClass PlayServicesUtils;

		public static bool isAvailable()
		{
			return true;
		}

		public static void init()
		{
			if (!Initted)
			{
				PlayFabPluginEventHandler.init();
				AndroidPlugin = new AndroidJavaClass("com.playfab.unity.plugin.AndroidPlugin");
				AndroidPlugin.CallStatic("init");
				PlayServicesUtils = new AndroidJavaClass("com.playfab.unity.plugin.PlayServicesUtils");
				PlayFabGoogleCloudMessaging.init();
				Initted = true;
			}
		}

		public static bool isPlayServicesAvailable()
		{
			return PlayServicesUtils.CallStatic<bool>("isPlayServicesAvailable", new object[0]);
		}
	}
	public class PlayFabGoogleCloudMessaging
	{
		public delegate void GCMRegisterComplete(string id, string error);

		public delegate void GCMMessageReceived(string message);

		private static GCMRegisterComplete RegistrationCallback;

		private static GCMMessageReceived MessageCallbackEvent;

		private static AndroidJavaClass PlayFabGCMClass;

		public static void addMessageListener(GCMMessageReceived listener)
		{
			MessageCallbackEvent = (GCMMessageReceived)Delegate.Combine(MessageCallbackEvent, listener);
		}

		public static void removeMessageListener(GCMMessageReceived listener)
		{
			MessageCallbackEvent = (GCMMessageReceived)Delegate.Remove(MessageCallbackEvent, listener);
		}

		public static void init()
		{
			PlayFabGCMClass = new AndroidJavaClass("com.playfab.unity.plugin.GoogleCloudMessaging");
		}

		public static void registerAsync(string senderId, GCMRegisterComplete callback)
		{
			if (RegistrationCallback != null)
			{
				throw new Exception("GCM Registration already in progress");
			}
			RegistrationCallback = callback;
			PlayFabGCMClass.CallStatic("registerInBackground", senderId);
		}

		public static bool isRegistered()
		{
			return getRegistrationId() != null;
		}

		public static string getRegistrationId()
		{
			return PlayFabGCMClass.CallStatic<string>("getRegistrationId", new object[0]);
		}

		public static void unregister()
		{
			PlayFabGCMClass.CallStatic("unregister");
		}

		public static void cancelAllNotifications()
		{
			PlayFabGCMClass.CallStatic("cancelAllNotifications");
		}

		public static void cancelNotification(int id)
		{
			PlayFabGCMClass.CallStatic("cancelNotification", id);
		}

		internal static void registrationComplete(string id, string error)
		{
			if (RegistrationCallback != null)
			{
				RegistrationCallback(id, error);
				RegistrationCallback = null;
			}
		}

		internal static void messageReceived(string message)
		{
			if (MessageCallbackEvent != null)
			{
				MessageCallbackEvent(message);
			}
		}
	}
}
namespace PlayFab.Internal
{
	public class PlayFabPluginEventHandler : MonoBehaviour
	{
		private static PlayFabPluginEventHandler PlayFabGO;

		private Dictionary<int, Action<string, string>> HttpHandlers = new Dictionary<int, Action<string, string>>();

		public static void init()
		{
			if (!(PlayFabGO != null))
			{
				GameObject gameObject = GameObject.Find("_PlayFabGO");
				if (gameObject == null)
				{
					gameObject = new GameObject("_PlayFabGO");
				}
				UnityEngine.Object.DontDestroyOnLoad(gameObject);
				PlayFabGO = gameObject.GetComponent<PlayFabPluginEventHandler>();
				if (PlayFabGO == null)
				{
					PlayFabGO = gameObject.AddComponent<PlayFabPluginEventHandler>();
				}
			}
		}

		public void GCMRegistered(string id)
		{
			PlayFabGoogleCloudMessaging.registrationComplete(id, null);
		}

		public void GCMRegisterError(string error)
		{
			PlayFabGoogleCloudMessaging.registrationComplete(null, error);
		}

		public void GCMMessageReceived(string message)
		{
			PlayFabGoogleCloudMessaging.messageReceived(message);
		}

		public static void addHttpDelegate(int id, Action<string, string> callback)
		{
			init();
			if (callback != null)
			{
				PlayFabGO.HttpHandlers.Add(id, callback);
			}
		}

		public void OnHttpError(string response)
		{
			try
			{
				string[] array = response.Split(":".ToCharArray(), 2);
				int key = int.Parse(array[0]);
				HttpHandlers[key]?.Invoke(null, array[1]);
				HttpHandlers.Remove(key);
			}
			catch (Exception ex)
			{
				Debug.LogError("Error handling HTTP Error: " + ex);
			}
		}

		public void OnHttpResponse(string response)
		{
			try
			{
				string[] array = response.Split(":".ToCharArray(), 2);
				int key = int.Parse(array[0]);
				HttpHandlers[key]?.Invoke(array[1], null);
				HttpHandlers.Remove(key);
			}
			catch (Exception ex)
			{
				Debug.LogError("Error handling HTTP request: " + ex);
			}
		}
	}
}
namespace Valve.VR
{
	public struct IVRSystem
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetRecommendedRenderTargetSize(ref uint pnWidth, ref uint pnHeight);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate HmdMatrix44_t _GetProjectionMatrix(EVREye eEye, float fNearZ, float fFarZ, EGraphicsAPIConvention eProjType);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetProjectionRaw(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate DistortionCoordinates_t _ComputeDistortion(EVREye eEye, float fU, float fV);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate HmdMatrix34_t _GetEyeToHeadTransform(EVREye eEye);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate int _GetD3D9AdapterIndex();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsDisplayOnDesktop();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _SetDisplayVisibility(bool bIsVisibleOnDesktop);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, [In][Out] TrackedDevicePose_t[] pTrackedDevicePoseArray, uint unTrackedDevicePoseArrayCount);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ResetSeatedZeroPose();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate HmdMatrix34_t _GetSeatedZeroPoseToStandingAbsoluteTrackingPose();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate HmdMatrix34_t _GetRawZeroPoseToStandingAbsoluteTrackingPose();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass eTrackedDeviceClass, [In][Out] uint[] punTrackedDeviceIndexArray, uint unTrackedDeviceIndexArrayCount, uint unRelativeToTrackedDeviceIndex);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EDeviceActivityLevel _GetTrackedDeviceActivityLevel(uint unDeviceId);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ApplyTransform(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole unDeviceType);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ETrackedControllerRole _GetControllerRoleForTrackedDeviceIndex(uint unDeviceIndex);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ETrackedDeviceClass _GetTrackedDeviceClass(uint unDeviceIndex);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsTrackedDeviceConnected(uint unDeviceIndex);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetBoolTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate float _GetFloatTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate int _GetInt32TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ulong _GetUint64TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate HmdMatrix34_t _GetMatrix34TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetStringTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetPropErrorNameFromEnum(ETrackedPropertyError error);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _PollNextEvent(ref VREvent_t pEvent, uint uncbVREvent);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _PollNextEventWithPose(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetEventTypeNameFromEnum(EVREventType eType);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate HiddenAreaMesh_t _GetHiddenAreaMesh(EVREye eEye);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetControllerState(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, ref TrackedDevicePose_t pTrackedDevicePose);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _TriggerHapticPulse(uint unControllerDeviceIndex, uint unAxisId, char usDurationMicroSec);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetButtonIdNameFromEnum(EVRButtonId eButtonId);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _CaptureInputFocus();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ReleaseInputFocus();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsInputFocusCapturedByAnotherProcess();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _DriverDebugRequest(uint unDeviceIndex, string pchRequest, string pchResponseBuffer, uint unResponseBufferSize);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRFirmwareError _PerformFirmwareUpdate(uint unDeviceIndex);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _AcknowledgeQuit_Exiting();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _AcknowledgeQuit_UserPrompt();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _PerformanceTestEnableCapture(bool bEnable);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _PerformanceTestReportFidelityLevelChange(int nFidelityLevel);

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetRecommendedRenderTargetSize GetRecommendedRenderTargetSize;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetProjectionMatrix GetProjectionMatrix;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetProjectionRaw GetProjectionRaw;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ComputeDistortion ComputeDistortion;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetEyeToHeadTransform GetEyeToHeadTransform;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetTimeSinceLastVsync GetTimeSinceLastVsync;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetD3D9AdapterIndex GetD3D9AdapterIndex;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetDXGIOutputInfo GetDXGIOutputInfo;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsDisplayOnDesktop IsDisplayOnDesktop;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetDisplayVisibility SetDisplayVisibility;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetDeviceToAbsoluteTrackingPose GetDeviceToAbsoluteTrackingPose;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ResetSeatedZeroPose ResetSeatedZeroPose;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetSeatedZeroPoseToStandingAbsoluteTrackingPose GetSeatedZeroPoseToStandingAbsoluteTrackingPose;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetRawZeroPoseToStandingAbsoluteTrackingPose GetRawZeroPoseToStandingAbsoluteTrackingPose;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetSortedTrackedDeviceIndicesOfClass GetSortedTrackedDeviceIndicesOfClass;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetTrackedDeviceActivityLevel GetTrackedDeviceActivityLevel;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ApplyTransform ApplyTransform;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetTrackedDeviceIndexForControllerRole GetTrackedDeviceIndexForControllerRole;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetControllerRoleForTrackedDeviceIndex GetControllerRoleForTrackedDeviceIndex;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetTrackedDeviceClass GetTrackedDeviceClass;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsTrackedDeviceConnected IsTrackedDeviceConnected;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetBoolTrackedDeviceProperty GetBoolTrackedDeviceProperty;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetFloatTrackedDeviceProperty GetFloatTrackedDeviceProperty;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetInt32TrackedDeviceProperty GetInt32TrackedDeviceProperty;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetUint64TrackedDeviceProperty GetUint64TrackedDeviceProperty;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetMatrix34TrackedDeviceProperty GetMatrix34TrackedDeviceProperty;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetStringTrackedDeviceProperty GetStringTrackedDeviceProperty;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetPropErrorNameFromEnum GetPropErrorNameFromEnum;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _PollNextEvent PollNextEvent;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _PollNextEventWithPose PollNextEventWithPose;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetEventTypeNameFromEnum GetEventTypeNameFromEnum;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetHiddenAreaMesh GetHiddenAreaMesh;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetControllerState GetControllerState;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetControllerStateWithPose GetControllerStateWithPose;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _TriggerHapticPulse TriggerHapticPulse;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetButtonIdNameFromEnum GetButtonIdNameFromEnum;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetControllerAxisTypeNameFromEnum GetControllerAxisTypeNameFromEnum;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CaptureInputFocus CaptureInputFocus;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReleaseInputFocus ReleaseInputFocus;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsInputFocusCapturedByAnotherProcess IsInputFocusCapturedByAnotherProcess;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _DriverDebugRequest DriverDebugRequest;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _PerformFirmwareUpdate PerformFirmwareUpdate;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _AcknowledgeQuit_Exiting AcknowledgeQuit_Exiting;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _AcknowledgeQuit_UserPrompt AcknowledgeQuit_UserPrompt;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _PerformanceTestEnableCapture PerformanceTestEnableCapture;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _PerformanceTestReportFidelityLevelChange PerformanceTestReportFidelityLevelChange;
	}
	public struct IVRExtendedDisplay
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetWindowBounds(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetEyeOutputViewport(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex, ref int pnAdapterOutputIndex);

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetWindowBounds GetWindowBounds;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetEyeOutputViewport GetEyeOutputViewport;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetDXGIOutputInfo GetDXGIOutputInfo;
	}
	public struct IVRApplications
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _AddApplicationManifest(string pchApplicationManifestFullPath, bool bTemporary);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _RemoveApplicationManifest(string pchApplicationManifestFullPath);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsApplicationInstalled(string pchAppKey);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetApplicationCount();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _GetApplicationKeyByIndex(uint unApplicationIndex, string pchAppKeyBuffer, uint unAppKeyBufferLen);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _GetApplicationKeyByProcessId(uint unProcessId, string pchAppKeyBuffer, uint unAppKeyBufferLen);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _LaunchApplication(string pchAppKey);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _LaunchDashboardOverlay(string pchAppKey);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _CancelApplicationLaunch(string pchAppKey);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _IdentifyApplication(uint unProcessId, string pchAppKey);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetApplicationProcessId(string pchAppKey);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetApplicationsErrorNameFromEnum(EVRApplicationError error);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetApplicationPropertyString(string pchAppKey, EVRApplicationProperty eProperty, string pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetApplicationPropertyBool(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ulong _GetApplicationPropertyUint64(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _SetApplicationAutoLaunch(string pchAppKey, bool bAutoLaunch);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetApplicationAutoLaunch(string pchAppKey);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _GetStartingApplication(string pchAppKeyBuffer, uint unAppKeyBufferLen);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationTransitionState _GetTransitionState();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _PerformApplicationPrelaunchCheck(string pchAppKey);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetApplicationsTransitionStateNameFromEnum(EVRApplicationTransitionState state);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsQuitUserPromptRequested();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _LaunchInternalProcess(string pchBinaryPath, string pchArguments, string pchWorkingDirectory);

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _AddApplicationManifest AddApplicationManifest;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _RemoveApplicationManifest RemoveApplicationManifest;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsApplicationInstalled IsApplicationInstalled;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationCount GetApplicationCount;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationKeyByIndex GetApplicationKeyByIndex;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationKeyByProcessId GetApplicationKeyByProcessId;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _LaunchApplication LaunchApplication;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _LaunchDashboardOverlay LaunchDashboardOverlay;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CancelApplicationLaunch CancelApplicationLaunch;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IdentifyApplication IdentifyApplication;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationProcessId GetApplicationProcessId;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationsErrorNameFromEnum GetApplicationsErrorNameFromEnum;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationPropertyString GetApplicationPropertyString;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationPropertyBool GetApplicationPropertyBool;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationPropertyUint64 GetApplicationPropertyUint64;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetApplicationAutoLaunch SetApplicationAutoLaunch;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationAutoLaunch GetApplicationAutoLaunch;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetStartingApplication GetStartingApplication;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetTransitionState GetTransitionState;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _PerformApplicationPrelaunchCheck PerformApplicationPrelaunchCheck;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationsTransitionStateNameFromEnum GetApplicationsTransitionStateNameFromEnum;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsQuitUserPromptRequested IsQuitUserPromptRequested;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _LaunchInternalProcess LaunchInternalProcess;
	}
	public struct IVRChaperone
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ChaperoneCalibrationState _GetCalibrationState();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetPlayAreaSize(ref float pSizeX, ref float pSizeZ);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetPlayAreaRect(ref HmdQuad_t rect);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ReloadInfo();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetSceneColor(HmdColor_t color);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetBoundsColor(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _AreBoundsVisible();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ForceBoundsVisible(bool bForce);

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetCalibrationState GetCalibrationState;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetPlayAreaSize GetPlayAreaSize;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetPlayAreaRect GetPlayAreaRect;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReloadInfo ReloadInfo;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetSceneColor SetSceneColor;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetBoundsColor GetBoundsColor;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _AreBoundsVisible AreBoundsVisible;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ForceBoundsVisible ForceBoundsVisible;
	}
	public struct IVRChaperoneSetup
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _CommitWorkingCopy(EChaperoneConfigFile configFile);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _RevertWorkingCopy();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetWorkingPlayAreaSize(ref float pSizeX, ref float pSizeZ);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetWorkingPlayAreaRect(ref HmdQuad_t rect);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetWorkingCollisionBoundsInfo([In][Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetLiveCollisionBoundsInfo([In][Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetWorkingPlayAreaSize(float sizeX, float sizeZ);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetWorkingCollisionBoundsInfo([In][Out] HmdQuad_t[] pQuadsBuffer, uint unQuadsCount);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ReloadFromDisk(EChaperoneConfigFile configFile);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetWorkingCollisionBoundsTagsInfo([In][Out] byte[] pTagsBuffer, uint unTagCount);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetLiveCollisionBoundsTagsInfo([In][Out] byte[] pTagsBuffer, ref uint punTagCount);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _SetWorkingPhysicalBoundsInfo([In][Out] HmdQuad_t[] pQuadsBuffer, uint unQuadsCount);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetLivePhysicalBoundsInfo([In][Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _ExportLiveToBuffer(StringBuilder pBuffer, ref uint pnBufferLength);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _ImportFromBufferToWorking(string pBuffer, uint nImportFlags);

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CommitWorkingCopy CommitWorkingCopy;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _RevertWorkingCopy RevertWorkingCopy;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetWorkingPlayAreaSize GetWorkingPlayAreaSize;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetWorkingPlayAreaRect GetWorkingPlayAreaRect;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetWorkingCollisionBoundsInfo GetWorkingCollisionBoundsInfo;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetLiveCollisionBoundsInfo GetLiveCollisionBoundsInfo;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetWorkingSeatedZeroPoseToRawTrackingPose GetWorkingSeatedZeroPoseToRawTrackingPose;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetWorkingStandingZeroPoseToRawTrackingPose GetWorkingStandingZeroPoseToRawTrackingPose;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetWorkingPlayAreaSize SetWorkingPlayAreaSize;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetWorkingCollisionBoundsInfo SetWorkingCollisionBoundsInfo;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetWorkingSeatedZeroPoseToRawTrackingPose SetWorkingSeatedZeroPoseToRawTrackingPose;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetWorkingStandingZeroPoseToRawTrackingPose SetWorkingStandingZeroPoseToRawTrackingPose;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReloadFromDisk ReloadFromDisk;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetLiveSeatedZeroPoseToRawTrackingPose GetLiveSeatedZeroPoseToRawTrackingPose;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetWorkingCollisionBoundsTagsInfo SetWorkingCollisionBoundsTagsInfo;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetLiveCollisionBoundsTagsInfo GetLiveCollisionBoundsTagsInfo;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetWorkingPhysicalBoundsInfo SetWorkingPhysicalBoundsInfo;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetLivePhysicalBoundsInfo GetLivePhysicalBoundsInfo;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ExportLiveToBuffer ExportLiveToBuffer;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ImportFromBufferToWorking ImportFromBufferToWorking;
	}
	public struct IVRCompositor
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetTrackingSpace(ETrackingUniverseOrigin eOrigin);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ETrackingUniverseOrigin _GetTrackingSpace();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _WaitGetPoses([In][Out] TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, [In][Out] TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _GetLastPoses([In][Out] TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, [In][Out] TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _Submit(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ClearLastSubmittedFrame();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _PostPresentHandoff();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetFrameTiming(ref Compositor_FrameTiming pTiming, uint unFramesAgo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate float _GetFrameTimeRemaining();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _FadeGrid(float fSeconds, bool bFadeIn);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _SetSkyboxOverride([In][Out] Texture_t[] pTextures, uint unTextureCount);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ClearSkyboxOverride();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _CompositorBringToFront();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _CompositorGoToBack();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _CompositorQuit();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsFullscreen();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetCurrentSceneFocusProcess();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetLastFrameRenderer();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _CanRenderScene();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ShowMirrorWindow();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _HideMirrorWindow();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsMirrorWindowVisible();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _CompositorDumpImages();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _ShouldAppRenderWithLowResources();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ForceInterleavedReprojectionOn(bool bOverride);

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetTrackingSpace SetTrackingSpace;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetTrackingSpace GetTrackingSpace;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _WaitGetPoses WaitGetPoses;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetLastPoses GetLastPoses;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetLastPoseForTrackedDeviceIndex GetLastPoseForTrackedDeviceIndex;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _Submit Submit;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ClearLastSubmittedFrame ClearLastSubmittedFrame;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _PostPresentHandoff PostPresentHandoff;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetFrameTiming GetFrameTiming;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetFrameTimeRemaining GetFrameTimeRemaining;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _FadeToColor FadeToColor;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _FadeGrid FadeGrid;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetSkyboxOverride SetSkyboxOverride;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ClearSkyboxOverride ClearSkyboxOverride;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CompositorBringToFront CompositorBringToFront;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CompositorGoToBack CompositorGoToBack;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CompositorQuit CompositorQuit;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsFullscreen IsFullscreen;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetCurrentSceneFocusProcess GetCurrentSceneFocusProcess;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetLastFrameRenderer GetLastFrameRenderer;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CanRenderScene CanRenderScene;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ShowMirrorWindow ShowMirrorWindow;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _HideMirrorWindow HideMirrorWindow;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsMirrorWindowVisible IsMirrorWindowVisible;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CompositorDumpImages CompositorDumpImages;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ShouldAppRenderWithLowResources ShouldAppRenderWithLowResources;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ForceInterleavedReprojectionOn ForceInterleavedReprojectionOn;
	}
	public struct IVROverlay
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _FindOverlay(string pchOverlayKey, ref ulong pOverlayHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _CreateOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pOverlayHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _DestroyOverlay(ulong ulOverlayHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetHighQualityOverlay(ulong ulOverlayHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ulong _GetHighQualityOverlay();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetOverlayKey(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetOverlayName(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayImageData(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetOverlayErrorNameFromEnum(EVROverlayError error);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, bool bEnabled);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, ref bool pbEnabled);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayColor(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayColor(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayAlpha(ulong ulOverlayHandle, float fAlpha);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayAlpha(ulong ulOverlayHandle, ref float pfAlpha);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayWidthInMeters(ulong ulOverlayHandle, float fWidthInMeters);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayWidthInMeters(ulong ulOverlayHandle, ref float pfWidthInMeters);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, float fMinDistanceInMeters, float fMaxDistanceInMeters);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, ref float pfMinDistanceInMeters, ref float pfMaxDistanceInMeters);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTextureColorSpace(ulong ulOverlayHandle, EColorSpace eTextureColorSpace);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTextureColorSpace(ulong ulOverlayHandle, ref EColorSpace peTextureColorSpace);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTransformType(ulong ulOverlayHandle, ref VROverlayTransformType peTransformType);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTransformAbsolute(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTransformAbsolute(ulong ulOverlayHandle, ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, uint unTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, uint unDeviceIndex, string pchComponentName);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, ref uint punDeviceIndex, string pchComponentName, uint unComponentNameSize);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _ShowOverlay(ulong ulOverlayHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _HideOverlay(ulong ulOverlayHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsOverlayVisible(ulong ulOverlayHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetTransformForOverlayCoordinates(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, HmdVector2_t coordinatesInOverlay, ref HmdMatrix34_t pmatTransform);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _PollNextOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pEvent, uint uncbVREvent);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayInputMethod(ulong ulOverlayHandle, ref VROverlayInputMethod peInputMethod);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayInputMethod(ulong ulOverlayHandle, VROverlayInputMethod eInputMethod);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _ComputeOverlayIntersection(ulong ulOverlayHandle, ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _HandleControllerOverlayInteractionAsMouse(ulong ulOverlayHandle, uint unControllerDeviceIndex);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsHoverTargetOverlay(ulong ulOverlayHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ulong _GetGamepadFocusOverlay();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetGamepadFocusOverlay(ulong ulNewFocusOverlay);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayNeighbor(EOverlayDirection eDirection, ulong ulFrom, ulong ulTo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _MoveGamepadFocusToNeighbor(EOverlayDirection eDirection, ulong ulFrom);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _ClearOverlayTexture(ulong ulOverlayHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayRaw(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unDepth);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayFromFile(ulong ulOverlayHandle, string pchFilePath);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _CreateDashboardOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsDashboardVisible();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsActiveDashboardOverlay(ulong ulOverlayHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetDashboardOverlaySceneProcess(ulong ulOverlayHandle, uint unProcessId);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetDashboardOverlaySceneProcess(ulong ulOverlayHandle, ref uint punProcessId);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ShowDashboard(string pchOverlayToShow);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetPrimaryDashboardDevice();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _ShowKeyboard(int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _ShowKeyboardForOverlay(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetKeyboardText(StringBuilder pchText, uint cchText);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _HideKeyboard();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetKeyboardPositionForOverlay(ulong ulOverlayHandle, HmdRect2_t avoidRect);

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _FindOverlay FindOverlay;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CreateOverlay CreateOverlay;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _DestroyOverlay DestroyOverlay;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetHighQualityOverlay SetHighQualityOverlay;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetHighQualityOverlay GetHighQualityOverlay;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayKey GetOverlayKey;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayName GetOverlayName;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayImageData GetOverlayImageData;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayErrorNameFromEnum GetOverlayErrorNameFromEnum;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayFlag SetOverlayFlag;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayFlag GetOverlayFlag;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayColor SetOverlayColor;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayColor GetOverlayColor;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayAlpha SetOverlayAlpha;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayAlpha GetOverlayAlpha;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayWidthInMeters SetOverlayWidthInMeters;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayWidthInMeters GetOverlayWidthInMeters;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayAutoCurveDistanceRangeInMeters SetOverlayAutoCurveDistanceRangeInMeters;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayAutoCurveDistanceRangeInMeters GetOverlayAutoCurveDistanceRangeInMeters;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayTextureColorSpace SetOverlayTextureColorSpace;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayTextureColorSpace GetOverlayTextureColorSpace;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayTextureBounds SetOverlayTextureBounds;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayTextureBounds GetOverlayTextureBounds;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayTransformType GetOverlayTransformType;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayTransformAbsolute SetOverlayTransformAbsolute;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayTransformAbsolute GetOverlayTransformAbsolute;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayTransformTrackedDeviceRelative SetOverlayTransformTrackedDeviceRelative;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayTransformTrackedDeviceRelative GetOverlayTransformTrackedDeviceRelative;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayTransformTrackedDeviceComponent SetOverlayTransformTrackedDeviceComponent;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayTransformTrackedDeviceComponent GetOverlayTransformTrackedDeviceComponent;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ShowOverlay ShowOverlay;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _HideOverlay HideOverlay;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsOverlayVisible IsOverlayVisible;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetTransformForOverlayCoordinates GetTransformForOverlayCoordinates;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _PollNextOverlayEvent PollNextOverlayEvent;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayInputMethod GetOverlayInputMethod;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayInputMethod SetOverlayInputMethod;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayMouseScale GetOverlayMouseScale;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayMouseScale SetOverlayMouseScale;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ComputeOverlayIntersection ComputeOverlayIntersection;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _HandleControllerOverlayInteractionAsMouse HandleControllerOverlayInteractionAsMouse;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsHoverTargetOverlay IsHoverTargetOverlay;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetGamepadFocusOverlay GetGamepadFocusOverlay;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetGamepadFocusOverlay SetGamepadFocusOverlay;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayNeighbor SetOverlayNeighbor;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _MoveGamepadFocusToNeighbor MoveGamepadFocusToNeighbor;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayTexture SetOverlayTexture;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ClearOverlayTexture ClearOverlayTexture;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayRaw SetOverlayRaw;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayFromFile SetOverlayFromFile;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CreateDashboardOverlay CreateDashboardOverlay;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsDashboardVisible IsDashboardVisible;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsActiveDashboardOverlay IsActiveDashboardOverlay;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetDashboardOverlaySceneProcess SetDashboardOverlaySceneProcess;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetDashboardOverlaySceneProcess GetDashboardOverlaySceneProcess;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ShowDashboard ShowDashboard;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetPrimaryDashboardDevice GetPrimaryDashboardDevice;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ShowKeyboard ShowKeyboard;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ShowKeyboardForOverlay ShowKeyboardForOverlay;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetKeyboardText GetKeyboardText;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _HideKeyboard HideKeyboard;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetKeyboardTransformAbsolute SetKeyboardTransformAbsolute;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetKeyboardPositionForOverlay SetKeyboardPositionForOverlay;
	}
	public struct IVRRenderModels
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRRenderModelError _LoadRenderModel_Async(string pchRenderModelName, ref IntPtr ppRenderModel);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _FreeRenderModel(IntPtr pRenderModel);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRRenderModelError _LoadTexture_Async(int textureId, ref IntPtr ppTexture);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _FreeTexture(IntPtr pTexture);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRRenderModelError _LoadTextureD3D11_Async(int textureId, IntPtr pD3D11Device, ref IntPtr ppD3D11Texture2D);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRRenderModelError _LoadIntoTextureD3D11_Async(int textureId, IntPtr pDstTexture);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _FreeTextureD3D11(IntPtr pD3D11Texture2D);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetRenderModelName(uint unRenderModelIndex, StringBuilder pchRenderModelName, uint unRenderModelNameLen);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetRenderModelCount();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetComponentCount(string pchRenderModelName);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetComponentName(string pchRenderModelName, uint unComponentIndex, StringBuilder pchComponentName, uint unComponentNameLen);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ulong _GetComponentButtonMask(string pchRenderModelName, string pchComponentName);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetComponentRenderModelName(string pchRenderModelName, string pchComponentName, StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetComponentState(string pchRenderModelName, string pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _RenderModelHasComponent(string pchRenderModelName, string pchComponentName);

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _LoadRenderModel_Async LoadRenderModel_Async;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _FreeRenderModel FreeRenderModel;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _LoadTexture_Async LoadTexture_Async;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _FreeTexture FreeTexture;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _LoadTextureD3D11_Async LoadTextureD3D11_Async;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _LoadIntoTextureD3D11_Async LoadIntoTextureD3D11_Async;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _FreeTextureD3D11 FreeTextureD3D11;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetRenderModelName GetRenderModelName;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetRenderModelCount GetRenderModelCount;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetComponentCount GetComponentCount;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetComponentName GetComponentName;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetComponentButtonMask GetComponentButtonMask;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetComponentRenderModelName GetComponentRenderModelName;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetComponentState GetComponentState;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _RenderModelHasComponent RenderModelHasComponent;
	}
	public struct IVRNotifications
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRNotificationError _CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, string pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRNotificationError _RemoveNotification(uint notificationId);

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CreateNotification CreateNotification;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _RemoveNotification RemoveNotification;
	}
	public struct IVRSettings
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetSettingsErrorNameFromEnum(EVRSettingsError eError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _Sync(bool bForce, ref EVRSettingsError peError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetBool(string pchSection, string pchSettingsKey, bool bDefaultValue, ref EVRSettingsError peError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetBool(string pchSection, string pchSettingsKey, bool bValue, ref EVRSettingsError peError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate int _GetInt32(string pchSection, string pchSettingsKey, int nDefaultValue, ref EVRSettingsError peError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetInt32(string pchSection, string pchSettingsKey, int nValue, ref EVRSettingsError peError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate float _GetFloat(string pchSection, string pchSettingsKey, float flDefaultValue, ref EVRSettingsError peError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetFloat(string pchSection, string pchSettingsKey, float flValue, ref EVRSettingsError peError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetString(string pchSection, string pchSettingsKey, string pchValue, uint unValueLen, string pchDefaultValue, ref EVRSettingsError peError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetString(string pchSection, string pchSettingsKey, string pchValue, ref EVRSettingsError peError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _RemoveSection(string pchSection, ref EVRSettingsError peError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _RemoveKeyInSection(string pchSection, string pchSettingsKey, ref EVRSettingsError peError);

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetSettingsErrorNameFromEnum GetSettingsErrorNameFromEnum;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _Sync Sync;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetBool GetBool;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetBool SetBool;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetInt32 GetInt32;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetInt32 SetInt32;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetFloat GetFloat;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetFloat SetFloat;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetString GetString;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetString SetString;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _RemoveSection RemoveSection;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _RemoveKeyInSection RemoveKeyInSection;
	}
	public struct IVRTrackedCamera
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _HasCamera(uint nDeviceIndex);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetCameraFirmwareDescription(uint nDeviceIndex, string pBuffer, uint nBufferLen);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetCameraFrameDimensions(uint nDeviceIndex, ECameraVideoStreamFormat nVideoStreamFormat, ref uint pWidth, ref uint pHeight);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _SetCameraVideoStreamFormat(uint nDeviceIndex, ECameraVideoStreamFormat nVideoStreamFormat);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ECameraVideoStreamFormat _GetCameraVideoStreamFormat(uint nDeviceIndex);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _EnableCameraForStreaming(uint nDeviceIndex, bool bEnable);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _StartVideoStream(uint nDeviceIndex);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _StopVideoStream(uint nDeviceIndex);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsVideoStreamActive(uint nDeviceIndex, ref bool pbPaused, ref float pflElapsedTime);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetVideoStreamFrame(uint nDeviceIndex);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _ReleaseVideoStreamFrame(uint nDeviceIndex, ref CameraVideoStreamFrame_t pFrameImage);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _SetAutoExposure(uint nDeviceIndex, bool bEnable);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _PauseVideoStream(uint nDeviceIndex);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _ResumeVideoStream(uint nDeviceIndex);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetCameraDistortion(uint nDeviceIndex, float flInputU, float flInputV, ref float pflOutputU, ref float pflOutputV);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetCameraProjection(uint nDeviceIndex, float flWidthPixels, float flHeightPixels, float flZNear, float flZFar, ref HmdMatrix44_t pProjection);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetRecommendedCameraUndistortion(uint nDeviceIndex, ref uint pUndistortionWidthPixels, ref uint pUndistortionHeightPixels);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _SetCameraUndistortion(uint nDeviceIndex, uint nUndistortionWidthPixels, uint nUndistortionHeightPixels);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _RequestVideoServicesForTool();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ReleaseVideoServicesForTool();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetVideoStreamFrameSharedTextureGL(bool bUndistorted, ref uint pglTextureId, IntPtr pglSharedTextureHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _ReleaseVideoStreamFrameSharedTextureGL(uint glTextureId, IntPtr glSharedTextureHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _LockSharedTextureGL(IntPtr glSharedTextureHandle, ref CameraVideoStreamFrame_t pFrameImage);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _UnlockSharedTextureGL(IntPtr glSharedTextureHandle);

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _HasCamera HasCamera;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetCameraFirmwareDescription GetCameraFirmwareDescription;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetCameraFrameDimensions GetCameraFrameDimensions;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetCameraVideoStreamFormat SetCameraVideoStreamFormat;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetCameraVideoStreamFormat GetCameraVideoStreamFormat;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _EnableCameraForStreaming EnableCameraForStreaming;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _StartVideoStream StartVideoStream;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _StopVideoStream StopVideoStream;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsVideoStreamActive IsVideoStreamActive;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetVideoStreamFrame GetVideoStreamFrame;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReleaseVideoStreamFrame ReleaseVideoStreamFrame;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetAutoExposure SetAutoExposure;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _PauseVideoStream PauseVideoStream;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ResumeVideoStream ResumeVideoStream;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetCameraDistortion GetCameraDistortion;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetCameraProjection GetCameraProjection;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetRecommendedCameraUndistortion GetRecommendedCameraUndistortion;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetCameraUndistortion SetCameraUndistortion;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _RequestVideoServicesForTool RequestVideoServicesForTool;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReleaseVideoServicesForTool ReleaseVideoServicesForTool;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetVideoStreamFrameSharedTextureGL GetVideoStreamFrameSharedTextureGL;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReleaseVideoStreamFrameSharedTextureGL ReleaseVideoStreamFrameSharedTextureGL;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _LockSharedTextureGL LockSharedTextureGL;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _UnlockSharedTextureGL UnlockSharedTextureGL;
	}
	public class CVRSystem
	{
		private IVRSystem FnTable;

		internal CVRSystem(IntPtr pInterface)
		{
			FnTable = (IVRSystem)Marshal.PtrToStructure(pInterface, typeof(IVRSystem));
		}

		public void GetRecommendedRenderTargetSize(ref uint pnWidth, ref uint pnHeight)
		{
			pnWidth = 0u;
			pnHeight = 0u;
			FnTable.GetRecommendedRenderTargetSize(ref pnWidth, ref pnHeight);
		}

		public HmdMatrix44_t GetProjectionMatrix(EVREye eEye, float fNearZ, float fFarZ, EGraphicsAPIConvention eProjType)
		{
			return FnTable.GetProjectionMatrix(eEye, fNearZ, fFarZ, eProjType);
		}

		public void GetProjectionRaw(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom)
		{
			pfLeft = 0f;
			pfRight = 0f;
			pfTop = 0f;
			pfBottom = 0f;
			FnTable.GetProjectionRaw(eEye, ref pfLeft, ref pfRight, ref pfTop, ref pfBottom);
		}

		public DistortionCoordinates_t ComputeDistortion(EVREye eEye, float fU, float fV)
		{
			return FnTable.ComputeDistortion(eEye, fU, fV);
		}

		public HmdMatrix34_t GetEyeToHeadTransform(EVREye eEye)
		{
			return FnTable.GetEyeToHeadTransform(eEye);
		}

		public bool GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter)
		{
			pfSecondsSinceLastVsync = 0f;
			pulFrameCounter = 0uL;
			return FnTable.GetTimeSinceLastVsync(ref pfSecondsSinceLastVsync, ref pulFrameCounter);
		}

		public int GetD3D9AdapterIndex()
		{
			return FnTable.GetD3D9AdapterIndex();
		}

		public void GetDXGIOutputInfo(ref int pnAdapterIndex)
		{
			pnAdapterIndex = 0;
			FnTable.GetDXGIOutputInfo(ref pnAdapterIndex);
		}

		public bool IsDisplayOnDesktop()
		{
			return FnTable.IsDisplayOnDesktop();
		}

		public bool SetDisplayVisibility(bool bIsVisibleOnDesktop)
		{
			return FnTable.SetDisplayVisibility(bIsVisibleOnDesktop);
		}

		public void GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, TrackedDevicePose_t[] pTrackedDevicePoseArray)
		{
			FnTable.GetDeviceToAbsoluteTrackingPose(eOrigin, fPredictedSecondsToPhotonsFromNow, pTrackedDevicePoseArray, (uint)pTrackedDevicePoseArray.Length);
		}

		public void ResetSeatedZeroPose()
		{
			FnTable.ResetSeatedZeroPose();
		}

		public HmdMatrix34_t GetSeatedZeroPoseToStandingAbsoluteTrackingPose()
		{
			return FnTable.GetSeatedZeroPoseToStandingAbsoluteTrackingPose();
		}

		public HmdMatrix34_t GetRawZeroPoseToStandingAbsoluteTrackingPose()
		{
			return FnTable.GetRawZeroPoseToStandingAbsoluteTrackingPose();
		}

		public uint GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass eTrackedDeviceClass, uint[] punTrackedDeviceIndexArray, uint unRelativeToTrackedDeviceIndex)
		{
			return FnTable.GetSortedTrackedDeviceIndicesOfClass(eTrackedDeviceClass, punTrackedDeviceIndexArray, (uint)punTrackedDeviceIndexArray.Length, unRelativeToTrackedDeviceIndex);
		}

		public EDeviceActivityLevel GetTrackedDeviceActivityLevel(uint unDeviceId)
		{
			return FnTable.GetTrackedDeviceActivityLevel(unDeviceId);
		}

		public void ApplyTransform(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform)
		{
			FnTable.ApplyTransform(ref pOutputPose, ref pTrackedDevicePose, ref pTransform);
		}

		public uint GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole unDeviceType)
		{
			return FnTable.GetTrackedDeviceIndexForControllerRole(unDeviceType);
		}

		public ETrackedControllerRole GetControllerRoleForTrackedDeviceIndex(uint unDeviceIndex)
		{
			return FnTable.GetControllerRoleForTrackedDeviceIndex(unDeviceIndex);
		}

		public ETrackedDeviceClass GetTrackedDeviceClass(uint unDeviceIndex)
		{
			return FnTable.GetTrackedDeviceClass(unDeviceIndex);
		}

		public bool IsTrackedDeviceConnected(uint unDeviceIndex)
		{
			return FnTable.IsTrackedDeviceConnected(unDeviceIndex);
		}

		public bool GetBoolTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			return FnTable.GetBoolTrackedDeviceProperty(unDeviceIndex, prop, ref pError);
		}

		public float GetFloatTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			return FnTable.GetFloatTrackedDeviceProperty(unDeviceIndex, prop, ref pError);
		}

		public int GetInt32TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			return FnTable.GetInt32TrackedDeviceProperty(unDeviceIndex, prop, ref pError);
		}

		public ulong GetUint64TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			return FnTable.GetUint64TrackedDeviceProperty(unDeviceIndex, prop, ref pError);
		}

		public HmdMatrix34_t GetMatrix34TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			return FnTable.GetMatrix34TrackedDeviceProperty(unDeviceIndex, prop, ref pError);
		}

		public uint GetStringTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError)
		{
			return FnTable.GetStringTrackedDeviceProperty(unDeviceIndex, prop, pchValue, unBufferSize, ref pError);
		}

		public string GetPropErrorNameFromEnum(ETrackedPropertyError error)
		{
			IntPtr ptr = FnTable.GetPropErrorNameFromEnum(error);
			return (string)Marshal.PtrToStructure(ptr, typeof(string));
		}

		public bool PollNextEvent(ref VREvent_t pEvent, uint uncbVREvent)
		{
			return FnTable.PollNextEvent(ref pEvent, uncbVREvent);
		}

		public bool PollNextEventWithPose(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose)
		{
			return FnTable.PollNextEventWithPose(eOrigin, ref pEvent, uncbVREvent, ref pTrackedDevicePose);
		}

		public string GetEventTypeNameFromEnum(EVREventType eType)
		{
			IntPtr ptr = FnTable.GetEventTypeNameFromEnum(eType);
			return (string)Marshal.PtrToStructure(ptr, typeof(string));
		}

		public HiddenAreaMesh_t GetHiddenAreaMesh(EVREye eEye)
		{
			return FnTable.GetHiddenAreaMesh(eEye);
		}

		public bool GetControllerState(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState)
		{
			return FnTable.GetControllerState(unControllerDeviceIndex, ref pControllerState);
		}

		public bool GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, ref TrackedDevicePose_t pTrackedDevicePose)
		{
			return FnTable.GetControllerStateWithPose(eOrigin, unControllerDeviceIndex, ref pControllerState, ref pTrackedDevicePose);
		}

		public void TriggerHapticPulse(uint unControllerDeviceIndex, uint unAxisId, char usDurationMicroSec)
		{
			FnTable.TriggerHapticPulse(unControllerDeviceIndex, unAxisId, usDurationMicroSec);
		}

		public string GetButtonIdNameFromEnum(EVRButtonId eButtonId)
		{
			IntPtr ptr = FnTable.GetButtonIdNameFromEnum(eButtonId);
			return (string)Marshal.PtrToStructure(ptr, typeof(string));
		}

		public string GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType)
		{
			IntPtr ptr = FnTable.GetControllerAxisTypeNameFromEnum(eAxisType);
			return (string)Marshal.PtrToStructure(ptr, typeof(string));
		}

		public bool CaptureInputFocus()
		{
			return FnTable.CaptureInputFocus();
		}

		public void ReleaseInputFocus()
		{
			FnTable.ReleaseInputFocus();
		}

		public bool IsInputFocusCapturedByAnotherProcess()
		{
			return FnTable.IsInputFocusCapturedByAnotherProcess();
		}

		public uint DriverDebugRequest(uint unDeviceIndex, string pchRequest, string pchResponseBuffer, uint unResponseBufferSize)
		{
			return FnTable.DriverDebugRequest(unDeviceIndex, pchRequest, pchResponseBuffer, unResponseBufferSize);
		}

		public EVRFirmwareError PerformFirmwareUpdate(uint unDeviceIndex)
		{
			return FnTable.PerformFirmwareUpdate(unDeviceIndex);
		}

		public void AcknowledgeQuit_Exiting()
		{
			FnTable.AcknowledgeQuit_Exiting();
		}

		public void AcknowledgeQuit_UserPrompt()
		{
			FnTable.AcknowledgeQuit_UserPrompt();
		}

		public void PerformanceTestEnableCapture(bool bEnable)
		{
			FnTable.PerformanceTestEnableCapture(bEnable);
		}

		public void PerformanceTestReportFidelityLevelChange(int nFidelityLevel)
		{
			FnTable.PerformanceTestReportFidelityLevelChange(nFidelityLevel);
		}
	}
	public class CVRExtendedDisplay
	{
		private IVRExtendedDisplay FnTable;

		internal CVRExtendedDisplay(IntPtr pInterface)
		{
			FnTable = (IVRExtendedDisplay)Marshal.PtrToStructure(pInterface, typeof(IVRExtendedDisplay));
		}

		public void GetWindowBounds(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight)
		{
			pnX = 0;
			pnY = 0;
			pnWidth = 0u;
			pnHeight = 0u;
			FnTable.GetWindowBounds(ref pnX, ref pnY, ref pnWidth, ref pnHeight);
		}

		public void GetEyeOutputViewport(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight)
		{
			pnX = 0u;
			pnY = 0u;
			pnWidth = 0u;
			pnHeight = 0u;
			FnTable.GetEyeOutputViewport(eEye, ref pnX, ref pnY, ref pnWidth, ref pnHeight);
		}

		public void GetDXGIOutputInfo(ref int pnAdapterIndex, ref int pnAdapterOutputIndex)
		{
			pnAdapterIndex = 0;
			pnAdapterOutputIndex = 0;
			FnTable.GetDXGIOutputInfo(ref pnAdapterIndex, ref pnAdapterOutputIndex);
		}
	}
	public class CVRApplications
	{
		private IVRApplications FnTable;

		internal CVRApplications(IntPtr pInterface)
		{
			FnTable = (IVRApplications)Marshal.PtrToStructure(pInterface, typeof(IVRApplications));
		}

		public EVRApplicationError AddApplicationManifest(string pchApplicationManifestFullPath, bool bTemporary)
		{
			return FnTable.AddApplicationManifest(pchApplicationManifestFullPath, bTemporary);
		}

		public EVRApplicationError RemoveApplicationManifest(string pchApplicationManifestFullPath)
		{
			return FnTable.RemoveApplicationManifest(pchApplicationManifestFullPath);
		}

		public bool IsApplicationInstalled(string pchAppKey)
		{
			return FnTable.IsApplicationInstalled(pchAppKey);
		}

		public uint GetApplicationCount()
		{
			return FnTable.GetApplicationCount();
		}

		public EVRApplicationError GetApplicationKeyByIndex(uint unApplicationIndex, string pchAppKeyBuffer, uint unAppKeyBufferLen)
		{
			return FnTable.GetApplicationKeyByIndex(unApplicationIndex, pchAppKeyBuffer, unAppKeyBufferLen);
		}

		public EVRApplicationError GetApplicationKeyByProcessId(uint unProcessId, string pchAppKeyBuffer, uint unAppKeyBufferLen)
		{
			return FnTable.GetApplicationKeyByProcessId(unProcessId, pchAppKeyBuffer, unAppKeyBufferLen);
		}

		public EVRApplicationError LaunchApplication(string pchAppKey)
		{
			return FnTable.LaunchApplication(pchAppKey);
		}

		public EVRApplicationError LaunchDashboardOverlay(string pchAppKey)
		{
			return FnTable.LaunchDashboardOverlay(pchAppKey);
		}

		public bool CancelApplicationLaunch(string pchAppKey)
		{
			return FnTable.CancelApplicationLaunch(pchAppKey);
		}

		public EVRApplicationError IdentifyApplication(uint unProcessId, string pchAppKey)
		{
			return FnTable.IdentifyApplication(unProcessId, pchAppKey);
		}

		public uint GetApplicationProcessId(string pchAppKey)
		{
			return FnTable.GetApplicationProcessId(pchAppKey);
		}

		public string GetApplicationsErrorNameFromEnum(EVRApplicationError error)
		{
			IntPtr ptr = FnTable.GetApplicationsErrorNameFromEnum(error);
			return (string)Marshal.PtrToStructure(ptr, typeof(string));
		}

		public uint GetApplicationPropertyString(string pchAppKey, EVRApplicationProperty eProperty, string pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError)
		{
			return FnTable.GetApplicationPropertyString(pchAppKey, eProperty, pchPropertyValueBuffer, unPropertyValueBufferLen, ref peError);
		}

		public bool GetApplicationPropertyBool(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError)
		{
			return FnTable.GetApplicationPropertyBool(pchAppKey, eProperty, ref peError);
		}

		public ulong GetApplicationPropertyUint64(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError)
		{
			return FnTable.GetApplicationPropertyUint64(pchAppKey, eProperty, ref peError);
		}

		public EVRApplicationError SetApplicationAutoLaunch(string pchAppKey, bool bAutoLaunch)
		{
			return FnTable.SetApplicationAutoLaunch(pchAppKey, bAutoLaunch);
		}

		public bool GetApplicationAutoLaunch(string pchAppKey)
		{
			return FnTable.GetApplicationAutoLaunch(pchAppKey);
		}

		public EVRApplicationError GetStartingApplication(string pchAppKeyBuffer, uint unAppKeyBufferLen)
		{
			return FnTable.GetStartingApplication(pchAppKeyBuffer, unAppKeyBufferLen);
		}

		public EVRApplicationTransitionState GetTransitionState()
		{
			return FnTable.GetTransitionState();
		}

		public EVRApplicationError PerformApplicationPrelaunchCheck(string pchAppKey)
		{
			return FnTable.PerformApplicationPrelaunchCheck(pchAppKey);
		}

		public string GetApplicationsTransitionStateNameFromEnum(EVRApplicationTransitionState state)
		{
			IntPtr ptr = FnTable.GetApplicationsTransitionStateNameFromEnum(state);
			return (string)Marshal.PtrToStructure(ptr, typeof(string));
		}

		public bool IsQuitUserPromptRequested()
		{
			return FnTable.IsQuitUserPromptRequested();
		}

		public EVRApplicationError LaunchInternalProcess(string pchBinaryPath, string pchArguments, string pchWorkingDirectory)
		{
			return FnTable.LaunchInternalProcess(pchBinaryPath, pchArguments, pchWorkingDirectory);
		}
	}
	public class CVRChaperone
	{
		private IVRChaperone FnTable;

		internal CVRChaperone(IntPtr pInterface)
		{
			FnTable = (IVRChaperone)Marshal.PtrToStructure(pInterface, typeof(IVRChaperone));
		}

		public ChaperoneCalibrationState GetCalibrationState()
		{
			return FnTable.GetCalibrationState();
		}

		public bool GetPlayAreaSize(ref float pSizeX, ref float pSizeZ)
		{
			pSizeX = 0f;
			pSizeZ = 0f;
			return FnTable.GetPlayAreaSize(ref pSizeX, ref pSizeZ);
		}

		public bool GetPlayAreaRect(ref HmdQuad_t rect)
		{
			return FnTable.GetPlayAreaRect(ref rect);
		}

		public void ReloadInfo()
		{
			FnTable.ReloadInfo();
		}

		public void SetSceneColor(HmdColor_t color)
		{
			FnTable.SetSceneColor(color);
		}

		public void GetBoundsColor(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor)
		{
			FnTable.GetBoundsColor(ref pOutputColorArray, nNumOutputColors, flCollisionBoundsFadeDistance, ref pOutputCameraColor);
		}

		public bool AreBoundsVisible()
		{
			return FnTable.AreBoundsVisible();
		}

		public void ForceBoundsVisible(bool bForce)
		{
			FnTable.ForceBoundsVisible(bForce);
		}
	}
	public class CVRChaperoneSetup
	{
		private IVRChaperoneSetup FnTable;

		internal CVRChaperoneSetup(IntPtr pInterface)
		{
			FnTable = (IVRChaperoneSetup)Marshal.PtrToStructure(pInterface, typeof(IVRChaperoneSetup));
		}

		public bool CommitWorkingCopy(EChaperoneConfigFile configFile)
		{
			return FnTable.CommitWorkingCopy(configFile);
		}

		public void RevertWorkingCopy()
		{
			FnTable.RevertWorkingCopy();
		}

		public bool GetWorkingPlayAreaSize(ref float pSizeX, ref float pSizeZ)
		{
			pSizeX = 0f;
			pSizeZ = 0f;
			return FnTable.GetWorkingPlayAreaSize(ref pSizeX, ref pSizeZ);
		}

		public bool GetWorkingPlayAreaRect(ref HmdQuad_t rect)
		{
			return FnTable.GetWorkingPlayAreaRect(ref rect);
		}

		public bool GetWorkingCollisionBoundsInfo(out HmdQuad_t[] pQuadsBuffer)
		{
			uint punQuadsCount = 0u;
			bool flag = FnTable.GetWorkingCollisionBoundsInfo(null, ref punQuadsCount);
			pQuadsBuffer = new HmdQuad_t[punQuadsCount];
			return FnTable.GetWorkingCollisionBoundsInfo(pQuadsBuffer, ref punQuadsCount);
		}

		public bool GetLiveCollisionBoundsInfo(out HmdQuad_t[] pQuadsBuffer)
		{
			uint punQuadsCount = 0u;
			bool flag = FnTable.GetLiveCollisionBoundsInfo(null, ref punQuadsCount);
			pQuadsBuffer = new HmdQuad_t[punQuadsCount];
			return FnTable.GetLiveCollisionBoundsInfo(pQuadsBuffer, ref punQuadsCount);
		}

		public bool GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose)
		{
			return FnTable.GetWorkingSeatedZeroPoseToRawTrackingPose(ref pmatSeatedZeroPoseToRawTrackingPose);
		}

		public bool GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose)
		{
			return FnTable.GetWorkingStandingZeroPoseToRawTrackingPose(ref pmatStandingZeroPoseToRawTrackingPose);
		}

		public void SetWorkingPlayAreaSize(float sizeX, float sizeZ)
		{
			FnTable.SetWorkingPlayAreaSize(sizeX, sizeZ);
		}

		public void SetWorkingCollisionBoundsInfo(HmdQuad_t[] pQuadsBuffer)
		{
			FnTable.SetWorkingCollisionBoundsInfo(pQuadsBuffer, (uint)pQuadsBuffer.Length);
		}

		public void SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose)
		{
			FnTable.SetWorkingSeatedZeroPoseToRawTrackingPose(ref pMatSeatedZeroPoseToRawTrackingPose);
		}

		public void SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose)
		{
			FnTable.SetWorkingStandingZeroPoseToRawTrackingPose(ref pMatStandingZeroPoseToRawTrackingPose);
		}

		public void ReloadFromDisk(EChaperoneConfigFile configFile)
		{
			FnTable.ReloadFromDisk(configFile);
		}

		public bool GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose)
		{
			return FnTable.GetLiveSeatedZeroPoseToRawTrackingPose(ref pmatSeatedZeroPoseToRawTrackingPose);
		}

		public void SetWorkingCollisionBoundsTagsInfo(byte[] pTagsBuffer)
		{
			FnTable.SetWorkingCollisionBoundsTagsInfo(pTagsBuffer, (uint)pTagsBuffer.Length);
		}

		public bool GetLiveCollisionBoundsTagsInfo(out byte[] pTagsBuffer)
		{
			uint punTagCount = 0u;
			bool flag = FnTable.GetLiveCollisionBoundsTagsInfo(null, ref punTagCount);
			pTagsBuffer = new byte[punTagCount];
			return FnTable.GetLiveCollisionBoundsTagsInfo(pTagsBuffer, ref punTagCount);
		}

		public bool SetWorkingPhysicalBoundsInfo(HmdQuad_t[] pQuadsBuffer)
		{
			return FnTable.SetWorkingPhysicalBoundsInfo(pQuadsBuffer, (uint)pQuadsBuffer.Length);
		}

		public bool GetLivePhysicalBoundsInfo(out HmdQuad_t[] pQuadsBuffer)
		{
			uint punQuadsCount = 0u;
			bool flag = FnTable.GetLivePhysicalBoundsInfo(null, ref punQuadsCount);
			pQuadsBuffer = new HmdQuad_t[punQuadsCount];
			return FnTable.GetLivePhysicalBoundsInfo(pQuadsBuffer, ref punQuadsCount);
		}

		public bool ExportLiveToBuffer(StringBuilder pBuffer, ref uint pnBufferLength)
		{
			pnBufferLength = 0u;
			return FnTable.ExportLiveToBuffer(pBuffer, ref pnBufferLength);
		}

		public bool ImportFromBufferToWorking(string pBuffer, uint nImportFlags)
		{
			return FnTable.ImportFromBufferToWorking(pBuffer, nImportFlags);
		}
	}
	public class CVRCompositor
	{
		private IVRCompositor FnTable;

		internal CVRCompositor(IntPtr pInterface)
		{
			FnTable = (IVRCompositor)Marshal.PtrToStructure(pInterface, typeof(IVRCompositor));
		}

		public void SetTrackingSpace(ETrackingUniverseOrigin eOrigin)
		{
			FnTable.SetTrackingSpace(eOrigin);
		}

		public ETrackingUniverseOrigin GetTrackingSpace()
		{
			return FnTable.GetTrackingSpace();
		}

		public EVRCompositorError WaitGetPoses(TrackedDevicePose_t[] pRenderPoseArray, TrackedDevicePose_t[] pGamePoseArray)
		{
			return FnTable.WaitGetPoses(pRenderPoseArray, (uint)pRenderPoseArray.Length, pGamePoseArray, (uint)pGamePoseArray.Length);
		}

		public EVRCompositorError GetLastPoses(TrackedDevicePose_t[] pRenderPoseArray, TrackedDevicePose_t[] pGamePoseArray)
		{
			return FnTable.GetLastPoses(pRenderPoseArray, (uint)pRenderPoseArray.Length, pGamePoseArray, (uint)pGamePoseArray.Length);
		}

		public EVRCompositorError GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose)
		{
			return FnTable.GetLastPoseForTrackedDeviceIndex(unDeviceIndex, ref pOutputPose, ref pOutputGamePose);
		}

		public EVRCompositorError Submit(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags)
		{
			return FnTable.Submit(eEye, ref pTexture, ref pBounds, nSubmitFlags);
		}

		public void ClearLastSubmittedFrame()
		{
			FnTable.ClearLastSubmittedFrame();
		}

		public void PostPresentHandoff()
		{
			FnTable.PostPresentHandoff();
		}

		public bool GetFrameTiming(ref Compositor_FrameTiming pTiming, uint unFramesAgo)
		{
			return FnTable.GetFrameTiming(ref pTiming, unFramesAgo);
		}

		public float GetFrameTimeRemaining()
		{
			return FnTable.GetFrameTimeRemaining();
		}

		public void FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground)
		{
			FnTable.FadeToColor(fSeconds, fRed, fGreen, fBlue, fAlpha, bBackground);
		}

		public void FadeGrid(float fSeconds, bool bFadeIn)
		{
			FnTable.FadeGrid(fSeconds, bFadeIn);
		}

		public EVRCompositorError SetSkyboxOverride(Texture_t[] pTextures)
		{
			return FnTable.SetSkyboxOverride(pTextures, (uint)pTextures.Length);
		}

		public void ClearSkyboxOverride()
		{
			FnTable.ClearSkyboxOverride();
		}

		public void CompositorBringToFront()
		{
			FnTable.CompositorBringToFront();
		}

		public void CompositorGoToBack()
		{
			FnTable.CompositorGoToBack();
		}

		public void CompositorQuit()
		{
			FnTable.CompositorQuit();
		}

		public bool IsFullscreen()
		{
			return FnTable.IsFullscreen();
		}

		public uint GetCurrentSceneFocusProcess()
		{
			return FnTable.GetCurrentSceneFocusProcess();
		}

		public uint GetLastFrameRenderer()
		{
			return FnTable.GetLastFrameRenderer();
		}

		public bool CanRenderScene()
		{
			return FnTable.CanRenderScene();
		}

		public void ShowMirrorWindow()
		{
			FnTable.ShowMirrorWindow();
		}

		public void HideMirrorWindow()
		{
			FnTable.HideMirrorWindow();
		}

		public bool IsMirrorWindowVisible()
		{
			return FnTable.IsMirrorWindowVisible();
		}

		public void CompositorDumpImages()
		{
			FnTable.CompositorDumpImages();
		}

		public bool ShouldAppRenderWithLowResources()
		{
			return FnTable.ShouldAppRenderWithLowResources();
		}

		public void ForceInterleavedReprojectionOn(bool bOverride)
		{
			FnTable.ForceInterleavedReprojectionOn(bOverride);
		}
	}
	public class CVROverlay
	{
		private IVROverlay FnTable;

		internal CVROverlay(IntPtr pInterface)
		{
			FnTable = (IVROverlay)Marshal.PtrToStructure(pInterface, typeof(IVROverlay));
		}

		public EVROverlayError FindOverlay(string pchOverlayKey, ref ulong pOverlayHandle)
		{
			pOverlayHandle = 0uL;
			return FnTable.FindOverlay(pchOverlayKey, ref pOverlayHandle);
		}

		public EVROverlayError CreateOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pOverlayHandle)
		{
			pOverlayHandle = 0uL;
			return FnTable.CreateOverlay(pchOverlayKey, pchOverlayFriendlyName, ref pOverlayHandle);
		}

		public EVROverlayError DestroyOverlay(ulong ulOverlayHandle)
		{
			return FnTable.DestroyOverlay(ulOverlayHandle);
		}

		public EVROverlayError SetHighQualityOverlay(ulong ulOverlayHandle)
		{
			return FnTable.SetHighQualityOverlay(ulOverlayHandle);
		}

		public ulong GetHighQualityOverlay()
		{
			return FnTable.GetHighQualityOverlay();
		}

		public uint GetOverlayKey(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError)
		{
			return FnTable.GetOverlayKey(ulOverlayHandle, pchValue, unBufferSize, ref pError);
		}

		public uint GetOverlayName(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError)
		{
			return FnTable.GetOverlayName(ulOverlayHandle, pchValue, unBufferSize, ref pError);
		}

		public EVROverlayError GetOverlayImageData(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight)
		{
			punWidth = 0u;
			punHeight = 0u;
			return FnTable.GetOverlayImageData(ulOverlayHandle, pvBuffer, unBufferSize, ref punWidth, ref punHeight);
		}

		public string GetOverlayErrorNameFromEnum(EVROverlayError error)
		{
			IntPtr ptr = FnTable.GetOverlayErrorNameFromEnum(error);
			return (string)Marshal.PtrToStructure(ptr, typeof(string));
		}

		public EVROverlayError SetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, bool bEnabled)
		{
			return FnTable.SetOverlayFlag(ulOverlayHandle, eOverlayFlag, bEnabled);
		}

		public EVROverlayError GetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, ref bool pbEnabled)
		{
			pbEnabled = false;
			return FnTable.GetOverlayFlag(ulOverlayHandle, eOverlayFlag, ref pbEnabled);
		}

		public EVROverlayError SetOverlayColor(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue)
		{
			return FnTable.SetOverlayColor(ulOverlayHandle, fRed, fGreen, fBlue);
		}

		public EVROverlayError GetOverlayColor(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue)
		{
			pfRed = 0f;
			pfGreen = 0f;
			pfBlue = 0f;
			return FnTable.GetOverlayColor(ulOverlayHandle, ref pfRed, ref pfGreen, ref pfBlue);
		}

		public EVROverlayError SetOverlayAlpha(ulong ulOverlayHandle, float fAlpha)
		{
			return FnTable.SetOverlayAlpha(ulOverlayHandle, fAlpha);
		}

		public EVROverlayError GetOverlayAlpha(ulong ulOverlayHandle, ref float pfAlpha)
		{
			pfAlpha = 0f;
			return FnTable.GetOverlayAlpha(ulOverlayHandle, ref pfAlpha);
		}

		public EVROverlayError SetOverlayWidthInMeters(ulong ulOverlayHandle, float fWidthInMeters)
		{
			return FnTable.SetOverlayWidthInMeters(ulOverlayHandle, fWidthInMeters);
		}

		public EVROverlayError GetOverlayWidthInMeters(ulong ulOverlayHandle, ref float pfWidthInMeters)
		{
			pfWidthInMeters = 0f;
			return FnTable.GetOverlayWidthInMeters(ulOverlayHandle, ref pfWidthInMeters);
		}

		public EVROverlayError SetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, float fMinDistanceInMeters, float fMaxDistanceInMeters)
		{
			return FnTable.SetOverlayAutoCurveDistanceRangeInMeters(ulOverlayHandle, fMinDistanceInMeters, fMaxDistanceInMeters);
		}

		public EVROverlayError GetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, ref float pfMinDistanceInMeters, ref float pfMaxDistanceInMeters)
		{
			pfMinDistanceInMeters = 0f;
			pfMaxDistanceInMeters = 0f;
			return FnTable.GetOverlayAutoCurveDistanceRangeInMeters(ulOverlayHandle, ref pfMinDistanceInMeters, ref pfMaxDistanceInMeters);
		}

		public EVROverlayError SetOverlayTextureColorSpace(ulong ulOverlayHandle, EColorSpace eTextureColorSpace)
		{
			return FnTable.SetOverlayTextureColorSpace(ulOverlayHandle, eTextureColorSpace);
		}

		public EVROverlayError GetOverlayTextureColorSpace(ulong ulOverlayHandle, ref EColorSpace peTextureColorSpace)
		{
			return FnTable.GetOverlayTextureColorSpace(ulOverlayHandle, ref peTextureColorSpace);
		}

		public EVROverlayError SetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds)
		{
			return FnTable.SetOverlayTextureBounds(ulOverlayHandle, ref pOverlayTextureBounds);
		}

		public EVROverlayError GetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds)
		{
			return FnTable.GetOverlayTextureBounds(ulOverlayHandle, ref pOverlayTextureBounds);
		}

		public EVROverlayError GetOverlayTransformType(ulong ulOverlayHandle, ref VROverlayTransformType peTransformType)
		{
			return FnTable.GetOverlayTransformType(ulOverlayHandle, ref peTransformType);
		}

		public EVROverlayError SetOverlayTransformAbsolute(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform)
		{
			return FnTable.SetOverlayTransformAbsolute(ulOverlayHandle, eTrackingOrigin, ref pmatTrackingOriginToOverlayTransform);
		}

		public EVROverlayError GetOverlayTransformAbsolute(ulong ulOverlayHandle, ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform)
		{
			return FnTable.GetOverlayTransformAbsolute(ulOverlayHandle, ref peTrackingOrigin, ref pmatTrackingOriginToOverlayTransform);
		}

		public EVROverlayError SetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, uint unTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform)
		{
			return FnTable.SetOverlayTransformTrackedDeviceRelative(ulOverlayHandle, unTrackedDevice, ref pmatTrackedDeviceToOverlayTransform);
		}

		public EVROverlayError GetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform)
		{
			punTrackedDevice = 0u;
			return FnTable.GetOverlayTransformTrackedDeviceRelative(ulOverlayHandle, ref punTrackedDevice, ref pmatTrackedDeviceToOverlayTransform);
		}

		public EVROverlayError SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, uint unDeviceIndex, string pchComponentName)
		{
			return FnTable.SetOverlayTransformTrackedDeviceComponent(ulOverlayHandle, unDeviceIndex, pchComponentName);
		}

		public EVROverlayError GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, ref uint punDeviceIndex, string pchComponentName, uint unComponentNameSize)
		{
			punDeviceIndex = 0u;
			return FnTable.GetOverlayTransformTrackedDeviceComponent(ulOverlayHandle, ref punDeviceIndex, pchComponentName, unComponentNameSize);
		}

		public EVROverlayError ShowOverlay(ulong ulOverlayHandle)
		{
			return FnTable.ShowOverlay(ulOverlayHandle);
		}

		public EVROverlayError HideOverlay(ulong ulOverlayHandle)
		{
			return FnTable.HideOverlay(ulOverlayHandle);
		}

		public bool IsOverlayVisible(ulong ulOverlayHandle)
		{
			return FnTable.IsOverlayVisible(ulOverlayHandle);
		}

		public EVROverlayError GetTransformForOverlayCoordinates(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, HmdVector2_t coordinatesInOverlay, ref HmdMatrix34_t pmatTransform)
		{
			return FnTable.GetTransformForOverlayCoordinates(ulOverlayHandle, eTrackingOrigin, coordinatesInOverlay, ref pmatTransform);
		}

		public bool PollNextOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pEvent, uint uncbVREvent)
		{
			return FnTable.PollNextOverlayEvent(ulOverlayHandle, ref pEvent, uncbVREvent);
		}

		public EVROverlayError GetOverlayInputMethod(ulong ulOverlayHandle, ref VROverlayInputMethod peInputMethod)
		{
			return FnTable.GetOverlayInputMethod(ulOverlayHandle, ref peInputMethod);
		}

		public EVROverlayError SetOverlayInputMethod(ulong ulOverlayHandle, VROverlayInputMethod eInputMethod)
		{
			return FnTable.SetOverlayInputMethod(ulOverlayHandle, eInputMethod);
		}

		public EVROverlayError GetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale)
		{
			return FnTable.GetOverlayMouseScale(ulOverlayHandle, ref pvecMouseScale);
		}

		public EVROverlayError SetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale)
		{
			return FnTable.SetOverlayMouseScale(ulOverlayHandle, ref pvecMouseScale);
		}

		public bool ComputeOverlayIntersection(ulong ulOverlayHandle, ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults)
		{
			return FnTable.ComputeOverlayIntersection(ulOverlayHandle, ref pParams, ref pResults);
		}

		public bool HandleControllerOverlayInteractionAsMouse(ulong ulOverlayHandle, uint unControllerDeviceIndex)
		{
			return FnTable.HandleControllerOverlayInteractionAsMouse(ulOverlayHandle, unControllerDeviceIndex);
		}

		public bool IsHoverTargetOverlay(ulong ulOverlayHandle)
		{
			return FnTable.IsHoverTargetOverlay(ulOverlayHandle);
		}

		public ulong GetGamepadFocusOverlay()
		{
			return FnTable.GetGamepadFocusOverlay();
		}

		public EVROverlayError SetGamepadFocusOverlay(ulong ulNewFocusOverlay)
		{
			return FnTable.SetGamepadFocusOverlay(ulNewFocusOverlay);
		}

		public EVROverlayError SetOverlayNeighbor(EOverlayDirection eDirection, ulong ulFrom, ulong ulTo)
		{
			return FnTable.SetOverlayNeighbor(eDirection, ulFrom, ulTo);
		}

		public EVROverlayError MoveGamepadFocusToNeighbor(EOverlayDirection eDirection, ulong ulFrom)
		{
			return FnTable.MoveGamepadFocusToNeighbor(eDirection, ulFrom);
		}

		public EVROverlayError SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture)
		{
			return FnTable.SetOverlayTexture(ulOverlayHandle, ref pTexture);
		}

		public EVROverlayError ClearOverlayTexture(ulong ulOverlayHandle)
		{
			return FnTable.ClearOverlayTexture(ulOverlayHandle);
		}

		public EVROverlayError SetOverlayRaw(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unDepth)
		{
			return FnTable.SetOverlayRaw(ulOverlayHandle, pvBuffer, unWidth, unHeight, unDepth);
		}

		public EVROverlayError SetOverlayFromFile(ulong ulOverlayHandle, string pchFilePath)
		{
			return FnTable.SetOverlayFromFile(ulOverlayHandle, pchFilePath);
		}

		public EVROverlayError CreateDashboardOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle)
		{
			pMainHandle = 0uL;
			pThumbnailHandle = 0uL;
			return FnTable.CreateDashboardOverlay(pchOverlayKey, pchOverlayFriendlyName, ref pMainHandle, ref pThumbnailHandle);
		}

		public bool IsDashboardVisible()
		{
			return FnTable.IsDashboardVisible();
		}

		public bool IsActiveDashboardOverlay(ulong ulOverlayHandle)
		{
			return FnTable.IsActiveDashboardOverlay(ulOverlayHandle);
		}

		public EVROverlayError SetDashboardOverlaySceneProcess(ulong ulOverlayHandle, uint unProcessId)
		{
			return FnTable.SetDashboardOverlaySceneProcess(ulOverlayHandle, unProcessId);
		}

		public EVROverlayError GetDashboardOverlaySceneProcess(ulong ulOverlayHandle, ref uint punProcessId)
		{
			punProcessId = 0u;
			return FnTable.GetDashboardOverlaySceneProcess(ulOverlayHandle, ref punProcessId);
		}

		public void ShowDashboard(string pchOverlayToShow)
		{
			FnTable.ShowDashboard(pchOverlayToShow);
		}

		public uint GetPrimaryDashboardDevice()
		{
			return FnTable.GetPrimaryDashboardDevice();
		}

		public EVROverlayError ShowKeyboard(int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue)
		{
			return FnTable.ShowKeyboard(eInputMode, eLineInputMode, pchDescription, unCharMax, pchExistingText, bUseMinimalMode, uUserValue);
		}

		public EVROverlayError ShowKeyboardForOverlay(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue)
		{
			return FnTable.ShowKeyboardForOverlay(ulOverlayHandle, eInputMode, eLineInputMode, pchDescription, unCharMax, pchExistingText, bUseMinimalMode, uUserValue);
		}

		public uint GetKeyboardText(StringBuilder pchText, uint cchText)
		{
			return FnTable.GetKeyboardText(pchText, cchText);
		}

		public void HideKeyboard()
		{
			FnTable.HideKeyboard();
		}

		public void SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform)
		{
			FnTable.SetKeyboardTransformAbsolute(eTrackingOrigin, ref pmatTrackingOriginToKeyboardTransform);
		}

		public void SetKeyboardPositionForOverlay(ulong ulOverlayHandle, HmdRect2_t avoidRect)
		{
			FnTable.SetKeyboardPositionForOverlay(ulOverlayHandle, avoidRect);
		}
	}
	public class CVRRenderModels
	{
		private IVRRenderModels FnTable;

		internal CVRRenderModels(IntPtr pInterface)
		{
			FnTable = (IVRRenderModels)Marshal.PtrToStructure(pInterface, typeof(IVRRenderModels));
		}

		public EVRRenderModelError LoadRenderModel_Async(string pchRenderModelName, ref IntPtr ppRenderModel)
		{
			return FnTable.LoadRenderModel_Async(pchRenderModelName, ref ppRenderModel);
		}

		public void FreeRenderModel(IntPtr pRenderModel)
		{
			FnTable.FreeRenderModel(pRenderModel);
		}

		public EVRRenderModelError LoadTexture_Async(int textureId, ref IntPtr ppTexture)
		{
			return FnTable.LoadTexture_Async(textureId, ref ppTexture);
		}

		public void FreeTexture(IntPtr pTexture)
		{
			FnTable.FreeTexture(pTexture);
		}

		public EVRRenderModelError LoadTextureD3D11_Async(int textureId, IntPtr pD3D11Device, ref IntPtr ppD3D11Texture2D)
		{
			return FnTable.LoadTextureD3D11_Async(textureId, pD3D11Device, ref ppD3D11Texture2D);
		}

		public EVRRenderModelError LoadIntoTextureD3D11_Async(int textureId, IntPtr pDstTexture)
		{
			return FnTable.LoadIntoTextureD3D11_Async(textureId, pDstTexture);
		}

		public void FreeTextureD3D11(IntPtr pD3D11Texture2D)
		{
			FnTable.FreeTextureD3D11(pD3D11Texture2D);
		}

		public uint GetRenderModelName(uint unRenderModelIndex, StringBuilder pchRenderModelName, uint unRenderModelNameLen)
		{
			return FnTable.GetRenderModelName(unRenderModelIndex, pchRenderModelName, unRenderModelNameLen);
		}

		public uint GetRenderModelCount()
		{
			return FnTable.GetRenderModelCount();
		}

		public uint GetComponentCount(string pchRenderModelName)
		{
			return FnTable.GetComponentCount(pchRenderModelName);
		}

		public uint GetComponentName(string pchRenderModelName, uint unComponentIndex, StringBuilder pchComponentName, uint unComponentNameLen)
		{
			return FnTable.GetComponentName(pchRenderModelName, unComponentIndex, pchComponentName, unComponentNameLen);
		}

		public ulong GetComponentButtonMask(string pchRenderModelName, string pchComponentName)
		{
			return FnTable.GetComponentButtonMask(pchRenderModelName, pchComponentName);
		}

		public uint GetComponentRenderModelName(string pchRenderModelName, string pchComponentName, StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen)
		{
			return FnTable.GetComponentRenderModelName(pchRenderModelName, pchComponentName, pchComponentRenderModelName, unComponentRenderModelNameLen);
		}

		public bool GetComponentState(string pchRenderModelName, string pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState)
		{
			return FnTable.GetComponentState(pchRenderModelName, pchComponentName, ref pControllerState, ref pState, ref pComponentState);
		}

		public bool RenderModelHasComponent(string pchRenderModelName, string pchComponentName)
		{
			return FnTable.RenderModelHasComponent(pchRenderModelName, pchComponentName);
		}
	}
	public class CVRNotifications
	{
		private IVRNotifications FnTable;

		internal CVRNotifications(IntPtr pInterface)
		{
			FnTable = (IVRNotifications)Marshal.PtrToStructure(pInterface, typeof(IVRNotifications));
		}

		public EVRNotificationError CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, string pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId)
		{
			pNotificationId = 0u;
			return FnTable.CreateNotification(ulOverlayHandle, ulUserValue, type, pchText, style, ref pImage, ref pNotificationId);
		}

		public EVRNotificationError RemoveNotification(uint notificationId)
		{
			return FnTable.RemoveNotification(notificationId);
		}
	}
	public class CVRSettings
	{
		private IVRSettings FnTable;

		internal CVRSettings(IntPtr pInterface)
		{
			FnTable = (IVRSettings)Marshal.PtrToStructure(pInterface, typeof(IVRSettings));
		}

		public string GetSettingsErrorNameFromEnum(EVRSettingsError eError)
		{
			IntPtr ptr = FnTable.GetSettingsErrorNameFromEnum(eError);
			return (string)Marshal.PtrToStructure(ptr, typeof(string));
		}

		public bool Sync(bool bForce, ref EVRSettingsError peError)
		{
			return FnTable.Sync(bForce, ref peError);
		}

		public bool GetBool(string pchSection, string pchSettingsKey, bool bDefaultValue, ref EVRSettingsError peError)
		{
			return FnTable.GetBool(pchSection, pchSettingsKey, bDefaultValue, ref peError);
		}

		public void SetBool(string pchSection, string pchSettingsKey, bool bValue, ref EVRSettingsError peError)
		{
			FnTable.SetBool(pchSection, pchSettingsKey, bValue, ref peError);
		}

		public int GetInt32(string pchSection, string pchSettingsKey, int nDefaultValue, ref EVRSettingsError peError)
		{
			return FnTable.GetInt32(pchSection, pchSettingsKey, nDefaultValue, ref peError);
		}

		public void SetInt32(string pchSection, string pchSettingsKey, int nValue, ref EVRSettingsError peError)
		{
			FnTable.SetInt32(pchSection, pchSettingsKey, nValue, ref peError);
		}

		public float GetFloat(string pchSection, string pchSettingsKey, float flDefaultValue, ref EVRSettingsError peError)
		{
			return FnTable.GetFloat(pchSection, pchSettingsKey, flDefaultValue, ref peError);
		}

		public void SetFloat(string pchSection, string pchSettingsKey, float flValue, ref EVRSettingsError peError)
		{
			FnTable.SetFloat(pchSection, pchSettingsKey, flValue, ref peError);
		}

		public void GetString(string pchSection, string pchSettingsKey, string pchValue, uint unValueLen, string pchDefaultValue, ref EVRSettingsError peError)
		{
			FnTable.GetString(pchSection, pchSettingsKey, pchValue, unValueLen, pchDefaultValue, ref peError);
		}

		public void SetString(string pchSection, string pchSettingsKey, string pchValue, ref EVRSettingsError peError)
		{
			FnTable.SetString(pchSection, pchSettingsKey, pchValue, ref peError);
		}

		public void RemoveSection(string pchSection, ref EVRSettingsError peError)
		{
			FnTable.RemoveSection(pchSection, ref peError);
		}

		public void RemoveKeyInSection(string pchSection, string pchSettingsKey, ref EVRSettingsError peError)
		{
			FnTable.RemoveKeyInSection(pchSection, pchSettingsKey, ref peError);
		}
	}
	public class CVRTrackedCamera
	{
		private IVRTrackedCamera FnTable;

		internal CVRTrackedCamera(IntPtr pInterface)
		{
			FnTable = (IVRTrackedCamera)Marshal.PtrToStructure(pInterface, typeof(IVRTrackedCamera));
		}

		public bool HasCamera(uint nDeviceIndex)
		{
			return FnTable.HasCamera(nDeviceIndex);
		}

		public bool GetCameraFirmwareDescription(uint nDeviceIndex, string pBuffer, uint nBufferLen)
		{
			return FnTable.GetCameraFirmwareDescription(nDeviceIndex, pBuffer, nBufferLen);
		}

		public bool GetCameraFrameDimensions(uint nDeviceIndex, ECameraVideoStreamFormat nVideoStreamFormat, ref uint pWidth, ref uint pHeight)
		{
			pWidth = 0u;
			pHeight = 0u;
			return FnTable.GetCameraFrameDimensions(nDeviceIndex, nVideoStreamFormat, ref pWidth, ref pHeight);
		}

		public bool SetCameraVideoStreamFormat(uint nDeviceIndex, ECameraVideoStreamFormat nVideoStreamFormat)
		{
			return FnTable.SetCameraVideoStreamFormat(nDeviceIndex, nVideoStreamFormat);
		}

		public ECameraVideoStreamFormat GetCameraVideoStreamFormat(uint nDeviceIndex)
		{
			return FnTable.GetCameraVideoStreamFormat(nDeviceIndex);
		}

		public bool EnableCameraForStreaming(uint nDeviceIndex, bool bEnable)
		{
			return FnTable.EnableCameraForStreaming(nDeviceIndex, bEnable);
		}

		public bool StartVideoStream(uint nDeviceIndex)
		{
			return FnTable.StartVideoStream(nDeviceIndex);
		}

		public bool StopVideoStream(uint nDeviceIndex)
		{
			return FnTable.StopVideoStream(nDeviceIndex);
		}

		public bool IsVideoStreamActive(uint nDeviceIndex, ref bool pbPaused, ref float pflElapsedTime)
		{
			pbPaused = false;
			pflElapsedTime = 0f;
			return FnTable.IsVideoStreamActive(nDeviceIndex, ref pbPaused, ref pflElapsedTime);
		}

		public CameraVideoStreamFrame_t GetVideoStreamFrame(uint nDeviceIndex)
		{
			IntPtr ptr = FnTable.GetVideoStreamFrame(nDeviceIndex);
			return (CameraVideoStreamFrame_t)Marshal.PtrToStructure(ptr, typeof(CameraVideoStreamFrame_t));
		}

		public bool ReleaseVideoStreamFrame(uint nDeviceIndex, ref CameraVideoStreamFrame_t pFrameImage)
		{
			return FnTable.ReleaseVideoStreamFrame(nDeviceIndex, ref pFrameImage);
		}

		public bool SetAutoExposure(uint nDeviceIndex, bool bEnable)
		{
			return FnTable.SetAutoExposure(nDeviceIndex, bEnable);
		}

		public bool PauseVideoStream(uint nDeviceIndex)
		{
			return FnTable.PauseVideoStream(nDeviceIndex);
		}

		public bool ResumeVideoStream(uint nDeviceIndex)
		{
			return FnTable.ResumeVideoStream(nDeviceIndex);
		}

		public bool GetCameraDistortion(uint nDeviceIndex, float flInputU, float flInputV, ref float pflOutputU, ref float pflOutputV)
		{
			pflOutputU = 0f;
			pflOutputV = 0f;
			return FnTable.GetCameraDistortion(nDeviceIndex, flInputU, flInputV, ref pflOutputU, ref pflOutputV);
		}

		public bool GetCameraProjection(uint nDeviceIndex, float flWidthPixels, float flHeightPixels, float flZNear, float flZFar, ref HmdMatrix44_t pProjection)
		{
			return FnTable.GetCameraProjection(nDeviceIndex, flWidthPixels, flHeightPixels, flZNear, flZFar, ref pProjection);
		}

		public bool GetRecommendedCameraUndistortion(uint nDeviceIndex, ref uint pUndistortionWidthPixels, ref uint pUndistortionHeightPixels)
		{
			pUndistortionWidthPixels = 0u;
			pUndistortionHeightPixels = 0u;
			return FnTable.GetRecommendedCameraUndistortion(nDeviceIndex, ref pUndistortionWidthPixels, ref pUndistortionHeightPixels);
		}

		public bool SetCameraUndistortion(uint nDeviceIndex, uint nUndistortionWidthPixels, uint nUndistortionHeightPixels)
		{
			return FnTable.SetCameraUndistortion(nDeviceIndex, nUndistortionWidthPixels, nUndistortionHeightPixels);
		}

		public void RequestVideoServicesForTool()
		{
			FnTable.RequestVideoServicesForTool();
		}

		public void ReleaseVideoServicesForTool()
		{
			FnTable.ReleaseVideoServicesForTool();
		}

		public bool GetVideoStreamFrameSharedTextureGL(bool bUndistorted, ref uint pglTextureId, IntPtr pglSharedTextureHandle)
		{
			pglTextureId = 0u;
			return FnTable.GetVideoStreamFrameSharedTextureGL(bUndistorted, ref pglTextureId, pglSharedTextureHandle);
		}

		public bool ReleaseVideoStreamFrameSharedTextureGL(uint glTextureId, IntPtr glSharedTextureHandle)
		{
			return FnTable.ReleaseVideoStreamFrameSharedTextureGL(glTextureId, glSharedTextureHandle);
		}

		public void LockSharedTextureGL(IntPtr glSharedTextureHandle, ref CameraVideoStreamFrame_t pFrameImage)
		{
			FnTable.LockSharedTextureGL(glSharedTextureHandle, ref pFrameImage);
		}

		public void UnlockSharedTextureGL(IntPtr glSharedTextureHandle)
		{
			FnTable.UnlockSharedTextureGL(glSharedTextureHandle);
		}
	}
	public class OpenVRInterop
	{
		[DllImport("openvr_api", EntryPoint = "VR_InitInternal")]
		internal static extern uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType);

		[DllImport("openvr_api", EntryPoint = "VR_ShutdownInternal")]
		internal static extern void ShutdownInternal();

		[DllImport("openvr_api", EntryPoint = "VR_IsHmdPresent")]
		internal static extern bool IsHmdPresent();

		[DllImport("openvr_api", EntryPoint = "VR_IsRuntimeInstalled")]
		internal static extern bool IsRuntimeInstalled();

		[DllImport("openvr_api", EntryPoint = "VR_GetStringForHmdError")]
		internal static extern IntPtr GetStringForHmdError(EVRInitError error);

		[DllImport("openvr_api", EntryPoint = "VR_GetGenericInterface")]
		internal static extern IntPtr GetGenericInterface([In][MarshalAs(UnmanagedType.LPStr)] string pchInterfaceVersion, ref EVRInitError peError);

		[DllImport("openvr_api", EntryPoint = "VR_IsInterfaceVersionValid")]
		internal static extern bool IsInterfaceVersionValid([In][MarshalAs(UnmanagedType.LPStr)] string pchInterfaceVersion);

		[DllImport("openvr_api", EntryPoint = "VR_GetInitToken")]
		internal static extern uint GetInitToken();
	}
	public enum EVREye
	{
		Eye_Left,
		Eye_Right
	}
	public enum EGraphicsAPIConvention
	{
		API_DirectX,
		API_OpenGL
	}
	public enum EColorSpace
	{
		Auto,
		Gamma,
		Linear
	}
	public enum ETrackingResult
	{
		Uninitialized = 1,
		Calibrating_InProgress = 100,
		Calibrating_OutOfRange = 101,
		Running_OK = 200,
		Running_OutOfRange = 201
	}
	public enum ETrackedDeviceClass
	{
		Invalid = 0,
		HMD = 1,
		Controller = 2,
		TrackingReference = 4,
		Other = 1000
	}
	public enum ETrackedControllerRole
	{
		Invalid,
		LeftHand,
		RightHand
	}
	public enum ETrackingUniverseOrigin
	{
		TrackingUniverseSeated,
		TrackingUniverseStanding,
		TrackingUniverseRawAndUncalibrated
	}
	public enum ETrackedDeviceProperty
	{
		Prop_TrackingSystemName_String = 1000,
		Prop_ModelNumber_String = 1001,
		Prop_SerialNumber_String = 1002,
		Prop_RenderModelName_String = 1003,
		Prop_WillDriftInYaw_Bool = 1004,
		Prop_ManufacturerName_String = 1005,
		Prop_TrackingFirmwareVersion_String = 1006,
		Prop_HardwareRevision_String = 1007,
		Prop_AllWirelessDongleDescriptions_String = 1008,
		Prop_ConnectedWirelessDongle_String = 1009,
		Prop_DeviceIsWireless_Bool = 1010,
		Prop_DeviceIsCharging_Bool = 1011,
		Prop_DeviceBatteryPercentage_Float = 1012,
		Prop_StatusDisplayTransform_Matrix34 = 1013,
		Prop_Firmware_UpdateAvailable_Bool = 1014,
		Prop_Firmware_ManualUpdate_Bool = 1015,
		Prop_Firmware_ManualUpdateURL_String = 1016,
		Prop_HardwareRevision_Uint64 = 1017,
		Prop_FirmwareVersion_Uint64 = 1018,
		Prop_FPGAVersion_Uint64 = 1019,
		Prop_VRCVersion_Uint64 = 1020,
		Prop_RadioVersion_Uint64 = 1021,
		Prop_DongleVersion_Uint64 = 1022,
		Prop_BlockServerShutdown_Bool = 1023,
		Prop_CanUnifyCoordinateSystemWithHmd_Bool = 1024,
		Prop_ContainsProximitySensor_Bool = 1025,
		Prop_DeviceProvidesBatteryStatus_Bool = 1026,
		Prop_DeviceCanPowerOff_Bool = 1027,
		Prop_Firmware_ProgrammingTarget_String = 1028,
		Prop_DeviceClass_Int32 = 1029,
		Prop_HasCamera_Bool = 1030,
		Prop_ReportsTimeSinceVSync_Bool = 2000,
		Prop_SecondsFromVsyncToPhotons_Float = 2001,
		Prop_DisplayFrequency_Float = 2002,
		Prop_UserIpdMeters_Float = 2003,
		Prop_CurrentUniverseId_Uint64 = 2004,
		Prop_PreviousUniverseId_Uint64 = 2005,
		Prop_DisplayFirmwareVersion_Uint64 = 2006,
		Prop_IsOnDesktop_Bool = 2007,
		Prop_DisplayMCType_Int32 = 2008,
		Prop_DisplayMCOffset_Float = 2009,
		Prop_DisplayMCScale_Float = 2010,
		Prop_EdidVendorID_Int32 = 2011,
		Prop_DisplayMCImageLeft_String = 2012,
		Prop_DisplayMCImageRight_String = 2013,
		Prop_DisplayGCBlackClamp_Float = 2014,
		Prop_EdidProductID_Int32 = 2015,
		Prop_CameraToHeadTransform_Matrix34 = 2016,
		Prop_DisplayGCType_Int32 = 2017,
		Prop_DisplayGCOffset_Float = 2018,
		Prop_DisplayGCScale_Float = 2019,
		Prop_DisplayGCPrescale_Float = 2020,
		Prop_DisplayGCImage_String = 2021,
		Prop_LensCenterLeftU_Float = 2022,
		Prop_LensCenterLeftV_Float = 2023,
		Prop_LensCenterRightU_Float = 2024,
		Prop_LensCenterRightV_Float = 2025,
		Prop_UserHeadToEyeDepthMeters_Float = 2026,
		Prop_CameraFirmwareVersion_Uint64 = 2027,
		Prop_CameraFirmwareDescription_String = 2028,
		Prop_DisplayFPGAVersion_Uint64 = 2029,
		Prop_DisplayBootloaderVersion_Uint64 = 2030,
		Prop_DisplayHardwareVersion_Uint64 = 2031,
		Prop_AudioFirmwareVersion_Uint64 = 2032,
		Prop_AttachedDeviceId_String = 3000,
		Prop_SupportedButtons_Uint64 = 3001,
		Prop_Axis0Type_Int32 = 3002,
		Prop_Axis1Type_Int32 = 3003,
		Prop_Axis2Type_Int32 = 3004,
		Prop_Axis3Type_Int32 = 3005,
		Prop_Axis4Type_Int32 = 3006,
		Prop_FieldOfViewLeftDegrees_Float = 4000,
		Prop_FieldOfViewRightDegrees_Float = 4001,
		Prop_FieldOfViewTopDegrees_Float = 4002,
		Prop_FieldOfViewBottomDegrees_Float = 4003,
		Prop_TrackingRangeMinimumMeters_Float = 4004,
		Prop_TrackingRangeMaximumMeters_Float = 4005,
		Prop_ModeLabel_String = 4006,
		Prop_VendorSpecific_Reserved_Start = 10000,
		Prop_VendorSpecific_Reserved_End = 10999
	}
	public enum ETrackedPropertyError
	{
		TrackedProp_Success,
		TrackedProp_WrongDataType,
		TrackedProp_WrongDeviceClass,
		TrackedProp_BufferTooSmall,
		TrackedProp_UnknownProperty,
		TrackedProp_InvalidDevice,
		TrackedProp_CouldNotContactServer,
		TrackedProp_ValueNotProvidedByDevice,
		TrackedProp_StringExceedsMaximumLength,
		TrackedProp_NotYetAvailable
	}
	public enum EVRSubmitFlags
	{
		Submit_Default,
		Submit_LensDistortionAlreadyApplied,
		Submit_GlRenderBuffer
	}
	public enum EVRState
	{
		Undefined = -1,
		Off,
		Searching,
		Searching_Alert,
		Ready,
		Ready_Alert,
		NotReady
	}
	public enum EVREventType
	{
		VREvent_None = 0,
		VREvent_TrackedDeviceActivated = 100,
		VREvent_TrackedDeviceDeactivated = 101,
		VREvent_TrackedDeviceUpdated = 102,
		VREvent_TrackedDeviceUserInteractionStarted = 103,
		VREvent_TrackedDeviceUserInteractionEnded = 104,
		VREvent_IpdChanged = 105,
		VREvent_EnterStandbyMode = 106,
		VREvent_LeaveStandbyMode = 107,
		VREvent_TrackedDeviceRoleChanged = 108,
		VREvent_ButtonPress = 200,
		VREvent_ButtonUnpress = 201,
		VREvent_ButtonTouch = 202,
		VREvent_ButtonUntouch = 203,
		VREvent_MouseMove = 300,
		VREvent_MouseButtonDown = 301,
		VREvent_MouseButtonUp = 302,
		VREvent_FocusEnter = 303,
		VREvent_FocusLeave = 304,
		VREvent_Scroll = 305,
		VREvent_TouchPadMove = 306,
		VREvent_InputFocusCaptured = 400,
		VREvent_InputFocusReleased = 401,
		VREvent_SceneFocusLost = 402,
		VREvent_SceneFocusGained = 403,
		VREvent_SceneApplicationChanged = 404,
		VREvent_SceneFocusChanged = 405,
		VREvent_HideRenderModels = 410,
		VREvent_ShowRenderModels = 411,
		VREvent_OverlayShown = 500,
		VREvent_OverlayHidden = 501,
		VREvent_DashboardActivated = 502,
		VREvent_DashboardDeactivated = 503,
		VREvent_DashboardThumbSelected = 504,
		VREvent_DashboardRequested = 505,
		VREvent_ResetDashboard = 506,
		VREvent_RenderToast = 507,
		VREvent_ImageLoaded = 508,
		VREvent_ShowKeyboard = 509,
		VREvent_HideKeyboard = 510,
		VREvent_OverlayGamepadFocusGained = 511,
		VREvent_OverlayGamepadFocusLost = 512,
		VREvent_Notification_Shown = 600,
		VREvent_Notification_Hidden = 601,
		VREvent_Notification_BeginInteraction = 602,
		VREvent_Notification_Destroyed = 603,
		VREvent_Quit = 700,
		VREvent_ProcessQuit = 701,
		VREvent_QuitAborted_UserPrompt = 702,
		VREvent_QuitAcknowledged = 703,
		VREvent_ChaperoneDataHasChanged = 800,
		VREvent_ChaperoneUniverseHasChanged = 801,
		VREvent_ChaperoneTempDataHasChanged = 802,
		VREvent_ChaperoneSettingsHaveChanged = 803,
		VREvent_SeatedZeroPoseReset = 804,
		VREvent_BackgroundSettingHasChanged = 850,
		VREvent_CameraSettingsHaveChanged = 851,
		VREvent_StatusUpdate = 900,
		VREvent_MCImageUpdated = 1000,
		VREvent_FirmwareUpdateStarted = 1100,
		VREvent_FirmwareUpdateFinished = 1101,
		VREvent_KeyboardClosed = 1200,
		VREvent_KeyboardCharInput = 1201,
		VREvent_KeyboardDone = 1202,
		VREvent_ApplicationTransitionStarted = 1300,
		VREvent_ApplicationTransitionAborted = 1301,
		VREvent_ApplicationTransitionNewAppStarted = 1302,
		VREvent_Compositor_MirrorWindowShown = 1400,
		VREvent_Compositor_MirrorWindowHidden = 1401,
		VREvent_Compositor_ChaperoneBoundsShown = 1410,
		VREvent_Compositor_ChaperoneBoundsHidden = 1411,
		VREvent_TrackedCamera_StartVideoStream = 1500,
		VREvent_TrackedCamera_StopVideoStream = 1501,
		VREvent_TrackedCamera_PauseVideoStream = 1502,
		VREvent_TrackedCamera_ResumeVideoStream = 1503,
		VREvent_PerformanceTest_EnableCapture = 1600,
		VREvent_PerformanceTest_DisableCapture = 1601,
		VREvent_PerformanceTest_FidelityLevel = 1602,
		VREvent_VendorSpecific_Reserved_Start = 10000,
		VREvent_VendorSpecific_Reserved_End = 19999
	}
	public enum EDeviceActivityLevel
	{
		k_EDeviceActivityLevel_Unknown = -1,
		k_EDeviceActivityLevel_Idle,
		k_EDeviceActivityLevel_UserInteraction,
		k_EDeviceActivityLevel_UserInteraction_Timeout,
		k_EDeviceActivityLevel_Standby
	}
	public enum EVRButtonId
	{
		k_EButton_System = 0,
		k_EButton_ApplicationMenu = 1,
		k_EButton_Grip = 2,
		k_EButton_DPad_Left = 3,
		k_EButton_DPad_Up = 4,
		k_EButton_DPad_Right = 5,
		k_EButton_DPad_Down = 6,
		k_EButton_A = 7,
		k_EButton_Axis0 = 32,
		k_EButton_Axis1 = 33,
		k_EButton_Axis2 = 34,
		k_EButton_Axis3 = 35,
		k_EButton_Axis4 = 36,
		k_EButton_SteamVR_Touchpad = 32,
		k_EButton_SteamVR_Trigger = 33,
		k_EButton_Dashboard_Back = 2,
		k_EButton_Max = 64
	}
	public enum EVRMouseButton
	{
		Left = 1,
		Right = 2,
		Middle = 4
	}
	public enum EVRControllerAxisType
	{
		k_eControllerAxis_None,
		k_eControllerAxis_TrackPad,
		k_eControllerAxis_Joystick,
		k_eControllerAxis_Trigger
	}
	public enum EVRControllerEventOutputType
	{
		ControllerEventOutput_OSEvents,
		ControllerEventOutput_VREvents
	}
	public enum ECollisionBoundsStyle
	{
		COLLISION_BOUNDS_STYLE_BEGINNER,
		COLLISION_BOUNDS_STYLE_INTERMEDIATE,
		COLLISION_BOUNDS_STYLE_SQUARES,
		COLLISION_BOUNDS_STYLE_ADVANCED,
		COLLISION_BOUNDS_STYLE_NONE,
		COLLISION_BOUNDS_STYLE_COUNT
	}
	public enum EVROverlayError
	{
		None = 0,
		UnknownOverlay = 10,
		InvalidHandle = 11,
		PermissionDenied = 12,
		OverlayLimitExceeded = 13,
		WrongVisibilityType = 14,
		KeyTooLong = 15,
		NameTooLong = 16,
		KeyInUse = 17,
		WrongTransformType = 18,
		InvalidTrackedDevice = 19,
		InvalidParameter = 20,
		ThumbnailCantBeDestroyed = 21,
		ArrayTooSmall = 22,
		RequestFailed = 23,
		InvalidTexture = 24,
		UnableToLoadFile = 25,
		VROVerlayError_KeyboardAlreadyInUse = 26,
		NoNeighbor = 27
	}
	public enum EVRApplicationType
	{
		VRApplication_Other,
		VRApplication_Scene,
		VRApplication_Overlay,
		VRApplication_Background,
		VRApplication_Utility
	}
	public enum EVRFirmwareError
	{
		None,
		Success,
		Fail
	}
	public enum EVRNotificationError
	{
		OK = 0,
		InvalidNotificationId = 100,
		NotificationQueueFull = 101,
		InvalidOverlayHandle = 102
	}
	public enum EVRInitError
	{
		None = 0,
		Unknown = 1,
		Init_InstallationNotFound = 100,
		Init_InstallationCorrupt = 101,
		Init_VRClientDLLNotFound = 102,
		Init_FileNotFound = 103,
		Init_FactoryNotFound = 104,
		Init_InterfaceNotFound = 105,
		Init_InvalidInterface = 106,
		Init_UserConfigDirectoryInvalid = 107,
		Init_HmdNotFound = 108,
		Init_NotInitialized = 109,
		Init_PathRegistryNotFound = 110,
		Init_NoConfigPath = 111,
		Init_NoLogPath = 112,
		Init_PathRegistryNotWritable = 113,
		Init_AppInfoInitFailed = 114,
		Init_Retry = 115,
		Init_InitCanceledByUser = 116,
		Init_AnotherAppLaunching = 117,
		Init_SettingsInitFailed = 118,
		Init_ShuttingDown = 119,
		Init_TooManyObjects = 120,
		Init_NoServerForBackgroundApp = 121,
		Init_NotSupportedWithCompositor = 122,
		Init_NotAvailableToUtilityApps = 123,
		Driver_Failed = 200,
		Driver_Unknown = 201,
		Driver_HmdUnknown = 202,
		Driver_NotLoaded = 203,
		Driver_RuntimeOutOfDate = 204,
		Driver_HmdInUse = 205,
		Driver_NotCalibrated = 206,
		Driver_CalibrationInvalid = 207,
		Driver_HmdDisplayNotFound = 208,
		IPC_ServerInitFailed = 300,
		IPC_ConnectFailed = 301,
		IPC_SharedStateInitFailed = 302,
		IPC_CompositorInitFailed = 303,
		IPC_MutexInitFailed = 304,
		IPC_Failed = 305,
		Compositor_Failed = 400,
		Compositor_D3D11HardwareRequired = 401,
		VendorSpecific_UnableToConnectToOculusRuntime = 1000,
		VendorSpecific_HmdFound_CantOpenDevice = 1101,
		VendorSpecific_HmdFound_UnableToRequestConfigStart = 1102,
		VendorSpecific_HmdFound_NoStoredConfig = 1103,
		VendorSpecific_HmdFound_ConfigTooBig = 1104,
		VendorSpecific_HmdFound_ConfigTooSmall = 1105,
		VendorSpecific_HmdFound_UnableToInitZLib = 1106,
		VendorSpecific_HmdFound_CantReadFirmwareVersion = 1107,
		VendorSpecific_HmdFound_UnableToSendUserDataStart = 1108,
		VendorSpecific_HmdFound_UnableToGetUserDataStart = 1109,
		VendorSpecific_HmdFound_UnableToGetUserDataNext = 1110,
		VendorSpecific_HmdFound_UserDataAddressRange = 1111,
		VendorSpecific_HmdFound_UserDataError = 1112,
		VendorSpecific_HmdFound_ConfigFailedSanityCheck = 1113,
		Steam_SteamInstallationNotFound = 2000
	}
	public enum EVRApplicationError
	{
		None = 0,
		AppKeyAlreadyExists = 100,
		NoManifest = 101,
		NoApplication = 102,
		InvalidIndex = 103,
		UnknownApplication = 104,
		IPCFailed = 105,
		ApplicationAlreadyRunning = 106,
		InvalidManifest = 107,
		InvalidApplication = 108,
		LaunchFailed = 109,
		ApplicationAlreadyStarting = 110,
		LaunchInProgress = 111,
		OldApplicationQuitting = 112,
		TransitionAborted = 113,
		BufferTooSmall = 200,
		PropertyNotSet = 201,
		UnknownProperty = 202
	}
	public enum EVRApplicationProperty
	{
		Name_String = 0,
		LaunchType_String = 11,
		WorkingDirectory_String = 12,
		BinaryPath_String = 13,
		Arguments_String = 14,
		URL_String = 15,
		Description_String = 50,
		NewsURL_String = 51,
		ImagePath_String = 52,
		Source_String = 53,
		IsDashboardOverlay_Bool = 60,
		LastLaunchTime_Uint64 = 70
	}
	public enum EVRApplicationTransitionState
	{
		VRApplicationTransition_None = 0,
		VRApplicationTransition_OldAppQuitSent = 10,
		VRApplicationTransition_WaitingForExternalLaunch = 11,
		VRApplicationTransition_NewAppLaunched = 20
	}
	public enum ChaperoneCalibrationState
	{
		OK = 1,
		Warning = 100,
		Warning_BaseStationMayHaveMoved = 101,
		Warning_BaseStationRemoved = 102,
		Warning_SeatedBoundsInvalid = 103,
		Error = 200,
		Error_BaseStationUninitalized = 201,
		Error_BaseStationConflict = 202,
		Error_PlayAreaInvalid = 203,
		Error_CollisionBoundsInvalid = 204
	}
	public enum EChaperoneConfigFile
	{
		Live = 1,
		Temp
	}
	public enum EChaperoneImportFlags
	{
		EChaperoneImport_BoundsOnly = 1
	}
	public enum EVRCompositorError
	{
		None = 0,
		IncompatibleVersion = 100,
		DoNotHaveFocus = 101,
		InvalidTexture = 102,
		IsNotSceneApplication = 103,
		TextureIsOnWrongDevice = 104,
		TextureUsesUnsupportedFormat = 105,
		SharedTexturesNotSupported = 106,
		IndexOutOfRange = 107
	}
	public enum VROverlayInputMethod
	{
		None,
		Mouse
	}
	public enum VROverlayTransformType
	{
		VROverlayTransform_Absolute,
		VROverlayTransform_TrackedDeviceRelative,
		VROverlayTransform_SystemOverlay,
		VROverlayTransform_TrackedComponent
	}
	public enum VROverlayFlags
	{
		None,
		Curved,
		RGSS4X,
		NoDashboardTab,
		AcceptsGamepadEvents,
		ShowGamepadFocus,
		SendVRScrollEvents,
		SendVRTouchpadEvents,
		ShowTouchPadScrollWheel
	}
	public enum EGamepadTextInputMode
	{
		k_EGamepadTextInputModeNormal,
		k_EGamepadTextInputModePassword,
		k_EGamepadTextInputModeSubmit
	}
	public enum EGamepadTextInputLineMode
	{
		k_EGamepadTextInputLineModeSingleLine,
		k_EGamepadTextInputLineModeMultipleLines
	}
	public enum EOverlayDirection
	{
		Up,
		Down,
		Left,
		Right,
		Count
	}
	public enum EVRRenderModelError
	{
		None = 0,
		Loading = 100,
		NotSupported = 200,
		InvalidArg = 300,
		InvalidModel = 301,
		NoShapes = 302,
		MultipleShapes = 303,
		TooManyIndices = 304,
		MultipleTextures = 305,
		InvalidTexture = 400
	}
	public enum EVRComponentProperty
	{
		IsStatic = 1,
		IsVisible = 2,
		IsTouched = 4,
		IsPressed = 8,
		IsScrolled = 0x10
	}
	public enum EVRNotificationType
	{
		Transient,
		Persistent
	}
	public enum EVRNotificationStyle
	{
		None = 0,
		Application = 100,
		Contact_Disabled = 200,
		Contact_Enabled = 201,
		Contact_Active = 202
	}
	public enum EVRSettingsError
	{
		None,
		IPCFailed,
		WriteFailed,
		ReadFailed
	}
	public enum ECameraVideoStreamFormat
	{
		CVS_FORMAT_UNKNOWN,
		CVS_FORMAT_RAW10,
		CVS_FORMAT_NV12,
		CVS_FORMAT_RGB24,
		CVS_MAX_FORMATS
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct VREvent_Data_t
	{
		[FieldOffset(0)]
		public VREvent_Reserved_t reserved;

		[FieldOffset(0)]
		public VREvent_Controller_t controller;

		[FieldOffset(0)]
		public VREvent_Mouse_t mouse;

		[FieldOffset(0)]
		public VREvent_Scroll_t scroll;

		[FieldOffset(0)]
		public VREvent_Process_t process;

		[FieldOffset(0)]
		public VREvent_Notification_t notification;

		[FieldOffset(0)]
		public VREvent_Overlay_t overlay;

		[FieldOffset(0)]
		public VREvent_Status_t status;

		[FieldOffset(0)]
		public VREvent_Ipd_t ipd;

		[FieldOffset(0)]
		public VREvent_Chaperone_t chaperone;

		[FieldOffset(0)]
		public VREvent_PerformanceTest_t performanceTest;

		[FieldOffset(0)]
		public VREvent_TouchPadMove_t touchPadMove;

		[FieldOffset(0)]
		public VREvent_SeatedZeroPoseReset_t seatedZeroPoseReset;

		[FieldOffset(0)]
		public VREvent_Keyboard_t keyboard;
	}
	public struct HmdMatrix34_t
	{
		public float m0;

		public float m1;

		public float m2;

		public float m3;

		public float m4;

		public float m5;

		public float m6;

		public float m7;

		public float m8;

		public float m9;

		public float m10;

		public float m11;
	}
	public struct HmdMatrix44_t
	{
		public float m0;

		public float m1;

		public float m2;

		public float m3;

		public float m4;

		public float m5;

		public float m6;

		public float m7;

		public float m8;

		public float m9;

		public float m10;

		public float m11;

		public float m12;

		public float m13;

		public float m14;

		public float m15;
	}
	public struct HmdVector3_t
	{
		public float v0;

		public float v1;

		public float v2;
	}
	public struct HmdVector4_t
	{
		public float v0;

		public float v1;

		public float v2;

		public float v3;
	}
	public struct HmdVector3d_t
	{
		public double v0;

		public double v1;

		public double v2;
	}
	public struct HmdVector2_t
	{
		public float v0;

		public float v1;
	}
	public struct HmdQuaternion_t
	{
		public double w;

		public double x;

		public double y;

		public double z;
	}
	public struct HmdColor_t
	{
		public float r;

		public float g;

		public float b;

		public float a;
	}
	public struct HmdQuad_t
	{
		public HmdVector3_t vCorners0;

		public HmdVector3_t vCorners1;

		public HmdVector3_t vCorners2;

		public HmdVector3_t vCorners3;
	}
	public struct HmdRect2_t
	{
		public HmdVector2_t vTopLeft;

		public HmdVector2_t vBottomRight;
	}
	public struct DistortionCoordinates_t
	{
		public float rfRed0;

		public float rfRed1;

		public float rfGreen0;

		public float rfGreen1;

		public float rfBlue0;

		public float rfBlue1;
	}
	public struct Texture_t
	{
		public IntPtr handle;

		public EGraphicsAPIConvention eType;

		public EColorSpace eColorSpace;
	}
	public struct TrackedDevicePose_t
	{
		public HmdMatrix34_t mDeviceToAbsoluteTracking;

		public HmdVector3_t vVelocity;

		public HmdVector3_t vAngularVelocity;

		public ETrackingResult eTrackingResult;

		[MarshalAs(UnmanagedType.I1)]
		public bool bPoseIsValid;

		[MarshalAs(UnmanagedType.I1)]
		public bool bDeviceIsConnected;
	}
	public struct VRTextureBounds_t
	{
		public float uMin;

		public float vMin;

		public float uMax;

		public float vMax;
	}
	public struct VREvent_Controller_t
	{
		public uint button;
	}
	public struct VREvent_Mouse_t
	{
		public float x;

		public float y;

		public uint button;
	}
	public struct VREvent_Scroll_t
	{
		public float xdelta;

		public float ydelta;

		public uint repeatCount;
	}
	public struct VREvent_TouchPadMove_t
	{
		[MarshalAs(UnmanagedType.I1)]
		public bool bFingerDown;

		public float flSecondsFingerDown;

		public float fValueXFirst;

		public float fValueYFirst;

		public float fValueXRaw;

		public float fValueYRaw;
	}
	public struct VREvent_Notification_t
	{
		public ulong ulUserValue;

		public uint notificationId;
	}
	public struct VREvent_Process_t
	{
		public uint pid;

		public uint oldPid;

		[MarshalAs(UnmanagedType.I1)]
		public bool bForced;
	}
	public struct VREvent_Overlay_t
	{
		public ulong overlayHandle;
	}
	public struct VREvent_Status_t
	{
		public uint statusState;
	}
	public struct VREvent_Keyboard_t
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
		public string cNewInput;

		public ulong uUserValue;
	}
	public struct VREvent_Ipd_t
	{
		public float ipdMeters;
	}
	public struct VREvent_Chaperone_t
	{
		public ulong m_nPreviousUniverse;

		public ulong m_nCurrentUniverse;
	}
	public struct VREvent_Reserved_t
	{
		public ulong reserved0;

		public ulong reserved1;
	}
	public struct VREvent_PerformanceTest_t
	{
		public uint m_nFidelityLevel;
	}
	public struct VREvent_SeatedZeroPoseReset_t
	{
		[MarshalAs(UnmanagedType.I1)]
		public bool bResetBySystemMenu;
	}
	public struct VREvent_t
	{
		public uint eventType;

		public uint trackedDeviceIndex;

		public float eventAgeSeconds;

		public VREvent_Data_t data;
	}
	public struct HiddenAreaMesh_t
	{
		public IntPtr pVertexData;

		public uint unTriangleCount;
	}
	public struct VRControllerAxis_t
	{
		public float x;

		public float y;
	}
	public struct VRControllerState_t
	{
		public uint unPacketNum;

		public ulong ulButtonPressed;

		public ulong ulButtonTouched;

		public VRControllerAxis_t rAxis0;

		public VRControllerAxis_t rAxis1;

		public VRControllerAxis_t rAxis2;

		public VRControllerAxis_t rAxis3;

		public VRControllerAxis_t rAxis4;
	}
	public struct Compositor_OverlaySettings
	{
		public uint size;

		[MarshalAs(UnmanagedType.I1)]
		public bool curved;

		[MarshalAs(UnmanagedType.I1)]
		public bool antialias;

		public float scale;

		public float distance;

		public float alpha;

		public float uOffset;

		public float vOffset;

		public float uScale;

		public float vScale;

		public float gridDivs;

		public float gridWidth;

		public float gridScale;

		public HmdMatrix44_t transform;
	}
	public struct Compositor_FrameTiming
	{
		public uint m_nSize;

		public uint m_nFrameIndex;

		public uint m_nNumFramePresents;

		public uint m_nNumDroppedFrames;

		public double m_flSystemTimeInSeconds;

		public float m_flSceneRenderGpuMs;

		public float m_flTotalRenderGpuMs;

		public float m_flCompositorRenderGpuMs;

		public float m_flCompositorRenderCpuMs;

		public float m_flCompositorIdleCpuMs;

		public float m_flClientFrameIntervalMs;

		public float m_flPresentCallCpuMs;

		public float m_flWaitForPresentCpuMs;

		public float m_flSubmitFrameMs;

		public float m_flWaitGetPosesCalledMs;

		public float m_flNewPosesReadyMs;

		public float m_flNewFrameReadyMs;

		public float m_flCompositorUpdateStartMs;

		public float m_flCompositorUpdateEndMs;

		public float m_flCompositorRenderStartMs;

		public TrackedDevicePose_t m_HmdPose;

		public int m_nFidelityLevel;
	}
	public struct VROverlayIntersectionParams_t
	{
		public HmdVector3_t vSource;

		public HmdVector3_t vDirection;

		public ETrackingUniverseOrigin eOrigin;
	}
	public struct VROverlayIntersectionResults_t
	{
		public HmdVector3_t vPoint;

		public HmdVector3_t vNormal;

		public HmdVector2_t vUVs;

		public float fDistance;
	}
	public struct RenderModel_ComponentState_t
	{
		public HmdMatrix34_t mTrackingToComponentRenderModel;

		public HmdMatrix34_t mTrackingToComponentLocal;

		public uint uProperties;
	}
	public struct RenderModel_Vertex_t
	{
		public HmdVector3_t vPosition;

		public HmdVector3_t vNormal;

		public float rfTextureCoord0;

		public float rfTextureCoord1;
	}
	public struct RenderModel_TextureMap_t
	{
		public char unWidth;

		public char unHeight;

		public IntPtr rubTextureMapData;
	}
	public struct RenderModel_t
	{
		public IntPtr rVertexData;

		public uint unVertexCount;

		public IntPtr rIndexData;

		public uint unTriangleCount;

		public int diffuseTextureId;
	}
	public struct RenderModel_ControllerMode_State_t
	{
		[MarshalAs(UnmanagedType.I1)]
		public bool bScrollWheelVisible;
	}
	public struct NotificationBitmap_t
	{
		public IntPtr bytes;

		public int width;

		public int height;

		public int depth;
	}
	public struct CameraVideoStreamFrame_t
	{
		public ECameraVideoStreamFormat m_nStreamFormat;

		public uint m_nWidth;

		public uint m_nHeight;

		public uint m_nImageDataSize;

		public uint m_nFrameSequence;

		public uint m_nBufferIndex;

		public uint m_nBufferCount;

		public uint m_nExposureTime;

		public uint m_nISPFrameTimeStamp;

		public uint m_nISPReferenceTimeStamp;

		public uint m_nSyncCounter;

		public uint m_nCamSyncEvents;

		public double m_flReferenceCamSyncTime;

		public double m_flFrameElapsedTime;

		public double m_flFrameDeliveryRate;

		public double m_flFrameCaptureTime_DriverAbsolute;

		public double m_flFrameCaptureTime_ServerRelative;

		public ulong m_nFrameCaptureTicks_ServerAbsolute;

		public double m_flFrameCaptureTime_ClientRelative;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bPoseIsValid;

		public HmdMatrix34_t m_matDeviceToAbsoluteTracking;

		public float m_Pad0;

		public float m_Pad1;

		public float m_Pad2;

		public float m_Pad3;

		public IntPtr m_pImageData;
	}
	public struct COpenVRContext
	{
		public IntPtr m_pVRSystem;

		public IntPtr m_pVRChaperone;

		public IntPtr m_pVRChaperoneSetup;

		public IntPtr m_pVRCompositor;

		public IntPtr m_pVROverlay;

		public IntPtr m_pVRRenderModels;

		public IntPtr m_pVRExtendedDisplay;

		public IntPtr m_pVRSettings;

		public IntPtr m_pVRApplications;
	}
	public class OpenVR
	{
		private class COpenVRContext
		{
			private CVRSystem m_pVRSystem;

			private CVRChaperone m_pVRChaperone;

			private CVRChaperoneSetup m_pVRChaperoneSetup;

			private CVRCompositor m_pVRCompositor;

			private CVROverlay m_pVROverlay;

			private CVRRenderModels m_pVRRenderModels;

			private CVRExtendedDisplay m_pVRExtendedDisplay;

			private CVRSettings m_pVRSettings;

			private CVRApplications m_pVRApplications;

			public COpenVRContext()
			{
				Clear();
			}

			public void Clear()
			{
				m_pVRSystem = null;
				m_pVRChaperone = null;
				m_pVRChaperoneSetup = null;
				m_pVRCompositor = null;
				m_pVROverlay = null;
				m_pVRRenderModels = null;
				m_pVRExtendedDisplay = null;
				m_pVRSettings = null;
				m_pVRApplications = null;
			}

			private void CheckClear()
			{
				if (VRToken != GetInitToken())
				{
					Clear();
					VRToken = GetInitToken();
				}
			}

			public CVRSystem VRSystem()
			{
				CheckClear();
				if (m_pVRSystem == null)
				{
					EVRInitError peError = EVRInitError.None;
					IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRSystem_011", ref peError);
					if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
					{
						m_pVRSystem = new CVRSystem(genericInterface);
					}
				}
				return m_pVRSystem;
			}

			public CVRChaperone VRChaperone()
			{
				CheckClear();
				if (m_pVRChaperone == null)
				{
					EVRInitError peError = EVRInitError.None;
					IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRChaperone_003", ref peError);
					if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
					{
						m_pVRChaperone = new CVRChaperone(genericInterface);
					}
				}
				return m_pVRChaperone;
			}

			public CVRChaperoneSetup VRChaperoneSetup()
			{
				CheckClear();
				if (m_pVRChaperoneSetup == null)
				{
					EVRInitError peError = EVRInitError.None;
					IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRChaperoneSetup_005", ref peError);
					if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
					{
						m_pVRChaperoneSetup = new CVRChaperoneSetup(genericInterface);
					}
				}
				return m_pVRChaperoneSetup;
			}

			public CVRCompositor VRCompositor()
			{
				CheckClear();
				if (m_pVRCompositor == null)
				{
					EVRInitError peError = EVRInitError.None;
					IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRCompositor_013", ref peError);
					if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
					{
						m_pVRCompositor = new CVRCompositor(genericInterface);
					}
				}
				return m_pVRCompositor;
			}

			public CVROverlay VROverlay()
			{
				CheckClear();
				if (m_pVROverlay == null)
				{
					EVRInitError peError = EVRInitError.None;
					IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVROverlay_010", ref peError);
					if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
					{
						m_pVROverlay = new CVROverlay(genericInterface);
					}
				}
				return m_pVROverlay;
			}

			public CVRRenderModels VRRenderModels()
			{
				CheckClear();
				if (m_pVRRenderModels == null)
				{
					EVRInitError peError = EVRInitError.None;
					IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRRenderModels_005", ref peError);
					if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
					{
						m_pVRRenderModels = new CVRRenderModels(genericInterface);
					}
				}
				return m_pVRRenderModels;
			}

			public CVRExtendedDisplay VRExtendedDisplay()
			{
				CheckClear();
				if (m_pVRExtendedDisplay == null)
				{
					EVRInitError peError = EVRInitError.None;
					IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRExtendedDisplay_001", ref peError);
					if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
					{
						m_pVRExtendedDisplay = new CVRExtendedDisplay(genericInterface);
					}
				}
				return m_pVRExtendedDisplay;
			}

			public CVRSettings VRSettings()
			{
				CheckClear();
				if (m_pVRSettings == null)
				{
					EVRInitError peError = EVRInitError.None;
					IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRSettings_001", ref peError);
					if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
					{
						m_pVRSettings = new CVRSettings(genericInterface);
					}
				}
				return m_pVRSettings;
			}

			public CVRApplications VRApplications()
			{
				CheckClear();
				if (m_pVRApplications == null)
				{
					EVRInitError peError = EVRInitError.None;
					IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRApplications_004", ref peError);
					if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
					{
						m_pVRApplications = new CVRApplications(genericInterface);
					}
				}
				return m_pVRApplications;
			}
		}

		public const uint k_unTrackingStringSize = 32u;

		public const uint k_unMaxDriverDebugResponseSize = 32768u;

		public const uint k_unTrackedDeviceIndex_Hmd = 0u;

		public const uint k_unMaxTrackedDeviceCount = 16u;

		public const uint k_unTrackedDeviceIndexInvalid = uint.MaxValue;

		public const uint k_unMaxPropertyStringSize = 32768u;

		public const uint k_unControllerStateAxisCount = 5u;

		public const ulong k_ulOverlayHandleInvalid = 0uL;

		public const string IVRSystem_Version = "IVRSystem_011";

		public const string IVRExtendedDisplay_Version = "IVRExtendedDisplay_001";

		public const uint k_unMaxApplicationKeyLength = 128u;

		public const string IVRApplications_Version = "IVRApplications_004";

		public const string IVRChaperone_Version = "IVRChaperone_003";

		public const string IVRChaperoneSetup_Version = "IVRChaperoneSetup_005";

		public const string IVRCompositor_Version = "IVRCompositor_013";

		public const uint k_unVROverlayMaxKeyLength = 128u;

		public const uint k_unVROverlayMaxNameLength = 128u;

		public const uint k_unMaxOverlayCount = 32u;

		public const string IVROverlay_Version = "IVROverlay_010";

		public const string k_pch_Controller_Component_GDC2015 = "gdc2015";

		public const string k_pch_Controller_Component_Base = "base";

		public const string k_pch_Controller_Component_Tip = "tip";

		public const string k_pch_Controller_Component_HandGrip = "handgrip";

		public const string k_pch_Controller_Component_Status = "status";

		public const string IVRRenderModels_Version = "IVRRenderModels_005";

		public const uint k_unNotificationTextMaxSize = 256u;

		public const string IVRNotifications_Version = "IVRNotifications_002";

		public const uint k_unMaxSettingsKeyLength = 128u;

		public const string k_pch_SteamVR_Section = "steamvr";

		public const string k_pch_SteamVR_RequireHmd_String = "requireHmd";

		public const string k_pch_SteamVR_ForcedDriverKey_String = "forcedDriver";

		public const string k_pch_SteamVR_ForcedHmdKey_String = "forcedHmd";

		public const string k_pch_SteamVR_DisplayDebug_Bool = "displayDebug";

		public const string k_pch_SteamVR_DebugProcessPipe_String = "debugProcessPipe";

		public const string k_pch_SteamVR_EnableDistortion_Bool = "enableDistortion";

		public const string k_pch_SteamVR_DisplayDebugX_Int32 = "displayDebugX";

		public const string k_pch_SteamVR_DisplayDebugY_Int32 = "displayDebugY";

		public const string k_pch_SteamVR_SendSystemButtonToAllApps_Bool = "sendSystemButtonToAllApps";

		public const string k_pch_SteamVR_LogLevel_Int32 = "loglevel";

		public const string k_pch_SteamVR_IPD_Float = "ipd";

		public const string k_pch_SteamVR_Background_String = "background";

		public const string k_pch_SteamVR_GridColor_String = "gridColor";

		public const string k_pch_SteamVR_PlayAreaColor_String = "playAreaColor";

		public const string k_pch_SteamVR_ActivateMultipleDrivers_Bool = "activateMultipleDrivers";

		public const string k_pch_SteamVR_PowerOffOnExit_Bool = "powerOffOnExit";

		public const string k_pch_SteamVR_StandbyAppRunningTimeout_Float = "standbyAppRunningTimeout";

		public const string k_pch_SteamVR_StandbyNoAppTimeout_Float = "standbyNoAppTimeout";

		public const string k_pch_SteamVR_DirectMode_Bool = "directMode";

		public const string k_pch_SteamVR_DirectModeEdidVid_Int32 = "directModeEdidVid";

		public const string k_pch_SteamVR_DirectModeEdidPid_Int32 = "directModeEdidPid";

		public const string k_pch_SteamVR_UsingSpeakers_Bool = "usingSpeakers";

		public const string k_pch_SteamVR_SpeakersForwardYawOffsetDegrees_Float = "speakersForwardYawOffsetDegrees";

		public const string k_pch_SteamVR_BaseStationPowerManagement_Bool = "basestationPowerManagement";

		public const string k_pch_Lighthouse_Section = "driver_lighthouse";

		public const string k_pch_Lighthouse_DisableIMU_Bool = "disableimu";

		public const string k_pch_Lighthouse_UseDisambiguation_String = "usedisambiguation";

		public const string k_pch_Lighthouse_DisambiguationDebug_Int32 = "disambiguationdebug";

		public const string k_pch_Lighthouse_PrimaryBasestation_Int32 = "primarybasestation";

		public const string k_pch_Lighthouse_LighthouseName_String = "lighthousename";

		public const string k_pch_Lighthouse_MaxIncidenceAngleDegrees_Float = "maxincidenceangledegrees";

		public const string k_pch_Lighthouse_UseLighthouseDirect_Bool = "uselighthousedirect";

		public const string k_pch_Lighthouse_DBHistory_Bool = "dbhistory";

		public const string k_pch_Lighthouse_OriginOffsetX_Float = "originoffsetx";

		public const string k_pch_Lighthouse_OriginOffsetY_Float = "originoffsety";

		public const string k_pch_Lighthouse_OriginOffsetZ_Float = "originoffsetz";

		public const string k_pch_Lighthouse_HeadingOffset_Float = "headingoffset";

		public const string k_pch_Null_Section = "driver_null";

		public const string k_pch_Null_EnableNullDriver_Bool = "enable";

		public const string k_pch_Null_SerialNumber_String = "serialNumber";

		public const string k_pch_Null_ModelNumber_String = "modelNumber";

		public const string k_pch_Null_WindowX_Int32 = "windowX";

		public const string k_pch_Null_WindowY_Int32 = "windowY";

		public const string k_pch_Null_WindowWidth_Int32 = "windowWidth";

		public const string k_pch_Null_WindowHeight_Int32 = "windowHeight";

		public const string k_pch_Null_RenderWidth_Int32 = "renderWidth";

		public const string k_pch_Null_RenderHeight_Int32 = "renderHeight";

		public const string k_pch_Null_SecondsFromVsyncToPhotons_Float = "secondsFromVsyncToPhotons";

		public const string k_pch_Null_DisplayFrequency_Float = "displayFrequency";

		public const string k_pch_UserInterface_Section = "userinterface";

		public const string k_pch_UserInterface_StatusAlwaysOnTop_Bool = "StatusAlwaysOnTop";

		public const string k_pch_Notifications_Section = "notifications";

		public const string k_pch_Notifications_DoNotDisturb_Bool = "DoNotDisturb";

		public const string k_pch_Keyboard_Section = "keyboard";

		public const string k_pch_Keyboard_TutorialCompletions = "TutorialCompletions";

		public const string k_pch_Perf_Section = "perfcheck";

		public const string k_pch_Perf_HeuristicActive_Bool = "heuristicActive";

		public const string k_pch_Perf_NotifyInHMD_Bool = "warnInHMD";

		public const string k_pch_Perf_NotifyOnlyOnce_Bool = "warnOnlyOnce";

		public const string k_pch_Perf_AllowTimingStore_Bool = "allowTimingStore";

		public const string k_pch_Perf_SaveTimingsOnExit_Bool = "saveTimingsOnExit";

		public const string k_pch_Perf_TestData_Float = "perfTestData";

		public const string k_pch_Camera_Section = "camera";

		public const string IVRSettings_Version = "IVRSettings_001";

		public const string k_pch_audio_Section = "audio";

		public const string k_pch_audio_OnPlaybackDevice_String = "onPlaybackDevice";

		public const string k_pch_audio_OnRecordDevice_String = "onRecordDevice";

		public const string k_pch_audio_OffPlaybackDevice_String = "offPlaybackDevice";

		public const string k_pch_audio_OffRecordDevice_String = "offRecordDevice";

		public const string k_pch_audio_VIVEHDMIGain = "viveHDMIGain";

		public const string IVRTrackedCamera_Version = "IVRTrackedCamera_001";

		private const string FnTable_Prefix = "FnTable:";

		private static COpenVRContext _OpenVRInternal_ModuleContext;

		private static uint VRToken { get; set; }

		private static COpenVRContext OpenVRInternal_ModuleContext
		{
			get
			{
				if (_OpenVRInternal_ModuleContext == null)
				{
					_OpenVRInternal_ModuleContext = new COpenVRContext();
				}
				return _OpenVRInternal_ModuleContext;
			}
		}

		public static CVRSystem System => OpenVRInternal_ModuleContext.VRSystem();

		public static CVRChaperone Chaperone => OpenVRInternal_ModuleContext.VRChaperone();

		public static CVRChaperoneSetup ChaperoneSetup => OpenVRInternal_ModuleContext.VRChaperoneSetup();

		public static CVRCompositor Compositor => OpenVRInternal_ModuleContext.VRCompositor();

		public static CVROverlay Overlay => OpenVRInternal_ModuleContext.VROverlay();

		public static CVRRenderModels RenderModels => OpenVRInternal_ModuleContext.VRRenderModels();

		public static CVRApplications Applications => OpenVRInternal_ModuleContext.VRApplications();

		public static CVRSettings Settings => OpenVRInternal_ModuleContext.VRSettings();

		public static CVRExtendedDisplay ExtendedDisplay => OpenVRInternal_ModuleContext.VRExtendedDisplay();

		public static uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType)
		{
			return OpenVRInterop.InitInternal(ref peError, eApplicationType);
		}

		public static void ShutdownInternal()
		{
			OpenVRInterop.ShutdownInternal();
		}

		public static bool IsHmdPresent()
		{
			return OpenVRInterop.IsHmdPresent();
		}

		public static bool IsRuntimeInstalled()
		{
			return OpenVRInterop.IsRuntimeInstalled();
		}

		public static string GetStringForHmdError(EVRInitError error)
		{
			return Marshal.PtrToStringAnsi(OpenVRInterop.GetStringForHmdError(error));
		}

		public static IntPtr GetGenericInterface(string pchInterfaceVersion, ref EVRInitError peError)
		{
			return OpenVRInterop.GetGenericInterface(pchInterfaceVersion, ref peError);
		}

		public static bool IsInterfaceVersionValid(string pchInterfaceVersion)
		{
			return OpenVRInterop.IsInterfaceVersionValid(pchInterfaceVersion);
		}

		public static uint GetInitToken()
		{
			return OpenVRInterop.GetInitToken();
		}

		public static CVRSystem Init(ref EVRInitError peError, EVRApplicationType eApplicationType = EVRApplicationType.VRApplication_Scene)
		{
			VRToken = InitInternal(ref peError, eApplicationType);
			OpenVRInternal_ModuleContext.Clear();
			if (peError != 0)
			{
				return null;
			}
			if (!IsInterfaceVersionValid("IVRSystem_011"))
			{
				ShutdownInternal();
				peError = EVRInitError.Init_InterfaceNotFound;
				return null;
			}
			return System;
		}

		public static void Shutdown()
		{
			ShutdownInternal();
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
	{
		public string axisName = "Horizontal";

		public float axisValue = 1f;

		public float responseSpeed = 3f;

		public float returnToCentreSpeed = 3f;

		private AxisTouchButton m_PairedWith;

		private CrossPlatformInputManager.VirtualAxis m_Axis;

		private void OnEnable()
		{
			if (!CrossPlatformInputManager.AxisExists(axisName))
			{
				m_Axis = new CrossPlatformInputManager.VirtualAxis(axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(m_Axis);
			}
			else
			{
				m_Axis = CrossPlatformInputManager.VirtualAxisReference(axisName);
			}
			FindPairedButton();
		}

		private void FindPairedButton()
		{
			if (!(UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) is AxisTouchButton[] array))
			{
				return;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].axisName == axisName && array[i] != this)
				{
					m_PairedWith = array[i];
				}
			}
		}

		private void OnDisable()
		{
			m_Axis.Remove();
		}

		public void OnPointerDown(PointerEventData data)
		{
			if (m_PairedWith == null)
			{
				FindPairedButton();
			}
			m_Axis.Update(Mathf.MoveTowards(m_Axis.GetValue, axisValue, responseSpeed * Time.deltaTime));
		}

		public void OnPointerUp(PointerEventData data)
		{
			m_Axis.Update(Mathf.MoveTowards(m_Axis.GetValue, 0f, responseSpeed * Time.deltaTime));
		}
	}
	public class ButtonHandler : MonoBehaviour
	{
		public string Name;

		private void OnEnable()
		{
		}

		public void SetDownState()
		{
			CrossPlatformInputManager.SetButtonDown(Name);
		}

		public void SetUpState()
		{
			CrossPlatformInputManager.SetButtonUp(Name);
		}

		public void SetAxisPositiveState()
		{
			CrossPlatformInputManager.SetAxisPositive(Name);
		}

		public void SetAxisNeutralState()
		{
			CrossPlatformInputManager.SetAxisZero(Name);
		}

		public void SetAxisNegativeState()
		{
			CrossPlatformInputManager.SetAxisNegative(Name);
		}

		public void Update()
		{
		}
	}
	public static class CrossPlatformInputManager
	{
		public enum ActiveInputMethod
		{
			Hardware,
			Touch
		}

		public class VirtualAxis
		{
			private float m_Value;

			public string name { get; private set; }

			public bool matchWithInputManager { get; private set; }

			public float GetValue => m_Value;

			public float GetValueRaw => m_Value;

			public VirtualAxis(string name)
				: this(name, matchToInputSettings: true)
			{
			}

			public VirtualAxis(string name, bool matchToInputSettings)
			{
				this.name = name;
				matchWithInputManager = matchToInputSettings;
			}

			public void Remove()
			{
				UnRegisterVirtualAxis(name);
			}

			public void Update(float value)
			{
				m_Value = value;
			}
		}

		public class VirtualButton
		{
			private int m_LastPressedFrame = -5;

			private int m_ReleasedFrame = -5;

			private bool m_Pressed;

			public string name { get; private set; }

			public bool matchWithInputManager { get; private set; }

			public bool GetButton => m_Pressed;

			public bool GetButtonDown => m_LastPressedFrame - Time.frameCount == -1;

			public bool GetButtonUp => m_ReleasedFrame == Time.frameCount - 1;

			public VirtualButton(string name)
				: this(name, matchToInputSettings: true)
			{
			}

			public VirtualButton(string name, bool matchToInputSettings)
			{
				this.name = name;
				matchWithInputManager = matchToInputSettings;
			}

			public void Pressed()
			{
				if (!m_Pressed)
				{
					m_Pressed = true;
					m_LastPressedFrame = Time.frameCount;
				}
			}

			public void Released()
			{
				m_Pressed = false;
				m_ReleasedFrame = Time.frameCount;
			}

			public void Remove()
			{
				UnRegisterVirtualButton(name);
			}
		}

		private static VirtualInput activeInput;

		private static VirtualInput s_TouchInput;

		private static VirtualInput s_HardwareInput;

		public static Vector3 mousePosition => activeInput.MousePosition();

		static CrossPlatformInputManager()
		{
			s_TouchInput = new MobileInput();
			s_HardwareInput = new StandaloneInput();
			activeInput = s_HardwareInput;
		}

		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
			switch (activeInputMethod)
			{
			case ActiveInputMethod.Hardware:
				activeInput = s_HardwareInput;
				break;
			case ActiveInputMethod.Touch:
				activeInput = s_TouchInput;
				break;
			}
		}

		public static bool AxisExists(string name)
		{
			return activeInput.AxisExists(name);
		}

		public static bool ButtonExists(string name)
		{
			return activeInput.ButtonExists(name);
		}

		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
			activeInput.RegisterVirtualAxis(axis);
		}

		public static void RegisterVirtualButton(VirtualButton button)
		{
			activeInput.RegisterVirtualButton(button);
		}

		public static void UnRegisterVirtualAxis(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			activeInput.UnRegisterVirtualAxis(name);
		}

		public static void UnRegisterVirtualButton(string name)
		{
			activeInput.UnRegisterVirtualButton(name);
		}

		public static VirtualAxis VirtualAxisReference(string name)
		{
			return activeInput.VirtualAxisReference(name);
		}

		public static float GetAxis(string name)
		{
			return GetAxis(name, raw: false);
		}

		public static float GetAxisRaw(string name)
		{
			return GetAxis(name, raw: true);
		}

		private static float GetAxis(string name, bool raw)
		{
			return activeInput.GetAxis(name, raw);
		}

		public static bool GetButton(string name)
		{
			return activeInput.GetButton(name);
		}

		public static bool GetButtonDown(string name)
		{
			return activeInput.GetButtonDown(name);
		}

		public static bool GetButtonUp(string name)
		{
			return activeInput.GetButtonUp(name);
		}

		public static void SetButtonDown(string name)
		{
			activeInput.SetButtonDown(name);
		}

		public static void SetButtonUp(string name)
		{
			activeInput.SetButtonUp(name);
		}

		public static void SetAxisPositive(string name)
		{
			activeInput.SetAxisPositive(name);
		}

		public static void SetAxisNegative(string name)
		{
			activeInput.SetAxisNegative(name);
		}

		public static void SetAxisZero(string name)
		{
			activeInput.SetAxisZero(name);
		}

		public static void SetAxis(string name, float value)
		{
			activeInput.SetAxis(name, value);
		}

		public static void SetVirtualMousePositionX(float f)
		{
			activeInput.SetVirtualMousePositionX(f);
		}

		public static void SetVirtualMousePositionY(float f)
		{
			activeInput.SetVirtualMousePositionY(f);
		}

		public static void SetVirtualMousePositionZ(float f)
		{
			activeInput.SetVirtualMousePositionZ(f);
		}
	}
	public class InputAxisScrollbar : MonoBehaviour
	{
		public string axis;

		private void Update()
		{
		}

		public void HandleInput(float value)
		{
			CrossPlatformInputManager.SetAxis(axis, value * 2f - 1f);
		}
	}
	public class Joystick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler, IEventSystemHandler
	{
		public enum AxisOption
		{
			Both,
			OnlyHorizontal,
			OnlyVertical
		}

		public int MovementRange = 100;

		public AxisOption axesToUse;

		public string horizontalAxisName = "Horizontal";

		public string verticalAxisName = "Vertical";

		private Vector3 m_StartPos;

		private bool m_UseX;

		private bool m_UseY;

		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		private void OnEnable()
		{
			CreateVirtualAxes();
		}

		private void Start()
		{
			m_StartPos = base.transform.position;
		}

		private void UpdateVirtualAxes(Vector3 value)
		{
			Vector3 vector = m_StartPos - value;
			vector.y = 0f - vector.y;
			vector /= (float)MovementRange;
			if (m_UseX)
			{
				m_HorizontalVirtualAxis.Update(0f - vector.x);
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis.Update(vector.y);
			}
		}

		private void CreateVirtualAxes()
		{
			m_UseX = axesToUse == AxisOption.Both || axesToUse == AxisOption.OnlyHorizontal;
			m_UseY = axesToUse == AxisOption.Both || axesToUse == AxisOption.OnlyVertical;
			if (m_UseX)
			{
				m_HorizontalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(horizontalAxisName);
				CrossPlatformInputManager.RegisterVirtualAxis(m_HorizontalVirtualAxis);
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(verticalAxisName);
				CrossPlatformInputManager.RegisterVirtualAxis(m_VerticalVirtualAxis);
			}
		}

		public void OnDrag(PointerEventData data)
		{
			Vector3 zero = Vector3.zero;
			if (m_UseX)
			{
				int value = (int)(data.position.x - m_StartPos.x);
				value = Mathf.Clamp(value, -MovementRange, MovementRange);
				zero.x = value;
			}
			if (m_UseY)
			{
				int value2 = (int)(data.position.y - m_StartPos.y);
				value2 = Mathf.Clamp(value2, -MovementRange, MovementRange);
				zero.y = value2;
			}
			base.transform.position = new Vector3(m_StartPos.x + zero.x, m_StartPos.y + zero.y, m_StartPos.z + zero.z);
			UpdateVirtualAxes(base.transform.position);
		}

		public void OnPointerUp(PointerEventData data)
		{
			base.transform.position = m_StartPos;
			UpdateVirtualAxes(m_StartPos);
		}

		public void OnPointerDown(PointerEventData data)
		{
		}

		private void OnDisable()
		{
			if (m_UseX)
			{
				m_HorizontalVirtualAxis.Remove();
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis.Remove();
			}
		}
	}
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		private void OnEnable()
		{
			CheckEnableControlRig();
		}

		private void Start()
		{
			EventSystem eventSystem = UnityEngine.Object.FindObjectOfType<EventSystem>();
			if (eventSystem == null)
			{
				GameObject gameObject = new GameObject("EventSystem");
				gameObject.AddComponent<EventSystem>();
				gameObject.AddComponent<StandaloneInputModule>();
				gameObject.AddComponent<TouchInputModule>();
			}
		}

		private void CheckEnableControlRig()
		{
			EnableControlRig(enabled: false);
		}

		private void EnableControlRig(bool enabled)
		{
			foreach (Transform item in base.transform)
			{
				item.gameObject.SetActive(enabled);
			}
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	public class MobileInput : VirtualInput
	{
		private void AddButton(string name)
		{
			CrossPlatformInputManager.RegisterVirtualButton(new CrossPlatformInputManager.VirtualButton(name));
		}

		private void AddAxes(string name)
		{
			CrossPlatformInputManager.RegisterVirtualAxis(new CrossPlatformInputManager.VirtualAxis(name));
		}

		public override float GetAxis(string name, bool raw)
		{
			if (!m_VirtualAxes.ContainsKey(name))
			{
				AddAxes(name);
			}
			return m_VirtualAxes[name].GetValue;
		}

		public override void SetButtonDown(string name)
		{
			if (!m_VirtualButtons.ContainsKey(name))
			{
				AddButton(name);
			}
			m_VirtualButtons[name].Pressed();
		}

		public override void SetButtonUp(string name)
		{
			if (!m_VirtualButtons.ContainsKey(name))
			{
				AddButton(name);
			}
			m_VirtualButtons[name].Released();
		}

		public override void SetAxisPositive(string name)
		{
			if (!m_VirtualAxes.ContainsKey(name))
			{
				AddAxes(name);
			}
			m_VirtualAxes[name].Update(1f);
		}

		public override void SetAxisNegative(string name)
		{
			if (!m_VirtualAxes.ContainsKey(name))
			{
				AddAxes(name);
			}
			m_VirtualAxes[name].Update(-1f);
		}

		public override void SetAxisZero(string name)
		{
			if (!m_VirtualAxes.ContainsKey(name))
			{
				AddAxes(name);
			}
			m_VirtualAxes[name].Update(0f);
		}

		public override void SetAxis(string name, float value)
		{
			if (!m_VirtualAxes.ContainsKey(name))
			{
				AddAxes(name);
			}
			m_VirtualAxes[name].Update(value);
		}

		public override bool GetButtonDown(string name)
		{
			if (m_VirtualButtons.ContainsKey(name))
			{
				return m_VirtualButtons[name].GetButtonDown;
			}
			AddButton(name);
			return m_VirtualButtons[name].GetButtonDown;
		}

		public override bool GetButtonUp(string name)
		{
			if (m_VirtualButtons.ContainsKey(name))
			{
				return m_VirtualButtons[name].GetButtonUp;
			}
			AddButton(name);
			return m_VirtualButtons[name].GetButtonUp;
		}

		public override bool GetButton(string name)
		{
			if (m_VirtualButtons.ContainsKey(name))
			{
				return m_VirtualButtons[name].GetButton;
			}
			AddButton(name);
			return m_VirtualButtons[name].GetButton;
		}

		public override Vector3 MousePosition()
		{
			return base.virtualMousePosition;
		}
	}
	public class StandaloneInput : VirtualInput
	{
		public override float GetAxis(string name, bool raw)
		{
			return (!raw) ? Input.GetAxis(name) : Input.GetAxisRaw(name);
		}

		public override bool GetButton(string name)
		{
			return Input.GetButton(name);
		}

		public override bool GetButtonDown(string name)
		{
			return Input.GetButtonDown(name);
		}

		public override bool GetButtonUp(string name)
		{
			return Input.GetButtonUp(name);
		}

		public override void SetButtonDown(string name)
		{
			throw new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		}

		public override void SetButtonUp(string name)
		{
			throw new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		}

		public override void SetAxisPositive(string name)
		{
			throw new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		}

		public override void SetAxisNegative(string name)
		{
			throw new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		}

		public override void SetAxisZero(string name)
		{
			throw new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		}

		public override void SetAxis(string name, float value)
		{
			throw new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		}

		public override Vector3 MousePosition()
		{
			return Input.mousePosition;
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	public class TiltInput : MonoBehaviour
	{
		public enum AxisOptions
		{
			ForwardAxis,
			SidewaysAxis
		}

		[Serializable]
		public class AxisMapping
		{
			public enum MappingType
			{
				NamedAxis,
				MousePositionX,
				MousePositionY,
				MousePositionZ
			}

			public MappingType type;

			public string axisName;
		}

		public AxisMapping mapping;

		public AxisOptions tiltAroundAxis;

		public float fullTiltAngle = 25f;

		public float centreAngleOffset;

		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		private void OnEnable()
		{
			if (mapping.type == AxisMapping.MappingType.NamedAxis)
			{
				m_SteerAxis = new CrossPlatformInputManager.VirtualAxis(mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(m_SteerAxis);
			}
		}

		private void Update()
		{
			float value = 0f;
			if (Input.acceleration != Vector3.zero)
			{
				switch (tiltAroundAxis)
				{
				case AxisOptions.ForwardAxis:
					value = Mathf.Atan2(Input.acceleration.x, 0f - Input.acceleration.y) * 57.29578f + centreAngleOffset;
					break;
				case AxisOptions.SidewaysAxis:
					value = Mathf.Atan2(Input.acceleration.z, 0f - Input.acceleration.y) * 57.29578f + centreAngleOffset;
					break;
				}
			}
			float num = Mathf.InverseLerp(0f - fullTiltAngle, fullTiltAngle, value) * 2f - 1f;
			switch (mapping.type)
			{
			case AxisMapping.MappingType.NamedAxis:
				m_SteerAxis.Update(num);
				break;
			case AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		private void OnDisable()
		{
			m_SteerAxis.Remove();
		}
	}
	[RequireComponent(typeof(Image))]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
	{
		public enum AxisOption
		{
			Both,
			OnlyHorizontal,
			OnlyVertical
		}

		public enum ControlStyle
		{
			Absolute,
			Relative,
			Swipe
		}

		public AxisOption axesToUse;

		public ControlStyle controlStyle;

		public string horizontalAxisName = "Horizontal";

		public string verticalAxisName = "Vertical";

		public float Xsensitivity = 1f;

		public float Ysensitivity = 1f;

		private Vector3 m_StartPos;

		private Vector2 m_PreviousDelta;

		private Vector3 m_JoytickOutput;

		private bool m_UseX;

		private bool m_UseY;

		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		private bool m_Dragging;

		private int m_Id = -1;

		private Vector2 m_PreviousTouchPos;

		private Vector3 m_Center;

		private Image m_Image;

		private void OnEnable()
		{
			CreateVirtualAxes();
		}

		private void Start()
		{
			m_Image = GetComponent<Image>();
			m_Center = m_Image.transform.position;
		}

		private void CreateVirtualAxes()
		{
			m_UseX = axesToUse == AxisOption.Both || axesToUse == AxisOption.OnlyHorizontal;
			m_UseY = axesToUse == AxisOption.Both || axesToUse == AxisOption.OnlyVertical;
			if (m_UseX)
			{
				m_HorizontalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(horizontalAxisName);
				CrossPlatformInputManager.RegisterVirtualAxis(m_HorizontalVirtualAxis);
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(verticalAxisName);
				CrossPlatformInputManager.RegisterVirtualAxis(m_VerticalVirtualAxis);
			}
		}

		private void UpdateVirtualAxes(Vector3 value)
		{
			value = value.normalized;
			if (m_UseX)
			{
				m_HorizontalVirtualAxis.Update(value.x);
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis.Update(value.y);
			}
		}

		public void OnPointerDown(PointerEventData data)
		{
			m_Dragging = true;
			m_Id = data.pointerId;
			if (controlStyle != 0)
			{
				m_Center = data.position;
			}
		}

		private void Update()
		{
			if (m_Dragging && Input.touchCount >= m_Id + 1 && m_Id != -1)
			{
				if (controlStyle == ControlStyle.Swipe)
				{
					m_Center = m_PreviousTouchPos;
					m_PreviousTouchPos = Input.touches[m_Id].position;
				}
				Vector2 vector = new Vector2(Input.touches[m_Id].position.x - m_Center.x, Input.touches[m_Id].position.y - m_Center.y);
				Vector2 normalized = vector.normalized;
				normalized.x *= Xsensitivity;
				normalized.y *= Ysensitivity;
				UpdateVirtualAxes(new Vector3(normalized.x, normalized.y, 0f));
			}
		}

		public void OnPointerUp(PointerEventData data)
		{
			m_Dragging = false;
			m_Id = -1;
			UpdateVirtualAxes(Vector3.zero);
		}

		private void OnDisable()
		{
			if (CrossPlatformInputManager.AxisExists(horizontalAxisName))
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(horizontalAxisName);
			}
			if (CrossPlatformInputManager.AxisExists(verticalAxisName))
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(verticalAxisName);
			}
		}
	}
	public abstract class VirtualInput
	{
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes = new Dictionary<string, CrossPlatformInputManager.VirtualAxis>();

		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons = new Dictionary<string, CrossPlatformInputManager.VirtualButton>();

		protected List<string> m_AlwaysUseVirtual = new List<string>();

		public Vector3 virtualMousePosition { get; private set; }

		public bool AxisExists(string name)
		{
			return m_VirtualAxes.ContainsKey(name);
		}

		public bool ButtonExists(string name)
		{
			return m_VirtualButtons.ContainsKey(name);
		}

		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
			if (m_VirtualAxes.ContainsKey(axis.name))
			{
				Debug.LogError("There is already a virtual axis named " + axis.name + " registered.");
				return;
			}
			m_VirtualAxes.Add(axis.name, axis);
			if (!axis.matchWithInputManager)
			{
				m_AlwaysUseVirtual.Add(axis.name);
			}
		}

		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
			if (m_VirtualButtons.ContainsKey(button.name))
			{
				Debug.LogError("There is already a virtual button named " + button.name + " registered.");
				return;
			}
			m_VirtualButtons.Add(button.name, button);
			if (!button.matchWithInputManager)
			{
				m_AlwaysUseVirtual.Add(button.name);
			}
		}

		public void UnRegisterVirtualAxis(string name)
		{
			if (m_VirtualAxes.ContainsKey(name))
			{
				m_VirtualAxes.Remove(name);
			}
		}

		public void UnRegisterVirtualButton(string name)
		{
			if (m_VirtualButtons.ContainsKey(name))
			{
				m_VirtualButtons.Remove(name);
			}
		}

		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return (!m_VirtualAxes.ContainsKey(name)) ? null : m_VirtualAxes[name];
		}

		public void SetVirtualMousePositionX(float f)
		{
			virtualMousePosition = new Vector3(f, virtualMousePosition.y, virtualMousePosition.z);
		}

		public void SetVirtualMousePositionY(float f)
		{
			virtualMousePosition = new Vector3(virtualMousePosition.x, f, virtualMousePosition.z);
		}

		public void SetVirtualMousePositionZ(float f)
		{
			virtualMousePosition = new Vector3(virtualMousePosition.x, virtualMousePosition.y, f);
		}

		public abstract float GetAxis(string name, bool raw);

		public abstract bool GetButton(string name);

		public abstract bool GetButtonDown(string name);

		public abstract bool GetButtonUp(string name);

		public abstract void SetButtonDown(string name);

		public abstract void SetButtonUp(string name);

		public abstract void SetAxisPositive(string name);

		public abstract void SetAxisNegative(string name);

		public abstract void SetAxisZero(string name);

		public abstract void SetAxis(string name, float value);

		public abstract Vector3 MousePosition();
	}
}
namespace UnityStandardAssets.ImageEffects
{
	public enum AAMode
	{
		FXAA2,
		FXAA3Console,
		FXAA1PresetA,
		FXAA1PresetB,
		NFAA,
		SSAA,
		DLAA
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Other/Antialiasing")]
	public class Antialiasing : PostEffectsBase
	{
		public AAMode mode = AAMode.FXAA3Console;

		public bool showGeneratedNormals;

		public float offsetScale = 0.2f;

		public float blurRadius = 18f;

		public float edgeThresholdMin = 0.05f;

		public float edgeThreshold = 0.2f;

		public float edgeSharpness = 4f;

		public bool dlaaSharp;

		public Shader ssaaShader;

		private Material ssaa;

		public Shader dlaaShader;

		private Material dlaa;

		public Shader nfaaShader;

		private Material nfaa;

		public Shader shaderFXAAPreset2;

		private Material materialFXAAPreset2;

		public Shader shaderFXAAPreset3;

		private Material materialFXAAPreset3;

		public Shader shaderFXAAII;

		private Material materialFXAAII;

		public Shader shaderFXAAIII;

		private Material materialFXAAIII;

		public Material CurrentAAMaterial()
		{
			Material material = null;
			return mode switch
			{
				AAMode.FXAA3Console => materialFXAAIII, 
				AAMode.FXAA2 => materialFXAAII, 
				AAMode.FXAA1PresetA => materialFXAAPreset2, 
				AAMode.FXAA1PresetB => materialFXAAPreset3, 
				AAMode.NFAA => nfaa, 
				AAMode.SSAA => ssaa, 
				AAMode.DLAA => dlaa, 
				_ => null, 
			};
		}

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			materialFXAAPreset2 = CreateMaterial(shaderFXAAPreset2, materialFXAAPreset2);
			materialFXAAPreset3 = CreateMaterial(shaderFXAAPreset3, materialFXAAPreset3);
			materialFXAAII = CreateMaterial(shaderFXAAII, materialFXAAII);
			materialFXAAIII = CreateMaterial(shaderFXAAIII, materialFXAAIII);
			nfaa = CreateMaterial(nfaaShader, nfaa);
			ssaa = CreateMaterial(ssaaShader, ssaa);
			dlaa = CreateMaterial(dlaaShader, dlaa);
			if (!ssaaShader.isSupported)
			{
				NotSupported();
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
			}
			else if (mode == AAMode.FXAA3Console && materialFXAAIII != null)
			{
				materialFXAAIII.SetFloat("_EdgeThresholdMin", edgeThresholdMin);
				materialFXAAIII.SetFloat("_EdgeThreshold", edgeThreshold);
				materialFXAAIII.SetFloat("_EdgeSharpness", edgeSharpness);
				Graphics.Blit(source, destination, materialFXAAIII);
			}
			else if (mode == AAMode.FXAA1PresetB && materialFXAAPreset3 != null)
			{
				Graphics.Blit(source, destination, materialFXAAPreset3);
			}
			else if (mode == AAMode.FXAA1PresetA && materialFXAAPreset2 != null)
			{
				source.anisoLevel = 4;
				Graphics.Blit(source, destination, materialFXAAPreset2);
				source.anisoLevel = 0;
			}
			else if (mode == AAMode.FXAA2 && materialFXAAII != null)
			{
				Graphics.Blit(source, destination, materialFXAAII);
			}
			else if (mode == AAMode.SSAA && ssaa != null)
			{
				Graphics.Blit(source, destination, ssaa);
			}
			else if (mode == AAMode.DLAA && dlaa != null)
			{
				source.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height);
				Graphics.Blit(source, temporary, dlaa, 0);
				Graphics.Blit(temporary, destination, dlaa, (!dlaaSharp) ? 1 : 2);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (mode == AAMode.NFAA && nfaa != null)
			{
				source.anisoLevel = 0;
				nfaa.SetFloat("_OffsetScale", offsetScale);
				nfaa.SetFloat("_BlurRadius", blurRadius);
				Graphics.Blit(source, destination, nfaa, showGeneratedNormals ? 1 : 0);
			}
			else
			{
				Graphics.Blit(source, destination);
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom")]
	public class Bloom : PostEffectsBase
	{
		public enum LensFlareStyle
		{
			Ghosting,
			Anamorphic,
			Combined
		}

		public enum TweakMode
		{
			Basic,
			Complex
		}

		public enum HDRBloomMode
		{
			Auto,
			On,
			Off
		}

		public enum BloomScreenBlendMode
		{
			Screen,
			Add
		}

		public enum BloomQuality
		{
			Cheap,
			High
		}

		public TweakMode tweakMode;

		public BloomScreenBlendMode screenBlendMode = BloomScreenBlendMode.Add;

		public HDRBloomMode hdr;

		private bool doHdr;

		public float sepBlurSpread = 2.5f;

		public BloomQuality quality = BloomQuality.High;

		public float bloomIntensity = 0.5f;

		public float bloomThreshold = 0.5f;

		public Color bloomThresholdColor = Color.white;

		public int bloomBlurIterations = 2;

		public int hollywoodFlareBlurIterations = 2;

		public float flareRotation;

		public LensFlareStyle lensflareMode = LensFlareStyle.Anamorphic;

		public float hollyStretchWidth = 2.5f;

		public float lensflareIntensity;

		public float lensflareThreshold = 0.3f;

		public float lensFlareSaturation = 0.75f;

		public Color flareColorA = new Color(0.4f, 0.4f, 0.8f, 0.75f);

		public Color flareColorB = new Color(0.4f, 0.8f, 0.8f, 0.75f);

		public Color flareColorC = new Color(0.8f, 0.4f, 0.8f, 0.75f);

		public Color flareColorD = new Color(0.8f, 0.4f, 0f, 0.75f);

		public Texture2D lensFlareVignetteMask;

		public Shader lensFlareShader;

		private Material lensFlareMaterial;

		public Shader screenBlendShader;

		private Material screenBlend;

		public Shader blurAndFlaresShader;

		private Material blurAndFlaresMaterial;

		public Shader brightPassFilterShader;

		private Material brightPassFilterMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			screenBlend = CheckShaderAndCreateMaterial(screenBlendShader, screenBlend);
			lensFlareMaterial = CheckShaderAndCreateMaterial(lensFlareShader, lensFlareMaterial);
			blurAndFlaresMaterial = CheckShaderAndCreateMaterial(blurAndFlaresShader, blurAndFlaresMaterial);
			brightPassFilterMaterial = CheckShaderAndCreateMaterial(brightPassFilterShader, brightPassFilterMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			doHdr = false;
			if (hdr == HDRBloomMode.Auto)
			{
				doHdr = source.format == RenderTextureFormat.ARGBHalf && GetComponent<Camera>().hdr;
			}
			else
			{
				doHdr = hdr == HDRBloomMode.On;
			}
			doHdr = doHdr && supportHDRTextures;
			BloomScreenBlendMode bloomScreenBlendMode = screenBlendMode;
			if (doHdr)
			{
				bloomScreenBlendMode = BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = ((!doHdr) ? RenderTextureFormat.Default : RenderTextureFormat.ARGBHalf);
			int width = source.width / 2;
			int height = source.height / 2;
			int width2 = source.width / 4;
			int height2 = source.height / 4;
			float num = 1f * (float)source.width / (1f * (float)source.height);
			float num2 = 0.001953125f;
			RenderTexture temporary = RenderTexture.GetTemporary(width2, height2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, format);
			if (quality > BloomQuality.Cheap)
			{
				Graphics.Blit(source, temporary2, screenBlend, 2);
				RenderTexture temporary3 = RenderTexture.GetTemporary(width2, height2, 0, format);
				Graphics.Blit(temporary2, temporary3, screenBlend, 2);
				Graphics.Blit(temporary3, temporary, screenBlend, 6);
				RenderTexture.ReleaseTemporary(temporary3);
			}
			else
			{
				Graphics.Blit(source, temporary2);
				Graphics.Blit(temporary2, temporary, screenBlend, 6);
			}
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width2, height2, 0, format);
			BrightFilter(bloomThreshold * bloomThresholdColor, temporary, renderTexture);
			if (bloomBlurIterations < 1)
			{
				bloomBlurIterations = 1;
			}
			else if (bloomBlurIterations > 10)
			{
				bloomBlurIterations = 10;
			}
			for (int i = 0; i < bloomBlurIterations; i++)
			{
				float num3 = (1f + (float)i * 0.25f) * sepBlurSpread;
				RenderTexture temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(0f, num3 * num2, 0f, 0f));
				Graphics.Blit(renderTexture, temporary4, blurAndFlaresMaterial, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num3 / num * num2, 0f, 0f, 0f));
				Graphics.Blit(renderTexture, temporary4, blurAndFlaresMaterial, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				if (quality > BloomQuality.Cheap)
				{
					if (i == 0)
					{
						Graphics.SetRenderTarget(temporary);
						GL.Clear(clearDepth: false, clearColor: true, Color.black);
						Graphics.Blit(renderTexture, temporary);
					}
					else
					{
						temporary.MarkRestoreExpected();
						Graphics.Blit(renderTexture, temporary, screenBlend, 10);
					}
				}
			}
			if (quality > BloomQuality.Cheap)
			{
				Graphics.SetRenderTarget(renderTexture);
				GL.Clear(clearDepth: false, clearColor: true, Color.black);
				Graphics.Blit(temporary, renderTexture, screenBlend, 6);
			}
			if (lensflareIntensity > Mathf.Epsilon)
			{
				RenderTexture temporary5 = RenderTexture.GetTemporary(width2, height2, 0, format);
				if (lensflareMode == LensFlareStyle.Ghosting)
				{
					BrightFilter(lensflareThreshold, renderTexture, temporary5);
					if (quality > BloomQuality.Cheap)
					{
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f / (1f * (float)temporary.height), 0f, 0f));
						Graphics.SetRenderTarget(temporary);
						GL.Clear(clearDepth: false, clearColor: true, Color.black);
						Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 4);
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(1.5f / (1f * (float)temporary.width), 0f, 0f, 0f));
						Graphics.SetRenderTarget(temporary5);
						GL.Clear(clearDepth: false, clearColor: true, Color.black);
						Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 4);
					}
					Vignette(0.975f, temporary5, temporary5);
					BlendFlares(temporary5, renderTexture);
				}
				else
				{
					float num4 = 1f * Mathf.Cos(flareRotation);
					float num5 = 1f * Mathf.Sin(flareRotation);
					float num6 = hollyStretchWidth * 1f / num * num2;
					blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num4, num5, 0f, 0f));
					blurAndFlaresMaterial.SetVector("_Threshhold", new Vector4(lensflareThreshold, 1f, 0f, 0f));
					blurAndFlaresMaterial.SetVector("_TintColor", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * flareColorA.a * lensflareIntensity);
					blurAndFlaresMaterial.SetFloat("_Saturation", lensFlareSaturation);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 2);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 3);
					blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num4 * num6, num5 * num6, 0f, 0f));
					blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 1);
					blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth * 2f);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 1);
					blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth * 4f);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 1);
					for (int j = 0; j < hollywoodFlareBlurIterations; j++)
					{
						num6 = hollyStretchWidth * 2f / num * num2;
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num6 * num4, num6 * num5, 0f, 0f));
						temporary5.DiscardContents();
						Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 4);
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num6 * num4, num6 * num5, 0f, 0f));
						temporary.DiscardContents();
						Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 4);
					}
					if (lensflareMode == LensFlareStyle.Anamorphic)
					{
						AddTo(1f, temporary, renderTexture);
					}
					else
					{
						Vignette(1f, temporary, temporary5);
						BlendFlares(temporary5, temporary);
						AddTo(1f, temporary, renderTexture);
					}
				}
				RenderTexture.ReleaseTemporary(temporary5);
			}
			int pass = (int)bloomScreenBlendMode;
			screenBlend.SetFloat("_Intensity", bloomIntensity);
			screenBlend.SetTexture("_ColorBuffer", source);
			if (quality > BloomQuality.Cheap)
			{
				RenderTexture temporary6 = RenderTexture.GetTemporary(width, height, 0, format);
				Graphics.Blit(renderTexture, temporary6);
				Graphics.Blit(temporary6, destination, screenBlend, pass);
				RenderTexture.ReleaseTemporary(temporary6);
			}
			else
			{
				Graphics.Blit(renderTexture, destination, screenBlend, pass);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
			screenBlend.SetFloat("_Intensity", intensity_);
			to.MarkRestoreExpected();
			Graphics.Blit(from, to, screenBlend, 9);
		}

		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
			lensFlareMaterial.SetVector("colorA", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorB", new Vector4(flareColorB.r, flareColorB.g, flareColorB.b, flareColorB.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorC", new Vector4(flareColorC.r, flareColorC.g, flareColorC.b, flareColorC.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorD", new Vector4(flareColorD.r, flareColorD.g, flareColorD.b, flareColorD.a) * lensflareIntensity);
			to.MarkRestoreExpected();
			Graphics.Blit(from, to, lensFlareMaterial);
		}

		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
			brightPassFilterMaterial.SetVector("_Threshhold", new Vector4(thresh, thresh, thresh, thresh));
			Graphics.Blit(from, to, brightPassFilterMaterial, 0);
		}

		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
			brightPassFilterMaterial.SetVector("_Threshhold", threshColor);
			Graphics.Blit(from, to, brightPassFilterMaterial, 1);
		}

		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
			if ((bool)lensFlareVignetteMask)
			{
				screenBlend.SetTexture("_ColorBuffer", lensFlareVignetteMask);
				to.MarkRestoreExpected();
				Graphics.Blit((!(from == to)) ? from : null, to, screenBlend, (!(from == to)) ? 3 : 7);
			}
			else if (from != to)
			{
				Graphics.SetRenderTarget(to);
				GL.Clear(clearDepth: false, clearColor: true, Color.black);
				Graphics.Blit(from, to);
			}
		}
	}
	public enum LensflareStyle34
	{
		Ghosting,
		Anamorphic,
		Combined
	}
	public enum TweakMode34
	{
		Basic,
		Complex
	}
	public enum HDRBloomMode
	{
		Auto,
		On,
		Off
	}
	public enum BloomScreenBlendMode
	{
		Screen,
		Add
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/BloomAndFlares (3.5, Deprecated)")]
	public class BloomAndFlares : PostEffectsBase
	{
		public TweakMode34 tweakMode;

		public BloomScreenBlendMode screenBlendMode = BloomScreenBlendMode.Add;

		public HDRBloomMode hdr;

		private bool doHdr;

		public float sepBlurSpread = 1.5f;

		public float useSrcAlphaAsMask = 0.5f;

		public float bloomIntensity = 1f;

		public float bloomThreshold = 0.5f;

		public int bloomBlurIterations = 2;

		public bool lensflares;

		public int hollywoodFlareBlurIterations = 2;

		public LensflareStyle34 lensflareMode = LensflareStyle34.Anamorphic;

		public float hollyStretchWidth = 3.5f;

		public float lensflareIntensity = 1f;

		public float lensflareThreshold = 0.3f;

		public Color flareColorA = new Color(0.4f, 0.4f, 0.8f, 0.75f);

		public Color flareColorB = new Color(0.4f, 0.8f, 0.8f, 0.75f);

		public Color flareColorC = new Color(0.8f, 0.4f, 0.8f, 0.75f);

		public Color flareColorD = new Color(0.8f, 0.4f, 0f, 0.75f);

		public Texture2D lensFlareVignetteMask;

		public Shader lensFlareShader;

		private Material lensFlareMaterial;

		public Shader vignetteShader;

		private Material vignetteMaterial;

		public Shader separableBlurShader;

		private Material separableBlurMaterial;

		public Shader addBrightStuffOneOneShader;

		private Material addBrightStuffBlendOneOneMaterial;

		public Shader screenBlendShader;

		private Material screenBlend;

		public Shader hollywoodFlaresShader;

		private Material hollywoodFlaresMaterial;

		public Shader brightPassFilterShader;

		private Material brightPassFilterMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			screenBlend = CheckShaderAndCreateMaterial(screenBlendShader, screenBlend);
			lensFlareMaterial = CheckShaderAndCreateMaterial(lensFlareShader, lensFlareMaterial);
			vignetteMaterial = CheckShaderAndCreateMaterial(vignetteShader, vignetteMaterial);
			separableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, separableBlurMaterial);
			addBrightStuffBlendOneOneMaterial = CheckShaderAndCreateMaterial(addBrightStuffOneOneShader, addBrightStuffBlendOneOneMaterial);
			hollywoodFlaresMaterial = CheckShaderAndCreateMaterial(hollywoodFlaresShader, hollywoodFlaresMaterial);
			brightPassFilterMaterial = CheckShaderAndCreateMaterial(brightPassFilterShader, brightPassFilterMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			doHdr = false;
			if (hdr == HDRBloomMode.Auto)
			{
				doHdr = source.format == RenderTextureFormat.ARGBHalf && GetComponent<Camera>().hdr;
			}
			else
			{
				doHdr = hdr == HDRBloomMode.On;
			}
			doHdr = doHdr && supportHDRTextures;
			BloomScreenBlendMode pass = screenBlendMode;
			if (doHdr)
			{
				pass = BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = ((!doHdr) ? RenderTextureFormat.Default : RenderTextureFormat.ARGBHalf);
			RenderTexture temporary = RenderTexture.GetTemporary(source.width / 2, source.height / 2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
			float num = 1f * (float)source.width / (1f * (float)source.height);
			float num2 = 0.001953125f;
			Graphics.Blit(source, temporary, screenBlend, 2);
			Graphics.Blit(temporary, temporary2, screenBlend, 2);
			RenderTexture.ReleaseTemporary(temporary);
			BrightFilter(bloomThreshold, useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (bloomBlurIterations < 1)
			{
				bloomBlurIterations = 1;
			}
			for (int i = 0; i < bloomBlurIterations; i++)
			{
				float num3 = (1f + (float)i * 0.5f) * sepBlurSpread;
				separableBlurMaterial.SetVector("offsets", new Vector4(0f, num3 * num2, 0f, 0f));
				RenderTexture renderTexture = ((i != 0) ? temporary2 : temporary3);
				Graphics.Blit(renderTexture, temporary4, separableBlurMaterial);
				renderTexture.DiscardContents();
				separableBlurMaterial.SetVector("offsets", new Vector4(num3 / num * num2, 0f, 0f, 0f));
				Graphics.Blit(temporary4, temporary2, separableBlurMaterial);
				temporary4.DiscardContents();
			}
			if (lensflares)
			{
				if (lensflareMode == LensflareStyle34.Ghosting)
				{
					BrightFilter(lensflareThreshold, 0f, temporary2, temporary4);
					temporary2.DiscardContents();
					Vignette(0.975f, temporary4, temporary3);
					temporary4.DiscardContents();
					BlendFlares(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					hollywoodFlaresMaterial.SetVector("_threshold", new Vector4(lensflareThreshold, 1f / (1f - lensflareThreshold), 0f, 0f));
					hollywoodFlaresMaterial.SetVector("tintColor", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * flareColorA.a * lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 2);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, hollywoodFlaresMaterial, 3);
					temporary3.DiscardContents();
					hollywoodFlaresMaterial.SetVector("offsets", new Vector4(sepBlurSpread * 1f / num * num2, 0f, 0f, 0f));
					hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 1);
					temporary4.DiscardContents();
					hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth * 2f);
					Graphics.Blit(temporary3, temporary4, hollywoodFlaresMaterial, 1);
					temporary3.DiscardContents();
					hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth * 4f);
					Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 1);
					temporary4.DiscardContents();
					if (lensflareMode == LensflareStyle34.Anamorphic)
					{
						for (int j = 0; j < hollywoodFlareBlurIterations; j++)
						{
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary3, temporary4, separableBlurMaterial);
							temporary3.DiscardContents();
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary4, temporary3, separableBlurMaterial);
							temporary4.DiscardContents();
						}
						AddTo(1f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < hollywoodFlareBlurIterations; k++)
						{
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary3, temporary4, separableBlurMaterial);
							temporary3.DiscardContents();
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary4, temporary3, separableBlurMaterial);
							temporary4.DiscardContents();
						}
						Vignette(1f, temporary3, temporary4);
						temporary3.DiscardContents();
						BlendFlares(temporary4, temporary3);
						temporary4.DiscardContents();
						AddTo(1f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			screenBlend.SetFloat("_Intensity", bloomIntensity);
			screenBlend.SetTexture("_ColorBuffer", source);
			Graphics.Blit(temporary2, destination, screenBlend, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
			addBrightStuffBlendOneOneMaterial.SetFloat("_Intensity", intensity_);
			Graphics.Blit(from, to, addBrightStuffBlendOneOneMaterial);
		}

		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
			lensFlareMaterial.SetVector("colorA", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorB", new Vector4(flareColorB.r, flareColorB.g, flareColorB.b, flareColorB.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorC", new Vector4(flareColorC.r, flareColorC.g, flareColorC.b, flareColorC.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorD", new Vector4(flareColorD.r, flareColorD.g, flareColorD.b, flareColorD.a) * lensflareIntensity);
			Graphics.Blit(from, to, lensFlareMaterial);
		}

		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
			if (doHdr)
			{
				brightPassFilterMaterial.SetVector("threshold", new Vector4(thresh, 1f, 0f, 0f));
			}
			else
			{
				brightPassFilterMaterial.SetVector("threshold", new Vector4(thresh, 1f / (1f - thresh), 0f, 0f));
			}
			brightPassFilterMaterial.SetFloat("useSrcAlphaAsMask", useAlphaAsMask);
			Graphics.Blit(from, to, brightPassFilterMaterial);
		}

		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
			if ((bool)lensFlareVignetteMask)
			{
				screenBlend.SetTexture("_ColorBuffer", lensFlareVignetteMask);
				Graphics.Blit(from, to, screenBlend, 3);
			}
			else
			{
				vignetteMaterial.SetFloat("vignetteIntensity", amount);
				Graphics.Blit(from, to, vignetteMaterial);
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom (Optimized)")]
	public class BloomOptimized : PostEffectsBase
	{
		public enum Resolution
		{
			Low,
			High
		}

		public enum BlurType
		{
			Standard,
			Sgx
		}

		[Range(0f, 1.5f)]
		public float threshold = 0.25f;

		[Range(0f, 2.5f)]
		public float intensity = 0.75f;

		[Range(0.25f, 5.5f)]
		public float blurSize = 1f;

		private Resolution resolution;

		[Range(1f, 4f)]
		public int blurIterations = 1;

		public BlurType blurType;

		public Shader fastBloomShader;

		private Material fastBloomMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			fastBloomMaterial = CheckShaderAndCreateMaterial(fastBloomShader, fastBloomMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			if ((bool)fastBloomMaterial)
			{
				UnityEngine.Object.DestroyImmediate(fastBloomMaterial);
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int num = ((resolution != 0) ? 2 : 4);
			float num2 = ((resolution != 0) ? 1f : 0.5f);
			fastBloomMaterial.SetVector("_Parameter", new Vector4(blurSize * num2, 0f, threshold, intensity));
			source.filterMode = FilterMode.Bilinear;
			int width = source.width / num;
			int height = source.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, fastBloomMaterial, 1);
			int num3 = ((blurType != 0) ? 2 : 0);
			for (int i = 0; i < blurIterations; i++)
			{
				fastBloomMaterial.SetVector("_Parameter", new Vector4(blurSize * num2 + (float)i * 1f, 0f, threshold, intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, fastBloomMaterial, 2 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, fastBloomMaterial, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			fastBloomMaterial.SetTexture("_Bloom", renderTexture);
			Graphics.Blit(source, destination, fastBloomMaterial, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Blur/Blur")]
	public class Blur : MonoBehaviour
	{
		public int iterations = 3;

		public float blurSpread = 0.6f;

		public Shader blurShader;

		private static Material m_Material;

		protected Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = new Material(blurShader);
					m_Material.hideFlags = HideFlags.DontSave;
				}
				return m_Material;
			}
		}

		protected void OnDisable()
		{
			if ((bool)m_Material)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
		}

		protected void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
			}
			else if (!blurShader || !material.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
			float num = 0.5f + (float)iteration * blurSpread;
			Graphics.BlitMultiTap(source, dest, material, new Vector2(0f - num, 0f - num), new Vector2(0f - num, num), new Vector2(num, num), new Vector2(num, 0f - num));
		}

		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
			float num = 1f;
			Graphics.BlitMultiTap(source, dest, material, new Vector2(0f - num, 0f - num), new Vector2(0f - num, num), new Vector2(num, num), new Vector2(num, 0f - num));
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			int width = source.width / 4;
			int height = source.height / 4;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0);
			DownSample4x(source, renderTexture);
			for (int i = 0; i < iterations; i++)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				FourTapCone(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, destination);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Blur/Blur (Optimized)")]
	public class BlurOptimized : PostEffectsBase
	{
		public enum BlurType
		{
			StandardGauss,
			SgxGauss
		}

		[Range(0f, 2f)]
		public int downsample = 1;

		[Range(0f, 10f)]
		public float blurSize = 3f;

		[Range(1f, 4f)]
		public int blurIterations = 2;

		public BlurType blurType;

		public Shader blurShader;

		private Material blurMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			blurMaterial = CheckShaderAndCreateMaterial(blurShader, blurMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void OnDisable()
		{
			if ((bool)blurMaterial)
			{
				UnityEngine.Object.DestroyImmediate(blurMaterial);
			}
		}

		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			float num = 1f / (1f * (float)(1 << downsample));
			blurMaterial.SetVector("_Parameter", new Vector4(blurSize * num, (0f - blurSize) * num, 0f, 0f));
			source.filterMode = FilterMode.Bilinear;
			int width = source.width >> downsample;
			int height = source.height >> downsample;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, blurMaterial, 0);
			int num2 = ((blurType != 0) ? 2 : 0);
			for (int i = 0; i < blurIterations; i++)
			{
				float num3 = (float)i * 1f;
				blurMaterial.SetVector("_Parameter", new Vector4(blurSize * num + num3, (0f - blurSize) * num - num3, 0f, 0f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, blurMaterial, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, blurMaterial, 2 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, destination);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Camera Motion Blur")]
	public class CameraMotionBlur : PostEffectsBase
	{
		public enum MotionBlurFilter
		{
			CameraMotion,
			LocalBlur,
			Reconstruction,
			ReconstructionDX11,
			ReconstructionDisc
		}

		private static float MAX_RADIUS = 10f;

		public MotionBlurFilter filterType = MotionBlurFilter.Reconstruction;

		public bool preview;

		public Vector3 previewScale = Vector3.one;

		public float movementScale;

		public float rotationScale = 1f;

		public float maxVelocity = 8f;

		public float minVelocity = 0.1f;

		public float velocityScale = 0.375f;

		public float softZDistance = 0.005f;

		public int velocityDownsample = 1;

		public LayerMask excludeLayers = 0;

		private GameObject tmpCam;

		public Shader shader;

		public Shader dx11MotionBlurShader;

		public Shader replacementClear;

		private Material motionBlurMaterial;

		private Material dx11MotionBlurMaterial;

		public Texture2D noiseTexture;

		public float jitter = 0.05f;

		public bool showVelocity;

		public float showVelocityScale = 1f;

		private Matrix4x4 currentViewProjMat;

		private Matrix4x4 prevViewProjMat;

		private int prevFrameCount;

		private bool wasActive;

		private Vector3 prevFrameForward = Vector3.forward;

		private Vector3 prevFrameUp = Vector3.up;

		private Vector3 prevFramePos = Vector3.zero;

		private Camera _camera;

		private void CalculateViewProjection()
		{
			Matrix4x4 worldToCameraMatrix = _camera.worldToCameraMatrix;
			Matrix4x4 gPUProjectionMatrix = GL.GetGPUProjectionMatrix(_camera.projectionMatrix, renderIntoTexture: true);
			currentViewProjMat = gPUProjectionMatrix * worldToCameraMatrix;
		}

		private new void Start()
		{
			CheckResources();
			if (_camera == null)
			{
				_camera = GetComponent<Camera>();
			}
			wasActive = base.gameObject.activeInHierarchy;
			CalculateViewProjection();
			Remember();
			wasActive = false;
		}

		private void OnEnable()
		{
			if (_camera == null)
			{
				_camera = GetComponent<Camera>();
			}
			_camera.depthTextureMode |= DepthTextureMode.Depth;
		}

		private void OnDisable()
		{
			if (null != motionBlurMaterial)
			{
				UnityEngine.Object.DestroyImmediate(motionBlurMaterial);
				motionBlurMaterial = null;
			}
			if (null != dx11MotionBlurMaterial)
			{
				UnityEngine.Object.DestroyImmediate(dx11MotionBlurMaterial);
				dx11MotionBlurMaterial = null;
			}
			if (null != tmpCam)
			{
				UnityEngine.Object.DestroyImmediate(tmpCam);
				tmpCam = null;
			}
		}

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true, needHdr: true);
			motionBlurMaterial = CheckShaderAndCreateMaterial(shader, motionBlurMaterial);
			if (supportDX11 && filterType == MotionBlurFilter.ReconstructionDX11)
			{
				dx11MotionBlurMaterial = CheckShaderAndCreateMaterial(dx11MotionBlurShader, dx11MotionBlurMaterial);
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (filterType == MotionBlurFilter.CameraMotion)
			{
				StartFrame();
			}
			RenderTextureFormat format = ((!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf)) ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.RGHalf);
			RenderTexture temporary = RenderTexture.GetTemporary(divRoundUp(source.width, velocityDownsample), divRoundUp(source.height, velocityDownsample), 0, format);
			int num = 1;
			int num2 = 1;
			maxVelocity = Mathf.Max(2f, maxVelocity);
			float num3 = maxVelocity;
			bool flag = filterType == MotionBlurFilter.ReconstructionDX11 && dx11MotionBlurMaterial == null;
			if (filterType == MotionBlurFilter.Reconstruction || flag || filterType == MotionBlurFilter.ReconstructionDisc)
			{
				maxVelocity = Mathf.Min(maxVelocity, MAX_RADIUS);
				num = divRoundUp(temporary.width, (int)maxVelocity);
				num2 = divRoundUp(temporary.height, (int)maxVelocity);
				num3 = temporary.width / num;
			}
			else
			{
				num = divRoundUp(temporary.width, (int)maxVelocity);
				num2 = divRoundUp(temporary.height, (int)maxVelocity);
				num3 = temporary.width / num;
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, num2, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, num2, 0, format);
			temporary.filterMode = FilterMode.Point;
			temporary2.filterMode = FilterMode.Point;
			temporary3.filterMode = FilterMode.Point;
			if ((bool)noiseTexture)
			{
				noiseTexture.filterMode = FilterMode.Point;
			}
			source.wrapMode = TextureWrapMode.Clamp;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary3.wrapMode = TextureWrapMode.Clamp;
			temporary2.wrapMode = TextureWrapMode.Clamp;
			CalculateViewProjection();
			if (base.gameObject.activeInHierarchy && !wasActive)
			{
				Remember();
			}
			wasActive = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(currentViewProjMat);
			motionBlurMaterial.SetMatrix("_InvViewProj", matrix4x);
			motionBlurMaterial.SetMatrix("_PrevViewProj", prevViewProjMat);
			motionBlurMaterial.SetMatrix("_ToPrevViewProjCombined", prevViewProjMat * matrix4x);
			motionBlurMaterial.SetFloat("_MaxVelocity", num3);
			motionBlurMaterial.SetFloat("_MaxRadiusOrKInPaper", num3);
			motionBlurMaterial.SetFloat("_MinVelocity", minVelocity);
			motionBlurMaterial.SetFloat("_VelocityScale", velocityScale);
			motionBlurMaterial.SetFloat("_Jitter", jitter);
			motionBlurMaterial.SetTexture("_NoiseTex", noiseTexture);
			motionBlurMaterial.SetTexture("_VelTex", temporary);
			motionBlurMaterial.SetTexture("_NeighbourMaxTex", temporary3);
			motionBlurMaterial.SetTexture("_TileTexDebug", temporary2);
			if (preview)
			{
				Matrix4x4 worldToCameraMatrix = _camera.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(previewScale * 0.3333f, Quaternion.identity, Vector3.one);
				Matrix4x4 gPUProjectionMatrix = GL.GetGPUProjectionMatrix(_camera.projectionMatrix, renderIntoTexture: true);
				prevViewProjMat = gPUProjectionMatrix * identity * worldToCameraMatrix;
				motionBlurMaterial.SetMatrix("_PrevViewProj", prevViewProjMat);
				motionBlurMaterial.SetMatrix("_ToPrevViewProjCombined", prevViewProjMat * matrix4x);
			}
			if (filterType == MotionBlurFilter.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num4 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = prevFramePos - base.transform.position;
				float magnitude = rhs.magnitude;
				float num5 = 1f;
				num5 = Vector3.Angle(base.transform.up, prevFrameUp) / _camera.fieldOfView * ((float)source.width * 0.75f);
				zero.x = rotationScale * num5;
				num5 = Vector3.Angle(base.transform.forward, prevFrameForward) / _camera.fieldOfView * ((float)source.width * 0.75f);
				zero.y = rotationScale * num4 * num5;
				num5 = Vector3.Angle(base.transform.forward, prevFrameForward) / _camera.fieldOfView * ((float)source.width * 0.75f);
				zero.z = rotationScale * (1f - num4) * num5;
				if (magnitude > Mathf.Epsilon && movementScale > Mathf.Epsilon)
				{
					zero.w = movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)source.width * 0.5f);
					zero.x += movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)source.width * 0.5f);
					zero.y += movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)source.width * 0.5f);
				}
				if (preview)
				{
					motionBlurMaterial.SetVector("_BlurDirectionPacked", new Vector4(previewScale.y, previewScale.x, 0f, previewScale.z) * 0.5f * _camera.fieldOfView);
				}
				else
				{
					motionBlurMaterial.SetVector("_BlurDirectionPacked", zero);
				}
			}
			else
			{
				Graphics.Blit(source, temporary, motionBlurMaterial, 0);
				Camera camera = null;
				if (excludeLayers.value != 0)
				{
					camera = GetTmpCam();
				}
				if ((bool)camera && excludeLayers.value != 0 && (bool)replacementClear && replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = excludeLayers;
					camera.RenderWithShader(replacementClear, string.Empty);
				}
			}
			if (!preview && Time.frameCount != prevFrameCount)
			{
				prevFrameCount = Time.frameCount;
				Remember();
			}
			source.filterMode = FilterMode.Bilinear;
			if (showVelocity)
			{
				motionBlurMaterial.SetFloat("_DisplayVelocityScale", showVelocityScale);
				Graphics.Blit(temporary, destination, motionBlurMaterial, 1);
			}
			else if (filterType == MotionBlurFilter.ReconstructionDX11 && !flag)
			{
				dx11MotionBlurMaterial.SetFloat("_MinVelocity", minVelocity);
				dx11MotionBlurMaterial.SetFloat("_VelocityScale", velocityScale);
				dx11MotionBlurMaterial.SetFloat("_Jitter", jitter);
				dx11MotionBlurMaterial.SetTexture("_NoiseTex", noiseTexture);
				dx11MotionBlurMaterial.SetTexture("_VelTex", temporary);
				dx11MotionBlurMaterial.SetTexture("_NeighbourMaxTex", temporary3);
				dx11MotionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
				dx11MotionBlurMaterial.SetFloat("_MaxRadiusOrKInPaper", num3);
				Graphics.Blit(temporary, temporary2, dx11MotionBlurMaterial, 0);
				Graphics.Blit(temporary2, temporary3, dx11MotionBlurMaterial, 1);
				Graphics.Blit(source, destination, dx11MotionBlurMaterial, 2);
			}
			else if (filterType == MotionBlurFilter.Reconstruction || flag)
			{
				motionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
				Graphics.Blit(temporary, temporary2, motionBlurMaterial, 2);
				Graphics.Blit(temporary2, temporary3, motionBlurMaterial, 3);
				Graphics.Blit(source, destination, motionBlurMaterial, 4);
			}
			else if (filterType == MotionBlurFilter.CameraMotion)
			{
				Graphics.Blit(source, destination, motionBlurMaterial, 6);
			}
			else if (filterType == MotionBlurFilter.ReconstructionDisc)
			{
				motionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
				Graphics.Blit(temporary, temporary2, motionBlurMaterial, 2);
				Graphics.Blit(temporary2, temporary3, motionBlurMaterial, 3);
				Graphics.Blit(source, destination, motionBlurMaterial, 7);
			}
			else
			{
				Graphics.Blit(source, destination, motionBlurMaterial, 5);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		private void Remember()
		{
			prevViewProjMat = currentViewProjMat;
			prevFrameForward = base.transform.forward;
			prevFrameUp = base.transform.up;
			prevFramePos = base.transform.position;
		}

		private Camera GetTmpCam()
		{
			if (tmpCam == null)
			{
				string text = "_" + _camera.name + "_MotionBlurTmpCam";
				GameObject gameObject = GameObject.Find(text);
				if (null == gameObject)
				{
					tmpCam = new GameObject(text, typeof(Camera));
				}
				else
				{
					tmpCam = gameObject;
				}
			}
			tmpCam.hideFlags = HideFlags.DontSave;
			tmpCam.transform.position = _camera.transform.position;
			tmpCam.transform.rotation = _camera.transform.rotation;
			tmpCam.transform.localScale = _camera.transform.localScale;
			tmpCam.GetComponent<Camera>().CopyFrom(_camera);
			tmpCam.GetComponent<Camera>().enabled = false;
			tmpCam.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			tmpCam.GetComponent<Camera>().clearFlags = CameraClearFlags.Nothing;
			return tmpCam.GetComponent<Camera>();
		}

		private void StartFrame()
		{
			prevFramePos = Vector3.Slerp(prevFramePos, base.transform.position, 0.75f);
		}

		private static int divRoundUp(int x, int d)
		{
			return (x + d - 1) / d;
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Curves, Saturation)")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		public enum ColorCorrectionMode
		{
			Simple,
			Advanced
		}

		public AnimationCurve redChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve greenChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve blueChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public bool useDepthCorrection;

		public AnimationCurve zCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve depthRedChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve depthGreenChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve depthBlueChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		private Material ccMaterial;

		private Material ccDepthMaterial;

		private Material selectiveCcMaterial;

		private Texture2D rgbChannelTex;

		private Texture2D rgbDepthChannelTex;

		private Texture2D zCurveTex;

		public float saturation = 1f;

		public bool selectiveCc;

		public Color selectiveFromColor = Color.white;

		public Color selectiveToColor = Color.white;

		public ColorCorrectionMode mode;

		public bool updateTextures = true;

		public Shader colorCorrectionCurvesShader;

		public Shader simpleColorCorrectionCurvesShader;

		public Shader colorCorrectionSelectiveShader;

		private bool updateTexturesOnStartup = true;

		private new void Start()
		{
			base.Start();
			updateTexturesOnStartup = true;
		}

		private void Awake()
		{
		}

		public override bool CheckResources()
		{
			CheckSupport(mode == ColorCorrectionMode.Advanced);
			ccMaterial = CheckShaderAndCreateMaterial(simpleColorCorrectionCurvesShader, ccMaterial);
			ccDepthMaterial = CheckShaderAndCreateMaterial(colorCorrectionCurvesShader, ccDepthMaterial);
			selectiveCcMaterial = CheckShaderAndCreateMaterial(colorCorrectionSelectiveShader, selectiveCcMaterial);
			if (!rgbChannelTex)
			{
				rgbChannelTex = new Texture2D(256, 4, TextureFormat.ARGB32, mipmap: false, linear: true);
			}
			if (!rgbDepthChannelTex)
			{
				rgbDepthChannelTex = new Texture2D(256, 4, TextureFormat.ARGB32, mipmap: false, linear: true);
			}
			if (!zCurveTex)
			{
				zCurveTex = new Texture2D(256, 1, TextureFormat.ARGB32, mipmap: false, linear: true);
			}
			rgbChannelTex.hideFlags = HideFlags.DontSave;
			rgbDepthChannelTex.hideFlags = HideFlags.DontSave;
			zCurveTex.hideFlags = HideFlags.DontSave;
			rgbChannelTex.wrapMode = TextureWrapMode.Clamp;
			rgbDepthChannelTex.wrapMode = TextureWrapMode.Clamp;
			zCurveTex.wrapMode = TextureWrapMode.Clamp;
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void UpdateParameters()
		{
			CheckResources();
			if (redChannel != null && greenChannel != null && blueChannel != null)
			{
				for (float num = 0f; num <= 1f; num += 0.003921569f)
				{
					float num2 = Mathf.Clamp(redChannel.Evaluate(num), 0f, 1f);
					float num3 = Mathf.Clamp(greenChannel.Evaluate(num), 0f, 1f);
					float num4 = Mathf.Clamp(blueChannel.Evaluate(num), 0f, 1f);
					rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num2, num2, num2));
					rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 1, new Color(num3, num3, num3));
					rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 2, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(zCurve.Evaluate(num), 0f, 1f);
					zCurveTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(depthRedChannel.Evaluate(num), 0f, 1f);
					num3 = Mathf.Clamp(depthGreenChannel.Evaluate(num), 0f, 1f);
					num4 = Mathf.Clamp(depthBlueChannel.Evaluate(num), 0f, 1f);
					rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num2, num2, num2));
					rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 1, new Color(num3, num3, num3));
					rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 2, new Color(num4, num4, num4));
				}
				rgbChannelTex.Apply();
				rgbDepthChannelTex.Apply();
				zCurveTex.Apply();
			}
		}

		private void UpdateTextures()
		{
			UpdateParameters();
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (updateTexturesOnStartup)
			{
				UpdateParameters();
				updateTexturesOnStartup = false;
			}
			if (useDepthCorrection)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			RenderTexture renderTexture = destination;
			if (selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(source.width, source.height);
			}
			if (useDepthCorrection)
			{
				ccDepthMaterial.SetTexture("_RgbTex", rgbChannelTex);
				ccDepthMaterial.SetTexture("_ZCurve", zCurveTex);
				ccDepthMaterial.SetTexture("_RgbDepthTex", rgbDepthChannelTex);
				ccDepthMaterial.SetFloat("_Saturation", saturation);
				Graphics.Blit(source, renderTexture, ccDepthMaterial);
			}
			else
			{
				ccMaterial.SetTexture("_RgbTex", rgbChannelTex);
				ccMaterial.SetFloat("_Saturation", saturation);
				Graphics.Blit(source, renderTexture, ccMaterial);
			}
			if (selectiveCc)
			{
				selectiveCcMaterial.SetColor("selColor", selectiveFromColor);
				selectiveCcMaterial.SetColor("targetColor", selectiveToColor);
				Graphics.Blit(renderTexture, destination, selectiveCcMaterial);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (3D Lookup Texture)")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		public Shader shader;

		private Material material;

		public Texture3D converted3DLut;

		public string basedOnTempTex = string.Empty;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			material = CheckShaderAndCreateMaterial(shader, material);
			if (!isSupported || !SystemInfo.supports3DTextures)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			if ((bool)material)
			{
				UnityEngine.Object.DestroyImmediate(material);
				material = null;
			}
		}

		private void OnDestroy()
		{
			if ((bool)converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(converted3DLut);
			}
			converted3DLut = null;
		}

		public void SetIdentityLut()
		{
			int num = 16;
			Color[] array = new Color[num * num * num];
			float num2 = 1f / (1f * (float)num - 1f);
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = new Color((float)i * 1f * num2, (float)j * 1f * num2, (float)k * 1f * num2, 1f);
					}
				}
			}
			if ((bool)converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(converted3DLut);
			}
			converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, mipmap: false);
			converted3DLut.SetPixels(array);
			converted3DLut.Apply();
			basedOnTempTex = string.Empty;
		}

		public bool ValidDimensions(Texture2D tex2d)
		{
			if (!tex2d)
			{
				return false;
			}
			int height = tex2d.height;
			if (height != Mathf.FloorToInt(Mathf.Sqrt(tex2d.width)))
			{
				return false;
			}
			return true;
		}

		public void Convert(Texture2D temp2DTex, string path)
		{
			if ((bool)temp2DTex)
			{
				int num = temp2DTex.width * temp2DTex.height;
				num = temp2DTex.height;
				if (!ValidDimensions(temp2DTex))
				{
					Debug.LogWarning("The given 2D texture " + temp2DTex.name + " cannot be used as a 3D LUT.");
					basedOnTempTex = string.Empty;
					return;
				}
				Color[] pixels = temp2DTex.GetPixels();
				Color[] array = new Color[pixels.Length];
				for (int i = 0; i < num; i++)
				{
					for (int j = 0; j < num; j++)
					{
						for (int k = 0; k < num; k++)
						{
							int num2 = num - j - 1;
							ref Color reference = ref array[i + j * num + k * num * num];
							reference = pixels[k * num + i + num2 * num * num];
						}
					}
				}
				if ((bool)converted3DLut)
				{
					UnityEngine.Object.DestroyImmediate(converted3DLut);
				}
				converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, mipmap: false);
				converted3DLut.SetPixels(array);
				converted3DLut.Apply();
				basedOnTempTex = path;
			}
			else
			{
				Debug.LogError("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.");
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (converted3DLut == null)
			{
				SetIdentityLut();
			}
			int width = converted3DLut.width;
			converted3DLut.wrapMode = TextureWrapMode.Clamp;
			material.SetFloat("_Scale", (float)(width - 1) / (1f * (float)width));
			material.SetFloat("_Offset", 1f / (2f * (float)width));
			material.SetTexture("_ClutTex", converted3DLut);
			Graphics.Blit(source, destination, material, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Ramp)")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		public Texture textureRamp;

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			base.material.SetTexture("_RampTex", textureRamp);
			Graphics.Blit(source, destination, base.material);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Enhance (Unsharp Mask)")]
	internal class ContrastEnhance : PostEffectsBase
	{
		public float intensity = 0.5f;

		public float threshold;

		private Material separableBlurMaterial;

		private Material contrastCompositeMaterial;

		public float blurSpread = 1f;

		public Shader separableBlurShader;

		public Shader contrastCompositeShader;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			contrastCompositeMaterial = CheckShaderAndCreateMaterial(contrastCompositeShader, contrastCompositeMaterial);
			separableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, separableBlurMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 2, 0);
			Graphics.Blit(source, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			separableBlurMaterial.SetVector("offsets", new Vector4(0f, blurSpread * 1f / (float)temporary2.height, 0f, 0f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary2, temporary3, separableBlurMaterial);
			RenderTexture.ReleaseTemporary(temporary2);
			separableBlurMaterial.SetVector("offsets", new Vector4(blurSpread * 1f / (float)temporary2.width, 0f, 0f, 0f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary3, temporary2, separableBlurMaterial);
			RenderTexture.ReleaseTemporary(temporary3);
			contrastCompositeMaterial.SetTexture("_MainTexBlurred", temporary2);
			contrastCompositeMaterial.SetFloat("intensity", intensity);
			contrastCompositeMaterial.SetFloat("threshhold", threshold);
			Graphics.Blit(source, destination, contrastCompositeMaterial);
			RenderTexture.ReleaseTemporary(temporary2);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Stretch")]
	public class ContrastStretch : MonoBehaviour
	{
		public float adaptationSpeed = 0.02f;

		public float limitMinimum = 0.2f;

		public float limitMaximum = 0.6f;

		private RenderTexture[] adaptRenderTex = new RenderTexture[2];

		private int curAdaptIndex;

		public Shader shaderLum;

		private Material m_materialLum;

		public Shader shaderReduce;

		private Material m_materialReduce;

		public Shader shaderAdapt;

		private Material m_materialAdapt;

		public Shader shaderApply;

		private Material m_materialApply;

		protected Material materialLum
		{
			get
			{
				if (m_materialLum == null)
				{
					m_materialLum = new Material(shaderLum);
					m_materialLum.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_materialLum;
			}
		}

		protected Material materialReduce
		{
			get
			{
				if (m_materialReduce == null)
				{
					m_materialReduce = new Material(shaderReduce);
					m_materialReduce.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_materialReduce;
			}
		}

		protected Material materialAdapt
		{
			get
			{
				if (m_materialAdapt == null)
				{
					m_materialAdapt = new Material(shaderAdapt);
					m_materialAdapt.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_materialAdapt;
			}
		}

		protected Material materialApply
		{
			get
			{
				if (m_materialApply == null)
				{
					m_materialApply = new Material(shaderApply);
					m_materialApply.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_materialApply;
			}
		}

		private void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
			}
			else if (!shaderAdapt.isSupported || !shaderApply.isSupported || !shaderLum.isSupported || !shaderReduce.isSupported)
			{
				base.enabled = false;
			}
		}

		private void OnEnable()
		{
			for (int i = 0; i < 2; i++)
			{
				if (!adaptRenderTex[i])
				{
					adaptRenderTex[i] = new RenderTexture(1, 1, 0);
					adaptRenderTex[i].hideFlags = HideFlags.HideAndDontSave;
				}
			}
		}

		private void OnDisable()
		{
			for (int i = 0; i < 2; i++)
			{
				UnityEngine.Object.DestroyImmediate(adaptRenderTex[i]);
				adaptRenderTex[i] = null;
			}
			if ((bool)m_materialLum)
			{
				UnityEngine.Object.DestroyImmediate(m_materialLum);
			}
			if ((bool)m_materialReduce)
			{
				UnityEngine.Object.DestroyImmediate(m_materialReduce);
			}
			if ((bool)m_materialAdapt)
			{
				UnityEngine.Object.DestroyImmediate(m_materialAdapt);
			}
			if ((bool)m_materialApply)
			{
				UnityEngine.Object.DestroyImmediate(m_materialApply);
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(source.width, source.height);
			Graphics.Blit(source, renderTexture, materialLum);
			while (renderTexture.width > 1 || renderTexture.height > 1)
			{
				int num = renderTexture.width / 2;
				if (num < 1)
				{
					num = 1;
				}
				int num2 = renderTexture.height / 2;
				if (num2 < 1)
				{
					num2 = 1;
				}
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2);
				Graphics.Blit(renderTexture, temporary, materialReduce);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			CalculateAdaptation(renderTexture);
			materialApply.SetTexture("_AdaptTex", adaptRenderTex[curAdaptIndex]);
			Graphics.Blit(source, destination, materialApply);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		private void CalculateAdaptation(Texture curTexture)
		{
			int num = curAdaptIndex;
			curAdaptIndex = (curAdaptIndex + 1) % 2;
			float value = 1f - Mathf.Pow(1f - adaptationSpeed, 30f * Time.deltaTime);
			value = Mathf.Clamp(value, 0.01f, 1f);
			materialAdapt.SetTexture("_CurTex", curTexture);
			materialAdapt.SetVector("_AdaptParams", new Vector4(value, limitMinimum, limitMaximum, 0f));
			Graphics.SetRenderTarget(adaptRenderTex[curAdaptIndex]);
			GL.Clear(clearDepth: false, clearColor: true, Color.black);
			Graphics.Blit(adaptRenderTex[num], adaptRenderTex[curAdaptIndex], materialAdapt);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Edge Detection/Crease Shading")]
	internal class CreaseShading : PostEffectsBase
	{
		public float intensity = 0.5f;

		public int softness = 1;

		public float spread = 1f;

		public Shader blurShader;

		private Material blurMaterial;

		public Shader depthFetchShader;

		private Material depthFetchMaterial;

		public Shader creaseApplyShader;

		private Material creaseApplyMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			blurMaterial = CheckShaderAndCreateMaterial(blurShader, blurMaterial);
			depthFetchMaterial = CheckShaderAndCreateMaterial(depthFetchShader, depthFetchMaterial);
			creaseApplyMaterial = CheckShaderAndCreateMaterial(creaseApplyShader, creaseApplyMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			float num = 1f * (float)width / (1f * (float)height);
			float num2 = 0.001953125f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 2, height / 2, 0);
			Graphics.Blit(source, temporary, depthFetchMaterial);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 2, height / 2, 0);
				blurMaterial.SetVector("offsets", new Vector4(0f, spread * num2, 0f, 0f));
				Graphics.Blit(renderTexture, temporary2, blurMaterial);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 2, height / 2, 0);
				blurMaterial.SetVector("offsets", new Vector4(spread * num2 / num, 0f, 0f, 0f));
				Graphics.Blit(renderTexture, temporary2, blurMaterial);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			creaseApplyMaterial.SetTexture("_HrDepthTex", temporary);
			creaseApplyMaterial.SetTexture("_LrDepthTex", renderTexture);
			creaseApplyMaterial.SetFloat("intensity", intensity);
			Graphics.Blit(source, destination, creaseApplyMaterial);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (Lens Blur, Scatter, DX11)")]
	public class DepthOfField : PostEffectsBase
	{
		public enum BlurType
		{
			DiscBlur,
			DX11
		}

		public enum BlurSampleCount
		{
			Low,
			Medium,
			High
		}

		public bool visualizeFocus;

		public float focalLength = 10f;

		public float focalSize = 0.05f;

		public float aperture = 11.5f;

		public Transform focalTransform;

		public float maxBlurSize = 2f;

		public bool highResolution;

		public BlurType blurType;

		public BlurSampleCount blurSampleCount = BlurSampleCount.High;

		public bool nearBlur;

		public float foregroundOverlap = 1f;

		public Shader dofHdrShader;

		private Material dofHdrMaterial;

		public Shader dx11BokehShader;

		private Material dx11bokehMaterial;

		public float dx11BokehThreshold = 0.5f;

		public float dx11SpawnHeuristic = 0.0875f;

		public Texture2D dx11BokehTexture;

		public float dx11BokehScale = 1.2f;

		public float dx11BokehIntensity = 2.5f;

		private float focalDistance01 = 10f;

		private ComputeBuffer cbDrawArgs;

		private ComputeBuffer cbPoints;

		private float internalBlurWidth = 1f;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			dofHdrMaterial = CheckShaderAndCreateMaterial(dofHdrShader, dofHdrMaterial);
			if (supportDX11 && blurType == BlurType.DX11)
			{
				dx11bokehMaterial = CheckShaderAndCreateMaterial(dx11BokehShader, dx11bokehMaterial);
				CreateComputeResources();
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnEnable()
		{
			GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
		}

		private void OnDisable()
		{
			ReleaseComputeResources();
			if ((bool)dofHdrMaterial)
			{
				UnityEngine.Object.DestroyImmediate(dofHdrMaterial);
			}
			dofHdrMaterial = null;
			if ((bool)dx11bokehMaterial)
			{
				UnityEngine.Object.DestroyImmediate(dx11bokehMaterial);
			}
			dx11bokehMaterial = null;
		}

		private void ReleaseComputeResources()
		{
			if (cbDrawArgs != null)
			{
				cbDrawArgs.Release();
			}
			cbDrawArgs = null;
			if (cbPoints != null)
			{
				cbPoints.Release();
			}
			cbPoints = null;
		}

		private void CreateComputeResources()
		{
			if (cbDrawArgs == null)
			{
				cbDrawArgs = new ComputeBuffer(1, 16, ComputeBufferType.DrawIndirect);
				int[] data = new int[4] { 0, 1, 0, 0 };
				cbDrawArgs.SetData(data);
			}
			if (cbPoints == null)
			{
				cbPoints = new ComputeBuffer(90000, 28, ComputeBufferType.Append);
			}
		}

		private float FocalDistance01(float worldDist)
		{
			return GetComponent<Camera>().WorldToViewportPoint((worldDist - GetComponent<Camera>().nearClipPlane) * GetComponent<Camera>().transform.forward + GetComponent<Camera>().transform.position).z / (GetComponent<Camera>().farClipPlane - GetComponent<Camera>().nearClipPlane);
		}

		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
			dofHdrMaterial.SetTexture("_FgOverlap", null);
			if (nearBlur && fgDilate)
			{
				int width = fromTo.width / 2;
				int height = fromTo.height / 2;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, fromTo.format);
				Graphics.Blit(fromTo, temporary, dofHdrMaterial, 4);
				float num = internalBlurWidth * foregroundOverlap;
				dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, fromTo.format);
				Graphics.Blit(temporary, temporary2, dofHdrMaterial, 2);
				RenderTexture.ReleaseTemporary(temporary);
				dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
				temporary = RenderTexture.GetTemporary(width, height, 0, fromTo.format);
				Graphics.Blit(temporary2, temporary, dofHdrMaterial, 2);
				RenderTexture.ReleaseTemporary(temporary2);
				dofHdrMaterial.SetTexture("_FgOverlap", temporary);
				fromTo.MarkRestoreExpected();
				Graphics.Blit(fromTo, fromTo, dofHdrMaterial, 13);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				fromTo.MarkRestoreExpected();
				Graphics.Blit(fromTo, fromTo, dofHdrMaterial, 0);
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (aperture < 0f)
			{
				aperture = 0f;
			}
			if (maxBlurSize < 0.1f)
			{
				maxBlurSize = 0.1f;
			}
			focalSize = Mathf.Clamp(focalSize, 0f, 2f);
			internalBlurWidth = Mathf.Max(maxBlurSize, 0f);
			focalDistance01 = ((!focalTransform) ? FocalDistance01(focalLength) : (GetComponent<Camera>().WorldToViewportPoint(focalTransform.position).z / GetComponent<Camera>().farClipPlane));
			dofHdrMaterial.SetVector("_CurveParams", new Vector4(1f, focalSize, aperture / 10f, focalDistance01));
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			RenderTexture renderTexture3 = null;
			RenderTexture renderTexture4 = null;
			float num = internalBlurWidth * foregroundOverlap;
			if (visualizeFocus)
			{
				WriteCoc(source, fgDilate: true);
				Graphics.Blit(source, destination, dofHdrMaterial, 16);
			}
			else if (blurType == BlurType.DX11 && (bool)dx11bokehMaterial)
			{
				if (highResolution)
				{
					internalBlurWidth = ((!(internalBlurWidth < 0.1f)) ? internalBlurWidth : 0.1f);
					num = internalBlurWidth * foregroundOverlap;
					renderTexture = RenderTexture.GetTemporary(source.width, source.height, 0, source.format);
					RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height, 0, source.format);
					WriteCoc(source, fgDilate: false);
					renderTexture3 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					renderTexture4 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					Graphics.Blit(source, renderTexture3, dofHdrMaterial, 15);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
					Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 19);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
					Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 19);
					if (nearBlur)
					{
						Graphics.Blit(source, renderTexture4, dofHdrMaterial, 4);
					}
					dx11bokehMaterial.SetTexture("_BlurredColor", renderTexture3);
					dx11bokehMaterial.SetFloat("_SpawnHeuristic", dx11SpawnHeuristic);
					dx11bokehMaterial.SetVector("_BokehParams", new Vector4(dx11BokehScale, dx11BokehIntensity, Mathf.Clamp(dx11BokehThreshold, 0.005f, 4f), internalBlurWidth));
					dx11bokehMaterial.SetTexture("_FgCocMask", (!nearBlur) ? null : renderTexture4);
					Graphics.SetRandomWriteTarget(1, cbPoints);
					Graphics.Blit(source, renderTexture, dx11bokehMaterial, 0);
					Graphics.ClearRandomWriteTargets();
					if (nearBlur)
					{
						dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
						Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 2);
						dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
						Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 2);
						Graphics.Blit(renderTexture4, renderTexture, dofHdrMaterial, 3);
					}
					Graphics.Blit(renderTexture, temporary, dofHdrMaterial, 20);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(internalBlurWidth, 0f, 0f, internalBlurWidth));
					Graphics.Blit(renderTexture, source, dofHdrMaterial, 5);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0f, internalBlurWidth));
					Graphics.Blit(source, temporary, dofHdrMaterial, 21);
					Graphics.SetRenderTarget(temporary);
					ComputeBuffer.CopyCount(cbPoints, cbDrawArgs, 0);
					dx11bokehMaterial.SetBuffer("pointBuffer", cbPoints);
					dx11bokehMaterial.SetTexture("_MainTex", dx11BokehTexture);
					dx11bokehMaterial.SetVector("_Screen", new Vector3(1f / (1f * (float)source.width), 1f / (1f * (float)source.height), internalBlurWidth));
					dx11bokehMaterial.SetPass(2);
					Graphics.DrawProceduralIndirect(MeshTopology.Points, cbDrawArgs, 0);
					Graphics.Blit(temporary, destination);
					RenderTexture.ReleaseTemporary(temporary);
					RenderTexture.ReleaseTemporary(renderTexture3);
					RenderTexture.ReleaseTemporary(renderTexture4);
				}
				else
				{
					renderTexture = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					renderTexture2 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					num = internalBlurWidth * foregroundOverlap;
					WriteCoc(source, fgDilate: false);
					source.filterMode = FilterMode.Bilinear;
					Graphics.Blit(source, renderTexture, dofHdrMaterial, 6);
					renderTexture3 = RenderTexture.GetTemporary(renderTexture.width >> 1, renderTexture.height >> 1, 0, renderTexture.format);
					renderTexture4 = RenderTexture.GetTemporary(renderTexture.width >> 1, renderTexture.height >> 1, 0, renderTexture.format);
					Graphics.Blit(renderTexture, renderTexture3, dofHdrMaterial, 15);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
					Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 19);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
					Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 19);
					RenderTexture renderTexture5 = null;
					if (nearBlur)
					{
						renderTexture5 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
						Graphics.Blit(source, renderTexture5, dofHdrMaterial, 4);
					}
					dx11bokehMaterial.SetTexture("_BlurredColor", renderTexture3);
					dx11bokehMaterial.SetFloat("_SpawnHeuristic", dx11SpawnHeuristic);
					dx11bokehMaterial.SetVector("_BokehParams", new Vector4(dx11BokehScale, dx11BokehIntensity, Mathf.Clamp(dx11BokehThreshold, 0.005f, 4f), internalBlurWidth));
					dx11bokehMaterial.SetTexture("_FgCocMask", renderTexture5);
					Graphics.SetRandomWriteTarget(1, cbPoints);
					Graphics.Blit(renderTexture, renderTexture2, dx11bokehMaterial, 0);
					Graphics.ClearRandomWriteTargets();
					RenderTexture.ReleaseTemporary(renderTexture3);
					RenderTexture.ReleaseTemporary(renderTexture4);
					if (nearBlur)
					{
						dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
						Graphics.Blit(renderTexture5, renderTexture, dofHdrMaterial, 2);
						dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
						Graphics.Blit(renderTexture, renderTexture5, dofHdrMaterial, 2);
						Graphics.Blit(renderTexture5, renderTexture2, dofHdrMaterial, 3);
					}
					dofHdrMaterial.SetVector("_Offsets", new Vector4(internalBlurWidth, 0f, 0f, internalBlurWidth));
					Graphics.Blit(renderTexture2, renderTexture, dofHdrMaterial, 5);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0f, internalBlurWidth));
					Graphics.Blit(renderTexture, renderTexture2, dofHdrMaterial, 5);
					Graphics.SetRenderTarget(renderTexture2);
					ComputeBuffer.CopyCount(cbPoints, cbDrawArgs, 0);
					dx11bokehMaterial.SetBuffer("pointBuffer", cbPoints);
					dx11bokehMaterial.SetTexture("_MainTex", dx11BokehTexture);
					dx11bokehMaterial.SetVector("_Screen", new Vector3(1f / (1f * (float)renderTexture2.width), 1f / (1f * (float)renderTexture2.height), internalBlurWidth));
					dx11bokehMaterial.SetPass(1);
					Graphics.DrawProceduralIndirect(MeshTopology.Points, cbDrawArgs, 0);
					dofHdrMaterial.SetTexture("_LowRez", renderTexture2);
					dofHdrMaterial.SetTexture("_FgOverlap", renderTexture5);
					dofHdrMaterial.SetVector("_Offsets", 1f * (float)source.width / (1f * (float)renderTexture2.width) * internalBlurWidth * Vector4.one);
					Graphics.Blit(source, destination, dofHdrMaterial, 9);
					if ((bool)renderTexture5)
					{
						RenderTexture.ReleaseTemporary(renderTexture5);
					}
				}
			}
			else
			{
				source.filterMode = FilterMode.Bilinear;
				if (highResolution)
				{
					internalBlurWidth *= 2f;
				}
				WriteCoc(source, fgDilate: true);
				renderTexture = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
				renderTexture2 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
				int pass = ((blurSampleCount != BlurSampleCount.High && blurSampleCount != BlurSampleCount.Medium) ? 11 : 17);
				if (highResolution)
				{
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0.025f, internalBlurWidth));
					Graphics.Blit(source, destination, dofHdrMaterial, pass);
				}
				else
				{
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0.1f, internalBlurWidth));
					Graphics.Blit(source, renderTexture, dofHdrMaterial, 6);
					Graphics.Blit(renderTexture, renderTexture2, dofHdrMaterial, pass);
					dofHdrMaterial.SetTexture("_LowRez", renderTexture2);
					dofHdrMaterial.SetTexture("_FgOverlap", null);
					dofHdrMaterial.SetVector("_Offsets", Vector4.one * (1f * (float)source.width / (1f * (float)renderTexture2.width)) * internalBlurWidth);
					Graphics.Blit(source, destination, dofHdrMaterial, (blurSampleCount != BlurSampleCount.High) ? 12 : 18);
				}
			}
			if ((bool)renderTexture)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
			if ((bool)renderTexture2)
			{
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (deprecated)")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		public enum Dof34QualitySetting
		{
			OnlyBackground = 1,
			BackgroundAndForeground
		}

		public enum DofResolution
		{
			High = 2,
			Medium,
			Low
		}

		public enum DofBlurriness
		{
			Low = 1,
			High = 2,
			VeryHigh = 4
		}

		public enum BokehDestination
		{
			Background = 1,
			Foreground,
			BackgroundAndForeground
		}

		private static int SMOOTH_DOWNSAMPLE_PASS = 6;

		private static float BOKEH_EXTRA_BLUR = 2f;

		public Dof34QualitySetting quality = Dof34QualitySetting.OnlyBackground;

		public DofResolution resolution = DofResolution.Low;

		public bool simpleTweakMode = true;

		public float focalPoint = 1f;

		public float smoothness = 0.5f;

		public float focalZDistance;

		public float focalZStartCurve = 1f;

		public float focalZEndCurve = 1f;

		private float focalStartCurve = 2f;

		private float focalEndCurve = 2f;

		private float focalDistance01 = 0.1f;

		public Transform objectFocus;

		public float focalSize;

		public DofBlurriness bluriness = DofBlurriness.High;

		public float maxBlurSpread = 1.75f;

		public float foregroundBlurExtrude = 1.15f;

		public Shader dofBlurShader;

		private Material dofBlurMaterial;

		public Shader dofShader;

		private Material dofMaterial;

		public bool visualize;

		public BokehDestination bokehDestination = BokehDestination.Background;

		private float widthOverHeight = 1.25f;

		private float oneOverBaseSize = 0.001953125f;

		public bool bokeh;

		public bool bokehSupport = true;

		public Shader bokehShader;

		public Texture2D bokehTexture;

		public float bokehScale = 2.4f;

		public float bokehIntensity = 0.15f;

		public float bokehThresholdContrast = 0.1f;

		public float bokehThresholdLuminance = 0.55f;

		public int bokehDownsample = 1;

		private Material bokehMaterial;

		private Camera _camera;

		private RenderTexture foregroundTexture;

		private RenderTexture mediumRezWorkTexture;

		private RenderTexture finalDefocus;

		private RenderTexture lowRezWorkTexture;

		private RenderTexture bokehSource;

		private RenderTexture bokehSource2;

		private void CreateMaterials()
		{
			dofBlurMaterial = CheckShaderAndCreateMaterial(dofBlurShader, dofBlurMaterial);
			dofMaterial = CheckShaderAndCreateMaterial(dofShader, dofMaterial);
			bokehSupport = bokehShader.isSupported;
			if (bokeh && bokehSupport && (bool)bokehShader)
			{
				bokehMaterial = CheckShaderAndCreateMaterial(bokehShader, bokehMaterial);
			}
		}

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			dofBlurMaterial = CheckShaderAndCreateMaterial(dofBlurShader, dofBlurMaterial);
			dofMaterial = CheckShaderAndCreateMaterial(dofShader, dofMaterial);
			bokehSupport = bokehShader.isSupported;
			if (bokeh && bokehSupport && (bool)bokehShader)
			{
				bokehMaterial = CheckShaderAndCreateMaterial(bokehShader, bokehMaterial);
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			Quads.Cleanup();
		}

		private void OnEnable()
		{
			_camera = GetComponent<Camera>();
			_camera.depthTextureMode |= DepthTextureMode.Depth;
		}

		private float FocalDistance01(float worldDist)
		{
			return _camera.WorldToViewportPoint((worldDist - _camera.nearClipPlane) * _camera.transform.forward + _camera.transform.position).z / (_camera.farClipPlane - _camera.nearClipPlane);
		}

		private int GetDividerBasedOnQuality()
		{
			int result = 1;
			if (resolution == DofResolution.Medium)
			{
				result = 2;
			}
			else if (resolution == DofResolution.Low)
			{
				result = 2;
			}
			return result;
		}

		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			int num = baseDivider;
			if (resolution == DofResolution.High)
			{
				num *= 2;
			}
			if (resolution == DofResolution.Low)
			{
				num *= 2;
			}
			return num;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (smoothness < 0.1f)
			{
				smoothness = 0.1f;
			}
			bokeh = bokeh && bokehSupport;
			float num = ((!bokeh) ? 1f : BOKEH_EXTRA_BLUR);
			bool flag = quality > Dof34QualitySetting.OnlyBackground;
			float num2 = focalSize / (_camera.farClipPlane - _camera.nearClipPlane);
			if (simpleTweakMode)
			{
				focalDistance01 = ((!objectFocus) ? FocalDistance01(focalPoint) : (_camera.WorldToViewportPoint(objectFocus.position).z / _camera.farClipPlane));
				focalStartCurve = focalDistance01 * smoothness;
				focalEndCurve = focalStartCurve;
				flag = flag && focalPoint > _camera.nearClipPlane + Mathf.Epsilon;
			}
			else
			{
				if ((bool)objectFocus)
				{
					Vector3 vector = _camera.WorldToViewportPoint(objectFocus.position);
					vector.z /= _camera.farClipPlane;
					focalDistance01 = vector.z;
				}
				else
				{
					focalDistance01 = FocalDistance01(focalZDistance);
				}
				focalStartCurve = focalZStartCurve;
				focalEndCurve = focalZEndCurve;
				flag = flag && focalPoint > _camera.nearClipPlane + Mathf.Epsilon;
			}
			widthOverHeight = 1f * (float)source.width / (1f * (float)source.height);
			oneOverBaseSize = 0.001953125f;
			dofMaterial.SetFloat("_ForegroundBlurExtrude", foregroundBlurExtrude);
			dofMaterial.SetVector("_CurveParams", new Vector4((!simpleTweakMode) ? focalStartCurve : (1f / focalStartCurve), (!simpleTweakMode) ? focalEndCurve : (1f / focalEndCurve), num2 * 0.5f, focalDistance01));
			dofMaterial.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)source.width), 1f / (1f * (float)source.height), 0f, 0f));
			int dividerBasedOnQuality = GetDividerBasedOnQuality();
			int lowResolutionDividerBasedOnQuality = GetLowResolutionDividerBasedOnQuality(dividerBasedOnQuality);
			AllocateTextures(flag, source, dividerBasedOnQuality, lowResolutionDividerBasedOnQuality);
			Graphics.Blit(source, source, dofMaterial, 3);
			Downsample(source, mediumRezWorkTexture);
			Blur(mediumRezWorkTexture, mediumRezWorkTexture, DofBlurriness.Low, 4, maxBlurSpread);
			if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
			{
				dofMaterial.SetVector("_Threshhold", new Vector4(bokehThresholdContrast, bokehThresholdLuminance, 0.95f, 0f));
				Graphics.Blit(mediumRezWorkTexture, bokehSource2, dofMaterial, 11);
				Graphics.Blit(mediumRezWorkTexture, lowRezWorkTexture);
				Blur(lowRezWorkTexture, lowRezWorkTexture, bluriness, 0, maxBlurSpread * num);
			}
			else
			{
				Downsample(mediumRezWorkTexture, lowRezWorkTexture);
				Blur(lowRezWorkTexture, lowRezWorkTexture, bluriness, 0, maxBlurSpread);
			}
			dofBlurMaterial.SetTexture("_TapLow", lowRezWorkTexture);
			dofBlurMaterial.SetTexture("_TapMedium", mediumRezWorkTexture);
			Graphics.Blit(null, finalDefocus, dofBlurMaterial, 3);
			if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
			{
				AddBokeh(bokehSource2, bokehSource, finalDefocus);
			}
			dofMaterial.SetTexture("_TapLowBackground", finalDefocus);
			dofMaterial.SetTexture("_TapMedium", mediumRezWorkTexture);
			Graphics.Blit(source, (!flag) ? destination : foregroundTexture, dofMaterial, visualize ? 2 : 0);
			if (flag)
			{
				Graphics.Blit(foregroundTexture, source, dofMaterial, 5);
				Downsample(source, mediumRezWorkTexture);
				BlurFg(mediumRezWorkTexture, mediumRezWorkTexture, DofBlurriness.Low, 2, maxBlurSpread);
				if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
				{
					dofMaterial.SetVector("_Threshhold", new Vector4(bokehThresholdContrast * 0.5f, bokehThresholdLuminance, 0f, 0f));
					Graphics.Blit(mediumRezWorkTexture, bokehSource2, dofMaterial, 11);
					Graphics.Blit(mediumRezWorkTexture, lowRezWorkTexture);
					BlurFg(lowRezWorkTexture, lowRezWorkTexture, bluriness, 1, maxBlurSpread * num);
				}
				else
				{
					BlurFg(mediumRezWorkTexture, lowRezWorkTexture, bluriness, 1, maxBlurSpread);
				}
				Graphics.Blit(lowRezWorkTexture, finalDefocus);
				dofMaterial.SetTexture("_TapLowForeground", finalDefocus);
				Graphics.Blit(source, destination, dofMaterial, visualize ? 1 : 4);
				if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
				{
					AddBokeh(bokehSource2, bokehSource, destination);
				}
			}
			ReleaseTextures();
		}

		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(to.width, to.height);
			if (iterations > DofBlurriness.Low)
			{
				BlurHex(from, to, blurPass, spread, temporary);
				if (iterations > DofBlurriness.High)
				{
					dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
					Graphics.Blit(to, temporary, dofBlurMaterial, blurPass);
					dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
					Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
				}
			}
			else
			{
				dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
				Graphics.Blit(from, temporary, dofBlurMaterial, blurPass);
				dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
				Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
			dofBlurMaterial.SetTexture("_TapHigh", from);
			RenderTexture temporary = RenderTexture.GetTemporary(to.width, to.height);
			if (iterations > DofBlurriness.Low)
			{
				BlurHex(from, to, blurPass, spread, temporary);
				if (iterations > DofBlurriness.High)
				{
					dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
					Graphics.Blit(to, temporary, dofBlurMaterial, blurPass);
					dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
					Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
				}
			}
			else
			{
				dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
				Graphics.Blit(from, temporary, dofBlurMaterial, blurPass);
				dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
				Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
			dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(from, tmp, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
			Graphics.Blit(tmp, to, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, spread * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(to, tmp, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, (0f - spread) * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(tmp, to, dofBlurMaterial, blurPass);
		}

		private void Downsample(RenderTexture from, RenderTexture to)
		{
			dofMaterial.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)to.width), 1f / (1f * (float)to.height), 0f, 0f));
			Graphics.Blit(from, to, dofMaterial, SMOOTH_DOWNSAMPLE_PASS);
		}

		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
			if (!bokehMaterial)
			{
				return;
			}
			Mesh[] meshes = Quads.GetMeshes(tempTex.width, tempTex.height);
			RenderTexture.active = tempTex;
			GL.Clear(clearDepth: false, clearColor: true, new Color(0f, 0f, 0f, 0f));
			GL.PushMatrix();
			GL.LoadIdentity();
			bokehInfo.filterMode = FilterMode.Point;
			float num = (float)bokehInfo.width * 1f / ((float)bokehInfo.height * 1f);
			float num2 = 2f / (1f * (float)bokehInfo.width);
			num2 += bokehScale * maxBlurSpread * BOKEH_EXTRA_BLUR * oneOverBaseSize;
			bokehMaterial.SetTexture("_Source", bokehInfo);
			bokehMaterial.SetTexture("_MainTex", bokehTexture);
			bokehMaterial.SetVector("_ArScale", new Vector4(num2, num2 * num, 0.5f, 0.5f * num));
			bokehMaterial.SetFloat("_Intensity", bokehIntensity);
			bokehMaterial.SetPass(0);
			Mesh[] array = meshes;
			foreach (Mesh mesh in array)
			{
				if ((bool)mesh)
				{
					Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
				}
			}
			GL.PopMatrix();
			Graphics.Blit(tempTex, finalTarget, dofMaterial, 8);
			bokehInfo.filterMode = FilterMode.Bilinear;
		}

		private void ReleaseTextures()
		{
			if ((bool)foregroundTexture)
			{
				RenderTexture.ReleaseTemporary(foregroundTexture);
			}
			if ((bool)finalDefocus)
			{
				RenderTexture.ReleaseTemporary(finalDefocus);
			}
			if ((bool)mediumRezWorkTexture)
			{
				RenderTexture.ReleaseTemporary(mediumRezWorkTexture);
			}
			if ((bool)lowRezWorkTexture)
			{
				RenderTexture.ReleaseTemporary(lowRezWorkTexture);
			}
			if ((bool)bokehSource)
			{
				RenderTexture.ReleaseTemporary(bokehSource);
			}
			if ((bool)bokehSource2)
			{
				RenderTexture.ReleaseTemporary(bokehSource2);
			}
		}

		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
			foregroundTexture = null;
			if (blurForeground)
			{
				foregroundTexture = RenderTexture.GetTemporary(source.width, source.height, 0);
			}
			mediumRezWorkTexture = RenderTexture.GetTemporary(source.width / divider, source.height / divider, 0);
			finalDefocus = RenderTexture.GetTemporary(source.width / divider, source.height / divider, 0);
			lowRezWorkTexture = RenderTexture.GetTemporary(source.width / lowTexDivider, source.height / lowTexDivider, 0);
			bokehSource = null;
			bokehSource2 = null;
			if (bokeh)
			{
				bokehSource = RenderTexture.GetTemporary(source.width / (lowTexDivider * bokehDownsample), source.height / (lowTexDivider * bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
				bokehSource2 = RenderTexture.GetTemporary(source.width / (lowTexDivider * bokehDownsample), source.height / (lowTexDivider * bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
				bokehSource.filterMode = FilterMode.Bilinear;
				bokehSource2.filterMode = FilterMode.Bilinear;
				RenderTexture.active = bokehSource2;
				GL.Clear(clearDepth: false, clearColor: true, new Color(0f, 0f, 0f, 0f));
			}
			source.filterMode = FilterMode.Bilinear;
			finalDefocus.filterMode = FilterMode.Bilinear;
			mediumRezWorkTexture.filterMode = FilterMode.Bilinear;
			lowRezWorkTexture.filterMode = FilterMode.Bilinear;
			if ((bool)foregroundTexture)
			{
				foregroundTexture.filterMode = FilterMode.Bilinear;
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Edge Detection/Edge Detection")]
	public class EdgeDetection : PostEffectsBase
	{
		public enum EdgeDetectMode
		{
			TriangleDepthNormals,
			RobertsCrossDepthNormals,
			SobelDepth,
			SobelDepthThin,
			TriangleLuminance
		}

		public EdgeDetectMode mode = EdgeDetectMode.SobelDepthThin;

		public float sensitivityDepth = 1f;

		public float sensitivityNormals = 1f;

		public float lumThreshold = 0.2f;

		public float edgeExp = 1f;

		public float sampleDist = 1f;

		public float edgesOnly;

		public Color edgesOnlyBgColor = Color.white;

		public Shader edgeDetectShader;

		private Material edgeDetectMaterial;

		private EdgeDetectMode oldMode = EdgeDetectMode.SobelDepthThin;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			edgeDetectMaterial = CheckShaderAndCreateMaterial(edgeDetectShader, edgeDetectMaterial);
			if (mode != oldMode)
			{
				SetCameraFlag();
			}
			oldMode = mode;
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private new void Start()
		{
			oldMode = mode;
		}

		private void SetCameraFlag()
		{
			if (mode == EdgeDetectMode.SobelDepth || mode == EdgeDetectMode.SobelDepthThin)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			else if (mode == EdgeDetectMode.TriangleDepthNormals || mode == EdgeDetectMode.RobertsCrossDepthNormals)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
			}
		}

		private void OnEnable()
		{
			SetCameraFlag();
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			Vector2 vector = new Vector2(sensitivityDepth, sensitivityNormals);
			edgeDetectMaterial.SetVector("_Sensitivity", new Vector4(vector.x, vector.y, 1f, vector.y));
			edgeDetectMaterial.SetFloat("_BgFade", edgesOnly);
			edgeDetectMaterial.SetFloat("_SampleDistance", sampleDist);
			edgeDetectMaterial.SetVector("_BgColor", edgesOnlyBgColor);
			edgeDetectMaterial.SetFloat("_Exponent", edgeExp);
			edgeDetectMaterial.SetFloat("_Threshold", lumThreshold);
			Graphics.Blit(source, destination, edgeDetectMaterial, (int)mode);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Displacement/Fisheye")]
	internal class Fisheye : PostEffectsBase
	{
		public float strengthX = 0.05f;

		public float strengthY = 0.05f;

		public Shader fishEyeShader;

		private Material fisheyeMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			fisheyeMaterial = CheckShaderAndCreateMaterial(fishEyeShader, fisheyeMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			float num = 5f / 32f;
			float num2 = (float)source.width * 1f / ((float)source.height * 1f);
			fisheyeMaterial.SetVector("intensity", new Vector4(strengthX * num2 * num, strengthY * num, strengthX * num2 * num, strengthY * num));
			Graphics.Blit(source, destination, fisheyeMaterial);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Global Fog")]
	internal class GlobalFog : PostEffectsBase
	{
		[Tooltip("Apply distance-based fog?")]
		public bool distanceFog = true;

		[Tooltip("Distance fog is based on radial distance from camera when checked")]
		public bool useRadialDistance;

		[Tooltip("Apply height-based fog?")]
		public bool heightFog = true;

		[Tooltip("Fog top Y coordinate")]
		public float height = 1f;

		[Range(0.001f, 10f)]
		public float heightDensity = 2f;

		[Tooltip("Push fog away from the camera by this amount")]
		public float startDistance;

		public Shader fogShader;

		private Material fogMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			fogMaterial = CheckShaderAndCreateMaterial(fogShader, fogMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources() || (!distanceFog && !heightFog))
			{
				Graphics.Blit(source, destination);
				return;
			}
			Camera component = GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 0.5f;
			Vector3 vector = transform.right * nearClipPlane * Mathf.Tan(num * ((float)Math.PI / 180f)) * aspect;
			Vector3 vector2 = transform.up * nearClipPlane * Mathf.Tan(num * ((float)Math.PI / 180f));
			Vector3 vector3 = transform.forward * nearClipPlane - vector + vector2;
			float num2 = vector3.magnitude * farClipPlane / nearClipPlane;
			vector3.Normalize();
			vector3 *= num2;
			Vector3 vector4 = transform.forward * nearClipPlane + vector + vector2;
			vector4.Normalize();
			vector4 *= num2;
			Vector3 vector5 = transform.forward * nearClipPlane + vector - vector2;
			vector5.Normalize();
			vector5 *= num2;
			Vector3 vector6 = transform.forward * nearClipPlane - vector - vector2;
			vector6.Normalize();
			vector6 *= num2;
			identity.SetRow(0, vector3);
			identity.SetRow(1, vector4);
			identity.SetRow(2, vector5);
			identity.SetRow(3, vector6);
			Vector3 position = transform.position;
			float num3 = position.y - height;
			float z = ((!(num3 <= 0f)) ? 0f : 1f);
			fogMaterial.SetMatrix("_FrustumCornersWS", identity);
			fogMaterial.SetVector("_CameraWS", position);
			fogMaterial.SetVector("_HeightParams", new Vector4(height, num3, z, heightDensity * 0.5f));
			fogMaterial.SetVector("_DistanceParams", new Vector4(0f - Mathf.Max(startDistance, 0f), 0f, 0f, 0f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num4 = ((!flag) ? 0f : (fogEndDistance - fogStartDistance));
			float num5 = ((!(Mathf.Abs(num4) > 0.0001f)) ? 0f : (1f / num4));
			Vector4 value = default(Vector4);
			value.x = fogDensity * 1.2011224f;
			value.y = fogDensity * 1.442695f;
			value.z = ((!flag) ? 0f : (0f - num5));
			value.w = ((!flag) ? 0f : (fogEndDistance * num5));
			fogMaterial.SetVector("_SceneFogParams", value);
			fogMaterial.SetVector("_SceneFogMode", new Vector4((float)fogMode, useRadialDistance ? 1 : 0, 0f, 0f));
			int num6 = 0;
			CustomGraphicsBlit(passNr: (!distanceFog || !heightFog) ? (distanceFog ? 1 : 2) : 0, source: source, dest: destination, fxMaterial: fogMaterial);
		}

		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
			RenderTexture.active = dest;
			fxMaterial.SetTexture("_MainTex", source);
			GL.PushMatrix();
			GL.LoadOrtho();
			fxMaterial.SetPass(passNr);
			GL.Begin(7);
			GL.MultiTexCoord2(0, 0f, 0f);
			GL.Vertex3(0f, 0f, 3f);
			GL.MultiTexCoord2(0, 1f, 0f);
			GL.Vertex3(1f, 0f, 2f);
			GL.MultiTexCoord2(0, 1f, 1f);
			GL.Vertex3(1f, 1f, 1f);
			GL.MultiTexCoord2(0, 0f, 1f);
			GL.Vertex3(0f, 1f, 0f);
			GL.End();
			GL.PopMatrix();
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Grayscale")]
	public class Grayscale : ImageEffectBase
	{
		public Texture textureRamp;

		public float rampOffset;

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			base.material.SetTexture("_RampTex", textureRamp);
			base.material.SetFloat("_RampOffset", rampOffset);
			Graphics.Blit(source, destination, base.material);
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("")]
	public class ImageEffectBase : MonoBehaviour
	{
		public Shader shader;

		private Material m_Material;

		protected Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = new Material(shader);
					m_Material.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_Material;
			}
		}

		protected virtual void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
			}
			else if (!shader || !shader.isSupported)
			{
				base.enabled = false;
			}
		}

		protected virtual void OnDisable()
		{
			if ((bool)m_Material)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
		}
	}
	[AddComponentMenu("")]
	public class ImageEffects
	{
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
			if (source.texelSize.y < 0f)
			{
				center.y = 1f - center.y;
				angle = 0f - angle;
			}
			Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(0f, 0f, angle), Vector3.one);
			material.SetMatrix("_RotationMatrix", value);
			material.SetVector("_CenterRadius", new Vector4(center.x, center.y, radius.x, radius.y));
			material.SetFloat("_Angle", angle * ((float)Math.PI / 180f));
			Graphics.Blit(source, destination, material);
		}

		[Obsolete("Use Graphics.Blit(source,dest) instead")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
			Graphics.Blit(source, dest);
		}

		[Obsolete("Use Graphics.Blit(source, destination, material) instead")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
			Graphics.Blit(source, dest, material);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Blur/Motion Blur (Color Accumulation)")]
	[RequireComponent(typeof(Camera))]
	public class MotionBlur : ImageEffectBase
	{
		public float blurAmount = 0.8f;

		public bool extraBlur;

		private RenderTexture accumTexture;

		protected override void Start()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
			}
			else
			{
				base.Start();
			}
		}

		protected override void OnDisable()
		{
			base.OnDisable();
			UnityEngine.Object.DestroyImmediate(accumTexture);
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (accumTexture == null || accumTexture.width != source.width || accumTexture.height != source.height)
			{
				UnityEngine.Object.DestroyImmediate(accumTexture);
				accumTexture = new RenderTexture(source.width, source.height, 0);
				accumTexture.hideFlags = HideFlags.HideAndDontSave;
				Graphics.Blit(source, accumTexture);
			}
			if (extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0);
				accumTexture.MarkRestoreExpected();
				Graphics.Blit(accumTexture, temporary);
				Graphics.Blit(temporary, accumTexture);
				RenderTexture.ReleaseTemporary(temporary);
			}
			blurAmount = Mathf.Clamp(blurAmount, 0f, 0.92f);
			base.material.SetTexture("_MainTex", accumTexture);
			base.material.SetFloat("_AccumOrig", 1f - blurAmount);
			accumTexture.MarkRestoreExpected();
			Graphics.Blit(source, accumTexture, base.material);
			Graphics.Blit(accumTexture, destination);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Noise/Noise And Grain (Filmic)")]
	public class NoiseAndGrain : PostEffectsBase
	{
		public float intensityMultiplier = 0.25f;

		public float generalIntensity = 0.5f;

		public float blackIntensity = 1f;

		public float whiteIntensity = 1f;

		public float midGrey = 0.2f;

		public bool dx11Grain;

		public float softness;

		public bool monochrome;

		public Vector3 intensities = new Vector3(1f, 1f, 1f);

		public Vector3 tiling = new Vector3(64f, 64f, 64f);

		public float monochromeTiling = 64f;

		public FilterMode filterMode = FilterMode.Bilinear;

		public Texture2D noiseTexture;

		public Shader noiseShader;

		private Material noiseMaterial;

		public Shader dx11NoiseShader;

		private Material dx11NoiseMaterial;

		private static float TILE_AMOUNT = 64f;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			noiseMaterial = CheckShaderAndCreateMaterial(noiseShader, noiseMaterial);
			if (dx11Grain && supportDX11)
			{
				dx11NoiseMaterial = CheckShaderAndCreateMaterial(dx11NoiseShader, dx11NoiseMaterial);
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources() || null == noiseTexture)
			{
				Graphics.Blit(source, destination);
				if (null == noiseTexture)
				{
					Debug.LogWarning("Noise & Grain effect failing as noise texture is not assigned. please assign.", base.transform);
				}
				return;
			}
			softness = Mathf.Clamp(softness, 0f, 0.99f);
			if (dx11Grain && supportDX11)
			{
				dx11NoiseMaterial.SetFloat("_DX11NoiseTime", Time.frameCount);
				dx11NoiseMaterial.SetTexture("_NoiseTex", noiseTexture);
				dx11NoiseMaterial.SetVector("_NoisePerChannel", (!monochrome) ? intensities : Vector3.one);
				dx11NoiseMaterial.SetVector("_MidGrey", new Vector3(midGrey, 1f / (1f - midGrey), -1f / midGrey));
				dx11NoiseMaterial.SetVector("_NoiseAmount", new Vector3(generalIntensity, blackIntensity, whiteIntensity) * intensityMultiplier);
				if (softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)source.width * (1f - softness)), (int)((float)source.height * (1f - softness)));
					DrawNoiseQuadGrid(source, temporary, dx11NoiseMaterial, noiseTexture, (!monochrome) ? 2 : 3);
					dx11NoiseMaterial.SetTexture("_NoiseTex", temporary);
					Graphics.Blit(source, destination, dx11NoiseMaterial, 4);
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					DrawNoiseQuadGrid(source, destination, dx11NoiseMaterial, noiseTexture, monochrome ? 1 : 0);
				}
				return;
			}
			if ((bool)noiseTexture)
			{
				noiseTexture.wrapMode = TextureWrapMode.Repeat;
				noiseTexture.filterMode = filterMode;
			}
			noiseMaterial.SetTexture("_NoiseTex", noiseTexture);
			noiseMaterial.SetVector("_NoisePerChannel", (!monochrome) ? intensities : Vector3.one);
			noiseMaterial.SetVector("_NoiseTilingPerChannel", (!monochrome) ? tiling : (Vector3.one * monochromeTiling));
			noiseMaterial.SetVector("_MidGrey", new Vector3(midGrey, 1f / (1f - midGrey), -1f / midGrey));
			noiseMaterial.SetVector("_NoiseAmount", new Vector3(generalIntensity, blackIntensity, whiteIntensity) * intensityMultiplier);
			if (softness > Mathf.Epsilon)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)source.width * (1f - softness)), (int)((float)source.height * (1f - softness)));
				DrawNoiseQuadGrid(source, temporary2, noiseMaterial, noiseTexture, 2);
				noiseMaterial.SetTexture("_NoiseTex", temporary2);
				Graphics.Blit(source, destination, noiseMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				DrawNoiseQuadGrid(source, destination, noiseMaterial, noiseTexture, 0);
			}
		}

		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
			RenderTexture.active = dest;
			float num = (float)noise.width * 1f;
			float num2 = 1f * (float)source.width / TILE_AMOUNT;
			fxMaterial.SetTexture("_MainTex", source);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 1f * (float)source.width / (1f * (float)source.height);
			float num4 = 1f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)noise.width * 1f);
			fxMaterial.SetPass(passNr);
			GL.Begin(7);
			for (float num7 = 0f; num7 < 1f; num7 += num4)
			{
				for (float num8 = 0f; num8 < 1f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(0f, 1f);
					float num10 = UnityEngine.Random.Range(0f, 1f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 1f / num;
					GL.MultiTexCoord2(0, num9, num10);
					GL.MultiTexCoord2(1, 0f, 0f);
					GL.Vertex3(num7, num8, 0.1f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(1, 1f, 0f);
					GL.Vertex3(num7 + num4, num8, 0.1f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 1f, 1f);
					GL.Vertex3(num7 + num4, num8 + num5, 0.1f);
					GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 0f, 1f);
					GL.Vertex3(num7, num8 + num5, 0.1f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Noise/Noise and Scratches")]
	public class NoiseAndScratches : MonoBehaviour
	{
		public bool monochrome = true;

		private bool rgbFallback;

		public float grainIntensityMin = 0.1f;

		public float grainIntensityMax = 0.2f;

		public float grainSize = 2f;

		public float scratchIntensityMin = 0.05f;

		public float scratchIntensityMax = 0.25f;

		public float scratchFPS = 10f;

		public float scratchJitter = 0.01f;

		public Texture grainTexture;

		public Texture scratchTexture;

		public Shader shaderRGB;

		public Shader shaderYUV;

		private Material m_MaterialRGB;

		private Material m_MaterialYUV;

		private float scratchTimeLeft;

		private float scratchX;

		private float scratchY;

		protected Material material
		{
			get
			{
				if (m_MaterialRGB == null)
				{
					m_MaterialRGB = new Material(shaderRGB);
					m_MaterialRGB.hideFlags = HideFlags.HideAndDontSave;
				}
				if (m_MaterialYUV == null && !rgbFallback)
				{
					m_MaterialYUV = new Material(shaderYUV);
					m_MaterialYUV.hideFlags = HideFlags.HideAndDontSave;
				}
				return (rgbFallback || monochrome) ? m_MaterialRGB : m_MaterialYUV;
			}
		}

		protected void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
			}
			else if (shaderRGB == null || shaderYUV == null)
			{
				Debug.Log("Noise shaders are not set up! Disabling noise effect.");
				base.enabled = false;
			}
			else if (!shaderRGB.isSupported)
			{
				base.enabled = false;
			}
			else if (!shaderYUV.isSupported)
			{
				rgbFallback = true;
			}
		}

		protected void OnDisable()
		{
			if ((bool)m_MaterialRGB)
			{
				UnityEngine.Object.DestroyImmediate(m_MaterialRGB);
			}
			if ((bool)m_MaterialYUV)
			{
				UnityEngine.Object.DestroyImmediate(m_MaterialYUV);
			}
		}

		private void SanitizeParameters()
		{
			grainIntensityMin = Mathf.Clamp(grainIntensityMin, 0f, 5f);
			grainIntensityMax = Mathf.Clamp(grainIntensityMax, 0f, 5f);
			scratchIntensityMin = Mathf.Clamp(scratchIntensityMin, 0f, 5f);
			scratchIntensityMax = Mathf.Clamp(scratchIntensityMax, 0f, 5f);
			scratchFPS = Mathf.Clamp(scratchFPS, 1f, 30f);
			scratchJitter = Mathf.Clamp(scratchJitter, 0f, 1f);
			grainSize = Mathf.Clamp(grainSize, 0.1f, 50f);
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			SanitizeParameters();
			if (scratchTimeLeft <= 0f)
			{
				scratchTimeLeft = UnityEngine.Random.value * 2f / scratchFPS;
				scratchX = UnityEngine.Random.value;
				scratchY = UnityEngine.Random.value;
			}
			scratchTimeLeft -= Time.deltaTime;
			Material material = this.material;
			material.SetTexture("_GrainTex", grainTexture);
			material.SetTexture("_ScratchTex", scratchTexture);
			float num = 1f / grainSize;
			material.SetVector("_GrainOffsetScale", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)grainTexture.width * num, (float)Screen.height / (float)grainTexture.height * num));
			material.SetVector("_ScratchOffsetScale", new Vector4(scratchX + UnityEngine.Random.value * scratchJitter, scratchY + UnityEngine.Random.value * scratchJitter, (float)Screen.width / (float)scratchTexture.width, (float)Screen.height / (float)scratchTexture.height));
			material.SetVector("_Intensity", new Vector4(UnityEngine.Random.Range(grainIntensityMin, grainIntensityMax), UnityEngine.Random.Range(scratchIntensityMin, scratchIntensityMax), 0f, 0f));
			Graphics.Blit(source, destination, material);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class PostEffectsBase : MonoBehaviour
	{
		protected bool supportHDRTextures = true;

		protected bool supportDX11;

		protected bool isSupported = true;

		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			if (!s)
			{
				Debug.Log("Missing shader in " + ToString());
				base.enabled = false;
				return null;
			}
			if (s.isSupported && (bool)m2Create && m2Create.shader == s)
			{
				return m2Create;
			}
			if (!s.isSupported)
			{
				NotSupported();
				Debug.Log("The shader " + s.ToString() + " on effect " + ToString() + " is not supported on this platform!");
				return null;
			}
			m2Create = new Material(s);
			m2Create.hideFlags = HideFlags.DontSave;
			if ((bool)m2Create)
			{
				return m2Create;
			}
			return null;
		}

		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			if (!s)
			{
				Debug.Log("Missing shader in " + ToString());
				return null;
			}
			if ((bool)m2Create && m2Create.shader == s && s.isSupported)
			{
				return m2Create;
			}
			if (!s.isSupported)
			{
				return null;
			}
			m2Create = new Material(s);
			m2Create.hideFlags = HideFlags.DontSave;
			if ((bool)m2Create)
			{
				return m2Create;
			}
			return null;
		}

		private void OnEnable()
		{
			isSupported = true;
		}

		protected bool CheckSupport()
		{
			return CheckSupport(needDepth: false);
		}

		public virtual bool CheckResources()
		{
			Debug.LogWarning("CheckResources () for " + ToString() + " should be overwritten.");
			return isSupported;
		}

		protected void Start()
		{
			CheckResources();
		}

		protected bool CheckSupport(bool needDepth)
		{
			isSupported = true;
			supportHDRTextures = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf);
			supportDX11 = SystemInfo.graphicsShaderLevel >= 50 && SystemInfo.supportsComputeShaders;
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				NotSupported();
				return false;
			}
			if (needDepth && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				NotSupported();
				return false;
			}
			if (needDepth)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return true;
		}

		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			if (!CheckSupport(needDepth))
			{
				return false;
			}
			if (needHdr && !supportHDRTextures)
			{
				NotSupported();
				return false;
			}
			return true;
		}

		public bool Dx11Support()
		{
			return supportDX11;
		}

		protected void ReportAutoDisable()
		{
			Debug.LogWarning("The image effect " + ToString() + " has been disabled as it's not supported on the current platform.");
		}

		private bool CheckShader(Shader s)
		{
			Debug.Log("The shader " + s.ToString() + " on effect " + ToString() + " is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.");
			if (!s.isSupported)
			{
				NotSupported();
				return false;
			}
			return false;
		}

		protected void NotSupported()
		{
			base.enabled = false;
			isSupported = false;
		}

		protected void DrawBorder(RenderTexture dest, Material material)
		{
			RenderTexture.active = dest;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				float x = 0f;
				float x2 = 1f / ((float)dest.width * 1f);
				float y3 = 0f;
				float y4 = 1f;
				GL.Begin(7);
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 1f - 1f / ((float)dest.width * 1f);
				x2 = 1f;
				y3 = 0f;
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 0f;
				x2 = 1f;
				y3 = 0f;
				y4 = 1f / ((float)dest.height * 1f);
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 0f;
				x2 = 1f;
				y3 = 1f - 1f / ((float)dest.height * 1f);
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	internal class PostEffectsHelper : MonoBehaviour
	{
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			Debug.Log("OnRenderImage in Helper called ...");
		}

		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
			RenderTexture.active = dest;
			material.SetTexture("_MainTex", source);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(cameraForProjectionMatrix.projectionMatrix);
			float f = cameraForProjectionMatrix.fieldOfView * 0.5f * ((float)Math.PI / 180f);
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = cameraForProjectionMatrix.aspect;
			float num2 = aspect / (0f - num);
			float num3 = aspect / num;
			float num4 = 1f / (0f - num);
			float num5 = 1f / num;
			float num6 = 1f;
			num2 *= dist * num6;
			num3 *= dist * num6;
			num4 *= dist * num6;
			num5 *= dist * num6;
			float z = 0f - dist;
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				GL.Begin(7);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				GL.TexCoord2(0f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		private static void DrawBorder(RenderTexture dest, Material material)
		{
			RenderTexture.active = dest;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				float x = 0f;
				float x2 = 1f / ((float)dest.width * 1f);
				float y3 = 0f;
				float y4 = 1f;
				GL.Begin(7);
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 1f - 1f / ((float)dest.width * 1f);
				x2 = 1f;
				y3 = 0f;
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 0f;
				x2 = 1f;
				y3 = 0f;
				y4 = 1f / ((float)dest.height * 1f);
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 0f;
				x2 = 1f;
				y3 = 1f - 1f / ((float)dest.height * 1f);
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}

		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
			RenderTexture.active = dest;
			material.SetTexture("_MainTex", source);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				GL.Begin(7);
				float y3;
				float y4;
				if (flag)
				{
					y3 = 1f;
					y4 = 0f;
				}
				else
				{
					y3 = 0f;
					y4 = 1f;
				}
				GL.TexCoord2(0f, y3);
				GL.Vertex3(x1, y1, 0.1f);
				GL.TexCoord2(1f, y3);
				GL.Vertex3(x2, y1, 0.1f);
				GL.TexCoord2(1f, y4);
				GL.Vertex3(x2, y2, 0.1f);
				GL.TexCoord2(0f, y4);
				GL.Vertex3(x1, y2, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}
	}
	internal class Quads
	{
		private static Mesh[] meshes;

		private static int currentQuads;

		private static bool HasMeshes()
		{
			if (meshes == null)
			{
				return false;
			}
			Mesh[] array = meshes;
			foreach (Mesh mesh in array)
			{
				if (null == mesh)
				{
					return false;
				}
			}
			return true;
		}

		public static void Cleanup()
		{
			if (meshes == null)
			{
				return;
			}
			for (int i = 0; i < meshes.Length; i++)
			{
				if (null != meshes[i])
				{
					UnityEngine.Object.DestroyImmediate(meshes[i]);
					meshes[i] = null;
				}
			}
			meshes = null;
		}

		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			if (HasMeshes() && currentQuads == totalWidth * totalHeight)
			{
				return meshes;
			}
			int num = 10833;
			int num2 = (currentQuads = totalWidth * totalHeight);
			int num3 = Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num));
			meshes = new Mesh[num3];
			int num4 = 0;
			int num5 = 0;
			for (num4 = 0; num4 < num2; num4 += num)
			{
				int triCount = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
				meshes[num5] = GetMesh(triCount, num4, totalWidth, totalHeight);
				num5++;
			}
			return meshes;
		}

		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			Mesh mesh = new Mesh();
			mesh.hideFlags = HideFlags.DontSave;
			Vector3[] array = new Vector3[triCount * 4];
			Vector2[] array2 = new Vector2[triCount * 4];
			Vector2[] array3 = new Vector2[triCount * 4];
			int[] array4 = new int[triCount * 6];
			for (int i = 0; i < triCount; i++)
			{
				int num = i * 4;
				int num2 = i * 6;
				int num3 = triOffset + i;
				float num4 = Mathf.Floor(num3 % totalWidth) / (float)totalWidth;
				float num5 = Mathf.Floor(num3 / totalWidth) / (float)totalHeight;
				Vector3 vector = new Vector3(num4 * 2f - 1f, num5 * 2f - 1f, 1f);
				array[num] = vector;
				array[num + 1] = vector;
				array[num + 2] = vector;
				array[num + 3] = vector;
				ref Vector2 reference = ref array2[num];
				reference = new Vector2(0f, 0f);
				ref Vector2 reference2 = ref array2[num + 1];
				reference2 = new Vector2(1f, 0f);
				ref Vector2 reference3 = ref array2[num + 2];
				reference3 = new Vector2(0f, 1f);
				ref Vector2 reference4 = ref array2[num + 3];
				reference4 = new Vector2(1f, 1f);
				ref Vector2 reference5 = ref array3[num];
				reference5 = new Vector2(num4, num5);
				ref Vector2 reference6 = ref array3[num + 1];
				reference6 = new Vector2(num4, num5);
				ref Vector2 reference7 = ref array3[num + 2];
				reference7 = new Vector2(num4, num5);
				ref Vector2 reference8 = ref array3[num + 3];
				reference8 = new Vector2(num4, num5);
				array4[num2] = num;
				array4[num2 + 1] = num + 1;
				array4[num2 + 2] = num + 2;
				array4[num2 + 3] = num + 1;
				array4[num2 + 4] = num + 2;
				array4[num2 + 5] = num + 3;
			}
			mesh.vertices = array;
			mesh.triangles = array4;
			mesh.uv = array2;
			mesh.uv2 = array3;
			return mesh;
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Other/Screen Overlay")]
	public class ScreenOverlay : PostEffectsBase
	{
		public enum OverlayBlendMode
		{
			Additive,
			ScreenBlend,
			Multiply,
			Overlay,
			AlphaBlend
		}

		public OverlayBlendMode blendMode = OverlayBlendMode.Overlay;

		public float intensity = 1f;

		public Texture2D texture;

		public Shader overlayShader;

		private Material overlayMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			overlayMaterial = CheckShaderAndCreateMaterial(overlayShader, overlayMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			Vector4 value = new Vector4(1f, 0f, 0f, 1f);
			overlayMaterial.SetVector("_UV_Transform", value);
			overlayMaterial.SetFloat("_Intensity", intensity);
			overlayMaterial.SetTexture("_Overlay", texture);
			Graphics.Blit(source, destination, overlayMaterial, (int)blendMode);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Obscurance")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Range(0f, 3f)]
		public float intensity = 0.5f;

		[Range(0.1f, 3f)]
		public float radius = 0.2f;

		[Range(0f, 3f)]
		public int blurIterations = 1;

		[Range(0f, 5f)]
		public float blurFilterDistance = 1.25f;

		[Range(0f, 1f)]
		public int downsample;

		public Texture2D rand;

		public Shader aoShader;

		private Material aoMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			aoMaterial = CheckShaderAndCreateMaterial(aoShader, aoMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			if ((bool)aoMaterial)
			{
				UnityEngine.Object.DestroyImmediate(aoMaterial);
			}
			aoMaterial = null;
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			Matrix4x4 projectionMatrix = GetComponent<Camera>().projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(-2f / ((float)Screen.width * projectionMatrix[0]), -2f / ((float)Screen.height * projectionMatrix[5]), (1f - projectionMatrix[2]) / projectionMatrix[0], (1f + projectionMatrix[6]) / projectionMatrix[5]);
			aoMaterial.SetVector("_ProjInfo", value);
			aoMaterial.SetMatrix("_ProjectionInv", inverse);
			aoMaterial.SetTexture("_Rand", rand);
			aoMaterial.SetFloat("_Radius", radius);
			aoMaterial.SetFloat("_Radius2", radius * radius);
			aoMaterial.SetFloat("_Intensity", intensity);
			aoMaterial.SetFloat("_BlurFilterDistance", blurFilterDistance);
			int width = source.width;
			int height = source.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> downsample, height >> downsample);
			Graphics.Blit(source, renderTexture, aoMaterial, 0);
			if (downsample > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, aoMaterial, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 0; i < blurIterations; i++)
			{
				aoMaterial.SetVector("_Axis", new Vector2(1f, 0f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, aoMaterial, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				aoMaterial.SetVector("_Axis", new Vector2(0f, 1f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, aoMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary);
			}
			aoMaterial.SetTexture("_AOTex", renderTexture);
			Graphics.Blit(source, destination, aoMaterial, 2);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Occlusion")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		public enum SSAOSamples
		{
			Low,
			Medium,
			High
		}

		public float m_Radius = 0.4f;

		public SSAOSamples m_SampleCount = SSAOSamples.Medium;

		public float m_OcclusionIntensity = 1.5f;

		public int m_Blur = 2;

		public int m_Downsampling = 2;

		public float m_OcclusionAttenuation = 1f;

		public float m_MinZ = 0.01f;

		public Shader m_SSAOShader;

		private Material m_SSAOMaterial;

		public Texture2D m_RandomTexture;

		private bool m_Supported;

		private static Material CreateMaterial(Shader shader)
		{
			if (!shader)
			{
				return null;
			}
			Material material = new Material(shader);
			material.hideFlags = HideFlags.HideAndDontSave;
			return material;
		}

		private static void DestroyMaterial(Material mat)
		{
			if ((bool)mat)
			{
				UnityEngine.Object.DestroyImmediate(mat);
				mat = null;
			}
		}

		private void OnDisable()
		{
			DestroyMaterial(m_SSAOMaterial);
		}

		private void Start()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				m_Supported = false;
				base.enabled = false;
				return;
			}
			CreateMaterials();
			if (!m_SSAOMaterial || m_SSAOMaterial.passCount != 5)
			{
				m_Supported = false;
				base.enabled = false;
			}
			else
			{
				m_Supported = true;
			}
		}

		private void OnEnable()
		{
			GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
		}

		private void CreateMaterials()
		{
			if (!m_SSAOMaterial && m_SSAOShader.isSupported)
			{
				m_SSAOMaterial = CreateMaterial(m_SSAOShader);
				m_SSAOMaterial.SetTexture("_RandomTexture", m_RandomTexture);
			}
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!m_Supported || !m_SSAOShader.isSupported)
			{
				base.enabled = false;
				return;
			}
			CreateMaterials();
			m_Downsampling = Mathf.Clamp(m_Downsampling, 1, 6);
			m_Radius = Mathf.Clamp(m_Radius, 0.05f, 1f);
			m_MinZ = Mathf.Clamp(m_MinZ, 1E-05f, 0.5f);
			m_OcclusionIntensity = Mathf.Clamp(m_OcclusionIntensity, 0.5f, 4f);
			m_OcclusionAttenuation = Mathf.Clamp(m_OcclusionAttenuation, 0.2f, 2f);
			m_Blur = Mathf.Clamp(m_Blur, 0, 4);
			RenderTexture renderTexture = RenderTexture.GetTemporary(source.width / m_Downsampling, source.height / m_Downsampling, 0);
			float fieldOfView = GetComponent<Camera>().fieldOfView;
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * ((float)Math.PI / 180f) * 0.5f) * farClipPlane;
			float x = num * GetComponent<Camera>().aspect;
			m_SSAOMaterial.SetVector("_FarCorner", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if ((bool)m_RandomTexture)
			{
				num2 = m_RandomTexture.width;
				num3 = m_RandomTexture.height;
			}
			else
			{
				num2 = 1;
				num3 = 1;
			}
			m_SSAOMaterial.SetVector("_NoiseScale", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 0f));
			m_SSAOMaterial.SetVector("_Params", new Vector4(m_Radius, m_MinZ, 1f / m_OcclusionAttenuation, m_OcclusionIntensity));
			bool flag = m_Blur > 0;
			Graphics.Blit((!flag) ? source : null, renderTexture, m_SSAOMaterial, (int)m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height, 0);
				m_SSAOMaterial.SetVector("_TexelOffsetScale", new Vector4((float)m_Blur / (float)source.width, 0f, 0f, 0f));
				m_SSAOMaterial.SetTexture("_SSAO", renderTexture);
				Graphics.Blit(null, temporary, m_SSAOMaterial, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(source.width, source.height, 0);
				m_SSAOMaterial.SetVector("_TexelOffsetScale", new Vector4(0f, (float)m_Blur / (float)source.height, 0f, 0f));
				m_SSAOMaterial.SetTexture("_SSAO", temporary);
				Graphics.Blit(source, temporary2, m_SSAOMaterial, 3);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			m_SSAOMaterial.SetTexture("_SSAO", renderTexture);
			Graphics.Blit(source, destination, m_SSAOMaterial, 4);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Sepia Tone")]
	public class SepiaTone : ImageEffectBase
	{
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			Graphics.Blit(source, destination, base.material);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Sun Shafts")]
	public class SunShafts : PostEffectsBase
	{
		public enum SunShaftsResolution
		{
			Low,
			Normal,
			High
		}

		public enum ShaftsScreenBlendMode
		{
			Screen,
			Add
		}

		public SunShaftsResolution resolution = SunShaftsResolution.Normal;

		public ShaftsScreenBlendMode screenBlendMode;

		public Transform sunTransform;

		public int radialBlurIterations = 2;

		public Color sunColor = Color.white;

		public Color sunThreshold = new Color(0.87f, 0.74f, 0.65f);

		public float sunShaftBlurRadius = 2.5f;

		public float sunShaftIntensity = 1.15f;

		public float maxRadius = 0.75f;

		public bool useDepthTexture = true;

		public Shader sunShaftsShader;

		private Material sunShaftsMaterial;

		public Shader simpleClearShader;

		private Material simpleClearMaterial;

		public override bool CheckResources()
		{
			CheckSupport(useDepthTexture);
			sunShaftsMaterial = CheckShaderAndCreateMaterial(sunShaftsShader, sunShaftsMaterial);
			simpleClearMaterial = CheckShaderAndCreateMaterial(simpleClearShader, simpleClearMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (useDepthTexture)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 4;
			if (resolution == SunShaftsResolution.Normal)
			{
				num = 2;
			}
			else if (resolution == SunShaftsResolution.High)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 0.5f;
			vector = ((!sunTransform) ? new Vector3(0.5f, 0.5f, 0f) : GetComponent<Camera>().WorldToViewportPoint(sunTransform.position));
			int width = source.width / num;
			int height = source.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(1f, 1f, 0f, 0f) * sunShaftBlurRadius);
			sunShaftsMaterial.SetVector("_SunPosition", new Vector4(vector.x, vector.y, vector.z, maxRadius));
			sunShaftsMaterial.SetVector("_SunThreshold", sunThreshold);
			if (!useDepthTexture)
			{
				RenderTextureFormat format = ((!GetComponent<Camera>().hdr) ? RenderTextureFormat.Default : RenderTextureFormat.DefaultHDR);
				RenderTexture renderTexture = (RenderTexture.active = RenderTexture.GetTemporary(source.width, source.height, 0, format));
				GL.ClearWithSkybox(clearDepth: false, GetComponent<Camera>());
				sunShaftsMaterial.SetTexture("_Skybox", renderTexture);
				Graphics.Blit(source, temporary, sunShaftsMaterial, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
			else
			{
				Graphics.Blit(source, temporary, sunShaftsMaterial, 2);
			}
			DrawBorder(temporary, simpleClearMaterial);
			radialBlurIterations = Mathf.Clamp(radialBlurIterations, 1, 4);
			float num2 = sunShaftBlurRadius * 0.0013020834f;
			sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
			sunShaftsMaterial.SetVector("_SunPosition", new Vector4(vector.x, vector.y, vector.z, maxRadius));
			for (int i = 0; i < radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, sunShaftsMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = sunShaftBlurRadius * (((float)i * 2f + 1f) * 6f) / 768f;
				sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, sunShaftsMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = sunShaftBlurRadius * (((float)i * 2f + 2f) * 6f) / 768f;
				sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
			}
			if (vector.z >= 0f)
			{
				sunShaftsMaterial.SetVector("_SunColor", new Vector4(sunColor.r, sunColor.g, sunColor.b, sunColor.a) * sunShaftIntensity);
			}
			else
			{
				sunShaftsMaterial.SetVector("_SunColor", Vector4.zero);
			}
			sunShaftsMaterial.SetTexture("_ColorBuffer", temporary);
			Graphics.Blit(source, destination, sunShaftsMaterial, (screenBlendMode != 0) ? 4 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Tilt Shift (Lens Blur)")]
	internal class TiltShift : PostEffectsBase
	{
		public enum TiltShiftMode
		{
			TiltShiftMode,
			IrisMode
		}

		public enum TiltShiftQuality
		{
			Preview,
			Normal,
			High
		}

		public TiltShiftMode mode;

		public TiltShiftQuality quality = TiltShiftQuality.Normal;

		[Range(0f, 15f)]
		public float blurArea = 1f;

		[Range(0f, 25f)]
		public float maxBlurSize = 5f;

		[Range(0f, 1f)]
		public int downsample;

		public Shader tiltShiftShader;

		private Material tiltShiftMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			tiltShiftMaterial = CheckShaderAndCreateMaterial(tiltShiftShader, tiltShiftMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			tiltShiftMaterial.SetFloat("_BlurSize", (!(maxBlurSize < 0f)) ? maxBlurSize : 0f);
			tiltShiftMaterial.SetFloat("_BlurArea", blurArea);
			source.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = destination;
			if ((float)downsample > 0f)
			{
				renderTexture = RenderTexture.GetTemporary(source.width >> downsample, source.height >> downsample, 0, source.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)quality;
			num *= 2;
			Graphics.Blit(source, renderTexture, tiltShiftMaterial, (mode != 0) ? (num + 1) : num);
			if (downsample > 0)
			{
				tiltShiftMaterial.SetTexture("_Blurred", renderTexture);
				Graphics.Blit(source, destination, tiltShiftMaterial, 6);
			}
			if (renderTexture != destination)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Color Adjustments/Tonemapping")]
	public class Tonemapping : PostEffectsBase
	{
		public enum TonemapperType
		{
			SimpleReinhard,
			UserCurve,
			Hable,
			Photographic,
			OptimizedHejiDawson,
			AdaptiveReinhard,
			AdaptiveReinhardAutoWhite
		}

		public enum AdaptiveTexSize
		{
			Square16 = 0x10,
			Square32 = 0x20,
			Square64 = 0x40,
			Square128 = 0x80,
			Square256 = 0x100,
			Square512 = 0x200,
			Square1024 = 0x400
		}

		public TonemapperType type = TonemapperType.Photographic;

		public AdaptiveTexSize adaptiveTextureSize = AdaptiveTexSize.Square256;

		public AnimationCurve remapCurve;

		private Texture2D curveTex;

		public float exposureAdjustment = 1.5f;

		public float middleGrey = 0.4f;

		public float white = 2f;

		public float adaptionSpeed = 1.5f;

		public Shader tonemapper;

		public bool validRenderTextureFormat = true;

		private Material tonemapMaterial;

		private RenderTexture rt;

		private RenderTextureFormat rtFormat = RenderTextureFormat.ARGBHalf;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false, needHdr: true);
			tonemapMaterial = CheckShaderAndCreateMaterial(tonemapper, tonemapMaterial);
			if (!curveTex && type == TonemapperType.UserCurve)
			{
				curveTex = new Texture2D(256, 1, TextureFormat.ARGB32, mipmap: false, linear: true);
				curveTex.filterMode = FilterMode.Bilinear;
				curveTex.wrapMode = TextureWrapMode.Clamp;
				curveTex.hideFlags = HideFlags.DontSave;
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public float UpdateCurve()
		{
			float num = 1f;
			if (remapCurve.keys.Length < 1)
			{
				remapCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(2f, 1f));
			}
			if (remapCurve != null)
			{
				if (remapCurve.length > 0)
				{
					num = remapCurve[remapCurve.length - 1].time;
				}
				for (float num2 = 0f; num2 <= 1f; num2 += 0.003921569f)
				{
					float num3 = remapCurve.Evaluate(num2 * 1f * num);
					curveTex.SetPixel((int)Mathf.Floor(num2 * 255f), 0, new Color(num3, num3, num3));
				}
				curveTex.Apply();
			}
			return 1f / num;
		}

		private void OnDisable()
		{
			if ((bool)rt)
			{
				UnityEngine.Object.DestroyImmediate(rt);
				rt = null;
			}
			if ((bool)tonemapMaterial)
			{
				UnityEngine.Object.DestroyImmediate(tonemapMaterial);
				tonemapMaterial = null;
			}
			if ((bool)curveTex)
			{
				UnityEngine.Object.DestroyImmediate(curveTex);
				curveTex = null;
			}
		}

		private bool CreateInternalRenderTexture()
		{
			if ((bool)rt)
			{
				return false;
			}
			rtFormat = ((!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf)) ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.RGHalf);
			rt = new RenderTexture(1, 1, 0, rtFormat);
			rt.hideFlags = HideFlags.DontSave;
			return true;
		}

		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			exposureAdjustment = ((!(exposureAdjustment < 0.001f)) ? exposureAdjustment : 0.001f);
			if (type == TonemapperType.UserCurve)
			{
				float value = UpdateCurve();
				tonemapMaterial.SetFloat("_RangeScale", value);
				tonemapMaterial.SetTexture("_Curve", curveTex);
				Graphics.Blit(source, destination, tonemapMaterial, 4);
				return;
			}
			if (type == TonemapperType.SimpleReinhard)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 6);
				return;
			}
			if (type == TonemapperType.Hable)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 5);
				return;
			}
			if (type == TonemapperType.Photographic)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 8);
				return;
			}
			if (type == TonemapperType.OptimizedHejiDawson)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", 0.5f * exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 7);
				return;
			}
			bool flag = CreateInternalRenderTexture();
			RenderTexture temporary = RenderTexture.GetTemporary((int)adaptiveTextureSize, (int)adaptiveTextureSize, 0, rtFormat);
			Graphics.Blit(source, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 1f, 2f);
			int num2 = 2;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 0, rtFormat);
				num2 *= 2;
			}
			RenderTexture source2 = array[num - 1];
			Graphics.Blit(temporary, array[0], tonemapMaterial, 1);
			if (type == TonemapperType.AdaptiveReinhardAutoWhite)
			{
				for (int j = 0; j < num - 1; j++)
				{
					Graphics.Blit(array[j], array[j + 1], tonemapMaterial, 9);
					source2 = array[j + 1];
				}
			}
			else if (type == TonemapperType.AdaptiveReinhard)
			{
				for (int k = 0; k < num - 1; k++)
				{
					Graphics.Blit(array[k], array[k + 1]);
					source2 = array[k + 1];
				}
			}
			adaptionSpeed = ((!(adaptionSpeed < 0.001f)) ? adaptionSpeed : 0.001f);
			tonemapMaterial.SetFloat("_AdaptionSpeed", adaptionSpeed);
			rt.MarkRestoreExpected();
			Graphics.Blit(source2, rt, tonemapMaterial, (!flag) ? 2 : 3);
			middleGrey = ((!(middleGrey < 0.001f)) ? middleGrey : 0.001f);
			tonemapMaterial.SetVector("_HdrParams", new Vector4(middleGrey, middleGrey, middleGrey, white * white));
			tonemapMaterial.SetTexture("_SmallTex", rt);
			if (type == TonemapperType.AdaptiveReinhard)
			{
				Graphics.Blit(source, destination, tonemapMaterial, 0);
			}
			else if (type == TonemapperType.AdaptiveReinhardAutoWhite)
			{
				Graphics.Blit(source, destination, tonemapMaterial, 10);
			}
			else
			{
				Debug.LogError("No valid adaptive tonemapper type found!");
				Graphics.Blit(source, destination);
			}
			for (int l = 0; l < num; l++)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}
	}
	internal class Triangles
	{
		private static Mesh[] meshes;

		private static int currentTris;

		private static bool HasMeshes()
		{
			if (meshes == null)
			{
				return false;
			}
			for (int i = 0; i < meshes.Length; i++)
			{
				if (null == meshes[i])
				{
					return false;
				}
			}
			return true;
		}

		private static void Cleanup()
		{
			if (meshes == null)
			{
				return;
			}
			for (int i = 0; i < meshes.Length; i++)
			{
				if (null != meshes[i])
				{
					UnityEngine.Object.DestroyImmediate(meshes[i]);
					meshes[i] = null;
				}
			}
			meshes = null;
		}

		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			if (HasMeshes() && currentTris == totalWidth * totalHeight)
			{
				return meshes;
			}
			int num = 21666;
			int num2 = (currentTris = totalWidth * totalHeight);
			int num3 = Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num));
			meshes = new Mesh[num3];
			int num4 = 0;
			int num5 = 0;
			for (num4 = 0; num4 < num2; num4 += num)
			{
				int triCount = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
				meshes[num5] = GetMesh(triCount, num4, totalWidth, totalHeight);
				num5++;
			}
			return meshes;
		}

		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			Mesh mesh = new Mesh();
			mesh.hideFlags = HideFlags.DontSave;
			Vector3[] array = new Vector3[triCount * 3];
			Vector2[] array2 = new Vector2[triCount * 3];
			Vector2[] array3 = new Vector2[triCount * 3];
			int[] array4 = new int[triCount * 3];
			for (int i = 0; i < triCount; i++)
			{
				int num = i * 3;
				int num2 = triOffset + i;
				float num3 = Mathf.Floor(num2 % totalWidth) / (float)totalWidth;
				float num4 = Mathf.Floor(num2 / totalWidth) / (float)totalHeight;
				Vector3 vector = new Vector3(num3 * 2f - 1f, num4 * 2f - 1f, 1f);
				array[num] = vector;
				array[num + 1] = vector;
				array[num + 2] = vector;
				ref Vector2 reference = ref array2[num];
				reference = new Vector2(0f, 0f);
				ref Vector2 reference2 = ref array2[num + 1];
				reference2 = new Vector2(1f, 0f);
				ref Vector2 reference3 = ref array2[num + 2];
				reference3 = new Vector2(0f, 1f);
				ref Vector2 reference4 = ref array3[num];
				reference4 = new Vector2(num3, num4);
				ref Vector2 reference5 = ref array3[num + 1];
				reference5 = new Vector2(num3, num4);
				ref Vector2 reference6 = ref array3[num + 2];
				reference6 = new Vector2(num3, num4);
				array4[num] = num;
				array4[num + 1] = num + 1;
				array4[num + 2] = num + 2;
			}
			mesh.vertices = array;
			mesh.triangles = array4;
			mesh.uv = array2;
			mesh.uv2 = array3;
			return mesh;
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Twirl")]
	public class Twirl : ImageEffectBase
	{
		public Vector2 radius = new Vector2(0.3f, 0.3f);

		public float angle = 50f;

		public Vector2 center = new Vector2(0.5f, 0.5f);

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			ImageEffects.RenderDistortion(base.material, source, destination, angle, center, radius);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Vignette and Chromatic Aberration")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		public enum AberrationMode
		{
			Simple,
			Advanced
		}

		public AberrationMode mode;

		public float intensity = 0.375f;

		public float chromaticAberration = 0.2f;

		public float axialAberration = 0.5f;

		public float blur;

		public float blurSpread = 0.75f;

		public float luminanceDependency = 0.25f;

		public float blurDistance = 2.5f;

		public Shader vignetteShader;

		public Shader separableBlurShader;

		public Shader chromAberrationShader;

		private Material m_VignetteMaterial;

		private Material m_SeparableBlurMaterial;

		private Material m_ChromAberrationMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			m_VignetteMaterial = CheckShaderAndCreateMaterial(vignetteShader, m_VignetteMaterial);
			m_SeparableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, m_SeparableBlurMaterial);
			m_ChromAberrationMaterial = CheckShaderAndCreateMaterial(chromAberrationShader, m_ChromAberrationMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			bool flag = Mathf.Abs(blur) > 0f || Mathf.Abs(intensity) > 0f;
			float num = 1f * (float)width / (1f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
				if (Mathf.Abs(blur) > 0f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
					Graphics.Blit(source, renderTexture2, m_ChromAberrationMaterial, 0);
					for (int i = 0; i < 2; i++)
					{
						m_SeparableBlurMaterial.SetVector("offsets", new Vector4(0f, blurSpread * 0.001953125f, 0f, 0f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
						Graphics.Blit(renderTexture2, temporary, m_SeparableBlurMaterial);
						RenderTexture.ReleaseTemporary(renderTexture2);
						m_SeparableBlurMaterial.SetVector("offsets", new Vector4(blurSpread * 0.001953125f / num, 0f, 0f, 0f));
						renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
						Graphics.Blit(temporary, renderTexture2, m_SeparableBlurMaterial);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				m_VignetteMaterial.SetFloat("_Intensity", intensity);
				m_VignetteMaterial.SetFloat("_Blur", blur);
				m_VignetteMaterial.SetTexture("_VignetteTex", renderTexture2);
				Graphics.Blit(source, renderTexture, m_VignetteMaterial, 0);
			}
			m_ChromAberrationMaterial.SetFloat("_ChromaticAberration", chromaticAberration);
			m_ChromAberrationMaterial.SetFloat("_AxialAberration", axialAberration);
			m_ChromAberrationMaterial.SetVector("_BlurDistance", new Vector2(0f - blurDistance, blurDistance));
			m_ChromAberrationMaterial.SetFloat("_Luminance", 1f / Mathf.Max(Mathf.Epsilon, luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				source.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit((!flag) ? source : renderTexture, destination, m_ChromAberrationMaterial, (mode != AberrationMode.Advanced) ? 1 : 2);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Vortex")]
	public class Vortex : ImageEffectBase
	{
		public Vector2 radius = new Vector2(0.4f, 0.4f);

		public float angle = 50f;

		public Vector2 center = new Vector2(0.5f, 0.5f);

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			ImageEffects.RenderDistortion(base.material, source, destination, angle, center, radius);
		}
	}
}
namespace UnityStandardAssets.Water
{
	[ExecuteInEditMode]
	public class WaterBasic : MonoBehaviour
	{
		private void Update()
		{
			Renderer component = GetComponent<Renderer>();
			if ((bool)component)
			{
				Material sharedMaterial = component.sharedMaterial;
				if ((bool)sharedMaterial)
				{
					Vector4 vector = sharedMaterial.GetVector("WaveSpeed");
					float @float = sharedMaterial.GetFloat("_WaveScale");
					float num = Time.time / 20f;
					Vector4 vector2 = vector * (num * @float);
					Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1f), Mathf.Repeat(vector2.y, 1f), Mathf.Repeat(vector2.z, 1f), Mathf.Repeat(vector2.w, 1f));
					sharedMaterial.SetVector("_WaveOffset", value);
				}
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class Displace : MonoBehaviour
	{
		public void Awake()
		{
			if (base.enabled)
			{
				OnEnable();
			}
			else
			{
				OnDisable();
			}
		}

		public void OnEnable()
		{
			Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_ON");
			Shader.DisableKeyword("WATER_VERTEX_DISPLACEMENT_OFF");
		}

		public void OnDisable()
		{
			Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_OFF");
			Shader.DisableKeyword("WATER_VERTEX_DISPLACEMENT_ON");
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class GerstnerDisplace : Displace
	{
	}
	public class MeshContainer
	{
		public Mesh mesh;

		public Vector3[] vertices;

		public Vector3[] normals;

		public MeshContainer(Mesh m)
		{
			mesh = m;
			vertices = m.vertices;
			normals = m.normals;
		}

		public void Update()
		{
			mesh.vertices = vertices;
			mesh.normals = normals;
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class PlanarReflection : MonoBehaviour
	{
		public LayerMask reflectionMask;

		public bool reflectSkybox;

		public Color clearColor = Color.grey;

		public string reflectionSampler = "_ReflectionTex";

		public float clipPlaneOffset = 0.07f;

		private Vector3 m_Oldpos;

		private Camera m_ReflectionCamera;

		private Material m_SharedMaterial;

		private Dictionary<Camera, bool> m_HelperCameras;

		public void Start()
		{
			m_SharedMaterial = ((WaterBase)base.gameObject.GetComponent(typeof(WaterBase))).sharedMaterial;
		}

		private Camera CreateReflectionCameraFor(Camera cam)
		{
			string text = base.gameObject.name + "Reflection" + cam.name;
			GameObject gameObject = GameObject.Find(text);
			if (!gameObject)
			{
				gameObject = new GameObject(text, typeof(Camera));
			}
			if (!gameObject.GetComponent(typeof(Camera)))
			{
				gameObject.AddComponent(typeof(Camera));
			}
			Camera component = gameObject.GetComponent<Camera>();
			component.backgroundColor = clearColor;
			component.clearFlags = (reflectSkybox ? CameraClearFlags.Skybox : CameraClearFlags.Color);
			SetStandardCameraParameter(component, reflectionMask);
			if (!component.targetTexture)
			{
				component.targetTexture = CreateTextureFor(cam);
			}
			return component;
		}

		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
			cam.cullingMask = (int)mask & ~(1 << LayerMask.NameToLayer("Water"));
			cam.backgroundColor = Color.black;
			cam.enabled = false;
		}

		private RenderTexture CreateTextureFor(Camera cam)
		{
			RenderTexture renderTexture = new RenderTexture(Mathf.FloorToInt((float)cam.pixelWidth * 0.5f), Mathf.FloorToInt((float)cam.pixelHeight * 0.5f), 24);
			renderTexture.hideFlags = HideFlags.DontSave;
			return renderTexture;
		}

		public void RenderHelpCameras(Camera currentCam)
		{
			if (m_HelperCameras == null)
			{
				m_HelperCameras = new Dictionary<Camera, bool>();
			}
			if (!m_HelperCameras.ContainsKey(currentCam))
			{
				m_HelperCameras.Add(currentCam, value: false);
			}
			if (!m_HelperCameras[currentCam])
			{
				if (!m_ReflectionCamera)
				{
					m_ReflectionCamera = CreateReflectionCameraFor(currentCam);
				}
				RenderReflectionFor(currentCam, m_ReflectionCamera);
				m_HelperCameras[currentCam] = true;
			}
		}

		public void LateUpdate()
		{
			if (m_HelperCameras != null)
			{
				m_HelperCameras.Clear();
			}
		}

		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
			RenderHelpCameras(currentCam);
			if ((bool)m_ReflectionCamera && (bool)m_SharedMaterial)
			{
				m_SharedMaterial.SetTexture(reflectionSampler, m_ReflectionCamera.targetTexture);
			}
		}

		public void OnEnable()
		{
			Shader.EnableKeyword("WATER_REFLECTIVE");
			Shader.DisableKeyword("WATER_SIMPLE");
		}

		public void OnDisable()
		{
			Shader.EnableKeyword("WATER_SIMPLE");
			Shader.DisableKeyword("WATER_REFLECTIVE");
		}

		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
			if (!reflectCamera || ((bool)m_SharedMaterial && !m_SharedMaterial.HasProperty(reflectionSampler)))
			{
				return;
			}
			reflectCamera.cullingMask = (int)reflectionMask & ~(1 << LayerMask.NameToLayer("Water"));
			SaneCameraSettings(reflectCamera);
			reflectCamera.backgroundColor = clearColor;
			reflectCamera.clearFlags = (reflectSkybox ? CameraClearFlags.Skybox : CameraClearFlags.Color);
			if (reflectSkybox && (bool)cam.gameObject.GetComponent(typeof(Skybox)))
			{
				Skybox skybox = (Skybox)reflectCamera.gameObject.GetComponent(typeof(Skybox));
				if (!skybox)
				{
					skybox = (Skybox)reflectCamera.gameObject.AddComponent(typeof(Skybox));
				}
				skybox.material = ((Skybox)cam.GetComponent(typeof(Skybox))).material;
			}
			GL.invertCulling = true;
			Transform transform = base.transform;
			Vector3 eulerAngles = cam.transform.eulerAngles;
			reflectCamera.transform.eulerAngles = new Vector3(0f - eulerAngles.x, eulerAngles.y, eulerAngles.z);
			reflectCamera.transform.position = cam.transform.position;
			Vector3 position = transform.transform.position;
			position.y = transform.position.y;
			Vector3 up = transform.transform.up;
			float w = 0f - Vector3.Dot(up, position) - clipPlaneOffset;
			Vector4 plane = new Vector4(up.x, up.y, up.z, w);
			Matrix4x4 zero = Matrix4x4.zero;
			zero = CalculateReflectionMatrix(zero, plane);
			m_Oldpos = cam.transform.position;
			Vector3 position2 = zero.MultiplyPoint(m_Oldpos);
			reflectCamera.worldToCameraMatrix = cam.worldToCameraMatrix * zero;
			Vector4 clipPlane = CameraSpacePlane(reflectCamera, position, up, 1f);
			Matrix4x4 projectionMatrix = cam.projectionMatrix;
			projectionMatrix = CalculateObliqueMatrix(projectionMatrix, clipPlane);
			reflectCamera.projectionMatrix = projectionMatrix;
			reflectCamera.transform.position = position2;
			Vector3 eulerAngles2 = cam.transform.eulerAngles;
			reflectCamera.transform.eulerAngles = new Vector3(0f - eulerAngles2.x, eulerAngles2.y, eulerAngles2.z);
			reflectCamera.Render();
			GL.invertCulling = false;
		}

		private void SaneCameraSettings(Camera helperCam)
		{
			helperCam.depthTextureMode = DepthTextureMode.None;
			helperCam.backgroundColor = Color.black;
			helperCam.clearFlags = CameraClearFlags.Color;
			helperCam.renderingPath = RenderingPath.Forward;
		}

		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			Vector4 b = projection.inverse * new Vector4(Sgn(clipPlane.x), Sgn(clipPlane.y), 1f, 1f);
			Vector4 vector = clipPlane * (2f / Vector4.Dot(clipPlane, b));
			projection[2] = vector.x - projection[3];
			projection[6] = vector.y - projection[7];
			projection[10] = vector.z - projection[11];
			projection[14] = vector.w - projection[15];
			return projection;
		}

		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			reflectionMat.m00 = 1f - 2f * plane[0] * plane[0];
			reflectionMat.m01 = -2f * plane[0] * plane[1];
			reflectionMat.m02 = -2f * plane[0] * plane[2];
			reflectionMat.m03 = -2f * plane[3] * plane[0];
			reflectionMat.m10 = -2f * plane[1] * plane[0];
			reflectionMat.m11 = 1f - 2f * plane[1] * plane[1];
			reflectionMat.m12 = -2f * plane[1] * plane[2];
			reflectionMat.m13 = -2f * plane[3] * plane[1];
			reflectionMat.m20 = -2f * plane[2] * plane[0];
			reflectionMat.m21 = -2f * plane[2] * plane[1];
			reflectionMat.m22 = 1f - 2f * plane[2] * plane[2];
			reflectionMat.m23 = -2f * plane[3] * plane[2];
			reflectionMat.m30 = 0f;
			reflectionMat.m31 = 0f;
			reflectionMat.m32 = 0f;
			reflectionMat.m33 = 1f;
			return reflectionMat;
		}

		private static float Sgn(float a)
		{
			if (a > 0f)
			{
				return 1f;
			}
			if (a < 0f)
			{
				return -1f;
			}
			return 0f;
		}

		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			Vector3 v = pos + normal * clipPlaneOffset;
			Matrix4x4 worldToCameraMatrix = cam.worldToCameraMatrix;
			Vector3 lhs = worldToCameraMatrix.MultiplyPoint(v);
			Vector3 rhs = worldToCameraMatrix.MultiplyVector(normal).normalized * sideSign;
			return new Vector4(rhs.x, rhs.y, rhs.z, 0f - Vector3.Dot(lhs, rhs));
		}
	}
	[RequireComponent(typeof(WaterBase))]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		public Transform specularLight;

		private WaterBase m_WaterBase;

		public void Start()
		{
			m_WaterBase = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
		}

		public void Update()
		{
			if (!m_WaterBase)
			{
				m_WaterBase = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
			}
			if ((bool)specularLight && (bool)m_WaterBase.sharedMaterial)
			{
				m_WaterBase.sharedMaterial.SetVector("_WorldLightDir", specularLight.transform.forward);
			}
		}
	}
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		public enum WaterMode
		{
			Simple,
			Reflective,
			Refractive
		}

		public WaterMode waterMode = WaterMode.Refractive;

		public bool disablePixelLights = true;

		public int textureSize = 256;

		public float clipPlaneOffset = 0.07f;

		public LayerMask reflectLayers = -1;

		public LayerMask refractLayers = -1;

		private Dictionary<Camera, Camera> m_ReflectionCameras = new Dictionary<Camera, Camera>();

		private Dictionary<Camera, Camera> m_RefractionCameras = new Dictionary<Camera, Camera>();

		private RenderTexture m_ReflectionTexture;

		private RenderTexture m_RefractionTexture;

		private WaterMode m_HardwareWaterSupport = WaterMode.Refractive;

		private int m_OldReflectionTextureSize;

		private int m_OldRefractionTextureSize;

		private static bool s_InsideWater;

		public void OnWillRenderObject()
		{
			if (!base.enabled || !GetComponent<Renderer>() || !GetComponent<Renderer>().sharedMaterial || !GetComponent<Renderer>().enabled)
			{
				return;
			}
			Camera current = Camera.current;
			if ((bool)current && !s_InsideWater)
			{
				s_InsideWater = true;
				m_HardwareWaterSupport = FindHardwareWaterSupport();
				WaterMode waterMode = GetWaterMode();
				CreateWaterObjects(current, out var reflectionCamera, out var refractionCamera);
				Vector3 position = base.transform.position;
				Vector3 up = base.transform.up;
				int pixelLightCount = QualitySettings.pixelLightCount;
				if (disablePixelLights)
				{
					QualitySettings.pixelLightCount = 0;
				}
				UpdateCameraModes(current, reflectionCamera);
				UpdateCameraModes(current, refractionCamera);
				if (waterMode >= WaterMode.Reflective)
				{
					float w = 0f - Vector3.Dot(up, position) - clipPlaneOffset;
					Vector4 plane = new Vector4(up.x, up.y, up.z, w);
					Matrix4x4 reflectionMat = Matrix4x4.zero;
					CalculateReflectionMatrix(ref reflectionMat, plane);
					Vector3 position2 = current.transform.position;
					Vector3 position3 = reflectionMat.MultiplyPoint(position2);
					reflectionCamera.worldToCameraMatrix = current.worldToCameraMatrix * reflectionMat;
					Vector4 clipPlane = CameraSpacePlane(reflectionCamera, position, up, 1f);
					reflectionCamera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
					reflectionCamera.cullingMask = -17 & reflectLayers.value;
					reflectionCamera.targetTexture = m_ReflectionTexture;
					GL.invertCulling = true;
					reflectionCamera.transform.position = position3;
					Vector3 eulerAngles = current.transform.eulerAngles;
					reflectionCamera.transform.eulerAngles = new Vector3(0f - eulerAngles.x, eulerAngles.y, eulerAngles.z);
					reflectionCamera.Render();
					reflectionCamera.transform.position = position2;
					GL.invertCulling = false;
					GetComponent<Renderer>().sharedMaterial.SetTexture("_ReflectionTex", m_ReflectionTexture);
				}
				if (waterMode >= WaterMode.Refractive)
				{
					refractionCamera.worldToCameraMatrix = current.worldToCameraMatrix;
					Vector4 clipPlane2 = CameraSpacePlane(refractionCamera, position, up, -1f);
					refractionCamera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane2);
					refractionCamera.cullingMask = -17 & refractLayers.value;
					refractionCamera.targetTexture = m_RefractionTexture;
					refractionCamera.transform.position = current.transform.position;
					refractionCamera.transform.rotation = current.transform.rotation;
					refractionCamera.Render();
					GetComponent<Renderer>().sharedMaterial.SetTexture("_RefractionTex", m_RefractionTexture);
				}
				if (disablePixelLights)
				{
					QualitySettings.pixelLightCount = pixelLightCount;
				}
				switch (waterMode)
				{
				case WaterMode.Simple:
					Shader.EnableKeyword("WATER_SIMPLE");
					Shader.DisableKeyword("WATER_REFLECTIVE");
					Shader.DisableKeyword("WATER_REFRACTIVE");
					break;
				case WaterMode.Reflective:
					Shader.DisableKeyword("WATER_SIMPLE");
					Shader.EnableKeyword("WATER_REFLECTIVE");
					Shader.DisableKeyword("WATER_REFRACTIVE");
					break;
				case WaterMode.Refractive:
					Shader.DisableKeyword("WATER_SIMPLE");
					Shader.DisableKeyword("WATER_REFLECTIVE");
					Shader.EnableKeyword("WATER_REFRACTIVE");
					break;
				}
				s_InsideWater = false;
			}
		}

		private void OnDisable()
		{
			if ((bool)m_ReflectionTexture)
			{
				UnityEngine.Object.DestroyImmediate(m_ReflectionTexture);
				m_ReflectionTexture = null;
			}
			if ((bool)m_RefractionTexture)
			{
				UnityEngine.Object.DestroyImmediate(m_RefractionTexture);
				m_RefractionTexture = null;
			}
			foreach (KeyValuePair<Camera, Camera> reflectionCamera in m_ReflectionCameras)
			{
				UnityEngine.Object.DestroyImmediate(reflectionCamera.Value.gameObject);
			}
			m_ReflectionCameras.Clear();
			foreach (KeyValuePair<Camera, Camera> refractionCamera in m_RefractionCameras)
			{
				UnityEngine.Object.DestroyImmediate(refractionCamera.Value.gameObject);
			}
			m_RefractionCameras.Clear();
		}

		private void Update()
		{
			if ((bool)GetComponent<Renderer>())
			{
				Material sharedMaterial = GetComponent<Renderer>().sharedMaterial;
				if ((bool)sharedMaterial)
				{
					Vector4 vector = sharedMaterial.GetVector("WaveSpeed");
					float @float = sharedMaterial.GetFloat("_WaveScale");
					Vector4 value = new Vector4(@float, @float, @float * 0.4f, @float * 0.45f);
					double num = (double)Time.timeSinceLevelLoad / 20.0;
					Vector4 value2 = new Vector4((float)Math.IEEERemainder((double)(vector.x * value.x) * num, 1.0), (float)Math.IEEERemainder((double)(vector.y * value.y) * num, 1.0), (float)Math.IEEERemainder((double)(vector.z * value.z) * num, 1.0), (float)Math.IEEERemainder((double)(vector.w * value.w) * num, 1.0));
					sharedMaterial.SetVector("_WaveOffset", value2);
					sharedMaterial.SetVector("_WaveScale4", value);
				}
			}
		}

		private void UpdateCameraModes(Camera src, Camera dest)
		{
			if (dest == null)
			{
				return;
			}
			dest.clearFlags = src.clearFlags;
			dest.backgroundColor = src.backgroundColor;
			if (src.clearFlags == CameraClearFlags.Skybox)
			{
				Skybox component = src.GetComponent<Skybox>();
				Skybox component2 = dest.GetComponent<Skybox>();
				if (!component || !component.material)
				{
					component2.enabled = false;
				}
				else
				{
					component2.enabled = true;
					component2.material = component.material;
				}
			}
			dest.farClipPlane = src.farClipPlane;
			dest.nearClipPlane = src.nearClipPlane;
			dest.orthographic = src.orthographic;
			dest.fieldOfView = src.fieldOfView;
			dest.aspect = src.aspect;
			dest.orthographicSize = src.orthographicSize;
		}

		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
			WaterMode waterMode = GetWaterMode();
			reflectionCamera = null;
			refractionCamera = null;
			if (waterMode >= WaterMode.Reflective)
			{
				if (!m_ReflectionTexture || m_OldReflectionTextureSize != textureSize)
				{
					if ((bool)m_ReflectionTexture)
					{
						UnityEngine.Object.DestroyImmediate(m_ReflectionTexture);
					}
					m_ReflectionTexture = new RenderTexture(textureSize, textureSize, 16);
					m_ReflectionTexture.name = "__WaterReflection" + GetInstanceID();
					m_ReflectionTexture.isPowerOfTwo = true;
					m_ReflectionTexture.hideFlags = HideFlags.DontSave;
					m_OldReflectionTextureSize = textureSize;
				}
				m_ReflectionCameras.TryGetValue(currentCamera, out reflectionCamera);
				if (!reflectionCamera)
				{
					GameObject gameObject = new GameObject("Water Refl Camera id" + GetInstanceID() + " for " + currentCamera.GetInstanceID(), typeof(Camera), typeof(Skybox));
					reflectionCamera = gameObject.GetComponent<Camera>();
					reflectionCamera.enabled = false;
					reflectionCamera.transform.position = base.transform.position;
					reflectionCamera.transform.rotation = base.transform.rotation;
					reflectionCamera.gameObject.AddComponent<FlareLayer>();
					gameObject.hideFlags = HideFlags.HideAndDontSave;
					m_ReflectionCameras[currentCamera] = reflectionCamera;
				}
			}
			if (waterMode < WaterMode.Refractive)
			{
				return;
			}
			if (!m_RefractionTexture || m_OldRefractionTextureSize != textureSize)
			{
				if ((bool)m_RefractionTexture)
				{
					UnityEngine.Object.DestroyImmediate(m_RefractionTexture);
				}
				m_RefractionTexture = new RenderTexture(textureSize, textureSize, 16);
				m_RefractionTexture.name = "__WaterRefraction" + GetInstanceID();
				m_RefractionTexture.isPowerOfTwo = true;
				m_RefractionTexture.hideFlags = HideFlags.DontSave;
				m_OldRefractionTextureSize = textureSize;
			}
			m_RefractionCameras.TryGetValue(currentCamera, out refractionCamera);
			if (!refractionCamera)
			{
				GameObject gameObject2 = new GameObject("Water Refr Camera id" + GetInstanceID() + " for " + currentCamera.GetInstanceID(), typeof(Camera), typeof(Skybox));
				refractionCamera = gameObject2.GetComponent<Camera>();
				refractionCamera.enabled = false;
				refractionCamera.transform.position = base.transform.position;
				refractionCamera.transform.rotation = base.transform.rotation;
				refractionCamera.gameObject.AddComponent<FlareLayer>();
				gameObject2.hideFlags = HideFlags.HideAndDontSave;
				m_RefractionCameras[currentCamera] = refractionCamera;
			}
		}

		private WaterMode GetWaterMode()
		{
			if (m_HardwareWaterSupport < waterMode)
			{
				return m_HardwareWaterSupport;
			}
			return waterMode;
		}

		private WaterMode FindHardwareWaterSupport()
		{
			if (!SystemInfo.supportsRenderTextures || !GetComponent<Renderer>())
			{
				return WaterMode.Simple;
			}
			Material sharedMaterial = GetComponent<Renderer>().sharedMaterial;
			if (!sharedMaterial)
			{
				return WaterMode.Simple;
			}
			string text = sharedMaterial.GetTag("WATERMODE", searchFallbacks: false);
			if (text == "Refractive")
			{
				return WaterMode.Refractive;
			}
			if (text == "Reflective")
			{
				return WaterMode.Reflective;
			}
			return WaterMode.Simple;
		}

		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			Vector3 v = pos + normal * clipPlaneOffset;
			Matrix4x4 worldToCameraMatrix = cam.worldToCameraMatrix;
			Vector3 lhs = worldToCameraMatrix.MultiplyPoint(v);
			Vector3 rhs = worldToCameraMatrix.MultiplyVector(normal).normalized * sideSign;
			return new Vector4(rhs.x, rhs.y, rhs.z, 0f - Vector3.Dot(lhs, rhs));
		}

		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
			reflectionMat.m00 = 1f - 2f * plane[0] * plane[0];
			reflectionMat.m01 = -2f * plane[0] * plane[1];
			reflectionMat.m02 = -2f * plane[0] * plane[2];
			reflectionMat.m03 = -2f * plane[3] * plane[0];
			reflectionMat.m10 = -2f * plane[1] * plane[0];
			reflectionMat.m11 = 1f - 2f * plane[1] * plane[1];
			reflectionMat.m12 = -2f * plane[1] * plane[2];
			reflectionMat.m13 = -2f * plane[3] * plane[1];
			reflectionMat.m20 = -2f * plane[2] * plane[0];
			reflectionMat.m21 = -2f * plane[2] * plane[1];
			reflectionMat.m22 = 1f - 2f * plane[2] * plane[2];
			reflectionMat.m23 = -2f * plane[3] * plane[2];
			reflectionMat.m30 = 0f;
			reflectionMat.m31 = 0f;
			reflectionMat.m32 = 0f;
			reflectionMat.m33 = 1f;
		}
	}
	public enum WaterQuality
	{
		High = 2,
		Medium = 1,
		Low = 0
	}
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		public Material sharedMaterial;

		public WaterQuality waterQuality = WaterQuality.High;

		public bool edgeBlend = true;

		public void UpdateShader()
		{
			if (waterQuality > WaterQuality.Medium)
			{
				sharedMaterial.shader.maximumLOD = 501;
			}
			else if (waterQuality > WaterQuality.Low)
			{
				sharedMaterial.shader.maximumLOD = 301;
			}
			else
			{
				sharedMaterial.shader.maximumLOD = 201;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				edgeBlend = false;
			}
			if (edgeBlend)
			{
				Shader.EnableKeyword("WATER_EDGEBLEND_ON");
				Shader.DisableKeyword("WATER_EDGEBLEND_OFF");
				if ((bool)Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
				}
			}
			else
			{
				Shader.EnableKeyword("WATER_EDGEBLEND_OFF");
				Shader.DisableKeyword("WATER_EDGEBLEND_ON");
			}
		}

		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
			if ((bool)currentCam && edgeBlend)
			{
				currentCam.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		public void Update()
		{
			if ((bool)sharedMaterial)
			{
				UpdateShader();
			}
		}
	}
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		public PlanarReflection reflection;

		public WaterBase waterBase;

		public void Start()
		{
			AcquireComponents();
		}

		private void AcquireComponents()
		{
			if (!reflection)
			{
				if ((bool)base.transform.parent)
				{
					reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!waterBase)
			{
				if ((bool)base.transform.parent)
				{
					waterBase = base.transform.parent.GetComponent<WaterBase>();
				}
				else
				{
					waterBase = base.transform.GetComponent<WaterBase>();
				}
			}
		}

		public void OnWillRenderObject()
		{
			if ((bool)reflection)
			{
				reflection.WaterTileBeingRendered(base.transform, Camera.current);
			}
			if ((bool)waterBase)
			{
				waterBase.WaterTileBeingRendered(base.transform, Camera.current);
			}
		}
	}
}
public class Gun
{
	public float Frequency;

	public float ConeAngle;

	public float DamagePerSecond;

	public float HitSoundVolume;

	public float Pitch;
}
public class PlayFabGameBridge : MonoBehaviour
{
	public static int playerHealth = 100;

	public static int totalKills = 0;

	public static uint gameState = 2u;

	public static Dictionary<string, Gun> gunTypes;

	public static List<string> gunNames;

	public static Gun currentGun = new Gun
	{
		Frequency = 10f,
		ConeAngle = 1.5f,
		DamagePerSecond = 20f,
		HitSoundVolume = 0.5f,
		Pitch = 1f
	};

	public static string currentGunName = "Default";

	public static bool mouseOverGui = false;

	public static Dictionary<string, int?> consumableItems = new Dictionary<string, int?>();

	public static Dictionary<string, int?> consumableItemsConsumed = new Dictionary<string, int?>();

	public static void consumeItem(string str)
	{
		consumableItems[str]--;
		consumableItemsConsumed[str]++;
	}

	public static void consumeItem(string str, int? count)
	{
		consumableItems[str] -= count;
		consumableItemsConsumed[str] += count;
	}

	public static void recordConsumed(string str)
	{
		consumableItemsConsumed[str] = 0;
	}
}
namespace UnityStandardAssets.Utility
{
	public class ActivateTrigger : MonoBehaviour
	{
		public enum Mode
		{
			Trigger,
			Replace,
			Activate,
			Enable,
			Animate,
			Deactivate
		}

		public Mode action = Mode.Activate;

		public UnityEngine.Object target;

		public GameObject source;

		public int triggerCount = 1;

		public bool repeatTrigger;

		private void DoActivateTrigger()
		{
			triggerCount--;
			if (triggerCount != 0 && !repeatTrigger)
			{
				return;
			}
			UnityEngine.Object @object = target ?? base.gameObject;
			Behaviour behaviour = @object as Behaviour;
			GameObject gameObject = @object as GameObject;
			if (behaviour != null)
			{
				gameObject = behaviour.gameObject;
			}
			switch (action)
			{
			case Mode.Trigger:
				if (gameObject != null)
				{
					gameObject.BroadcastMessage("DoActivateTrigger");
				}
				break;
			case Mode.Replace:
				if (source != null && gameObject != null)
				{
					UnityEngine.Object.Instantiate(source, gameObject.transform.position, gameObject.transform.rotation);
					UnityEngine.Object.DestroyObject(gameObject);
				}
				break;
			case Mode.Activate:
				if (gameObject != null)
				{
					gameObject.SetActive(value: true);
				}
				break;
			case Mode.Enable:
				if (behaviour != null)
				{
					behaviour.enabled = true;
				}
				break;
			case Mode.Animate:
				if (gameObject != null)
				{
					gameObject.GetComponent<Animation>().Play();
				}
				break;
			case Mode.Deactivate:
				if (gameObject != null)
				{
					gameObject.SetActive(value: false);
				}
				break;
			}
		}

		private void OnTriggerEnter(Collider other)
		{
			DoActivateTrigger();
		}
	}
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		public class ReplacementDefinition
		{
			public Shader original;

			public Shader replacement;
		}

		[Serializable]
		public class ReplacementList
		{
			public ReplacementDefinition[] items = new ReplacementDefinition[0];
		}

		[SerializeField]
		private ReplacementList m_ReplacementList;

		private void OnEnable()
		{
			Renderer[] array = UnityEngine.Object.FindObjectsOfType<Renderer>();
			Debug.Log(array.Length + " renderers");
			List<Material> list = new List<Material>();
			List<Material> list2 = new List<Material>();
			int num = 0;
			int num2 = 0;
			ReplacementDefinition[] items = m_ReplacementList.items;
			foreach (ReplacementDefinition replacementDefinition in items)
			{
				Renderer[] array2 = array;
				foreach (Renderer renderer in array2)
				{
					Material[] array3 = null;
					for (int k = 0; k < renderer.sharedMaterials.Length; k++)
					{
						Material material = renderer.sharedMaterials[k];
						if (material.shader == replacementDefinition.original)
						{
							if (array3 == null)
							{
								array3 = renderer.materials;
							}
							if (!list.Contains(material))
							{
								list.Add(material);
								Material material2 = UnityEngine.Object.Instantiate(material);
								material2.shader = replacementDefinition.replacement;
								list2.Add(material2);
								num++;
							}
							Debug.Log("replacing " + renderer.gameObject.name + " renderer " + k + " with " + list2[list.IndexOf(material)].name);
							array3[k] = list2[list.IndexOf(material)];
							num2++;
						}
					}
					if (array3 != null)
					{
						renderer.materials = array3;
					}
				}
			}
			Debug.Log(num2 + " material instances replaced");
			Debug.Log(num + " materials replaced");
			for (int l = 0; l < list.Count; l++)
			{
				Debug.Log(list[l].name + " (" + list[l].shader.name + ") replaced with " + list2[l].name + " (" + list2[l].shader.name + ")");
			}
		}
	}
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		public class Vector3andSpace
		{
			public Vector3 value;

			public Space space = Space.Self;
		}

		public Vector3andSpace moveUnitsPerSecond;

		public Vector3andSpace rotateDegreesPerSecond;

		public bool ignoreTimescale;

		private float m_LastRealTime;

		private void Start()
		{
			m_LastRealTime = Time.realtimeSinceStartup;
		}

		private void Update()
		{
			float num = Time.deltaTime;
			if (ignoreTimescale)
			{
				num = Time.realtimeSinceStartup - m_LastRealTime;
				m_LastRealTime = Time.realtimeSinceStartup;
			}
			base.transform.Translate(moveUnitsPerSecond.value * num, moveUnitsPerSecond.space);
			base.transform.Rotate(rotateDegreesPerSecond.value * num, moveUnitsPerSecond.space);
		}
	}
	public class CameraRefocus
	{
		public Camera Camera;

		public Vector3 Lookatpoint;

		public Transform Parent;

		private Vector3 m_OrigCameraPos;

		private bool m_Refocus;

		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
			m_OrigCameraPos = origCameraPos;
			Camera = camera;
			Parent = parent;
		}

		public void ChangeCamera(Camera camera)
		{
			Camera = camera;
		}

		public void ChangeParent(Transform parent)
		{
			Parent = parent;
		}

		public void GetFocusPoint()
		{
			if (Physics.Raycast(Parent.transform.position + m_OrigCameraPos, Parent.transform.forward, out var hitInfo, 100f))
			{
				Lookatpoint = hitInfo.point;
				m_Refocus = true;
			}
			else
			{
				m_Refocus = false;
			}
		}

		public void SetFocusPoint()
		{
			if (m_Refocus)
			{
				Camera.transform.LookAt(Lookatpoint);
			}
		}
	}
	[Serializable]
	public class CurveControlledBob
	{
		public float HorizontalBobRange = 0.33f;

		public float VerticalBobRange = 0.33f;

		public AnimationCurve Bobcurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(0.5f, 1f), new Keyframe(1f, 0f), new Keyframe(1.5f, -1f), new Keyframe(2f, 0f));

		public float VerticaltoHorizontalRatio = 1f;

		private float m_CyclePositionX;

		private float m_CyclePositionY;

		private float m_BobBaseInterval;

		private Vector3 m_OriginalCameraPosition;

		private float m_Time;

		public void Setup(Camera camera, float bobBaseInterval)
		{
			m_BobBaseInterval = bobBaseInterval;
			m_OriginalCameraPosition = camera.transform.localPosition;
			m_Time = Bobcurve[Bobcurve.length - 1].time;
		}

		public Vector3 DoHeadBob(float speed)
		{
			float x = m_OriginalCameraPosition.x + Bobcurve.Evaluate(m_CyclePositionX) * HorizontalBobRange;
			float y = m_OriginalCameraPosition.y + Bobcurve.Evaluate(m_CyclePositionY) * VerticalBobRange;
			m_CyclePositionX += speed * Time.deltaTime / m_BobBaseInterval;
			m_CyclePositionY += speed * Time.deltaTime / m_BobBaseInterval * VerticaltoHorizontalRatio;
			if (m_CyclePositionX > m_Time)
			{
				m_CyclePositionX -= m_Time;
			}
			if (m_CyclePositionY > m_Time)
			{
				m_CyclePositionY -= m_Time;
			}
			return new Vector3(x, y, 0f);
		}
	}
	public class DragRigidbody : MonoBehaviour
	{
		private const float k_Spring = 50f;

		private const float k_Damper = 5f;

		private const float k_Drag = 10f;

		private const float k_AngularDrag = 5f;

		private const float k_Distance = 0.2f;

		private const bool k_AttachToCenterOfMass = false;

		private SpringJoint m_SpringJoint;

		private void Update()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = FindCamera();
			RaycastHit hitInfo = default(RaycastHit);
			if (Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out hitInfo, 100f, -5) && (bool)hitInfo.rigidbody && !hitInfo.rigidbody.isKinematic)
			{
				if (!m_SpringJoint)
				{
					GameObject gameObject = new GameObject("Rigidbody dragger");
					Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
					m_SpringJoint = gameObject.AddComponent<SpringJoint>();
					rigidbody.isKinematic = true;
				}
				m_SpringJoint.transform.position = hitInfo.point;
				m_SpringJoint.anchor = Vector3.zero;
				m_SpringJoint.spring = 50f;
				m_SpringJoint.damper = 5f;
				m_SpringJoint.maxDistance = 0.2f;
				m_SpringJoint.connectedBody = hitInfo.rigidbody;
				StartCoroutine("DragObject", hitInfo.distance);
			}
		}

		private IEnumerator DragObject(float distance)
		{
			float oldDrag = m_SpringJoint.connectedBody.drag;
			float oldAngularDrag = m_SpringJoint.connectedBody.angularDrag;
			m_SpringJoint.connectedBody.drag = 10f;
			m_SpringJoint.connectedBody.angularDrag = 5f;
			Camera mainCamera = FindCamera();
			while (Input.GetMouseButton(0))
			{
				Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
				m_SpringJoint.transform.position = ray.GetPoint(distance);
				yield return null;
			}
			if ((bool)m_SpringJoint.connectedBody)
			{
				m_SpringJoint.connectedBody.drag = oldDrag;
				m_SpringJoint.connectedBody.angularDrag = oldAngularDrag;
				m_SpringJoint.connectedBody = null;
			}
		}

		private Camera FindCamera()
		{
			if ((bool)GetComponent<Camera>())
			{
				return GetComponent<Camera>();
			}
			return Camera.main;
		}
	}
	public class DynamicShadowSettings : MonoBehaviour
	{
		public Light sunLight;

		public float minHeight = 10f;

		public float minShadowDistance = 80f;

		public float minShadowBias = 1f;

		public float maxHeight = 1000f;

		public float maxShadowDistance = 10000f;

		public float maxShadowBias = 0.1f;

		public float adaptTime = 1f;

		private float m_SmoothHeight;

		private float m_ChangeSpeed;

		private float m_OriginalStrength = 1f;

		private void Start()
		{
			m_OriginalStrength = sunLight.shadowStrength;
		}

		private void Update()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			if (Physics.Raycast(ray, out var hitInfo))
			{
				num = hitInfo.distance;
			}
			if (Mathf.Abs(num - m_SmoothHeight) > 1f)
			{
				m_SmoothHeight = Mathf.SmoothDamp(m_SmoothHeight, num, ref m_ChangeSpeed, adaptTime);
			}
			float num2 = Mathf.InverseLerp(minHeight, maxHeight, m_SmoothHeight);
			QualitySettings.shadowDistance = Mathf.Lerp(minShadowDistance, maxShadowDistance, num2);
			sunLight.shadowBias = Mathf.Lerp(minShadowBias, maxShadowBias, 1f - (1f - num2) * (1f - num2));
			sunLight.shadowStrength = Mathf.Lerp(m_OriginalStrength, 0f, num2);
		}
	}
}
public class EventSystemChecker : MonoBehaviour
{
	private void Awake()
	{
		if (!UnityEngine.Object.FindObjectOfType<EventSystem>())
		{
			GameObject gameObject = new GameObject("EventSystem");
			gameObject.AddComponent<EventSystem>();
			gameObject.AddComponent<StandaloneInputModule>().forceModuleActive = true;
			gameObject.AddComponent<TouchInputModule>();
		}
	}
}
namespace UnityStandardAssets.Utility
{
	[Serializable]
	public class FOVKick
	{
		public Camera Camera;

		[HideInInspector]
		public float originalFov;

		public float FOVIncrease = 3f;

		public float TimeToIncrease = 1f;

		public float TimeToDecrease = 1f;

		public AnimationCurve IncreaseCurve;

		public void Setup(Camera camera)
		{
			CheckStatus(camera);
			Camera = camera;
			originalFov = camera.fieldOfView;
		}

		private void CheckStatus(Camera camera)
		{
			if (camera == null)
			{
				throw new Exception("FOVKick camera is null, please supply the camera to the constructor");
			}
			if (IncreaseCurve == null)
			{
				throw new Exception("FOVKick Increase curve is null, please define the curve for the field of view kicks");
			}
		}

		public void ChangeCamera(Camera camera)
		{
			Camera = camera;
		}

		public IEnumerator FOVKickUp()
		{
			float t = Mathf.Abs((Camera.fieldOfView - originalFov) / FOVIncrease);
			while (t < TimeToIncrease)
			{
				Camera.fieldOfView = originalFov + IncreaseCurve.Evaluate(t / TimeToIncrease) * FOVIncrease;
				t += Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
		}

		public IEnumerator FOVKickDown()
		{
			float t = Mathf.Abs((Camera.fieldOfView - originalFov) / FOVIncrease);
			while (t > 0f)
			{
				Camera.fieldOfView = originalFov + IncreaseCurve.Evaluate(t / TimeToDecrease) * FOVIncrease;
				t -= Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
			Camera.fieldOfView = originalFov;
		}
	}
	[RequireComponent(typeof(Text))]
	public class FPSCounter : MonoBehaviour
	{
		private const float fpsMeasurePeriod = 0.5f;

		private int m_FpsAccumulator;

		private float m_FpsNextPeriod;

		private int m_CurrentFps;

		private const string display = "{0} FPS";

		private Text m_Text;

		private void Start()
		{
			m_FpsNextPeriod = Time.realtimeSinceStartup + 0.5f;
			m_Text = GetComponent<Text>();
		}

		private void Update()
		{
			m_FpsAccumulator++;
			if (Time.realtimeSinceStartup > m_FpsNextPeriod)
			{
				m_CurrentFps = (int)((float)m_FpsAccumulator / 0.5f);
				m_FpsAccumulator = 0;
				m_FpsNextPeriod += 0.5f;
				m_Text.text = $"{m_CurrentFps} FPS";
			}
		}
	}
	public class FollowTarget : MonoBehaviour
	{
		public Transform target;

		public Vector3 offset = new Vector3(0f, 7.5f, 0f);

		private void LateUpdate()
		{
			base.transform.position = target.position + offset;
		}
	}
}
[RequireComponent(typeof(GUITexture))]
public class ForcedReset : MonoBehaviour
{
	private void Update()
	{
		if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
		{
			Application.LoadLevelAsync(Application.loadedLevelName);
		}
	}
}
namespace UnityStandardAssets.Utility
{
	[Serializable]
	public class LerpControlledBob
	{
		public float BobDuration;

		public float BobAmount;

		private float m_Offset;

		public float Offset()
		{
			return m_Offset;
		}

		public IEnumerator DoBobCycle()
		{
			float t2 = 0f;
			while (t2 < BobDuration)
			{
				m_Offset = Mathf.Lerp(0f, BobAmount, t2 / BobDuration);
				t2 += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			t2 = 0f;
			while (t2 < BobDuration)
			{
				m_Offset = Mathf.Lerp(BobAmount, 0f, t2 / BobDuration);
				t2 += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			m_Offset = 0f;
		}
	}
	public class ObjectResetter : MonoBehaviour
	{
		private Vector3 originalPosition;

		private Quaternion originalRotation;

		private List<Transform> originalStructure;

		private Rigidbody Rigidbody;

		private void Start()
		{
			originalStructure = new List<Transform>(GetComponentsInChildren<Transform>());
			originalPosition = base.transform.position;
			originalRotation = base.transform.rotation;
			Rigidbody = GetComponent<Rigidbody>();
		}

		public void DelayedReset(float delay)
		{
			StartCoroutine(ResetCoroutine(delay));
		}

		public IEnumerator ResetCoroutine(float delay)
		{
			yield return new WaitForSeconds(delay);
			Transform[] componentsInChildren = GetComponentsInChildren<Transform>();
			foreach (Transform transform in componentsInChildren)
			{
				if (!originalStructure.Contains(transform))
				{
					transform.parent = null;
				}
			}
			base.transform.position = originalPosition;
			base.transform.rotation = originalRotation;
			if ((bool)Rigidbody)
			{
				Rigidbody.velocity = Vector3.zero;
				Rigidbody.angularVelocity = Vector3.zero;
			}
			SendMessage("Reset");
		}
	}
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		public float minDuration = 8f;

		public float maxDuration = 10f;

		private float m_MaxLifetime;

		private bool m_EarlyStop;

		private IEnumerator Start()
		{
			ParticleSystem[] systems = GetComponentsInChildren<ParticleSystem>();
			ParticleSystem[] array = systems;
			foreach (ParticleSystem particleSystem in array)
			{
				m_MaxLifetime = Mathf.Max(particleSystem.startLifetime, m_MaxLifetime);
			}
			float stopTime = Time.time + UnityEngine.Random.Range(minDuration, maxDuration);
			while (Time.time < stopTime || m_EarlyStop)
			{
				yield return null;
			}
			Debug.Log("stopping " + base.name);
			ParticleSystem[] array2 = systems;
			foreach (ParticleSystem particleSystem2 in array2)
			{
				particleSystem2.enableEmission = false;
			}
			BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(m_MaxLifetime);
			UnityEngine.Object.Destroy(base.gameObject);
		}

		public void Stop()
		{
			m_EarlyStop = true;
		}
	}
	public class PlatformSpecificContent : MonoBehaviour
	{
		private enum BuildTargetGroup
		{
			Standalone,
			Mobile
		}

		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[SerializeField]
		private GameObject[] m_Content = new GameObject[0];

		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours = new MonoBehaviour[0];

		[SerializeField]
		private bool m_ChildrenOfThisObject;

		private void OnEnable()
		{
			CheckEnableContent();
		}

		private void CheckEnableContent()
		{
			if (m_BuildTargetGroup == BuildTargetGroup.Mobile)
			{
				EnableContent(enabled: true);
			}
			else
			{
				EnableContent(enabled: false);
			}
		}

		private void EnableContent(bool enabled)
		{
			if (m_Content.Length > 0)
			{
				GameObject[] content = m_Content;
				foreach (GameObject gameObject in content)
				{
					if (gameObject != null)
					{
						gameObject.SetActive(enabled);
					}
				}
			}
			if (m_ChildrenOfThisObject)
			{
				foreach (Transform item in base.transform)
				{
					item.gameObject.SetActive(enabled);
				}
			}
			if (m_MonoBehaviours.Length > 0)
			{
				MonoBehaviour[] monoBehaviours = m_MonoBehaviours;
				foreach (MonoBehaviour monoBehaviour in monoBehaviours)
				{
					monoBehaviour.enabled = enabled;
				}
			}
		}
	}
	public class SimpleActivatorMenu : MonoBehaviour
	{
		public GUIText camSwitchButton;

		public GameObject[] objects;

		private int m_CurrentActiveObject;

		private void OnEnable()
		{
			m_CurrentActiveObject = 0;
			camSwitchButton.text = objects[m_CurrentActiveObject].name;
		}

		public void NextCamera()
		{
			int num = ((m_CurrentActiveObject + 1 < objects.Length) ? (m_CurrentActiveObject + 1) : 0);
			for (int i = 0; i < objects.Length; i++)
			{
				objects[i].SetActive(i == num);
			}
			m_CurrentActiveObject = num;
			camSwitchButton.text = objects[m_CurrentActiveObject].name;
		}
	}
	public class SimpleMouseRotator : MonoBehaviour
	{
		public Vector2 rotationRange = new Vector3(70f, 70f);

		public float rotationSpeed = 10f;

		public float dampingTime = 0.2f;

		public bool autoZeroVerticalOnMobile = true;

		public bool autoZeroHorizontalOnMobile;

		public bool relative = true;

		private Vector3 m_TargetAngles;

		private Vector3 m_FollowAngles;

		private Vector3 m_FollowVelocity;

		private Quaternion m_OriginalRotation;

		private void Start()
		{
			m_OriginalRotation = base.transform.localRotation;
		}

		private void Update()
		{
			base.transform.localRotation = m_OriginalRotation;
			if (relative)
			{
				float axis = CrossPlatformInputManager.GetAxis("Mouse X");
				float axis2 = CrossPlatformInputManager.GetAxis("Mouse Y");
				if (m_TargetAngles.y > 180f)
				{
					m_TargetAngles.y -= 360f;
					m_FollowAngles.y -= 360f;
				}
				if (m_TargetAngles.x > 180f)
				{
					m_TargetAngles.x -= 360f;
					m_FollowAngles.x -= 360f;
				}
				if (m_TargetAngles.y < -180f)
				{
					m_TargetAngles.y += 360f;
					m_FollowAngles.y += 360f;
				}
				if (m_TargetAngles.x < -180f)
				{
					m_TargetAngles.x += 360f;
					m_FollowAngles.x += 360f;
				}
				m_TargetAngles.y += axis * rotationSpeed;
				m_TargetAngles.x += axis2 * rotationSpeed;
				m_TargetAngles.y = Mathf.Clamp(m_TargetAngles.y, (0f - rotationRange.y) * 0.5f, rotationRange.y * 0.5f);
				m_TargetAngles.x = Mathf.Clamp(m_TargetAngles.x, (0f - rotationRange.x) * 0.5f, rotationRange.x * 0.5f);
			}
			else
			{
				float axis = Input.mousePosition.x;
				float axis2 = Input.mousePosition.y;
				m_TargetAngles.y = Mathf.Lerp((0f - rotationRange.y) * 0.5f, rotationRange.y * 0.5f, axis / (float)Screen.width);
				m_TargetAngles.x = Mathf.Lerp((0f - rotationRange.x) * 0.5f, rotationRange.x * 0.5f, axis2 / (float)Screen.height);
			}
			m_FollowAngles = Vector3.SmoothDamp(m_FollowAngles, m_TargetAngles, ref m_FollowVelocity, dampingTime);
			base.transform.localRotation = m_OriginalRotation * Quaternion.Euler(0f - m_FollowAngles.x, m_FollowAngles.y, 0f);
		}
	}
	public class SmoothFollow : MonoBehaviour
	{
		[SerializeField]
		private Transform target;

		[SerializeField]
		private float distance = 10f;

		[SerializeField]
		private float height = 5f;

		[SerializeField]
		private float rotationDamping;

		[SerializeField]
		private float heightDamping;

		private void Start()
		{
		}

		private void LateUpdate()
		{
			if ((bool)target)
			{
				float y = target.eulerAngles.y;
				float b = target.position.y + height;
				float y2 = base.transform.eulerAngles.y;
				float y3 = base.transform.position.y;
				y2 = Mathf.LerpAngle(y2, y, rotationDamping * Time.deltaTime);
				y3 = Mathf.Lerp(y3, b, heightDamping * Time.deltaTime);
				Quaternion quaternion = Quaternion.Euler(0f, y2, 0f);
				base.transform.position = target.position;
				base.transform.position -= quaternion * Vector3.forward * distance;
				base.transform.position = new Vector3(base.transform.position.x, y3, base.transform.position.z);
				base.transform.LookAt(target);
			}
		}
	}
	public class TimedObjectActivator : MonoBehaviour
	{
		public enum Action
		{
			Activate,
			Deactivate,
			Destroy,
			ReloadLevel,
			Call
		}

		[Serializable]
		public class Entry
		{
			public GameObject target;

			public Action action;

			public float delay;
		}

		[Serializable]
		public class Entries
		{
			public Entry[] entries;
		}

		public Entries entries = new Entries();

		private void Awake()
		{
			Entry[] array = entries.entries;
			foreach (Entry entry in array)
			{
				switch (entry.action)
				{
				case Action.Activate:
					StartCoroutine(Activate(entry));
					break;
				case Action.Deactivate:
					StartCoroutine(Deactivate(entry));
					break;
				case Action.Destroy:
					UnityEngine.Object.Destroy(entry.target, entry.delay);
					break;
				case Action.ReloadLevel:
					StartCoroutine(ReloadLevel(entry));
					break;
				}
			}
		}

		private IEnumerator Activate(Entry entry)
		{
			yield return new WaitForSeconds(entry.delay);
			entry.target.SetActive(value: true);
		}

		private IEnumerator Deactivate(Entry entry)
		{
			yield return new WaitForSeconds(entry.delay);
			entry.target.SetActive(value: false);
		}

		private IEnumerator ReloadLevel(Entry entry)
		{
			yield return new WaitForSeconds(entry.delay);
			Application.LoadLevel(Application.loadedLevel);
		}
	}
	public class TimedObjectDestructor : MonoBehaviour
	{
		[SerializeField]
		private float m_TimeOut = 1f;

		[SerializeField]
		private bool m_DetachChildren;

		private void Awake()
		{
			Invoke("DestroyNow", m_TimeOut);
		}

		private void DestroyNow()
		{
			if (m_DetachChildren)
			{
				base.transform.DetachChildren();
			}
			UnityEngine.Object.DestroyObject(base.gameObject);
		}
	}
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		public class WaypointList
		{
			public WaypointCircuit circuit;

			public Transform[] items = new Transform[0];
		}

		public struct RoutePoint
		{
			public Vector3 position;

			public Vector3 direction;

			public RoutePoint(Vector3 position, Vector3 direction)
			{
				this.position = position;
				this.direction = direction;
			}
		}

		public WaypointList waypointList = new WaypointList();

		[SerializeField]
		private bool smoothRoute = true;

		private int numPoints;

		private Vector3[] points;

		private float[] distances;

		public float editorVisualisationSubsteps = 100f;

		private int p0n;

		private int p1n;

		private int p2n;

		private int p3n;

		private float i;

		private Vector3 P0;

		private Vector3 P1;

		private Vector3 P2;

		private Vector3 P3;

		public float Length { get; private set; }

		public Transform[] Waypoints => waypointList.items;

		private void Awake()
		{
			if (Waypoints.Length > 1)
			{
				CachePositionsAndDistances();
			}
			numPoints = Waypoints.Length;
		}

		public RoutePoint GetRoutePoint(float dist)
		{
			Vector3 routePosition = GetRoutePosition(dist);
			Vector3 routePosition2 = GetRoutePosition(dist + 0.1f);
			return new RoutePoint(routePosition, (routePosition2 - routePosition).normalized);
		}

		public Vector3 GetRoutePosition(float dist)
		{
			int i = 0;
			if (Length == 0f)
			{
				Length = distances[distances.Length - 1];
			}
			for (dist = Mathf.Repeat(dist, Length); distances[i] < dist; i++)
			{
			}
			p1n = (i - 1 + numPoints) % numPoints;
			p2n = i;
			this.i = Mathf.InverseLerp(distances[p1n], distances[p2n], dist);
			if (smoothRoute)
			{
				p0n = (i - 2 + numPoints) % numPoints;
				p3n = (i + 1) % numPoints;
				p2n %= numPoints;
				P0 = points[p0n];
				P1 = points[p1n];
				P2 = points[p2n];
				P3 = points[p3n];
				return CatmullRom(P0, P1, P2, P3, this.i);
			}
			p1n = (i - 1 + numPoints) % numPoints;
			p2n = i;
			return Vector3.Lerp(points[p1n], points[p2n], this.i);
		}

		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return 0.5f * (2f * p1 + (-p0 + p2) * i + (2f * p0 - 5f * p1 + 4f * p2 - p3) * i * i + (-p0 + 3f * p1 - 3f * p2 + p3) * i * i * i);
		}

		private void CachePositionsAndDistances()
		{
			points = new Vector3[Waypoints.Length + 1];
			distances = new float[Waypoints.Length + 1];
			float num = 0f;
			for (int i = 0; i < points.Length; i++)
			{
				Transform transform = Waypoints[i % Waypoints.Length];
				Transform transform2 = Waypoints[(i + 1) % Waypoints.Length];
				if (transform != null && transform2 != null)
				{
					Vector3 position = transform.position;
					Vector3 position2 = transform2.position;
					ref Vector3 reference = ref points[i];
					reference = Waypoints[i % Waypoints.Length].position;
					distances[i] = num;
					num += (position - position2).magnitude;
				}
			}
		}

		private void OnDrawGizmos()
		{
			DrawGizmos(selected: false);
		}

		private void OnDrawGizmosSelected()
		{
			DrawGizmos(selected: true);
		}

		private void DrawGizmos(bool selected)
		{
			waypointList.circuit = this;
			if (Waypoints.Length <= 1)
			{
				return;
			}
			numPoints = Waypoints.Length;
			CachePositionsAndDistances();
			Length = distances[distances.Length - 1];
			Gizmos.color = ((!selected) ? new Color(1f, 1f, 0f, 0.5f) : Color.yellow);
			Vector3 from = Waypoints[0].position;
			if (smoothRoute)
			{
				for (float num = 0f; num < Length; num += Length / editorVisualisationSubsteps)
				{
					Vector3 routePosition = GetRoutePosition(num + 1f);
					Gizmos.DrawLine(from, routePosition);
					from = routePosition;
				}
				Gizmos.DrawLine(from, Waypoints[0].position);
			}
			else
			{
				for (int i = 0; i < Waypoints.Length; i++)
				{
					Vector3 position = Waypoints[(i + 1) % Waypoints.Length].position;
					Gizmos.DrawLine(from, position);
					from = position;
				}
			}
		}
	}
	public class WaypointProgressTracker : MonoBehaviour
	{
		public enum ProgressStyle
		{
			SmoothAlongRoute,
			PointToPoint
		}

		[SerializeField]
		private WaypointCircuit circuit;

		[SerializeField]
		private float lookAheadForTargetOffset = 5f;

		[SerializeField]
		private float lookAheadForTargetFactor = 0.1f;

		[SerializeField]
		private float lookAheadForSpeedOffset = 10f;

		[SerializeField]
		private float lookAheadForSpeedFactor = 0.2f;

		[SerializeField]
		private ProgressStyle progressStyle;

		[SerializeField]
		private float pointToPointThreshold = 4f;

		public Transform target;

		private float progressDistance;

		private int progressNum;

		private Vector3 lastPosition;

		private float speed;

		public WaypointCircuit.RoutePoint targetPoint { get; private set; }

		public WaypointCircuit.RoutePoint speedPoint { get; private set; }

		public WaypointCircuit.RoutePoint progressPoint { get; private set; }

		private void Start()
		{
			if (target == null)
			{
				target = new GameObject(base.name + " Waypoint Target").transform;
			}
			Reset();
		}

		public void Reset()
		{
			progressDistance = 0f;
			progressNum = 0;
			if (progressStyle == ProgressStyle.PointToPoint)
			{
				target.position = circuit.Waypoints[progressNum].position;
				target.rotation = circuit.Waypoints[progressNum].rotation;
			}
		}

		private void Update()
		{
			if (progressStyle == ProgressStyle.SmoothAlongRoute)
			{
				if (Time.deltaTime > 0f)
				{
					speed = Mathf.Lerp(speed, (lastPosition - base.transform.position).magnitude / Time.deltaTime, Time.deltaTime);
				}
				target.position = circuit.GetRoutePoint(progressDistance + lookAheadForTargetOffset + lookAheadForTargetFactor * speed).position;
				target.rotation = Quaternion.LookRotation(circuit.GetRoutePoint(progressDistance + lookAheadForSpeedOffset + lookAheadForSpeedFactor * speed).direction);
				progressPoint = circuit.GetRoutePoint(progressDistance);
				Vector3 lhs = progressPoint.position - base.transform.position;
				if (Vector3.Dot(lhs, progressPoint.direction) < 0f)
				{
					progressDistance += lhs.magnitude * 0.5f;
				}
				lastPosition = base.transform.position;
			}
			else
			{
				if ((target.position - base.transform.position).magnitude < pointToPointThreshold)
				{
					progressNum = (progressNum + 1) % circuit.Waypoints.Length;
				}
				target.position = circuit.Waypoints[progressNum].position;
				target.rotation = circuit.Waypoints[progressNum].rotation;
				progressPoint = circuit.GetRoutePoint(progressDistance);
				Vector3 lhs2 = progressPoint.position - base.transform.position;
				if (Vector3.Dot(lhs2, progressPoint.direction) < 0f)
				{
					progressDistance += lhs2.magnitude;
				}
				lastPosition = base.transform.position;
			}
		}

		private void OnDrawGizmos()
		{
			if (Application.isPlaying)
			{
				Gizmos.color = Color.green;
				Gizmos.DrawLine(base.transform.position, target.position);
				Gizmos.DrawWireSphere(circuit.GetRoutePosition(progressDistance), 1f);
				Gizmos.color = Color.yellow;
				Gizmos.DrawLine(target.position, target.position + target.forward);
			}
		}
	}
}
