using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;
using UnityEngine.Events;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class GooglePlayDownloader
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AndroidJavaClass detectAndroidJNI;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static AndroidJavaClass Environment;

	[Token(Token = "0x4000003")]
	private const string Environment_MEDIA_MOUNTED = "mounted";

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string obb_package;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int obb_version;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x23D1364", Offset = "0x23D1364", VA = "0x23D1364")]
	public static bool RunningOnAndroid()
	{
		return default(bool);
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x23D1480", Offset = "0x23D1480", VA = "0x23D1480")]
	static GooglePlayDownloader()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x23D170C", Offset = "0x23D170C", VA = "0x23D170C")]
	public static string GetExpansionFilePath()
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x23D20C8", Offset = "0x23D20C8", VA = "0x23D20C8")]
	public static string GetMainOBBPath(string expansionFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x23D21D0", Offset = "0x23D21D0", VA = "0x23D21D0")]
	public static string GetPatchOBBPath(string expansionFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x23D22D8", Offset = "0x23D22D8", VA = "0x23D22D8")]
	public static void FetchOBB()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x23D1B88", Offset = "0x23D1B88", VA = "0x23D1B88")]
	private static void populateOBBData()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x23D2A64", Offset = "0x23D2A64", VA = "0x23D2A64")]
	public GooglePlayDownloader()
	{
	}
}
[Token(Token = "0x2000003")]
public class Skeleton : MonoBehaviour
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PuppetMaster puppetMaster;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ConfigurableJoint[] leftLeg;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ConfigurableJoint[] rightLeg;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool leftLegRemoved;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool rightLegRemoved;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2673C74", Offset = "0x2673C74", VA = "0x2673C74")]
	private void Start()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2673D64", Offset = "0x2673D64", VA = "0x2673D64")]
	private void OnMuscleRemoved(Muscle m)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2673E28", Offset = "0x2673E28", VA = "0x2673E28")]
	private bool IsLegMuscle(Muscle m, out bool isLeft)
	{
		return default(bool);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2673FAC", Offset = "0x2673FAC", VA = "0x2673FAC")]
	public Skeleton()
	{
	}
}
[Token(Token = "0x2000004")]
public class ColliderEventBroadcaster : MonoBehaviour
{
	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x23D0024", Offset = "0x23D0024", VA = "0x23D0024")]
	private void OnCollisionEnter(Collision collider)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x23D00E4", Offset = "0x23D00E4", VA = "0x23D00E4")]
	private void OnCollisionStay(Collision collider)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x23D01A4", Offset = "0x23D01A4", VA = "0x23D01A4")]
	private void OnCollisionExit(Collision collider)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x23D0264", Offset = "0x23D0264", VA = "0x23D0264")]
	public ColliderEventBroadcaster()
	{
	}
}
[Token(Token = "0x2000005")]
public class CollisionEventBroadcaster : MonoBehaviour
{
	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x23D026C", Offset = "0x23D026C", VA = "0x23D026C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x23D032C", Offset = "0x23D032C", VA = "0x23D032C")]
	private void OnCollisionStay(Collision collision)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x23D03EC", Offset = "0x23D03EC", VA = "0x23D03EC")]
	private void OnCollisionExit(Collision collision)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x23D04AC", Offset = "0x23D04AC", VA = "0x23D04AC")]
	public CollisionEventBroadcaster()
	{
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000006")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000007")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000034")]
			Update,
			[Token(Token = "0x4000035")]
			FixedUpdate,
			[Token(Token = "0x4000036")]
			LateUpdate,
			[Token(Token = "0x4000037")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D1C54", Offset = "0x9D1C54")]
		public bool smoothFollow;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D1C8C", Offset = "0x9D1C8C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D1CC4", Offset = "0x9D1CC4")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D1CFC", Offset = "0x9D1CFC")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D1D34", Offset = "0x9D1D34")]
		public float blockedOffset;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1D4C", Offset = "0x9D1D4C")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1D5C", Offset = "0x9D1D5C")]
		private float <y>k__BackingField;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1D6C", Offset = "0x9D1D6C")]
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

		[Token(Token = "0x17000001")]
		public float x
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x2666A94", Offset = "0x2666A94", VA = "0x2666A94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D4FEC", Offset = "0x9D4FEC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x2666A9C", Offset = "0x2666A9C", VA = "0x2666A9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D4FFC", Offset = "0x9D4FFC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float y
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x2666AA4", Offset = "0x2666AA4", VA = "0x2666AA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D500C", Offset = "0x9D500C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x2666AAC", Offset = "0x2666AAC", VA = "0x2666AAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D501C", Offset = "0x9D501C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public float distanceTarget
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x2666AB4", Offset = "0x2666AB4", VA = "0x2666AB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D502C", Offset = "0x9D502C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x2666ABC", Offset = "0x2666ABC", VA = "0x2666ABC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D503C", Offset = "0x9D503C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		private float zoomAdd
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x266730C", Offset = "0x266730C", VA = "0x266730C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2666AC4", Offset = "0x2666AC4", VA = "0x2666AC4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2666BD4", Offset = "0x2666BD4", VA = "0x2666BD4", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2666C30", Offset = "0x2666C30", VA = "0x2666C30", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2666C98", Offset = "0x2666C98", VA = "0x2666C98", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2666CFC", Offset = "0x2666CFC", VA = "0x2666CFC")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2666C08", Offset = "0x2666C08", VA = "0x2666C08")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2666E7C", Offset = "0x2666E7C", VA = "0x2666E7C")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x26672DC", Offset = "0x26672DC", VA = "0x26672DC")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x266737C", Offset = "0x266737C", VA = "0x266737C")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2667420", Offset = "0x2667420", VA = "0x2667420")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2667458", Offset = "0x2667458", VA = "0x2667458")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2667600", Offset = "0x2667600", VA = "0x2667600")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2667630", Offset = "0x2667630", VA = "0x2667630")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000009")]
	public enum Axis
	{
		[Token(Token = "0x400003E")]
		X,
		[Token(Token = "0x400003F")]
		Y,
		[Token(Token = "0x4000040")]
		Z
	}
	[Token(Token = "0x200000A")]
	public class AxisTools
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2655E30", Offset = "0x2655E30", VA = "0x2655E30")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2655E54", Offset = "0x2655E54", VA = "0x2655E54")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2655E8C", Offset = "0x2655E8C", VA = "0x2655E8C")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2655F7C", Offset = "0x2655F7C", VA = "0x2655F7C")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2655F24", Offset = "0x2655F24", VA = "0x2655F24")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2656014", Offset = "0x2656014", VA = "0x2656014")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2656170", Offset = "0x2656170", VA = "0x2656170")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x200000C")]
		public class LimbOrientation
		{
			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000033")]
			[Address(RVA = "0x2679890", Offset = "0x2679890", VA = "0x2679890")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000005")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x265AD5C", Offset = "0x265AD5C", VA = "0x265AD5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x265AFCC", Offset = "0x265AFCC", VA = "0x265AFCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x265ACDC", Offset = "0x265ACDC", VA = "0x265ACDC")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x200000D")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x200000E")]
		public enum BoneType
		{
			[Token(Token = "0x400005B")]
			Unassigned,
			[Token(Token = "0x400005C")]
			Spine,
			[Token(Token = "0x400005D")]
			Head,
			[Token(Token = "0x400005E")]
			Arm,
			[Token(Token = "0x400005F")]
			Leg,
			[Token(Token = "0x4000060")]
			Tail,
			[Token(Token = "0x4000061")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x200000F")]
		public enum BoneSide
		{
			[Token(Token = "0x4000063")]
			Center,
			[Token(Token = "0x4000064")]
			Left,
			[Token(Token = "0x4000065")]
			Right
		}

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x265B23C", Offset = "0x265B23C", VA = "0x265B23C")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x265B560", Offset = "0x265B560", VA = "0x265B560")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x265B7D4", Offset = "0x265B7D4", VA = "0x265B7D4")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x265B854", Offset = "0x265B854", VA = "0x265B854")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x265B8FC", Offset = "0x265B8FC", VA = "0x265B8FC")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x265B414", Offset = "0x265B414", VA = "0x265B414")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x265B738", Offset = "0x265B738", VA = "0x265B738")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x265C12C", Offset = "0x265C12C", VA = "0x265C12C")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x265BF34", Offset = "0x265BF34", VA = "0x265BF34")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x265C030", Offset = "0x265C030", VA = "0x265C030")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x265BB14", Offset = "0x265BB14", VA = "0x265BB14")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x265BBC4", Offset = "0x265BBC4", VA = "0x265BBC4")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x265BC74", Offset = "0x265BC74", VA = "0x265BC74")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x265BD24", Offset = "0x265BD24", VA = "0x265BD24")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x265BDD4", Offset = "0x265BDD4", VA = "0x265BDD4")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x265BE84", Offset = "0x265BE84", VA = "0x265BE84")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x265C334", Offset = "0x265C334", VA = "0x265C334")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x265BA2C", Offset = "0x265BA2C", VA = "0x265BA2C")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x265C2A4", Offset = "0x265C2A4", VA = "0x265C2A4")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x265C3A0", Offset = "0x265C3A0", VA = "0x265C3A0")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x265C474", Offset = "0x265C474", VA = "0x265C474")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x265C22C", Offset = "0x265C22C", VA = "0x265C22C")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x265C1B8", Offset = "0x265C1B8", VA = "0x265C1B8")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000010")]
	public class BipedReferences
	{
		[Token(Token = "0x2000011")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x4000077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x4000078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x17000009")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000065")]
				[Address(RVA = "0x2679954", Offset = "0x2679954", VA = "0x2679954")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000064")]
			[Address(RVA = "0x2679940", Offset = "0x2679940", VA = "0x2679940")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000007")]
		public virtual bool isFilled
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x266311C", Offset = "0x266311C", VA = "0x266311C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public bool isEmpty
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x2663504", Offset = "0x2663504", VA = "0x2663504")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2663514", Offset = "0x2663514", VA = "0x2663514", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x266393C", Offset = "0x266393C", VA = "0x266393C", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2663D70", Offset = "0x2663D70", VA = "0x2663D70")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x26644C4", Offset = "0x26644C4", VA = "0x26644C4")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2664020", Offset = "0x2664020", VA = "0x2664020")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2664D48", Offset = "0x2664D48", VA = "0x2664D48")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2664E44", Offset = "0x2664E44", VA = "0x2664E44")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2665400", Offset = "0x2665400", VA = "0x2665400")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x26651E0", Offset = "0x26651E0", VA = "0x26651E0")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x266505C", Offset = "0x266505C", VA = "0x266505C")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2664EE4", Offset = "0x2664EE4", VA = "0x2664EE4")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x26652EC", Offset = "0x26652EC", VA = "0x26652EC")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x26654F8", Offset = "0x26654F8", VA = "0x26654F8")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x26660E0", Offset = "0x26660E0", VA = "0x26660E0")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2665B50", Offset = "0x2665B50", VA = "0x2665B50")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x26663DC", Offset = "0x26663DC", VA = "0x26663DC")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2665EC8", Offset = "0x2665EC8", VA = "0x2665EC8")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x26663E4", Offset = "0x26663E4", VA = "0x26663E4")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x26663EC", Offset = "0x26663EC", VA = "0x26663EC")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x26665C0", Offset = "0x26665C0", VA = "0x26665C0")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2666788", Offset = "0x2666788", VA = "0x2666788")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2663F9C", Offset = "0x2663F9C", VA = "0x2663F9C")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "MultilineAttribute", RVA = "0x9D1D7C", Offset = "0x9D1D7C")]
		public string text;

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x23D04B4", Offset = "0x23D04B4", VA = "0x23D04B4")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x23D09B0", Offset = "0x23D09B0", VA = "0x23D09B0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x23D0AF8", Offset = "0x23D0AF8", VA = "0x23D0AF8")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class Hierarchy
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x23D3048", Offset = "0x23D3048", VA = "0x23D3048")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x23D3234", Offset = "0x23D3234", VA = "0x23D3234")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x23D30E0", Offset = "0x23D30E0", VA = "0x23D30E0")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x23D3354", Offset = "0x23D3354", VA = "0x23D3354")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x23D3480", Offset = "0x23D3480", VA = "0x23D3480")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x23D36D4", Offset = "0x23D36D4", VA = "0x23D36D4")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x23D37DC", Offset = "0x23D37DC", VA = "0x23D37DC")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x23D3950", Offset = "0x23D3950", VA = "0x23D3950")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x23D3D2C", Offset = "0x23D3D2C", VA = "0x23D3D2C")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x23D3AF0", Offset = "0x23D3AF0", VA = "0x23D3AF0")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x23D3EE0", Offset = "0x23D3EE0", VA = "0x23D3EE0")]
		public Hierarchy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000015")]
	public enum InterpolationMode
	{
		[Token(Token = "0x400007D")]
		None,
		[Token(Token = "0x400007E")]
		InOutCubic,
		[Token(Token = "0x400007F")]
		InOutQuintic,
		[Token(Token = "0x4000080")]
		InOutSine,
		[Token(Token = "0x4000081")]
		InQuintic,
		[Token(Token = "0x4000082")]
		InQuartic,
		[Token(Token = "0x4000083")]
		InCubic,
		[Token(Token = "0x4000084")]
		InQuadratic,
		[Token(Token = "0x4000085")]
		InElastic,
		[Token(Token = "0x4000086")]
		InElasticSmall,
		[Token(Token = "0x4000087")]
		InElasticBig,
		[Token(Token = "0x4000088")]
		InSine,
		[Token(Token = "0x4000089")]
		InBack,
		[Token(Token = "0x400008A")]
		OutQuintic,
		[Token(Token = "0x400008B")]
		OutQuartic,
		[Token(Token = "0x400008C")]
		OutCubic,
		[Token(Token = "0x400008D")]
		OutInCubic,
		[Token(Token = "0x400008E")]
		OutInQuartic,
		[Token(Token = "0x400008F")]
		OutElastic,
		[Token(Token = "0x4000090")]
		OutElasticSmall,
		[Token(Token = "0x4000091")]
		OutElasticBig,
		[Token(Token = "0x4000092")]
		OutSine,
		[Token(Token = "0x4000093")]
		OutBack,
		[Token(Token = "0x4000094")]
		OutBackCubic,
		[Token(Token = "0x4000095")]
		OutBackQuartic,
		[Token(Token = "0x4000096")]
		BackInCubic,
		[Token(Token = "0x4000097")]
		BackInQuartic
	}
	[Token(Token = "0x2000016")]
	public class Interp
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x23D3F54", Offset = "0x23D3F54", VA = "0x23D3F54")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x23D4900", Offset = "0x23D4900", VA = "0x23D4900")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x23D4974", Offset = "0x23D4974", VA = "0x23D4974")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x23D4368", Offset = "0x23D4368", VA = "0x23D4368")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x23D4374", Offset = "0x23D4374", VA = "0x23D4374")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x23D4398", Offset = "0x23D4398", VA = "0x23D4398")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x23D43D4", Offset = "0x23D43D4", VA = "0x23D43D4")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x23D43EC", Offset = "0x23D43EC", VA = "0x23D43EC")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x23D4400", Offset = "0x23D4400", VA = "0x23D4400")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x23D4414", Offset = "0x23D4414", VA = "0x23D4414")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x23D4424", Offset = "0x23D4424", VA = "0x23D4424")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x23D446C", Offset = "0x23D446C", VA = "0x23D446C")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x23D44A4", Offset = "0x23D44A4", VA = "0x23D44A4")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x23D44CC", Offset = "0x23D44CC", VA = "0x23D44CC")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x23D4A00", Offset = "0x23D4A00", VA = "0x23D4A00")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x23D4500", Offset = "0x23D4500", VA = "0x23D4500")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x23D4528", Offset = "0x23D4528", VA = "0x23D4528")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x23D4558", Offset = "0x23D4558", VA = "0x23D4558")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x23D458C", Offset = "0x23D458C", VA = "0x23D458C")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x23D45D0", Offset = "0x23D45D0", VA = "0x23D45D0")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x23D4634", Offset = "0x23D4634", VA = "0x23D4634")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x23D4698", Offset = "0x23D4698", VA = "0x23D4698")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x23D46EC", Offset = "0x23D46EC", VA = "0x23D46EC")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x23D4740", Offset = "0x23D4740", VA = "0x23D4740")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x23D477C", Offset = "0x23D477C", VA = "0x23D477C")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x23D47B4", Offset = "0x23D47B4", VA = "0x23D47B4")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x23D4A34", Offset = "0x23D4A34", VA = "0x23D4A34")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x23D47FC", Offset = "0x23D47FC", VA = "0x23D47FC")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x23D4890", Offset = "0x23D4890", VA = "0x23D4890")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x23D48C0", Offset = "0x23D48C0", VA = "0x23D48C0")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x23D4AC8", Offset = "0x23D4AC8", VA = "0x23D4AC8")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x23D6804", Offset = "0x23D6804", VA = "0x23D6804")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x23D6890", Offset = "0x23D6890", VA = "0x23D6890")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000018")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x23D6920", Offset = "0x23D6920", VA = "0x23D6920")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x23D6978", Offset = "0x23D6978", VA = "0x23D6978")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x23D6A44", Offset = "0x23D6A44", VA = "0x23D6A44")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x23D6990", Offset = "0x23D6990", VA = "0x23D6990")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x23D6A5C", Offset = "0x23D6A5C", VA = "0x23D6A5C")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x23D6B00", Offset = "0x23D6B00", VA = "0x23D6B00")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x23D6B2C", Offset = "0x23D6B2C", VA = "0x23D6B2C")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x23D6B7C", Offset = "0x23D6B7C", VA = "0x23D6B7C")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x23D6BE8", Offset = "0x23D6BE8", VA = "0x23D6BE8")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x23D6CFC", Offset = "0x23D6CFC", VA = "0x23D6CFC")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x23D6DF4", Offset = "0x23D6DF4", VA = "0x23D6DF4")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x23D6E50", Offset = "0x23D6E50", VA = "0x23D6E50")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000019")]
	public static class QuaTools
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2671084", Offset = "0x2671084", VA = "0x2671084")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x26710D4", Offset = "0x26710D4", VA = "0x26710D4")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2671124", Offset = "0x2671124", VA = "0x2671124")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x26711CC", Offset = "0x26711CC", VA = "0x26711CC")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2671274", Offset = "0x2671274", VA = "0x2671274")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2671354", Offset = "0x2671354", VA = "0x2671354")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x26713A8", Offset = "0x26713A8", VA = "0x26713A8")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x267147C", Offset = "0x267147C", VA = "0x267147C")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x267158C", Offset = "0x267158C", VA = "0x267158C")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x267171C", Offset = "0x267171C", VA = "0x267171C")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2671810", Offset = "0x2671810", VA = "0x2671810")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x200001A")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700000A")]
		public static T instance
		{
			[Token(Token = "0x60000AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000AD")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000AE")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D1D8C", Offset = "0x9D1D8C")]
		public bool fixTransforms;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000B")]
		private bool animatePhysics
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x26745B4", Offset = "0x26745B4", VA = "0x26745B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		private bool isAnimated
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x2674900", Offset = "0x2674900", VA = "0x2674900")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2674474", Offset = "0x2674474", VA = "0x2674474")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2674514", Offset = "0x2674514", VA = "0x2674514", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2674518", Offset = "0x2674518", VA = "0x2674518", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x267451C", Offset = "0x267451C", VA = "0x267451C", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2674520", Offset = "0x2674520", VA = "0x2674520")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x26745B0", Offset = "0x26745B0", VA = "0x26745B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2674558", Offset = "0x2674558", VA = "0x2674558")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x26748B4", Offset = "0x26748B4", VA = "0x26748B4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x26746A0", Offset = "0x26746A0", VA = "0x26746A0")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x26749B8", Offset = "0x26749B8", VA = "0x26749B8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2674A14", Offset = "0x2674A14", VA = "0x2674A14")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2674A70", Offset = "0x2674A70", VA = "0x2674A70")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2674AB8", Offset = "0x2674AB8", VA = "0x2674AB8")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2676340", Offset = "0x2676340", VA = "0x2676340")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2676400", Offset = "0x2676400", VA = "0x2676400")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x26764C0", Offset = "0x26764C0", VA = "0x26764C0")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2676580", Offset = "0x2676580", VA = "0x2676580")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public static class V3Tools
	{
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2676D6C", Offset = "0x2676D6C", VA = "0x2676D6C")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2676E0C", Offset = "0x2676E0C", VA = "0x2676E0C")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2676E48", Offset = "0x2676E48", VA = "0x2676E48")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2676E8C", Offset = "0x2676E8C", VA = "0x2676E8C")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2676F28", Offset = "0x2676F28", VA = "0x2676F28")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x26770A4", Offset = "0x26770A4", VA = "0x26770A4")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2677228", Offset = "0x2677228", VA = "0x2677228")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x26772E4", Offset = "0x26772E4", VA = "0x26772E4")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200001E")]
	public static class Warning
	{
		[Token(Token = "0x200001F")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x26773E4", Offset = "0x26773E4", VA = "0x26773E4")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x26777EC", Offset = "0x26777EC", VA = "0x26777EC")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D14D4", Offset = "0x9D14D4")]
	public class AnimatorIKDemo : MonoBehaviour
	{
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftHandIKTarget;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2655D2C", Offset = "0x2655D2C", VA = "0x2655D2C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2655D88", Offset = "0x2655D88", VA = "0x2655D88")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2655DE4", Offset = "0x2655DE4", VA = "0x2655DE4")]
		public AnimatorIKDemo()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class BallShooter : MonoBehaviour
	{
		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode keyCode;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject ball;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 spawnOffset;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 force;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float mass;

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2656178", Offset = "0x2656178", VA = "0x2656178")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x26563A0", Offset = "0x26563A0", VA = "0x26563A0")]
		public BallShooter()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class CharacterAnimationMeleeDemo : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x1700000D")]
		private CharacterMeleeDemo melee
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x2667B20", Offset = "0x2667B20", VA = "0x2667B20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2667BA0", Offset = "0x2667BA0", VA = "0x2667BA0", Slot = "9")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2668020", Offset = "0x2668020", VA = "0x2668020")]
		public CharacterAnimationMeleeDemo()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class CharacterMeleeDemo : CharacterPuppet
	{
		[Serializable]
		[Token(Token = "0x2000024")]
		public class Action
		{
			[Serializable]
			[Token(Token = "0x2000025")]
			public class Anim
			{
				[Token(Token = "0x40000B5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string stateName;

				[Token(Token = "0x40000B6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public int layer;

				[Token(Token = "0x40000B7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public float transitionDuration;

				[Token(Token = "0x40000B8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public float fixedTime;

				[Token(Token = "0x60000DF")]
				[Address(RVA = "0x267B584", Offset = "0x267B584", VA = "0x267B584")]
				public Anim()
				{
				}
			}

			[Token(Token = "0x40000AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x40000AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int inputActionIndex;

			[Token(Token = "0x40000B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float duration;

			[Token(Token = "0x40000B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float minFrequency;

			[Token(Token = "0x40000B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Anim anim;

			[Token(Token = "0x40000B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int[] requiredPropTypes;

			[Token(Token = "0x40000B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Booster[] boosters;

			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x267995C", Offset = "0x267995C", VA = "0x267995C")]
			public Action()
			{
			}
		}

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D1DC4", Offset = "0x9D1DC4")]
		public Action[] actions;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[HideInInspector]
		public int currentActionIndex;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		[HideInInspector]
		public float lastActionTime;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private float lastActionMoveMag;

		[Token(Token = "0x1700000E")]
		public Action currentAction
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x23CDCF0", Offset = "0x23CDCF0", VA = "0x23CDCF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x23CDC64", Offset = "0x23CDC64", VA = "0x23CDC64", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x23CDD3C", Offset = "0x23CDD3C", VA = "0x23CDD3C", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x23CDF58", Offset = "0x23CDF58", VA = "0x23CDF58")]
		private bool StartAction(Action action)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x23CE1C0", Offset = "0x23CE1C0", VA = "0x23CE1C0")]
		public CharacterMeleeDemo()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class CharacterPuppet : CharacterThirdPerson
	{
		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D1E1C", Offset = "0x9D1E1C")]
		public PropRoot propRoot;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1E54", Offset = "0x9D1E54")]
		private BehaviourPuppet <puppet>k__BackingField;

		[Token(Token = "0x1700000F")]
		public BehaviourPuppet puppet
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x23CE1D0", Offset = "0x23CE1D0", VA = "0x23CE1D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D50BC", Offset = "0x9D50BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x23CE1D8", Offset = "0x23CE1D8", VA = "0x23CE1D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D50CC", Offset = "0x9D50CC")]
			private set
			{
			}
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x23CDC70", Offset = "0x23CDC70", VA = "0x23CDC70", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x23CE354", Offset = "0x23CE354", VA = "0x23CE354", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x23CE420", Offset = "0x23CE420", VA = "0x23CE420", Slot = "9")]
		protected override void Rotate()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x23CE918", Offset = "0x23CE918", VA = "0x23CE918", Slot = "10")]
		protected override bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x23CE1CC", Offset = "0x23CE1CC", VA = "0x23CE1CC")]
		public CharacterPuppet()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class CreatePuppetInRuntime : MonoBehaviour
	{
		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D1E64", Offset = "0x9D1E64")]
		public Transform ragdollPrefab;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D1E9C", Offset = "0x9D1E9C")]
		public string instanceName;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D1ED4", Offset = "0x9D1ED4")]
		public int characterControllerLayer;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D1F0C", Offset = "0x9D1F0C")]
		public int ragdollLayer;

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x23D04BC", Offset = "0x23D04BC", VA = "0x23D04BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x23D07A4", Offset = "0x23D07A4", VA = "0x23D07A4")]
		public CreatePuppetInRuntime()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class CreateRagdollInRuntime : MonoBehaviour
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D1F44", Offset = "0x9D1F44")]
		public GameObject prefab;

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x23D0800", Offset = "0x23D0800", VA = "0x23D0800")]
		private void Start()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x23D09A4", Offset = "0x23D09A4", VA = "0x23D09A4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x23D09A8", Offset = "0x23D09A8", VA = "0x23D09A8")]
		public CreateRagdollInRuntime()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class Destructor : MonoBehaviour
	{
		[Token(Token = "0x200002A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1534", Offset = "0x9D1534")]
		private sealed class <Destruct>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Destructor <>4__this;

			[Token(Token = "0x17000010")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000F2")]
				[Address(RVA = "0x2679A9C", Offset = "0x2679A9C", VA = "0x2679A9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000011")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000F4")]
				[Address(RVA = "0x2679AE4", Offset = "0x2679AE4", VA = "0x2679AE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x267996C", Offset = "0x267996C", VA = "0x267996C")]
			[DebuggerHidden]
			public <Destruct>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x2679998", Offset = "0x2679998", VA = "0x2679998", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x267999C", Offset = "0x267999C", VA = "0x267999C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x2679AA4", Offset = "0x2679AA4", VA = "0x2679AA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float delay;

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x23D0B2C", Offset = "0x23D0B2C", VA = "0x23D0B2C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x23D0B58", Offset = "0x23D0B58", VA = "0x23D0B58")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9D50DC", Offset = "0x9D50DC")]
		private IEnumerator Destruct()
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x23D0BD0", Offset = "0x23D0BD0", VA = "0x23D0BD0")]
		public Destructor()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class Dying : MonoBehaviour
	{
		[Token(Token = "0x200002C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1544", Offset = "0x9D1544")]
		private sealed class <FadeOutPinWeight>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dying <>4__this;

			[Token(Token = "0x17000012")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000FD")]
				[Address(RVA = "0x2679CE8", Offset = "0x2679CE8", VA = "0x2679CE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000013")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000FF")]
				[Address(RVA = "0x2679D30", Offset = "0x2679D30", VA = "0x2679D30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x2679C14", Offset = "0x2679C14", VA = "0x2679C14")]
			[DebuggerHidden]
			public <FadeOutPinWeight>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x2679C40", Offset = "0x2679C40", VA = "0x2679C40", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x2679C44", Offset = "0x2679C44", VA = "0x2679C44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x2679CF0", Offset = "0x2679CF0", VA = "0x2679CF0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200002D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1554", Offset = "0x9D1554")]
		private sealed class <FadeOutMuscleWeight>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dying <>4__this;

			[Token(Token = "0x17000014")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000103")]
				[Address(RVA = "0x2679BC4", Offset = "0x2679BC4", VA = "0x2679BC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000015")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000105")]
				[Address(RVA = "0x2679C0C", Offset = "0x2679C0C", VA = "0x2679C0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000100")]
			[Address(RVA = "0x2679AEC", Offset = "0x2679AEC", VA = "0x2679AEC")]
			[DebuggerHidden]
			public <FadeOutMuscleWeight>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000101")]
			[Address(RVA = "0x2679B18", Offset = "0x2679B18", VA = "0x2679B18", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000102")]
			[Address(RVA = "0x2679B1C", Offset = "0x2679B1C", VA = "0x2679B1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000104")]
			[Address(RVA = "0x2679BCC", Offset = "0x2679BCC", VA = "0x2679BCC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D1F7C", Offset = "0x9D1F7C")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D1FB4", Offset = "0x9D1FB4")]
		public float fadeOutPinWeightSpeed;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D1FEC", Offset = "0x9D1FEC")]
		public float fadeOutMuscleWeightSpeed;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2024", Offset = "0x9D2024")]
		public float deadMuscleWeight;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool isDead;

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x23D0BE0", Offset = "0x23D0BE0", VA = "0x23D0BE0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x23D0C84", Offset = "0x23D0C84", VA = "0x23D0C84")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x23D0E74", Offset = "0x23D0E74", VA = "0x23D0E74")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9D518C", Offset = "0x9D518C")]
		private IEnumerator FadeOutPinWeight()
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x23D0EEC", Offset = "0x23D0EEC", VA = "0x23D0EEC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9D51EC", Offset = "0x9D51EC")]
		private IEnumerator FadeOutMuscleWeight()
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x23D0F64", Offset = "0x23D0F64", VA = "0x23D0F64")]
		public Dying()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D1564", Offset = "0x9D1564")]
	public class FXCollisionBlood : MonoBehaviour
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minCollisionImpulse;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int emission;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float emissionImpulseAdd;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int maxEmission;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem particles;

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x23D0FAC", Offset = "0x23D0FAC", VA = "0x23D0FAC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x23D10AC", Offset = "0x23D10AC", VA = "0x23D10AC")]
		private void OnCollisionImpulse(MuscleCollision m, float impulse)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x23D121C", Offset = "0x23D121C", VA = "0x23D121C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x23D1344", Offset = "0x23D1344", VA = "0x23D1344")]
		public FXCollisionBlood()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class Grab : MonoBehaviour
	{
		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D205C", Offset = "0x9D205C")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2094", Offset = "0x9D2094")]
		public UserControlMelee userControl;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D20CC", Offset = "0x9D20CC")]
		public int grabLayer;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool grabbed;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Collider c;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BehaviourPuppet otherPuppet;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Collider otherCollider;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ConfigurableJoint joint;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float nextGrabTime;

		[Token(Token = "0x40000E2")]
		private const float massMlp = 5f;

		[Token(Token = "0x40000E3")]
		private const int solverIterationMlp = 10;

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x23D2A6C", Offset = "0x23D2A6C", VA = "0x23D2A6C")]
		private void Start()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x23D2AF8", Offset = "0x23D2AF8", VA = "0x23D2AF8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x23D2EFC", Offset = "0x23D2EFC", VA = "0x23D2EFC")]
		private void Update()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x23D3040", Offset = "0x23D3040", VA = "0x23D3040")]
		public Grab()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class Killing : MonoBehaviour
	{
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2104", Offset = "0x9D2104")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D213C", Offset = "0x9D213C")]
		public PuppetMaster.StateSettings stateSettings;

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x23D66A4", Offset = "0x23D66A4", VA = "0x23D66A4")]
		private void Update()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x23D67A8", Offset = "0x23D67A8", VA = "0x23D67A8")]
		public Killing()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D15C4", Offset = "0x9D15C4")]
	public class LayerSetup : MonoBehaviour
	{
		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2174", Offset = "0x9D2174")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D2174", Offset = "0x9D2174")]
		public Transform characterController;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D21D4", Offset = "0x9D21D4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D21D4", Offset = "0x9D21D4")]
		public int characterControllerLayer;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2234", Offset = "0x9D2234")]
		public int ragdollLayer;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D226C", Offset = "0x9D226C")]
		public LayerMask ignoreCollisionWithCharacterController;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D22A4", Offset = "0x9D22A4")]
		public LayerMask ignoreCollisionWithRagdoll;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PuppetMaster puppetMaster;

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x23D6E80", Offset = "0x23D6E80", VA = "0x23D6E80")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x23D708C", Offset = "0x23D708C", VA = "0x23D708C")]
		public LayerSetup()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class Planet : MonoBehaviour
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float mass;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Rigidbody[] rigidbodies;

		[Token(Token = "0x40000EE")]
		private const float G = 6.672E-11f;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x23DB258", Offset = "0x23DB258", VA = "0x23DB258")]
		private void Start()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x23DB338", Offset = "0x23DB338", VA = "0x23DB338")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x23DB3C4", Offset = "0x23DB3C4", VA = "0x23DB3C4")]
		private void ApplyGravity(Rigidbody r)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x23DB500", Offset = "0x23DB500", VA = "0x23DB500")]
		public Planet()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class PropDemo : MonoBehaviour
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D22DC", Offset = "0x9D22DC")]
		public Prop prop;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2314", Offset = "0x9D2314")]
		public PropRoot propRootLeft;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D234C", Offset = "0x9D234C")]
		public PropRoot propRootRight;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2384", Offset = "0x9D2384")]
		public bool pickUpOnStart;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool right;

		[Token(Token = "0x17000016")]
		private PropRoot connectTo
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x23DC05C", Offset = "0x23DC05C", VA = "0x23DC05C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x23DC018", Offset = "0x23DC018", VA = "0x23DC018")]
		private void Start()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x23DC078", Offset = "0x23DC078", VA = "0x23DC078")]
		private void Update()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x23DC26C", Offset = "0x23DC26C", VA = "0x23DC26C")]
		public PropDemo()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class PropMelee : Prop
	{
		[Token(Token = "0x2000035")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1624", Offset = "0x9D1624")]
		private sealed class <Action>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000100")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PropMelee <>4__this;

			[Token(Token = "0x4000101")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x4000102")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <additionalPinMuscleIndex>5__2;

			[Token(Token = "0x17000017")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000123")]
				[Address(RVA = "0x267A1A8", Offset = "0x267A1A8", VA = "0x267A1A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000018")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000125")]
				[Address(RVA = "0x267A1F0", Offset = "0x267A1F0", VA = "0x267A1F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000120")]
			[Address(RVA = "0x2679F40", Offset = "0x2679F40", VA = "0x2679F40")]
			[DebuggerHidden]
			public <Action>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000121")]
			[Address(RVA = "0x2679F6C", Offset = "0x2679F6C", VA = "0x2679F6C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000122")]
			[Address(RVA = "0x2679F70", Offset = "0x2679F70", VA = "0x2679F70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000124")]
			[Address(RVA = "0x267A1B0", Offset = "0x267A1B0", VA = "0x267A1B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D23BC", Offset = "0x9D23BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D23BC", Offset = "0x9D23BC")]
		public CapsuleCollider capsuleCollider;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D241C", Offset = "0x9D241C")]
		public BoxCollider boxCollider;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2454", Offset = "0x9D2454")]
		public float actionColliderRadiusMlp;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D248C", Offset = "0x9D248C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D248C", Offset = "0x9D248C")]
		public float actionAdditionalPinWeight;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D24E0", Offset = "0x9D24E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D24E0", Offset = "0x9D24E0")]
		public float actionMassMlp;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2538", Offset = "0x9D2538")]
		public Vector3 COMOffset;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float defaultColliderRadius;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float defaultMass;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float defaultAddMass;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Rigidbody r;

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x23CE0F0", Offset = "0x23CE0F0", VA = "0x23CE0F0")]
		public void StartAction(float duration)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x23DC27C", Offset = "0x23DC27C", VA = "0x23DC27C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9D52EC", Offset = "0x9D52EC")]
		public IEnumerator Action(float duration)
		{
			return null;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x23DC304", Offset = "0x23DC304", VA = "0x23DC304", Slot = "6")]
		protected override void OnStart()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x23DC3CC", Offset = "0x23DC3CC", VA = "0x23DC3CC", Slot = "4")]
		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x23DC444", Offset = "0x23DC444", VA = "0x23DC444", Slot = "5")]
		protected override void OnDrop()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x23DC4BC", Offset = "0x23DC4BC", VA = "0x23DC4BC")]
		public PropMelee()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class PropPickUpTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Prop prop;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask characterLayers;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CharacterPuppet characterPuppet;

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x23DC4D0", Offset = "0x23DC4D0", VA = "0x23DC4D0")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x23DC6A8", Offset = "0x23DC6A8", VA = "0x23DC6A8")]
		public PropPickUpTrigger()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class PuppetBoard : MonoBehaviour
	{
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2570", Offset = "0x9D2570")]
		public Rigidbody target;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D25A8", Offset = "0x9D25A8")]
		public Transform bodyTargetPivot;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D25E0", Offset = "0x9D25E0")]
		public Transform bodyTarget;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x23DD720", Offset = "0x23DD720", VA = "0x23DD720")]
		private void Start()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x23DD7D0", Offset = "0x23DD7D0", VA = "0x23DD7D0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x23DD950", Offset = "0x23DD950", VA = "0x23DD950")]
		public PuppetBoard()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class PuppetScaling : MonoBehaviour
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D2618", Offset = "0x9D2618")]
		public float masterScale;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int muscleIndex;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D2634", Offset = "0x9D2634")]
		public float muscleScale;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float defaultMuscleSpring;

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2670D1C", Offset = "0x2670D1C", VA = "0x2670D1C")]
		private void Start()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2670D5C", Offset = "0x2670D5C", VA = "0x2670D5C")]
		private void Update()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2671070", Offset = "0x2671070", VA = "0x2671070")]
		public PuppetScaling()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class RaycastShooter : MonoBehaviour
	{
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask layers;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unpin;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float force;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem blood;

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2672F04", Offset = "0x2672F04", VA = "0x2672F04")]
		private void Update()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2673164", Offset = "0x2673164", VA = "0x2673164")]
		public RaycastShooter()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class Respawning : MonoBehaviour
	{
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2650", Offset = "0x9D2650")]
		public Transform pool;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2688", Offset = "0x9D2688")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D26C0", Offset = "0x9D26C0")]
		public string idleAnimation;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform puppetRoot;

		[Token(Token = "0x17000019")]
		private bool isPooled
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x2673174", Offset = "0x2673174", VA = "0x2673174")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2673208", Offset = "0x2673208", VA = "0x2673208")]
		private void Start()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2673270", Offset = "0x2673270", VA = "0x2673270")]
		private void Update()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x26733A4", Offset = "0x26733A4", VA = "0x26733A4")]
		private void Pool()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x26733C8", Offset = "0x26733C8", VA = "0x26733C8")]
		private void Respawn(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x26734D0", Offset = "0x26734D0", VA = "0x26734D0")]
		public Respawning()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class RotateShoulderToTarget : MonoBehaviour
	{
		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform shoulder;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 euler;

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x26734D8", Offset = "0x26734D8", VA = "0x26734D8")]
		private void OnPuppetMasterRead()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2673570", Offset = "0x2673570", VA = "0x2673570")]
		public RotateShoulderToTarget()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class SkeletonShooter : MonoBehaviour
	{
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MuscleRemoveMode removeMuscleMode;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask layers;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float unpin;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem particles;

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2673FB4", Offset = "0x2673FB4", VA = "0x2673FB4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x267436C", Offset = "0x267436C", VA = "0x267436C")]
		public SkeletonShooter()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class UserControlAIMelee : UserControlThirdPerson
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BehaviourPuppet targetPuppet;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isAttacking;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float attackTimer;

		[Token(Token = "0x1700001A")]
		private Transform moveTarget
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x2676710", Offset = "0x2676710", VA = "0x2676710")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2676764", Offset = "0x2676764", VA = "0x2676764", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2676914", Offset = "0x2676914", VA = "0x2676914")]
		private bool CanAttack()
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2676A30", Offset = "0x2676A30", VA = "0x2676A30")]
		public UserControlAIMelee()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class UserControlMelee : UserControlThirdPerson
	{
		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public KeyCode hitKey;

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2676A4C", Offset = "0x2676A4C", VA = "0x2676A4C", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2676D1C", Offset = "0x2676D1C", VA = "0x2676D1C")]
		public UserControlMelee()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x1700001B")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x2667670", Offset = "0x2667670", VA = "0x2667670", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x266764C", Offset = "0x266764C", VA = "0x266764C", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2667678", Offset = "0x2667678", VA = "0x2667678")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x26676DC", Offset = "0x26676DC", VA = "0x26676DC", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2667914", Offset = "0x2667914", VA = "0x2667914", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2667AF8", Offset = "0x2667AF8", VA = "0x2667AF8", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2667924", Offset = "0x2667924", VA = "0x2667924")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2667B08", Offset = "0x2667B08", VA = "0x2667B08")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D1634", Offset = "0x9D1634")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2668068", Offset = "0x2668068", VA = "0x2668068", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x26680CC", Offset = "0x26680CC", VA = "0x26680CC", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2668168", Offset = "0x2668168", VA = "0x2668168")]
		private void Update()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2668280", Offset = "0x2668280", VA = "0x2668280")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D1694", Offset = "0x9D1694")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D2758", Offset = "0x9D2758")]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x4000136")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000137")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x1700001C")]
		public override bool animationGrounded
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x2668340", Offset = "0x2668340", VA = "0x2668340", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2668298", Offset = "0x2668298", VA = "0x2668298", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2668324", Offset = "0x2668324", VA = "0x2668324", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2667CA0", Offset = "0x2667CA0", VA = "0x2667CA0", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2668438", Offset = "0x2668438", VA = "0x2668438")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2668044", Offset = "0x2668044", VA = "0x2668044")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D16F4", Offset = "0x9D16F4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D16F4", Offset = "0x9D16F4")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D279C", Offset = "0x9D279C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D279C", Offset = "0x9D279C")]
		public Transform gravityTarget;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D27FC", Offset = "0x9D27FC")]
		[SerializeField]
		protected float gravityMultiplier;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x4000143")]
		protected const float half = 0.5f;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x6000152")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2668540", Offset = "0x2668540", VA = "0x2668540")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2668670", Offset = "0x2668670", VA = "0x2668670", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2668858", Offset = "0x2668858", VA = "0x2668858", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2668A08", Offset = "0x2668A08", VA = "0x2668A08")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2668A6C", Offset = "0x2668A6C", VA = "0x2668A6C")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2668B8C", Offset = "0x2668B8C", VA = "0x2668B8C")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2668CB0", Offset = "0x2668CB0", VA = "0x2668CB0")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2668CD4", Offset = "0x2668CD4", VA = "0x2668CD4")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2668CF8", Offset = "0x2668CF8", VA = "0x2668CF8")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2668D58", Offset = "0x2668D58", VA = "0x2668D58")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000044")]
		public enum MoveMode
		{
			[Token(Token = "0x400017B")]
			Directional,
			[Token(Token = "0x400017C")]
			Strafe
		}

		[Token(Token = "0x2000045")]
		public struct AnimState
		{
			[Token(Token = "0x400017D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x400017F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;
		}

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D2898", Offset = "0x9D2898")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D28D0", Offset = "0x9D28D0")]
		public MoveMode moveMode;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D2908", Offset = "0x9D2908")]
		public bool lookInCameraDirection;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D2940", Offset = "0x9D2940")]
		public float airSpeed;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airControl;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float jumpPower;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D2978", Offset = "0x9D2978")]
		private LayerMask wallRunLayers;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float wallRunMaxLength;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D29C4", Offset = "0x9D29C4")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D29FC", Offset = "0x9D29FC")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AnimState animState;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		protected Vector3 moveDirection;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Animator animator;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3 normal;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 platformVelocity;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private RaycastHit hit;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private float jumpLeg;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private float jumpEndTime;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private float forwardMlp;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private float groundDistance;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float lastAirTime;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float stickyForce;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private float wallRunWeight;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private bool fixedFrame;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private float wallRunEndTime;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Vector3 gravity;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private float velocityY;

		[Token(Token = "0x1700001D")]
		public bool onGround
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x23CEB14", Offset = "0x23CEB14", VA = "0x23CEB14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D539C", Offset = "0x9D539C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x23CEB1C", Offset = "0x23CEB1C", VA = "0x23CEB1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D53AC", Offset = "0x9D53AC")]
			private set
			{
			}
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x23CE1E8", Offset = "0x23CE1E8", VA = "0x23CE1E8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x23CEB28", Offset = "0x23CEB28", VA = "0x23CEB28")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x23CE3A4", Offset = "0x23CE3A4", VA = "0x23CE3A4", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x23CEBB8", Offset = "0x23CEBB8", VA = "0x23CEBB8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x23CE138", Offset = "0x23CE138", VA = "0x23CE138", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x23CF908", Offset = "0x23CF908", VA = "0x23CF908", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x23CEFE0", Offset = "0x23CEFE0", VA = "0x23CEFE0")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x23CF9EC", Offset = "0x23CF9EC", VA = "0x23CF9EC")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x23CFE94", Offset = "0x23CFE94", VA = "0x23CFE94")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x23CF754", Offset = "0x23CF754", VA = "0x23CF754")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x23CE5D8", Offset = "0x23CE5D8", VA = "0x23CE5D8", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x23CFF34", Offset = "0x23CFF34", VA = "0x23CFF34")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x23CE940", Offset = "0x23CE940", VA = "0x23CE940", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x23CF3AC", Offset = "0x23CF3AC", VA = "0x23CF3AC")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x23CEA74", Offset = "0x23CEA74", VA = "0x23CEA74")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D1788", Offset = "0x9D1788")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000047")]
		public enum RotationMode
		{
			[Token(Token = "0x4000191")]
			Smooth,
			[Token(Token = "0x4000192")]
			Linear
		}

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2A0C", Offset = "0x9D2A0C")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2A58", Offset = "0x9D2A58")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2AA4", Offset = "0x9D2AA4")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2AF0", Offset = "0x9D2AF0")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2B3C", Offset = "0x9D2B3C")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2B88", Offset = "0x9D2B88")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D2BD4", Offset = "0x9D2BD4")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x1700001E")]
		public bool isGrounded
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x2673578", Offset = "0x2673578", VA = "0x2673578")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D53BC", Offset = "0x9D53BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x2673580", Offset = "0x2673580", VA = "0x2673580")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D53CC", Offset = "0x9D53CC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x267358C", Offset = "0x267358C", VA = "0x267358C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2673630", Offset = "0x2673630", VA = "0x2673630")]
		private void Update()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2673AF0", Offset = "0x2673AF0", VA = "0x2673AF0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x2673684", Offset = "0x2673684", VA = "0x2673684")]
		private void Rotate()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2673904", Offset = "0x2673904", VA = "0x2673904")]
		private void Move()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2673B2C", Offset = "0x2673B2C", VA = "0x2673B2C")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2673BC8", Offset = "0x2673BC8", VA = "0x2673BC8")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2673C4C", Offset = "0x2673C4C", VA = "0x2673C4C")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2676588", Offset = "0x2676588", VA = "0x2676588", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x26766E4", Offset = "0x26766E4", VA = "0x26766E4")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x200004A")]
		public struct State
		{
			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2676D2C", Offset = "0x2676D2C", VA = "0x2676D2C")]
		private void Start()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2676A80", Offset = "0x2676A80", VA = "0x2676A80", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2676700", Offset = "0x2676700", VA = "0x2676700")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2655DEC", Offset = "0x2655DEC", VA = "0x2655DEC")]
		private void Update()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x2655E28", Offset = "0x2655E28", VA = "0x2655E28")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x267437C", Offset = "0x267437C", VA = "0x267437C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x26743B0", Offset = "0x26743B0", VA = "0x26743B0")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2674460", Offset = "0x2674460", VA = "0x2674460")]
		public SlowMo()
		{
		}
	}
}
namespace RootMotion.Dynamics
{
	[Token(Token = "0x200004D")]
	public class AnimationBlocker : MonoBehaviour
	{
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2655CBC", Offset = "0x2655CBC", VA = "0x2655CBC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2655D24", Offset = "0x2655D24", VA = "0x2655D24")]
		public AnimationBlocker()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D17E8", Offset = "0x9D17E8")]
	public class BehaviourAnimatedStagger : BehaviourBase
	{
		[Serializable]
		[Token(Token = "0x200004F")]
		public struct FallParams
		{
			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float startPinWeightMlp;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float startMuscleWeightMlp;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float losePinSpeed;
		}

