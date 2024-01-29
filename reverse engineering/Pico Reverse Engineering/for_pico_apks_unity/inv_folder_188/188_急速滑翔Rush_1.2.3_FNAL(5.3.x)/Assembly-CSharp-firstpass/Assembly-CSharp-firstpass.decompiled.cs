using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using CodeStage.AdvancedFPSCounter.CountersData;
using CodeStage.AdvancedFPSCounter.Labels;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.Store;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class AndroidRuntimePermissions
{
	[Token(Token = "0x20000BC")]
	public enum Permission
	{
		[Token(Token = "0x400059F")]
		Denied,
		[Token(Token = "0x40005A0")]
		Granted,
		[Token(Token = "0x40005A1")]
		ShouldAsk
	}

	[Token(Token = "0x20000BD")]
	public delegate void PermissionResult(string permission, Permission result);

	[Token(Token = "0x20000BE")]
	public delegate void PermissionResultMultiple(string[] permissions, Permission[] result);

	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB26AAC", Offset = "0xB26AAC")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PermissionResult callback;

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x16BA25C", Offset = "0x16BA25C", VA = "0x16BA25C")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x16BA5F8", Offset = "0x16BA5F8", VA = "0x16BA5F8")]
		internal void <RequestPermissionAsync>b__0(string[] permissions, Permission[] result)
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AndroidJavaClass m_ajc;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static AndroidJavaObject m_context;

	[Token(Token = "0x17000001")]
	private static AndroidJavaClass AJC
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x16B9220", Offset = "0x16B9220", VA = "0x16B9220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	private static AndroidJavaObject Context
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x16B92FC", Offset = "0x16B92FC", VA = "0x16B92FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x16B94AC", Offset = "0x16B94AC", VA = "0x16B94AC")]
	public static void OpenSettings()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x16B959C", Offset = "0x16B959C", VA = "0x16B959C")]
	public static Permission CheckPermission(string permission)
	{
		return default(Permission);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x16B9670", Offset = "0x16B9670", VA = "0x16B9670")]
	public static Permission[] CheckPermissions(params string[] permissions)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x16B9A44", Offset = "0x16B9A44", VA = "0x16B9A44")]
	public static Permission RequestPermission(string permission)
	{
		return default(Permission);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x16B9B18", Offset = "0x16B9B18", VA = "0x16B9B18")]
	public static Permission[] RequestPermissions(params string[] permissions)
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x16BA13C", Offset = "0x16BA13C", VA = "0x16BA13C")]
	private static void RequestPermissionAsync(string permission, PermissionResult callback)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x16BA274", Offset = "0x16BA274", VA = "0x16BA274")]
	private static void RequestPermissionsAsync(string[] permissions, PermissionResultMultiple callback)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x16B9FB8", Offset = "0x16B9FB8", VA = "0x16B9FB8")]
	public static Permission[] ProcessPermissionRequest(string[] permissions, string resultRaw)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x16B99D8", Offset = "0x16B99D8", VA = "0x16B99D8")]
	private static Permission GetCachedPermission(string permission, Permission defaultValue)
	{
		return default(Permission);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x16B9EAC", Offset = "0x16B9EAC", VA = "0x16B9EAC")]
	private static string GetCachedPermissions(string[] permissions)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x16BA4B0", Offset = "0x16BA4B0", VA = "0x16BA4B0")]
	private static bool CachePermission(string permission, Permission value)
	{
		return default(bool);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x16B98DC", Offset = "0x16B98DC", VA = "0x16B98DC")]
	private static void ValidateArgument(string[] permissions)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x16BA550", Offset = "0x16BA550", VA = "0x16BA550")]
	private static Permission[] GetDummyResult(string[] permissions)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x16B99CC", Offset = "0x16B99CC", VA = "0x16B99CC")]
	private static Permission ToPermission(this char ch)
	{
		return default(Permission);
	}
}
[Token(Token = "0x2000003")]
internal class LabelEffect
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enabled;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Color color;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector2 distance;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int padding;

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x16BF11C", Offset = "0x16BF11C", VA = "0x16BF11C")]
	internal LabelEffect(bool enabled, Color color, int padding)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x16BF1E8", Offset = "0x16BF1E8", VA = "0x16BF1E8")]
	internal LabelEffect(bool enabled, Color color, Vector2 distance)
	{
	}
}
namespace AppStoresSupport
{
	[Serializable]
	[Token(Token = "0x2000004")]
	public class AppStoreSetting
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string AppID;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string AppKey;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsTestMode;

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x16BB3D4", Offset = "0x16BB3D4", VA = "0x16BB3D4")]
		public AppStoreSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000005")]
	public class AppStoreSettings : ScriptableObject
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string UnityClientID;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string UnityClientKey;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string UnityClientRSAPublicKey;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AppStoreSetting XiaomiAppStoreSetting;

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x16BB42C", Offset = "0x16BB42C", VA = "0x16BB42C")]
		public AppInfo getAppInfo()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x16BB4D4", Offset = "0x16BB4D4", VA = "0x16BB4D4")]
		public AppStoreSettings()
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000006")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C0")]
		public enum UpdateMode
		{
			[Token(Token = "0x40005A4")]
			Update,
			[Token(Token = "0x40005A5")]
			FixedUpdate,
			[Token(Token = "0x40005A6")]
			LateUpdate,
			[Token(Token = "0x40005A7")]
			FixedLateUpdate
		}

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB26B5C", Offset = "0xB26B5C")]
		public bool smoothFollow;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB26B94", Offset = "0xB26B94")]
		public float rotationSensitivity;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB26BCC", Offset = "0xB26BCC")]
		public float distance;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB26C04", Offset = "0xB26C04")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB26C3C", Offset = "0xB26C3C")]
		public float blockedOffset;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB26C54", Offset = "0xB26C54")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB26C64", Offset = "0xB26C64")]
		private float <y>k__BackingField;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB26C74", Offset = "0xB26C74")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000003")]
		public float x
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x12DF0A0", Offset = "0x12DF0A0", VA = "0x12DF0A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F158", Offset = "0xB2F158")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x12DF0A8", Offset = "0x12DF0A8", VA = "0x12DF0A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F168", Offset = "0xB2F168")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public float y
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x12DF0B0", Offset = "0x12DF0B0", VA = "0x12DF0B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F178", Offset = "0xB2F178")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x12DF0B8", Offset = "0x12DF0B8", VA = "0x12DF0B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F188", Offset = "0xB2F188")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float distanceTarget
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x12DF0C0", Offset = "0x12DF0C0", VA = "0x12DF0C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F198", Offset = "0xB2F198")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x12DF0C8", Offset = "0x12DF0C8", VA = "0x12DF0C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F1A8", Offset = "0xB2F1A8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		private float zoomAdd
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x12DFB30", Offset = "0x12DFB30", VA = "0x12DFB30")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x12DF0D0", Offset = "0x12DF0D0", VA = "0x12DF0D0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x12DF1EC", Offset = "0x12DF1EC", VA = "0x12DF1EC", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x12DF248", Offset = "0x12DF248", VA = "0x12DF248", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x12DF2B0", Offset = "0x12DF2B0", VA = "0x12DF2B0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x12DF314", Offset = "0x12DF314", VA = "0x12DF314")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x12DF220", Offset = "0x12DF220", VA = "0x12DF220")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x12DF494", Offset = "0x12DF494", VA = "0x12DF494")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x12DFA80", Offset = "0x12DFA80", VA = "0x12DFA80")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x12DFBA4", Offset = "0x12DFBA4", VA = "0x12DFBA4")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x12DFCB4", Offset = "0x12DFCB4", VA = "0x12DFCB4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x12DFCEC", Offset = "0x12DFCEC", VA = "0x12DFCEC")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x12DFEA4", Offset = "0x12DFEA4", VA = "0x12DFEA4")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x12DFF54", Offset = "0x12DFF54", VA = "0x12DFF54")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000008")]
	public enum Axis
	{
		[Token(Token = "0x4000039")]
		X,
		[Token(Token = "0x400003A")]
		Y,
		[Token(Token = "0x400003B")]
		Z
	}
	[Token(Token = "0x2000009")]
	public class AxisTools
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x16CAFA8", Offset = "0x16CAFA8", VA = "0x16CAFA8")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x16CB060", Offset = "0x16CB060", VA = "0x16CB060")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x16CB10C", Offset = "0x16CB10C", VA = "0x16CB10C")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x16CB2F0", Offset = "0x16CB2F0", VA = "0x16CB2F0")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x16CB228", Offset = "0x16CB228", VA = "0x16CB228")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x16CB40C", Offset = "0x16CB40C", VA = "0x16CB40C")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x16CB638", Offset = "0x16CB638", VA = "0x16CB638")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000A")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x20000C1")]
		public class LimbOrientation
		{
			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x16CB900", Offset = "0x16CB900", VA = "0x16CB900")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000007")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x16CB68C", Offset = "0x16CB68C", VA = "0x16CB68C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x16CB978", Offset = "0x16CB978", VA = "0x16CB978")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x16CB640", Offset = "0x16CB640", VA = "0x16CB640")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x20000C2")]
		public enum BoneType
		{
			[Token(Token = "0x40005AC")]
			Unassigned,
			[Token(Token = "0x40005AD")]
			Spine,
			[Token(Token = "0x40005AE")]
			Head,
			[Token(Token = "0x40005AF")]
			Arm,
			[Token(Token = "0x40005B0")]
			Leg,
			[Token(Token = "0x40005B1")]
			Tail,
			[Token(Token = "0x40005B2")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x20000C3")]
		public enum BoneSide
		{
			[Token(Token = "0x40005B4")]
			Center,
			[Token(Token = "0x40005B5")]
			Left,
			[Token(Token = "0x40005B6")]
			Right
		}

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x16CBBEC", Offset = "0x16CBBEC", VA = "0x16CBBEC")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x16CBEEC", Offset = "0x16CBEEC", VA = "0x16CBEEC")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x16CC13C", Offset = "0x16CC13C", VA = "0x16CC13C")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x16CC1C0", Offset = "0x16CC1C0", VA = "0x16CC1C0")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x16CC26C", Offset = "0x16CC26C", VA = "0x16CC26C")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x16CBD9C", Offset = "0x16CBD9C", VA = "0x16CBD9C")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x16CC09C", Offset = "0x16CC09C", VA = "0x16CC09C")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x16CCAAC", Offset = "0x16CCAAC", VA = "0x16CCAAC")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x16CC8C4", Offset = "0x16CC8C4", VA = "0x16CC8C4")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x16CC9B8", Offset = "0x16CC9B8", VA = "0x16CC9B8")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x16CC48C", Offset = "0x16CC48C", VA = "0x16CC48C")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x16CC540", Offset = "0x16CC540", VA = "0x16CC540")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x16CC5F4", Offset = "0x16CC5F4", VA = "0x16CC5F4")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x16CC6A8", Offset = "0x16CC6A8", VA = "0x16CC6A8")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x16CC75C", Offset = "0x16CC75C", VA = "0x16CC75C")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x16CC810", Offset = "0x16CC810", VA = "0x16CC810")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x16CCCC0", Offset = "0x16CCCC0", VA = "0x16CCCC0")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x16CC3A0", Offset = "0x16CC3A0", VA = "0x16CC3A0")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x16CCC30", Offset = "0x16CCC30", VA = "0x16CCC30")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x16CCD30", Offset = "0x16CCD30", VA = "0x16CCD30")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x16CCE08", Offset = "0x16CCE08", VA = "0x16CCE08")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x16CCBB4", Offset = "0x16CCBB4", VA = "0x16CCBB4")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x16CCB3C", Offset = "0x16CCB3C", VA = "0x16CCB3C")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	public class BipedReferences
	{
		[Token(Token = "0x20000C4")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x170000B4")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x600067D")]
				[Address(RVA = "0x12DF098", Offset = "0x12DF098", VA = "0x12DF098")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x12DF084", Offset = "0x12DF084", VA = "0x12DF084")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000009")]
		public virtual bool isFilled
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x16CE97C", Offset = "0x16CE97C", VA = "0x16CE97C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		public bool isEmpty
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x16CED68", Offset = "0x16CED68", VA = "0x16CED68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x16CED78", Offset = "0x16CED78", VA = "0x16CED78", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x16CF1A4", Offset = "0x16CF1A4", VA = "0x16CF1A4", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x16CF5DC", Offset = "0x16CF5DC", VA = "0x16CF5DC")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x16CFBEC", Offset = "0x16CFBEC", VA = "0x16CFBEC")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x16CF828", Offset = "0x16CF828", VA = "0x16CF828")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x16D039C", Offset = "0x16D039C", VA = "0x16D039C")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x16D0490", Offset = "0x16D0490", VA = "0x16D0490")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x16D09E8", Offset = "0x16D09E8", VA = "0x16D09E8")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x16D07EC", Offset = "0x16D07EC", VA = "0x16D07EC")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x16D0664", Offset = "0x16D0664", VA = "0x16D0664")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x16D0530", Offset = "0x16D0530", VA = "0x16D0530")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x16D08F0", Offset = "0x16D08F0", VA = "0x16D08F0")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x16D0AE4", Offset = "0x16D0AE4", VA = "0x16D0AE4")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x16D1584", Offset = "0x16D1584", VA = "0x16D1584")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x16D1068", Offset = "0x16D1068", VA = "0x16D1068")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x16D1878", Offset = "0x16D1878", VA = "0x16D1878")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x16D13A8", Offset = "0x16D13A8", VA = "0x16D13A8")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x16D1880", Offset = "0x16D1880", VA = "0x16D1880")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x16D1888", Offset = "0x16D1888", VA = "0x16D1888")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x16D1A48", Offset = "0x16D1A48", VA = "0x16D1A48")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x16D1C60", Offset = "0x16D1C60", VA = "0x16D1C60")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x16CF7B8", Offset = "0x16CF7B8", VA = "0x16CF7B8")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x12DFF70", Offset = "0x12DFF70", VA = "0x12DFF70")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x12DFF78", Offset = "0x12DFF78", VA = "0x12DFF78")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x12E00B8", Offset = "0x12E00B8", VA = "0x12E00B8")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class Hierarchy
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x14F09A8", Offset = "0x14F09A8", VA = "0x14F09A8")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x14F0BA8", Offset = "0x14F0BA8", VA = "0x14F0BA8")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x14F0A40", Offset = "0x14F0A40", VA = "0x14F0A40")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x14F0CCC", Offset = "0x14F0CCC", VA = "0x14F0CCC")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x14F0DF0", Offset = "0x14F0DF0", VA = "0x14F0DF0")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x14F1098", Offset = "0x14F1098", VA = "0x14F1098")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x14F11B4", Offset = "0x14F11B4", VA = "0x14F11B4")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x14F133C", Offset = "0x14F133C", VA = "0x14F133C")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x14F16D0", Offset = "0x14F16D0", VA = "0x14F16D0")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x14F14BC", Offset = "0x14F14BC", VA = "0x14F14BC")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x14F1870", Offset = "0x14F1870", VA = "0x14F1870")]
		public Hierarchy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000010")]
	public enum InterpolationMode
	{
		[Token(Token = "0x4000067")]
		None,
		[Token(Token = "0x4000068")]
		InOutCubic,
		[Token(Token = "0x4000069")]
		InOutQuintic,
		[Token(Token = "0x400006A")]
		InOutSine,
		[Token(Token = "0x400006B")]
		InQuintic,
		[Token(Token = "0x400006C")]
		InQuartic,
		[Token(Token = "0x400006D")]
		InCubic,
		[Token(Token = "0x400006E")]
		InQuadratic,
		[Token(Token = "0x400006F")]
		InElastic,
		[Token(Token = "0x4000070")]
		InElasticSmall,
		[Token(Token = "0x4000071")]
		InElasticBig,
		[Token(Token = "0x4000072")]
		InSine,
		[Token(Token = "0x4000073")]
		InBack,
		[Token(Token = "0x4000074")]
		OutQuintic,
		[Token(Token = "0x4000075")]
		OutQuartic,
		[Token(Token = "0x4000076")]
		OutCubic,
		[Token(Token = "0x4000077")]
		OutInCubic,
		[Token(Token = "0x4000078")]
		OutInQuartic,
		[Token(Token = "0x4000079")]
		OutElastic,
		[Token(Token = "0x400007A")]
		OutElasticSmall,
		[Token(Token = "0x400007B")]
		OutElasticBig,
		[Token(Token = "0x400007C")]
		OutSine,
		[Token(Token = "0x400007D")]
		OutBack,
		[Token(Token = "0x400007E")]
		OutBackCubic,
		[Token(Token = "0x400007F")]
		OutBackQuartic,
		[Token(Token = "0x4000080")]
		BackInCubic,
		[Token(Token = "0x4000081")]
		BackInQuartic
	}
	[Token(Token = "0x2000011")]
	public class Interp
	{
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x14DC758", Offset = "0x14DC758", VA = "0x14DC758")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x14F1F74", Offset = "0x14F1F74", VA = "0x14F1F74")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x14F207C", Offset = "0x14F207C", VA = "0x14F207C")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x14F1878", Offset = "0x14F1878", VA = "0x14F1878")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x14F1884", Offset = "0x14F1884", VA = "0x14F1884")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x14F18A8", Offset = "0x14F18A8", VA = "0x14F18A8")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x14F18E4", Offset = "0x14F18E4", VA = "0x14F18E4")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x14F18FC", Offset = "0x14F18FC", VA = "0x14F18FC")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x14F1910", Offset = "0x14F1910", VA = "0x14F1910")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x14F1924", Offset = "0x14F1924", VA = "0x14F1924")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x14F1934", Offset = "0x14F1934", VA = "0x14F1934")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x14F197C", Offset = "0x14F197C", VA = "0x14F197C")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x14F19B4", Offset = "0x14F19B4", VA = "0x14F19B4")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x14F19DC", Offset = "0x14F19DC", VA = "0x14F19DC")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x14F2178", Offset = "0x14F2178", VA = "0x14F2178")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x14F1A10", Offset = "0x14F1A10", VA = "0x14F1A10")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x14F1A38", Offset = "0x14F1A38", VA = "0x14F1A38")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x14F1A68", Offset = "0x14F1A68", VA = "0x14F1A68")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x14F1A9C", Offset = "0x14F1A9C", VA = "0x14F1A9C")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x14F1AE0", Offset = "0x14F1AE0", VA = "0x14F1AE0")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x14F1B44", Offset = "0x14F1B44", VA = "0x14F1B44")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x14F1BA8", Offset = "0x14F1BA8", VA = "0x14F1BA8")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x14F1BFC", Offset = "0x14F1BFC", VA = "0x14F1BFC")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x14F1C50", Offset = "0x14F1C50", VA = "0x14F1C50")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x14F1CE8", Offset = "0x14F1CE8", VA = "0x14F1CE8")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x14F1D7C", Offset = "0x14F1D7C", VA = "0x14F1D7C")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x14F21AC", Offset = "0x14F21AC", VA = "0x14F21AC")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x14F1E20", Offset = "0x14F1E20", VA = "0x14F1E20")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x14F1F04", Offset = "0x14F1F04", VA = "0x14F1F04")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x14F1F34", Offset = "0x14F1F34", VA = "0x14F1F34")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x14F2294", Offset = "0x14F2294", VA = "0x14F2294")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x14F229C", Offset = "0x14F229C", VA = "0x14F229C")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x14F230C", Offset = "0x14F230C", VA = "0x14F230C")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000013")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x14F237C", Offset = "0x14F237C", VA = "0x14F237C")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x14F23D4", Offset = "0x14F23D4", VA = "0x14F23D4")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x14F24A0", Offset = "0x14F24A0", VA = "0x14F24A0")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x14F23EC", Offset = "0x14F23EC", VA = "0x14F23EC")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x14F24B8", Offset = "0x14F24B8", VA = "0x14F24B8")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x14F255C", Offset = "0x14F255C", VA = "0x14F255C")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x14F2588", Offset = "0x14F2588", VA = "0x14F2588")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x14F25D8", Offset = "0x14F25D8", VA = "0x14F25D8")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x14F2644", Offset = "0x14F2644", VA = "0x14F2644")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x14F2738", Offset = "0x14F2738", VA = "0x14F2738")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x14F2810", Offset = "0x14F2810", VA = "0x14F2810")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x14F2870", Offset = "0x14F2870", VA = "0x14F2870")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000014")]
	public static class QuaTools
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x14F28A0", Offset = "0x14F28A0", VA = "0x14F28A0")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x14F29EC", Offset = "0x14F29EC", VA = "0x14F29EC")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x14F2B38", Offset = "0x14F2B38", VA = "0x14F2B38")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x14F2C4C", Offset = "0x14F2C4C", VA = "0x14F2C4C")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x14E3078", Offset = "0x14E3078", VA = "0x14E3078")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x14F2D60", Offset = "0x14F2D60", VA = "0x14F2D60")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x14E7480", Offset = "0x14E7480", VA = "0x14E7480")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x14F2E30", Offset = "0x14F2E30", VA = "0x14F2E30")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x14F30B4", Offset = "0x14F30B4", VA = "0x14F30B4")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x14F32C8", Offset = "0x14F32C8", VA = "0x14F32C8")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x14EF890", Offset = "0x14EF890", VA = "0x14EF890")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000015")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700000B")]
		public static T instance
		{
			[Token(Token = "0x60000AB")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000AC")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000AD")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB26C94", Offset = "0xB26C94")]
		public bool fixTransforms;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000C")]
		private bool animatePhysics
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x1CF7F94", Offset = "0x1CF7F94", VA = "0x1CF7F94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000D")]
		private bool isAnimated
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x1CF8290", Offset = "0x1CF8290", VA = "0x1CF8290")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1CF7E5C", Offset = "0x1CF7E5C", VA = "0x1CF7E5C")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1CF7EF4", Offset = "0x1CF7EF4", VA = "0x1CF7EF4", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1CF7EF8", Offset = "0x1CF7EF8", VA = "0x1CF7EF8", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1CF7EFC", Offset = "0x1CF7EFC", VA = "0x1CF7EFC", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1CF7F00", Offset = "0x1CF7F00", VA = "0x1CF7F00")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1CF7F90", Offset = "0x1CF7F90", VA = "0x1CF7F90")]
		private void Start()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1CF7F38", Offset = "0x1CF7F38", VA = "0x1CF7F38")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1CF8244", Offset = "0x1CF8244", VA = "0x1CF8244")]
		private void Update()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1CF8084", Offset = "0x1CF8084", VA = "0x1CF8084")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1CF834C", Offset = "0x1CF834C", VA = "0x1CF834C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1CF83A8", Offset = "0x1CF83A8", VA = "0x1CF83A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1CF8404", Offset = "0x1CF8404", VA = "0x1CF8404")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1CF844C", Offset = "0x1CF844C", VA = "0x1CF844C")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1CF845C", Offset = "0x1CF845C", VA = "0x1CF845C")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1CF8514", Offset = "0x1CF8514", VA = "0x1CF8514")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1CF85CC", Offset = "0x1CF85CC", VA = "0x1CF85CC")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1CF8684", Offset = "0x1CF8684", VA = "0x1CF8684")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public static class V3Tools
	{
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1CF868C", Offset = "0x1CF868C", VA = "0x1CF868C")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1CF8784", Offset = "0x1CF8784", VA = "0x1CF8784")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1CF887C", Offset = "0x1CF887C", VA = "0x1CF887C")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1CF8974", Offset = "0x1CF8974", VA = "0x1CF8974")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1CF8A74", Offset = "0x1CF8A74", VA = "0x1CF8A74")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1CF8CB0", Offset = "0x1CF8CB0", VA = "0x1CF8CB0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1CF8F00", Offset = "0x1CF8F00", VA = "0x1CF8F00")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1CF9100", Offset = "0x1CF9100", VA = "0x1CF9100")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000019")]
	public static class Warning
	{
		[Token(Token = "0x20000C5")]
		public delegate void Logger(string message);

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1CF92DC", Offset = "0x1CF92DC", VA = "0x1CF92DC")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1CF9708", Offset = "0x1CF9708", VA = "0x1CF9708")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x200001A")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x12E00EC", Offset = "0x12E00EC", VA = "0x12E00EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x12E0170", Offset = "0x12E0170", VA = "0x12E0170")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB26CCC", Offset = "0xB26CCC")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x12E0178", Offset = "0x12E0178", VA = "0x12E0178")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x12E0280", Offset = "0x12E0280", VA = "0x12E0280")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB26D04", Offset = "0xB26D04")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB26D3C", Offset = "0xB26D3C")]
		public AimIK aim;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB26D74", Offset = "0xB26D74")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB26DAC", Offset = "0xB26DAC")]
		public Animator animator;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB26DE4", Offset = "0xB26DE4")]
		public float crossfadeTime;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB26E1C", Offset = "0xB26E1C")]
		public float minAimDistance;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x12F1650", Offset = "0x12F1650", VA = "0x12F1650")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x12F1694", Offset = "0x12F1694", VA = "0x12F1694")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x12F17E8", Offset = "0x12F17E8", VA = "0x12F17E8")]
		private void Pose()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x12F19E4", Offset = "0x12F19E4", VA = "0x12F19E4")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x12F1D24", Offset = "0x12F1D24", VA = "0x12F1D24")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x12F1DFC", Offset = "0x12F1DFC", VA = "0x12F1DFC")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x12F2B88", Offset = "0x12F2B88", VA = "0x12F2B88")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x12F2DEC", Offset = "0x12F2DEC", VA = "0x12F2DEC")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x12F303C", Offset = "0x12F303C", VA = "0x12F303C")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB26E54", Offset = "0xB26E54")]
		public Animator animator;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB26E8C", Offset = "0xB26E8C")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB26EC4", Offset = "0xB26EC4")]
		public float lookAtWeight;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB26EDC", Offset = "0xB26EDC")]
		public float lookAtBodyWeight;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB26EF4", Offset = "0xB26EF4")]
		public float lookAtHeadWeight;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB26F0C", Offset = "0xB26F0C")]
		public float lookAtEyesWeight;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB26F24", Offset = "0xB26F24")]
		public float lookAtClampWeight;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB26F3C", Offset = "0xB26F3C")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB26F54", Offset = "0xB26F54")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB26F6C", Offset = "0xB26F6C")]
		public Transform footTargetBiped;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB26FA4", Offset = "0xB26FA4")]
		public float footPositionWeight;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB26FBC", Offset = "0xB26FBC")]
		public float footRotationWeight;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB26FD4", Offset = "0xB26FD4")]
		public Transform handTargetBiped;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2700C", Offset = "0xB2700C")]
		public float handPositionWeight;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB27024", Offset = "0xB27024")]
		public float handRotationWeight;

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x12E1E08", Offset = "0x12E1E08", VA = "0x12E1E08")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x12E22B4", Offset = "0x12E22B4", VA = "0x12E22B4")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x12EBF84", Offset = "0x12EBF84", VA = "0x12EBF84")]
		private void Update()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x12EC9B8", Offset = "0x12EC9B8", VA = "0x12EC9B8")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x12EC6A0", Offset = "0x12EC6A0", VA = "0x12EC6A0")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x12ECB60", Offset = "0x12ECB60", VA = "0x12ECB60")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x1700000E")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x12ECB8C", Offset = "0x12ECB8C", VA = "0x12ECB8C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x12ECC2C", Offset = "0x12ECC2C", VA = "0x12ECC2C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x12ECEC4", Offset = "0x12ECEC4", VA = "0x12ECEC4")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB26ABC", Offset = "0xB26ABC")]
		private sealed class <Step>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000B5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000685")]
				[Address(RVA = "0x12EDB00", Offset = "0x12EDB00", VA = "0x12EDB00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000687")]
				[Address(RVA = "0x12EDB68", Offset = "0x12EDB68", VA = "0x12EDB68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x12ED790", Offset = "0x12ED790", VA = "0x12ED790")]
			[DebuggerHidden]
			public <Step>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x12ED7EC", Offset = "0x12ED7EC", VA = "0x12ED7EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000684")]
			[Address(RVA = "0x12ED7F0", Offset = "0x12ED7F0", VA = "0x12ED7F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000686")]
			[Address(RVA = "0x12EDB08", Offset = "0x12EDB08", VA = "0x12EDB08", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ParticleSystem sand;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IK ik;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float stepProgress;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lastStepTime;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit hit;

		[Token(Token = "0x1700000F")]
		public bool isStepping
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x12ECED8", Offset = "0x12ECED8", VA = "0x12ECED8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		public Vector3 position
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x12ECB2C", Offset = "0x12ECB2C", VA = "0x12ECB2C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x12ECEEC", Offset = "0x12ECEEC", VA = "0x12ECEEC")]
			set
			{
			}
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x12ECF3C", Offset = "0x12ECF3C", VA = "0x12ECF3C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x12ED0F8", Offset = "0x12ED0F8", VA = "0x12ED0F8")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x12ED4C8", Offset = "0x12ED4C8", VA = "0x12ED4C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x12ED6E4", Offset = "0x12ED6E4", VA = "0x12ED6E4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB2F228", Offset = "0xB2F228")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x12ED7BC", Offset = "0x12ED7BC", VA = "0x12ED7BC")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x12EDB70", Offset = "0x12EDB70", VA = "0x12EDB70")]
		private void Start()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x12EDC1C", Offset = "0x12EDC1C", VA = "0x12EDC1C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x12EDEB0", Offset = "0x12EDEB0", VA = "0x12EDEB0")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C7")]
		public struct Warp
		{
			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C228", Offset = "0xB2C228")]
			public int animationLayer;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C260", Offset = "0xB2C260")]
			public string animationState;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C298", Offset = "0xB2C298")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C2D0", Offset = "0xB2C2D0")]
			public Transform warpFrom;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C308", Offset = "0xB2C308")]
			public Transform warpTo;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C340", Offset = "0xB2C340")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000C8")]
		public enum EffectorMode
		{
			[Token(Token = "0x40005C5")]
			PositionOffset,
			[Token(Token = "0x40005C6")]
			Position
		}

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2703C", Offset = "0xB2703C")]
		public Animator animator;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27074", Offset = "0xB27074")]
		public EffectorMode effectorMode;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xB270AC", Offset = "0xB270AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB270AC", Offset = "0xB270AC")]
		public Warp[] warps;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x12E02F8", Offset = "0x12E02F8", VA = "0x12E02F8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x12E0324", Offset = "0x12E0324", VA = "0x12E0324")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x12E0544", Offset = "0x12E0544", VA = "0x12E0544", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x12E08F8", Offset = "0x12E08F8", VA = "0x12E08F8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x12E0998", Offset = "0x12E0998", VA = "0x12E0998")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB25AE8", Offset = "0xB25AE8")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x12E09A0", Offset = "0x12E09A0", VA = "0x12E09A0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x12E09F8", Offset = "0x12E09F8", VA = "0x12E09F8")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x12E0C30", Offset = "0x12E0C30", VA = "0x12E0C30", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x12E0E94", Offset = "0x12E0E94", VA = "0x12E0E94")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB25B4C", Offset = "0xB25B4C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB25B4C", Offset = "0xB25B4C")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB270FC", Offset = "0xB270FC")]
		public float headLookWeight;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x12E0EA8", Offset = "0x12E0EA8", VA = "0x12E0EA8", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x12E1014", Offset = "0x12E1014", VA = "0x12E1014", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x12E1088", Offset = "0x12E1088", VA = "0x12E1088")]
		private void Read()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x12E11E0", Offset = "0x12E11E0", VA = "0x12E11E0")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x12E1228", Offset = "0x12E1228", VA = "0x12E1228")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x12E1820", Offset = "0x12E1820", VA = "0x12E1820")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x12E15E4", Offset = "0x12E15E4", VA = "0x12E15E4")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x12E1B78", Offset = "0x12E1B78", VA = "0x12E1B78")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x12E1C70", Offset = "0x12E1C70", VA = "0x12E1C70")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB25BD8", Offset = "0xB25BD8")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x12E32B4", Offset = "0x12E32B4", VA = "0x12E32B4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x12E3314", Offset = "0x12E3314", VA = "0x12E3314", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x12E35D8", Offset = "0x12E35D8", VA = "0x12E35D8")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x12E3790", Offset = "0x12E3790", VA = "0x12E3790")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB25C3C", Offset = "0xB25C3C")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CameraController cam;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x17000011")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x12E45C4", Offset = "0x12E45C4", VA = "0x12E45C4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000012")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x12E4664", Offset = "0x12E4664", VA = "0x12E4664")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x12E4310", Offset = "0x12E4310", VA = "0x12E4310")]
		private void Start()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x12E4380", Offset = "0x12E4380", VA = "0x12E4380")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x12E4704", Offset = "0x12E4704", VA = "0x12E4704")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB27124", Offset = "0xB27124")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x12E6D34", Offset = "0x12E6D34", VA = "0x12E6D34", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x12E7318", Offset = "0x12E7318", VA = "0x12E7318")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x12E7320", Offset = "0x12E7320", VA = "0x12E7320")]
		private void Start()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x12E73C0", Offset = "0x12E73C0", VA = "0x12E73C0")]
		private void Update()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x12E783C", Offset = "0x12E783C", VA = "0x12E783C")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x12E78E8", Offset = "0x12E78E8", VA = "0x12E78E8")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C9")]
		public class Limb
		{
			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x6000688")]
			[Address(RVA = "0x12E7ABC", Offset = "0x12E7ABC", VA = "0x12E7ABC")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x12E7BF0", Offset = "0x12E7BF0", VA = "0x12E7BF0")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x12E7970", Offset = "0x12E7970", VA = "0x12E7970")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x12E7B40", Offset = "0x12E7B40", VA = "0x12E7B40")]
		private void Start()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x12E7BDC", Offset = "0x12E7BDC", VA = "0x12E7BDC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x12E7BE0", Offset = "0x12E7BE0", VA = "0x12E7BE0")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x12E7C00", Offset = "0x12E7C00", VA = "0x12E7C00")]
		private void Start()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x12E7C6C", Offset = "0x12E7C6C", VA = "0x12E7C6C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x12E7D44", Offset = "0x12E7D44", VA = "0x12E7D44")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2713C", Offset = "0xB2713C")]
		public Transform target;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27174", Offset = "0xB27174")]
		public Transform pin;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB271AC", Offset = "0xB271AC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB271E4", Offset = "0xB271E4")]
		public AimIK aim;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2721C", Offset = "0xB2721C")]
		public float weight;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27254", Offset = "0xB27254")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2728C", Offset = "0xB2728C")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x12E7D4C", Offset = "0x12E7D4C", VA = "0x12E7D4C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x12E7DA4", Offset = "0x12E7DA4", VA = "0x12E7DA4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x12E7F40", Offset = "0x12E7F40", VA = "0x12E7F40")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x12E7F48", Offset = "0x12E7F48", VA = "0x12E7F48")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x12E8008", Offset = "0x12E8008", VA = "0x12E8008")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x12E8094", Offset = "0x12E8094", VA = "0x12E8094")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x12E8528", Offset = "0x12E8528", VA = "0x12E8528")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x12E8620", Offset = "0x12E8620", VA = "0x12E8620")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB272C4", Offset = "0xB272C4")]
		public float aimWeight;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB272DC", Offset = "0xB272DC")]
		public float sightWeight;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB272F4", Offset = "0xB272F4")]
		public float maxAngle;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform gunTarget;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AimIK gunAim;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Recoil recoil;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB27380", Offset = "0xB27380")]
		private float cameraRecoilWeight;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool updateFrame;

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x12E8628", Offset = "0x12E8628", VA = "0x12E8628")]
		private void Start()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x12E8788", Offset = "0x12E8788", VA = "0x12E8788")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x12E8794", Offset = "0x12E8794", VA = "0x12E8794")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x12E8AD4", Offset = "0x12E8AD4", VA = "0x12E8AD4")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x12E8CA8", Offset = "0x12E8CA8", VA = "0x12E8CA8")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x12E8858", Offset = "0x12E8858", VA = "0x12E8858")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x12E96B4", Offset = "0x12E96B4", VA = "0x12E96B4")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB25CA0", Offset = "0xB25CA0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB25CA0", Offset = "0xB25CA0")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB273C0", Offset = "0xB273C0")]
		public float walkSpeed;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x12E96D4", Offset = "0x12E96D4", VA = "0x12E96D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x12E9744", Offset = "0x12E9744", VA = "0x12E9744")]
		private void Update()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x12E9868", Offset = "0x12E9868", VA = "0x12E9868")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x12E9918", Offset = "0x12E9918", VA = "0x12E9918")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReaction hitReaction;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x12E9CAC", Offset = "0x12E9CAC", VA = "0x12E9CAC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x12E9E6C", Offset = "0x12E9E6C", VA = "0x12E9E6C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x12EA030", Offset = "0x12EA030", VA = "0x12EA030")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x12EA3D4", Offset = "0x12EA3D4", VA = "0x12EA3D4")]
		private void Start()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x12EA580", Offset = "0x12EA580", VA = "0x12EA580")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x12EA93C", Offset = "0x12EA93C", VA = "0x12EA93C")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x12EA94C", Offset = "0x12EA94C", VA = "0x12EA94C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x12EAA80", Offset = "0x12EAA80", VA = "0x12EAA80")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x12EABD0", Offset = "0x12EABD0", VA = "0x12EABD0")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x12EABD8", Offset = "0x12EABD8", VA = "0x12EABD8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x12EB2A8", Offset = "0x12EB2A8", VA = "0x12EB2A8")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB25D2C", Offset = "0xB25D2C")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB273F8", Offset = "0xB273F8")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27444", Offset = "0xB27444")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x12EB2B0", Offset = "0x12EB2B0", VA = "0x12EB2B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x12EB308", Offset = "0x12EB308", VA = "0x12EB308")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x12EB614", Offset = "0x12EB614", VA = "0x12EB614")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000CA")]
		public class Partner
		{
			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000B7")]
			private Transform neck
			{
				[Token(Token = "0x600068C")]
				[Address(RVA = "0x12EBF18", Offset = "0x12EBF18", VA = "0x12EBF18")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x12EB650", Offset = "0x12EB650", VA = "0x12EB650")]
			public void Initiate()
			{
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x12EB6D0", Offset = "0x12EB6D0", VA = "0x12EB6D0")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x12EBD3C", Offset = "0x12EBD3C", VA = "0x12EBD3C")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0x12EBF70", Offset = "0x12EBF70", VA = "0x12EBF70")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x12EB61C", Offset = "0x12EB61C", VA = "0x12EB61C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x12EB670", Offset = "0x12EB670", VA = "0x12EB670")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x12EBD2C", Offset = "0x12EBD2C", VA = "0x12EBD2C")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000CB")]
		public enum Mode
		{
			[Token(Token = "0x40005D6")]
			Position,
			[Token(Token = "0x40005D7")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x20000CC")]
		public class Absorber
		{
			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C378", Offset = "0xB2C378")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C3B0", Offset = "0xB2C3B0")]
			public float weight;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x600068F")]
			[Address(RVA = "0x12EE018", Offset = "0x12EE018", VA = "0x12EE018")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0x12EE1F8", Offset = "0x12EE1F8", VA = "0x12EE1F8")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x12EE234", Offset = "0x12EE234", VA = "0x12EE234")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0x12EE3E4", Offset = "0x12EE3E4", VA = "0x12EE3E4")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x12EE608", Offset = "0x12EE608", VA = "0x12EE608")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27490", Offset = "0xB27490")]
		public Mode mode;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB274C8", Offset = "0xB274C8")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27500", Offset = "0xB27500")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27538", Offset = "0xB27538")]
		public float falloffSpeed;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x12EDEB8", Offset = "0x12EDEB8", VA = "0x12EDEB8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x12EDF8C", Offset = "0x12EDF8C", VA = "0x12EDF8C")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x12EE0EC", Offset = "0x12EE0EC", VA = "0x12EE0EC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x12EE35C", Offset = "0x12EE35C", VA = "0x12EE35C")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x12EE4F4", Offset = "0x12EE4F4", VA = "0x12EE4F4", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x12EE5F8", Offset = "0x12EE5F8", VA = "0x12EE5F8")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x12EE688", Offset = "0x12EE688", VA = "0x12EE688")]
		private void Start()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x12EE700", Offset = "0x12EE700", VA = "0x12EE700")]
		private void Update()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x12EE7CC", Offset = "0x12EE7CC", VA = "0x12EE7CC")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x12EE92C", Offset = "0x12EE92C", VA = "0x12EE92C")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000CD")]
		public class EffectorLink
		{
			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x12EEC74", Offset = "0x12EEC74", VA = "0x12EEC74")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x12EE940", Offset = "0x12EE940", VA = "0x12EE940", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x12EEA40", Offset = "0x12EEA40", VA = "0x12EEA40", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x12EEC6C", Offset = "0x12EEC6C", VA = "0x12EEC6C")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB25D90", Offset = "0xB25D90")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27570", Offset = "0xB27570")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB27570", Offset = "0xB27570")]
		public float weight;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB275C4", Offset = "0xB275C4")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB275FC", Offset = "0xB275FC")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27648", Offset = "0xB27648")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform leftHandTarget;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform rightHandTarget;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform leftFootTarget;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform headTarget;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x12EEC84", Offset = "0x12EEC84", VA = "0x12EEC84")]
		private void Start()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x12EEFC0", Offset = "0x12EEFC0", VA = "0x12EEFC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x12EF710", Offset = "0x12EF710", VA = "0x12EF710")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x17000013")]
		private bool holding
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x12EFA54", Offset = "0x12EFA54", VA = "0x12EFA54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x12EF794", Offset = "0x12EF794", VA = "0x12EF794")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600014A")]
		protected abstract void RotatePivot();

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x12EFA74", Offset = "0x12EFA74", VA = "0x12EFA74")]
		private void Start()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x12EFBDC", Offset = "0x12EFBDC", VA = "0x12EFBDC")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x12EFD58", Offset = "0x12EFD58", VA = "0x12EFD58")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x12EFE38", Offset = "0x12EFE38", VA = "0x12EFE38")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x12EFF64", Offset = "0x12EFF64", VA = "0x12EFF64")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x12F0174", Offset = "0x12F0174", VA = "0x12F0174")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x12F0314", Offset = "0x12F0314", VA = "0x12F0314")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x12F0328", Offset = "0x12F0328", VA = "0x12F0328", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x12F051C", Offset = "0x12F051C", VA = "0x12F051C")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x12F0530", Offset = "0x12F0530", VA = "0x12F0530", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x12F06DC", Offset = "0x12F06DC", VA = "0x12F06DC")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x12F0E58", Offset = "0x12F0E58", VA = "0x12F0E58")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x12F0F30", Offset = "0x12F0F30", VA = "0x12F0F30")]
		private void Update()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x12F10D8", Offset = "0x12F10D8", VA = "0x12F10D8")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB25DF4", Offset = "0xB25DF4")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x12F10E0", Offset = "0x12F10E0", VA = "0x12F10E0")]
		private void Start()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x12F1138", Offset = "0x12F1138", VA = "0x12F1138")]
		private void Update()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x12F1194", Offset = "0x12F1194", VA = "0x12F1194")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x12F126C", Offset = "0x12F126C", VA = "0x12F126C")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB26ACC", Offset = "0xB26ACC")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000B8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000698")]
				[Address(RVA = "0x12F15E0", Offset = "0x12F15E0", VA = "0x12F15E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600069A")]
				[Address(RVA = "0x12F1648", Offset = "0x12F1648", VA = "0x12F1648", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x12F13FC", Offset = "0x12F13FC", VA = "0x12F13FC")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x12F1438", Offset = "0x12F1438", VA = "0x12F1438", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x12F143C", Offset = "0x12F143C", VA = "0x12F143C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x12F15E8", Offset = "0x12F15E8", VA = "0x12F15E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x12F127C", Offset = "0x12F127C", VA = "0x12F127C")]
		private void Start()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x12F1334", Offset = "0x12F1334", VA = "0x12F1334")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x12F137C", Offset = "0x12F137C", VA = "0x12F137C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB2F28C", Offset = "0xB2F28C")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x12F1428", Offset = "0x12F1428", VA = "0x12F1428")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB25E58", Offset = "0xB25E58")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x20000CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB26ADC", Offset = "0xB26ADC")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000BA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600069E")]
				[Address(RVA = "0x12F2B18", Offset = "0x12F2B18", VA = "0x12F2B18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006A0")]
				[Address(RVA = "0x12F2B80", Offset = "0x12F2B80", VA = "0x12F2B80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x12F29C0", Offset = "0x12F29C0", VA = "0x12F29C0")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x12F29F4", Offset = "0x12F29F4", VA = "0x12F29F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x12F29F8", Offset = "0x12F29F8", VA = "0x12F29F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x12F2B20", Offset = "0x12F2B20", VA = "0x12F2B20", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x12F28A0", Offset = "0x12F28A0", VA = "0x12F28A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x12F2950", Offset = "0x12F2950", VA = "0x12F2950")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB2F2F0", Offset = "0xB2F2F0")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x12F29EC", Offset = "0x12F29EC", VA = "0x12F29EC")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D0")]
		public class EffectorLink
		{
			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x12F3128", Offset = "0x12F3128", VA = "0x12F3128")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x12F3DB0", Offset = "0x12F3DB0", VA = "0x12F3DB0")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x12F3468", Offset = "0x12F3468", VA = "0x12F3468")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x12F3E98", Offset = "0x12F3E98", VA = "0x12F3E98")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x12F4034", Offset = "0x12F4034", VA = "0x12F4034")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x12F40D0", Offset = "0x12F40D0", VA = "0x12F40D0")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x12F4168", Offset = "0x12F4168", VA = "0x12F4168")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x12F3C48", Offset = "0x12F3C48", VA = "0x12F3C48")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x12F4200", Offset = "0x12F4200", VA = "0x12F4200")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x12F30B0", Offset = "0x12F30B0", VA = "0x12F30B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x12F33FC", Offset = "0x12F33FC", VA = "0x12F33FC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x12F3B80", Offset = "0x12F3B80", VA = "0x12F3B80")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x12F3DA8", Offset = "0x12F3DA8", VA = "0x12F3DA8")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27734", Offset = "0xB27734")]
		public Transform to;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2776C", Offset = "0xB2776C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2776C", Offset = "0xB2776C")]
		public float transferMotion;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x12F4234", Offset = "0x12F4234", VA = "0x12F4234")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x12F4270", Offset = "0x12F4270", VA = "0x12F4270")]
		private void Update()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x12F43C8", Offset = "0x12F43C8", VA = "0x12F43C8")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB277C0", Offset = "0xB277C0")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x12F4588", Offset = "0x12F4588", VA = "0x12F4588")]
		private void Start()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x12F4740", Offset = "0x12F4740", VA = "0x12F4740")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x12F49DC", Offset = "0x12F49DC", VA = "0x12F49DC")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x12F4AA8", Offset = "0x12F4AA8", VA = "0x12F4AA8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x12F4BA0", Offset = "0x12F4BA0", VA = "0x12F4BA0")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x12F4DD8", Offset = "0x12F4DD8", VA = "0x12F4DD8", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x12F5250", Offset = "0x12F5250", VA = "0x12F5250")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x12F54A8", Offset = "0x12F54A8", VA = "0x12F54A8")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x12E9928", Offset = "0x12E9928", VA = "0x12E9928")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x12E9C24", Offset = "0x12E9C24", VA = "0x12E9C24")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x12E9CA4", Offset = "0x12E9CA4", VA = "0x12E9CA4")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB26AEC", Offset = "0xB26AEC")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000BC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006AD")]
				[Address(RVA = "0x12F0DE8", Offset = "0x12F0DE8", VA = "0x12F0DE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006AF")]
				[Address(RVA = "0x12F0E50", Offset = "0x12F0E50", VA = "0x12F0E50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x12F0AA4", Offset = "0x12F0AA4", VA = "0x12F0AA4")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x12F0CB0", Offset = "0x12F0CB0", VA = "0x12F0CB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x12F0CB4", Offset = "0x12F0CB4", VA = "0x12F0CB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x12F0DF0", Offset = "0x12F0DF0", VA = "0x12F0DF0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x12F06F0", Offset = "0x12F06F0", VA = "0x12F06F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x12F087C", Offset = "0x12F087C", VA = "0x12F087C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x12F080C", Offset = "0x12F080C", VA = "0x12F080C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB2F354", Offset = "0xB2F354")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x12F0AD0", Offset = "0x12F0AD0", VA = "0x12F0AD0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x12F0BB4", Offset = "0x12F0BB4", VA = "0x12F0BB4")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x12F0C94", Offset = "0x12F0C94", VA = "0x12F0C94")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB27828", Offset = "0xB27828")]
		public float weight;

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x12E1CD0", Offset = "0x12E1CD0", VA = "0x12E1CD0")]
		private void Start()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x12E1D3C", Offset = "0x12E1D3C", VA = "0x12E1D3C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x12E1DF8", Offset = "0x12E1DF8", VA = "0x12E1DF8")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D2")]
		public class Part
		{
			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x12F4454", Offset = "0x12F4454", VA = "0x12F4454")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x12F4580", Offset = "0x12F4580", VA = "0x12F4580")]
			public Part()
			{
			}
		}

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x12F43DC", Offset = "0x12F43DC", VA = "0x12F43DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x12F4578", Offset = "0x12F4578", VA = "0x12F4578")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReactionVRIK hitReaction;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x12EA040", Offset = "0x12EA040", VA = "0x12EA040")]
		private void Update()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x12EA200", Offset = "0x12EA200", VA = "0x12EA200")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x12EA3C4", Offset = "0x12EA3C4", VA = "0x12EA3C4")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27860", Offset = "0xB27860")]
		public VRIK ik;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27898", Offset = "0xB27898")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB278D0", Offset = "0xB278D0")]
		public Transform headTracker;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27908", Offset = "0xB27908")]
		public Transform bodyTracker;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27940", Offset = "0xB27940")]
		public Transform leftHandTracker;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27978", Offset = "0xB27978")]
		public Transform rightHandTracker;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB279B0", Offset = "0xB279B0")]
		public Transform leftFootTracker;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB279E8", Offset = "0xB279E8")]
		public Transform rightFootTracker;

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x12F5504", Offset = "0x12F5504", VA = "0x12F5504")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x12F5540", Offset = "0x12F5540", VA = "0x12F5540")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F3B8", Offset = "0xB2F3B8")]
		private void Calibrate()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x12F5574", Offset = "0x12F5574", VA = "0x12F5574")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x12F557C", Offset = "0x12F557C", VA = "0x12F557C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x12F55D8", Offset = "0x12F55D8", VA = "0x12F55D8")]
		private void Update()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x12F57EC", Offset = "0x12F57EC", VA = "0x12F57EC")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x17000014")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x12E22F8", Offset = "0x12E22F8", VA = "0x12E22F8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x12E22D4", Offset = "0x12E22D4", VA = "0x12E22D4", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x12E2300", Offset = "0x12E2300", VA = "0x12E2300")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x12E23C4", Offset = "0x12E23C4", VA = "0x12E23C4", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x12E261C", Offset = "0x12E261C", VA = "0x12E261C", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x12E288C", Offset = "0x12E288C", VA = "0x12E288C", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x12E262C", Offset = "0x12E262C", VA = "0x12E262C")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x12E289C", Offset = "0x12E289C", VA = "0x12E289C")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB25EBC", Offset = "0xB25EBC")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x12E28B4", Offset = "0x12E28B4", VA = "0x12E28B4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x12E2914", Offset = "0x12E2914", VA = "0x12E2914", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x12E2A40", Offset = "0x12E2A40", VA = "0x12E2A40")]
		private void Update()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x12E2BBC", Offset = "0x12E2BBC", VA = "0x12E2BBC")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB25F20", Offset = "0xB25F20")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB27A80", Offset = "0xB27A80")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x40001C8")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40001C9")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x17000015")]
		public override bool animationGrounded
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x12E2C74", Offset = "0x12E2C74", VA = "0x12E2C74", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x12E2BD4", Offset = "0x12E2BD4", VA = "0x12E2BD4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x12E2C58", Offset = "0x12E2C58", VA = "0x12E2C58", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x12E2D64", Offset = "0x12E2D64", VA = "0x12E2D64", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x12E30DC", Offset = "0x12E30DC", VA = "0x12E30DC")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x12E3290", Offset = "0x12E3290", VA = "0x12E3290")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB25F84", Offset = "0xB25F84")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB25F84", Offset = "0xB25F84")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB27AC4", Offset = "0xB27AC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27AC4", Offset = "0xB27AC4")]
		public Transform gravityTarget;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27B24", Offset = "0xB27B24")]
		[SerializeField]
		protected float gravityMultiplier;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40001D5")]
		protected const float half = 0.5f;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x600019D")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x12E37B4", Offset = "0x12E37B4", VA = "0x12E37B4")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x12E3938", Offset = "0x12E3938", VA = "0x12E3938", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x12E3AD0", Offset = "0x12E3AD0", VA = "0x12E3AD0", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x12E3D48", Offset = "0x12E3D48", VA = "0x12E3D48")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x12E3E0C", Offset = "0x12E3E0C", VA = "0x12E3E0C")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x12E3FF4", Offset = "0x12E3FF4", VA = "0x12E3FF4")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x12E41A4", Offset = "0x12E41A4", VA = "0x12E41A4")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x12E41C8", Offset = "0x12E41C8", VA = "0x12E41C8")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x12E41EC", Offset = "0x12E41EC", VA = "0x12E41EC")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x12E42F0", Offset = "0x12E42F0", VA = "0x12E42F0")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x20000D3")]
		public enum MoveMode
		{
			[Token(Token = "0x4000601")]
			Directional,
			[Token(Token = "0x4000602")]
			Strafe
		}

		[Token(Token = "0x20000D4")]
		public struct AnimState
		{
			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;
		}

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB27BC0", Offset = "0xB27BC0")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB27BF8", Offset = "0xB27BF8")]
		public MoveMode moveMode;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB27C30", Offset = "0xB27C30")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB27C68", Offset = "0xB27C68")]
		public float airSpeed;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airControl;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float jumpPower;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB27CA0", Offset = "0xB27CA0")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float wallRunMaxLength;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB27CEC", Offset = "0xB27CEC")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB27D24", Offset = "0xB27D24")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AnimState animState;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Animator animator;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3 normal;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private RaycastHit hit;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private float jumpLeg;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private float jumpEndTime;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private float forwardMlp;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private float groundDistance;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float lastAirTime;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float stickyForce;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private float wallRunWeight;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private bool fixedFrame;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private float wallRunEndTime;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Vector3 gravity;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private float velocityY;

		[Token(Token = "0x17000016")]
		public bool onGround
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x12E470C", Offset = "0x12E470C", VA = "0x12E470C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F3F0", Offset = "0xB2F3F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x12E4714", Offset = "0x12E4714", VA = "0x12E4714")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F400", Offset = "0xB2F400")]
			private set
			{
			}
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x12E4720", Offset = "0x12E4720", VA = "0x12E4720", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x12E48A4", Offset = "0x12E48A4", VA = "0x12E48A4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x12E4934", Offset = "0x12E4934", VA = "0x12E4934", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x12E4A70", Offset = "0x12E4A70", VA = "0x12E4A70")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x12E599C", Offset = "0x12E599C", VA = "0x12E599C", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x12E5D18", Offset = "0x12E5D18", VA = "0x12E5D18", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x12E4F94", Offset = "0x12E4F94", VA = "0x12E4F94")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x12E5DF8", Offset = "0x12E5DF8", VA = "0x12E5DF8")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x12E63E8", Offset = "0x12E63E8", VA = "0x12E63E8")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x12E5A78", Offset = "0x12E5A78", VA = "0x12E5A78")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x12E6488", Offset = "0x12E6488", VA = "0x12E6488", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x12E68F8", Offset = "0x12E68F8", VA = "0x12E68F8")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x12E6A84", Offset = "0x12E6A84", VA = "0x12E6A84", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x12E557C", Offset = "0x12E557C", VA = "0x12E557C")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x12E6C18", Offset = "0x12E6C18", VA = "0x12E6C18")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB26010", Offset = "0xB26010")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D5")]
		public enum RotationMode
		{
			[Token(Token = "0x400060A")]
			Smooth,
			[Token(Token = "0x400060B")]
			Linear
		}

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27D34", Offset = "0xB27D34")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27D80", Offset = "0xB27D80")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27DCC", Offset = "0xB27DCC")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27E18", Offset = "0xB27E18")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27E64", Offset = "0xB27E64")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27EB0", Offset = "0xB27EB0")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB27EFC", Offset = "0xB27EFC")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x17000017")]
		public bool isGrounded
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x12F1E10", Offset = "0x12F1E10", VA = "0x12F1E10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F410", Offset = "0xB2F410")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x12F1E18", Offset = "0x12F1E18", VA = "0x12F1E18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F420", Offset = "0xB2F420")]
			private set
			{
			}
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x12F1E24", Offset = "0x12F1E24", VA = "0x12F1E24")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x12F1EAC", Offset = "0x12F1EAC", VA = "0x12F1EAC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x12F25A8", Offset = "0x12F25A8", VA = "0x12F25A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x12F1F00", Offset = "0x12F1F00", VA = "0x12F1F00")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x12F2300", Offset = "0x12F2300", VA = "0x12F2300")]
		private void Move()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x12F25E8", Offset = "0x12F25E8", VA = "0x12F25E8")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x12F26E0", Offset = "0x12F26E0", VA = "0x12F26E0")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x12F2780", Offset = "0x12F2780", VA = "0x12F2780")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x12F4BA8", Offset = "0x12F4BA8", VA = "0x12F4BA8", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x12F4DAC", Offset = "0x12F4DAC", VA = "0x12F4DAC")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x20000D6")]
		public struct State
		{
			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x12F54CC", Offset = "0x12F54CC", VA = "0x12F54CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x12F4EEC", Offset = "0x12F4EEC", VA = "0x12F4EEC", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x12F4DC8", Offset = "0x12F4DC8", VA = "0x12F4DC8")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x12E1C8C", Offset = "0x12E1C8C", VA = "0x12E1C8C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x12E1CC8", Offset = "0x12E1CC8", VA = "0x12E1CC8")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x12F27A8", Offset = "0x12F27A8", VA = "0x12F27A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x12F27DC", Offset = "0x12F27DC", VA = "0x12F27DC")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x12F288C", Offset = "0x12F288C", VA = "0x12F288C")]
		public SlowMo()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB26074", Offset = "0xB26074")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB26074", Offset = "0xB26074")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x167613C", Offset = "0x167613C", VA = "0x167613C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F430", Offset = "0xB2F430")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1676188", Offset = "0x1676188", VA = "0x1676188")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F468", Offset = "0xB2F468")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x16761D4", Offset = "0x16761D4", VA = "0x16761D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F4A0", Offset = "0xB2F4A0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1676220", Offset = "0x1676220", VA = "0x1676220")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F4D8", Offset = "0xB2F4D8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x167626C", Offset = "0x167626C", VA = "0x167626C")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1676308", Offset = "0x1676308", VA = "0x1676308")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1676328", Offset = "0x1676328", VA = "0x1676328")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1676358", Offset = "0x1676358", VA = "0x1676358")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1676388", Offset = "0x1676388", VA = "0x1676388")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x16763C8", Offset = "0x16763C8", VA = "0x16763C8")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x167640C", Offset = "0x167640C", VA = "0x167640C")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1676430", Offset = "0x1676430", VA = "0x1676430")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1676454", Offset = "0x1676454", VA = "0x1676454")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x167647C", Offset = "0x167647C", VA = "0x167647C")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x16764A8", Offset = "0x16764A8", VA = "0x16764A8")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x16764D4", Offset = "0x16764D4", VA = "0x16764D4")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x167628C", Offset = "0x167628C", VA = "0x167628C")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x16764FC", Offset = "0x16764FC", VA = "0x16764FC")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1676508", Offset = "0x1676508", VA = "0x1676508")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1676514", Offset = "0x1676514", VA = "0x1676514")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x16767FC", Offset = "0x16767FC", VA = "0x16767FC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x16768A4", Offset = "0x16768A4", VA = "0x16768A4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1676BEC", Offset = "0x1676BEC", VA = "0x1676BEC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x16770D4", Offset = "0x16770D4", VA = "0x16770D4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1677108", Offset = "0x1677108", VA = "0x1677108")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000018")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x16766B4", Offset = "0x16766B4", VA = "0x16766B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x16772D4", Offset = "0x16772D4", VA = "0x16772D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1676A74", Offset = "0x1676A74", VA = "0x1676A74")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x167718C", Offset = "0x167718C", VA = "0x167718C")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700001A")]
		public bool isValid
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x16778D4", Offset = "0x16778D4", VA = "0x16778D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001EB")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1677944", Offset = "0x1677944", VA = "0x1677944")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x167794C", Offset = "0x167794C", VA = "0x167794C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1677A58", Offset = "0x1677A58", VA = "0x1677A58")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1677A60", Offset = "0x1677A60", VA = "0x1677A60")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x1700001B")]
		private bool positionChanged
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x1677C28", Offset = "0x1677C28", VA = "0x1677C28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1677A8C", Offset = "0x1677A8C", VA = "0x1677A8C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1677CE4", Offset = "0x1677CE4", VA = "0x1677CE4")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1677CEC", Offset = "0x1677CEC", VA = "0x1677CEC")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1677D18", Offset = "0x1677D18", VA = "0x1677D18", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1677E40", Offset = "0x1677E40", VA = "0x1677E40")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1677E48", Offset = "0x1677E48", VA = "0x1677E48")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x1700001C")]
		private bool rotationChanged
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x1678014", Offset = "0x1678014", VA = "0x1678014")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1677E74", Offset = "0x1677E74", VA = "0x1677E74", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x16780E4", Offset = "0x16780E4", VA = "0x16780E4")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x16780EC", Offset = "0x16780EC", VA = "0x16780EC")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public class Constraints
	{
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB27F4C", Offset = "0xB27F4C")]
		public float positionWeight;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB27F64", Offset = "0xB27F64")]
		public float rotationWeight;

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1678118", Offset = "0x1678118", VA = "0x1678118")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1676B98", Offset = "0x1676B98", VA = "0x1676B98")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1676D74", Offset = "0x1676D74", VA = "0x1676D74")]
		public void Update()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x16774A0", Offset = "0x16774A0", VA = "0x16774A0")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005E")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x20000D7")]
		public enum DOF
		{
			[Token(Token = "0x4000612")]
			One,
			[Token(Token = "0x4000613")]
			Three
		}

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27F7C", Offset = "0xB27F7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB27F7C", Offset = "0xB27F7C")]
		public float weight;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB27FD0", Offset = "0xB27FD0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB27FD0", Offset = "0xB27FD0")]
		public float rotationWeight;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28024", Offset = "0xB28024")]
		public DOF rotationDOF;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2805C", Offset = "0xB2805C")]
		public Transform bone1;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28094", Offset = "0xB28094")]
		public Transform bone2;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB280CC", Offset = "0xB280CC")]
		public Transform bone3;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28104", Offset = "0xB28104")]
		public Transform tip;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2813C", Offset = "0xB2813C")]
		public Transform target;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB28174", Offset = "0xB28174")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x1700001D")]
		public bool initiated
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x167F2E4", Offset = "0x167F2E4", VA = "0x167F2E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F510", Offset = "0xB2F510")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x167F2EC", Offset = "0x167F2EC", VA = "0x167F2EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F520", Offset = "0xB2F520")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x167F2F8", Offset = "0x167F2F8", VA = "0x167F2F8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x167F318", Offset = "0x167F318", VA = "0x167F318")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x167F338", Offset = "0x167F338", VA = "0x167F338")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x167F358", Offset = "0x167F358", VA = "0x167F358")]
			set
			{
			}
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x167F378", Offset = "0x167F378", VA = "0x167F378")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x167F478", Offset = "0x167F478", VA = "0x167F478")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x167F88C", Offset = "0x167F88C", VA = "0x167F88C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x167F95C", Offset = "0x167F95C", VA = "0x167F95C")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x167FD10", Offset = "0x167FD10", VA = "0x167FD10")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28184", Offset = "0xB28184")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB28184", Offset = "0xB28184")]
		public float weight;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB281D8", Offset = "0xB281D8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000020")]
		public bool initiated
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x167FD20", Offset = "0x167FD20", VA = "0x167FD20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F530", Offset = "0xB2F530")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x167FD28", Offset = "0x167FD28", VA = "0x167FD28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F540", Offset = "0xB2F540")]
			private set
			{
			}
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x167FD34", Offset = "0x167FD34", VA = "0x167FD34")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x167FDBC", Offset = "0x167FDBC", VA = "0x167FDBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F550", Offset = "0xB2F550")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x16800E0", Offset = "0x16800E0", VA = "0x16800E0")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1680250", Offset = "0x1680250", VA = "0x1680250")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x167FFD8", Offset = "0x167FFD8", VA = "0x167FFD8")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x16803B8", Offset = "0x16803B8", VA = "0x16803B8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1680478", Offset = "0x1680478", VA = "0x1680478")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x16804FC", Offset = "0x16804FC", VA = "0x16804FC")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1680564", Offset = "0x1680564", VA = "0x1680564", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1680568", Offset = "0x1680568", VA = "0x1680568", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x168056C", Offset = "0x168056C", VA = "0x168056C")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x20000D8")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB281E8", Offset = "0xB281E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB281E8", Offset = "0xB281E8")]
		public float weight;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2823C", Offset = "0xB2823C")]
		public Grounding solver;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected bool initiated;

		[Token(Token = "0x6000217")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x16815A0", Offset = "0x16815A0", VA = "0x16815A0")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1681874", Offset = "0x1681874", VA = "0x1681874")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x16816E4", Offset = "0x16816E4", VA = "0x16816E4")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x16818A8", Offset = "0x16818A8", VA = "0x16818A8")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600021C")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600021D")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1681AB0", Offset = "0x1681AB0", VA = "0x1681AB0")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB260D4", Offset = "0xB260D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB260D4", Offset = "0xB260D4")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28274", Offset = "0xB28274")]
		public BipedIK ik;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB282AC", Offset = "0xB282AC")]
		public float spineBend;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB282E4", Offset = "0xB282E4")]
		public float spineSpeed;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1681E00", Offset = "0x1681E00", VA = "0x1681E00", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F588", Offset = "0xB2F588")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1681E4C", Offset = "0x1681E4C", VA = "0x1681E4C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F5C0", Offset = "0xB2F5C0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1681E98", Offset = "0x1681E98", VA = "0x1681E98", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1681F9C", Offset = "0x1681F9C", VA = "0x1681F9C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x168204C", Offset = "0x168204C", VA = "0x168204C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1682100", Offset = "0x1682100", VA = "0x1682100")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1682614", Offset = "0x1682614", VA = "0x1682614")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1682668", Offset = "0x1682668", VA = "0x1682668")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1682E1C", Offset = "0x1682E1C", VA = "0x1682E1C")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1682F7C", Offset = "0x1682F7C", VA = "0x1682F7C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x168310C", Offset = "0x168310C", VA = "0x168310C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x168327C", Offset = "0x168327C", VA = "0x168327C")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB26134", Offset = "0xB26134")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB26134", Offset = "0xB26134")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000D9")]
		public class SpineEffector
		{
			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C3F8", Offset = "0xB2C3F8")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C430", Offset = "0xB2C430")]
			public float horizontalWeight;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C468", Offset = "0xB2C468")]
			public float verticalWeight;

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x16840E4", Offset = "0x16840E4", VA = "0x16840E4")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x16840F4", Offset = "0x16840F4", VA = "0x16840F4")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2831C", Offset = "0xB2831C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28354", Offset = "0xB28354")]
		public float spineBend;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2838C", Offset = "0xB2838C")]
		public float spineSpeed;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x16832FC", Offset = "0x16832FC", VA = "0x16832FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F5F8", Offset = "0xB2F5F8")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1683348", Offset = "0x1683348", VA = "0x1683348", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F630", Offset = "0xB2F630")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1683394", Offset = "0x1683394", VA = "0x1683394", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F668", Offset = "0xB2F668")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x16833E0", Offset = "0x16833E0", VA = "0x16833E0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1683460", Offset = "0x1683460", VA = "0x1683460")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x16834F8", Offset = "0x16834F8", VA = "0x16834F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x16837B4", Offset = "0x16837B4", VA = "0x16837B4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x16837C0", Offset = "0x16837C0", VA = "0x16837C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x16835B4", Offset = "0x16835B4", VA = "0x16835B4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x16837CC", Offset = "0x16837CC", VA = "0x16837CC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1683C6C", Offset = "0x1683C6C", VA = "0x1683C6C")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1683E2C", Offset = "0x1683E2C", VA = "0x1683E2C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1683F64", Offset = "0x1683F64", VA = "0x1683F64")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1684064", Offset = "0x1684064", VA = "0x1684064")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB26194", Offset = "0xB26194")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB26194", Offset = "0xB26194")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB283C4", Offset = "0xB283C4")]
		public Transform pelvis;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB283FC", Offset = "0xB283FC")]
		public Transform characterRoot;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28434", Offset = "0xB28434")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB28434", Offset = "0xB28434")]
		public float rootRotationWeight;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28488", Offset = "0xB28488")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB284C0", Offset = "0xB284C0")]
		public float maxRootRotationAngle;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x168413C", Offset = "0x168413C", VA = "0x168413C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F6A0", Offset = "0xB2F6A0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1684188", Offset = "0x1684188", VA = "0x1684188", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F6D8", Offset = "0xB2F6D8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x16841D4", Offset = "0x16841D4", VA = "0x16841D4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x16841EC", Offset = "0x16841EC", VA = "0x16841EC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x16843DC", Offset = "0x16843DC", VA = "0x16843DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x16844DC", Offset = "0x16844DC", VA = "0x16844DC")]
		private void Update()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1684B20", Offset = "0x1684B20", VA = "0x1684B20")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1684EE8", Offset = "0x1684EE8", VA = "0x1684EE8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1685158", Offset = "0x1685158", VA = "0x1685158")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1685478", Offset = "0x1685478", VA = "0x1685478")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1685604", Offset = "0x1685604", VA = "0x1685604")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x16857CC", Offset = "0x16857CC", VA = "0x16857CC")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB261F4", Offset = "0xB261F4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB261F4", Offset = "0xB261F4")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x20000DA")]
		public struct Foot
		{
			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x168632C", Offset = "0x168632C", VA = "0x168632C")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB284F8", Offset = "0xB284F8")]
		public Grounding forelegSolver;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28530", Offset = "0xB28530")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB28530", Offset = "0xB28530")]
		public float rootRotationWeight;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28584", Offset = "0xB28584")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB28584", Offset = "0xB28584")]
		public float minRootRotation;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB285DC", Offset = "0xB285DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB285DC", Offset = "0xB285DC")]
		public float maxRootRotation;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28634", Offset = "0xB28634")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2866C", Offset = "0xB2866C")]
		public float maxLegOffset;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB286A4", Offset = "0xB286A4")]
		public float maxForeLegOffset;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB286DC", Offset = "0xB286DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB286DC", Offset = "0xB286DC")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28730", Offset = "0xB28730")]
		public Transform characterRoot;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28768", Offset = "0xB28768")]
		public Transform pelvis;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB287A0", Offset = "0xB287A0")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB287D8", Offset = "0xB287D8")]
		public Transform head;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x168584C", Offset = "0x168584C", VA = "0x168584C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F710", Offset = "0xB2F710")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1685898", Offset = "0x1685898", VA = "0x1685898", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F748", Offset = "0xB2F748")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x16858E4", Offset = "0x16858E4", VA = "0x16858E4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1685918", Offset = "0x1685918", VA = "0x1685918")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1685A48", Offset = "0x1685A48", VA = "0x1685A48")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1685C08", Offset = "0x1685C08", VA = "0x1685C08")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1685C70", Offset = "0x1685C70", VA = "0x1685C70")]
		private void Update()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1685D28", Offset = "0x1685D28", VA = "0x1685D28")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x168600C", Offset = "0x168600C", VA = "0x168600C")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x168636C", Offset = "0x168636C", VA = "0x168636C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x16864B8", Offset = "0x16864B8", VA = "0x16864B8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1686848", Offset = "0x1686848", VA = "0x1686848")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1687038", Offset = "0x1687038", VA = "0x1687038")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x16872F8", Offset = "0x16872F8", VA = "0x16872F8")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1687458", Offset = "0x1687458", VA = "0x1687458")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1687734", Offset = "0x1687734", VA = "0x1687734")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x168776C", Offset = "0x168776C", VA = "0x168776C")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x168792C", Offset = "0x168792C", VA = "0x168792C")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB26254", Offset = "0xB26254")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28820", Offset = "0xB28820")]
		public VRIK ik;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1687A38", Offset = "0x1687A38", VA = "0x1687A38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F780", Offset = "0xB2F780")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1687A3C", Offset = "0x1687A3C", VA = "0x1687A3C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F7B8", Offset = "0xB2F7B8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1687A40", Offset = "0x1687A40", VA = "0x1687A40", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F7F0", Offset = "0xB2F7F0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1687A44", Offset = "0x1687A44", VA = "0x1687A44", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1687A5C", Offset = "0x1687A5C", VA = "0x1687A5C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1687AF4", Offset = "0x1687AF4", VA = "0x1687AF4")]
		private void Update()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1687BA8", Offset = "0x1687BA8", VA = "0x1687BA8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1687DA8", Offset = "0x1687DA8", VA = "0x1687DA8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x168803C", Offset = "0x168803C", VA = "0x168803C")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1688144", Offset = "0x1688144", VA = "0x1688144")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1688344", Offset = "0x1688344", VA = "0x1688344")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x168847C", Offset = "0x168847C", VA = "0x168847C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x16885DC", Offset = "0x16885DC", VA = "0x16885DC")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x20000DB")]
		public enum Quality
		{
			[Token(Token = "0x400061C")]
			Fastest,
			[Token(Token = "0x400061D")]
			Simple,
			[Token(Token = "0x400061E")]
			Best
		}

		[Token(Token = "0x20000DC")]
		public class Leg
		{
			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C4A0", Offset = "0xB2C4A0")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C4B0", Offset = "0xB2C4B0")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C4C0", Offset = "0xB2C4C0")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C4D0", Offset = "0xB2C4D0")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C4E0", Offset = "0xB2C4E0")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C4F0", Offset = "0xB2C4F0")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C500", Offset = "0xB2C500")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x170000BE")]
			public bool isGrounded
			{
				[Token(Token = "0x60006B9")]
				[Address(RVA = "0x1689DEC", Offset = "0x1689DEC", VA = "0x1689DEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31390", Offset = "0xB31390")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006BA")]
				[Address(RVA = "0x1689DF4", Offset = "0x1689DF4", VA = "0x1689DF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB313A0", Offset = "0xB313A0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BF")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60006BB")]
				[Address(RVA = "0x1689E00", Offset = "0x1689E00", VA = "0x1689E00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB313B0", Offset = "0xB313B0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006BC")]
				[Address(RVA = "0x1689E0C", Offset = "0x1689E0C", VA = "0x1689E0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB313C0", Offset = "0xB313C0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C0")]
			public bool initiated
			{
				[Token(Token = "0x60006BD")]
				[Address(RVA = "0x1689E18", Offset = "0x1689E18", VA = "0x1689E18")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB313D0", Offset = "0xB313D0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006BE")]
				[Address(RVA = "0x1689E20", Offset = "0x1689E20", VA = "0x1689E20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB313E0", Offset = "0xB313E0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C1")]
			public float heightFromGround
			{
				[Token(Token = "0x60006BF")]
				[Address(RVA = "0x1689E2C", Offset = "0x1689E2C", VA = "0x1689E2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB313F0", Offset = "0xB313F0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006C0")]
				[Address(RVA = "0x1689E34", Offset = "0x1689E34", VA = "0x1689E34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31400", Offset = "0xB31400")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C2")]
			public Vector3 velocity
			{
				[Token(Token = "0x60006C1")]
				[Address(RVA = "0x1689E3C", Offset = "0x1689E3C", VA = "0x1689E3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31410", Offset = "0xB31410")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006C2")]
				[Address(RVA = "0x1689E48", Offset = "0x1689E48", VA = "0x1689E48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31420", Offset = "0xB31420")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C3")]
			public Transform transform
			{
				[Token(Token = "0x60006C3")]
				[Address(RVA = "0x1689E54", Offset = "0x1689E54", VA = "0x1689E54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31430", Offset = "0xB31430")]
				get
				{
					return null;
				}
				[Token(Token = "0x60006C4")]
				[Address(RVA = "0x1689E5C", Offset = "0x1689E5C", VA = "0x1689E5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31440", Offset = "0xB31440")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C4")]
			public float IKOffset
			{
				[Token(Token = "0x60006C5")]
				[Address(RVA = "0x1689E64", Offset = "0x1689E64", VA = "0x1689E64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31450", Offset = "0xB31450")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006C6")]
				[Address(RVA = "0x1689E6C", Offset = "0x1689E6C", VA = "0x1689E6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31460", Offset = "0xB31460")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C5")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60006CB")]
				[Address(RVA = "0x168A7EC", Offset = "0x168A7EC", VA = "0x168A7EC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000C6")]
			private float rootYOffset
			{
				[Token(Token = "0x60006D4")]
				[Address(RVA = "0x168AAE0", Offset = "0x168AAE0", VA = "0x168AAE0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x1688C74", Offset = "0x1688C74", VA = "0x1688C74")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x1689E74", Offset = "0x1689E74", VA = "0x1689E74")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x168990C", Offset = "0x168990C", VA = "0x168990C")]
			public void Reset()
			{
			}

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x1688D80", Offset = "0x1688D80", VA = "0x1688D80")]
			public void Process()
			{
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x168A484", Offset = "0x168A484", VA = "0x168A484")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x1689EC0", Offset = "0x1689EC0", VA = "0x1689EC0")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x168A96C", Offset = "0x168A96C", VA = "0x168A96C")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x168A114", Offset = "0x168A114", VA = "0x168A114")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x168A21C", Offset = "0x168A21C", VA = "0x168A21C")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x168AA68", Offset = "0x168AA68", VA = "0x168AA68")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x168A878", Offset = "0x168A878", VA = "0x168A878")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x168AC14", Offset = "0x168AC14", VA = "0x168AC14")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x1688BC4", Offset = "0x1688BC4", VA = "0x1688BC4")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x20000DD")]
		public class Pelvis
		{
			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C510", Offset = "0xB2C510")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C520", Offset = "0xB2C520")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000C7")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60006D6")]
				[Address(RVA = "0x168AD04", Offset = "0x168AD04", VA = "0x168AD04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31470", Offset = "0xB31470")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006D7")]
				[Address(RVA = "0x168AD10", Offset = "0x168AD10", VA = "0x168AD10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31480", Offset = "0xB31480")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C8")]
			public float heightOffset
			{
				[Token(Token = "0x60006D8")]
				[Address(RVA = "0x168AD1C", Offset = "0x168AD1C", VA = "0x168AD1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31490", Offset = "0xB31490")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006D9")]
				[Address(RVA = "0x168AD24", Offset = "0x168AD24", VA = "0x168AD24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB314A0", Offset = "0xB314A0")]
				private set
				{
				}
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x1688D58", Offset = "0x1688D58", VA = "0x1688D58")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x168985C", Offset = "0x168985C", VA = "0x168985C")]
			public void Reset()
			{
			}

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x168AD2C", Offset = "0x168AD2C", VA = "0x168AD2C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x16895F0", Offset = "0x16895F0", VA = "0x16895F0")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x1688C6C", Offset = "0x1688C6C", VA = "0x1688C6C")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28858", Offset = "0xB28858")]
		public LayerMask layers;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28890", Offset = "0xB28890")]
		public float maxStep;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB288C8", Offset = "0xB288C8")]
		public float heightOffset;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28900", Offset = "0xB28900")]
		public float footSpeed;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28938", Offset = "0xB28938")]
		public float footRadius;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28970", Offset = "0xB28970")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB289BC", Offset = "0xB289BC")]
		public float prediction;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB289F4", Offset = "0xB289F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB289F4", Offset = "0xB289F4")]
		public float footRotationWeight;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28A48", Offset = "0xB28A48")]
		public float footRotationSpeed;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28A80", Offset = "0xB28A80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB28A80", Offset = "0xB28A80")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28AD8", Offset = "0xB28AD8")]
		public bool rotateSolver;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28B10", Offset = "0xB28B10")]
		public float pelvisSpeed;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28B48", Offset = "0xB28B48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB28B48", Offset = "0xB28B48")]
		public float pelvisDamper;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28B9C", Offset = "0xB28B9C")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28BD4", Offset = "0xB28BD4")]
		public float liftPelvisWeight;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28C0C", Offset = "0xB28C0C")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28C44", Offset = "0xB28C44")]
		public Quality quality;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB28C7C", Offset = "0xB28C7C")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB28C8C", Offset = "0xB28C8C")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB28C9C", Offset = "0xB28C9C")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB28CAC", Offset = "0xB28CAC")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB28CBC", Offset = "0xB28CBC")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000021")]
		public Leg[] legs
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x1688638", Offset = "0x1688638", VA = "0x1688638")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F828", Offset = "0xB2F828")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x1688640", Offset = "0x1688640", VA = "0x1688640")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F838", Offset = "0xB2F838")]
			private set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x1688648", Offset = "0x1688648", VA = "0x1688648")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F848", Offset = "0xB2F848")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x1688650", Offset = "0x1688650", VA = "0x1688650")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F858", Offset = "0xB2F858")]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public bool isGrounded
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x1688658", Offset = "0x1688658", VA = "0x1688658")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F868", Offset = "0xB2F868")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x1688660", Offset = "0x1688660", VA = "0x1688660")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F878", Offset = "0xB2F878")]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public Transform root
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x168866C", Offset = "0x168866C", VA = "0x168866C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F888", Offset = "0xB2F888")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x1688674", Offset = "0x1688674", VA = "0x1688674")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F898", Offset = "0xB2F898")]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x168867C", Offset = "0x168867C", VA = "0x168867C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F8A8", Offset = "0xB2F8A8")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x1688694", Offset = "0x1688694", VA = "0x1688694")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2F8B8", Offset = "0xB2F8B8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public bool rootGrounded
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x16886B4", Offset = "0x16886B4", VA = "0x16886B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000027")]
		public Vector3 up
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x1682EF0", Offset = "0x1682EF0", VA = "0x1682EF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000028")]
		private bool useRootRotation
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x16899C0", Offset = "0x16899C0", VA = "0x16899C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1688708", Offset = "0x1688708", VA = "0x1688708")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1688AE8", Offset = "0x1688AE8", VA = "0x1688AE8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x16823B4", Offset = "0x16823B4", VA = "0x16823B4")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1682BB4", Offset = "0x1682BB4", VA = "0x1682BB4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1684908", Offset = "0x1684908", VA = "0x1684908")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1681F18", Offset = "0x1681F18", VA = "0x1681F18")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1688D68", Offset = "0x1688D68", VA = "0x1688D68")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1689A90", Offset = "0x1689A90", VA = "0x1689A90")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1689BF8", Offset = "0x1689BF8", VA = "0x1689BF8")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1689CFC", Offset = "0x1689CFC", VA = "0x1689CFC")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1681B64", Offset = "0x1681B64", VA = "0x1681B64")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB2628C", Offset = "0xB2628C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB2628C", Offset = "0xB2628C")]
	public class AimIK : IK
	{
		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x12F6744", Offset = "0x12F6744", VA = "0x12F6744", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F8C8", Offset = "0xB2F8C8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x12F6790", Offset = "0x12F6790", VA = "0x12F6790", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F900", Offset = "0xB2F900")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x12F67DC", Offset = "0x12F67DC", VA = "0x12F67DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F938", Offset = "0xB2F938")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x12F6828", Offset = "0x12F6828", VA = "0x12F6828")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F970", Offset = "0xB2F970")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x12F6874", Offset = "0x12F6874", VA = "0x12F6874")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F9A8", Offset = "0xB2F9A8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x12F68C0", Offset = "0x12F68C0", VA = "0x12F68C0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x12F68C8", Offset = "0x12F68C8", VA = "0x12F68C8")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB262EC", Offset = "0xB262EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB262EC", Offset = "0xB262EC")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1677734", Offset = "0x1677734", VA = "0x1677734", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2F9E0", Offset = "0xB2F9E0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1677780", Offset = "0x1677780", VA = "0x1677780", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FA18", Offset = "0xB2FA18")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x16777CC", Offset = "0x16777CC", VA = "0x16777CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FA50", Offset = "0xB2FA50")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1677818", Offset = "0x1677818", VA = "0x1677818")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FA88", Offset = "0xB2FA88")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1677864", Offset = "0x1677864", VA = "0x1677864", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x167786C", Offset = "0x167786C", VA = "0x167786C")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB2634C", Offset = "0xB2634C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB2634C", Offset = "0xB2634C")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1678188", Offset = "0x1678188", VA = "0x1678188", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FAC0", Offset = "0xB2FAC0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x16781D4", Offset = "0x16781D4", VA = "0x16781D4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FAF8", Offset = "0xB2FAF8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1678220", Offset = "0x1678220", VA = "0x1678220")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FB30", Offset = "0xB2FB30")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x167826C", Offset = "0x167826C", VA = "0x167826C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FB68", Offset = "0xB2FB68")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x16782B8", Offset = "0x16782B8", VA = "0x16782B8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x16782C0", Offset = "0x16782C0", VA = "0x16782C0")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB263AC", Offset = "0xB263AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB263AC", Offset = "0xB263AC")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1678940", Offset = "0x1678940", VA = "0x1678940", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FBA0", Offset = "0xB2FBA0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x167898C", Offset = "0x167898C", VA = "0x167898C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FBD8", Offset = "0xB2FBD8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x16789D8", Offset = "0x16789D8", VA = "0x16789D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FC10", Offset = "0xB2FC10")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1678A24", Offset = "0x1678A24", VA = "0x1678A24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FC48", Offset = "0xB2FC48")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1678A70", Offset = "0x1678A70", VA = "0x1678A70", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1678A78", Offset = "0x1678A78", VA = "0x1678A78")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB2640C", Offset = "0xB2640C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB2640C", Offset = "0xB2640C")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x16805D4", Offset = "0x16805D4", VA = "0x16805D4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FC80", Offset = "0xB2FC80")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1680620", Offset = "0x1680620", VA = "0x1680620", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FCB8", Offset = "0xB2FCB8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x168066C", Offset = "0x168066C", VA = "0x168066C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FCF0", Offset = "0xB2FCF0")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x16806B8", Offset = "0x16806B8", VA = "0x16806B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FD28", Offset = "0xB2FD28")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1680704", Offset = "0x1680704", VA = "0x1680704")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FD60", Offset = "0xB2FD60")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x1680750", Offset = "0x1680750", VA = "0x1680750")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FD98", Offset = "0xB2FD98")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x168079C", Offset = "0x168079C", VA = "0x168079C")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x16807C0", Offset = "0x16807C0", VA = "0x16807C0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x16807C8", Offset = "0x16807C8", VA = "0x16807C8")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1680984", Offset = "0x1680984", VA = "0x1680984")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1680CD8", Offset = "0x1680CD8", VA = "0x1680CD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FDD0", Offset = "0xB2FDD0")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1680CF8", Offset = "0x1680CF8", VA = "0x1680CF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FE08", Offset = "0xB2FE08")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1680DD4", Offset = "0x1680DD4", VA = "0x1680DD4")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x60002A2")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x191EEB4", Offset = "0x191EEB4", VA = "0x191EEB4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x191EFA0", Offset = "0x191EFA0", VA = "0x191EFA0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x191F15C", Offset = "0x191F15C", VA = "0x191F15C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60002A6")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60002A7")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x191F1BC", Offset = "0x191F1BC", VA = "0x191F1BC")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28CCC", Offset = "0xB28CCC")]
		public IK[] IKComponents;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28D04", Offset = "0xB28D04")]
		public Animator animator;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000029")]
		private bool animatePhysics
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x192211C", Offset = "0x192211C", VA = "0x192211C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x19221B8", Offset = "0x19221B8", VA = "0x19221B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1922228", Offset = "0x1922228", VA = "0x1922228")]
		private void Update()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x19222E4", Offset = "0x19222E4", VA = "0x19222E4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1922320", Offset = "0x1922320", VA = "0x1922320")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x192225C", Offset = "0x192225C", VA = "0x192225C")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x19223AC", Offset = "0x19223AC", VA = "0x19223AC")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB2646C", Offset = "0xB2646C")]
	public class LegIK : IK
	{
		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x14E428C", Offset = "0x14E428C", VA = "0x14E428C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FE40", Offset = "0xB2FE40")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x14E42F8", Offset = "0x14E42F8", VA = "0x14E42F8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FE78", Offset = "0xB2FE78")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x14E4364", Offset = "0x14E4364", VA = "0x14E4364")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FEB0", Offset = "0xB2FEB0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x14E43B0", Offset = "0x14E43B0", VA = "0x14E43B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FEE8", Offset = "0xB2FEE8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x14E43FC", Offset = "0x14E43FC", VA = "0x14E43FC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x14E4404", Offset = "0x14E4404", VA = "0x14E4404")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB264A4", Offset = "0xB264A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB264A4", Offset = "0xB264A4")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x14E446C", Offset = "0x14E446C", VA = "0x14E446C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FF20", Offset = "0xB2FF20")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x14E44B8", Offset = "0x14E44B8", VA = "0x14E44B8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FF58", Offset = "0xB2FF58")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x14E4504", Offset = "0x14E4504", VA = "0x14E4504")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FF90", Offset = "0xB2FF90")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x14E4550", Offset = "0x14E4550", VA = "0x14E4550")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB2FFC8", Offset = "0xB2FFC8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x14E459C", Offset = "0x14E459C", VA = "0x14E459C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x14E45A4", Offset = "0x14E45A4", VA = "0x14E45A4")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB26504", Offset = "0xB26504")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB26504", Offset = "0xB26504")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x14E460C", Offset = "0x14E460C", VA = "0x14E460C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30000", Offset = "0xB30000")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x14E4658", Offset = "0x14E4658", VA = "0x14E4658", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30038", Offset = "0xB30038")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x14E46A4", Offset = "0x14E46A4", VA = "0x14E46A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30070", Offset = "0xB30070")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x14E46F0", Offset = "0x14E46F0", VA = "0x14E46F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB300A8", Offset = "0xB300A8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x14E473C", Offset = "0x14E473C", VA = "0x14E473C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x14E4744", Offset = "0x14E4744", VA = "0x14E4744")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB26564", Offset = "0xB26564")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB26564", Offset = "0xB26564")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x14EC9C0", Offset = "0x14EC9C0", VA = "0x14EC9C0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB300E0", Offset = "0xB300E0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x14ECA0C", Offset = "0x14ECA0C", VA = "0x14ECA0C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30118", Offset = "0xB30118")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x14ECA58", Offset = "0x14ECA58", VA = "0x14ECA58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30150", Offset = "0xB30150")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x14ECAA4", Offset = "0x14ECAA4", VA = "0x14ECAA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30188", Offset = "0xB30188")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x14ECAF0", Offset = "0x14ECAF0", VA = "0x14ECAF0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x14ECAF8", Offset = "0x14ECAF8", VA = "0x14ECAF8")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB265C4", Offset = "0xB265C4")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x20000DE")]
		public class References
		{
			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform chest;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform neck;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform leftShoulder;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Transform rightShoulder;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Transform leftThigh;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Transform leftCalf;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Transform leftFoot;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Transform leftToes;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public Transform rightThigh;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Transform rightCalf;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Transform rightFoot;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public Transform rightToes;

			[Token(Token = "0x170000C9")]
			public bool isFilled
			{
				[Token(Token = "0x60006E0")]
				[Address(RVA = "0x14EDFE0", Offset = "0x14EDFE0", VA = "0x14EDFE0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000CA")]
			public bool isEmpty
			{
				[Token(Token = "0x60006E1")]
				[Address(RVA = "0x14EDB64", Offset = "0x14EDB64", VA = "0x14EDB64")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x14EE3CC", Offset = "0x14EE3CC", VA = "0x14EE3CC")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x14ED750", Offset = "0x14ED750", VA = "0x14ED750")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x14EE3C4", Offset = "0x14EE3C4", VA = "0x14EE3C4")]
			public References()
			{
			}
		}

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0xB28D3C", Offset = "0xB28D3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28D3C", Offset = "0xB28D3C")]
		public References references;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28DB8", Offset = "0xB28DB8")]
		public IKSolverVR solver;

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x14ED604", Offset = "0x14ED604", VA = "0x14ED604", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB301C0", Offset = "0xB301C0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x14ED670", Offset = "0x14ED670", VA = "0x14ED670", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB301F8", Offset = "0xB301F8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x14ED6DC", Offset = "0x14ED6DC", VA = "0x14ED6DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30230", Offset = "0xB30230")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x14ED728", Offset = "0x14ED728", VA = "0x14ED728")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30268", Offset = "0xB30268")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x14EDAC0", Offset = "0x14EDAC0", VA = "0x14EDAC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB302A0", Offset = "0xB302A0")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x14EDAE8", Offset = "0x14EDAE8", VA = "0x14EDAE8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x14EDAF0", Offset = "0x14EDAF0", VA = "0x14EDAF0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x14EE33C", Offset = "0x14EE33C", VA = "0x14EE33C")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class FABRIKChain
	{
		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB28DF0", Offset = "0xB28DF0")]
		public float pull;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB28E08", Offset = "0xB28E08")]
		public float pin;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1678328", Offset = "0x1678328", VA = "0x1678328")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x16783F0", Offset = "0x16783F0", VA = "0x16783F0")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1678410", Offset = "0x1678410", VA = "0x1678410")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x16787E0", Offset = "0x16787E0", VA = "0x16787E0")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x16784E4", Offset = "0x16784E4", VA = "0x16784E4")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x16788D8", Offset = "0x16788D8", VA = "0x16788D8")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1678AE0", Offset = "0x1678AE0", VA = "0x1678AE0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1679048", Offset = "0x1679048", VA = "0x1679048")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1679208", Offset = "0x1679208", VA = "0x1679208")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1679300", Offset = "0x1679300", VA = "0x1679300")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000DF")]
		public class BendBone
		{
			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C530", Offset = "0xB2C530")]
			public Transform transform;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C568", Offset = "0xB2C568")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2C568", Offset = "0xB2C568")]
			public float weight;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x167C330", Offset = "0x167C330", VA = "0x167C330")]
			public BendBone()
			{
			}

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x167C3B0", Offset = "0x167C3B0", VA = "0x167C3B0")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x1679AC0", Offset = "0x1679AC0", VA = "0x1679AC0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x1679EC4", Offset = "0x1679EC4", VA = "0x1679EC4")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28E20", Offset = "0xB28E20")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB28E58", Offset = "0xB28E58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28E58", Offset = "0xB28E58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB28E58", Offset = "0xB28E58")]
		public float positionWeight;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28ED0", Offset = "0xB28ED0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB28ED0", Offset = "0xB28ED0")]
		public float bodyWeight;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28F24", Offset = "0xB28F24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB28F24", Offset = "0xB28F24")]
		public float thighWeight;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28F78", Offset = "0xB28F78")]
		public bool handsPullBody;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB28FB0", Offset = "0xB28FB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB28FB0", Offset = "0xB28FB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB28FB0", Offset = "0xB28FB0")]
		public float rotationWeight;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29028", Offset = "0xB29028")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB29028", Offset = "0xB29028")]
		public float bodyClampWeight;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2907C", Offset = "0xB2907C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2907C", Offset = "0xB2907C")]
		public float headClampWeight;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB290D0", Offset = "0xB290D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB290D0", Offset = "0xB290D0")]
		public float bendWeight;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29124", Offset = "0xB29124")]
		public BendBone[] bendBones;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB2915C", Offset = "0xB2915C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2915C", Offset = "0xB2915C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2915C", Offset = "0xB2915C")]
		public float CCDWeight;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB291D4", Offset = "0xB291D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB291D4", Offset = "0xB291D4")]
		public float roll;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29228", Offset = "0xB29228")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB29228", Offset = "0xB29228")]
		public float damper;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29280", Offset = "0xB29280")]
		public Transform[] CCDBones;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB292B8", Offset = "0xB292B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB292B8", Offset = "0xB292B8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB292B8", Offset = "0xB292B8")]
		public float postStretchWeight;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29330", Offset = "0xB29330")]
		public float maxStretch;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29368", Offset = "0xB29368")]
		public float stretchDamper;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB293A0", Offset = "0xB293A0")]
		public bool fixHead;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB293D8", Offset = "0xB293D8")]
		public Transform[] stretchBones;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB29410", Offset = "0xB29410")]
		public Vector3 chestDirection;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB29448", Offset = "0xB29448")]
		public float chestDirectionWeight;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1679308", Offset = "0x1679308", VA = "0x1679308")]
		private void Start()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1679638", Offset = "0x1679638", VA = "0x1679638")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1679AF8", Offset = "0x1679AF8", VA = "0x1679AF8")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1679EEC", Offset = "0x1679EEC", VA = "0x1679EEC")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x167A864", Offset = "0x167A864", VA = "0x167A864")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x167ABB0", Offset = "0x167ABB0", VA = "0x167ABB0")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x167AF4C", Offset = "0x167AF4C", VA = "0x167AF4C")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x167B9B8", Offset = "0x167B9B8", VA = "0x167B9B8")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x167A590", Offset = "0x167A590", VA = "0x167A590")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x167BBC8", Offset = "0x167BBC8", VA = "0x167BBC8")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x167B874", Offset = "0x167B874", VA = "0x167B874")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x167B6D8", Offset = "0x167B6D8", VA = "0x167B6D8")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x167BF34", Offset = "0x167BF34", VA = "0x167BF34")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x167C1B4", Offset = "0x167C1B4", VA = "0x167C1B4")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x20000E0")]
		public class ChildConstraint
		{
			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C5DC", Offset = "0xB2C5DC")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C5EC", Offset = "0xB2C5EC")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x170000CB")]
			public float nominalDistance
			{
				[Token(Token = "0x60006E8")]
				[Address(RVA = "0x167F274", Offset = "0x167F274", VA = "0x167F274")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB314B0", Offset = "0xB314B0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006E9")]
				[Address(RVA = "0x167F27C", Offset = "0x167F27C", VA = "0x167F27C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB314C0", Offset = "0xB314C0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CC")]
			public bool isRigid
			{
				[Token(Token = "0x60006EA")]
				[Address(RVA = "0x167F284", Offset = "0x167F284", VA = "0x167F284")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB314D0", Offset = "0xB314D0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006EB")]
				[Address(RVA = "0x167F28C", Offset = "0x167F28C", VA = "0x167F28C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB314E0", Offset = "0xB314E0")]
				private set
				{
				}
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x167F298", Offset = "0x167F298", VA = "0x167F298")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x167CFF8", Offset = "0x167CFF8", VA = "0x167CFF8")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x167D538", Offset = "0x167D538", VA = "0x167D538")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x167EF70", Offset = "0x167EF70", VA = "0x167EF70")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E1")]
		public enum Smoothing
		{
			[Token(Token = "0x400065B")]
			None,
			[Token(Token = "0x400065C")]
			Exponential,
			[Token(Token = "0x400065D")]
			Cubic
		}

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB29460", Offset = "0xB29460")]
		public float pin;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB29478", Offset = "0xB29478")]
		public float pull;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB29490", Offset = "0xB29490")]
		public float push;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB294A8", Offset = "0xB294A8")]
		public float pushParent;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB294C0", Offset = "0xB294C0")]
		public float reach;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x400030F")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x167C454", Offset = "0x167C454", VA = "0x167C454")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x167C520", Offset = "0x167C520", VA = "0x167C520")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x167C62C", Offset = "0x167C62C", VA = "0x167C62C")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x167C750", Offset = "0x167C750", VA = "0x167C750")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x167C82C", Offset = "0x167C82C", VA = "0x167C82C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x167C930", Offset = "0x167C930", VA = "0x167C930")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x167D050", Offset = "0x167D050", VA = "0x167D050")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x167CAC0", Offset = "0x167CAC0", VA = "0x167CAC0")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x167D73C", Offset = "0x167D73C", VA = "0x167D73C")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x167DAE0", Offset = "0x167DAE0", VA = "0x167DAE0")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x167DEC4", Offset = "0x167DEC4", VA = "0x167DEC4")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x167E448", Offset = "0x167E448", VA = "0x167E448")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x167EA18", Offset = "0x167EA18", VA = "0x167EA18")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x167ECB0", Offset = "0x167ECB0", VA = "0x167ECB0")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x167E910", Offset = "0x167E910", VA = "0x167E910")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x167E230", Offset = "0x167E230", VA = "0x167E230")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x167E898", Offset = "0x167E898", VA = "0x167E898")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x167ED98", Offset = "0x167ED98", VA = "0x167ED98")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x167E7B8", Offset = "0x167E7B8", VA = "0x167E7B8")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x167EB98", Offset = "0x167EB98", VA = "0x167EB98")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public class IKConstraintBend
	{
		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB294D8", Offset = "0xB294D8")]
		public float weight;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB294F0", Offset = "0xB294F0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700002A")]
		public bool initiated
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x191F38C", Offset = "0x191F38C", VA = "0x191F38C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB302D8", Offset = "0xB302D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x191F394", Offset = "0x191F394", VA = "0x191F394")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB302E8", Offset = "0xB302E8")]
			private set
			{
			}
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x191F1C4", Offset = "0x191F1C4", VA = "0x191F1C4")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x191F3A0", Offset = "0x191F3A0", VA = "0x191F3A0")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x191F424", Offset = "0x191F424", VA = "0x191F424")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x191F4D0", Offset = "0x191F4D0", VA = "0x191F4D0")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x191F4DC", Offset = "0x191F4DC", VA = "0x191F4DC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x191FA04", Offset = "0x191FA04", VA = "0x191FA04")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x191FC34", Offset = "0x191FC34", VA = "0x191FC34")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x19200D0", Offset = "0x19200D0", VA = "0x19200D0")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x191F7D4", Offset = "0x191F7D4", VA = "0x191F7D4")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x191F8EC", Offset = "0x191F8EC", VA = "0x191F8EC")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000078")]
	public class IKEffector
	{
		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB29500", Offset = "0xB29500")]
		public float positionWeight;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB29518", Offset = "0xB29518")]
		public float rotationWeight;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB29530", Offset = "0xB29530")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB29540", Offset = "0xB29540")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x1700002B")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x1920780", Offset = "0x1920780", VA = "0x1920780")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB302F8", Offset = "0xB302F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x1920788", Offset = "0x1920788", VA = "0x1920788")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30308", Offset = "0xB30308")]
			private set
			{
			}
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1920718", Offset = "0x1920718", VA = "0x1920718")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1920794", Offset = "0x1920794", VA = "0x1920794")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1920868", Offset = "0x1920868", VA = "0x1920868")]
		public IKEffector()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x19209A4", Offset = "0x19209A4", VA = "0x19209A4")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1920AFC", Offset = "0x1920AFC", VA = "0x1920AFC")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1920DEC", Offset = "0x1920DEC", VA = "0x1920DEC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1921078", Offset = "0x1921078", VA = "0x1921078")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x19211B0", Offset = "0x19211B0", VA = "0x19211B0")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x192125C", Offset = "0x192125C", VA = "0x192125C")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x192189C", Offset = "0x192189C", VA = "0x192189C")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x192190C", Offset = "0x192190C", VA = "0x192190C")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1921B18", Offset = "0x1921B18", VA = "0x1921B18")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1921E4C", Offset = "0x1921E4C", VA = "0x1921E4C")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000079")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000E2")]
		public class BoneMap
		{
			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x170000CD")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60006F1")]
				[Address(RVA = "0x192261C", Offset = "0x192261C", VA = "0x192261C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CE")]
			public bool isNodeBone
			{
				[Token(Token = "0x60006F4")]
				[Address(RVA = "0x1922788", Offset = "0x1922788", VA = "0x1922788")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000CF")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000708")]
				[Address(RVA = "0x1922D60", Offset = "0x1922D60", VA = "0x1922D60")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x19225F4", Offset = "0x19225F4", VA = "0x19225F4")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x19226E8", Offset = "0x19226E8", VA = "0x19226E8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x1922738", Offset = "0x1922738", VA = "0x1922738")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x1922798", Offset = "0x1922798", VA = "0x1922798")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x1922880", Offset = "0x1922880", VA = "0x1922880")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x1922888", Offset = "0x1922888", VA = "0x1922888")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x1922A18", Offset = "0x1922A18", VA = "0x1922A18")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x1922B24", Offset = "0x1922B24", VA = "0x1922B24")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x1922BB0", Offset = "0x1922BB0", VA = "0x1922BB0")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x1922F84", Offset = "0x1922F84", VA = "0x1922F84")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x1922FBC", Offset = "0x1922FBC", VA = "0x1922FBC")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x1922FF4", Offset = "0x1922FF4", VA = "0x1922FF4")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x192301C", Offset = "0x192301C", VA = "0x192301C")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x1923144", Offset = "0x1923144", VA = "0x1923144")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x192347C", Offset = "0x192347C", VA = "0x192347C")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x19234AC", Offset = "0x19234AC", VA = "0x19234AC")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x1923644", Offset = "0x1923644", VA = "0x1923644")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x19236B4", Offset = "0x19236B4", VA = "0x19236B4")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x19238F8", Offset = "0x19238F8", VA = "0x19238F8")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x1923B20", Offset = "0x1923B20", VA = "0x1923B20")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x1923C38", Offset = "0x1923C38", VA = "0x1923C38")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x1923284", Offset = "0x1923284", VA = "0x1923284")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x1923DC8", Offset = "0x1923DC8", VA = "0x1923DC8")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x19223B4", Offset = "0x19223B4", VA = "0x19223B4", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x19223BC", Offset = "0x19223BC", VA = "0x19223BC", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x19223C0", Offset = "0x19223C0", VA = "0x19223C0")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x19224E4", Offset = "0x19224E4", VA = "0x19224E4")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x19225EC", Offset = "0x19225EC", VA = "0x19225EC")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007A")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB29558", Offset = "0xB29558")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1923DE4", Offset = "0x1923DE4", VA = "0x1923DE4", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1923E84", Offset = "0x1923E84", VA = "0x1923E84")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1923F08", Offset = "0x1923F08", VA = "0x1923F08")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1923FA0", Offset = "0x1923FA0", VA = "0x1923FA0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1923FB8", Offset = "0x1923FB8", VA = "0x1923FB8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1923FD4", Offset = "0x1923FD4", VA = "0x1923FD4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1924070", Offset = "0x1924070", VA = "0x1924070")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1924088", Offset = "0x1924088", VA = "0x1924088")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000E3")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000675")]
			Parent,
			[Token(Token = "0x4000676")]
			Bone1,
			[Token(Token = "0x4000677")]
			Bone2,
			[Token(Token = "0x4000678")]
			Bone3
		}

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB29570", Offset = "0xB29570")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB29588", Offset = "0xB29588")]
		public float weight;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x19240AC", Offset = "0x19240AC", VA = "0x19240AC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1924130", Offset = "0x1924130", VA = "0x1924130")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1924204", Offset = "0x1924204", VA = "0x1924204")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1924558", Offset = "0x1924558", VA = "0x1924558")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1924658", Offset = "0x1924658", VA = "0x1924658")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1924784", Offset = "0x1924784", VA = "0x1924784")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1924790", Offset = "0x1924790", VA = "0x1924790")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1924838", Offset = "0x1924838", VA = "0x1924838")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x19248F0", Offset = "0x19248F0", VA = "0x19248F0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1924B60", Offset = "0x1924B60", VA = "0x1924B60")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1924C18", Offset = "0x1924C18", VA = "0x1924C18")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007C")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB295A0", Offset = "0xB295A0")]
		public int iterations;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB295B8", Offset = "0xB295B8")]
		public float twistWeight;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1924D80", Offset = "0x1924D80", VA = "0x1924D80", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1925070", Offset = "0x1925070", VA = "0x1925070")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x192518C", Offset = "0x192518C", VA = "0x192518C")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x19252E4", Offset = "0x19252E4", VA = "0x19252E4")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x19252F4", Offset = "0x19252F4", VA = "0x19252F4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x192535C", Offset = "0x192535C", VA = "0x192535C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x19253DC", Offset = "0x19253DC", VA = "0x19253DC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1925A30", Offset = "0x1925A30", VA = "0x1925A30")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1925A68", Offset = "0x1925A68", VA = "0x1925A68")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1925D48", Offset = "0x1925D48", VA = "0x1925D48")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x19260F4", Offset = "0x19260F4", VA = "0x19260F4")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x19261E0", Offset = "0x19261E0", VA = "0x19261E0")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x19262A8", Offset = "0x19262A8", VA = "0x19262A8")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007D")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000E4")]
		public class Point
		{
			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2C5FC", Offset = "0xB2C5FC")]
			public float weight;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x1927DC8", Offset = "0x1927DC8", VA = "0x1927DC8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x1927E18", Offset = "0x1927E18", VA = "0x1927E18")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x1927FA0", Offset = "0x1927FA0", VA = "0x1927FA0")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x1927FD8", Offset = "0x1927FD8", VA = "0x1927FD8")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x1928010", Offset = "0x1928010", VA = "0x1928010")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x1928060", Offset = "0x1928060", VA = "0x1928060")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x192789C", Offset = "0x192789C", VA = "0x192789C")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E5")]
		public class Bone : Point
		{
			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x170000D0")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000711")]
				[Address(RVA = "0x1926E6C", Offset = "0x1926E6C", VA = "0x1926E6C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000712")]
				[Address(RVA = "0x1926F60", Offset = "0x1926F60", VA = "0x1926F60")]
				set
				{
				}
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x1926FE8", Offset = "0x1926FE8", VA = "0x1926FE8")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0x19272A8", Offset = "0x19272A8", VA = "0x19272A8")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x1927588", Offset = "0x1927588", VA = "0x1927588")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x19277F0", Offset = "0x19277F0", VA = "0x19277F0")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000717")]
			[Address(RVA = "0x1927818", Offset = "0x1927818", VA = "0x1927818")]
			public Bone()
			{
			}

			[Token(Token = "0x6000718")]
			[Address(RVA = "0x192791C", Offset = "0x192791C", VA = "0x192791C")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000719")]
			[Address(RVA = "0x19279B4", Offset = "0x19279B4", VA = "0x19279B4")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E6")]
		public class Node : Point
		{
			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x600071A")]
			[Address(RVA = "0x1927D64", Offset = "0x1927D64", VA = "0x1927D64")]
			public Node()
			{
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x1927D68", Offset = "0x1927D68", VA = "0x1927D68")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x1927D90", Offset = "0x1927D90", VA = "0x1927D90")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000E7")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000E8")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB295E0", Offset = "0xB295E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB295E0", Offset = "0xB295E0")]
		public float IKPositionWeight;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB29634", Offset = "0xB29634")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x1700002C")]
		public bool initiated
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x19268BC", Offset = "0x19268BC", VA = "0x19268BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30318", Offset = "0xB30318")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x19268C4", Offset = "0x19268C4", VA = "0x19268C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30328", Offset = "0xB30328")]
			private set
			{
			}
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1926588", Offset = "0x1926588", VA = "0x1926588")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600033D")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x191F010", Offset = "0x191F010", VA = "0x191F010")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x191EF38", Offset = "0x191EF38", VA = "0x191EF38")]
		public void Update()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1926810", Offset = "0x1926810", VA = "0x1926810", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x192681C", Offset = "0x192681C", VA = "0x192681C")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1926828", Offset = "0x1926828", VA = "0x1926828")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1926830", Offset = "0x1926830", VA = "0x1926830")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x19268B4", Offset = "0x19268B4", VA = "0x19268B4")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000348")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000349")]
		public abstract void FixTransforms();

		[Token(Token = "0x600034A")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x600034B")]
		protected abstract void OnInitiate();

		[Token(Token = "0x600034C")]
		protected abstract void OnUpdate();

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x19268D0", Offset = "0x19268D0", VA = "0x19268D0")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x19268E8", Offset = "0x19268E8", VA = "0x19268E8")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1926A24", Offset = "0x1926A24", VA = "0x1926A24")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1926AD0", Offset = "0x1926AD0", VA = "0x1926AD0")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1926E54", Offset = "0x1926E54", VA = "0x1926E54")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007E")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2967C", Offset = "0xB2967C")]
		public float poleWeight;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB29694", Offset = "0xB29694")]
		public float clampWeight;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB296AC", Offset = "0xB296AC")]
		public int clampSmoothing;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700002D")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x19281F8", Offset = "0x19281F8", VA = "0x19281F8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002E")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x19282C4", Offset = "0x19282C4", VA = "0x19282C4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002F")]
		protected override int minBones
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x1929034", Offset = "0x1929034", VA = "0x1929034", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000030")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x19295D8", Offset = "0x19295D8", VA = "0x19295D8", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x19280F8", Offset = "0x19280F8", VA = "0x19280F8")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1928390", Offset = "0x1928390", VA = "0x1928390", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1928610", Offset = "0x1928610", VA = "0x1928610", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1928F80", Offset = "0x1928F80", VA = "0x1928F80")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1928BA8", Offset = "0x1928BA8", VA = "0x1928BA8")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x192903C", Offset = "0x192903C", VA = "0x192903C")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x192964C", Offset = "0x192964C", VA = "0x192964C")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x192975C", Offset = "0x192975C", VA = "0x192975C")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x192980C", Offset = "0x192980C", VA = "0x192980C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1929E00", Offset = "0x1929E00", VA = "0x1929E00", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x192A550", Offset = "0x192A550", VA = "0x192A550")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x192ACA4", Offset = "0x192ACA4", VA = "0x192ACA4")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000031")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x192BEC4", Offset = "0x192BEC4", VA = "0x192BEC4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x192ACA8", Offset = "0x192ACA8", VA = "0x192ACA8")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x192B3F0", Offset = "0x192B3F0", VA = "0x192B3F0")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x192B528", Offset = "0x192B528", VA = "0x192B528", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x192B5C0", Offset = "0x192B5C0", VA = "0x192B5C0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x192BB64", Offset = "0x192BB64", VA = "0x192BB64", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x192BECC", Offset = "0x192BECC", VA = "0x192BECC")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x192AD7C", Offset = "0x192AD7C", VA = "0x192AD7C")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x192B4D4", Offset = "0x192B4D4", VA = "0x192B4D4")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x192BE68", Offset = "0x192BE68", VA = "0x192BE68")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x192B218", Offset = "0x192B218", VA = "0x192B218")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x192C70C", Offset = "0x192C70C", VA = "0x192C70C")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x192C81C", Offset = "0x192C81C", VA = "0x192C81C")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x192C948", Offset = "0x192C948", VA = "0x192C948")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x192CA60", Offset = "0x192CA60", VA = "0x192CA60")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x192B8CC", Offset = "0x192B8CC", VA = "0x192B8CC")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x192BA18", Offset = "0x192BA18", VA = "0x192BA18")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x192CC4C", Offset = "0x192CC4C", VA = "0x192CC4C")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x192C184", Offset = "0x192C184", VA = "0x192C184")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x192B4C4", Offset = "0x192B4C4", VA = "0x192B4C4")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x192D3B4", Offset = "0x192D3B4", VA = "0x192D3B4")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x192CE20", Offset = "0x192CE20", VA = "0x192CE20")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x192BFE4", Offset = "0x192BFE4", VA = "0x192BFE4")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x192C0C0", Offset = "0x192C0C0", VA = "0x192C0C0")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x192D480", Offset = "0x192D480", VA = "0x192D480")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB296C4", Offset = "0xB296C4")]
		public float rootPin;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x192D4F4", Offset = "0x192D4F4", VA = "0x192D4F4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x192DDC0", Offset = "0x192DDC0", VA = "0x192DDC0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x192DE58", Offset = "0x192DE58", VA = "0x192DE58", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x192DEF8", Offset = "0x192DEF8", VA = "0x192DEF8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x192DFF8", Offset = "0x192DFF8", VA = "0x192DFF8")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x192E094", Offset = "0x192E094", VA = "0x192E094", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x192E5FC", Offset = "0x192E5FC", VA = "0x192E5FC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x192E7FC", Offset = "0x192E7FC", VA = "0x192E7FC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x192E6AC", Offset = "0x192E6AC", VA = "0x192E6AC")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x192E2C8", Offset = "0x192E2C8", VA = "0x192E2C8")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x192E894", Offset = "0x192E894", VA = "0x192E894")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB296DC", Offset = "0xB296DC")]
		public int iterations;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x192E90C", Offset = "0x192E90C", VA = "0x192E90C")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x192EA00", Offset = "0x192EA00", VA = "0x192EA00")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x192EA5C", Offset = "0x192EA5C", VA = "0x192EA5C")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x19206BC", Offset = "0x19206BC", VA = "0x19206BC")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x191F754", Offset = "0x191F754", VA = "0x191F754")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x192EB90", Offset = "0x192EB90", VA = "0x192EB90", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x192ED18", Offset = "0x192ED18", VA = "0x192ED18", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x192EE8C", Offset = "0x192EE8C", VA = "0x192EE8C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x192F08C", Offset = "0x192F08C", VA = "0x192F08C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x192F15C", Offset = "0x192F15C", VA = "0x192F15C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x192F238", Offset = "0x192F238", VA = "0x192F238", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x192F3A8", Offset = "0x192F3A8", VA = "0x192F3A8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x192F560", Offset = "0x192F560", VA = "0x192F560", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x192F79C", Offset = "0x192F79C", VA = "0x192F79C", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x192FA5C", Offset = "0x192FA5C", VA = "0x192FA5C", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x192FAA0", Offset = "0x192FAA0", VA = "0x192FAA0", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x192FB84", Offset = "0x192FB84", VA = "0x192FB84")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x400038C")]
		Body,
		[Token(Token = "0x400038D")]
		LeftShoulder,
		[Token(Token = "0x400038E")]
		RightShoulder,
		[Token(Token = "0x400038F")]
		LeftThigh,
		[Token(Token = "0x4000390")]
		RightThigh,
		[Token(Token = "0x4000391")]
		LeftHand,
		[Token(Token = "0x4000392")]
		RightHand,
		[Token(Token = "0x4000393")]
		LeftFoot,
		[Token(Token = "0x4000394")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x4000396")]
		LeftArm,
		[Token(Token = "0x4000397")]
		RightArm,
		[Token(Token = "0x4000398")]
		LeftLeg,
		[Token(Token = "0x4000399")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000085")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB296F4", Offset = "0xB296F4")]
		public float spineStiffness;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2970C", Offset = "0xB2970C")]
		public float pullBodyVertical;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB29724", Offset = "0xB29724")]
		public float pullBodyHorizontal;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2973C", Offset = "0xB2973C")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000032")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x192FC64", Offset = "0x192FC64", VA = "0x192FC64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x192FDAC", Offset = "0x192FDAC", VA = "0x192FDAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x192FDB4", Offset = "0x192FDB4", VA = "0x192FDB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x192FDBC", Offset = "0x192FDBC", VA = "0x192FDBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x192FDC4", Offset = "0x192FDC4", VA = "0x192FDC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x192FDCC", Offset = "0x192FDCC", VA = "0x192FDCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x192FDD4", Offset = "0x192FDD4", VA = "0x192FDD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x192FDDC", Offset = "0x192FDDC", VA = "0x192FDDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x192FDE4", Offset = "0x192FDE4", VA = "0x192FDE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x192FDEC", Offset = "0x192FDEC", VA = "0x192FDEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x192FE24", Offset = "0x192FE24", VA = "0x192FE24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x192FE5C", Offset = "0x192FE5C", VA = "0x192FE5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x192FE94", Offset = "0x192FE94", VA = "0x192FE94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x192FECC", Offset = "0x192FECC", VA = "0x192FECC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x192FF00", Offset = "0x192FF00", VA = "0x192FF00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x192FF38", Offset = "0x192FF38", VA = "0x192FF38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x192FF70", Offset = "0x192FF70", VA = "0x192FF70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x192FFA8", Offset = "0x192FFA8", VA = "0x192FFA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x1931EF8", Offset = "0x1931EF8", VA = "0x1931EF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30338", Offset = "0xB30338")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x1931F04", Offset = "0x1931F04", VA = "0x1931F04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30348", Offset = "0xB30348")]
			private set
			{
			}
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x192FFDC", Offset = "0x192FFDC", VA = "0x192FFDC")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x19300E8", Offset = "0x19300E8", VA = "0x19300E8")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1930030", Offset = "0x1930030", VA = "0x1930030")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x19301C4", Offset = "0x19301C4", VA = "0x19301C4")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x192FC6C", Offset = "0x192FC6C", VA = "0x192FC6C")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1930294", Offset = "0x1930294", VA = "0x1930294")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x193034C", Offset = "0x193034C", VA = "0x193034C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1930400", Offset = "0x1930400", VA = "0x1930400")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x19304B4", Offset = "0x19304B4", VA = "0x19304B4")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x19304BC", Offset = "0x19304BC", VA = "0x19304BC")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x19304F0", Offset = "0x19304F0", VA = "0x19304F0")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x19305B8", Offset = "0x19305B8", VA = "0x19305B8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x1930748", Offset = "0x1930748", VA = "0x1930748")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x193181C", Offset = "0x193181C", VA = "0x193181C")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1931CB0", Offset = "0x1931CB0", VA = "0x1931CB0")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1931D10", Offset = "0x1931D10", VA = "0x1931D10")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1931B30", Offset = "0x1931B30", VA = "0x1931B30")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x1931BF0", Offset = "0x1931BF0", VA = "0x1931BF0")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x1931F10", Offset = "0x1931F10", VA = "0x1931F10")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1931FEC", Offset = "0x1931FEC", VA = "0x1931FEC", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x1932130", Offset = "0x1932130", VA = "0x1932130")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x19322C0", Offset = "0x19322C0", VA = "0x19322C0")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x19324C0", Offset = "0x19324C0", VA = "0x19324C0")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x19326C0", Offset = "0x19326C0", VA = "0x19326C0", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x19329F0", Offset = "0x19329F0", VA = "0x19329F0", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1932AF0", Offset = "0x1932AF0", VA = "0x1932AF0")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000045")]
		protected virtual int minBones
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x1933328", Offset = "0x1933328", VA = "0x1933328", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000046")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x1933330", Offset = "0x1933330", VA = "0x1933330", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x1933338", Offset = "0x1933338", VA = "0x1933338", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x1933348", Offset = "0x1933348", VA = "0x1933348", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000049")]
		protected float positionOffset
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x192A48C", Offset = "0x192A48C", VA = "0x192A48C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1932AFC", Offset = "0x1932AFC", VA = "0x1932AFC")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1932C88", Offset = "0x1932C88", VA = "0x1932C88")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1932DC4", Offset = "0x1932DC4", VA = "0x1932DC4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1932E2C", Offset = "0x1932E2C", VA = "0x1932E2C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1932EA8", Offset = "0x1932EA8", VA = "0x1932EA8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x193322C", Offset = "0x193322C", VA = "0x193322C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1933234", Offset = "0x1933234", VA = "0x1933234", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1933340", Offset = "0x1933340", VA = "0x1933340", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1933344", Offset = "0x1933344", VA = "0x1933344", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x192988C", Offset = "0x192988C", VA = "0x192988C")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x192A0F4", Offset = "0x192A0F4", VA = "0x192A0F4")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x193347C", Offset = "0x193347C", VA = "0x193347C")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x19296E0", Offset = "0x19296E0", VA = "0x19296E0")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000087")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2974C", Offset = "0xB2974C")]
		public float IKRotationWeight;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1933730", Offset = "0x1933730", VA = "0x1933730", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1933AA4", Offset = "0x1933AA4", VA = "0x1933AA4")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1933B10", Offset = "0x1933B10", VA = "0x1933B10", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1933C6C", Offset = "0x1933C6C", VA = "0x1933C6C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1933E04", Offset = "0x1933E04", VA = "0x1933E04", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1933E50", Offset = "0x1933E50", VA = "0x1933E50", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1933EB0", Offset = "0x1933EB0", VA = "0x1933EB0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1934218", Offset = "0x1934218", VA = "0x1934218", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1934244", Offset = "0x1934244", VA = "0x1934244")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1933F14", Offset = "0x1933F14", VA = "0x1933F14")]
		private void Read()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1934348", Offset = "0x1934348", VA = "0x1934348")]
		private void Write()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1934460", Offset = "0x1934460", VA = "0x1934460")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000088")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20000E9")]
		public enum BendModifier
		{
			[Token(Token = "0x4000689")]
			Animation,
			[Token(Token = "0x400068A")]
			Target,
			[Token(Token = "0x400068B")]
			Parent,
			[Token(Token = "0x400068C")]
			Arm,
			[Token(Token = "0x400068D")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20000EA")]
		public struct AxisDirection
		{
			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x17A9D30", Offset = "0x17A9D30", VA = "0x17A9D30")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB29764", Offset = "0xB29764")]
		public float maintainRotationWeight;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2977C", Offset = "0xB2977C")]
		public float bendModifierWeight;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x1700004A")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x17A9D14", Offset = "0x17A9D14", VA = "0x17A9D14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x17A8610", Offset = "0x17A8610", VA = "0x17A8610")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x17A8660", Offset = "0x17A8660", VA = "0x17A8660")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x17A8774", Offset = "0x17A8774", VA = "0x17A8774", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x17A8DE4", Offset = "0x17A8DE4", VA = "0x17A8DE4", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x17A99C0", Offset = "0x17A99C0", VA = "0x17A99C0", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x17A9B08", Offset = "0x17A9B08", VA = "0x17A9B08")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x17A9C8C", Offset = "0x17A9C8C", VA = "0x17A9C8C")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x17A8AF0", Offset = "0x17A8AF0", VA = "0x17A8AF0")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x17A8F10", Offset = "0x17A8F10", VA = "0x17A8F10")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000089")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000EB")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x170000D1")]
			public Vector3 forward
			{
				[Token(Token = "0x600072A")]
				[Address(RVA = "0x17ABBD0", Offset = "0x17ABBD0", VA = "0x17ABBD0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000726")]
			[Address(RVA = "0x17AC31C", Offset = "0x17AC31C", VA = "0x17AC31C")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000727")]
			[Address(RVA = "0x17AAF6C", Offset = "0x17AAF6C", VA = "0x17AAF6C")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x17AB2A8", Offset = "0x17AB2A8", VA = "0x17AB2A8")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0x17ABFD4", Offset = "0x17ABFD4", VA = "0x17ABFD4")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB29794", Offset = "0xB29794")]
		public float bodyWeight;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB297AC", Offset = "0xB297AC")]
		public float headWeight;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB297C4", Offset = "0xB297C4")]
		public float eyesWeight;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB297DC", Offset = "0xB297DC")]
		public float clampWeight;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB297F4", Offset = "0xB297F4")]
		public float clampWeightHead;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2980C", Offset = "0xB2980C")]
		public float clampWeightEyes;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB29824", Offset = "0xB29824")]
		public int clampSmoothing;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] headForwards;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x1700004B")]
		private bool spineIsValid
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x17AA6D0", Offset = "0x17AA6D0", VA = "0x17AA6D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004C")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x17AA8A8", Offset = "0x17AA8A8", VA = "0x17AA8A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		private bool headIsValid
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x17AA7B4", Offset = "0x17AA7B4", VA = "0x17AA7B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		private bool headIsEmpty
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x17AA8CC", Offset = "0x17AA8CC", VA = "0x17AA8CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		private bool eyesIsValid
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x17AA7C4", Offset = "0x17AA7C4", VA = "0x17AA7C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000050")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x17AA948", Offset = "0x17AA948", VA = "0x17AA948")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x17A9D90", Offset = "0x17A9D90", VA = "0x17A9D90")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x17A9E14", Offset = "0x17A9E14", VA = "0x17A9E14")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x17A9EC0", Offset = "0x17A9EC0", VA = "0x17A9EC0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x17A9F88", Offset = "0x17A9F88", VA = "0x17A9F88")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x17AA074", Offset = "0x17AA074", VA = "0x17AA074")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x17AA180", Offset = "0x17AA180", VA = "0x17AA180")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x17AA2C8", Offset = "0x17AA2C8", VA = "0x17AA2C8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x17AA3F8", Offset = "0x17AA3F8", VA = "0x17AA3F8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x17AA53C", Offset = "0x17AA53C", VA = "0x17AA53C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x17AA96C", Offset = "0x17AA96C", VA = "0x17AA96C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x17AABA4", Offset = "0x17AABA4", VA = "0x17AABA4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x17AAD44", Offset = "0x17AAD44", VA = "0x17AAD44")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x17AAF98", Offset = "0x17AAF98", VA = "0x17AAF98", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x17AB3E4", Offset = "0x17AB3E4", VA = "0x17AB3E4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x17AB4E8", Offset = "0x17AB4E8", VA = "0x17AB4E8")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x17AB714", Offset = "0x17AB714", VA = "0x17AB714")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x17AB970", Offset = "0x17AB970", VA = "0x17AB970")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x17ABC9C", Offset = "0x17ABC9C", VA = "0x17ABC9C")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x17AADF4", Offset = "0x17AADF4", VA = "0x17AADF4")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x17AC13C", Offset = "0x17AC13C", VA = "0x17AC13C")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008A")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000EC")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x17AD8F4", Offset = "0x17AD8F4", VA = "0x17AD8F4")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x17AE49C", Offset = "0x17AE49C", VA = "0x17AE49C")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600072D")]
			[Address(RVA = "0x17A86A8", Offset = "0x17A86A8", VA = "0x17A86A8")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x17AE564", Offset = "0x17AE564", VA = "0x17AE564")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2983C", Offset = "0xB2983C")]
		public float IKRotationWeight;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x17AC324", Offset = "0x17AC324", VA = "0x17AC324")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x17AC514", Offset = "0x17AC514", VA = "0x17AC514")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x17AC6C8", Offset = "0x17AC6C8", VA = "0x17AC6C8")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x17AC6D4", Offset = "0x17AC6D4", VA = "0x17AC6D4")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x17AC758", Offset = "0x17AC758", VA = "0x17AC758")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x17AC764", Offset = "0x17AC764", VA = "0x17AC764")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x17AC76C", Offset = "0x17AC76C", VA = "0x17AC76C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x17AC870", Offset = "0x17AC870", VA = "0x17AC870", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x17AC990", Offset = "0x17AC990", VA = "0x17AC990", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x17AC9DC", Offset = "0x17AC9DC", VA = "0x17AC9DC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x17ACA3C", Offset = "0x17ACA3C", VA = "0x17ACA3C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x17ACE18", Offset = "0x17ACE18", VA = "0x17ACE18")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x17ACE70", Offset = "0x17ACE70", VA = "0x17ACE70")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x17AD418", Offset = "0x17AD418", VA = "0x17AD418")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x17AD630", Offset = "0x17AD630", VA = "0x17AD630", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x17AD7EC", Offset = "0x17AD7EC", VA = "0x17AD7EC")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x17AD768", Offset = "0x17AD768", VA = "0x17AD768")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x17ADA94", Offset = "0x17ADA94", VA = "0x17ADA94", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x17AE558", Offset = "0x17AE558", VA = "0x17AE558", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x17AE55C", Offset = "0x17AE55C", VA = "0x17AE55C", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x17AE560", Offset = "0x17AE560", VA = "0x17AE560", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x17AE1A0", Offset = "0x17AE1A0", VA = "0x17AE1A0")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x17A9B7C", Offset = "0x17A9B7C", VA = "0x17A9B7C")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008B")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000ED")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x200011B")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x40007F0")]
				YawPitch,
				[Token(Token = "0x40007F1")]
				FromTo
			}

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C614", Offset = "0xB2C614")]
			public Transform target;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C64C", Offset = "0xB2C64C")]
			public Transform bendGoal;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C684", Offset = "0xB2C684")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2C684", Offset = "0xB2C684")]
			public float positionWeight;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C6D8", Offset = "0xB2C6D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2C6D8", Offset = "0xB2C6D8")]
			public float rotationWeight;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C72C", Offset = "0xB2C72C")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C764", Offset = "0xB2C764")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2C764", Offset = "0xB2C764")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C7B8", Offset = "0xB2C7B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2C7B8", Offset = "0xB2C7B8")]
			public float bendGoalWeight;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C80C", Offset = "0xB2C80C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2C80C", Offset = "0xB2C80C")]
			public float swivelOffset;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C868", Offset = "0xB2C868")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C8A0", Offset = "0xB2C8A0")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C8D8", Offset = "0xB2C8D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2C8D8", Offset = "0xB2C8D8")]
			public float armLengthMlp;

			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C930", Offset = "0xB2C930")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C9A8", Offset = "0xB2C9A8")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C9B8", Offset = "0xB2C9B8")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x40006AC")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x40006AD")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170000D2")]
			public Vector3 position
			{
				[Token(Token = "0x600072F")]
				[Address(RVA = "0x17B6B78", Offset = "0x17B6B78", VA = "0x17B6B78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB314F0", Offset = "0xB314F0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000730")]
				[Address(RVA = "0x17B6B84", Offset = "0x17B6B84", VA = "0x17B6B84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31500", Offset = "0xB31500")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D3")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000731")]
				[Address(RVA = "0x17B6B90", Offset = "0x17B6B90", VA = "0x17B6B90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31510", Offset = "0xB31510")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000732")]
				[Address(RVA = "0x17B6B9C", Offset = "0x17B6B9C", VA = "0x17B6B9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31520", Offset = "0xB31520")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D4")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000733")]
				[Address(RVA = "0x17B6BA8", Offset = "0x17B6BA8", VA = "0x17B6BA8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D5")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000734")]
				[Address(RVA = "0x17B6BDC", Offset = "0x17B6BDC", VA = "0x17B6BDC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D6")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000735")]
				[Address(RVA = "0x17B6C14", Offset = "0x17B6C14", VA = "0x17B6C14")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D7")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000736")]
				[Address(RVA = "0x17B6C4C", Offset = "0x17B6C4C", VA = "0x17B6C4C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x17B6C84", Offset = "0x17B6C84", VA = "0x17B6C84", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000738")]
			[Address(RVA = "0x17B73EC", Offset = "0x17B73EC", VA = "0x17B73EC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000739")]
			[Address(RVA = "0x17B75E0", Offset = "0x17B75E0", VA = "0x17B75E0", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0x17B768C", Offset = "0x17B768C", VA = "0x17B768C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0x17B4C88", Offset = "0x17B4C88", VA = "0x17B4C88")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x600073C")]
			[Address(RVA = "0x17B8AB4", Offset = "0x17B8AB4", VA = "0x17B8AB4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0x17B8B24", Offset = "0x17B8B24", VA = "0x17B8B24", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600073E")]
			[Address(RVA = "0x17B7AA4", Offset = "0x17B7AA4", VA = "0x17B7AA4")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600073F")]
			[Address(RVA = "0x17B7DB0", Offset = "0x17B7DB0", VA = "0x17B7DB0")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0x17B8D44", Offset = "0x17B8D44", VA = "0x17B8D44")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x17B68E0", Offset = "0x17B68E0", VA = "0x17B68E0")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EE")]
		public abstract class BodyPart
		{
			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C9C8", Offset = "0xB2C9C8")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C9D8", Offset = "0xB2C9D8")]
			private float <mag>k__BackingField;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x170000D8")]
			public float sqrMag
			{
				[Token(Token = "0x6000747")]
				[Address(RVA = "0x17B8F04", Offset = "0x17B8F04", VA = "0x17B8F04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31530", Offset = "0xB31530")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000748")]
				[Address(RVA = "0x17B8F0C", Offset = "0x17B8F0C", VA = "0x17B8F0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31540", Offset = "0xB31540")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D9")]
			public float mag
			{
				[Token(Token = "0x6000749")]
				[Address(RVA = "0x17B8F14", Offset = "0x17B8F14", VA = "0x17B8F14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31550", Offset = "0xB31550")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600074A")]
				[Address(RVA = "0x17B8F1C", Offset = "0x17B8F1C", VA = "0x17B8F1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31560", Offset = "0xB31560")]
				private set
				{
				}
			}

			[Token(Token = "0x6000742")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index);

			[Token(Token = "0x6000743")]
			public abstract void PreSolve();

			[Token(Token = "0x6000744")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000745")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x6000746")]
			public abstract void ResetOffsets();

			[Token(Token = "0x600074B")]
			[Address(RVA = "0x17B2744", Offset = "0x17B2744", VA = "0x17B2744")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0x17B9210", Offset = "0x17B9210", VA = "0x17B9210")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x600074D")]
			[Address(RVA = "0x17B937C", Offset = "0x17B937C", VA = "0x17B937C")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0x17B960C", Offset = "0x17B960C", VA = "0x17B960C")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0x17B470C", Offset = "0x17B470C", VA = "0x17B470C")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000750")]
			[Address(RVA = "0x17B8914", Offset = "0x17B8914", VA = "0x17B8914")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0x17B9660", Offset = "0x17B9660", VA = "0x17B9660")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000752")]
			[Address(RVA = "0x17B97A4", Offset = "0x17B97A4", VA = "0x17B97A4")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000753")]
			[Address(RVA = "0x17B8E6C", Offset = "0x17B8E6C", VA = "0x17B8E6C")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EF")]
		public class Footstep
		{
			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C9F8", Offset = "0xB2C9F8")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x170000DA")]
			public bool isStepping
			{
				[Token(Token = "0x6000754")]
				[Address(RVA = "0x17B97CC", Offset = "0x17B97CC", VA = "0x17B97CC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000DB")]
			public float stepProgress
			{
				[Token(Token = "0x6000755")]
				[Address(RVA = "0x17B97E0", Offset = "0x17B97E0", VA = "0x17B97E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31570", Offset = "0xB31570")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000756")]
				[Address(RVA = "0x17B97E8", Offset = "0x17B97E8", VA = "0x17B97E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31580", Offset = "0xB31580")]
				private set
				{
				}
			}

			[Token(Token = "0x6000757")]
			[Address(RVA = "0x17B97F0", Offset = "0x17B97F0", VA = "0x17B97F0")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0x17B9920", Offset = "0x17B9920", VA = "0x17B9920")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x17B9A50", Offset = "0x17B9A50", VA = "0x17B9A50")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x17B9B50", Offset = "0x17B9B50", VA = "0x17B9B50")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x17B9D28", Offset = "0x17B9D28", VA = "0x17B9D28")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x17B9F14", Offset = "0x17B9F14", VA = "0x17B9F14")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F0")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CA08", Offset = "0xB2CA08")]
			public Transform target;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CA40", Offset = "0xB2CA40")]
			public Transform bendGoal;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CA78", Offset = "0xB2CA78")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2CA78", Offset = "0xB2CA78")]
			public float positionWeight;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CACC", Offset = "0xB2CACC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2CACC", Offset = "0xB2CACC")]
			public float rotationWeight;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CB20", Offset = "0xB2CB20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2CB20", Offset = "0xB2CB20")]
			public float bendGoalWeight;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CB74", Offset = "0xB2CB74")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2CB74", Offset = "0xB2CB74")]
			public float swivelOffset;

			[NonSerialized]
			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2CC30", Offset = "0xB2CC30")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2CC40", Offset = "0xB2CC40")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2CC50", Offset = "0xB2CC50")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2CC60", Offset = "0xB2CC60")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Vector3 footPosition;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Quaternion footRotation;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 bendNormal;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x170000DC")]
			public Vector3 position
			{
				[Token(Token = "0x600075D")]
				[Address(RVA = "0x17BA130", Offset = "0x17BA130", VA = "0x17BA130")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31590", Offset = "0xB31590")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600075E")]
				[Address(RVA = "0x17BA13C", Offset = "0x17BA13C", VA = "0x17BA13C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB315A0", Offset = "0xB315A0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DD")]
			public Quaternion rotation
			{
				[Token(Token = "0x600075F")]
				[Address(RVA = "0x17BA148", Offset = "0x17BA148", VA = "0x17BA148")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB315B0", Offset = "0xB315B0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000760")]
				[Address(RVA = "0x17BA154", Offset = "0x17BA154", VA = "0x17BA154")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB315C0", Offset = "0xB315C0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DE")]
			public bool hasToes
			{
				[Token(Token = "0x6000761")]
				[Address(RVA = "0x17BA160", Offset = "0x17BA160", VA = "0x17BA160")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB315D0", Offset = "0xB315D0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000762")]
				[Address(RVA = "0x17BA168", Offset = "0x17BA168", VA = "0x17BA168")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB315E0", Offset = "0xB315E0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DF")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000763")]
				[Address(RVA = "0x17BA174", Offset = "0x17BA174", VA = "0x17BA174")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E0")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000764")]
				[Address(RVA = "0x17BA1A8", Offset = "0x17BA1A8", VA = "0x17BA1A8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E1")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000765")]
				[Address(RVA = "0x17BA1E0", Offset = "0x17BA1E0", VA = "0x17BA1E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E2")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000766")]
				[Address(RVA = "0x17BA218", Offset = "0x17BA218", VA = "0x17BA218")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E3")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000767")]
				[Address(RVA = "0x17B454C", Offset = "0x17B454C", VA = "0x17B454C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E4")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000768")]
				[Address(RVA = "0x17BA250", Offset = "0x17BA250", VA = "0x17BA250")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB315F0", Offset = "0xB315F0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000769")]
				[Address(RVA = "0x17BA25C", Offset = "0x17BA25C", VA = "0x17BA25C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31600", Offset = "0xB31600")]
				private set
				{
				}
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0x17BA268", Offset = "0x17BA268", VA = "0x17BA268", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x17BA710", Offset = "0x17BA710", VA = "0x17BA710", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0x17BADF0", Offset = "0x17BADF0", VA = "0x17BADF0", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600076D")]
			[Address(RVA = "0x17BACEC", Offset = "0x17BACEC", VA = "0x17BACEC")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0x17BAAC4", Offset = "0x17BAAC4", VA = "0x17BAAC4")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x600076F")]
			[Address(RVA = "0x17B48F8", Offset = "0x17B48F8", VA = "0x17B48F8")]
			public void Solve()
			{
			}

			[Token(Token = "0x6000770")]
			[Address(RVA = "0x17BB394", Offset = "0x17BB394", VA = "0x17BB394", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0x17BB49C", Offset = "0x17BB49C", VA = "0x17BB49C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x17B69E8", Offset = "0x17B69E8", VA = "0x17B69E8")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F1")]
		public class Locomotion
		{
			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CC70", Offset = "0xB2CC70")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2CC70", Offset = "0xB2CC70")]
			public float weight;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CCC4", Offset = "0xB2CCC4")]
			public float footDistance;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CCFC", Offset = "0xB2CCFC")]
			public float stepThreshold;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CD34", Offset = "0xB2CD34")]
			public float angleThreshold;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CD6C", Offset = "0xB2CD6C")]
			public float comAngleMlp;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CDA4", Offset = "0xB2CDA4")]
			public float maxVelocity;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CDDC", Offset = "0xB2CDDC")]
			public float velocityFactor;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CE14", Offset = "0xB2CE14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2CE14", Offset = "0xB2CE14")]
			public float maxLegStretch;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CE6C", Offset = "0xB2CE6C")]
			public float rootSpeed;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CEA4", Offset = "0xB2CEA4")]
			public float stepSpeed;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CEDC", Offset = "0xB2CEDC")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CF14", Offset = "0xB2CF14")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CF4C", Offset = "0xB2CF4C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2CF4C", Offset = "0xB2CF4C")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CFA4", Offset = "0xB2CFA4")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2CFDC", Offset = "0xB2CFDC")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D014", Offset = "0xB2D014")]
			public Vector3 offset;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D08C", Offset = "0xB2D08C")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D0C4", Offset = "0xB2D0C4")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2D0FC", Offset = "0xB2D0FC")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x170000E5")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000773")]
				[Address(RVA = "0x17BB54C", Offset = "0x17BB54C", VA = "0x17BB54C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31610", Offset = "0xB31610")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000774")]
				[Address(RVA = "0x17BB558", Offset = "0x17BB558", VA = "0x17BB558")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31620", Offset = "0xB31620")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E6")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x600077A")]
				[Address(RVA = "0x17BB998", Offset = "0x17BB998", VA = "0x17BB998")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E7")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x600077B")]
				[Address(RVA = "0x17BB9D8", Offset = "0x17BB9D8", VA = "0x17BB9D8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E8")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x600077C")]
				[Address(RVA = "0x17BBA1C", Offset = "0x17BBA1C", VA = "0x17BBA1C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000E9")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x600077D")]
				[Address(RVA = "0x17BBA5C", Offset = "0x17BBA5C", VA = "0x17BBA5C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000775")]
			[Address(RVA = "0x17B2808", Offset = "0x17B2808", VA = "0x17B2808")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x17B072C", Offset = "0x17B072C", VA = "0x17B072C")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0x17AFB8C", Offset = "0x17AFB8C", VA = "0x17AFB8C")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0x17AF9DC", Offset = "0x17AF9DC", VA = "0x17AF9DC")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0x17B308C", Offset = "0x17B308C", VA = "0x17B308C")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x600077E")]
			[Address(RVA = "0x17BB5A4", Offset = "0x17BB5A4", VA = "0x17BB5A4")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600077F")]
			[Address(RVA = "0x17BB748", Offset = "0x17BB748", VA = "0x17BB748")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000780")]
			[Address(RVA = "0x17BB7CC", Offset = "0x17BB7CC", VA = "0x17BB7CC")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000781")]
			[Address(RVA = "0x17B6A94", Offset = "0x17B6A94", VA = "0x17B6A94")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F2")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D10C", Offset = "0xB2D10C")]
			public Transform headTarget;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D144", Offset = "0xB2D144")]
			public Transform pelvisTarget;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D17C", Offset = "0xB2D17C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2D17C", Offset = "0xB2D17C")]
			public float positionWeight;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D1D0", Offset = "0xB2D1D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2D1D0", Offset = "0xB2D1D0")]
			public float rotationWeight;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D224", Offset = "0xB2D224")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2D224", Offset = "0xB2D224")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D278", Offset = "0xB2D278")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2D278", Offset = "0xB2D278")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D2CC", Offset = "0xB2D2CC")]
			public Transform chestGoal;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D304", Offset = "0xB2D304")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2D304", Offset = "0xB2D304")]
			public float chestGoalWeight;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D358", Offset = "0xB2D358")]
			public float minHeadHeight;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D390", Offset = "0xB2D390")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2D390", Offset = "0xB2D390")]
			public float bodyPosStiffness;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D3E4", Offset = "0xB2D3E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2D3E4", Offset = "0xB2D3E4")]
			public float bodyRotStiffness;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D438", Offset = "0xB2D438")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB2D438", Offset = "0xB2D438")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2D438", Offset = "0xB2D438")]
			public float neckStiffness;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D4B0", Offset = "0xB2D4B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2D4B0", Offset = "0xB2D4B0")]
			public float rotateChestByHands;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D504", Offset = "0xB2D504")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2D504", Offset = "0xB2D504")]
			public float chestClampWeight;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D558", Offset = "0xB2D558")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2D558", Offset = "0xB2D558")]
			public float headClampWeight;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D5AC", Offset = "0xB2D5AC")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D5E4", Offset = "0xB2D5E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2D5E4", Offset = "0xB2D5E4")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D638", Offset = "0xB2D638")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2D638", Offset = "0xB2D638")]
			public float maxRootAngle;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public bool useFabrikPass;

			[NonSerialized]
			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2D770", Offset = "0xB2D770")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			private Quaternion headRotation;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private int pelvisIndex;

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
			private int spineIndex;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private int chestIndex;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private int neckIndex;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private int headIndex;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
			private float length;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private bool hasChest;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F1")]
			private bool hasNeck;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private float headHeight;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private float sizeMlp;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private Vector3 chestForward;

			[Token(Token = "0x170000EA")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000782")]
				[Address(RVA = "0x17B09A0", Offset = "0x17B09A0", VA = "0x17B09A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EB")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000783")]
				[Address(RVA = "0x17BBAA0", Offset = "0x17BBAA0", VA = "0x17BBAA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EC")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000784")]
				[Address(RVA = "0x17B4C34", Offset = "0x17B4C34", VA = "0x17B4C34")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000ED")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000785")]
				[Address(RVA = "0x17BBAE0", Offset = "0x17BBAE0", VA = "0x17BBAE0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EE")]
			public VirtualBone head
			{
				[Token(Token = "0x6000786")]
				[Address(RVA = "0x17BB564", Offset = "0x17BB564", VA = "0x17BB564")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EF")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000787")]
				[Address(RVA = "0x17BBB20", Offset = "0x17BBB20", VA = "0x17BBB20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31630", Offset = "0xB31630")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000788")]
				[Address(RVA = "0x17BBB34", Offset = "0x17BBB34", VA = "0x17BBB34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31640", Offset = "0xB31640")]
				private set
				{
				}
			}

			[Token(Token = "0x6000789")]
			[Address(RVA = "0x17BBB48", Offset = "0x17BBB48", VA = "0x17BBB48", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600078A")]
			[Address(RVA = "0x17BC5A4", Offset = "0x17BC5A4", VA = "0x17BC5A4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600078B")]
			[Address(RVA = "0x17BC778", Offset = "0x17BC778", VA = "0x17BC778", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600078C")]
			[Address(RVA = "0x17BCC9C", Offset = "0x17BCC9C", VA = "0x17BCC9C")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600078D")]
			[Address(RVA = "0x17B2B00", Offset = "0x17B2B00", VA = "0x17B2B00")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0x17BD658", Offset = "0x17BD658", VA = "0x17BD658")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x600078F")]
			[Address(RVA = "0x17BDD00", Offset = "0x17BDD00", VA = "0x17BDD00")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x17BE4E0", Offset = "0x17BE4E0", VA = "0x17BE4E0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000791")]
			[Address(RVA = "0x17BE6BC", Offset = "0x17BE6BC", VA = "0x17BE6BC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x17BCECC", Offset = "0x17BCECC", VA = "0x17BCECC")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0x17B458C", Offset = "0x17B458C", VA = "0x17B458C")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x17BD250", Offset = "0x17BD250", VA = "0x17BD250")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0x17BE7B8", Offset = "0x17BE7B8", VA = "0x17BE7B8")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0x17BDAB4", Offset = "0x17BDAB4", VA = "0x17BDAB4")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0x17BD84C", Offset = "0x17BD84C", VA = "0x17BD84C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000798")]
			[Address(RVA = "0x17B673C", Offset = "0x17B673C", VA = "0x17B673C")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F3")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000728")]
			Pelvis,
			[Token(Token = "0x4000729")]
			Chest,
			[Token(Token = "0x400072A")]
			Head,
			[Token(Token = "0x400072B")]
			LeftHand,
			[Token(Token = "0x400072C")]
			RightHand,
			[Token(Token = "0x400072D")]
			LeftFoot,
			[Token(Token = "0x400072E")]
			RightFoot,
			[Token(Token = "0x400072F")]
			LeftHeel,
			[Token(Token = "0x4000730")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000F4")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000732")]
			Pelvis,
			[Token(Token = "0x4000733")]
			Chest,
			[Token(Token = "0x4000734")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000F5")]
		public class VirtualBone
		{
			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x17B26A8", Offset = "0x17B26A8", VA = "0x17B26A8")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x17B2724", Offset = "0x17B2724", VA = "0x17B2724")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x17BEAD8", Offset = "0x17BEAD8", VA = "0x17BEAD8")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x17B8F24", Offset = "0x17B8F24", VA = "0x17B8F24")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0x17B9424", Offset = "0x17B9424", VA = "0x17B9424")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600079E")]
			[Address(RVA = "0x17BED68", Offset = "0x17BED68", VA = "0x17BED68")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0x17B7B7C", Offset = "0x17B7B7C", VA = "0x17B7B7C")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x17BEFA0", Offset = "0x17BEFA0", VA = "0x17BEFA0")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x17B8368", Offset = "0x17B8368", VA = "0x17B8368")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x17BF058", Offset = "0x17BF058", VA = "0x17BF058")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x17BE0A0", Offset = "0x17BE0A0", VA = "0x17BE0A0")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x17BF270", Offset = "0x17BF270", VA = "0x17BF270")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x17BF378", Offset = "0x17BF378", VA = "0x17BF378")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29854", Offset = "0xB29854")]
		public bool plantFeet;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2988C", Offset = "0xB2988C")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2989C", Offset = "0xB2989C")]
		public Spine spine;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB298D4", Offset = "0xB298D4")]
		public Arm leftArm;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2990C", Offset = "0xB2990C")]
		public Arm rightArm;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29944", Offset = "0xB29944")]
		public Leg leftLeg;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2997C", Offset = "0xB2997C")]
		public Leg rightLeg;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB299B4", Offset = "0xB299B4")]
		public Locomotion locomotion;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Leg[] legs;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Arm[] arms;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 headPosition;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastOffset;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 debugPos1;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 debugPos2;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos3;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000051")]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x17B6584", Offset = "0x17B6584", VA = "0x17B6584")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30358", Offset = "0xB30358")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x17B658C", Offset = "0x17B658C", VA = "0x17B658C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30368", Offset = "0xB30368")]
			private set
			{
			}
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x17AE56C", Offset = "0x17AE56C", VA = "0x17AE56C")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x17AE960", Offset = "0x17AE960", VA = "0x17AE960")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x17AE808", Offset = "0x17AE808", VA = "0x17AE808")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x17AF344", Offset = "0x17AF344", VA = "0x17AF344")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x17AF620", Offset = "0x17AF620", VA = "0x17AF620")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x17AF6C4", Offset = "0x17AF6C4", VA = "0x17AF6C4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x17AF858", Offset = "0x17AF858", VA = "0x17AF858")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x17AFF64", Offset = "0x17AFF64", VA = "0x17AFF64")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x17B09E0", Offset = "0x17B09E0", VA = "0x17B09E0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x17B0B54", Offset = "0x17B0B54", VA = "0x17B0B54", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x17B0CF0", Offset = "0x17B0CF0", VA = "0x17B0CF0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x17B0D64", Offset = "0x17B0D64", VA = "0x17B0D64", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x17B0DD8", Offset = "0x17B0DD8", VA = "0x17B0DD8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x17B0FEC", Offset = "0x17B0FEC", VA = "0x17B0FEC")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x17AEBF8", Offset = "0x17AEBF8", VA = "0x17AEBF8")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x17AEDD0", Offset = "0x17AEDD0", VA = "0x17AEDD0")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x17AF220", Offset = "0x17AF220", VA = "0x17AF220")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x17B00C0", Offset = "0x17B00C0", VA = "0x17B00C0")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x17B12CC", Offset = "0x17B12CC", VA = "0x17B12CC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x17B1304", Offset = "0x17B1304", VA = "0x17B1304", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x17B2434", Offset = "0x17B2434", VA = "0x17B2434")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x17B0228", Offset = "0x17B0228", VA = "0x17B0228")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x17B1364", Offset = "0x17B1364", VA = "0x17B1364")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x17B261C", Offset = "0x17B261C", VA = "0x17B261C")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x17B2664", Offset = "0x17B2664", VA = "0x17B2664")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x17B22EC", Offset = "0x17B22EC", VA = "0x17B22EC")]
		private void Write()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x17B5F9C", Offset = "0x17B5F9C", VA = "0x17B5F9C")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x17B6594", Offset = "0x17B6594", VA = "0x17B6594")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB299EC", Offset = "0xB299EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB299EC", Offset = "0xB299EC")]
		public float weight;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29A40", Offset = "0xB29A40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB29A40", Offset = "0xB29A40")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29A94", Offset = "0xB29A94")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB29A94", Offset = "0xB29A94")]
		public float twistAngleOffset;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 axis;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform parent;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform child;

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x14ECB60", Offset = "0x14ECB60", VA = "0x14ECB60")]
		public void Relax()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x14ECF40", Offset = "0x14ECF40", VA = "0x14ECF40")]
		private void Start()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x14ED35C", Offset = "0x14ED35C", VA = "0x14ED35C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x14ED3E4", Offset = "0x14ED3E4", VA = "0x14ED3E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x14ED46C", Offset = "0x14ED46C", VA = "0x14ED46C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x14ED570", Offset = "0x14ED570", VA = "0x14ED570")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008D")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB29AF0", Offset = "0xB29AF0")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB29B00", Offset = "0xB29B00")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB29B10", Offset = "0xB29B10")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x17000052")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x17BFBA0", Offset = "0x17BFBA0", VA = "0x17BFBA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30378", Offset = "0xB30378")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x17BFBA8", Offset = "0x17BFBA8", VA = "0x17BFBA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30388", Offset = "0xB30388")]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public bool isPaused
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x17BFBB0", Offset = "0x17BFBB0", VA = "0x17BFBB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30398", Offset = "0xB30398")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x17BFBB8", Offset = "0x17BFBB8", VA = "0x17BFBB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB303A8", Offset = "0xB303A8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x17BFBC4", Offset = "0x17BFBC4", VA = "0x17BFBC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB303B8", Offset = "0xB303B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x17BFBCC", Offset = "0x17BFBCC", VA = "0x17BFBCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB303C8", Offset = "0xB303C8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public bool inInteraction
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x17BFBD4", Offset = "0x17BFBD4", VA = "0x17BFBD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		public float progress
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x17C14FC", Offset = "0x17C14FC", VA = "0x17C14FC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x17BFC44", Offset = "0x17BFC44", VA = "0x17BFC44")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x17BFCC8", Offset = "0x17BFCC8", VA = "0x17BFCC8")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x17BFD6C", Offset = "0x17BFD6C", VA = "0x17BFD6C")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x17BFEAC", Offset = "0x17BFEAC", VA = "0x17BFEAC")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x17C02B0", Offset = "0x17C02B0", VA = "0x17C02B0")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x17C03E4", Offset = "0x17C03E4", VA = "0x17C03E4")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x17C043C", Offset = "0x17C043C", VA = "0x17C043C")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x17C0884", Offset = "0x17C0884", VA = "0x17C0884")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x17C0F58", Offset = "0x17C0F58", VA = "0x17C0F58")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x17C1188", Offset = "0x17C1188", VA = "0x17C1188")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x17C13A0", Offset = "0x17C13A0", VA = "0x17C13A0")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x17C1538", Offset = "0x17C1538", VA = "0x17C1538")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008E")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29B20", Offset = "0xB29B20")]
		public LookAtIK ik;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29B58", Offset = "0xB29B58")]
		public float lerpSpeed;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29B90", Offset = "0xB29B90")]
		public float weightSpeed;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x14DC2C8", Offset = "0x14DC2C8", VA = "0x14DC2C8")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x14DC440", Offset = "0x14DC440", VA = "0x14DC440")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x14DC4E8", Offset = "0x14DC4E8", VA = "0x14DC4E8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x14DCAC4", Offset = "0x14DCAC4", VA = "0x14DCAC4")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x14DCBBC", Offset = "0x14DCBBC", VA = "0x14DCBBC")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x14DCC88", Offset = "0x14DCC88", VA = "0x14DCC88")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB265FC", Offset = "0xB265FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB265FC", Offset = "0xB265FC")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F6")]
		public class InteractionEvent
		{
			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D780", Offset = "0xB2D780")]
			public float time;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D7B8", Offset = "0xB2D7B8")]
			public bool pause;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D7F0", Offset = "0xB2D7F0")]
			public bool pickUp;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D828", Offset = "0xB2D828")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D860", Offset = "0xB2D860")]
			public Message[] messages;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D898", Offset = "0xB2D898")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x14DE70C", Offset = "0x14DE70C", VA = "0x14DE70C")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x14DE8CC", Offset = "0x14DE8CC", VA = "0x14DE8CC")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F7")]
		public class Message
		{
			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D8D0", Offset = "0xB2D8D0")]
			public string function;

			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D908", Offset = "0xB2D908")]
			public GameObject recipient;

			[Token(Token = "0x4000744")]
			private const string empty = "";

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x14DE7DC", Offset = "0x14DE7DC", VA = "0x14DE7DC")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x14DE8D4", Offset = "0x14DE8D4", VA = "0x14DE8D4")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F8")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D940", Offset = "0xB2D940")]
			public Animator animator;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D978", Offset = "0xB2D978")]
			public Animation animation;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D9B0", Offset = "0xB2D9B0")]
			public string animationState;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2D9E8", Offset = "0xB2D9E8")]
			public float crossfadeTime;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DA20", Offset = "0xB2DA20")]
			public int layer;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DA58", Offset = "0xB2DA58")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400074B")]
			private const string empty = "";

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x14DE46C", Offset = "0x14DE46C", VA = "0x14DE46C")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x14DE560", Offset = "0x14DE560", VA = "0x14DE560")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x14DE618", Offset = "0x14DE618", VA = "0x14DE618")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x14DE6F8", Offset = "0x14DE6F8", VA = "0x14DE6F8")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F9")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x200011C")]
			public enum Type
			{
				[Token(Token = "0x40007F3")]
				PositionWeight,
				[Token(Token = "0x40007F4")]
				RotationWeight,
				[Token(Token = "0x40007F5")]
				PositionOffsetX,
				[Token(Token = "0x40007F6")]
				PositionOffsetY,
				[Token(Token = "0x40007F7")]
				PositionOffsetZ,
				[Token(Token = "0x40007F8")]
				Pull,
				[Token(Token = "0x40007F9")]
				Reach,
				[Token(Token = "0x40007FA")]
				RotateBoneWeight,
				[Token(Token = "0x40007FB")]
				Push,
				[Token(Token = "0x40007FC")]
				PushParent,
				[Token(Token = "0x40007FD")]
				PoserWeight
			}

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DA90", Offset = "0xB2DA90")]
			public Type type;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DAC8", Offset = "0xB2DAC8")]
			public AnimationCurve curve;

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x14DDA40", Offset = "0x14DDA40", VA = "0x14DDA40")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x14DE8EC", Offset = "0x14DE8EC", VA = "0x14DE8EC")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FA")]
		public class Multiplier
		{
			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DB00", Offset = "0xB2DB00")]
			public WeightCurve.Type curve;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DB38", Offset = "0xB2DB38")]
			public float multiplier;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DB70", Offset = "0xB2DB70")]
			public WeightCurve.Type result;

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x14DE0A4", Offset = "0x14DE0A4", VA = "0x14DE0A4")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x14DE8DC", Offset = "0x14DE8DC", VA = "0x14DE8DC")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29BD8", Offset = "0xB29BD8")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29C10", Offset = "0xB29C10")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29C48", Offset = "0xB29C48")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB29C80", Offset = "0xB29C80")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB29C90", Offset = "0xB29C90")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000057")]
		public float length
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x14DCE64", Offset = "0x14DCE64", VA = "0x14DCE64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30528", Offset = "0xB30528")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x14DCE6C", Offset = "0x14DCE6C", VA = "0x14DCE6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30538", Offset = "0xB30538")]
			private set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x14DCE74", Offset = "0x14DCE74", VA = "0x14DCE74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30548", Offset = "0xB30548")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x14DCE7C", Offset = "0x14DCE7C", VA = "0x14DCE7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30558", Offset = "0xB30558")]
			private set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x14DD128", Offset = "0x14DD128", VA = "0x14DD128")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public Transform targetsRoot
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x14DD098", Offset = "0x14DD098", VA = "0x14DD098")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x14DCC9C", Offset = "0x14DCC9C", VA = "0x14DCC9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB303D8", Offset = "0xB303D8")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x14DCCE8", Offset = "0x14DCCE8", VA = "0x14DCCE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30410", Offset = "0xB30410")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x14DCD34", Offset = "0x14DCD34", VA = "0x14DCD34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30448", Offset = "0xB30448")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x14DCD80", Offset = "0x14DCD80", VA = "0x14DCD80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30480", Offset = "0xB30480")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x14DCDCC", Offset = "0x14DCDCC", VA = "0x14DCDCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB304B8", Offset = "0xB304B8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x14DCE18", Offset = "0x14DCE18", VA = "0x14DCE18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB304F0", Offset = "0xB304F0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x14DCE84", Offset = "0x14DCE84", VA = "0x14DCE84")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x14DD1B8", Offset = "0x14DD1B8", VA = "0x14DD1B8")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x14DD33C", Offset = "0x14DD33C", VA = "0x14DD33C")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x14DD3F0", Offset = "0x14DD3F0", VA = "0x14DD3F0")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x14DD3F8", Offset = "0x14DD3F8", VA = "0x14DD3F8")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x14DD5AC", Offset = "0x14DD5AC", VA = "0x14DD5AC")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x14DD5B4", Offset = "0x14DD5B4", VA = "0x14DD5B4")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x14DE0E0", Offset = "0x14DE0E0", VA = "0x14DE0E0")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x14DE308", Offset = "0x14DE308", VA = "0x14DE308")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x14DDA5C", Offset = "0x14DDA5C", VA = "0x14DDA5C")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x14DD53C", Offset = "0x14DD53C", VA = "0x14DD53C")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x14DE03C", Offset = "0x14DE03C", VA = "0x14DE03C")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x14DE30C", Offset = "0x14DE30C", VA = "0x14DE30C")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x14DE374", Offset = "0x14DE374", VA = "0x14DE374")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30568", Offset = "0xB30568")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x14DE3C0", Offset = "0x14DE3C0", VA = "0x14DE3C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB305A0", Offset = "0xB305A0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x14DE40C", Offset = "0x14DE40C", VA = "0x14DE40C")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB2665C", Offset = "0xB2665C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB2665C", Offset = "0xB2665C")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000FB")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000FC")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29CA0", Offset = "0xB29CA0")]
		public string targetTag;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29CD8", Offset = "0xB29CD8")]
		public float fadeInTime;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29D10", Offset = "0xB29D10")]
		public float speed;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29D48", Offset = "0xB29D48")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB29D80", Offset = "0xB29D80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29D80", Offset = "0xB29D80")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB29D80", Offset = "0xB29D80")]
		public Collider characterCollider;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29E04", Offset = "0xB29E04")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB29E04", Offset = "0xB29E04")]
		public Transform FPSCamera;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29E64", Offset = "0xB29E64")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29E9C", Offset = "0xB29E9C")]
		public float camRaycastDistance;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB29ED4", Offset = "0xB29ED4")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xB29EE4", Offset = "0xB29EE4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29EE4", Offset = "0xB29EE4")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29F44", Offset = "0xB29F44")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x1700005B")]
		public bool inInteraction
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x14DEABC", Offset = "0x14DEABC", VA = "0x14DEABC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x14E06CC", Offset = "0x14E06CC", VA = "0x14E06CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x14E06D4", Offset = "0x14E06D4", VA = "0x14E06D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x14E06DC", Offset = "0x14E06DC", VA = "0x14E06DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30728", Offset = "0xB30728")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x14E06E4", Offset = "0x14E06E4", VA = "0x14E06E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30738", Offset = "0xB30738")]
			private set
			{
			}
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x14DE8F4", Offset = "0x14DE8F4", VA = "0x14DE8F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB305D8", Offset = "0xB305D8")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x14DE940", Offset = "0x14DE940", VA = "0x14DE940")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30610", Offset = "0xB30610")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x14DE98C", Offset = "0x14DE98C", VA = "0x14DE98C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30648", Offset = "0xB30648")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x14DE9D8", Offset = "0x14DE9D8", VA = "0x14DE9D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30680", Offset = "0xB30680")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x14DEA24", Offset = "0x14DEA24", VA = "0x14DEA24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB306B8", Offset = "0xB306B8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x14DEA70", Offset = "0x14DEA70", VA = "0x14DEA70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB306F0", Offset = "0xB306F0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x14DEC50", Offset = "0x14DEC50", VA = "0x14DEC50")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x14DED20", Offset = "0x14DED20", VA = "0x14DED20")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x14DEDF0", Offset = "0x14DEDF0", VA = "0x14DEDF0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x14DEEA0", Offset = "0x14DEEA0", VA = "0x14DEEA0")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x14DEF9C", Offset = "0x14DEF9C", VA = "0x14DEF9C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x14DF0BC", Offset = "0x14DF0BC", VA = "0x14DF0BC")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x14DF150", Offset = "0x14DF150", VA = "0x14DF150")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x14DF1E4", Offset = "0x14DF1E4", VA = "0x14DF1E4")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x14DF278", Offset = "0x14DF278", VA = "0x14DF278")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x14DF2F0", Offset = "0x14DF2F0", VA = "0x14DF2F0")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x14DF368", Offset = "0x14DF368", VA = "0x14DF368")]
		public void StopAll()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x14DF3D4", Offset = "0x14DF3D4", VA = "0x14DF3D4")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x14DF460", Offset = "0x14DF460", VA = "0x14DF460")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x14DF4F4", Offset = "0x14DF4F4", VA = "0x14DF4F4")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x14DF5C0", Offset = "0x14DF5C0", VA = "0x14DF5C0")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x14DF864", Offset = "0x14DF864", VA = "0x14DF864")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x14DFA3C", Offset = "0x14DFA3C", VA = "0x14DFA3C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x14DFCB0", Offset = "0x14DFCB0", VA = "0x14DFCB0")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x14DFFA4", Offset = "0x14DFFA4", VA = "0x14DFFA4")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x14DFFE8", Offset = "0x14DFFE8", VA = "0x14DFFE8")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x14E0060", Offset = "0x14E0060", VA = "0x14E0060")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x14E0180", Offset = "0x14E0180", VA = "0x14E0180")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x14E02F8", Offset = "0x14E02F8", VA = "0x14E02F8")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x14E05A0", Offset = "0x14E05A0", VA = "0x14E05A0")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x14DFDB0", Offset = "0x14DFDB0", VA = "0x14DFDB0")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x14E06EC", Offset = "0x14E06EC", VA = "0x14E06EC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x14E0DA4", Offset = "0x14E0DA4", VA = "0x14E0DA4")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x14E0DC4", Offset = "0x14E0DC4", VA = "0x14E0DC4")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x14E0DE0", Offset = "0x14E0DE0", VA = "0x14E0DE0")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x14E0DFC", Offset = "0x14E0DFC", VA = "0x14E0DFC")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x14E0E5C", Offset = "0x14E0E5C", VA = "0x14E0E5C")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x14E0F78", Offset = "0x14E0F78", VA = "0x14E0F78")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x14E1074", Offset = "0x14E1074", VA = "0x14E1074")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x14E13D4", Offset = "0x14E13D4", VA = "0x14E13D4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x14E14C0", Offset = "0x14E14C0", VA = "0x14E14C0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x14E170C", Offset = "0x14E170C", VA = "0x14E170C")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x14E0B1C", Offset = "0x14E0B1C", VA = "0x14E0B1C")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x14E184C", Offset = "0x14E184C", VA = "0x14E184C")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x14E1980", Offset = "0x14E1980", VA = "0x14E1980")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x14E1A3C", Offset = "0x14E1A3C", VA = "0x14E1A3C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x14E1B3C", Offset = "0x14E1B3C", VA = "0x14E1B3C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x14E1B54", Offset = "0x14E1B54", VA = "0x14E1B54")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x14DEB6C", Offset = "0x14DEB6C", VA = "0x14DEB6C")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x14DF760", Offset = "0x14DF760", VA = "0x14DF760")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x14E1E44", Offset = "0x14E1E44", VA = "0x14E1E44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30748", Offset = "0xB30748")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x14E1E90", Offset = "0x14E1E90", VA = "0x14E1E90")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30780", Offset = "0xB30780")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x14E1EDC", Offset = "0x14E1EDC", VA = "0x14E1EDC")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB266BC", Offset = "0xB266BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB266BC", Offset = "0xB266BC")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FD")]
		public class Multiplier
		{
			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DBA8", Offset = "0xB2DBA8")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DBE0", Offset = "0xB2DBE0")]
			public float multiplier;

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x14E3328", Offset = "0x14E3328", VA = "0x14E3328")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29F7C", Offset = "0xB29F7C")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29FB4", Offset = "0xB29FB4")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB29FEC", Offset = "0xB29FEC")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A024", Offset = "0xB2A024")]
		public Transform pivot;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A05C", Offset = "0xB2A05C")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A094", Offset = "0xB2A094")]
		public float twistWeight;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A0CC", Offset = "0xB2A0CC")]
		public float swingWeight;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A104", Offset = "0xB2A104")]
		public bool rotateOnce;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x14E28F4", Offset = "0x14E28F4", VA = "0x14E28F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB307B8", Offset = "0xB307B8")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x14E2940", Offset = "0x14E2940", VA = "0x14E2940")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB307F0", Offset = "0xB307F0")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x14E298C", Offset = "0x14E298C", VA = "0x14E298C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30828", Offset = "0xB30828")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x14E29D8", Offset = "0x14E29D8", VA = "0x14E29D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30860", Offset = "0xB30860")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x14E2A24", Offset = "0x14E2A24", VA = "0x14E2A24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30898", Offset = "0xB30898")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x14E2A70", Offset = "0x14E2A70", VA = "0x14E2A70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB308D0", Offset = "0xB308D0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x14DD9D0", Offset = "0x14DD9D0", VA = "0x14DD9D0")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x14E2ABC", Offset = "0x14E2ABC", VA = "0x14E2ABC")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x14E2B58", Offset = "0x14E2B58", VA = "0x14E2B58")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x14E3204", Offset = "0x14E3204", VA = "0x14E3204")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30908", Offset = "0xB30908")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x14E3250", Offset = "0x14E3250", VA = "0x14E3250")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30940", Offset = "0xB30940")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x14E329C", Offset = "0x14E329C", VA = "0x14E329C")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB2671C", Offset = "0xB2671C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB2671C", Offset = "0xB2671C")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FE")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DC18", Offset = "0xB2DC18")]
			public bool use;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DC50", Offset = "0xB2DC50")]
			public Vector2 offset;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DC88", Offset = "0xB2DC88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2DC88", Offset = "0xB2DC88")]
			public float angleOffset;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DCE4", Offset = "0xB2DCE4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2DCE4", Offset = "0xB2DCE4")]
			public float maxAngle;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DD3C", Offset = "0xB2DD3C")]
			public float radius;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DD74", Offset = "0xB2DD74")]
			public bool orbit;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DDAC", Offset = "0xB2DDAC")]
			public bool fixYAxis;

			[Token(Token = "0x170000F0")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60007BB")]
				[Address(RVA = "0x14E3AB0", Offset = "0x14E3AB0", VA = "0x14E3AB0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000F1")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60007BC")]
				[Address(RVA = "0x14E3AEC", Offset = "0x14E3AEC", VA = "0x14E3AEC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x14E3BE4", Offset = "0x14E3BE4", VA = "0x14E3BE4")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x14E4260", Offset = "0x14E4260", VA = "0x14E4260")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FF")]
		public class CameraPosition
		{
			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DDE4", Offset = "0xB2DDE4")]
			public Collider lookAtTarget;

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DE1C", Offset = "0xB2DE1C")]
			public Vector3 direction;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DE54", Offset = "0xB2DE54")]
			public float maxDistance;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DE8C", Offset = "0xB2DE8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2DE8C", Offset = "0xB2DE8C")]
			public float maxAngle;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DEE4", Offset = "0xB2DEE4")]
			public bool fixYAxis;

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x14E359C", Offset = "0x14E359C", VA = "0x14E359C")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x14E3744", Offset = "0x14E3744", VA = "0x14E3744")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x14E3A24", Offset = "0x14E3A24", VA = "0x14E3A24")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000100")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x200011D")]
			public class Interaction
			{
				[Token(Token = "0x40007FE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2ED90", Offset = "0xB2ED90")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40007FF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EDC8", Offset = "0xB2EDC8")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x600083A")]
				[Address(RVA = "0x14E4284", Offset = "0x14E4284", VA = "0x14E4284")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DF8C", Offset = "0xB2DF8C")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DFC4", Offset = "0xB2DFC4")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2DFFC", Offset = "0xB2DFFC")]
			public Interaction[] interactions;

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x14E3418", Offset = "0x14E3418", VA = "0x14E3418")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x14E4274", Offset = "0x14E4274", VA = "0x14E4274")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A13C", Offset = "0xB2A13C")]
		public Range[] ranges;

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x14E3330", Offset = "0x14E3330", VA = "0x14E3330")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30978", Offset = "0xB30978")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x14E337C", Offset = "0x14E337C", VA = "0x14E337C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB309B0", Offset = "0xB309B0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x14E33C8", Offset = "0x14E33C8", VA = "0x14E33C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB309E8", Offset = "0xB309E8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x14E3414", Offset = "0x14E3414", VA = "0x14E3414")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x14E1218", Offset = "0x14E1218", VA = "0x14E1218")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x14E353C", Offset = "0x14E353C", VA = "0x14E353C")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x2000101")]
		public class Map
		{
			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x1681144", Offset = "0x1681144", VA = "0x1681144")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x1681548", Offset = "0x1681548", VA = "0x1681548")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x16814FC", Offset = "0x16814FC", VA = "0x16814FC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x16812F4", Offset = "0x16812F4", VA = "0x16812F4")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1680E5C", Offset = "0x1680E5C", VA = "0x1680E5C", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30A20", Offset = "0xB30A20")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x16811E8", Offset = "0x16811E8", VA = "0x16811E8", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x16811EC", Offset = "0x16811EC", VA = "0x16811EC", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1681494", Offset = "0x1681494", VA = "0x1681494", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1681180", Offset = "0x1681180", VA = "0x1681180")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x16810A4", Offset = "0x16810A4", VA = "0x16810A4")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1681598", Offset = "0x1681598", VA = "0x1681598")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _poseRoot;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] children;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x168AD8C", Offset = "0x168AD8C", VA = "0x168AD8C", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x168AE44", Offset = "0x168AE44", VA = "0x168AE44", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x168AFFC", Offset = "0x168AFFC", VA = "0x168AFFC", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x168B0F8", Offset = "0x168B0F8", VA = "0x168B0F8", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x168AEA0", Offset = "0x168AEA0", VA = "0x168AEA0")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x168B4A8", Offset = "0x168B4A8", VA = "0x168B4A8")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2A174", Offset = "0xB2A174")]
		public float weight;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2A18C", Offset = "0xB2A18C")]
		public float localRotationWeight;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2A1A4", Offset = "0xB2A1A4")]
		public float localPositionWeight;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60004D1")]
		public abstract void AutoMapping();

		[Token(Token = "0x60004D2")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60004D3")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60004D4")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x14E5A60", Offset = "0x14E5A60", VA = "0x14E5A60", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x14E5AB4", Offset = "0x14E5AB4", VA = "0x14E5AB4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x14E5AF0", Offset = "0x14E5AF0", VA = "0x14E5AF0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x14E5B08", Offset = "0x14E5B08", VA = "0x14E5B08")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB2677C", Offset = "0xB2677C")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x2000102")]
		public class Rigidbone
		{
			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x14E608C", Offset = "0x14E608C", VA = "0x14E608C")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x14E6C98", Offset = "0x14E6C98", VA = "0x14E6C98")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x14E6A7C", Offset = "0x14E6A7C", VA = "0x14E6A7C")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x2000103")]
		public class Child
		{
			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x14E61E8", Offset = "0x14E61E8", VA = "0x14E61E8")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x14E6E30", Offset = "0x14E6E30", VA = "0x14E6E30")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x14E6DE0", Offset = "0x14E6DE0", VA = "0x14E6DE0")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x2000104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB26AFC", Offset = "0xB26AFC")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000F2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D1")]
				[Address(RVA = "0x14E7410", Offset = "0x14E7410", VA = "0x14E7410", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D3")]
				[Address(RVA = "0x14E7478", Offset = "0x14E7478", VA = "0x14E7478", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x14E6248", Offset = "0x14E6248", VA = "0x14E6248")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x14E71C8", Offset = "0x14E71C8", VA = "0x14E71C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x14E71CC", Offset = "0x14E71CC", VA = "0x14E71CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x14E7418", Offset = "0x14E7418", VA = "0x14E7418", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A1BC", Offset = "0xB2A1BC")]
		public IK ik;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A1F4", Offset = "0xB2A1F4")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A22C", Offset = "0xB2A22C")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A264", Offset = "0xB2A264")]
		public float applyVelocity;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A29C", Offset = "0xB2A29C")]
		public float applyAngularVelocity;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x1700005E")]
		private bool isRagdoll
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x14E5B50", Offset = "0x14E5B50", VA = "0x14E5B50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		private bool ikUsed
		{
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x14E6634", Offset = "0x14E6634", VA = "0x14E6634")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x14E5B18", Offset = "0x14E5B18", VA = "0x14E5B18")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x14E5BC8", Offset = "0x14E5BC8", VA = "0x14E5BC8")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x14E5CF8", Offset = "0x14E5CF8", VA = "0x14E5CF8")]
		public void Start()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x14E5C88", Offset = "0x14E5C88", VA = "0x14E5C88")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB30A58", Offset = "0xB30A58")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x14E6274", Offset = "0x14E6274", VA = "0x14E6274")]
		private void Update()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x14E64C0", Offset = "0x14E64C0", VA = "0x14E64C0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x14E6578", Offset = "0x14E6578", VA = "0x14E6578")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x14E67B8", Offset = "0x14E67B8", VA = "0x14E67B8")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x14E65F8", Offset = "0x14E65F8", VA = "0x14E65F8")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x14E6774", Offset = "0x14E6774", VA = "0x14E6774")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x14E6854", Offset = "0x14E6854", VA = "0x14E6854")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x14E67EC", Offset = "0x14E67EC", VA = "0x14E67EC")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x14E5C20", Offset = "0x14E5C20", VA = "0x14E5C20")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x14E6500", Offset = "0x14E6500", VA = "0x14E6500")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x14E6FF8", Offset = "0x14E6FF8", VA = "0x14E6FF8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x14E70FC", Offset = "0x14E70FC", VA = "0x14E70FC")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000060")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x14E8E34", Offset = "0x14E8E34", VA = "0x14E8E34")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000061")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x14E8E70", Offset = "0x14E8E70", VA = "0x14E8E70")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x14E8ABC", Offset = "0x14E8ABC", VA = "0x14E8ABC")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x14E8B00", Offset = "0x14E8B00", VA = "0x14E8B00")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x14E8D8C", Offset = "0x14E8D8C", VA = "0x14E8D8C")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x14E8DFC", Offset = "0x14E8DFC", VA = "0x14E8DFC")]
		public void Disable()
		{
		}

		[Token(Token = "0x60004F1")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x14E8C9C", Offset = "0x14E8C9C", VA = "0x14E8C9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x14E8F40", Offset = "0x14E8F40", VA = "0x14E8F40")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x14E8F44", Offset = "0x14E8F44", VA = "0x14E8F44")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x14E8F78", Offset = "0x14E8F78", VA = "0x14E8F78")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x14E905C", Offset = "0x14E905C", VA = "0x14E905C")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x14E92D8", Offset = "0x14E92D8", VA = "0x14E92D8")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x14E9394", Offset = "0x14E9394", VA = "0x14E9394")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB267E0", Offset = "0xB267E0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB267E0", Offset = "0xB267E0")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2A2E4", Offset = "0xB2A2E4")]
		public float limit;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2A300", Offset = "0xB2A300")]
		public float twistLimit;

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x14E940C", Offset = "0x14E940C", VA = "0x14E940C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30ABC", Offset = "0xB30ABC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x14E9458", Offset = "0x14E9458", VA = "0x14E9458")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30AF4", Offset = "0xB30AF4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x14E94A4", Offset = "0x14E94A4", VA = "0x14E94A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30B2C", Offset = "0xB30B2C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x14E94F0", Offset = "0x14E94F0", VA = "0x14E94F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30B64", Offset = "0xB30B64")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x14E953C", Offset = "0x14E953C", VA = "0x14E953C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x14E95F4", Offset = "0x14E95F4", VA = "0x14E95F4")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x14E983C", Offset = "0x14E983C", VA = "0x14E983C")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB26840", Offset = "0xB26840")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB26840", Offset = "0xB26840")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x14E984C", Offset = "0x14E984C", VA = "0x14E984C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30B9C", Offset = "0xB30B9C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x14E9898", Offset = "0x14E9898", VA = "0x14E9898")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30BD4", Offset = "0xB30BD4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x14E98E4", Offset = "0x14E98E4", VA = "0x14E98E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30C0C", Offset = "0xB30C0C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x14E9930", Offset = "0x14E9930", VA = "0x14E9930")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30C44", Offset = "0xB30C44")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x14E997C", Offset = "0x14E997C", VA = "0x14E997C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x14E99A4", Offset = "0x14E99A4", VA = "0x14E99A4")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x14E9CA4", Offset = "0x14E9CA4", VA = "0x14E9CA4")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB268A0", Offset = "0xB268A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB268A0", Offset = "0xB268A0")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x2000105")]
		public class ReachCone
		{
			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000F4")]
			public Vector3 o
			{
				[Token(Token = "0x60007D4")]
				[Address(RVA = "0x14EBC4C", Offset = "0x14EBC4C", VA = "0x14EBC4C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000F5")]
			public Vector3 a
			{
				[Token(Token = "0x60007D5")]
				[Address(RVA = "0x14EBC84", Offset = "0x14EBC84", VA = "0x14EBC84")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000F6")]
			public Vector3 b
			{
				[Token(Token = "0x60007D6")]
				[Address(RVA = "0x14EBCC0", Offset = "0x14EBCC0", VA = "0x14EBCC0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000F7")]
			public Vector3 c
			{
				[Token(Token = "0x60007D7")]
				[Address(RVA = "0x14EBCFC", Offset = "0x14EBCFC", VA = "0x14EBCFC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000F8")]
			public bool isValid
			{
				[Token(Token = "0x60007D9")]
				[Address(RVA = "0x14EADB0", Offset = "0x14EADB0", VA = "0x14EADB0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x14EB3FC", Offset = "0x14EB3FC", VA = "0x14EB3FC")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x14EB55C", Offset = "0x14EB55C", VA = "0x14EB55C")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000106")]
		public class LimitPoint
		{
			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x14EADC0", Offset = "0x14EADC0", VA = "0x14EADC0")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2A32C", Offset = "0xB2A32C")]
		public float twistLimit;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2A348", Offset = "0xB2A348")]
		public int smoothIterations;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x14E9D2C", Offset = "0x14E9D2C", VA = "0x14E9D2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30C7C", Offset = "0xB30C7C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x14E9D78", Offset = "0x14E9D78", VA = "0x14E9D78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30CB4", Offset = "0xB30CB4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x14E9DC4", Offset = "0x14E9DC4", VA = "0x14E9DC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30CEC", Offset = "0xB30CEC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x14E9E10", Offset = "0x14E9E10", VA = "0x14E9E10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30D24", Offset = "0xB30D24")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x14E9E5C", Offset = "0x14E9E5C", VA = "0x14E9E5C")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x14EA344", Offset = "0x14EA344", VA = "0x14EA344", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x14EA43C", Offset = "0x14EA43C", VA = "0x14EA43C")]
		private void Start()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x14EA9FC", Offset = "0x14EA9FC", VA = "0x14EA9FC")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x14E9EFC", Offset = "0x14E9EFC", VA = "0x14E9EFC")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x14EAE44", Offset = "0x14EAE44", VA = "0x14EAE44")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x14EB71C", Offset = "0x14EB71C", VA = "0x14EB71C")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x14EB760", Offset = "0x14EB760", VA = "0x14EB760")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x14EB8A8", Offset = "0x14EB8A8", VA = "0x14EB8A8")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x14EA6C0", Offset = "0x14EA6C0", VA = "0x14EA6C0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x14EBA38", Offset = "0x14EBA38", VA = "0x14EBA38")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x14EBBE8", Offset = "0x14EBBE8", VA = "0x14EBBE8")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB26900", Offset = "0xB26900")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB26900", Offset = "0xB26900")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2A408", Offset = "0xB2A408")]
		public float twistLimit;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x14EBD38", Offset = "0x14EBD38", VA = "0x14EBD38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30D5C", Offset = "0xB30D5C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x14EBD84", Offset = "0x14EBD84", VA = "0x14EBD84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30D94", Offset = "0xB30D94")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x14EBDD0", Offset = "0x14EBDD0", VA = "0x14EBDD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30DCC", Offset = "0xB30DCC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x14EBE1C", Offset = "0x14EBE1C", VA = "0x14EBE1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB30E04", Offset = "0xB30E04")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x14EBE68", Offset = "0x14EBE68", VA = "0x14EBE68")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x14EBE84", Offset = "0x14EBE84", VA = "0x14EBE84", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x14EBF3C", Offset = "0x14EBF3C", VA = "0x14EBF3C")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x14EC268", Offset = "0x14EC268", VA = "0x14EC268")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A45C", Offset = "0xB2A45C")]
		public AimIK ik;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A494", Offset = "0xB2A494")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2A494", Offset = "0xB2A494")]
		public float weight;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB2A4E8", Offset = "0xB2A4E8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A4E8", Offset = "0xB2A4E8")]
		public Transform target;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A548", Offset = "0xB2A548")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A580", Offset = "0xB2A580")]
		public float weightSmoothTime;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB2A5B8", Offset = "0xB2A5B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A5B8", Offset = "0xB2A5B8")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A618", Offset = "0xB2A618")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A650", Offset = "0xB2A650")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A688", Offset = "0xB2A688")]
		public float slerpSpeed;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A6C0", Offset = "0xB2A6C0")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A6F8", Offset = "0xB2A6F8")]
		public float minDistance;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A730", Offset = "0xB2A730")]
		public Vector3 offset;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB2A768", Offset = "0xB2A768")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A768", Offset = "0xB2A768")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2A768", Offset = "0xB2A768")]
		public float maxRootAngle;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB2A7E4", Offset = "0xB2A7E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A7E4", Offset = "0xB2A7E4")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A844", Offset = "0xB2A844")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform lastTarget;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float switchWeight;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float switchWeightV;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float weightV;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 dir;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x17000062")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x12F5960", Offset = "0x12F5960", VA = "0x12F5960")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x12F5864", Offset = "0x12F5864", VA = "0x12F5864")]
		private void Start()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x12F5AAC", Offset = "0x12F5AAC", VA = "0x12F5AAC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x12F61C8", Offset = "0x12F61C8", VA = "0x12F61C8")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x12F6364", Offset = "0x12F6364", VA = "0x12F6364")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x12F6680", Offset = "0x12F6680", VA = "0x12F6680")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000107")]
		public class Pose
		{
			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x12F6930", Offset = "0x12F6930", VA = "0x12F6930")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x12F6C30", Offset = "0x12F6C30", VA = "0x12F6C30")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x12F6C38", Offset = "0x12F6C38", VA = "0x12F6C38")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x12F1BDC", Offset = "0x12F1BDC", VA = "0x12F1BDC")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x12F1CB8", Offset = "0x12F1CB8", VA = "0x12F1CB8")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x12F6BC8", Offset = "0x12F6BC8", VA = "0x12F6BC8")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000108")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x200011E")]
			public class EffectorLink
			{
				[Token(Token = "0x4000800")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EE00", Offset = "0xB2EE00")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000801")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EE38", Offset = "0xB2EE38")]
				public float weight;

				[Token(Token = "0x600083B")]
				[Address(RVA = "0x1676134", Offset = "0x1676134", VA = "0x1676134")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E034", Offset = "0xB2E034")]
			public Transform transform;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E06C", Offset = "0xB2E06C")]
			public Transform relativeTo;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E0A4", Offset = "0xB2E0A4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E0DC", Offset = "0xB2E0DC")]
			public float verticalWeight;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E114", Offset = "0xB2E114")]
			public float horizontalWeight;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E14C", Offset = "0xB2E14C")]
			public float speed;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x12F6D94", Offset = "0x12F6D94", VA = "0x12F6D94")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x12F7200", Offset = "0x12F7200", VA = "0x12F7200")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x12F7210", Offset = "0x12F7210", VA = "0x12F7210")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A87C", Offset = "0xB2A87C")]
		public Body[] bodies;

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x12F6C54", Offset = "0x12F6C54", VA = "0x12F6C54", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x12F71F8", Offset = "0x12F71F8", VA = "0x12F71F8")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A8B4", Offset = "0xB2A8B4")]
		public float tiltSpeed;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A8EC", Offset = "0xB2A8EC")]
		public float tiltSensitivity;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A924", Offset = "0xB2A924")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A95C", Offset = "0xB2A95C")]
		public OffsetPose poseRight;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x16774A8", Offset = "0x16774A8", VA = "0x16774A8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x16774F0", Offset = "0x16774F0", VA = "0x16774F0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1677720", Offset = "0x1677720", VA = "0x1677720")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000109")]
		public abstract class HitPoint
		{
			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E184", Offset = "0xB2E184")]
			public string name;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E1BC", Offset = "0xB2E1BC")]
			public Collider collider;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E1F4", Offset = "0xB2E1F4")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2E240", Offset = "0xB2E240")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2E250", Offset = "0xB2E250")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2E260", Offset = "0xB2E260")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2E270", Offset = "0xB2E270")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000F9")]
			public bool inProgress
			{
				[Token(Token = "0x60007E2")]
				[Address(RVA = "0x168B56C", Offset = "0x168B56C", VA = "0x168B56C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000FA")]
			protected float crossFader
			{
				[Token(Token = "0x60007E3")]
				[Address(RVA = "0x168BB14", Offset = "0x168BB14", VA = "0x168BB14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB316A0", Offset = "0xB316A0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007E4")]
				[Address(RVA = "0x168BB1C", Offset = "0x168BB1C", VA = "0x168BB1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB316B0", Offset = "0xB316B0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000FB")]
			protected float timer
			{
				[Token(Token = "0x60007E5")]
				[Address(RVA = "0x168BB24", Offset = "0x168BB24", VA = "0x168BB24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB316C0", Offset = "0xB316C0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007E6")]
				[Address(RVA = "0x168BB2C", Offset = "0x168BB2C", VA = "0x168BB2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB316D0", Offset = "0xB316D0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000FC")]
			protected Vector3 force
			{
				[Token(Token = "0x60007E7")]
				[Address(RVA = "0x168BB34", Offset = "0x168BB34", VA = "0x168BB34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB316E0", Offset = "0xB316E0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007E8")]
				[Address(RVA = "0x168BB40", Offset = "0x168BB40", VA = "0x168BB40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB316F0", Offset = "0xB316F0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000FD")]
			protected Vector3 point
			{
				[Token(Token = "0x60007E9")]
				[Address(RVA = "0x168BB4C", Offset = "0x168BB4C", VA = "0x168BB4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31700", Offset = "0xB31700")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007EA")]
				[Address(RVA = "0x168BB58", Offset = "0x168BB58", VA = "0x168BB58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31710", Offset = "0xB31710")]
				private set
				{
				}
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x168B9E0", Offset = "0x168B9E0", VA = "0x168B9E0")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x168B654", Offset = "0x168B654", VA = "0x168B654")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60007ED")]
			protected abstract float GetLength();

			[Token(Token = "0x60007EE")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60007EF")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x168BB64", Offset = "0x168BB64", VA = "0x168BB64")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010A")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x200011F")]
			public class EffectorLink
			{
				[Token(Token = "0x4000802")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EE70", Offset = "0xB2EE70")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000803")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EEA8", Offset = "0xB2EEA8")]
				public float weight;

				[Token(Token = "0x4000804")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000805")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600083C")]
				[Address(RVA = "0x168C4D0", Offset = "0x168C4D0", VA = "0x168C4D0")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600083D")]
				[Address(RVA = "0x168C2C4", Offset = "0x168C2C4", VA = "0x168C2C4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600083E")]
				[Address(RVA = "0x168C60C", Offset = "0x168C60C", VA = "0x168C60C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E280", Offset = "0xB2E280")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E2B8", Offset = "0xB2E2B8")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E2F0", Offset = "0xB2E2F0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x168C0E0", Offset = "0x168C0E0", VA = "0x168C0E0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x168C258", Offset = "0x168C258", VA = "0x168C258", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x168C2D8", Offset = "0x168C2D8", VA = "0x168C2D8", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x168C5F8", Offset = "0x168C5F8", VA = "0x168C5F8")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010B")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000120")]
			public class BoneLink
			{
				[Token(Token = "0x4000806")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EEE0", Offset = "0xB2EEE0")]
				public Transform bone;

				[Token(Token = "0x4000807")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EF18", Offset = "0xB2EF18")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2EF18", Offset = "0xB2EF18")]
				public float weight;

				[Token(Token = "0x4000808")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000809")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x600083F")]
				[Address(RVA = "0x168BEE8", Offset = "0x168BEE8", VA = "0x168BEE8")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000840")]
				[Address(RVA = "0x168BC80", Offset = "0x168BC80", VA = "0x168BC80")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000841")]
				[Address(RVA = "0x168C058", Offset = "0x168C058", VA = "0x168C058")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E328", Offset = "0xB2E328")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E360", Offset = "0xB2E360")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x168BB78", Offset = "0x168BB78", VA = "0x168BB78", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x168BC1C", Offset = "0x168BC1C", VA = "0x168BC1C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x168BC8C", Offset = "0x168BC8C", VA = "0x168BC8C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x168C044", Offset = "0x168C044", VA = "0x168C044")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A994", Offset = "0xB2A994")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2A9CC", Offset = "0xB2A9CC")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x17000063")]
		public bool inProgress
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x168B4B0", Offset = "0x168B4B0", VA = "0x168B4B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x168B580", Offset = "0x168B580", VA = "0x168B580", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x168B7A0", Offset = "0x168B7A0", VA = "0x168B7A0")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x168BB0C", Offset = "0x168BB0C", VA = "0x168BB0C")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x200010C")]
		public abstract class Offset
		{
			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E398", Offset = "0xB2E398")]
			public string name;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E3D0", Offset = "0xB2E3D0")]
			public Collider collider;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E408", Offset = "0xB2E408")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2E454", Offset = "0xB2E454")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2E464", Offset = "0xB2E464")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2E474", Offset = "0xB2E474")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2E484", Offset = "0xB2E484")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000FE")]
			protected float crossFader
			{
				[Token(Token = "0x60007F9")]
				[Address(RVA = "0x168CBC4", Offset = "0x168CBC4", VA = "0x168CBC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31720", Offset = "0xB31720")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007FA")]
				[Address(RVA = "0x168CBCC", Offset = "0x168CBCC", VA = "0x168CBCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31730", Offset = "0xB31730")]
				private set
				{
				}
			}

			[Token(Token = "0x170000FF")]
			protected float timer
			{
				[Token(Token = "0x60007FB")]
				[Address(RVA = "0x168CBD4", Offset = "0x168CBD4", VA = "0x168CBD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31740", Offset = "0xB31740")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007FC")]
				[Address(RVA = "0x168CBDC", Offset = "0x168CBDC", VA = "0x168CBDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31750", Offset = "0xB31750")]
				private set
				{
				}
			}

			[Token(Token = "0x17000100")]
			protected Vector3 force
			{
				[Token(Token = "0x60007FD")]
				[Address(RVA = "0x168CBE4", Offset = "0x168CBE4", VA = "0x168CBE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31760", Offset = "0xB31760")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007FE")]
				[Address(RVA = "0x168CBF0", Offset = "0x168CBF0", VA = "0x168CBF0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31770", Offset = "0xB31770")]
				private set
				{
				}
			}

			[Token(Token = "0x17000101")]
			protected Vector3 point
			{
				[Token(Token = "0x60007FF")]
				[Address(RVA = "0x168CBFC", Offset = "0x168CBFC", VA = "0x168CBFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31780", Offset = "0xB31780")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000800")]
				[Address(RVA = "0x168CC08", Offset = "0x168CC08", VA = "0x168CC08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31790", Offset = "0xB31790")]
				private set
				{
				}
			}

			[Token(Token = "0x6000801")]
			[Address(RVA = "0x168CA7C", Offset = "0x168CA7C", VA = "0x168CA7C")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000802")]
			[Address(RVA = "0x168C6E0", Offset = "0x168C6E0", VA = "0x168C6E0")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000803")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000804")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000805")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000806")]
			[Address(RVA = "0x168CC14", Offset = "0x168CC14", VA = "0x168CC14")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010D")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000121")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x400080A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EF6C", Offset = "0xB2EF6C")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x400080B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EFA4", Offset = "0xB2EFA4")]
				public float weight;

				[Token(Token = "0x400080C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400080D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000842")]
				[Address(RVA = "0x191E784", Offset = "0x191E784", VA = "0x191E784")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000843")]
				[Address(RVA = "0x191E540", Offset = "0x191E540", VA = "0x191E540")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000844")]
				[Address(RVA = "0x191E894", Offset = "0x191E894", VA = "0x191E894")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E494", Offset = "0xB2E494")]
			public int forceDirCurveIndex;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E4CC", Offset = "0xB2E4CC")]
			public int upDirCurveIndex;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E504", Offset = "0xB2E504")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000807")]
			[Address(RVA = "0x191E2DC", Offset = "0x191E2DC", VA = "0x191E2DC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000808")]
			[Address(RVA = "0x191E4D4", Offset = "0x191E4D4", VA = "0x191E4D4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000809")]
			[Address(RVA = "0x191E554", Offset = "0x191E554", VA = "0x191E554", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600080A")]
			[Address(RVA = "0x191E884", Offset = "0x191E884", VA = "0x191E884")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010E")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000122")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x400080E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EFDC", Offset = "0xB2EFDC")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x400080F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2F014", Offset = "0xB2F014")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2F014", Offset = "0xB2F014")]
				public float weight;

				[Token(Token = "0x4000810")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000811")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000845")]
				[Address(RVA = "0x191ECFC", Offset = "0x191ECFC", VA = "0x191ECFC")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000846")]
				[Address(RVA = "0x191E9E4", Offset = "0x191E9E4", VA = "0x191E9E4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000847")]
				[Address(RVA = "0x191EE2C", Offset = "0x191EE2C", VA = "0x191EE2C")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E53C", Offset = "0xB2E53C")]
			public int curveIndex;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E574", Offset = "0xB2E574")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600080B")]
			[Address(RVA = "0x191E89C", Offset = "0x191E89C", VA = "0x191E89C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600080C")]
			[Address(RVA = "0x191E980", Offset = "0x191E980", VA = "0x191E980", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600080D")]
			[Address(RVA = "0x191E9F0", Offset = "0x191E9F0", VA = "0x191E9F0", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600080E")]
			[Address(RVA = "0x191EE24", Offset = "0x191EE24", VA = "0x191EE24")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AA04", Offset = "0xB2AA04")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AA3C", Offset = "0xB2AA3C")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x168C614", Offset = "0x168C614", VA = "0x168C614", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x168C834", Offset = "0x168C834", VA = "0x168C834")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x168CBBC", Offset = "0x168CBBC", VA = "0x168CBBC")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200010F")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000123")]
			public class EffectorLink
			{
				[Token(Token = "0x4000812")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2F068", Offset = "0xB2F068")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000813")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2F0A0", Offset = "0xB2F0A0")]
				public float weight;

				[Token(Token = "0x6000848")]
				[Address(RVA = "0x17BFB98", Offset = "0x17BFB98", VA = "0x17BFB98")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E5AC", Offset = "0xB2E5AC")]
			public Transform transform;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E5E4", Offset = "0xB2E5E4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E61C", Offset = "0xB2E61C")]
			public float speed;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E654", Offset = "0xB2E654")]
			public float acceleration;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E68C", Offset = "0xB2E68C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2E68C", Offset = "0xB2E68C")]
			public float matchVelocity;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E6E0", Offset = "0xB2E6E0")]
			public float gravity;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x600080F")]
			[Address(RVA = "0x17BF664", Offset = "0x17BF664", VA = "0x17BF664")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000810")]
			[Address(RVA = "0x17BF7FC", Offset = "0x17BF7FC", VA = "0x17BF7FC")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000811")]
			[Address(RVA = "0x17BFB7C", Offset = "0x17BFB7C", VA = "0x17BFB7C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AA74", Offset = "0xB2AA74")]
		public Body[] bodies;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AAAC", Offset = "0xB2AAAC")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x17BF5EC", Offset = "0x17BF5EC", VA = "0x17BF5EC")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x17BF740", Offset = "0x17BF740", VA = "0x17BF740", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x17BFB74", Offset = "0x17BFB74", VA = "0x17BFB74")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000110")]
		public class OffsetLimits
		{
			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E718", Offset = "0xB2E718")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E750", Offset = "0xB2E750")]
			public float spring;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E788", Offset = "0xB2E788")]
			public bool x;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E7C0", Offset = "0xB2E7C0")]
			public bool y;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E7F8", Offset = "0xB2E7F8")]
			public bool z;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E830", Offset = "0xB2E830")]
			public float minX;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E868", Offset = "0xB2E868")]
			public float maxX;

			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E8A0", Offset = "0xB2E8A0")]
			public float minY;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E8D8", Offset = "0xB2E8D8")]
			public float maxY;

			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E910", Offset = "0xB2E910")]
			public float minZ;

			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E948", Offset = "0xB2E948")]
			public float maxZ;

			[Token(Token = "0x6000812")]
			[Address(RVA = "0x14E4A68", Offset = "0x14E4A68", VA = "0x14E4A68")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000813")]
			[Address(RVA = "0x14E4F80", Offset = "0x14E4F80", VA = "0x14E4F80")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000814")]
			[Address(RVA = "0x14E4FB0", Offset = "0x14E4FB0", VA = "0x14E4FB0")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000815")]
			[Address(RVA = "0x14E5088", Offset = "0x14E5088", VA = "0x14E5088")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000111")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB26B0C", Offset = "0xB26B0C")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x17000102")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000819")]
				[Address(RVA = "0x14E4F10", Offset = "0x14E4F10", VA = "0x14E4F10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000103")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600081B")]
				[Address(RVA = "0x14E4F78", Offset = "0x14E4F78", VA = "0x14E4F78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000816")]
			[Address(RVA = "0x14E4874", Offset = "0x14E4874", VA = "0x14E4874")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0x14E4DD0", Offset = "0x14E4DD0", VA = "0x14E4DD0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000818")]
			[Address(RVA = "0x14E4DD4", Offset = "0x14E4DD4", VA = "0x14E4DD4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600081A")]
			[Address(RVA = "0x14E4F18", Offset = "0x14E4F18", VA = "0x14E4F18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AAE4", Offset = "0xB2AAE4")]
		public float weight;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AB1C", Offset = "0xB2AB1C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x17000064")]
		protected float deltaTime
		{
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x14E47AC", Offset = "0x14E47AC", VA = "0x14E47AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000538")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x14E47D8", Offset = "0x14E47D8", VA = "0x14E47D8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x14E4804", Offset = "0x14E4804", VA = "0x14E4804")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB30E3C", Offset = "0xB30E3C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x14E48A0", Offset = "0x14E48A0", VA = "0x14E48A0")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x14E49AC", Offset = "0x14E49AC", VA = "0x14E49AC")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x14E4CC8", Offset = "0x14E4CC8", VA = "0x14E4CC8", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x14E4DC0", Offset = "0x14E4DC0", VA = "0x14E4DC0")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000112")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB26B1C", Offset = "0xB26B1C")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x17000104")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600081F")]
				[Address(RVA = "0x14E54D8", Offset = "0x14E54D8", VA = "0x14E54D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000105")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000821")]
				[Address(RVA = "0x14E5540", Offset = "0x14E5540", VA = "0x14E5540", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600081C")]
			[Address(RVA = "0x14E5158", Offset = "0x14E5158", VA = "0x14E5158")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600081D")]
			[Address(RVA = "0x14E5398", Offset = "0x14E5398", VA = "0x14E5398", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600081E")]
			[Address(RVA = "0x14E539C", Offset = "0x14E539C", VA = "0x14E539C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x14E54E0", Offset = "0x14E54E0", VA = "0x14E54E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AB54", Offset = "0xB2AB54")]
		public float weight;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AB8C", Offset = "0xB2AB8C")]
		public VRIK ik;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x17000065")]
		protected float deltaTime
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x14E5090", Offset = "0x14E5090", VA = "0x14E5090")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000540")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x14E50BC", Offset = "0x14E50BC", VA = "0x14E50BC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x14E50E8", Offset = "0x14E50E8", VA = "0x14E50E8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB30EA0", Offset = "0xB30EA0")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x14E5184", Offset = "0x14E5184", VA = "0x14E5184")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x14E5290", Offset = "0x14E5290", VA = "0x14E5290", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x14E5388", Offset = "0x14E5388", VA = "0x14E5388")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000113")]
		public class EffectorLink
		{
			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000822")]
			[Address(RVA = "0x14E5608", Offset = "0x14E5608", VA = "0x14E5608")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000823")]
			[Address(RVA = "0x14E5A58", Offset = "0x14E5A58", VA = "0x14E5A58")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x14E5548", Offset = "0x14E5548", VA = "0x14E5548")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x14E5940", Offset = "0x14E5940", VA = "0x14E5940")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x14E59F8", Offset = "0x14E59F8", VA = "0x14E59F8")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000114")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x2000124")]
			public class EffectorLink
			{
				[Token(Token = "0x4000814")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2F0D8", Offset = "0xB2F0D8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000815")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2F110", Offset = "0xB2F110")]
				public float weight;

				[Token(Token = "0x6000849")]
				[Address(RVA = "0x14E8AB4", Offset = "0x14E8AB4", VA = "0x14E8AB4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E980", Offset = "0xB2E980")]
			public Vector3 offset;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2E9B8", Offset = "0xB2E9B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2E9B8", Offset = "0xB2E9B8")]
			public float additivity;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EA0C", Offset = "0xB2EA0C")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EA44", Offset = "0xB2EA44")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000824")]
			[Address(RVA = "0x14E77FC", Offset = "0x14E77FC", VA = "0x14E77FC")]
			public void Start()
			{
			}

			[Token(Token = "0x6000825")]
			[Address(RVA = "0x14E838C", Offset = "0x14E838C", VA = "0x14E838C")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000826")]
			[Address(RVA = "0x14E8AA0", Offset = "0x14E8AA0", VA = "0x14E8AA0")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000115")]
		public enum Handedness
		{
			[Token(Token = "0x40007D5")]
			Right,
			[Token(Token = "0x40007D6")]
			Left
		}

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2ABC4", Offset = "0xB2ABC4")]
		public AimIK aimIK;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2ABFC", Offset = "0xB2ABFC")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AC34", Offset = "0xB2AC34")]
		public Handedness handedness;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AC6C", Offset = "0xB2AC6C")]
		public bool twoHanded;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2ACA4", Offset = "0xB2ACA4")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2ACDC", Offset = "0xB2ACDC")]
		public float magnitudeRandom;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AD14", Offset = "0xB2AD14")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AD4C", Offset = "0xB2AD4C")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AD84", Offset = "0xB2AD84")]
		public float blendTime;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xB2ADBC", Offset = "0xB2ADBC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2ADBC", Offset = "0xB2ADBC")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x17000066")]
		public bool isFinished
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x14E75D4", Offset = "0x14E75D4", VA = "0x14E75D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x14E8640", Offset = "0x14E8640", VA = "0x14E8640")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x14E8680", Offset = "0x14E8680", VA = "0x14E8680")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x14E8600", Offset = "0x14E8600", VA = "0x14E8600")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x14E8620", Offset = "0x14E8620", VA = "0x14E8620")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x14E7604", Offset = "0x14E7604", VA = "0x14E7604")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x14E7630", Offset = "0x14E7630", VA = "0x14E7630")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x14E78AC", Offset = "0x14E78AC", VA = "0x14E78AC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x14E86C0", Offset = "0x14E86C0", VA = "0x14E86C0")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x14E8818", Offset = "0x14E8818", VA = "0x14E8818")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x14E8854", Offset = "0x14E8854", VA = "0x14E8854", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x14E89EC", Offset = "0x14E89EC", VA = "0x14E89EC")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AE1C", Offset = "0xB2AE1C")]
		public float weight;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AE54", Offset = "0xB2AE54")]
		public float offset;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x14EC274", Offset = "0x14EC274", VA = "0x14EC274")]
		private void Start()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x14EC348", Offset = "0x14EC348", VA = "0x14EC348")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x14EC434", Offset = "0x14EC434", VA = "0x14EC434")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x14EC87C", Offset = "0x14EC87C", VA = "0x14EC87C")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x14EC8B4", Offset = "0x14EC8B4", VA = "0x14EC8B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x14EC9AC", Offset = "0x14EC9AC", VA = "0x14EC9AC")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x2000116")]
		public class Settings
		{
			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EA7C", Offset = "0xB2EA7C")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EAB4", Offset = "0xB2EAB4")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EAEC", Offset = "0xB2EAEC")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EB24", Offset = "0xB2EB24")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EB5C", Offset = "0xB2EB5C")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EB94", Offset = "0xB2EB94")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EBCC", Offset = "0xB2EBCC")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EC04", Offset = "0xB2EC04")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xB2EC3C", Offset = "0xB2EC3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EC3C", Offset = "0xB2EC3C")]
			public Vector3 headOffset;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2EC8C", Offset = "0xB2EC8C")]
			public Vector3 handOffset;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2ECC4", Offset = "0xB2ECC4")]
			public float footForwardOffset;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2ECFC", Offset = "0xB2ECFC")]
			public float footInwardOffset;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2ED34", Offset = "0xB2ED34")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2ED34", Offset = "0xB2ED34")]
			public float footHeadingOffset;

			[Token(Token = "0x6000827")]
			[Address(RVA = "0x14F0300", Offset = "0x14F0300", VA = "0x14F0300")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x14EE818", Offset = "0x14EE818", VA = "0x14EE818")]
		public static void Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x14EFA00", Offset = "0x14EFA00", VA = "0x14EFA00")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvisTarget;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftFootTarget;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightFootTarget;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 pelvisTargetRight;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x14F03E8", Offset = "0x14F03E8", VA = "0x14F03E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x14F01C0", Offset = "0x14F01C0", VA = "0x14F01C0")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x14F04BC", Offset = "0x14F04BC", VA = "0x14F04BC")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x14F08A8", Offset = "0x14F08A8", VA = "0x14F08A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x14F09A0", Offset = "0x14F09A0", VA = "0x14F09A0")]
		public VRIKRootController()
		{
		}
	}
}
namespace CodeStage.AdvancedFPSCounter
{
	[Token(Token = "0x20000AA")]
	public class APITester : MonoBehaviour
	{
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int selectedTab;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string[] tabs;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSLevel currentFPSLevel;

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x16BF348", Offset = "0x16BF348", VA = "0x16BF348")]
		private void Start()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x16BF488", Offset = "0x16BF488", VA = "0x16BF488")]
		private void OnFPSLevelChanged(FPSLevel newLevel)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x16BF490", Offset = "0x16BF490", VA = "0x16BF490")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x16C07DC", Offset = "0x16C07DC", VA = "0x16C07DC")]
		private void DrawCommonTab()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x16C1524", Offset = "0x16C1524", VA = "0x16C1524")]
		private void DrawLookFeelTab()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x16C2270", Offset = "0x16C2270", VA = "0x16C2270")]
		private void DrawFPSCounterTab()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x16C3AD8", Offset = "0x16C3AD8", VA = "0x16C3AD8")]
		private void DrawMemoryCounterTab()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x16C49BC", Offset = "0x16C49BC", VA = "0x16C49BC")]
		private void DrawDeviceInfoTab()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x16C5AE0", Offset = "0x16C5AE0", VA = "0x16C5AE0")]
		private static float SliderLabel(float sliderValue, float sliderMinValue, float sliderMaxValue)
		{
			return default(float);
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x16C60A0", Offset = "0x16C60A0", VA = "0x16C60A0")]
		private Color ColorSliders(string caption, Color color)
		{
			return default(Color);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x16C5DE8", Offset = "0x16C5DE8", VA = "0x16C5DE8")]
		private Vector2 Vector2Slider(Vector2 input, string label)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x16C7054", Offset = "0x16C7054", VA = "0x16C7054")]
		public APITester()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB26960", Offset = "0xB26960")]
	[DisallowMultipleComponent]
	public class AFPSCounter : MonoBehaviour
	{
		[Token(Token = "0x40004DC")]
		private const string MENU_PATH = "Code Stage/Advanced FPS Counter";

		[Token(Token = "0x40004DD")]
		private const string COMPONENT_NAME = "Advanced FPS Counter";

		[Token(Token = "0x40004DE")]
		internal const string LOG_PREFIX = "<b>[AFPSCounter]:</b> ";

		[Token(Token = "0x40004DF")]
		internal const char NEW_LINE = '\n';

		[Token(Token = "0x40004E0")]
		internal const char SPACE = ' ';

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FPSCounterData fpsCounter;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MemoryCounterData memoryCounter;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DeviceInfoCounterData deviceInfoCounter;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AE8C", Offset = "0xB2AE8C")]
		public KeyCode hotKey;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AEC4", Offset = "0xB2AEC4")]
		public bool circleGesture;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AEFC", Offset = "0xB2AEFC")]
		public bool hotKeyCtrl;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AF34", Offset = "0xB2AF34")]
		public bool hotKeyShift;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AF6C", Offset = "0xB2AF6C")]
		public bool hotKeyAlt;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AFA4", Offset = "0xB2AFA4")]
		[SerializeField]
		private bool keepAlive;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Canvas canvas;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CanvasScaler canvasScaler;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool externalCanvas;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private DrawableLabel[] labels;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int anchorsCount;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int cachedVSync;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int cachedFrameRate;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool inited;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly List<Vector2> gesturePoints;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int gestureCount;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2AFF0", Offset = "0xB2AFF0")]
		[SerializeField]
		private OperationMode operationMode;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B03C", Offset = "0xB2B03C")]
		[SerializeField]
		private bool forceFrameRate;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2B088", Offset = "0xB2B088")]
		[SerializeField]
		private int forcedFrameRate;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B0CC", Offset = "0xB2B0CC")]
		[SerializeField]
		private bool background;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B118", Offset = "0xB2B118")]
		[SerializeField]
		private Color backgroundColor;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B164", Offset = "0xB2B164")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2B164", Offset = "0xB2B164")]
		[SerializeField]
		private int backgroundPadding;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B1C8", Offset = "0xB2B1C8")]
		[SerializeField]
		private bool shadow;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B214", Offset = "0xB2B214")]
		[SerializeField]
		private Color shadowColor;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B260", Offset = "0xB2B260")]
		[SerializeField]
		private Vector2 shadowDistance;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B2AC", Offset = "0xB2B2AC")]
		[SerializeField]
		private bool outline;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B2F8", Offset = "0xB2B2F8")]
		[SerializeField]
		private Color outlineColor;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B344", Offset = "0xB2B344")]
		[SerializeField]
		private Vector2 outlineDistance;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B390", Offset = "0xB2B390")]
		[SerializeField]
		private bool autoScale;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B3DC", Offset = "0xB2B3DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2B3DC", Offset = "0xB2B3DC")]
		[SerializeField]
		private float scaleFactor;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B440", Offset = "0xB2B440")]
		[SerializeField]
		private Font labelsFont;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B48C", Offset = "0xB2B48C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2B48C", Offset = "0xB2B48C")]
		[SerializeField]
		private int fontSize;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B4F4", Offset = "0xB2B4F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2B4F4", Offset = "0xB2B4F4")]
		[SerializeField]
		private float lineSpacing;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B558", Offset = "0xB2B558")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2B558", Offset = "0xB2B558")]
		[SerializeField]
		private int countersSpacing;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B5BC", Offset = "0xB2B5BC")]
		[SerializeField]
		private Vector2 paddingOffset;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B608", Offset = "0xB2B608")]
		[SerializeField]
		private bool pixelPerfect;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B654", Offset = "0xB2B654")]
		[SerializeField]
		private int sortingOrder;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2B6A0", Offset = "0xB2B6A0")]
		private static AFPSCounter <Instance>k__BackingField;

		[Token(Token = "0x1700006B")]
		public bool KeepAlive
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x16BB54C", Offset = "0x16BB54C", VA = "0x16BB54C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		public OperationMode OperationMode
		{
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x16BB554", Offset = "0x16BB554", VA = "0x16BB554")]
			get
			{
				return default(OperationMode);
			}
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x16BB55C", Offset = "0x16BB55C", VA = "0x16BB55C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public bool ForceFrameRate
		{
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x16BBBA8", Offset = "0x16BBBA8", VA = "0x16BBBA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x16BBBB0", Offset = "0x16BBBB0", VA = "0x16BBBB0")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public int ForcedFrameRate
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x16BBC1C", Offset = "0x16BBC1C", VA = "0x16BBC1C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x16BBC24", Offset = "0x16BBC24", VA = "0x16BBC24")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public bool Background
		{
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x16BBC7C", Offset = "0x16BBC7C", VA = "0x16BBC7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x16BBC84", Offset = "0x16BBC84", VA = "0x16BBC84")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public Color BackgroundColor
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x16BBD54", Offset = "0x16BBD54", VA = "0x16BBD54")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x16BBD60", Offset = "0x16BBD60", VA = "0x16BBD60")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public int BackgroundPadding
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x16BBE64", Offset = "0x16BBE64", VA = "0x16BBE64")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x16BBE6C", Offset = "0x16BBE6C", VA = "0x16BBE6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public bool Shadow
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x16BBF38", Offset = "0x16BBF38", VA = "0x16BBF38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x16BBF40", Offset = "0x16BBF40", VA = "0x16BBF40")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public Color ShadowColor
		{
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x16BC010", Offset = "0x16BC010", VA = "0x16BC010")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x16BC01C", Offset = "0x16BC01C", VA = "0x16BC01C")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public Vector2 ShadowDistance
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x16BC120", Offset = "0x16BC120", VA = "0x16BC120")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000580")]
			[Address(RVA = "0x16BC128", Offset = "0x16BC128", VA = "0x16BC128")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public bool Outline
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x16BC254", Offset = "0x16BC254", VA = "0x16BC254")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x16BC25C", Offset = "0x16BC25C", VA = "0x16BC25C")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public Color OutlineColor
		{
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x16BC32C", Offset = "0x16BC32C", VA = "0x16BC32C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x16BC338", Offset = "0x16BC338", VA = "0x16BC338")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public Vector2 OutlineDistance
		{
			[Token(Token = "0x6000585")]
			[Address(RVA = "0x16BC43C", Offset = "0x16BC43C", VA = "0x16BC43C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x16BC444", Offset = "0x16BC444", VA = "0x16BC444")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public bool AutoScale
		{
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x16BC570", Offset = "0x16BC570", VA = "0x16BC570")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x16BC578", Offset = "0x16BC578", VA = "0x16BC578")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public float ScaleFactor
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x16BC648", Offset = "0x16BC648", VA = "0x16BC648")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x16BC650", Offset = "0x16BC650", VA = "0x16BC650")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public Font LabelsFont
		{
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x16BC784", Offset = "0x16BC784", VA = "0x16BC784")]
			get
			{
				return null;
			}
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x16BC78C", Offset = "0x16BC78C", VA = "0x16BC78C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public int FontSize
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x16BC8C0", Offset = "0x16BC8C0", VA = "0x16BC8C0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x16BC8C8", Offset = "0x16BC8C8", VA = "0x16BC8C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public float LineSpacing
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x16BCA10", Offset = "0x16BCA10", VA = "0x16BCA10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x16BCA18", Offset = "0x16BCA18", VA = "0x16BCA18")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public int CountersSpacing
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x16BCBB8", Offset = "0x16BCBB8", VA = "0x16BCBB8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x16BCBC0", Offset = "0x16BCBC0", VA = "0x16BCBC0")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public Vector2 PaddingOffset
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x16BCC6C", Offset = "0x16BCC6C", VA = "0x16BCC6C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x16BCC74", Offset = "0x16BCC74", VA = "0x16BCC74")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public bool PixelPerfect
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x16BCE34", Offset = "0x16BCE34", VA = "0x16BCE34")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x16BCE3C", Offset = "0x16BCE3C", VA = "0x16BCE3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public int SortingOrder
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x16BCEB4", Offset = "0x16BCEB4", VA = "0x16BCEB4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x16BCEBC", Offset = "0x16BCEBC", VA = "0x16BCEBC")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public static AFPSCounter Instance
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x16BD428", Offset = "0x16BD428", VA = "0x16BD428")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30F04", Offset = "0xB30F04")]
			get
			{
				return null;
			}
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x16BD478", Offset = "0x16BD478", VA = "0x16BD478")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30F14", Offset = "0xB30F14")]
			private set
			{
			}
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x16BCF88", Offset = "0x16BCF88", VA = "0x16BCF88")]
		private AFPSCounter()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x16BD4CC", Offset = "0x16BD4CC", VA = "0x16BD4CC")]
		private static AFPSCounter GetOrCreateInstance(bool keepAlive)
		{
			return null;
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x16BD73C", Offset = "0x16BD73C", VA = "0x16BD73C")]
		public static AFPSCounter AddToScene()
		{
			return null;
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x16BD744", Offset = "0x16BD744", VA = "0x16BD744")]
		public static AFPSCounter AddToScene(bool keepAlive)
		{
			return null;
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x16BD74C", Offset = "0x16BD74C", VA = "0x16BD74C")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x16BD924", Offset = "0x16BD924", VA = "0x16BD924")]
		internal static string Color32ToHex(Color32 color)
		{
			return null;
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x16BD63C", Offset = "0x16BD63C", VA = "0x16BD63C")]
		private static AFPSCounter CreateInScene(bool lookForExistingContainer = true)
		{
			return null;
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x16BD9E4", Offset = "0x16BD9E4", VA = "0x16BD9E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x16BE050", Offset = "0x16BE050", VA = "0x16BE050")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x16BE15C", Offset = "0x16BE15C", VA = "0x16BE15C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x16BE68C", Offset = "0x16BE68C", VA = "0x16BE68C")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x16BE690", Offset = "0x16BE690", VA = "0x16BE690")]
		private void OnLevelLoadedCallback()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x16BB738", Offset = "0x16BB738", VA = "0x16BB738")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x16BBACC", Offset = "0x16BBACC", VA = "0x16BBACC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x16BE948", Offset = "0x16BE948", VA = "0x16BE948")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x16BEC04", Offset = "0x16BEC04", VA = "0x16BEC04")]
		internal void MakeDrawableLabelDirty(LabelAnchor anchor)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x16BB7B4", Offset = "0x16BB7B4", VA = "0x16BB7B4")]
		internal void UpdateTexts()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x16BDB7C", Offset = "0x16BDB7C", VA = "0x16BDB7C")]
		private void ConfigureCanvas()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x16BDDC0", Offset = "0x16BDDC0", VA = "0x16BDDC0")]
		private void ConfigureLabels()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x16BD840", Offset = "0x16BD840", VA = "0x16BD840")]
		private void DisposeInternal()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x16BE1A8", Offset = "0x16BE1A8", VA = "0x16BE1A8")]
		private void ProcessHotKey()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x16BE2AC", Offset = "0x16BE2AC", VA = "0x16BE2AC")]
		private bool CircleGestureMade()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x16BE668", Offset = "0x16BE668", VA = "0x16BE668")]
		private void SwitchCounter()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x16BE728", Offset = "0x16BE728", VA = "0x16BE728")]
		private void ActivateCounters()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x16BE7C4", Offset = "0x16BE7C4", VA = "0x16BE7C4")]
		private void DeactivateCounters()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x16BBC14", Offset = "0x16BBC14", VA = "0x16BBC14")]
		private void RefreshForcedFrameRate()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x16BE8B8", Offset = "0x16BE8B8", VA = "0x16BE8B8")]
		private void RefreshForcedFrameRate(bool disabling)
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public enum FPSLevel : byte
	{
		[Token(Token = "0x400050B")]
		Normal,
		[Token(Token = "0x400050C")]
		Warning,
		[Token(Token = "0x400050D")]
		Critical
	}
	[Token(Token = "0x20000AD")]
	public enum OperationMode : byte
	{
		[Token(Token = "0x400050F")]
		Disabled,
		[Token(Token = "0x4000510")]
		Background,
		[Token(Token = "0x4000511")]
		Normal
	}
	[Token(Token = "0x20000AE")]
	internal class UIUtils
	{
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x16BEFB8", Offset = "0x16BEFB8", VA = "0x16BEFB8")]
		internal static void ResetRectTransform(RectTransform rectTransform)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x16CAD64", Offset = "0x16CAD64", VA = "0x16CAD64")]
		public UIUtils()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class WaitForSecondsUnscaled : CustomYieldInstruction
	{
		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly float waitTime;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float runUntil;

		[Token(Token = "0x17000082")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x16CAF78", Offset = "0x16CAF78", VA = "0x16CAF78", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x16C9568", Offset = "0x16C9568", VA = "0x16C9568")]
		public new void Reset()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x16CA0E4", Offset = "0x16CA0E4", VA = "0x16CA0E4")]
		public WaitForSecondsUnscaled(float time)
		{
		}
	}
}
namespace CodeStage.AdvancedFPSCounter.Utils
{
	[Token(Token = "0x20000B0")]
	[DisallowMultipleComponent]
	public class AFPSRenderRecorder : MonoBehaviour
	{
		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool recording;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float renderTime;

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x16CAD6C", Offset = "0x16CAD6C", VA = "0x16CAD6C")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x16CAE34", Offset = "0x16CAE34", VA = "0x16CAE34")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x16CAF70", Offset = "0x16CAF70", VA = "0x16CAF70")]
		public AFPSRenderRecorder()
		{
		}
	}
}
namespace CodeStage.AdvancedFPSCounter.Labels
{
	[Token(Token = "0x20000B1")]
	internal class DrawableLabel
	{
		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal GameObject container;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal LabelAnchor anchor;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal StringBuilder newText;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal bool dirty;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject labelGameObject;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RectTransform labelTransform;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ContentSizeFitter labelFitter;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private HorizontalLayoutGroup labelGroup;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject uiTextGameObject;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Text uiText;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Font font;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int fontSize;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lineSpacing;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector2 pixelOffset;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly LabelEffect background;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Image backgroundImage;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly LabelEffect shadow;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Shadow shadowComponent;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly LabelEffect outline;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Outline outlineComponent;

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x16BF254", Offset = "0x16BF254", VA = "0x16BF254")]
		internal DrawableLabel(GameObject container, LabelAnchor anchor, LabelEffect background, LabelEffect shadow, LabelEffect outline, Font font, int fontSize, float lineSpacing, Vector2 pixelOffset)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x16BEC5C", Offset = "0x16BEC5C", VA = "0x16BEC5C")]
		internal void CheckAndUpdate()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x16BB660", Offset = "0x16BB660", VA = "0x16BB660")]
		internal void Clear()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x16BEBE0", Offset = "0x16BEBE0", VA = "0x16BEBE0")]
		internal void Dispose()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x16BC898", Offset = "0x16BC898", VA = "0x16BC898")]
		internal void ChangeFont(Font labelsFont)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x16BC96C", Offset = "0x16BC96C", VA = "0x16BC96C")]
		internal void ChangeFontSize(int newSize)
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x16BCD84", Offset = "0x16BCD84", VA = "0x16BCD84")]
		internal void ChangeOffset(Vector2 newPixelOffset)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x16BCB14", Offset = "0x16BCB14", VA = "0x16BCB14")]
		internal void ChangeLineSpacing(float newValueLineSpacing)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x16BBD34", Offset = "0x16BBD34", VA = "0x16BBD34")]
		internal void ChangeBackground(bool enabled)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x16BBE44", Offset = "0x16BBE44", VA = "0x16BBE44")]
		internal void ChangeBackgroundColor(Color color)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x16BBF1C", Offset = "0x16BBF1C", VA = "0x16BBF1C")]
		public void ChangeBackgroundPadding(int backgroundPadding)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x16BBFF0", Offset = "0x16BBFF0", VA = "0x16BBFF0")]
		internal void ChangeShadow(bool enabled)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x16BC100", Offset = "0x16BC100", VA = "0x16BC100")]
		internal void ChangeShadowColor(Color color)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x16BC238", Offset = "0x16BC238", VA = "0x16BC238")]
		internal void ChangeShadowDistance(Vector2 distance)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x16BC30C", Offset = "0x16BC30C", VA = "0x16BC30C")]
		internal void ChangeOutline(bool enabled)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x16BC41C", Offset = "0x16BC41C", VA = "0x16BC41C")]
		internal void ChangeOutlineColor(Color color)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x16BC554", Offset = "0x16BC554", VA = "0x16BC554")]
		internal void ChangeOutlineDistance(Vector2 distance)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x16CA5E0", Offset = "0x16CA5E0", VA = "0x16CA5E0")]
		private void UpdateTextPosition()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x16CA118", Offset = "0x16CA118", VA = "0x16CA118")]
		private void NormalizeOffset()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x16CAAC0", Offset = "0x16CAAC0", VA = "0x16CAAC0")]
		private void ApplyBackground()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x16CA17C", Offset = "0x16CA17C", VA = "0x16CA17C")]
		private void ApplyShadow()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x16CA334", Offset = "0x16CA334", VA = "0x16CA334")]
		private void ApplyOutline()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x16CA4EC", Offset = "0x16CA4EC", VA = "0x16CA4EC")]
		private void ApplyFont()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public enum LabelAnchor : byte
	{
		[Token(Token = "0x400052B")]
		UpperLeft,
		[Token(Token = "0x400052C")]
		UpperRight,
		[Token(Token = "0x400052D")]
		LowerLeft,
		[Token(Token = "0x400052E")]
		LowerRight,
		[Token(Token = "0x400052F")]
		UpperCenter,
		[Token(Token = "0x4000530")]
		LowerCenter
	}
}
namespace CodeStage.AdvancedFPSCounter.CountersData
{
	[Serializable]
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB269BC", Offset = "0xB269BC")]
	public abstract class BaseCounterData
	{
		[Token(Token = "0x4000531")]
		protected const string BOLD_START = "<b>";

