using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyVersion("0.0.0.0")]
public class UniWebViewEventProcessor : MonoBehaviour
{
	private object _queueLock = new object();

	private List<Action> _queuedEvents = new List<Action>();

	private List<Action> _executingEvents = new List<Action>();

	private static UniWebViewEventProcessor _instance;

	public static UniWebViewEventProcessor instance
	{
		get
		{
			if (!_instance)
			{
				_instance = UnityEngine.Object.FindObjectOfType(typeof(UniWebViewEventProcessor)) as UniWebViewEventProcessor;
				if (!_instance)
				{
					GameObject obj = new GameObject("UniWebViewEventProcessor");
					UnityEngine.Object.DontDestroyOnLoad(obj);
					_instance = obj.AddComponent<UniWebViewEventProcessor>();
				}
			}
			return _instance;
		}
	}

	public void QueueEvent(Action action)
	{
		lock (_queueLock)
		{
			_queuedEvents.Add(action);
		}
	}

	private void Update()
	{
		MoveQueuedEventsToExecuting();
		while (_executingEvents.Count > 0)
		{
			Action action = _executingEvents[0];
			_executingEvents.RemoveAt(0);
			action();
		}
	}

	private void MoveQueuedEventsToExecuting()
	{
		lock (_queueLock)
		{
			while (_queuedEvents.Count > 0)
			{
				Action item = _queuedEvents[0];
				_executingEvents.Add(item);
				_queuedEvents.RemoveAt(0);
			}
		}
	}
}
public class UniWebViewPlugin
{
	private static AndroidJavaClass webView;

	public static void Init(string name, int top, int left, int bottom, int right)
	{
		Debug.Log("Unity Init");
		if (Application.platform == RuntimePlatform.Android)
		{
			webView = new AndroidJavaClass("com.onevcat.uniwebview.AndroidPlugin");
			webView.CallStatic("_UniWebViewInit", name, top, left, bottom, right);
		}
	}

	public static void ChangeInsets(string name, int top, int left, int bottom, int right)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewChangeInsets", name, top, left, bottom, right);
		}
	}

	public static void Load(string name, string url)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewLoad", name, url);
		}
	}

	public static void LoadHTMLString(string name, string htmlString, string baseUrl)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewLoadHTMLString", name, htmlString, baseUrl);
		}
	}

	public static void Reload(string name)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewReload", name);
		}
	}

	public static void Stop(string name)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewStop", name);
		}
	}

	public static void EvaluatingJavaScript(string name, string javaScript)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			Debug.Log("calling eval js " + javaScript);
			webView.CallStatic("_UniWebViewEvaluatingJavaScript", name, javaScript);
		}
	}

	public static void AddJavaScript(string name, string javaScript)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			Debug.Log("adding js " + javaScript);
			webView.CallStatic("_UniWebViewAddJavaScript", name, javaScript);
		}
	}

	public static void Show(string name, bool fade, int direction, float duration)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewShow", name, fade, direction, duration);
		}
	}

	public static void Hide(string name, bool fade, int direction, float duration)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewHide", name, fade, direction, duration);
		}
	}

	public static void CleanCache(string name)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewCleanCache", name);
		}
	}

	public static void CleanCookie(string name, string key)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewCleanCookie", name, key);
		}
	}

	public static void Destroy(string name)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewDestroy", name);
		}
	}

	public static void SetSpinnerShowWhenLoading(string name, bool show)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewSetSpinnerShowWhenLoading", name, show);
		}
	}

	public static void SetSpinnerText(string name, string text)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewSetSpinnerText", name, text);
		}
	}

	public static void TransparentBackground(string name, bool transparent)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewTransparentBackground", name, transparent);
		}
	}

	public static void SetBackgroundColor(string name, float r, float g, float b, float a)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewSetBackgroundColor", name, r, g, b, a);
		}
	}

	public static bool CanGoBack(string name)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			return webView.CallStatic<bool>("_UniWebViewCanGoBack", new object[1] { name });
		}
		return false;
	}

	public static bool CanGoForward(string name)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			return webView.CallStatic<bool>("_UniWebViewCanGoForward", new object[1] { name });
		}
		return false;
	}

	public static void GoBack(string name)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewGoBack", name);
		}
	}

	public static void GoForward(string name)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewGoForward", name);
		}
	}

	public static string GetCurrentUrl(string name)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			return webView.CallStatic<string>("_UniWebViewGetCurrentUrl", new object[1] { name });
		}
		return "";
	}

	public static void SetBackButtonEnable(string name, bool enable)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewSetBackButtonEnable", name, enable);
		}
	}

	public static void SetBounces(string name, bool enable)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewSetBounces", name, enable);
		}
	}

	public static void SetZoomEnable(string name, bool enable)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewSetZoomEnable", name, enable);
		}
	}

	public static void AddUrlScheme(string name, string scheme)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewAddUrlScheme", name, scheme);
		}
	}

	public static void RemoveUrlScheme(string name, string scheme)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewRemoveUrlScheme", name, scheme);
		}
	}

	public static void SetUseWideViewPort(string name, bool use)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewUseWideViewPort", name, use);
		}
	}

	public static void SetUserAgent(string userAgent)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewSetUserAgent", userAgent);
		}
	}

	public static string GetUserAgent(string name)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			return webView.CallStatic<string>("_UniWebViewGetUserAgent", new object[1] { name });
		}
		return "";
	}

	public static float GetAlpha(string name)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			return webView.CallStatic<float>("_UniWebViewGetAlpha", new object[1] { name });
		}
		return 0f;
	}

	public static void SetAlpha(string name, float alpha)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewSetAlpha", name, alpha);
		}
	}

	public static void SetImmersiveModeEnabled(string name, bool enabled)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewSetImmersiveModeEnabled", name, enabled);
		}
	}

	public static void AddPermissionRequestTrustSite(string name, string url)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewAddPermissionRequestTrustSite", name, url);
		}
	}

	public static void SetHeaderField(string name, string key, string value)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewSetHeaderField", name, key, value);
		}
	}

	public static void SetVerticalScrollBarShow(string name, bool show)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewSetVerticalScrollBarShow", name, show);
		}
	}

	public static void SetHorizontalScrollBarShow(string name, bool show)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewSetHorizontalScrollBarShow", name, show);
		}
	}

	public static bool GetOpenLinksInExternalBrowser(string name)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			return webView.CallStatic<bool>("_UniWebViewGetOpenLinksInExternalBrowser", new object[1] { name });
		}
		return false;
	}

	public static void SetOpenLinksInExternalBrowser(string name, bool value)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			webView.CallStatic("_UniWebViewSetOpenLinksInExternalBrowser", name, value);
		}
	}
}
namespace Valve.VR;

