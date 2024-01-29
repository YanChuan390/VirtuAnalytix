using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class Skeleton : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PuppetMaster puppetMaster;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ConfigurableJoint[] leftLeg;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ConfigurableJoint[] rightLeg;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool leftLegRemoved;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool rightLegRemoved;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1CC4E8C", Offset = "0x1CC4E8C", VA = "0x1CC4E8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1CC4F44", Offset = "0x1CC4F44", VA = "0x1CC4F44")]
	private void OnMuscleRemoved(Muscle m)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1CC500C", Offset = "0x1CC500C", VA = "0x1CC500C")]
	private bool IsLegMuscle(Muscle m, out bool isLeft)
	{
		return default(bool);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1CC5194", Offset = "0x1CC5194", VA = "0x1CC5194")]
	public Skeleton()
	{
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000003")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E1")]
		public enum UpdateMode
		{
			[Token(Token = "0x40006C4")]
			Update,
			[Token(Token = "0x40006C5")]
			FixedUpdate,
			[Token(Token = "0x40006C6")]
			LateUpdate,
			[Token(Token = "0x40006C7")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BA830", Offset = "0x9BA830")]
		public bool smoothFollow;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BA868", Offset = "0x9BA868")]
		public float rotationSensitivity;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BA8A0", Offset = "0x9BA8A0")]
		public float distance;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BA8D8", Offset = "0x9BA8D8")]
		public LayerMask blockingLayers;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BA910", Offset = "0x9BA910")]
		public float blockedOffset;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA928", Offset = "0x9BA928")]
		private float <x>k__BackingField;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA938", Offset = "0x9BA938")]
		private float <y>k__BackingField;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA948", Offset = "0x9BA948")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000001")]
		public float x
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x1252358", Offset = "0x1252358", VA = "0x1252358")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4BF0", Offset = "0x9C4BF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x1252360", Offset = "0x1252360", VA = "0x1252360")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4C00", Offset = "0x9C4C00")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float y
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x1252368", Offset = "0x1252368", VA = "0x1252368")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4C10", Offset = "0x9C4C10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x1252370", Offset = "0x1252370", VA = "0x1252370")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4C20", Offset = "0x9C4C20")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public float distanceTarget
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x1252378", Offset = "0x1252378", VA = "0x1252378")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4C30", Offset = "0x9C4C30")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x1252380", Offset = "0x1252380", VA = "0x1252380")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4C40", Offset = "0x9C4C40")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		private float zoomAdd
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x1252DE8", Offset = "0x1252DE8", VA = "0x1252DE8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1252388", Offset = "0x1252388", VA = "0x1252388", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x12524A4", Offset = "0x12524A4", VA = "0x12524A4", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1252500", Offset = "0x1252500", VA = "0x1252500", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1252568", Offset = "0x1252568", VA = "0x1252568", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x12525CC", Offset = "0x12525CC", VA = "0x12525CC")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x12524D8", Offset = "0x12524D8", VA = "0x12524D8")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x125274C", Offset = "0x125274C", VA = "0x125274C")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1252D38", Offset = "0x1252D38", VA = "0x1252D38")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1252E5C", Offset = "0x1252E5C", VA = "0x1252E5C")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1252F6C", Offset = "0x1252F6C", VA = "0x1252F6C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1252FA4", Offset = "0x1252FA4", VA = "0x1252FA4")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x125315C", Offset = "0x125315C", VA = "0x125315C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x125320C", Offset = "0x125320C", VA = "0x125320C")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000005")]
	public enum Axis
	{
		[Token(Token = "0x4000032")]
		X,
		[Token(Token = "0x4000033")]
		Y,
		[Token(Token = "0x4000034")]
		Z
	}
	[Token(Token = "0x2000006")]
	public class AxisTools
	{
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x124B560", Offset = "0x124B560", VA = "0x124B560")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x124B618", Offset = "0x124B618", VA = "0x124B618")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x124B6C4", Offset = "0x124B6C4", VA = "0x124B6C4")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x124B8A8", Offset = "0x124B8A8", VA = "0x124B8A8")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x124B7E0", Offset = "0x124B7E0", VA = "0x124B7E0")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x124B9C4", Offset = "0x124B9C4", VA = "0x124B9C4")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x124BBF0", Offset = "0x124BBF0", VA = "0x124BBF0")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000007")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x20000E2")]
		public class LimbOrientation
		{
			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x124BEB8", Offset = "0x124BEB8", VA = "0x124BEB8")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000005")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x124BC44", Offset = "0x124BC44", VA = "0x124BC44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x124BF30", Offset = "0x124BF30", VA = "0x124BF30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x124BBF8", Offset = "0x124BBF8", VA = "0x124BBF8")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000008")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x20000E3")]
		public enum BoneType
		{
			[Token(Token = "0x40006CC")]
			Unassigned,
			[Token(Token = "0x40006CD")]
			Spine,
			[Token(Token = "0x40006CE")]
			Head,
			[Token(Token = "0x40006CF")]
			Arm,
			[Token(Token = "0x40006D0")]
			Leg,
			[Token(Token = "0x40006D1")]
			Tail,
			[Token(Token = "0x40006D2")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		public enum BoneSide
		{
			[Token(Token = "0x40006D4")]
			Center,
			[Token(Token = "0x40006D5")]
			Left,
			[Token(Token = "0x40006D6")]
			Right
		}

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x124C1A4", Offset = "0x124C1A4", VA = "0x124C1A4")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x124C4A4", Offset = "0x124C4A4", VA = "0x124C4A4")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x124C6F4", Offset = "0x124C6F4", VA = "0x124C6F4")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x124C778", Offset = "0x124C778", VA = "0x124C778")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x124C824", Offset = "0x124C824", VA = "0x124C824")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x124C354", Offset = "0x124C354", VA = "0x124C354")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x124C654", Offset = "0x124C654", VA = "0x124C654")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x124D064", Offset = "0x124D064", VA = "0x124D064")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x124CE7C", Offset = "0x124CE7C", VA = "0x124CE7C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x124CF70", Offset = "0x124CF70", VA = "0x124CF70")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x124CA44", Offset = "0x124CA44", VA = "0x124CA44")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x124CAF8", Offset = "0x124CAF8", VA = "0x124CAF8")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x124CBAC", Offset = "0x124CBAC", VA = "0x124CBAC")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x124CC60", Offset = "0x124CC60", VA = "0x124CC60")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x124CD14", Offset = "0x124CD14", VA = "0x124CD14")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x124CDC8", Offset = "0x124CDC8", VA = "0x124CDC8")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x124D278", Offset = "0x124D278", VA = "0x124D278")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x124C958", Offset = "0x124C958", VA = "0x124C958")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x124D1E8", Offset = "0x124D1E8", VA = "0x124D1E8")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x124D2E8", Offset = "0x124D2E8", VA = "0x124D2E8")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x124D3C0", Offset = "0x124D3C0", VA = "0x124D3C0")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x124D16C", Offset = "0x124D16C", VA = "0x124D16C")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x124D0F4", Offset = "0x124D0F4", VA = "0x124D0F4")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000009")]
	public class BipedReferences
	{
		[Token(Token = "0x20000E5")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x170000A6")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000796")]
				[Address(RVA = "0x1252350", Offset = "0x1252350", VA = "0x1252350")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0x125233C", Offset = "0x125233C", VA = "0x125233C")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000007")]
		public virtual bool isFilled
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x124EF34", Offset = "0x124EF34", VA = "0x124EF34", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public bool isEmpty
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x124F320", Offset = "0x124F320", VA = "0x124F320")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x124F330", Offset = "0x124F330", VA = "0x124F330", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x124F75C", Offset = "0x124F75C", VA = "0x124F75C", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x124FB94", Offset = "0x124FB94", VA = "0x124FB94")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x12501A4", Offset = "0x12501A4", VA = "0x12501A4")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x124FDE0", Offset = "0x124FDE0", VA = "0x124FDE0")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1250954", Offset = "0x1250954", VA = "0x1250954")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1250A48", Offset = "0x1250A48", VA = "0x1250A48")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1250FA0", Offset = "0x1250FA0", VA = "0x1250FA0")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1250DA4", Offset = "0x1250DA4", VA = "0x1250DA4")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1250C1C", Offset = "0x1250C1C", VA = "0x1250C1C")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1250AE8", Offset = "0x1250AE8", VA = "0x1250AE8")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1250EA8", Offset = "0x1250EA8", VA = "0x1250EA8")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x125109C", Offset = "0x125109C", VA = "0x125109C")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1251B3C", Offset = "0x1251B3C", VA = "0x1251B3C")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1251620", Offset = "0x1251620", VA = "0x1251620")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1251E30", Offset = "0x1251E30", VA = "0x1251E30")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1251960", Offset = "0x1251960", VA = "0x1251960")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1251E38", Offset = "0x1251E38", VA = "0x1251E38")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1251E40", Offset = "0x1251E40", VA = "0x1251E40")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1252000", Offset = "0x1252000", VA = "0x1252000")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1252218", Offset = "0x1252218", VA = "0x1252218")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x124FD70", Offset = "0x124FD70", VA = "0x124FD70")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1253228", Offset = "0x1253228", VA = "0x1253228")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1253230", Offset = "0x1253230", VA = "0x1253230")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1253370", Offset = "0x1253370", VA = "0x1253370")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class Hierarchy
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1CC03FC", Offset = "0x1CC03FC", VA = "0x1CC03FC")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1CC05FC", Offset = "0x1CC05FC", VA = "0x1CC05FC")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1CC0494", Offset = "0x1CC0494", VA = "0x1CC0494")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1CC0720", Offset = "0x1CC0720", VA = "0x1CC0720")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1CC0844", Offset = "0x1CC0844", VA = "0x1CC0844")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1CC0AEC", Offset = "0x1CC0AEC", VA = "0x1CC0AEC")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1CC0C08", Offset = "0x1CC0C08", VA = "0x1CC0C08")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1CC0D90", Offset = "0x1CC0D90", VA = "0x1CC0D90")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1CC1124", Offset = "0x1CC1124", VA = "0x1CC1124")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1CC0F10", Offset = "0x1CC0F10", VA = "0x1CC0F10")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1CC12C4", Offset = "0x1CC12C4", VA = "0x1CC12C4")]
		public Hierarchy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public enum InterpolationMode
	{
		[Token(Token = "0x4000060")]
		None,
		[Token(Token = "0x4000061")]
		InOutCubic,
		[Token(Token = "0x4000062")]
		InOutQuintic,
		[Token(Token = "0x4000063")]
		InOutSine,
		[Token(Token = "0x4000064")]
		InQuintic,
		[Token(Token = "0x4000065")]
		InQuartic,
		[Token(Token = "0x4000066")]
		InCubic,
		[Token(Token = "0x4000067")]
		InQuadratic,
		[Token(Token = "0x4000068")]
		InElastic,
		[Token(Token = "0x4000069")]
		InElasticSmall,
		[Token(Token = "0x400006A")]
		InElasticBig,
		[Token(Token = "0x400006B")]
		InSine,
		[Token(Token = "0x400006C")]
		InBack,
		[Token(Token = "0x400006D")]
		OutQuintic,
		[Token(Token = "0x400006E")]
		OutQuartic,
		[Token(Token = "0x400006F")]
		OutCubic,
		[Token(Token = "0x4000070")]
		OutInCubic,
		[Token(Token = "0x4000071")]
		OutInQuartic,
		[Token(Token = "0x4000072")]
		OutElastic,
		[Token(Token = "0x4000073")]
		OutElasticSmall,
		[Token(Token = "0x4000074")]
		OutElasticBig,
		[Token(Token = "0x4000075")]
		OutSine,
		[Token(Token = "0x4000076")]
		OutBack,
		[Token(Token = "0x4000077")]
		OutBackCubic,
		[Token(Token = "0x4000078")]
		OutBackQuartic,
		[Token(Token = "0x4000079")]
		BackInCubic,
		[Token(Token = "0x400007A")]
		BackInQuartic
	}
	[Token(Token = "0x200000E")]
	public class Interp
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1CC12CC", Offset = "0x1CC12CC", VA = "0x1CC12CC")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1CC1D34", Offset = "0x1CC1D34", VA = "0x1CC1D34")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1CC1E3C", Offset = "0x1CC1E3C", VA = "0x1CC1E3C")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1CC1638", Offset = "0x1CC1638", VA = "0x1CC1638")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1CC1644", Offset = "0x1CC1644", VA = "0x1CC1644")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1CC1668", Offset = "0x1CC1668", VA = "0x1CC1668")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1CC16A4", Offset = "0x1CC16A4", VA = "0x1CC16A4")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1CC16BC", Offset = "0x1CC16BC", VA = "0x1CC16BC")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1CC16D0", Offset = "0x1CC16D0", VA = "0x1CC16D0")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1CC16E4", Offset = "0x1CC16E4", VA = "0x1CC16E4")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1CC16F4", Offset = "0x1CC16F4", VA = "0x1CC16F4")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1CC173C", Offset = "0x1CC173C", VA = "0x1CC173C")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1CC1774", Offset = "0x1CC1774", VA = "0x1CC1774")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1CC179C", Offset = "0x1CC179C", VA = "0x1CC179C")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1CC1F38", Offset = "0x1CC1F38", VA = "0x1CC1F38")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1CC17D0", Offset = "0x1CC17D0", VA = "0x1CC17D0")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1CC17F8", Offset = "0x1CC17F8", VA = "0x1CC17F8")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1CC1828", Offset = "0x1CC1828", VA = "0x1CC1828")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1CC185C", Offset = "0x1CC185C", VA = "0x1CC185C")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1CC18A0", Offset = "0x1CC18A0", VA = "0x1CC18A0")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1CC1904", Offset = "0x1CC1904", VA = "0x1CC1904")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1CC1968", Offset = "0x1CC1968", VA = "0x1CC1968")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1CC19BC", Offset = "0x1CC19BC", VA = "0x1CC19BC")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1CC1A10", Offset = "0x1CC1A10", VA = "0x1CC1A10")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1CC1AA8", Offset = "0x1CC1AA8", VA = "0x1CC1AA8")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1CC1B3C", Offset = "0x1CC1B3C", VA = "0x1CC1B3C")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1CC1F6C", Offset = "0x1CC1F6C", VA = "0x1CC1F6C")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1CC1BE0", Offset = "0x1CC1BE0", VA = "0x1CC1BE0")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1CC1CC4", Offset = "0x1CC1CC4", VA = "0x1CC1CC4")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1CC1CF4", Offset = "0x1CC1CF4", VA = "0x1CC1CF4")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1CC2054", Offset = "0x1CC2054", VA = "0x1CC2054")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1CC205C", Offset = "0x1CC205C", VA = "0x1CC205C")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1CC20CC", Offset = "0x1CC20CC", VA = "0x1CC20CC")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000010")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1CC213C", Offset = "0x1CC213C", VA = "0x1CC213C")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1CC2194", Offset = "0x1CC2194", VA = "0x1CC2194")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1CC2260", Offset = "0x1CC2260", VA = "0x1CC2260")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1CC21AC", Offset = "0x1CC21AC", VA = "0x1CC21AC")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1CC2278", Offset = "0x1CC2278", VA = "0x1CC2278")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1CC231C", Offset = "0x1CC231C", VA = "0x1CC231C")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1CC2348", Offset = "0x1CC2348", VA = "0x1CC2348")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1CC2398", Offset = "0x1CC2398", VA = "0x1CC2398")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1CC2404", Offset = "0x1CC2404", VA = "0x1CC2404")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1CC24F8", Offset = "0x1CC24F8", VA = "0x1CC24F8")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1CC25D0", Offset = "0x1CC25D0", VA = "0x1CC25D0")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1CC2630", Offset = "0x1CC2630", VA = "0x1CC2630")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000011")]
	public static class QuaTools
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1CC2660", Offset = "0x1CC2660", VA = "0x1CC2660")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1CC27AC", Offset = "0x1CC27AC", VA = "0x1CC27AC")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1CC28F8", Offset = "0x1CC28F8", VA = "0x1CC28F8")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1CC2A0C", Offset = "0x1CC2A0C", VA = "0x1CC2A0C")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1CC2B20", Offset = "0x1CC2B20", VA = "0x1CC2B20")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1CC2CAC", Offset = "0x1CC2CAC", VA = "0x1CC2CAC")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1CC2D7C", Offset = "0x1CC2D7C", VA = "0x1CC2D7C")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1CC2ED0", Offset = "0x1CC2ED0", VA = "0x1CC2ED0")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1CC3154", Offset = "0x1CC3154", VA = "0x1CC3154")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1CC3368", Offset = "0x1CC3368", VA = "0x1CC3368")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1CBF2E4", Offset = "0x1CBF2E4", VA = "0x1CBF2E4")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000012")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000009")]
		public static T instance
		{
			[Token(Token = "0x6000099")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009A")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600009B")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA968", Offset = "0x9BA968")]
		public bool fixTransforms;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000A")]
		private bool animatePhysics
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x1CC3620", Offset = "0x1CC3620", VA = "0x1CC3620")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool isAnimated
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x1CC391C", Offset = "0x1CC391C", VA = "0x1CC391C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1CC34E8", Offset = "0x1CC34E8", VA = "0x1CC34E8")]
		public void Disable()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1CC3580", Offset = "0x1CC3580", VA = "0x1CC3580", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1CC3584", Offset = "0x1CC3584", VA = "0x1CC3584", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1CC3588", Offset = "0x1CC3588", VA = "0x1CC3588", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1CC358C", Offset = "0x1CC358C", VA = "0x1CC358C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1CC361C", Offset = "0x1CC361C", VA = "0x1CC361C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1CC35C4", Offset = "0x1CC35C4", VA = "0x1CC35C4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1CC38D0", Offset = "0x1CC38D0", VA = "0x1CC38D0")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1CC3710", Offset = "0x1CC3710", VA = "0x1CC3710")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1CC39D8", Offset = "0x1CC39D8", VA = "0x1CC39D8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1CC3A34", Offset = "0x1CC3A34", VA = "0x1CC3A34")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1CC3A90", Offset = "0x1CC3A90", VA = "0x1CC3A90")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1CC3AD8", Offset = "0x1CC3AD8", VA = "0x1CC3AD8")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1CC3AE8", Offset = "0x1CC3AE8", VA = "0x1CC3AE8")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1CC3BA0", Offset = "0x1CC3BA0", VA = "0x1CC3BA0")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1CC3C58", Offset = "0x1CC3C58", VA = "0x1CC3C58")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1CC3D10", Offset = "0x1CC3D10", VA = "0x1CC3D10")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public static class V3Tools
	{
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1CC3D18", Offset = "0x1CC3D18", VA = "0x1CC3D18")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1CC3E10", Offset = "0x1CC3E10", VA = "0x1CC3E10")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1CC3F08", Offset = "0x1CC3F08", VA = "0x1CC3F08")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1CC4000", Offset = "0x1CC4000", VA = "0x1CC4000")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1CC4100", Offset = "0x1CC4100", VA = "0x1CC4100")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1CC433C", Offset = "0x1CC433C", VA = "0x1CC433C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1CC458C", Offset = "0x1CC458C", VA = "0x1CC458C")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1CC478C", Offset = "0x1CC478C", VA = "0x1CC478C")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000016")]
	public static class Warning
	{
		[Token(Token = "0x20000E6")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1CC4968", Offset = "0x1CC4968", VA = "0x1CC4968")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1CC4D94", Offset = "0x1CC4D94", VA = "0x1CC4D94")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Dynamics
{
	[Token(Token = "0x2000017")]
	public class AnimationBlocker : MonoBehaviour
	{
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x11E27A0", Offset = "0x11E27A0", VA = "0x11E27A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x11E2878", Offset = "0x11E2878", VA = "0x11E2878")]
		public AnimationBlocker()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B9388", Offset = "0x9B9388")]
	public class BehaviourAnimatedStagger : BehaviourBase
	{
		[Serializable]
		[Token(Token = "0x20000E7")]
		public struct FallParams
		{
			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float startPinWeightMlp;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float startMuscleWeightMlp;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float losePinSpeed;
		}

		[Serializable]
		[Token(Token = "0x20000E8")]
		public struct FallParamsGroup
		{
			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Muscle.Group[] groups;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FallParams fallParams;
		}

		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA710", Offset = "0x9BA710")]
		private sealed class <LoseBalance>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BehaviourAnimatedStagger <>4__this;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool <done>5__2;

			[Token(Token = "0x170000A7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600079E")]
				[Address(RVA = "0x11E3494", Offset = "0x11E3494", VA = "0x11E3494", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007A0")]
				[Address(RVA = "0x11E34FC", Offset = "0x11E34FC", VA = "0x11E34FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x11E2944", Offset = "0x11E2944", VA = "0x11E2944")]
			[DebuggerHidden]
			public <LoseBalance>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x11E2A70", Offset = "0x11E2A70", VA = "0x11E2A70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0x11E2A74", Offset = "0x11E2A74", VA = "0x11E2A74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0x11E349C", Offset = "0x11E349C", VA = "0x11E349C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BA9A0", Offset = "0x9BA9A0")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public float animationBlendSpeed;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public float animationMag;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public float momentumMag;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public float unbalancedMuscleWeightMlp;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float unbalancedMuscleDamperAdd;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public bool dropProps;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public float maxGetUpVelocity;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public float minHipHeight;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public SubBehaviourCOM centerOfMass;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BA9D8", Offset = "0x9BA9D8")]
		public FallParams defaults;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public FallParamsGroup[] groupOverrides;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BAA10", Offset = "0x9BAA10")]
		public PuppetEvent onUngrounded;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public PuppetEvent onFallOver;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public PuppetEvent onRest;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[HideInInspector]
		public Vector3 moveVector;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		[HideInInspector]
		public bool isGrounded;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[HideInInspector]
		public Vector3 forward;

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x11E2880", Offset = "0x11E2880", VA = "0x11E2880", Slot = "15")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x11E28A4", Offset = "0x11E28A4", VA = "0x11E28A4", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x11E2940", Offset = "0x11E2940", VA = "0x11E2940", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x11E28D0", Offset = "0x11E28D0", VA = "0x11E28D0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C4CC0", Offset = "0x9C4CC0")]
		private IEnumerator LoseBalance()
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x11E2970", Offset = "0x11E2970", VA = "0x11E2970")]
		private FallParams GetFallParams(Muscle.Group group)
		{
			return default(FallParams);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x11E2A34", Offset = "0x11E2A34", VA = "0x11E2A34")]
		public BehaviourAnimatedStagger()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public abstract class BehaviourBase : MonoBehaviour
	{
		[Token(Token = "0x20000EA")]
		public delegate void BehaviourDelegate();

		[Token(Token = "0x20000EB")]
		public delegate void HitDelegate(MuscleHit hit);

		[Token(Token = "0x20000EC")]
		public delegate void CollisionDelegate(MuscleCollision collision);

		[Serializable]
		[Token(Token = "0x20000ED")]
		public struct PuppetEvent
		{
			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1184", Offset = "0x9C1184")]
			public string switchToBehaviour;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C11BC", Offset = "0x9C11BC")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C11F4", Offset = "0x9C11F4")]
			public UnityEvent unityEvent;

			[Token(Token = "0x40006E5")]
			private const string empty = "";

			[Token(Token = "0x170000A9")]
			public bool switchBehaviour
			{
				[Token(Token = "0x60007AD")]
				[Address(RVA = "0x11E340C", Offset = "0x11E340C", VA = "0x11E340C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x11E31D0", Offset = "0x11E31D0", VA = "0x11E31D0")]
			public void Trigger(PuppetMaster puppetMaster, bool switchBehaviourEnabled = true)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EE")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string animationState;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float crossfadeTime;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int layer;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40006EA")]
			private const string empty = "";

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x11E49FC", Offset = "0x11E49FC", VA = "0x11E49FC")]
			public void Activate(Animator animator, Animation animation)
			{
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x11E4AD0", Offset = "0x11E4AD0", VA = "0x11E4AD0")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x11E4BD4", Offset = "0x11E4BD4", VA = "0x11E4BD4")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x11E4CB4", Offset = "0x11E4CB4", VA = "0x11E4CB4")]
			public AnimatorEvent()
			{
			}
		}

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BehaviourDelegate OnPreActivate;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BehaviourDelegate OnPreInitiate;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BehaviourDelegate OnPreFixedUpdate;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BehaviourDelegate OnPreUpdate;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BehaviourDelegate OnPreLateUpdate;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BehaviourDelegate OnPreDeactivate;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public BehaviourDelegate OnPreFixTransforms;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public BehaviourDelegate OnPreRead;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public BehaviourDelegate OnPreWrite;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public HitDelegate OnPreMuscleHit;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public CollisionDelegate OnPreMuscleCollision;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CollisionDelegate OnPreMuscleCollisionExit;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public BehaviourDelegate OnHierarchyChanged;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public BehaviourDelegate OnPostActivate;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public BehaviourDelegate OnPostInitiate;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public BehaviourDelegate OnPostFixedUpdate;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public BehaviourDelegate OnPostUpdate;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public BehaviourDelegate OnPostLateUpdate;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public BehaviourDelegate OnPostDeactivate;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public BehaviourDelegate OnPostDrawGizmos;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public BehaviourDelegate OnPostFixTransforms;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public BehaviourDelegate OnPostRead;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public BehaviourDelegate OnPostWrite;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public HitDelegate OnPostMuscleHit;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public CollisionDelegate OnPostMuscleCollision;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public CollisionDelegate OnPostMuscleCollisionExit;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		public bool deactivated;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BAA98", Offset = "0x9BAA98")]
		private bool <forceActive>k__BackingField;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		private bool initiated;

		[Token(Token = "0x1700000C")]
		public bool forceActive
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x11E377C", Offset = "0x11E377C", VA = "0x11E377C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4D24", Offset = "0x9C4D24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x11E3784", Offset = "0x11E3784", VA = "0x11E3784")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4D34", Offset = "0x9C4D34")]
			protected set
			{
			}
		}

		[Token(Token = "0x60000C2")]
		public abstract void OnReactivate();

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x11E3504", Offset = "0x11E3504", VA = "0x11E3504", Slot = "5")]
		public virtual void Resurrect()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x11E3508", Offset = "0x11E3508", VA = "0x11E3508", Slot = "6")]
		public virtual void Freeze()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x11E350C", Offset = "0x11E350C", VA = "0x11E350C", Slot = "7")]
		public virtual void Unfreeze()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x11E3510", Offset = "0x11E3510", VA = "0x11E3510", Slot = "8")]
		public virtual void KillStart()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x11E3514", Offset = "0x11E3514", VA = "0x11E3514", Slot = "9")]
		public virtual void KillEnd()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x11E3518", Offset = "0x11E3518", VA = "0x11E3518", Slot = "10")]
		public virtual void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x11E351C", Offset = "0x11E351C", VA = "0x11E351C", Slot = "11")]
		public virtual void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x11E3738", Offset = "0x11E3738", VA = "0x11E3738", Slot = "12")]
		public virtual void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x11E3748", Offset = "0x11E3748", VA = "0x11E3748", Slot = "13")]
		protected virtual void OnActivate()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x11E374C", Offset = "0x11E374C", VA = "0x11E374C", Slot = "14")]
		protected virtual void OnDeactivate()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x11E3750", Offset = "0x11E3750", VA = "0x11E3750", Slot = "15")]
		protected virtual void OnInitiate()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x11E3754", Offset = "0x11E3754", VA = "0x11E3754", Slot = "16")]
		protected virtual void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x11E3758", Offset = "0x11E3758", VA = "0x11E3758", Slot = "17")]
		protected virtual void OnUpdate()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x11E375C", Offset = "0x11E375C", VA = "0x11E375C", Slot = "18")]
		protected virtual void OnLateUpdate()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x11E3760", Offset = "0x11E3760", VA = "0x11E3760", Slot = "19")]
		protected virtual void OnDrawGizmosBehaviour()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x11E3764", Offset = "0x11E3764", VA = "0x11E3764", Slot = "20")]
		protected virtual void OnFixTransformsBehaviour()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x11E3768", Offset = "0x11E3768", VA = "0x11E3768", Slot = "21")]
		protected virtual void OnReadBehaviour()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x11E376C", Offset = "0x11E376C", VA = "0x11E376C", Slot = "22")]
		protected virtual void OnWriteBehaviour()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x11E3770", Offset = "0x11E3770", VA = "0x11E3770", Slot = "23")]
		protected virtual void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x11E3774", Offset = "0x11E3774", VA = "0x11E3774", Slot = "24")]
		protected virtual void OnMuscleCollisionBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x11E3778", Offset = "0x11E3778", VA = "0x11E3778", Slot = "25")]
		protected virtual void OnMuscleCollisionExitBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x11E3790", Offset = "0x11E3790", VA = "0x11E3790")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x11E37E8", Offset = "0x11E37E8", VA = "0x11E37E8")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x11E384C", Offset = "0x11E384C", VA = "0x11E384C")]
		public void OnRead()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x11E38B0", Offset = "0x11E38B0", VA = "0x11E38B0")]
		public void OnWrite()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x11E3914", Offset = "0x11E3914", VA = "0x11E3914")]
		public void OnMuscleHit(MuscleHit hit)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x11E3C64", Offset = "0x11E3C64", VA = "0x11E3C64")]
		public void OnMuscleCollision(MuscleCollision collision)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x11E4028", Offset = "0x11E4028", VA = "0x11E4028")]
		public void OnMuscleCollisionExit(MuscleCollision collision)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x11E40D0", Offset = "0x11E40D0", VA = "0x11E40D0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x11E40E0", Offset = "0x11E40E0", VA = "0x11E40E0")]
		public void Activate()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x11E4200", Offset = "0x11E4200", VA = "0x11E4200")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x11E4250", Offset = "0x11E4250", VA = "0x11E4250")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x11E42F4", Offset = "0x11E42F4", VA = "0x11E42F4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x11E4398", Offset = "0x11E4398", VA = "0x11E4398")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x11E443C", Offset = "0x11E443C", VA = "0x11E443C", Slot = "26")]
		protected virtual void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x11E447C", Offset = "0x11E447C", VA = "0x11E447C")]
		protected void RotateTargetToRootMuscle()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x11E4614", Offset = "0x11E4614", VA = "0x11E4614")]
		protected void TranslateTargetToRootMuscle(float maintainY)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x11E3124", Offset = "0x11E3124", VA = "0x11E3124")]
		protected void RemoveMusclesOfGroup(Muscle.Group group)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x11E483C", Offset = "0x11E483C", VA = "0x11E483C", Slot = "27")]
		protected virtual void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x11E47BC", Offset = "0x11E47BC", VA = "0x11E47BC")]
		protected bool MusclesContainsGroup(Muscle.Group group)
		{
			return default(bool);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x11E2A68", Offset = "0x11E2A68", VA = "0x11E2A68")]
		protected BehaviourBase()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B93C0", Offset = "0x9B93C0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B93C0", Offset = "0x9B93C0")]
	public class BehaviourFall : BehaviourBase
	{
		[Token(Token = "0x20000EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA720", Offset = "0x9BA720")]
		private sealed class <SmoothActivate>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BehaviourFall <>4__this;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <fader>5__2;

			[Token(Token = "0x170000AA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007B6")]
				[Address(RVA = "0x11E59C0", Offset = "0x11E59C0", VA = "0x11E59C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007B8")]
				[Address(RVA = "0x11E5A28", Offset = "0x11E5A28", VA = "0x11E5A28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x11E4FCC", Offset = "0x11E4FCC", VA = "0x11E4FCC")]
			[DebuggerHidden]
			public <SmoothActivate>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x11E57E4", Offset = "0x11E57E4", VA = "0x11E57E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x11E57E8", Offset = "0x11E57E8", VA = "0x11E57E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x11E59C8", Offset = "0x11E59C8", VA = "0x11E59C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BAAA8", Offset = "0x9BAAA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAAA8", Offset = "0x9BAAA8")]
		public string stateName;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAB08", Offset = "0x9BAB08")]
		public float transitionDuration;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAB40", Offset = "0x9BAB40")]
		public int layer;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAB78", Offset = "0x9BAB78")]
		public float fixedTime;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BABB0", Offset = "0x9BABB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BABB0", Offset = "0x9BABB0")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAC10", Offset = "0x9BAC10")]
		public string blendParameter;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAC48", Offset = "0x9BAC48")]
		public float writheHeight;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAC80", Offset = "0x9BAC80")]
		public float writheYVelocity;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BACB8", Offset = "0x9BACB8")]
		public float blendSpeed;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BACF0", Offset = "0x9BACF0")]
		public float blendMappingSpeed;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BAD28", Offset = "0x9BAD28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAD28", Offset = "0x9BAD28")]
		public bool canEnd;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAD88", Offset = "0x9BAD88")]
		public float minTime;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BADC0", Offset = "0x9BADC0")]
		public float maxEndVelocity;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BADF8", Offset = "0x9BADF8")]
		public PuppetEvent onEnd;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private float timer;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private bool endTriggered;

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x11E4E70", Offset = "0x11E4E70", VA = "0x11E4E70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C4D44", Offset = "0x9C4D44")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x11E4EBC", Offset = "0x11E4EBC", VA = "0x11E4EBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C4D7C", Offset = "0x9C4D7C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x11E4F08", Offset = "0x11E4F08", VA = "0x11E4F08", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x11E4FB8", Offset = "0x11E4FB8", VA = "0x11E4FB8", Slot = "14")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x11E4FC0", Offset = "0x11E4FC0", VA = "0x11E4FC0", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x11E4F48", Offset = "0x11E4F48", VA = "0x11E4F48")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C4DB4", Offset = "0x9C4DB4")]
		private IEnumerator SmoothActivate()
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x11E4FF8", Offset = "0x11E4FF8", VA = "0x11E4FF8", Slot = "16")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x11E5548", Offset = "0x11E5548", VA = "0x11E5548", Slot = "18")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x11E56E8", Offset = "0x11E56E8", VA = "0x11E56E8", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x11E5394", Offset = "0x11E5394", VA = "0x11E5394")]
		private float GetBlendTarget(float groundHeight)
		{
			return default(float);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x11E521C", Offset = "0x11E521C", VA = "0x11E521C")]
		private float GetGroundHeight()
		{
			return default(float);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x11E5750", Offset = "0x11E5750", VA = "0x11E5750")]
		public BehaviourFall()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B9420", Offset = "0x9B9420")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B9420", Offset = "0x9B9420")]
	public class BehaviourPuppet : BehaviourBase
	{
		[Serializable]
		[Token(Token = "0x20000F0")]
		public enum State
		{
			[Token(Token = "0x40006F0")]
			Puppet,
			[Token(Token = "0x40006F1")]
			Unpinned,
			[Token(Token = "0x40006F2")]
			GetUp
		}

		[Serializable]
		[Token(Token = "0x20000F1")]
		public enum NormalMode
		{
			[Token(Token = "0x40006F4")]
			Active,
			[Token(Token = "0x40006F5")]
			Unmapped,
			[Token(Token = "0x40006F6")]
			Kinematic
		}

		[Serializable]
		[Token(Token = "0x20000F2")]
		public class MasterProps
		{
			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NormalMode normalMode;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float mappingBlendSpeed;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool activateOnStaticCollisions;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float activateOnImpulse;

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x11E9144", Offset = "0x11E9144", VA = "0x11E9144")]
			public MasterProps()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F3")]
		public struct MuscleProps
		{
			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C122C", Offset = "0x9C122C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C122C", Offset = "0x9C122C")]
			public float unpinParents;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1280", Offset = "0x9C1280")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C1280", Offset = "0x9C1280")]
			public float unpinChildren;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C12D4", Offset = "0x9C12D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C12D4", Offset = "0x9C12D4")]
			public float unpinGroup;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1328", Offset = "0x9C1328")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C1328", Offset = "0x9C1328")]
			public float minMappingWeight;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C137C", Offset = "0x9C137C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C137C", Offset = "0x9C137C")]
			public float maxMappingWeight;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C13D0", Offset = "0x9C13D0")]
			public bool disableColliders;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1408", Offset = "0x9C1408")]
			public float regainPinSpeed;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1440", Offset = "0x9C1440")]
			public float collisionResistance;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1478", Offset = "0x9C1478")]
			public float knockOutDistance;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C14B0", Offset = "0x9C14B0")]
			public PhysicMaterial puppetMaterial;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C14E8", Offset = "0x9C14E8")]
			public PhysicMaterial unpinnedMaterial;
		}

		[Serializable]
		[Token(Token = "0x20000F4")]
		public struct MusclePropsGroup
		{
			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1530", Offset = "0x9C1530")]
			public Muscle.Group[] groups;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1568", Offset = "0x9C1568")]
			public MuscleProps props;
		}

		[Serializable]
		[Token(Token = "0x20000F5")]
		public struct CollisionResistanceMultiplier
		{
			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LayerMask layers;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C15A0", Offset = "0x9C15A0")]
			public float multiplier;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C15D8", Offset = "0x9C15D8")]
			public float collisionThreshold;
		}

		[Token(Token = "0x20000F6")]
		public delegate void CollisionImpulseDelegate(MuscleCollision m, float impulse);

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BAE30", Offset = "0x9BAE30")]
		public MasterProps masterProps;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAE68", Offset = "0x9BAE68")]
		public LayerMask groundLayers;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAEA0", Offset = "0x9BAEA0")]
		public LayerMask collisionLayers;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAED8", Offset = "0x9BAED8")]
		public float collisionThreshold;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Weight collisionResistance;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAF10", Offset = "0x9BAF10")]
		public CollisionResistanceMultiplier[] collisionResistanceMultipliers;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAF48", Offset = "0x9BAF48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BAF48", Offset = "0x9BAF48")]
		public int maxCollisions;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAF9C", Offset = "0x9BAF9C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BAF9C", Offset = "0x9BAF9C")]
		public float regainPinSpeed;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAFF4", Offset = "0x9BAFF4")]
		public float boostFalloff;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BB02C", Offset = "0x9BB02C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB02C", Offset = "0x9BB02C")]
		public MuscleProps defaults;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB08C", Offset = "0x9BB08C")]
		public MusclePropsGroup[] groupOverrides;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BB0C4", Offset = "0x9BB0C4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB0C4", Offset = "0x9BB0C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB0C4", Offset = "0x9BB0C4")]
		public float knockOutDistance;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB140", Offset = "0x9BB140")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB140", Offset = "0x9BB140")]
		public float unpinnedMuscleWeightMlp;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB194", Offset = "0x9BB194")]
		public float maxRigidbodyVelocity;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB1CC", Offset = "0x9BB1CC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB1CC", Offset = "0x9BB1CC")]
		public float pinWeightThreshold;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB220", Offset = "0x9BB220")]
		public bool unpinnedMuscleKnockout;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB258", Offset = "0x9BB258")]
		public bool dropProps;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x182")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BB290", Offset = "0x9BB290")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB290", Offset = "0x9BB290")]
		public bool canGetUp;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB2F0", Offset = "0x9BB2F0")]
		public float getUpDelay;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB328", Offset = "0x9BB328")]
		public float blendToAnimationTime;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB360", Offset = "0x9BB360")]
		public float maxGetUpVelocity;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB398", Offset = "0x9BB398")]
		public float minGetUpDuration;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB3D0", Offset = "0x9BB3D0")]
		public float getUpCollisionResistanceMlp;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB408", Offset = "0x9BB408")]
		public float getUpRegainPinSpeedMlp;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB440", Offset = "0x9BB440")]
		public float getUpKnockOutDistanceMlp;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB478", Offset = "0x9BB478")]
		public Vector3 getUpOffsetProne;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB4B0", Offset = "0x9BB4B0")]
		public Vector3 getUpOffsetSupine;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BB4E8", Offset = "0x9BB4E8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB4E8", Offset = "0x9BB4E8")]
		public PuppetEvent onGetUpProne;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB548", Offset = "0x9BB548")]
		public PuppetEvent onGetUpSupine;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB580", Offset = "0x9BB580")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB5B8", Offset = "0x9BB5B8")]
		public PuppetEvent onLoseBalanceFromPuppet;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB5F0", Offset = "0x9BB5F0")]
		public PuppetEvent onLoseBalanceFromGetUp;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB628", Offset = "0x9BB628")]
		public PuppetEvent onRegainBalance;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public CollisionImpulseDelegate OnCollisionImpulse;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BB660", Offset = "0x9BB660")]
		private State <state>k__BackingField;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
		[HideInInspector]
		public bool canMoveTarget;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private float unpinnedTimer;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		private float getUpTimer;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private Vector3 hipsForward;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		private Vector3 hipsUp;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private float getupAnimationBlendWeight;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		private float getupAnimationBlendWeightV;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private bool getUpTargetFixed;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		private NormalMode lastNormalMode;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private int collisions;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		private bool eventsEnabled;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private float lastKnockOutDistance;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
		private float knockOutDistanceSqr;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private bool getupDisabled;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x299")]
		private bool hasCollidedSinceGetUp;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29A")]
		private bool hasBoosted;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private Vector3 getUpPosition;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
		private bool dropPropFlag;

		[Token(Token = "0x1700000D")]
		public State state
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x11E5AC8", Offset = "0x11E5AC8", VA = "0x11E5AC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4E88", Offset = "0x9C4E88")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x11E5AD0", Offset = "0x11E5AD0", VA = "0x11E5AD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4E98", Offset = "0x9C4E98")]
			private set
			{
			}
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x11E5A30", Offset = "0x11E5A30", VA = "0x11E5A30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C4E18", Offset = "0x9C4E18")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x11E5A7C", Offset = "0x11E5A7C", VA = "0x11E5A7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C4E50", Offset = "0x9C4E50")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x11E5AD8", Offset = "0x11E5AD8", VA = "0x11E5AD8", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x11E5D84", Offset = "0x11E5D84", VA = "0x11E5D84")]
		public void Reset(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x11E5DF0", Offset = "0x11E5DF0", VA = "0x11E5DF0", Slot = "10")]
		public override void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x11E5F60", Offset = "0x11E5F60", VA = "0x11E5F60", Slot = "15")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x11E64C8", Offset = "0x11E64C8", VA = "0x11E64C8", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x11E656C", Offset = "0x11E656C", VA = "0x11E656C", Slot = "8")]
		public override void KillStart()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x11E6608", Offset = "0x11E6608", VA = "0x11E6608", Slot = "9")]
		public override void KillEnd()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x11E6610", Offset = "0x11E6610", VA = "0x11E6610", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x11E669C", Offset = "0x11E669C", VA = "0x11E669C", Slot = "14")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x11E66A8", Offset = "0x11E66A8", VA = "0x11E66A8", Slot = "16")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x11E6E7C", Offset = "0x11E6E7C", VA = "0x11E6E7C", Slot = "18")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x11E7194", Offset = "0x11E7194", VA = "0x11E7194")]
		private bool SetKinematic()
		{
			return default(bool);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x11E7274", Offset = "0x11E7274", VA = "0x11E7274", Slot = "21")]
		protected override void OnReadBehaviour()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x11E6FFC", Offset = "0x11E6FFC", VA = "0x11E6FFC")]
		private void BlendMuscleMapping(int muscleIndex, ref bool to)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x11E753C", Offset = "0x11E753C", VA = "0x11E753C", Slot = "11")]
		public override void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x11E757C", Offset = "0x11E757C", VA = "0x11E757C", Slot = "12")]
		public override void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x11E7504", Offset = "0x11E7504", VA = "0x11E7504")]
		protected void MoveTarget(Vector3 position)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x11E75B4", Offset = "0x11E75B4", VA = "0x11E75B4")]
		protected void RotateTarget(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x11E75EC", Offset = "0x11E75EC", VA = "0x11E75EC", Slot = "27")]
		protected override void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x11E7600", Offset = "0x11E7600", VA = "0x11E7600")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x11E77E8", Offset = "0x11E77E8", VA = "0x11E77E8")]
		public void Boost(float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x11E7878", Offset = "0x11E7878", VA = "0x11E7878")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x11E7A60", Offset = "0x11E7A60", VA = "0x11E7A60")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x11E7CA4", Offset = "0x11E7CA4", VA = "0x11E7CA4")]
		public void BoostImmunity(float immunity)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x11E78BC", Offset = "0x11E78BC", VA = "0x11E78BC")]
		public void BoostImmunity(int muscleIndex, float immunity)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x11E7D1C", Offset = "0x11E7D1C", VA = "0x11E7D1C")]
		public void BoostImmunity(int muscleIndex, float immunity, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x11E7DC0", Offset = "0x11E7DC0", VA = "0x11E7DC0")]
		public void BoostImpulseMlp(float impulseMlp)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x11E7990", Offset = "0x11E7990", VA = "0x11E7990")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x11E7E30", Offset = "0x11E7E30", VA = "0x11E7E30")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x11E7ED4", Offset = "0x11E7ED4", VA = "0x11E7ED4")]
		public void Unpin()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x11E7F50", Offset = "0x11E7F50", VA = "0x11E7F50", Slot = "23")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x11E8130", Offset = "0x11E8130", VA = "0x11E8130", Slot = "24")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x11E84B0", Offset = "0x11E84B0", VA = "0x11E84B0")]
		private float GetImpulse(MuscleCollision m, ref float layerThreshold)
		{
			return default(float);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x11E8034", Offset = "0x11E8034", VA = "0x11E8034")]
		private void UnPin(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x11E8B5C", Offset = "0x11E8B5C", VA = "0x11E8B5C")]
		private void UnPinMuscle(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x11E8974", Offset = "0x11E8974", VA = "0x11E8974")]
		private bool Activate(Collision collision, float impulse)
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x11E8D68", Offset = "0x11E8D68", VA = "0x11E8D68")]
		public bool IsProne()
		{
			return default(bool);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x11E7B80", Offset = "0x11E7B80", VA = "0x11E7B80")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren)
		{
			return default(float);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x11E8A0C", Offset = "0x11E8A0C", VA = "0x11E8A0C")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren, float falloffGroup)
		{
			return default(float);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x11E8EE0", Offset = "0x11E8EE0", VA = "0x11E8EE0")]
		private bool InGroup(Muscle.Group group1, Muscle.Group group2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x11E6D94", Offset = "0x11E6D94", VA = "0x11E6D94")]
		private MuscleProps GetProps(Muscle.Group group)
		{
			return default(MuscleProps);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x11DD438", Offset = "0x11DD438", VA = "0x11DD438")]
		public void SetState(State newState)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x11E8FC0", Offset = "0x11E8FC0", VA = "0x11E8FC0")]
		public void SetColliders(bool unpinned)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x11E5BB0", Offset = "0x11E5BB0", VA = "0x11E5BB0")]
		private void SetColliders(Muscle m, bool unpinned)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x11E9050", Offset = "0x11E9050", VA = "0x11E9050")]
		public BehaviourPuppet()
		{
		}
	}
	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B9480", Offset = "0x9B9480")]
	public class BehaviourTemplate : BehaviourBase
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public SubBehaviourCOM centerOfMass;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public LayerMask groundLayers;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float loseBalanceAngle;

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x11E9224", Offset = "0x11E9224", VA = "0x11E9224", Slot = "15")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x11E9248", Offset = "0x11E9248", VA = "0x11E9248", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x11E924C", Offset = "0x11E924C", VA = "0x11E924C", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x11E9250", Offset = "0x11E9250", VA = "0x11E9250", Slot = "14")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x11E9254", Offset = "0x11E9254", VA = "0x11E9254", Slot = "16")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x11E928C", Offset = "0x11E928C", VA = "0x11E928C", Slot = "18")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x11E9290", Offset = "0x11E9290", VA = "0x11E9290", Slot = "23")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x11E9298", Offset = "0x11E9298", VA = "0x11E9298", Slot = "24")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x11E92A0", Offset = "0x11E92A0", VA = "0x11E92A0")]
		public BehaviourTemplate()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001D")]
	public class SubBehaviourBalancer : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x20000F7")]
		public class Settings
		{
			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1610", Offset = "0x9C1610")]
			public float damperForSpring;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1648", Offset = "0x9C1648")]
			public float maxForceMlp;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1680", Offset = "0x9C1680")]
			public float IMlp;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C16B8", Offset = "0x9C16B8")]
			public float velocityF;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C16F0", Offset = "0x9C16F0")]
			public Vector3 copOffset;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1728", Offset = "0x9C1728")]
			public float torqueMlp;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1760", Offset = "0x9C1760")]
			public float maxTorqueMag;

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x1475FDC", Offset = "0x1475FDC", VA = "0x1475FDC")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BB680", Offset = "0x9BB680")]
		private ConfigurableJoint <joint>k__BackingField;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BB690", Offset = "0x9BB690")]
		private Vector3 <dir>k__BackingField;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BB6A0", Offset = "0x9BB6A0")]
		private Vector3 <dirVel>k__BackingField;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BB6B0", Offset = "0x9BB6B0")]
		private Vector3 <cop>k__BackingField;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BB6C0", Offset = "0x9BB6C0")]
		private Vector3 <com>k__BackingField;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BB6D0", Offset = "0x9BB6D0")]
		private Vector3 <comV>k__BackingField;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Settings settings;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody[] rigidbodies;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform[] copPoints;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PressureSensor pressureSensor;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Rigidbody Ibody;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 I;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion toJointSpace;

		[Token(Token = "0x1700000E")]
		public ConfigurableJoint joint
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x14757C8", Offset = "0x14757C8", VA = "0x14757C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4EA8", Offset = "0x9C4EA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x14757D0", Offset = "0x14757D0", VA = "0x14757D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4EB8", Offset = "0x9C4EB8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public Vector3 dir
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x14757D8", Offset = "0x14757D8", VA = "0x14757D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4EC8", Offset = "0x9C4EC8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x14757E4", Offset = "0x14757E4", VA = "0x14757E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4ED8", Offset = "0x9C4ED8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Vector3 dirVel
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x14757F0", Offset = "0x14757F0", VA = "0x14757F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4EE8", Offset = "0x9C4EE8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x14757FC", Offset = "0x14757FC", VA = "0x14757FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4EF8", Offset = "0x9C4EF8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public Vector3 cop
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x1475808", Offset = "0x1475808", VA = "0x1475808")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4F08", Offset = "0x9C4F08")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x1475814", Offset = "0x1475814", VA = "0x1475814")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4F18", Offset = "0x9C4F18")]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public Vector3 com
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x1475820", Offset = "0x1475820", VA = "0x1475820")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4F28", Offset = "0x9C4F28")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x147582C", Offset = "0x147582C", VA = "0x147582C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4F38", Offset = "0x9C4F38")]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public Vector3 comV
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x1475838", Offset = "0x1475838", VA = "0x1475838")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4F48", Offset = "0x9C4F48")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x1475844", Offset = "0x1475844", VA = "0x1475844")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4F58", Offset = "0x9C4F58")]
			private set
			{
			}
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1475850", Offset = "0x1475850", VA = "0x1475850")]
		public void Initiate(BehaviourBase behaviour, Settings settings, Rigidbody Ibody, Rigidbody[] rigidbodies, ConfigurableJoint joint, Transform[] copPoints, PressureSensor pressureSensor)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1475954", Offset = "0x1475954", VA = "0x1475954")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1475F2C", Offset = "0x1475F2C", VA = "0x1475F2C")]
		public SubBehaviourBalancer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001E")]
	public abstract class SubBehaviourBase
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected BehaviourBase behaviour;

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1475FF8", Offset = "0x1475FF8", VA = "0x1475FF8")]
		protected static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1476028", Offset = "0x1476028", VA = "0x1476028")]
		protected static Vector3 XYZ(Vector2 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1476064", Offset = "0x1476064", VA = "0x1476064")]
		protected static Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x147609C", Offset = "0x147609C", VA = "0x147609C")]
		protected static Vector3 SetY(Vector3 v, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1475FD4", Offset = "0x1475FD4", VA = "0x1475FD4")]
		protected SubBehaviourBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001F")]
	public class SubBehaviourCOM : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x20000F8")]
		public enum Mode
		{
			[Token(Token = "0x4000714")]
			FeetCentroid,
			[Token(Token = "0x4000715")]
			CenterOfPressure
		}

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode mode;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float velocityDamper;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float velocityLerpSpeed;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float velocityMax;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centerOfPressureSpeed;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BB6E0", Offset = "0x9BB6E0")]
		private Vector3 <position>k__BackingField;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BB6F0", Offset = "0x9BB6F0")]
		private Vector3 <direction>k__BackingField;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BB700", Offset = "0x9BB700")]
		private float <angle>k__BackingField;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BB710", Offset = "0x9BB710")]
		private Vector3 <velocity>k__BackingField;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BB720", Offset = "0x9BB720")]
		private Vector3 <centerOfPressure>k__BackingField;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BB730", Offset = "0x9BB730")]
		private Quaternion <rotation>k__BackingField;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BB740", Offset = "0x9BB740")]
		private Quaternion <inverseRotation>k__BackingField;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BB750", Offset = "0x9BB750")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BB760", Offset = "0x9BB760")]
		private float <lastGroundedTime>k__BackingField;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public bool[] groundContacts;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector3[] groundContactPoints;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private LayerMask groundLayers;

		[Token(Token = "0x17000014")]
		public Vector3 position
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x14760D4", Offset = "0x14760D4", VA = "0x14760D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4F68", Offset = "0x9C4F68")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x14760E0", Offset = "0x14760E0", VA = "0x14760E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4F78", Offset = "0x9C4F78")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public Vector3 direction
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x14760EC", Offset = "0x14760EC", VA = "0x14760EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4F88", Offset = "0x9C4F88")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x14760F8", Offset = "0x14760F8", VA = "0x14760F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4F98", Offset = "0x9C4F98")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public float angle
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x1476104", Offset = "0x1476104", VA = "0x1476104")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4FA8", Offset = "0x9C4FA8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x147610C", Offset = "0x147610C", VA = "0x147610C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4FB8", Offset = "0x9C4FB8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Vector3 velocity
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x1476114", Offset = "0x1476114", VA = "0x1476114")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4FC8", Offset = "0x9C4FC8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x1476120", Offset = "0x1476120", VA = "0x1476120")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4FD8", Offset = "0x9C4FD8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public Vector3 centerOfPressure
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x147612C", Offset = "0x147612C", VA = "0x147612C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4FE8", Offset = "0x9C4FE8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x1476138", Offset = "0x1476138", VA = "0x1476138")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4FF8", Offset = "0x9C4FF8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public Quaternion rotation
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x1476144", Offset = "0x1476144", VA = "0x1476144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5008", Offset = "0x9C5008")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x1476150", Offset = "0x1476150", VA = "0x1476150")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5018", Offset = "0x9C5018")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public Quaternion inverseRotation
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x147615C", Offset = "0x147615C", VA = "0x147615C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5028", Offset = "0x9C5028")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x1476168", Offset = "0x1476168", VA = "0x1476168")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5038", Offset = "0x9C5038")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool isGrounded
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1476174", Offset = "0x1476174", VA = "0x1476174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5048", Offset = "0x9C5048")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x147617C", Offset = "0x147617C", VA = "0x147617C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5058", Offset = "0x9C5058")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public float lastGroundedTime
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x1476188", Offset = "0x1476188", VA = "0x1476188")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5068", Offset = "0x9C5068")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x1476190", Offset = "0x1476190", VA = "0x1476190")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5078", Offset = "0x9C5078")]
			private set
			{
			}
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1476198", Offset = "0x1476198", VA = "0x1476198")]
		public void Initiate(BehaviourBase behaviour, LayerMask groundLayers)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x147646C", Offset = "0x147646C", VA = "0x147646C")]
		private void OnHierarchyChanged()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x147650C", Offset = "0x147650C", VA = "0x147650C")]
		private void OnPreMuscleCollision(MuscleCollision c)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x14767A4", Offset = "0x14767A4", VA = "0x14767A4")]
		private void OnPreMuscleCollisionExit(MuscleCollision c)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x14768A4", Offset = "0x14768A4", VA = "0x14768A4")]
		private void OnPreActivate()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1476D24", Offset = "0x1476D24", VA = "0x1476D24")]
		private void OnPreLateUpdate()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x14774E0", Offset = "0x14774E0", VA = "0x14774E0")]
		private void OnPreDeactivate()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1476604", Offset = "0x1476604", VA = "0x1476604")]
		private Vector3 GetCollisionCOP(Collision collision)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x14770B8", Offset = "0x14770B8", VA = "0x14770B8")]
		private bool IsGrounded()
		{
			return default(bool);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x14769C0", Offset = "0x14769C0", VA = "0x14769C0")]
		private Vector3 GetCenterOfMass()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x14772A0", Offset = "0x14772A0", VA = "0x14772A0")]
		private Vector3 GetCenterOfMassVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1477550", Offset = "0x1477550", VA = "0x1477550")]
		private Vector3 GetMomentum()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x147711C", Offset = "0x147711C", VA = "0x147711C")]
		private Vector3 GetCenterOfPressure()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1476B90", Offset = "0x1476B90", VA = "0x1476B90")]
		private Vector3 GetFeetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1477708", Offset = "0x1477708", VA = "0x1477708")]
		public SubBehaviourCOM()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000020")]
	public class Booster
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB790", Offset = "0x9BB790")]
		public bool fullBody;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB7C8", Offset = "0x9BB7C8")]
		public ConfigurableJoint[] muscles;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB800", Offset = "0x9BB800")]
		public Muscle.Group[] groups;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB838", Offset = "0x9BB838")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB838", Offset = "0x9BB838")]
		public float immunity;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB88C", Offset = "0x9BB88C")]
		public float impulseMlp;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB8C4", Offset = "0x9BB8C4")]
		public float boostParents;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB8FC", Offset = "0x9BB8FC")]
		public float boostChildren;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB934", Offset = "0x9BB934")]
		public float delay;

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x18F513C", Offset = "0x18F513C", VA = "0x18F513C")]
		public void Boost(BehaviourPuppet puppet)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x18F5354", Offset = "0x18F5354", VA = "0x18F5354")]
		public Booster()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class JointBreakBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		public int muscleIndex;

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x18F543C", Offset = "0x18F543C", VA = "0x18F543C")]
		private void OnJointBreak()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x18F624C", Offset = "0x18F624C", VA = "0x18F624C")]
		public JointBreakBroadcaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000022")]
	public class Muscle
	{
		[Serializable]
		[Token(Token = "0x20000F9")]
		public enum Group
		{
			[Token(Token = "0x4000717")]
			Hips,
			[Token(Token = "0x4000718")]
			Spine,
			[Token(Token = "0x4000719")]
			Head,
			[Token(Token = "0x400071A")]
			Arm,
			[Token(Token = "0x400071B")]
			Hand,
			[Token(Token = "0x400071C")]
			Leg,
			[Token(Token = "0x400071D")]
			Foot,
			[Token(Token = "0x400071E")]
			Tail,
			[Token(Token = "0x400071F")]
			Prop
		}

		[Serializable]
		[Token(Token = "0x20000FA")]
		public class Props
		{
			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1798", Offset = "0x9C1798")]
			public Group group;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C17D0", Offset = "0x9C17D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C17D0", Offset = "0x9C17D0")]
			public float mappingWeight;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1824", Offset = "0x9C1824")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C1824", Offset = "0x9C1824")]
			public float pinWeight;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1878", Offset = "0x9C1878")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C1878", Offset = "0x9C1878")]
			public float muscleWeight;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C18CC", Offset = "0x9C18CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C18CC", Offset = "0x9C18CC")]
			public float muscleDamper;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1920", Offset = "0x9C1920")]
			public bool mapPosition;

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x18FA8A8", Offset = "0x18FA8A8", VA = "0x18FA8A8")]
			public Props()
			{
			}

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x18FA8E8", Offset = "0x18FA8E8", VA = "0x18FA8E8")]
			public Props(float pinWeight, float muscleWeight, float mappingWeight, float muscleDamper, bool mapPosition, Group group = Group.Hips)
			{
			}

			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x18F9A38", Offset = "0x18F9A38", VA = "0x18F9A38")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x20000FB")]
		public struct State
		{
			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float mappingWeightMlp;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float pinWeightMlp;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float muscleWeightMlp;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float maxForceMlp;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float muscleDamperMlp;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float muscleDamperAdd;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float immunity;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float impulseMlp;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 velocity;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 angularVelocity;

			[Token(Token = "0x170000AC")]
			public static State Default
			{
				[Token(Token = "0x60007C2")]
				[Address(RVA = "0x18F80F4", Offset = "0x18F80F4", VA = "0x18F80F4")]
				get
				{
					return default(State);
				}
			}

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x18F9B14", Offset = "0x18F9B14", VA = "0x18F9B14")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public string name;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ConfigurableJoint joint;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform target;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Props props;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public State state;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public int[] parentIndexes;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public int[] childIndexes;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public bool[] childFlags;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public int[] kinshipDegrees;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[HideInInspector]
		public MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public JointBreakBroadcaster jointBreakBroadcaster;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 positionOffset;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BBA5C", Offset = "0x9BBA5C")]
		private Transform <transform>k__BackingField;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BBA6C", Offset = "0x9BBA6C")]
		private Rigidbody <rigidbody>k__BackingField;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BBA7C", Offset = "0x9BBA7C")]
		private Transform <connectedBodyTarget>k__BackingField;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BBA8C", Offset = "0x9BBA8C")]
		private Vector3 <targetAnimatedPosition>k__BackingField;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BBA9C", Offset = "0x9BBA9C")]
		private Vector3 <targetVelocity>k__BackingField;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BBAAC", Offset = "0x9BBAAC")]
		private Vector3 <targetAngularVelocity>k__BackingField;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BBABC", Offset = "0x9BBABC")]
		private Vector3 <mappedVelocity>k__BackingField;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BBACC", Offset = "0x9BBACC")]
		private Vector3 <mappedAngularVelocity>k__BackingField;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BBADC", Offset = "0x9BBADC")]
		private Quaternion <targetRotationRelative>k__BackingField;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private JointDrive slerpDrive;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float lastJointDriveRotationWeight;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private float lastRotationDamper;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Vector3 defaultTargetLocalPosition;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Vector3 lastMappedPosition;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Quaternion localRotationConvert;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Quaternion toParentSpace;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private Quaternion toJointSpaceInverse;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private Quaternion toJointSpaceDefault;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private Quaternion targetAnimatedRotation;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Quaternion targetAnimatedWorldRotation;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Quaternion rotationRelativeToTarget;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private Quaternion lastMappedRotation;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Transform targetParent;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private Transform connectedBodyTransform;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private ConfigurableJointMotion angularXMotionDefault;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private ConfigurableJointMotion angularYMotionDefault;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private ConfigurableJointMotion angularZMotionDefault;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		private bool directTargetParent;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x215")]
		private bool initiated;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Collider[] _colliders;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private float lastReadTime;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private float lastWriteTime;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private bool[] disabledColliders;

		[Token(Token = "0x1700001D")]
		public Transform transform
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x18F6FE4", Offset = "0x18F6FE4", VA = "0x18F6FE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5088", Offset = "0x9C5088")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x18F6FEC", Offset = "0x18F6FEC", VA = "0x18F6FEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5098", Offset = "0x9C5098")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public Rigidbody rigidbody
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x18F6FF4", Offset = "0x18F6FF4", VA = "0x18F6FF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C50A8", Offset = "0x9C50A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x18F6FFC", Offset = "0x18F6FFC", VA = "0x18F6FFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C50B8", Offset = "0x9C50B8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public Transform connectedBodyTarget
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x18F7004", Offset = "0x18F7004", VA = "0x18F7004")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C50C8", Offset = "0x9C50C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x18F700C", Offset = "0x18F700C", VA = "0x18F700C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C50D8", Offset = "0x9C50D8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public Vector3 targetAnimatedPosition
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x18F7014", Offset = "0x18F7014", VA = "0x18F7014")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C50E8", Offset = "0x9C50E8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x18F7020", Offset = "0x18F7020", VA = "0x18F7020")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C50F8", Offset = "0x9C50F8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public Collider[] colliders
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x18F702C", Offset = "0x18F702C", VA = "0x18F702C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		public Vector3 targetVelocity
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x18F7034", Offset = "0x18F7034", VA = "0x18F7034")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5108", Offset = "0x9C5108")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x18F7040", Offset = "0x18F7040", VA = "0x18F7040")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5118", Offset = "0x9C5118")]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public Vector3 targetAngularVelocity
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x18F704C", Offset = "0x18F704C", VA = "0x18F704C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5128", Offset = "0x9C5128")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x18F7058", Offset = "0x18F7058", VA = "0x18F7058")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5138", Offset = "0x9C5138")]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public Vector3 mappedVelocity
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x18F7064", Offset = "0x18F7064", VA = "0x18F7064")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5148", Offset = "0x9C5148")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x18F7070", Offset = "0x18F7070", VA = "0x18F7070")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5158", Offset = "0x9C5158")]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public Vector3 mappedAngularVelocity
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x18F707C", Offset = "0x18F707C", VA = "0x18F707C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5168", Offset = "0x9C5168")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x18F7088", Offset = "0x18F7088", VA = "0x18F7088")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5178", Offset = "0x9C5178")]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Quaternion targetRotationRelative
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x18F7094", Offset = "0x18F7094", VA = "0x18F7094")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5188", Offset = "0x9C5188")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x18F70A4", Offset = "0x18F70A4", VA = "0x18F70A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5198", Offset = "0x9C5198")]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		private Quaternion localRotation
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x18F82F4", Offset = "0x18F82F4", VA = "0x18F82F4")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000028")]
		private Quaternion parentRotation
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x18F8494", Offset = "0x18F8494", VA = "0x18F8494")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000029")]
		private Quaternion targetParentRotation
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x18F83DC", Offset = "0x18F83DC", VA = "0x18F83DC")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700002A")]
		private Quaternion targetLocalRotation
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x18F85E4", Offset = "0x18F85E4", VA = "0x18F85E4")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x18F70B4", Offset = "0x18F70B4", VA = "0x18F70B4")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x18F7298", Offset = "0x18F7298", VA = "0x18F7298", Slot = "4")]
		public virtual void Initiate(Muscle[] colleagues)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x18F8110", Offset = "0x18F8110", VA = "0x18F8110")]
		public void UpdateColliders()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x18F8CD8", Offset = "0x18F8CD8", VA = "0x18F8CD8")]
		public void DisableColliders()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x18F8D98", Offset = "0x18F8D98", VA = "0x18F8D98")]
		public void EnableColliders()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x18F8984", Offset = "0x18F8984", VA = "0x18F8984")]
		private void AddColliders(Transform t, ref Collider[] C, bool includeMeshColliders)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x18F8BD0", Offset = "0x18F8BD0", VA = "0x18F8BD0")]
		private void AddCompoundColliders(Transform t, ref Collider[] colliders)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x18F8E44", Offset = "0x18F8E44", VA = "0x18F8E44")]
		public void IgnoreCollisions(Muscle m, bool ignore)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x18F9010", Offset = "0x18F9010", VA = "0x18F9010")]
		public void IgnoreAngularLimits(bool ignore)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x18F90B0", Offset = "0x18F90B0", VA = "0x18F90B0")]
		public void FixTargetTransforms()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x18F911C", Offset = "0x18F911C", VA = "0x18F911C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x18F936C", Offset = "0x18F936C", VA = "0x18F936C")]
		public void MoveToTarget()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x18F8704", Offset = "0x18F8704", VA = "0x18F8704")]
		public void Read()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x18F94A0", Offset = "0x18F94A0", VA = "0x18F94A0")]
		public void ClearVelocities()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x18F95B8", Offset = "0x18F95B8", VA = "0x18F95B8")]
		public void UpdateAnchor(bool supportTranslationAnimation)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x18F9950", Offset = "0x18F9950", VA = "0x18F9950", Slot = "5")]
		public virtual void Update(float pinWeightMaster, float muscleWeightMaster, float muscleSpring, float muscleDamper, float pinPow, float pinDistanceFalloff, bool rotationTargetChanged)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x18FA0DC", Offset = "0x18FA0DC", VA = "0x18FA0DC")]
		public void Map(float mappingWeightMaster)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x18FA4D8", Offset = "0x18FA4D8", VA = "0x18FA4D8")]
		public void CalculateMappedVelocity()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x18F9C04", Offset = "0x18F9C04", VA = "0x18F9C04")]
		private void Pin(float pinWeightMaster, float pinPow, float pinDistanceFalloff)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x18F9EF8", Offset = "0x18F9EF8", VA = "0x18F9EF8")]
		private void MuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x18FA694", Offset = "0x18FA694", VA = "0x18FA694")]
		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x18F9830", Offset = "0x18F9830", VA = "0x18F9830")]
		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x18F8224", Offset = "0x18F8224", VA = "0x18F8224")]
		private Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x18FA788", Offset = "0x18FA788", VA = "0x18FA788")]
		public Muscle()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public struct MuscleCollision
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Collision collision;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isStay;

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x18FA958", Offset = "0x18FA958", VA = "0x18FA958")]
		public MuscleCollision(int muscleIndex, Collision collision, bool isStay = false)
		{
		}
	}
	[Token(Token = "0x2000024")]
	public struct MuscleHit
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float unPin;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 force;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 position;

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x18FAA58", Offset = "0x18FAA58", VA = "0x18FAA58")]
		public MuscleHit(int muscleIndex, float unPin, Vector3 force, Vector3 position)
		{
		}
	}
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B94B8", Offset = "0x9B94B8")]
	public class MuscleCollisionBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		public int muscleIndex;

		[Token(Token = "0x4000164")]
		private const string onMuscleHit = "OnMuscleHit";

		[Token(Token = "0x4000165")]
		private const string onMuscleCollision = "OnMuscleCollision";

		[Token(Token = "0x4000166")]
		private const string onMuscleCollisionExit = "OnMuscleCollisionExit";

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MuscleCollisionBroadcaster otherBroadcaster;

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x18FA96C", Offset = "0x18FA96C", VA = "0x18FA96C")]
		public void Hit(float unPin, Vector3 force, Vector3 position)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x18FAA70", Offset = "0x18FAA70", VA = "0x18FAA70")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x18FAC28", Offset = "0x18FAC28", VA = "0x18FAC28")]
		private void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x18FAE74", Offset = "0x18FAE74", VA = "0x18FAE74")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x18FB0BC", Offset = "0x18FB0BC", VA = "0x18FB0BC")]
		public MuscleCollisionBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public static class PhysXTools
	{
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x18FB0C4", Offset = "0x18FB0C4", VA = "0x18FB0C4")]
		public static Vector3 GetCenterOfMass(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x18FB2BC", Offset = "0x18FB2BC", VA = "0x18FB2BC")]
		public static Vector3 GetCenterOfMassVelocity(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x18FB4B4", Offset = "0x18FB4B4", VA = "0x18FB4B4")]
		public static void DivByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x18FB5F4", Offset = "0x18FB5F4", VA = "0x18FB5F4")]
		public static void ScaleByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x18FB730", Offset = "0x18FB730", VA = "0x18FB730")]
		public static Vector3 GetFromToAcceleration(Vector3 fromV, Vector3 toV)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x18FB894", Offset = "0x18FB894", VA = "0x18FB894")]
		public static Vector3 GetAngularAcceleration(Quaternion fromR, Quaternion toR)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x18FBB20", Offset = "0x18FBB20", VA = "0x18FBB20")]
		public static void AddFromToTorque(Rigidbody r, Quaternion toR, ForceMode forceMode)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x18FBDD0", Offset = "0x18FBDD0", VA = "0x18FBDD0")]
		public static void AddFromToTorque(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x18FC084", Offset = "0x18FC084", VA = "0x18FC084")]
		public static void AddFromToForce(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x18FC2F0", Offset = "0x18FC2F0", VA = "0x18FC2F0")]
		public static Vector3 GetLinearAcceleration(Vector3 fromPoint, Vector3 toPoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x18FC3C4", Offset = "0x18FC3C4", VA = "0x18FC3C4")]
		public static Quaternion ToJointSpace(ConfigurableJoint joint)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x18FC514", Offset = "0x18FC514", VA = "0x18FC514")]
		public static Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x18FB5B4", Offset = "0x18FB5B4", VA = "0x18FB5B4")]
		public static Vector3 Div(Vector3 v, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000027")]
	public class PressureSensor : MonoBehaviour
	{
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool visualize;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask layers;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BBB5C", Offset = "0x9BBB5C")]
		private Vector3 <center>k__BackingField;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BBB6C", Offset = "0x9BBB6C")]
		private bool <inContact>k__BackingField;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BBB7C", Offset = "0x9BBB7C")]
		private Vector3 <bottom>k__BackingField;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BBB8C", Offset = "0x9BBB8C")]
		private Rigidbody <r>k__BackingField;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool fixedFrame;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 P;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int count;

		[Token(Token = "0x1700002B")]
		public Vector3 center
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x18FC578", Offset = "0x18FC578", VA = "0x18FC578")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C51A8", Offset = "0x9C51A8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x18FC584", Offset = "0x18FC584", VA = "0x18FC584")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C51B8", Offset = "0x9C51B8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public bool inContact
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x18FC590", Offset = "0x18FC590", VA = "0x18FC590")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C51C8", Offset = "0x9C51C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x18FC598", Offset = "0x18FC598", VA = "0x18FC598")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C51D8", Offset = "0x9C51D8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public Vector3 bottom
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x18FC5A4", Offset = "0x18FC5A4", VA = "0x18FC5A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C51E8", Offset = "0x9C51E8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x18FC5B0", Offset = "0x18FC5B0", VA = "0x18FC5B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C51F8", Offset = "0x9C51F8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public Rigidbody r
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x18FC5BC", Offset = "0x18FC5BC", VA = "0x18FC5BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5208", Offset = "0x9C5208")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x18FC5C4", Offset = "0x18FC5C4", VA = "0x18FC5C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5218", Offset = "0x9C5218")]
			private set
			{
			}
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x18FC5CC", Offset = "0x18FC5CC", VA = "0x18FC5CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x18FC648", Offset = "0x18FC648", VA = "0x18FC648")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x18FC868", Offset = "0x18FC868", VA = "0x18FC868")]
		private void OnCollisionStay(Collision c)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x18FC86C", Offset = "0x18FC86C", VA = "0x18FC86C")]
		private void OnCollisionExit(Collision c)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x18FC874", Offset = "0x18FC874", VA = "0x18FC874")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x18FC908", Offset = "0x18FC908", VA = "0x18FC908")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x18FC64C", Offset = "0x18FC64C", VA = "0x18FC64C")]
		private void ProcessCollision(Collision c)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x18FC9B8", Offset = "0x18FC9B8", VA = "0x18FC9B8")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x18FC9DC", Offset = "0x18FC9DC", VA = "0x18FC9DC")]
		public PressureSensor()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public abstract class Prop : MonoBehaviour
	{
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBB9C", Offset = "0x9BBB9C")]
		public int propType;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BBBD4", Offset = "0x9BBBD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBBD4", Offset = "0x9BBBD4")]
		public ConfigurableJoint muscle;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBC34", Offset = "0x9BBC34")]
		public Muscle.Props muscleProps;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBC6C", Offset = "0x9BBC6C")]
		public bool forceLayers;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BBCA4", Offset = "0x9BBCA4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBCA4", Offset = "0x9BBCA4")]
		public ConfigurableJoint additionalPin;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBD04", Offset = "0x9BBD04")]
		public Transform additionalPinTarget;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBD3C", Offset = "0x9BBD3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BBD3C", Offset = "0x9BBD3C")]
		public float additionalPinWeight;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BBD90", Offset = "0x9BBD90")]
		private PropRoot <propRoot>k__BackingField;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ConfigurableJointMotion xMotion;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private ConfigurableJointMotion yMotion;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ConfigurableJointMotion zMotion;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private ConfigurableJointMotion angularXMotion;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ConfigurableJointMotion angularYMotion;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private ConfigurableJointMotion angularZMotion;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Collider[] colliders;

		[Token(Token = "0x1700002F")]
		public bool isPickedUp
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x18FC9E4", Offset = "0x18FC9E4", VA = "0x18FC9E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000030")]
		public PropRoot propRoot
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x18FCA54", Offset = "0x18FCA54", VA = "0x18FCA54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5228", Offset = "0x9C5228")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x18FCA5C", Offset = "0x18FCA5C", VA = "0x18FCA5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5238", Offset = "0x9C5238")]
			private set
			{
			}
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x18FCA64", Offset = "0x18FCA64", VA = "0x18FCA64")]
		public void PickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x18FCC08", Offset = "0x18FCC08", VA = "0x18FCC08")]
		public void Drop()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x18FCC18", Offset = "0x18FCC18", VA = "0x18FCC18")]
		public void StartPickedUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x18FCC20", Offset = "0x18FCC20", VA = "0x18FCC20", Slot = "4")]
		protected virtual void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x18FCC24", Offset = "0x18FCC24", VA = "0x18FCC24", Slot = "5")]
		protected virtual void OnDrop()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x18FCC28", Offset = "0x18FCC28", VA = "0x18FCC28", Slot = "6")]
		protected virtual void OnStart()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x18FCC2C", Offset = "0x18FCC2C", VA = "0x18FCC2C", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x18FCE10", Offset = "0x18FCE10", VA = "0x18FCE10")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x18FCE48", Offset = "0x18FCE48", VA = "0x18FCE48")]
		private void ReleaseJoint()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x18FCF94", Offset = "0x18FCF94", VA = "0x18FCF94")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x18FD144", Offset = "0x18FD144", VA = "0x18FD144")]
		protected Prop()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B94F0", Offset = "0x9B94F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B94F0", Offset = "0x9B94F0")]
	public class PropRoot : MonoBehaviour
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBDA0", Offset = "0x9BBDA0")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBDD8", Offset = "0x9BBDD8")]
		public Rigidbody connectTo;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBE10", Offset = "0x9BBE10")]
		public Prop currentProp;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Prop lastProp;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool fixedUpdateCalled;

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x18FD1F0", Offset = "0x18FD1F0", VA = "0x18FD1F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5248", Offset = "0x9C5248")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x18FD23C", Offset = "0x18FD23C", VA = "0x18FD23C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5280", Offset = "0x9C5280")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x18FD288", Offset = "0x18FD288", VA = "0x18FD288")]
		public void DropImmediate()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x18FD344", Offset = "0x18FD344", VA = "0x18FD344")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x18FD3CC", Offset = "0x18FD3CC", VA = "0x18FD3CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x18FD4F4", Offset = "0x18FD4F4", VA = "0x18FD4F4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x18FD6C0", Offset = "0x18FD6C0", VA = "0x18FD6C0")]
		private void AttachProp(Prop prop)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x18FE1AC", Offset = "0x18FE1AC", VA = "0x18FE1AC")]
		public PropRoot()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B9550", Offset = "0x9B9550")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B9550", Offset = "0x9B9550")]
	public class PropTemplate : Prop
	{
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x18FE1B4", Offset = "0x18FE1B4", VA = "0x18FE1B4", Slot = "6")]
		protected override void OnStart()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x18FE1B8", Offset = "0x18FE1B8", VA = "0x18FE1B8", Slot = "4")]
		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x18FE1BC", Offset = "0x18FE1BC", VA = "0x18FE1BC", Slot = "5")]
		protected override void OnDrop()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x18FE1C0", Offset = "0x18FE1C0", VA = "0x18FE1C0")]
		public PropTemplate()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B95B0", Offset = "0x9B95B0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B95B0", Offset = "0x9B95B0")]
	public class PuppetMaster : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FC")]
		public enum Mode
		{
			[Token(Token = "0x4000731")]
			Active,
			[Token(Token = "0x4000732")]
			Kinematic,
			[Token(Token = "0x4000733")]
			Disabled
		}

		[Token(Token = "0x20000FD")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000FE")]
		public delegate void MuscleDelegate(Muscle muscle);

		[Serializable]
		[Token(Token = "0x20000FF")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000735")]
			Normal,
			[Token(Token = "0x4000736")]
			AnimatePhysics,
			[Token(Token = "0x4000737")]
			FixedUpdate
		}

		[Serializable]
		[Token(Token = "0x2000100")]
		public enum State
		{
			[Token(Token = "0x4000739")]
			Alive,
			[Token(Token = "0x400073A")]
			Dead,
			[Token(Token = "0x400073B")]
			Frozen
		}

		[Serializable]
		[Token(Token = "0x2000101")]
		public struct StateSettings
		{
			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1958", Offset = "0x9C1958")]
			public float killDuration;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1990", Offset = "0x9C1990")]
			public float deadMuscleWeight;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C19C8", Offset = "0x9C19C8")]
			public float deadMuscleDamper;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1A00", Offset = "0x9C1A00")]
			public float maxFreezeSqrVelocity;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1A38", Offset = "0x9C1A38")]
			public bool freezePermanently;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1A70", Offset = "0x9C1A70")]
			public bool enableAngularLimitsOnKill;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1AA8", Offset = "0x9C1AA8")]
			public bool enableInternalCollisionsOnKill;

			[Token(Token = "0x170000AD")]
			public static StateSettings Default
			{
				[Token(Token = "0x60007CD")]
				[Address(RVA = "0x18FE3A8", Offset = "0x18FE3A8", VA = "0x18FE3A8")]
				get
				{
					return default(StateSettings);
				}
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x190A2C8", Offset = "0x190A2C8", VA = "0x190A2C8")]
			public StateSettings(float killDuration, float deadMuscleWeight = 0.01f, float deadMuscleDamper = 2f, float maxFreezeSqrVelocity = 0.02f, bool freezePermanently = false, bool enableAngularLimitsOnKill = true, bool enableInternalCollisionsOnKill = true)
			{
			}
		}

		[Token(Token = "0x2000102")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA730", Offset = "0x9BA730")]
		private sealed class <DisabledToActive>d__126 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x170000AE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D1")]
				[Address(RVA = "0x1909FA4", Offset = "0x1909FA4", VA = "0x1909FA4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D3")]
				[Address(RVA = "0x190A00C", Offset = "0x190A00C", VA = "0x190A00C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x19046A4", Offset = "0x19046A4", VA = "0x19046A4")]
			[DebuggerHidden]
			public <DisabledToActive>d__126(int <>1__state)
			{
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x1909D04", Offset = "0x1909D04", VA = "0x1909D04", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x1909D08", Offset = "0x1909D08", VA = "0x1909D08", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x1909FAC", Offset = "0x1909FAC", VA = "0x1909FAC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000103")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA740", Offset = "0x9BA740")]
		private sealed class <KinematicToActive>d__128 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x170000B0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D7")]
				[Address(RVA = "0x190A218", Offset = "0x190A218", VA = "0x190A218", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D9")]
				[Address(RVA = "0x190A280", Offset = "0x190A280", VA = "0x190A280", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x19046D0", Offset = "0x19046D0", VA = "0x19046D0")]
			[DebuggerHidden]
			public <KinematicToActive>d__128(int <>1__state)
			{
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x190A014", Offset = "0x190A014", VA = "0x190A014", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x190A018", Offset = "0x190A018", VA = "0x190A018", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x190A220", Offset = "0x190A220", VA = "0x190A220", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA750", Offset = "0x9BA750")]
		private sealed class <ActiveToDisabled>d__129 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x170000B2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007DD")]
				[Address(RVA = "0x1909690", Offset = "0x1909690", VA = "0x1909690", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007DF")]
				[Address(RVA = "0x19096F8", Offset = "0x19096F8", VA = "0x19096F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x19046FC", Offset = "0x19046FC", VA = "0x19046FC")]
			[DebuggerHidden]
			public <ActiveToDisabled>d__129(int <>1__state)
			{
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x1909530", Offset = "0x1909530", VA = "0x1909530", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x1909534", Offset = "0x1909534", VA = "0x1909534", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x1909698", Offset = "0x1909698", VA = "0x1909698", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA760", Offset = "0x9BA760")]
		private sealed class <ActiveToKinematic>d__130 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x170000B4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E3")]
				[Address(RVA = "0x1909894", Offset = "0x1909894", VA = "0x1909894", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007E5")]
				[Address(RVA = "0x19098FC", Offset = "0x19098FC", VA = "0x19098FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x1904728", Offset = "0x1904728", VA = "0x1904728")]
			[DebuggerHidden]
			public <ActiveToKinematic>d__130(int <>1__state)
			{
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x1909700", Offset = "0x1909700", VA = "0x1909700", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x1909704", Offset = "0x1909704", VA = "0x1909704", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x190989C", Offset = "0x190989C", VA = "0x190989C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA770", Offset = "0x9BA770")]
		private sealed class <AliveToDead>d__182 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool freeze;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <range>5__2;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <mW>5__3;

			[Token(Token = "0x170000B6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E9")]
				[Address(RVA = "0x1909C94", Offset = "0x1909C94", VA = "0x1909C94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007EB")]
				[Address(RVA = "0x1909CFC", Offset = "0x1909CFC", VA = "0x1909CFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x1907EC4", Offset = "0x1907EC4", VA = "0x1907EC4")]
			[DebuggerHidden]
			public <AliveToDead>d__182(int <>1__state)
			{
			}

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x1909904", Offset = "0x1909904", VA = "0x1909904", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x1909908", Offset = "0x1909908", VA = "0x1909908", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x1909C9C", Offset = "0x1909C9C", VA = "0x1909C9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBE48", Offset = "0x9BBE48")]
		public PuppetMasterHumanoidConfig humanoidConfig;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform targetRoot;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BBE80", Offset = "0x9BBE80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBE80", Offset = "0x9BBE80")]
		public State state;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x9BBEE0", Offset = "0x9BBEE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBEE0", Offset = "0x9BBEE0")]
		public StateSettings stateSettings;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBF5C", Offset = "0x9BBF5C")]
		public Mode mode;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBF94", Offset = "0x9BBF94")]
		public float blendTime;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBFCC", Offset = "0x9BBFCC")]
		public bool fixTargetTransforms;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC004", Offset = "0x9BC004")]
		public int solverIterationCount;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC03C", Offset = "0x9BC03C")]
		public bool visualizeTargetPose;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BC074", Offset = "0x9BC074")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC074", Offset = "0x9BC074")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC074", Offset = "0x9BC074")]
		public float mappingWeight;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC0EC", Offset = "0x9BC0EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC0EC", Offset = "0x9BC0EC")]
		public float pinWeight;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC140", Offset = "0x9BC140")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC140", Offset = "0x9BC140")]
		public float muscleWeight;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BC194", Offset = "0x9BC194")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC194", Offset = "0x9BC194")]
		public float muscleSpring;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC1F4", Offset = "0x9BC1F4")]
		public float muscleDamper;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC22C", Offset = "0x9BC22C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC22C", Offset = "0x9BC22C")]
		public float pinPow;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC280", Offset = "0x9BC280")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC280", Offset = "0x9BC280")]
		public float pinDistanceFalloff;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC2D8", Offset = "0x9BC2D8")]
		public bool updateJointAnchors;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC310", Offset = "0x9BC310")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC348", Offset = "0x9BC348")]
		public bool angularLimits;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC380", Offset = "0x9BC380")]
		public bool internalCollisions;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BC3B8", Offset = "0x9BC3B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC3B8", Offset = "0x9BC3B8")]
		public Muscle[] muscles;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UpdateDelegate OnRead;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnWrite;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPostLateUpdate;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public UpdateDelegate OnHierarchyChanged;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public MuscleDelegate OnMuscleRemoved;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Animator _targetAnimator;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC418", Offset = "0x9BC418")]
		private Animation <targetAnimation>k__BackingField;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC428", Offset = "0x9BC428")]
		private BehaviourBase[] <behaviours>k__BackingField;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC438", Offset = "0x9BC438")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[HideInInspector]
		public List<SolverManager> solvers;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool internalCollisionsEnabled;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool angularLimitsEnabled;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE2")]
		private bool fixedFrame;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int lastSolverIterationCount;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool isLegacy;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		private bool animatorDisabled;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
		private bool awakeFailed;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEB")]
		private bool interpolated;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private bool freezeFlag;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xED")]
		private bool hasBeenDisabled;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEE")]
		private bool hierarchyIsFlat;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEF")]
		private bool teleport;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 teleportPosition;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private Quaternion teleportRotation;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool teleportMoveToTarget;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Transform headOriginTr;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC458", Offset = "0x9BC458")]
		private bool <isSwitchingMode>k__BackingField;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Mode activeMode;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Mode lastMode;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private float mappingBlend;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC468", Offset = "0x9BC468")]
		private bool <isKilling>k__BackingField;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public UpdateDelegate OnFreeze;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public UpdateDelegate OnUnfreeze;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public UpdateDelegate OnDeath;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public UpdateDelegate OnResurrection;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private State activeState;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private State lastState;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool angularLimitsEnabledOnKill;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
		private bool internalCollisionsEnabledOnKill;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15A")]
		private bool animationDisabledbyStates;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15B")]
		[HideInInspector]
		public bool storeTargetMappedState;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Transform[] targetChildren;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Vector3[] targetMappedPositions;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Quaternion[] targetMappedRotations;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Vector3[] targetSampledPositions;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Quaternion[] targetSampledRotations;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private bool targetMappedStateStored;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x189")]
		private bool targetMappedStateSampled;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18A")]
		private bool sampleTargetMappedState;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18B")]
		private bool hasProp;

		[Token(Token = "0x17000031")]
		public Animator targetAnimator
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x18FE3D0", Offset = "0x18FE3D0", VA = "0x18FE3D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x18FE518", Offset = "0x18FE518", VA = "0x18FE518")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public Animation targetAnimation
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x18FE520", Offset = "0x18FE520", VA = "0x18FE520")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5408", Offset = "0x9C5408")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x18FE528", Offset = "0x18FE528", VA = "0x18FE528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5418", Offset = "0x9C5418")]
			private set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public BehaviourBase[] behaviours
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x18FE530", Offset = "0x18FE530", VA = "0x18FE530")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5428", Offset = "0x9C5428")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x18FE538", Offset = "0x18FE538", VA = "0x18FE538")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5438", Offset = "0x9C5438")]
			private set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public bool isActive
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x18FE540", Offset = "0x18FE540", VA = "0x18FE540")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		public bool initiated
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x18FE5C4", Offset = "0x18FE5C4", VA = "0x18FE5C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5448", Offset = "0x9C5448")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x18FE5CC", Offset = "0x18FE5CC", VA = "0x18FE5CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5458", Offset = "0x9C5458")]
			private set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public UpdateMode updateMode
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x18FE5D8", Offset = "0x18FE5D8", VA = "0x18FE5D8")]
			get
			{
				return default(UpdateMode);
			}
		}

		[Token(Token = "0x17000037")]
		public bool controlsAnimator
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x18FE714", Offset = "0x18FE714", VA = "0x18FE714")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		public bool isBlending
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x18FE5A0", Offset = "0x18FE5A0", VA = "0x18FE5A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		private AnimatorUpdateMode targetUpdateMode
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x18FE618", Offset = "0x18FE618", VA = "0x18FE618")]
			get
			{
				return default(AnimatorUpdateMode);
			}
		}

		[Token(Token = "0x1700003A")]
		public bool isSwitchingMode
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x19040EC", Offset = "0x19040EC", VA = "0x19040EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5510", Offset = "0x9C5510")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x19040F4", Offset = "0x19040F4", VA = "0x19040F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5520", Offset = "0x9C5520")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public bool isSwitchingState
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x18FE774", Offset = "0x18FE774", VA = "0x18FE774")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		public bool isKilling
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x19078D4", Offset = "0x19078D4", VA = "0x19078D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C56C0", Offset = "0x9C56C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x19078DC", Offset = "0x19078DC", VA = "0x19078DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C56D0", Offset = "0x9C56D0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public bool isAlive
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x1902984", Offset = "0x1902984", VA = "0x1902984")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003E")]
		public bool isFrozen
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x1902074", Offset = "0x1902074", VA = "0x1902074")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x18FE1C4", Offset = "0x18FE1C4", VA = "0x18FE1C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C52B8", Offset = "0x9C52B8")]
		private void OpenUserManualSetup()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x18FE210", Offset = "0x18FE210", VA = "0x18FE210")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C52F0", Offset = "0x9C52F0")]
		private void OpenUserManualComponent()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x18FE25C", Offset = "0x18FE25C", VA = "0x18FE25C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5328", Offset = "0x9C5328")]
		private void OpenUserManualPerformance()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x18FE2A8", Offset = "0x18FE2A8", VA = "0x18FE2A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5360", Offset = "0x9C5360")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x18FE2F4", Offset = "0x18FE2F4", VA = "0x18FE2F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5398", Offset = "0x9C5398")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x18FE340", Offset = "0x18FE340", VA = "0x18FE340")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C53D0", Offset = "0x9C53D0")]
		private void OpenComponentTutorial()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x18FE38C", Offset = "0x18FE38C", VA = "0x18FE38C")]
		private void ResetStateSettings()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x18FE788", Offset = "0x18FE788", VA = "0x18FE788")]
		public void Teleport(Vector3 position, Quaternion rotation, bool moveToTarget)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x18FE7B0", Offset = "0x18FE7B0", VA = "0x18FE7B0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x18FE858", Offset = "0x18FE858", VA = "0x18FE858")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x18FEFA4", Offset = "0x18FEFA4", VA = "0x18FEFA4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x18FF8FC", Offset = "0x18FF8FC", VA = "0x18FF8FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x18FF9A4", Offset = "0x18FF9A4", VA = "0x18FF9A4")]
		public Transform FindTargetRootRecursive(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x18FEFE8", Offset = "0x18FEFE8", VA = "0x18FEFE8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1900CC4", Offset = "0x1900CC4", VA = "0x1900CC4")]
		private void ActivateBehaviour(BehaviourBase behaviour)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1900FCC", Offset = "0x1900FCC", VA = "0x1900FCC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x19010C0", Offset = "0x19010C0", VA = "0x19010C0")]
		private bool IsInterpolated()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x190114C", Offset = "0x190114C", VA = "0x190114C", Slot = "4")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1902218", Offset = "0x1902218", VA = "0x1902218", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1902294", Offset = "0x1902294", VA = "0x1902294", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x19022E4", Offset = "0x19022E4", VA = "0x19022E4", Slot = "7")]
		protected virtual void OnLateUpdate()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x190256C", Offset = "0x190256C", VA = "0x190256C")]
		private void MoveToTarget()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x19016FC", Offset = "0x19016FC", VA = "0x19016FC")]
		private void Read()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x1901570", Offset = "0x1901570", VA = "0x1901570")]
		private void FixTargetTransforms()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1902994", Offset = "0x1902994", VA = "0x1902994")]
		private void VisualizeTargetPose()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1902C3C", Offset = "0x1902C3C", VA = "0x1902C3C")]
		private void VisualizeHierarchy(Transform t, Color color)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1902084", Offset = "0x1902084", VA = "0x1902084")]
		private void SetInternalCollisions(bool collide)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x190217C", Offset = "0x190217C", VA = "0x190217C")]
		private void SetAngularLimits(bool limited)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x18FD8FC", Offset = "0x18FD8FC", VA = "0x18FD8FC")]
		public void AddMuscle(ConfigurableJoint joint, Transform target, Rigidbody connectTo, Transform targetParent, [Optional] Muscle.Props muscleProps, bool forceTreeHierarchy = false, bool forceLayers = true)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x18F54BC", Offset = "0x18F54BC", VA = "0x18F54BC")]
		public void RemoveMuscleRecursive(ConfigurableJoint joint, bool attachTarget, bool blockTargetAnimation = false, MuscleRemoveMode removeMode = MuscleRemoveMode.Sever)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x190393C", Offset = "0x190393C", VA = "0x190393C")]
		public void ReplaceMuscle(ConfigurableJoint oldJoint, ConfigurableJoint newJoint)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x19039DC", Offset = "0x19039DC", VA = "0x19039DC")]
		public void SetMuscles(Muscle[] newMuscles)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1903A7C", Offset = "0x1903A7C", VA = "0x1903A7C")]
		public void DisableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1903B1C", Offset = "0x1903B1C", VA = "0x1903B1C")]
		public void EnableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1903BBC", Offset = "0x1903BBC", VA = "0x1903BBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5468", Offset = "0x9C5468")]
		public void FlattenHierarchy()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1903CCC", Offset = "0x1903CCC", VA = "0x1903CCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C54A0", Offset = "0x9C54A0")]
		public void TreeHierarchy()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1903E40", Offset = "0x1903E40", VA = "0x1903E40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C54D8", Offset = "0x9C54D8")]
		public void FixMusclePositions()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1903F7C", Offset = "0x1903F7C", VA = "0x1903F7C")]
		private void AddIndexesRecursive(int index, ref int[] indexes)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x190085C", Offset = "0x190085C", VA = "0x190085C")]
		private bool HierarchyIsFlat()
		{
			return default(bool);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1903448", Offset = "0x1903448", VA = "0x1903448")]
		private void DisconnectJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x19034E0", Offset = "0x19034E0", VA = "0x19034E0")]
		private void KillJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1904100", Offset = "0x1904100", VA = "0x1904100")]
		public void DisableImmediately()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x19041A0", Offset = "0x19041A0", VA = "0x19041A0", Slot = "8")]
		protected virtual void SwitchModes()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1904304", Offset = "0x1904304", VA = "0x1904304")]
		private void DisabledToKinematic()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1904448", Offset = "0x1904448", VA = "0x1904448")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C5530", Offset = "0x9C5530")]
		private IEnumerator DisabledToActive()
		{
			return null;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x19044B8", Offset = "0x19044B8", VA = "0x19044B8")]
		private void KinematicToDisabled()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1904554", Offset = "0x1904554", VA = "0x1904554")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C5594", Offset = "0x9C5594")]
		private IEnumerator KinematicToActive()
		{
			return null;
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x19045C4", Offset = "0x19045C4", VA = "0x19045C4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C55F8", Offset = "0x9C55F8")]
		private IEnumerator ActiveToDisabled()
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1904634", Offset = "0x1904634", VA = "0x1904634")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C565C", Offset = "0x9C565C")]
		private IEnumerator ActiveToKinematic()
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1904754", Offset = "0x1904754", VA = "0x1904754")]
		private void UpdateInternalCollisions()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1904824", Offset = "0x1904824", VA = "0x1904824")]
		public void SetMuscleWeights(Muscle.Group group, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x19048F4", Offset = "0x19048F4", VA = "0x19048F4")]
		public void SetMuscleWeights(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1904D28", Offset = "0x1904D28", VA = "0x1904D28")]
		public void SetMuscleWeights(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1904FDC", Offset = "0x1904FDC", VA = "0x1904FDC")]
		public void SetMuscleWeightsRecursive(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1905110", Offset = "0x1905110", VA = "0x1905110")]
		public void SetMuscleWeightsRecursive(int muscleIndex, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x19051FC", Offset = "0x19051FC", VA = "0x19051FC")]
		public void SetMuscleWeightsRecursive(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1904B54", Offset = "0x1904B54", VA = "0x1904B54")]
		public void SetMuscleWeights(int muscleIndex, float muscleWeight, float pinWeight, float mappingWeight, float muscleDamper)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1905284", Offset = "0x1905284", VA = "0x1905284")]
		public Muscle GetMuscle(Transform target)
		{
			return null;
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1902F3C", Offset = "0x1902F3C", VA = "0x1902F3C")]
		public Muscle GetMuscle(Rigidbody rigidbody)
		{
			return null;
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x19054B8", Offset = "0x19054B8", VA = "0x19054B8")]
		public Muscle GetMuscle(ConfigurableJoint joint)
		{
			return null;
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1902E4C", Offset = "0x1902E4C", VA = "0x1902E4C")]
		public bool ContainsJoint(ConfigurableJoint joint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1904DB0", Offset = "0x1904DB0", VA = "0x1904DB0")]
		public int GetMuscleIndex(HumanBodyBones humanBodyBone)
		{
			return default(int);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x190497C", Offset = "0x190497C", VA = "0x190497C")]
		public int GetMuscleIndex(Transform target)
		{
			return default(int);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x19052E0", Offset = "0x19052E0", VA = "0x19052E0")]
		public int GetMuscleIndex(Rigidbody rigidbody)
		{
			return default(int);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1903270", Offset = "0x1903270", VA = "0x1903270")]
		public int GetMuscleIndex(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1905514", Offset = "0x1905514", VA = "0x1905514")]
		public static PuppetMaster SetUp(Transform target, Transform ragdoll, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x19060DC", Offset = "0x19060DC", VA = "0x19060DC")]
		public static PuppetMaster SetUp(Transform target, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1905608", Offset = "0x1905608", VA = "0x1905608")]
		public void SetUpTo(Transform setUpTo, int characterControllerLayer, int ragdollLayer)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x190623C", Offset = "0x190623C", VA = "0x190623C")]
		public static void RemoveRagdollComponents(Transform target, int characterControllerLayer)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1906A38", Offset = "0x1906A38", VA = "0x1906A38")]
		private void SetUpMuscles(Transform setUpTo)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x190742C", Offset = "0x190742C", VA = "0x190742C")]
		private static Muscle.Group FindGroup(Animator animator, Transform t)
		{
			return default(Muscle.Group);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1906664", Offset = "0x1906664", VA = "0x1906664")]
		private void RemoveUnnecessaryBones()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1907118", Offset = "0x1907118", VA = "0x1907118")]
		private static bool IsClothCollider(Collider collider, Cloth[] cloths)
		{
			return default(bool);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x19078E8", Offset = "0x19078E8", VA = "0x19078E8")]
		public void Kill()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x19078F4", Offset = "0x19078F4", VA = "0x19078F4")]
		public void Kill(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1907910", Offset = "0x1907910", VA = "0x1907910")]
		public void Freeze()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x190791C", Offset = "0x190791C", VA = "0x190791C")]
		public void Freeze(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1907938", Offset = "0x1907938", VA = "0x1907938")]
		public void Resurrect()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1907940", Offset = "0x1907940", VA = "0x1907940", Slot = "9")]
		protected virtual void SwitchStates()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1907A40", Offset = "0x1907A40", VA = "0x1907A40")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C56E0", Offset = "0x9C56E0")]
		private IEnumerator AliveToDead(bool freeze)
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1902704", Offset = "0x1902704", VA = "0x1902704")]
		private void OnFreezeFlag()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1907AC4", Offset = "0x1907AC4", VA = "0x1907AC4")]
		private void DeadToAlive()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x18FECD0", Offset = "0x18FECD0", VA = "0x18FECD0")]
		private void SetAnimationEnabled(bool to)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1907BD0", Offset = "0x1907BD0", VA = "0x1907BD0")]
		private void DeadToFrozen()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1907BDC", Offset = "0x1907BDC", VA = "0x1907BDC")]
		private void FrozenToAlive()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1907DF4", Offset = "0x1907DF4", VA = "0x1907DF4")]
		private void FrozenToDead()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x18FEDD0", Offset = "0x18FEDD0", VA = "0x18FEDD0")]
		private void ActivateRagdoll(bool kinematic = false)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1907EF0", Offset = "0x1907EF0", VA = "0x1907EF0")]
		private bool CanFreeze()
		{
			return default(bool);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1907FAC", Offset = "0x1907FAC", VA = "0x1907FAC")]
		public void SampleTargetMappedState()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x19080A0", Offset = "0x19080A0", VA = "0x19080A0")]
		public void FixTargetToSampledState(float weight)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x190096C", Offset = "0x190096C", VA = "0x190096C")]
		public void StoreTargetMappedState()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1900670", Offset = "0x1900670", VA = "0x1900670")]
		private void UpdateHierarchies()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1908B54", Offset = "0x1908B54", VA = "0x1908B54")]
		private bool HasProp()
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x19089E8", Offset = "0x19089E8", VA = "0x19089E8")]
		private void UpdateBroadcasterMuscleIndexes()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x19085E4", Offset = "0x19085E4", VA = "0x19085E4")]
		private void AssignParentAndChildIndexes()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1908BCC", Offset = "0x1908BCC", VA = "0x1908BCC")]
		private void AddToParentsRecursive(ConfigurableJoint joint, ref int[] indexes)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1908D44", Offset = "0x1908D44", VA = "0x1908D44")]
		private void AddToChildrenRecursive(ConfigurableJoint joint, ref int[] indexes, ref bool[] childFlags)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x19088DC", Offset = "0x19088DC", VA = "0x19088DC")]
		private void AssignKinshipDegrees()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1909024", Offset = "0x1909024", VA = "0x1909024")]
		private void AssignKinshipsDownRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1909188", Offset = "0x1909188", VA = "0x1909188")]
		private void AssignKinshipsUpRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1908F48", Offset = "0x1908F48", VA = "0x1908F48")]
		private int GetMuscleIndexLowLevel(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x18FFD18", Offset = "0x18FFD18", VA = "0x18FFD18")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1902F98", Offset = "0x1902F98", VA = "0x1902F98")]
		private bool CheckMassVariation(float threshold, bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1902DBC", Offset = "0x1902DBC", VA = "0x1902DBC")]
		private bool CheckIfInitiated()
		{
			return default(bool);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x19093EC", Offset = "0x19093EC", VA = "0x19093EC")]
		public PuppetMaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002C")]
	public enum MuscleRemoveMode
	{
		[Token(Token = "0x40001CF")]
		Sever,
		[Token(Token = "0x40001D0")]
		Explode,
		[Token(Token = "0x40001D1")]
		Numb
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x9B9610", Offset = "0x9B9610")]
	public class PuppetMasterHumanoidConfig : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2000107")]
		public class HumanoidMuscle
		{
			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Muscle.Props props;

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x14723B4", Offset = "0x14723B4", VA = "0x14723B4")]
			public HumanoidMuscle()
			{
			}
		}

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BC488", Offset = "0x9BC488")]
		public PuppetMaster.State state;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PuppetMaster.StateSettings stateSettings;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PuppetMaster.Mode mode;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blendTime;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool fixTargetTransforms;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int solverIterationCount;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool visualizeTargetPose;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BC4C0", Offset = "0x9BC4C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC4C0", Offset = "0x9BC4C0")]
		public float mappingWeight;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC514", Offset = "0x9BC514")]
		public float pinWeight;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC52C", Offset = "0x9BC52C")]
		public float muscleWeight;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BC544", Offset = "0x9BC544")]
		public float muscleSpring;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float muscleDamper;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC57C", Offset = "0x9BC57C")]
		public float pinPow;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC594", Offset = "0x9BC594")]
		public float pinDistanceFalloff;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool updateJointAnchors;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool angularLimits;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		public bool internalCollisions;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BC5B0", Offset = "0x9BC5B0")]
		public HumanoidMuscle[] muscles;

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1471E40", Offset = "0x1471E40", VA = "0x1471E40")]
		public void ApplyTo(PuppetMaster p)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x14721BC", Offset = "0x14721BC", VA = "0x14721BC")]
		private Muscle GetMuscle(HumanBodyBones boneId, Animator animator, PuppetMaster puppetMaster)
		{
			return null;
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x14722F0", Offset = "0x14722F0", VA = "0x14722F0")]
		public PuppetMasterHumanoidConfig()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B9664", Offset = "0x9B9664")]
	public class PuppetMasterSettings : Singleton<PuppetMasterSettings>
	{
		[Serializable]
		[Token(Token = "0x2000108")]
		public class PuppetUpdateLimit
		{
			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C1B18", Offset = "0x9C1B18")]
			public int puppetsPerFrame;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int index;

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x14729FC", Offset = "0x14729FC", VA = "0x14729FC")]
			public PuppetUpdateLimit()
			{
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x1472868", Offset = "0x1472868", VA = "0x1472868")]
			public void Step(int puppetCount)
			{
			}

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x1472518", Offset = "0x1472518", VA = "0x1472518")]
			public bool Update(List<PuppetMaster> puppets, PuppetMaster puppetMaster)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BC5E8", Offset = "0x9BC5E8")]
		public PuppetUpdateLimit kinematicCollidersUpdateLimit;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PuppetUpdateLimit freeUpdateLimit;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PuppetUpdateLimit fixedUpdateLimit;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool collisionStayMessages;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool collisionExitMessages;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float activePuppetCollisionThresholdMlp;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC620", Offset = "0x9BC620")]
		private int <currentlyActivePuppets>k__BackingField;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC630", Offset = "0x9BC630")]
		private int <currentlyKinematicPuppets>k__BackingField;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC640", Offset = "0x9BC640")]
		private int <currentlyDisabledPuppets>k__BackingField;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<PuppetMaster> _puppets;

		[Token(Token = "0x1700003F")]
		public int currentlyActivePuppets
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x14723BC", Offset = "0x14723BC", VA = "0x14723BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5744", Offset = "0x9C5744")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x14723C4", Offset = "0x14723C4", VA = "0x14723C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5754", Offset = "0x9C5754")]
			private set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public int currentlyKinematicPuppets
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x14723CC", Offset = "0x14723CC", VA = "0x14723CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5764", Offset = "0x9C5764")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x14723D4", Offset = "0x14723D4", VA = "0x14723D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5774", Offset = "0x9C5774")]
			private set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public int currentlyDisabledPuppets
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x14723DC", Offset = "0x14723DC", VA = "0x14723DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5784", Offset = "0x9C5784")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x14723E4", Offset = "0x14723E4", VA = "0x14723E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5794", Offset = "0x9C5794")]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public List<PuppetMaster> puppets
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x14723EC", Offset = "0x14723EC", VA = "0x14723EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x14723F4", Offset = "0x14723F4", VA = "0x14723F4")]
		public void Register(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x147248C", Offset = "0x147248C", VA = "0x147248C")]
		public void Unregister(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x14724F4", Offset = "0x14724F4", VA = "0x14724F4")]
		public bool UpdateMoveToTarget(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1472630", Offset = "0x1472630", VA = "0x1472630")]
		public bool UpdateFree(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1472654", Offset = "0x1472654", VA = "0x1472654")]
		public bool UpdateFixed(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1472678", Offset = "0x1472678", VA = "0x1472678")]
		private void Update()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1472884", Offset = "0x1472884", VA = "0x1472884")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x14728F4", Offset = "0x14728F4", VA = "0x14728F4")]
		public PuppetMasterSettings()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public static class PuppetMasterTools
	{
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1472A28", Offset = "0x1472A28", VA = "0x1472A28")]
		public static void PositionRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x14730B0", Offset = "0x14730B0", VA = "0x14730B0")]
		public static void RealignRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x147399C", Offset = "0x147399C", VA = "0x147399C")]
		private static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1473A54", Offset = "0x1473A54", VA = "0x1473A54")]
		private static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public class Weight
	{
		[Serializable]
		[Token(Token = "0x2000109")]
		public enum Mode
		{
			[Token(Token = "0x400075B")]
			Float,
			[Token(Token = "0x400075C")]
			Curve
		}

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mode mode;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float floatValue;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve curve;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string tooltip;

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x147771C", Offset = "0x147771C", VA = "0x147771C")]
		public Weight(float floatValue)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1477788", Offset = "0x1477788", VA = "0x1477788")]
		public Weight(float floatValue, string tooltip)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1477804", Offset = "0x1477804", VA = "0x1477804")]
		public float GetValue(float param)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000031")]
	public class InitialVelocity : MonoBehaviour
	{
		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 initialVelocity;

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x18F53CC", Offset = "0x18F53CC", VA = "0x18F53CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x18F5434", Offset = "0x18F5434", VA = "0x18F5434")]
		public InitialVelocity()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B969C", Offset = "0x9B969C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B969C", Offset = "0x9B969C")]
	public class BipedRagdollCreator : RagdollCreator
	{
		[Serializable]
		[Token(Token = "0x200010A")]
		public struct Options
		{
			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float weight;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1B34", Offset = "0x9C1B34")]
			public bool spine;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public bool chest;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public bool hands;

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public bool feet;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1B6C", Offset = "0x9C1B6C")]
			public JointType joints;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float jointRange;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1BA4", Offset = "0x9C1BA4")]
			public float colliderLengthOverlap;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ColliderType torsoColliders;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ColliderType headCollider;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ColliderType armColliders;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ColliderType handColliders;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public ColliderType legColliders;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ColliderType footColliders;

			[Token(Token = "0x170000B8")]
			public static Options Default
			{
				[Token(Token = "0x60007F0")]
				[Address(RVA = "0x11E95C4", Offset = "0x11E95C4", VA = "0x11E95C4")]
				get
				{
					return default(Options);
				}
			}
		}

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool canBuild;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedRagdollReferences references;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Options options;

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x11E92B0", Offset = "0x11E92B0", VA = "0x11E92B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C57A4", Offset = "0x9C57A4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x11E92FC", Offset = "0x11E92FC", VA = "0x11E92FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C57DC", Offset = "0x9C57DC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x11E9348", Offset = "0x11E9348", VA = "0x11E9348")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5814", Offset = "0x9C5814")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x11E9394", Offset = "0x11E9394", VA = "0x11E9394")]
		public static Options AutodetectOptions(BipedRagdollReferences r)
		{
			return default(Options);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x11E96D0", Offset = "0x11E96D0", VA = "0x11E96D0")]
		public static void Create(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x11E9FE4", Offset = "0x11E9FE4", VA = "0x11E9FE4")]
		private static void CreateColliders(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x11EB98C", Offset = "0x11EB98C", VA = "0x11EB98C")]
		private static void CreateHandCollider(Transform hand, Transform lowerArm, Transform root, Options options)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x11EBC84", Offset = "0x11EBC84", VA = "0x11EBC84")]
		private static void CreateFootCollider(Transform foot, Transform lowerLeg, Transform upperLeg, Transform root, Options options)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x11EC2B8", Offset = "0x11EC2B8", VA = "0x11EC2B8")]
		private static Vector3 GetChildCentroid(Transform t, Vector3 fallback)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x11EAC20", Offset = "0x11EAC20", VA = "0x11EAC20")]
		private static void MassDistribution(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x11EB084", Offset = "0x11EB084", VA = "0x11EB084")]
		private static void CreateJoints(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x11EC468", Offset = "0x11EC468", VA = "0x11EC468")]
		private static void CreateLimbJoints(Transform connectedBone, Transform bone1, Transform bone2, Transform bone3, Transform root, Vector3 defaultWorldDirection, JointType jointType, CreateJointParams.Limits limits1, CreateJointParams.Limits limits2, CreateJointParams.Limits limits3)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x11ECB6C", Offset = "0x11ECB6C", VA = "0x11ECB6C")]
		public static void ClearBipedRagdoll(BipedRagdollReferences r)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x11ECF24", Offset = "0x11ECF24", VA = "0x11ECF24")]
		public static bool IsClear(BipedRagdollReferences r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x11EB8A8", Offset = "0x11EB8A8", VA = "0x11EB8A8")]
		private static Vector3 GetUpperArmToHeadCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x11E95FC", Offset = "0x11E95FC", VA = "0x11E95FC")]
		private static Vector3 GetUpperArmCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x11ED020", Offset = "0x11ED020", VA = "0x11ED020")]
		public BipedRagdollCreator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000033")]
	public struct BipedRagdollReferences
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform root;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform hips;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform spine;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform chest;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform head;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftUpperLeg;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftLowerLeg;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform leftFoot;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightUpperLeg;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightLowerLeg;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightFoot;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftLowerArm;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform leftHand;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightLowerArm;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform rightHand;

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x11E9814", Offset = "0x11E9814", VA = "0x11E9814")]
		public bool IsValid(ref string msg)
		{
			return default(bool);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x11ED05C", Offset = "0x11ED05C", VA = "0x11ED05C")]
		private bool IsChildRecursive(Transform t, Transform parent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x11ED16C", Offset = "0x11ED16C", VA = "0x11ED16C")]
		public bool IsEmpty(bool considerRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x11ED508", Offset = "0x11ED508", VA = "0x11ED508")]
		public bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x11ECBE4", Offset = "0x11ECBE4", VA = "0x11ECBE4")]
		public Transform[] GetRagdollTransforms()
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x11ED8A8", Offset = "0x11ED8A8", VA = "0x11ED8A8")]
		public static BipedRagdollReferences FromAvatar(Animator animator)
		{
			return default(BipedRagdollReferences);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x11EDAC4", Offset = "0x11EDAC4", VA = "0x11EDAC4")]
		public static BipedRagdollReferences FromBipedReferences(BipedReferences biped)
		{
			return default(BipedRagdollReferences);
		}
	}
	[Token(Token = "0x2000034")]
	public static class JointConverter
	{
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x18F6254", Offset = "0x18F6254", VA = "0x18F6254")]
		public static void ToConfigurable(GameObject root)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x18F6730", Offset = "0x18F6730", VA = "0x18F6730")]
		public static void HingeToConfigurable(HingeJoint src)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x18F69E4", Offset = "0x18F69E4", VA = "0x18F69E4")]
		public static void FixedToConfigurable(FixedJoint src)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x18F6B30", Offset = "0x18F6B30", VA = "0x18F6B30")]
		public static void SpringToConfigurable(SpringJoint src)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x18F64F0", Offset = "0x18F64F0", VA = "0x18F64F0")]
		public static void CharacterToConfigurable(CharacterJoint src)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x18F6CD8", Offset = "0x18F6CD8", VA = "0x18F6CD8")]
		private static void ConvertJoint(ref ConfigurableJoint conf, Joint src)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x18F6E10", Offset = "0x18F6E10", VA = "0x18F6E10")]
		private static SoftJointLimit ConvertToHighSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x18F6ECC", Offset = "0x18F6ECC", VA = "0x18F6ECC")]
		private static SoftJointLimit ConvertToLowSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x18F6E74", Offset = "0x18F6E74", VA = "0x18F6E74")]
		private static SoftJointLimitSpring ConvertToSoftJointLimitSpring(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimitSpring);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x18F6F30", Offset = "0x18F6F30", VA = "0x18F6F30")]
		private static SoftJointLimit CopyLimit(SoftJointLimit src)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x18F6F90", Offset = "0x18F6F90", VA = "0x18F6F90")]
		private static SoftJointLimitSpring CopyLimitSpring(SoftJointLimitSpring src)
		{
			return default(SoftJointLimitSpring);
		}
	}
	[Token(Token = "0x2000035")]
	public abstract class RagdollCreator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010B")]
		public enum ColliderType
		{
			[Token(Token = "0x400076C")]
			Box,
			[Token(Token = "0x400076D")]
			Capsule
		}

		[Serializable]
		[Token(Token = "0x200010C")]
		public enum JointType
		{
			[Token(Token = "0x400076F")]
			Configurable,
			[Token(Token = "0x4000770")]
			Character
		}

		[Serializable]
		[Token(Token = "0x200010D")]
		public enum Direction
		{
			[Token(Token = "0x4000772")]
			X,
			[Token(Token = "0x4000773")]
			Y,
			[Token(Token = "0x4000774")]
			Z
		}

		[Token(Token = "0x200010E")]
		public struct CreateJointParams
		{
			[Token(Token = "0x2000167")]
			public struct Limits
			{
				[Token(Token = "0x40009C4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public float minSwing;

				[Token(Token = "0x40009C5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public float maxSwing;

				[Token(Token = "0x40009C6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public float swing2;

				[Token(Token = "0x40009C7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public float twist;

				[Token(Token = "0x60009B3")]
				[Address(RVA = "0x14756C8", Offset = "0x14756C8", VA = "0x14756C8")]
				public Limits(float minSwing, float maxSwing, float swing2, float twist)
				{
				}
			}

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rigidbody rigidbody;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Rigidbody connectedBody;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform child;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 worldSwingAxis;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Limits limits;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public JointType type;

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x14756A8", Offset = "0x14756A8", VA = "0x14756A8")]
			public CreateJointParams(Rigidbody rigidbody, Rigidbody connectedBody, Transform child, Vector3 worldSwingAxis, Limits limits, JointType type)
			{
			}
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1473BAC", Offset = "0x1473BAC", VA = "0x1473BAC")]
		public static void ClearAll(Transform root)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1473DAC", Offset = "0x1473DAC", VA = "0x1473DAC")]
		protected static void ClearTransform(Transform transform)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1473FE0", Offset = "0x1473FE0", VA = "0x1473FE0")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x147455C", Offset = "0x147455C", VA = "0x147455C")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width, float proportionAspect, Vector3 widthDirection)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x14743D4", Offset = "0x14743D4", VA = "0x14743D4")]
		protected static float GetScaleF(Transform t)
		{
			return default(float);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1474954", Offset = "0x1474954", VA = "0x1474954")]
		protected static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1474984", Offset = "0x1474984", VA = "0x1474984")]
		protected static void Vector3Abs(ref Vector3 v)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1474A04", Offset = "0x1474A04", VA = "0x1474A04")]
		protected static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1474ABC", Offset = "0x1474ABC", VA = "0x1474ABC")]
		protected static Vector3 DirectionToVector3(Direction dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1474404", Offset = "0x1474404", VA = "0x1474404")]
		protected static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1474B74", Offset = "0x1474B74", VA = "0x1474B74")]
		protected static Vector3 GetLocalOrthoDirection(Transform transform, Vector3 worldDir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1474E8C", Offset = "0x1474E8C", VA = "0x1474E8C")]
		protected static Rigidbody GetConnectedBody(Transform bone, ref Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x147504C", Offset = "0x147504C", VA = "0x147504C")]
		protected static void CreateJoint(CreateJointParams p)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x147566C", Offset = "0x147566C", VA = "0x147566C")]
		private static SoftJointLimit ToSoftJointLimit(float limit)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x14756A0", Offset = "0x14756A0", VA = "0x14756A0")]
		protected RagdollCreator()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B96FC", Offset = "0x9B96FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B96FC", Offset = "0x9B96FC")]
	public class RagdollEditor : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010F")]
		public enum Mode
		{
			[Token(Token = "0x400077C")]
			Colliders,
			[Token(Token = "0x400077D")]
			Joints
		}

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Rigidbody selectedRigidbody;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Collider selectedCollider;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool symmetry;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public Mode mode;

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x14756D4", Offset = "0x14756D4", VA = "0x14756D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C584C", Offset = "0x9C584C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1475720", Offset = "0x1475720", VA = "0x1475720")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5884", Offset = "0x9C5884")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x147576C", Offset = "0x147576C", VA = "0x147576C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C58BC", Offset = "0x9C58BC")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x14757B8", Offset = "0x14757B8", VA = "0x14757B8")]
		public RagdollEditor()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000037")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x12533A4", Offset = "0x12533A4", VA = "0x12533A4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x1253428", Offset = "0x1253428", VA = "0x1253428")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC690", Offset = "0x9BC690")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1253430", Offset = "0x1253430", VA = "0x1253430")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1253538", Offset = "0x1253538", VA = "0x1253538")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC6C8", Offset = "0x9BC6C8")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC700", Offset = "0x9BC700")]
		public AimIK aim;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC738", Offset = "0x9BC738")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC770", Offset = "0x9BC770")]
		public Animator animator;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC7A8", Offset = "0x9BC7A8")]
		public float crossfadeTime;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC7E0", Offset = "0x9BC7E0")]
		public float minAimDistance;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x11DDCA0", Offset = "0x11DDCA0", VA = "0x11DDCA0")]
		private void Start()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x11DDCE4", Offset = "0x11DDCE4", VA = "0x11DDCE4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x11DDE38", Offset = "0x11DDE38", VA = "0x11DDE38")]
		private void Pose()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x11DE03C", Offset = "0x11DE03C", VA = "0x11DE03C")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x11DE234", Offset = "0x11DE234", VA = "0x11DE234")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x11DE30C", Offset = "0x11DE30C", VA = "0x11DE30C")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x11DF54C", Offset = "0x11DF54C", VA = "0x11DF54C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x11DF7B0", Offset = "0x11DF7B0", VA = "0x11DF7B0")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x11DFA00", Offset = "0x11DFA00", VA = "0x11DFA00")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BC818", Offset = "0x9BC818")]
		public Animator animator;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BC850", Offset = "0x9BC850")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC888", Offset = "0x9BC888")]
		public float lookAtWeight;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC8A0", Offset = "0x9BC8A0")]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC8B8", Offset = "0x9BC8B8")]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC8D0", Offset = "0x9BC8D0")]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC8E8", Offset = "0x9BC8E8")]
		public float lookAtClampWeight;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC900", Offset = "0x9BC900")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC918", Offset = "0x9BC918")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BC930", Offset = "0x9BC930")]
		public Transform footTargetBiped;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC968", Offset = "0x9BC968")]
		public float footPositionWeight;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC980", Offset = "0x9BC980")]
		public float footRotationWeight;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BC998", Offset = "0x9BC998")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC9D0", Offset = "0x9BC9D0")]
		public float handPositionWeight;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC9E8", Offset = "0x9BC9E8")]
		public float handRotationWeight;

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x12554C8", Offset = "0x12554C8", VA = "0x12554C8")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1255974", Offset = "0x1255974", VA = "0x1255974")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1261920", Offset = "0x1261920", VA = "0x1261920")]
		private void Update()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1262354", Offset = "0x1262354", VA = "0x1262354")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x126203C", Offset = "0x126203C", VA = "0x126203C")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x12624FC", Offset = "0x12624FC", VA = "0x12624FC")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x17000043")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x1262528", Offset = "0x1262528", VA = "0x1262528")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x12625C8", Offset = "0x12625C8", VA = "0x12625C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1262860", Offset = "0x1262860", VA = "0x1262860")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA780", Offset = "0x9BA780")]
		private sealed class <Step>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007F5")]
				[Address(RVA = "0x126349C", Offset = "0x126349C", VA = "0x126349C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007F7")]
				[Address(RVA = "0x1263504", Offset = "0x1263504", VA = "0x1263504", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x126312C", Offset = "0x126312C", VA = "0x126312C")]
			[DebuggerHidden]
			public <Step>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x1263188", Offset = "0x1263188", VA = "0x1263188", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x126318C", Offset = "0x126318C", VA = "0x126318C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x12634A4", Offset = "0x12634A4", VA = "0x12634A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ParticleSystem sand;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IK ik;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float stepProgress;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lastStepTime;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit hit;

		[Token(Token = "0x17000044")]
		public bool isStepping
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x1262874", Offset = "0x1262874", VA = "0x1262874")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		public Vector3 position
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x12624C8", Offset = "0x12624C8", VA = "0x12624C8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x1262888", Offset = "0x1262888", VA = "0x1262888")]
			set
			{
			}
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x12628D8", Offset = "0x12628D8", VA = "0x12628D8")]
		private void Start()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1262A94", Offset = "0x1262A94", VA = "0x1262A94")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1262E64", Offset = "0x1262E64", VA = "0x1262E64")]
		private void Update()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1263080", Offset = "0x1263080", VA = "0x1263080")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C58F4", Offset = "0x9C58F4")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1263158", Offset = "0x1263158", VA = "0x1263158")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x11D7FE8", Offset = "0x11D7FE8", VA = "0x11D7FE8")]
		private void Start()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x11D8094", Offset = "0x11D8094", VA = "0x11D8094")]
		private void Update()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x11D832C", Offset = "0x11D832C", VA = "0x11D832C")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000111")]
		public struct Warp
		{
			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1BDC", Offset = "0x9C1BDC")]
			public int animationLayer;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1C14", Offset = "0x9C1C14")]
			public string animationState;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1C4C", Offset = "0x9C1C4C")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1C84", Offset = "0x9C1C84")]
			public Transform warpFrom;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1CBC", Offset = "0x9C1CBC")]
			public Transform warpTo;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1CF4", Offset = "0x9C1CF4")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x2000112")]
		public enum EffectorMode
		{
			[Token(Token = "0x400078A")]
			PositionOffset,
			[Token(Token = "0x400078B")]
			Position
		}

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BCA00", Offset = "0x9BCA00")]
		public Animator animator;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BCA38", Offset = "0x9BCA38")]
		public EffectorMode effectorMode;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9BCA70", Offset = "0x9BCA70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BCA70", Offset = "0x9BCA70")]
		public Warp[] warps;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x12535B0", Offset = "0x12535B0", VA = "0x12535B0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x12535DC", Offset = "0x12535DC", VA = "0x12535DC")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x12537E4", Offset = "0x12537E4", VA = "0x12537E4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1253B98", Offset = "0x1253B98", VA = "0x1253B98")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1253C38", Offset = "0x1253C38", VA = "0x1253C38")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B975C", Offset = "0x9B975C")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1253C40", Offset = "0x1253C40", VA = "0x1253C40", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1253C98", Offset = "0x1253C98", VA = "0x1253C98")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1253ED0", Offset = "0x1253ED0", VA = "0x1253ED0", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1254134", Offset = "0x1254134", VA = "0x1254134")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B97C0", Offset = "0x9B97C0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B97C0", Offset = "0x9B97C0")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BCAC0", Offset = "0x9BCAC0")]
		public float headLookWeight;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1254148", Offset = "0x1254148", VA = "0x1254148", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x12542B4", Offset = "0x12542B4", VA = "0x12542B4", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1254328", Offset = "0x1254328", VA = "0x1254328")]
		private void Read()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1254480", Offset = "0x1254480", VA = "0x1254480")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x12544C8", Offset = "0x12544C8", VA = "0x12544C8")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1254AC0", Offset = "0x1254AC0", VA = "0x1254AC0")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1254884", Offset = "0x1254884", VA = "0x1254884")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1254E18", Offset = "0x1254E18", VA = "0x1254E18")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1254F10", Offset = "0x1254F10", VA = "0x1254F10")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B984C", Offset = "0x9B984C")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1256B64", Offset = "0x1256B64", VA = "0x1256B64", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1256BC4", Offset = "0x1256BC4", VA = "0x1256BC4", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1256E88", Offset = "0x1256E88", VA = "0x1256E88")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1257040", Offset = "0x1257040", VA = "0x1257040")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B98B0", Offset = "0x9B98B0")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CameraController cam;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x17000046")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x1257E74", Offset = "0x1257E74", VA = "0x1257E74")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000047")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x1257F14", Offset = "0x1257F14", VA = "0x1257F14")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1257BC0", Offset = "0x1257BC0", VA = "0x1257BC0")]
		private void Start()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1257C30", Offset = "0x1257C30", VA = "0x1257C30")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1257FB4", Offset = "0x1257FB4", VA = "0x1257FB4")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BCAE8", Offset = "0x9BCAE8")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x125BA7C", Offset = "0x125BA7C", VA = "0x125BA7C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x125C060", Offset = "0x125C060", VA = "0x125C060")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x125C068", Offset = "0x125C068", VA = "0x125C068")]
		private void Start()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x125C108", Offset = "0x125C108", VA = "0x125C108")]
		private void Update()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x125C584", Offset = "0x125C584", VA = "0x125C584")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x125C630", Offset = "0x125C630", VA = "0x125C630")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000113")]
		public class Limb
		{
			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x125C804", Offset = "0x125C804", VA = "0x125C804")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x125C938", Offset = "0x125C938", VA = "0x125C938")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x125C6B8", Offset = "0x125C6B8", VA = "0x125C6B8")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x125C888", Offset = "0x125C888", VA = "0x125C888")]
		private void Start()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x125C924", Offset = "0x125C924", VA = "0x125C924")]
		private void Update()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x125C928", Offset = "0x125C928", VA = "0x125C928")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x125C948", Offset = "0x125C948", VA = "0x125C948")]
		private void Start()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x125C9B4", Offset = "0x125C9B4", VA = "0x125C9B4")]
		private void Update()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x125CA8C", Offset = "0x125CA8C", VA = "0x125CA8C")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BCB00", Offset = "0x9BCB00")]
		public Transform target;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BCB38", Offset = "0x9BCB38")]
		public Transform pin;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BCB70", Offset = "0x9BCB70")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BCBA8", Offset = "0x9BCBA8")]
		public AimIK aim;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BCBE0", Offset = "0x9BCBE0")]
		public float weight;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BCC18", Offset = "0x9BCC18")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BCC50", Offset = "0x9BCC50")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x125CA94", Offset = "0x125CA94", VA = "0x125CA94")]
		private void Start()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x125CAEC", Offset = "0x125CAEC", VA = "0x125CAEC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x125CC88", Offset = "0x125CC88", VA = "0x125CC88")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x125CC90", Offset = "0x125CC90", VA = "0x125CC90")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x125CD50", Offset = "0x125CD50", VA = "0x125CD50")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x125CDDC", Offset = "0x125CDDC", VA = "0x125CDDC")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x125D270", Offset = "0x125D270", VA = "0x125D270")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x125D368", Offset = "0x125D368", VA = "0x125D368")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BCC88", Offset = "0x9BCC88")]
		public float aimWeight;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BCCA0", Offset = "0x9BCCA0")]
		public float sightWeight;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BCCB8", Offset = "0x9BCCB8")]
		public float maxAngle;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform gunTarget;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AimIK gunAim;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Recoil recoil;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BCD44", Offset = "0x9BCD44")]
		private float cameraRecoilWeight;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool updateFrame;

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x125D370", Offset = "0x125D370", VA = "0x125D370")]
		private void Start()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x125D4D0", Offset = "0x125D4D0", VA = "0x125D4D0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x125D4DC", Offset = "0x125D4DC", VA = "0x125D4DC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x125D81C", Offset = "0x125D81C", VA = "0x125D81C")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x125D9F0", Offset = "0x125D9F0", VA = "0x125D9F0")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x125D5A0", Offset = "0x125D5A0", VA = "0x125D5A0")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x125E3FC", Offset = "0x125E3FC", VA = "0x125E3FC")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B9914", Offset = "0x9B9914")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B9914", Offset = "0x9B9914")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BCD84", Offset = "0x9BCD84")]
		public float walkSpeed;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x125E41C", Offset = "0x125E41C", VA = "0x125E41C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x125E48C", Offset = "0x125E48C", VA = "0x125E48C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x125E5B0", Offset = "0x125E5B0", VA = "0x125E5B0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x125E660", Offset = "0x125E660", VA = "0x125E660")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReaction hitReaction;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x125F328", Offset = "0x125F328", VA = "0x125F328")]
		private void Update()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x125F4E8", Offset = "0x125F4E8", VA = "0x125F4E8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x125F6AC", Offset = "0x125F6AC", VA = "0x125F6AC")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x125FA50", Offset = "0x125FA50", VA = "0x125FA50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x125FBFC", Offset = "0x125FBFC", VA = "0x125FBFC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x125FFB8", Offset = "0x125FFB8", VA = "0x125FFB8")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x125FFC8", Offset = "0x125FFC8", VA = "0x125FFC8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x12600FC", Offset = "0x12600FC", VA = "0x12600FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x126024C", Offset = "0x126024C", VA = "0x126024C")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1260254", Offset = "0x1260254", VA = "0x1260254")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1260924", Offset = "0x1260924", VA = "0x1260924")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B99A0", Offset = "0x9B99A0")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BCDBC", Offset = "0x9BCDBC")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BCE08", Offset = "0x9BCE08")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x126092C", Offset = "0x126092C", VA = "0x126092C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1260984", Offset = "0x1260984", VA = "0x1260984")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1260C90", Offset = "0x1260C90", VA = "0x1260C90")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000114")]
		public class Partner
		{
			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000BB")]
			private Transform neck
			{
				[Token(Token = "0x60007FC")]
				[Address(RVA = "0x12616B0", Offset = "0x12616B0", VA = "0x12616B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x1260DE8", Offset = "0x1260DE8", VA = "0x1260DE8")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x1260E68", Offset = "0x1260E68", VA = "0x1260E68")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x12614D4", Offset = "0x12614D4", VA = "0x12614D4")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x1261708", Offset = "0x1261708", VA = "0x1261708")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1260DB4", Offset = "0x1260DB4", VA = "0x1260DB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1260E08", Offset = "0x1260E08", VA = "0x1260E08")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x12614C4", Offset = "0x12614C4", VA = "0x12614C4")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000115")]
		public enum Mode
		{
			[Token(Token = "0x400079B")]
			Position,
			[Token(Token = "0x400079C")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x2000116")]
		public class Absorber
		{
			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1D2C", Offset = "0x9C1D2C")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1D64", Offset = "0x9C1D64")]
			public float weight;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x11D8494", Offset = "0x11D8494", VA = "0x11D8494")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000800")]
			[Address(RVA = "0x11D8674", Offset = "0x11D8674", VA = "0x11D8674")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000801")]
			[Address(RVA = "0x11D86B0", Offset = "0x11D86B0", VA = "0x11D86B0")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000802")]
			[Address(RVA = "0x11D8860", Offset = "0x11D8860", VA = "0x11D8860")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000803")]
			[Address(RVA = "0x11D8A84", Offset = "0x11D8A84", VA = "0x11D8A84")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BCE54", Offset = "0x9BCE54")]
		public Mode mode;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BCE8C", Offset = "0x9BCE8C")]
		public Absorber[] absorbers;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BCEC4", Offset = "0x9BCEC4")]
		public AnimationCurve falloff;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BCEFC", Offset = "0x9BCEFC")]
		public float falloffSpeed;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x11D8334", Offset = "0x11D8334", VA = "0x11D8334", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x11D8408", Offset = "0x11D8408", VA = "0x11D8408")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x11D8568", Offset = "0x11D8568", VA = "0x11D8568", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x11D87D8", Offset = "0x11D87D8", VA = "0x11D87D8")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x11D8970", Offset = "0x11D8970", VA = "0x11D8970", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x11D8A74", Offset = "0x11D8A74", VA = "0x11D8A74")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x11D8B04", Offset = "0x11D8B04", VA = "0x11D8B04")]
		private void Start()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x11D8B7C", Offset = "0x11D8B7C", VA = "0x11D8B7C")]
		private void Update()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x11D8C30", Offset = "0x11D8C30", VA = "0x11D8C30")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x11D8D90", Offset = "0x11D8D90", VA = "0x11D8D90")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000117")]
		public class EffectorLink
		{
			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x11D90D8", Offset = "0x11D90D8", VA = "0x11D90D8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x11D8DA4", Offset = "0x11D8DA4", VA = "0x11D8DA4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x11D8EA4", Offset = "0x11D8EA4", VA = "0x11D8EA4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x11D90D0", Offset = "0x11D90D0", VA = "0x11D90D0")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B9A04", Offset = "0x9B9A04")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BCF34", Offset = "0x9BCF34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BCF34", Offset = "0x9BCF34")]
		public float weight;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BCF88", Offset = "0x9BCF88")]
		public float hangingDistanceMlp;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BCFC0", Offset = "0x9BCFC0")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD00C", Offset = "0x9BD00C")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform leftHandTarget;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform rightHandTarget;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform leftFootTarget;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform headTarget;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x11D90E8", Offset = "0x11D90E8", VA = "0x11D90E8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x11D9424", Offset = "0x11D9424", VA = "0x11D9424")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x11D9B74", Offset = "0x11D9B74", VA = "0x11D9B74")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x17000048")]
		private bool holding
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x11D9EB8", Offset = "0x11D9EB8", VA = "0x11D9EB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x11D9BF8", Offset = "0x11D9BF8", VA = "0x11D9BF8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000327")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x11D9ED8", Offset = "0x11D9ED8", VA = "0x11D9ED8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x11DA040", Offset = "0x11DA040", VA = "0x11DA040")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x11DA1BC", Offset = "0x11DA1BC", VA = "0x11DA1BC")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x11DA29C", Offset = "0x11DA29C", VA = "0x11DA29C")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x11DA3C8", Offset = "0x11DA3C8", VA = "0x11DA3C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x11DA5D8", Offset = "0x11DA5D8", VA = "0x11DA5D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x11DA778", Offset = "0x11DA778", VA = "0x11DA778")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x11DA78C", Offset = "0x11DA78C", VA = "0x11DA78C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x11DA980", Offset = "0x11DA980", VA = "0x11DA980")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x11DA994", Offset = "0x11DA994", VA = "0x11DA994", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x11DAB40", Offset = "0x11DAB40", VA = "0x11DAB40")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x11DC558", Offset = "0x11DC558", VA = "0x11DC558")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x11DC630", Offset = "0x11DC630", VA = "0x11DC630")]
		private void Update()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x11DC7D8", Offset = "0x11DC7D8", VA = "0x11DC7D8")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B9A68", Offset = "0x9B9A68")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x11DCAD0", Offset = "0x11DCAD0", VA = "0x11DCAD0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x11DCB28", Offset = "0x11DCB28", VA = "0x11DCB28")]
		private void Update()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x11DCB84", Offset = "0x11DCB84", VA = "0x11DCB84")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x11DCC5C", Offset = "0x11DCC5C", VA = "0x11DCC5C")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA790", Offset = "0x9BA790")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000BC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000808")]
				[Address(RVA = "0x11DCFD0", Offset = "0x11DCFD0", VA = "0x11DCFD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600080A")]
				[Address(RVA = "0x11DD038", Offset = "0x11DD038", VA = "0x11DD038", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000805")]
			[Address(RVA = "0x11DCDEC", Offset = "0x11DCDEC", VA = "0x11DCDEC")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000806")]
			[Address(RVA = "0x11DCE28", Offset = "0x11DCE28", VA = "0x11DCE28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000807")]
			[Address(RVA = "0x11DCE2C", Offset = "0x11DCE2C", VA = "0x11DCE2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000809")]
			[Address(RVA = "0x11DCFD8", Offset = "0x11DCFD8", VA = "0x11DCFD8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x11DCC6C", Offset = "0x11DCC6C", VA = "0x11DCC6C")]
		private void Start()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x11DCD24", Offset = "0x11DCD24", VA = "0x11DCD24")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x11DCD6C", Offset = "0x11DCD6C", VA = "0x11DCD6C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C5958", Offset = "0x9C5958")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x11DCE18", Offset = "0x11DCE18", VA = "0x11DCE18")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B9ACC", Offset = "0x9B9ACC")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000119")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA7A0", Offset = "0x9BA7A0")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000BE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600080E")]
				[Address(RVA = "0x11DF4DC", Offset = "0x11DF4DC", VA = "0x11DF4DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000810")]
				[Address(RVA = "0x11DF544", Offset = "0x11DF544", VA = "0x11DF544", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600080B")]
			[Address(RVA = "0x11DF384", Offset = "0x11DF384", VA = "0x11DF384")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600080C")]
			[Address(RVA = "0x11DF3B8", Offset = "0x11DF3B8", VA = "0x11DF3B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600080D")]
			[Address(RVA = "0x11DF3BC", Offset = "0x11DF3BC", VA = "0x11DF3BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600080F")]
			[Address(RVA = "0x11DF4E4", Offset = "0x11DF4E4", VA = "0x11DF4E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x11DF264", Offset = "0x11DF264", VA = "0x11DF264")]
		private void Start()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x11DF314", Offset = "0x11DF314", VA = "0x11DF314")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C59BC", Offset = "0x9C59BC")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x11DF3B0", Offset = "0x11DF3B0", VA = "0x11DF3B0")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200011A")]
		public class EffectorLink
		{
			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x6000811")]
			[Address(RVA = "0x11DFAEC", Offset = "0x11DFAEC", VA = "0x11DFAEC")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000812")]
			[Address(RVA = "0x11E0774", Offset = "0x11E0774", VA = "0x11E0774")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000813")]
			[Address(RVA = "0x11DFE2C", Offset = "0x11DFE2C", VA = "0x11DFE2C")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000814")]
			[Address(RVA = "0x11E085C", Offset = "0x11E085C", VA = "0x11E085C")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000815")]
			[Address(RVA = "0x11E09F8", Offset = "0x11E09F8", VA = "0x11E09F8")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000816")]
			[Address(RVA = "0x11E0A94", Offset = "0x11E0A94", VA = "0x11E0A94")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0x11E0B2C", Offset = "0x11E0B2C", VA = "0x11E0B2C")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000818")]
			[Address(RVA = "0x11E060C", Offset = "0x11E060C", VA = "0x11E060C")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0x11E0BC4", Offset = "0x11E0BC4", VA = "0x11E0BC4")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x11DFA74", Offset = "0x11DFA74", VA = "0x11DFA74")]
		private void Start()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x11DFDC0", Offset = "0x11DFDC0", VA = "0x11DFDC0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x11E0544", Offset = "0x11E0544", VA = "0x11E0544")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x11E076C", Offset = "0x11E076C", VA = "0x11E076C")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD0F8", Offset = "0x9BD0F8")]
		public Transform to;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD130", Offset = "0x9BD130")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BD130", Offset = "0x9BD130")]
		public float transferMotion;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x11E0BF8", Offset = "0x11E0BF8", VA = "0x11E0BF8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x11E0C34", Offset = "0x11E0C34", VA = "0x11E0C34")]
		private void Update()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x11E0D8C", Offset = "0x11E0D8C", VA = "0x11E0D8C")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD184", Offset = "0x9BD184")]
		public Transform leftHandTarget;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x11E0F4C", Offset = "0x11E0F4C", VA = "0x11E0F4C")]
		private void Start()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x11E1104", Offset = "0x11E1104", VA = "0x11E1104")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x11E13A0", Offset = "0x11E13A0", VA = "0x11E13A0")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x11E146C", Offset = "0x11E146C", VA = "0x11E146C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x11E1564", Offset = "0x11E1564", VA = "0x11E1564")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x11E1CD0", Offset = "0x11E1CD0", VA = "0x11E1CD0", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x11E2148", Offset = "0x11E2148", VA = "0x11E2148")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x11E23A0", Offset = "0x11E23A0", VA = "0x11E23A0")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x125EFA4", Offset = "0x125EFA4", VA = "0x125EFA4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x125F2A0", Offset = "0x125F2A0", VA = "0x125F2A0")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x125F320", Offset = "0x125F320", VA = "0x125F320")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x200011B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA7B0", Offset = "0x9BA7B0")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000C0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600081D")]
				[Address(RVA = "0x11DB5A4", Offset = "0x11DB5A4", VA = "0x11DB5A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600081F")]
				[Address(RVA = "0x11DB60C", Offset = "0x11DB60C", VA = "0x11DB60C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600081A")]
			[Address(RVA = "0x11DB260", Offset = "0x11DB260", VA = "0x11DB260")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600081B")]
			[Address(RVA = "0x11DB46C", Offset = "0x11DB46C", VA = "0x11DB46C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600081C")]
			[Address(RVA = "0x11DB470", Offset = "0x11DB470", VA = "0x11DB470", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600081E")]
			[Address(RVA = "0x11DB5AC", Offset = "0x11DB5AC", VA = "0x11DB5AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x11DAEAC", Offset = "0x11DAEAC", VA = "0x11DAEAC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x11DB038", Offset = "0x11DB038", VA = "0x11DB038")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x11DAFC8", Offset = "0x11DAFC8", VA = "0x11DAFC8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C5A20", Offset = "0x9C5A20")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x11DB28C", Offset = "0x11DB28C", VA = "0x11DB28C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x11DB370", Offset = "0x11DB370", VA = "0x11DB370")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x11DB450", Offset = "0x11DB450", VA = "0x11DB450")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BD1EC", Offset = "0x9BD1EC")]
		public float weight;

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1255390", Offset = "0x1255390", VA = "0x1255390")]
		private void Start()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x12553FC", Offset = "0x12553FC", VA = "0x12553FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x12554B8", Offset = "0x12554B8", VA = "0x12554B8")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200011C")]
		public class Part
		{
			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x11E0E18", Offset = "0x11E0E18", VA = "0x11E0E18")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000821")]
			[Address(RVA = "0x11E0F44", Offset = "0x11E0F44", VA = "0x11E0F44")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x11E0DA0", Offset = "0x11E0DA0", VA = "0x11E0DA0")]
		private void Update()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x11E0F3C", Offset = "0x11E0F3C", VA = "0x11E0F3C")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReactionVRIK hitReaction;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x125F6BC", Offset = "0x125F6BC", VA = "0x125F6BC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x125F87C", Offset = "0x125F87C", VA = "0x125F87C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x125FA40", Offset = "0x125FA40", VA = "0x125FA40")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD224", Offset = "0x9BD224")]
		public VRIK ik;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD25C", Offset = "0x9BD25C")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD294", Offset = "0x9BD294")]
		public Transform headTracker;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD2CC", Offset = "0x9BD2CC")]
		public Transform bodyTracker;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD304", Offset = "0x9BD304")]
		public Transform leftHandTracker;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD33C", Offset = "0x9BD33C")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD374", Offset = "0x9BD374")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD3AC", Offset = "0x9BD3AC")]
		public Transform rightFootTracker;

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x11E2440", Offset = "0x11E2440", VA = "0x11E2440")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x11E247C", Offset = "0x11E247C", VA = "0x11E247C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5A84", Offset = "0x9C5A84")]
		private void Calibrate()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x11E24B0", Offset = "0x11E24B0", VA = "0x11E24B0")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x11E24B8", Offset = "0x11E24B8", VA = "0x11E24B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x11E2514", Offset = "0x11E2514", VA = "0x11E2514")]
		private void Update()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x11E2728", Offset = "0x11E2728", VA = "0x11E2728")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B9B30", Offset = "0x9B9B30")]
	public class AnimatorIKDemo : MonoBehaviour
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftHandIKTarget;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1254F2C", Offset = "0x1254F2C", VA = "0x1254F2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x1254F84", Offset = "0x1254F84", VA = "0x1254F84")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1254FE0", Offset = "0x1254FE0", VA = "0x1254FE0")]
		public AnimatorIKDemo()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class BallShooter : MonoBehaviour
	{
		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode keyCode;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject ball;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 spawnOffset;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 force;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float mass;

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x125502C", Offset = "0x125502C", VA = "0x125502C")]
		private void Update()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x12552F4", Offset = "0x12552F4", VA = "0x12552F4")]
		public BallShooter()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class CharacterAnimationMeleeDemo : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x17000049")]
		private CharacterMeleeDemo melee
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x1255F74", Offset = "0x1255F74", VA = "0x1255F74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1255FF8", Offset = "0x1255FF8", VA = "0x1255FF8", Slot = "9")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x12564B8", Offset = "0x12564B8", VA = "0x12564B8")]
		public CharacterAnimationMeleeDemo()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class CharacterMeleeDemo : CharacterPuppet
	{
		[Serializable]
		[Token(Token = "0x200011D")]
		public class Action
		{
			[Serializable]
			[Token(Token = "0x2000168")]
			public class Anim
			{
				[Token(Token = "0x40009C8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string stateName;

				[Token(Token = "0x40009C9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public int layer;

				[Token(Token = "0x40009CA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public float transitionDuration;

				[Token(Token = "0x40009CB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public float fixedTime;

				[Token(Token = "0x60009B4")]
				[Address(RVA = "0x1258564", Offset = "0x1258564", VA = "0x1258564")]
				public Anim()
				{
				}
			}

			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int inputActionIndex;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float duration;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float minFrequency;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Anim anim;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int[] requiredPropTypes;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Booster[] boosters;

			[Token(Token = "0x6000822")]
			[Address(RVA = "0x1258554", Offset = "0x1258554", VA = "0x1258554")]
			public Action()
			{
			}
		}

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BD3E4", Offset = "0x9BD3E4")]
		public Action[] actions;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[HideInInspector]
		public int currentActionIndex;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		[HideInInspector]
		public float lastActionTime;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private float lastActionMoveMag;

		[Token(Token = "0x1700004A")]
		public Action currentAction
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x125646C", Offset = "0x125646C", VA = "0x125646C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1257FBC", Offset = "0x1257FBC", VA = "0x1257FBC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1258044", Offset = "0x1258044", VA = "0x1258044", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x12582CC", Offset = "0x12582CC", VA = "0x12582CC")]
		private bool StartAction(Action action)
		{
			return default(bool);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1258544", Offset = "0x1258544", VA = "0x1258544")]
		public CharacterMeleeDemo()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class CharacterPuppet : CharacterThirdPerson
	{
		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BD43C", Offset = "0x9BD43C")]
		public PropRoot propRoot;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD474", Offset = "0x9BD474")]
		private BehaviourPuppet <puppet>k__BackingField;

		[Token(Token = "0x1700004B")]
		public BehaviourPuppet puppet
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x125856C", Offset = "0x125856C", VA = "0x125856C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5ABC", Offset = "0x9C5ABC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x1258574", Offset = "0x1258574", VA = "0x1258574")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5ACC", Offset = "0x9C5ACC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1257FC8", Offset = "0x1257FC8", VA = "0x1257FC8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1258700", Offset = "0x1258700", VA = "0x1258700", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1258940", Offset = "0x1258940", VA = "0x1258940", Slot = "9")]
		protected override void Rotate()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1259008", Offset = "0x1259008", VA = "0x1259008", Slot = "10")]
		protected override bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1258550", Offset = "0x1258550", VA = "0x1258550")]
		public CharacterPuppet()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class CreatePuppetInRuntime : MonoBehaviour
	{
		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD484", Offset = "0x9BD484")]
		public Transform ragdollPrefab;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD4BC", Offset = "0x9BD4BC")]
		public string instanceName;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD4F4", Offset = "0x9BD4F4")]
		public int characterControllerLayer;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD52C", Offset = "0x9BD52C")]
		public int ragdollLayer;

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x125AE4C", Offset = "0x125AE4C", VA = "0x125AE4C")]
		private void Start()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x125AFA4", Offset = "0x125AFA4", VA = "0x125AFA4")]
		public CreatePuppetInRuntime()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class CreateRagdollInRuntime : MonoBehaviour
	{
		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD564", Offset = "0x9BD564")]
		public GameObject prefab;

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x125AFFC", Offset = "0x125AFFC", VA = "0x125AFFC")]
		private void Start()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x125B140", Offset = "0x125B140", VA = "0x125B140")]
		private void Update()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x125B144", Offset = "0x125B144", VA = "0x125B144")]
		public CreateRagdollInRuntime()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class Destructor : MonoBehaviour
	{
		[Token(Token = "0x200011E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA7C0", Offset = "0x9BA7C0")]
		private sealed class <Destruct>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Destructor <>4__this;

			[Token(Token = "0x170000C2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000826")]
				[Address(RVA = "0x125B314", Offset = "0x125B314", VA = "0x125B314", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000828")]
				[Address(RVA = "0x125B37C", Offset = "0x125B37C", VA = "0x125B37C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000823")]
			[Address(RVA = "0x125B1E8", Offset = "0x125B1E8", VA = "0x125B1E8")]
			[DebuggerHidden]
			public <Destruct>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000824")]
			[Address(RVA = "0x125B224", Offset = "0x125B224", VA = "0x125B224", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000825")]
			[Address(RVA = "0x125B228", Offset = "0x125B228", VA = "0x125B228", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000827")]
			[Address(RVA = "0x125B31C", Offset = "0x125B31C", VA = "0x125B31C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float delay;

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x125B14C", Offset = "0x125B14C", VA = "0x125B14C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x125B178", Offset = "0x125B178", VA = "0x125B178")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C5ADC", Offset = "0x9C5ADC")]
		private IEnumerator Destruct()
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x125B214", Offset = "0x125B214", VA = "0x125B214")]
		public Destructor()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class Dying : MonoBehaviour
	{
		[Token(Token = "0x200011F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA7D0", Offset = "0x9BA7D0")]
		private sealed class <FadeOutPinWeight>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dying <>4__this;

			[Token(Token = "0x170000C4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600082C")]
				[Address(RVA = "0x125BA0C", Offset = "0x125BA0C", VA = "0x125BA0C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600082E")]
				[Address(RVA = "0x125BA74", Offset = "0x125BA74", VA = "0x125BA74", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000829")]
			[Address(RVA = "0x125B6DC", Offset = "0x125B6DC", VA = "0x125B6DC")]
			[DebuggerHidden]
			public <FadeOutPinWeight>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600082A")]
			[Address(RVA = "0x125B920", Offset = "0x125B920", VA = "0x125B920", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600082B")]
			[Address(RVA = "0x125B924", Offset = "0x125B924", VA = "0x125B924", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600082D")]
			[Address(RVA = "0x125BA14", Offset = "0x125BA14", VA = "0x125BA14", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA7E0", Offset = "0x9BA7E0")]
		private sealed class <FadeOutMuscleWeight>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dying <>4__this;

			[Token(Token = "0x170000C6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000832")]
				[Address(RVA = "0x125B8B0", Offset = "0x125B8B0", VA = "0x125B8B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000834")]
				[Address(RVA = "0x125B918", Offset = "0x125B918", VA = "0x125B918", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600082F")]
			[Address(RVA = "0x125B708", Offset = "0x125B708", VA = "0x125B708")]
			[DebuggerHidden]
			public <FadeOutMuscleWeight>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000830")]
			[Address(RVA = "0x125B7C0", Offset = "0x125B7C0", VA = "0x125B7C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000831")]
			[Address(RVA = "0x125B7C4", Offset = "0x125B7C4", VA = "0x125B7C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000833")]
			[Address(RVA = "0x125B8B8", Offset = "0x125B8B8", VA = "0x125B8B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD59C", Offset = "0x9BD59C")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD5D4", Offset = "0x9BD5D4")]
		public float fadeOutPinWeightSpeed;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD60C", Offset = "0x9BD60C")]
		public float fadeOutMuscleWeightSpeed;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD644", Offset = "0x9BD644")]
		public float deadMuscleWeight;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool isDead;

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x125B384", Offset = "0x125B384", VA = "0x125B384")]
		private void Start()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x125B420", Offset = "0x125B420", VA = "0x125B420")]
		private void Update()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x125B5FC", Offset = "0x125B5FC", VA = "0x125B5FC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C5B40", Offset = "0x9C5B40")]
		private IEnumerator FadeOutPinWeight()
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x125B66C", Offset = "0x125B66C", VA = "0x125B66C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C5BA4", Offset = "0x9C5BA4")]
		private IEnumerator FadeOutMuscleWeight()
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x125B734", Offset = "0x125B734", VA = "0x125B734")]
		public Dying()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B9B94", Offset = "0x9B9B94")]
	public class FXCollisionBlood : MonoBehaviour
	{
		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minCollisionImpulse;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int emission;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float emissionImpulseAdd;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int maxEmission;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem particles;

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x125E670", Offset = "0x125E670", VA = "0x125E670")]
		private void Start()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x125E740", Offset = "0x125E740", VA = "0x125E740")]
		private void OnCollisionImpulse(MuscleCollision m, float impulse)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x125E920", Offset = "0x125E920", VA = "0x125E920")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x125EA10", Offset = "0x125EA10", VA = "0x125EA10")]
		public FXCollisionBlood()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class Grab : MonoBehaviour
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD67C", Offset = "0x9BD67C")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD6B4", Offset = "0x9BD6B4")]
		public UserControlMelee userControl;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD6EC", Offset = "0x9BD6EC")]
		public int grabLayer;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool grabbed;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Collider c;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BehaviourPuppet otherPuppet;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Collider otherCollider;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ConfigurableJoint joint;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float nextGrabTime;

		[Token(Token = "0x4000360")]
		private const float massMlp = 5f;

		[Token(Token = "0x4000361")]
		private const int solverIterationMlp = 10;

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x125EA30", Offset = "0x125EA30", VA = "0x125EA30")]
		private void Start()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x125EAA0", Offset = "0x125EAA0", VA = "0x125EAA0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x125EE70", Offset = "0x125EE70", VA = "0x125EE70")]
		private void Update()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x125EF9C", Offset = "0x125EF9C", VA = "0x125EF9C")]
		public Grab()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class Killing : MonoBehaviour
	{
		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD724", Offset = "0x9BD724")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD75C", Offset = "0x9BD75C")]
		public PuppetMaster.StateSettings stateSettings;

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1260C98", Offset = "0x1260C98", VA = "0x1260C98")]
		private void Update()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1260D68", Offset = "0x1260D68", VA = "0x1260D68")]
		public Killing()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B9BF8", Offset = "0x9B9BF8")]
	public class LayerSetup : MonoBehaviour
	{
		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BD794", Offset = "0x9BD794")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD794", Offset = "0x9BD794")]
		public Transform characterController;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BD7F4", Offset = "0x9BD7F4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD7F4", Offset = "0x9BD7F4")]
		public int characterControllerLayer;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD854", Offset = "0x9BD854")]
		public int ragdollLayer;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD88C", Offset = "0x9BD88C")]
		public LayerMask ignoreCollisionWithCharacterController;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD8C4", Offset = "0x9BD8C4")]
		public LayerMask ignoreCollisionWithRagdoll;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PuppetMaster puppetMaster;

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x126171C", Offset = "0x126171C", VA = "0x126171C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1261918", Offset = "0x1261918", VA = "0x1261918")]
		public LayerSetup()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class Planet : MonoBehaviour
	{
		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float mass;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Rigidbody[] rigidbodies;

		[Token(Token = "0x400036C")]
		private const float G = 6.672E-11f;

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x11DAB54", Offset = "0x11DAB54", VA = "0x11DAB54")]
		private void Start()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x11DAC20", Offset = "0x11DAC20", VA = "0x11DAC20")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x11DACAC", Offset = "0x11DACAC", VA = "0x11DACAC")]
		private void ApplyGravity(Rigidbody r)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x11DAE9C", Offset = "0x11DAE9C", VA = "0x11DAE9C")]
		public Planet()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class PropDemo : MonoBehaviour
	{
		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD8FC", Offset = "0x9BD8FC")]
		public Prop prop;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD934", Offset = "0x9BD934")]
		public PropRoot propRootLeft;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD96C", Offset = "0x9BD96C")]
		public PropRoot propRootRight;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD9A4", Offset = "0x9BD9A4")]
		public bool pickUpOnStart;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool right;

		[Token(Token = "0x1700004C")]
		private PropRoot connectTo
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x11DB650", Offset = "0x11DB650", VA = "0x11DB650")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x11DB614", Offset = "0x11DB614", VA = "0x11DB614")]
		private void Start()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x11DB66C", Offset = "0x11DB66C", VA = "0x11DB66C")]
		private void Update()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x11DB750", Offset = "0x11DB750", VA = "0x11DB750")]
		public PropDemo()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class PropMelee : Prop
	{
		[Token(Token = "0x2000121")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA7F0", Offset = "0x9BA7F0")]
		private sealed class <Action>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PropMelee <>4__this;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <additionalPinMuscleIndex>5__2;

			[Token(Token = "0x170000C8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000838")]
				[Address(RVA = "0x11DBC94", Offset = "0x11DBC94", VA = "0x11DBC94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600083A")]
				[Address(RVA = "0x11DBCFC", Offset = "0x11DBCFC", VA = "0x11DBCFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000835")]
			[Address(RVA = "0x11DB828", Offset = "0x11DB828", VA = "0x11DB828")]
			[DebuggerHidden]
			public <Action>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000836")]
			[Address(RVA = "0x11DBA6C", Offset = "0x11DBA6C", VA = "0x11DBA6C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000837")]
			[Address(RVA = "0x11DBA70", Offset = "0x11DBA70", VA = "0x11DBA70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000839")]
			[Address(RVA = "0x11DBC9C", Offset = "0x11DBC9C", VA = "0x11DBC9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BD9DC", Offset = "0x9BD9DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BD9DC", Offset = "0x9BD9DC")]
		public CapsuleCollider capsuleCollider;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BDA3C", Offset = "0x9BDA3C")]
		public BoxCollider boxCollider;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BDA74", Offset = "0x9BDA74")]
		public float actionColliderRadiusMlp;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BDAAC", Offset = "0x9BDAAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BDAAC", Offset = "0x9BDAAC")]
		public float actionAdditionalPinWeight;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BDB00", Offset = "0x9BDB00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BDB00", Offset = "0x9BDB00")]
		public float actionMassMlp;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BDB58", Offset = "0x9BDB58")]
		public Vector3 COMOffset;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float defaultColliderRadius;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float defaultMass;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float defaultAddMass;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Rigidbody r;

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x11DB760", Offset = "0x11DB760", VA = "0x11DB760")]
		public void StartAction(float duration)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x11DB7A8", Offset = "0x11DB7A8", VA = "0x11DB7A8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C5C08", Offset = "0x9C5C08")]
		public IEnumerator Action(float duration)
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x11DB854", Offset = "0x11DB854", VA = "0x11DB854", Slot = "6")]
		protected override void OnStart()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x11DB964", Offset = "0x11DB964", VA = "0x11DB964", Slot = "4")]
		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x11DB9DC", Offset = "0x11DB9DC", VA = "0x11DB9DC", Slot = "5")]
		protected override void OnDrop()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x11DBA54", Offset = "0x11DBA54", VA = "0x11DBA54")]
		public PropMelee()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class PropPickUpTrigger : MonoBehaviour
	{
		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Prop prop;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask characterLayers;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CharacterPuppet characterPuppet;

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x11DBD04", Offset = "0x11DBD04", VA = "0x11DBD04")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x11DBE8C", Offset = "0x11DBE8C", VA = "0x11DBE8C")]
		public PropPickUpTrigger()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class PuppetBoard : MonoBehaviour
	{
		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BDB90", Offset = "0x9BDB90")]
		public Rigidbody target;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BDBC8", Offset = "0x9BDBC8")]
		public Transform bodyTargetPivot;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BDC00", Offset = "0x9BDC00")]
		public Transform bodyTarget;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x11DBE94", Offset = "0x11DBE94", VA = "0x11DBE94")]
		private void Start()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x11DBF3C", Offset = "0x11DBF3C", VA = "0x11DBF3C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x11DC160", Offset = "0x11DC160", VA = "0x11DC160")]
		public PuppetBoard()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class PuppetScaling : MonoBehaviour
	{
		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BDC38", Offset = "0x9BDC38")]
		public float masterScale;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int muscleIndex;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BDC54", Offset = "0x9BDC54")]
		public float muscleScale;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float defaultMuscleSpring;

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x11DC168", Offset = "0x11DC168", VA = "0x11DC168")]
		private void Start()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x11DC1A8", Offset = "0x11DC1A8", VA = "0x11DC1A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x11DC544", Offset = "0x11DC544", VA = "0x11DC544")]
		public PuppetScaling()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class RaycastShooter : MonoBehaviour
	{
		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask layers;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unpin;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float force;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem blood;

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x11DC7E0", Offset = "0x11DC7E0", VA = "0x11DC7E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x11DCAC0", Offset = "0x11DCAC0", VA = "0x11DCAC0")]
		public RaycastShooter()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class Respawning : MonoBehaviour
	{
		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BDC70", Offset = "0x9BDC70")]
		public Transform pool;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BDCA8", Offset = "0x9BDCA8")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BDCE0", Offset = "0x9BDCE0")]
		public string idleAnimation;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform puppetRoot;

		[Token(Token = "0x1700004D")]
		private bool isPooled
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x11DD040", Offset = "0x11DD040", VA = "0x11DD040")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x11DD0D8", Offset = "0x11DD0D8", VA = "0x11DD0D8")]
		private void Start()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x11DD138", Offset = "0x11DD138", VA = "0x11DD138")]
		private void Update()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x11DD31C", Offset = "0x11DD31C", VA = "0x11DD31C")]
		private void Pool()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x11DD340", Offset = "0x11DD340", VA = "0x11DD340")]
		private void Respawn(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x11DDBA8", Offset = "0x11DDBA8", VA = "0x11DDBA8")]
		public Respawning()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class RotateShoulderToTarget : MonoBehaviour
	{
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform shoulder;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 euler;

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x11DDBB0", Offset = "0x11DDBB0", VA = "0x11DDBB0")]
		private void OnPuppetMasterRead()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x11DDC98", Offset = "0x11DDC98", VA = "0x11DDC98")]
		public RotateShoulderToTarget()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class SkeletonShooter : MonoBehaviour
	{
		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MuscleRemoveMode removeMuscleMode;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask layers;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float unpin;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem particles;

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x11DECB4", Offset = "0x11DECB4", VA = "0x11DECB4")]
		private void Update()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x11DF15C", Offset = "0x11DF15C", VA = "0x11DF15C")]
		public SkeletonShooter()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class UserControlAIMelee : UserControlThirdPerson
	{
		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BehaviourPuppet targetPuppet;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isAttacking;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float attackTimer;

		[Token(Token = "0x1700004E")]
		private Transform moveTarget
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x11E179C", Offset = "0x11E179C", VA = "0x11E179C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x11E17F0", Offset = "0x11E17F0", VA = "0x11E17F0", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x11E1AA0", Offset = "0x11E1AA0", VA = "0x11E1AA0")]
		private bool CanAttack()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x11E1CB4", Offset = "0x11E1CB4", VA = "0x11E1CB4")]
		public UserControlAIMelee()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class UserControlMelee : UserControlThirdPerson
	{
		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public KeyCode hitKey;

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x11E23C4", Offset = "0x11E23C4", VA = "0x11E23C4", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x11E23F8", Offset = "0x11E23F8", VA = "0x11E23F8")]
		public UserControlMelee()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x1700004F")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x12559B8", Offset = "0x12559B8", VA = "0x12559B8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x1255994", Offset = "0x1255994", VA = "0x1255994", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x12559C0", Offset = "0x12559C0", VA = "0x12559C0")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x1255A84", Offset = "0x1255A84", VA = "0x1255A84", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x1255CDC", Offset = "0x1255CDC", VA = "0x1255CDC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1255F4C", Offset = "0x1255F4C", VA = "0x1255F4C", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1255CEC", Offset = "0x1255CEC", VA = "0x1255CEC")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1255F5C", Offset = "0x1255F5C", VA = "0x1255F5C")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B9C5C", Offset = "0x9B9C5C")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1256500", Offset = "0x1256500", VA = "0x1256500", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1256560", Offset = "0x1256560", VA = "0x1256560", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x125668C", Offset = "0x125668C", VA = "0x125668C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1256808", Offset = "0x1256808", VA = "0x1256808")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B9CC0", Offset = "0x9B9CC0")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BDD78", Offset = "0x9BDD78")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x40003AF")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40003B0")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x17000050")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x12568C0", Offset = "0x12568C0", VA = "0x12568C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1256820", Offset = "0x1256820", VA = "0x1256820", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x12568A4", Offset = "0x12568A4", VA = "0x12568A4", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x12560F4", Offset = "0x12560F4", VA = "0x12560F4", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x12569B0", Offset = "0x12569B0", VA = "0x12569B0")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x12564DC", Offset = "0x12564DC", VA = "0x12564DC")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B9D24", Offset = "0x9B9D24")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B9D24", Offset = "0x9B9D24")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BDDBC", Offset = "0x9BDDBC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BDDBC", Offset = "0x9BDDBC")]
		public Transform gravityTarget;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BDE1C", Offset = "0x9BDE1C")]
		[SerializeField]
		protected float gravityMultiplier;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40003BC")]
		protected const float half = 0.5f;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60003CF")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1257064", Offset = "0x1257064", VA = "0x1257064")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x12571E8", Offset = "0x12571E8", VA = "0x12571E8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1257380", Offset = "0x1257380", VA = "0x1257380", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x12575F8", Offset = "0x12575F8", VA = "0x12575F8")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x12576BC", Offset = "0x12576BC", VA = "0x12576BC")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x12578A4", Offset = "0x12578A4", VA = "0x12578A4")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1257A54", Offset = "0x1257A54", VA = "0x1257A54")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1257A78", Offset = "0x1257A78", VA = "0x1257A78")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1257A9C", Offset = "0x1257A9C", VA = "0x1257A9C")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1257BA0", Offset = "0x1257BA0", VA = "0x1257BA0")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000122")]
		public enum MoveMode
		{
			[Token(Token = "0x40007DB")]
			Directional,
			[Token(Token = "0x40007DC")]
			Strafe
		}

		[Token(Token = "0x2000123")]
		public struct AnimState
		{
			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;
		}

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BDEB8", Offset = "0x9BDEB8")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BDEF0", Offset = "0x9BDEF0")]
		public MoveMode moveMode;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BDF28", Offset = "0x9BDF28")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BDF60", Offset = "0x9BDF60")]
		public float airSpeed;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airControl;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float jumpPower;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BDF98", Offset = "0x9BDF98")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float wallRunMaxLength;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BDFE4", Offset = "0x9BDFE4")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE01C", Offset = "0x9BE01C")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AnimState animState;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Animator animator;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3 normal;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private RaycastHit hit;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private float jumpLeg;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private float jumpEndTime;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private float forwardMlp;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private float groundDistance;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float lastAirTime;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float stickyForce;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 wallNormal;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private float wallRunWeight;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float lastWallRunWeight;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private bool fixedFrame;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private float wallRunEndTime;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Vector3 gravity;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private float velocityY;

		[Token(Token = "0x17000051")]
		public bool onGround
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x12592E0", Offset = "0x12592E0", VA = "0x12592E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5C6C", Offset = "0x9C5C6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x12592E8", Offset = "0x12592E8", VA = "0x12592E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5C7C", Offset = "0x9C5C7C")]
			private set
			{
			}
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x125857C", Offset = "0x125857C", VA = "0x125857C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x12592F4", Offset = "0x12592F4", VA = "0x12592F4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1258804", Offset = "0x1258804", VA = "0x1258804", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1259384", Offset = "0x1259384", VA = "0x1259384")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1258468", Offset = "0x1258468", VA = "0x1258468", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x125A550", Offset = "0x125A550", VA = "0x125A550", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x12598A8", Offset = "0x12598A8", VA = "0x12598A8")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x125A630", Offset = "0x125A630", VA = "0x125A630")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x125AC20", Offset = "0x125AC20", VA = "0x125AC20")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x125A2B0", Offset = "0x125A2B0", VA = "0x125A2B0")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1258B98", Offset = "0x1258B98", VA = "0x1258B98", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x125ACC0", Offset = "0x125ACC0", VA = "0x125ACC0")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1259030", Offset = "0x1259030", VA = "0x1259030", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1259E90", Offset = "0x1259E90", VA = "0x1259E90")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x12591C4", Offset = "0x12591C4", VA = "0x12591C4")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B9DB0", Offset = "0x9B9DB0")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000124")]
		public enum RotationMode
		{
			[Token(Token = "0x40007E4")]
			Smooth,
			[Token(Token = "0x40007E5")]
			Linear
		}

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE02C", Offset = "0x9BE02C")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE078", Offset = "0x9BE078")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE0C4", Offset = "0x9BE0C4")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE110", Offset = "0x9BE110")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE15C", Offset = "0x9BE15C")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE1A8", Offset = "0x9BE1A8")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE1F4", Offset = "0x9BE1F4")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x17000052")]
		public bool isGrounded
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x11DE320", Offset = "0x11DE320", VA = "0x11DE320")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5C8C", Offset = "0x9C5C8C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x11DE328", Offset = "0x11DE328", VA = "0x11DE328")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5C9C", Offset = "0x9C5C9C")]
			private set
			{
			}
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x11DE334", Offset = "0x11DE334", VA = "0x11DE334")]
		private void Start()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x11DE3BC", Offset = "0x11DE3BC", VA = "0x11DE3BC")]
		private void Update()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x11DEAB8", Offset = "0x11DEAB8", VA = "0x11DEAB8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x11DE410", Offset = "0x11DE410", VA = "0x11DE410")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x11DE810", Offset = "0x11DE810", VA = "0x11DE810")]
		private void Move()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x11DEAF4", Offset = "0x11DEAF4", VA = "0x11DEAF4")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x11DEBEC", Offset = "0x11DEBEC", VA = "0x11DEBEC")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x11DEC8C", Offset = "0x11DEC8C", VA = "0x11DEC8C")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x11E156C", Offset = "0x11E156C", VA = "0x11E156C", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x11E1770", Offset = "0x11E1770", VA = "0x11E1770")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000125")]
		public struct State
		{
			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x11E2408", Offset = "0x11E2408", VA = "0x11E2408")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x11E1DE4", Offset = "0x11E1DE4", VA = "0x11E1DE4", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x11E178C", Offset = "0x11E178C", VA = "0x11E178C")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1254FE8", Offset = "0x1254FE8", VA = "0x1254FE8")]
		private void Update()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1255024", Offset = "0x1255024", VA = "0x1255024")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x11DF16C", Offset = "0x11DF16C", VA = "0x11DF16C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x11DF1A0", Offset = "0x11DF1A0", VA = "0x11DF1A0")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x11DF250", Offset = "0x11DF250", VA = "0x11DF250")]
		public SlowMo()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B9E14", Offset = "0x9B9E14")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B9E14", Offset = "0x9B9E14")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1479348", Offset = "0x1479348", VA = "0x1479348")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5CAC", Offset = "0x9C5CAC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1479394", Offset = "0x1479394", VA = "0x1479394")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5CE4", Offset = "0x9C5CE4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x14793E0", Offset = "0x14793E0", VA = "0x14793E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5D1C", Offset = "0x9C5D1C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x147942C", Offset = "0x147942C", VA = "0x147942C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5D54", Offset = "0x9C5D54")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1479478", Offset = "0x1479478", VA = "0x1479478")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1479514", Offset = "0x1479514", VA = "0x1479514")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1479534", Offset = "0x1479534", VA = "0x1479534")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1479564", Offset = "0x1479564", VA = "0x1479564")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1479594", Offset = "0x1479594", VA = "0x1479594")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x14795D4", Offset = "0x14795D4", VA = "0x14795D4")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1479618", Offset = "0x1479618", VA = "0x1479618")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x147963C", Offset = "0x147963C", VA = "0x147963C")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1479660", Offset = "0x1479660", VA = "0x1479660")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1479688", Offset = "0x1479688", VA = "0x1479688")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x14796B4", Offset = "0x14796B4", VA = "0x14796B4")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x14796E0", Offset = "0x14796E0", VA = "0x14796E0")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1479498", Offset = "0x1479498", VA = "0x1479498")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1479708", Offset = "0x1479708", VA = "0x1479708")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1479714", Offset = "0x1479714", VA = "0x1479714")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1479720", Offset = "0x1479720", VA = "0x1479720")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1479A08", Offset = "0x1479A08", VA = "0x1479A08", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1479AB0", Offset = "0x1479AB0", VA = "0x1479AB0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1479DF8", Offset = "0x1479DF8", VA = "0x1479DF8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x147A2E0", Offset = "0x147A2E0", VA = "0x147A2E0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x147A314", Offset = "0x147A314", VA = "0x147A314")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008D")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000053")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x14798C0", Offset = "0x14798C0", VA = "0x14798C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x147A4E0", Offset = "0x147A4E0", VA = "0x147A4E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1479C80", Offset = "0x1479C80", VA = "0x1479C80")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x147A398", Offset = "0x147A398", VA = "0x147A398")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008E")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000055")]
		public bool isValid
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x147AAE0", Offset = "0x147AAE0", VA = "0x147AAE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600041D")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x147AB50", Offset = "0x147AB50", VA = "0x147AB50")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008F")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x147AB58", Offset = "0x147AB58", VA = "0x147AB58", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x147AC64", Offset = "0x147AC64", VA = "0x147AC64")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x147AC6C", Offset = "0x147AC6C", VA = "0x147AC6C")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000090")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000056")]
		private bool positionChanged
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x147AE34", Offset = "0x147AE34", VA = "0x147AE34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x147AC98", Offset = "0x147AC98", VA = "0x147AC98", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x147AEF0", Offset = "0x147AEF0", VA = "0x147AEF0")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x147AEF8", Offset = "0x147AEF8", VA = "0x147AEF8")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000091")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x147AF24", Offset = "0x147AF24", VA = "0x147AF24", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x147B04C", Offset = "0x147B04C", VA = "0x147B04C")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x147B054", Offset = "0x147B054", VA = "0x147B054")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000092")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000057")]
		private bool rotationChanged
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x147B220", Offset = "0x147B220", VA = "0x147B220")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x147B080", Offset = "0x147B080", VA = "0x147B080", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x147B2F0", Offset = "0x147B2F0", VA = "0x147B2F0")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x147B2F8", Offset = "0x147B2F8", VA = "0x147B2F8")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000093")]
	public class Constraints
	{
		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BE244", Offset = "0x9BE244")]
		public float positionWeight;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BE25C", Offset = "0x9BE25C")]
		public float rotationWeight;

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x147B324", Offset = "0x147B324", VA = "0x147B324")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1479DA4", Offset = "0x1479DA4", VA = "0x1479DA4")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1479F80", Offset = "0x1479F80", VA = "0x1479F80")]
		public void Update()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x147A6AC", Offset = "0x147A6AC", VA = "0x147A6AC")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000094")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000126")]
		public enum DOF
		{
			[Token(Token = "0x40007EC")]
			One,
			[Token(Token = "0x40007ED")]
			Three
		}

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE274", Offset = "0x9BE274")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BE274", Offset = "0x9BE274")]
		public float weight;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE2C8", Offset = "0x9BE2C8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BE2C8", Offset = "0x9BE2C8")]
		public float rotationWeight;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE31C", Offset = "0x9BE31C")]
		public DOF rotationDOF;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE354", Offset = "0x9BE354")]
		public Transform bone1;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE38C", Offset = "0x9BE38C")]
		public Transform bone2;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE3C4", Offset = "0x9BE3C4")]
		public Transform bone3;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE3FC", Offset = "0x9BE3FC")]
		public Transform tip;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE434", Offset = "0x9BE434")]
		public Transform target;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE46C", Offset = "0x9BE46C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x17000058")]
		public bool initiated
		{
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x14824F0", Offset = "0x14824F0", VA = "0x14824F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5D8C", Offset = "0x9C5D8C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x14824F8", Offset = "0x14824F8", VA = "0x14824F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5D9C", Offset = "0x9C5D9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x1482504", Offset = "0x1482504", VA = "0x1482504")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x1482524", Offset = "0x1482524", VA = "0x1482524")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x1482544", Offset = "0x1482544", VA = "0x1482544")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x1482564", Offset = "0x1482564", VA = "0x1482564")]
			set
			{
			}
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1482584", Offset = "0x1482584", VA = "0x1482584")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1482684", Offset = "0x1482684", VA = "0x1482684")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1482A98", Offset = "0x1482A98", VA = "0x1482A98")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1482B68", Offset = "0x1482B68", VA = "0x1482B68")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1482F1C", Offset = "0x1482F1C", VA = "0x1482F1C")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE47C", Offset = "0x9BE47C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BE47C", Offset = "0x9BE47C")]
		public float weight;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE4D0", Offset = "0x9BE4D0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700005B")]
		public bool initiated
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x1482F2C", Offset = "0x1482F2C", VA = "0x1482F2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5DAC", Offset = "0x9C5DAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x1482F34", Offset = "0x1482F34", VA = "0x1482F34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5DBC", Offset = "0x9C5DBC")]
			private set
			{
			}
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1482F40", Offset = "0x1482F40", VA = "0x1482F40")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1482FC8", Offset = "0x1482FC8", VA = "0x1482FC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5DCC", Offset = "0x9C5DCC")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x14832EC", Offset = "0x14832EC", VA = "0x14832EC")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x148345C", Offset = "0x148345C", VA = "0x148345C")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x14831E4", Offset = "0x14831E4", VA = "0x14831E4")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x14835C4", Offset = "0x14835C4", VA = "0x14835C4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1483684", Offset = "0x1483684", VA = "0x1483684")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1483708", Offset = "0x1483708", VA = "0x1483708")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1483770", Offset = "0x1483770", VA = "0x1483770", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1483774", Offset = "0x1483774", VA = "0x1483774", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1483778", Offset = "0x1483778", VA = "0x1483778")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000127")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE4E0", Offset = "0x9BE4E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BE4E0", Offset = "0x9BE4E0")]
		public float weight;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE534", Offset = "0x9BE534")]
		public Grounding solver;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected bool initiated;

		[Token(Token = "0x6000449")]
		public abstract void ResetPosition();

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x14847AC", Offset = "0x14847AC", VA = "0x14847AC")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1484A80", Offset = "0x1484A80", VA = "0x1484A80")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x14848F0", Offset = "0x14848F0", VA = "0x14848F0")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1484AB4", Offset = "0x1484AB4", VA = "0x1484AB4")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044E")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600044F")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1484CBC", Offset = "0x1484CBC", VA = "0x1484CBC")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B9E74", Offset = "0x9B9E74")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B9E74", Offset = "0x9B9E74")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE56C", Offset = "0x9BE56C")]
		public BipedIK ik;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE5A4", Offset = "0x9BE5A4")]
		public float spineBend;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE5DC", Offset = "0x9BE5DC")]
		public float spineSpeed;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1484F80", Offset = "0x1484F80", VA = "0x1484F80", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5E04", Offset = "0x9C5E04")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1484FCC", Offset = "0x1484FCC", VA = "0x1484FCC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5E3C", Offset = "0x9C5E3C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1485018", Offset = "0x1485018", VA = "0x1485018", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x148509C", Offset = "0x148509C", VA = "0x148509C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x148514C", Offset = "0x148514C", VA = "0x148514C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1485200", Offset = "0x1485200", VA = "0x1485200")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x14854B8", Offset = "0x14854B8", VA = "0x14854B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x148550C", Offset = "0x148550C", VA = "0x148550C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1485A60", Offset = "0x1485A60", VA = "0x1485A60")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1485B34", Offset = "0x1485B34", VA = "0x1485B34")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1485CC4", Offset = "0x1485CC4", VA = "0x1485CC4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1485E34", Offset = "0x1485E34", VA = "0x1485E34")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B9ED4", Offset = "0x9B9ED4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B9ED4", Offset = "0x9B9ED4")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000128")]
		public class SpineEffector
		{
			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1DAC", Offset = "0x9C1DAC")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1DE4", Offset = "0x9C1DE4")]
			public float horizontalWeight;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1E1C", Offset = "0x9C1E1C")]
			public float verticalWeight;

			[Token(Token = "0x600083F")]
			[Address(RVA = "0x1486CA8", Offset = "0x1486CA8", VA = "0x1486CA8")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000840")]
			[Address(RVA = "0x1486CB8", Offset = "0x1486CB8", VA = "0x1486CB8")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE614", Offset = "0x9BE614")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE64C", Offset = "0x9BE64C")]
		public float spineBend;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE684", Offset = "0x9BE684")]
		public float spineSpeed;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1485EB4", Offset = "0x1485EB4", VA = "0x1485EB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5E74", Offset = "0x9C5E74")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1485F00", Offset = "0x1485F00", VA = "0x1485F00", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5EAC", Offset = "0x9C5EAC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1485F4C", Offset = "0x1485F4C", VA = "0x1485F4C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5EE4", Offset = "0x9C5EE4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1485F98", Offset = "0x1485F98", VA = "0x1485F98", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x148601C", Offset = "0x148601C", VA = "0x148601C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x14860B4", Offset = "0x14860B4", VA = "0x14860B4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1486374", Offset = "0x1486374", VA = "0x1486374")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1486380", Offset = "0x1486380", VA = "0x1486380")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1486170", Offset = "0x1486170", VA = "0x1486170")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x148638C", Offset = "0x148638C", VA = "0x148638C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1486830", Offset = "0x1486830", VA = "0x1486830")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x14869F0", Offset = "0x14869F0", VA = "0x14869F0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1486B28", Offset = "0x1486B28", VA = "0x1486B28")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1486C28", Offset = "0x1486C28", VA = "0x1486C28")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B9F34", Offset = "0x9B9F34")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B9F34", Offset = "0x9B9F34")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE6BC", Offset = "0x9BE6BC")]
		public Transform pelvis;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE6F4", Offset = "0x9BE6F4")]
		public Transform characterRoot;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE72C", Offset = "0x9BE72C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BE72C", Offset = "0x9BE72C")]
		public float rootRotationWeight;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE780", Offset = "0x9BE780")]
		public float rootRotationSpeed;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE7B8", Offset = "0x9BE7B8")]
		public float maxRootRotationAngle;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1486D00", Offset = "0x1486D00", VA = "0x1486D00", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5F1C", Offset = "0x9C5F1C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1486D4C", Offset = "0x1486D4C", VA = "0x1486D4C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5F54", Offset = "0x9C5F54")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1486D98", Offset = "0x1486D98", VA = "0x1486D98", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1486DB4", Offset = "0x1486DB4", VA = "0x1486DB4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1486FA4", Offset = "0x1486FA4", VA = "0x1486FA4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x14870A4", Offset = "0x14870A4", VA = "0x14870A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x14874D4", Offset = "0x14874D4", VA = "0x14874D4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x14878A0", Offset = "0x14878A0", VA = "0x14878A0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1487B14", Offset = "0x1487B14", VA = "0x1487B14")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1487E34", Offset = "0x1487E34", VA = "0x1487E34")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1487FC0", Offset = "0x1487FC0", VA = "0x1487FC0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1488188", Offset = "0x1488188", VA = "0x1488188")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B9F94", Offset = "0x9B9F94")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B9F94", Offset = "0x9B9F94")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000129")]
		public struct Foot
		{
			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x6000841")]
			[Address(RVA = "0x1944098", Offset = "0x1944098", VA = "0x1944098")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE7F0", Offset = "0x9BE7F0")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE828", Offset = "0x9BE828")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BE828", Offset = "0x9BE828")]
		public float rootRotationWeight;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE87C", Offset = "0x9BE87C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BE87C", Offset = "0x9BE87C")]
		public float minRootRotation;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE8D4", Offset = "0x9BE8D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BE8D4", Offset = "0x9BE8D4")]
		public float maxRootRotation;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE92C", Offset = "0x9BE92C")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE964", Offset = "0x9BE964")]
		public float maxLegOffset;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE99C", Offset = "0x9BE99C")]
		public float maxForeLegOffset;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BE9D4", Offset = "0x9BE9D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BE9D4", Offset = "0x9BE9D4")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BEA28", Offset = "0x9BEA28")]
		public Transform characterRoot;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BEA60", Offset = "0x9BEA60")]
		public Transform pelvis;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BEA98", Offset = "0x9BEA98")]
		public Transform lastSpineBone;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BEAD0", Offset = "0x9BEAD0")]
		public Transform head;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1943304", Offset = "0x1943304", VA = "0x1943304", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5F8C", Offset = "0x9C5F8C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1943350", Offset = "0x1943350", VA = "0x1943350", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5FC4", Offset = "0x9C5FC4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x194339C", Offset = "0x194339C", VA = "0x194339C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1943454", Offset = "0x1943454", VA = "0x1943454")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1943584", Offset = "0x1943584", VA = "0x1943584")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1943730", Offset = "0x1943730", VA = "0x1943730")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1943798", Offset = "0x1943798", VA = "0x1943798")]
		private void Update()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1943850", Offset = "0x1943850", VA = "0x1943850")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1943B34", Offset = "0x1943B34", VA = "0x1943B34")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x19440E8", Offset = "0x19440E8", VA = "0x19440E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1944234", Offset = "0x1944234", VA = "0x1944234")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x19445C4", Offset = "0x19445C4", VA = "0x19445C4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1944DBC", Offset = "0x1944DBC", VA = "0x1944DBC")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x19452E4", Offset = "0x19452E4", VA = "0x19452E4")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1945444", Offset = "0x1945444", VA = "0x1945444")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1945720", Offset = "0x1945720", VA = "0x1945720")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1945758", Offset = "0x1945758", VA = "0x1945758")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1945910", Offset = "0x1945910", VA = "0x1945910")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B9FF4", Offset = "0x9B9FF4")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BEB18", Offset = "0x9BEB18")]
		public VRIK ik;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1945A68", Offset = "0x1945A68", VA = "0x1945A68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C5FFC", Offset = "0x9C5FFC")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1945A6C", Offset = "0x1945A6C", VA = "0x1945A6C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6034", Offset = "0x9C6034")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1945A70", Offset = "0x1945A70", VA = "0x1945A70", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C606C", Offset = "0x9C606C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1945A74", Offset = "0x1945A74", VA = "0x1945A74", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1945A8C", Offset = "0x1945A8C", VA = "0x1945A8C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x1945B24", Offset = "0x1945B24", VA = "0x1945B24")]
		private void Update()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1945BD8", Offset = "0x1945BD8", VA = "0x1945BD8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1945DC8", Offset = "0x1945DC8", VA = "0x1945DC8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x1946064", Offset = "0x1946064", VA = "0x1946064")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x194616C", Offset = "0x194616C", VA = "0x194616C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x194636C", Offset = "0x194636C", VA = "0x194636C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x19464A4", Offset = "0x19464A4", VA = "0x19464A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x19465F4", Offset = "0x19465F4", VA = "0x19465F4")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009C")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x200012A")]
		public enum Quality
		{
			[Token(Token = "0x40007F6")]
			Fastest,
			[Token(Token = "0x40007F7")]
			Simple,
			[Token(Token = "0x40007F8")]
			Best
		}

		[Token(Token = "0x200012B")]
		public class Leg
		{
			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C1E54", Offset = "0x9C1E54")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C1E64", Offset = "0x9C1E64")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C1E74", Offset = "0x9C1E74")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C1E84", Offset = "0x9C1E84")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C1E94", Offset = "0x9C1E94")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C1EA4", Offset = "0x9C1EA4")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C1EB4", Offset = "0x9C1EB4")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x4000809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x170000CA")]
			public bool isGrounded
			{
				[Token(Token = "0x6000842")]
				[Address(RVA = "0x19480AC", Offset = "0x19480AC", VA = "0x19480AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7C30", Offset = "0x9C7C30")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000843")]
				[Address(RVA = "0x19480B4", Offset = "0x19480B4", VA = "0x19480B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7C40", Offset = "0x9C7C40")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CB")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000844")]
				[Address(RVA = "0x19480C0", Offset = "0x19480C0", VA = "0x19480C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7C50", Offset = "0x9C7C50")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000845")]
				[Address(RVA = "0x19480CC", Offset = "0x19480CC", VA = "0x19480CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7C60", Offset = "0x9C7C60")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CC")]
			public bool initiated
			{
				[Token(Token = "0x6000846")]
				[Address(RVA = "0x19480D8", Offset = "0x19480D8", VA = "0x19480D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7C70", Offset = "0x9C7C70")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000847")]
				[Address(RVA = "0x19480E0", Offset = "0x19480E0", VA = "0x19480E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7C80", Offset = "0x9C7C80")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CD")]
			public float heightFromGround
			{
				[Token(Token = "0x6000848")]
				[Address(RVA = "0x19480EC", Offset = "0x19480EC", VA = "0x19480EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7C90", Offset = "0x9C7C90")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000849")]
				[Address(RVA = "0x19480F4", Offset = "0x19480F4", VA = "0x19480F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7CA0", Offset = "0x9C7CA0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CE")]
			public Vector3 velocity
			{
				[Token(Token = "0x600084A")]
				[Address(RVA = "0x19480FC", Offset = "0x19480FC", VA = "0x19480FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7CB0", Offset = "0x9C7CB0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600084B")]
				[Address(RVA = "0x1948108", Offset = "0x1948108", VA = "0x1948108")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7CC0", Offset = "0x9C7CC0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CF")]
			public Transform transform
			{
				[Token(Token = "0x600084C")]
				[Address(RVA = "0x1948114", Offset = "0x1948114", VA = "0x1948114")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7CD0", Offset = "0x9C7CD0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600084D")]
				[Address(RVA = "0x194811C", Offset = "0x194811C", VA = "0x194811C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7CE0", Offset = "0x9C7CE0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D0")]
			public float IKOffset
			{
				[Token(Token = "0x600084E")]
				[Address(RVA = "0x1948124", Offset = "0x1948124", VA = "0x1948124")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7CF0", Offset = "0x9C7CF0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600084F")]
				[Address(RVA = "0x194812C", Offset = "0x194812C", VA = "0x194812C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7D00", Offset = "0x9C7D00")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D1")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000854")]
				[Address(RVA = "0x1948AAC", Offset = "0x1948AAC", VA = "0x1948AAC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000D2")]
			private float rootYOffset
			{
				[Token(Token = "0x600085D")]
				[Address(RVA = "0x1948DA0", Offset = "0x1948DA0", VA = "0x1948DA0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000850")]
			[Address(RVA = "0x1946D1C", Offset = "0x1946D1C", VA = "0x1946D1C")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000851")]
			[Address(RVA = "0x1948134", Offset = "0x1948134", VA = "0x1948134")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000852")]
			[Address(RVA = "0x1947BCC", Offset = "0x1947BCC", VA = "0x1947BCC")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000853")]
			[Address(RVA = "0x1946E28", Offset = "0x1946E28", VA = "0x1946E28")]
			public void Process()
			{
			}

			[Token(Token = "0x6000855")]
			[Address(RVA = "0x1948744", Offset = "0x1948744", VA = "0x1948744")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000856")]
			[Address(RVA = "0x1948180", Offset = "0x1948180", VA = "0x1948180")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000857")]
			[Address(RVA = "0x1948C2C", Offset = "0x1948C2C", VA = "0x1948C2C")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000858")]
			[Address(RVA = "0x19483D4", Offset = "0x19483D4", VA = "0x19483D4")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000859")]
			[Address(RVA = "0x19484DC", Offset = "0x19484DC", VA = "0x19484DC")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x600085A")]
			[Address(RVA = "0x1948D28", Offset = "0x1948D28", VA = "0x1948D28")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x600085B")]
			[Address(RVA = "0x1948B38", Offset = "0x1948B38", VA = "0x1948B38")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x600085C")]
			[Address(RVA = "0x1948ED4", Offset = "0x1948ED4", VA = "0x1948ED4")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600085E")]
			[Address(RVA = "0x1946C6C", Offset = "0x1946C6C", VA = "0x1946C6C")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200012C")]
		public class Pelvis
		{
			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C1EC4", Offset = "0x9C1EC4")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400080B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C1ED4", Offset = "0x9C1ED4")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000D3")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x600085F")]
				[Address(RVA = "0x1948FC4", Offset = "0x1948FC4", VA = "0x1948FC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7D10", Offset = "0x9C7D10")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000860")]
				[Address(RVA = "0x1948FD0", Offset = "0x1948FD0", VA = "0x1948FD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7D20", Offset = "0x9C7D20")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D4")]
			public float heightOffset
			{
				[Token(Token = "0x6000861")]
				[Address(RVA = "0x1948FDC", Offset = "0x1948FDC", VA = "0x1948FDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7D30", Offset = "0x9C7D30")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000862")]
				[Address(RVA = "0x1948FE4", Offset = "0x1948FE4", VA = "0x1948FE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7D40", Offset = "0x9C7D40")]
				private set
				{
				}
			}

			[Token(Token = "0x6000863")]
			[Address(RVA = "0x1946E00", Offset = "0x1946E00", VA = "0x1946E00")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000864")]
			[Address(RVA = "0x1947B1C", Offset = "0x1947B1C", VA = "0x1947B1C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000865")]
			[Address(RVA = "0x1948FEC", Offset = "0x1948FEC", VA = "0x1948FEC")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000866")]
			[Address(RVA = "0x1947698", Offset = "0x1947698", VA = "0x1947698")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000867")]
			[Address(RVA = "0x1946D14", Offset = "0x1946D14", VA = "0x1946D14")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BEB50", Offset = "0x9BEB50")]
		public LayerMask layers;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BEB88", Offset = "0x9BEB88")]
		public float maxStep;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BEBC0", Offset = "0x9BEBC0")]
		public float heightOffset;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BEBF8", Offset = "0x9BEBF8")]
		public float footSpeed;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BEC30", Offset = "0x9BEC30")]
		public float footRadius;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BEC68", Offset = "0x9BEC68")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BECB4", Offset = "0x9BECB4")]
		public float prediction;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BECEC", Offset = "0x9BECEC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BECEC", Offset = "0x9BECEC")]
		public float footRotationWeight;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BED40", Offset = "0x9BED40")]
		public float footRotationSpeed;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BED78", Offset = "0x9BED78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BED78", Offset = "0x9BED78")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BEDD0", Offset = "0x9BEDD0")]
		public bool rotateSolver;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BEE08", Offset = "0x9BEE08")]
		public float pelvisSpeed;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BEE40", Offset = "0x9BEE40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BEE40", Offset = "0x9BEE40")]
		public float pelvisDamper;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BEE94", Offset = "0x9BEE94")]
		public float lowerPelvisWeight;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BEECC", Offset = "0x9BEECC")]
		public float liftPelvisWeight;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BEF04", Offset = "0x9BEF04")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BEF3C", Offset = "0x9BEF3C")]
		public Quality quality;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEF74", Offset = "0x9BEF74")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEF84", Offset = "0x9BEF84")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEF94", Offset = "0x9BEF94")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEFA4", Offset = "0x9BEFA4")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEFB4", Offset = "0x9BEFB4")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700005C")]
		public Leg[] legs
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x1946654", Offset = "0x1946654", VA = "0x1946654")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C60A4", Offset = "0x9C60A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x194665C", Offset = "0x194665C", VA = "0x194665C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C60B4", Offset = "0x9C60B4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x1946664", Offset = "0x1946664", VA = "0x1946664")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C60C4", Offset = "0x9C60C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x194666C", Offset = "0x194666C", VA = "0x194666C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C60D4", Offset = "0x9C60D4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public bool isGrounded
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x1946674", Offset = "0x1946674", VA = "0x1946674")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C60E4", Offset = "0x9C60E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x194667C", Offset = "0x194667C", VA = "0x194667C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C60F4", Offset = "0x9C60F4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public Transform root
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x1946688", Offset = "0x1946688", VA = "0x1946688")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6104", Offset = "0x9C6104")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x1946690", Offset = "0x1946690", VA = "0x1946690")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6114", Offset = "0x9C6114")]
			private set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x1946698", Offset = "0x1946698", VA = "0x1946698")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6124", Offset = "0x9C6124")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x19466B0", Offset = "0x19466B0", VA = "0x19466B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6134", Offset = "0x9C6134")]
			private set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public bool rootGrounded
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x19466D0", Offset = "0x19466D0", VA = "0x19466D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000062")]
		public Vector3 up
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x1946B04", Offset = "0x1946B04", VA = "0x1946B04")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000063")]
		private bool useRootRotation
		{
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x1947C80", Offset = "0x1947C80", VA = "0x1947C80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1946724", Offset = "0x1946724", VA = "0x1946724")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1946B90", Offset = "0x1946B90", VA = "0x1946B90")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1943E38", Offset = "0x1943E38", VA = "0x1943E38")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x194507C", Offset = "0x194507C", VA = "0x194507C")]
		public void Update()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1947904", Offset = "0x1947904", VA = "0x1947904")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x19433D0", Offset = "0x19433D0", VA = "0x19433D0")]
		public void Reset()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1946E10", Offset = "0x1946E10", VA = "0x1946E10")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1947D50", Offset = "0x1947D50", VA = "0x1947D50")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1947EB8", Offset = "0x1947EB8", VA = "0x1947EB8")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1947FBC", Offset = "0x1947FBC", VA = "0x1947FBC")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1945A20", Offset = "0x1945A20", VA = "0x1945A20")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9BA02C", Offset = "0x9BA02C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BA02C", Offset = "0x9BA02C")]
	public class AimIK : IK
	{
		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1478714", Offset = "0x1478714", VA = "0x1478714", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6144", Offset = "0x9C6144")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1478760", Offset = "0x1478760", VA = "0x1478760", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C617C", Offset = "0x9C617C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x14787AC", Offset = "0x14787AC", VA = "0x14787AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C61B4", Offset = "0x9C61B4")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x14787F8", Offset = "0x14787F8", VA = "0x14787F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C61EC", Offset = "0x9C61EC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x1478844", Offset = "0x1478844", VA = "0x1478844")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6224", Offset = "0x9C6224")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1478890", Offset = "0x1478890", VA = "0x1478890", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1478898", Offset = "0x1478898", VA = "0x1478898")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9BA08C", Offset = "0x9BA08C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BA08C", Offset = "0x9BA08C")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x147A940", Offset = "0x147A940", VA = "0x147A940", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C625C", Offset = "0x9C625C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x147A98C", Offset = "0x147A98C", VA = "0x147A98C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6294", Offset = "0x9C6294")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x147A9D8", Offset = "0x147A9D8", VA = "0x147A9D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C62CC", Offset = "0x9C62CC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x147AA24", Offset = "0x147AA24", VA = "0x147AA24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6304", Offset = "0x9C6304")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x147AA70", Offset = "0x147AA70", VA = "0x147AA70", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x147AA78", Offset = "0x147AA78", VA = "0x147AA78")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9BA0EC", Offset = "0x9BA0EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BA0EC", Offset = "0x9BA0EC")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x147B394", Offset = "0x147B394", VA = "0x147B394", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C633C", Offset = "0x9C633C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x147B3E0", Offset = "0x147B3E0", VA = "0x147B3E0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6374", Offset = "0x9C6374")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x147B42C", Offset = "0x147B42C", VA = "0x147B42C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C63AC", Offset = "0x9C63AC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x147B478", Offset = "0x147B478", VA = "0x147B478")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C63E4", Offset = "0x9C63E4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x147B4C4", Offset = "0x147B4C4", VA = "0x147B4C4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x147B4CC", Offset = "0x147B4CC", VA = "0x147B4CC")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9BA14C", Offset = "0x9BA14C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BA14C", Offset = "0x9BA14C")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x147BB4C", Offset = "0x147BB4C", VA = "0x147BB4C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C641C", Offset = "0x9C641C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x147BB98", Offset = "0x147BB98", VA = "0x147BB98", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6454", Offset = "0x9C6454")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x147BBE4", Offset = "0x147BBE4", VA = "0x147BBE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C648C", Offset = "0x9C648C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x147BC30", Offset = "0x147BC30", VA = "0x147BC30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C64C4", Offset = "0x9C64C4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x147BC7C", Offset = "0x147BC7C", VA = "0x147BC7C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x147BC84", Offset = "0x147BC84", VA = "0x147BC84")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9BA1AC", Offset = "0x9BA1AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BA1AC", Offset = "0x9BA1AC")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x14837E0", Offset = "0x14837E0", VA = "0x14837E0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C64FC", Offset = "0x9C64FC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x148382C", Offset = "0x148382C", VA = "0x148382C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6534", Offset = "0x9C6534")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1483878", Offset = "0x1483878", VA = "0x1483878")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C656C", Offset = "0x9C656C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x14838C4", Offset = "0x14838C4", VA = "0x14838C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C65A4", Offset = "0x9C65A4")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1483910", Offset = "0x1483910", VA = "0x1483910")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C65DC", Offset = "0x9C65DC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x148395C", Offset = "0x148395C", VA = "0x148395C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6614", Offset = "0x9C6614")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x14839A8", Offset = "0x14839A8", VA = "0x14839A8")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x14839CC", Offset = "0x14839CC", VA = "0x14839CC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x14839D4", Offset = "0x14839D4", VA = "0x14839D4")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1483B90", Offset = "0x1483B90", VA = "0x1483B90")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1483EE4", Offset = "0x1483EE4", VA = "0x1483EE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C664C", Offset = "0x9C664C")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1483F04", Offset = "0x1483F04", VA = "0x1483F04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6684", Offset = "0x9C6684")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1483FE0", Offset = "0x1483FE0", VA = "0x1483FE0")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x60004D4")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x194BAD8", Offset = "0x194BAD8", VA = "0x194BAD8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x194BBC4", Offset = "0x194BBC4", VA = "0x194BBC4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x194BD80", Offset = "0x194BD80", VA = "0x194BD80", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60004D8")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60004D9")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x194BDE0", Offset = "0x194BDE0", VA = "0x194BDE0")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BEFC4", Offset = "0x9BEFC4")]
		public IK[] IKComponents;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BEFFC", Offset = "0x9BEFFC")]
		public Animator animator;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000064")]
		private bool animatePhysics
		{
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x194ECF4", Offset = "0x194ECF4", VA = "0x194ECF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x194ED90", Offset = "0x194ED90", VA = "0x194ED90")]
		private void Start()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x194EE00", Offset = "0x194EE00", VA = "0x194EE00")]
		private void Update()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x194EEBC", Offset = "0x194EEBC", VA = "0x194EEBC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x194EEF8", Offset = "0x194EEF8", VA = "0x194EEF8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x194EE34", Offset = "0x194EE34", VA = "0x194EE34")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x194EF84", Offset = "0x194EF84", VA = "0x194EF84")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BA20C", Offset = "0x9BA20C")]
	public class LegIK : IK
	{
		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x16AC8BC", Offset = "0x16AC8BC", VA = "0x16AC8BC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C66BC", Offset = "0x9C66BC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x16AC928", Offset = "0x16AC928", VA = "0x16AC928", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C66F4", Offset = "0x9C66F4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x16AC994", Offset = "0x16AC994", VA = "0x16AC994")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C672C", Offset = "0x9C672C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x16AC9E0", Offset = "0x16AC9E0", VA = "0x16AC9E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6764", Offset = "0x9C6764")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x16ACA2C", Offset = "0x16ACA2C", VA = "0x16ACA2C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x16ACA34", Offset = "0x16ACA34", VA = "0x16ACA34")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9BA244", Offset = "0x9BA244")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BA244", Offset = "0x9BA244")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x16ACA9C", Offset = "0x16ACA9C", VA = "0x16ACA9C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C679C", Offset = "0x9C679C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x16ACAE8", Offset = "0x16ACAE8", VA = "0x16ACAE8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C67D4", Offset = "0x9C67D4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x16ACB34", Offset = "0x16ACB34", VA = "0x16ACB34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C680C", Offset = "0x9C680C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x16ACB80", Offset = "0x16ACB80", VA = "0x16ACB80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6844", Offset = "0x9C6844")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x16ACBCC", Offset = "0x16ACBCC", VA = "0x16ACBCC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x16ACBD4", Offset = "0x16ACBD4", VA = "0x16ACBD4")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9BA2A4", Offset = "0x9BA2A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BA2A4", Offset = "0x9BA2A4")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x16ACC3C", Offset = "0x16ACC3C", VA = "0x16ACC3C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C687C", Offset = "0x9C687C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x16ACC88", Offset = "0x16ACC88", VA = "0x16ACC88", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C68B4", Offset = "0x9C68B4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x16ACCD4", Offset = "0x16ACCD4", VA = "0x16ACCD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C68EC", Offset = "0x9C68EC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x16ACD20", Offset = "0x16ACD20", VA = "0x16ACD20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6924", Offset = "0x9C6924")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x16ACD6C", Offset = "0x16ACD6C", VA = "0x16ACD6C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x16ACD74", Offset = "0x16ACD74", VA = "0x16ACD74")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9BA304", Offset = "0x9BA304")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BA304", Offset = "0x9BA304")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1CBC414", Offset = "0x1CBC414", VA = "0x1CBC414", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C695C", Offset = "0x9C695C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1CBC460", Offset = "0x1CBC460", VA = "0x1CBC460", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6994", Offset = "0x9C6994")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1CBC4AC", Offset = "0x1CBC4AC", VA = "0x1CBC4AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C69CC", Offset = "0x9C69CC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1CBC4F8", Offset = "0x1CBC4F8", VA = "0x1CBC4F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6A04", Offset = "0x9C6A04")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1CBC544", Offset = "0x1CBC544", VA = "0x1CBC544", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1CBC54C", Offset = "0x1CBC54C", VA = "0x1CBC54C")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BA364", Offset = "0x9BA364")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x200012D")]
		public class References
		{
			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform chest;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform neck;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform leftShoulder;

			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Transform rightShoulder;

			[Token(Token = "0x400081C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x400081E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x400081F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Transform leftThigh;

			[Token(Token = "0x4000820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Transform leftCalf;

			[Token(Token = "0x4000821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Transform leftFoot;

			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Transform leftToes;

			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public Transform rightThigh;

			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Transform rightCalf;

			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Transform rightFoot;

			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public Transform rightToes;

			[Token(Token = "0x170000D5")]
			public bool isFilled
			{
				[Token(Token = "0x6000869")]
				[Address(RVA = "0x1CBDA34", Offset = "0x1CBDA34", VA = "0x1CBDA34")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000D6")]
			public bool isEmpty
			{
				[Token(Token = "0x600086A")]
				[Address(RVA = "0x1CBD5B8", Offset = "0x1CBD5B8", VA = "0x1CBD5B8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000868")]
			[Address(RVA = "0x1CBDE20", Offset = "0x1CBDE20", VA = "0x1CBDE20")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600086B")]
			[Address(RVA = "0x1CBD1A4", Offset = "0x1CBD1A4", VA = "0x1CBD1A4")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x600086C")]
			[Address(RVA = "0x1CBDE18", Offset = "0x1CBDE18", VA = "0x1CBDE18")]
			public References()
			{
			}
		}

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x9BF034", Offset = "0x9BF034")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF034", Offset = "0x9BF034")]
		public References references;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF0B0", Offset = "0x9BF0B0")]
		public IKSolverVR solver;

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1CBD058", Offset = "0x1CBD058", VA = "0x1CBD058", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6A3C", Offset = "0x9C6A3C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1CBD0C4", Offset = "0x1CBD0C4", VA = "0x1CBD0C4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6A74", Offset = "0x9C6A74")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1CBD130", Offset = "0x1CBD130", VA = "0x1CBD130")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6AAC", Offset = "0x9C6AAC")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1CBD17C", Offset = "0x1CBD17C", VA = "0x1CBD17C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6AE4", Offset = "0x9C6AE4")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1CBD514", Offset = "0x1CBD514", VA = "0x1CBD514")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6B1C", Offset = "0x9C6B1C")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1CBD53C", Offset = "0x1CBD53C", VA = "0x1CBD53C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1CBD544", Offset = "0x1CBD544", VA = "0x1CBD544", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1CBDD90", Offset = "0x1CBDD90", VA = "0x1CBDD90")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A9")]
	public class FABRIKChain
	{
		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF0E8", Offset = "0x9BF0E8")]
		public float pull;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF100", Offset = "0x9BF100")]
		public float pin;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x147B534", Offset = "0x147B534", VA = "0x147B534")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x147B5FC", Offset = "0x147B5FC", VA = "0x147B5FC")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x147B61C", Offset = "0x147B61C", VA = "0x147B61C")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x147B9EC", Offset = "0x147B9EC", VA = "0x147B9EC")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x147B6F0", Offset = "0x147B6F0", VA = "0x147B6F0")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x147BAE4", Offset = "0x147BAE4", VA = "0x147BAE4")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x147BCEC", Offset = "0x147BCEC", VA = "0x147BCEC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x147C254", Offset = "0x147C254", VA = "0x147C254")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x147C414", Offset = "0x147C414", VA = "0x147C414")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x147C50C", Offset = "0x147C50C", VA = "0x147C50C")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200012E")]
		public class BendBone
		{
			[Token(Token = "0x4000827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1EE4", Offset = "0x9C1EE4")]
			public Transform transform;

			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1F1C", Offset = "0x9C1F1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C1F1C", Offset = "0x9C1F1C")]
			public float weight;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600086D")]
			[Address(RVA = "0x147F53C", Offset = "0x147F53C", VA = "0x147F53C")]
			public BendBone()
			{
			}

			[Token(Token = "0x600086E")]
			[Address(RVA = "0x147F5BC", Offset = "0x147F5BC", VA = "0x147F5BC")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x600086F")]
			[Address(RVA = "0x147CCCC", Offset = "0x147CCCC", VA = "0x147CCCC")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000870")]
			[Address(RVA = "0x147D0D0", Offset = "0x147D0D0", VA = "0x147D0D0")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF118", Offset = "0x9BF118")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BF150", Offset = "0x9BF150")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF150", Offset = "0x9BF150")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF150", Offset = "0x9BF150")]
		public float positionWeight;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF1C8", Offset = "0x9BF1C8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF1C8", Offset = "0x9BF1C8")]
		public float bodyWeight;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF21C", Offset = "0x9BF21C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF21C", Offset = "0x9BF21C")]
		public float thighWeight;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF270", Offset = "0x9BF270")]
		public bool handsPullBody;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BF2A8", Offset = "0x9BF2A8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF2A8", Offset = "0x9BF2A8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF2A8", Offset = "0x9BF2A8")]
		public float rotationWeight;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF320", Offset = "0x9BF320")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF320", Offset = "0x9BF320")]
		public float bodyClampWeight;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF374", Offset = "0x9BF374")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF374", Offset = "0x9BF374")]
		public float headClampWeight;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF3C8", Offset = "0x9BF3C8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF3C8", Offset = "0x9BF3C8")]
		public float bendWeight;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF41C", Offset = "0x9BF41C")]
		public BendBone[] bendBones;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BF454", Offset = "0x9BF454")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF454", Offset = "0x9BF454")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF454", Offset = "0x9BF454")]
		public float CCDWeight;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF4CC", Offset = "0x9BF4CC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF4CC", Offset = "0x9BF4CC")]
		public float roll;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF520", Offset = "0x9BF520")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF520", Offset = "0x9BF520")]
		public float damper;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF578", Offset = "0x9BF578")]
		public Transform[] CCDBones;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BF5B0", Offset = "0x9BF5B0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF5B0", Offset = "0x9BF5B0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF5B0", Offset = "0x9BF5B0")]
		public float postStretchWeight;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF628", Offset = "0x9BF628")]
		public float maxStretch;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF660", Offset = "0x9BF660")]
		public float stretchDamper;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF698", Offset = "0x9BF698")]
		public bool fixHead;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF6D0", Offset = "0x9BF6D0")]
		public Transform[] stretchBones;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BF708", Offset = "0x9BF708")]
		public Vector3 chestDirection;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF740", Offset = "0x9BF740")]
		public float chestDirectionWeight;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x147C514", Offset = "0x147C514", VA = "0x147C514")]
		private void Start()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x147C844", Offset = "0x147C844", VA = "0x147C844")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x147CD04", Offset = "0x147CD04", VA = "0x147CD04")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x147D0F8", Offset = "0x147D0F8", VA = "0x147D0F8")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x147DA70", Offset = "0x147DA70", VA = "0x147DA70")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x147DDBC", Offset = "0x147DDBC", VA = "0x147DDBC")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x147E158", Offset = "0x147E158", VA = "0x147E158")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x147EBC4", Offset = "0x147EBC4", VA = "0x147EBC4")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x147D79C", Offset = "0x147D79C", VA = "0x147D79C")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x147EDD4", Offset = "0x147EDD4", VA = "0x147EDD4")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x147EA80", Offset = "0x147EA80", VA = "0x147EA80")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x147E8E4", Offset = "0x147E8E4", VA = "0x147E8E4")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x147F140", Offset = "0x147F140", VA = "0x147F140")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x147F3C0", Offset = "0x147F3C0", VA = "0x147F3C0")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AC")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x200012F")]
		public class ChildConstraint
		{
			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C1F90", Offset = "0x9C1F90")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C1FA0", Offset = "0x9C1FA0")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x170000D7")]
			public float nominalDistance
			{
				[Token(Token = "0x6000871")]
				[Address(RVA = "0x1482480", Offset = "0x1482480", VA = "0x1482480")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7D50", Offset = "0x9C7D50")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000872")]
				[Address(RVA = "0x1482488", Offset = "0x1482488", VA = "0x1482488")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7D60", Offset = "0x9C7D60")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D8")]
			public bool isRigid
			{
				[Token(Token = "0x6000873")]
				[Address(RVA = "0x1482490", Offset = "0x1482490", VA = "0x1482490")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7D70", Offset = "0x9C7D70")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000874")]
				[Address(RVA = "0x1482498", Offset = "0x1482498", VA = "0x1482498")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7D80", Offset = "0x9C7D80")]
				private set
				{
				}
			}

			[Token(Token = "0x6000875")]
			[Address(RVA = "0x14824A4", Offset = "0x14824A4", VA = "0x14824A4")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000876")]
			[Address(RVA = "0x1480204", Offset = "0x1480204", VA = "0x1480204")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0x1480744", Offset = "0x1480744", VA = "0x1480744")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000878")]
			[Address(RVA = "0x148217C", Offset = "0x148217C", VA = "0x148217C")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000130")]
		public enum Smoothing
		{
			[Token(Token = "0x4000835")]
			None,
			[Token(Token = "0x4000836")]
			Exponential,
			[Token(Token = "0x4000837")]
			Cubic
		}

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF758", Offset = "0x9BF758")]
		public float pin;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF770", Offset = "0x9BF770")]
		public float pull;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF788", Offset = "0x9BF788")]
		public float push;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF7A0", Offset = "0x9BF7A0")]
		public float pushParent;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF7B8", Offset = "0x9BF7B8")]
		public float reach;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x40004F6")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x147F660", Offset = "0x147F660", VA = "0x147F660")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x147F72C", Offset = "0x147F72C", VA = "0x147F72C")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x147F838", Offset = "0x147F838", VA = "0x147F838")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x147F95C", Offset = "0x147F95C", VA = "0x147F95C")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x147FA38", Offset = "0x147FA38", VA = "0x147FA38")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x147FB3C", Offset = "0x147FB3C", VA = "0x147FB3C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x148025C", Offset = "0x148025C", VA = "0x148025C")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x147FCCC", Offset = "0x147FCCC", VA = "0x147FCCC")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1480948", Offset = "0x1480948", VA = "0x1480948")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1480CEC", Offset = "0x1480CEC", VA = "0x1480CEC")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x14810D0", Offset = "0x14810D0", VA = "0x14810D0")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1481654", Offset = "0x1481654", VA = "0x1481654")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1481C24", Offset = "0x1481C24", VA = "0x1481C24")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1481EBC", Offset = "0x1481EBC", VA = "0x1481EBC")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1481B1C", Offset = "0x1481B1C", VA = "0x1481B1C")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x148143C", Offset = "0x148143C", VA = "0x148143C")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1481AA4", Offset = "0x1481AA4", VA = "0x1481AA4")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1481FA4", Offset = "0x1481FA4", VA = "0x1481FA4")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x14819C4", Offset = "0x14819C4", VA = "0x14819C4")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1481DA4", Offset = "0x1481DA4", VA = "0x1481DA4")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AD")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF7D0", Offset = "0x9BF7D0")]
		public float weight;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF7E8", Offset = "0x9BF7E8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000065")]
		public bool initiated
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x194BFB0", Offset = "0x194BFB0", VA = "0x194BFB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6B54", Offset = "0x9C6B54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x194BFB8", Offset = "0x194BFB8", VA = "0x194BFB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6B64", Offset = "0x9C6B64")]
			private set
			{
			}
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x194BDE8", Offset = "0x194BDE8", VA = "0x194BDE8")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x194BFC4", Offset = "0x194BFC4", VA = "0x194BFC4")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x194C048", Offset = "0x194C048", VA = "0x194C048")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x194C0F4", Offset = "0x194C0F4", VA = "0x194C0F4")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x194C100", Offset = "0x194C100", VA = "0x194C100")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x194C5C4", Offset = "0x194C5C4", VA = "0x194C5C4")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x194C7F4", Offset = "0x194C7F4", VA = "0x194C7F4")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x194CC90", Offset = "0x194CC90", VA = "0x194CC90")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x194C384", Offset = "0x194C384", VA = "0x194C384")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x194C4A4", Offset = "0x194C4A4", VA = "0x194C4A4")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000AE")]
	public class IKEffector
	{
		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF7F8", Offset = "0x9BF7F8")]
		public float positionWeight;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF810", Offset = "0x9BF810")]
		public float rotationWeight;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF828", Offset = "0x9BF828")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF838", Offset = "0x9BF838")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000066")]
		public bool isEndEffector
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x194D2FC", Offset = "0x194D2FC", VA = "0x194D2FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6B74", Offset = "0x9C6B74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x194D304", Offset = "0x194D304", VA = "0x194D304")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6B84", Offset = "0x9C6B84")]
			private set
			{
			}
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x194D294", Offset = "0x194D294", VA = "0x194D294")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x194D310", Offset = "0x194D310", VA = "0x194D310")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x194D3E4", Offset = "0x194D3E4", VA = "0x194D3E4")]
		public IKEffector()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x194D520", Offset = "0x194D520", VA = "0x194D520")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x194D678", Offset = "0x194D678", VA = "0x194D678")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x194D968", Offset = "0x194D968", VA = "0x194D968")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x194DC08", Offset = "0x194DC08", VA = "0x194DC08")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x194DD48", Offset = "0x194DD48", VA = "0x194DD48")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x194DDF4", Offset = "0x194DDF4", VA = "0x194DDF4")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x194E448", Offset = "0x194E448", VA = "0x194E448")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x194E4B8", Offset = "0x194E4B8", VA = "0x194E4B8")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x194E6D0", Offset = "0x194E6D0", VA = "0x194E6D0")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x194EA18", Offset = "0x194EA18", VA = "0x194EA18")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000AF")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000131")]
		public class BoneMap
		{
			[Token(Token = "0x4000838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x400083A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x4000844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x4000845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x4000848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x4000849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x400084A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x400084B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x400084C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x170000D9")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x600087A")]
				[Address(RVA = "0x194F1F8", Offset = "0x194F1F8", VA = "0x194F1F8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000DA")]
			public bool isNodeBone
			{
				[Token(Token = "0x600087D")]
				[Address(RVA = "0x194F364", Offset = "0x194F364", VA = "0x194F364")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000DB")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000891")]
				[Address(RVA = "0x194F948", Offset = "0x194F948", VA = "0x194F948")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000879")]
			[Address(RVA = "0x194F1CC", Offset = "0x194F1CC", VA = "0x194F1CC")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600087B")]
			[Address(RVA = "0x194F2C4", Offset = "0x194F2C4", VA = "0x194F2C4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600087C")]
			[Address(RVA = "0x194F314", Offset = "0x194F314", VA = "0x194F314")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x600087E")]
			[Address(RVA = "0x194F374", Offset = "0x194F374", VA = "0x194F374")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0x194F45C", Offset = "0x194F45C", VA = "0x194F45C")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0x194F464", Offset = "0x194F464", VA = "0x194F464")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000881")]
			[Address(RVA = "0x194F5F4", Offset = "0x194F5F4", VA = "0x194F5F4")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000882")]
			[Address(RVA = "0x194F700", Offset = "0x194F700", VA = "0x194F700")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000883")]
			[Address(RVA = "0x194F798", Offset = "0x194F798", VA = "0x194F798")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000884")]
			[Address(RVA = "0x194FB6C", Offset = "0x194FB6C", VA = "0x194FB6C")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000885")]
			[Address(RVA = "0x194FBA4", Offset = "0x194FBA4", VA = "0x194FBA4")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000886")]
			[Address(RVA = "0x194FBDC", Offset = "0x194FBDC", VA = "0x194FBDC")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000887")]
			[Address(RVA = "0x194FC04", Offset = "0x194FC04", VA = "0x194FC04")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000888")]
			[Address(RVA = "0x194FD30", Offset = "0x194FD30", VA = "0x194FD30")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000889")]
			[Address(RVA = "0x1950078", Offset = "0x1950078", VA = "0x1950078")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600088A")]
			[Address(RVA = "0x19500A8", Offset = "0x19500A8", VA = "0x19500A8")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600088B")]
			[Address(RVA = "0x1950240", Offset = "0x1950240", VA = "0x1950240")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x600088C")]
			[Address(RVA = "0x19502B0", Offset = "0x19502B0", VA = "0x19502B0")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x600088D")]
			[Address(RVA = "0x19504F4", Offset = "0x19504F4", VA = "0x19504F4")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x600088E")]
			[Address(RVA = "0x195071C", Offset = "0x195071C", VA = "0x195071C")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x600088F")]
			[Address(RVA = "0x1950834", Offset = "0x1950834", VA = "0x1950834")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000890")]
			[Address(RVA = "0x194FE74", Offset = "0x194FE74", VA = "0x194FE74")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000892")]
			[Address(RVA = "0x19509D0", Offset = "0x19509D0", VA = "0x19509D0")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x194EF8C", Offset = "0x194EF8C", VA = "0x194EF8C", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x194EF94", Offset = "0x194EF94", VA = "0x194EF94", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x194EF98", Offset = "0x194EF98", VA = "0x194EF98")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x194F0BC", Offset = "0x194F0BC", VA = "0x194F0BC")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x194F1C4", Offset = "0x194F1C4", VA = "0x194F1C4")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF850", Offset = "0x9BF850")]
		public float maintainRotationWeight;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x19509EC", Offset = "0x19509EC", VA = "0x19509EC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1950A8C", Offset = "0x1950A8C", VA = "0x1950A8C")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1950B10", Offset = "0x1950B10", VA = "0x1950B10")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1950BA8", Offset = "0x1950BA8", VA = "0x1950BA8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1950BC0", Offset = "0x1950BC0", VA = "0x1950BC0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1950BDC", Offset = "0x1950BDC", VA = "0x1950BDC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1950C78", Offset = "0x1950C78", VA = "0x1950C78")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1950C90", Offset = "0x1950C90", VA = "0x1950C90")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000132")]
		public enum BoneMapType
		{
			[Token(Token = "0x400084F")]
			Parent,
			[Token(Token = "0x4000850")]
			Bone1,
			[Token(Token = "0x4000851")]
			Bone2,
			[Token(Token = "0x4000852")]
			Bone3
		}

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF868", Offset = "0x9BF868")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF880", Offset = "0x9BF880")]
		public float weight;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1950CB4", Offset = "0x1950CB4", VA = "0x1950CB4", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1950D38", Offset = "0x1950D38", VA = "0x1950D38")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1950E0C", Offset = "0x1950E0C", VA = "0x1950E0C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1951160", Offset = "0x1951160", VA = "0x1951160")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1951260", Offset = "0x1951260", VA = "0x1951260")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x195138C", Offset = "0x195138C", VA = "0x195138C")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1951398", Offset = "0x1951398", VA = "0x1951398")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1951440", Offset = "0x1951440", VA = "0x1951440")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x19514F8", Offset = "0x19514F8", VA = "0x19514F8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1951768", Offset = "0x1951768", VA = "0x1951768")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1951820", Offset = "0x1951820", VA = "0x1951820")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B2")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF898", Offset = "0x9BF898")]
		public int iterations;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF8B0", Offset = "0x9BF8B0")]
		public float twistWeight;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x195198C", Offset = "0x195198C", VA = "0x195198C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1951C7C", Offset = "0x1951C7C", VA = "0x1951C7C")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1951D98", Offset = "0x1951D98", VA = "0x1951D98")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1951EF0", Offset = "0x1951EF0", VA = "0x1951EF0")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1951F00", Offset = "0x1951F00", VA = "0x1951F00")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1951F68", Offset = "0x1951F68", VA = "0x1951F68")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1951FE8", Offset = "0x1951FE8", VA = "0x1951FE8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x195263C", Offset = "0x195263C", VA = "0x195263C")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1952674", Offset = "0x1952674", VA = "0x1952674")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1952954", Offset = "0x1952954", VA = "0x1952954")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1952D08", Offset = "0x1952D08", VA = "0x1952D08")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1952DF4", Offset = "0x1952DF4", VA = "0x1952DF4")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1952EBC", Offset = "0x1952EBC", VA = "0x1952EBC")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B3")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000133")]
		public class Point
		{
			[Token(Token = "0x4000853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C1FB0", Offset = "0x9C1FB0")]
			public float weight;

			[Token(Token = "0x4000855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000893")]
			[Address(RVA = "0x19549E4", Offset = "0x19549E4", VA = "0x19549E4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000894")]
			[Address(RVA = "0x1954A34", Offset = "0x1954A34", VA = "0x1954A34")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000895")]
			[Address(RVA = "0x1954BBC", Offset = "0x1954BBC", VA = "0x1954BBC")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000896")]
			[Address(RVA = "0x1954BF4", Offset = "0x1954BF4", VA = "0x1954BF4")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000897")]
			[Address(RVA = "0x1954C2C", Offset = "0x1954C2C", VA = "0x1954C2C")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000898")]
			[Address(RVA = "0x1954C7C", Offset = "0x1954C7C", VA = "0x1954C7C")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000899")]
			[Address(RVA = "0x19544B8", Offset = "0x19544B8", VA = "0x19544B8")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000134")]
		public class Bone : Point
		{
			[Token(Token = "0x4000859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x400085A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x400085B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x400085C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x400085D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x170000DC")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600089A")]
				[Address(RVA = "0x1953A88", Offset = "0x1953A88", VA = "0x1953A88")]
				get
				{
					return null;
				}
				[Token(Token = "0x600089B")]
				[Address(RVA = "0x1953B7C", Offset = "0x1953B7C", VA = "0x1953B7C")]
				set
				{
				}
			}

			[Token(Token = "0x600089C")]
			[Address(RVA = "0x1953C04", Offset = "0x1953C04", VA = "0x1953C04")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600089D")]
			[Address(RVA = "0x1953EC4", Offset = "0x1953EC4", VA = "0x1953EC4")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600089E")]
			[Address(RVA = "0x19541A4", Offset = "0x19541A4", VA = "0x19541A4")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600089F")]
			[Address(RVA = "0x195440C", Offset = "0x195440C", VA = "0x195440C")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x1954434", Offset = "0x1954434", VA = "0x1954434")]
			public Bone()
			{
			}

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x1954538", Offset = "0x1954538", VA = "0x1954538")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x19545D0", Offset = "0x19545D0", VA = "0x19545D0")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000135")]
		public class Node : Point
		{
			[Token(Token = "0x400085E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x400085F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000860")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x1954980", Offset = "0x1954980", VA = "0x1954980")]
			public Node()
			{
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x1954984", Offset = "0x1954984", VA = "0x1954984")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x19549AC", Offset = "0x19549AC", VA = "0x19549AC")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000136")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000137")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF8D8", Offset = "0x9BF8D8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF8D8", Offset = "0x9BF8D8")]
		public float IKPositionWeight;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF92C", Offset = "0x9BF92C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000067")]
		public bool initiated
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x19534D8", Offset = "0x19534D8", VA = "0x19534D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6B94", Offset = "0x9C6B94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x19534E0", Offset = "0x19534E0", VA = "0x19534E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6BA4", Offset = "0x9C6BA4")]
			private set
			{
			}
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x19531A4", Offset = "0x19531A4", VA = "0x19531A4")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600056F")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x194BC34", Offset = "0x194BC34", VA = "0x194BC34")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x194BB5C", Offset = "0x194BB5C", VA = "0x194BB5C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x195342C", Offset = "0x195342C", VA = "0x195342C", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1953438", Offset = "0x1953438", VA = "0x1953438")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1953444", Offset = "0x1953444", VA = "0x1953444")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x195344C", Offset = "0x195344C", VA = "0x195344C")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x19534D0", Offset = "0x19534D0", VA = "0x19534D0")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000579")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x600057A")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x600057B")]
		public abstract void FixTransforms();

		[Token(Token = "0x600057C")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x600057D")]
		protected abstract void OnInitiate();

		[Token(Token = "0x600057E")]
		protected abstract void OnUpdate();

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x19534EC", Offset = "0x19534EC", VA = "0x19534EC")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1953504", Offset = "0x1953504", VA = "0x1953504")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1953640", Offset = "0x1953640", VA = "0x1953640")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x19536EC", Offset = "0x19536EC", VA = "0x19536EC")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1953A70", Offset = "0x1953A70", VA = "0x1953A70")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B4")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF974", Offset = "0x9BF974")]
		public float poleWeight;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF98C", Offset = "0x9BF98C")]
		public float clampWeight;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF9A4", Offset = "0x9BF9A4")]
		public int clampSmoothing;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000068")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000585")]
			[Address(RVA = "0x1954E04", Offset = "0x1954E04", VA = "0x1954E04")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000069")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x1954ED0", Offset = "0x1954ED0", VA = "0x1954ED0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006A")]
		protected override int minBones
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x1955C40", Offset = "0x1955C40", VA = "0x1955C40", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006B")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x19561E4", Offset = "0x19561E4", VA = "0x19561E4", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1954D04", Offset = "0x1954D04", VA = "0x1954D04")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1954F9C", Offset = "0x1954F9C", VA = "0x1954F9C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x195521C", Offset = "0x195521C", VA = "0x195521C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1955B8C", Offset = "0x1955B8C", VA = "0x1955B8C")]
		private void Solve()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x19557B4", Offset = "0x19557B4", VA = "0x19557B4")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1955C48", Offset = "0x1955C48", VA = "0x1955C48")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1956258", Offset = "0x1956258", VA = "0x1956258")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B5")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x19562F0", Offset = "0x19562F0", VA = "0x19562F0")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x19563A0", Offset = "0x19563A0", VA = "0x19563A0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1956424", Offset = "0x1956424", VA = "0x1956424", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1956720", Offset = "0x1956720", VA = "0x1956720")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1956E74", Offset = "0x1956E74", VA = "0x1956E74")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B6")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x1700006C")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x19580A4", Offset = "0x19580A4", VA = "0x19580A4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1956E7C", Offset = "0x1956E7C", VA = "0x1956E7C")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x19575C4", Offset = "0x19575C4", VA = "0x19575C4")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x19576FC", Offset = "0x19576FC", VA = "0x19576FC", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1957794", Offset = "0x1957794", VA = "0x1957794", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1957D3C", Offset = "0x1957D3C", VA = "0x1957D3C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x19580AC", Offset = "0x19580AC", VA = "0x19580AC")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1956F50", Offset = "0x1956F50", VA = "0x1956F50")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x19576A8", Offset = "0x19576A8", VA = "0x19576A8")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1958048", Offset = "0x1958048", VA = "0x1958048")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x19573EC", Offset = "0x19573EC", VA = "0x19573EC")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x19588EC", Offset = "0x19588EC", VA = "0x19588EC")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x19589FC", Offset = "0x19589FC", VA = "0x19589FC")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1958B28", Offset = "0x1958B28", VA = "0x1958B28")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1958C40", Offset = "0x1958C40", VA = "0x1958C40")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1957AA4", Offset = "0x1957AA4", VA = "0x1957AA4")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1957BF0", Offset = "0x1957BF0", VA = "0x1957BF0")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1958E2C", Offset = "0x1958E2C", VA = "0x1958E2C")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1958364", Offset = "0x1958364", VA = "0x1958364")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1957698", Offset = "0x1957698", VA = "0x1957698")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1959594", Offset = "0x1959594", VA = "0x1959594")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1959000", Offset = "0x1959000", VA = "0x1959000")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x19581C4", Offset = "0x19581C4", VA = "0x19581C4")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x19582A0", Offset = "0x19582A0", VA = "0x19582A0")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1959660", Offset = "0x1959660", VA = "0x1959660")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B7")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF9BC", Offset = "0x9BF9BC")]
		public float rootPin;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x19596D8", Offset = "0x19596D8", VA = "0x19596D8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1959FA4", Offset = "0x1959FA4", VA = "0x1959FA4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x195A03C", Offset = "0x195A03C", VA = "0x195A03C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x195A0DC", Offset = "0x195A0DC", VA = "0x195A0DC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x195A1DC", Offset = "0x195A1DC", VA = "0x195A1DC")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x195A278", Offset = "0x195A278", VA = "0x195A278", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x195A7E0", Offset = "0x195A7E0", VA = "0x195A7E0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x195A9E0", Offset = "0x195A9E0", VA = "0x195A9E0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x195A890", Offset = "0x195A890", VA = "0x195A890")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x195A4AC", Offset = "0x195A4AC", VA = "0x195A4AC")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x195AA78", Offset = "0x195AA78", VA = "0x195AA78")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B8")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF9D4", Offset = "0x9BF9D4")]
		public int iterations;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x195BAF0", Offset = "0x195BAF0", VA = "0x195BAF0")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x195BBE4", Offset = "0x195BBE4", VA = "0x195BBE4")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x195BC40", Offset = "0x195BC40", VA = "0x195BC40")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x195BD74", Offset = "0x195BD74", VA = "0x195BD74")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x195BDD0", Offset = "0x195BDD0", VA = "0x195BDD0")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x195BE50", Offset = "0x195BE50", VA = "0x195BE50", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x195BFD8", Offset = "0x195BFD8", VA = "0x195BFD8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x195C14C", Offset = "0x195C14C", VA = "0x195C14C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x195C350", Offset = "0x195C350", VA = "0x195C350", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x195C428", Offset = "0x195C428", VA = "0x195C428", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x195C514", Offset = "0x195C514", VA = "0x195C514", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x195C688", Offset = "0x195C688", VA = "0x195C688", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x195C850", Offset = "0x195C850", VA = "0x195C850", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x195CA9C", Offset = "0x195CA9C", VA = "0x195CA9C", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x195CD78", Offset = "0x195CD78", VA = "0x195CD78", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x195CDBC", Offset = "0x195CDBC", VA = "0x195CDBC", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x195CEAC", Offset = "0x195CEAC", VA = "0x195CEAC")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B9")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x4000573")]
		Body,
		[Token(Token = "0x4000574")]
		LeftShoulder,
		[Token(Token = "0x4000575")]
		RightShoulder,
		[Token(Token = "0x4000576")]
		LeftThigh,
		[Token(Token = "0x4000577")]
		RightThigh,
		[Token(Token = "0x4000578")]
		LeftHand,
		[Token(Token = "0x4000579")]
		RightHand,
		[Token(Token = "0x400057A")]
		LeftFoot,
		[Token(Token = "0x400057B")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x20000BA")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x400057D")]
		LeftArm,
		[Token(Token = "0x400057E")]
		RightArm,
		[Token(Token = "0x400057F")]
		LeftLeg,
		[Token(Token = "0x4000580")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x20000BB")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF9EC", Offset = "0x9BF9EC")]
		public float spineStiffness;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BFA04", Offset = "0x9BFA04")]
		public float pullBodyVertical;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BFA1C", Offset = "0x9BFA1C")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BFA34", Offset = "0x9BFA34")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700006D")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x195CF84", Offset = "0x195CF84", VA = "0x195CF84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x195D0CC", Offset = "0x195D0CC", VA = "0x195D0CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x195D0D4", Offset = "0x195D0D4", VA = "0x195D0D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x195D0DC", Offset = "0x195D0DC", VA = "0x195D0DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x195D0E4", Offset = "0x195D0E4", VA = "0x195D0E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x195D0EC", Offset = "0x195D0EC", VA = "0x195D0EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x195D0F4", Offset = "0x195D0F4", VA = "0x195D0F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x195D0FC", Offset = "0x195D0FC", VA = "0x195D0FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x195D104", Offset = "0x195D104", VA = "0x195D104")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x195D10C", Offset = "0x195D10C", VA = "0x195D10C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x195D144", Offset = "0x195D144", VA = "0x195D144")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x195D17C", Offset = "0x195D17C", VA = "0x195D17C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x195D1B4", Offset = "0x195D1B4", VA = "0x195D1B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x195D1EC", Offset = "0x195D1EC", VA = "0x195D1EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x195D220", Offset = "0x195D220", VA = "0x195D220")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x195D258", Offset = "0x195D258", VA = "0x195D258")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x195D290", Offset = "0x195D290", VA = "0x195D290")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x195D2C8", Offset = "0x195D2C8", VA = "0x195D2C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x195F28C", Offset = "0x195F28C", VA = "0x195F28C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6BB4", Offset = "0x9C6BB4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x195F298", Offset = "0x195F298", VA = "0x195F298")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6BC4", Offset = "0x9C6BC4")]
			private set
			{
			}
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x195D2FC", Offset = "0x195D2FC", VA = "0x195D2FC")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x195D408", Offset = "0x195D408", VA = "0x195D408")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x195D350", Offset = "0x195D350", VA = "0x195D350")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x195D4E4", Offset = "0x195D4E4", VA = "0x195D4E4")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x195CF8C", Offset = "0x195CF8C", VA = "0x195CF8C")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x195D5B4", Offset = "0x195D5B4", VA = "0x195D5B4")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x195D66C", Offset = "0x195D66C", VA = "0x195D66C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x195D720", Offset = "0x195D720", VA = "0x195D720")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x195D7D4", Offset = "0x195D7D4", VA = "0x195D7D4")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x195D7DC", Offset = "0x195D7DC", VA = "0x195D7DC")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x195D810", Offset = "0x195D810", VA = "0x195D810")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x195D8D8", Offset = "0x195D8D8", VA = "0x195D8D8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x195DA68", Offset = "0x195DA68", VA = "0x195DA68")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x195EBA4", Offset = "0x195EBA4", VA = "0x195EBA4")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x195F038", Offset = "0x195F038", VA = "0x195F038")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x195F098", Offset = "0x195F098", VA = "0x195F098")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x195EEB8", Offset = "0x195EEB8", VA = "0x195EEB8")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x195EF78", Offset = "0x195EF78", VA = "0x195EF78")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x195F2A4", Offset = "0x195F2A4", VA = "0x195F2A4")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x195F380", Offset = "0x195F380", VA = "0x195F380", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x195F4C8", Offset = "0x195F4C8", VA = "0x195F4C8")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x195F658", Offset = "0x195F658", VA = "0x195F658")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x195F858", Offset = "0x195F858", VA = "0x195F858")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x195FA58", Offset = "0x195FA58", VA = "0x195FA58", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x195FD8C", Offset = "0x195FD8C", VA = "0x195FD8C", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x195FE8C", Offset = "0x195FE8C", VA = "0x195FE8C")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BC")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000080")]
		protected virtual int minBones
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x19606DC", Offset = "0x19606DC", VA = "0x19606DC", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000081")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x19606E4", Offset = "0x19606E4", VA = "0x19606E4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000082")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x19606EC", Offset = "0x19606EC", VA = "0x19606EC", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000083")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x1960C7C", Offset = "0x1960C7C", VA = "0x1960C7C", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000084")]
		protected float positionOffset
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x1960DB0", Offset = "0x1960DB0", VA = "0x1960DB0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x195FE98", Offset = "0x195FE98", VA = "0x195FE98")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x196002C", Offset = "0x196002C", VA = "0x196002C")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x1960168", Offset = "0x1960168", VA = "0x1960168", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x19601D4", Offset = "0x19601D4", VA = "0x19601D4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1960254", Offset = "0x1960254", VA = "0x1960254", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x19605E0", Offset = "0x19605E0", VA = "0x19605E0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x19605E8", Offset = "0x19605E8", VA = "0x19605E8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x19606F4", Offset = "0x19606F4", VA = "0x19606F4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x19606F8", Offset = "0x19606F8", VA = "0x19606F8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x19606FC", Offset = "0x19606FC", VA = "0x19606FC")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x1960E74", Offset = "0x1960E74", VA = "0x1960E74")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x1961218", Offset = "0x1961218", VA = "0x1961218")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x19614CC", Offset = "0x19614CC", VA = "0x19614CC")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BD")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BFA44", Offset = "0x9BFA44")]
		public float IKRotationWeight;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x196153C", Offset = "0x196153C", VA = "0x196153C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x19618B0", Offset = "0x19618B0", VA = "0x19618B0")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x1961920", Offset = "0x1961920", VA = "0x1961920", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x1961A7C", Offset = "0x1961A7C", VA = "0x1961A7C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x1961C14", Offset = "0x1961C14", VA = "0x1961C14", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x1961C70", Offset = "0x1961C70", VA = "0x1961C70", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x1961CE0", Offset = "0x1961CE0", VA = "0x1961CE0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x1962044", Offset = "0x1962044", VA = "0x1962044", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x1962070", Offset = "0x1962070", VA = "0x1962070")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x1961D44", Offset = "0x1961D44", VA = "0x1961D44")]
		private void Read()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x1962174", Offset = "0x1962174", VA = "0x1962174")]
		private void Write()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x1962580", Offset = "0x1962580", VA = "0x1962580")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BE")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x2000138")]
		public enum BendModifier
		{
			[Token(Token = "0x4000863")]
			Animation,
			[Token(Token = "0x4000864")]
			Target,
			[Token(Token = "0x4000865")]
			Parent,
			[Token(Token = "0x4000866")]
			Arm,
			[Token(Token = "0x4000867")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x2000139")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x1963EE8", Offset = "0x1963EE8", VA = "0x1963EE8")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BFA5C", Offset = "0x9BFA5C")]
		public float maintainRotationWeight;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BFA74", Offset = "0x9BFA74")]
		public float bendModifierWeight;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000085")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x1963ECC", Offset = "0x1963ECC", VA = "0x1963ECC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x19627C8", Offset = "0x19627C8", VA = "0x19627C8")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x1962818", Offset = "0x1962818", VA = "0x1962818")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x196292C", Offset = "0x196292C", VA = "0x196292C", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1962F9C", Offset = "0x1962F9C", VA = "0x1962F9C", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x1963B78", Offset = "0x1963B78", VA = "0x1963B78", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1963CC0", Offset = "0x1963CC0", VA = "0x1963CC0")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x1963E44", Offset = "0x1963E44", VA = "0x1963E44")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1962CA8", Offset = "0x1962CA8", VA = "0x1962CA8")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x19630C8", Offset = "0x19630C8", VA = "0x19630C8")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000BF")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200013A")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x170000DD")]
			public Vector3 forward
			{
				[Token(Token = "0x60008B3")]
				[Address(RVA = "0x1965D88", Offset = "0x1965D88", VA = "0x1965D88")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x196679C", Offset = "0x196679C", VA = "0x196679C")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x1965124", Offset = "0x1965124", VA = "0x1965124")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x1965460", Offset = "0x1965460", VA = "0x1965460")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x196618C", Offset = "0x196618C", VA = "0x196618C")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Transform cameraTr;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int LevelNum;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BFA8C", Offset = "0x9BFA8C")]
		public float bodyWeight;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BFAA4", Offset = "0x9BFAA4")]
		public float headWeight;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BFABC", Offset = "0x9BFABC")]
		public float eyesWeight;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BFAD4", Offset = "0x9BFAD4")]
		public float clampWeight;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BFAEC", Offset = "0x9BFAEC")]
		public float clampWeightHead;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BFB04", Offset = "0x9BFB04")]
		public float clampWeightEyes;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BFB1C", Offset = "0x9BFB1C")]
		public int clampSmoothing;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] headForwards;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x17000086")]
		private bool spineIsValid
		{
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x1964888", Offset = "0x1964888", VA = "0x1964888")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000087")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x1964A60", Offset = "0x1964A60", VA = "0x1964A60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000088")]
		private bool headIsValid
		{
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x196496C", Offset = "0x196496C", VA = "0x196496C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000089")]
		private bool headIsEmpty
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x1964A84", Offset = "0x1964A84", VA = "0x1964A84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008A")]
		private bool eyesIsValid
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x196497C", Offset = "0x196497C", VA = "0x196497C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x1964B00", Offset = "0x1964B00", VA = "0x1964B00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x1963F48", Offset = "0x1963F48", VA = "0x1963F48")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x1963FCC", Offset = "0x1963FCC", VA = "0x1963FCC")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x1964078", Offset = "0x1964078", VA = "0x1964078")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x1964140", Offset = "0x1964140", VA = "0x1964140")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x196422C", Offset = "0x196422C", VA = "0x196422C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x1964338", Offset = "0x1964338", VA = "0x1964338")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x1964480", Offset = "0x1964480", VA = "0x1964480", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x19645B0", Offset = "0x19645B0", VA = "0x19645B0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x19646F4", Offset = "0x19646F4", VA = "0x19646F4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x1964B24", Offset = "0x1964B24", VA = "0x1964B24", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x1964D5C", Offset = "0x1964D5C", VA = "0x1964D5C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x1964EFC", Offset = "0x1964EFC", VA = "0x1964EFC")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x1965150", Offset = "0x1965150", VA = "0x1965150", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x196559C", Offset = "0x196559C", VA = "0x196559C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x19656A0", Offset = "0x19656A0", VA = "0x19656A0")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x19658CC", Offset = "0x19658CC", VA = "0x19658CC")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1965B28", Offset = "0x1965B28", VA = "0x1965B28")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1965E54", Offset = "0x1965E54", VA = "0x1965E54")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1964FAC", Offset = "0x1964FAC", VA = "0x1964FAC")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x19665BC", Offset = "0x19665BC", VA = "0x19665BC")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C0")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200013B")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x400086B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x400086C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x1967D74", Offset = "0x1967D74", VA = "0x1967D74")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x196891C", Offset = "0x196891C", VA = "0x196891C")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x1962860", Offset = "0x1962860", VA = "0x1962860")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x19689E4", Offset = "0x19689E4", VA = "0x19689E4")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BFB34", Offset = "0x9BFB34")]
		public float IKRotationWeight;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x19667A4", Offset = "0x19667A4", VA = "0x19667A4")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x1966994", Offset = "0x1966994", VA = "0x1966994")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x1966B48", Offset = "0x1966B48", VA = "0x1966B48")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x1966B54", Offset = "0x1966B54", VA = "0x1966B54")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1966BD8", Offset = "0x1966BD8", VA = "0x1966BD8")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1966BE4", Offset = "0x1966BE4", VA = "0x1966BE4")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1966BEC", Offset = "0x1966BEC", VA = "0x1966BEC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x1966CF0", Offset = "0x1966CF0", VA = "0x1966CF0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x1966E10", Offset = "0x1966E10", VA = "0x1966E10", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1966E5C", Offset = "0x1966E5C", VA = "0x1966E5C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1966EBC", Offset = "0x1966EBC", VA = "0x1966EBC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x1967298", Offset = "0x1967298", VA = "0x1967298")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x19672F0", Offset = "0x19672F0", VA = "0x19672F0")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1967898", Offset = "0x1967898", VA = "0x1967898")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1967AB0", Offset = "0x1967AB0", VA = "0x1967AB0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1967C6C", Offset = "0x1967C6C", VA = "0x1967C6C")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x1967BE8", Offset = "0x1967BE8", VA = "0x1967BE8")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1967F14", Offset = "0x1967F14", VA = "0x1967F14", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x19689D8", Offset = "0x19689D8", VA = "0x19689D8", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x19689DC", Offset = "0x19689DC", VA = "0x19689DC", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x19689E0", Offset = "0x19689E0", VA = "0x19689E0", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x1968620", Offset = "0x1968620", VA = "0x1968620")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x1963D34", Offset = "0x1963D34", VA = "0x1963D34")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C1")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200013C")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000169")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x40009CD")]
				YawPitch,
				[Token(Token = "0x40009CE")]
				FromTo
			}

			[Token(Token = "0x400086D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1FC8", Offset = "0x9C1FC8")]
			public Transform target;

			[Token(Token = "0x400086E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2000", Offset = "0x9C2000")]
			public Transform bendGoal;

			[Token(Token = "0x400086F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2038", Offset = "0x9C2038")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C2038", Offset = "0x9C2038")]
			public float positionWeight;

			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C208C", Offset = "0x9C208C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C208C", Offset = "0x9C208C")]
			public float rotationWeight;

			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C20E0", Offset = "0x9C20E0")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2118", Offset = "0x9C2118")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C2118", Offset = "0x9C2118")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C216C", Offset = "0x9C216C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C216C", Offset = "0x9C216C")]
			public float bendGoalWeight;

			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C21C0", Offset = "0x9C21C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C21C0", Offset = "0x9C21C0")]
			public float swivelOffset;

			[Token(Token = "0x4000875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C221C", Offset = "0x9C221C")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2254", Offset = "0x9C2254")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C228C", Offset = "0x9C228C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C228C", Offset = "0x9C228C")]
			public float armLengthMlp;

			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C22E4", Offset = "0x9C22E4")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C235C", Offset = "0x9C235C")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C236C", Offset = "0x9C236C")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400087F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x4000885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000886")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x4000887")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170000DE")]
			public Vector3 position
			{
				[Token(Token = "0x60008B8")]
				[Address(RVA = "0x196E134", Offset = "0x196E134", VA = "0x196E134")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7D90", Offset = "0x9C7D90")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008B9")]
				[Address(RVA = "0x196E140", Offset = "0x196E140", VA = "0x196E140")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7DA0", Offset = "0x9C7DA0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DF")]
			public Quaternion rotation
			{
				[Token(Token = "0x60008BA")]
				[Address(RVA = "0x196E14C", Offset = "0x196E14C", VA = "0x196E14C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7DB0", Offset = "0x9C7DB0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60008BB")]
				[Address(RVA = "0x196E158", Offset = "0x196E158", VA = "0x196E158")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7DC0", Offset = "0x9C7DC0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E0")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x60008BC")]
				[Address(RVA = "0x196E164", Offset = "0x196E164", VA = "0x196E164")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E1")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x60008BD")]
				[Address(RVA = "0x196E198", Offset = "0x196E198", VA = "0x196E198")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E2")]
			private VirtualBone forearm
			{
				[Token(Token = "0x60008BE")]
				[Address(RVA = "0x196E1D0", Offset = "0x196E1D0", VA = "0x196E1D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E3")]
			private VirtualBone hand
			{
				[Token(Token = "0x60008BF")]
				[Address(RVA = "0x196E208", Offset = "0x196E208", VA = "0x196E208")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x196E240", Offset = "0x196E240", VA = "0x196E240", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x196E9C0", Offset = "0x196E9C0", VA = "0x196E9C0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x196EBB4", Offset = "0x196EBB4", VA = "0x196EBB4", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x196EC60", Offset = "0x196EC60", VA = "0x196EC60")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x196C540", Offset = "0x196C540", VA = "0x196C540")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x196F8AC", Offset = "0x196F8AC", VA = "0x196F8AC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x196F91C", Offset = "0x196F91C", VA = "0x196F91C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x196F078", Offset = "0x196F078", VA = "0x196F078")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x196F150", Offset = "0x196F150", VA = "0x196F150")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x196FB3C", Offset = "0x196FB3C", VA = "0x196FB3C")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x196E02C", Offset = "0x196E02C", VA = "0x196E02C")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013D")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C237C", Offset = "0x9C237C")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C238C", Offset = "0x9C238C")]
			private float <mag>k__BackingField;

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x400088B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x400088C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x400088D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x400088E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x170000E4")]
			public float sqrMag
			{
				[Token(Token = "0x60008D0")]
				[Address(RVA = "0x196FCFC", Offset = "0x196FCFC", VA = "0x196FCFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7DD0", Offset = "0x9C7DD0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008D1")]
				[Address(RVA = "0x196FD04", Offset = "0x196FD04", VA = "0x196FD04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7DE0", Offset = "0x9C7DE0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E5")]
			public float mag
			{
				[Token(Token = "0x60008D2")]
				[Address(RVA = "0x196FD0C", Offset = "0x196FD0C", VA = "0x196FD0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7DF0", Offset = "0x9C7DF0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008D3")]
				[Address(RVA = "0x196FD14", Offset = "0x196FD14", VA = "0x196FD14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7E00", Offset = "0x9C7E00")]
				private set
				{
				}
			}

			[Token(Token = "0x60008CB")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index);

			[Token(Token = "0x60008CC")]
			public abstract void PreSolve();

			[Token(Token = "0x60008CD")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x60008CE")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x60008CF")]
			public abstract void ResetOffsets();

			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x19624B8", Offset = "0x19624B8", VA = "0x19624B8")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x196FD1C", Offset = "0x196FD1C", VA = "0x196FD1C")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x196FE88", Offset = "0x196FE88", VA = "0x196FE88")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x196FF34", Offset = "0x196FF34", VA = "0x196FF34")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x196C350", Offset = "0x196C350", VA = "0x196C350")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x196F708", Offset = "0x196F708", VA = "0x196F708")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x196FF88", Offset = "0x196FF88", VA = "0x196FF88")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x19700CC", Offset = "0x19700CC", VA = "0x19700CC")]
			public void Visualize()
			{
			}

			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x196FC64", Offset = "0x196FC64", VA = "0x196FC64")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013E")]
		public class Footstep
		{
			[Token(Token = "0x400088F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x4000893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C23AC", Offset = "0x9C23AC")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x4000896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x400089C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x170000E6")]
			public bool isStepping
			{
				[Token(Token = "0x60008DD")]
				[Address(RVA = "0x19700F4", Offset = "0x19700F4", VA = "0x19700F4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E7")]
			public float stepProgress
			{
				[Token(Token = "0x60008DE")]
				[Address(RVA = "0x1970108", Offset = "0x1970108", VA = "0x1970108")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7E10", Offset = "0x9C7E10")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008DF")]
				[Address(RVA = "0x1970110", Offset = "0x1970110", VA = "0x1970110")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7E20", Offset = "0x9C7E20")]
				private set
				{
				}
			}

			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x1970118", Offset = "0x1970118", VA = "0x1970118")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x1970248", Offset = "0x1970248", VA = "0x1970248")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x1970378", Offset = "0x1970378", VA = "0x1970378")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x1970478", Offset = "0x1970478", VA = "0x1970478")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x1970650", Offset = "0x1970650", VA = "0x1970650")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x197083C", Offset = "0x197083C", VA = "0x197083C")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013F")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x400089D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C23BC", Offset = "0x9C23BC")]
			public Transform target;

			[Token(Token = "0x400089E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C23F4", Offset = "0x9C23F4")]
			public Transform bendGoal;

			[Token(Token = "0x400089F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C242C", Offset = "0x9C242C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C242C", Offset = "0x9C242C")]
			public float positionWeight;

			[Token(Token = "0x40008A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2480", Offset = "0x9C2480")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C2480", Offset = "0x9C2480")]
			public float rotationWeight;

			[Token(Token = "0x40008A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C24D4", Offset = "0x9C24D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C24D4", Offset = "0x9C24D4")]
			public float bendGoalWeight;

			[Token(Token = "0x40008A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2528", Offset = "0x9C2528")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C2528", Offset = "0x9C2528")]
			public float swivelOffset;

			[Token(Token = "0x40008A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2584", Offset = "0x9C2584")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C2584", Offset = "0x9C2584")]
			public float bendToTargetWeight;

			[Token(Token = "0x40008A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C25D8", Offset = "0x9C25D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C25D8", Offset = "0x9C25D8")]
			public float legLengthMlp;

			[Token(Token = "0x40008A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2630", Offset = "0x9C2630")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40008A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40008A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40008A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40008A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40008AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40008AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40008AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x40008AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C26D8", Offset = "0x9C26D8")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40008AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C26E8", Offset = "0x9C26E8")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40008AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C26F8", Offset = "0x9C26F8")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40008B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C2708", Offset = "0x9C2708")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x40008B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x40008B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x40008B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x40008B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40008B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x40008B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x40008B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x170000E8")]
			public Vector3 position
			{
				[Token(Token = "0x60008E6")]
				[Address(RVA = "0x1970A58", Offset = "0x1970A58", VA = "0x1970A58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7E30", Offset = "0x9C7E30")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008E7")]
				[Address(RVA = "0x1970A64", Offset = "0x1970A64", VA = "0x1970A64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7E40", Offset = "0x9C7E40")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E9")]
			public Quaternion rotation
			{
				[Token(Token = "0x60008E8")]
				[Address(RVA = "0x1970A70", Offset = "0x1970A70", VA = "0x1970A70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7E50", Offset = "0x9C7E50")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60008E9")]
				[Address(RVA = "0x1970A7C", Offset = "0x1970A7C", VA = "0x1970A7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7E60", Offset = "0x9C7E60")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EA")]
			public bool hasToes
			{
				[Token(Token = "0x60008EA")]
				[Address(RVA = "0x1970A88", Offset = "0x1970A88", VA = "0x1970A88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7E70", Offset = "0x9C7E70")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60008EB")]
				[Address(RVA = "0x1970A90", Offset = "0x1970A90", VA = "0x1970A90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7E80", Offset = "0x9C7E80")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EB")]
			public VirtualBone thigh
			{
				[Token(Token = "0x60008EC")]
				[Address(RVA = "0x1970A9C", Offset = "0x1970A9C", VA = "0x1970A9C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EC")]
			private VirtualBone calf
			{
				[Token(Token = "0x60008ED")]
				[Address(RVA = "0x1970AD0", Offset = "0x1970AD0", VA = "0x1970AD0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000ED")]
			private VirtualBone foot
			{
				[Token(Token = "0x60008EE")]
				[Address(RVA = "0x1970B08", Offset = "0x1970B08", VA = "0x1970B08")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EE")]
			private VirtualBone toes
			{
				[Token(Token = "0x60008EF")]
				[Address(RVA = "0x1970B40", Offset = "0x1970B40", VA = "0x1970B40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EF")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x60008F0")]
				[Address(RVA = "0x196C310", Offset = "0x196C310", VA = "0x196C310")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F0")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x60008F1")]
				[Address(RVA = "0x1970B78", Offset = "0x1970B78", VA = "0x1970B78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7E90", Offset = "0x9C7E90")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008F2")]
				[Address(RVA = "0x1970B84", Offset = "0x1970B84", VA = "0x1970B84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7EA0", Offset = "0x9C7EA0")]
				private set
				{
				}
			}

			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x1970B90", Offset = "0x1970B90", VA = "0x1970B90", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x19711D4", Offset = "0x19711D4", VA = "0x19711D4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x1971AD4", Offset = "0x1971AD4", VA = "0x1971AD4", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x19719D0", Offset = "0x19719D0", VA = "0x19719D0")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x1971798", Offset = "0x1971798", VA = "0x1971798")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x196228C", Offset = "0x196228C", VA = "0x196228C")]
			public void Solve(bool stretch = false)
			{
			}

			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x19725B8", Offset = "0x19725B8", VA = "0x19725B8")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x197208C", Offset = "0x197208C", VA = "0x197208C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x1972A14", Offset = "0x1972A14", VA = "0x1972A14", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x1972C30", Offset = "0x1972C30", VA = "0x1972C30", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x19626D4", Offset = "0x19626D4", VA = "0x19626D4")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000140")]
		public class Locomotion
		{
			[Token(Token = "0x40008B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2718", Offset = "0x9C2718")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C2718", Offset = "0x9C2718")]
			public float weight;

			[Token(Token = "0x40008B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C276C", Offset = "0x9C276C")]
			public float footDistance;

			[Token(Token = "0x40008BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C27A4", Offset = "0x9C27A4")]
			public float stepThreshold;

			[Token(Token = "0x40008BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C27DC", Offset = "0x9C27DC")]
			public float angleThreshold;

			[Token(Token = "0x40008BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2814", Offset = "0x9C2814")]
			public float comAngleMlp;

			[Token(Token = "0x40008BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C284C", Offset = "0x9C284C")]
			public float maxVelocity;

			[Token(Token = "0x40008BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2884", Offset = "0x9C2884")]
			public float velocityFactor;

			[Token(Token = "0x40008BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C28BC", Offset = "0x9C28BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C28BC", Offset = "0x9C28BC")]
			public float maxLegStretch;

			[Token(Token = "0x40008C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2914", Offset = "0x9C2914")]
			public float rootSpeed;

			[Token(Token = "0x40008C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C294C", Offset = "0x9C294C")]
			public float stepSpeed;

			[Token(Token = "0x40008C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2984", Offset = "0x9C2984")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40008C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C29BC", Offset = "0x9C29BC")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40008C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C29F4", Offset = "0x9C29F4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C29F4", Offset = "0x9C29F4")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40008C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2A4C", Offset = "0x9C2A4C")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40008C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2A84", Offset = "0x9C2A84")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40008C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2ABC", Offset = "0x9C2ABC")]
			public Vector3 offset;

			[Token(Token = "0x40008C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40008C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40008CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40008CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40008CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2B34", Offset = "0x9C2B34")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40008CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2B6C", Offset = "0x9C2B6C")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40008CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C2BA4", Offset = "0x9C2BA4")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x40008CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x40008D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40008D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x40008D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x40008D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x170000F1")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x60008FE")]
				[Address(RVA = "0x169B378", Offset = "0x169B378", VA = "0x169B378")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7EB0", Offset = "0x9C7EB0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008FF")]
				[Address(RVA = "0x169B384", Offset = "0x169B384", VA = "0x169B384")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7EC0", Offset = "0x9C7EC0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000F2")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000905")]
				[Address(RVA = "0x169D85C", Offset = "0x169D85C", VA = "0x169D85C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000F3")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000906")]
				[Address(RVA = "0x169D89C", Offset = "0x169D89C", VA = "0x169D89C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000F4")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000907")]
				[Address(RVA = "0x169D8E0", Offset = "0x169D8E0", VA = "0x169D8E0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000F5")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000908")]
				[Address(RVA = "0x169D920", Offset = "0x169D920", VA = "0x169D920")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000900")]
			[Address(RVA = "0x169B390", Offset = "0x169B390", VA = "0x169B390")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000901")]
			[Address(RVA = "0x169B690", Offset = "0x169B690", VA = "0x169B690")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000902")]
			[Address(RVA = "0x169B90C", Offset = "0x169B90C", VA = "0x169B90C")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000903")]
			[Address(RVA = "0x169BCE4", Offset = "0x169BCE4", VA = "0x169BCE4")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000904")]
			[Address(RVA = "0x169BE94", Offset = "0x169BE94", VA = "0x169BE94")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000909")]
			[Address(RVA = "0x169D448", Offset = "0x169D448", VA = "0x169D448")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600090A")]
			[Address(RVA = "0x169D5EC", Offset = "0x169D5EC", VA = "0x169D5EC")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600090B")]
			[Address(RVA = "0x169D690", Offset = "0x169D690", VA = "0x169D690")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x600090C")]
			[Address(RVA = "0x169D964", Offset = "0x169D964", VA = "0x169D964")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000141")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40008D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2BB4", Offset = "0x9C2BB4")]
			public Transform headTarget;

			[Token(Token = "0x40008D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2BEC", Offset = "0x9C2BEC")]
			public Transform pelvisTarget;

			[Token(Token = "0x40008D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2C24", Offset = "0x9C2C24")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C2C24", Offset = "0x9C2C24")]
			public float positionWeight;

			[Token(Token = "0x40008D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2C78", Offset = "0x9C2C78")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C2C78", Offset = "0x9C2C78")]
			public float rotationWeight;

			[Token(Token = "0x40008D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2CCC", Offset = "0x9C2CCC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C2CCC", Offset = "0x9C2CCC")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40008D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2D20", Offset = "0x9C2D20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C2D20", Offset = "0x9C2D20")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40008DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2D74", Offset = "0x9C2D74")]
			public Transform chestGoal;

			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2DAC", Offset = "0x9C2DAC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C2DAC", Offset = "0x9C2DAC")]
			public float chestGoalWeight;

			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2E00", Offset = "0x9C2E00")]
			public float minHeadHeight;

			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2E38", Offset = "0x9C2E38")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C2E38", Offset = "0x9C2E38")]
			public float bodyPosStiffness;

			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2E8C", Offset = "0x9C2E8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C2E8C", Offset = "0x9C2E8C")]
			public float bodyRotStiffness;

			[Token(Token = "0x40008DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2EE0", Offset = "0x9C2EE0")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C2EE0", Offset = "0x9C2EE0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C2EE0", Offset = "0x9C2EE0")]
			public float neckStiffness;

			[Token(Token = "0x40008E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2F58", Offset = "0x9C2F58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C2F58", Offset = "0x9C2F58")]
			public float rotateChestByHands;

			[Token(Token = "0x40008E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2FAC", Offset = "0x9C2FAC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C2FAC", Offset = "0x9C2FAC")]
			public float chestClampWeight;

			[Token(Token = "0x40008E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3000", Offset = "0x9C3000")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C3000", Offset = "0x9C3000")]
			public float headClampWeight;

			[Token(Token = "0x40008E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3054", Offset = "0x9C3054")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40008E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C308C", Offset = "0x9C308C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C308C", Offset = "0x9C308C")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C30E0", Offset = "0x9C30E0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C30E0", Offset = "0x9C30E0")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40008E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40008E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40008EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40008EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40008ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40008EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40008EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40008F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40008F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40008F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40008F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40008F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3218", Offset = "0x9C3218")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40008F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private Quaternion headRotation;

			[Token(Token = "0x40008F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x40008F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private int pelvisIndex;

			[Token(Token = "0x40008FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private int spineIndex;

			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
			private int chestIndex;

			[Token(Token = "0x40008FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private int neckIndex;

			[Token(Token = "0x4000900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private int headIndex;

			[Token(Token = "0x4000901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private float length;

			[Token(Token = "0x4000902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
			private bool hasChest;

			[Token(Token = "0x4000903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1ED")]
			private bool hasNeck;

			[Token(Token = "0x4000904")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private float headHeight;

			[Token(Token = "0x4000905")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private float sizeMlp;

			[Token(Token = "0x4000906")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private Vector3 chestForward;

			[Token(Token = "0x170000F6")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x600090D")]
				[Address(RVA = "0x169D3C8", Offset = "0x169D3C8", VA = "0x169D3C8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F7")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600090E")]
				[Address(RVA = "0x169DA48", Offset = "0x169DA48", VA = "0x169DA48")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F8")]
			public VirtualBone chest
			{
				[Token(Token = "0x600090F")]
				[Address(RVA = "0x169DA88", Offset = "0x169DA88", VA = "0x169DA88")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F9")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000910")]
				[Address(RVA = "0x169DADC", Offset = "0x169DADC", VA = "0x169DADC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FA")]
			public VirtualBone head
			{
				[Token(Token = "0x6000911")]
				[Address(RVA = "0x169D408", Offset = "0x169D408", VA = "0x169D408")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FB")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000912")]
				[Address(RVA = "0x169DB1C", Offset = "0x169DB1C", VA = "0x169DB1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7ED0", Offset = "0x9C7ED0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000913")]
				[Address(RVA = "0x169DB30", Offset = "0x169DB30", VA = "0x169DB30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7EE0", Offset = "0x9C7EE0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000914")]
			[Address(RVA = "0x169DB44", Offset = "0x169DB44", VA = "0x169DB44", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000915")]
			[Address(RVA = "0x169E63C", Offset = "0x169E63C", VA = "0x169E63C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000916")]
			[Address(RVA = "0x169E810", Offset = "0x169E810", VA = "0x169E810", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000917")]
			[Address(RVA = "0x169ED34", Offset = "0x169ED34", VA = "0x169ED34")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000918")]
			[Address(RVA = "0x169F2E8", Offset = "0x169F2E8", VA = "0x169F2E8")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000919")]
			[Address(RVA = "0x169FC84", Offset = "0x169FC84", VA = "0x169FC84")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x600091A")]
			[Address(RVA = "0x16A04B0", Offset = "0x16A04B0", VA = "0x16A04B0")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x600091B")]
			[Address(RVA = "0x16A123C", Offset = "0x16A123C", VA = "0x16A123C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600091C")]
			[Address(RVA = "0x16A1418", Offset = "0x16A1418", VA = "0x16A1418", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600091D")]
			[Address(RVA = "0x169EF64", Offset = "0x169EF64", VA = "0x169EF64")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x600091E")]
			[Address(RVA = "0x16A00E0", Offset = "0x16A00E0", VA = "0x16A00E0")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x600091F")]
			[Address(RVA = "0x169F878", Offset = "0x169F878", VA = "0x169F878")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000920")]
			[Address(RVA = "0x16A1510", Offset = "0x16A1510", VA = "0x16A1510")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000921")]
			[Address(RVA = "0x16A0264", Offset = "0x16A0264", VA = "0x16A0264")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000922")]
			[Address(RVA = "0x169FE78", Offset = "0x169FE78", VA = "0x169FE78")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000923")]
			[Address(RVA = "0x16A1A24", Offset = "0x16A1A24", VA = "0x16A1A24")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000142")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000908")]
			Pelvis,
			[Token(Token = "0x4000909")]
			Chest,
			[Token(Token = "0x400090A")]
			Head,
			[Token(Token = "0x400090B")]
			LeftHand,
			[Token(Token = "0x400090C")]
			RightHand,
			[Token(Token = "0x400090D")]
			LeftFoot,
			[Token(Token = "0x400090E")]
			RightFoot,
			[Token(Token = "0x400090F")]
			LeftHeel,
			[Token(Token = "0x4000910")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x2000143")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000912")]
			Pelvis,
			[Token(Token = "0x4000913")]
			Chest,
			[Token(Token = "0x4000914")]
			Head
		}

		[Serializable]
		[Token(Token = "0x2000144")]
		public class VirtualBone
		{
			[Token(Token = "0x4000915")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000916")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000917")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000919")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x400091A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x400091B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000924")]
			[Address(RVA = "0x169E5A0", Offset = "0x169E5A0", VA = "0x169E5A0")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000925")]
			[Address(RVA = "0x169E61C", Offset = "0x169E61C", VA = "0x169E61C")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000926")]
			[Address(RVA = "0x16A1BC4", Offset = "0x16A1BC4", VA = "0x16A1BC4")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000927")]
			[Address(RVA = "0x16A1E54", Offset = "0x16A1E54", VA = "0x16A1E54")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000928")]
			[Address(RVA = "0x16A183C", Offset = "0x16A183C", VA = "0x16A183C")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000929")]
			[Address(RVA = "0x16A2140", Offset = "0x16A2140", VA = "0x16A2140")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600092A")]
			[Address(RVA = "0x16A2378", Offset = "0x16A2378", VA = "0x16A2378")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x600092B")]
			[Address(RVA = "0x16A25AC", Offset = "0x16A25AC", VA = "0x16A25AC")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0x16A0C90", Offset = "0x16A0C90", VA = "0x16A0C90")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x600092D")]
			[Address(RVA = "0x16A2664", Offset = "0x16A2664", VA = "0x16A2664")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600092E")]
			[Address(RVA = "0x16A0850", Offset = "0x16A0850", VA = "0x16A0850")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x600092F")]
			[Address(RVA = "0x16A287C", Offset = "0x16A287C", VA = "0x16A287C")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000930")]
			[Address(RVA = "0x16A2984", Offset = "0x16A2984", VA = "0x16A2984")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BFB4C", Offset = "0x9BFB4C")]
		public bool plantFeet;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BFB84", Offset = "0x9BFB84")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BFB94", Offset = "0x9BFB94")]
		public Spine spine;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BFBCC", Offset = "0x9BFBCC")]
		public Arm leftArm;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BFC04", Offset = "0x9BFC04")]
		public Arm rightArm;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BFC3C", Offset = "0x9BFC3C")]
		public Leg leftLeg;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BFC74", Offset = "0x9BFC74")]
		public Leg rightLeg;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BFCAC", Offset = "0x9BFCAC")]
		public Locomotion locomotion;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Leg[] legs;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Arm[] arms;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 headPosition;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastOffset;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 debugPos1;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 debugPos2;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos3;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos4;

		[Token(Token = "0x1700008C")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x196DE6C", Offset = "0x196DE6C", VA = "0x196DE6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6BD4", Offset = "0x9C6BD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x196DE74", Offset = "0x196DE74", VA = "0x196DE74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6BE4", Offset = "0x9C6BE4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x19689EC", Offset = "0x19689EC", VA = "0x19689EC")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x1968DE0", Offset = "0x1968DE0", VA = "0x1968DE0")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x1968C88", Offset = "0x1968C88", VA = "0x1968C88")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x19697C4", Offset = "0x19697C4", VA = "0x19697C4")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x1969AA0", Offset = "0x1969AA0", VA = "0x1969AA0")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x1969B44", Offset = "0x1969B44", VA = "0x1969B44")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1969CD8", Offset = "0x1969CD8", VA = "0x1969CD8")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x1969E64", Offset = "0x1969E64", VA = "0x1969E64")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x196A62C", Offset = "0x196A62C", VA = "0x196A62C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x196A7A0", Offset = "0x196A7A0", VA = "0x196A7A0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x196A93C", Offset = "0x196A93C", VA = "0x196A93C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x196A9B0", Offset = "0x196A9B0", VA = "0x196A9B0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x196AA24", Offset = "0x196AA24", VA = "0x196AA24", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x196AC38", Offset = "0x196AC38", VA = "0x196AC38")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1969078", Offset = "0x1969078", VA = "0x1969078")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x1969250", Offset = "0x1969250", VA = "0x1969250")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x19696A0", Offset = "0x19696A0", VA = "0x19696A0")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x1969FC8", Offset = "0x1969FC8", VA = "0x1969FC8")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x196AF18", Offset = "0x196AF18", VA = "0x196AF18", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x196AF50", Offset = "0x196AF50", VA = "0x196AF50", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x196C09C", Offset = "0x196C09C", VA = "0x196C09C")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x196A130", Offset = "0x196A130", VA = "0x196A130")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x196AFB0", Offset = "0x196AFB0", VA = "0x196AFB0")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x196C284", Offset = "0x196C284", VA = "0x196C284")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x196C2CC", Offset = "0x196C2CC", VA = "0x196C2CC")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x196BF54", Offset = "0x196BF54", VA = "0x196BF54")]
		private void Write()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x196D86C", Offset = "0x196D86C", VA = "0x196D86C")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x196DE7C", Offset = "0x196DE7C", VA = "0x196DE7C")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BFCE4", Offset = "0x9BFCE4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BFCE4", Offset = "0x9BFCE4")]
		public float weight;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BFD38", Offset = "0x9BFD38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BFD38", Offset = "0x9BFD38")]
		public float parentChildCrossfade;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BFD8C", Offset = "0x9BFD8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BFD8C", Offset = "0x9BFD8C")]
		public float twistAngleOffset;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 twistAxis;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 axis;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform parent;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform child;

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x1CBC5B4", Offset = "0x1CBC5B4", VA = "0x1CBC5B4")]
		public void Relax()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x1CBC994", Offset = "0x1CBC994", VA = "0x1CBC994")]
		private void Start()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x1CBCDB0", Offset = "0x1CBCDB0", VA = "0x1CBCDB0")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1CBCE38", Offset = "0x1CBCE38", VA = "0x1CBCE38")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x1CBCEC0", Offset = "0x1CBCEC0", VA = "0x1CBCEC0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1CBCFC4", Offset = "0x1CBCFC4", VA = "0x1CBCFC4")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C3")]
	public class InteractionEffector
	{
		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BFDE8", Offset = "0x9BFDE8")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BFDF8", Offset = "0x9BFDF8")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BFE08", Offset = "0x9BFE08")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x1700008D")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000674")]
			[Address(RVA = "0x16A32A8", Offset = "0x16A32A8", VA = "0x16A32A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6BF4", Offset = "0x9C6BF4")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x16A32B0", Offset = "0x16A32B0", VA = "0x16A32B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6C04", Offset = "0x9C6C04")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public bool isPaused
		{
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x16A32B8", Offset = "0x16A32B8", VA = "0x16A32B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6C14", Offset = "0x9C6C14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x16A32C0", Offset = "0x16A32C0", VA = "0x16A32C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6C24", Offset = "0x9C6C24")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x16A32CC", Offset = "0x16A32CC", VA = "0x16A32CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6C34", Offset = "0x9C6C34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x16A32D4", Offset = "0x16A32D4", VA = "0x16A32D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6C44", Offset = "0x9C6C44")]
			private set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public bool inInteraction
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x16A32DC", Offset = "0x16A32DC", VA = "0x16A32DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		public float progress
		{
			[Token(Token = "0x6000683")]
			[Address(RVA = "0x16A5B9C", Offset = "0x16A5B9C", VA = "0x16A5B9C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x16A334C", Offset = "0x16A334C", VA = "0x16A334C")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x16A33D0", Offset = "0x16A33D0", VA = "0x16A33D0")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x16A3474", Offset = "0x16A3474", VA = "0x16A3474")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x16A35B4", Offset = "0x16A35B4", VA = "0x16A35B4")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x16A39B8", Offset = "0x16A39B8", VA = "0x16A39B8")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x16A3D78", Offset = "0x16A3D78", VA = "0x16A3D78")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x16A3DCC", Offset = "0x16A3DCC", VA = "0x16A3DCC")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x16A490C", Offset = "0x16A490C", VA = "0x16A490C")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x16A53EC", Offset = "0x16A53EC", VA = "0x16A53EC")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x16A5614", Offset = "0x16A5614", VA = "0x16A5614")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x16A5A48", Offset = "0x16A5A48", VA = "0x16A5A48")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x16A6084", Offset = "0x16A6084", VA = "0x16A6084")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C4")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BFE18", Offset = "0x9BFE18")]
		public LookAtIK ik;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BFE50", Offset = "0x9BFE50")]
		public float lerpSpeed;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BFE88", Offset = "0x9BFE88")]
		public float weightSpeed;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x16A62E8", Offset = "0x16A62E8", VA = "0x16A62E8")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x16A6460", Offset = "0x16A6460", VA = "0x16A6460")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x16A6508", Offset = "0x16A6508", VA = "0x16A6508")]
		public void Update()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x16A674C", Offset = "0x16A674C", VA = "0x16A674C")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x16A6844", Offset = "0x16A6844", VA = "0x16A6844")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x16A6910", Offset = "0x16A6910", VA = "0x16A6910")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9BA39C", Offset = "0x9BA39C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BA39C", Offset = "0x9BA39C")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000145")]
		public class InteractionEvent
		{
			[Token(Token = "0x400091C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3228", Offset = "0x9C3228")]
			public float time;

			[Token(Token = "0x400091D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3260", Offset = "0x9C3260")]
			public bool pause;

			[Token(Token = "0x400091E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3298", Offset = "0x9C3298")]
			public bool pickUp;

			[Token(Token = "0x400091F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C32D0", Offset = "0x9C32D0")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3308", Offset = "0x9C3308")]
			public Message[] messages;

			[Token(Token = "0x4000921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3340", Offset = "0x9C3340")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000931")]
			[Address(RVA = "0x16A5BD8", Offset = "0x16A5BD8", VA = "0x16A5BD8")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000932")]
			[Address(RVA = "0x16A7BB0", Offset = "0x16A7BB0", VA = "0x16A7BB0")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000146")]
		public class Message
		{
			[Token(Token = "0x4000922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3378", Offset = "0x9C3378")]
			public string function;

			[Token(Token = "0x4000923")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C33B0", Offset = "0x9C33B0")]
			public GameObject recipient;

			[Token(Token = "0x4000924")]
			private const string empty = "";

			[Token(Token = "0x6000933")]
			[Address(RVA = "0x16A7AC0", Offset = "0x16A7AC0", VA = "0x16A7AC0")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000934")]
			[Address(RVA = "0x16A7BB8", Offset = "0x16A7BB8", VA = "0x16A7BB8")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000147")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C33E8", Offset = "0x9C33E8")]
			public Animator animator;

			[Token(Token = "0x4000926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3420", Offset = "0x9C3420")]
			public Animation animation;

			[Token(Token = "0x4000927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3458", Offset = "0x9C3458")]
			public string animationState;

			[Token(Token = "0x4000928")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3490", Offset = "0x9C3490")]
			public float crossfadeTime;

			[Token(Token = "0x4000929")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C34C8", Offset = "0x9C34C8")]
			public int layer;

			[Token(Token = "0x400092A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3500", Offset = "0x9C3500")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400092B")]
			private const string empty = "";

			[Token(Token = "0x6000935")]
			[Address(RVA = "0x16A7820", Offset = "0x16A7820", VA = "0x16A7820")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000936")]
			[Address(RVA = "0x16A7914", Offset = "0x16A7914", VA = "0x16A7914")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000937")]
			[Address(RVA = "0x16A79CC", Offset = "0x16A79CC", VA = "0x16A79CC")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000938")]
			[Address(RVA = "0x16A7AAC", Offset = "0x16A7AAC", VA = "0x16A7AAC")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000148")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x200016A")]
			public enum Type
			{
				[Token(Token = "0x40009D0")]
				PositionWeight,
				[Token(Token = "0x40009D1")]
				RotationWeight,
				[Token(Token = "0x40009D2")]
				PositionOffsetX,
				[Token(Token = "0x40009D3")]
				PositionOffsetY,
				[Token(Token = "0x40009D4")]
				PositionOffsetZ,
				[Token(Token = "0x40009D5")]
				Pull,
				[Token(Token = "0x40009D6")]
				Reach,
				[Token(Token = "0x40009D7")]
				RotateBoneWeight,
				[Token(Token = "0x40009D8")]
				Push,
				[Token(Token = "0x40009D9")]
				PushParent,
				[Token(Token = "0x40009DA")]
				PoserWeight
			}

			[Token(Token = "0x400092C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3538", Offset = "0x9C3538")]
			public Type type;

			[Token(Token = "0x400092D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3570", Offset = "0x9C3570")]
			public AnimationCurve curve;

			[Token(Token = "0x6000939")]
			[Address(RVA = "0x16A701C", Offset = "0x16A701C", VA = "0x16A701C")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600093A")]
			[Address(RVA = "0x16A7BD0", Offset = "0x16A7BD0", VA = "0x16A7BD0")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000149")]
		public class Multiplier
		{
			[Token(Token = "0x400092E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C35A8", Offset = "0x9C35A8")]
			public WeightCurve.Type curve;

			[Token(Token = "0x400092F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C35E0", Offset = "0x9C35E0")]
			public float multiplier;

			[Token(Token = "0x4000930")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3618", Offset = "0x9C3618")]
			public WeightCurve.Type result;

			[Token(Token = "0x600093B")]
			[Address(RVA = "0x16A7680", Offset = "0x16A7680", VA = "0x16A7680")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600093C")]
			[Address(RVA = "0x16A7BC0", Offset = "0x16A7BC0", VA = "0x16A7BC0")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BFED0", Offset = "0x9BFED0")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BFF08", Offset = "0x9BFF08")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BFF40", Offset = "0x9BFF40")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BFF78", Offset = "0x9BFF78")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BFF88", Offset = "0x9BFF88")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000092")]
		public float length
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x16A6AEC", Offset = "0x16A6AEC", VA = "0x16A6AEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6DA4", Offset = "0x9C6DA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x16A6AF4", Offset = "0x16A6AF4", VA = "0x16A6AF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6DB4", Offset = "0x9C6DB4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x16A6AFC", Offset = "0x16A6AFC", VA = "0x16A6AFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6DC4", Offset = "0x9C6DC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x16A6B04", Offset = "0x16A6B04", VA = "0x16A6B04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6DD4", Offset = "0x9C6DD4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x16A6D20", Offset = "0x16A6D20", VA = "0x16A6D20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x16A5F58", Offset = "0x16A5F58", VA = "0x16A5F58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x16A6924", Offset = "0x16A6924", VA = "0x16A6924")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6C54", Offset = "0x9C6C54")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x16A6970", Offset = "0x16A6970", VA = "0x16A6970")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6C8C", Offset = "0x9C6C8C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x16A69BC", Offset = "0x16A69BC", VA = "0x16A69BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6CC4", Offset = "0x9C6CC4")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x16A6A08", Offset = "0x16A6A08", VA = "0x16A6A08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6CFC", Offset = "0x9C6CFC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x16A6A54", Offset = "0x16A6A54", VA = "0x16A6A54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6D34", Offset = "0x9C6D34")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x16A6AA0", Offset = "0x16A6AA0", VA = "0x16A6AA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6D6C", Offset = "0x9C6D6C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x16A6B0C", Offset = "0x16A6B0C", VA = "0x16A6B0C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x16A6DB0", Offset = "0x16A6DB0", VA = "0x16A6DB0")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x16A4334", Offset = "0x16A4334", VA = "0x16A4334")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x16A6F34", Offset = "0x16A6F34", VA = "0x16A6F34")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x16A41E8", Offset = "0x16A41E8", VA = "0x16A41E8")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x16A432C", Offset = "0x16A432C", VA = "0x16A432C")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x16A4FD0", Offset = "0x16A4FD0", VA = "0x16A4FD0")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x16A5820", Offset = "0x16A5820", VA = "0x16A5820")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x16A76BC", Offset = "0x16A76BC", VA = "0x16A76BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x16A7038", Offset = "0x16A7038", VA = "0x16A7038")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x16A6F3C", Offset = "0x16A6F3C", VA = "0x16A6F3C")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x16A7618", Offset = "0x16A7618", VA = "0x16A7618")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x16A76C0", Offset = "0x16A76C0", VA = "0x16A76C0")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x16A7728", Offset = "0x16A7728", VA = "0x16A7728")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6DE4", Offset = "0x9C6DE4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x16A7774", Offset = "0x16A7774", VA = "0x16A7774")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6E1C", Offset = "0x9C6E1C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x16A77C0", Offset = "0x16A77C0", VA = "0x16A77C0")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9BA3FC", Offset = "0x9BA3FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BA3FC", Offset = "0x9BA3FC")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200014A")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200014B")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BFF98", Offset = "0x9BFF98")]
		public string targetTag;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BFFD0", Offset = "0x9BFFD0")]
		public float fadeInTime;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0008", Offset = "0x9C0008")]
		public float speed;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0040", Offset = "0x9C0040")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0078", Offset = "0x9C0078")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0078", Offset = "0x9C0078")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C0078", Offset = "0x9C0078")]
		public Collider characterCollider;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C00FC", Offset = "0x9C00FC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C00FC", Offset = "0x9C00FC")]
		public Transform FPSCamera;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C015C", Offset = "0x9C015C")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0194", Offset = "0x9C0194")]
		public float camRaycastDistance;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C01CC", Offset = "0x9C01CC")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9C01DC", Offset = "0x9C01DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C01DC", Offset = "0x9C01DC")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C023C", Offset = "0x9C023C")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x17000096")]
		public bool inInteraction
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x16A7DA0", Offset = "0x16A7DA0", VA = "0x16A7DA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000097")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x16A99B8", Offset = "0x16A99B8", VA = "0x16A99B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x16A99C0", Offset = "0x16A99C0", VA = "0x16A99C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x16A99C8", Offset = "0x16A99C8", VA = "0x16A99C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6FA4", Offset = "0x9C6FA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x16A99D0", Offset = "0x16A99D0", VA = "0x16A99D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6FB4", Offset = "0x9C6FB4")]
			private set
			{
			}
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x16A7BD8", Offset = "0x16A7BD8", VA = "0x16A7BD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6E54", Offset = "0x9C6E54")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x16A7C24", Offset = "0x16A7C24", VA = "0x16A7C24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6E8C", Offset = "0x9C6E8C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x16A7C70", Offset = "0x16A7C70", VA = "0x16A7C70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6EC4", Offset = "0x9C6EC4")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x16A7CBC", Offset = "0x16A7CBC", VA = "0x16A7CBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6EFC", Offset = "0x9C6EFC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x16A7D08", Offset = "0x16A7D08", VA = "0x16A7D08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6F34", Offset = "0x9C6F34")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x16A7D54", Offset = "0x16A7D54", VA = "0x16A7D54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6F6C", Offset = "0x9C6F6C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x16A7F30", Offset = "0x16A7F30", VA = "0x16A7F30")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x16A7FFC", Offset = "0x16A7FFC", VA = "0x16A7FFC")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x16A80C8", Offset = "0x16A80C8", VA = "0x16A80C8")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x16A8174", Offset = "0x16A8174", VA = "0x16A8174")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x16A826C", Offset = "0x16A826C", VA = "0x16A826C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x16A8388", Offset = "0x16A8388", VA = "0x16A8388")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x16A8418", Offset = "0x16A8418", VA = "0x16A8418")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x16A84A8", Offset = "0x16A84A8", VA = "0x16A84A8")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x16A8538", Offset = "0x16A8538", VA = "0x16A8538")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x16A85AC", Offset = "0x16A85AC", VA = "0x16A85AC")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x16A8620", Offset = "0x16A8620", VA = "0x16A8620")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x16A8688", Offset = "0x16A8688", VA = "0x16A8688")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x16A8714", Offset = "0x16A8714", VA = "0x16A8714")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x16A87C8", Offset = "0x16A87C8", VA = "0x16A87C8")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x16A88AC", Offset = "0x16A88AC", VA = "0x16A88AC")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x16A8B50", Offset = "0x16A8B50", VA = "0x16A8B50")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x16A8D28", Offset = "0x16A8D28", VA = "0x16A8D28")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x16A8F9C", Offset = "0x16A8F9C", VA = "0x16A8F9C")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x16A9290", Offset = "0x16A9290", VA = "0x16A9290")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x16A92D4", Offset = "0x16A92D4", VA = "0x16A92D4")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x16A934C", Offset = "0x16A934C", VA = "0x16A934C")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x16A946C", Offset = "0x16A946C", VA = "0x16A946C")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x16A95E4", Offset = "0x16A95E4", VA = "0x16A95E4")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x16A988C", Offset = "0x16A988C", VA = "0x16A988C")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x16A909C", Offset = "0x16A909C", VA = "0x16A909C")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x16A99D8", Offset = "0x16A99D8", VA = "0x16A99D8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x16AA08C", Offset = "0x16AA08C", VA = "0x16AA08C")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x16AA0AC", Offset = "0x16AA0AC", VA = "0x16AA0AC")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x16AA0C8", Offset = "0x16AA0C8", VA = "0x16AA0C8")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x16AA0E4", Offset = "0x16AA0E4", VA = "0x16AA0E4")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x16AA144", Offset = "0x16AA144", VA = "0x16AA144")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x16AA260", Offset = "0x16AA260", VA = "0x16AA260")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x16AA35C", Offset = "0x16AA35C", VA = "0x16AA35C")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x16AA6BC", Offset = "0x16AA6BC", VA = "0x16AA6BC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x16AA7A8", Offset = "0x16AA7A8", VA = "0x16AA7A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x16AA9F4", Offset = "0x16AA9F4", VA = "0x16AA9F4")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x16A9E04", Offset = "0x16A9E04", VA = "0x16A9E04")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x16AAB34", Offset = "0x16AAB34", VA = "0x16AAB34")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x16AAC60", Offset = "0x16AAC60", VA = "0x16AAC60")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x16AAD1C", Offset = "0x16AAD1C", VA = "0x16AAD1C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x16AAE18", Offset = "0x16AAE18", VA = "0x16AAE18")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x16AAE30", Offset = "0x16AAE30", VA = "0x16AAE30")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x16A7E4C", Offset = "0x16A7E4C", VA = "0x16A7E4C")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x16A8A4C", Offset = "0x16A8A4C", VA = "0x16A8A4C")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x16AB120", Offset = "0x16AB120", VA = "0x16AB120")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6FC4", Offset = "0x9C6FC4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x16AB16C", Offset = "0x16AB16C", VA = "0x16AB16C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6FFC", Offset = "0x9C6FFC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x16AB1B8", Offset = "0x16AB1B8", VA = "0x16AB1B8")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9BA45C", Offset = "0x9BA45C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BA45C", Offset = "0x9BA45C")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200014C")]
		public class Multiplier
		{
			[Token(Token = "0x4000931")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3650", Offset = "0x9C3650")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000932")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3688", Offset = "0x9C3688")]
			public float multiplier;

			[Token(Token = "0x6000945")]
			[Address(RVA = "0x16AB958", Offset = "0x16AB958", VA = "0x16AB958")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0274", Offset = "0x9C0274")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C02AC", Offset = "0x9C02AC")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C02E4", Offset = "0x9C02E4")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C031C", Offset = "0x9C031C")]
		public Transform pivot;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0354", Offset = "0x9C0354")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C038C", Offset = "0x9C038C")]
		public float twistWeight;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C03C4", Offset = "0x9C03C4")]
		public float swingWeight;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C03FC", Offset = "0x9C03FC")]
		public bool rotateOnce;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x16AB66C", Offset = "0x16AB66C", VA = "0x16AB66C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C7034", Offset = "0x9C7034")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x16AB6B8", Offset = "0x16AB6B8", VA = "0x16AB6B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C706C", Offset = "0x9C706C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x16AB704", Offset = "0x16AB704", VA = "0x16AB704")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C70A4", Offset = "0x9C70A4")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x16AB750", Offset = "0x16AB750", VA = "0x16AB750")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C70DC", Offset = "0x9C70DC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x16AB79C", Offset = "0x16AB79C", VA = "0x16AB79C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C7114", Offset = "0x9C7114")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x16AB7E8", Offset = "0x16AB7E8", VA = "0x16AB7E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C714C", Offset = "0x9C714C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x16A6FAC", Offset = "0x16A6FAC", VA = "0x16A6FAC")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x16A5FE8", Offset = "0x16A5FE8", VA = "0x16A5FE8")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x16A43E8", Offset = "0x16A43E8", VA = "0x16A43E8")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x16AB834", Offset = "0x16AB834", VA = "0x16AB834")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C7184", Offset = "0x9C7184")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x16AB880", Offset = "0x16AB880", VA = "0x16AB880")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C71BC", Offset = "0x9C71BC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x16AB8CC", Offset = "0x16AB8CC", VA = "0x16AB8CC")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9BA4BC", Offset = "0x9BA4BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BA4BC", Offset = "0x9BA4BC")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200014D")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000933")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C36C0", Offset = "0x9C36C0")]
			public bool use;

			[Token(Token = "0x4000934")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C36F8", Offset = "0x9C36F8")]
			public Vector2 offset;

			[Token(Token = "0x4000935")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3730", Offset = "0x9C3730")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C3730", Offset = "0x9C3730")]
			public float angleOffset;

			[Token(Token = "0x4000936")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C378C", Offset = "0x9C378C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C378C", Offset = "0x9C378C")]
			public float maxAngle;

			[Token(Token = "0x4000937")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C37E4", Offset = "0x9C37E4")]
			public float radius;

			[Token(Token = "0x4000938")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C381C", Offset = "0x9C381C")]
			public bool orbit;

			[Token(Token = "0x4000939")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3854", Offset = "0x9C3854")]
			public bool fixYAxis;

			[Token(Token = "0x170000FC")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000946")]
				[Address(RVA = "0x16AC0E0", Offset = "0x16AC0E0", VA = "0x16AC0E0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000FD")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000947")]
				[Address(RVA = "0x16AC11C", Offset = "0x16AC11C", VA = "0x16AC11C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000948")]
			[Address(RVA = "0x16AC214", Offset = "0x16AC214", VA = "0x16AC214")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000949")]
			[Address(RVA = "0x16AC890", Offset = "0x16AC890", VA = "0x16AC890")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200014E")]
		public class CameraPosition
		{
			[Token(Token = "0x400093A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C388C", Offset = "0x9C388C")]
			public Collider lookAtTarget;

			[Token(Token = "0x400093B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C38C4", Offset = "0x9C38C4")]
			public Vector3 direction;

			[Token(Token = "0x400093C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C38FC", Offset = "0x9C38FC")]
			public float maxDistance;

			[Token(Token = "0x400093D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3934", Offset = "0x9C3934")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C3934", Offset = "0x9C3934")]
			public float maxAngle;

			[Token(Token = "0x400093E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C398C", Offset = "0x9C398C")]
			public bool fixYAxis;

			[Token(Token = "0x600094A")]
			[Address(RVA = "0x16ABBCC", Offset = "0x16ABBCC", VA = "0x16ABBCC")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600094B")]
			[Address(RVA = "0x16ABD74", Offset = "0x16ABD74", VA = "0x16ABD74")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600094C")]
			[Address(RVA = "0x16AC054", Offset = "0x16AC054", VA = "0x16AC054")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200014F")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x200016B")]
			public class Interaction
			{
				[Token(Token = "0x40009DB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4838", Offset = "0x9C4838")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40009DC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4870", Offset = "0x9C4870")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x60009B5")]
				[Address(RVA = "0x16AC8B4", Offset = "0x16AC8B4", VA = "0x16AC8B4")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x400093F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000940")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x4000941")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3A34", Offset = "0x9C3A34")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000942")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3A6C", Offset = "0x9C3A6C")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000943")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3AA4", Offset = "0x9C3AA4")]
			public Interaction[] interactions;

			[Token(Token = "0x600094D")]
			[Address(RVA = "0x16ABA48", Offset = "0x16ABA48", VA = "0x16ABA48")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x600094E")]
			[Address(RVA = "0x16AC8A4", Offset = "0x16AC8A4", VA = "0x16AC8A4")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0434", Offset = "0x9C0434")]
		public Range[] ranges;

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x16AB960", Offset = "0x16AB960", VA = "0x16AB960")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C71F4", Offset = "0x9C71F4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x16AB9AC", Offset = "0x16AB9AC", VA = "0x16AB9AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C722C", Offset = "0x9C722C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x16AB9F8", Offset = "0x16AB9F8", VA = "0x16AB9F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C7264", Offset = "0x9C7264")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x16ABA44", Offset = "0x16ABA44", VA = "0x16ABA44")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x16AA500", Offset = "0x16AA500", VA = "0x16AA500")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x16ABB6C", Offset = "0x16ABB6C", VA = "0x16ABB6C")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x2000150")]
		public class Map
		{
			[Token(Token = "0x4000944")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x4000945")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x4000946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600094F")]
			[Address(RVA = "0x1484350", Offset = "0x1484350", VA = "0x1484350")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000950")]
			[Address(RVA = "0x1484754", Offset = "0x1484754", VA = "0x1484754")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000951")]
			[Address(RVA = "0x1484708", Offset = "0x1484708", VA = "0x1484708")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000952")]
			[Address(RVA = "0x1484500", Offset = "0x1484500", VA = "0x1484500")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1484068", Offset = "0x1484068", VA = "0x1484068", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C729C", Offset = "0x9C729C")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x14843F4", Offset = "0x14843F4", VA = "0x14843F4", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x14843F8", Offset = "0x14843F8", VA = "0x14843F8", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x14846A0", Offset = "0x14846A0", VA = "0x14846A0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x148438C", Offset = "0x148438C", VA = "0x148438C")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x14842B0", Offset = "0x14842B0", VA = "0x14842B0")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x14847A4", Offset = "0x14847A4", VA = "0x14847A4")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _poseRoot;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] children;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x194904C", Offset = "0x194904C", VA = "0x194904C", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1949104", Offset = "0x1949104", VA = "0x1949104", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x19492BC", Offset = "0x19492BC", VA = "0x19492BC", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x19493B8", Offset = "0x19493B8", VA = "0x19493B8", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x1949160", Offset = "0x1949160", VA = "0x1949160")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x1949768", Offset = "0x1949768", VA = "0x1949768")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C046C", Offset = "0x9C046C")]
		public float weight;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0484", Offset = "0x9C0484")]
		public float localRotationWeight;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C049C", Offset = "0x9C049C")]
		public float localPositionWeight;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000703")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000704")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000705")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000706")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x16ADF98", Offset = "0x16ADF98", VA = "0x16ADF98", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x16ADFEC", Offset = "0x16ADFEC", VA = "0x16ADFEC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x16AE028", Offset = "0x16AE028", VA = "0x16AE028", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x16AE040", Offset = "0x16AE040", VA = "0x16AE040")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BA51C", Offset = "0x9BA51C")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x2000151")]
		public class Rigidbone
		{
			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x400094A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x400094B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x400094C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x400094D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x400094E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x400094F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000950")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x4000951")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000953")]
			[Address(RVA = "0x16AE5C4", Offset = "0x16AE5C4", VA = "0x16AE5C4")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000954")]
			[Address(RVA = "0x16AF1D0", Offset = "0x16AF1D0", VA = "0x16AF1D0")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000955")]
			[Address(RVA = "0x16AEFB4", Offset = "0x16AEFB4", VA = "0x16AEFB4")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x2000152")]
		public class Child
		{
			[Token(Token = "0x4000953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000956")]
			[Address(RVA = "0x16AE720", Offset = "0x16AE720", VA = "0x16AE720")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000957")]
			[Address(RVA = "0x16AF36C", Offset = "0x16AF36C", VA = "0x16AF36C")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000958")]
			[Address(RVA = "0x16AF31C", Offset = "0x16AF31C", VA = "0x16AF31C")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x2000153")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA800", Offset = "0x9BA800")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000FE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600095C")]
				[Address(RVA = "0x16AF94C", Offset = "0x16AF94C", VA = "0x16AF94C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600095E")]
				[Address(RVA = "0x16AF9B4", Offset = "0x16AF9B4", VA = "0x16AF9B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000959")]
			[Address(RVA = "0x16AE780", Offset = "0x16AE780", VA = "0x16AE780")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600095A")]
			[Address(RVA = "0x16AF704", Offset = "0x16AF704", VA = "0x16AF704", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600095B")]
			[Address(RVA = "0x16AF708", Offset = "0x16AF708", VA = "0x16AF708", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600095D")]
			[Address(RVA = "0x16AF954", Offset = "0x16AF954", VA = "0x16AF954", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C04B4", Offset = "0x9C04B4")]
		public IK ik;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C04EC", Offset = "0x9C04EC")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0524", Offset = "0x9C0524")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C055C", Offset = "0x9C055C")]
		public float applyVelocity;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0594", Offset = "0x9C0594")]
		public float applyAngularVelocity;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000099")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x16AE088", Offset = "0x16AE088", VA = "0x16AE088")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009A")]
		private bool ikUsed
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x16AEB6C", Offset = "0x16AEB6C", VA = "0x16AEB6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x16AE050", Offset = "0x16AE050", VA = "0x16AE050")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x16AE100", Offset = "0x16AE100", VA = "0x16AE100")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x16AE230", Offset = "0x16AE230", VA = "0x16AE230")]
		public void Start()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x16AE1C0", Offset = "0x16AE1C0", VA = "0x16AE1C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C72D4", Offset = "0x9C72D4")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x16AE7AC", Offset = "0x16AE7AC", VA = "0x16AE7AC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x16AE9F8", Offset = "0x16AE9F8", VA = "0x16AE9F8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x16AEAB0", Offset = "0x16AEAB0", VA = "0x16AEAB0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x16AECF0", Offset = "0x16AECF0", VA = "0x16AECF0")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x16AEB30", Offset = "0x16AEB30", VA = "0x16AEB30")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x16AECAC", Offset = "0x16AECAC", VA = "0x16AECAC")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x16AED8C", Offset = "0x16AED8C", VA = "0x16AED8C")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x16AED24", Offset = "0x16AED24", VA = "0x16AED24")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x16AE158", Offset = "0x16AE158", VA = "0x16AE158")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x16AEA38", Offset = "0x16AEA38", VA = "0x16AEA38")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x16AF534", Offset = "0x16AF534", VA = "0x16AF534")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x16AF638", Offset = "0x16AF638", VA = "0x16AF638")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x1700009B")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x16B121C", Offset = "0x16B121C", VA = "0x16B121C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700009C")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x16B1258", Offset = "0x16B1258", VA = "0x16B1258")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x16B0EA4", Offset = "0x16B0EA4", VA = "0x16B0EA4")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x16B0EE8", Offset = "0x16B0EE8", VA = "0x16B0EE8")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x16B1174", Offset = "0x16B1174", VA = "0x16B1174")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x16B11E4", Offset = "0x16B11E4", VA = "0x16B11E4")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000723")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x16B1084", Offset = "0x16B1084", VA = "0x16B1084")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x16B1328", Offset = "0x16B1328", VA = "0x16B1328")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x16B132C", Offset = "0x16B132C", VA = "0x16B132C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x16B1360", Offset = "0x16B1360", VA = "0x16B1360")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x16B1444", Offset = "0x16B1444", VA = "0x16B1444")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x16B16C0", Offset = "0x16B16C0", VA = "0x16B16C0")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x16B177C", Offset = "0x16B177C", VA = "0x16B177C")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9BA580", Offset = "0x9BA580")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BA580", Offset = "0x9BA580")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C05DC", Offset = "0x9C05DC")]
		public float limit;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C05F8", Offset = "0x9C05F8")]
		public float twistLimit;

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x16B17F4", Offset = "0x16B17F4", VA = "0x16B17F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C7338", Offset = "0x9C7338")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x16B1840", Offset = "0x16B1840", VA = "0x16B1840")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C7370", Offset = "0x9C7370")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x16B188C", Offset = "0x16B188C", VA = "0x16B188C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C73A8", Offset = "0x9C73A8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x16B18D8", Offset = "0x16B18D8", VA = "0x16B18D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C73E0", Offset = "0x9C73E0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x16B1924", Offset = "0x16B1924", VA = "0x16B1924", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x16B19DC", Offset = "0x16B19DC", VA = "0x16B19DC")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x16B1C24", Offset = "0x16B1C24", VA = "0x16B1C24")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9BA5E0", Offset = "0x9BA5E0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BA5E0", Offset = "0x9BA5E0")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x16B1C34", Offset = "0x16B1C34", VA = "0x16B1C34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C7418", Offset = "0x9C7418")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x16B1C80", Offset = "0x16B1C80", VA = "0x16B1C80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C7450", Offset = "0x9C7450")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x16B1CCC", Offset = "0x16B1CCC", VA = "0x16B1CCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C7488", Offset = "0x9C7488")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x16B1D18", Offset = "0x16B1D18", VA = "0x16B1D18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C74C0", Offset = "0x9C74C0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x16B1D64", Offset = "0x16B1D64", VA = "0x16B1D64", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x16B1D8C", Offset = "0x16B1D8C", VA = "0x16B1D8C")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x16B208C", Offset = "0x16B208C", VA = "0x16B208C")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9BA640", Offset = "0x9BA640")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BA640", Offset = "0x9BA640")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x2000154")]
		public class ReachCone
		{
			[Token(Token = "0x4000959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x400095A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x400095B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x400095C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x17000100")]
			public Vector3 o
			{
				[Token(Token = "0x600095F")]
				[Address(RVA = "0x1CBB6B8", Offset = "0x1CBB6B8", VA = "0x1CBB6B8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000101")]
			public Vector3 a
			{
				[Token(Token = "0x6000960")]
				[Address(RVA = "0x1CBB6F0", Offset = "0x1CBB6F0", VA = "0x1CBB6F0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000102")]
			public Vector3 b
			{
				[Token(Token = "0x6000961")]
				[Address(RVA = "0x1CBB72C", Offset = "0x1CBB72C", VA = "0x1CBB72C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000103")]
			public Vector3 c
			{
				[Token(Token = "0x6000962")]
				[Address(RVA = "0x1CBB768", Offset = "0x1CBB768", VA = "0x1CBB768")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000104")]
			public bool isValid
			{
				[Token(Token = "0x6000964")]
				[Address(RVA = "0x1CBA818", Offset = "0x1CBA818", VA = "0x1CBA818")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000963")]
			[Address(RVA = "0x1CBAE64", Offset = "0x1CBAE64", VA = "0x1CBAE64")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000965")]
			[Address(RVA = "0x1CBAFC4", Offset = "0x1CBAFC4", VA = "0x1CBAFC4")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000155")]
		public class LimitPoint
		{
			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x6000966")]
			[Address(RVA = "0x1CBA828", Offset = "0x1CBA828", VA = "0x1CBA828")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0624", Offset = "0x9C0624")]
		public float twistLimit;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0640", Offset = "0x9C0640")]
		public int smoothIterations;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x1CB97E8", Offset = "0x1CB97E8", VA = "0x1CB97E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C74F8", Offset = "0x9C74F8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x1CB9834", Offset = "0x1CB9834", VA = "0x1CB9834")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C7530", Offset = "0x9C7530")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x1CB9880", Offset = "0x1CB9880", VA = "0x1CB9880")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C7568", Offset = "0x9C7568")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x1CB98CC", Offset = "0x1CB98CC", VA = "0x1CB98CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C75A0", Offset = "0x9C75A0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x1CB9918", Offset = "0x1CB9918", VA = "0x1CB9918")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x1CB9DEC", Offset = "0x1CB9DEC", VA = "0x1CB9DEC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x1CB9ECC", Offset = "0x1CB9ECC", VA = "0x1CB9ECC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x1CBA464", Offset = "0x1CBA464", VA = "0x1CBA464")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x1CB99A4", Offset = "0x1CB99A4", VA = "0x1CB99A4")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x1CBA8AC", Offset = "0x1CBA8AC", VA = "0x1CBA8AC")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x1CBB184", Offset = "0x1CBB184", VA = "0x1CBB184")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x1CBB1C8", Offset = "0x1CBB1C8", VA = "0x1CBB1C8")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x1CBB310", Offset = "0x1CBB310", VA = "0x1CBB310")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x1CBA13C", Offset = "0x1CBA13C", VA = "0x1CBA13C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x1CBB4A0", Offset = "0x1CBB4A0", VA = "0x1CBB4A0")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x1CBB650", Offset = "0x1CBB650", VA = "0x1CBB650")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9BA6A0", Offset = "0x9BA6A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BA6A0", Offset = "0x9BA6A0")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0700", Offset = "0x9C0700")]
		public float twistLimit;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x1CBB7A4", Offset = "0x1CBB7A4", VA = "0x1CBB7A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C75D8", Offset = "0x9C75D8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x1CBB7F0", Offset = "0x1CBB7F0", VA = "0x1CBB7F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C7610", Offset = "0x9C7610")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x1CBB83C", Offset = "0x1CBB83C", VA = "0x1CBB83C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C7648", Offset = "0x9C7648")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x1CBB888", Offset = "0x1CBB888", VA = "0x1CBB888")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C7680", Offset = "0x9C7680")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x1CBB8D4", Offset = "0x1CBB8D4", VA = "0x1CBB8D4")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x1CBB8F0", Offset = "0x1CBB8F0", VA = "0x1CBB8F0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x1CBB990", Offset = "0x1CBB990", VA = "0x1CBB990")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1CBBCB8", Offset = "0x1CBBCB8", VA = "0x1CBBCB8")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0754", Offset = "0x9C0754")]
		public AimIK ik;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C078C", Offset = "0x9C078C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C078C", Offset = "0x9C078C")]
		public float weight;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C07E0", Offset = "0x9C07E0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C07E0", Offset = "0x9C07E0")]
		public Transform target;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0840", Offset = "0x9C0840")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0878", Offset = "0x9C0878")]
		public float weightSmoothTime;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C08B0", Offset = "0x9C08B0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C08B0", Offset = "0x9C08B0")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0910", Offset = "0x9C0910")]
		public float maxRadiansDelta;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0948", Offset = "0x9C0948")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0980", Offset = "0x9C0980")]
		public float slerpSpeed;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C09B8", Offset = "0x9C09B8")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C09F0", Offset = "0x9C09F0")]
		public float minDistance;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0A28", Offset = "0x9C0A28")]
		public Vector3 offset;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0A60", Offset = "0x9C0A60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0A60", Offset = "0x9C0A60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0A60", Offset = "0x9C0A60")]
		public float maxRootAngle;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0ADC", Offset = "0x9C0ADC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0ADC", Offset = "0x9C0ADC")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0B3C", Offset = "0x9C0B3C")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform lastTarget;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float switchWeight;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float switchWeightV;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float weightV;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 dir;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x1700009D")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x1477930", Offset = "0x1477930", VA = "0x1477930")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x1477834", Offset = "0x1477834", VA = "0x1477834")]
		private void Start()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1477A7C", Offset = "0x1477A7C", VA = "0x1477A7C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1478198", Offset = "0x1478198", VA = "0x1478198")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x1478334", Offset = "0x1478334", VA = "0x1478334")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x1478650", Offset = "0x1478650", VA = "0x1478650")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000156")]
		public class Pose
		{
			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000967")]
			[Address(RVA = "0x14789DC", Offset = "0x14789DC", VA = "0x14789DC")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000968")]
			[Address(RVA = "0x1478D48", Offset = "0x1478D48", VA = "0x1478D48")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000969")]
			[Address(RVA = "0x1478D50", Offset = "0x1478D50", VA = "0x1478D50")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x1478900", Offset = "0x1478900", VA = "0x1478900")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1478C74", Offset = "0x1478C74", VA = "0x1478C74")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x1478CE0", Offset = "0x1478CE0", VA = "0x1478CE0")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000157")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x200016C")]
			public class EffectorLink
			{
				[Token(Token = "0x40009DD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C48A8", Offset = "0x9C48A8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40009DE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C48E0", Offset = "0x9C48E0")]
				public float weight;

				[Token(Token = "0x60009B6")]
				[Address(RVA = "0x1479340", Offset = "0x1479340", VA = "0x1479340")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3ADC", Offset = "0x9C3ADC")]
			public Transform transform;

			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3B14", Offset = "0x9C3B14")]
			public Transform relativeTo;

			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3B4C", Offset = "0x9C3B4C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3B84", Offset = "0x9C3B84")]
			public float verticalWeight;

			[Token(Token = "0x4000969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3BBC", Offset = "0x9C3BBC")]
			public float horizontalWeight;

			[Token(Token = "0x400096A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3BF4", Offset = "0x9C3BF4")]
			public float speed;

			[Token(Token = "0x400096B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x400096C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x400096D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x600096A")]
			[Address(RVA = "0x1478EAC", Offset = "0x1478EAC", VA = "0x1478EAC")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x600096B")]
			[Address(RVA = "0x1479318", Offset = "0x1479318", VA = "0x1479318")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600096C")]
			[Address(RVA = "0x1479328", Offset = "0x1479328", VA = "0x1479328")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0B74", Offset = "0x9C0B74")]
		public Body[] bodies;

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x1478D6C", Offset = "0x1478D6C", VA = "0x1478D6C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x1479310", Offset = "0x1479310", VA = "0x1479310")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0BAC", Offset = "0x9C0BAC")]
		public float tiltSpeed;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0BE4", Offset = "0x9C0BE4")]
		public float tiltSensitivity;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0C1C", Offset = "0x9C0C1C")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0C54", Offset = "0x9C0C54")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x147A6B4", Offset = "0x147A6B4", VA = "0x147A6B4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x147A6FC", Offset = "0x147A6FC", VA = "0x147A6FC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x147A92C", Offset = "0x147A92C", VA = "0x147A92C")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000158")]
		public abstract class HitPoint
		{
			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3C2C", Offset = "0x9C3C2C")]
			public string name;

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3C64", Offset = "0x9C3C64")]
			public Collider collider;

			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3C9C", Offset = "0x9C3C9C")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3CE8", Offset = "0x9C3CE8")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3CF8", Offset = "0x9C3CF8")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3D08", Offset = "0x9C3D08")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3D18", Offset = "0x9C3D18")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x17000105")]
			public bool inProgress
			{
				[Token(Token = "0x600096D")]
				[Address(RVA = "0x194982C", Offset = "0x194982C", VA = "0x194982C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000106")]
			protected float crossFader
			{
				[Token(Token = "0x600096E")]
				[Address(RVA = "0x1949DD4", Offset = "0x1949DD4", VA = "0x1949DD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7F40", Offset = "0x9C7F40")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600096F")]
				[Address(RVA = "0x1949DDC", Offset = "0x1949DDC", VA = "0x1949DDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7F50", Offset = "0x9C7F50")]
				private set
				{
				}
			}

			[Token(Token = "0x17000107")]
			protected float timer
			{
				[Token(Token = "0x6000970")]
				[Address(RVA = "0x1949DE4", Offset = "0x1949DE4", VA = "0x1949DE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7F60", Offset = "0x9C7F60")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000971")]
				[Address(RVA = "0x1949DEC", Offset = "0x1949DEC", VA = "0x1949DEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7F70", Offset = "0x9C7F70")]
				private set
				{
				}
			}

			[Token(Token = "0x17000108")]
			protected Vector3 force
			{
				[Token(Token = "0x6000972")]
				[Address(RVA = "0x1949DF4", Offset = "0x1949DF4", VA = "0x1949DF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7F80", Offset = "0x9C7F80")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000973")]
				[Address(RVA = "0x1949E00", Offset = "0x1949E00", VA = "0x1949E00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7F90", Offset = "0x9C7F90")]
				private set
				{
				}
			}

			[Token(Token = "0x17000109")]
			protected Vector3 point
			{
				[Token(Token = "0x6000974")]
				[Address(RVA = "0x1949E0C", Offset = "0x1949E0C", VA = "0x1949E0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7FA0", Offset = "0x9C7FA0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000975")]
				[Address(RVA = "0x1949E18", Offset = "0x1949E18", VA = "0x1949E18")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7FB0", Offset = "0x9C7FB0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000976")]
			[Address(RVA = "0x1949CA0", Offset = "0x1949CA0", VA = "0x1949CA0")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000977")]
			[Address(RVA = "0x1949914", Offset = "0x1949914", VA = "0x1949914")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000978")]
			protected abstract float GetLength();

			[Token(Token = "0x6000979")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600097A")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x600097B")]
			[Address(RVA = "0x1949E24", Offset = "0x1949E24", VA = "0x1949E24")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000159")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x200016D")]
			public class EffectorLink
			{
				[Token(Token = "0x40009DF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4918", Offset = "0x9C4918")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40009E0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4950", Offset = "0x9C4950")]
				public float weight;

				[Token(Token = "0x40009E1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40009E2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60009B7")]
				[Address(RVA = "0x194A790", Offset = "0x194A790", VA = "0x194A790")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60009B8")]
				[Address(RVA = "0x194A584", Offset = "0x194A584", VA = "0x194A584")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60009B9")]
				[Address(RVA = "0x194A8CC", Offset = "0x194A8CC", VA = "0x194A8CC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3D28", Offset = "0x9C3D28")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3D60", Offset = "0x9C3D60")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400097A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3D98", Offset = "0x9C3D98")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600097C")]
			[Address(RVA = "0x194A3A0", Offset = "0x194A3A0", VA = "0x194A3A0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600097D")]
			[Address(RVA = "0x194A518", Offset = "0x194A518", VA = "0x194A518", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600097E")]
			[Address(RVA = "0x194A598", Offset = "0x194A598", VA = "0x194A598", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600097F")]
			[Address(RVA = "0x194A8B8", Offset = "0x194A8B8", VA = "0x194A8B8")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200015A")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x200016E")]
			public class BoneLink
			{
				[Token(Token = "0x40009E3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4988", Offset = "0x9C4988")]
				public Transform bone;

				[Token(Token = "0x40009E4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C49C0", Offset = "0x9C49C0")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C49C0", Offset = "0x9C49C0")]
				public float weight;

				[Token(Token = "0x40009E5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x40009E6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x60009BA")]
				[Address(RVA = "0x194A1A8", Offset = "0x194A1A8", VA = "0x194A1A8")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60009BB")]
				[Address(RVA = "0x1949F40", Offset = "0x1949F40", VA = "0x1949F40")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60009BC")]
				[Address(RVA = "0x194A318", Offset = "0x194A318", VA = "0x194A318")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400097B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3DD0", Offset = "0x9C3DD0")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x400097C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3E08", Offset = "0x9C3E08")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x400097D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000980")]
			[Address(RVA = "0x1949E38", Offset = "0x1949E38", VA = "0x1949E38", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000981")]
			[Address(RVA = "0x1949EDC", Offset = "0x1949EDC", VA = "0x1949EDC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000982")]
			[Address(RVA = "0x1949F4C", Offset = "0x1949F4C", VA = "0x1949F4C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000983")]
			[Address(RVA = "0x194A304", Offset = "0x194A304", VA = "0x194A304")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0C8C", Offset = "0x9C0C8C")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0CC4", Offset = "0x9C0CC4")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700009E")]
		public bool inProgress
		{
			[Token(Token = "0x600075F")]
			[Address(RVA = "0x1949770", Offset = "0x1949770", VA = "0x1949770")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x1949840", Offset = "0x1949840", VA = "0x1949840", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x1949A60", Offset = "0x1949A60", VA = "0x1949A60")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x1949DCC", Offset = "0x1949DCC", VA = "0x1949DCC")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x200015B")]
		public abstract class Offset
		{
			[Token(Token = "0x400097E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3E40", Offset = "0x9C3E40")]
			public string name;

			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3E78", Offset = "0x9C3E78")]
			public Collider collider;

			[Token(Token = "0x4000980")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3EB0", Offset = "0x9C3EB0")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000981")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3EFC", Offset = "0x9C3EFC")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000982")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3F0C", Offset = "0x9C3F0C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000983")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3F1C", Offset = "0x9C3F1C")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000984")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3F2C", Offset = "0x9C3F2C")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x1700010A")]
			protected float crossFader
			{
				[Token(Token = "0x6000984")]
				[Address(RVA = "0x194AE84", Offset = "0x194AE84", VA = "0x194AE84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7FC0", Offset = "0x9C7FC0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000985")]
				[Address(RVA = "0x194AE8C", Offset = "0x194AE8C", VA = "0x194AE8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7FD0", Offset = "0x9C7FD0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700010B")]
			protected float timer
			{
				[Token(Token = "0x6000986")]
				[Address(RVA = "0x194AE94", Offset = "0x194AE94", VA = "0x194AE94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7FE0", Offset = "0x9C7FE0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000987")]
				[Address(RVA = "0x194AE9C", Offset = "0x194AE9C", VA = "0x194AE9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7FF0", Offset = "0x9C7FF0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700010C")]
			protected Vector3 force
			{
				[Token(Token = "0x6000988")]
				[Address(RVA = "0x194AEA4", Offset = "0x194AEA4", VA = "0x194AEA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C8000", Offset = "0x9C8000")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000989")]
				[Address(RVA = "0x194AEB0", Offset = "0x194AEB0", VA = "0x194AEB0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C8010", Offset = "0x9C8010")]
				private set
				{
				}
			}

			[Token(Token = "0x1700010D")]
			protected Vector3 point
			{
				[Token(Token = "0x600098A")]
				[Address(RVA = "0x194AEBC", Offset = "0x194AEBC", VA = "0x194AEBC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C8020", Offset = "0x9C8020")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600098B")]
				[Address(RVA = "0x194AEC8", Offset = "0x194AEC8", VA = "0x194AEC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C8030", Offset = "0x9C8030")]
				private set
				{
				}
			}

			[Token(Token = "0x600098C")]
			[Address(RVA = "0x194AD3C", Offset = "0x194AD3C", VA = "0x194AD3C")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x600098D")]
			[Address(RVA = "0x194A9A0", Offset = "0x194A9A0", VA = "0x194A9A0")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600098E")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x600098F")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000990")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000991")]
			[Address(RVA = "0x194AED4", Offset = "0x194AED4", VA = "0x194AED4")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200015C")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x200016F")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x40009E7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4A14", Offset = "0x9C4A14")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x40009E8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4A4C", Offset = "0x9C4A4C")]
				public float weight;

				[Token(Token = "0x40009E9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40009EA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60009BD")]
				[Address(RVA = "0x194B390", Offset = "0x194B390", VA = "0x194B390")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60009BE")]
				[Address(RVA = "0x194B14C", Offset = "0x194B14C", VA = "0x194B14C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60009BF")]
				[Address(RVA = "0x194B4AC", Offset = "0x194B4AC", VA = "0x194B4AC")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3F3C", Offset = "0x9C3F3C")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3F74", Offset = "0x9C3F74")]
			public int upDirCurveIndex;

			[Token(Token = "0x400098A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3FAC", Offset = "0x9C3FAC")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000992")]
			[Address(RVA = "0x194AEE8", Offset = "0x194AEE8", VA = "0x194AEE8", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000993")]
			[Address(RVA = "0x194B0E0", Offset = "0x194B0E0", VA = "0x194B0E0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000994")]
			[Address(RVA = "0x194B160", Offset = "0x194B160", VA = "0x194B160", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000995")]
			[Address(RVA = "0x194B490", Offset = "0x194B490", VA = "0x194B490")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200015D")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000170")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x40009EB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4A84", Offset = "0x9C4A84")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x40009EC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4ABC", Offset = "0x9C4ABC")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C4ABC", Offset = "0x9C4ABC")]
				public float weight;

				[Token(Token = "0x40009ED")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x40009EE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x60009C0")]
				[Address(RVA = "0x194B914", Offset = "0x194B914", VA = "0x194B914")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60009C1")]
				[Address(RVA = "0x194B5FC", Offset = "0x194B5FC", VA = "0x194B5FC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60009C2")]
				[Address(RVA = "0x194BA50", Offset = "0x194BA50", VA = "0x194BA50")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400098B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C3FE4", Offset = "0x9C3FE4")]
			public int curveIndex;

			[Token(Token = "0x400098C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C401C", Offset = "0x9C401C")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x400098D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000996")]
			[Address(RVA = "0x194B4B4", Offset = "0x194B4B4", VA = "0x194B4B4", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000997")]
			[Address(RVA = "0x194B598", Offset = "0x194B598", VA = "0x194B598", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000998")]
			[Address(RVA = "0x194B608", Offset = "0x194B608", VA = "0x194B608", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000999")]
			[Address(RVA = "0x194BA3C", Offset = "0x194BA3C", VA = "0x194BA3C")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0CFC", Offset = "0x9C0CFC")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0D34", Offset = "0x9C0D34")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x194A8D4", Offset = "0x194A8D4", VA = "0x194A8D4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x194AAF4", Offset = "0x194AAF4", VA = "0x194AAF4")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x194AE7C", Offset = "0x194AE7C", VA = "0x194AE7C")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200015E")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000171")]
			public class EffectorLink
			{
				[Token(Token = "0x40009EF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4B10", Offset = "0x9C4B10")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40009F0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4B48", Offset = "0x9C4B48")]
				public float weight;

				[Token(Token = "0x60009C3")]
				[Address(RVA = "0x16A32A0", Offset = "0x16A32A0", VA = "0x16A32A0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400098E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4054", Offset = "0x9C4054")]
			public Transform transform;

			[Token(Token = "0x400098F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C408C", Offset = "0x9C408C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000990")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C40C4", Offset = "0x9C40C4")]
			public float speed;

			[Token(Token = "0x4000991")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C40FC", Offset = "0x9C40FC")]
			public float acceleration;

			[Token(Token = "0x4000992")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4134", Offset = "0x9C4134")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C4134", Offset = "0x9C4134")]
			public float matchVelocity;

			[Token(Token = "0x4000993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4188", Offset = "0x9C4188")]
			public float gravity;

			[Token(Token = "0x4000994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x600099A")]
			[Address(RVA = "0x16A2C70", Offset = "0x16A2C70", VA = "0x16A2C70")]
			public void Reset()
			{
			}

			[Token(Token = "0x600099B")]
			[Address(RVA = "0x16A2E30", Offset = "0x16A2E30", VA = "0x16A2E30")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600099C")]
			[Address(RVA = "0x16A3284", Offset = "0x16A3284", VA = "0x16A3284")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0D6C", Offset = "0x9C0D6C")]
		public Body[] bodies;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0DA4", Offset = "0x9C0DA4")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x16A2BF8", Offset = "0x16A2BF8", VA = "0x16A2BF8")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x16A2D4C", Offset = "0x16A2D4C", VA = "0x16A2D4C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x16A3264", Offset = "0x16A3264", VA = "0x16A3264")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200015F")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C41C0", Offset = "0x9C41C0")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400099A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C41F8", Offset = "0x9C41F8")]
			public float spring;

			[Token(Token = "0x400099B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4230", Offset = "0x9C4230")]
			public bool x;

			[Token(Token = "0x400099C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4268", Offset = "0x9C4268")]
			public bool y;

			[Token(Token = "0x400099D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C42A0", Offset = "0x9C42A0")]
			public bool z;

			[Token(Token = "0x400099E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C42D8", Offset = "0x9C42D8")]
			public float minX;

			[Token(Token = "0x400099F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4310", Offset = "0x9C4310")]
			public float maxX;

			[Token(Token = "0x40009A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4348", Offset = "0x9C4348")]
			public float minY;

			[Token(Token = "0x40009A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4380", Offset = "0x9C4380")]
			public float maxY;

			[Token(Token = "0x40009A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C43B8", Offset = "0x9C43B8")]
			public float minZ;

			[Token(Token = "0x40009A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C43F0", Offset = "0x9C43F0")]
			public float maxZ;

			[Token(Token = "0x600099D")]
			[Address(RVA = "0x16ACFB0", Offset = "0x16ACFB0", VA = "0x16ACFB0")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600099E")]
			[Address(RVA = "0x16AD4B8", Offset = "0x16AD4B8", VA = "0x16AD4B8")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x600099F")]
			[Address(RVA = "0x16AD4E8", Offset = "0x16AD4E8", VA = "0x16AD4E8")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x16AD5C0", Offset = "0x16AD5C0", VA = "0x16AD5C0")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA810", Offset = "0x9BA810")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x1700010E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009A4")]
				[Address(RVA = "0x16AD448", Offset = "0x16AD448", VA = "0x16AD448", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009A6")]
				[Address(RVA = "0x16AD4B0", Offset = "0x16AD4B0", VA = "0x16AD4B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x16ACE78", Offset = "0x16ACE78", VA = "0x16ACE78")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x16AD308", Offset = "0x16AD308", VA = "0x16AD308", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x16AD30C", Offset = "0x16AD30C", VA = "0x16AD30C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x16AD450", Offset = "0x16AD450", VA = "0x16AD450", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0DDC", Offset = "0x9C0DDC")]
		public float weight;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0E14", Offset = "0x9C0E14")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x1700009F")]
		protected float deltaTime
		{
			[Token(Token = "0x6000769")]
			[Address(RVA = "0x16A2E04", Offset = "0x16A2E04", VA = "0x16A2E04")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600076A")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x16ACDDC", Offset = "0x16ACDDC", VA = "0x16ACDDC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x16ACE08", Offset = "0x16ACE08", VA = "0x16ACE08")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C76B8", Offset = "0x9C76B8")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x16ACEA4", Offset = "0x16ACEA4", VA = "0x16ACEA4")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x16A31A8", Offset = "0x16A31A8", VA = "0x16A31A8")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x16AD210", Offset = "0x16AD210", VA = "0x16AD210", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x16A3274", Offset = "0x16A3274", VA = "0x16A3274")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000161")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA820", Offset = "0x9BA820")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x17000110")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009AA")]
				[Address(RVA = "0x16ADA10", Offset = "0x16ADA10", VA = "0x16ADA10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000111")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009AC")]
				[Address(RVA = "0x16ADA78", Offset = "0x16ADA78", VA = "0x16ADA78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x16AD690", Offset = "0x16AD690", VA = "0x16AD690")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x16AD8D0", Offset = "0x16AD8D0", VA = "0x16AD8D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009A9")]
			[Address(RVA = "0x16AD8D4", Offset = "0x16AD8D4", VA = "0x16AD8D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x16ADA18", Offset = "0x16ADA18", VA = "0x16ADA18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0E4C", Offset = "0x9C0E4C")]
		public float weight;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0E84", Offset = "0x9C0E84")]
		public VRIK ik;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000A0")]
		protected float deltaTime
		{
			[Token(Token = "0x6000771")]
			[Address(RVA = "0x16AD5C8", Offset = "0x16AD5C8", VA = "0x16AD5C8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000772")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x16AD5F4", Offset = "0x16AD5F4", VA = "0x16AD5F4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x16AD620", Offset = "0x16AD620", VA = "0x16AD620")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C771C", Offset = "0x9C771C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x16AD6BC", Offset = "0x16AD6BC", VA = "0x16AD6BC")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x16AD7C8", Offset = "0x16AD7C8", VA = "0x16AD7C8", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x16AD8C0", Offset = "0x16AD8C0", VA = "0x16AD8C0")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000162")]
		public class EffectorLink
		{
			[Token(Token = "0x40009AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40009AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40009AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40009AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x16ADB40", Offset = "0x16ADB40", VA = "0x16ADB40")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x16ADF90", Offset = "0x16ADF90", VA = "0x16ADF90")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x16ADA80", Offset = "0x16ADA80", VA = "0x16ADA80")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x16ADE78", Offset = "0x16ADE78", VA = "0x16ADE78")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x16ADF30", Offset = "0x16ADF30", VA = "0x16ADF30")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000163")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x2000172")]
			public class EffectorLink
			{
				[Token(Token = "0x40009F1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4B80", Offset = "0x9C4B80")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40009F2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4BB8", Offset = "0x9C4BB8")]
				public float weight;

				[Token(Token = "0x60009C4")]
				[Address(RVA = "0x16B0E9C", Offset = "0x16B0E9C", VA = "0x16B0E9C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40009AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4428", Offset = "0x9C4428")]
			public Vector3 offset;

			[Token(Token = "0x40009AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4460", Offset = "0x9C4460")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C4460", Offset = "0x9C4460")]
			public float additivity;

			[Token(Token = "0x40009B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C44B4", Offset = "0x9C44B4")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40009B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C44EC", Offset = "0x9C44EC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40009B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40009B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60009AF")]
			[Address(RVA = "0x16AFBE4", Offset = "0x16AFBE4", VA = "0x16AFBE4")]
			public void Start()
			{
			}

			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x16B0774", Offset = "0x16B0774", VA = "0x16B0774")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x16B0E88", Offset = "0x16B0E88", VA = "0x16B0E88")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000164")]
		public enum Handedness
		{
			[Token(Token = "0x40009B5")]
			Right,
			[Token(Token = "0x40009B6")]
			Left
		}

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0EBC", Offset = "0x9C0EBC")]
		public AimIK aimIK;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0EF4", Offset = "0x9C0EF4")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0F2C", Offset = "0x9C0F2C")]
		public Handedness handedness;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0F64", Offset = "0x9C0F64")]
		public bool twoHanded;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0F9C", Offset = "0x9C0F9C")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0FD4", Offset = "0x9C0FD4")]
		public float magnitudeRandom;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C100C", Offset = "0x9C100C")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1044", Offset = "0x9C1044")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C107C", Offset = "0x9C107C")]
		public float blendTime;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9C10B4", Offset = "0x9C10B4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C10B4", Offset = "0x9C10B4")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000A1")]
		public bool isFinished
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0x16AF9BC", Offset = "0x16AF9BC", VA = "0x16AF9BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A2")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x16B0A28", Offset = "0x16B0A28", VA = "0x16B0A28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0x16B0A68", Offset = "0x16B0A68", VA = "0x16B0A68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000783")]
			[Address(RVA = "0x16B09E8", Offset = "0x16B09E8", VA = "0x16B09E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000784")]
			[Address(RVA = "0x16B0A08", Offset = "0x16B0A08", VA = "0x16B0A08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x16AF9EC", Offset = "0x16AF9EC", VA = "0x16AF9EC")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x16AFA18", Offset = "0x16AFA18", VA = "0x16AFA18")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x16AFC94", Offset = "0x16AFC94", VA = "0x16AFC94", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x16B0AA8", Offset = "0x16B0AA8", VA = "0x16B0AA8")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x16B0C00", Offset = "0x16B0C00", VA = "0x16B0C00")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x16B0C3C", Offset = "0x16B0C3C", VA = "0x16B0C3C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x16B0DD4", Offset = "0x16B0DD4", VA = "0x16B0DD4")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C1114", Offset = "0x9C1114")]
		public float weight;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C114C", Offset = "0x9C114C")]
		public float offset;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1CBBCC8", Offset = "0x1CBBCC8", VA = "0x1CBBCC8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1CBBD9C", Offset = "0x1CBBD9C", VA = "0x1CBBD9C")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1CBBE88", Offset = "0x1CBBE88", VA = "0x1CBBE88")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1CBC2D0", Offset = "0x1CBC2D0", VA = "0x1CBC2D0")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x1CBC308", Offset = "0x1CBC308", VA = "0x1CBC308")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x1CBC400", Offset = "0x1CBC400", VA = "0x1CBC400")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x2000165")]
		public class Settings
		{
			[Token(Token = "0x40009B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4524", Offset = "0x9C4524")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40009B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C455C", Offset = "0x9C455C")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40009B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4594", Offset = "0x9C4594")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x40009BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C45CC", Offset = "0x9C45CC")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x40009BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4604", Offset = "0x9C4604")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40009BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C463C", Offset = "0x9C463C")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40009BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4674", Offset = "0x9C4674")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40009BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C46AC", Offset = "0x9C46AC")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40009BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9C46E4", Offset = "0x9C46E4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C46E4", Offset = "0x9C46E4")]
			public Vector3 headOffset;

			[Token(Token = "0x40009C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C4734", Offset = "0x9C4734")]
			public Vector3 handOffset;

			[Token(Token = "0x40009C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C476C", Offset = "0x9C476C")]
			public float footForwardOffset;

			[Token(Token = "0x40009C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C47A4", Offset = "0x9C47A4")]
			public float footInwardOffset;

			[Token(Token = "0x40009C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C47DC", Offset = "0x9C47DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C47DC", Offset = "0x9C47DC")]
			public float footHeadingOffset;

			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x1CBFD54", Offset = "0x1CBFD54", VA = "0x1CBFD54")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1CBE26C", Offset = "0x1CBE26C", VA = "0x1CBE26C")]
		public static void Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1CBF454", Offset = "0x1CBF454", VA = "0x1CBF454")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvisTarget;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftFootTarget;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightFootTarget;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 pelvisTargetRight;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1CBFE3C", Offset = "0x1CBFE3C", VA = "0x1CBFE3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1CBFC14", Offset = "0x1CBFC14", VA = "0x1CBFC14")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1CBFF10", Offset = "0x1CBFF10", VA = "0x1CBFF10")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1CC02FC", Offset = "0x1CC02FC", VA = "0x1CC02FC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x1CC03F4", Offset = "0x1CC03F4", VA = "0x1CC03F4")]
		public VRIKRootController()
		{
		}
	}
}