		[Token(Token = "0x4000532")]
		protected const string BOLD_END = "</b>";

		[Token(Token = "0x4000533")]
		protected const string ITALIC_START = "<i>";

		[Token(Token = "0x4000534")]
		protected const string ITALIC_END = "</i>";

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal StringBuilder text;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal bool dirty;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected AFPSCounter main;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected string colorCached;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected bool inited;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[SerializeField]
		protected bool enabled;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B6C0", Offset = "0xB2B6C0")]
		[SerializeField]
		protected LabelAnchor anchor;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B70C", Offset = "0xB2B70C")]
		[SerializeField]
		protected Color color;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B758", Offset = "0xB2B758")]
		[SerializeField]
		protected FontStyle style;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B7A4", Offset = "0xB2B7A4")]
		protected string extraText;

		[Token(Token = "0x17000083")]
		public bool Enabled
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x16C71E0", Offset = "0x16C71E0", VA = "0x16C71E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x16C63B0", Offset = "0x16C63B0", VA = "0x16C63B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public LabelAnchor Anchor
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x16C71E8", Offset = "0x16C71E8", VA = "0x16C71E8")]
			get
			{
				return default(LabelAnchor);
			}
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x16C64D8", Offset = "0x16C64D8", VA = "0x16C64D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public Color Color
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x16C71F0", Offset = "0x16C71F0", VA = "0x16C71F0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x16C71FC", Offset = "0x16C71FC", VA = "0x16C71FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public FontStyle Style
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x16C7300", Offset = "0x16C7300", VA = "0x16C7300")]
			get
			{
				return default(FontStyle);
			}
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x16C642C", Offset = "0x16C642C", VA = "0x16C642C")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public string ExtraText
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x16C7308", Offset = "0x16C7308", VA = "0x16C7308")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x16C6480", Offset = "0x16C6480", VA = "0x16C6480")]
			set
			{
			}
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x16C72A4", Offset = "0x16C72A4", VA = "0x16C72A4")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x16C7310", Offset = "0x16C7310", VA = "0x16C7310", Slot = "4")]
		internal virtual void UpdateValue()
		{
		}

		[Token(Token = "0x60005E1")]
		internal abstract void UpdateValue(bool force);

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x16C7320", Offset = "0x16C7320", VA = "0x16C7320")]
		internal void Init(AFPSCounter reference)
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x16BEB94", Offset = "0x16BEB94", VA = "0x16BEB94")]
		internal void Dispose()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x16C7328", Offset = "0x16C7328", VA = "0x16C7328", Slot = "6")]
		internal virtual void Activate()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x16C7448", Offset = "0x16C7448", VA = "0x16C7448", Slot = "7")]
		internal virtual void Deactivate()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x16C74BC", Offset = "0x16C74BC", VA = "0x16C74BC", Slot = "8")]
		protected virtual void PerformInitActions()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x16C74C0", Offset = "0x16C74C0", VA = "0x16C74C0", Slot = "9")]
		protected virtual void PerformActivationActions()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x16C74C4", Offset = "0x16C74C4", VA = "0x16C74C4", Slot = "10")]
		protected virtual void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x60005E9")]
		protected abstract bool HasData();

		[Token(Token = "0x60005EA")]
		protected abstract void CacheCurrentColor();

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x16C74C8", Offset = "0x16C74C8", VA = "0x16C74C8")]
		protected void ApplyTextStyles()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x16C765C", Offset = "0x16C765C", VA = "0x16C765C")]
		protected BaseCounterData()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public abstract class UpdatebleCounterData : BaseCounterData
	{
		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Coroutine updateCoroutine;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected WaitForSecondsUnscaled cachedWaitForSecondsUnscaled;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B7DC", Offset = "0xB2B7DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2B7DC", Offset = "0xB2B7DC")]
		[SerializeField]
		protected float updateInterval;

		[Token(Token = "0x17000088")]
		public float UpdateInterval
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x16C9FF8", Offset = "0x16C9FF8", VA = "0x16C9FF8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x16C654C", Offset = "0x16C654C", VA = "0x16C654C")]
			set
			{
			}
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x16CA070", Offset = "0x16CA070", VA = "0x16CA070", Slot = "8")]
		protected override void PerformInitActions()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x16C9244", Offset = "0x16C9244", VA = "0x16C9244", Slot = "9")]
		protected override void PerformActivationActions()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x16C9284", Offset = "0x16C9284", VA = "0x16C9284", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x60005F2")]
		protected abstract IEnumerator UpdateCounter();

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x16CA074", Offset = "0x16CA074", VA = "0x16CA074")]
		private void StartUpdateCoroutine()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x16CA0C0", Offset = "0x16CA0C0", VA = "0x16CA0C0")]
		private void StoptUpdateCoroutine()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x16CA000", Offset = "0x16CA000", VA = "0x16CA000")]
		private void CacheWaitForSeconds()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x16C87FC", Offset = "0x16C87FC", VA = "0x16C87FC")]
		protected UpdatebleCounterData()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB269F4", Offset = "0xB269F4")]
	public class DeviceInfoCounterData : BaseCounterData
	{
		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B844", Offset = "0xB2B844")]
		[SerializeField]
		private bool platform;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B890", Offset = "0xB2B890")]
		[SerializeField]
		private bool cpuModel;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B8DC", Offset = "0xB2B8DC")]
		[SerializeField]
		private bool gpuModel;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B928", Offset = "0xB2B928")]
		[SerializeField]
		private bool gpuApi;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B974", Offset = "0xB2B974")]
		[SerializeField]
		private bool gpuSpec;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2B9C0", Offset = "0xB2B9C0")]
		[SerializeField]
		private bool ramSize;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2BA0C", Offset = "0xB2BA0C")]
		[SerializeField]
		private bool screenData;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x57")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2BA58", Offset = "0xB2BA58")]
		[SerializeField]
		private bool deviceModel;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2BAA4", Offset = "0xB2BAA4")]
		private string <LastValue>k__BackingField;

		[Token(Token = "0x17000089")]
		public bool Platform
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x16C766C", Offset = "0x16C766C", VA = "0x16C766C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x16C6D54", Offset = "0x16C6D54", VA = "0x16C6D54")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public bool CpuModel
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x16C7674", Offset = "0x16C7674", VA = "0x16C7674")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x16C6DB4", Offset = "0x16C6DB4", VA = "0x16C6DB4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public bool GpuModel
		{
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x16C767C", Offset = "0x16C767C", VA = "0x16C767C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x16C6E14", Offset = "0x16C6E14", VA = "0x16C6E14")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public bool GpuApi
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x16C7684", Offset = "0x16C7684", VA = "0x16C7684")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x16C6E74", Offset = "0x16C6E74", VA = "0x16C6E74")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public bool GpuSpec
		{
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x16C768C", Offset = "0x16C768C", VA = "0x16C768C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x16C6ED4", Offset = "0x16C6ED4", VA = "0x16C6ED4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public bool RamSize
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x16C7694", Offset = "0x16C7694", VA = "0x16C7694")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x16C6F34", Offset = "0x16C6F34", VA = "0x16C6F34")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public bool ScreenData
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x16C769C", Offset = "0x16C769C", VA = "0x16C769C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x16C6F94", Offset = "0x16C6F94", VA = "0x16C6F94")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public bool DeviceModel
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x16C76A4", Offset = "0x16C76A4", VA = "0x16C76A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x16C6FF4", Offset = "0x16C6FF4", VA = "0x16C6FF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public string LastValue
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x16C76AC", Offset = "0x16C76AC", VA = "0x16C76AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30F24", Offset = "0xB30F24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x16C76B4", Offset = "0x16C76B4", VA = "0x16C76B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30F34", Offset = "0xB30F34")]
			private set
			{
			}
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x16BD3AC", Offset = "0x16BD3AC", VA = "0x16BD3AC")]
		internal DeviceInfoCounterData()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x16C76BC", Offset = "0x16C76BC", VA = "0x16C76BC", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x16C7F10", Offset = "0x16C7F10", VA = "0x16C7F10", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x16C7F40", Offset = "0x16C7F40", VA = "0x16C7F40", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB26A2C", Offset = "0xB26A2C")]
	public class FPSCounterData : UpdatebleCounterData
	{
		[Token(Token = "0x2000117")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB26B2C", Offset = "0xB26B2C")]
		private sealed class <UpdateCounter>d__147 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FPSCounterData <>4__this;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <previousUpdateTime>5__2;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <previousUpdateFrames>5__3;

			[Token(Token = "0x17000106")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600082B")]
				[Address(RVA = "0x16C9598", Offset = "0x16C9598", VA = "0x16C9598", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000107")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600082D")]
				[Address(RVA = "0x16C9600", Offset = "0x16C9600", VA = "0x16C9600", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000828")]
			[Address(RVA = "0x16C92F8", Offset = "0x16C92F8", VA = "0x16C92F8")]
			[DebuggerHidden]
			public <UpdateCounter>d__147(int <>1__state)
			{
			}

			[Token(Token = "0x6000829")]
			[Address(RVA = "0x16C9458", Offset = "0x16C9458", VA = "0x16C9458", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600082A")]
			[Address(RVA = "0x16C945C", Offset = "0x16C945C", VA = "0x16C945C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600082C")]
			[Address(RVA = "0x16C95A0", Offset = "0x16C95A0", VA = "0x16C95A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400054B")]
		private const string COLOR_TEXT_START = "<color=#{0}>";

		[Token(Token = "0x400054C")]
		private const string COLOR_TEXT_END = "</color>";

		[Token(Token = "0x400054D")]
		private const string FPS_TEXT_START = "<color=#{0}>FPS: ";

		[Token(Token = "0x400054E")]
		private const string MS_TEXT_START = " <color=#{0}>[";

		[Token(Token = "0x400054F")]
		private const string MS_TEXT_END = " MS]</color>";

		[Token(Token = "0x4000550")]
		private const string MIN_TEXT_START = "<color=#{0}>MIN: ";

		[Token(Token = "0x4000551")]
		private const string MAX_TEXT_START = "<color=#{0}>MAX: ";

		[Token(Token = "0x4000552")]
		private const string AVG_TEXT_START = "<color=#{0}>AVG: ";

		[Token(Token = "0x4000553")]
		private const string RENDER_TEXT_START = "<color=#{0}>REN: ";

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int warningLevelValue;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int criticalLevelValue;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2BAB4", Offset = "0xB2BAB4")]
		public bool resetAverageOnNewScene;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2BAEC", Offset = "0xB2BAEC")]
		public bool resetMinMaxOnNewScene;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2BB24", Offset = "0xB2BB24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2BB24", Offset = "0xB2BB24")]
		public int minMaxIntervalsToSkip;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal float newValue;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string colorCachedMs;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string colorCachedMin;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string colorCachedMax;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string colorCachedAvg;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private string colorCachedRender;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private string colorWarningCached;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private string colorWarningCachedMs;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string colorWarningCachedMin;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private string colorWarningCachedMax;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private string colorWarningCachedAvg;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private string colorCriticalCached;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private string colorCriticalCachedMs;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private string colorCriticalCachedMin;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private string colorCriticalCachedMax;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private string colorCriticalCachedAvg;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int currentAverageSamples;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private float currentAverageRaw;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private float[] accumulatedAverageSamples;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int minMaxIntervalsSkipped;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private float renderTimeBank;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private int previousFrameCount;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2BB88", Offset = "0xB2BB88")]
		[SerializeField]
		private bool milliseconds;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2BBD4", Offset = "0xB2BBD4")]
		[SerializeField]
		private bool average;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2BC20", Offset = "0xB2BC20")]
		[SerializeField]
		private bool averageMilliseconds;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11F")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2BC6C", Offset = "0xB2BC6C")]
		[SerializeField]
		private bool averageNewLine;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2BCB8", Offset = "0xB2BCB8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB2BCB8", Offset = "0xB2BCB8")]
		[SerializeField]
		private int averageSamples;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2BD20", Offset = "0xB2BD20")]
		[SerializeField]
		private bool minMax;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x125")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2BD6C", Offset = "0xB2BD6C")]
		[SerializeField]
		private bool minMaxMilliseconds;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x126")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2BDB8", Offset = "0xB2BDB8")]
		[SerializeField]
		private bool minMaxNewLine;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x127")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2BE04", Offset = "0xB2BE04")]
		[SerializeField]
		private bool minMaxTwoLines;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2BE50", Offset = "0xB2BE50")]
		[SerializeField]
		private bool render;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2BE9C", Offset = "0xB2BE9C")]
		[SerializeField]
		private bool renderNewLine;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2BEE8", Offset = "0xB2BEE8")]
		[SerializeField]
		private bool renderAutoAdd;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2BF34", Offset = "0xB2BF34")]
		[SerializeField]
		private Color colorWarning;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2BF80", Offset = "0xB2BF80")]
		[SerializeField]
		private Color colorCritical;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2BFCC", Offset = "0xB2BFCC")]
		[SerializeField]
		protected Color colorRender;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C018", Offset = "0xB2C018")]
		private int <LastValue>k__BackingField;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C028", Offset = "0xB2C028")]
		private float <LastMillisecondsValue>k__BackingField;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C038", Offset = "0xB2C038")]
		private float <LastRenderValue>k__BackingField;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C048", Offset = "0xB2C048")]
		private int <LastAverageValue>k__BackingField;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C058", Offset = "0xB2C058")]
		private float <LastAverageMillisecondsValue>k__BackingField;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C068", Offset = "0xB2C068")]
		private int <LastMinimumValue>k__BackingField;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C078", Offset = "0xB2C078")]
		private int <LastMaximumValue>k__BackingField;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C088", Offset = "0xB2C088")]
		private float <LastMinMillisecondsValue>k__BackingField;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C098", Offset = "0xB2C098")]
		private float <LastMaxMillisecondsValue>k__BackingField;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C0A8", Offset = "0xB2C0A8")]
		private FPSLevel <CurrentFpsLevel>k__BackingField;

		[Token(Token = "0x17000092")]
		public bool Milliseconds
		{
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x16C8068", Offset = "0x16C8068", VA = "0x16C8068")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x16C65F4", Offset = "0x16C65F4", VA = "0x16C65F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public bool Average
		{
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x16C8070", Offset = "0x16C8070", VA = "0x16C8070")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x16C665C", Offset = "0x16C665C", VA = "0x16C665C")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public bool AverageMilliseconds
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x16C8078", Offset = "0x16C8078", VA = "0x16C8078")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x16C67B0", Offset = "0x16C67B0", VA = "0x16C67B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public bool AverageNewLine
		{
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x16C8080", Offset = "0x16C8080", VA = "0x16C8080")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x16C6818", Offset = "0x16C6818", VA = "0x16C6818")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public int AverageSamples
		{
			[Token(Token = "0x6000617")]
			[Address(RVA = "0x16C8088", Offset = "0x16C8088", VA = "0x16C8088")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000618")]
			[Address(RVA = "0x16C66C8", Offset = "0x16C66C8", VA = "0x16C66C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public bool MinMax
		{
			[Token(Token = "0x6000619")]
			[Address(RVA = "0x16C8090", Offset = "0x16C8090", VA = "0x16C8090")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x16C68D4", Offset = "0x16C68D4", VA = "0x16C68D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public bool MinMaxMilliseconds
		{
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x16C8098", Offset = "0x16C8098", VA = "0x16C8098")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x16C6944", Offset = "0x16C6944", VA = "0x16C6944")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public bool MinMaxNewLine
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x16C80A0", Offset = "0x16C80A0", VA = "0x16C80A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x16C6A24", Offset = "0x16C6A24", VA = "0x16C6A24")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public bool MinMaxTwoLines
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x16C80A8", Offset = "0x16C80A8", VA = "0x16C80A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x16C69C4", Offset = "0x16C69C4", VA = "0x16C69C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public bool Render
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x16C80B0", Offset = "0x16C80B0", VA = "0x16C80B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x16C6AD4", Offset = "0x16C6AD4", VA = "0x16C6AD4")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public bool RenderNewLine
		{
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x16C82AC", Offset = "0x16C82AC", VA = "0x16C82AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x16C6B5C", Offset = "0x16C6B5C", VA = "0x16C6B5C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public bool RenderAutoAdd
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x16C82B4", Offset = "0x16C82B4", VA = "0x16C82B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x16C82BC", Offset = "0x16C82BC", VA = "0x16C82BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public Color ColorWarning
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x16C8320", Offset = "0x16C8320", VA = "0x16C8320")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x16C8334", Offset = "0x16C8334", VA = "0x16C8334")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public Color ColorCritical
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x16C84D8", Offset = "0x16C84D8", VA = "0x16C84D8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x16C84EC", Offset = "0x16C84EC", VA = "0x16C84EC")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public Color ColorRender
		{
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x16C8690", Offset = "0x16C8690", VA = "0x16C8690")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x16C86A4", Offset = "0x16C86A4", VA = "0x16C86A4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public int LastValue
		{
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x16C875C", Offset = "0x16C875C", VA = "0x16C875C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30F64", Offset = "0xB30F64")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x16C8764", Offset = "0x16C8764", VA = "0x16C8764")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30F74", Offset = "0xB30F74")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public float LastMillisecondsValue
		{
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x16C876C", Offset = "0x16C876C", VA = "0x16C876C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30F84", Offset = "0xB30F84")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x16C8774", Offset = "0x16C8774", VA = "0x16C8774")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30F94", Offset = "0xB30F94")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public float LastRenderValue
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x16C877C", Offset = "0x16C877C", VA = "0x16C877C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30FA4", Offset = "0xB30FA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x16C8784", Offset = "0x16C8784", VA = "0x16C8784")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30FB4", Offset = "0xB30FB4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public int LastAverageValue
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x16C878C", Offset = "0x16C878C", VA = "0x16C878C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30FC4", Offset = "0xB30FC4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x16C8794", Offset = "0x16C8794", VA = "0x16C8794")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30FD4", Offset = "0xB30FD4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public float LastAverageMillisecondsValue
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x16C879C", Offset = "0x16C879C", VA = "0x16C879C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30FE4", Offset = "0xB30FE4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x16C87A4", Offset = "0x16C87A4", VA = "0x16C87A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30FF4", Offset = "0xB30FF4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public int LastMinimumValue
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x16C87AC", Offset = "0x16C87AC", VA = "0x16C87AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31004", Offset = "0xB31004")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x16C87B4", Offset = "0x16C87B4", VA = "0x16C87B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31014", Offset = "0xB31014")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public int LastMaximumValue
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x16C87BC", Offset = "0x16C87BC", VA = "0x16C87BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31024", Offset = "0xB31024")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x16C87C4", Offset = "0x16C87C4", VA = "0x16C87C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31034", Offset = "0xB31034")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public float LastMinMillisecondsValue
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x16C87CC", Offset = "0x16C87CC", VA = "0x16C87CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31044", Offset = "0xB31044")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x16C87D4", Offset = "0x16C87D4", VA = "0x16C87D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31054", Offset = "0xB31054")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public float LastMaxMillisecondsValue
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x16C87DC", Offset = "0x16C87DC", VA = "0x16C87DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31064", Offset = "0xB31064")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x16C87E4", Offset = "0x16C87E4", VA = "0x16C87E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31074", Offset = "0xB31074")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public FPSLevel CurrentFpsLevel
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x16C87EC", Offset = "0x16C87EC", VA = "0x16C87EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31084", Offset = "0xB31084")]
			get
			{
				return default(FPSLevel);
			}
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x16C87F4", Offset = "0x16C87F4", VA = "0x16C87F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31094", Offset = "0xB31094")]
			private set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event Action<FPSLevel> OnFPSLevelChange
		{
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x16BF3E4", Offset = "0x16BF3E4", VA = "0x16BF3E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30F44", Offset = "0xB30F44")]
			add
			{
			}
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x16C7FC4", Offset = "0x16C7FC4", VA = "0x16C7FC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB30F54", Offset = "0xB30F54")]
			remove
			{
			}
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x16BD1C0", Offset = "0x16BD1C0", VA = "0x16BD1C0")]
		internal FPSCounterData()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x16C6878", Offset = "0x16C6878", VA = "0x16C6878")]
		public void ResetAverage()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x16C6A84", Offset = "0x16C6A84", VA = "0x16C6A84")]
		public void ResetMinMax(bool withoutUpdate = false)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x16BE6BC", Offset = "0x16BE6BC", VA = "0x16BE6BC")]
		internal void OnLevelLoadedCallback()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x16C8814", Offset = "0x16C8814", VA = "0x16C8814")]
		internal void AddRenderTime(float time)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x16C8834", Offset = "0x16C8834", VA = "0x16C8834", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x16C9144", Offset = "0x16C9144", VA = "0x16C9144", Slot = "9")]
		protected override void PerformActivationActions()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x16C9248", Offset = "0x16C9248", VA = "0x16C9248", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x16C9288", Offset = "0x16C9288", VA = "0x16C9288", Slot = "13")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB310A4", Offset = "0xB310A4")]
		protected override IEnumerator UpdateCounter()
		{
			return null;
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x16C9324", Offset = "0x16C9324", VA = "0x16C9324", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x16C932C", Offset = "0x16C932C", VA = "0x16C932C", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x16C83E4", Offset = "0x16C83E4", VA = "0x16C83E4")]
		protected void CacheWarningColor()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x16C859C", Offset = "0x16C859C", VA = "0x16C859C")]
		protected void CacheCriticalColor()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x16C90C8", Offset = "0x16C90C8", VA = "0x16C90C8")]
		private float GetAverageFromAccumulatedSamples()
		{
			return default(float);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x16C81B4", Offset = "0x16C81B4", VA = "0x16C81B4")]
		private static void TryToAddRenderRecorder()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x16C80B8", Offset = "0x16C80B8", VA = "0x16C80B8")]
		private static void TryToRemoveRenderRecorder()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB26A64", Offset = "0xB26A64")]
	public class MemoryCounterData : UpdatebleCounterData
	{
		[Token(Token = "0x2000118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB26B3C", Offset = "0xB26B3C")]
		private sealed class <UpdateCounter>d__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MemoryCounterData <>4__this;

			[Token(Token = "0x17000108")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000831")]
				[Address(RVA = "0x16C9F88", Offset = "0x16C9F88", VA = "0x16C9F88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000109")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000833")]
				[Address(RVA = "0x16C9FF0", Offset = "0x16C9FF0", VA = "0x16C9FF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600082E")]
			[Address(RVA = "0x16C9E24", Offset = "0x16C9E24", VA = "0x16C9E24")]
			[DebuggerHidden]
			public <UpdateCounter>d__39(int <>1__state)
			{
			}

			[Token(Token = "0x600082F")]
			[Address(RVA = "0x16C9EF0", Offset = "0x16C9EF0", VA = "0x16C9EF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000830")]
			[Address(RVA = "0x16C9EF4", Offset = "0x16C9EF4", VA = "0x16C9EF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000832")]
			[Address(RVA = "0x16C9F90", Offset = "0x16C9F90", VA = "0x16C9F90", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000589")]
		public const long MEMORY_DIVIDER = 1048576L;

		[Token(Token = "0x400058A")]
		private const string TEXT_START = "<color=#{0}>";

		[Token(Token = "0x400058B")]
		private const string LINE_START_TOTAL = "MEM TOTAL: ";

		[Token(Token = "0x400058C")]
		private const string LINE_START_ALLOCATED = "MEM ALLOC: ";

		[Token(Token = "0x400058D")]
		private const string LINE_START_MONO = "MEM MONO: ";

		[Token(Token = "0x400058E")]
		private const string LINE_END = " MB";

		[Token(Token = "0x400058F")]
		private const string TEXT_END = "</color>";

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C0B8", Offset = "0xB2C0B8")]
		[SerializeField]
		private bool precise;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C104", Offset = "0xB2C104")]
		[SerializeField]
		private bool total;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C150", Offset = "0xB2C150")]
		[SerializeField]
		private bool allocated;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB2C19C", Offset = "0xB2C19C")]
		[SerializeField]
		private bool monoUsage;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C1E8", Offset = "0xB2C1E8")]
		private long <LastTotalValue>k__BackingField;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C1F8", Offset = "0xB2C1F8")]
		private long <LastAllocatedValue>k__BackingField;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C208", Offset = "0xB2C208")]
		private long <LastMonoValue>k__BackingField;

		[Token(Token = "0x170000AB")]
		public bool Precise
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x16C9608", Offset = "0x16C9608", VA = "0x16C9608")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x16C6BBC", Offset = "0x16C6BBC", VA = "0x16C6BBC")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public bool Total
		{
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x16C9610", Offset = "0x16C9610", VA = "0x16C9610")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000654")]
			[Address(RVA = "0x16C6C1C", Offset = "0x16C6C1C", VA = "0x16C6C1C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public bool Allocated
		{
			[Token(Token = "0x6000655")]
			[Address(RVA = "0x16C9618", Offset = "0x16C9618", VA = "0x16C9618")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000656")]
			[Address(RVA = "0x16C6C84", Offset = "0x16C6C84", VA = "0x16C6C84")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public bool MonoUsage
		{
			[Token(Token = "0x6000657")]
			[Address(RVA = "0x16C9620", Offset = "0x16C9620", VA = "0x16C9620")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x16C6CEC", Offset = "0x16C6CEC", VA = "0x16C6CEC")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public long LastTotalValue
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0x16C9628", Offset = "0x16C9628", VA = "0x16C9628")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31108", Offset = "0xB31108")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x16C9630", Offset = "0x16C9630", VA = "0x16C9630")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31118", Offset = "0xB31118")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public long LastAllocatedValue
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x16C9638", Offset = "0x16C9638", VA = "0x16C9638")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31128", Offset = "0xB31128")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600065C")]
			[Address(RVA = "0x16C9640", Offset = "0x16C9640", VA = "0x16C9640")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31138", Offset = "0xB31138")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public long LastMonoValue
		{
			[Token(Token = "0x600065D")]
			[Address(RVA = "0x16C9648", Offset = "0x16C9648", VA = "0x16C9648")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31148", Offset = "0xB31148")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600065E")]
			[Address(RVA = "0x16C9650", Offset = "0x16C9650", VA = "0x16C9650")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB31158", Offset = "0xB31158")]
			private set
			{
			}
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x16BD32C", Offset = "0x16BD32C", VA = "0x16BD32C")]
		internal MemoryCounterData()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x16C9658", Offset = "0x16C9658", VA = "0x16C9658", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x16C9ACC", Offset = "0x16C9ACC", VA = "0x16C9ACC", Slot = "9")]
		protected override void PerformActivationActions()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x16C9D70", Offset = "0x16C9D70", VA = "0x16C9D70", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x16C9DB4", Offset = "0x16C9DB4", VA = "0x16C9DB4", Slot = "13")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB31168", Offset = "0xB31168")]
		protected override IEnumerator UpdateCounter()
		{
			return null;
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x16C9E50", Offset = "0x16C9E50", VA = "0x16C9E50", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x16C9E78", Offset = "0x16C9E78", VA = "0x16C9E78", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}
	}
}
namespace AndroidRuntimePermissionsNamespace
{
	[Token(Token = "0x20000B8")]
	public class PermissionCallback : AndroidJavaProxy
	{
		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object threadLock;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB2C218", Offset = "0xB2C218")]
		private string <Result>k__BackingField;

		[Token(Token = "0x170000B2")]
		public string Result
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x16BB21C", Offset = "0x16BB21C", VA = "0x16BB21C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB311CC", Offset = "0xB311CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x16BB224", Offset = "0x16BB224", VA = "0x16BB224")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB311DC", Offset = "0xB311DC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x16B9E24", Offset = "0x16B9E24", VA = "0x16B9E24")]
		public PermissionCallback(object threadLock)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x16BB22C", Offset = "0x16BB22C", VA = "0x16BB22C")]
		public void OnPermissionResult(string result)
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class PermissionCallbackAsync : AndroidJavaProxy
	{
		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string result;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string[] permissions;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AndroidRuntimePermissions.PermissionResultMultiple callback;

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x16BA420", Offset = "0x16BA420", VA = "0x16BA420")]
		public PermissionCallbackAsync(string[] permissions, AndroidRuntimePermissions.PermissionResultMultiple callback)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x16BB2C0", Offset = "0x16BB2C0", VA = "0x16BB2C0")]
		public void OnPermissionResult(string result)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x16BB340", Offset = "0x16BB340", VA = "0x16BB340")]
		private void ExecuteCallback()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class MainThreadDispatcher : MonoBehaviour
	{
		[Token(Token = "0x2000119")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB26B4C", Offset = "0xB26B4C")]
		private sealed class <ExecuteOnMainThreadCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action functionToExecute;

			[Token(Token = "0x1700010A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000837")]
				[Address(RVA = "0x16BB1AC", Offset = "0x16BB1AC", VA = "0x16BB1AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000839")]
				[Address(RVA = "0x16BB214", Offset = "0x16BB214", VA = "0x16BB214", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000834")]
			[Address(RVA = "0x16BB11C", Offset = "0x16BB11C", VA = "0x16BB11C")]
			[DebuggerHidden]
			public <ExecuteOnMainThreadCoroutine>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000835")]
			[Address(RVA = "0x16BB150", Offset = "0x16BB150", VA = "0x16BB150", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000836")]
			[Address(RVA = "0x16BB154", Offset = "0x16BB154", VA = "0x16BB154", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000838")]
			[Address(RVA = "0x16BB1B4", Offset = "0x16BB1B4", VA = "0x16BB1B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static MainThreadDispatcher m_instance;

		[Token(Token = "0x170000B3")]
		private static MainThreadDispatcher Instance
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x16BAF30", Offset = "0x16BAF30", VA = "0x16BAF30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x16BB05C", Offset = "0x16BB05C", VA = "0x16BB05C")]
		public static void ExecuteOnMainThread(Action functionToExecute)
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x16BB0AC", Offset = "0x16BB0AC", VA = "0x16BB0AC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB311EC", Offset = "0xB311EC")]
		private static IEnumerator ExecuteOnMainThreadCoroutine(Action functionToExecute)
		{
			return null;
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x16BB148", Offset = "0x16BB148", VA = "0x16BB148")]
		public MainThreadDispatcher()
		{
		}
	}
}