		[Serializable]
		[Token(Token = "0x2000050")]
		public struct FallParamsGroup
		{
			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Muscle.Group[] groups;

			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FallParams fallParams;
		}

		[Token(Token = "0x2000051")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1820", Offset = "0x9D1820")]
		private sealed class <LoseBalance>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BehaviourAnimatedStagger <>4__this;

			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool <done>5__2;

			[Token(Token = "0x1700001F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600018D")]
				[Address(RVA = "0x26782DC", Offset = "0x26782DC", VA = "0x26782DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000020")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600018F")]
				[Address(RVA = "0x2678324", Offset = "0x2678324", VA = "0x2678324", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600018A")]
			[Address(RVA = "0x26779D8", Offset = "0x26779D8", VA = "0x26779D8")]
			[DebuggerHidden]
			public <LoseBalance>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x600018B")]
			[Address(RVA = "0x2677A04", Offset = "0x2677A04", VA = "0x2677A04", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600018C")]
			[Address(RVA = "0x2677A08", Offset = "0x2677A08", VA = "0x2677A08", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600018E")]
			[Address(RVA = "0x26782E4", Offset = "0x26782E4", VA = "0x26782E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D2C24", Offset = "0x9D2C24")]
		public LayerMask groundLayers;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public float animationBlendSpeed;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public float animationMag;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public float momentumMag;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public float unbalancedMuscleWeightMlp;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float unbalancedMuscleDamperAdd;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public bool dropProps;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public float maxGetUpVelocity;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public float minHipHeight;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public SubBehaviourCOM centerOfMass;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D2C5C", Offset = "0x9D2C5C")]
		public FallParams defaults;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public FallParamsGroup[] groupOverrides;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D2C94", Offset = "0x9D2C94")]
		public PuppetEvent onUngrounded;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public PuppetEvent onFallOver;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public PuppetEvent onRest;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[HideInInspector]
		public Vector3 moveVector;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		[HideInInspector]
		public bool isGrounded;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[HideInInspector]
		public Vector3 forward;

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x26563CC", Offset = "0x26563CC", VA = "0x26563CC", Slot = "15")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x26563F0", Offset = "0x26563F0", VA = "0x26563F0", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2656494", Offset = "0x2656494", VA = "0x2656494", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x265641C", Offset = "0x265641C", VA = "0x265641C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9D53DC", Offset = "0x9D53DC")]
		private IEnumerator LoseBalance()
		{
			return null;
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2656498", Offset = "0x2656498", VA = "0x2656498")]
		private FallParams GetFallParams(Muscle.Group group)
		{
			return default(FallParams);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x265655C", Offset = "0x265655C", VA = "0x265655C")]
		public BehaviourAnimatedStagger()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public abstract class BehaviourBase : MonoBehaviour
	{
		[Token(Token = "0x2000053")]
		public delegate void BehaviourDelegate();

		[Token(Token = "0x2000054")]
		public delegate void HitDelegate(MuscleHit hit);

		[Token(Token = "0x2000055")]
		public delegate void CollisionDelegate(MuscleCollision collision);

		[Serializable]
		[Token(Token = "0x2000056")]
		public struct PuppetEvent
		{
			[Token(Token = "0x40001DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string switchToBehaviour;

			[Token(Token = "0x40001DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40001DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEvent unityEvent;

			[Token(Token = "0x40001E0")]
			private const string empty = "";

			[Token(Token = "0x17000022")]
			public bool switchBehaviour
			{
				[Token(Token = "0x60001C8")]
				[Address(RVA = "0x267824C", Offset = "0x267824C", VA = "0x267824C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x2677FE4", Offset = "0x2677FE4", VA = "0x2677FE4")]
			public void Trigger(PuppetMaster puppetMaster, bool switchBehaviourEnabled = true)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000057")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40001E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string animationState;

			[Token(Token = "0x40001E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float crossfadeTime;

			[Token(Token = "0x40001E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int layer;

			[Token(Token = "0x40001E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40001E5")]
			private const string empty = "";

			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x267832C", Offset = "0x267832C", VA = "0x267832C")]
			public void Activate(Animator animator, Animation animation)
			{
			}

			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x26783FC", Offset = "0x26783FC", VA = "0x26783FC")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x26784FC", Offset = "0x26784FC", VA = "0x26784FC")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x26785D8", Offset = "0x26785D8", VA = "0x26785D8")]
			public AnimatorEvent()
			{
			}
		}

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BehaviourDelegate OnPreActivate;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BehaviourDelegate OnPreInitiate;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BehaviourDelegate OnPreFixedUpdate;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BehaviourDelegate OnPreUpdate;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BehaviourDelegate OnPreLateUpdate;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BehaviourDelegate OnPreDeactivate;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public BehaviourDelegate OnPreFixTransforms;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public BehaviourDelegate OnPreRead;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public BehaviourDelegate OnPreWrite;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public HitDelegate OnPreMuscleHit;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public CollisionDelegate OnPreMuscleCollision;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CollisionDelegate OnPreMuscleCollisionExit;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public BehaviourDelegate OnHierarchyChanged;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public BehaviourDelegate OnPostActivate;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public BehaviourDelegate OnPostInitiate;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public BehaviourDelegate OnPostFixedUpdate;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public BehaviourDelegate OnPostUpdate;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public BehaviourDelegate OnPostLateUpdate;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public BehaviourDelegate OnPostDeactivate;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public BehaviourDelegate OnPostDrawGizmos;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public BehaviourDelegate OnPostFixTransforms;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public BehaviourDelegate OnPostRead;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public BehaviourDelegate OnPostWrite;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public HitDelegate OnPostMuscleHit;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public CollisionDelegate OnPostMuscleCollision;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public CollisionDelegate OnPostMuscleCollisionExit;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		public bool deactivated;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D2D1C", Offset = "0x9D2D1C")]
		private bool <forceActive>k__BackingField;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		private bool initiated;

		[Token(Token = "0x17000021")]
		public bool forceActive
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x265660C", Offset = "0x265660C", VA = "0x265660C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D548C", Offset = "0x9D548C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x2656614", Offset = "0x2656614", VA = "0x2656614")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D549C", Offset = "0x9D549C")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000190")]
		public abstract void OnReactivate();

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2656598", Offset = "0x2656598", VA = "0x2656598", Slot = "5")]
		public virtual void Resurrect()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x265659C", Offset = "0x265659C", VA = "0x265659C", Slot = "6")]
		public virtual void Freeze()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x26565A0", Offset = "0x26565A0", VA = "0x26565A0", Slot = "7")]
		public virtual void Unfreeze()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x26565A4", Offset = "0x26565A4", VA = "0x26565A4", Slot = "8")]
		public virtual void KillStart()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x26565A8", Offset = "0x26565A8", VA = "0x26565A8", Slot = "9")]
		public virtual void KillEnd()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x26565AC", Offset = "0x26565AC", VA = "0x26565AC", Slot = "10")]
		public virtual void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x26565B0", Offset = "0x26565B0", VA = "0x26565B0", Slot = "11")]
		public virtual void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x26565C4", Offset = "0x26565C4", VA = "0x26565C4", Slot = "12")]
		public virtual void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x26565D8", Offset = "0x26565D8", VA = "0x26565D8", Slot = "13")]
		protected virtual void OnActivate()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x26565DC", Offset = "0x26565DC", VA = "0x26565DC", Slot = "14")]
		protected virtual void OnDeactivate()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x26565E0", Offset = "0x26565E0", VA = "0x26565E0", Slot = "15")]
		protected virtual void OnInitiate()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x26565E4", Offset = "0x26565E4", VA = "0x26565E4", Slot = "16")]
		protected virtual void OnFixedUpdate()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x26565E8", Offset = "0x26565E8", VA = "0x26565E8", Slot = "17")]
		protected virtual void OnUpdate()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x26565EC", Offset = "0x26565EC", VA = "0x26565EC", Slot = "18")]
		protected virtual void OnLateUpdate()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x26565F0", Offset = "0x26565F0", VA = "0x26565F0", Slot = "19")]
		protected virtual void OnDrawGizmosBehaviour()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x26565F4", Offset = "0x26565F4", VA = "0x26565F4", Slot = "20")]
		protected virtual void OnFixTransformsBehaviour()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x26565F8", Offset = "0x26565F8", VA = "0x26565F8", Slot = "21")]
		protected virtual void OnReadBehaviour()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x26565FC", Offset = "0x26565FC", VA = "0x26565FC", Slot = "22")]
		protected virtual void OnWriteBehaviour()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2656600", Offset = "0x2656600", VA = "0x2656600", Slot = "23")]
		protected virtual void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2656604", Offset = "0x2656604", VA = "0x2656604", Slot = "24")]
		protected virtual void OnMuscleCollisionBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2656608", Offset = "0x2656608", VA = "0x2656608", Slot = "25")]
		protected virtual void OnMuscleCollisionExitBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2656620", Offset = "0x2656620", VA = "0x2656620")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2656680", Offset = "0x2656680", VA = "0x2656680")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x26566EC", Offset = "0x26566EC", VA = "0x26566EC")]
		public void OnRead()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2656758", Offset = "0x2656758", VA = "0x2656758")]
		public void OnWrite()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x26567C4", Offset = "0x26567C4", VA = "0x26567C4")]
		public void OnMuscleHit(MuscleHit hit)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2656854", Offset = "0x2656854", VA = "0x2656854")]
		public void OnMuscleCollision(MuscleCollision collision)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2656904", Offset = "0x2656904", VA = "0x2656904")]
		public void OnMuscleCollisionExit(MuscleCollision collision)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x26569B4", Offset = "0x26569B4", VA = "0x26569B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x26569C4", Offset = "0x26569C4", VA = "0x26569C4")]
		public void Activate()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2656AE8", Offset = "0x2656AE8", VA = "0x2656AE8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2656B40", Offset = "0x2656B40", VA = "0x2656B40")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2656BEC", Offset = "0x2656BEC", VA = "0x2656BEC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2656C98", Offset = "0x2656C98", VA = "0x2656C98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2656D44", Offset = "0x2656D44", VA = "0x2656D44", Slot = "26")]
		protected virtual void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2656D88", Offset = "0x2656D88", VA = "0x2656D88")]
		protected void RotateTargetToRootMuscle()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2656EBC", Offset = "0x2656EBC", VA = "0x2656EBC")]
		protected void TranslateTargetToRootMuscle(float maintainY)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2656FF0", Offset = "0x2656FF0", VA = "0x2656FF0")]
		protected void RemoveMusclesOfGroup(Muscle.Group group)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x265711C", Offset = "0x265711C", VA = "0x265711C", Slot = "27")]
		protected virtual void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x265709C", Offset = "0x265709C", VA = "0x265709C")]
		protected bool MusclesContainsGroup(Muscle.Group group)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2656590", Offset = "0x2656590", VA = "0x2656590")]
		protected BehaviourBase()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D1830", Offset = "0x9D1830")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D1830", Offset = "0x9D1830")]
	public class BehaviourFall : BehaviourBase
	{
		[Token(Token = "0x2000059")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1890", Offset = "0x9D1890")]
		private sealed class <SmoothActivate>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BehaviourFall <>4__this;

			[Token(Token = "0x40001F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <fader>5__2;

			[Token(Token = "0x17000023")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001DD")]
				[Address(RVA = "0x267913C", Offset = "0x267913C", VA = "0x267913C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000024")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0x2679184", Offset = "0x2679184", VA = "0x2679184", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x2678F28", Offset = "0x2678F28", VA = "0x2678F28")]
			[DebuggerHidden]
			public <SmoothActivate>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x2678F54", Offset = "0x2678F54", VA = "0x2678F54", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x2678F58", Offset = "0x2678F58", VA = "0x2678F58", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x2679144", Offset = "0x2679144", VA = "0x2679144", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D2D2C", Offset = "0x9D2D2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2D2C", Offset = "0x9D2D2C")]
		public string stateName;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2D8C", Offset = "0x9D2D8C")]
		public float transitionDuration;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2DC4", Offset = "0x9D2DC4")]
		public int layer;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2DFC", Offset = "0x9D2DFC")]
		public float fixedTime;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2E34", Offset = "0x9D2E34")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D2E34", Offset = "0x9D2E34")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2E94", Offset = "0x9D2E94")]
		public string blendParameter;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2ECC", Offset = "0x9D2ECC")]
		public float writheHeight;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2F04", Offset = "0x9D2F04")]
		public float writheYVelocity;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2F3C", Offset = "0x9D2F3C")]
		public float blendSpeed;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2F74", Offset = "0x9D2F74")]
		public float blendMappingSpeed;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D2FAC", Offset = "0x9D2FAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D2FAC", Offset = "0x9D2FAC")]
		public bool canEnd;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D300C", Offset = "0x9D300C")]
		public float minTime;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3044", Offset = "0x9D3044")]
		public float maxEndVelocity;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D307C", Offset = "0x9D307C")]
		public PuppetEvent onEnd;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private float timer;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private bool endTriggered;

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2657254", Offset = "0x2657254", VA = "0x2657254")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D54AC", Offset = "0x9D54AC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x265729C", Offset = "0x265729C", VA = "0x265729C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D54E4", Offset = "0x9D54E4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x26572E4", Offset = "0x26572E4", VA = "0x26572E4", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x265739C", Offset = "0x265739C", VA = "0x265739C", Slot = "14")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x26573A4", Offset = "0x26573A4", VA = "0x26573A4", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2657324", Offset = "0x2657324", VA = "0x2657324")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9D551C", Offset = "0x9D551C")]
		private IEnumerator SmoothActivate()
		{
			return null;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x26573B0", Offset = "0x26573B0", VA = "0x26573B0", Slot = "16")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2657814", Offset = "0x2657814", VA = "0x2657814", Slot = "18")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2657924", Offset = "0x2657924", VA = "0x2657924", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x26576C8", Offset = "0x26576C8", VA = "0x26576C8")]
		private float GetBlendTarget(float groundHeight)
		{
			return default(float);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x26575B4", Offset = "0x26575B4", VA = "0x26575B4")]
		private float GetGroundHeight()
		{
			return default(float);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x265798C", Offset = "0x265798C", VA = "0x265798C")]
		public BehaviourFall()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D18A0", Offset = "0x9D18A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D18A0", Offset = "0x9D18A0")]
	public class BehaviourPuppet : BehaviourBase
	{
		[Serializable]
		[Token(Token = "0x200005B")]
		public enum State
		{
			[Token(Token = "0x4000233")]
			Puppet,
			[Token(Token = "0x4000234")]
			Unpinned,
			[Token(Token = "0x4000235")]
			GetUp,
			[Token(Token = "0x4000236")]
			Knocked
		}

		[Serializable]
		[Token(Token = "0x200005C")]
		public enum NormalMode
		{
			[Token(Token = "0x4000238")]
			Active,
			[Token(Token = "0x4000239")]
			Unmapped,
			[Token(Token = "0x400023A")]
			Kinematic
		}

		[Serializable]
		[Token(Token = "0x200005D")]
		public class MasterProps
		{
			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NormalMode normalMode;

			[Token(Token = "0x400023C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float mappingBlendSpeed;

			[Token(Token = "0x400023D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool activateOnStaticCollisions;

			[Token(Token = "0x400023E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float activateOnImpulse;

			[Token(Token = "0x6000211")]
			[Address(RVA = "0x2679584", Offset = "0x2679584", VA = "0x2679584")]
			public MasterProps()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200005E")]
		public struct MuscleProps
		{
			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D3764", Offset = "0x9D3764")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3764", Offset = "0x9D3764")]
			public float unpinParents;

			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D37B8", Offset = "0x9D37B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D37B8", Offset = "0x9D37B8")]
			public float unpinChildren;

			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D380C", Offset = "0x9D380C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D380C", Offset = "0x9D380C")]
			public float unpinGroup;

			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D3860", Offset = "0x9D3860")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3860", Offset = "0x9D3860")]
			public float minMappingWeight;

			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D38B4", Offset = "0x9D38B4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D38B4", Offset = "0x9D38B4")]
			public float maxMappingWeight;

			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3908", Offset = "0x9D3908")]
			public bool disableColliders;

			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3940", Offset = "0x9D3940")]
			public float regainPinSpeed;

			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3978", Offset = "0x9D3978")]
			public float collisionResistance;

			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D39B0", Offset = "0x9D39B0")]
			public float knockOutDistance;

			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PhysicMaterial puppetMaterial;

			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PhysicMaterial unpinnedMaterial;
		}

		[Serializable]
		[Token(Token = "0x200005F")]
		public struct MusclePropsGroup
		{
			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x400024B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Muscle.Group[] groups;

			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MuscleProps props;
		}

		[Serializable]
		[Token(Token = "0x2000060")]
		public struct CollisionResistanceMultiplier
		{
			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LayerMask layers;

			[Token(Token = "0x400024E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D39F8", Offset = "0x9D39F8")]
			public float multiplier;

			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3A30", Offset = "0x9D3A30")]
			public float collisionThreshold;
		}

		[Token(Token = "0x2000061")]
		public delegate void CollisionImpulseDelegate(MuscleCollision m, float impulse);

		[Token(Token = "0x2000062")]
		public delegate void StateDelegate(int state, int muscule);

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D30B4", Offset = "0x9D30B4")]
		public MasterProps masterProps;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D30EC", Offset = "0x9D30EC")]
		public LayerMask groundLayers;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3124", Offset = "0x9D3124")]
		public LayerMask collisionLayers;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D315C", Offset = "0x9D315C")]
		public float collisionThreshold;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Weight collisionResistance;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3194", Offset = "0x9D3194")]
		public CollisionResistanceMultiplier[] collisionResistanceMultipliers;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D31CC", Offset = "0x9D31CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D31CC", Offset = "0x9D31CC")]
		public int maxCollisions;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D3220", Offset = "0x9D3220")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3220", Offset = "0x9D3220")]
		public float regainPinSpeed;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3278", Offset = "0x9D3278")]
		public float boostFalloff;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D32B0", Offset = "0x9D32B0")]
		public MuscleProps defaults;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public MusclePropsGroup[] groupOverrides;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D32E8", Offset = "0x9D32E8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D32E8", Offset = "0x9D32E8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D32E8", Offset = "0x9D32E8")]
		public float knockOutDistance;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3364", Offset = "0x9D3364")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D3364", Offset = "0x9D3364")]
		public float unpinnedMuscleWeightMlp;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D33B8", Offset = "0x9D33B8")]
		public float maxRigidbodyVelocity;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D33F0", Offset = "0x9D33F0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D33F0", Offset = "0x9D33F0")]
		public float pinWeightThreshold;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3444", Offset = "0x9D3444")]
		public bool unpinnedMuscleKnockout;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D347C", Offset = "0x9D347C")]
		public bool dropProps;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x182")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D34B4", Offset = "0x9D34B4")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D34B4", Offset = "0x9D34B4")]
		public bool canGetUp;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3514", Offset = "0x9D3514")]
		public float getUpDelay;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D354C", Offset = "0x9D354C")]
		public float blendToAnimationTime;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3584", Offset = "0x9D3584")]
		public float maxGetUpVelocity;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D35BC", Offset = "0x9D35BC")]
		public float minGetUpDuration;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D35F4", Offset = "0x9D35F4")]
		public float getUpCollisionResistanceMlp;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D362C", Offset = "0x9D362C")]
		public float getUpRegainPinSpeedMlp;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3664", Offset = "0x9D3664")]
		public float getUpKnockOutDistanceMlp;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D369C", Offset = "0x9D369C")]
		public Vector3 getUpOffsetProne;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D36D4", Offset = "0x9D36D4")]
		public Vector3 getUpOffsetSupine;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D370C", Offset = "0x9D370C")]
		public PuppetEvent onGetUpProne;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public PuppetEvent onGetUpSupine;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		public PuppetEvent onLoseBalanceFromPuppet;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		public PuppetEvent onLoseBalanceFromGetUp;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		public PuppetEvent onRegainBalance;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public CollisionImpulseDelegate OnCollisionImpulse;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D3744", Offset = "0x9D3744")]
		private State <state>k__BackingField;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
		[HideInInspector]
		public bool canMoveTarget;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private float unpinnedTimer;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		private float getUpTimer;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private Vector3 hipsForward;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		private Vector3 hipsUp;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private float getupAnimationBlendWeight;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		private float getupAnimationBlendWeightV;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		protected bool getUpTargetFixed;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		private NormalMode lastNormalMode;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private int collisions;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		protected bool eventsEnabled;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		protected float lastKnockOutDistance;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
		protected float knockOutDistanceSqr;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private bool getupDisabled;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x299")]
		protected bool hasCollidedSinceGetUp;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29A")]
		public bool LockedWakeUp;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29B")]
		private bool hasBoosted;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private Vector3 getUpPosition;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
		private bool dropPropFlag;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		public StateDelegate OnPuppetStateSwitch;

		[Token(Token = "0x17000025")]
		public State state
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x2657AC8", Offset = "0x2657AC8", VA = "0x2657AC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D563C", Offset = "0x9D563C")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x2657AD0", Offset = "0x2657AD0", VA = "0x2657AD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D564C", Offset = "0x9D564C")]
			protected set
			{
			}
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x2657A38", Offset = "0x2657A38", VA = "0x2657A38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D55CC", Offset = "0x9D55CC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x2657A80", Offset = "0x2657A80", VA = "0x2657A80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D5604", Offset = "0x9D5604")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2657AD8", Offset = "0x2657AD8", VA = "0x2657AD8", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x2657D80", Offset = "0x2657D80", VA = "0x2657D80")]
		public void Reset(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2657DF4", Offset = "0x2657DF4", VA = "0x2657DF4", Slot = "10")]
		public override void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2657E90", Offset = "0x2657E90", VA = "0x2657E90", Slot = "15")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x26580D4", Offset = "0x26580D4", VA = "0x26580D4", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2658198", Offset = "0x2658198", VA = "0x2658198", Slot = "8")]
		public override void KillStart()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2658234", Offset = "0x2658234", VA = "0x2658234", Slot = "9")]
		public override void KillEnd()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x265824C", Offset = "0x265824C", VA = "0x265824C", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x26582D8", Offset = "0x26582D8", VA = "0x26582D8", Slot = "14")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x26582E4", Offset = "0x26582E4", VA = "0x26582E4", Slot = "16")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x26589BC", Offset = "0x26589BC", VA = "0x26589BC", Slot = "18")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2658C84", Offset = "0x2658C84", VA = "0x2658C84")]
		private bool SetKinematic()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2658D64", Offset = "0x2658D64", VA = "0x2658D64", Slot = "21")]
		protected override void OnReadBehaviour()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2658B3C", Offset = "0x2658B3C", VA = "0x2658B3C")]
		private void BlendMuscleMapping(int muscleIndex, ref bool to)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2658F74", Offset = "0x2658F74", VA = "0x2658F74", Slot = "11")]
		public override void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2658FB8", Offset = "0x2658FB8", VA = "0x2658FB8", Slot = "12")]
		public override void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2658F3C", Offset = "0x2658F3C", VA = "0x2658F3C")]
		protected void MoveTarget(Vector3 position)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2658FF4", Offset = "0x2658FF4", VA = "0x2658FF4")]
		protected void RotateTarget(Quaternion rotation)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x265902C", Offset = "0x265902C", VA = "0x265902C", Slot = "27")]
		protected override void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2659040", Offset = "0x2659040", VA = "0x2659040")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2659258", Offset = "0x2659258", VA = "0x2659258")]
		public void Boost(float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x26592E8", Offset = "0x26592E8", VA = "0x26592E8")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2659400", Offset = "0x2659400", VA = "0x2659400")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x26595C4", Offset = "0x26595C4", VA = "0x26595C4")]
		public void BoostImmunity(float immunity)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x265932C", Offset = "0x265932C", VA = "0x265932C")]
		public void BoostImmunity(int muscleIndex, float immunity)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x265963C", Offset = "0x265963C", VA = "0x265963C")]
		public void BoostImmunity(int muscleIndex, float immunity, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x26596E0", Offset = "0x26596E0", VA = "0x26596E0")]
		public void BoostImpulseMlp(float impulseMlp)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2659398", Offset = "0x2659398", VA = "0x2659398")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2659750", Offset = "0x2659750", VA = "0x2659750")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x26597F4", Offset = "0x26597F4", VA = "0x26597F4")]
		public void Unpin()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2659888", Offset = "0x2659888", VA = "0x2659888", Slot = "23")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2659A68", Offset = "0x2659A68", VA = "0x2659A68", Slot = "24")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2659E1C", Offset = "0x2659E1C", VA = "0x2659E1C")]
		private float GetImpulse(MuscleCollision m, ref float layerThreshold)
		{
			return default(float);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x265996C", Offset = "0x265996C", VA = "0x265996C")]
		private void UnPin(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x265A120", Offset = "0x265A120", VA = "0x265A120")]
		private void UnPinMuscle(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2659FA4", Offset = "0x2659FA4", VA = "0x2659FA4")]
		private bool Activate(Collision collision, float impulse)
		{
			return default(bool);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x265A2E0", Offset = "0x265A2E0", VA = "0x265A2E0")]
		public bool IsProne()
		{
			return default(bool);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2659520", Offset = "0x2659520", VA = "0x2659520")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren)
		{
			return default(float);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x265A03C", Offset = "0x265A03C", VA = "0x265A03C")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren, float falloffGroup)
		{
			return default(float);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x265A3A0", Offset = "0x265A3A0", VA = "0x265A3A0")]
		private bool InGroup(Muscle.Group group1, Muscle.Group group2)
		{
			return default(bool);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x26588D4", Offset = "0x26588D4", VA = "0x26588D4")]
		protected MuscleProps GetProps(Muscle.Group group)
		{
			return default(MuscleProps);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x265A480", Offset = "0x265A480", VA = "0x265A480", Slot = "28")]
		public virtual void SetState(State newState, int musculeIndex = -1)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x265AAA0", Offset = "0x265AAA0", VA = "0x265AAA0")]
		public void SetColliders(bool unpinned)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2657BB0", Offset = "0x2657BB0", VA = "0x2657BB0")]
		private void SetColliders(Muscle m, bool unpinned)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x265AB30", Offset = "0x265AB30", VA = "0x265AB30")]
		public BehaviourPuppet()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D1900", Offset = "0x9D1900")]
	public class BehaviourTemplate : BehaviourBase
	{
		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public SubBehaviourCOM centerOfMass;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float loseBalanceAngle;

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x265AC4C", Offset = "0x265AC4C", VA = "0x265AC4C", Slot = "15")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x265AC70", Offset = "0x265AC70", VA = "0x265AC70", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x265AC74", Offset = "0x265AC74", VA = "0x265AC74", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x265AC78", Offset = "0x265AC78", VA = "0x265AC78", Slot = "14")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x265AC7C", Offset = "0x265AC7C", VA = "0x265AC7C", Slot = "16")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x265ACB8", Offset = "0x265ACB8", VA = "0x265ACB8", Slot = "18")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x265ACBC", Offset = "0x265ACBC", VA = "0x265ACBC", Slot = "23")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x265ACC4", Offset = "0x265ACC4", VA = "0x265ACC4", Slot = "24")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x265ACCC", Offset = "0x265ACCC", VA = "0x265ACCC")]
		public BehaviourTemplate()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class SubBehaviourBalancer : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x2000065")]
		public class Settings
		{
			[Token(Token = "0x4000261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3AC8", Offset = "0x9D3AC8")]
			public float damperForSpring;

			[Token(Token = "0x4000262")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3B00", Offset = "0x9D3B00")]
			public float maxForceMlp;

			[Token(Token = "0x4000263")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3B38", Offset = "0x9D3B38")]
			public float IMlp;

			[Token(Token = "0x4000264")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3B70", Offset = "0x9D3B70")]
			public float velocityF;

			[Token(Token = "0x4000265")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3BA8", Offset = "0x9D3BA8")]
			public Vector3 copOffset;

			[Token(Token = "0x4000266")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3BE0", Offset = "0x9D3BE0")]
			public float torqueMlp;

			[Token(Token = "0x4000267")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3C18", Offset = "0x9D3C18")]
			public float maxTorqueMag;

			[Token(Token = "0x6000232")]
			[Address(RVA = "0x267B524", Offset = "0x267B524", VA = "0x267B524")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D3A68", Offset = "0x9D3A68")]
		private ConfigurableJoint <joint>k__BackingField;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D3A78", Offset = "0x9D3A78")]
		private Vector3 <dir>k__BackingField;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D3A88", Offset = "0x9D3A88")]
		private Vector3 <dirVel>k__BackingField;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D3A98", Offset = "0x9D3A98")]
		private Vector3 <cop>k__BackingField;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D3AA8", Offset = "0x9D3AA8")]
		private Vector3 <com>k__BackingField;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D3AB8", Offset = "0x9D3AB8")]
		private Vector3 <comV>k__BackingField;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Settings settings;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody[] rigidbodies;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform[] copPoints;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PressureSensor pressureSensor;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Rigidbody Ibody;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 I;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion toJointSpace;

		[Token(Token = "0x17000026")]
		public ConfigurableJoint joint
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x2674AC8", Offset = "0x2674AC8", VA = "0x2674AC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D565C", Offset = "0x9D565C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x2674AD0", Offset = "0x2674AD0", VA = "0x2674AD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D566C", Offset = "0x9D566C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public Vector3 dir
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x2674AD8", Offset = "0x2674AD8", VA = "0x2674AD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D567C", Offset = "0x9D567C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x2674AE4", Offset = "0x2674AE4", VA = "0x2674AE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D568C", Offset = "0x9D568C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public Vector3 dirVel
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x2674AF0", Offset = "0x2674AF0", VA = "0x2674AF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D569C", Offset = "0x9D569C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x2674AFC", Offset = "0x2674AFC", VA = "0x2674AFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D56AC", Offset = "0x9D56AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public Vector3 cop
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x2674B08", Offset = "0x2674B08", VA = "0x2674B08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D56BC", Offset = "0x9D56BC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x2674B14", Offset = "0x2674B14", VA = "0x2674B14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D56CC", Offset = "0x9D56CC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public Vector3 com
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x2674B20", Offset = "0x2674B20", VA = "0x2674B20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D56DC", Offset = "0x9D56DC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x2674B2C", Offset = "0x2674B2C", VA = "0x2674B2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D56EC", Offset = "0x9D56EC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public Vector3 comV
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x2674B38", Offset = "0x2674B38", VA = "0x2674B38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D56FC", Offset = "0x9D56FC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x2674B44", Offset = "0x2674B44", VA = "0x2674B44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D570C", Offset = "0x9D570C")]
			private set
			{
			}
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2674B50", Offset = "0x2674B50", VA = "0x2674B50")]
		public void Initiate(BehaviourBase behaviour, Settings settings, Rigidbody Ibody, Rigidbody[] rigidbodies, ConfigurableJoint joint, Transform[] copPoints, PressureSensor pressureSensor)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x2674CF0", Offset = "0x2674CF0", VA = "0x2674CF0")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x2675118", Offset = "0x2675118", VA = "0x2675118")]
		public SubBehaviourBalancer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public abstract class SubBehaviourBase
	{
		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected BehaviourBase behaviour;

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x26751C8", Offset = "0x26751C8", VA = "0x26751C8")]
		protected static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x26751D0", Offset = "0x26751D0", VA = "0x26751D0")]
		protected static Vector3 XYZ(Vector2 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x26751DC", Offset = "0x26751DC", VA = "0x26751DC")]
		protected static Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x26751E4", Offset = "0x26751E4", VA = "0x26751E4")]
		protected static Vector3 SetY(Vector3 v, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x26751C0", Offset = "0x26751C0", VA = "0x26751C0")]
		protected SubBehaviourBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public class SubBehaviourCOM : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x2000068")]
		public enum Mode
		{
			[Token(Token = "0x400027C")]
			FeetCentroid,
			[Token(Token = "0x400027D")]
			CenterOfPressure
		}

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode mode;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float velocityDamper;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float velocityLerpSpeed;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float velocityMax;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centerOfPressureSpeed;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D3C50", Offset = "0x9D3C50")]
		private Vector3 <position>k__BackingField;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D3C60", Offset = "0x9D3C60")]
		private Vector3 <direction>k__BackingField;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D3C70", Offset = "0x9D3C70")]
		private float <angle>k__BackingField;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D3C80", Offset = "0x9D3C80")]
		private Vector3 <velocity>k__BackingField;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D3C90", Offset = "0x9D3C90")]
		private Vector3 <centerOfPressure>k__BackingField;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D3CA0", Offset = "0x9D3CA0")]
		private Quaternion <rotation>k__BackingField;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D3CB0", Offset = "0x9D3CB0")]
		private Quaternion <inverseRotation>k__BackingField;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D3CC0", Offset = "0x9D3CC0")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D3CD0", Offset = "0x9D3CD0")]
		private float <lastGroundedTime>k__BackingField;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public bool[] groundContacts;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector3[] groundContactPoints;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private LayerMask groundLayers;

		[Token(Token = "0x1700002C")]
		public Vector3 position
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x26751EC", Offset = "0x26751EC", VA = "0x26751EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D571C", Offset = "0x9D571C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x26751F8", Offset = "0x26751F8", VA = "0x26751F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D572C", Offset = "0x9D572C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public Vector3 direction
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x2675204", Offset = "0x2675204", VA = "0x2675204")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D573C", Offset = "0x9D573C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x2675210", Offset = "0x2675210", VA = "0x2675210")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D574C", Offset = "0x9D574C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public float angle
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x267521C", Offset = "0x267521C", VA = "0x267521C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D575C", Offset = "0x9D575C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x2675224", Offset = "0x2675224", VA = "0x2675224")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D576C", Offset = "0x9D576C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public Vector3 velocity
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x267522C", Offset = "0x267522C", VA = "0x267522C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D577C", Offset = "0x9D577C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x2675238", Offset = "0x2675238", VA = "0x2675238")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D578C", Offset = "0x9D578C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public Vector3 centerOfPressure
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x2675244", Offset = "0x2675244", VA = "0x2675244")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D579C", Offset = "0x9D579C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x2675250", Offset = "0x2675250", VA = "0x2675250")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D57AC", Offset = "0x9D57AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public Quaternion rotation
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x267525C", Offset = "0x267525C", VA = "0x267525C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D57BC", Offset = "0x9D57BC")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x2675268", Offset = "0x2675268", VA = "0x2675268")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D57CC", Offset = "0x9D57CC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public Quaternion inverseRotation
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x2675274", Offset = "0x2675274", VA = "0x2675274")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D57DC", Offset = "0x9D57DC")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x2675280", Offset = "0x2675280", VA = "0x2675280")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D57EC", Offset = "0x9D57EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public bool isGrounded
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x267528C", Offset = "0x267528C", VA = "0x267528C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D57FC", Offset = "0x9D57FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x2675294", Offset = "0x2675294", VA = "0x2675294")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D580C", Offset = "0x9D580C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public float lastGroundedTime
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x26752A0", Offset = "0x26752A0", VA = "0x26752A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D581C", Offset = "0x9D581C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x26752A8", Offset = "0x26752A8", VA = "0x26752A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D582C", Offset = "0x9D582C")]
			private set
			{
			}
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x26752B0", Offset = "0x26752B0", VA = "0x26752B0")]
		public void Initiate(BehaviourBase behaviour, LayerMask groundLayers)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x26756D0", Offset = "0x26756D0", VA = "0x26756D0")]
		private void OnHierarchyChanged()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x2675778", Offset = "0x2675778", VA = "0x2675778")]
		private void OnPreMuscleCollision(MuscleCollision c)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x2675954", Offset = "0x2675954", VA = "0x2675954")]
		private void OnPreMuscleCollisionExit(MuscleCollision c)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x2675A14", Offset = "0x2675A14", VA = "0x2675A14")]
		private void OnPreActivate()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x2675CC0", Offset = "0x2675CC0", VA = "0x2675CC0")]
		private void OnPreLateUpdate()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x26761DC", Offset = "0x26761DC", VA = "0x26761DC")]
		private void OnPreDeactivate()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2675870", Offset = "0x2675870", VA = "0x2675870")]
		private Vector3 GetCollisionCOP(Collision collision)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x2675F24", Offset = "0x2675F24", VA = "0x2675F24")]
		private bool IsGrounded()
		{
			return default(bool);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x2675AB4", Offset = "0x2675AB4", VA = "0x2675AB4")]
		private Vector3 GetCenterOfMass()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2676050", Offset = "0x2676050", VA = "0x2676050")]
		private Vector3 GetCenterOfMassVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2676208", Offset = "0x2676208", VA = "0x2676208")]
		private Vector3 GetMomentum()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x2675F88", Offset = "0x2675F88", VA = "0x2675F88")]
		private Vector3 GetCenterOfPressure()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2675BD8", Offset = "0x2675BD8", VA = "0x2675BD8")]
		private Vector3 GetFeetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x267632C", Offset = "0x267632C", VA = "0x267632C")]
		public SubBehaviourCOM()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public class Booster
	{
		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3D00", Offset = "0x9D3D00")]
		public bool fullBody;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3D38", Offset = "0x9D3D38")]
		public ConfigurableJoint[] muscles;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3D70", Offset = "0x9D3D70")]
		public Muscle.Group[] groups;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3DA8", Offset = "0x9D3DA8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D3DA8", Offset = "0x9D3DA8")]
		public float immunity;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3DFC", Offset = "0x9D3DFC")]
		public float impulseMlp;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3E34", Offset = "0x9D3E34")]
		public float boostParents;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3E6C", Offset = "0x9D3E6C")]
		public float boostChildren;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D3EA4", Offset = "0x9D3EA4")]
		public float delay;

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x26667F4", Offset = "0x26667F4", VA = "0x26667F4")]
		public void Boost(BehaviourPuppet puppet)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x26669FC", Offset = "0x26669FC", VA = "0x26669FC")]
		public Booster()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class JointBreakBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		public int muscleIndex;

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x23D4AD0", Offset = "0x23D4AD0", VA = "0x23D4AD0")]
		private void OnJointBreak()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x23D58A4", Offset = "0x23D58A4", VA = "0x23D58A4")]
		public JointBreakBroadcaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public class Muscle
	{
		[Serializable]
		[Token(Token = "0x200006C")]
		public enum Group
		{
			[Token(Token = "0x40002BA")]
			Hips,
			[Token(Token = "0x40002BB")]
			Spine,
			[Token(Token = "0x40002BC")]
			Head,
			[Token(Token = "0x40002BD")]
			Arm,
			[Token(Token = "0x40002BE")]
			Hand,
			[Token(Token = "0x40002BF")]
			Leg,
			[Token(Token = "0x40002C0")]
			Foot,
			[Token(Token = "0x40002C1")]
			Tail,
			[Token(Token = "0x40002C2")]
			Prop
		}

		[Serializable]
		[Token(Token = "0x200006D")]
		public class Props
		{
			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D405C", Offset = "0x9D405C")]
			public Group group;

			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D4094", Offset = "0x9D4094")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4094", Offset = "0x9D4094")]
			public float mappingWeight;

			[Token(Token = "0x40002C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D40E8", Offset = "0x9D40E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D40E8", Offset = "0x9D40E8")]
			public float pinWeight;

			[Token(Token = "0x40002C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D413C", Offset = "0x9D413C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D413C", Offset = "0x9D413C")]
			public float muscleWeight;

			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4190", Offset = "0x9D4190")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D4190", Offset = "0x9D4190")]
			public float muscleDamper;

			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D41E4", Offset = "0x9D41E4")]
			public bool mapPosition;

			[Token(Token = "0x600028C")]
			[Address(RVA = "0x2679D38", Offset = "0x2679D38", VA = "0x2679D38")]
			public Props()
			{
			}

			[Token(Token = "0x600028D")]
			[Address(RVA = "0x2679D78", Offset = "0x2679D78", VA = "0x2679D78")]
			public Props(float pinWeight, float muscleWeight, float mappingWeight, float muscleDamper, bool mapPosition, Group group = Group.Hips)
			{
			}

			[Token(Token = "0x600028E")]
			[Address(RVA = "0x2679DE8", Offset = "0x2679DE8", VA = "0x2679DE8")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x200006E")]
		public struct State
		{
			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float mappingWeightMlp;

			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float pinWeightMlp;

			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float muscleWeightMlp;

			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float maxForceMlp;

			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float muscleDamperMlp;

			[Token(Token = "0x40002CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float muscleDamperAdd;

			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float immunity;

			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float impulseMlp;

			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 velocity;

			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 angularVelocity;

			[Token(Token = "0x17000043")]
			public static State Default
			{
				[Token(Token = "0x600028F")]
				[Address(RVA = "0x2679E7C", Offset = "0x2679E7C", VA = "0x2679E7C")]
				get
				{
					return default(State);
				}
			}

			[Token(Token = "0x6000290")]
			[Address(RVA = "0x2679E98", Offset = "0x2679E98", VA = "0x2679E98")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public string name;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ConfigurableJoint joint;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform target;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Props props;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public State state;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public int[] parentIndexes;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public int[] childIndexes;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public bool[] childFlags;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public int[] kinshipDegrees;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[HideInInspector]
		public MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public JointBreakBroadcaster jointBreakBroadcaster;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 positionOffset;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D3FCC", Offset = "0x9D3FCC")]
		private Transform <transform>k__BackingField;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D3FDC", Offset = "0x9D3FDC")]
		private Rigidbody <rigidbody>k__BackingField;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D3FEC", Offset = "0x9D3FEC")]
		private Transform <connectedBodyTarget>k__BackingField;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D3FFC", Offset = "0x9D3FFC")]
		private Vector3 <targetAnimatedPosition>k__BackingField;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D400C", Offset = "0x9D400C")]
		private Vector3 <targetVelocity>k__BackingField;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D401C", Offset = "0x9D401C")]
		private Vector3 <targetAngularVelocity>k__BackingField;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D402C", Offset = "0x9D402C")]
		private Vector3 <mappedVelocity>k__BackingField;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D403C", Offset = "0x9D403C")]
		private Vector3 <mappedAngularVelocity>k__BackingField;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D404C", Offset = "0x9D404C")]
		private Quaternion <targetRotationRelative>k__BackingField;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private JointDrive slerpDrive;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float lastJointDriveRotationWeight;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private float lastRotationDamper;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Vector3 defaultTargetLocalPosition;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Vector3 lastMappedPosition;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Quaternion localRotationConvert;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Quaternion toParentSpace;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private Quaternion toJointSpaceInverse;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private Quaternion toJointSpaceDefault;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private Quaternion targetAnimatedRotation;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Quaternion targetAnimatedWorldRotation;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Quaternion rotationRelativeToTarget;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private Quaternion lastMappedRotation;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Transform targetParent;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private Transform connectedBodyTransform;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private ConfigurableJointMotion angularXMotionDefault;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private ConfigurableJointMotion angularYMotionDefault;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private ConfigurableJointMotion angularZMotionDefault;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		private bool directTargetParent;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x215")]
		private bool initiated;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Collider[] _colliders;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private float lastReadTime;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private float lastWriteTime;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private bool[] disabledColliders;

		[Token(Token = "0x17000035")]
		public Transform transform
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x23D7094", Offset = "0x23D7094", VA = "0x23D7094")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D583C", Offset = "0x9D583C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x23D709C", Offset = "0x23D709C", VA = "0x23D709C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D584C", Offset = "0x9D584C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public Rigidbody rigidbody
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x23D70A4", Offset = "0x23D70A4", VA = "0x23D70A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D585C", Offset = "0x9D585C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x23D70AC", Offset = "0x23D70AC", VA = "0x23D70AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D586C", Offset = "0x9D586C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public Transform connectedBodyTarget
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x23D70B4", Offset = "0x23D70B4", VA = "0x23D70B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D587C", Offset = "0x9D587C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x23D70BC", Offset = "0x23D70BC", VA = "0x23D70BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D588C", Offset = "0x9D588C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public Vector3 targetAnimatedPosition
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x23D70C4", Offset = "0x23D70C4", VA = "0x23D70C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D589C", Offset = "0x9D589C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x23D70D0", Offset = "0x23D70D0", VA = "0x23D70D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D58AC", Offset = "0x9D58AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public Collider[] colliders
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x23D70DC", Offset = "0x23D70DC", VA = "0x23D70DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public Vector3 targetVelocity
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x23D70E4", Offset = "0x23D70E4", VA = "0x23D70E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D58BC", Offset = "0x9D58BC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x23D70F0", Offset = "0x23D70F0", VA = "0x23D70F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D58CC", Offset = "0x9D58CC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public Vector3 targetAngularVelocity
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x23D70FC", Offset = "0x23D70FC", VA = "0x23D70FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D58DC", Offset = "0x9D58DC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x23D7108", Offset = "0x23D7108", VA = "0x23D7108")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D58EC", Offset = "0x9D58EC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public Vector3 mappedVelocity
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x23D7114", Offset = "0x23D7114", VA = "0x23D7114")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D58FC", Offset = "0x9D58FC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x23D7120", Offset = "0x23D7120", VA = "0x23D7120")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D590C", Offset = "0x9D590C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public Vector3 mappedAngularVelocity
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x23D712C", Offset = "0x23D712C", VA = "0x23D712C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D591C", Offset = "0x9D591C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x23D7138", Offset = "0x23D7138", VA = "0x23D7138")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D592C", Offset = "0x9D592C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public Quaternion targetRotationRelative
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x23D7144", Offset = "0x23D7144", VA = "0x23D7144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D593C", Offset = "0x9D593C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x23D7154", Offset = "0x23D7154", VA = "0x23D7154")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D594C", Offset = "0x9D594C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		private Quaternion localRotation
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x23D8220", Offset = "0x23D8220", VA = "0x23D8220")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000040")]
		private Quaternion parentRotation
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x23D8334", Offset = "0x23D8334", VA = "0x23D8334")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000041")]
		private Quaternion targetParentRotation
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x23D82A0", Offset = "0x23D82A0", VA = "0x23D82A0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000042")]
		private Quaternion targetLocalRotation
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x23D8460", Offset = "0x23D8460", VA = "0x23D8460")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x23D7164", Offset = "0x23D7164", VA = "0x23D7164")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x23D7380", Offset = "0x23D7380", VA = "0x23D7380", Slot = "4")]
		public virtual void Initiate(Muscle[] colleagues)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x23D80C0", Offset = "0x23D80C0", VA = "0x23D80C0")]
		public void UpdateColliders()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x23D8A5C", Offset = "0x23D8A5C", VA = "0x23D8A5C")]
		public void DisableColliders()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x23D8B1C", Offset = "0x23D8B1C", VA = "0x23D8B1C")]
		public void EnableColliders()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x23D86E4", Offset = "0x23D86E4", VA = "0x23D86E4")]
		private void AddColliders(Transform t, ref Collider[] C, bool includeMeshColliders)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x23D894C", Offset = "0x23D894C", VA = "0x23D894C")]
		private void AddCompoundColliders(Transform t, ref Collider[] colliders)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x23D8BC8", Offset = "0x23D8BC8", VA = "0x23D8BC8")]
		public void IgnoreCollisions(Muscle m, bool ignore)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x23D8D90", Offset = "0x23D8D90", VA = "0x23D8D90")]
		public void IgnoreAngularLimits(bool ignore)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x23D8E30", Offset = "0x23D8E30", VA = "0x23D8E30")]
		public void FixTargetTransforms()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x23D8E9C", Offset = "0x23D8E9C", VA = "0x23D8E9C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x23D9058", Offset = "0x23D9058", VA = "0x23D9058")]
		public void MoveToTarget()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x23D84F8", Offset = "0x23D84F8", VA = "0x23D84F8")]
		public void Read()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x23D90E8", Offset = "0x23D90E8", VA = "0x23D90E8")]
		public void ClearVelocities()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x23D9214", Offset = "0x23D9214", VA = "0x23D9214")]
		public void UpdateAnchor(bool supportTranslationAnimation)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x23D9474", Offset = "0x23D9474", VA = "0x23D9474", Slot = "5")]
		public virtual void Update(float pinWeightMaster, float muscleWeightMaster, float muscleSpring, float muscleDamper, float pinPow, float pinDistanceFalloff, bool rotationTargetChanged)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x23D98AC", Offset = "0x23D98AC", VA = "0x23D98AC")]
		public void Map(float mappingWeightMaster)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x23D9C4C", Offset = "0x23D9C4C", VA = "0x23D9C4C")]
		public void CalculateMappedVelocity()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x23D9564", Offset = "0x23D9564", VA = "0x23D9564")]
		private void Pin(float pinWeightMaster, float pinPow, float pinDistanceFalloff)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x23D96EC", Offset = "0x23D96EC", VA = "0x23D96EC")]
		private void MuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x23D9D9C", Offset = "0x23D9D9C", VA = "0x23D9D9C")]
		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x23D9410", Offset = "0x23D9410", VA = "0x23D9410")]
		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x23D81EC", Offset = "0x23D81EC", VA = "0x23D81EC")]
		private Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x23D9E1C", Offset = "0x23D9E1C", VA = "0x23D9E1C")]
		public Muscle()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public struct MuscleCollision
	{
		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Collision collision;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isStay;

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x23D9FC8", Offset = "0x23D9FC8", VA = "0x23D9FC8")]
		public MuscleCollision(int muscleIndex, Collision collision, bool isStay = false)
		{
		}
	}
	[Token(Token = "0x2000070")]
	public struct MuscleHit
	{
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float unPin;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 force;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 position;

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x23DA0EC", Offset = "0x23DA0EC", VA = "0x23DA0EC")]
		public MuscleHit(int muscleIndex, float unPin, Vector3 force, Vector3 position)
		{
		}
	}
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D1938", Offset = "0x9D1938")]
	public class MuscleCollisionBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		public int muscleIndex;

		[Token(Token = "0x40002DC")]
		private const string onMuscleHit = "OnMuscleHit";

		[Token(Token = "0x40002DD")]
		private const string onMuscleCollision = "OnMuscleCollision";

		[Token(Token = "0x40002DE")]
		private const string onMuscleCollisionExit = "OnMuscleCollisionExit";

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MuscleCollisionBroadcaster otherBroadcaster;

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x23DA000", Offset = "0x23DA000", VA = "0x23DA000")]
		public void Hit(float unPin, Vector3 force, Vector3 position)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x23DA104", Offset = "0x23DA104", VA = "0x23DA104")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x23DA2B8", Offset = "0x23DA2B8", VA = "0x23DA2B8")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x23DA514", Offset = "0x23DA514", VA = "0x23DA514")]
		public MuscleCollisionBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public static class PhysXTools
	{
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x23DA51C", Offset = "0x23DA51C", VA = "0x23DA51C")]
		public static Vector3 GetCenterOfMass(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x23DA668", Offset = "0x23DA668", VA = "0x23DA668")]
		public static Vector3 GetCenterOfMassVelocity(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x23DA7B4", Offset = "0x23DA7B4", VA = "0x23DA7B4")]
		public static void DivByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x23DA860", Offset = "0x23DA860", VA = "0x23DA860")]
		public static void ScaleByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x23DA8FC", Offset = "0x23DA8FC", VA = "0x23DA8FC")]
		public static Vector3 GetFromToAcceleration(Vector3 fromV, Vector3 toV)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x23DA9C8", Offset = "0x23DA9C8", VA = "0x23DA9C8")]
		public static Vector3 GetAngularAcceleration(Quaternion fromR, Quaternion toR)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x23DAC08", Offset = "0x23DAC08", VA = "0x23DAC08")]
		public static void AddFromToTorque(Rigidbody r, Quaternion toR, ForceMode forceMode)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x23DADEC", Offset = "0x23DADEC", VA = "0x23DADEC")]
		public static void AddFromToTorque(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x23DAFA8", Offset = "0x23DAFA8", VA = "0x23DAFA8")]
		public static void AddFromToForce(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x23DB118", Offset = "0x23DB118", VA = "0x23DB118")]
		public static Vector3 GetLinearAcceleration(Vector3 fromPoint, Vector3 toPoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x23DB15C", Offset = "0x23DB15C", VA = "0x23DB15C")]
		public static Quaternion ToJointSpace(ConfigurableJoint joint)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x23DB224", Offset = "0x23DB224", VA = "0x23DB224")]
		public static Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x23DA850", Offset = "0x23DA850", VA = "0x23DA850")]
		public static Vector3 Div(Vector3 v, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000073")]
	public class PressureSensor : MonoBehaviour
	{
		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool visualize;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask layers;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D428C", Offset = "0x9D428C")]
		private Vector3 <center>k__BackingField;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D429C", Offset = "0x9D429C")]
		private bool <inContact>k__BackingField;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D42AC", Offset = "0x9D42AC")]
		private Vector3 <bottom>k__BackingField;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D42BC", Offset = "0x9D42BC")]
		private Rigidbody <r>k__BackingField;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool fixedFrame;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 P;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int count;

		[Token(Token = "0x17000044")]
		public Vector3 center
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x23DB510", Offset = "0x23DB510", VA = "0x23DB510")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D595C", Offset = "0x9D595C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x23DB51C", Offset = "0x23DB51C", VA = "0x23DB51C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D596C", Offset = "0x9D596C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public bool inContact
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x23DB528", Offset = "0x23DB528", VA = "0x23DB528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D597C", Offset = "0x9D597C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x23DB530", Offset = "0x23DB530", VA = "0x23DB530")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D598C", Offset = "0x9D598C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public Vector3 bottom
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x23DB53C", Offset = "0x23DB53C", VA = "0x23DB53C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D599C", Offset = "0x9D599C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x23DB548", Offset = "0x23DB548", VA = "0x23DB548")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D59AC", Offset = "0x9D59AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public Rigidbody r
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x23DB554", Offset = "0x23DB554", VA = "0x23DB554")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D59BC", Offset = "0x9D59BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x23DB55C", Offset = "0x23DB55C", VA = "0x23DB55C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D59CC", Offset = "0x9D59CC")]
			private set
			{
			}
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x23DB564", Offset = "0x23DB564", VA = "0x23DB564")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x23DB5E8", Offset = "0x23DB5E8", VA = "0x23DB5E8")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x23DB770", Offset = "0x23DB770", VA = "0x23DB770")]
		private void OnCollisionStay(Collision c)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x23DB774", Offset = "0x23DB774", VA = "0x23DB774")]
		private void OnCollisionExit(Collision c)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x23DB77C", Offset = "0x23DB77C", VA = "0x23DB77C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x23DB7CC", Offset = "0x23DB7CC", VA = "0x23DB7CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x23DB5EC", Offset = "0x23DB5EC", VA = "0x23DB5EC")]
		private void ProcessCollision(Collision c)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x23DB80C", Offset = "0x23DB80C", VA = "0x23DB80C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x23DB830", Offset = "0x23DB830", VA = "0x23DB830")]
		public PressureSensor()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public abstract class Prop : MonoBehaviour
	{
		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D42CC", Offset = "0x9D42CC")]
		public int propType;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D4304", Offset = "0x9D4304")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4304", Offset = "0x9D4304")]
		public ConfigurableJoint muscle;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4364", Offset = "0x9D4364")]
		public Muscle.Props muscleProps;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D439C", Offset = "0x9D439C")]
		public bool forceLayers;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D43D4", Offset = "0x9D43D4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D43D4", Offset = "0x9D43D4")]
		public ConfigurableJoint additionalPin;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4434", Offset = "0x9D4434")]
		public Transform additionalPinTarget;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D446C", Offset = "0x9D446C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D446C", Offset = "0x9D446C")]
		public float additionalPinWeight;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D44C0", Offset = "0x9D44C0")]
		private PropRoot <propRoot>k__BackingField;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ConfigurableJointMotion xMotion;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private ConfigurableJointMotion yMotion;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ConfigurableJointMotion zMotion;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private ConfigurableJointMotion angularXMotion;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ConfigurableJointMotion angularYMotion;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private ConfigurableJointMotion angularZMotion;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Collider[] colliders;

		[Token(Token = "0x17000048")]
		public bool isPickedUp
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x23DB838", Offset = "0x23DB838", VA = "0x23DB838")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000049")]
		public PropRoot propRoot
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x23DB8A4", Offset = "0x23DB8A4", VA = "0x23DB8A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D59DC", Offset = "0x9D59DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x23DB8AC", Offset = "0x23DB8AC", VA = "0x23DB8AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D59EC", Offset = "0x9D59EC")]
			private set
			{
			}
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x23DB8B4", Offset = "0x23DB8B4", VA = "0x23DB8B4")]
		public void PickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x23DBA68", Offset = "0x23DBA68", VA = "0x23DBA68")]
		public void Drop()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x23DBA9C", Offset = "0x23DBA9C", VA = "0x23DBA9C")]
		public void StartPickedUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x23DBAA4", Offset = "0x23DBAA4", VA = "0x23DBAA4", Slot = "4")]
		protected virtual void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x23DBAA8", Offset = "0x23DBAA8", VA = "0x23DBAA8", Slot = "5")]
		protected virtual void OnDrop()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x23DBAAC", Offset = "0x23DBAAC", VA = "0x23DBAAC", Slot = "6")]
		protected virtual void OnStart()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x23DBAB0", Offset = "0x23DBAB0", VA = "0x23DBAB0", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x23DBC7C", Offset = "0x23DBC7C", VA = "0x23DBC7C")]
		private void Start()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x23DBCB4", Offset = "0x23DBCB4", VA = "0x23DBCB4")]
		private void ReleaseJoint()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x23DBDBC", Offset = "0x23DBDBC", VA = "0x23DBDBC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x23DBF68", Offset = "0x23DBF68", VA = "0x23DBF68")]
		protected Prop()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D1970", Offset = "0x9D1970")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D1970", Offset = "0x9D1970")]
	public class PropRoot : MonoBehaviour
	{
		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D44D0", Offset = "0x9D44D0")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4508", Offset = "0x9D4508")]
		public Rigidbody connectTo;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4540", Offset = "0x9D4540")]
		public Prop currentProp;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Prop lastProp;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool fixedUpdateCalled;

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x23DC6B0", Offset = "0x23DC6B0", VA = "0x23DC6B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D59FC", Offset = "0x9D59FC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x23DC6F8", Offset = "0x23DC6F8", VA = "0x23DC6F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D5A34", Offset = "0x9D5A34")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x23DC170", Offset = "0x23DC170", VA = "0x23DC170")]
		public void DropImmediate()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x23DC740", Offset = "0x23DC740", VA = "0x23DC740")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x23DC7D4", Offset = "0x23DC7D4", VA = "0x23DC7D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x23DC940", Offset = "0x23DC940", VA = "0x23DC940")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x23DCB40", Offset = "0x23DCB40", VA = "0x23DCB40")]
		private void AttachProp(Prop prop)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x23DD708", Offset = "0x23DD708", VA = "0x23DD708")]
		public PropRoot()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D19D0", Offset = "0x9D19D0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D19D0", Offset = "0x9D19D0")]
	public class PropTemplate : Prop
	{
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x23DD710", Offset = "0x23DD710", VA = "0x23DD710", Slot = "6")]
		protected override void OnStart()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x23DD714", Offset = "0x23DD714", VA = "0x23DD714", Slot = "4")]
		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x23DD718", Offset = "0x23DD718", VA = "0x23DD718", Slot = "5")]
		protected override void OnDrop()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x23DD71C", Offset = "0x23DD71C", VA = "0x23DD71C")]
		public PropTemplate()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D1A30", Offset = "0x9D1A30")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D1A30", Offset = "0x9D1A30")]
	public class PuppetMaster : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000078")]
		public enum Mode
		{
			[Token(Token = "0x4000346")]
			Active,
			[Token(Token = "0x4000347")]
			Kinematic,
			[Token(Token = "0x4000348")]
			Disabled
		}

		[Token(Token = "0x2000079")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x200007A")]
		public delegate void MuscleDelegate(Muscle muscle);

		[Serializable]
		[Token(Token = "0x200007B")]
		public enum UpdateMode
		{
			[Token(Token = "0x400034A")]
			Normal,
			[Token(Token = "0x400034B")]
			AnimatePhysics,
			[Token(Token = "0x400034C")]
			FixedUpdate
		}

		[Serializable]
		[Token(Token = "0x200007C")]
		public enum State
		{
			[Token(Token = "0x400034E")]
			Alive,
			[Token(Token = "0x400034F")]
			Dead,
			[Token(Token = "0x4000350")]
			Frozen
		}

		[Serializable]
		[Token(Token = "0x200007D")]
		public struct StateSettings
		{
			[Token(Token = "0x4000351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4B60", Offset = "0x9D4B60")]
			public float killDuration;

			[Token(Token = "0x4000352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4B98", Offset = "0x9D4B98")]
			public float deadMuscleWeight;

			[Token(Token = "0x4000353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4BD0", Offset = "0x9D4BD0")]
			public float deadMuscleDamper;

			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4C08", Offset = "0x9D4C08")]
			public float maxFreezeSqrVelocity;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4C40", Offset = "0x9D4C40")]
			public bool freezePermanently;

			[Token(Token = "0x4000356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4C78", Offset = "0x9D4C78")]
			public bool enableAngularLimitsOnKill;

			[Token(Token = "0x4000357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4CB0", Offset = "0x9D4CB0")]
			public bool enableInternalCollisionsOnKill;

			[Token(Token = "0x17000058")]
			public static StateSettings Default
			{
				[Token(Token = "0x6000355")]
				[Address(RVA = "0x266F654", Offset = "0x266F654", VA = "0x266F654")]
				get
				{
					return default(StateSettings);
				}
			}

			[Token(Token = "0x6000354")]
			[Address(RVA = "0x267B404", Offset = "0x267B404", VA = "0x267B404")]
			public StateSettings(float killDuration, float deadMuscleWeight = 0.01f, float deadMuscleDamper = 2f, float maxFreezeSqrVelocity = 0.02f, bool freezePermanently = false, bool enableAngularLimitsOnKill = true, bool enableInternalCollisionsOnKill = true)
			{
			}
		}

		[Token(Token = "0x200007E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1A90", Offset = "0x9D1A90")]
		private sealed class <DisabledToActive>d__125 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400035A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000059")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000359")]
				[Address(RVA = "0x267ADC8", Offset = "0x267ADC8", VA = "0x267ADC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600035B")]
				[Address(RVA = "0x267AE10", Offset = "0x267AE10", VA = "0x267AE10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000356")]
			[Address(RVA = "0x267AB2C", Offset = "0x267AB2C", VA = "0x267AB2C")]
			[DebuggerHidden]
			public <DisabledToActive>d__125(int <>1__state)
			{
			}

			[Token(Token = "0x6000357")]
			[Address(RVA = "0x267AB58", Offset = "0x267AB58", VA = "0x267AB58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000358")]
			[Address(RVA = "0x267AB5C", Offset = "0x267AB5C", VA = "0x267AB5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600035A")]
			[Address(RVA = "0x267ADD0", Offset = "0x267ADD0", VA = "0x267ADD0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200007F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1AA0", Offset = "0x9D1AA0")]
		private sealed class <KinematicToActive>d__127 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400035B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400035C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x1700005B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600035F")]
				[Address(RVA = "0x267B010", Offset = "0x267B010", VA = "0x267B010", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000361")]
				[Address(RVA = "0x267B058", Offset = "0x267B058", VA = "0x267B058", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600035C")]
			[Address(RVA = "0x267AE18", Offset = "0x267AE18", VA = "0x267AE18")]
			[DebuggerHidden]
			public <KinematicToActive>d__127(int <>1__state)
			{
			}

			[Token(Token = "0x600035D")]
			[Address(RVA = "0x267AE44", Offset = "0x267AE44", VA = "0x267AE44", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600035E")]
			[Address(RVA = "0x267AE48", Offset = "0x267AE48", VA = "0x267AE48", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000360")]
			[Address(RVA = "0x267B018", Offset = "0x267B018", VA = "0x267B018", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000080")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1AB0", Offset = "0x9D1AB0")]
		private sealed class <ActiveToDisabled>d__128 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x1700005D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000365")]
				[Address(RVA = "0x267A340", Offset = "0x267A340", VA = "0x267A340", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000367")]
				[Address(RVA = "0x267A388", Offset = "0x267A388", VA = "0x267A388", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000362")]
			[Address(RVA = "0x267A1F8", Offset = "0x267A1F8", VA = "0x267A1F8")]
			[DebuggerHidden]
			public <ActiveToDisabled>d__128(int <>1__state)
			{
			}

			[Token(Token = "0x6000363")]
			[Address(RVA = "0x267A224", Offset = "0x267A224", VA = "0x267A224", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000364")]
			[Address(RVA = "0x267A228", Offset = "0x267A228", VA = "0x267A228", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000366")]
			[Address(RVA = "0x267A348", Offset = "0x267A348", VA = "0x267A348", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000081")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1AC0", Offset = "0x9D1AC0")]
		private sealed class <ActiveToKinematic>d__129 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x1700005F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600036B")]
				[Address(RVA = "0x267A510", Offset = "0x267A510", VA = "0x267A510", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000060")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600036D")]
				[Address(RVA = "0x267A558", Offset = "0x267A558", VA = "0x267A558", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000368")]
			[Address(RVA = "0x267A390", Offset = "0x267A390", VA = "0x267A390")]
			[DebuggerHidden]
			public <ActiveToKinematic>d__129(int <>1__state)
			{
			}

			[Token(Token = "0x6000369")]
			[Address(RVA = "0x267A3BC", Offset = "0x267A3BC", VA = "0x267A3BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600036A")]
			[Address(RVA = "0x267A3C0", Offset = "0x267A3C0", VA = "0x267A3C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600036C")]
			[Address(RVA = "0x267A518", Offset = "0x267A518", VA = "0x267A518", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000082")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1AD0", Offset = "0x9D1AD0")]
		private sealed class <AliveToDead>d__181 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool freeze;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <range>5__2;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <mW>5__3;

			[Token(Token = "0x17000061")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000371")]
				[Address(RVA = "0x267AADC", Offset = "0x267AADC", VA = "0x267AADC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000062")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000373")]
				[Address(RVA = "0x267AB24", Offset = "0x267AB24", VA = "0x267AB24", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600036E")]
			[Address(RVA = "0x267A560", Offset = "0x267A560", VA = "0x267A560")]
			[DebuggerHidden]
			public <AliveToDead>d__181(int <>1__state)
			{
			}

			[Token(Token = "0x600036F")]
			[Address(RVA = "0x267A58C", Offset = "0x267A58C", VA = "0x267A58C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000370")]
			[Address(RVA = "0x267A590", Offset = "0x267A590", VA = "0x267A590", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000372")]
			[Address(RVA = "0x267AAE4", Offset = "0x267AAE4", VA = "0x267AAE4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4578", Offset = "0x9D4578")]
		public PuppetMasterHumanoidConfig humanoidConfig;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform targetRoot;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D45B0", Offset = "0x9D45B0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D45B0", Offset = "0x9D45B0")]
		public State state;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x9D4610", Offset = "0x9D4610")]
		public StateSettings stateSettings;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D465C", Offset = "0x9D465C")]
		public Mode mode;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4694", Offset = "0x9D4694")]
		public float blendTime;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D46CC", Offset = "0x9D46CC")]
		public bool fixTargetTransforms;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4704", Offset = "0x9D4704")]
		public int solverIterationCount;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D473C", Offset = "0x9D473C")]
		public bool visualizeTargetPose;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D4774", Offset = "0x9D4774")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4774", Offset = "0x9D4774")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D4774", Offset = "0x9D4774")]
		public float mappingWeight;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D47EC", Offset = "0x9D47EC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D47EC", Offset = "0x9D47EC")]
		public float pinWeight;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4840", Offset = "0x9D4840")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D4840", Offset = "0x9D4840")]
		public float muscleWeight;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D4894", Offset = "0x9D4894")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4894", Offset = "0x9D4894")]
		public float muscleSpring;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D48F4", Offset = "0x9D48F4")]
		public float muscleDamper;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D492C", Offset = "0x9D492C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D492C", Offset = "0x9D492C")]
		public float pinPow;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4980", Offset = "0x9D4980")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D4980", Offset = "0x9D4980")]
		public float pinDistanceFalloff;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D49D8", Offset = "0x9D49D8")]
		public bool updateJointAnchors;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4A10", Offset = "0x9D4A10")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4A48", Offset = "0x9D4A48")]
		public bool angularLimits;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D4A80", Offset = "0x9D4A80")]
		public bool internalCollisions;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D4AB8", Offset = "0x9D4AB8")]
		public Muscle[] muscles;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UpdateDelegate OnRead;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnWrite;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPostLateUpdate;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public UpdateDelegate OnHierarchyChanged;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public MuscleDelegate OnMuscleRemoved;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Animator _targetAnimator;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D4AF0", Offset = "0x9D4AF0")]
		private Animation <targetAnimation>k__BackingField;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D4B00", Offset = "0x9D4B00")]
		private BehaviourBase[] <behaviours>k__BackingField;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D4B10", Offset = "0x9D4B10")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[HideInInspector]
		public List<SolverManager> solvers;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool internalCollisionsEnabled;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool angularLimitsEnabled;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE2")]
		private bool fixedFrame;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int lastSolverIterationCount;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool isLegacy;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		private bool animatorDisabled;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
		private bool awakeFailed;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEB")]
		private bool interpolated;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private bool freezeFlag;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xED")]
		private bool hasBeenDisabled;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEE")]
		private bool hierarchyIsFlat;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEF")]
		private bool teleport;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 teleportPosition;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private Quaternion teleportRotation;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool teleportMoveToTarget;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D4B30", Offset = "0x9D4B30")]
		private bool <isSwitchingMode>k__BackingField;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Mode activeMode;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Mode lastMode;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float mappingBlend;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D4B40", Offset = "0x9D4B40")]
		private bool <isKilling>k__BackingField;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public UpdateDelegate OnFreeze;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public UpdateDelegate OnUnfreeze;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public UpdateDelegate OnDeath;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public UpdateDelegate OnResurrection;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private State activeState;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private State lastState;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool angularLimitsEnabledOnKill;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		private bool internalCollisionsEnabledOnKill;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A")]
		private bool animationDisabledbyStates;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14B")]
		[HideInInspector]
		public bool storeTargetMappedState;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Transform[] targetChildren;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3[] targetMappedPositions;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Quaternion[] targetMappedRotations;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Vector3[] targetSampledPositions;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Quaternion[] targetSampledRotations;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private bool targetMappedStateStored;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x179")]
		private bool targetMappedStateSampled;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17A")]
		private bool sampleTargetMappedState;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17B")]
		private bool hasProp;

		[Token(Token = "0x1700004A")]
		public Animator targetAnimator
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x23DDB58", Offset = "0x23DDB58", VA = "0x23DDB58")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x23DDCBC", Offset = "0x23DDCBC", VA = "0x23DDCBC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public Animation targetAnimation
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x23DDCC4", Offset = "0x23DDCC4", VA = "0x23DDCC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5BBC", Offset = "0x9D5BBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x23DDCCC", Offset = "0x23DDCCC", VA = "0x23DDCCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5BCC", Offset = "0x9D5BCC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public BehaviourBase[] behaviours
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x23DDCD4", Offset = "0x23DDCD4", VA = "0x23DDCD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5BDC", Offset = "0x9D5BDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x23DDCDC", Offset = "0x23DDCDC", VA = "0x23DDCDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5BEC", Offset = "0x9D5BEC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public bool isActive
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x23DDCE4", Offset = "0x23DDCE4", VA = "0x23DDCE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		public bool initiated
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x23DDD68", Offset = "0x23DDD68", VA = "0x23DDD68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5BFC", Offset = "0x9D5BFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x23DDD70", Offset = "0x23DDD70", VA = "0x23DDD70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5C0C", Offset = "0x9D5C0C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public UpdateMode updateMode
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x23DDD7C", Offset = "0x23DDD7C", VA = "0x23DDD7C")]
			get
			{
				return default(UpdateMode);
			}
		}

		[Token(Token = "0x17000050")]
		public bool controlsAnimator
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x23DDEB4", Offset = "0x23DDEB4", VA = "0x23DDEB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000051")]
		public bool isBlending
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x23DDD44", Offset = "0x23DDD44", VA = "0x23DDD44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000052")]
		private AnimatorUpdateMode targetUpdateMode
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x23DDDBC", Offset = "0x23DDDBC", VA = "0x23DDDBC")]
			get
			{
				return default(AnimatorUpdateMode);
			}
		}

		[Token(Token = "0x17000053")]
		public bool isSwitchingMode
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x23E3294", Offset = "0x23E3294", VA = "0x23E3294")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5CC4", Offset = "0x9D5CC4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x23E329C", Offset = "0x23E329C", VA = "0x23E329C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5CD4", Offset = "0x9D5CD4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public bool isSwitchingState
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x23DDF14", Offset = "0x23DDF14", VA = "0x23DDF14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		public bool isKilling
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x23E6BF8", Offset = "0x23E6BF8", VA = "0x23E6BF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5E64", Offset = "0x9D5E64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x23E6C00", Offset = "0x23E6C00", VA = "0x23E6C00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5E74", Offset = "0x9D5E74")]
			private set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public bool isAlive
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x23E1E28", Offset = "0x23E1E28", VA = "0x23E1E28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		public bool isFrozen
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x23E1544", Offset = "0x23E1544", VA = "0x23E1544")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x23DD958", Offset = "0x23DD958", VA = "0x23DD958")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D5A6C", Offset = "0x9D5A6C")]
		private void OpenUserManualSetup()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x23DD9A0", Offset = "0x23DD9A0", VA = "0x23DD9A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D5AA4", Offset = "0x9D5AA4")]
		private void OpenUserManualComponent()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x23DD9E8", Offset = "0x23DD9E8", VA = "0x23DD9E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D5ADC", Offset = "0x9D5ADC")]
		private void OpenUserManualPerformance()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x23DDA30", Offset = "0x23DDA30", VA = "0x23DDA30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D5B14", Offset = "0x9D5B14")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x23DDA78", Offset = "0x23DDA78", VA = "0x23DDA78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D5B4C", Offset = "0x9D5B4C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x23DDAC0", Offset = "0x23DDAC0", VA = "0x23DDAC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D5B84", Offset = "0x9D5B84")]
		private void OpenComponentTutorial()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x23DDB08", Offset = "0x23DDB08", VA = "0x23DDB08")]
		private void ResetStateSettings()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x23DDF28", Offset = "0x23DDF28", VA = "0x23DDF28")]
		public void Teleport(Vector3 position, Quaternion rotation, bool moveToTarget)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x23DDF50", Offset = "0x23DDF50", VA = "0x23DDF50")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x23DDFF8", Offset = "0x23DDFF8", VA = "0x23DDFF8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x23DE6F0", Offset = "0x23DE6F0", VA = "0x23DE6F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x23DF15C", Offset = "0x23DF15C", VA = "0x23DF15C")]
		private void Start()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x23DF20C", Offset = "0x23DF20C", VA = "0x23DF20C")]
		public Transform FindTargetRootRecursive(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x23DE734", Offset = "0x23DE734", VA = "0x23DE734")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x23E05C4", Offset = "0x23E05C4", VA = "0x23E05C4")]
		private void ActivateBehaviour(BehaviourBase behaviour)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x23E06BC", Offset = "0x23E06BC", VA = "0x23E06BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x23E07C4", Offset = "0x23E07C4", VA = "0x23E07C4")]
		private bool IsInterpolated()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x23E0850", Offset = "0x23E0850", VA = "0x23E0850", Slot = "4")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x23E16E8", Offset = "0x23E16E8", VA = "0x23E16E8", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x23E1764", Offset = "0x23E1764", VA = "0x23E1764", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x23E17B8", Offset = "0x23E17B8", VA = "0x23E17B8", Slot = "7")]
		protected virtual void OnLateUpdate()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x23E19FC", Offset = "0x23E19FC", VA = "0x23E19FC")]
		private void MoveToTarget()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x23E0DBC", Offset = "0x23E0DBC", VA = "0x23E0DBC")]
		private void Read()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x23E0C7C", Offset = "0x23E0C7C", VA = "0x23E0C7C")]
		private void FixTargetTransforms()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x23E1E38", Offset = "0x23E1E38", VA = "0x23E1E38")]
		private void VisualizeTargetPose()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x23E20E8", Offset = "0x23E20E8", VA = "0x23E20E8")]
		private void VisualizeHierarchy(Transform t, Color color)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x23E1554", Offset = "0x23E1554", VA = "0x23E1554")]
		private void SetInternalCollisions(bool collide)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x23E164C", Offset = "0x23E164C", VA = "0x23E164C")]
		private void SetAngularLimits(bool limited)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x23DCD94", Offset = "0x23DCD94", VA = "0x23DCD94")]
		public void AddMuscle(ConfigurableJoint joint, Transform target, Rigidbody connectTo, Transform targetParent, [Optional] Muscle.Props muscleProps, bool forceTreeHierarchy = false, bool forceLayers = true)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x23D4B50", Offset = "0x23D4B50", VA = "0x23D4B50")]
		public void RemoveMuscleRecursive(ConfigurableJoint joint, bool attachTarget, bool blockTargetAnimation = false, MuscleRemoveMode removeMode = MuscleRemoveMode.Sever)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x23E2AD4", Offset = "0x23E2AD4", VA = "0x23E2AD4")]
		public void ReplaceMuscle(ConfigurableJoint oldJoint, ConfigurableJoint newJoint)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x23E2B7C", Offset = "0x23E2B7C", VA = "0x23E2B7C")]
		public void SetMuscles(Muscle[] newMuscles)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x23E2C24", Offset = "0x23E2C24", VA = "0x23E2C24")]
		public void DisableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x23E2CCC", Offset = "0x23E2CCC", VA = "0x23E2CCC")]
		public void EnableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x23E2D74", Offset = "0x23E2D74", VA = "0x23E2D74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D5C1C", Offset = "0x9D5C1C")]
		public void FlattenHierarchy()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x23E2E80", Offset = "0x23E2E80", VA = "0x23E2E80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D5C54", Offset = "0x9D5C54")]
		public void TreeHierarchy()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x23E2FF0", Offset = "0x23E2FF0", VA = "0x23E2FF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D5C8C", Offset = "0x9D5C8C")]
		public void FixMusclePositions()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x23E3128", Offset = "0x23E3128", VA = "0x23E3128")]
		private void AddIndexesRecursive(int index, ref int[] indexes)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x23E0224", Offset = "0x23E0224", VA = "0x23E0224")]
		private bool HierarchyIsFlat()
		{
			return default(bool);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x23E29B8", Offset = "0x23E29B8", VA = "0x23E29B8")]
		private void DisconnectJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x23E2A50", Offset = "0x23E2A50", VA = "0x23E2A50")]
		private void KillJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x23E32A8", Offset = "0x23E32A8", VA = "0x23E32A8")]
		public void DisableImmediately()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x23E3344", Offset = "0x23E3344", VA = "0x23E3344", Slot = "8")]
		protected virtual void SwitchModes()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x23E34A8", Offset = "0x23E34A8", VA = "0x23E34A8")]
		private void DisabledToKinematic()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x23E35EC", Offset = "0x23E35EC", VA = "0x23E35EC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9D5CE4", Offset = "0x9D5CE4")]
		private IEnumerator DisabledToActive()
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x23E3664", Offset = "0x23E3664", VA = "0x23E3664")]
		private void KinematicToDisabled()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x23E3700", Offset = "0x23E3700", VA = "0x23E3700")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9D5D44", Offset = "0x9D5D44")]
		private IEnumerator KinematicToActive()
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x23E3778", Offset = "0x23E3778", VA = "0x23E3778")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9D5DA4", Offset = "0x9D5DA4")]
		private IEnumerator ActiveToDisabled()
		{
			return null;
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x23E37F0", Offset = "0x23E37F0", VA = "0x23E37F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9D5E04", Offset = "0x9D5E04")]
		private IEnumerator ActiveToKinematic()
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x23E3868", Offset = "0x23E3868", VA = "0x23E3868")]
		private void UpdateInternalCollisions()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x23E3938", Offset = "0x23E3938", VA = "0x23E3938")]
		public void SetMuscleWeights(Muscle.Group group, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x23E3A08", Offset = "0x23E3A08", VA = "0x23E3A08")]
		public void SetMuscleWeights(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x23E3E74", Offset = "0x23E3E74", VA = "0x23E3E74")]
		public void SetMuscleWeights(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x23E4184", Offset = "0x23E4184", VA = "0x23E4184")]
		public void SetMuscleWeightsRecursive(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x23E42B4", Offset = "0x23E42B4", VA = "0x23E42B4")]
		public void SetMuscleWeightsRecursive(int muscleIndex, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x23E43A0", Offset = "0x23E43A0", VA = "0x23E43A0")]
		public void SetMuscleWeightsRecursive(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x23E3C94", Offset = "0x23E3C94", VA = "0x23E3C94")]
		public void SetMuscleWeights(int muscleIndex, float muscleWeight, float pinWeight, float mappingWeight, float muscleDamper)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x23E4428", Offset = "0x23E4428", VA = "0x23E4428")]
		public Muscle GetMuscle(Transform target)
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x23E23E8", Offset = "0x23E23E8", VA = "0x23E23E8")]
		public Muscle GetMuscle(Rigidbody rigidbody)
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x23E4688", Offset = "0x23E4688", VA = "0x23E4688")]
		public Muscle GetMuscle(ConfigurableJoint joint)
		{
			return null;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x23E22FC", Offset = "0x23E22FC", VA = "0x23E22FC")]
		public bool ContainsJoint(ConfigurableJoint joint)
		{
			return default(bool);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x23E3EFC", Offset = "0x23E3EFC", VA = "0x23E3EFC")]
		public int GetMuscleIndex(HumanBodyBones humanBodyBone)
		{
			return default(int);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x23E3A90", Offset = "0x23E3A90", VA = "0x23E3A90")]
		public int GetMuscleIndex(Transform target)
		{
			return default(int);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x23E4484", Offset = "0x23E4484", VA = "0x23E4484")]
		public int GetMuscleIndex(Rigidbody rigidbody)
		{
			return default(int);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x23E27B4", Offset = "0x23E27B4", VA = "0x23E27B4")]
		public int GetMuscleIndex(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x23E46E4", Offset = "0x23E46E4", VA = "0x23E46E4")]
		public static PuppetMaster SetUp(Transform target, Transform ragdoll, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x23D0630", Offset = "0x23D0630", VA = "0x23D0630")]
		public static PuppetMaster SetUp(Transform target, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x23E47E0", Offset = "0x23E47E0", VA = "0x23E47E0")]
		public void SetUpTo(Transform setUpTo, int characterControllerLayer, int ragdollLayer)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x23E5408", Offset = "0x23E5408", VA = "0x23E5408")]
		public static void RemoveRagdollComponents(Transform target, int characterControllerLayer)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x23E5CB4", Offset = "0x23E5CB4", VA = "0x23E5CB4")]
		private void SetUpMuscles(Transform setUpTo)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x23E6754", Offset = "0x23E6754", VA = "0x23E6754")]
		private static Muscle.Group FindGroup(Animator animator, Transform t)
		{
			return default(Muscle.Group);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x23E5874", Offset = "0x23E5874", VA = "0x23E5874")]
		private void RemoveUnnecessaryBones()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x23E6444", Offset = "0x23E6444", VA = "0x23E6444")]
		private static bool IsClothCollider(Collider collider, Cloth[] cloths)
		{
			return default(bool);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x23E6C0C", Offset = "0x23E6C0C", VA = "0x23E6C0C")]
		public void Kill()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x23D6768", Offset = "0x23D6768", VA = "0x23D6768")]
		public void Kill(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x23E6C18", Offset = "0x23E6C18", VA = "0x23E6C18")]
		public void Freeze()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x23D6784", Offset = "0x23D6784", VA = "0x23D6784")]
		public void Freeze(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x23D67A0", Offset = "0x23D67A0", VA = "0x23D67A0")]
		public void Resurrect()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x23E6C24", Offset = "0x23E6C24", VA = "0x23E6C24", Slot = "9")]
		protected virtual void SwitchStates()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x23E6D24", Offset = "0x23E6D24", VA = "0x23E6D24")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9D5E84", Offset = "0x9D5E84")]
		private IEnumerator AliveToDead(bool freeze)
		{
			return null;
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x23E1BA8", Offset = "0x23E1BA8", VA = "0x23E1BA8")]
		private void OnFreezeFlag()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x23E6DB0", Offset = "0x23E6DB0", VA = "0x23E6DB0")]
		private void DeadToAlive()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x23DE46C", Offset = "0x23DE46C", VA = "0x23DE46C")]
		private void SetAnimationEnabled(bool to)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x23E6EC0", Offset = "0x23E6EC0", VA = "0x23E6EC0")]
		private void DeadToFrozen()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x23E6ECC", Offset = "0x23E6ECC", VA = "0x23E6ECC")]
		private void FrozenToAlive()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x23E70E8", Offset = "0x23E70E8", VA = "0x23E70E8")]
		private void FrozenToDead()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x23DE568", Offset = "0x23DE568", VA = "0x23DE568")]
		private void ActivateRagdoll(bool kinematic = false)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x23E71BC", Offset = "0x23E71BC", VA = "0x23E71BC")]
		private bool CanFreeze()
		{
			return default(bool);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x23E7278", Offset = "0x23E7278", VA = "0x23E7278")]
		public void SampleTargetMappedState()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x23E736C", Offset = "0x23E736C", VA = "0x23E736C")]
		public void FixTargetToSampledState(float weight)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x23E0330", Offset = "0x23E0330", VA = "0x23E0330")]
		public void StoreTargetMappedState()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x23DFFE0", Offset = "0x23DFFE0", VA = "0x23DFFE0")]
		private void UpdateHierarchies()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x23E7D58", Offset = "0x23E7D58", VA = "0x23E7D58")]
		private bool HasProp()
		{
			return default(bool);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x23E7BF0", Offset = "0x23E7BF0", VA = "0x23E7BF0")]
		private void UpdateBroadcasterMuscleIndexes()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x23E77A0", Offset = "0x23E77A0", VA = "0x23E77A0")]
		private void AssignParentAndChildIndexes()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x23E7DD0", Offset = "0x23E7DD0", VA = "0x23E7DD0")]
		private void AddToParentsRecursive(ConfigurableJoint joint, ref int[] indexes)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x23E7F4C", Offset = "0x23E7F4C", VA = "0x23E7F4C")]
		private void AddToChildrenRecursive(ConfigurableJoint joint, ref int[] indexes, ref bool[] childFlags)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x23E7ADC", Offset = "0x23E7ADC", VA = "0x23E7ADC")]
		private void AssignKinshipDegrees()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x23E823C", Offset = "0x23E823C", VA = "0x23E823C")]
		private void AssignKinshipsDownRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x23E839C", Offset = "0x23E839C", VA = "0x23E839C")]
		private void AssignKinshipsUpRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x23E8164", Offset = "0x23E8164", VA = "0x23E8164")]
		private int GetMuscleIndexLowLevel(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x23DF5A0", Offset = "0x23DF5A0", VA = "0x23DF5A0")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x23E2444", Offset = "0x23E2444", VA = "0x23E2444")]
		private bool CheckMassVariation(float threshold, bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x23E2264", Offset = "0x23E2264", VA = "0x23E2264")]
		private bool CheckIfInitiated()
		{
			return default(bool);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x23E85FC", Offset = "0x23E85FC", VA = "0x23E85FC")]
		public PuppetMaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public enum MuscleRemoveMode
	{
		[Token(Token = "0x400036B")]
		Sever,
		[Token(Token = "0x400036C")]
		Explode,
		[Token(Token = "0x400036D")]
		Numb
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x9D1AE0", Offset = "0x9D1AE0")]
	public class PuppetMasterHumanoidConfig : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2000085")]
		public class HumanoidMuscle
		{
			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Muscle.Props props;

			[Token(Token = "0x6000377")]
			[Address(RVA = "0x267B474", Offset = "0x267B474", VA = "0x267B474")]
			public HumanoidMuscle()
			{
			}
		}

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D4CE8", Offset = "0x9D4CE8")]
		public PuppetMaster.State state;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PuppetMaster.StateSettings stateSettings;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PuppetMaster.Mode mode;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blendTime;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool fixTargetTransforms;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int solverIterationCount;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool visualizeTargetPose;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D4D20", Offset = "0x9D4D20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D4D20", Offset = "0x9D4D20")]
		public float mappingWeight;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D4D74", Offset = "0x9D4D74")]
		public float pinWeight;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D4D8C", Offset = "0x9D4D8C")]
		public float muscleWeight;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D4DA4", Offset = "0x9D4DA4")]
		public float muscleSpring;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float muscleDamper;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D4DDC", Offset = "0x9D4DDC")]
		public float pinPow;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D4DF4", Offset = "0x9D4DF4")]
		public float pinDistanceFalloff;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool updateJointAnchors;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool angularLimits;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		public bool internalCollisions;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D4E10", Offset = "0x9D4E10")]
		public HumanoidMuscle[] muscles;

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x266F0C0", Offset = "0x266F0C0", VA = "0x266F0C0")]
		public void ApplyTo(PuppetMaster p)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x266F468", Offset = "0x266F468", VA = "0x266F468")]
		private Muscle GetMuscle(HumanBodyBones boneId, Animator animator, PuppetMaster puppetMaster)
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x266F598", Offset = "0x266F598", VA = "0x266F598")]
		public PuppetMasterHumanoidConfig()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D1B4C", Offset = "0x9D1B4C")]
	public class PuppetMasterSettings : Singleton<PuppetMasterSettings>
	{
		[Serializable]
		[Token(Token = "0x2000087")]
		public class PuppetUpdateLimit
		{
			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D4EE8", Offset = "0x9D4EE8")]
			public int puppetsPerFrame;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int index;

			[Token(Token = "0x6000387")]
			[Address(RVA = "0x266FD64", Offset = "0x266FD64", VA = "0x266FD64")]
			public PuppetUpdateLimit()
			{
			}

			[Token(Token = "0x6000388")]
			[Address(RVA = "0x266FB6C", Offset = "0x266FB6C", VA = "0x266FB6C")]
			public void Step(int puppetCount)
			{
			}

			[Token(Token = "0x6000389")]
			[Address(RVA = "0x266F7DC", Offset = "0x266F7DC", VA = "0x266F7DC")]
			public bool Update(List<PuppetMaster> puppets, PuppetMaster puppetMaster)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D4E80", Offset = "0x9D4E80")]
		public PuppetUpdateLimit kinematicCollidersUpdateLimit;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PuppetUpdateLimit freeUpdateLimit;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PuppetUpdateLimit fixedUpdateLimit;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool collisionStayMessages;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool collisionExitMessages;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float activePuppetCollisionThresholdMlp;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D4EB8", Offset = "0x9D4EB8")]
		private int <currentlyActivePuppets>k__BackingField;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D4EC8", Offset = "0x9D4EC8")]
		private int <currentlyKinematicPuppets>k__BackingField;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D4ED8", Offset = "0x9D4ED8")]
		private int <currentlyDisabledPuppets>k__BackingField;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<PuppetMaster> _puppets;

		[Token(Token = "0x17000063")]
		public int currentlyActivePuppets
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x266F67C", Offset = "0x266F67C", VA = "0x266F67C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D6074", Offset = "0x9D6074")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x266F684", Offset = "0x266F684", VA = "0x266F684")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D6084", Offset = "0x9D6084")]
			private set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public int currentlyKinematicPuppets
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x266F68C", Offset = "0x266F68C", VA = "0x266F68C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D6094", Offset = "0x9D6094")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x266F694", Offset = "0x266F694", VA = "0x266F694")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D60A4", Offset = "0x9D60A4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public int currentlyDisabledPuppets
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x266F69C", Offset = "0x266F69C", VA = "0x266F69C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D60B4", Offset = "0x9D60B4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x266F6A4", Offset = "0x266F6A4", VA = "0x266F6A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D60C4", Offset = "0x9D60C4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public List<PuppetMaster> puppets
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x266F6AC", Offset = "0x266F6AC", VA = "0x266F6AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x266F6B4", Offset = "0x266F6B4", VA = "0x266F6B4")]
		public void Register(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x266F754", Offset = "0x266F754", VA = "0x266F754")]
		public void Unregister(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x266F7B8", Offset = "0x266F7B8", VA = "0x266F7B8")]
		public bool UpdateMoveToTarget(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x266F908", Offset = "0x266F908", VA = "0x266F908")]
		public bool UpdateFree(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x266F92C", Offset = "0x266F92C", VA = "0x266F92C")]
		public bool UpdateFixed(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x266F950", Offset = "0x266F950", VA = "0x266F950")]
		private void Update()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x266FB88", Offset = "0x266FB88", VA = "0x266FB88")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x266FBF4", Offset = "0x266FBF4", VA = "0x266FBF4")]
		public PuppetMasterSettings()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public static class PuppetMasterTools
	{
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x266FD90", Offset = "0x266FD90", VA = "0x266FD90")]
		public static void PositionRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x2670350", Offset = "0x2670350", VA = "0x2670350")]
		public static void RealignRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x2670C3C", Offset = "0x2670C3C", VA = "0x2670C3C")]
		private static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x2670C60", Offset = "0x2670C60", VA = "0x2670C60")]
		private static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000089")]
	public class Weight
	{
		[Serializable]
		[Token(Token = "0x200008A")]
		public enum Mode
		{
			[Token(Token = "0x4000395")]
			Float,
			[Token(Token = "0x4000396")]
			Curve
		}

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mode mode;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float floatValue;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve curve;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string tooltip;

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x26778AC", Offset = "0x26778AC", VA = "0x26778AC")]
		public Weight(float floatValue)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x267791C", Offset = "0x267791C", VA = "0x267791C")]
		public Weight(float floatValue, string tooltip)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x26779A8", Offset = "0x26779A8", VA = "0x26779A8")]
		public float GetValue(float param)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200008B")]
	public class InitialVelocity : MonoBehaviour
	{
		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 initialVelocity;

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x23D3EE8", Offset = "0x23D3EE8", VA = "0x23D3EE8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x23D3F4C", Offset = "0x23D3F4C", VA = "0x23D3F4C")]
		public InitialVelocity()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D1B84", Offset = "0x9D1B84")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D1B84", Offset = "0x9D1B84")]
	public class BipedRagdollCreator : RagdollCreator
	{
		[Serializable]
		[Token(Token = "0x200008D")]
		public struct Options
		{
			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float weight;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D4F04", Offset = "0x9D4F04")]
			public bool spine;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public bool chest;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public bool hands;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public bool feet;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D4F3C", Offset = "0x9D4F3C")]
			public JointType joints;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float jointRange;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D4F74", Offset = "0x9D4F74")]
			public float colliderLengthOverlap;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ColliderType torsoColliders;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ColliderType headCollider;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ColliderType armColliders;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ColliderType handColliders;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public ColliderType legColliders;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ColliderType footColliders;

			[Token(Token = "0x17000067")]
			public static Options Default
			{
				[Token(Token = "0x60003A4")]
				[Address(RVA = "0x2679908", Offset = "0x2679908", VA = "0x2679908")]
				get
				{
					return default(Options);
				}
			}
		}

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool canBuild;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedRagdollReferences references;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Options options;

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x265ECDC", Offset = "0x265ECDC", VA = "0x265ECDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D60D4", Offset = "0x9D60D4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x265ED24", Offset = "0x265ED24", VA = "0x265ED24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D610C", Offset = "0x9D610C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x265ED6C", Offset = "0x265ED6C", VA = "0x265ED6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D6144", Offset = "0x9D6144")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x265EDB4", Offset = "0x265EDB4", VA = "0x265EDB4")]
		public static Options AutodetectOptions(BipedRagdollReferences r)
		{
			return default(Options);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x265F05C", Offset = "0x265F05C", VA = "0x265F05C")]
		public static void Create(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x265FA38", Offset = "0x265FA38", VA = "0x265FA38")]
		private static void CreateColliders(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x2661224", Offset = "0x2661224", VA = "0x2661224")]
		private static void CreateHandCollider(Transform hand, Transform lowerArm, Transform root, Options options)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x2661450", Offset = "0x2661450", VA = "0x2661450")]
		private static void CreateFootCollider(Transform foot, Transform lowerLeg, Transform upperLeg, Transform root, Options options)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x2661844", Offset = "0x2661844", VA = "0x2661844")]
		private static Vector3 GetChildCentroid(Transform t, Vector3 fallback)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x2660514", Offset = "0x2660514", VA = "0x2660514")]
		private static void MassDistribution(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x2660980", Offset = "0x2660980", VA = "0x2660980")]
		private static void CreateJoints(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x2661924", Offset = "0x2661924", VA = "0x2661924")]
		private static void CreateLimbJoints(Transform connectedBone, Transform bone1, Transform bone2, Transform bone3, Transform root, Vector3 defaultWorldDirection, JointType jointType, CreateJointParams.Limits limits1, CreateJointParams.Limits limits2, CreateJointParams.Limits limits3)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x2661ED4", Offset = "0x2661ED4", VA = "0x2661ED4")]
		public static void ClearBipedRagdoll(BipedRagdollReferences r)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x2662348", Offset = "0x2662348", VA = "0x2662348")]
		public static bool IsClear(BipedRagdollReferences r)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x2661174", Offset = "0x2661174", VA = "0x2661174")]
		private static Vector3 GetUpperArmToHeadCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x265EFBC", Offset = "0x265EFBC", VA = "0x265EFBC")]
		private static Vector3 GetUpperArmCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x266244C", Offset = "0x266244C", VA = "0x266244C")]
		public BipedRagdollCreator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008E")]
	public struct BipedRagdollReferences
	{
		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform root;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform hips;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform spine;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform chest;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform head;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftUpperLeg;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftLowerLeg;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform leftFoot;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightUpperLeg;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightLowerLeg;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightFoot;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftUpperArm;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftLowerArm;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform leftHand;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightUpperArm;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightLowerArm;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform rightHand;

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x265F1AC", Offset = "0x265F1AC", VA = "0x265F1AC")]
		public bool IsValid(ref string msg)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x26624AC", Offset = "0x26624AC", VA = "0x26624AC")]
		private bool IsChildRecursive(Transform t, Transform parent)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x26625A8", Offset = "0x26625A8", VA = "0x26625A8")]
		public bool IsEmpty(bool considerRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x2662940", Offset = "0x2662940", VA = "0x2662940")]
		public bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x2661F4C", Offset = "0x2661F4C", VA = "0x2661F4C")]
		public Transform[] GetRagdollTransforms()
		{
			return null;
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x2662CDC", Offset = "0x2662CDC", VA = "0x2662CDC")]
		public static BipedRagdollReferences FromAvatar(Animator animator)
		{
			return default(BipedRagdollReferences);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x2662F64", Offset = "0x2662F64", VA = "0x2662F64")]
		public static BipedRagdollReferences FromBipedReferences(BipedReferences biped)
		{
			return default(BipedRagdollReferences);
		}
	}
	[Token(Token = "0x200008F")]
	public static class JointConverter
	{
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x23D58AC", Offset = "0x23D58AC", VA = "0x23D58AC")]
		public static void ToConfigurable(GameObject root)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x23D5DE0", Offset = "0x23D5DE0", VA = "0x23D5DE0")]
		public static void HingeToConfigurable(HingeJoint src)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x23D60B4", Offset = "0x23D60B4", VA = "0x23D60B4")]
		public static void FixedToConfigurable(FixedJoint src)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x23D61E8", Offset = "0x23D61E8", VA = "0x23D61E8")]
		public static void SpringToConfigurable(SpringJoint src)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x23D5B98", Offset = "0x23D5B98", VA = "0x23D5B98")]
		public static void CharacterToConfigurable(CharacterJoint src)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x23D6398", Offset = "0x23D6398", VA = "0x23D6398")]
		private static void ConvertJoint(ref ConfigurableJoint conf, Joint src)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x23D64D0", Offset = "0x23D64D0", VA = "0x23D64D0")]
		private static SoftJointLimit ConvertToHighSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x23D658C", Offset = "0x23D658C", VA = "0x23D658C")]
		private static SoftJointLimit ConvertToLowSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x23D6534", Offset = "0x23D6534", VA = "0x23D6534")]
		private static SoftJointLimitSpring ConvertToSoftJointLimitSpring(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimitSpring);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x23D65F0", Offset = "0x23D65F0", VA = "0x23D65F0")]
		private static SoftJointLimit CopyLimit(SoftJointLimit src)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x23D6650", Offset = "0x23D6650", VA = "0x23D6650")]
		private static SoftJointLimitSpring CopyLimitSpring(SoftJointLimitSpring src)
		{
			return default(SoftJointLimitSpring);
		}
	}
	[Token(Token = "0x2000090")]
	public abstract class RagdollCreator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000091")]
		public enum ColliderType
		{
			[Token(Token = "0x40003BB")]
			Box,
			[Token(Token = "0x40003BC")]
			Capsule
		}

		[Serializable]
		[Token(Token = "0x2000092")]
		public enum JointType
		{
			[Token(Token = "0x40003BE")]
			Configurable,
			[Token(Token = "0x40003BF")]
			Character
		}

		[Serializable]
		[Token(Token = "0x2000093")]
		public enum Direction
		{
			[Token(Token = "0x40003C1")]
			X,
			[Token(Token = "0x40003C2")]
			Y,
			[Token(Token = "0x40003C3")]
			Z
		}

		[Token(Token = "0x2000094")]
		public struct CreateJointParams
		{
			[Token(Token = "0x2000095")]
			public struct Limits
			{
				[Token(Token = "0x40003CA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public float minSwing;

				[Token(Token = "0x40003CB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public float maxSwing;

				[Token(Token = "0x40003CC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public float swing2;

				[Token(Token = "0x40003CD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public float twist;

				[Token(Token = "0x60003C7")]
				[Address(RVA = "0x267B58C", Offset = "0x267B58C", VA = "0x267B58C")]
				public Limits(float minSwing, float maxSwing, float swing2, float twist)
				{
				}
			}

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rigidbody rigidbody;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Rigidbody connectedBody;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform child;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 worldSwingAxis;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Limits limits;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public JointType type;

			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x267B47C", Offset = "0x267B47C", VA = "0x267B47C")]
			public CreateJointParams(Rigidbody rigidbody, Rigidbody connectedBody, Transform child, Vector3 worldSwingAxis, Limits limits, JointType type)
			{
			}
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x267191C", Offset = "0x267191C", VA = "0x267191C")]
		public static void ClearAll(Transform root)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x2671B30", Offset = "0x2671B30", VA = "0x2671B30")]
		protected static void ClearTransform(Transform transform)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x2671D84", Offset = "0x2671D84", VA = "0x2671D84")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x267216C", Offset = "0x267216C", VA = "0x267216C")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width, float proportionAspect, Vector3 widthDirection)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x2672080", Offset = "0x2672080", VA = "0x2672080")]
		protected static float GetScaleF(Transform t)
		{
			return default(float);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x2672490", Offset = "0x2672490", VA = "0x2672490")]
		protected static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x26724A0", Offset = "0x26724A0", VA = "0x26724A0")]
		protected static void Vector3Abs(ref Vector3 v)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x26724BC", Offset = "0x26724BC", VA = "0x26724BC")]
		protected static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x26724E0", Offset = "0x26724E0", VA = "0x26724E0")]
		protected static Vector3 DirectionToVector3(Direction dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x26720B0", Offset = "0x26720B0", VA = "0x26720B0")]
		protected static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x2672504", Offset = "0x2672504", VA = "0x2672504")]
		protected static Vector3 GetLocalOrthoDirection(Transform transform, Vector3 worldDir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x26726A4", Offset = "0x26726A4", VA = "0x26726A4")]
		protected static Rigidbody GetConnectedBody(Transform bone, ref Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x2672854", Offset = "0x2672854", VA = "0x2672854")]
		protected static void CreateJoint(CreateJointParams p)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x2672DE0", Offset = "0x2672DE0", VA = "0x2672DE0")]
		private static SoftJointLimit ToSoftJointLimit(float limit)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x2672E14", Offset = "0x2672E14", VA = "0x2672E14")]
		protected RagdollCreator()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D1BE4", Offset = "0x9D1BE4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D1BE4", Offset = "0x9D1BE4")]
	public class RagdollEditor : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000097")]
		public enum Mode
		{
			[Token(Token = "0x40003D3")]
			Colliders,
			[Token(Token = "0x40003D4")]
			Joints
		}

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Rigidbody selectedRigidbody;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Collider selectedCollider;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool symmetry;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public Mode mode;

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x2672E1C", Offset = "0x2672E1C", VA = "0x2672E1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D617C", Offset = "0x9D617C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x2672E64", Offset = "0x2672E64", VA = "0x2672E64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D61B4", Offset = "0x9D61B4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x2672EAC", Offset = "0x2672EAC", VA = "0x2672EAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D61EC", Offset = "0x9D61EC")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x2672EF4", Offset = "0x2672EF4", VA = "0x2672EF4")]
		public RagdollEditor()
		{
		}
	}
}