public struct IVRSystem
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetRecommendedRenderTargetSize(ref uint pnWidth, ref uint pnHeight);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate HmdMatrix44_t _GetProjectionMatrix(EVREye eEye, float fNearZ, float fFarZ);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetProjectionRaw(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ComputeDistortion(EVREye eEye, float fU, float fV, ref DistortionCoordinates_t pDistortionCoordinates);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate HmdMatrix34_t _GetEyeToHeadTransform(EVREye eEye);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate int _GetD3D9AdapterIndex();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetOutputDevice(ref ulong pnDevice, ETextureType textureType, IntPtr pInstance);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsDisplayOnDesktop();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _SetDisplayVisibility(bool bIsVisibleOnDesktop);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, [In][Out] TrackedDevicePose_t[] pTrackedDevicePoseArray, uint unTrackedDevicePoseArrayCount);

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
	internal delegate uint _GetArrayTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, uint propType, IntPtr pBuffer, uint unBufferSize, ref ETrackedPropertyError pError);

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
	internal delegate HiddenAreaMesh_t _GetHiddenAreaMesh(EVREye eEye, EHiddenAreaMeshType type);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetControllerState(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _TriggerHapticPulse(uint unControllerDeviceIndex, uint unAxisId, ushort usDurationMicroSec);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetButtonIdNameFromEnum(EVRButtonId eButtonId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsInputAvailable();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsSteamVRDrawingControllers();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ShouldApplicationPause();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ShouldApplicationReduceRenderingWork();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRFirmwareError _PerformFirmwareUpdate(uint unDeviceIndex);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _AcknowledgeQuit_Exiting();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetAppContainerFilePaths(StringBuilder pchBuffer, uint unBufferSize);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetRuntimeVersion();

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
	internal _GetOutputDevice GetOutputDevice;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsDisplayOnDesktop IsDisplayOnDesktop;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetDisplayVisibility SetDisplayVisibility;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetDeviceToAbsoluteTrackingPose GetDeviceToAbsoluteTrackingPose;

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
	internal _GetArrayTrackedDeviceProperty GetArrayTrackedDeviceProperty;

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
	internal _IsInputAvailable IsInputAvailable;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsSteamVRDrawingControllers IsSteamVRDrawingControllers;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShouldApplicationPause ShouldApplicationPause;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShouldApplicationReduceRenderingWork ShouldApplicationReduceRenderingWork;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PerformFirmwareUpdate PerformFirmwareUpdate;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _AcknowledgeQuit_Exiting AcknowledgeQuit_Exiting;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetAppContainerFilePaths GetAppContainerFilePaths;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetRuntimeVersion GetRuntimeVersion;
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
public struct IVRTrackedCamera
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetCameraErrorNameFromEnum(EVRTrackedCameraError eCameraError);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _HasCamera(uint nDeviceIndex, ref bool pHasCamera);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _GetCameraFrameSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref uint pnWidth, ref uint pnHeight, ref uint pnFrameBufferSize);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _GetCameraIntrinsics(uint nDeviceIndex, uint nCameraIndex, EVRTrackedCameraFrameType eFrameType, ref HmdVector2_t pFocalLength, ref HmdVector2_t pCenter);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _GetCameraProjection(uint nDeviceIndex, uint nCameraIndex, EVRTrackedCameraFrameType eFrameType, float flZNear, float flZFar, ref HmdMatrix44_t pProjection);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _AcquireVideoStreamingService(uint nDeviceIndex, ref ulong pHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _ReleaseVideoStreamingService(ulong hTrackedCamera);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _GetVideoStreamFrameBuffer(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pFrameBuffer, uint nFrameBufferSize, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _GetVideoStreamTextureSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref VRTextureBounds_t pTextureBounds, ref uint pnWidth, ref uint pnHeight);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _GetVideoStreamTextureD3D11(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _GetVideoStreamTextureGL(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, ref uint pglTextureId, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _ReleaseVideoStreamTextureGL(ulong hTrackedCamera, uint glTextureId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetCameraTrackingSpace(ETrackingUniverseOrigin eUniverse);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ETrackingUniverseOrigin _GetCameraTrackingSpace();

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCameraErrorNameFromEnum GetCameraErrorNameFromEnum;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _HasCamera HasCamera;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCameraFrameSize GetCameraFrameSize;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCameraIntrinsics GetCameraIntrinsics;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCameraProjection GetCameraProjection;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _AcquireVideoStreamingService AcquireVideoStreamingService;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReleaseVideoStreamingService ReleaseVideoStreamingService;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetVideoStreamFrameBuffer GetVideoStreamFrameBuffer;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetVideoStreamTextureSize GetVideoStreamTextureSize;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetVideoStreamTextureD3D11 GetVideoStreamTextureD3D11;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetVideoStreamTextureGL GetVideoStreamTextureGL;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReleaseVideoStreamTextureGL ReleaseVideoStreamTextureGL;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetCameraTrackingSpace SetCameraTrackingSpace;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCameraTrackingSpace GetCameraTrackingSpace;
}
public struct IVRApplications
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _AddApplicationManifest(IntPtr pchApplicationManifestFullPath, bool bTemporary);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _RemoveApplicationManifest(IntPtr pchApplicationManifestFullPath);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsApplicationInstalled(IntPtr pchAppKey);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetApplicationCount();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _GetApplicationKeyByIndex(uint unApplicationIndex, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _GetApplicationKeyByProcessId(uint unProcessId, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _LaunchApplication(IntPtr pchAppKey);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _LaunchTemplateApplication(IntPtr pchTemplateAppKey, IntPtr pchNewAppKey, [In][Out] AppOverrideKeys_t[] pKeys, uint unKeys);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _LaunchApplicationFromMimeType(IntPtr pchMimeType, IntPtr pchArgs);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _LaunchDashboardOverlay(IntPtr pchAppKey);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _CancelApplicationLaunch(IntPtr pchAppKey);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _IdentifyApplication(uint unProcessId, IntPtr pchAppKey);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetApplicationProcessId(IntPtr pchAppKey);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetApplicationsErrorNameFromEnum(EVRApplicationError error);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetApplicationPropertyString(IntPtr pchAppKey, EVRApplicationProperty eProperty, StringBuilder pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetApplicationPropertyBool(IntPtr pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ulong _GetApplicationPropertyUint64(IntPtr pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _SetApplicationAutoLaunch(IntPtr pchAppKey, bool bAutoLaunch);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetApplicationAutoLaunch(IntPtr pchAppKey);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _SetDefaultApplicationForMimeType(IntPtr pchAppKey, IntPtr pchMimeType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetDefaultApplicationForMimeType(IntPtr pchMimeType, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetApplicationSupportedMimeTypes(IntPtr pchAppKey, StringBuilder pchMimeTypesBuffer, uint unMimeTypesBuffer);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetApplicationsThatSupportMimeType(IntPtr pchMimeType, StringBuilder pchAppKeysThatSupportBuffer, uint unAppKeysThatSupportBuffer);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetApplicationLaunchArguments(uint unHandle, StringBuilder pchArgs, uint unArgs);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _GetStartingApplication(StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRSceneApplicationState _GetSceneApplicationState();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _PerformApplicationPrelaunchCheck(IntPtr pchAppKey);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetSceneApplicationStateNameFromEnum(EVRSceneApplicationState state);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _LaunchInternalProcess(IntPtr pchBinaryPath, IntPtr pchArguments, IntPtr pchWorkingDirectory);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetCurrentSceneProcessId();

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
	internal _LaunchTemplateApplication LaunchTemplateApplication;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LaunchApplicationFromMimeType LaunchApplicationFromMimeType;

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
	internal _SetDefaultApplicationForMimeType SetDefaultApplicationForMimeType;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetDefaultApplicationForMimeType GetDefaultApplicationForMimeType;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationSupportedMimeTypes GetApplicationSupportedMimeTypes;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationsThatSupportMimeType GetApplicationsThatSupportMimeType;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationLaunchArguments GetApplicationLaunchArguments;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetStartingApplication GetStartingApplication;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetSceneApplicationState GetSceneApplicationState;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PerformApplicationPrelaunchCheck PerformApplicationPrelaunchCheck;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetSceneApplicationStateNameFromEnum GetSceneApplicationStateNameFromEnum;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LaunchInternalProcess LaunchInternalProcess;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCurrentSceneProcessId GetCurrentSceneProcessId;
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

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ResetZeroPose(ETrackingUniverseOrigin eTrackingUniverseOrigin);

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

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ResetZeroPose ResetZeroPose;
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
	internal delegate void _SetWorkingPerimeter([In][Out] HmdVector2_t[] pPointBuffer, uint unPointCount);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ReloadFromDisk(EChaperoneConfigFile configFile);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ExportLiveToBuffer(StringBuilder pBuffer, ref uint pnBufferLength);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ImportFromBufferToWorking(IntPtr pBuffer, uint nImportFlags);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ShowWorkingSetPreview();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _HideWorkingSetPreview();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _RoomSetupStarting();

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
	internal _SetWorkingPerimeter SetWorkingPerimeter;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetWorkingSeatedZeroPoseToRawTrackingPose SetWorkingSeatedZeroPoseToRawTrackingPose;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetWorkingStandingZeroPoseToRawTrackingPose SetWorkingStandingZeroPoseToRawTrackingPose;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReloadFromDisk ReloadFromDisk;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLiveSeatedZeroPoseToRawTrackingPose GetLiveSeatedZeroPoseToRawTrackingPose;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ExportLiveToBuffer ExportLiveToBuffer;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ImportFromBufferToWorking ImportFromBufferToWorking;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowWorkingSetPreview ShowWorkingSetPreview;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _HideWorkingSetPreview HideWorkingSetPreview;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RoomSetupStarting RoomSetupStarting;
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
	internal delegate uint _GetFrameTimings([In][Out] Compositor_FrameTiming[] pTiming, uint nFrames);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate float _GetFrameTimeRemaining();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetCumulativeStats(ref Compositor_CumulativeStats pStats, uint nStatsSizeInBytes);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate HmdColor_t _GetCurrentFadeColor(bool bBackground);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _FadeGrid(float fSeconds, bool bFadeIn);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate float _GetCurrentGridAlpha();

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

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ForceReconnectProcess();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SuspendRendering(bool bSuspend);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _GetMirrorTextureD3D11(EVREye eEye, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ReleaseMirrorTextureD3D11(IntPtr pD3D11ShaderResourceView);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _GetMirrorTextureGL(EVREye eEye, ref uint pglTextureId, IntPtr pglSharedTextureHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ReleaseSharedGLTexture(uint glTextureId, IntPtr glSharedTextureHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _LockGLSharedTextureForAccess(IntPtr glSharedTextureHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _UnlockGLSharedTextureForAccess(IntPtr glSharedTextureHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetVulkanInstanceExtensionsRequired(StringBuilder pchValue, uint unBufferSize);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetVulkanDeviceExtensionsRequired(IntPtr pPhysicalDevice, StringBuilder pchValue, uint unBufferSize);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetExplicitTimingMode(EVRCompositorTimingMode eTimingMode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _SubmitExplicitTimingData();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsMotionSmoothingEnabled();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsMotionSmoothingSupported();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsCurrentSceneFocusAppLoading();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _SetStageOverride_Async(IntPtr pchRenderModelPath, ref HmdMatrix34_t pTransform, ref Compositor_StageRenderSettings pRenderSettings, uint nSizeOfRenderSettings);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ClearStageOverride();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetCompositorBenchmarkResults(ref Compositor_BenchmarkResults pBenchmarkResults, uint nSizeOfBenchmarkResults);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _GetLastPosePredictionIDs(ref uint pRenderPosePredictionID, ref uint pGamePosePredictionID);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _GetPosesForFrame(uint unPosePredictionID, [In][Out] TrackedDevicePose_t[] pPoseArray, uint unPoseArrayCount);

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
	internal _GetFrameTimings GetFrameTimings;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetFrameTimeRemaining GetFrameTimeRemaining;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCumulativeStats GetCumulativeStats;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _FadeToColor FadeToColor;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCurrentFadeColor GetCurrentFadeColor;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _FadeGrid FadeGrid;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCurrentGridAlpha GetCurrentGridAlpha;

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

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ForceReconnectProcess ForceReconnectProcess;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SuspendRendering SuspendRendering;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetMirrorTextureD3D11 GetMirrorTextureD3D11;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReleaseMirrorTextureD3D11 ReleaseMirrorTextureD3D11;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetMirrorTextureGL GetMirrorTextureGL;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReleaseSharedGLTexture ReleaseSharedGLTexture;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LockGLSharedTextureForAccess LockGLSharedTextureForAccess;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _UnlockGLSharedTextureForAccess UnlockGLSharedTextureForAccess;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetVulkanInstanceExtensionsRequired GetVulkanInstanceExtensionsRequired;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetVulkanDeviceExtensionsRequired GetVulkanDeviceExtensionsRequired;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetExplicitTimingMode SetExplicitTimingMode;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SubmitExplicitTimingData SubmitExplicitTimingData;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsMotionSmoothingEnabled IsMotionSmoothingEnabled;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsMotionSmoothingSupported IsMotionSmoothingSupported;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsCurrentSceneFocusAppLoading IsCurrentSceneFocusAppLoading;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetStageOverride_Async SetStageOverride_Async;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ClearStageOverride ClearStageOverride;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCompositorBenchmarkResults GetCompositorBenchmarkResults;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLastPosePredictionIDs GetLastPosePredictionIDs;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetPosesForFrame GetPosesForFrame;
}
public struct IVROverlay
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _FindOverlay(IntPtr pchOverlayKey, ref ulong pOverlayHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _CreateOverlay(IntPtr pchOverlayKey, IntPtr pchOverlayName, ref ulong pOverlayHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _DestroyOverlay(ulong ulOverlayHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetOverlayKey(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetOverlayName(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayName(ulong ulOverlayHandle, IntPtr pchName);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayImageData(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetOverlayErrorNameFromEnum(EVROverlayError error);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayRenderingPid(ulong ulOverlayHandle, uint unPID);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetOverlayRenderingPid(ulong ulOverlayHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, bool bEnabled);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, ref bool pbEnabled);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayFlags(ulong ulOverlayHandle, ref uint pFlags);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayColor(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayColor(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayAlpha(ulong ulOverlayHandle, float fAlpha);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayAlpha(ulong ulOverlayHandle, ref float pfAlpha);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTexelAspect(ulong ulOverlayHandle, float fTexelAspect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTexelAspect(ulong ulOverlayHandle, ref float pfTexelAspect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlaySortOrder(ulong ulOverlayHandle, uint unSortOrder);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlaySortOrder(ulong ulOverlayHandle, ref uint punSortOrder);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayWidthInMeters(ulong ulOverlayHandle, float fWidthInMeters);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayWidthInMeters(ulong ulOverlayHandle, ref float pfWidthInMeters);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayCurvature(ulong ulOverlayHandle, float fCurvature);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayCurvature(ulong ulOverlayHandle, ref float pfCurvature);

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
	internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, uint unDeviceIndex, IntPtr pchComponentName);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, ref uint punDeviceIndex, StringBuilder pchComponentName, uint unComponentNameSize);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ref ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTransformCursor(ulong ulCursorOverlayHandle, ref HmdVector2_t pvHotspot);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTransformCursor(ulong ulOverlayHandle, ref HmdVector2_t pvHotspot);

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
	internal delegate bool _IsHoverTargetOverlay(ulong ulOverlayHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayIntersectionMask(ulong ulOverlayHandle, ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives, uint unNumMaskPrimitives, uint unPrimitiveSize);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _TriggerLaserMouseHapticVibration(ulong ulOverlayHandle, float fDurationSeconds, float fFrequency, float fAmplitude);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayCursor(ulong ulOverlayHandle, ulong ulCursorHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayCursorPositionOverride(ulong ulOverlayHandle, ref HmdVector2_t pvCursor);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _ClearOverlayCursorPositionOverride(ulong ulOverlayHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _ClearOverlayTexture(ulong ulOverlayHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayRaw(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unBytesPerPixel);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayFromFile(ulong ulOverlayHandle, IntPtr pchFilePath);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTexture(ulong ulOverlayHandle, ref IntPtr pNativeTextureHandle, IntPtr pNativeTextureRef, ref uint pWidth, ref uint pHeight, ref uint pNativeFormat, ref ETextureType pAPIType, ref EColorSpace pColorSpace, ref VRTextureBounds_t pTextureBounds);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _ReleaseNativeOverlayHandle(ulong ulOverlayHandle, IntPtr pNativeTextureHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTextureSize(ulong ulOverlayHandle, ref uint pWidth, ref uint pHeight);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _CreateDashboardOverlay(IntPtr pchOverlayKey, IntPtr pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsDashboardVisible();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsActiveDashboardOverlay(ulong ulOverlayHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetDashboardOverlaySceneProcess(ulong ulOverlayHandle, uint unProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetDashboardOverlaySceneProcess(ulong ulOverlayHandle, ref uint punProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ShowDashboard(IntPtr pchOverlayToShow);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetPrimaryDashboardDevice();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _ShowKeyboard(int eInputMode, int eLineInputMode, uint unFlags, IntPtr pchDescription, uint unCharMax, IntPtr pchExistingText, ulong uUserValue);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _ShowKeyboardForOverlay(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, uint unFlags, IntPtr pchDescription, uint unCharMax, IntPtr pchExistingText, ulong uUserValue);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetKeyboardText(StringBuilder pchText, uint cchText);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _HideKeyboard();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetKeyboardPositionForOverlay(ulong ulOverlayHandle, HmdRect2_t avoidRect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate VRMessageOverlayResponse _ShowMessageOverlay(IntPtr pchText, IntPtr pchCaption, IntPtr pchButton0Text, IntPtr pchButton1Text, IntPtr pchButton2Text, IntPtr pchButton3Text);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _CloseMessageOverlay();

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _FindOverlay FindOverlay;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CreateOverlay CreateOverlay;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _DestroyOverlay DestroyOverlay;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayKey GetOverlayKey;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayName GetOverlayName;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayName SetOverlayName;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayImageData GetOverlayImageData;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayErrorNameFromEnum GetOverlayErrorNameFromEnum;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayRenderingPid SetOverlayRenderingPid;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayRenderingPid GetOverlayRenderingPid;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayFlag SetOverlayFlag;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayFlag GetOverlayFlag;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayFlags GetOverlayFlags;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayColor SetOverlayColor;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayColor GetOverlayColor;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayAlpha SetOverlayAlpha;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayAlpha GetOverlayAlpha;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTexelAspect SetOverlayTexelAspect;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTexelAspect GetOverlayTexelAspect;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlaySortOrder SetOverlaySortOrder;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlaySortOrder GetOverlaySortOrder;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayWidthInMeters SetOverlayWidthInMeters;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayWidthInMeters GetOverlayWidthInMeters;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayCurvature SetOverlayCurvature;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayCurvature GetOverlayCurvature;

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
	internal _GetOverlayTransformOverlayRelative GetOverlayTransformOverlayRelative;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTransformOverlayRelative SetOverlayTransformOverlayRelative;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTransformCursor SetOverlayTransformCursor;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTransformCursor GetOverlayTransformCursor;

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
	internal _IsHoverTargetOverlay IsHoverTargetOverlay;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayIntersectionMask SetOverlayIntersectionMask;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _TriggerLaserMouseHapticVibration TriggerLaserMouseHapticVibration;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayCursor SetOverlayCursor;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayCursorPositionOverride SetOverlayCursorPositionOverride;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ClearOverlayCursorPositionOverride ClearOverlayCursorPositionOverride;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTexture SetOverlayTexture;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ClearOverlayTexture ClearOverlayTexture;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayRaw SetOverlayRaw;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayFromFile SetOverlayFromFile;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTexture GetOverlayTexture;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReleaseNativeOverlayHandle ReleaseNativeOverlayHandle;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTextureSize GetOverlayTextureSize;

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

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowMessageOverlay ShowMessageOverlay;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CloseMessageOverlay CloseMessageOverlay;
}
public struct IVROverlayView
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _AcquireOverlayView(ulong ulOverlayHandle, ref VRNativeDevice_t pNativeDevice, ref VROverlayView_t pOverlayView, uint unOverlayViewSize);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _ReleaseOverlayView(ref VROverlayView_t pOverlayView);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _PostOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pvrEvent);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsViewingPermitted(ulong ulOverlayHandle);

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _AcquireOverlayView AcquireOverlayView;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReleaseOverlayView ReleaseOverlayView;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PostOverlayEvent PostOverlayEvent;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsViewingPermitted IsViewingPermitted;
}
public struct IVRHeadsetView
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetHeadsetViewSize(uint nWidth, uint nHeight);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetHeadsetViewSize(ref uint pnWidth, ref uint pnHeight);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetHeadsetViewMode(uint eHeadsetViewMode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetHeadsetViewMode();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetHeadsetViewCropped(bool bCropped);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetHeadsetViewCropped();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate float _GetHeadsetViewAspectRatio();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetHeadsetViewBlendRange(float flStartPct, float flEndPct);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetHeadsetViewBlendRange(ref float pStartPct, ref float pEndPct);

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetHeadsetViewSize SetHeadsetViewSize;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetHeadsetViewSize GetHeadsetViewSize;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetHeadsetViewMode SetHeadsetViewMode;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetHeadsetViewMode GetHeadsetViewMode;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetHeadsetViewCropped SetHeadsetViewCropped;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetHeadsetViewCropped GetHeadsetViewCropped;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetHeadsetViewAspectRatio GetHeadsetViewAspectRatio;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetHeadsetViewBlendRange SetHeadsetViewBlendRange;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetHeadsetViewBlendRange GetHeadsetViewBlendRange;
}
public struct IVRRenderModels
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRRenderModelError _LoadRenderModel_Async(IntPtr pchRenderModelName, ref IntPtr ppRenderModel);

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
	internal delegate uint _GetComponentCount(IntPtr pchRenderModelName);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetComponentName(IntPtr pchRenderModelName, uint unComponentIndex, StringBuilder pchComponentName, uint unComponentNameLen);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ulong _GetComponentButtonMask(IntPtr pchRenderModelName, IntPtr pchComponentName);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetComponentRenderModelName(IntPtr pchRenderModelName, IntPtr pchComponentName, StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetComponentStateForDevicePath(IntPtr pchRenderModelName, IntPtr pchComponentName, ulong devicePath, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetComponentState(IntPtr pchRenderModelName, IntPtr pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _RenderModelHasComponent(IntPtr pchRenderModelName, IntPtr pchComponentName);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetRenderModelThumbnailURL(IntPtr pchRenderModelName, StringBuilder pchThumbnailURL, uint unThumbnailURLLen, ref EVRRenderModelError peError);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetRenderModelOriginalPath(IntPtr pchRenderModelName, StringBuilder pchOriginalPath, uint unOriginalPathLen, ref EVRRenderModelError peError);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetRenderModelErrorNameFromEnum(EVRRenderModelError error);

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
	internal _GetComponentStateForDevicePath GetComponentStateForDevicePath;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetComponentState GetComponentState;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RenderModelHasComponent RenderModelHasComponent;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetRenderModelThumbnailURL GetRenderModelThumbnailURL;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetRenderModelOriginalPath GetRenderModelOriginalPath;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetRenderModelErrorNameFromEnum GetRenderModelErrorNameFromEnum;
}
public struct IVRNotifications
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRNotificationError _CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, IntPtr pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId);

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
	internal delegate void _SetBool(IntPtr pchSection, IntPtr pchSettingsKey, bool bValue, ref EVRSettingsError peError);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetInt32(IntPtr pchSection, IntPtr pchSettingsKey, int nValue, ref EVRSettingsError peError);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetFloat(IntPtr pchSection, IntPtr pchSettingsKey, float flValue, ref EVRSettingsError peError);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetString(IntPtr pchSection, IntPtr pchSettingsKey, IntPtr pchValue, ref EVRSettingsError peError);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetBool(IntPtr pchSection, IntPtr pchSettingsKey, ref EVRSettingsError peError);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate int _GetInt32(IntPtr pchSection, IntPtr pchSettingsKey, ref EVRSettingsError peError);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate float _GetFloat(IntPtr pchSection, IntPtr pchSettingsKey, ref EVRSettingsError peError);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetString(IntPtr pchSection, IntPtr pchSettingsKey, StringBuilder pchValue, uint unValueLen, ref EVRSettingsError peError);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _RemoveSection(IntPtr pchSection, ref EVRSettingsError peError);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _RemoveKeyInSection(IntPtr pchSection, IntPtr pchSettingsKey, ref EVRSettingsError peError);

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetSettingsErrorNameFromEnum GetSettingsErrorNameFromEnum;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetBool SetBool;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetInt32 SetInt32;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetFloat SetFloat;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetString SetString;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetBool GetBool;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetInt32 GetInt32;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetFloat GetFloat;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetString GetString;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RemoveSection RemoveSection;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RemoveKeyInSection RemoveKeyInSection;
}
public struct IVRScreenshots
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRScreenshotError _RequestScreenshot(ref uint pOutScreenshotHandle, EVRScreenshotType type, IntPtr pchPreviewFilename, IntPtr pchVRFilename);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRScreenshotError _HookScreenshot([In][Out] EVRScreenshotType[] pSupportedTypes, int numTypes);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRScreenshotType _GetScreenshotPropertyType(uint screenshotHandle, ref EVRScreenshotError pError);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetScreenshotPropertyFilename(uint screenshotHandle, EVRScreenshotPropertyFilenames filenameType, StringBuilder pchFilename, uint cchFilename, ref EVRScreenshotError pError);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRScreenshotError _UpdateScreenshotProgress(uint screenshotHandle, float flProgress);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRScreenshotError _TakeStereoScreenshot(ref uint pOutScreenshotHandle, IntPtr pchPreviewFilename, IntPtr pchVRFilename);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRScreenshotError _SubmitScreenshot(uint screenshotHandle, EVRScreenshotType type, IntPtr pchSourcePreviewFilename, IntPtr pchSourceVRFilename);

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RequestScreenshot RequestScreenshot;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _HookScreenshot HookScreenshot;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetScreenshotPropertyType GetScreenshotPropertyType;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetScreenshotPropertyFilename GetScreenshotPropertyFilename;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _UpdateScreenshotProgress UpdateScreenshotProgress;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _TakeStereoScreenshot TakeStereoScreenshot;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SubmitScreenshot SubmitScreenshot;
}
public struct IVRResources
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _LoadSharedResource(IntPtr pchResourceName, string pchBuffer, uint unBufferLen);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetResourceFullPath(IntPtr pchResourceName, IntPtr pchResourceTypeDirectory, StringBuilder pchPathBuffer, uint unBufferLen);

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LoadSharedResource LoadSharedResource;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetResourceFullPath GetResourceFullPath;
}
public struct IVRDriverManager
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetDriverCount();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetDriverName(uint nDriver, StringBuilder pchValue, uint unBufferSize);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ulong _GetDriverHandle(IntPtr pchDriverName);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsEnabled(uint nDriver);

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetDriverCount GetDriverCount;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetDriverName GetDriverName;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetDriverHandle GetDriverHandle;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsEnabled IsEnabled;
}
public struct IVRInput
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _SetActionManifestPath(IntPtr pchActionManifestPath);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetActionSetHandle(IntPtr pchActionSetName, ref ulong pHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetActionHandle(IntPtr pchActionName, ref ulong pHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetInputSourceHandle(IntPtr pchInputSourcePath, ref ulong pHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _UpdateActionState([In][Out] VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t, uint unSetCount);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetDigitalActionData(ulong action, ref InputDigitalActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetAnalogActionData(ulong action, ref InputAnalogActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetPoseActionDataRelativeToNow(ulong action, ETrackingUniverseOrigin eOrigin, float fPredictedSecondsFromNow, ref InputPoseActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetPoseActionDataForNextFrame(ulong action, ETrackingUniverseOrigin eOrigin, ref InputPoseActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetSkeletalActionData(ulong action, ref InputSkeletalActionData_t pActionData, uint unActionDataSize);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetDominantHand(ref ETrackedControllerRole peDominantHand);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _SetDominantHand(ETrackedControllerRole eDominantHand);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetBoneCount(ulong action, ref uint pBoneCount);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetBoneHierarchy(ulong action, [In][Out] int[] pParentIndices, uint unIndexArayCount);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetBoneName(ulong action, int nBoneIndex, StringBuilder pchBoneName, uint unNameBufferSize);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetSkeletalReferenceTransforms(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalReferencePose eReferencePose, [In][Out] VRBoneTransform_t[] pTransformArray, uint unTransformArrayCount);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetSkeletalTrackingLevel(ulong action, ref EVRSkeletalTrackingLevel pSkeletalTrackingLevel);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetSkeletalBoneData(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalMotionRange eMotionRange, [In][Out] VRBoneTransform_t[] pTransformArray, uint unTransformArrayCount);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetSkeletalSummaryData(ulong action, EVRSummaryType eSummaryType, ref VRSkeletalSummaryData_t pSkeletalSummaryData);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetSkeletalBoneDataCompressed(ulong action, EVRSkeletalMotionRange eMotionRange, IntPtr pvCompressedData, uint unCompressedSize, ref uint punRequiredCompressedSize);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _DecompressSkeletalBoneData(IntPtr pvCompressedBuffer, uint unCompressedBufferSize, EVRSkeletalTransformSpace eTransformSpace, [In][Out] VRBoneTransform_t[] pTransformArray, uint unTransformArrayCount);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _TriggerHapticVibrationAction(ulong action, float fStartSecondsFromNow, float fDurationSeconds, float fFrequency, float fAmplitude, ulong ulRestrictToDevice);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetActionOrigins(ulong actionSetHandle, ulong digitalActionHandle, [In][Out] ulong[] originsOut, uint originOutCount);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetOriginLocalizedName(ulong origin, StringBuilder pchNameArray, uint unNameArraySize, int unStringSectionsToInclude);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetOriginTrackedDeviceInfo(ulong origin, ref InputOriginInfo_t pOriginInfo, uint unOriginInfoSize);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetActionBindingInfo(ulong action, ref InputBindingInfo_t pOriginInfo, uint unBindingInfoSize, uint unBindingInfoCount, ref uint punReturnedBindingInfoCount);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _ShowActionOrigins(ulong actionSetHandle, ulong ulActionHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _ShowBindingsForActionSet([In][Out] VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t, uint unSetCount, ulong originToHighlight);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetComponentStateForBinding(IntPtr pchRenderModelName, IntPtr pchComponentName, ref InputBindingInfo_t pOriginInfo, uint unBindingInfoSize, uint unBindingInfoCount, ref RenderModel_ComponentState_t pComponentState);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsUsingLegacyInput();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _OpenBindingUI(IntPtr pchAppKey, ulong ulActionSetHandle, ulong ulDeviceHandle, bool bShowOnDesktop);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRInputError _GetBindingVariant(ulong ulDevicePath, StringBuilder pchVariantArray, uint unVariantArraySize);

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetActionManifestPath SetActionManifestPath;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetActionSetHandle GetActionSetHandle;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetActionHandle GetActionHandle;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetInputSourceHandle GetInputSourceHandle;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _UpdateActionState UpdateActionState;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetDigitalActionData GetDigitalActionData;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetAnalogActionData GetAnalogActionData;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetPoseActionDataRelativeToNow GetPoseActionDataRelativeToNow;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetPoseActionDataForNextFrame GetPoseActionDataForNextFrame;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetSkeletalActionData GetSkeletalActionData;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetDominantHand GetDominantHand;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetDominantHand SetDominantHand;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetBoneCount GetBoneCount;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetBoneHierarchy GetBoneHierarchy;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetBoneName GetBoneName;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetSkeletalReferenceTransforms GetSkeletalReferenceTransforms;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetSkeletalTrackingLevel GetSkeletalTrackingLevel;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetSkeletalBoneData GetSkeletalBoneData;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetSkeletalSummaryData GetSkeletalSummaryData;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetSkeletalBoneDataCompressed GetSkeletalBoneDataCompressed;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _DecompressSkeletalBoneData DecompressSkeletalBoneData;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _TriggerHapticVibrationAction TriggerHapticVibrationAction;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetActionOrigins GetActionOrigins;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOriginLocalizedName GetOriginLocalizedName;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOriginTrackedDeviceInfo GetOriginTrackedDeviceInfo;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetActionBindingInfo GetActionBindingInfo;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowActionOrigins ShowActionOrigins;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowBindingsForActionSet ShowBindingsForActionSet;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetComponentStateForBinding GetComponentStateForBinding;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsUsingLegacyInput IsUsingLegacyInput;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _OpenBindingUI OpenBindingUI;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetBindingVariant GetBindingVariant;
}
public struct IVRIOBuffer
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EIOBufferError _Open(IntPtr pchPath, EIOBufferMode mode, uint unElementSize, uint unElements, ref ulong pulBuffer);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EIOBufferError _Close(ulong ulBuffer);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EIOBufferError _Read(ulong ulBuffer, IntPtr pDst, uint unBytes, ref uint punRead);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EIOBufferError _Write(ulong ulBuffer, IntPtr pSrc, uint unBytes);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ulong _PropertyContainer(ulong ulBuffer);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _HasReaders(ulong ulBuffer);

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _Open Open;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _Close Close;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _Read Read;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _Write Write;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PropertyContainer PropertyContainer;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _HasReaders HasReaders;
}
public struct IVRSpatialAnchors
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRSpatialAnchorError _CreateSpatialAnchorFromDescriptor(IntPtr pchDescriptor, ref uint pHandleOut);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRSpatialAnchorError _CreateSpatialAnchorFromPose(uint unDeviceIndex, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPose, ref uint pHandleOut);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRSpatialAnchorError _GetSpatialAnchorPose(uint unHandle, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPoseOut);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRSpatialAnchorError _GetSpatialAnchorDescriptor(uint unHandle, StringBuilder pchDescriptorOut, ref uint punDescriptorBufferLenInOut);

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CreateSpatialAnchorFromDescriptor CreateSpatialAnchorFromDescriptor;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CreateSpatialAnchorFromPose CreateSpatialAnchorFromPose;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetSpatialAnchorPose GetSpatialAnchorPose;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetSpatialAnchorDescriptor GetSpatialAnchorDescriptor;
}
public struct IVRDebug
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRDebugError _EmitVrProfilerEvent(IntPtr pchMessage);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRDebugError _BeginVrProfilerEvent(ref ulong pHandleOut);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRDebugError _FinishVrProfilerEvent(ulong hHandle, IntPtr pchMessage);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _DriverDebugRequest(uint unDeviceIndex, IntPtr pchRequest, StringBuilder pchResponseBuffer, uint unResponseBufferSize);

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _EmitVrProfilerEvent EmitVrProfilerEvent;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _BeginVrProfilerEvent BeginVrProfilerEvent;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _FinishVrProfilerEvent FinishVrProfilerEvent;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _DriverDebugRequest DriverDebugRequest;
}
public struct IVRProperties
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ETrackedPropertyError _ReadPropertyBatch(ulong ulContainerHandle, ref PropertyRead_t pBatch, uint unBatchEntryCount);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ETrackedPropertyError _WritePropertyBatch(ulong ulContainerHandle, ref PropertyWrite_t pBatch, uint unBatchEntryCount);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetPropErrorNameFromEnum(ETrackedPropertyError error);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ulong _TrackedDeviceToPropertyContainer(uint nDevice);

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReadPropertyBatch ReadPropertyBatch;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _WritePropertyBatch WritePropertyBatch;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetPropErrorNameFromEnum GetPropErrorNameFromEnum;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _TrackedDeviceToPropertyContainer TrackedDeviceToPropertyContainer;
}
public struct IVRPaths
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ETrackedPropertyError _ReadPathBatch(ulong ulRootHandle, ref PathRead_t pBatch, uint unBatchEntryCount);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ETrackedPropertyError _WritePathBatch(ulong ulRootHandle, ref PathWrite_t pBatch, uint unBatchEntryCount);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ETrackedPropertyError _StringToHandle(ref ulong pHandle, IntPtr pchPath);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ETrackedPropertyError _HandleToString(ulong pHandle, string pchBuffer, uint unBufferSize, ref uint punBufferSizeUsed);

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReadPathBatch ReadPathBatch;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _WritePathBatch WritePathBatch;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _StringToHandle StringToHandle;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _HandleToString HandleToString;
}
public struct IVRBlockQueue
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EBlockQueueError _Create(ref ulong pulQueueHandle, IntPtr pchPath, uint unBlockDataSize, uint unBlockHeaderSize, uint unBlockCount);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EBlockQueueError _Connect(ref ulong pulQueueHandle, IntPtr pchPath);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EBlockQueueError _Destroy(ulong ulQueueHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EBlockQueueError _AcquireWriteOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EBlockQueueError _ReleaseWriteOnlyBlock(ulong ulQueueHandle, ulong ulBlockHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EBlockQueueError _WaitAndAcquireReadOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer, EBlockQueueReadType eReadType, uint unTimeoutMs);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EBlockQueueError _AcquireReadOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer, EBlockQueueReadType eReadType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EBlockQueueError _ReleaseReadOnlyBlock(ulong ulQueueHandle, ulong ulBlockHandle);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EBlockQueueError _QueueHasReader(ulong ulQueueHandle, ref bool pbHasReaders);

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _Create Create;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _Connect Connect;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _Destroy Destroy;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _AcquireWriteOnlyBlock AcquireWriteOnlyBlock;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReleaseWriteOnlyBlock ReleaseWriteOnlyBlock;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _WaitAndAcquireReadOnlyBlock WaitAndAcquireReadOnlyBlock;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _AcquireReadOnlyBlock AcquireReadOnlyBlock;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReleaseReadOnlyBlock ReleaseReadOnlyBlock;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _QueueHasReader QueueHasReader;
}
public class Utils
{
	private static byte[] buffer = new byte[1024];

	public static IntPtr ToUtf8(string managedString)
	{
		if (managedString == null)
		{
			return IntPtr.Zero;
		}
		int num = Encoding.UTF8.GetByteCount(managedString) + 1;
		if (buffer.Length < num)
		{
			buffer = new byte[num];
		}
		int bytes = Encoding.UTF8.GetBytes(managedString, 0, managedString.Length, buffer, 0);
		buffer[bytes] = 0;
		IntPtr intPtr = Marshal.AllocHGlobal(bytes + 1);
		Marshal.Copy(buffer, 0, intPtr, bytes + 1);
		return intPtr;
	}
}
public class CVRSystem
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _PollNextEventPacked(ref VREvent_t_Packed pEvent, uint uncbVREvent);

	[StructLayout(LayoutKind.Explicit)]
	private struct PollNextEventUnion
	{
		[FieldOffset(0)]
		public IVRSystem._PollNextEvent pPollNextEvent;

		[FieldOffset(0)]
		public _PollNextEventPacked pPollNextEventPacked;
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetControllerStatePacked(uint unControllerDeviceIndex, ref VRControllerState_t_Packed pControllerState, uint unControllerStateSize);

	[StructLayout(LayoutKind.Explicit)]
	private struct GetControllerStateUnion
	{
		[FieldOffset(0)]
		public IVRSystem._GetControllerState pGetControllerState;

		[FieldOffset(0)]
		public _GetControllerStatePacked pGetControllerStatePacked;
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetControllerStateWithPosePacked(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t_Packed pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose);

	[StructLayout(LayoutKind.Explicit)]
	private struct GetControllerStateWithPoseUnion
	{
		[FieldOffset(0)]
		public IVRSystem._GetControllerStateWithPose pGetControllerStateWithPose;

		[FieldOffset(0)]
		public _GetControllerStateWithPosePacked pGetControllerStateWithPosePacked;
	}

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

	public HmdMatrix44_t GetProjectionMatrix(EVREye eEye, float fNearZ, float fFarZ)
	{
		return FnTable.GetProjectionMatrix(eEye, fNearZ, fFarZ);
	}

	public void GetProjectionRaw(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom)
	{
		pfLeft = 0f;
		pfRight = 0f;
		pfTop = 0f;
		pfBottom = 0f;
		FnTable.GetProjectionRaw(eEye, ref pfLeft, ref pfRight, ref pfTop, ref pfBottom);
	}

	public bool ComputeDistortion(EVREye eEye, float fU, float fV, ref DistortionCoordinates_t pDistortionCoordinates)
	{
		return FnTable.ComputeDistortion(eEye, fU, fV, ref pDistortionCoordinates);
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

	public void GetOutputDevice(ref ulong pnDevice, ETextureType textureType, IntPtr pInstance)
	{
		pnDevice = 0uL;
		FnTable.GetOutputDevice(ref pnDevice, textureType, pInstance);
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

	public uint GetArrayTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, uint propType, IntPtr pBuffer, uint unBufferSize, ref ETrackedPropertyError pError)
	{
		return FnTable.GetArrayTrackedDeviceProperty(unDeviceIndex, prop, propType, pBuffer, unBufferSize, ref pError);
	}

	public uint GetStringTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError)
	{
		return FnTable.GetStringTrackedDeviceProperty(unDeviceIndex, prop, pchValue, unBufferSize, ref pError);
	}

	public string GetPropErrorNameFromEnum(ETrackedPropertyError error)
	{
		return Marshal.PtrToStringAnsi(FnTable.GetPropErrorNameFromEnum(error));
	}

	public bool PollNextEvent(ref VREvent_t pEvent, uint uncbVREvent)
	{
		if (Environment.OSVersion.Platform == PlatformID.MacOSX || Environment.OSVersion.Platform == PlatformID.Unix)
		{
			VREvent_t_Packed pEvent2 = default(VREvent_t_Packed);
			PollNextEventUnion pollNextEventUnion = default(PollNextEventUnion);
			pollNextEventUnion.pPollNextEventPacked = null;
			pollNextEventUnion.pPollNextEvent = FnTable.PollNextEvent;
			bool result = pollNextEventUnion.pPollNextEventPacked(ref pEvent2, (uint)Marshal.SizeOf(typeof(VREvent_t_Packed)));
			pEvent2.Unpack(ref pEvent);
			return result;
		}
		return FnTable.PollNextEvent(ref pEvent, uncbVREvent);
	}

	public bool PollNextEventWithPose(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose)
	{
		return FnTable.PollNextEventWithPose(eOrigin, ref pEvent, uncbVREvent, ref pTrackedDevicePose);
	}

	public string GetEventTypeNameFromEnum(EVREventType eType)
	{
		return Marshal.PtrToStringAnsi(FnTable.GetEventTypeNameFromEnum(eType));
	}

	public HiddenAreaMesh_t GetHiddenAreaMesh(EVREye eEye, EHiddenAreaMeshType type)
	{
		return FnTable.GetHiddenAreaMesh(eEye, type);
	}

	public bool GetControllerState(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize)
	{
		if (Environment.OSVersion.Platform == PlatformID.MacOSX || Environment.OSVersion.Platform == PlatformID.Unix)
		{
			VRControllerState_t_Packed pControllerState2 = new VRControllerState_t_Packed(pControllerState);
			GetControllerStateUnion getControllerStateUnion = default(GetControllerStateUnion);
			getControllerStateUnion.pGetControllerStatePacked = null;
			getControllerStateUnion.pGetControllerState = FnTable.GetControllerState;
			bool result = getControllerStateUnion.pGetControllerStatePacked(unControllerDeviceIndex, ref pControllerState2, (uint)Marshal.SizeOf(typeof(VRControllerState_t_Packed)));
			pControllerState2.Unpack(ref pControllerState);
			return result;
		}
		return FnTable.GetControllerState(unControllerDeviceIndex, ref pControllerState, unControllerStateSize);
	}

	public bool GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose)
	{
		if (Environment.OSVersion.Platform == PlatformID.MacOSX || Environment.OSVersion.Platform == PlatformID.Unix)
		{
			VRControllerState_t_Packed pControllerState2 = new VRControllerState_t_Packed(pControllerState);
			GetControllerStateWithPoseUnion getControllerStateWithPoseUnion = default(GetControllerStateWithPoseUnion);
			getControllerStateWithPoseUnion.pGetControllerStateWithPosePacked = null;
			getControllerStateWithPoseUnion.pGetControllerStateWithPose = FnTable.GetControllerStateWithPose;
			bool result = getControllerStateWithPoseUnion.pGetControllerStateWithPosePacked(eOrigin, unControllerDeviceIndex, ref pControllerState2, (uint)Marshal.SizeOf(typeof(VRControllerState_t_Packed)), ref pTrackedDevicePose);
			pControllerState2.Unpack(ref pControllerState);
			return result;
		}
		return FnTable.GetControllerStateWithPose(eOrigin, unControllerDeviceIndex, ref pControllerState, unControllerStateSize, ref pTrackedDevicePose);
	}

	public void TriggerHapticPulse(uint unControllerDeviceIndex, uint unAxisId, ushort usDurationMicroSec)
	{
		FnTable.TriggerHapticPulse(unControllerDeviceIndex, unAxisId, usDurationMicroSec);
	}

	public string GetButtonIdNameFromEnum(EVRButtonId eButtonId)
	{
		return Marshal.PtrToStringAnsi(FnTable.GetButtonIdNameFromEnum(eButtonId));
	}

	public string GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType)
	{
		return Marshal.PtrToStringAnsi(FnTable.GetControllerAxisTypeNameFromEnum(eAxisType));
	}

	public bool IsInputAvailable()
	{
		return FnTable.IsInputAvailable();
	}

	public bool IsSteamVRDrawingControllers()
	{
		return FnTable.IsSteamVRDrawingControllers();
	}

	public bool ShouldApplicationPause()
	{
		return FnTable.ShouldApplicationPause();
	}

	public bool ShouldApplicationReduceRenderingWork()
	{
		return FnTable.ShouldApplicationReduceRenderingWork();
	}

	public EVRFirmwareError PerformFirmwareUpdate(uint unDeviceIndex)
	{
		return FnTable.PerformFirmwareUpdate(unDeviceIndex);
	}

	public void AcknowledgeQuit_Exiting()
	{
		FnTable.AcknowledgeQuit_Exiting();
	}

	public uint GetAppContainerFilePaths(StringBuilder pchBuffer, uint unBufferSize)
	{
		return FnTable.GetAppContainerFilePaths(pchBuffer, unBufferSize);
	}

	public string GetRuntimeVersion()
	{
		return Marshal.PtrToStringAnsi(FnTable.GetRuntimeVersion());
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
public class CVRTrackedCamera
{
	private IVRTrackedCamera FnTable;

	internal CVRTrackedCamera(IntPtr pInterface)
	{
		FnTable = (IVRTrackedCamera)Marshal.PtrToStructure(pInterface, typeof(IVRTrackedCamera));
	}

	public string GetCameraErrorNameFromEnum(EVRTrackedCameraError eCameraError)
	{
		return Marshal.PtrToStringAnsi(FnTable.GetCameraErrorNameFromEnum(eCameraError));
	}

	public EVRTrackedCameraError HasCamera(uint nDeviceIndex, ref bool pHasCamera)
	{
		pHasCamera = false;
		return FnTable.HasCamera(nDeviceIndex, ref pHasCamera);
	}

	public EVRTrackedCameraError GetCameraFrameSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref uint pnWidth, ref uint pnHeight, ref uint pnFrameBufferSize)
	{
		pnWidth = 0u;
		pnHeight = 0u;
		pnFrameBufferSize = 0u;
		return FnTable.GetCameraFrameSize(nDeviceIndex, eFrameType, ref pnWidth, ref pnHeight, ref pnFrameBufferSize);
	}

	public EVRTrackedCameraError GetCameraIntrinsics(uint nDeviceIndex, uint nCameraIndex, EVRTrackedCameraFrameType eFrameType, ref HmdVector2_t pFocalLength, ref HmdVector2_t pCenter)
	{
		return FnTable.GetCameraIntrinsics(nDeviceIndex, nCameraIndex, eFrameType, ref pFocalLength, ref pCenter);
	}

	public EVRTrackedCameraError GetCameraProjection(uint nDeviceIndex, uint nCameraIndex, EVRTrackedCameraFrameType eFrameType, float flZNear, float flZFar, ref HmdMatrix44_t pProjection)
	{
		return FnTable.GetCameraProjection(nDeviceIndex, nCameraIndex, eFrameType, flZNear, flZFar, ref pProjection);
	}

	public EVRTrackedCameraError AcquireVideoStreamingService(uint nDeviceIndex, ref ulong pHandle)
	{
		pHandle = 0uL;
		return FnTable.AcquireVideoStreamingService(nDeviceIndex, ref pHandle);
	}

	public EVRTrackedCameraError ReleaseVideoStreamingService(ulong hTrackedCamera)
	{
		return FnTable.ReleaseVideoStreamingService(hTrackedCamera);
	}

	public EVRTrackedCameraError GetVideoStreamFrameBuffer(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pFrameBuffer, uint nFrameBufferSize, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize)
	{
		return FnTable.GetVideoStreamFrameBuffer(hTrackedCamera, eFrameType, pFrameBuffer, nFrameBufferSize, ref pFrameHeader, nFrameHeaderSize);
	}

	public EVRTrackedCameraError GetVideoStreamTextureSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref VRTextureBounds_t pTextureBounds, ref uint pnWidth, ref uint pnHeight)
	{
		pnWidth = 0u;
		pnHeight = 0u;
		return FnTable.GetVideoStreamTextureSize(nDeviceIndex, eFrameType, ref pTextureBounds, ref pnWidth, ref pnHeight);
	}

	public EVRTrackedCameraError GetVideoStreamTextureD3D11(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize)
	{
		return FnTable.GetVideoStreamTextureD3D11(hTrackedCamera, eFrameType, pD3D11DeviceOrResource, ref ppD3D11ShaderResourceView, ref pFrameHeader, nFrameHeaderSize);
	}

	public EVRTrackedCameraError GetVideoStreamTextureGL(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, ref uint pglTextureId, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize)
	{
		pglTextureId = 0u;
		return FnTable.GetVideoStreamTextureGL(hTrackedCamera, eFrameType, ref pglTextureId, ref pFrameHeader, nFrameHeaderSize);
	}

	public EVRTrackedCameraError ReleaseVideoStreamTextureGL(ulong hTrackedCamera, uint glTextureId)
	{
		return FnTable.ReleaseVideoStreamTextureGL(hTrackedCamera, glTextureId);
	}

	public void SetCameraTrackingSpace(ETrackingUniverseOrigin eUniverse)
	{
		FnTable.SetCameraTrackingSpace(eUniverse);
	}

	public ETrackingUniverseOrigin GetCameraTrackingSpace()
	{
		return FnTable.GetCameraTrackingSpace();
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
		IntPtr intPtr = Utils.ToUtf8(pchApplicationManifestFullPath);
		EVRApplicationError result = FnTable.AddApplicationManifest(intPtr, bTemporary);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public EVRApplicationError RemoveApplicationManifest(string pchApplicationManifestFullPath)
	{
		IntPtr intPtr = Utils.ToUtf8(pchApplicationManifestFullPath);
		EVRApplicationError result = FnTable.RemoveApplicationManifest(intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public bool IsApplicationInstalled(string pchAppKey)
	{
		IntPtr intPtr = Utils.ToUtf8(pchAppKey);
		bool result = FnTable.IsApplicationInstalled(intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public uint GetApplicationCount()
	{
		return FnTable.GetApplicationCount();
	}

	public EVRApplicationError GetApplicationKeyByIndex(uint unApplicationIndex, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen)
	{
		return FnTable.GetApplicationKeyByIndex(unApplicationIndex, pchAppKeyBuffer, unAppKeyBufferLen);
	}

	public EVRApplicationError GetApplicationKeyByProcessId(uint unProcessId, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen)
	{
		return FnTable.GetApplicationKeyByProcessId(unProcessId, pchAppKeyBuffer, unAppKeyBufferLen);
	}

	public EVRApplicationError LaunchApplication(string pchAppKey)
	{
		IntPtr intPtr = Utils.ToUtf8(pchAppKey);
		EVRApplicationError result = FnTable.LaunchApplication(intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public EVRApplicationError LaunchTemplateApplication(string pchTemplateAppKey, string pchNewAppKey, AppOverrideKeys_t[] pKeys)
	{
		IntPtr intPtr = Utils.ToUtf8(pchTemplateAppKey);
		IntPtr intPtr2 = Utils.ToUtf8(pchNewAppKey);
		EVRApplicationError result = FnTable.LaunchTemplateApplication(intPtr, intPtr2, pKeys, (uint)pKeys.Length);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	public EVRApplicationError LaunchApplicationFromMimeType(string pchMimeType, string pchArgs)
	{
		IntPtr intPtr = Utils.ToUtf8(pchMimeType);
		IntPtr intPtr2 = Utils.ToUtf8(pchArgs);
		EVRApplicationError result = FnTable.LaunchApplicationFromMimeType(intPtr, intPtr2);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	public EVRApplicationError LaunchDashboardOverlay(string pchAppKey)
	{
		IntPtr intPtr = Utils.ToUtf8(pchAppKey);
		EVRApplicationError result = FnTable.LaunchDashboardOverlay(intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public bool CancelApplicationLaunch(string pchAppKey)
	{
		IntPtr intPtr = Utils.ToUtf8(pchAppKey);
		bool result = FnTable.CancelApplicationLaunch(intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public EVRApplicationError IdentifyApplication(uint unProcessId, string pchAppKey)
	{
		IntPtr intPtr = Utils.ToUtf8(pchAppKey);
		EVRApplicationError result = FnTable.IdentifyApplication(unProcessId, intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public uint GetApplicationProcessId(string pchAppKey)
	{
		IntPtr intPtr = Utils.ToUtf8(pchAppKey);
		uint result = FnTable.GetApplicationProcessId(intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public string GetApplicationsErrorNameFromEnum(EVRApplicationError error)
	{
		return Marshal.PtrToStringAnsi(FnTable.GetApplicationsErrorNameFromEnum(error));
	}

	public uint GetApplicationPropertyString(string pchAppKey, EVRApplicationProperty eProperty, StringBuilder pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError)
	{
		IntPtr intPtr = Utils.ToUtf8(pchAppKey);
		uint result = FnTable.GetApplicationPropertyString(intPtr, eProperty, pchPropertyValueBuffer, unPropertyValueBufferLen, ref peError);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public bool GetApplicationPropertyBool(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError)
	{
		IntPtr intPtr = Utils.ToUtf8(pchAppKey);
		bool result = FnTable.GetApplicationPropertyBool(intPtr, eProperty, ref peError);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public ulong GetApplicationPropertyUint64(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError)
	{
		IntPtr intPtr = Utils.ToUtf8(pchAppKey);
		ulong result = FnTable.GetApplicationPropertyUint64(intPtr, eProperty, ref peError);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public EVRApplicationError SetApplicationAutoLaunch(string pchAppKey, bool bAutoLaunch)
	{
		IntPtr intPtr = Utils.ToUtf8(pchAppKey);
		EVRApplicationError result = FnTable.SetApplicationAutoLaunch(intPtr, bAutoLaunch);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public bool GetApplicationAutoLaunch(string pchAppKey)
	{
		IntPtr intPtr = Utils.ToUtf8(pchAppKey);
		bool result = FnTable.GetApplicationAutoLaunch(intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public EVRApplicationError SetDefaultApplicationForMimeType(string pchAppKey, string pchMimeType)
	{
		IntPtr intPtr = Utils.ToUtf8(pchAppKey);
		IntPtr intPtr2 = Utils.ToUtf8(pchMimeType);
		EVRApplicationError result = FnTable.SetDefaultApplicationForMimeType(intPtr, intPtr2);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	public bool GetDefaultApplicationForMimeType(string pchMimeType, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen)
	{
		IntPtr intPtr = Utils.ToUtf8(pchMimeType);
		bool result = FnTable.GetDefaultApplicationForMimeType(intPtr, pchAppKeyBuffer, unAppKeyBufferLen);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public bool GetApplicationSupportedMimeTypes(string pchAppKey, StringBuilder pchMimeTypesBuffer, uint unMimeTypesBuffer)
	{
		IntPtr intPtr = Utils.ToUtf8(pchAppKey);
		bool result = FnTable.GetApplicationSupportedMimeTypes(intPtr, pchMimeTypesBuffer, unMimeTypesBuffer);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public uint GetApplicationsThatSupportMimeType(string pchMimeType, StringBuilder pchAppKeysThatSupportBuffer, uint unAppKeysThatSupportBuffer)
	{
		IntPtr intPtr = Utils.ToUtf8(pchMimeType);
		uint result = FnTable.GetApplicationsThatSupportMimeType(intPtr, pchAppKeysThatSupportBuffer, unAppKeysThatSupportBuffer);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public uint GetApplicationLaunchArguments(uint unHandle, StringBuilder pchArgs, uint unArgs)
	{
		return FnTable.GetApplicationLaunchArguments(unHandle, pchArgs, unArgs);
	}

	public EVRApplicationError GetStartingApplication(StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen)
	{
		return FnTable.GetStartingApplication(pchAppKeyBuffer, unAppKeyBufferLen);
	}

	public EVRSceneApplicationState GetSceneApplicationState()
	{
		return FnTable.GetSceneApplicationState();
	}

	public EVRApplicationError PerformApplicationPrelaunchCheck(string pchAppKey)
	{
		IntPtr intPtr = Utils.ToUtf8(pchAppKey);
		EVRApplicationError result = FnTable.PerformApplicationPrelaunchCheck(intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public string GetSceneApplicationStateNameFromEnum(EVRSceneApplicationState state)
	{
		return Marshal.PtrToStringAnsi(FnTable.GetSceneApplicationStateNameFromEnum(state));
	}

	public EVRApplicationError LaunchInternalProcess(string pchBinaryPath, string pchArguments, string pchWorkingDirectory)
	{
		IntPtr intPtr = Utils.ToUtf8(pchBinaryPath);
		IntPtr intPtr2 = Utils.ToUtf8(pchArguments);
		IntPtr intPtr3 = Utils.ToUtf8(pchWorkingDirectory);
		EVRApplicationError result = FnTable.LaunchInternalProcess(intPtr, intPtr2, intPtr3);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		Marshal.FreeHGlobal(intPtr3);
		return result;
	}

	public uint GetCurrentSceneProcessId()
	{
		return FnTable.GetCurrentSceneProcessId();
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

	public void ResetZeroPose(ETrackingUniverseOrigin eTrackingUniverseOrigin)
	{
		FnTable.ResetZeroPose(eTrackingUniverseOrigin);
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
		FnTable.GetWorkingCollisionBoundsInfo(null, ref punQuadsCount);
		pQuadsBuffer = new HmdQuad_t[punQuadsCount];
		return FnTable.GetWorkingCollisionBoundsInfo(pQuadsBuffer, ref punQuadsCount);
	}

	public bool GetLiveCollisionBoundsInfo(out HmdQuad_t[] pQuadsBuffer)
	{
		uint punQuadsCount = 0u;
		FnTable.GetLiveCollisionBoundsInfo(null, ref punQuadsCount);
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

	public void SetWorkingPerimeter(HmdVector2_t[] pPointBuffer)
	{
		FnTable.SetWorkingPerimeter(pPointBuffer, (uint)pPointBuffer.Length);
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

	public bool ExportLiveToBuffer(StringBuilder pBuffer, ref uint pnBufferLength)
	{
		pnBufferLength = 0u;
		return FnTable.ExportLiveToBuffer(pBuffer, ref pnBufferLength);
	}

	public bool ImportFromBufferToWorking(string pBuffer, uint nImportFlags)
	{
		IntPtr intPtr = Utils.ToUtf8(pBuffer);
		bool result = FnTable.ImportFromBufferToWorking(intPtr, nImportFlags);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public void ShowWorkingSetPreview()
	{
		FnTable.ShowWorkingSetPreview();
	}

	public void HideWorkingSetPreview()
	{
		FnTable.HideWorkingSetPreview();
	}

	public void RoomSetupStarting()
	{
		FnTable.RoomSetupStarting();
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

	public uint GetFrameTimings(Compositor_FrameTiming[] pTiming)
	{
		return FnTable.GetFrameTimings(pTiming, (uint)pTiming.Length);
	}

	public float GetFrameTimeRemaining()
	{
		return FnTable.GetFrameTimeRemaining();
	}

	public void GetCumulativeStats(ref Compositor_CumulativeStats pStats, uint nStatsSizeInBytes)
	{
		FnTable.GetCumulativeStats(ref pStats, nStatsSizeInBytes);
	}

	public void FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground)
	{
		FnTable.FadeToColor(fSeconds, fRed, fGreen, fBlue, fAlpha, bBackground);
	}

	public HmdColor_t GetCurrentFadeColor(bool bBackground)
	{
		return FnTable.GetCurrentFadeColor(bBackground);
	}

	public void FadeGrid(float fSeconds, bool bFadeIn)
	{
		FnTable.FadeGrid(fSeconds, bFadeIn);
	}

	public float GetCurrentGridAlpha()
	{
		return FnTable.GetCurrentGridAlpha();
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

	public void ForceReconnectProcess()
	{
		FnTable.ForceReconnectProcess();
	}

	public void SuspendRendering(bool bSuspend)
	{
		FnTable.SuspendRendering(bSuspend);
	}

	public EVRCompositorError GetMirrorTextureD3D11(EVREye eEye, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView)
	{
		return FnTable.GetMirrorTextureD3D11(eEye, pD3D11DeviceOrResource, ref ppD3D11ShaderResourceView);
	}

	public void ReleaseMirrorTextureD3D11(IntPtr pD3D11ShaderResourceView)
	{
		FnTable.ReleaseMirrorTextureD3D11(pD3D11ShaderResourceView);
	}

	public EVRCompositorError GetMirrorTextureGL(EVREye eEye, ref uint pglTextureId, IntPtr pglSharedTextureHandle)
	{
		pglTextureId = 0u;
		return FnTable.GetMirrorTextureGL(eEye, ref pglTextureId, pglSharedTextureHandle);
	}

	public bool ReleaseSharedGLTexture(uint glTextureId, IntPtr glSharedTextureHandle)
	{
		return FnTable.ReleaseSharedGLTexture(glTextureId, glSharedTextureHandle);
	}

	public void LockGLSharedTextureForAccess(IntPtr glSharedTextureHandle)
	{
		FnTable.LockGLSharedTextureForAccess(glSharedTextureHandle);
	}

	public void UnlockGLSharedTextureForAccess(IntPtr glSharedTextureHandle)
	{
		FnTable.UnlockGLSharedTextureForAccess(glSharedTextureHandle);
	}

	public uint GetVulkanInstanceExtensionsRequired(StringBuilder pchValue, uint unBufferSize)
	{
		return FnTable.GetVulkanInstanceExtensionsRequired(pchValue, unBufferSize);
	}

	public uint GetVulkanDeviceExtensionsRequired(IntPtr pPhysicalDevice, StringBuilder pchValue, uint unBufferSize)
	{
		return FnTable.GetVulkanDeviceExtensionsRequired(pPhysicalDevice, pchValue, unBufferSize);
	}

	public void SetExplicitTimingMode(EVRCompositorTimingMode eTimingMode)
	{
		FnTable.SetExplicitTimingMode(eTimingMode);
	}

	public EVRCompositorError SubmitExplicitTimingData()
	{
		return FnTable.SubmitExplicitTimingData();
	}

	public bool IsMotionSmoothingEnabled()
	{
		return FnTable.IsMotionSmoothingEnabled();
	}

	public bool IsMotionSmoothingSupported()
	{
		return FnTable.IsMotionSmoothingSupported();
	}

	public bool IsCurrentSceneFocusAppLoading()
	{
		return FnTable.IsCurrentSceneFocusAppLoading();
	}

	public EVRCompositorError SetStageOverride_Async(string pchRenderModelPath, ref HmdMatrix34_t pTransform, ref Compositor_StageRenderSettings pRenderSettings, uint nSizeOfRenderSettings)
	{
		IntPtr intPtr = Utils.ToUtf8(pchRenderModelPath);
		EVRCompositorError result = FnTable.SetStageOverride_Async(intPtr, ref pTransform, ref pRenderSettings, nSizeOfRenderSettings);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public void ClearStageOverride()
	{
		FnTable.ClearStageOverride();
	}

	public bool GetCompositorBenchmarkResults(ref Compositor_BenchmarkResults pBenchmarkResults, uint nSizeOfBenchmarkResults)
	{
		return FnTable.GetCompositorBenchmarkResults(ref pBenchmarkResults, nSizeOfBenchmarkResults);
	}

	public EVRCompositorError GetLastPosePredictionIDs(ref uint pRenderPosePredictionID, ref uint pGamePosePredictionID)
	{
		pRenderPosePredictionID = 0u;
		pGamePosePredictionID = 0u;
		return FnTable.GetLastPosePredictionIDs(ref pRenderPosePredictionID, ref pGamePosePredictionID);
	}

	public EVRCompositorError GetPosesForFrame(uint unPosePredictionID, TrackedDevicePose_t[] pPoseArray)
	{
		return FnTable.GetPosesForFrame(unPosePredictionID, pPoseArray, (uint)pPoseArray.Length);
	}
}
public class CVROverlay
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _PollNextOverlayEventPacked(ulong ulOverlayHandle, ref VREvent_t_Packed pEvent, uint uncbVREvent);

	[StructLayout(LayoutKind.Explicit)]
	private struct PollNextOverlayEventUnion
	{
		[FieldOffset(0)]
		public IVROverlay._PollNextOverlayEvent pPollNextOverlayEvent;

		[FieldOffset(0)]
		public _PollNextOverlayEventPacked pPollNextOverlayEventPacked;
	}

	private IVROverlay FnTable;

	internal CVROverlay(IntPtr pInterface)
	{
		FnTable = (IVROverlay)Marshal.PtrToStructure(pInterface, typeof(IVROverlay));
	}

	public EVROverlayError FindOverlay(string pchOverlayKey, ref ulong pOverlayHandle)
	{
		IntPtr intPtr = Utils.ToUtf8(pchOverlayKey);
		pOverlayHandle = 0uL;
		EVROverlayError result = FnTable.FindOverlay(intPtr, ref pOverlayHandle);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public EVROverlayError CreateOverlay(string pchOverlayKey, string pchOverlayName, ref ulong pOverlayHandle)
	{
		IntPtr intPtr = Utils.ToUtf8(pchOverlayKey);
		IntPtr intPtr2 = Utils.ToUtf8(pchOverlayName);
		pOverlayHandle = 0uL;
		EVROverlayError result = FnTable.CreateOverlay(intPtr, intPtr2, ref pOverlayHandle);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	public EVROverlayError DestroyOverlay(ulong ulOverlayHandle)
	{
		return FnTable.DestroyOverlay(ulOverlayHandle);
	}

	public uint GetOverlayKey(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError)
	{
		return FnTable.GetOverlayKey(ulOverlayHandle, pchValue, unBufferSize, ref pError);
	}

	public uint GetOverlayName(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError)
	{
		return FnTable.GetOverlayName(ulOverlayHandle, pchValue, unBufferSize, ref pError);
	}

	public EVROverlayError SetOverlayName(ulong ulOverlayHandle, string pchName)
	{
		IntPtr intPtr = Utils.ToUtf8(pchName);
		EVROverlayError result = FnTable.SetOverlayName(ulOverlayHandle, intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public EVROverlayError GetOverlayImageData(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight)
	{
		punWidth = 0u;
		punHeight = 0u;
		return FnTable.GetOverlayImageData(ulOverlayHandle, pvBuffer, unBufferSize, ref punWidth, ref punHeight);
	}

	public string GetOverlayErrorNameFromEnum(EVROverlayError error)
	{
		return Marshal.PtrToStringAnsi(FnTable.GetOverlayErrorNameFromEnum(error));
	}

	public EVROverlayError SetOverlayRenderingPid(ulong ulOverlayHandle, uint unPID)
	{
		return FnTable.SetOverlayRenderingPid(ulOverlayHandle, unPID);
	}

	public uint GetOverlayRenderingPid(ulong ulOverlayHandle)
	{
		return FnTable.GetOverlayRenderingPid(ulOverlayHandle);
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

	public EVROverlayError GetOverlayFlags(ulong ulOverlayHandle, ref uint pFlags)
	{
		pFlags = 0u;
		return FnTable.GetOverlayFlags(ulOverlayHandle, ref pFlags);
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

	public EVROverlayError SetOverlayTexelAspect(ulong ulOverlayHandle, float fTexelAspect)
	{
		return FnTable.SetOverlayTexelAspect(ulOverlayHandle, fTexelAspect);
	}

	public EVROverlayError GetOverlayTexelAspect(ulong ulOverlayHandle, ref float pfTexelAspect)
	{
		pfTexelAspect = 0f;
		return FnTable.GetOverlayTexelAspect(ulOverlayHandle, ref pfTexelAspect);
	}

	public EVROverlayError SetOverlaySortOrder(ulong ulOverlayHandle, uint unSortOrder)
	{
		return FnTable.SetOverlaySortOrder(ulOverlayHandle, unSortOrder);
	}

	public EVROverlayError GetOverlaySortOrder(ulong ulOverlayHandle, ref uint punSortOrder)
	{
		punSortOrder = 0u;
		return FnTable.GetOverlaySortOrder(ulOverlayHandle, ref punSortOrder);
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

	public EVROverlayError SetOverlayCurvature(ulong ulOverlayHandle, float fCurvature)
	{
		return FnTable.SetOverlayCurvature(ulOverlayHandle, fCurvature);
	}

	public EVROverlayError GetOverlayCurvature(ulong ulOverlayHandle, ref float pfCurvature)
	{
		pfCurvature = 0f;
		return FnTable.GetOverlayCurvature(ulOverlayHandle, ref pfCurvature);
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
		IntPtr intPtr = Utils.ToUtf8(pchComponentName);
		EVROverlayError result = FnTable.SetOverlayTransformTrackedDeviceComponent(ulOverlayHandle, unDeviceIndex, intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public EVROverlayError GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, ref uint punDeviceIndex, StringBuilder pchComponentName, uint unComponentNameSize)
	{
		punDeviceIndex = 0u;
		return FnTable.GetOverlayTransformTrackedDeviceComponent(ulOverlayHandle, ref punDeviceIndex, pchComponentName, unComponentNameSize);
	}

	public EVROverlayError GetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ref ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform)
	{
		ulOverlayHandleParent = 0uL;
		return FnTable.GetOverlayTransformOverlayRelative(ulOverlayHandle, ref ulOverlayHandleParent, ref pmatParentOverlayToOverlayTransform);
	}

	public EVROverlayError SetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform)
	{
		return FnTable.SetOverlayTransformOverlayRelative(ulOverlayHandle, ulOverlayHandleParent, ref pmatParentOverlayToOverlayTransform);
	}

	public EVROverlayError SetOverlayTransformCursor(ulong ulCursorOverlayHandle, ref HmdVector2_t pvHotspot)
	{
		return FnTable.SetOverlayTransformCursor(ulCursorOverlayHandle, ref pvHotspot);
	}

	public EVROverlayError GetOverlayTransformCursor(ulong ulOverlayHandle, ref HmdVector2_t pvHotspot)
	{
		return FnTable.GetOverlayTransformCursor(ulOverlayHandle, ref pvHotspot);
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
		if (Environment.OSVersion.Platform == PlatformID.MacOSX || Environment.OSVersion.Platform == PlatformID.Unix)
		{
			VREvent_t_Packed pEvent2 = default(VREvent_t_Packed);
			PollNextOverlayEventUnion pollNextOverlayEventUnion = default(PollNextOverlayEventUnion);
			pollNextOverlayEventUnion.pPollNextOverlayEventPacked = null;
			pollNextOverlayEventUnion.pPollNextOverlayEvent = FnTable.PollNextOverlayEvent;
			bool result = pollNextOverlayEventUnion.pPollNextOverlayEventPacked(ulOverlayHandle, ref pEvent2, (uint)Marshal.SizeOf(typeof(VREvent_t_Packed)));
			pEvent2.Unpack(ref pEvent);
			return result;
		}
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

	public bool IsHoverTargetOverlay(ulong ulOverlayHandle)
	{
		return FnTable.IsHoverTargetOverlay(ulOverlayHandle);
	}

	public EVROverlayError SetOverlayIntersectionMask(ulong ulOverlayHandle, ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives, uint unNumMaskPrimitives, uint unPrimitiveSize)
	{
		return FnTable.SetOverlayIntersectionMask(ulOverlayHandle, ref pMaskPrimitives, unNumMaskPrimitives, unPrimitiveSize);
	}

	public EVROverlayError TriggerLaserMouseHapticVibration(ulong ulOverlayHandle, float fDurationSeconds, float fFrequency, float fAmplitude)
	{
		return FnTable.TriggerLaserMouseHapticVibration(ulOverlayHandle, fDurationSeconds, fFrequency, fAmplitude);
	}

	public EVROverlayError SetOverlayCursor(ulong ulOverlayHandle, ulong ulCursorHandle)
	{
		return FnTable.SetOverlayCursor(ulOverlayHandle, ulCursorHandle);
	}

	public EVROverlayError SetOverlayCursorPositionOverride(ulong ulOverlayHandle, ref HmdVector2_t pvCursor)
	{
		return FnTable.SetOverlayCursorPositionOverride(ulOverlayHandle, ref pvCursor);
	}

	public EVROverlayError ClearOverlayCursorPositionOverride(ulong ulOverlayHandle)
	{
		return FnTable.ClearOverlayCursorPositionOverride(ulOverlayHandle);
	}

	public EVROverlayError SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture)
	{
		return FnTable.SetOverlayTexture(ulOverlayHandle, ref pTexture);
	}

	public EVROverlayError ClearOverlayTexture(ulong ulOverlayHandle)
	{
		return FnTable.ClearOverlayTexture(ulOverlayHandle);
	}

	public EVROverlayError SetOverlayRaw(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unBytesPerPixel)
	{
		return FnTable.SetOverlayRaw(ulOverlayHandle, pvBuffer, unWidth, unHeight, unBytesPerPixel);
	}

	public EVROverlayError SetOverlayFromFile(ulong ulOverlayHandle, string pchFilePath)
	{
		IntPtr intPtr = Utils.ToUtf8(pchFilePath);
		EVROverlayError result = FnTable.SetOverlayFromFile(ulOverlayHandle, intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public EVROverlayError GetOverlayTexture(ulong ulOverlayHandle, ref IntPtr pNativeTextureHandle, IntPtr pNativeTextureRef, ref uint pWidth, ref uint pHeight, ref uint pNativeFormat, ref ETextureType pAPIType, ref EColorSpace pColorSpace, ref VRTextureBounds_t pTextureBounds)
	{
		pWidth = 0u;
		pHeight = 0u;
		pNativeFormat = 0u;
		return FnTable.GetOverlayTexture(ulOverlayHandle, ref pNativeTextureHandle, pNativeTextureRef, ref pWidth, ref pHeight, ref pNativeFormat, ref pAPIType, ref pColorSpace, ref pTextureBounds);
	}

	public EVROverlayError ReleaseNativeOverlayHandle(ulong ulOverlayHandle, IntPtr pNativeTextureHandle)
	{
		return FnTable.ReleaseNativeOverlayHandle(ulOverlayHandle, pNativeTextureHandle);
	}

	public EVROverlayError GetOverlayTextureSize(ulong ulOverlayHandle, ref uint pWidth, ref uint pHeight)
	{
		pWidth = 0u;
		pHeight = 0u;
		return FnTable.GetOverlayTextureSize(ulOverlayHandle, ref pWidth, ref pHeight);
	}

	public EVROverlayError CreateDashboardOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle)
	{
		IntPtr intPtr = Utils.ToUtf8(pchOverlayKey);
		IntPtr intPtr2 = Utils.ToUtf8(pchOverlayFriendlyName);
		pMainHandle = 0uL;
		pThumbnailHandle = 0uL;
		EVROverlayError result = FnTable.CreateDashboardOverlay(intPtr, intPtr2, ref pMainHandle, ref pThumbnailHandle);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return result;
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
		IntPtr intPtr = Utils.ToUtf8(pchOverlayToShow);
		FnTable.ShowDashboard(intPtr);
		Marshal.FreeHGlobal(intPtr);
	}

	public uint GetPrimaryDashboardDevice()
	{
		return FnTable.GetPrimaryDashboardDevice();
	}

	public EVROverlayError ShowKeyboard(int eInputMode, int eLineInputMode, uint unFlags, string pchDescription, uint unCharMax, string pchExistingText, ulong uUserValue)
	{
		IntPtr intPtr = Utils.ToUtf8(pchDescription);
		IntPtr intPtr2 = Utils.ToUtf8(pchExistingText);
		EVROverlayError result = FnTable.ShowKeyboard(eInputMode, eLineInputMode, unFlags, intPtr, unCharMax, intPtr2, uUserValue);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	public EVROverlayError ShowKeyboardForOverlay(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, uint unFlags, string pchDescription, uint unCharMax, string pchExistingText, ulong uUserValue)
	{
		IntPtr intPtr = Utils.ToUtf8(pchDescription);
		IntPtr intPtr2 = Utils.ToUtf8(pchExistingText);
		EVROverlayError result = FnTable.ShowKeyboardForOverlay(ulOverlayHandle, eInputMode, eLineInputMode, unFlags, intPtr, unCharMax, intPtr2, uUserValue);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return result;
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

	public VRMessageOverlayResponse ShowMessageOverlay(string pchText, string pchCaption, string pchButton0Text, string pchButton1Text, string pchButton2Text, string pchButton3Text)
	{
		IntPtr intPtr = Utils.ToUtf8(pchText);
		IntPtr intPtr2 = Utils.ToUtf8(pchCaption);
		IntPtr intPtr3 = Utils.ToUtf8(pchButton0Text);
		IntPtr intPtr4 = Utils.ToUtf8(pchButton1Text);
		IntPtr intPtr5 = Utils.ToUtf8(pchButton2Text);
		IntPtr intPtr6 = Utils.ToUtf8(pchButton3Text);
		VRMessageOverlayResponse result = FnTable.ShowMessageOverlay(intPtr, intPtr2, intPtr3, intPtr4, intPtr5, intPtr6);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		Marshal.FreeHGlobal(intPtr3);
		Marshal.FreeHGlobal(intPtr4);
		Marshal.FreeHGlobal(intPtr5);
		Marshal.FreeHGlobal(intPtr6);
		return result;
	}

	public void CloseMessageOverlay()
	{
		FnTable.CloseMessageOverlay();
	}
}
public class CVROverlayView
{
	private IVROverlayView FnTable;

	internal CVROverlayView(IntPtr pInterface)
	{
		FnTable = (IVROverlayView)Marshal.PtrToStructure(pInterface, typeof(IVROverlayView));
	}

	public EVROverlayError AcquireOverlayView(ulong ulOverlayHandle, ref VRNativeDevice_t pNativeDevice, ref VROverlayView_t pOverlayView, uint unOverlayViewSize)
	{
		return FnTable.AcquireOverlayView(ulOverlayHandle, ref pNativeDevice, ref pOverlayView, unOverlayViewSize);
	}

	public EVROverlayError ReleaseOverlayView(ref VROverlayView_t pOverlayView)
	{
		return FnTable.ReleaseOverlayView(ref pOverlayView);
	}

	public void PostOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pvrEvent)
	{
		FnTable.PostOverlayEvent(ulOverlayHandle, ref pvrEvent);
	}

	public bool IsViewingPermitted(ulong ulOverlayHandle)
	{
		return FnTable.IsViewingPermitted(ulOverlayHandle);
	}
}
public class CVRHeadsetView
{
	private IVRHeadsetView FnTable;

	internal CVRHeadsetView(IntPtr pInterface)
	{
		FnTable = (IVRHeadsetView)Marshal.PtrToStructure(pInterface, typeof(IVRHeadsetView));
	}

	public void SetHeadsetViewSize(uint nWidth, uint nHeight)
	{
		FnTable.SetHeadsetViewSize(nWidth, nHeight);
	}

	public void GetHeadsetViewSize(ref uint pnWidth, ref uint pnHeight)
	{
		pnWidth = 0u;
		pnHeight = 0u;
		FnTable.GetHeadsetViewSize(ref pnWidth, ref pnHeight);
	}

	public void SetHeadsetViewMode(uint eHeadsetViewMode)
	{
		FnTable.SetHeadsetViewMode(eHeadsetViewMode);
	}

	public uint GetHeadsetViewMode()
	{
		return FnTable.GetHeadsetViewMode();
	}

	public void SetHeadsetViewCropped(bool bCropped)
	{
		FnTable.SetHeadsetViewCropped(bCropped);
	}

	public bool GetHeadsetViewCropped()
	{
		return FnTable.GetHeadsetViewCropped();
	}

	public float GetHeadsetViewAspectRatio()
	{
		return FnTable.GetHeadsetViewAspectRatio();
	}

	public void SetHeadsetViewBlendRange(float flStartPct, float flEndPct)
	{
		FnTable.SetHeadsetViewBlendRange(flStartPct, flEndPct);
	}

	public void GetHeadsetViewBlendRange(ref float pStartPct, ref float pEndPct)
	{
		pStartPct = 0f;
		pEndPct = 0f;
		FnTable.GetHeadsetViewBlendRange(ref pStartPct, ref pEndPct);
	}
}
public class CVRRenderModels
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetComponentStatePacked(IntPtr pchRenderModelName, IntPtr pchComponentName, ref VRControllerState_t_Packed pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState);

	[StructLayout(LayoutKind.Explicit)]
	private struct GetComponentStateUnion
	{
		[FieldOffset(0)]
		public IVRRenderModels._GetComponentState pGetComponentState;

		[FieldOffset(0)]
		public _GetComponentStatePacked pGetComponentStatePacked;
	}

	private IVRRenderModels FnTable;

	internal CVRRenderModels(IntPtr pInterface)
	{
		FnTable = (IVRRenderModels)Marshal.PtrToStructure(pInterface, typeof(IVRRenderModels));
	}

	public EVRRenderModelError LoadRenderModel_Async(string pchRenderModelName, ref IntPtr ppRenderModel)
	{
		IntPtr intPtr = Utils.ToUtf8(pchRenderModelName);
		EVRRenderModelError result = FnTable.LoadRenderModel_Async(intPtr, ref ppRenderModel);
		Marshal.FreeHGlobal(intPtr);
		return result;
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
		IntPtr intPtr = Utils.ToUtf8(pchRenderModelName);
		uint result = FnTable.GetComponentCount(intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public uint GetComponentName(string pchRenderModelName, uint unComponentIndex, StringBuilder pchComponentName, uint unComponentNameLen)
	{
		IntPtr intPtr = Utils.ToUtf8(pchRenderModelName);
		uint result = FnTable.GetComponentName(intPtr, unComponentIndex, pchComponentName, unComponentNameLen);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public ulong GetComponentButtonMask(string pchRenderModelName, string pchComponentName)
	{
		IntPtr intPtr = Utils.ToUtf8(pchRenderModelName);
		IntPtr intPtr2 = Utils.ToUtf8(pchComponentName);
		ulong result = FnTable.GetComponentButtonMask(intPtr, intPtr2);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	public uint GetComponentRenderModelName(string pchRenderModelName, string pchComponentName, StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen)
	{
		IntPtr intPtr = Utils.ToUtf8(pchRenderModelName);
		IntPtr intPtr2 = Utils.ToUtf8(pchComponentName);
		uint result = FnTable.GetComponentRenderModelName(intPtr, intPtr2, pchComponentRenderModelName, unComponentRenderModelNameLen);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	public bool GetComponentStateForDevicePath(string pchRenderModelName, string pchComponentName, ulong devicePath, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState)
	{
		IntPtr intPtr = Utils.ToUtf8(pchRenderModelName);
		IntPtr intPtr2 = Utils.ToUtf8(pchComponentName);
		bool result = FnTable.GetComponentStateForDevicePath(intPtr, intPtr2, devicePath, ref pState, ref pComponentState);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	public bool GetComponentState(string pchRenderModelName, string pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState)
	{
		IntPtr intPtr = Utils.ToUtf8(pchRenderModelName);
		IntPtr intPtr2 = Utils.ToUtf8(pchComponentName);
		if (Environment.OSVersion.Platform == PlatformID.MacOSX || Environment.OSVersion.Platform == PlatformID.Unix)
		{
			VRControllerState_t_Packed pControllerState2 = new VRControllerState_t_Packed(pControllerState);
			GetComponentStateUnion getComponentStateUnion = default(GetComponentStateUnion);
			getComponentStateUnion.pGetComponentStatePacked = null;
			getComponentStateUnion.pGetComponentState = FnTable.GetComponentState;
			bool result = getComponentStateUnion.pGetComponentStatePacked(intPtr, intPtr2, ref pControllerState2, ref pState, ref pComponentState);
			pControllerState2.Unpack(ref pControllerState);
			return result;
		}
		bool result2 = FnTable.GetComponentState(intPtr, intPtr2, ref pControllerState, ref pState, ref pComponentState);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return result2;
	}

	public bool RenderModelHasComponent(string pchRenderModelName, string pchComponentName)
	{
		IntPtr intPtr = Utils.ToUtf8(pchRenderModelName);
		IntPtr intPtr2 = Utils.ToUtf8(pchComponentName);
		bool result = FnTable.RenderModelHasComponent(intPtr, intPtr2);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	public uint GetRenderModelThumbnailURL(string pchRenderModelName, StringBuilder pchThumbnailURL, uint unThumbnailURLLen, ref EVRRenderModelError peError)
	{
		IntPtr intPtr = Utils.ToUtf8(pchRenderModelName);
		uint result = FnTable.GetRenderModelThumbnailURL(intPtr, pchThumbnailURL, unThumbnailURLLen, ref peError);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public uint GetRenderModelOriginalPath(string pchRenderModelName, StringBuilder pchOriginalPath, uint unOriginalPathLen, ref EVRRenderModelError peError)
	{
		IntPtr intPtr = Utils.ToUtf8(pchRenderModelName);
		uint result = FnTable.GetRenderModelOriginalPath(intPtr, pchOriginalPath, unOriginalPathLen, ref peError);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public string GetRenderModelErrorNameFromEnum(EVRRenderModelError error)
	{
		return Marshal.PtrToStringAnsi(FnTable.GetRenderModelErrorNameFromEnum(error));
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
		IntPtr intPtr = Utils.ToUtf8(pchText);
		pNotificationId = 0u;
		EVRNotificationError result = FnTable.CreateNotification(ulOverlayHandle, ulUserValue, type, intPtr, style, ref pImage, ref pNotificationId);
		Marshal.FreeHGlobal(intPtr);
		return result;
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
		return Marshal.PtrToStringAnsi(FnTable.GetSettingsErrorNameFromEnum(eError));
	}

	public void SetBool(string pchSection, string pchSettingsKey, bool bValue, ref EVRSettingsError peError)
	{
		IntPtr intPtr = Utils.ToUtf8(pchSection);
		IntPtr intPtr2 = Utils.ToUtf8(pchSettingsKey);
		FnTable.SetBool(intPtr, intPtr2, bValue, ref peError);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
	}

	public void SetInt32(string pchSection, string pchSettingsKey, int nValue, ref EVRSettingsError peError)
	{
		IntPtr intPtr = Utils.ToUtf8(pchSection);
		IntPtr intPtr2 = Utils.ToUtf8(pchSettingsKey);
		FnTable.SetInt32(intPtr, intPtr2, nValue, ref peError);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
	}

	public void SetFloat(string pchSection, string pchSettingsKey, float flValue, ref EVRSettingsError peError)
	{
		IntPtr intPtr = Utils.ToUtf8(pchSection);
		IntPtr intPtr2 = Utils.ToUtf8(pchSettingsKey);
		FnTable.SetFloat(intPtr, intPtr2, flValue, ref peError);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
	}

	public void SetString(string pchSection, string pchSettingsKey, string pchValue, ref EVRSettingsError peError)
	{
		IntPtr intPtr = Utils.ToUtf8(pchSection);
		IntPtr intPtr2 = Utils.ToUtf8(pchSettingsKey);
		IntPtr intPtr3 = Utils.ToUtf8(pchValue);
		FnTable.SetString(intPtr, intPtr2, intPtr3, ref peError);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		Marshal.FreeHGlobal(intPtr3);
	}

	public bool GetBool(string pchSection, string pchSettingsKey, ref EVRSettingsError peError)
	{
		IntPtr intPtr = Utils.ToUtf8(pchSection);
		IntPtr intPtr2 = Utils.ToUtf8(pchSettingsKey);
		bool result = FnTable.GetBool(intPtr, intPtr2, ref peError);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	public int GetInt32(string pchSection, string pchSettingsKey, ref EVRSettingsError peError)
	{
		IntPtr intPtr = Utils.ToUtf8(pchSection);
		IntPtr intPtr2 = Utils.ToUtf8(pchSettingsKey);
		int result = FnTable.GetInt32(intPtr, intPtr2, ref peError);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	public float GetFloat(string pchSection, string pchSettingsKey, ref EVRSettingsError peError)
	{
		IntPtr intPtr = Utils.ToUtf8(pchSection);
		IntPtr intPtr2 = Utils.ToUtf8(pchSettingsKey);
		float result = FnTable.GetFloat(intPtr, intPtr2, ref peError);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	public void GetString(string pchSection, string pchSettingsKey, StringBuilder pchValue, uint unValueLen, ref EVRSettingsError peError)
	{
		IntPtr intPtr = Utils.ToUtf8(pchSection);
		IntPtr intPtr2 = Utils.ToUtf8(pchSettingsKey);
		FnTable.GetString(intPtr, intPtr2, pchValue, unValueLen, ref peError);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
	}

	public void RemoveSection(string pchSection, ref EVRSettingsError peError)
	{
		IntPtr intPtr = Utils.ToUtf8(pchSection);
		FnTable.RemoveSection(intPtr, ref peError);
		Marshal.FreeHGlobal(intPtr);
	}

	public void RemoveKeyInSection(string pchSection, string pchSettingsKey, ref EVRSettingsError peError)
	{
		IntPtr intPtr = Utils.ToUtf8(pchSection);
		IntPtr intPtr2 = Utils.ToUtf8(pchSettingsKey);
		FnTable.RemoveKeyInSection(intPtr, intPtr2, ref peError);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
	}
}
public class CVRScreenshots
{
	private IVRScreenshots FnTable;

	internal CVRScreenshots(IntPtr pInterface)
	{
		FnTable = (IVRScreenshots)Marshal.PtrToStructure(pInterface, typeof(IVRScreenshots));
	}

	public EVRScreenshotError RequestScreenshot(ref uint pOutScreenshotHandle, EVRScreenshotType type, string pchPreviewFilename, string pchVRFilename)
	{
		pOutScreenshotHandle = 0u;
		IntPtr intPtr = Utils.ToUtf8(pchPreviewFilename);
		IntPtr intPtr2 = Utils.ToUtf8(pchVRFilename);
		EVRScreenshotError result = FnTable.RequestScreenshot(ref pOutScreenshotHandle, type, intPtr, intPtr2);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	public EVRScreenshotError HookScreenshot(EVRScreenshotType[] pSupportedTypes)
	{
		return FnTable.HookScreenshot(pSupportedTypes, pSupportedTypes.Length);
	}

	public EVRScreenshotType GetScreenshotPropertyType(uint screenshotHandle, ref EVRScreenshotError pError)
	{
		return FnTable.GetScreenshotPropertyType(screenshotHandle, ref pError);
	}

	public uint GetScreenshotPropertyFilename(uint screenshotHandle, EVRScreenshotPropertyFilenames filenameType, StringBuilder pchFilename, uint cchFilename, ref EVRScreenshotError pError)
	{
		return FnTable.GetScreenshotPropertyFilename(screenshotHandle, filenameType, pchFilename, cchFilename, ref pError);
	}

	public EVRScreenshotError UpdateScreenshotProgress(uint screenshotHandle, float flProgress)
	{
		return FnTable.UpdateScreenshotProgress(screenshotHandle, flProgress);
	}

	public EVRScreenshotError TakeStereoScreenshot(ref uint pOutScreenshotHandle, string pchPreviewFilename, string pchVRFilename)
	{
		pOutScreenshotHandle = 0u;
		IntPtr intPtr = Utils.ToUtf8(pchPreviewFilename);
		IntPtr intPtr2 = Utils.ToUtf8(pchVRFilename);
		EVRScreenshotError result = FnTable.TakeStereoScreenshot(ref pOutScreenshotHandle, intPtr, intPtr2);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	public EVRScreenshotError SubmitScreenshot(uint screenshotHandle, EVRScreenshotType type, string pchSourcePreviewFilename, string pchSourceVRFilename)
	{
		IntPtr intPtr = Utils.ToUtf8(pchSourcePreviewFilename);
		IntPtr intPtr2 = Utils.ToUtf8(pchSourceVRFilename);
		EVRScreenshotError result = FnTable.SubmitScreenshot(screenshotHandle, type, intPtr, intPtr2);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}
}
public class CVRResources
{
	private IVRResources FnTable;

	internal CVRResources(IntPtr pInterface)
	{
		FnTable = (IVRResources)Marshal.PtrToStructure(pInterface, typeof(IVRResources));
	}

	public uint LoadSharedResource(string pchResourceName, string pchBuffer, uint unBufferLen)
	{
		IntPtr intPtr = Utils.ToUtf8(pchResourceName);
		uint result = FnTable.LoadSharedResource(intPtr, pchBuffer, unBufferLen);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public uint GetResourceFullPath(string pchResourceName, string pchResourceTypeDirectory, StringBuilder pchPathBuffer, uint unBufferLen)
	{
		IntPtr intPtr = Utils.ToUtf8(pchResourceName);
		IntPtr intPtr2 = Utils.ToUtf8(pchResourceTypeDirectory);
		uint result = FnTable.GetResourceFullPath(intPtr, intPtr2, pchPathBuffer, unBufferLen);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}
}
public class CVRDriverManager
{
	private IVRDriverManager FnTable;

	internal CVRDriverManager(IntPtr pInterface)
	{
		FnTable = (IVRDriverManager)Marshal.PtrToStructure(pInterface, typeof(IVRDriverManager));
	}

	public uint GetDriverCount()
	{
		return FnTable.GetDriverCount();
	}

	public uint GetDriverName(uint nDriver, StringBuilder pchValue, uint unBufferSize)
	{
		return FnTable.GetDriverName(nDriver, pchValue, unBufferSize);
	}

	public ulong GetDriverHandle(string pchDriverName)
	{
		IntPtr intPtr = Utils.ToUtf8(pchDriverName);
		ulong result = FnTable.GetDriverHandle(intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public bool IsEnabled(uint nDriver)
	{
		return FnTable.IsEnabled(nDriver);
	}
}
public class CVRInput
{
	private IVRInput FnTable;

	internal CVRInput(IntPtr pInterface)
	{
		FnTable = (IVRInput)Marshal.PtrToStructure(pInterface, typeof(IVRInput));
	}

	public EVRInputError SetActionManifestPath(string pchActionManifestPath)
	{
		IntPtr intPtr = Utils.ToUtf8(pchActionManifestPath);
		EVRInputError result = FnTable.SetActionManifestPath(intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public EVRInputError GetActionSetHandle(string pchActionSetName, ref ulong pHandle)
	{
		IntPtr intPtr = Utils.ToUtf8(pchActionSetName);
		pHandle = 0uL;
		EVRInputError result = FnTable.GetActionSetHandle(intPtr, ref pHandle);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public EVRInputError GetActionHandle(string pchActionName, ref ulong pHandle)
	{
		IntPtr intPtr = Utils.ToUtf8(pchActionName);
		pHandle = 0uL;
		EVRInputError result = FnTable.GetActionHandle(intPtr, ref pHandle);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public EVRInputError GetInputSourceHandle(string pchInputSourcePath, ref ulong pHandle)
	{
		IntPtr intPtr = Utils.ToUtf8(pchInputSourcePath);
		pHandle = 0uL;
		EVRInputError result = FnTable.GetInputSourceHandle(intPtr, ref pHandle);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public EVRInputError UpdateActionState(VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t)
	{
		return FnTable.UpdateActionState(pSets, unSizeOfVRSelectedActionSet_t, (uint)pSets.Length);
	}

	public EVRInputError GetDigitalActionData(ulong action, ref InputDigitalActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice)
	{
		return FnTable.GetDigitalActionData(action, ref pActionData, unActionDataSize, ulRestrictToDevice);
	}

	public EVRInputError GetAnalogActionData(ulong action, ref InputAnalogActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice)
	{
		return FnTable.GetAnalogActionData(action, ref pActionData, unActionDataSize, ulRestrictToDevice);
	}

	public EVRInputError GetPoseActionDataRelativeToNow(ulong action, ETrackingUniverseOrigin eOrigin, float fPredictedSecondsFromNow, ref InputPoseActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice)
	{
		return FnTable.GetPoseActionDataRelativeToNow(action, eOrigin, fPredictedSecondsFromNow, ref pActionData, unActionDataSize, ulRestrictToDevice);
	}

	public EVRInputError GetPoseActionDataForNextFrame(ulong action, ETrackingUniverseOrigin eOrigin, ref InputPoseActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice)
	{
		return FnTable.GetPoseActionDataForNextFrame(action, eOrigin, ref pActionData, unActionDataSize, ulRestrictToDevice);
	}

	public EVRInputError GetSkeletalActionData(ulong action, ref InputSkeletalActionData_t pActionData, uint unActionDataSize)
	{
		return FnTable.GetSkeletalActionData(action, ref pActionData, unActionDataSize);
	}

	public EVRInputError GetDominantHand(ref ETrackedControllerRole peDominantHand)
	{
		return FnTable.GetDominantHand(ref peDominantHand);
	}

	public EVRInputError SetDominantHand(ETrackedControllerRole eDominantHand)
	{
		return FnTable.SetDominantHand(eDominantHand);
	}

	public EVRInputError GetBoneCount(ulong action, ref uint pBoneCount)
	{
		pBoneCount = 0u;
		return FnTable.GetBoneCount(action, ref pBoneCount);
	}

	public EVRInputError GetBoneHierarchy(ulong action, int[] pParentIndices)
	{
		return FnTable.GetBoneHierarchy(action, pParentIndices, (uint)pParentIndices.Length);
	}

	public EVRInputError GetBoneName(ulong action, int nBoneIndex, StringBuilder pchBoneName, uint unNameBufferSize)
	{
		return FnTable.GetBoneName(action, nBoneIndex, pchBoneName, unNameBufferSize);
	}

	public EVRInputError GetSkeletalReferenceTransforms(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalReferencePose eReferencePose, VRBoneTransform_t[] pTransformArray)
	{
		return FnTable.GetSkeletalReferenceTransforms(action, eTransformSpace, eReferencePose, pTransformArray, (uint)pTransformArray.Length);
	}

	public EVRInputError GetSkeletalTrackingLevel(ulong action, ref EVRSkeletalTrackingLevel pSkeletalTrackingLevel)
	{
		return FnTable.GetSkeletalTrackingLevel(action, ref pSkeletalTrackingLevel);
	}

	public EVRInputError GetSkeletalBoneData(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalMotionRange eMotionRange, VRBoneTransform_t[] pTransformArray)
	{
		return FnTable.GetSkeletalBoneData(action, eTransformSpace, eMotionRange, pTransformArray, (uint)pTransformArray.Length);
	}

	public EVRInputError GetSkeletalSummaryData(ulong action, EVRSummaryType eSummaryType, ref VRSkeletalSummaryData_t pSkeletalSummaryData)
	{
		return FnTable.GetSkeletalSummaryData(action, eSummaryType, ref pSkeletalSummaryData);
	}

	public EVRInputError GetSkeletalBoneDataCompressed(ulong action, EVRSkeletalMotionRange eMotionRange, IntPtr pvCompressedData, uint unCompressedSize, ref uint punRequiredCompressedSize)
	{
		punRequiredCompressedSize = 0u;
		return FnTable.GetSkeletalBoneDataCompressed(action, eMotionRange, pvCompressedData, unCompressedSize, ref punRequiredCompressedSize);
	}

	public EVRInputError DecompressSkeletalBoneData(IntPtr pvCompressedBuffer, uint unCompressedBufferSize, EVRSkeletalTransformSpace eTransformSpace, VRBoneTransform_t[] pTransformArray)
	{
		return FnTable.DecompressSkeletalBoneData(pvCompressedBuffer, unCompressedBufferSize, eTransformSpace, pTransformArray, (uint)pTransformArray.Length);
	}

	public EVRInputError TriggerHapticVibrationAction(ulong action, float fStartSecondsFromNow, float fDurationSeconds, float fFrequency, float fAmplitude, ulong ulRestrictToDevice)
	{
		return FnTable.TriggerHapticVibrationAction(action, fStartSecondsFromNow, fDurationSeconds, fFrequency, fAmplitude, ulRestrictToDevice);
	}

	public EVRInputError GetActionOrigins(ulong actionSetHandle, ulong digitalActionHandle, ulong[] originsOut)
	{
		return FnTable.GetActionOrigins(actionSetHandle, digitalActionHandle, originsOut, (uint)originsOut.Length);
	}

	public EVRInputError GetOriginLocalizedName(ulong origin, StringBuilder pchNameArray, uint unNameArraySize, int unStringSectionsToInclude)
	{
		return FnTable.GetOriginLocalizedName(origin, pchNameArray, unNameArraySize, unStringSectionsToInclude);
	}

	public EVRInputError GetOriginTrackedDeviceInfo(ulong origin, ref InputOriginInfo_t pOriginInfo, uint unOriginInfoSize)
	{
		return FnTable.GetOriginTrackedDeviceInfo(origin, ref pOriginInfo, unOriginInfoSize);
	}

	public EVRInputError GetActionBindingInfo(ulong action, ref InputBindingInfo_t pOriginInfo, uint unBindingInfoSize, uint unBindingInfoCount, ref uint punReturnedBindingInfoCount)
	{
		punReturnedBindingInfoCount = 0u;
		return FnTable.GetActionBindingInfo(action, ref pOriginInfo, unBindingInfoSize, unBindingInfoCount, ref punReturnedBindingInfoCount);
	}

	public EVRInputError ShowActionOrigins(ulong actionSetHandle, ulong ulActionHandle)
	{
		return FnTable.ShowActionOrigins(actionSetHandle, ulActionHandle);
	}

	public EVRInputError ShowBindingsForActionSet(VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t, ulong originToHighlight)
	{
		return FnTable.ShowBindingsForActionSet(pSets, unSizeOfVRSelectedActionSet_t, (uint)pSets.Length, originToHighlight);
	}

	public EVRInputError GetComponentStateForBinding(string pchRenderModelName, string pchComponentName, ref InputBindingInfo_t pOriginInfo, uint unBindingInfoSize, uint unBindingInfoCount, ref RenderModel_ComponentState_t pComponentState)
	{
		IntPtr intPtr = Utils.ToUtf8(pchRenderModelName);
		IntPtr intPtr2 = Utils.ToUtf8(pchComponentName);
		EVRInputError result = FnTable.GetComponentStateForBinding(intPtr, intPtr2, ref pOriginInfo, unBindingInfoSize, unBindingInfoCount, ref pComponentState);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	public bool IsUsingLegacyInput()
	{
		return FnTable.IsUsingLegacyInput();
	}

	public EVRInputError OpenBindingUI(string pchAppKey, ulong ulActionSetHandle, ulong ulDeviceHandle, bool bShowOnDesktop)
	{
		IntPtr intPtr = Utils.ToUtf8(pchAppKey);
		EVRInputError result = FnTable.OpenBindingUI(intPtr, ulActionSetHandle, ulDeviceHandle, bShowOnDesktop);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public EVRInputError GetBindingVariant(ulong ulDevicePath, StringBuilder pchVariantArray, uint unVariantArraySize)
	{
		return FnTable.GetBindingVariant(ulDevicePath, pchVariantArray, unVariantArraySize);
	}
}
public class CVRIOBuffer
{
	private IVRIOBuffer FnTable;

	internal CVRIOBuffer(IntPtr pInterface)
	{
		FnTable = (IVRIOBuffer)Marshal.PtrToStructure(pInterface, typeof(IVRIOBuffer));
	}

	public EIOBufferError Open(string pchPath, EIOBufferMode mode, uint unElementSize, uint unElements, ref ulong pulBuffer)
	{
		IntPtr intPtr = Utils.ToUtf8(pchPath);
		pulBuffer = 0uL;
		EIOBufferError result = FnTable.Open(intPtr, mode, unElementSize, unElements, ref pulBuffer);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public EIOBufferError Close(ulong ulBuffer)
	{
		return FnTable.Close(ulBuffer);
	}

	public EIOBufferError Read(ulong ulBuffer, IntPtr pDst, uint unBytes, ref uint punRead)
	{
		punRead = 0u;
		return FnTable.Read(ulBuffer, pDst, unBytes, ref punRead);
	}

	public EIOBufferError Write(ulong ulBuffer, IntPtr pSrc, uint unBytes)
	{
		return FnTable.Write(ulBuffer, pSrc, unBytes);
	}

	public ulong PropertyContainer(ulong ulBuffer)
	{
		return FnTable.PropertyContainer(ulBuffer);
	}

	public bool HasReaders(ulong ulBuffer)
	{
		return FnTable.HasReaders(ulBuffer);
	}
}
public class CVRSpatialAnchors
{
	private IVRSpatialAnchors FnTable;

	internal CVRSpatialAnchors(IntPtr pInterface)
	{
		FnTable = (IVRSpatialAnchors)Marshal.PtrToStructure(pInterface, typeof(IVRSpatialAnchors));
	}

	public EVRSpatialAnchorError CreateSpatialAnchorFromDescriptor(string pchDescriptor, ref uint pHandleOut)
	{
		IntPtr intPtr = Utils.ToUtf8(pchDescriptor);
		pHandleOut = 0u;
		EVRSpatialAnchorError result = FnTable.CreateSpatialAnchorFromDescriptor(intPtr, ref pHandleOut);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public EVRSpatialAnchorError CreateSpatialAnchorFromPose(uint unDeviceIndex, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPose, ref uint pHandleOut)
	{
		pHandleOut = 0u;
		return FnTable.CreateSpatialAnchorFromPose(unDeviceIndex, eOrigin, ref pPose, ref pHandleOut);
	}

	public EVRSpatialAnchorError GetSpatialAnchorPose(uint unHandle, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPoseOut)
	{
		return FnTable.GetSpatialAnchorPose(unHandle, eOrigin, ref pPoseOut);
	}

	public EVRSpatialAnchorError GetSpatialAnchorDescriptor(uint unHandle, StringBuilder pchDescriptorOut, ref uint punDescriptorBufferLenInOut)
	{
		punDescriptorBufferLenInOut = 0u;
		return FnTable.GetSpatialAnchorDescriptor(unHandle, pchDescriptorOut, ref punDescriptorBufferLenInOut);
	}
}
public class CVRDebug
{
	private IVRDebug FnTable;

	internal CVRDebug(IntPtr pInterface)
	{
		FnTable = (IVRDebug)Marshal.PtrToStructure(pInterface, typeof(IVRDebug));
	}

	public EVRDebugError EmitVrProfilerEvent(string pchMessage)
	{
		IntPtr intPtr = Utils.ToUtf8(pchMessage);
		EVRDebugError result = FnTable.EmitVrProfilerEvent(intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public EVRDebugError BeginVrProfilerEvent(ref ulong pHandleOut)
	{
		pHandleOut = 0uL;
		return FnTable.BeginVrProfilerEvent(ref pHandleOut);
	}

	public EVRDebugError FinishVrProfilerEvent(ulong hHandle, string pchMessage)
	{
		IntPtr intPtr = Utils.ToUtf8(pchMessage);
		EVRDebugError result = FnTable.FinishVrProfilerEvent(hHandle, intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public uint DriverDebugRequest(uint unDeviceIndex, string pchRequest, StringBuilder pchResponseBuffer, uint unResponseBufferSize)
	{
		IntPtr intPtr = Utils.ToUtf8(pchRequest);
		uint result = FnTable.DriverDebugRequest(unDeviceIndex, intPtr, pchResponseBuffer, unResponseBufferSize);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}
}
public class CVRProperties
{
	private IVRProperties FnTable;

	internal CVRProperties(IntPtr pInterface)
	{
		FnTable = (IVRProperties)Marshal.PtrToStructure(pInterface, typeof(IVRProperties));
	}

	public ETrackedPropertyError ReadPropertyBatch(ulong ulContainerHandle, ref PropertyRead_t pBatch, uint unBatchEntryCount)
	{
		return FnTable.ReadPropertyBatch(ulContainerHandle, ref pBatch, unBatchEntryCount);
	}

	public ETrackedPropertyError WritePropertyBatch(ulong ulContainerHandle, ref PropertyWrite_t pBatch, uint unBatchEntryCount)
	{
		return FnTable.WritePropertyBatch(ulContainerHandle, ref pBatch, unBatchEntryCount);
	}

	public string GetPropErrorNameFromEnum(ETrackedPropertyError error)
	{
		return Marshal.PtrToStringAnsi(FnTable.GetPropErrorNameFromEnum(error));
	}

	public ulong TrackedDeviceToPropertyContainer(uint nDevice)
	{
		return FnTable.TrackedDeviceToPropertyContainer(nDevice);
	}
}
public class CVRPaths
{
	private IVRPaths FnTable;

	internal CVRPaths(IntPtr pInterface)
	{
		FnTable = (IVRPaths)Marshal.PtrToStructure(pInterface, typeof(IVRPaths));
	}

	public ETrackedPropertyError ReadPathBatch(ulong ulRootHandle, ref PathRead_t pBatch, uint unBatchEntryCount)
	{
		return FnTable.ReadPathBatch(ulRootHandle, ref pBatch, unBatchEntryCount);
	}

	public ETrackedPropertyError WritePathBatch(ulong ulRootHandle, ref PathWrite_t pBatch, uint unBatchEntryCount)
	{
		return FnTable.WritePathBatch(ulRootHandle, ref pBatch, unBatchEntryCount);
	}

	public ETrackedPropertyError StringToHandle(ref ulong pHandle, string pchPath)
	{
		pHandle = 0uL;
		IntPtr intPtr = Utils.ToUtf8(pchPath);
		ETrackedPropertyError result = FnTable.StringToHandle(ref pHandle, intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public ETrackedPropertyError HandleToString(ulong pHandle, string pchBuffer, uint unBufferSize, ref uint punBufferSizeUsed)
	{
		punBufferSizeUsed = 0u;
		return FnTable.HandleToString(pHandle, pchBuffer, unBufferSize, ref punBufferSizeUsed);
	}
}
public class CVRBlockQueue
{
	private IVRBlockQueue FnTable;

	internal CVRBlockQueue(IntPtr pInterface)
	{
		FnTable = (IVRBlockQueue)Marshal.PtrToStructure(pInterface, typeof(IVRBlockQueue));
	}

	public EBlockQueueError Create(ref ulong pulQueueHandle, string pchPath, uint unBlockDataSize, uint unBlockHeaderSize, uint unBlockCount)
	{
		pulQueueHandle = 0uL;
		IntPtr intPtr = Utils.ToUtf8(pchPath);
		EBlockQueueError result = FnTable.Create(ref pulQueueHandle, intPtr, unBlockDataSize, unBlockHeaderSize, unBlockCount);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public EBlockQueueError Connect(ref ulong pulQueueHandle, string pchPath)
	{
		pulQueueHandle = 0uL;
		IntPtr intPtr = Utils.ToUtf8(pchPath);
		EBlockQueueError result = FnTable.Connect(ref pulQueueHandle, intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public EBlockQueueError Destroy(ulong ulQueueHandle)
	{
		return FnTable.Destroy(ulQueueHandle);
	}

	public EBlockQueueError AcquireWriteOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer)
	{
		pulBlockHandle = 0uL;
		return FnTable.AcquireWriteOnlyBlock(ulQueueHandle, ref pulBlockHandle, ref ppvBuffer);
	}

	public EBlockQueueError ReleaseWriteOnlyBlock(ulong ulQueueHandle, ulong ulBlockHandle)
	{
		return FnTable.ReleaseWriteOnlyBlock(ulQueueHandle, ulBlockHandle);
	}

	public EBlockQueueError WaitAndAcquireReadOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer, EBlockQueueReadType eReadType, uint unTimeoutMs)
	{
		pulBlockHandle = 0uL;
		return FnTable.WaitAndAcquireReadOnlyBlock(ulQueueHandle, ref pulBlockHandle, ref ppvBuffer, eReadType, unTimeoutMs);
	}

	public EBlockQueueError AcquireReadOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer, EBlockQueueReadType eReadType)
	{
		pulBlockHandle = 0uL;
		return FnTable.AcquireReadOnlyBlock(ulQueueHandle, ref pulBlockHandle, ref ppvBuffer, eReadType);
	}

	public EBlockQueueError ReleaseReadOnlyBlock(ulong ulQueueHandle, ulong ulBlockHandle)
	{
		return FnTable.ReleaseReadOnlyBlock(ulQueueHandle, ulBlockHandle);
	}

	public EBlockQueueError QueueHasReader(ulong ulQueueHandle, ref bool pbHasReaders)
	{
		pbHasReaders = false;
		return FnTable.QueueHasReader(ulQueueHandle, ref pbHasReaders);
	}
}
public class OpenVRInterop
{
	[DllImport("openvr_api", CallingConvention = CallingConvention.Cdecl, EntryPoint = "VR_InitInternal")]
	internal static extern uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType);

	[DllImport("openvr_api", CallingConvention = CallingConvention.Cdecl, EntryPoint = "VR_InitInternal2")]
	internal static extern uint InitInternal2(ref EVRInitError peError, EVRApplicationType eApplicationType, [In][MarshalAs(UnmanagedType.LPStr)] string pStartupInfo);

	[DllImport("openvr_api", CallingConvention = CallingConvention.Cdecl, EntryPoint = "VR_ShutdownInternal")]
	internal static extern void ShutdownInternal();

	[DllImport("openvr_api", CallingConvention = CallingConvention.Cdecl, EntryPoint = "VR_IsHmdPresent")]
	internal static extern bool IsHmdPresent();

	[DllImport("openvr_api", CallingConvention = CallingConvention.Cdecl, EntryPoint = "VR_IsRuntimeInstalled")]
	internal static extern bool IsRuntimeInstalled();

	[DllImport("openvr_api", CallingConvention = CallingConvention.Cdecl, EntryPoint = "VR_RuntimePath")]
	internal static extern string RuntimePath();

	[DllImport("openvr_api", CallingConvention = CallingConvention.Cdecl, EntryPoint = "VR_GetRuntimePath")]
	internal static extern bool GetRuntimePath(StringBuilder pchPathBuffer, uint unBufferSize, ref uint punRequiredBufferSize);

	[DllImport("openvr_api", CallingConvention = CallingConvention.Cdecl, EntryPoint = "VR_GetStringForHmdError")]
	internal static extern IntPtr GetStringForHmdError(EVRInitError error);

	[DllImport("openvr_api", CallingConvention = CallingConvention.Cdecl, EntryPoint = "VR_GetGenericInterface")]
	internal static extern IntPtr GetGenericInterface([In][MarshalAs(UnmanagedType.LPStr)] string pchInterfaceVersion, ref EVRInitError peError);

	[DllImport("openvr_api", CallingConvention = CallingConvention.Cdecl, EntryPoint = "VR_IsInterfaceVersionValid")]
	internal static extern bool IsInterfaceVersionValid([In][MarshalAs(UnmanagedType.LPStr)] string pchInterfaceVersion);

	[DllImport("openvr_api", CallingConvention = CallingConvention.Cdecl, EntryPoint = "VR_GetInitToken")]
	internal static extern uint GetInitToken();
}
public enum EVREye
{
	Eye_Left,
	Eye_Right
}
public enum ETextureType
{
	Invalid = -1,
	DirectX,
	OpenGL,
	Vulkan,
	IOSurface,
	DirectX12,
	DXGISharedHandle,
	Metal
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
	Running_OutOfRange = 201,
	Fallback_RotationOnly = 300
}
public enum ETrackedDeviceClass
{
	Invalid,
	HMD,
	Controller,
	GenericTracker,
	TrackingReference,
	DisplayRedirect,
	Max
}
public enum ETrackedControllerRole
{
	Invalid = 0,
	LeftHand = 1,
	RightHand = 2,
	OptOut = 3,
	Treadmill = 4,
	Stylus = 5,
	Max = 5
}
public enum ETrackingUniverseOrigin
{
	TrackingUniverseSeated,
	TrackingUniverseStanding,
	TrackingUniverseRawAndUncalibrated
}
public enum EAdditionalRadioFeatures
{
	None = 0,
	HTCLinkBox = 1,
	InternalDongle = 2,
	ExternalDongle = 4
}
public enum ETrackedDeviceProperty
{
	Prop_Invalid = 0,
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
	Prop_DriverVersion_String = 1031,
	Prop_Firmware_ForceUpdateRequired_Bool = 1032,
	Prop_ViveSystemButtonFixRequired_Bool = 1033,
	Prop_ParentDriver_Uint64 = 1034,
	Prop_ResourceRoot_String = 1035,
	Prop_RegisteredDeviceType_String = 1036,
	Prop_InputProfilePath_String = 1037,
	Prop_NeverTracked_Bool = 1038,
	Prop_NumCameras_Int32 = 1039,
	Prop_CameraFrameLayout_Int32 = 1040,
	Prop_CameraStreamFormat_Int32 = 1041,
	Prop_AdditionalDeviceSettingsPath_String = 1042,
	Prop_Identifiable_Bool = 1043,
	Prop_BootloaderVersion_Uint64 = 1044,
	Prop_AdditionalSystemReportData_String = 1045,
	Prop_CompositeFirmwareVersion_String = 1046,
	Prop_Firmware_RemindUpdate_Bool = 1047,
	Prop_PeripheralApplicationVersion_Uint64 = 1048,
	Prop_ManufacturerSerialNumber_String = 1049,
	Prop_ComputedSerialNumber_String = 1050,
	Prop_EstimatedDeviceFirstUseTime_Int32 = 1051,
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
	Prop_CameraCompatibilityMode_Int32 = 2033,
	Prop_ScreenshotHorizontalFieldOfViewDegrees_Float = 2034,
	Prop_ScreenshotVerticalFieldOfViewDegrees_Float = 2035,
	Prop_DisplaySuppressed_Bool = 2036,
	Prop_DisplayAllowNightMode_Bool = 2037,
	Prop_DisplayMCImageWidth_Int32 = 2038,
	Prop_DisplayMCImageHeight_Int32 = 2039,
	Prop_DisplayMCImageNumChannels_Int32 = 2040,
	Prop_DisplayMCImageData_Binary = 2041,
	Prop_SecondsFromPhotonsToVblank_Float = 2042,
	Prop_DriverDirectModeSendsVsyncEvents_Bool = 2043,
	Prop_DisplayDebugMode_Bool = 2044,
	Prop_GraphicsAdapterLuid_Uint64 = 2045,
	Prop_DriverProvidedChaperonePath_String = 2048,
	Prop_ExpectedTrackingReferenceCount_Int32 = 2049,
	Prop_ExpectedControllerCount_Int32 = 2050,
	Prop_NamedIconPathControllerLeftDeviceOff_String = 2051,
	Prop_NamedIconPathControllerRightDeviceOff_String = 2052,
	Prop_NamedIconPathTrackingReferenceDeviceOff_String = 2053,
	Prop_DoNotApplyPrediction_Bool = 2054,
	Prop_CameraToHeadTransforms_Matrix34_Array = 2055,
	Prop_DistortionMeshResolution_Int32 = 2056,
	Prop_DriverIsDrawingControllers_Bool = 2057,
	Prop_DriverRequestsApplicationPause_Bool = 2058,
	Prop_DriverRequestsReducedRendering_Bool = 2059,
	Prop_MinimumIpdStepMeters_Float = 2060,
	Prop_AudioBridgeFirmwareVersion_Uint64 = 2061,
	Prop_ImageBridgeFirmwareVersion_Uint64 = 2062,
	Prop_ImuToHeadTransform_Matrix34 = 2063,
	Prop_ImuFactoryGyroBias_Vector3 = 2064,
	Prop_ImuFactoryGyroScale_Vector3 = 2065,
	Prop_ImuFactoryAccelerometerBias_Vector3 = 2066,
	Prop_ImuFactoryAccelerometerScale_Vector3 = 2067,
	Prop_ConfigurationIncludesLighthouse20Features_Bool = 2069,
	Prop_AdditionalRadioFeatures_Uint64 = 2070,
	Prop_CameraWhiteBalance_Vector4_Array = 2071,
	Prop_CameraDistortionFunction_Int32_Array = 2072,
	Prop_CameraDistortionCoefficients_Float_Array = 2073,
	Prop_ExpectedControllerType_String = 2074,
	Prop_HmdTrackingStyle_Int32 = 2075,
	Prop_DriverProvidedChaperoneVisibility_Bool = 2076,
	Prop_HmdColumnCorrectionSettingPrefix_String = 2077,
	Prop_CameraSupportsCompatibilityModes_Bool = 2078,
	Prop_SupportsRoomViewDepthProjection_Bool = 2079,
	Prop_DisplayAvailableFrameRates_Float_Array = 2080,
	Prop_DisplaySupportsMultipleFramerates_Bool = 2081,
	Prop_DisplayColorMultLeft_Vector3 = 2082,
	Prop_DisplayColorMultRight_Vector3 = 2083,
	Prop_DisplaySupportsRuntimeFramerateChange_Bool = 2084,
	Prop_DisplaySupportsAnalogGain_Bool = 2085,
	Prop_DisplayMinAnalogGain_Float = 2086,
	Prop_DisplayMaxAnalogGain_Float = 2087,
	Prop_DashboardScale_Float = 2091,
	Prop_IpdUIRangeMinMeters_Float = 2100,
	Prop_IpdUIRangeMaxMeters_Float = 2101,
	Prop_DriverRequestedMuraCorrectionMode_Int32 = 2200,
	Prop_DriverRequestedMuraFeather_InnerLeft_Int32 = 2201,
	Prop_DriverRequestedMuraFeather_InnerRight_Int32 = 2202,
	Prop_DriverRequestedMuraFeather_InnerTop_Int32 = 2203,
	Prop_DriverRequestedMuraFeather_InnerBottom_Int32 = 2204,
	Prop_DriverRequestedMuraFeather_OuterLeft_Int32 = 2205,
	Prop_DriverRequestedMuraFeather_OuterRight_Int32 = 2206,
	Prop_DriverRequestedMuraFeather_OuterTop_Int32 = 2207,
	Prop_DriverRequestedMuraFeather_OuterBottom_Int32 = 2208,
	Prop_Audio_DefaultPlaybackDeviceId_String = 2300,
	Prop_Audio_DefaultRecordingDeviceId_String = 2301,
	Prop_Audio_DefaultPlaybackDeviceVolume_Float = 2302,
	Prop_Audio_SupportsDualSpeakerAndJackOutput_Bool = 2303,
	Prop_AttachedDeviceId_String = 3000,
	Prop_SupportedButtons_Uint64 = 3001,
	Prop_Axis0Type_Int32 = 3002,
	Prop_Axis1Type_Int32 = 3003,
	Prop_Axis2Type_Int32 = 3004,
	Prop_Axis3Type_Int32 = 3005,
	Prop_Axis4Type_Int32 = 3006,
	Prop_ControllerRoleHint_Int32 = 3007,
	Prop_FieldOfViewLeftDegrees_Float = 4000,
	Prop_FieldOfViewRightDegrees_Float = 4001,
	Prop_FieldOfViewTopDegrees_Float = 4002,
	Prop_FieldOfViewBottomDegrees_Float = 4003,
	Prop_TrackingRangeMinimumMeters_Float = 4004,
	Prop_TrackingRangeMaximumMeters_Float = 4005,
	Prop_ModeLabel_String = 4006,
	Prop_CanWirelessIdentify_Bool = 4007,
	Prop_Nonce_Int32 = 4008,
	Prop_IconPathName_String = 5000,
	Prop_NamedIconPathDeviceOff_String = 5001,
	Prop_NamedIconPathDeviceSearching_String = 5002,
	Prop_NamedIconPathDeviceSearchingAlert_String = 5003,
	Prop_NamedIconPathDeviceReady_String = 5004,
	Prop_NamedIconPathDeviceReadyAlert_String = 5005,
	Prop_NamedIconPathDeviceNotReady_String = 5006,
	Prop_NamedIconPathDeviceStandby_String = 5007,
	Prop_NamedIconPathDeviceAlertLow_String = 5008,
	Prop_NamedIconPathDeviceStandbyAlert_String = 5009,
	Prop_DisplayHiddenArea_Binary_Start = 5100,
	Prop_DisplayHiddenArea_Binary_End = 5150,
	Prop_ParentContainer = 5151,
	Prop_OverrideContainer_Uint64 = 5152,
	Prop_UserConfigPath_String = 6000,
	Prop_InstallPath_String = 6001,
	Prop_HasDisplayComponent_Bool = 6002,
	Prop_HasControllerComponent_Bool = 6003,
	Prop_HasCameraComponent_Bool = 6004,
	Prop_HasDriverDirectModeComponent_Bool = 6005,
	Prop_HasVirtualDisplayComponent_Bool = 6006,
	Prop_HasSpatialAnchorsSupport_Bool = 6007,
	Prop_ControllerType_String = 7000,
	Prop_ControllerHandSelectionPriority_Int32 = 7002,
	Prop_VendorSpecific_Reserved_Start = 10000,
	Prop_VendorSpecific_Reserved_End = 10999,
	Prop_TrackedDeviceProperty_Max = 1000000
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
	TrackedProp_NotYetAvailable,
	TrackedProp_PermissionDenied,
	TrackedProp_InvalidOperation,
	TrackedProp_CannotWriteToWildcards,
	TrackedProp_IPCReadFailure,
	TrackedProp_OutOfMemory,
	TrackedProp_InvalidContainer
}
public enum EHmdTrackingStyle
{
	Unknown,
	Lighthouse,
	OutsideInCameras,
	InsideOutCameras
}
public enum EVRSubmitFlags
{
	Submit_Default = 0,
	Submit_LensDistortionAlreadyApplied = 1,
	Submit_GlRenderBuffer = 2,
	Submit_Reserved = 4,
	Submit_TextureWithPose = 8,
	Submit_TextureWithDepth = 0x10,
	Submit_FrameDiscontinuty = 0x20,
	Submit_VulkanTextureWithArrayData = 0x40
}
public enum EVRState
{
	Undefined = -1,
	Off,
	Searching,
	Searching_Alert,
	Ready,
	Ready_Alert,
	NotReady,
	Standby,
	Ready_Alert_Low
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
	VREvent_WatchdogWakeUpRequested = 109,
	VREvent_LensDistortionChanged = 110,
	VREvent_PropertyChanged = 111,
	VREvent_WirelessDisconnect = 112,
	VREvent_WirelessReconnect = 113,
	VREvent_ButtonPress = 200,
	VREvent_ButtonUnpress = 201,
	VREvent_ButtonTouch = 202,
	VREvent_ButtonUntouch = 203,
	VREvent_Modal_Cancel = 257,
	VREvent_MouseMove = 300,
	VREvent_MouseButtonDown = 301,
	VREvent_MouseButtonUp = 302,
	VREvent_FocusEnter = 303,
	VREvent_FocusLeave = 304,
	VREvent_ScrollDiscrete = 305,
	VREvent_TouchPadMove = 306,
	VREvent_OverlayFocusChanged = 307,
	VREvent_ReloadOverlays = 308,
	VREvent_ScrollSmooth = 309,
	VREvent_LockMousePosition = 310,
	VREvent_UnlockMousePosition = 311,
	VREvent_InputFocusCaptured = 400,
	VREvent_InputFocusReleased = 401,
	VREvent_SceneApplicationChanged = 404,
	VREvent_SceneFocusChanged = 405,
	VREvent_InputFocusChanged = 406,
	VREvent_SceneApplicationUsingWrongGraphicsAdapter = 408,
	VREvent_ActionBindingReloaded = 409,
	VREvent_HideRenderModels = 410,
	VREvent_ShowRenderModels = 411,
	VREvent_SceneApplicationStateChanged = 412,
	VREvent_ConsoleOpened = 420,
	VREvent_ConsoleClosed = 421,
	VREvent_OverlayShown = 500,
	VREvent_OverlayHidden = 501,
	VREvent_DashboardActivated = 502,
	VREvent_DashboardDeactivated = 503,
	VREvent_DashboardRequested = 505,
	VREvent_ResetDashboard = 506,
	VREvent_ImageLoaded = 508,
	VREvent_ShowKeyboard = 509,
	VREvent_HideKeyboard = 510,
	VREvent_OverlayGamepadFocusGained = 511,
	VREvent_OverlayGamepadFocusLost = 512,
	VREvent_OverlaySharedTextureChanged = 513,
	VREvent_ScreenshotTriggered = 516,
	VREvent_ImageFailed = 517,
	VREvent_DashboardOverlayCreated = 518,
	VREvent_SwitchGamepadFocus = 519,
	VREvent_RequestScreenshot = 520,
	VREvent_ScreenshotTaken = 521,
	VREvent_ScreenshotFailed = 522,
	VREvent_SubmitScreenshotToDashboard = 523,
	VREvent_ScreenshotProgressToDashboard = 524,
	VREvent_PrimaryDashboardDeviceChanged = 525,
	VREvent_RoomViewShown = 526,
	VREvent_RoomViewHidden = 527,
	VREvent_ShowUI = 528,
	VREvent_ShowDevTools = 529,
	VREvent_DesktopViewUpdating = 530,
	VREvent_DesktopViewReady = 531,
	VREvent_Notification_Shown = 600,
	VREvent_Notification_Hidden = 601,
	VREvent_Notification_BeginInteraction = 602,
	VREvent_Notification_Destroyed = 603,
	VREvent_Quit = 700,
	VREvent_ProcessQuit = 701,
	VREvent_QuitAcknowledged = 703,
	VREvent_DriverRequestedQuit = 704,
	VREvent_RestartRequested = 705,
	VREvent_ChaperoneDataHasChanged = 800,
	VREvent_ChaperoneUniverseHasChanged = 801,
	VREvent_ChaperoneTempDataHasChanged = 802,
	VREvent_ChaperoneSettingsHaveChanged = 803,
	VREvent_SeatedZeroPoseReset = 804,
	VREvent_ChaperoneFlushCache = 805,
	VREvent_ChaperoneRoomSetupStarting = 806,
	VREvent_ChaperoneRoomSetupFinished = 807,
	VREvent_StandingZeroPoseReset = 808,
	VREvent_AudioSettingsHaveChanged = 820,
	VREvent_BackgroundSettingHasChanged = 850,
	VREvent_CameraSettingsHaveChanged = 851,
	VREvent_ReprojectionSettingHasChanged = 852,
	VREvent_ModelSkinSettingsHaveChanged = 853,
	VREvent_EnvironmentSettingsHaveChanged = 854,
	VREvent_PowerSettingsHaveChanged = 855,
	VREvent_EnableHomeAppSettingsHaveChanged = 856,
	VREvent_SteamVRSectionSettingChanged = 857,
	VREvent_LighthouseSectionSettingChanged = 858,
	VREvent_NullSectionSettingChanged = 859,
	VREvent_UserInterfaceSectionSettingChanged = 860,
	VREvent_NotificationsSectionSettingChanged = 861,
	VREvent_KeyboardSectionSettingChanged = 862,
	VREvent_PerfSectionSettingChanged = 863,
	VREvent_DashboardSectionSettingChanged = 864,
	VREvent_WebInterfaceSectionSettingChanged = 865,
	VREvent_TrackersSectionSettingChanged = 866,
	VREvent_LastKnownSectionSettingChanged = 867,
	VREvent_DismissedWarningsSectionSettingChanged = 868,
	VREvent_GpuSpeedSectionSettingChanged = 869,
	VREvent_WindowsMRSectionSettingChanged = 870,
	VREvent_OtherSectionSettingChanged = 871,
	VREvent_StatusUpdate = 900,
	VREvent_WebInterface_InstallDriverCompleted = 950,
	VREvent_MCImageUpdated = 1000,
	VREvent_FirmwareUpdateStarted = 1100,
	VREvent_FirmwareUpdateFinished = 1101,
	VREvent_KeyboardClosed = 1200,
	VREvent_KeyboardCharInput = 1201,
	VREvent_KeyboardDone = 1202,
	VREvent_ApplicationListUpdated = 1303,
	VREvent_ApplicationMimeTypeLoad = 1304,
	VREvent_ProcessConnected = 1306,
	VREvent_ProcessDisconnected = 1307,
	VREvent_Compositor_ChaperoneBoundsShown = 1410,
	VREvent_Compositor_ChaperoneBoundsHidden = 1411,
	VREvent_Compositor_DisplayDisconnected = 1412,
	VREvent_Compositor_DisplayReconnected = 1413,
	VREvent_Compositor_HDCPError = 1414,
	VREvent_Compositor_ApplicationNotResponding = 1415,
	VREvent_Compositor_ApplicationResumed = 1416,
	VREvent_Compositor_OutOfVideoMemory = 1417,
	VREvent_Compositor_DisplayModeNotSupported = 1418,
	VREvent_Compositor_StageOverrideReady = 1419,
	VREvent_TrackedCamera_StartVideoStream = 1500,
	VREvent_TrackedCamera_StopVideoStream = 1501,
	VREvent_TrackedCamera_PauseVideoStream = 1502,
	VREvent_TrackedCamera_ResumeVideoStream = 1503,
	VREvent_TrackedCamera_EditingSurface = 1550,
	VREvent_PerformanceTest_EnableCapture = 1600,
	VREvent_PerformanceTest_DisableCapture = 1601,
	VREvent_PerformanceTest_FidelityLevel = 1602,
	VREvent_MessageOverlay_Closed = 1650,
	VREvent_MessageOverlayCloseRequested = 1651,
	VREvent_Input_HapticVibration = 1700,
	VREvent_Input_BindingLoadFailed = 1701,
	VREvent_Input_BindingLoadSuccessful = 1702,
	VREvent_Input_ActionManifestReloaded = 1703,
	VREvent_Input_ActionManifestLoadFailed = 1704,
	VREvent_Input_ProgressUpdate = 1705,
	VREvent_Input_TrackerActivated = 1706,
	VREvent_Input_BindingsUpdated = 1707,
	VREvent_Input_BindingSubscriptionChanged = 1708,
	VREvent_SpatialAnchors_PoseUpdated = 1800,
	VREvent_SpatialAnchors_DescriptorUpdated = 1801,
	VREvent_SpatialAnchors_RequestPoseUpdate = 1802,
	VREvent_SpatialAnchors_RequestDescriptorUpdate = 1803,
	VREvent_SystemReport_Started = 1900,
	VREvent_Monitor_ShowHeadsetView = 2000,
	VREvent_Monitor_HideHeadsetView = 2001,
	VREvent_VendorSpecific_Reserved_Start = 10000,
	VREvent_VendorSpecific_Reserved_End = 19999
}
public enum EDeviceActivityLevel
{
	k_EDeviceActivityLevel_Unknown = -1,
	k_EDeviceActivityLevel_Idle,
	k_EDeviceActivityLevel_UserInteraction,
	k_EDeviceActivityLevel_UserInteraction_Timeout,
	k_EDeviceActivityLevel_Standby,
	k_EDeviceActivityLevel_Idle_Timeout
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
	k_EButton_ProximitySensor = 31,
	k_EButton_Axis0 = 32,
	k_EButton_Axis1 = 33,
	k_EButton_Axis2 = 34,
	k_EButton_Axis3 = 35,
	k_EButton_Axis4 = 36,
	k_EButton_SteamVR_Touchpad = 32,
	k_EButton_SteamVR_Trigger = 33,
	k_EButton_Dashboard_Back = 2,
	k_EButton_IndexController_A = 2,
	k_EButton_IndexController_B = 1,
	k_EButton_IndexController_JoyStick = 35,
	k_EButton_Max = 64
}
public enum EVRMouseButton
{
	Left = 1,
	Right = 2,
	Middle = 4
}
public enum EShowUIType
{
	ShowUI_ControllerBinding = 0,
	ShowUI_ManageTrackers = 1,
	ShowUI_Pairing = 3,
	ShowUI_Settings = 4,
	ShowUI_DebugCommands = 5,
	ShowUI_FullControllerBinding = 6,
	ShowUI_ManageDrivers = 7
}
public enum EHDCPError
{
	None,
	LinkLost,
	Tampered,
	DeviceRevoked,
	Unknown
}
public enum EVRComponentProperty
{
	IsStatic = 1,
	IsVisible = 2,
	IsTouched = 4,
	IsPressed = 8,
	IsScrolled = 0x10,
	IsHighlighted = 0x20
}
public enum EVRInputError
{
	None,
	NameNotFound,
	WrongType,
	InvalidHandle,
	InvalidParam,
	NoSteam,
	MaxCapacityReached,
	IPCError,
	NoActiveActionSet,
	InvalidDevice,
	InvalidSkeleton,
	InvalidBoneCount,
	InvalidCompressedData,
	NoData,
	BufferTooSmall,
	MismatchedActionManifest,
	MissingSkeletonData,
	InvalidBoneIndex,
	InvalidPriority,
	PermissionDenied,
	InvalidRenderModel
}
public enum EVRSpatialAnchorError
{
	Success,
	Internal,
	UnknownHandle,
	ArrayTooSmall,
	InvalidDescriptorChar,
	NotYetAvailable,
	NotAvailableInThisUniverse,
	PermanentlyUnavailable,
	WrongDriver,
	DescriptorTooLong,
	Unknown,
	NoRoomCalibration,
	InvalidArgument,
	UnknownDriver
}
public enum EHiddenAreaMeshType
{
	k_eHiddenAreaMesh_Standard,
	k_eHiddenAreaMesh_Inverse,
	k_eHiddenAreaMesh_LineLoop,
	k_eHiddenAreaMesh_Max
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
	KeyboardAlreadyInUse = 26,
	NoNeighbor = 27,
	TooManyMaskPrimitives = 29,
	BadMaskPrimitive = 30,
	TextureAlreadyLocked = 31,
	TextureLockCapacityReached = 32,
	TextureNotLocked = 33
}
public enum EVRApplicationType
{
	VRApplication_Other,
	VRApplication_Scene,
	VRApplication_Overlay,
	VRApplication_Background,
	VRApplication_Utility,
	VRApplication_VRMonitor,
	VRApplication_SteamWatchdog,
	VRApplication_Bootstrapper,
	VRApplication_WebHelper,
	VRApplication_OpenXR,
	VRApplication_Max
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
	InvalidOverlayHandle = 102,
	SystemWithUserValueAlreadyExists = 103
}
public enum EVRSkeletalMotionRange
{
	WithController,
	WithoutController
}
public enum EVRSkeletalTrackingLevel
{
	VRSkeletalTracking_Estimated = 0,
	VRSkeletalTracking_Partial = 1,
	VRSkeletalTracking_Full = 2,
	Count = 3,
	Max = 2
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
	Init_Internal = 124,
	Init_HmdDriverIdIsNone = 125,
	Init_HmdNotFoundPresenceFailed = 126,
	Init_VRMonitorNotFound = 127,
	Init_VRMonitorStartupFailed = 128,
	Init_LowPowerWatchdogNotSupported = 129,
	Init_InvalidApplicationType = 130,
	Init_NotAvailableToWatchdogApps = 131,
	Init_WatchdogDisabledInSettings = 132,
	Init_VRDashboardNotFound = 133,
	Init_VRDashboardStartupFailed = 134,
	Init_VRHomeNotFound = 135,
	Init_VRHomeStartupFailed = 136,
	Init_RebootingBusy = 137,
	Init_FirmwareUpdateBusy = 138,
	Init_FirmwareRecoveryBusy = 139,
	Init_USBServiceBusy = 140,
	Init_VRWebHelperStartupFailed = 141,
	Init_TrackerManagerInitFailed = 142,
	Init_AlreadyRunning = 143,
	Init_FailedForVrMonitor = 144,
	Init_PropertyManagerInitFailed = 145,
	Init_WebServerFailed = 146,
	Driver_Failed = 200,
	Driver_Unknown = 201,
	Driver_HmdUnknown = 202,
	Driver_NotLoaded = 203,
	Driver_RuntimeOutOfDate = 204,
	Driver_HmdInUse = 205,
	Driver_NotCalibrated = 206,
	Driver_CalibrationInvalid = 207,
	Driver_HmdDisplayNotFound = 208,
	Driver_TrackedDeviceInterfaceUnknown = 209,
	Driver_HmdDriverIdOutOfBounds = 211,
	Driver_HmdDisplayMirrored = 212,
	Driver_HmdDisplayNotFoundLaptop = 213,
	IPC_ServerInitFailed = 300,
	IPC_ConnectFailed = 301,
	IPC_SharedStateInitFailed = 302,
	IPC_CompositorInitFailed = 303,
	IPC_MutexInitFailed = 304,
	IPC_Failed = 305,
	IPC_CompositorConnectFailed = 306,
	IPC_CompositorInvalidConnectResponse = 307,
	IPC_ConnectFailedAfterMultipleAttempts = 308,
	IPC_ConnectFailedAfterTargetExited = 309,
	IPC_NamespaceUnavailable = 310,
	Compositor_Failed = 400,
	Compositor_D3D11HardwareRequired = 401,
	Compositor_FirmwareRequiresUpdate = 402,
	Compositor_OverlayInitFailed = 403,
	Compositor_ScreenshotsInitFailed = 404,
	Compositor_UnableToCreateDevice = 405,
	Compositor_SharedStateIsNull = 406,
	Compositor_NotificationManagerIsNull = 407,
	Compositor_ResourceManagerClientIsNull = 408,
	Compositor_MessageOverlaySharedStateInitFailure = 409,
	Compositor_PropertiesInterfaceIsNull = 410,
	Compositor_CreateFullscreenWindowFailed = 411,
	Compositor_SettingsInterfaceIsNull = 412,
	Compositor_FailedToShowWindow = 413,
	Compositor_DistortInterfaceIsNull = 414,
	Compositor_DisplayFrequencyFailure = 415,
	Compositor_RendererInitializationFailed = 416,
	Compositor_DXGIFactoryInterfaceIsNull = 417,
	Compositor_DXGIFactoryCreateFailed = 418,
	Compositor_DXGIFactoryQueryFailed = 419,
	Compositor_InvalidAdapterDesktop = 420,
	Compositor_InvalidHmdAttachment = 421,
	Compositor_InvalidOutputDesktop = 422,
	Compositor_InvalidDeviceProvided = 423,
	Compositor_D3D11RendererInitializationFailed = 424,
	Compositor_FailedToFindDisplayMode = 425,
	Compositor_FailedToCreateSwapChain = 426,
	Compositor_FailedToGetBackBuffer = 427,
	Compositor_FailedToCreateRenderTarget = 428,
	Compositor_FailedToCreateDXGI2SwapChain = 429,
	Compositor_FailedtoGetDXGI2BackBuffer = 430,
	Compositor_FailedToCreateDXGI2RenderTarget = 431,
	Compositor_FailedToGetDXGIDeviceInterface = 432,
	Compositor_SelectDisplayMode = 433,
	Compositor_FailedToCreateNvAPIRenderTargets = 434,
	Compositor_NvAPISetDisplayMode = 435,
	Compositor_FailedToCreateDirectModeDisplay = 436,
	Compositor_InvalidHmdPropertyContainer = 437,
	Compositor_UpdateDisplayFrequency = 438,
	Compositor_CreateRasterizerState = 439,
	Compositor_CreateWireframeRasterizerState = 440,
	Compositor_CreateSamplerState = 441,
	Compositor_CreateClampToBorderSamplerState = 442,
	Compositor_CreateAnisoSamplerState = 443,
	Compositor_CreateOverlaySamplerState = 444,
	Compositor_CreatePanoramaSamplerState = 445,
	Compositor_CreateFontSamplerState = 446,
	Compositor_CreateNoBlendState = 447,
	Compositor_CreateBlendState = 448,
	Compositor_CreateAlphaBlendState = 449,
	Compositor_CreateBlendStateMaskR = 450,
	Compositor_CreateBlendStateMaskG = 451,
	Compositor_CreateBlendStateMaskB = 452,
	Compositor_CreateDepthStencilState = 453,
	Compositor_CreateDepthStencilStateNoWrite = 454,
	Compositor_CreateDepthStencilStateNoDepth = 455,
	Compositor_CreateFlushTexture = 456,
	Compositor_CreateDistortionSurfaces = 457,
	Compositor_CreateConstantBuffer = 458,
	Compositor_CreateHmdPoseConstantBuffer = 459,
	Compositor_CreateHmdPoseStagingConstantBuffer = 460,
	Compositor_CreateSharedFrameInfoConstantBuffer = 461,
	Compositor_CreateOverlayConstantBuffer = 462,
	Compositor_CreateSceneTextureIndexConstantBuffer = 463,
	Compositor_CreateReadableSceneTextureIndexConstantBuffer = 464,
	Compositor_CreateLayerGraphicsTextureIndexConstantBuffer = 465,
	Compositor_CreateLayerComputeTextureIndexConstantBuffer = 466,
	Compositor_CreateLayerComputeSceneTextureIndexConstantBuffer = 467,
	Compositor_CreateComputeHmdPoseConstantBuffer = 468,
	Compositor_CreateGeomConstantBuffer = 469,
	Compositor_CreatePanelMaskConstantBuffer = 470,
	Compositor_CreatePixelSimUBO = 471,
	Compositor_CreateMSAARenderTextures = 472,
	Compositor_CreateResolveRenderTextures = 473,
	Compositor_CreateComputeResolveRenderTextures = 474,
	Compositor_CreateDriverDirectModeResolveTextures = 475,
	Compositor_OpenDriverDirectModeResolveTextures = 476,
	Compositor_CreateFallbackSyncTexture = 477,
	Compositor_ShareFallbackSyncTexture = 478,
	Compositor_CreateOverlayIndexBuffer = 479,
	Compositor_CreateOverlayVertexBuffer = 480,
	Compositor_CreateTextVertexBuffer = 481,
	Compositor_CreateTextIndexBuffer = 482,
	Compositor_CreateMirrorTextures = 483,
	Compositor_CreateLastFrameRenderTexture = 484,
	Compositor_CreateMirrorOverlay = 485,
	Compositor_FailedToCreateVirtualDisplayBackbuffer = 486,
	Compositor_DisplayModeNotSupported = 487,
	Compositor_CreateOverlayInvalidCall = 488,
	Compositor_CreateOverlayAlreadyInitialized = 489,
	Compositor_FailedToCreateMailbox = 490,
	VendorSpecific_UnableToConnectToOculusRuntime = 1000,
	VendorSpecific_WindowsNotInDevMode = 1001,
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
	VendorSpecific_OculusRuntimeBadInstall = 1114,
	Steam_SteamInstallationNotFound = 2000,
	LastError = 2001
}
public enum EVRScreenshotType
{
	None,
	Mono,
	Stereo,
	Cubemap,
	MonoPanorama,
	StereoPanorama
}
public enum EVRScreenshotPropertyFilenames
{
	Preview,
	VR
}
public enum EVRTrackedCameraError
{
	None = 0,
	OperationFailed = 100,
	InvalidHandle = 101,
	InvalidFrameHeaderVersion = 102,
	OutOfHandles = 103,
	IPCFailure = 104,
	NotSupportedForThisDevice = 105,
	SharedMemoryFailure = 106,
	FrameBufferingFailure = 107,
	StreamSetupFailure = 108,
	InvalidGLTextureId = 109,
	InvalidSharedTextureHandle = 110,
	FailedToGetGLTextureId = 111,
	SharedTextureFailure = 112,
	NoFrameAvailable = 113,
	InvalidArgument = 114,
	InvalidFrameBufferSize = 115
}
public enum EVRTrackedCameraFrameLayout
{
	Mono = 1,
	Stereo = 2,
	VerticalLayout = 0x10,
	HorizontalLayout = 0x20
}
public enum EVRTrackedCameraFrameType
{
	Distorted,
	Undistorted,
	MaximumUndistorted,
	MAX_CAMERA_FRAME_TYPES
}
public enum EVRDistortionFunctionType
{
	None,
	FTheta,
	Extended_FTheta,
	MAX_DISTORTION_FUNCTION_TYPES
}
public enum EVSync
{
	None,
	WaitRender,
	NoWaitRender
}
public enum EVRMuraCorrectionMode
{
	Default,
	NoCorrection
}
public enum Imu_OffScaleFlags
{
	OffScale_AccelX = 1,
	OffScale_AccelY = 2,
	OffScale_AccelZ = 4,
	OffScale_GyroX = 8,
	OffScale_GyroY = 0x10,
	OffScale_GyroZ = 0x20
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
	IsTemplate = 114,
	SteamVRIsExiting = 115,
	BufferTooSmall = 200,
	PropertyNotSet = 201,
	UnknownProperty = 202,
	InvalidParameter = 203
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
	ActionManifestURL_String = 54,
	IsDashboardOverlay_Bool = 60,
	IsTemplate_Bool = 61,
	IsInstanced_Bool = 62,
	IsInternal_Bool = 63,
	WantsCompositorPauseInStandby_Bool = 64,
	IsHidden_Bool = 65,
	LastLaunchTime_Uint64 = 70
}
public enum EVRSceneApplicationState
{
	None,
	Starting,
	Quitting,
	Running,
	Waiting
}
public enum ChaperoneCalibrationState
{
	OK = 1,
	Warning = 100,
	Warning_BaseStationMayHaveMoved = 101,
	Warning_BaseStationRemoved = 102,
	Warning_SeatedBoundsInvalid = 103,
	Error = 200,
	Error_BaseStationUninitialized = 201,
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
	RequestFailed = 1,
	IncompatibleVersion = 100,
	DoNotHaveFocus = 101,
	InvalidTexture = 102,
	IsNotSceneApplication = 103,
	TextureIsOnWrongDevice = 104,
	TextureUsesUnsupportedFormat = 105,
	SharedTexturesNotSupported = 106,
	IndexOutOfRange = 107,
	AlreadySubmitted = 108,
	InvalidBounds = 109,
	AlreadySet = 110
}
public enum EVRCompositorTimingMode
{
	Implicit,
	Explicit_RuntimePerformsPostPresentHandoff,
	Explicit_ApplicationPerformsPostPresentHandoff
}
public enum VROverlayInputMethod
{
	None,
	Mouse
}
public enum VROverlayTransformType
{
	VROverlayTransform_Invalid = -1,
	VROverlayTransform_Absolute,
	VROverlayTransform_TrackedDeviceRelative,
	VROverlayTransform_SystemOverlay,
	VROverlayTransform_TrackedComponent,
	VROverlayTransform_Cursor,
	VROverlayTransform_DashboardTab,
	VROverlayTransform_DashboardThumb,
	VROverlayTransform_Mountable
}
public enum VROverlayFlags
{
	NoDashboardTab = 8,
	SendVRDiscreteScrollEvents = 0x40,
	SendVRTouchpadEvents = 0x80,
	ShowTouchPadScrollWheel = 0x100,
	TransferOwnershipToInternalProcess = 0x200,
	SideBySide_Parallel = 0x400,
	SideBySide_Crossed = 0x800,
	Panorama = 0x1000,
	StereoPanorama = 0x2000,
	SortWithNonSceneOverlays = 0x4000,
	VisibleInDashboard = 0x8000,
	MakeOverlaysInteractiveIfVisible = 0x10000,
	SendVRSmoothScrollEvents = 0x20000,
	ProtectedContent = 0x40000,
	HideLaserIntersection = 0x80000,
	WantsModalBehavior = 0x100000,
	IsPremultiplied = 0x200000
}
public enum VRMessageOverlayResponse
{
	ButtonPress_0,
	ButtonPress_1,
	ButtonPress_2,
	ButtonPress_3,
	CouldntFindSystemOverlay,
	CouldntFindOrCreateClientOverlay,
	ApplicationQuit
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
public enum EVROverlayIntersectionMaskPrimitiveType
{
	OverlayIntersectionPrimitiveType_Rectangle,
	OverlayIntersectionPrimitiveType_Circle
}
public enum EKeyboardFlags
{
	KeyboardFlag_Minimal = 1,
	KeyboardFlag_Modal
}
public enum EDeviceType
{
	Invalid = -1,
	DirectX11,
	Vulkan
}
public enum HeadsetViewMode_t
{
	HeadsetViewMode_Left,
	HeadsetViewMode_Right,
	HeadsetViewMode_Both
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
	TooManyVertices = 304,
	MultipleTextures = 305,
	BufferTooSmall = 306,
	NotEnoughNormals = 307,
	NotEnoughTexCoords = 308,
	InvalidTexture = 400
}
public enum EVRRenderModelTextureFormat
{
	RGBA8_SRGB,
	BC2,
	BC4,
	BC7,
	BC7_SRGB
}
public enum EVRNotificationType
{
	Transient,
	Persistent,
	Transient_SystemWithUserValue
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
	ReadFailed,
	JsonParseFailed,
	UnsetSettingHasNoDefault
}
public enum EVRScreenshotError
{
	None = 0,
	RequestFailed = 1,
	IncompatibleVersion = 100,
	NotFound = 101,
	BufferTooSmall = 102,
	ScreenshotAlreadyInProgress = 108
}
public enum EVRSkeletalTransformSpace
{
	Model,
	Parent
}
public enum EVRSkeletalReferencePose
{
	BindPose,
	OpenHand,
	Fist,
	GripLimit
}
public enum EVRFinger
{
	Thumb,
	Index,
	Middle,
	Ring,
	Pinky,
	Count
}
public enum EVRFingerSplay
{
	Thumb_Index,
	Index_Middle,
	Middle_Ring,
	Ring_Pinky,
	Count
}
public enum EVRSummaryType
{
	FromAnimation,
	FromDevice
}
public enum EVRInputFilterCancelType
{
	VRInputFilterCancel_Timers,
	VRInputFilterCancel_Momentum
}
public enum EVRInputStringBits
{
	VRInputString_Hand = 1,
	VRInputString_ControllerType = 2,
	VRInputString_InputSource = 4,
	VRInputString_All = -1
}
public enum EIOBufferError
{
	IOBuffer_Success = 0,
	IOBuffer_OperationFailed = 100,
	IOBuffer_InvalidHandle = 101,
	IOBuffer_InvalidArgument = 102,
	IOBuffer_PathExists = 103,
	IOBuffer_PathDoesNotExist = 104,
	IOBuffer_Permission = 105
}
public enum EIOBufferMode
{
	Read = 1,
	Write = 2,
	Create = 0x200
}
public enum EVRDebugError
{
	Success,
	BadParameter
}
public enum EPropertyWriteType
{
	PropertyWrite_Set,
	PropertyWrite_Erase,
	PropertyWrite_SetError
}
public enum EBlockQueueError
{
	None,
	QueueAlreadyExists,
	QueueNotFound,
	BlockNotAvailable,
	InvalidHandle,
	InvalidParam,
	ParamMismatch,
	InternalError,
	AlreadyInitialized,
	OperationIsServerOnly,
	TooManyConnections
}
public enum EBlockQueueReadType
{
	BlockQueueRead_Latest,
	BlockQueueRead_New,
	BlockQueueRead_Next
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
	public VREvent_Screenshot_t screenshot;

	[FieldOffset(0)]
	public VREvent_ScreenshotProgress_t screenshotProgress;

	[FieldOffset(0)]
	public VREvent_ApplicationLaunch_t applicationLaunch;

	[FieldOffset(0)]
	public VREvent_EditingCameraSurface_t cameraSurface;

	[FieldOffset(0)]
	public VREvent_MessageOverlay_t messageOverlay;

	[FieldOffset(0)]
	public VREvent_Property_t property;

	[FieldOffset(0)]
	public VREvent_HapticVibration_t hapticVibration;

	[FieldOffset(0)]
	public VREvent_WebConsole_t webConsole;

	[FieldOffset(0)]
	public VREvent_InputBindingLoad_t inputBinding;

	[FieldOffset(0)]
	public VREvent_SpatialAnchor_t spatialAnchor;

	[FieldOffset(0)]
	public VREvent_InputActionManifestLoad_t actionManifest;

	[FieldOffset(0)]
	public VREvent_ProgressUpdate_t progressUpdate;

	[FieldOffset(0)]
	public VREvent_ShowUI_t showUi;

	[FieldOffset(0)]
	public VREvent_ShowDevTools_t showDevTools;

	[FieldOffset(0)]
	public VREvent_HDCPError_t hdcpError;

	[FieldOffset(0)]
	public VREvent_Keyboard_t keyboard;
}
[StructLayout(LayoutKind.Explicit)]
public struct VROverlayIntersectionMaskPrimitive_Data_t
{
	[FieldOffset(0)]
	public IntersectionMaskRectangle_t m_Rectangle;

	[FieldOffset(0)]
	public IntersectionMaskCircle_t m_Circle;
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

	public Vector3 GetPosition()
	{
		return new Vector3(m3, m7, 0f - m11);
	}

	public bool IsRotationValid()
	{
		if (m2 != 0f || m6 != 0f || m10 != 0f)
		{
			if (m1 == 0f && m5 == 0f)
			{
				return m9 != 0f;
			}
			return true;
		}
		return false;
	}

	public Quaternion GetRotation()
	{
		if (IsRotationValid())
		{
			float w = Mathf.Sqrt(Mathf.Max(0f, 1f + m0 + m5 + m10)) / 2f;
			float sizeval = Mathf.Sqrt(Mathf.Max(0f, 1f + m0 - m5 - m10)) / 2f;
			float sizeval2 = Mathf.Sqrt(Mathf.Max(0f, 1f - m0 + m5 - m10)) / 2f;
			float sizeval3 = Mathf.Sqrt(Mathf.Max(0f, 1f - m0 - m5 + m10)) / 2f;
			_copysign(ref sizeval, 0f - m9 - (0f - m6));
			_copysign(ref sizeval2, 0f - m2 - (0f - m8));
			_copysign(ref sizeval3, m4 - m1);
			return new Quaternion(sizeval, sizeval2, sizeval3, w);
		}
		return Quaternion.identity;
	}

	private static void _copysign(ref float sizeval, float signval)
	{
		if (signval > 0f != sizeval > 0f)
		{
			sizeval = 0f - sizeval;
		}
	}
}
public struct HmdMatrix33_t
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
public struct HmdQuaternionf_t
{
	public float w;

	public float x;

	public float y;

	public float z;
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

	public ETextureType eType;

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
public struct VRTextureWithPose_t
{
	public IntPtr handle;

	public ETextureType eType;

	public EColorSpace eColorSpace;

	public HmdMatrix34_t mDeviceToAbsoluteTracking;
}
public struct VRTextureDepthInfo_t
{
	public IntPtr handle;

	public HmdMatrix44_t mProjection;

	public HmdVector2_t vRange;
}
public struct VRTextureWithDepth_t
{
	public IntPtr handle;

	public ETextureType eType;

	public EColorSpace eColorSpace;

	public VRTextureDepthInfo_t depth;
}
public struct VRTextureWithPoseAndDepth_t
{
	public IntPtr handle;

	public ETextureType eType;

	public EColorSpace eColorSpace;

	public HmdMatrix34_t mDeviceToAbsoluteTracking;

	public VRTextureDepthInfo_t depth;
}
public struct VRVulkanTextureData_t
{
	public ulong m_nImage;

	public IntPtr m_pDevice;

	public IntPtr m_pPhysicalDevice;

	public IntPtr m_pInstance;

	public IntPtr m_pQueue;

	public uint m_nQueueFamilyIndex;

	public uint m_nWidth;

	public uint m_nHeight;

	public uint m_nFormat;

	public uint m_nSampleCount;
}
public struct VRVulkanTextureArrayData_t
{
	public uint m_unArrayIndex;

	public uint m_unArraySize;
}
public struct D3D12TextureData_t
{
	public IntPtr m_pResource;

	public IntPtr m_pCommandQueue;

	public uint m_nNodeMask;
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

	public uint unused;

	public float viewportscale;
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

	[MarshalAs(UnmanagedType.I1)]
	public bool bConnectionLost;
}
public struct VREvent_Overlay_t
{
	public ulong overlayHandle;

	public ulong devicePath;
}
public struct VREvent_Status_t
{
	public uint statusState;
}
public struct VREvent_Keyboard_t
{
	public byte cNewInput0;

	public byte cNewInput1;

	public byte cNewInput2;

	public byte cNewInput3;

	public byte cNewInput4;

	public byte cNewInput5;

	public byte cNewInput6;

	public byte cNewInput7;

	public ulong uUserValue;

	public string cNewInput => new string(new char[8]
	{
		(char)cNewInput0,
		(char)cNewInput1,
		(char)cNewInput2,
		(char)cNewInput3,
		(char)cNewInput4,
		(char)cNewInput5,
		(char)cNewInput6,
		(char)cNewInput7
	}).TrimEnd('\0');
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

	public ulong reserved2;

	public ulong reserved3;

	public ulong reserved4;

	public ulong reserved5;
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
public struct VREvent_Screenshot_t
{
	public uint handle;

	public uint type;
}
public struct VREvent_ScreenshotProgress_t
{
	public float progress;
}
public struct VREvent_ApplicationLaunch_t
{
	public uint pid;

	public uint unArgsHandle;
}
public struct VREvent_EditingCameraSurface_t
{
	public ulong overlayHandle;

	public uint nVisualMode;
}
public struct VREvent_MessageOverlay_t
{
	public uint unVRMessageOverlayResponse;
}
public struct VREvent_Property_t
{
	public ulong container;

	public ETrackedDeviceProperty prop;
}
public struct VREvent_HapticVibration_t
{
	public ulong containerHandle;

	public ulong componentHandle;

	public float fDurationSeconds;

	public float fFrequency;

	public float fAmplitude;
}
public struct VREvent_WebConsole_t
{
	public ulong webConsoleHandle;
}
public struct VREvent_InputBindingLoad_t
{
	public ulong ulAppContainer;

	public ulong pathMessage;

	public ulong pathUrl;

	public ulong pathControllerType;
}
public struct VREvent_InputActionManifestLoad_t
{
	public ulong pathAppKey;

	public ulong pathMessage;

	public ulong pathMessageParam;

	public ulong pathManifestPath;
}
public struct VREvent_SpatialAnchor_t
{
	public uint unHandle;
}
public struct VREvent_ProgressUpdate_t
{
	public ulong ulApplicationPropertyContainer;

	public ulong pathDevice;

	public ulong pathInputSource;

	public ulong pathProgressAction;

	public ulong pathIcon;

	public float fProgress;
}
public struct VREvent_ShowUI_t
{
	public EShowUIType eType;
}
public struct VREvent_ShowDevTools_t
{
	public int nBrowserIdentifier;
}
public struct VREvent_HDCPError_t
{
	public EHDCPError eCode;
}
public struct VREvent_t
{
	public uint eventType;

	public uint trackedDeviceIndex;

	public float eventAgeSeconds;

	public VREvent_Data_t data;
}
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct VREvent_t_Packed
{
	public uint eventType;

	public uint trackedDeviceIndex;

	public float eventAgeSeconds;

	public VREvent_Data_t data;

	public VREvent_t_Packed(VREvent_t unpacked)
	{
		eventType = unpacked.eventType;
		trackedDeviceIndex = unpacked.trackedDeviceIndex;
		eventAgeSeconds = unpacked.eventAgeSeconds;
		data = unpacked.data;
	}

	public void Unpack(ref VREvent_t unpacked)
	{
		unpacked.eventType = eventType;
		unpacked.trackedDeviceIndex = trackedDeviceIndex;
		unpacked.eventAgeSeconds = eventAgeSeconds;
		unpacked.data = data;
	}
}
public struct RenderModel_ComponentState_t
{
	public HmdMatrix34_t mTrackingToComponentRenderModel;

	public HmdMatrix34_t mTrackingToComponentLocal;

	public uint uProperties;
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
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct VRControllerState_t_Packed
{
	public uint unPacketNum;

	public ulong ulButtonPressed;

	public ulong ulButtonTouched;

	public VRControllerAxis_t rAxis0;

	public VRControllerAxis_t rAxis1;

	public VRControllerAxis_t rAxis2;

	public VRControllerAxis_t rAxis3;

	public VRControllerAxis_t rAxis4;

	public VRControllerState_t_Packed(VRControllerState_t unpacked)
	{
		unPacketNum = unpacked.unPacketNum;
		ulButtonPressed = unpacked.ulButtonPressed;
		ulButtonTouched = unpacked.ulButtonTouched;
		rAxis0 = unpacked.rAxis0;
		rAxis1 = unpacked.rAxis1;
		rAxis2 = unpacked.rAxis2;
		rAxis3 = unpacked.rAxis3;
		rAxis4 = unpacked.rAxis4;
	}

	public void Unpack(ref VRControllerState_t unpacked)
	{
		unpacked.unPacketNum = unPacketNum;
		unpacked.ulButtonPressed = ulButtonPressed;
		unpacked.ulButtonTouched = ulButtonTouched;
		unpacked.rAxis0 = rAxis0;
		unpacked.rAxis1 = rAxis1;
		unpacked.rAxis2 = rAxis2;
		unpacked.rAxis3 = rAxis3;
		unpacked.rAxis4 = rAxis4;
	}
}
public struct VRBoneTransform_t
{
	public HmdVector4_t position;

	public HmdQuaternionf_t orientation;
}
public struct CameraVideoStreamFrameHeader_t
{
	public EVRTrackedCameraFrameType eFrameType;

	public uint nWidth;

	public uint nHeight;

	public uint nBytesPerPixel;

	public uint nFrameSequence;

	public TrackedDevicePose_t trackedDevicePose;

	public ulong ulFrameExposureTime;
}
public struct Compositor_FrameTiming
{
	public uint m_nSize;

	public uint m_nFrameIndex;

	public uint m_nNumFramePresents;

	public uint m_nNumMisPresented;

	public uint m_nNumDroppedFrames;

	public uint m_nReprojectionFlags;

	public double m_flSystemTimeInSeconds;

	public float m_flPreSubmitGpuMs;

	public float m_flPostSubmitGpuMs;

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

	public uint m_nNumVSyncsReadyForUse;

	public uint m_nNumVSyncsToFirstView;
}
public struct Compositor_BenchmarkResults
{
	public float m_flMegaPixelsPerSecond;

	public float m_flHmdRecommendedMegaPixelsPerSecond;
}
public struct DriverDirectMode_FrameTiming
{
	public uint m_nSize;

	public uint m_nNumFramePresents;

	public uint m_nNumMisPresented;

	public uint m_nNumDroppedFrames;

	public uint m_nReprojectionFlags;
}
public struct ImuSample_t
{
	public double fSampleTime;

	public HmdVector3d_t vAccel;

	public HmdVector3d_t vGyro;

	public uint unOffScaleFlags;
}
public struct AppOverrideKeys_t
{
	public IntPtr pchKey;

	public IntPtr pchValue;
}
public struct Compositor_CumulativeStats
{
	public uint m_nPid;

	public uint m_nNumFramePresents;

	public uint m_nNumDroppedFrames;

	public uint m_nNumReprojectedFrames;

	public uint m_nNumFramePresentsOnStartup;

	public uint m_nNumDroppedFramesOnStartup;

	public uint m_nNumReprojectedFramesOnStartup;

	public uint m_nNumLoading;

	public uint m_nNumFramePresentsLoading;

	public uint m_nNumDroppedFramesLoading;

	public uint m_nNumReprojectedFramesLoading;

	public uint m_nNumTimedOut;

	public uint m_nNumFramePresentsTimedOut;

	public uint m_nNumDroppedFramesTimedOut;

	public uint m_nNumReprojectedFramesTimedOut;
}
public struct Compositor_StageRenderSettings
{
	public HmdColor_t m_PrimaryColor;

	public HmdColor_t m_SecondaryColor;

	public float m_flVignetteInnerRadius;

	public float m_flVignetteOuterRadius;

	public float m_flFresnelStrength;

	[MarshalAs(UnmanagedType.I1)]
	public bool m_bBackfaceCulling;

	[MarshalAs(UnmanagedType.I1)]
	public bool m_bGreyscale;

	[MarshalAs(UnmanagedType.I1)]
	public bool m_bWireframe;
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
public struct IntersectionMaskRectangle_t
{
	public float m_flTopLeftX;

	public float m_flTopLeftY;

	public float m_flWidth;

	public float m_flHeight;
}
public struct IntersectionMaskCircle_t
{
	public float m_flCenterX;

	public float m_flCenterY;

	public float m_flRadius;
}
public struct VROverlayIntersectionMaskPrimitive_t
{
	public EVROverlayIntersectionMaskPrimitiveType m_nPrimitiveType;

	public VROverlayIntersectionMaskPrimitive_Data_t m_Primitive;
}
public struct VROverlayView_t
{
	public ulong overlayHandle;

	public Texture_t texture;

	public VRTextureBounds_t textureBounds;
}
public struct VRVulkanDevice_t
{
	public IntPtr m_pInstance;

	public IntPtr m_pDevice;

	public IntPtr m_pPhysicalDevice;

	public IntPtr m_pQueue;

	public uint m_uQueueFamilyIndex;
}
public struct VRNativeDevice_t
{
	public IntPtr handle;

	public EDeviceType eType;
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
	public ushort unWidth;

	public ushort unHeight;

	public IntPtr rubTextureMapData;

	public EVRRenderModelTextureFormat format;
}
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct RenderModel_TextureMap_t_Packed
{
	public ushort unWidth;

	public ushort unHeight;

	public IntPtr rubTextureMapData;

	public EVRRenderModelTextureFormat format;

	public RenderModel_TextureMap_t_Packed(RenderModel_TextureMap_t unpacked)
	{
		unWidth = unpacked.unWidth;
		unHeight = unpacked.unHeight;
		rubTextureMapData = unpacked.rubTextureMapData;
		format = unpacked.format;
	}

	public void Unpack(ref RenderModel_TextureMap_t unpacked)
	{
		unpacked.unWidth = unWidth;
		unpacked.unHeight = unHeight;
		unpacked.rubTextureMapData = rubTextureMapData;
		unpacked.format = format;
	}
}
public struct RenderModel_t
{
	public IntPtr rVertexData;

	public uint unVertexCount;

	public IntPtr rIndexData;

	public uint unTriangleCount;

	public int diffuseTextureId;
}
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct RenderModel_t_Packed
{
	public IntPtr rVertexData;

	public uint unVertexCount;

	public IntPtr rIndexData;

	public uint unTriangleCount;

	public int diffuseTextureId;

	public RenderModel_t_Packed(RenderModel_t unpacked)
	{
		rVertexData = unpacked.rVertexData;
		unVertexCount = unpacked.unVertexCount;
		rIndexData = unpacked.rIndexData;
		unTriangleCount = unpacked.unTriangleCount;
		diffuseTextureId = unpacked.diffuseTextureId;
	}

	public void Unpack(ref RenderModel_t unpacked)
	{
		unpacked.rVertexData = rVertexData;
		unpacked.unVertexCount = unVertexCount;
		unpacked.rIndexData = rIndexData;
		unpacked.unTriangleCount = unTriangleCount;
		unpacked.diffuseTextureId = diffuseTextureId;
	}
}
public struct RenderModel_ControllerMode_State_t
{
	[MarshalAs(UnmanagedType.I1)]
	public bool bScrollWheelVisible;
}
public struct NotificationBitmap_t
{
	public IntPtr m_pImageData;

	public int m_nWidth;

	public int m_nHeight;

	public int m_nBytesPerPixel;
}
public struct CVRSettingHelper
{
	public IntPtr m_pSettings;
}
public struct InputAnalogActionData_t
{
	[MarshalAs(UnmanagedType.I1)]
	public bool bActive;

	public ulong activeOrigin;

	public float x;

	public float y;

	public float z;

	public float deltaX;

	public float deltaY;

	public float deltaZ;

	public float fUpdateTime;
}
public struct InputDigitalActionData_t
{
	[MarshalAs(UnmanagedType.I1)]
	public bool bActive;

	public ulong activeOrigin;

	[MarshalAs(UnmanagedType.I1)]
	public bool bState;

	[MarshalAs(UnmanagedType.I1)]
	public bool bChanged;

	public float fUpdateTime;
}
public struct InputPoseActionData_t
{
	[MarshalAs(UnmanagedType.I1)]
	public bool bActive;

	public ulong activeOrigin;

	public TrackedDevicePose_t pose;
}
public struct InputSkeletalActionData_t
{
	[MarshalAs(UnmanagedType.I1)]
	public bool bActive;

	public ulong activeOrigin;
}
public struct InputOriginInfo_t
{
	public ulong devicePath;

	public uint trackedDeviceIndex;

	public byte rchRenderModelComponentName0;

	public byte rchRenderModelComponentName1;

	public byte rchRenderModelComponentName2;

	public byte rchRenderModelComponentName3;

	public byte rchRenderModelComponentName4;

	public byte rchRenderModelComponentName5;

	public byte rchRenderModelComponentName6;

	public byte rchRenderModelComponentName7;

	public byte rchRenderModelComponentName8;

	public byte rchRenderModelComponentName9;

	public byte rchRenderModelComponentName10;

	public byte rchRenderModelComponentName11;

	public byte rchRenderModelComponentName12;

	public byte rchRenderModelComponentName13;

	public byte rchRenderModelComponentName14;

	public byte rchRenderModelComponentName15;

	public byte rchRenderModelComponentName16;

	public byte rchRenderModelComponentName17;

	public byte rchRenderModelComponentName18;

	public byte rchRenderModelComponentName19;

	public byte rchRenderModelComponentName20;

	public byte rchRenderModelComponentName21;

	public byte rchRenderModelComponentName22;

	public byte rchRenderModelComponentName23;

	public byte rchRenderModelComponentName24;

	public byte rchRenderModelComponentName25;

	public byte rchRenderModelComponentName26;

	public byte rchRenderModelComponentName27;

	public byte rchRenderModelComponentName28;

	public byte rchRenderModelComponentName29;

	public byte rchRenderModelComponentName30;

	public byte rchRenderModelComponentName31;

	public byte rchRenderModelComponentName32;

	public byte rchRenderModelComponentName33;

	public byte rchRenderModelComponentName34;

	public byte rchRenderModelComponentName35;

	public byte rchRenderModelComponentName36;

	public byte rchRenderModelComponentName37;

	public byte rchRenderModelComponentName38;

	public byte rchRenderModelComponentName39;

	public byte rchRenderModelComponentName40;

	public byte rchRenderModelComponentName41;

	public byte rchRenderModelComponentName42;

	public byte rchRenderModelComponentName43;

	public byte rchRenderModelComponentName44;

	public byte rchRenderModelComponentName45;

	public byte rchRenderModelComponentName46;

	public byte rchRenderModelComponentName47;

	public byte rchRenderModelComponentName48;

	public byte rchRenderModelComponentName49;

	public byte rchRenderModelComponentName50;

	public byte rchRenderModelComponentName51;

	public byte rchRenderModelComponentName52;

	public byte rchRenderModelComponentName53;

	public byte rchRenderModelComponentName54;

	public byte rchRenderModelComponentName55;

	public byte rchRenderModelComponentName56;

	public byte rchRenderModelComponentName57;

	public byte rchRenderModelComponentName58;

	public byte rchRenderModelComponentName59;

	public byte rchRenderModelComponentName60;

	public byte rchRenderModelComponentName61;

	public byte rchRenderModelComponentName62;

	public byte rchRenderModelComponentName63;

	public byte rchRenderModelComponentName64;

	public byte rchRenderModelComponentName65;

	public byte rchRenderModelComponentName66;

	public byte rchRenderModelComponentName67;

	public byte rchRenderModelComponentName68;

	public byte rchRenderModelComponentName69;

	public byte rchRenderModelComponentName70;

	public byte rchRenderModelComponentName71;

	public byte rchRenderModelComponentName72;

	public byte rchRenderModelComponentName73;

	public byte rchRenderModelComponentName74;

	public byte rchRenderModelComponentName75;

	public byte rchRenderModelComponentName76;

	public byte rchRenderModelComponentName77;

	public byte rchRenderModelComponentName78;

	public byte rchRenderModelComponentName79;

	public byte rchRenderModelComponentName80;

	public byte rchRenderModelComponentName81;

	public byte rchRenderModelComponentName82;

	public byte rchRenderModelComponentName83;

	public byte rchRenderModelComponentName84;

	public byte rchRenderModelComponentName85;

	public byte rchRenderModelComponentName86;

	public byte rchRenderModelComponentName87;

	public byte rchRenderModelComponentName88;

	public byte rchRenderModelComponentName89;

	public byte rchRenderModelComponentName90;

	public byte rchRenderModelComponentName91;

	public byte rchRenderModelComponentName92;

	public byte rchRenderModelComponentName93;

	public byte rchRenderModelComponentName94;

	public byte rchRenderModelComponentName95;

	public byte rchRenderModelComponentName96;

	public byte rchRenderModelComponentName97;

	public byte rchRenderModelComponentName98;

	public byte rchRenderModelComponentName99;

	public byte rchRenderModelComponentName100;

	public byte rchRenderModelComponentName101;

	public byte rchRenderModelComponentName102;

	public byte rchRenderModelComponentName103;

	public byte rchRenderModelComponentName104;

	public byte rchRenderModelComponentName105;

	public byte rchRenderModelComponentName106;

	public byte rchRenderModelComponentName107;

	public byte rchRenderModelComponentName108;

	public byte rchRenderModelComponentName109;

	public byte rchRenderModelComponentName110;

	public byte rchRenderModelComponentName111;

	public byte rchRenderModelComponentName112;

	public byte rchRenderModelComponentName113;

	public byte rchRenderModelComponentName114;

	public byte rchRenderModelComponentName115;

	public byte rchRenderModelComponentName116;

	public byte rchRenderModelComponentName117;

	public byte rchRenderModelComponentName118;

	public byte rchRenderModelComponentName119;

	public byte rchRenderModelComponentName120;

	public byte rchRenderModelComponentName121;

	public byte rchRenderModelComponentName122;

	public byte rchRenderModelComponentName123;

	public byte rchRenderModelComponentName124;

	public byte rchRenderModelComponentName125;

	public byte rchRenderModelComponentName126;

	public byte rchRenderModelComponentName127;

	public string rchRenderModelComponentName => new string(new char[128]
	{
		(char)rchRenderModelComponentName0,
		(char)rchRenderModelComponentName1,
		(char)rchRenderModelComponentName2,
		(char)rchRenderModelComponentName3,
		(char)rchRenderModelComponentName4,
		(char)rchRenderModelComponentName5,
		(char)rchRenderModelComponentName6,
		(char)rchRenderModelComponentName7,
		(char)rchRenderModelComponentName8,
		(char)rchRenderModelComponentName9,
		(char)rchRenderModelComponentName10,
		(char)rchRenderModelComponentName11,
		(char)rchRenderModelComponentName12,
		(char)rchRenderModelComponentName13,
		(char)rchRenderModelComponentName14,
		(char)rchRenderModelComponentName15,
		(char)rchRenderModelComponentName16,
		(char)rchRenderModelComponentName17,
		(char)rchRenderModelComponentName18,
		(char)rchRenderModelComponentName19,
		(char)rchRenderModelComponentName20,
		(char)rchRenderModelComponentName21,
		(char)rchRenderModelComponentName22,
		(char)rchRenderModelComponentName23,
		(char)rchRenderModelComponentName24,
		(char)rchRenderModelComponentName25,
		(char)rchRenderModelComponentName26,
		(char)rchRenderModelComponentName27,
		(char)rchRenderModelComponentName28,
		(char)rchRenderModelComponentName29,
		(char)rchRenderModelComponentName30,
		(char)rchRenderModelComponentName31,
		(char)rchRenderModelComponentName32,
		(char)rchRenderModelComponentName33,
		(char)rchRenderModelComponentName34,
		(char)rchRenderModelComponentName35,
		(char)rchRenderModelComponentName36,
		(char)rchRenderModelComponentName37,
		(char)rchRenderModelComponentName38,
		(char)rchRenderModelComponentName39,
		(char)rchRenderModelComponentName40,
		(char)rchRenderModelComponentName41,
		(char)rchRenderModelComponentName42,
		(char)rchRenderModelComponentName43,
		(char)rchRenderModelComponentName44,
		(char)rchRenderModelComponentName45,
		(char)rchRenderModelComponentName46,
		(char)rchRenderModelComponentName47,
		(char)rchRenderModelComponentName48,
		(char)rchRenderModelComponentName49,
		(char)rchRenderModelComponentName50,
		(char)rchRenderModelComponentName51,
		(char)rchRenderModelComponentName52,
		(char)rchRenderModelComponentName53,
		(char)rchRenderModelComponentName54,
		(char)rchRenderModelComponentName55,
		(char)rchRenderModelComponentName56,
		(char)rchRenderModelComponentName57,
		(char)rchRenderModelComponentName58,
		(char)rchRenderModelComponentName59,
		(char)rchRenderModelComponentName60,
		(char)rchRenderModelComponentName61,
		(char)rchRenderModelComponentName62,
		(char)rchRenderModelComponentName63,
		(char)rchRenderModelComponentName64,
		(char)rchRenderModelComponentName65,
		(char)rchRenderModelComponentName66,
		(char)rchRenderModelComponentName67,
		(char)rchRenderModelComponentName68,
		(char)rchRenderModelComponentName69,
		(char)rchRenderModelComponentName70,
		(char)rchRenderModelComponentName71,
		(char)rchRenderModelComponentName72,
		(char)rchRenderModelComponentName73,
		(char)rchRenderModelComponentName74,
		(char)rchRenderModelComponentName75,
		(char)rchRenderModelComponentName76,
		(char)rchRenderModelComponentName77,
		(char)rchRenderModelComponentName78,
		(char)rchRenderModelComponentName79,
		(char)rchRenderModelComponentName80,
		(char)rchRenderModelComponentName81,
		(char)rchRenderModelComponentName82,
		(char)rchRenderModelComponentName83,
		(char)rchRenderModelComponentName84,
		(char)rchRenderModelComponentName85,
		(char)rchRenderModelComponentName86,
		(char)rchRenderModelComponentName87,
		(char)rchRenderModelComponentName88,
		(char)rchRenderModelComponentName89,
		(char)rchRenderModelComponentName90,
		(char)rchRenderModelComponentName91,
		(char)rchRenderModelComponentName92,
		(char)rchRenderModelComponentName93,
		(char)rchRenderModelComponentName94,
		(char)rchRenderModelComponentName95,
		(char)rchRenderModelComponentName96,
		(char)rchRenderModelComponentName97,
		(char)rchRenderModelComponentName98,
		(char)rchRenderModelComponentName99,
		(char)rchRenderModelComponentName100,
		(char)rchRenderModelComponentName101,
		(char)rchRenderModelComponentName102,
		(char)rchRenderModelComponentName103,
		(char)rchRenderModelComponentName104,
		(char)rchRenderModelComponentName105,
		(char)rchRenderModelComponentName106,
		(char)rchRenderModelComponentName107,
		(char)rchRenderModelComponentName108,
		(char)rchRenderModelComponentName109,
		(char)rchRenderModelComponentName110,
		(char)rchRenderModelComponentName111,
		(char)rchRenderModelComponentName112,
		(char)rchRenderModelComponentName113,
		(char)rchRenderModelComponentName114,
		(char)rchRenderModelComponentName115,
		(char)rchRenderModelComponentName116,
		(char)rchRenderModelComponentName117,
		(char)rchRenderModelComponentName118,
		(char)rchRenderModelComponentName119,
		(char)rchRenderModelComponentName120,
		(char)rchRenderModelComponentName121,
		(char)rchRenderModelComponentName122,
		(char)rchRenderModelComponentName123,
		(char)rchRenderModelComponentName124,
		(char)rchRenderModelComponentName125,
		(char)rchRenderModelComponentName126,
		(char)rchRenderModelComponentName127
	}).TrimEnd('\0');
}
public struct InputBindingInfo_t
{
	public byte rchDevicePathName0;

	public byte rchDevicePathName1;

	public byte rchDevicePathName2;

	public byte rchDevicePathName3;

	public byte rchDevicePathName4;

	public byte rchDevicePathName5;

	public byte rchDevicePathName6;

	public byte rchDevicePathName7;

	public byte rchDevicePathName8;

	public byte rchDevicePathName9;

	public byte rchDevicePathName10;

	public byte rchDevicePathName11;

	public byte rchDevicePathName12;

	public byte rchDevicePathName13;

	public byte rchDevicePathName14;

	public byte rchDevicePathName15;

	public byte rchDevicePathName16;

	public byte rchDevicePathName17;

	public byte rchDevicePathName18;

	public byte rchDevicePathName19;

	public byte rchDevicePathName20;

	public byte rchDevicePathName21;

	public byte rchDevicePathName22;

	public byte rchDevicePathName23;

	public byte rchDevicePathName24;

	public byte rchDevicePathName25;

	public byte rchDevicePathName26;

	public byte rchDevicePathName27;

	public byte rchDevicePathName28;

	public byte rchDevicePathName29;

	public byte rchDevicePathName30;

	public byte rchDevicePathName31;

	public byte rchDevicePathName32;

	public byte rchDevicePathName33;

	public byte rchDevicePathName34;

	public byte rchDevicePathName35;

	public byte rchDevicePathName36;

	public byte rchDevicePathName37;

	public byte rchDevicePathName38;

	public byte rchDevicePathName39;

	public byte rchDevicePathName40;

	public byte rchDevicePathName41;

	public byte rchDevicePathName42;

	public byte rchDevicePathName43;

	public byte rchDevicePathName44;

	public byte rchDevicePathName45;

	public byte rchDevicePathName46;

	public byte rchDevicePathName47;

	public byte rchDevicePathName48;

	public byte rchDevicePathName49;

	public byte rchDevicePathName50;

	public byte rchDevicePathName51;

	public byte rchDevicePathName52;

	public byte rchDevicePathName53;

	public byte rchDevicePathName54;

	public byte rchDevicePathName55;

	public byte rchDevicePathName56;

	public byte rchDevicePathName57;

	public byte rchDevicePathName58;

	public byte rchDevicePathName59;

	public byte rchDevicePathName60;

	public byte rchDevicePathName61;

	public byte rchDevicePathName62;

	public byte rchDevicePathName63;

	public byte rchDevicePathName64;

	public byte rchDevicePathName65;

	public byte rchDevicePathName66;

	public byte rchDevicePathName67;

	public byte rchDevicePathName68;

	public byte rchDevicePathName69;

	public byte rchDevicePathName70;

	public byte rchDevicePathName71;

	public byte rchDevicePathName72;

	public byte rchDevicePathName73;

	public byte rchDevicePathName74;

	public byte rchDevicePathName75;

	public byte rchDevicePathName76;

	public byte rchDevicePathName77;

	public byte rchDevicePathName78;

	public byte rchDevicePathName79;

	public byte rchDevicePathName80;

	public byte rchDevicePathName81;

	public byte rchDevicePathName82;

	public byte rchDevicePathName83;

	public byte rchDevicePathName84;

	public byte rchDevicePathName85;

	public byte rchDevicePathName86;

	public byte rchDevicePathName87;

	public byte rchDevicePathName88;

	public byte rchDevicePathName89;

	public byte rchDevicePathName90;

	public byte rchDevicePathName91;

	public byte rchDevicePathName92;

	public byte rchDevicePathName93;

	public byte rchDevicePathName94;

	public byte rchDevicePathName95;

	public byte rchDevicePathName96;

	public byte rchDevicePathName97;

	public byte rchDevicePathName98;

	public byte rchDevicePathName99;

	public byte rchDevicePathName100;

	public byte rchDevicePathName101;

	public byte rchDevicePathName102;

	public byte rchDevicePathName103;

	public byte rchDevicePathName104;

	public byte rchDevicePathName105;

	public byte rchDevicePathName106;

	public byte rchDevicePathName107;

	public byte rchDevicePathName108;

	public byte rchDevicePathName109;

	public byte rchDevicePathName110;

	public byte rchDevicePathName111;

	public byte rchDevicePathName112;

	public byte rchDevicePathName113;

	public byte rchDevicePathName114;

	public byte rchDevicePathName115;

	public byte rchDevicePathName116;

	public byte rchDevicePathName117;

	public byte rchDevicePathName118;

	public byte rchDevicePathName119;

	public byte rchDevicePathName120;

	public byte rchDevicePathName121;

	public byte rchDevicePathName122;

	public byte rchDevicePathName123;

	public byte rchDevicePathName124;

	public byte rchDevicePathName125;

	public byte rchDevicePathName126;

	public byte rchDevicePathName127;

	public byte rchInputPathName0;

	public byte rchInputPathName1;

	public byte rchInputPathName2;

	public byte rchInputPathName3;

	public byte rchInputPathName4;

	public byte rchInputPathName5;

	public byte rchInputPathName6;

	public byte rchInputPathName7;

	public byte rchInputPathName8;

	public byte rchInputPathName9;

	public byte rchInputPathName10;

	public byte rchInputPathName11;

	public byte rchInputPathName12;

	public byte rchInputPathName13;

	public byte rchInputPathName14;

	public byte rchInputPathName15;

	public byte rchInputPathName16;

	public byte rchInputPathName17;

	public byte rchInputPathName18;

	public byte rchInputPathName19;

	public byte rchInputPathName20;

	public byte rchInputPathName21;

	public byte rchInputPathName22;

	public byte rchInputPathName23;

	public byte rchInputPathName24;

	public byte rchInputPathName25;

	public byte rchInputPathName26;

	public byte rchInputPathName27;

	public byte rchInputPathName28;

	public byte rchInputPathName29;

	public byte rchInputPathName30;

	public byte rchInputPathName31;

	public byte rchInputPathName32;

	public byte rchInputPathName33;

	public byte rchInputPathName34;

	public byte rchInputPathName35;

	public byte rchInputPathName36;

	public byte rchInputPathName37;

	public byte rchInputPathName38;

	public byte rchInputPathName39;

	public byte rchInputPathName40;

	public byte rchInputPathName41;

	public byte rchInputPathName42;

	public byte rchInputPathName43;

	public byte rchInputPathName44;

	public byte rchInputPathName45;

	public byte rchInputPathName46;

	public byte rchInputPathName47;

	public byte rchInputPathName48;

	public byte rchInputPathName49;

	public byte rchInputPathName50;

	public byte rchInputPathName51;

	public byte rchInputPathName52;

	public byte rchInputPathName53;

	public byte rchInputPathName54;

	public byte rchInputPathName55;

	public byte rchInputPathName56;

	public byte rchInputPathName57;

	public byte rchInputPathName58;

	public byte rchInputPathName59;

	public byte rchInputPathName60;

	public byte rchInputPathName61;

	public byte rchInputPathName62;

	public byte rchInputPathName63;

	public byte rchInputPathName64;

	public byte rchInputPathName65;

	public byte rchInputPathName66;

	public byte rchInputPathName67;

	public byte rchInputPathName68;

	public byte rchInputPathName69;

	public byte rchInputPathName70;

	public byte rchInputPathName71;

	public byte rchInputPathName72;

	public byte rchInputPathName73;

	public byte rchInputPathName74;

	public byte rchInputPathName75;

	public byte rchInputPathName76;

	public byte rchInputPathName77;

	public byte rchInputPathName78;

	public byte rchInputPathName79;

	public byte rchInputPathName80;

	public byte rchInputPathName81;

	public byte rchInputPathName82;

	public byte rchInputPathName83;

	public byte rchInputPathName84;

	public byte rchInputPathName85;

	public byte rchInputPathName86;

	public byte rchInputPathName87;

	public byte rchInputPathName88;

	public byte rchInputPathName89;

	public byte rchInputPathName90;

	public byte rchInputPathName91;

	public byte rchInputPathName92;

	public byte rchInputPathName93;

	public byte rchInputPathName94;

	public byte rchInputPathName95;

	public byte rchInputPathName96;

	public byte rchInputPathName97;

	public byte rchInputPathName98;

	public byte rchInputPathName99;

	public byte rchInputPathName100;

	public byte rchInputPathName101;

	public byte rchInputPathName102;

	public byte rchInputPathName103;

	public byte rchInputPathName104;

	public byte rchInputPathName105;

	public byte rchInputPathName106;

	public byte rchInputPathName107;

	public byte rchInputPathName108;

	public byte rchInputPathName109;

	public byte rchInputPathName110;

	public byte rchInputPathName111;

	public byte rchInputPathName112;

	public byte rchInputPathName113;

	public byte rchInputPathName114;

	public byte rchInputPathName115;

	public byte rchInputPathName116;

	public byte rchInputPathName117;

	public byte rchInputPathName118;

	public byte rchInputPathName119;

	public byte rchInputPathName120;

	public byte rchInputPathName121;

	public byte rchInputPathName122;

	public byte rchInputPathName123;

	public byte rchInputPathName124;

	public byte rchInputPathName125;

	public byte rchInputPathName126;

	public byte rchInputPathName127;

	public byte rchModeName0;

	public byte rchModeName1;

	public byte rchModeName2;

	public byte rchModeName3;

	public byte rchModeName4;

	public byte rchModeName5;

	public byte rchModeName6;

	public byte rchModeName7;

	public byte rchModeName8;

	public byte rchModeName9;

	public byte rchModeName10;

	public byte rchModeName11;

	public byte rchModeName12;

	public byte rchModeName13;

	public byte rchModeName14;

	public byte rchModeName15;

	public byte rchModeName16;

	public byte rchModeName17;

	public byte rchModeName18;

	public byte rchModeName19;

	public byte rchModeName20;

	public byte rchModeName21;

	public byte rchModeName22;

	public byte rchModeName23;

	public byte rchModeName24;

	public byte rchModeName25;

	public byte rchModeName26;

	public byte rchModeName27;

	public byte rchModeName28;

	public byte rchModeName29;

	public byte rchModeName30;

	public byte rchModeName31;

	public byte rchModeName32;

	public byte rchModeName33;

	public byte rchModeName34;

	public byte rchModeName35;

	public byte rchModeName36;

	public byte rchModeName37;

	public byte rchModeName38;

	public byte rchModeName39;

	public byte rchModeName40;

	public byte rchModeName41;

	public byte rchModeName42;

	public byte rchModeName43;

	public byte rchModeName44;

	public byte rchModeName45;

	public byte rchModeName46;

	public byte rchModeName47;

	public byte rchModeName48;

	public byte rchModeName49;

	public byte rchModeName50;

	public byte rchModeName51;

	public byte rchModeName52;

	public byte rchModeName53;

	public byte rchModeName54;

	public byte rchModeName55;

	public byte rchModeName56;

	public byte rchModeName57;

	public byte rchModeName58;

	public byte rchModeName59;

	public byte rchModeName60;

	public byte rchModeName61;

	public byte rchModeName62;

	public byte rchModeName63;

	public byte rchModeName64;

	public byte rchModeName65;

	public byte rchModeName66;

	public byte rchModeName67;

	public byte rchModeName68;

	public byte rchModeName69;

	public byte rchModeName70;

	public byte rchModeName71;

	public byte rchModeName72;

	public byte rchModeName73;

	public byte rchModeName74;

	public byte rchModeName75;

	public byte rchModeName76;

	public byte rchModeName77;

	public byte rchModeName78;

	public byte rchModeName79;

	public byte rchModeName80;

	public byte rchModeName81;

	public byte rchModeName82;

	public byte rchModeName83;

	public byte rchModeName84;

	public byte rchModeName85;

	public byte rchModeName86;

	public byte rchModeName87;

	public byte rchModeName88;

	public byte rchModeName89;

	public byte rchModeName90;

	public byte rchModeName91;

	public byte rchModeName92;

	public byte rchModeName93;

	public byte rchModeName94;

	public byte rchModeName95;

	public byte rchModeName96;

	public byte rchModeName97;

	public byte rchModeName98;

	public byte rchModeName99;

	public byte rchModeName100;

	public byte rchModeName101;

	public byte rchModeName102;

	public byte rchModeName103;

	public byte rchModeName104;

	public byte rchModeName105;

	public byte rchModeName106;

	public byte rchModeName107;

	public byte rchModeName108;

	public byte rchModeName109;

	public byte rchModeName110;

	public byte rchModeName111;

	public byte rchModeName112;

	public byte rchModeName113;

	public byte rchModeName114;

	public byte rchModeName115;

	public byte rchModeName116;

	public byte rchModeName117;

	public byte rchModeName118;

	public byte rchModeName119;

	public byte rchModeName120;

	public byte rchModeName121;

	public byte rchModeName122;

	public byte rchModeName123;

	public byte rchModeName124;

	public byte rchModeName125;

	public byte rchModeName126;

	public byte rchModeName127;

	public byte rchSlotName0;

	public byte rchSlotName1;

	public byte rchSlotName2;

	public byte rchSlotName3;

	public byte rchSlotName4;

	public byte rchSlotName5;

	public byte rchSlotName6;

	public byte rchSlotName7;

	public byte rchSlotName8;

	public byte rchSlotName9;

	public byte rchSlotName10;

	public byte rchSlotName11;

	public byte rchSlotName12;

	public byte rchSlotName13;

	public byte rchSlotName14;

	public byte rchSlotName15;

	public byte rchSlotName16;

	public byte rchSlotName17;

	public byte rchSlotName18;

	public byte rchSlotName19;

	public byte rchSlotName20;

	public byte rchSlotName21;

	public byte rchSlotName22;

	public byte rchSlotName23;

	public byte rchSlotName24;

	public byte rchSlotName25;

	public byte rchSlotName26;

	public byte rchSlotName27;

	public byte rchSlotName28;

	public byte rchSlotName29;

	public byte rchSlotName30;

	public byte rchSlotName31;

	public byte rchSlotName32;

	public byte rchSlotName33;

	public byte rchSlotName34;

	public byte rchSlotName35;

	public byte rchSlotName36;

	public byte rchSlotName37;

	public byte rchSlotName38;

	public byte rchSlotName39;

	public byte rchSlotName40;

	public byte rchSlotName41;

	public byte rchSlotName42;

	public byte rchSlotName43;

	public byte rchSlotName44;

	public byte rchSlotName45;

	public byte rchSlotName46;

	public byte rchSlotName47;

	public byte rchSlotName48;

	public byte rchSlotName49;

	public byte rchSlotName50;

	public byte rchSlotName51;

	public byte rchSlotName52;

	public byte rchSlotName53;

	public byte rchSlotName54;

	public byte rchSlotName55;

	public byte rchSlotName56;

	public byte rchSlotName57;

	public byte rchSlotName58;

	public byte rchSlotName59;

	public byte rchSlotName60;

	public byte rchSlotName61;

	public byte rchSlotName62;

	public byte rchSlotName63;

	public byte rchSlotName64;

	public byte rchSlotName65;

	public byte rchSlotName66;

	public byte rchSlotName67;

	public byte rchSlotName68;

	public byte rchSlotName69;

	public byte rchSlotName70;

	public byte rchSlotName71;

	public byte rchSlotName72;

	public byte rchSlotName73;

	public byte rchSlotName74;

	public byte rchSlotName75;

	public byte rchSlotName76;

	public byte rchSlotName77;

	public byte rchSlotName78;

	public byte rchSlotName79;

	public byte rchSlotName80;

	public byte rchSlotName81;

	public byte rchSlotName82;

	public byte rchSlotName83;

	public byte rchSlotName84;

	public byte rchSlotName85;

	public byte rchSlotName86;

	public byte rchSlotName87;

	public byte rchSlotName88;

	public byte rchSlotName89;

	public byte rchSlotName90;

	public byte rchSlotName91;

	public byte rchSlotName92;

	public byte rchSlotName93;

	public byte rchSlotName94;

	public byte rchSlotName95;

	public byte rchSlotName96;

	public byte rchSlotName97;

	public byte rchSlotName98;

	public byte rchSlotName99;

	public byte rchSlotName100;

	public byte rchSlotName101;

	public byte rchSlotName102;

	public byte rchSlotName103;

	public byte rchSlotName104;

	public byte rchSlotName105;

	public byte rchSlotName106;

	public byte rchSlotName107;

	public byte rchSlotName108;

	public byte rchSlotName109;

	public byte rchSlotName110;

	public byte rchSlotName111;

	public byte rchSlotName112;

	public byte rchSlotName113;

	public byte rchSlotName114;

	public byte rchSlotName115;

	public byte rchSlotName116;

	public byte rchSlotName117;

	public byte rchSlotName118;

	public byte rchSlotName119;

	public byte rchSlotName120;

	public byte rchSlotName121;

	public byte rchSlotName122;

	public byte rchSlotName123;

	public byte rchSlotName124;

	public byte rchSlotName125;

	public byte rchSlotName126;

	public byte rchSlotName127;

	public byte rchInputSourceType0;

	public byte rchInputSourceType1;

	public byte rchInputSourceType2;

	public byte rchInputSourceType3;

	public byte rchInputSourceType4;

	public byte rchInputSourceType5;

	public byte rchInputSourceType6;

	public byte rchInputSourceType7;

	public byte rchInputSourceType8;

	public byte rchInputSourceType9;

	public byte rchInputSourceType10;

	public byte rchInputSourceType11;

	public byte rchInputSourceType12;

	public byte rchInputSourceType13;

	public byte rchInputSourceType14;

	public byte rchInputSourceType15;

	public byte rchInputSourceType16;

	public byte rchInputSourceType17;

	public byte rchInputSourceType18;

	public byte rchInputSourceType19;

	public byte rchInputSourceType20;

	public byte rchInputSourceType21;

	public byte rchInputSourceType22;

	public byte rchInputSourceType23;

	public byte rchInputSourceType24;

	public byte rchInputSourceType25;

	public byte rchInputSourceType26;

	public byte rchInputSourceType27;

	public byte rchInputSourceType28;

	public byte rchInputSourceType29;

	public byte rchInputSourceType30;

	public byte rchInputSourceType31;

	public string rchDevicePathName => new string(new char[128]
	{
		(char)rchDevicePathName0,
		(char)rchDevicePathName1,
		(char)rchDevicePathName2,
		(char)rchDevicePathName3,
		(char)rchDevicePathName4,
		(char)rchDevicePathName5,
		(char)rchDevicePathName6,
		(char)rchDevicePathName7,
		(char)rchDevicePathName8,
		(char)rchDevicePathName9,
		(char)rchDevicePathName10,
		(char)rchDevicePathName11,
		(char)rchDevicePathName12,
		(char)rchDevicePathName13,
		(char)rchDevicePathName14,
		(char)rchDevicePathName15,
		(char)rchDevicePathName16,
		(char)rchDevicePathName17,
		(char)rchDevicePathName18,
		(char)rchDevicePathName19,
		(char)rchDevicePathName20,
		(char)rchDevicePathName21,
		(char)rchDevicePathName22,
		(char)rchDevicePathName23,
		(char)rchDevicePathName24,
		(char)rchDevicePathName25,
		(char)rchDevicePathName26,
		(char)rchDevicePathName27,
		(char)rchDevicePathName28,
		(char)rchDevicePathName29,
		(char)rchDevicePathName30,
		(char)rchDevicePathName31,
		(char)rchDevicePathName32,
		(char)rchDevicePathName33,
		(char)rchDevicePathName34,
		(char)rchDevicePathName35,
		(char)rchDevicePathName36,
		(char)rchDevicePathName37,
		(char)rchDevicePathName38,
		(char)rchDevicePathName39,
		(char)rchDevicePathName40,
		(char)rchDevicePathName41,
		(char)rchDevicePathName42,
		(char)rchDevicePathName43,
		(char)rchDevicePathName44,
		(char)rchDevicePathName45,
		(char)rchDevicePathName46,
		(char)rchDevicePathName47,
		(char)rchDevicePathName48,
		(char)rchDevicePathName49,
		(char)rchDevicePathName50,
		(char)rchDevicePathName51,
		(char)rchDevicePathName52,
		(char)rchDevicePathName53,
		(char)rchDevicePathName54,
		(char)rchDevicePathName55,
		(char)rchDevicePathName56,
		(char)rchDevicePathName57,
		(char)rchDevicePathName58,
		(char)rchDevicePathName59,
		(char)rchDevicePathName60,
		(char)rchDevicePathName61,
		(char)rchDevicePathName62,
		(char)rchDevicePathName63,
		(char)rchDevicePathName64,
		(char)rchDevicePathName65,
		(char)rchDevicePathName66,
		(char)rchDevicePathName67,
		(char)rchDevicePathName68,
		(char)rchDevicePathName69,
		(char)rchDevicePathName70,
		(char)rchDevicePathName71,
		(char)rchDevicePathName72,
		(char)rchDevicePathName73,
		(char)rchDevicePathName74,
		(char)rchDevicePathName75,
		(char)rchDevicePathName76,
		(char)rchDevicePathName77,
		(char)rchDevicePathName78,
		(char)rchDevicePathName79,
		(char)rchDevicePathName80,
		(char)rchDevicePathName81,
		(char)rchDevicePathName82,
		(char)rchDevicePathName83,
		(char)rchDevicePathName84,
		(char)rchDevicePathName85,
		(char)rchDevicePathName86,
		(char)rchDevicePathName87,
		(char)rchDevicePathName88,
		(char)rchDevicePathName89,
		(char)rchDevicePathName90,
		(char)rchDevicePathName91,
		(char)rchDevicePathName92,
		(char)rchDevicePathName93,
		(char)rchDevicePathName94,
		(char)rchDevicePathName95,
		(char)rchDevicePathName96,
		(char)rchDevicePathName97,
		(char)rchDevicePathName98,
		(char)rchDevicePathName99,
		(char)rchDevicePathName100,
		(char)rchDevicePathName101,
		(char)rchDevicePathName102,
		(char)rchDevicePathName103,
		(char)rchDevicePathName104,
		(char)rchDevicePathName105,
		(char)rchDevicePathName106,
		(char)rchDevicePathName107,
		(char)rchDevicePathName108,
		(char)rchDevicePathName109,
		(char)rchDevicePathName110,
		(char)rchDevicePathName111,
		(char)rchDevicePathName112,
		(char)rchDevicePathName113,
		(char)rchDevicePathName114,
		(char)rchDevicePathName115,
		(char)rchDevicePathName116,
		(char)rchDevicePathName117,
		(char)rchDevicePathName118,
		(char)rchDevicePathName119,
		(char)rchDevicePathName120,
		(char)rchDevicePathName121,
		(char)rchDevicePathName122,
		(char)rchDevicePathName123,
		(char)rchDevicePathName124,
		(char)rchDevicePathName125,
		(char)rchDevicePathName126,
		(char)rchDevicePathName127
	}).TrimEnd('\0');

	public string rchInputPathName => new string(new char[128]
	{
		(char)rchInputPathName0,
		(char)rchInputPathName1,
		(char)rchInputPathName2,
		(char)rchInputPathName3,
		(char)rchInputPathName4,
		(char)rchInputPathName5,
		(char)rchInputPathName6,
		(char)rchInputPathName7,
		(char)rchInputPathName8,
		(char)rchInputPathName9,
		(char)rchInputPathName10,
		(char)rchInputPathName11,
		(char)rchInputPathName12,
		(char)rchInputPathName13,
		(char)rchInputPathName14,
		(char)rchInputPathName15,
		(char)rchInputPathName16,
		(char)rchInputPathName17,
		(char)rchInputPathName18,
		(char)rchInputPathName19,
		(char)rchInputPathName20,
		(char)rchInputPathName21,
		(char)rchInputPathName22,
		(char)rchInputPathName23,
		(char)rchInputPathName24,
		(char)rchInputPathName25,
		(char)rchInputPathName26,
		(char)rchInputPathName27,
		(char)rchInputPathName28,
		(char)rchInputPathName29,
		(char)rchInputPathName30,
		(char)rchInputPathName31,
		(char)rchInputPathName32,
		(char)rchInputPathName33,
		(char)rchInputPathName34,
		(char)rchInputPathName35,
		(char)rchInputPathName36,
		(char)rchInputPathName37,
		(char)rchInputPathName38,
		(char)rchInputPathName39,
		(char)rchInputPathName40,
		(char)rchInputPathName41,
		(char)rchInputPathName42,
		(char)rchInputPathName43,
		(char)rchInputPathName44,
		(char)rchInputPathName45,
		(char)rchInputPathName46,
		(char)rchInputPathName47,
		(char)rchInputPathName48,
		(char)rchInputPathName49,
		(char)rchInputPathName50,
		(char)rchInputPathName51,
		(char)rchInputPathName52,
		(char)rchInputPathName53,
		(char)rchInputPathName54,
		(char)rchInputPathName55,
		(char)rchInputPathName56,
		(char)rchInputPathName57,
		(char)rchInputPathName58,
		(char)rchInputPathName59,
		(char)rchInputPathName60,
		(char)rchInputPathName61,
		(char)rchInputPathName62,
		(char)rchInputPathName63,
		(char)rchInputPathName64,
		(char)rchInputPathName65,
		(char)rchInputPathName66,
		(char)rchInputPathName67,
		(char)rchInputPathName68,
		(char)rchInputPathName69,
		(char)rchInputPathName70,
		(char)rchInputPathName71,
		(char)rchInputPathName72,
		(char)rchInputPathName73,
		(char)rchInputPathName74,
		(char)rchInputPathName75,
		(char)rchInputPathName76,
		(char)rchInputPathName77,
		(char)rchInputPathName78,
		(char)rchInputPathName79,
		(char)rchInputPathName80,
		(char)rchInputPathName81,
		(char)rchInputPathName82,
		(char)rchInputPathName83,
		(char)rchInputPathName84,
		(char)rchInputPathName85,
		(char)rchInputPathName86,
		(char)rchInputPathName87,
		(char)rchInputPathName88,
		(char)rchInputPathName89,
		(char)rchInputPathName90,
		(char)rchInputPathName91,
		(char)rchInputPathName92,
		(char)rchInputPathName93,
		(char)rchInputPathName94,
		(char)rchInputPathName95,
		(char)rchInputPathName96,
		(char)rchInputPathName97,
		(char)rchInputPathName98,
		(char)rchInputPathName99,
		(char)rchInputPathName100,
		(char)rchInputPathName101,
		(char)rchInputPathName102,
		(char)rchInputPathName103,
		(char)rchInputPathName104,
		(char)rchInputPathName105,
		(char)rchInputPathName106,
		(char)rchInputPathName107,
		(char)rchInputPathName108,
		(char)rchInputPathName109,
		(char)rchInputPathName110,
		(char)rchInputPathName111,
		(char)rchInputPathName112,
		(char)rchInputPathName113,
		(char)rchInputPathName114,
		(char)rchInputPathName115,
		(char)rchInputPathName116,
		(char)rchInputPathName117,
		(char)rchInputPathName118,
		(char)rchInputPathName119,
		(char)rchInputPathName120,
		(char)rchInputPathName121,
		(char)rchInputPathName122,
		(char)rchInputPathName123,
		(char)rchInputPathName124,
		(char)rchInputPathName125,
		(char)rchInputPathName126,
		(char)rchInputPathName127
	}).TrimEnd('\0');

	public string rchModeName => new string(new char[128]
	{
		(char)rchModeName0,
		(char)rchModeName1,
		(char)rchModeName2,
		(char)rchModeName3,
		(char)rchModeName4,
		(char)rchModeName5,
		(char)rchModeName6,
		(char)rchModeName7,
		(char)rchModeName8,
		(char)rchModeName9,
		(char)rchModeName10,
		(char)rchModeName11,
		(char)rchModeName12,
		(char)rchModeName13,
		(char)rchModeName14,
		(char)rchModeName15,
		(char)rchModeName16,
		(char)rchModeName17,
		(char)rchModeName18,
		(char)rchModeName19,
		(char)rchModeName20,
		(char)rchModeName21,
		(char)rchModeName22,
		(char)rchModeName23,
		(char)rchModeName24,
		(char)rchModeName25,
		(char)rchModeName26,
		(char)rchModeName27,
		(char)rchModeName28,
		(char)rchModeName29,
		(char)rchModeName30,
		(char)rchModeName31,
		(char)rchModeName32,
		(char)rchModeName33,
		(char)rchModeName34,
		(char)rchModeName35,
		(char)rchModeName36,
		(char)rchModeName37,
		(char)rchModeName38,
		(char)rchModeName39,
		(char)rchModeName40,
		(char)rchModeName41,
		(char)rchModeName42,
		(char)rchModeName43,
		(char)rchModeName44,
		(char)rchModeName45,
		(char)rchModeName46,
		(char)rchModeName47,
		(char)rchModeName48,
		(char)rchModeName49,
		(char)rchModeName50,
		(char)rchModeName51,
		(char)rchModeName52,
		(char)rchModeName53,
		(char)rchModeName54,
		(char)rchModeName55,
		(char)rchModeName56,
		(char)rchModeName57,
		(char)rchModeName58,
		(char)rchModeName59,
		(char)rchModeName60,
		(char)rchModeName61,
		(char)rchModeName62,
		(char)rchModeName63,
		(char)rchModeName64,
		(char)rchModeName65,
		(char)rchModeName66,
		(char)rchModeName67,
		(char)rchModeName68,
		(char)rchModeName69,
		(char)rchModeName70,
		(char)rchModeName71,
		(char)rchModeName72,
		(char)rchModeName73,
		(char)rchModeName74,
		(char)rchModeName75,
		(char)rchModeName76,
		(char)rchModeName77,
		(char)rchModeName78,
		(char)rchModeName79,
		(char)rchModeName80,
		(char)rchModeName81,
		(char)rchModeName82,
		(char)rchModeName83,
		(char)rchModeName84,
		(char)rchModeName85,
		(char)rchModeName86,
		(char)rchModeName87,
		(char)rchModeName88,
		(char)rchModeName89,
		(char)rchModeName90,
		(char)rchModeName91,
		(char)rchModeName92,
		(char)rchModeName93,
		(char)rchModeName94,
		(char)rchModeName95,
		(char)rchModeName96,
		(char)rchModeName97,
		(char)rchModeName98,
		(char)rchModeName99,
		(char)rchModeName100,
		(char)rchModeName101,
		(char)rchModeName102,
		(char)rchModeName103,
		(char)rchModeName104,
		(char)rchModeName105,
		(char)rchModeName106,
		(char)rchModeName107,
		(char)rchModeName108,
		(char)rchModeName109,
		(char)rchModeName110,
		(char)rchModeName111,
		(char)rchModeName112,
		(char)rchModeName113,
		(char)rchModeName114,
		(char)rchModeName115,
		(char)rchModeName116,
		(char)rchModeName117,
		(char)rchModeName118,
		(char)rchModeName119,
		(char)rchModeName120,
		(char)rchModeName121,
		(char)rchModeName122,
		(char)rchModeName123,
		(char)rchModeName124,
		(char)rchModeName125,
		(char)rchModeName126,
		(char)rchModeName127
	}).TrimEnd('\0');

	public string rchSlotName => new string(new char[128]
	{
		(char)rchSlotName0,
		(char)rchSlotName1,
		(char)rchSlotName2,
		(char)rchSlotName3,
		(char)rchSlotName4,
		(char)rchSlotName5,
		(char)rchSlotName6,
		(char)rchSlotName7,
		(char)rchSlotName8,
		(char)rchSlotName9,
		(char)rchSlotName10,
		(char)rchSlotName11,
		(char)rchSlotName12,
		(char)rchSlotName13,
		(char)rchSlotName14,
		(char)rchSlotName15,
		(char)rchSlotName16,
		(char)rchSlotName17,
		(char)rchSlotName18,
		(char)rchSlotName19,
		(char)rchSlotName20,
		(char)rchSlotName21,
		(char)rchSlotName22,
		(char)rchSlotName23,
		(char)rchSlotName24,
		(char)rchSlotName25,
		(char)rchSlotName26,
		(char)rchSlotName27,
		(char)rchSlotName28,
		(char)rchSlotName29,
		(char)rchSlotName30,
		(char)rchSlotName31,
		(char)rchSlotName32,
		(char)rchSlotName33,
		(char)rchSlotName34,
		(char)rchSlotName35,
		(char)rchSlotName36,
		(char)rchSlotName37,
		(char)rchSlotName38,
		(char)rchSlotName39,
		(char)rchSlotName40,
		(char)rchSlotName41,
		(char)rchSlotName42,
		(char)rchSlotName43,
		(char)rchSlotName44,
		(char)rchSlotName45,
		(char)rchSlotName46,
		(char)rchSlotName47,
		(char)rchSlotName48,
		(char)rchSlotName49,
		(char)rchSlotName50,
		(char)rchSlotName51,
		(char)rchSlotName52,
		(char)rchSlotName53,
		(char)rchSlotName54,
		(char)rchSlotName55,
		(char)rchSlotName56,
		(char)rchSlotName57,
		(char)rchSlotName58,
		(char)rchSlotName59,
		(char)rchSlotName60,
		(char)rchSlotName61,
		(char)rchSlotName62,
		(char)rchSlotName63,
		(char)rchSlotName64,
		(char)rchSlotName65,
		(char)rchSlotName66,
		(char)rchSlotName67,
		(char)rchSlotName68,
		(char)rchSlotName69,
		(char)rchSlotName70,
		(char)rchSlotName71,
		(char)rchSlotName72,
		(char)rchSlotName73,
		(char)rchSlotName74,
		(char)rchSlotName75,
		(char)rchSlotName76,
		(char)rchSlotName77,
		(char)rchSlotName78,
		(char)rchSlotName79,
		(char)rchSlotName80,
		(char)rchSlotName81,
		(char)rchSlotName82,
		(char)rchSlotName83,
		(char)rchSlotName84,
		(char)rchSlotName85,
		(char)rchSlotName86,
		(char)rchSlotName87,
		(char)rchSlotName88,
		(char)rchSlotName89,
		(char)rchSlotName90,
		(char)rchSlotName91,
		(char)rchSlotName92,
		(char)rchSlotName93,
		(char)rchSlotName94,
		(char)rchSlotName95,
		(char)rchSlotName96,
		(char)rchSlotName97,
		(char)rchSlotName98,
		(char)rchSlotName99,
		(char)rchSlotName100,
		(char)rchSlotName101,
		(char)rchSlotName102,
		(char)rchSlotName103,
		(char)rchSlotName104,
		(char)rchSlotName105,
		(char)rchSlotName106,
		(char)rchSlotName107,
		(char)rchSlotName108,
		(char)rchSlotName109,
		(char)rchSlotName110,
		(char)rchSlotName111,
		(char)rchSlotName112,
		(char)rchSlotName113,
		(char)rchSlotName114,
		(char)rchSlotName115,
		(char)rchSlotName116,
		(char)rchSlotName117,
		(char)rchSlotName118,
		(char)rchSlotName119,
		(char)rchSlotName120,
		(char)rchSlotName121,
		(char)rchSlotName122,
		(char)rchSlotName123,
		(char)rchSlotName124,
		(char)rchSlotName125,
		(char)rchSlotName126,
		(char)rchSlotName127
	}).TrimEnd('\0');

	public string rchInputSourceType => new string(new char[32]
	{
		(char)rchInputSourceType0,
		(char)rchInputSourceType1,
		(char)rchInputSourceType2,
		(char)rchInputSourceType3,
		(char)rchInputSourceType4,
		(char)rchInputSourceType5,
		(char)rchInputSourceType6,
		(char)rchInputSourceType7,
		(char)rchInputSourceType8,
		(char)rchInputSourceType9,
		(char)rchInputSourceType10,
		(char)rchInputSourceType11,
		(char)rchInputSourceType12,
		(char)rchInputSourceType13,
		(char)rchInputSourceType14,
		(char)rchInputSourceType15,
		(char)rchInputSourceType16,
		(char)rchInputSourceType17,
		(char)rchInputSourceType18,
		(char)rchInputSourceType19,
		(char)rchInputSourceType20,
		(char)rchInputSourceType21,
		(char)rchInputSourceType22,
		(char)rchInputSourceType23,
		(char)rchInputSourceType24,
		(char)rchInputSourceType25,
		(char)rchInputSourceType26,
		(char)rchInputSourceType27,
		(char)rchInputSourceType28,
		(char)rchInputSourceType29,
		(char)rchInputSourceType30,
		(char)rchInputSourceType31
	}).TrimEnd('\0');
}
public struct VRActiveActionSet_t
{
	public ulong ulActionSet;

	public ulong ulRestrictedToDevice;

	public ulong ulSecondaryActionSet;

	public uint unPadding;

	public int nPriority;
}
public struct VRSkeletalSummaryData_t
{
	public float flFingerCurl0;

	public float flFingerCurl1;

	public float flFingerCurl2;

	public float flFingerCurl3;

	public float flFingerCurl4;

	public float flFingerSplay0;

	public float flFingerSplay1;

	public float flFingerSplay2;

	public float flFingerSplay3;
}
public struct SpatialAnchorPose_t
{
	public HmdMatrix34_t mAnchorToAbsoluteTracking;
}
public struct COpenVRContext
{
	public IntPtr m_pVRSystem;

	public IntPtr m_pVRChaperone;

	public IntPtr m_pVRChaperoneSetup;

	public IntPtr m_pVRCompositor;

	public IntPtr m_pVRHeadsetView;

	public IntPtr m_pVROverlay;

	public IntPtr m_pVROverlayView;

	public IntPtr m_pVRResources;

	public IntPtr m_pVRRenderModels;

	public IntPtr m_pVRExtendedDisplay;

	public IntPtr m_pVRSettings;

	public IntPtr m_pVRApplications;

	public IntPtr m_pVRTrackedCamera;

	public IntPtr m_pVRScreenshots;

	public IntPtr m_pVRDriverManager;

	public IntPtr m_pVRInput;

	public IntPtr m_pVRIOBuffer;

	public IntPtr m_pVRSpatialAnchors;

	public IntPtr m_pVRDebug;

	public IntPtr m_pVRNotifications;
}
public struct PropertyWrite_t
{
	public ETrackedDeviceProperty prop;

	public EPropertyWriteType writeType;

	public ETrackedPropertyError eSetError;

	public IntPtr pvBuffer;

	public uint unBufferSize;

	public uint unTag;

	public ETrackedPropertyError eError;
}
public struct PropertyRead_t
{
	public ETrackedDeviceProperty prop;

	public IntPtr pvBuffer;

	public uint unBufferSize;

	public uint unTag;

	public uint unRequiredBufferSize;

	public ETrackedPropertyError eError;
}
public struct CVRPropertyHelpers
{
	public IntPtr m_pProperties;
}
public struct PathWrite_t
{
	public ulong ulPath;

	public EPropertyWriteType writeType;

	public ETrackedPropertyError eSetError;

	public IntPtr pvBuffer;

	public uint unBufferSize;

	public uint unTag;

	public ETrackedPropertyError eError;

	public IntPtr pszPath;
}
public struct PathRead_t
{
	public ulong ulPath;

	public IntPtr pvBuffer;

	public uint unBufferSize;

	public uint unTag;

	public uint unRequiredBufferSize;

	public ETrackedPropertyError eError;

	public IntPtr pszPath;
}
public class OpenVR
{
	private class COpenVRContext
	{
		private CVRSystem m_pVRSystem;

		private CVRChaperone m_pVRChaperone;

		private CVRChaperoneSetup m_pVRChaperoneSetup;

		private CVRCompositor m_pVRCompositor;

		private CVRHeadsetView m_pVRHeadsetView;

		private CVROverlay m_pVROverlay;

		private CVROverlayView m_pVROverlayView;

		private CVRRenderModels m_pVRRenderModels;

		private CVRExtendedDisplay m_pVRExtendedDisplay;

		private CVRSettings m_pVRSettings;

		private CVRApplications m_pVRApplications;

		private CVRScreenshots m_pVRScreenshots;

		private CVRTrackedCamera m_pVRTrackedCamera;

		private CVRInput m_pVRInput;

		private CVRIOBuffer m_pVRIOBuffer;

		private CVRSpatialAnchors m_pVRSpatialAnchors;

		private CVRNotifications m_pVRNotifications;

		private CVRDebug m_pVRDebug;

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
			m_pVRHeadsetView = null;
			m_pVROverlay = null;
			m_pVROverlayView = null;
			m_pVRRenderModels = null;
			m_pVRExtendedDisplay = null;
			m_pVRSettings = null;
			m_pVRApplications = null;
			m_pVRScreenshots = null;
			m_pVRTrackedCamera = null;
			m_pVRInput = null;
			m_pVRIOBuffer = null;
			m_pVRSpatialAnchors = null;
			m_pVRNotifications = null;
			m_pVRDebug = null;
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
				IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRSystem_022", ref peError);
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
				IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRChaperone_004", ref peError);
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
				IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRChaperoneSetup_006", ref peError);
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
				IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRCompositor_026", ref peError);
				if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
				{
					m_pVRCompositor = new CVRCompositor(genericInterface);
				}
			}
			return m_pVRCompositor;
		}

		public CVRHeadsetView VRHeadsetView()
		{
			CheckClear();
			if (m_pVRHeadsetView == null)
			{
				EVRInitError peError = EVRInitError.None;
				IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRHeadsetView_001", ref peError);
				if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
				{
					m_pVRHeadsetView = new CVRHeadsetView(genericInterface);
				}
			}
			return m_pVRHeadsetView;
		}

		public CVROverlay VROverlay()
		{
			CheckClear();
			if (m_pVROverlay == null)
			{
				EVRInitError peError = EVRInitError.None;
				IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVROverlay_024", ref peError);
				if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
				{
					m_pVROverlay = new CVROverlay(genericInterface);
				}
			}
			return m_pVROverlay;
		}

		public CVROverlayView VROverlayView()
		{
			CheckClear();
			if (m_pVROverlayView == null)
			{
				EVRInitError peError = EVRInitError.None;
				IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVROverlayView_003", ref peError);
				if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
				{
					m_pVROverlayView = new CVROverlayView(genericInterface);
				}
			}
			return m_pVROverlayView;
		}

		public CVRRenderModels VRRenderModels()
		{
			CheckClear();
			if (m_pVRRenderModels == null)
			{
				EVRInitError peError = EVRInitError.None;
				IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRRenderModels_006", ref peError);
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
				IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRSettings_003", ref peError);
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
				IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRApplications_007", ref peError);
				if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
				{
					m_pVRApplications = new CVRApplications(genericInterface);
				}
			}
			return m_pVRApplications;
		}

		public CVRScreenshots VRScreenshots()
		{
			CheckClear();
			if (m_pVRScreenshots == null)
			{
				EVRInitError peError = EVRInitError.None;
				IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRScreenshots_001", ref peError);
				if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
				{
					m_pVRScreenshots = new CVRScreenshots(genericInterface);
				}
			}
			return m_pVRScreenshots;
		}

		public CVRTrackedCamera VRTrackedCamera()
		{
			CheckClear();
			if (m_pVRTrackedCamera == null)
			{
				EVRInitError peError = EVRInitError.None;
				IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRTrackedCamera_006", ref peError);
				if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
				{
					m_pVRTrackedCamera = new CVRTrackedCamera(genericInterface);
				}
			}
			return m_pVRTrackedCamera;
		}

		public CVRInput VRInput()
		{
			CheckClear();
			if (m_pVRInput == null)
			{
				EVRInitError peError = EVRInitError.None;
				IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRInput_010", ref peError);
				if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
				{
					m_pVRInput = new CVRInput(genericInterface);
				}
			}
			return m_pVRInput;
		}

		public CVRIOBuffer VRIOBuffer()
		{
			CheckClear();
			if (m_pVRIOBuffer == null)
			{
				EVRInitError peError = EVRInitError.None;
				IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRIOBuffer_002", ref peError);
				if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
				{
					m_pVRIOBuffer = new CVRIOBuffer(genericInterface);
				}
			}
			return m_pVRIOBuffer;
		}

		public CVRSpatialAnchors VRSpatialAnchors()
		{
			CheckClear();
			if (m_pVRSpatialAnchors == null)
			{
				EVRInitError peError = EVRInitError.None;
				IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRSpatialAnchors_001", ref peError);
				if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
				{
					m_pVRSpatialAnchors = new CVRSpatialAnchors(genericInterface);
				}
			}
			return m_pVRSpatialAnchors;
		}

		public CVRDebug VRDebug()
		{
			CheckClear();
			if (m_pVRDebug == null)
			{
				EVRInitError peError = EVRInitError.None;
				IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRDebug_001", ref peError);
				if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
				{
					m_pVRDebug = new CVRDebug(genericInterface);
				}
			}
			return m_pVRDebug;
		}

		public CVRNotifications VRNotifications()
		{
			CheckClear();
			if (m_pVRNotifications == null)
			{
				EVRInitError peError = EVRInitError.None;
				IntPtr genericInterface = OpenVRInterop.GetGenericInterface("FnTable:IVRNotifications_002", ref peError);
				if (genericInterface != IntPtr.Zero && peError == EVRInitError.None)
				{
					m_pVRNotifications = new CVRNotifications(genericInterface);
				}
			}
			return m_pVRNotifications;
		}
	}

	public const uint k_nDriverNone = uint.MaxValue;

	public const uint k_unMaxDriverDebugResponseSize = 32768u;

	public const uint k_unTrackedDeviceIndex_Hmd = 0u;

	public const uint k_unMaxTrackedDeviceCount = 64u;

	public const uint k_unTrackedDeviceIndexOther = 4294967294u;

	public const uint k_unTrackedDeviceIndexInvalid = uint.MaxValue;

	public const ulong k_ulInvalidPropertyContainer = 0uL;

	public const uint k_unInvalidPropertyTag = 0u;

	public const ulong k_ulInvalidDriverHandle = 0uL;

	public const uint k_unFloatPropertyTag = 1u;

	public const uint k_unInt32PropertyTag = 2u;

	public const uint k_unUint64PropertyTag = 3u;

	public const uint k_unBoolPropertyTag = 4u;

	public const uint k_unStringPropertyTag = 5u;

	public const uint k_unErrorPropertyTag = 6u;

	public const uint k_unDoublePropertyTag = 7u;

	public const uint k_unHmdMatrix34PropertyTag = 20u;

	public const uint k_unHmdMatrix44PropertyTag = 21u;

	public const uint k_unHmdVector3PropertyTag = 22u;

	public const uint k_unHmdVector4PropertyTag = 23u;

	public const uint k_unHmdVector2PropertyTag = 24u;

	public const uint k_unHmdQuadPropertyTag = 25u;

	public const uint k_unHiddenAreaPropertyTag = 30u;

	public const uint k_unPathHandleInfoTag = 31u;

	public const uint k_unActionPropertyTag = 32u;

	public const uint k_unInputValuePropertyTag = 33u;

	public const uint k_unWildcardPropertyTag = 34u;

	public const uint k_unHapticVibrationPropertyTag = 35u;

	public const uint k_unSkeletonPropertyTag = 36u;

	public const uint k_unSpatialAnchorPosePropertyTag = 40u;

	public const uint k_unJsonPropertyTag = 41u;

	public const uint k_unActiveActionSetPropertyTag = 42u;

	public const uint k_unOpenVRInternalReserved_Start = 1000u;

	public const uint k_unOpenVRInternalReserved_End = 10000u;

	public const uint k_unMaxPropertyStringSize = 32768u;

	public const ulong k_ulInvalidActionHandle = 0uL;

	public const ulong k_ulInvalidActionSetHandle = 0uL;

	public const ulong k_ulInvalidInputValueHandle = 0uL;

	public const uint k_unControllerStateAxisCount = 5u;

	public const ulong k_ulOverlayHandleInvalid = 0uL;

	public const uint k_unMaxDistortionFunctionParameters = 8u;

	public const uint k_unScreenshotHandleInvalid = 0u;

	public const string IVRSystem_Version = "IVRSystem_022";

	public const string IVRExtendedDisplay_Version = "IVRExtendedDisplay_001";

	public const string IVRTrackedCamera_Version = "IVRTrackedCamera_006";

	public const uint k_unMaxApplicationKeyLength = 128u;

	public const string k_pch_MimeType_HomeApp = "vr/home";

	public const string k_pch_MimeType_GameTheater = "vr/game_theater";

	public const string IVRApplications_Version = "IVRApplications_007";

	public const string IVRChaperone_Version = "IVRChaperone_004";

	public const string IVRChaperoneSetup_Version = "IVRChaperoneSetup_006";

	public const string IVRCompositor_Version = "IVRCompositor_026";

	public const uint k_unVROverlayMaxKeyLength = 128u;

	public const uint k_unVROverlayMaxNameLength = 128u;

	public const uint k_unMaxOverlayCount = 128u;

	public const uint k_unMaxOverlayIntersectionMaskPrimitivesCount = 32u;

	public const string IVROverlay_Version = "IVROverlay_024";

	public const string IVROverlayView_Version = "IVROverlayView_003";

	public const uint k_unHeadsetViewMaxWidth = 3840u;

	public const uint k_unHeadsetViewMaxHeight = 2160u;

	public const string k_pchHeadsetViewOverlayKey = "system.HeadsetView";

	public const string IVRHeadsetView_Version = "IVRHeadsetView_001";

	public const string k_pch_Controller_Component_GDC2015 = "gdc2015";

	public const string k_pch_Controller_Component_Base = "base";

	public const string k_pch_Controller_Component_Tip = "tip";

	public const string k_pch_Controller_Component_HandGrip = "handgrip";

	public const string k_pch_Controller_Component_Status = "status";

	public const string IVRRenderModels_Version = "IVRRenderModels_006";

	public const uint k_unNotificationTextMaxSize = 256u;

	public const string IVRNotifications_Version = "IVRNotifications_002";

	public const uint k_unMaxSettingsKeyLength = 128u;

	public const string IVRSettings_Version = "IVRSettings_003";

	public const string k_pch_SteamVR_Section = "steamvr";

	public const string k_pch_SteamVR_RequireHmd_String = "requireHmd";

	public const string k_pch_SteamVR_ForcedDriverKey_String = "forcedDriver";

	public const string k_pch_SteamVR_ForcedHmdKey_String = "forcedHmd";

	public const string k_pch_SteamVR_DisplayDebug_Bool = "displayDebug";

	public const string k_pch_SteamVR_DebugProcessPipe_String = "debugProcessPipe";

	public const string k_pch_SteamVR_DisplayDebugX_Int32 = "displayDebugX";

	public const string k_pch_SteamVR_DisplayDebugY_Int32 = "displayDebugY";

	public const string k_pch_SteamVR_SendSystemButtonToAllApps_Bool = "sendSystemButtonToAllApps";

	public const string k_pch_SteamVR_LogLevel_Int32 = "loglevel";

	public const string k_pch_SteamVR_IPD_Float = "ipd";

	public const string k_pch_SteamVR_Background_String = "background";

	public const string k_pch_SteamVR_BackgroundUseDomeProjection_Bool = "backgroundUseDomeProjection";

	public const string k_pch_SteamVR_BackgroundCameraHeight_Float = "backgroundCameraHeight";

	public const string k_pch_SteamVR_BackgroundDomeRadius_Float = "backgroundDomeRadius";

	public const string k_pch_SteamVR_GridColor_String = "gridColor";

	public const string k_pch_SteamVR_PlayAreaColor_String = "playAreaColor";

	public const string k_pch_SteamVR_TrackingLossColor_String = "trackingLossColor";

	public const string k_pch_SteamVR_ShowStage_Bool = "showStage";

	public const string k_pch_SteamVR_ActivateMultipleDrivers_Bool = "activateMultipleDrivers";

	public const string k_pch_SteamVR_UsingSpeakers_Bool = "usingSpeakers";

	public const string k_pch_SteamVR_SpeakersForwardYawOffsetDegrees_Float = "speakersForwardYawOffsetDegrees";

	public const string k_pch_SteamVR_BaseStationPowerManagement_Int32 = "basestationPowerManagement";

	public const string k_pch_SteamVR_ShowBaseStationPowerManagementTip_Int32 = "ShowBaseStationPowerManagementTip";

	public const string k_pch_SteamVR_NeverKillProcesses_Bool = "neverKillProcesses";

	public const string k_pch_SteamVR_SupersampleScale_Float = "supersampleScale";

	public const string k_pch_SteamVR_MaxRecommendedResolution_Int32 = "maxRecommendedResolution";

	public const string k_pch_SteamVR_MotionSmoothing_Bool = "motionSmoothing";

	public const string k_pch_SteamVR_MotionSmoothingOverride_Int32 = "motionSmoothingOverride";

	public const string k_pch_SteamVR_DisableAsyncReprojection_Bool = "disableAsync";

	public const string k_pch_SteamVR_ForceFadeOnBadTracking_Bool = "forceFadeOnBadTracking";

	public const string k_pch_SteamVR_DefaultMirrorView_Int32 = "mirrorView";

	public const string k_pch_SteamVR_ShowLegacyMirrorView_Bool = "showLegacyMirrorView";

	public const string k_pch_SteamVR_MirrorViewVisibility_Bool = "showMirrorView";

	public const string k_pch_SteamVR_MirrorViewDisplayMode_Int32 = "mirrorViewDisplayMode";

	public const string k_pch_SteamVR_MirrorViewEye_Int32 = "mirrorViewEye";

	public const string k_pch_SteamVR_MirrorViewGeometry_String = "mirrorViewGeometry";

	public const string k_pch_SteamVR_MirrorViewGeometryMaximized_String = "mirrorViewGeometryMaximized";

	public const string k_pch_SteamVR_PerfGraphVisibility_Bool = "showPerfGraph";

	public const string k_pch_SteamVR_StartMonitorFromAppLaunch = "startMonitorFromAppLaunch";

	public const string k_pch_SteamVR_StartCompositorFromAppLaunch_Bool = "startCompositorFromAppLaunch";

	public const string k_pch_SteamVR_StartDashboardFromAppLaunch_Bool = "startDashboardFromAppLaunch";

	public const string k_pch_SteamVR_StartOverlayAppsFromDashboard_Bool = "startOverlayAppsFromDashboard";

	public const string k_pch_SteamVR_EnableHomeApp = "enableHomeApp";

	public const string k_pch_SteamVR_CycleBackgroundImageTimeSec_Int32 = "CycleBackgroundImageTimeSec";

	public const string k_pch_SteamVR_RetailDemo_Bool = "retailDemo";

	public const string k_pch_SteamVR_IpdOffset_Float = "ipdOffset";

	public const string k_pch_SteamVR_AllowSupersampleFiltering_Bool = "allowSupersampleFiltering";

	public const string k_pch_SteamVR_SupersampleManualOverride_Bool = "supersampleManualOverride";

	public const string k_pch_SteamVR_EnableLinuxVulkanAsync_Bool = "enableLinuxVulkanAsync";

	public const string k_pch_SteamVR_AllowDisplayLockedMode_Bool = "allowDisplayLockedMode";

	public const string k_pch_SteamVR_HaveStartedTutorialForNativeChaperoneDriver_Bool = "haveStartedTutorialForNativeChaperoneDriver";

	public const string k_pch_SteamVR_ForceWindows32bitVRMonitor = "forceWindows32BitVRMonitor";

	public const string k_pch_SteamVR_DebugInputBinding = "debugInputBinding";

	public const string k_pch_SteamVR_DoNotFadeToGrid = "doNotFadeToGrid";

	public const string k_pch_SteamVR_RenderCameraMode = "renderCameraMode";

	public const string k_pch_SteamVR_EnableSharedResourceJournaling = "enableSharedResourceJournaling";

	public const string k_pch_SteamVR_EnableSafeMode = "enableSafeMode";

	public const string k_pch_SteamVR_PreferredRefreshRate = "preferredRefreshRate";

	public const string k_pch_SteamVR_LastVersionNotice = "lastVersionNotice";

	public const string k_pch_SteamVR_LastVersionNoticeDate = "lastVersionNoticeDate";

	public const string k_pch_SteamVR_HmdDisplayColorGainR_Float = "hmdDisplayColorGainR";

	public const string k_pch_SteamVR_HmdDisplayColorGainG_Float = "hmdDisplayColorGainG";

	public const string k_pch_SteamVR_HmdDisplayColorGainB_Float = "hmdDisplayColorGainB";

	public const string k_pch_SteamVR_CustomIconStyle_String = "customIconStyle";

	public const string k_pch_SteamVR_CustomOffIconStyle_String = "customOffIconStyle";

	public const string k_pch_SteamVR_CustomIconForceUpdate_String = "customIconForceUpdate";

	public const string k_pch_SteamVR_AllowGlobalActionSetPriority = "globalActionSetPriority";

	public const string k_pch_SteamVR_OverlayRenderQuality = "overlayRenderQuality_2";

	public const string k_pch_SteamVR_BlockOculusSDKOnOpenVRLaunchOption_Bool = "blockOculusSDKOnOpenVRLaunchOption";

	public const string k_pch_SteamVR_BlockOculusSDKOnAllLaunches_Bool = "blockOculusSDKOnAllLaunches";

	public const string k_pch_DirectMode_Section = "direct_mode";

	public const string k_pch_DirectMode_Enable_Bool = "enable";

	public const string k_pch_DirectMode_Count_Int32 = "count";

	public const string k_pch_DirectMode_EdidVid_Int32 = "edidVid";

	public const string k_pch_DirectMode_EdidPid_Int32 = "edidPid";

	public const string k_pch_Lighthouse_Section = "driver_lighthouse";

	public const string k_pch_Lighthouse_DisableIMU_Bool = "disableimu";

	public const string k_pch_Lighthouse_DisableIMUExceptHMD_Bool = "disableimuexcepthmd";

	public const string k_pch_Lighthouse_UseDisambiguation_String = "usedisambiguation";

	public const string k_pch_Lighthouse_DisambiguationDebug_Int32 = "disambiguationdebug";

	public const string k_pch_Lighthouse_PrimaryBasestation_Int32 = "primarybasestation";

	public const string k_pch_Lighthouse_DBHistory_Bool = "dbhistory";

	public const string k_pch_Lighthouse_EnableBluetooth_Bool = "enableBluetooth";

	public const string k_pch_Lighthouse_PowerManagedBaseStations_String = "PowerManagedBaseStations";

	public const string k_pch_Lighthouse_PowerManagedBaseStations2_String = "PowerManagedBaseStations2";

	public const string k_pch_Lighthouse_InactivityTimeoutForBaseStations_Int32 = "InactivityTimeoutForBaseStations";

	public const string k_pch_Lighthouse_EnableImuFallback_Bool = "enableImuFallback";

	public const string k_pch_Null_Section = "driver_null";

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

	public const string k_pch_WindowsMR_Section = "driver_holographic";

	public const string k_pch_UserInterface_Section = "userinterface";

	public const string k_pch_UserInterface_StatusAlwaysOnTop_Bool = "StatusAlwaysOnTop";

	public const string k_pch_UserInterface_MinimizeToTray_Bool = "MinimizeToTray";

	public const string k_pch_UserInterface_HidePopupsWhenStatusMinimized_Bool = "HidePopupsWhenStatusMinimized";

	public const string k_pch_UserInterface_Screenshots_Bool = "screenshots";

	public const string k_pch_UserInterface_ScreenshotType_Int = "screenshotType";

	public const string k_pch_Notifications_Section = "notifications";

	public const string k_pch_Notifications_DoNotDisturb_Bool = "DoNotDisturb";

	public const string k_pch_Keyboard_Section = "keyboard";

	public const string k_pch_Keyboard_TutorialCompletions = "TutorialCompletions";

	public const string k_pch_Keyboard_ScaleX = "ScaleX";

	public const string k_pch_Keyboard_ScaleY = "ScaleY";

	public const string k_pch_Keyboard_OffsetLeftX = "OffsetLeftX";

	public const string k_pch_Keyboard_OffsetRightX = "OffsetRightX";

	public const string k_pch_Keyboard_OffsetY = "OffsetY";

	public const string k_pch_Keyboard_Smoothing = "Smoothing";

	public const string k_pch_Perf_Section = "perfcheck";

	public const string k_pch_Perf_PerfGraphInHMD_Bool = "perfGraphInHMD";

	public const string k_pch_Perf_AllowTimingStore_Bool = "allowTimingStore";

	public const string k_pch_Perf_SaveTimingsOnExit_Bool = "saveTimingsOnExit";

	public const string k_pch_Perf_TestData_Float = "perfTestData";

	public const string k_pch_Perf_GPUProfiling_Bool = "GPUProfiling";

	public const string k_pch_CollisionBounds_Section = "collisionBounds";

	public const string k_pch_CollisionBounds_Style_Int32 = "CollisionBoundsStyle";

	public const string k_pch_CollisionBounds_GroundPerimeterOn_Bool = "CollisionBoundsGroundPerimeterOn";

	public const string k_pch_CollisionBounds_CenterMarkerOn_Bool = "CollisionBoundsCenterMarkerOn";

	public const string k_pch_CollisionBounds_PlaySpaceOn_Bool = "CollisionBoundsPlaySpaceOn";

	public const string k_pch_CollisionBounds_FadeDistance_Float = "CollisionBoundsFadeDistance";

	public const string k_pch_CollisionBounds_WallHeight_Float = "CollisionBoundsWallHeight";

	public const string k_pch_CollisionBounds_ColorGammaR_Int32 = "CollisionBoundsColorGammaR";

	public const string k_pch_CollisionBounds_ColorGammaG_Int32 = "CollisionBoundsColorGammaG";

	public const string k_pch_CollisionBounds_ColorGammaB_Int32 = "CollisionBoundsColorGammaB";

	public const string k_pch_CollisionBounds_ColorGammaA_Int32 = "CollisionBoundsColorGammaA";

	public const string k_pch_CollisionBounds_EnableDriverImport = "enableDriverBoundsImport";

	public const string k_pch_Camera_Section = "camera";

	public const string k_pch_Camera_EnableCamera_Bool = "enableCamera";

	public const string k_pch_Camera_ShowOnController_Bool = "showOnController";

	public const string k_pch_Camera_EnableCameraForCollisionBounds_Bool = "enableCameraForCollisionBounds";

	public const string k_pch_Camera_RoomView_Int32 = "roomView";

	public const string k_pch_Camera_BoundsColorGammaR_Int32 = "cameraBoundsColorGammaR";

	public const string k_pch_Camera_BoundsColorGammaG_Int32 = "cameraBoundsColorGammaG";

	public const string k_pch_Camera_BoundsColorGammaB_Int32 = "cameraBoundsColorGammaB";

	public const string k_pch_Camera_BoundsColorGammaA_Int32 = "cameraBoundsColorGammaA";

	public const string k_pch_Camera_BoundsStrength_Int32 = "cameraBoundsStrength";

	public const string k_pch_Camera_RoomViewStyle_Int32 = "roomViewStyle";

	public const string k_pch_audio_Section = "audio";

	public const string k_pch_audio_SetOsDefaultPlaybackDevice_Bool = "setOsDefaultPlaybackDevice";

	public const string k_pch_audio_EnablePlaybackDeviceOverride_Bool = "enablePlaybackDeviceOverride";

	public const string k_pch_audio_PlaybackDeviceOverride_String = "playbackDeviceOverride";

	public const string k_pch_audio_PlaybackDeviceOverrideName_String = "playbackDeviceOverrideName";

	public const string k_pch_audio_SetOsDefaultRecordingDevice_Bool = "setOsDefaultRecordingDevice";

	public const string k_pch_audio_EnableRecordingDeviceOverride_Bool = "enableRecordingDeviceOverride";

	public const string k_pch_audio_RecordingDeviceOverride_String = "recordingDeviceOverride";

	public const string k_pch_audio_RecordingDeviceOverrideName_String = "recordingDeviceOverrideName";

	public const string k_pch_audio_EnablePlaybackMirror_Bool = "enablePlaybackMirror";

	public const string k_pch_audio_PlaybackMirrorDevice_String = "playbackMirrorDevice";

	public const string k_pch_audio_PlaybackMirrorDeviceName_String = "playbackMirrorDeviceName";

	public const string k_pch_audio_OldPlaybackMirrorDevice_String = "onPlaybackMirrorDevice";

	public const string k_pch_audio_ActiveMirrorDevice_String = "activePlaybackMirrorDevice";

	public const string k_pch_audio_EnablePlaybackMirrorIndependentVolume_Bool = "enablePlaybackMirrorIndependentVolume";

	public const string k_pch_audio_LastHmdPlaybackDeviceId_String = "lastHmdPlaybackDeviceId";

	public const string k_pch_audio_VIVEHDMIGain = "viveHDMIGain";

	public const string k_pch_audio_DualSpeakerAndJackOutput_Bool = "dualSpeakerAndJackOutput";

	public const string k_pch_Power_Section = "power";

	public const string k_pch_Power_PowerOffOnExit_Bool = "powerOffOnExit";

	public const string k_pch_Power_TurnOffScreensTimeout_Float = "turnOffScreensTimeout";

	public const string k_pch_Power_TurnOffControllersTimeout_Float = "turnOffControllersTimeout";

	public const string k_pch_Power_ReturnToWatchdogTimeout_Float = "returnToWatchdogTimeout";

	public const string k_pch_Power_AutoLaunchSteamVROnButtonPress = "autoLaunchSteamVROnButtonPress";

	public const string k_pch_Power_PauseCompositorOnStandby_Bool = "pauseCompositorOnStandby";

	public const string k_pch_Dashboard_Section = "dashboard";

	public const string k_pch_Dashboard_EnableDashboard_Bool = "enableDashboard";

	public const string k_pch_Dashboard_ArcadeMode_Bool = "arcadeMode";

	public const string k_pch_Dashboard_Position = "position";

	public const string k_pch_Dashboard_DesktopScale = "desktopScale";

	public const string k_pch_Dashboard_DashboardScale = "dashboardScale";

	public const string k_pch_modelskin_Section = "modelskins";

	public const string k_pch_Driver_Enable_Bool = "enable";

	public const string k_pch_Driver_BlockedBySafemode_Bool = "blocked_by_safe_mode";

	public const string k_pch_Driver_LoadPriority_Int32 = "loadPriority";

	public const string k_pch_WebInterface_Section = "WebInterface";

	public const string k_pch_VRWebHelper_Section = "VRWebHelper";

	public const string k_pch_VRWebHelper_DebuggerEnabled_Bool = "DebuggerEnabled";

	public const string k_pch_VRWebHelper_DebuggerPort_Int32 = "DebuggerPort";

	public const string k_pch_TrackingOverride_Section = "TrackingOverrides";

	public const string k_pch_App_BindingAutosaveURLSuffix_String = "AutosaveURL";

	public const string k_pch_App_BindingLegacyAPISuffix_String = "_legacy";

	public const string k_pch_App_BindingSteamVRInputAPISuffix_String = "_steamvrinput";

	public const string k_pch_App_BindingCurrentURLSuffix_String = "CurrentURL";

	public const string k_pch_App_BindingPreviousURLSuffix_String = "PreviousURL";

	public const string k_pch_App_NeedToUpdateAutosaveSuffix_Bool = "NeedToUpdateAutosave";

	public const string k_pch_App_DominantHand_Int32 = "DominantHand";

	public const string k_pch_App_BlockOculusSDK_Bool = "blockOculusSDK";

	public const string k_pch_Trackers_Section = "trackers";

	public const string k_pch_DesktopUI_Section = "DesktopUI";

	public const string k_pch_LastKnown_Section = "LastKnown";

	public const string k_pch_LastKnown_HMDManufacturer_String = "HMDManufacturer";

	public const string k_pch_LastKnown_HMDModel_String = "HMDModel";

	public const string k_pch_DismissedWarnings_Section = "DismissedWarnings";

	public const string k_pch_Input_Section = "input";

	public const string k_pch_Input_LeftThumbstickRotation_Float = "leftThumbstickRotation";

	public const string k_pch_Input_RightThumbstickRotation_Float = "rightThumbstickRotation";

	public const string k_pch_Input_ThumbstickDeadzone_Float = "thumbstickDeadzone";

	public const string k_pch_GpuSpeed_Section = "GpuSpeed";

	public const string IVRScreenshots_Version = "IVRScreenshots_001";

	public const string IVRResources_Version = "IVRResources_001";

	public const string IVRDriverManager_Version = "IVRDriverManager_001";

	public const uint k_unMaxActionNameLength = 64u;

	public const uint k_unMaxActionSetNameLength = 64u;

	public const uint k_unMaxActionOriginCount = 16u;

	public const uint k_unMaxBoneNameLength = 32u;

	public const int k_nActionSetOverlayGlobalPriorityMin = 16777216;

	public const int k_nActionSetOverlayGlobalPriorityMax = 33554431;

	public const int k_nActionSetPriorityReservedMin = 33554432;

	public const string IVRInput_Version = "IVRInput_010";

	public const ulong k_ulInvalidIOBufferHandle = 0uL;

	public const string IVRIOBuffer_Version = "IVRIOBuffer_002";

	public const uint k_ulInvalidSpatialAnchorHandle = 0u;

	public const string IVRSpatialAnchors_Version = "IVRSpatialAnchors_001";

	public const string IVRDebug_Version = "IVRDebug_001";

	public const ulong k_ulDisplayRedirectContainer = 25769803779uL;

	public const string IVRProperties_Version = "IVRProperties_001";

	public const string k_pchPathUserHandRight = "/user/hand/right";

	public const string k_pchPathUserHandLeft = "/user/hand/left";

	public const string k_pchPathUserHandPrimary = "/user/hand/primary";

	public const string k_pchPathUserHandSecondary = "/user/hand/secondary";

	public const string k_pchPathUserHead = "/user/head";

	public const string k_pchPathUserGamepad = "/user/gamepad";

	public const string k_pchPathUserTreadmill = "/user/treadmill";

	public const string k_pchPathUserStylus = "/user/stylus";

	public const string k_pchPathDevices = "/devices";

	public const string k_pchPathDevicePath = "/device_path";

	public const string k_pchPathBestAliasPath = "/best_alias_path";

	public const string k_pchPathBoundTrackerAliasPath = "/bound_tracker_path";

	public const string k_pchPathBoundTrackerRole = "/bound_tracker_role";

	public const string k_pchPathPoseRaw = "/pose/raw";

	public const string k_pchPathPoseTip = "/pose/tip";

	public const string k_pchPathPoseGrip = "/pose/grip";

	public const string k_pchPathSystemButtonClick = "/input/system/click";

	public const string k_pchPathProximity = "/proximity";

	public const string k_pchPathControllerTypePrefix = "/controller_type/";

	public const string k_pchPathInputProfileSuffix = "/input_profile";

	public const string k_pchPathBindingNameSuffix = "/binding_name";

	public const string k_pchPathBindingUrlSuffix = "/binding_url";

	public const string k_pchPathBindingErrorSuffix = "/binding_error";

	public const string k_pchPathActiveActionSets = "/active_action_sets";

	public const string k_pchPathComponentUpdates = "/total_component_updates";

	public const string k_pchPathUserFootLeft = "/user/foot/left";

	public const string k_pchPathUserFootRight = "/user/foot/right";

	public const string k_pchPathUserShoulderLeft = "/user/shoulder/left";

	public const string k_pchPathUserShoulderRight = "/user/shoulder/right";

	public const string k_pchPathUserElbowLeft = "/user/elbow/left";

	public const string k_pchPathUserElbowRight = "/user/elbow/right";

	public const string k_pchPathUserKneeLeft = "/user/knee/left";

	public const string k_pchPathUserKneeRight = "/user/knee/right";

	public const string k_pchPathUserWaist = "/user/waist";

	public const string k_pchPathUserChest = "/user/chest";

	public const string k_pchPathUserCamera = "/user/camera";

	public const string k_pchPathUserKeyboard = "/user/keyboard";

	public const string k_pchPathClientAppKey = "/client_info/app_key";

	public const ulong k_ulInvalidPathHandle = 0uL;

	public const string IVRPaths_Version = "IVRPaths_001";

	public const string IVRBlockQueue_Version = "IVRBlockQueue_004";

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

	public static CVRHeadsetView HeadsetView => OpenVRInternal_ModuleContext.VRHeadsetView();

	public static CVROverlay Overlay => OpenVRInternal_ModuleContext.VROverlay();

	public static CVROverlayView OverlayView => OpenVRInternal_ModuleContext.VROverlayView();

	public static CVRRenderModels RenderModels => OpenVRInternal_ModuleContext.VRRenderModels();

	public static CVRExtendedDisplay ExtendedDisplay => OpenVRInternal_ModuleContext.VRExtendedDisplay();

	public static CVRSettings Settings => OpenVRInternal_ModuleContext.VRSettings();

	public static CVRApplications Applications => OpenVRInternal_ModuleContext.VRApplications();

	public static CVRScreenshots Screenshots => OpenVRInternal_ModuleContext.VRScreenshots();

	public static CVRTrackedCamera TrackedCamera => OpenVRInternal_ModuleContext.VRTrackedCamera();

	public static CVRInput Input => OpenVRInternal_ModuleContext.VRInput();

	public static CVRIOBuffer IOBuffer => OpenVRInternal_ModuleContext.VRIOBuffer();

	public static CVRSpatialAnchors SpatialAnchors => OpenVRInternal_ModuleContext.VRSpatialAnchors();

	public static CVRNotifications Notifications => OpenVRInternal_ModuleContext.VRNotifications();

	public static CVRDebug Debug => OpenVRInternal_ModuleContext.VRDebug();

	public static uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType)
	{
		return OpenVRInterop.InitInternal(ref peError, eApplicationType);
	}

	public static uint InitInternal2(ref EVRInitError peError, EVRApplicationType eApplicationType, string pchStartupInfo)
	{
		return OpenVRInterop.InitInternal2(ref peError, eApplicationType, pchStartupInfo);
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

	public static string RuntimePath()
	{
		try
		{
			uint num = 512u;
			uint punRequiredBufferSize = 512u;
			StringBuilder stringBuilder = new StringBuilder((int)num);
			if (!OpenVRInterop.GetRuntimePath(stringBuilder, num, ref punRequiredBufferSize))
			{
				return null;
			}
			return stringBuilder.ToString();
		}
		catch
		{
			return OpenVRInterop.RuntimePath();
		}
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

	public static CVRSystem Init(ref EVRInitError peError, EVRApplicationType eApplicationType = EVRApplicationType.VRApplication_Scene, string pchStartupInfo = "")
	{
		try
		{
			VRToken = InitInternal2(ref peError, eApplicationType, pchStartupInfo);
		}
		catch (EntryPointNotFoundException)
		{
			VRToken = InitInternal(ref peError, eApplicationType);
		}
		OpenVRInternal_ModuleContext.Clear();
		if (peError != 0)
		{
			return null;
		}
		if (!IsInterfaceVersionValid("IVRSystem_022"))
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
