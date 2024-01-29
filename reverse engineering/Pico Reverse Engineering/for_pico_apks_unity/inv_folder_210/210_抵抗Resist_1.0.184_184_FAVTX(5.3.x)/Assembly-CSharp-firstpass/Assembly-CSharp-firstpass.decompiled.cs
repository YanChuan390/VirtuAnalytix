using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RootMotion
{
	[Token(Token = "0x2000002")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000073")]
		public enum UpdateMode
		{
			[Token(Token = "0x40003A0")]
			Update,
			[Token(Token = "0x40003A1")]
			FixedUpdate,
			[Token(Token = "0x40003A2")]
			LateUpdate,
			[Token(Token = "0x40003A3")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7948A0", Offset = "0x7948A0")]
		public bool smoothFollow;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7948D8", Offset = "0x7948D8")]
		public float rotationSensitivity;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x794910", Offset = "0x794910")]
		public float distance;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x794948", Offset = "0x794948")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x794980", Offset = "0x794980")]
		public float blockedOffset;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x794998", Offset = "0x794998")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7949A8", Offset = "0x7949A8")]
		private float <y>k__BackingField;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7949B8", Offset = "0x7949B8")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000001")]
		public float x
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x196C5D4", Offset = "0x196C5D4", VA = "0x196C5D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79A8B8", Offset = "0x79A8B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x196C5DC", Offset = "0x196C5DC", VA = "0x196C5DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79A8C8", Offset = "0x79A8C8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float y
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x196C5E4", Offset = "0x196C5E4", VA = "0x196C5E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79A8D8", Offset = "0x79A8D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x196C5EC", Offset = "0x196C5EC", VA = "0x196C5EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79A8E8", Offset = "0x79A8E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public float distanceTarget
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x196C5F4", Offset = "0x196C5F4", VA = "0x196C5F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79A8F8", Offset = "0x79A8F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x196C5FC", Offset = "0x196C5FC", VA = "0x196C5FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79A908", Offset = "0x79A908")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		private float zoomAdd
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x196CE40", Offset = "0x196CE40", VA = "0x196CE40")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x196C604", Offset = "0x196C604", VA = "0x196C604", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x196C708", Offset = "0x196C708", VA = "0x196C708", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x196C764", Offset = "0x196C764", VA = "0x196C764", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x196C7CC", Offset = "0x196C7CC", VA = "0x196C7CC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x196C830", Offset = "0x196C830", VA = "0x196C830")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x196C73C", Offset = "0x196C73C", VA = "0x196C73C")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x196C9B0", Offset = "0x196C9B0", VA = "0x196C9B0")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x196CE10", Offset = "0x196CE10", VA = "0x196CE10")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x196CEB0", Offset = "0x196CEB0", VA = "0x196CEB0")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000003")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x196CF54", Offset = "0x196CF54", VA = "0x196CF54")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x196CF8C", Offset = "0x196CF8C", VA = "0x196CF8C")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x196D134", Offset = "0x196D134", VA = "0x196D134")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x196D164", Offset = "0x196D164", VA = "0x196D164")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000004")]
	public enum Axis
	{
		[Token(Token = "0x400002C")]
		X,
		[Token(Token = "0x400002D")]
		Y,
		[Token(Token = "0x400002E")]
		Z
	}
	[Token(Token = "0x2000005")]
	public class AxisTools
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x19640D0", Offset = "0x19640D0", VA = "0x19640D0")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x19640F4", Offset = "0x19640F4", VA = "0x19640F4")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x196412C", Offset = "0x196412C", VA = "0x196412C")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x196421C", Offset = "0x196421C", VA = "0x196421C")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x19641C4", Offset = "0x19641C4", VA = "0x19641C4")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x19642B4", Offset = "0x19642B4", VA = "0x19642B4")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1964410", Offset = "0x1964410", VA = "0x1964410")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000006")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000074")]
		public class LimbOrientation
		{
			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x1AB8F74", Offset = "0x1AB8F74", VA = "0x1AB8F74")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000005")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x196588C", Offset = "0x196588C", VA = "0x196588C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x1965AF8", Offset = "0x1965AF8", VA = "0x1965AF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1965840", Offset = "0x1965840", VA = "0x1965840")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000075")]
		public enum BoneType
		{
			[Token(Token = "0x40003A8")]
			Unassigned,
			[Token(Token = "0x40003A9")]
			Spine,
			[Token(Token = "0x40003AA")]
			Head,
			[Token(Token = "0x40003AB")]
			Arm,
			[Token(Token = "0x40003AC")]
			Leg,
			[Token(Token = "0x40003AD")]
			Tail,
			[Token(Token = "0x40003AE")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000076")]
		public enum BoneSide
		{
			[Token(Token = "0x40003B0")]
			Center,
			[Token(Token = "0x40003B1")]
			Left,
			[Token(Token = "0x40003B2")]
			Right
		}

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1965D64", Offset = "0x1965D64", VA = "0x1965D64")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1966080", Offset = "0x1966080", VA = "0x1966080")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x19662EC", Offset = "0x19662EC", VA = "0x19662EC")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x196636C", Offset = "0x196636C", VA = "0x196636C")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1966414", Offset = "0x1966414", VA = "0x1966414")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1965F34", Offset = "0x1965F34", VA = "0x1965F34")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1966250", Offset = "0x1966250", VA = "0x1966250")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1966C44", Offset = "0x1966C44", VA = "0x1966C44")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1966A4C", Offset = "0x1966A4C", VA = "0x1966A4C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1966B48", Offset = "0x1966B48", VA = "0x1966B48")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x196662C", Offset = "0x196662C", VA = "0x196662C")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x19666DC", Offset = "0x19666DC", VA = "0x19666DC")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x196678C", Offset = "0x196678C", VA = "0x196678C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x196683C", Offset = "0x196683C", VA = "0x196683C")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x19668EC", Offset = "0x19668EC", VA = "0x19668EC")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x196699C", Offset = "0x196699C", VA = "0x196699C")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1966E4C", Offset = "0x1966E4C", VA = "0x1966E4C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1966544", Offset = "0x1966544", VA = "0x1966544")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1966DBC", Offset = "0x1966DBC", VA = "0x1966DBC")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1966EB8", Offset = "0x1966EB8", VA = "0x1966EB8")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1966F8C", Offset = "0x1966F8C", VA = "0x1966F8C")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1966D44", Offset = "0x1966D44", VA = "0x1966D44")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1966CD0", Offset = "0x1966CD0", VA = "0x1966CD0")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000008")]
	public class BipedReferences
	{
		[Token(Token = "0x2000077")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x17000063")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000488")]
				[Address(RVA = "0x1AB9000", Offset = "0x1AB9000", VA = "0x1AB9000")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0x1AB8FEC", Offset = "0x1AB8FEC", VA = "0x1AB8FEC")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000007")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x1968FD0", Offset = "0x1968FD0", VA = "0x1968FD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public bool isEmpty
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x19693B8", Offset = "0x19693B8", VA = "0x19693B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x19693C8", Offset = "0x19693C8", VA = "0x19693C8", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x19697F0", Offset = "0x19697F0", VA = "0x19697F0", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1969C24", Offset = "0x1969C24", VA = "0x1969C24")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x196A210", Offset = "0x196A210", VA = "0x196A210")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1969E38", Offset = "0x1969E38", VA = "0x1969E38")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1964D34", Offset = "0x1964D34", VA = "0x1964D34")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x196AA10", Offset = "0x196AA10", VA = "0x196AA10")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x196AF70", Offset = "0x196AF70", VA = "0x196AF70")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x196AD64", Offset = "0x196AD64", VA = "0x196AD64")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x196ABE0", Offset = "0x196ABE0", VA = "0x196ABE0")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x196AAB0", Offset = "0x196AAB0", VA = "0x196AAB0")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x196AE70", Offset = "0x196AE70", VA = "0x196AE70")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x196B068", Offset = "0x196B068", VA = "0x196B068")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x196BB8C", Offset = "0x196BB8C", VA = "0x196BB8C")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x196B614", Offset = "0x196B614", VA = "0x196B614")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x196BE34", Offset = "0x196BE34", VA = "0x196BE34")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x196B980", Offset = "0x196B980", VA = "0x196B980")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x196BE3C", Offset = "0x196BE3C", VA = "0x196BE3C")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x196BE44", Offset = "0x196BE44", VA = "0x196BE44")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x196C00C", Offset = "0x196C00C", VA = "0x196C00C")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x196C1C8", Offset = "0x196C1C8", VA = "0x196C1C8")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1965490", Offset = "0x1965490", VA = "0x1965490")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1970324", Offset = "0x1970324", VA = "0x1970324")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x19708A4", Offset = "0x19708A4", VA = "0x19708A4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x19709EC", Offset = "0x19709EC", VA = "0x19709EC")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class Hierarchy
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1A552F0", Offset = "0x1A552F0", VA = "0x1A552F0")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1A554DC", Offset = "0x1A554DC", VA = "0x1A554DC")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1A55388", Offset = "0x1A55388", VA = "0x1A55388")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1A555FC", Offset = "0x1A555FC", VA = "0x1A555FC")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1A55728", Offset = "0x1A55728", VA = "0x1A55728")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1A55974", Offset = "0x1A55974", VA = "0x1A55974")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1A55A7C", Offset = "0x1A55A7C", VA = "0x1A55A7C")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1A55BF0", Offset = "0x1A55BF0", VA = "0x1A55BF0")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1A55FCC", Offset = "0x1A55FCC", VA = "0x1A55FCC")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1A55D90", Offset = "0x1A55D90", VA = "0x1A55D90")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1A56180", Offset = "0x1A56180", VA = "0x1A56180")]
		public Hierarchy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	public enum InterpolationMode
	{
		[Token(Token = "0x400005A")]
		None,
		[Token(Token = "0x400005B")]
		InOutCubic,
		[Token(Token = "0x400005C")]
		InOutQuintic,
		[Token(Token = "0x400005D")]
		InOutSine,
		[Token(Token = "0x400005E")]
		InQuintic,
		[Token(Token = "0x400005F")]
		InQuartic,
		[Token(Token = "0x4000060")]
		InCubic,
		[Token(Token = "0x4000061")]
		InQuadratic,
		[Token(Token = "0x4000062")]
		InElastic,
		[Token(Token = "0x4000063")]
		InElasticSmall,
		[Token(Token = "0x4000064")]
		InElasticBig,
		[Token(Token = "0x4000065")]
		InSine,
		[Token(Token = "0x4000066")]
		InBack,
		[Token(Token = "0x4000067")]
		OutQuintic,
		[Token(Token = "0x4000068")]
		OutQuartic,
		[Token(Token = "0x4000069")]
		OutCubic,
		[Token(Token = "0x400006A")]
		OutInCubic,
		[Token(Token = "0x400006B")]
		OutInQuartic,
		[Token(Token = "0x400006C")]
		OutElastic,
		[Token(Token = "0x400006D")]
		OutElasticSmall,
		[Token(Token = "0x400006E")]
		OutElasticBig,
		[Token(Token = "0x400006F")]
		OutSine,
		[Token(Token = "0x4000070")]
		OutBack,
		[Token(Token = "0x4000071")]
		OutBackCubic,
		[Token(Token = "0x4000072")]
		OutBackQuartic,
		[Token(Token = "0x4000073")]
		BackInCubic,
		[Token(Token = "0x4000074")]
		BackInQuartic
	}
	[Token(Token = "0x200000D")]
	public class Interp
	{
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x192A0A0", Offset = "0x192A0A0", VA = "0x192A0A0")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x192F91C", Offset = "0x192F91C", VA = "0x192F91C")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x192F990", Offset = "0x192F990", VA = "0x192F990")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x192F384", Offset = "0x192F384", VA = "0x192F384")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x192F390", Offset = "0x192F390", VA = "0x192F390")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x192F3B4", Offset = "0x192F3B4", VA = "0x192F3B4")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x192F3F0", Offset = "0x192F3F0", VA = "0x192F3F0")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x192F408", Offset = "0x192F408", VA = "0x192F408")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x192F41C", Offset = "0x192F41C", VA = "0x192F41C")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x192F430", Offset = "0x192F430", VA = "0x192F430")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x192F440", Offset = "0x192F440", VA = "0x192F440")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x192F488", Offset = "0x192F488", VA = "0x192F488")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x192F4C0", Offset = "0x192F4C0", VA = "0x192F4C0")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x192F4E8", Offset = "0x192F4E8", VA = "0x192F4E8")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x192FA1C", Offset = "0x192FA1C", VA = "0x192FA1C")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x192F51C", Offset = "0x192F51C", VA = "0x192F51C")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x192F544", Offset = "0x192F544", VA = "0x192F544")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x192F574", Offset = "0x192F574", VA = "0x192F574")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x192F5A8", Offset = "0x192F5A8", VA = "0x192F5A8")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x192F5EC", Offset = "0x192F5EC", VA = "0x192F5EC")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x192F650", Offset = "0x192F650", VA = "0x192F650")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x192F6B4", Offset = "0x192F6B4", VA = "0x192F6B4")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x192F708", Offset = "0x192F708", VA = "0x192F708")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x192F75C", Offset = "0x192F75C", VA = "0x192F75C")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x192F798", Offset = "0x192F798", VA = "0x192F798")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x192F7D0", Offset = "0x192F7D0", VA = "0x192F7D0")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x192FA50", Offset = "0x192FA50", VA = "0x192FA50")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x192F818", Offset = "0x192F818", VA = "0x192F818")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x192F8AC", Offset = "0x192F8AC", VA = "0x192F8AC")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x192F8DC", Offset = "0x192F8DC", VA = "0x192F8DC")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x192FAE4", Offset = "0x192FAE4", VA = "0x192FAE4")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x192FAEC", Offset = "0x192FAEC", VA = "0x192FAEC")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x192FB58", Offset = "0x192FB58", VA = "0x192FB58")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200000F")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x192FBC4", Offset = "0x192FBC4", VA = "0x192FBC4")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x192FC1C", Offset = "0x192FC1C", VA = "0x192FC1C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x192FCE8", Offset = "0x192FCE8", VA = "0x192FCE8")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x192FC34", Offset = "0x192FC34", VA = "0x192FC34")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x192FD00", Offset = "0x192FD00", VA = "0x192FD00")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x192FDA4", Offset = "0x192FDA4", VA = "0x192FDA4")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x192FDD0", Offset = "0x192FDD0", VA = "0x192FDD0")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x192FE20", Offset = "0x192FE20", VA = "0x192FE20")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x192FE8C", Offset = "0x192FE8C", VA = "0x192FE8C")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x192FFA0", Offset = "0x192FFA0", VA = "0x192FFA0")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1930098", Offset = "0x1930098", VA = "0x1930098")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x19300F4", Offset = "0x19300F4", VA = "0x19300F4")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000010")]
	public static class QuaTools
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1930E08", Offset = "0x1930E08", VA = "0x1930E08")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1930E58", Offset = "0x1930E58", VA = "0x1930E58")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1930EA8", Offset = "0x1930EA8", VA = "0x1930EA8")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1930F50", Offset = "0x1930F50", VA = "0x1930F50")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x192F094", Offset = "0x192F094", VA = "0x192F094")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1930FF8", Offset = "0x1930FF8", VA = "0x1930FF8")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x193104C", Offset = "0x193104C", VA = "0x193104C")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1931120", Offset = "0x1931120", VA = "0x1931120")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1931230", Offset = "0x1931230", VA = "0x1931230")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x19313C0", Offset = "0x19313C0", VA = "0x19313C0")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x19314B4", Offset = "0x19314B4", VA = "0x19314B4")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000011")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000009")]
		public static T instance
		{
			[Token(Token = "0x6000095")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000096")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000097")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7949D8", Offset = "0x7949D8")]
		public bool fixTransforms;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000A")]
		private bool animatePhysics
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x19369A8", Offset = "0x19369A8", VA = "0x19369A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool isAnimated
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x1936CB4", Offset = "0x1936CB4", VA = "0x1936CB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1936868", Offset = "0x1936868", VA = "0x1936868")]
		public void Disable()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1936908", Offset = "0x1936908", VA = "0x1936908", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x193690C", Offset = "0x193690C", VA = "0x193690C", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1936910", Offset = "0x1936910", VA = "0x1936910", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1936914", Offset = "0x1936914", VA = "0x1936914")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x19369A4", Offset = "0x19369A4", VA = "0x19369A4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x193694C", Offset = "0x193694C", VA = "0x193694C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1936C68", Offset = "0x1936C68", VA = "0x1936C68")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1936A94", Offset = "0x1936A94", VA = "0x1936A94")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1936D6C", Offset = "0x1936D6C", VA = "0x1936D6C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1936DC8", Offset = "0x1936DC8", VA = "0x1936DC8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1936E24", Offset = "0x1936E24", VA = "0x1936E24")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1930DF8", Offset = "0x1930DF8", VA = "0x1930DF8")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1936E6C", Offset = "0x1936E6C", VA = "0x1936E6C")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1936F2C", Offset = "0x1936F2C", VA = "0x1936F2C")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1936FEC", Offset = "0x1936FEC", VA = "0x1936FEC")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x19370AC", Offset = "0x19370AC", VA = "0x19370AC")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public static class V3Tools
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1937F90", Offset = "0x1937F90", VA = "0x1937F90")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1938030", Offset = "0x1938030", VA = "0x1938030")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x193806C", Offset = "0x193806C", VA = "0x193806C")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x19380B0", Offset = "0x19380B0", VA = "0x19380B0")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x193814C", Offset = "0x193814C", VA = "0x193814C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x19382C8", Offset = "0x19382C8", VA = "0x19382C8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x193844C", Offset = "0x193844C", VA = "0x193844C")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1938508", Offset = "0x1938508", VA = "0x1938508")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000015")]
	public static class Warning
	{
		[Token(Token = "0x2000078")]
		public delegate void Logger(string message);

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x19388A4", Offset = "0x19388A4", VA = "0x19388A4")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1929758", Offset = "0x1929758", VA = "0x1929758")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000016")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x1700000C")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x196D1A4", Offset = "0x196D1A4", VA = "0x196D1A4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x196D180", Offset = "0x196D180", VA = "0x196D180", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x196D1AC", Offset = "0x196D1AC", VA = "0x196D1AC")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x196D210", Offset = "0x196D210", VA = "0x196D210", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x196D448", Offset = "0x196D448", VA = "0x196D448", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x196D62C", Offset = "0x196D62C", VA = "0x196D62C", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x196D458", Offset = "0x196D458", VA = "0x196D458")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x196D63C", Offset = "0x196D63C", VA = "0x196D63C")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x793DC4", Offset = "0x793DC4")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x196D654", Offset = "0x196D654", VA = "0x196D654", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x196D6B0", Offset = "0x196D6B0", VA = "0x196D6B0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x196D74C", Offset = "0x196D74C", VA = "0x196D74C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x196D864", Offset = "0x196D864", VA = "0x196D864")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x793E24", Offset = "0x793E24")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x794A70", Offset = "0x794A70")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x4000092")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000093")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x1700000D")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x196D918", Offset = "0x196D918", VA = "0x196D918", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x196D87C", Offset = "0x196D87C", VA = "0x196D87C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x196D8FC", Offset = "0x196D8FC", VA = "0x196D8FC", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x196DA10", Offset = "0x196DA10", VA = "0x196DA10", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x196DD90", Offset = "0x196DD90", VA = "0x196DD90")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x196DE98", Offset = "0x196DE98", VA = "0x196DE98")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x793E84", Offset = "0x793E84")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x793E84", Offset = "0x793E84")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x794AB4", Offset = "0x794AB4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x794AB4", Offset = "0x794AB4")]
		public Transform gravityTarget;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x794B14", Offset = "0x794B14")]
		[SerializeField]
		protected float gravityMultiplier;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x400009F")]
		protected const float half = 0.5f;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60000C8")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x196DEBC", Offset = "0x196DEBC", VA = "0x196DEBC")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x196DFEC", Offset = "0x196DFEC", VA = "0x196DFEC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x196E1A4", Offset = "0x196E1A4", VA = "0x196E1A4", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x196E354", Offset = "0x196E354", VA = "0x196E354")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x196E3B8", Offset = "0x196E3B8", VA = "0x196E3B8")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x196E4D8", Offset = "0x196E4D8", VA = "0x196E4D8")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x196E5FC", Offset = "0x196E5FC", VA = "0x196E5FC")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x196E620", Offset = "0x196E620", VA = "0x196E620")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x196E644", Offset = "0x196E644", VA = "0x196E644")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x196E6A4", Offset = "0x196E6A4", VA = "0x196E6A4")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000079")]
		public enum MoveMode
		{
			[Token(Token = "0x40003B6")]
			Directional,
			[Token(Token = "0x40003B7")]
			Strafe
		}

		[Token(Token = "0x200007A")]
		public struct AnimState
		{
			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;
		}

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x794BB0", Offset = "0x794BB0")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x794BE8", Offset = "0x794BE8")]
		public MoveMode moveMode;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x794C20", Offset = "0x794C20")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x794C58", Offset = "0x794C58")]
		public float airSpeed;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airControl;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float jumpPower;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x794C90", Offset = "0x794C90")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float wallRunMaxLength;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x794CDC", Offset = "0x794CDC")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x794D14", Offset = "0x794D14")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AnimState animState;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Animator animator;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3 normal;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private RaycastHit hit;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private float jumpLeg;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private float jumpEndTime;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private float forwardMlp;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private float groundDistance;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float lastAirTime;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float stickyForce;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 wallNormal;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private float wallRunWeight;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float lastWallRunWeight;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private bool fixedFrame;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private float wallRunEndTime;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Vector3 gravity;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private float velocityY;

		[Token(Token = "0x1700000E")]
		public bool onGround
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x196E6C4", Offset = "0x196E6C4", VA = "0x196E6C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79A988", Offset = "0x79A988")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x196E6CC", Offset = "0x196E6CC", VA = "0x196E6CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79A998", Offset = "0x79A998")]
			private set
			{
			}
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x196E6D8", Offset = "0x196E6D8", VA = "0x196E6D8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x196E818", Offset = "0x196E818", VA = "0x196E818")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x196E8A8", Offset = "0x196E8A8", VA = "0x196E8A8", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x196E924", Offset = "0x196E924", VA = "0x196E924")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x196F4AC", Offset = "0x196F4AC", VA = "0x196F4AC", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x196F6E8", Offset = "0x196F6E8", VA = "0x196F6E8", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x196ED3C", Offset = "0x196ED3C", VA = "0x196ED3C")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x196F7C4", Offset = "0x196F7C4", VA = "0x196F7C4")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x196FC6C", Offset = "0x196FC6C", VA = "0x196FC6C")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x196F534", Offset = "0x196F534", VA = "0x196F534")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x196FD0C", Offset = "0x196FD0C", VA = "0x196FD0C", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1970048", Offset = "0x1970048", VA = "0x1970048")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1970138", Offset = "0x1970138", VA = "0x1970138", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x196F104", Offset = "0x196F104", VA = "0x196F104")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x197026C", Offset = "0x197026C", VA = "0x197026C")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x793F18", Offset = "0x793F18")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200007B")]
		public enum RotationMode
		{
			[Token(Token = "0x40003BF")]
			Smooth,
			[Token(Token = "0x40003C0")]
			Linear
		}

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x794D24", Offset = "0x794D24")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x794D70", Offset = "0x794D70")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x794DBC", Offset = "0x794DBC")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x794E08", Offset = "0x794E08")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x794E54", Offset = "0x794E54")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x794EA0", Offset = "0x794EA0")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x794EEC", Offset = "0x794EEC")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x1700000F")]
		public bool isGrounded
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x1936088", Offset = "0x1936088", VA = "0x1936088")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79A9A8", Offset = "0x79A9A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x1936090", Offset = "0x1936090", VA = "0x1936090")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79A9B8", Offset = "0x79A9B8")]
			private set
			{
			}
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x193609C", Offset = "0x193609C", VA = "0x193609C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x193612C", Offset = "0x193612C", VA = "0x193612C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x19365EC", Offset = "0x19365EC", VA = "0x19365EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1936180", Offset = "0x1936180", VA = "0x1936180")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1936400", Offset = "0x1936400", VA = "0x1936400")]
		private void Move()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1936628", Offset = "0x1936628", VA = "0x1936628")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x19366C4", Offset = "0x19366C4", VA = "0x19366C4")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1936748", Offset = "0x1936748", VA = "0x1936748")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1937B34", Offset = "0x1937B34", VA = "0x1937B34", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1937C90", Offset = "0x1937C90", VA = "0x1937C90")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x200007C")]
		public struct State
		{
			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1937CBC", Offset = "0x1937CBC", VA = "0x1937CBC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1937CF4", Offset = "0x1937CF4", VA = "0x1937CF4", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1937CAC", Offset = "0x1937CAC", VA = "0x1937CAC")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x196408C", Offset = "0x196408C", VA = "0x196408C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x19640C8", Offset = "0x19640C8", VA = "0x19640C8")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class SlowMoRoot : MonoBehaviour
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1936770", Offset = "0x1936770", VA = "0x1936770")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x19367A4", Offset = "0x19367A4", VA = "0x19367A4")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1936854", Offset = "0x1936854", VA = "0x1936854")]
		public SlowMoRoot()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x793F78", Offset = "0x793F78")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x793F78", Offset = "0x793F78")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1964418", Offset = "0x1964418", VA = "0x1964418")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79A9C8", Offset = "0x79A9C8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1964460", Offset = "0x1964460", VA = "0x1964460")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AA00", Offset = "0x79AA00")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x19644A8", Offset = "0x19644A8", VA = "0x19644A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AA38", Offset = "0x79AA38")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x19644F0", Offset = "0x19644F0", VA = "0x19644F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AA70", Offset = "0x79AA70")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1964538", Offset = "0x1964538", VA = "0x1964538")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x19645D4", Offset = "0x19645D4", VA = "0x19645D4")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x19645F4", Offset = "0x19645F4", VA = "0x19645F4")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1964624", Offset = "0x1964624", VA = "0x1964624")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1964654", Offset = "0x1964654", VA = "0x1964654")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1964694", Offset = "0x1964694", VA = "0x1964694")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x19646D8", Offset = "0x19646D8", VA = "0x19646D8")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x19646FC", Offset = "0x19646FC", VA = "0x19646FC")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1964720", Offset = "0x1964720", VA = "0x1964720")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1964748", Offset = "0x1964748", VA = "0x1964748")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1964774", Offset = "0x1964774", VA = "0x1964774")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x19647A0", Offset = "0x19647A0", VA = "0x19647A0")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1964558", Offset = "0x1964558", VA = "0x1964558")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x19647C8", Offset = "0x19647C8", VA = "0x19647C8")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x19647D4", Offset = "0x19647D4", VA = "0x19647D4")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x19647E0", Offset = "0x19647E0", VA = "0x19647E0")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1964AC4", Offset = "0x1964AC4", VA = "0x1964AC4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1964B6C", Offset = "0x1964B6C", VA = "0x1964B6C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1964F9C", Offset = "0x1964F9C", VA = "0x1964F9C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x19653D4", Offset = "0x19653D4", VA = "0x19653D4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1965408", Offset = "0x1965408", VA = "0x1965408")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000021")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000010")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x1964980", Offset = "0x1964980", VA = "0x1964980")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x1965670", Offset = "0x1965670", VA = "0x1965670")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1964E24", Offset = "0x1964E24", VA = "0x1964E24")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x19654FC", Offset = "0x19654FC", VA = "0x19654FC")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000022")]
	public abstract class Constraint
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000012")]
		public bool isValid
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x197032C", Offset = "0x197032C", VA = "0x197032C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000116")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1970398", Offset = "0x1970398", VA = "0x1970398")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000023")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x19703A0", Offset = "0x19703A0", VA = "0x19703A0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1970460", Offset = "0x1970460", VA = "0x1970460")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1970468", Offset = "0x1970468", VA = "0x1970468")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000024")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000013")]
		private bool positionChanged
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x197059C", Offset = "0x197059C", VA = "0x197059C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1970494", Offset = "0x1970494", VA = "0x1970494", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x19705D8", Offset = "0x19705D8", VA = "0x19705D8")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x19705E0", Offset = "0x19705E0", VA = "0x19705E0")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000025")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x197060C", Offset = "0x197060C", VA = "0x197060C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x197068C", Offset = "0x197068C", VA = "0x197068C")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1970694", Offset = "0x1970694", VA = "0x1970694")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000026")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000014")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x19707C8", Offset = "0x19707C8", VA = "0x19707C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x19706C0", Offset = "0x19706C0", VA = "0x19706C0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1970804", Offset = "0x1970804", VA = "0x1970804")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x197080C", Offset = "0x197080C", VA = "0x197080C")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000027")]
	public class Constraints
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x794F3C", Offset = "0x794F3C")]
		public float positionWeight;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x794F54", Offset = "0x794F54")]
		public float rotationWeight;

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1970838", Offset = "0x1970838", VA = "0x1970838")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1964F48", Offset = "0x1964F48", VA = "0x1964F48")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1965124", Offset = "0x1965124", VA = "0x1965124")]
		public void Update()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1965838", Offset = "0x1965838", VA = "0x1965838")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000028")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x200007D")]
		public enum DOF
		{
			[Token(Token = "0x40003C7")]
			One,
			[Token(Token = "0x40003C8")]
			Three
		}

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x794F6C", Offset = "0x794F6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x794F6C", Offset = "0x794F6C")]
		public float weight;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x794FC0", Offset = "0x794FC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x794FC0", Offset = "0x794FC0")]
		public float rotationWeight;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795014", Offset = "0x795014")]
		public DOF rotationDOF;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79504C", Offset = "0x79504C")]
		public Transform bone1;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795084", Offset = "0x795084")]
		public Transform bone2;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7950BC", Offset = "0x7950BC")]
		public Transform bone3;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7950F4", Offset = "0x7950F4")]
		public Transform tip;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79512C", Offset = "0x79512C")]
		public Transform target;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x795164", Offset = "0x795164")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x17000015")]
		public bool initiated
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x1A4C6C8", Offset = "0x1A4C6C8", VA = "0x1A4C6C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79AAA8", Offset = "0x79AAA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x1A4C6D0", Offset = "0x1A4C6D0", VA = "0x1A4C6D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79AAB8", Offset = "0x79AAB8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x1A4C6DC", Offset = "0x1A4C6DC", VA = "0x1A4C6DC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x1A4C6FC", Offset = "0x1A4C6FC", VA = "0x1A4C6FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x1A4C71C", Offset = "0x1A4C71C", VA = "0x1A4C71C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x1A4C73C", Offset = "0x1A4C73C", VA = "0x1A4C73C")]
			set
			{
			}
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1A4C75C", Offset = "0x1A4C75C", VA = "0x1A4C75C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1A4C864", Offset = "0x1A4C864", VA = "0x1A4C864")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1A4CD40", Offset = "0x1A4CD40", VA = "0x1A4CD40")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1A4CE0C", Offset = "0x1A4CE0C", VA = "0x1A4CE0C")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1A4D168", Offset = "0x1A4D168", VA = "0x1A4D168")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795174", Offset = "0x795174")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x795174", Offset = "0x795174")]
		public float weight;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7951C8", Offset = "0x7951C8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000018")]
		public bool initiated
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x1A4D178", Offset = "0x1A4D178", VA = "0x1A4D178")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79AAC8", Offset = "0x79AAC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x1A4D180", Offset = "0x1A4D180", VA = "0x1A4D180")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79AAD8", Offset = "0x79AAD8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1A4D18C", Offset = "0x1A4D18C", VA = "0x1A4D18C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1A4D214", Offset = "0x1A4D214", VA = "0x1A4D214")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AAE8", Offset = "0x79AAE8")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1A4D54C", Offset = "0x1A4D54C", VA = "0x1A4D54C")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1A4D6C4", Offset = "0x1A4D6C4", VA = "0x1A4D6C4")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1A4D450", Offset = "0x1A4D450", VA = "0x1A4D450")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1A4D834", Offset = "0x1A4D834", VA = "0x1A4D834", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1A4D8F4", Offset = "0x1A4D8F4", VA = "0x1A4D8F4")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1A4D978", Offset = "0x1A4D978", VA = "0x1A4D978")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1A4D9E0", Offset = "0x1A4D9E0", VA = "0x1A4D9E0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1A4D9E4", Offset = "0x1A4D9E4", VA = "0x1A4D9E4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1A4D9E8", Offset = "0x1A4D9E8", VA = "0x1A4D9E8")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x200007E")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7951D8", Offset = "0x7951D8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7951D8", Offset = "0x7951D8")]
		public float weight;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79522C", Offset = "0x79522C")]
		public Grounding solver;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected bool initiated;

		[Token(Token = "0x6000142")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1A4E724", Offset = "0x1A4E724", VA = "0x1A4E724")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1A4E8D0", Offset = "0x1A4E8D0", VA = "0x1A4E8D0")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1A4E7D0", Offset = "0x1A4E7D0", VA = "0x1A4E7D0")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1A4E904", Offset = "0x1A4E904", VA = "0x1A4E904")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000147")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000148")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1A4EA40", Offset = "0x1A4EA40", VA = "0x1A4EA40")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x793FD8", Offset = "0x793FD8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x793FD8", Offset = "0x793FD8")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795264", Offset = "0x795264")]
		public BipedIK ik;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79529C", Offset = "0x79529C")]
		public float spineBend;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7952D4", Offset = "0x7952D4")]
		public float spineSpeed;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1A4EB38", Offset = "0x1A4EB38", VA = "0x1A4EB38", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AB20", Offset = "0x79AB20")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1A4EB80", Offset = "0x1A4EB80", VA = "0x1A4EB80", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AB58", Offset = "0x79AB58")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1A4EBC8", Offset = "0x1A4EBC8", VA = "0x1A4EBC8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1A4EC90", Offset = "0x1A4EC90", VA = "0x1A4EC90")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1A4ED3C", Offset = "0x1A4ED3C", VA = "0x1A4ED3C")]
		private void Update()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1A4ED9C", Offset = "0x1A4ED9C", VA = "0x1A4ED9C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1A4F2E4", Offset = "0x1A4F2E4", VA = "0x1A4F2E4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1A4F338", Offset = "0x1A4F338", VA = "0x1A4F338")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1A4F974", Offset = "0x1A4F974", VA = "0x1A4F974")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1A4FA8C", Offset = "0x1A4FA8C", VA = "0x1A4FA8C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1A4FBCC", Offset = "0x1A4FBCC", VA = "0x1A4FBCC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1A4FD5C", Offset = "0x1A4FD5C", VA = "0x1A4FD5C")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x794038", Offset = "0x794038")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x794038", Offset = "0x794038")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x200007F")]
		public class SpineEffector
		{
			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797E7C", Offset = "0x797E7C")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797EB4", Offset = "0x797EB4")]
			public float horizontalWeight;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797EEC", Offset = "0x797EEC")]
			public float verticalWeight;

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x1AB99DC", Offset = "0x1AB99DC", VA = "0x1AB99DC")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x1AB99EC", Offset = "0x1AB99EC", VA = "0x1AB99EC")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79530C", Offset = "0x79530C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795344", Offset = "0x795344")]
		public float spineBend;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79537C", Offset = "0x79537C")]
		public float spineSpeed;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1A4FDE4", Offset = "0x1A4FDE4", VA = "0x1A4FDE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AB90", Offset = "0x79AB90")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1A4FE2C", Offset = "0x1A4FE2C", VA = "0x1A4FE2C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79ABC8", Offset = "0x79ABC8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1A4FE74", Offset = "0x1A4FE74", VA = "0x1A4FE74", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AC00", Offset = "0x79AC00")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1A4FEBC", Offset = "0x1A4FEBC", VA = "0x1A4FEBC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1A4FEF8", Offset = "0x1A4FEF8", VA = "0x1A4FEF8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1A4FF8C", Offset = "0x1A4FF8C", VA = "0x1A4FF8C")]
		private void Update()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1A50208", Offset = "0x1A50208", VA = "0x1A50208")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1A50214", Offset = "0x1A50214", VA = "0x1A50214")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1A4FFF4", Offset = "0x1A4FFF4", VA = "0x1A4FFF4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1A50220", Offset = "0x1A50220", VA = "0x1A50220")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1A5053C", Offset = "0x1A5053C", VA = "0x1A5053C")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1A5064C", Offset = "0x1A5064C", VA = "0x1A5064C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1A507A4", Offset = "0x1A507A4", VA = "0x1A507A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1A508B8", Offset = "0x1A508B8", VA = "0x1A508B8")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x794098", Offset = "0x794098")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x794098", Offset = "0x794098")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7953B4", Offset = "0x7953B4")]
		public Transform pelvis;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7953EC", Offset = "0x7953EC")]
		public Transform characterRoot;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795424", Offset = "0x795424")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x795424", Offset = "0x795424")]
		public float rootRotationWeight;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795478", Offset = "0x795478")]
		public float rootRotationSpeed;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7954B0", Offset = "0x7954B0")]
		public float maxRootRotationAngle;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1A50940", Offset = "0x1A50940", VA = "0x1A50940", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AC38", Offset = "0x79AC38")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1A50988", Offset = "0x1A50988", VA = "0x1A50988", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AC70", Offset = "0x79AC70")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1A509D0", Offset = "0x1A509D0", VA = "0x1A509D0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1A509E8", Offset = "0x1A509E8", VA = "0x1A509E8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1A50C1C", Offset = "0x1A50C1C", VA = "0x1A50C1C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1A50D18", Offset = "0x1A50D18", VA = "0x1A50D18")]
		private void Update()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1A511F0", Offset = "0x1A511F0", VA = "0x1A511F0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1A515D0", Offset = "0x1A515D0", VA = "0x1A515D0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1A5175C", Offset = "0x1A5175C", VA = "0x1A5175C")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1A51A60", Offset = "0x1A51A60", VA = "0x1A51A60")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1A51BA4", Offset = "0x1A51BA4", VA = "0x1A51BA4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1A51D8C", Offset = "0x1A51D8C", VA = "0x1A51D8C")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7940F8", Offset = "0x7940F8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7940F8", Offset = "0x7940F8")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000080")]
		public struct Foot
		{
			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x1AB9A34", Offset = "0x1AB9A34", VA = "0x1AB9A34")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7954E8", Offset = "0x7954E8")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795520", Offset = "0x795520")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x795520", Offset = "0x795520")]
		public float rootRotationWeight;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795574", Offset = "0x795574")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x795574", Offset = "0x795574")]
		public float minRootRotation;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7955CC", Offset = "0x7955CC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7955CC", Offset = "0x7955CC")]
		public float maxRootRotation;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795624", Offset = "0x795624")]
		public float rootRotationSpeed;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79565C", Offset = "0x79565C")]
		public float maxLegOffset;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795694", Offset = "0x795694")]
		public float maxForeLegOffset;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7956CC", Offset = "0x7956CC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7956CC", Offset = "0x7956CC")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795720", Offset = "0x795720")]
		public Transform characterRoot;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795758", Offset = "0x795758")]
		public Transform pelvis;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795790", Offset = "0x795790")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7957C8", Offset = "0x7957C8")]
		public Transform head;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1A51E14", Offset = "0x1A51E14", VA = "0x1A51E14", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79ACA8", Offset = "0x79ACA8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1A51E5C", Offset = "0x1A51E5C", VA = "0x1A51E5C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79ACE0", Offset = "0x79ACE0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1A51EA4", Offset = "0x1A51EA4", VA = "0x1A51EA4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1A51ED8", Offset = "0x1A51ED8", VA = "0x1A51ED8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1A52004", Offset = "0x1A52004", VA = "0x1A52004")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1A52208", Offset = "0x1A52208", VA = "0x1A52208")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1A52270", Offset = "0x1A52270", VA = "0x1A52270")]
		private void Update()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1A522D4", Offset = "0x1A522D4", VA = "0x1A522D4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1A525D8", Offset = "0x1A525D8", VA = "0x1A525D8")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1A5291C", Offset = "0x1A5291C", VA = "0x1A5291C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1A52A14", Offset = "0x1A52A14", VA = "0x1A52A14")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1A52CC8", Offset = "0x1A52CC8", VA = "0x1A52CC8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1A532E4", Offset = "0x1A532E4", VA = "0x1A532E4")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1A534B4", Offset = "0x1A534B4", VA = "0x1A534B4")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1A53590", Offset = "0x1A53590", VA = "0x1A53590")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1A537D8", Offset = "0x1A537D8", VA = "0x1A537D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1A53810", Offset = "0x1A53810", VA = "0x1A53810")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1A539F0", Offset = "0x1A539F0", VA = "0x1A539F0")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x794158", Offset = "0x794158")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795810", Offset = "0x795810")]
		public VRIK ik;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1A53AE4", Offset = "0x1A53AE4", VA = "0x1A53AE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AD18", Offset = "0x79AD18")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1A53AE8", Offset = "0x1A53AE8", VA = "0x1A53AE8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AD50", Offset = "0x79AD50")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1A53AEC", Offset = "0x1A53AEC", VA = "0x1A53AEC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AD88", Offset = "0x79AD88")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1A53AF0", Offset = "0x1A53AF0", VA = "0x1A53AF0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1A53B08", Offset = "0x1A53B08", VA = "0x1A53B08")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1A53B9C", Offset = "0x1A53B9C", VA = "0x1A53B9C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1A53BFC", Offset = "0x1A53BFC", VA = "0x1A53BFC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1A53E1C", Offset = "0x1A53E1C", VA = "0x1A53E1C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1A5400C", Offset = "0x1A5400C", VA = "0x1A5400C")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1A5409C", Offset = "0x1A5409C", VA = "0x1A5409C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1A54258", Offset = "0x1A54258", VA = "0x1A54258")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1A543B0", Offset = "0x1A543B0", VA = "0x1A543B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1A54530", Offset = "0x1A54530", VA = "0x1A54530")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000081")]
		public enum Quality
		{
			[Token(Token = "0x40003D1")]
			Fastest,
			[Token(Token = "0x40003D2")]
			Simple,
			[Token(Token = "0x40003D3")]
			Best
		}

		[Token(Token = "0x2000082")]
		public class Leg
		{
			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x797F24", Offset = "0x797F24")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x797F34", Offset = "0x797F34")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x797F44", Offset = "0x797F44")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x797F54", Offset = "0x797F54")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x797F64", Offset = "0x797F64")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x797F74", Offset = "0x797F74")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x797F84", Offset = "0x797F84")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x17000064")]
			public bool isGrounded
			{
				[Token(Token = "0x6000494")]
				[Address(RVA = "0x1AB9A74", Offset = "0x1AB9A74", VA = "0x1AB9A74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C490", Offset = "0x79C490")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000495")]
				[Address(RVA = "0x1AB9A7C", Offset = "0x1AB9A7C", VA = "0x1AB9A7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C4A0", Offset = "0x79C4A0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000065")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000496")]
				[Address(RVA = "0x1AB9A88", Offset = "0x1AB9A88", VA = "0x1AB9A88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C4B0", Offset = "0x79C4B0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000497")]
				[Address(RVA = "0x1AB9A94", Offset = "0x1AB9A94", VA = "0x1AB9A94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C4C0", Offset = "0x79C4C0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000066")]
			public bool initiated
			{
				[Token(Token = "0x6000498")]
				[Address(RVA = "0x1AB9AA0", Offset = "0x1AB9AA0", VA = "0x1AB9AA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C4D0", Offset = "0x79C4D0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000499")]
				[Address(RVA = "0x1AB9AA8", Offset = "0x1AB9AA8", VA = "0x1AB9AA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C4E0", Offset = "0x79C4E0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000067")]
			public float heightFromGround
			{
				[Token(Token = "0x600049A")]
				[Address(RVA = "0x1AB9AB4", Offset = "0x1AB9AB4", VA = "0x1AB9AB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C4F0", Offset = "0x79C4F0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600049B")]
				[Address(RVA = "0x1AB9ABC", Offset = "0x1AB9ABC", VA = "0x1AB9ABC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C500", Offset = "0x79C500")]
				private set
				{
				}
			}

			[Token(Token = "0x17000068")]
			public Vector3 velocity
			{
				[Token(Token = "0x600049C")]
				[Address(RVA = "0x1AB9AC4", Offset = "0x1AB9AC4", VA = "0x1AB9AC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C510", Offset = "0x79C510")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600049D")]
				[Address(RVA = "0x1AB9AD0", Offset = "0x1AB9AD0", VA = "0x1AB9AD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C520", Offset = "0x79C520")]
				private set
				{
				}
			}

			[Token(Token = "0x17000069")]
			public Transform transform
			{
				[Token(Token = "0x600049E")]
				[Address(RVA = "0x1AB9ADC", Offset = "0x1AB9ADC", VA = "0x1AB9ADC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C530", Offset = "0x79C530")]
				get
				{
					return null;
				}
				[Token(Token = "0x600049F")]
				[Address(RVA = "0x1AB9AE4", Offset = "0x1AB9AE4", VA = "0x1AB9AE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C540", Offset = "0x79C540")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006A")]
			public float IKOffset
			{
				[Token(Token = "0x60004A0")]
				[Address(RVA = "0x1AB9AEC", Offset = "0x1AB9AEC", VA = "0x1AB9AEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C550", Offset = "0x79C550")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60004A1")]
				[Address(RVA = "0x1AB9AF4", Offset = "0x1AB9AF4", VA = "0x1AB9AF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C560", Offset = "0x79C560")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006B")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60004A6")]
				[Address(RVA = "0x1ABA7A0", Offset = "0x1ABA7A0", VA = "0x1ABA7A0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700006C")]
			private float rootYOffset
			{
				[Token(Token = "0x60004AF")]
				[Address(RVA = "0x1ABA920", Offset = "0x1ABA920", VA = "0x1ABA920")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x1AB9AFC", Offset = "0x1AB9AFC", VA = "0x1AB9AFC")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x1AB9B70", Offset = "0x1AB9B70", VA = "0x1AB9B70")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x1AB9BBC", Offset = "0x1AB9BBC", VA = "0x1AB9BBC")]
			public void Reset()
			{
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x1AB9C2C", Offset = "0x1AB9C2C", VA = "0x1AB9C2C")]
			public void Process()
			{
			}

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x1ABA55C", Offset = "0x1ABA55C", VA = "0x1ABA55C")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x1ABA230", Offset = "0x1ABA230", VA = "0x1ABA230")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x1ABA834", Offset = "0x1ABA834", VA = "0x1ABA834")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x1ABA398", Offset = "0x1ABA398", VA = "0x1ABA398")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x1ABA424", Offset = "0x1ABA424", VA = "0x1ABA424")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x1ABA8A4", Offset = "0x1ABA8A4", VA = "0x1ABA8A4")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x1ABA7C8", Offset = "0x1ABA7C8", VA = "0x1ABA7C8")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x1ABA9CC", Offset = "0x1ABA9CC", VA = "0x1ABA9CC")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x1ABAA58", Offset = "0x1ABAA58", VA = "0x1ABAA58")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000083")]
		public class Pelvis
		{
			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x797F94", Offset = "0x797F94")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x797FA4", Offset = "0x797FA4")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x1700006D")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60004B1")]
				[Address(RVA = "0x1ABAA9C", Offset = "0x1ABAA9C", VA = "0x1ABAA9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C570", Offset = "0x79C570")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60004B2")]
				[Address(RVA = "0x1ABAAA8", Offset = "0x1ABAAA8", VA = "0x1ABAAA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C580", Offset = "0x79C580")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			public float heightOffset
			{
				[Token(Token = "0x60004B3")]
				[Address(RVA = "0x1ABAAB4", Offset = "0x1ABAAB4", VA = "0x1ABAAB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C590", Offset = "0x79C590")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60004B4")]
				[Address(RVA = "0x1ABAABC", Offset = "0x1ABAABC", VA = "0x1ABAABC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C5A0", Offset = "0x79C5A0")]
				private set
				{
				}
			}

			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x1ABAAC4", Offset = "0x1ABAAC4", VA = "0x1ABAAC4")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x1ABAB34", Offset = "0x1ABAB34", VA = "0x1ABAB34")]
			public void Reset()
			{
			}

			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x1ABAAD4", Offset = "0x1ABAAD4", VA = "0x1ABAAD4")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x1ABABA0", Offset = "0x1ABABA0", VA = "0x1ABABA0")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x1ABAD40", Offset = "0x1ABAD40", VA = "0x1ABAD40")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795848", Offset = "0x795848")]
		public LayerMask layers;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795880", Offset = "0x795880")]
		public float maxStep;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7958B8", Offset = "0x7958B8")]
		public float heightOffset;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7958F0", Offset = "0x7958F0")]
		public float footSpeed;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795928", Offset = "0x795928")]
		public float footRadius;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795960", Offset = "0x795960")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7959AC", Offset = "0x7959AC")]
		public float prediction;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7959E4", Offset = "0x7959E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7959E4", Offset = "0x7959E4")]
		public float footRotationWeight;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795A38", Offset = "0x795A38")]
		public float footRotationSpeed;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795A70", Offset = "0x795A70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x795A70", Offset = "0x795A70")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795AC8", Offset = "0x795AC8")]
		public bool rotateSolver;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795B00", Offset = "0x795B00")]
		public float pelvisSpeed;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795B38", Offset = "0x795B38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x795B38", Offset = "0x795B38")]
		public float pelvisDamper;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795B8C", Offset = "0x795B8C")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795BC4", Offset = "0x795BC4")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795BFC", Offset = "0x795BFC")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795C34", Offset = "0x795C34")]
		public Quality quality;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x795C6C", Offset = "0x795C6C")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x795C7C", Offset = "0x795C7C")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x795C8C", Offset = "0x795C8C")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x795C9C", Offset = "0x795C9C")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x795CAC", Offset = "0x795CAC")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000019")]
		public Leg[] legs
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x1A54588", Offset = "0x1A54588", VA = "0x1A54588")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79ADC0", Offset = "0x79ADC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x1A54590", Offset = "0x1A54590", VA = "0x1A54590")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79ADD0", Offset = "0x79ADD0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x1A54598", Offset = "0x1A54598", VA = "0x1A54598")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79ADE0", Offset = "0x79ADE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x1A545A0", Offset = "0x1A545A0", VA = "0x1A545A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79ADF0", Offset = "0x79ADF0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool isGrounded
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x1A545A8", Offset = "0x1A545A8", VA = "0x1A545A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79AE00", Offset = "0x79AE00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x1A545B0", Offset = "0x1A545B0", VA = "0x1A545B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79AE10", Offset = "0x79AE10")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public Transform root
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x1A545BC", Offset = "0x1A545BC", VA = "0x1A545BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79AE20", Offset = "0x79AE20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x1A545C4", Offset = "0x1A545C4", VA = "0x1A545C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79AE30", Offset = "0x79AE30")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x1A545CC", Offset = "0x1A545CC", VA = "0x1A545CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79AE40", Offset = "0x79AE40")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x1A545E4", Offset = "0x1A545E4", VA = "0x1A545E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79AE50", Offset = "0x79AE50")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x1A54604", Offset = "0x1A54604", VA = "0x1A54604")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public Vector3 up
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x1A4FA48", Offset = "0x1A4FA48", VA = "0x1A4FA48")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000020")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x1A549BC", Offset = "0x1A549BC", VA = "0x1A549BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1A54658", Offset = "0x1A54658", VA = "0x1A54658")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1A5489C", Offset = "0x1A5489C", VA = "0x1A5489C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1A4F05C", Offset = "0x1A4F05C", VA = "0x1A4F05C")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1A4F72C", Offset = "0x1A4F72C", VA = "0x1A4F72C")]
		public void Update()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1A51090", Offset = "0x1A51090", VA = "0x1A51090")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1A4EC04", Offset = "0x1A4EC04", VA = "0x1A4EC04")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1A549A4", Offset = "0x1A549A4", VA = "0x1A549A4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1A54A3C", Offset = "0x1A54A3C", VA = "0x1A54A3C")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1A54ACC", Offset = "0x1A54ACC", VA = "0x1A54ACC")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1A54B88", Offset = "0x1A54B88", VA = "0x1A54B88")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1A4EAF0", Offset = "0x1A4EAF0", VA = "0x1A4EAF0")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x794190", Offset = "0x794190")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x794190", Offset = "0x794190")]
	public class AimIK : IK
	{
		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1963BB4", Offset = "0x1963BB4", VA = "0x1963BB4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AE60", Offset = "0x79AE60")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1963BFC", Offset = "0x1963BFC", VA = "0x1963BFC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AE98", Offset = "0x79AE98")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1963C44", Offset = "0x1963C44", VA = "0x1963C44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AED0", Offset = "0x79AED0")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1963C8C", Offset = "0x1963C8C", VA = "0x1963C8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AF08", Offset = "0x79AF08")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1963CD4", Offset = "0x1963CD4", VA = "0x1963CD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AF40", Offset = "0x79AF40")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1963D1C", Offset = "0x1963D1C", VA = "0x1963D1C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1963D24", Offset = "0x1963D24", VA = "0x1963D24")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7941F0", Offset = "0x7941F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7941F0", Offset = "0x7941F0")]
	public class CCDIK : IK
	{
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x196C448", Offset = "0x196C448", VA = "0x196C448", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AF78", Offset = "0x79AF78")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x196C490", Offset = "0x196C490", VA = "0x196C490", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AFB0", Offset = "0x79AFB0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x196C4D8", Offset = "0x196C4D8", VA = "0x196C4D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79AFE8", Offset = "0x79AFE8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x196C520", Offset = "0x196C520", VA = "0x196C520")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B020", Offset = "0x79B020")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x196C568", Offset = "0x196C568", VA = "0x196C568", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x196C570", Offset = "0x196C570", VA = "0x196C570")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x794250", Offset = "0x794250")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x794250", Offset = "0x794250")]
	public class FABRIK : IK
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1970A20", Offset = "0x1970A20", VA = "0x1970A20", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B058", Offset = "0x79B058")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1970A68", Offset = "0x1970A68", VA = "0x1970A68", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B090", Offset = "0x79B090")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1970AB0", Offset = "0x1970AB0", VA = "0x1970AB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B0C8", Offset = "0x79B0C8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1970AF8", Offset = "0x1970AF8", VA = "0x1970AF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B100", Offset = "0x79B100")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1970B40", Offset = "0x1970B40", VA = "0x1970B40", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1970B48", Offset = "0x1970B48", VA = "0x1970B48")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7942B0", Offset = "0x7942B0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7942B0", Offset = "0x7942B0")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x197106C", Offset = "0x197106C", VA = "0x197106C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B138", Offset = "0x79B138")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x19710B4", Offset = "0x19710B4", VA = "0x19710B4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B170", Offset = "0x79B170")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x19710FC", Offset = "0x19710FC", VA = "0x19710FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B1A8", Offset = "0x79B1A8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1971144", Offset = "0x1971144", VA = "0x1971144")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B1E0", Offset = "0x79B1E0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x197118C", Offset = "0x197118C", VA = "0x197118C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1971194", Offset = "0x1971194", VA = "0x1971194")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x794310", Offset = "0x794310")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x794310", Offset = "0x794310")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1A4DA4C", Offset = "0x1A4DA4C", VA = "0x1A4DA4C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B218", Offset = "0x79B218")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1A4DA94", Offset = "0x1A4DA94", VA = "0x1A4DA94", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B250", Offset = "0x79B250")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1A4DADC", Offset = "0x1A4DADC", VA = "0x1A4DADC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B288", Offset = "0x79B288")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1A4DB24", Offset = "0x1A4DB24", VA = "0x1A4DB24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B2C0", Offset = "0x79B2C0")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1A4DB6C", Offset = "0x1A4DB6C", VA = "0x1A4DB6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B2F8", Offset = "0x79B2F8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1A4DBB4", Offset = "0x1A4DBB4", VA = "0x1A4DBB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B330", Offset = "0x79B330")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1A4DBFC", Offset = "0x1A4DBFC", VA = "0x1A4DBFC")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1A4DC20", Offset = "0x1A4DC20", VA = "0x1A4DC20", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1A4DC28", Offset = "0x1A4DC28", VA = "0x1A4DC28")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1A4DE04", Offset = "0x1A4DE04", VA = "0x1A4DE04")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1A4E098", Offset = "0x1A4E098", VA = "0x1A4E098")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B368", Offset = "0x79B368")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1A4E0B8", Offset = "0x1A4E0B8", VA = "0x1A4E0B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B3A0", Offset = "0x79B3A0")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1A4E190", Offset = "0x1A4E190", VA = "0x1A4E190")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x60001CD")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1A568D8", Offset = "0x1A568D8", VA = "0x1A568D8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1A5695C", Offset = "0x1A5695C", VA = "0x1A5695C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1A569CC", Offset = "0x1A569CC", VA = "0x1A569CC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60001D1")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60001D2")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1A4E220", Offset = "0x1A4E220", VA = "0x1A4E220")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795CBC", Offset = "0x795CBC")]
		public IK[] IKComponents;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795CF4", Offset = "0x795CF4")]
		public Animator animator;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000021")]
		private bool animatePhysics
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x1A58F38", Offset = "0x1A58F38", VA = "0x1A58F38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1A58FD0", Offset = "0x1A58FD0", VA = "0x1A58FD0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1A59040", Offset = "0x1A59040", VA = "0x1A59040")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1A590FC", Offset = "0x1A590FC", VA = "0x1A590FC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1A59138", Offset = "0x1A59138", VA = "0x1A59138")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1A59074", Offset = "0x1A59074", VA = "0x1A59074")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1A591C4", Offset = "0x1A591C4", VA = "0x1A591C4")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x794370", Offset = "0x794370")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1930124", Offset = "0x1930124", VA = "0x1930124", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B3D8", Offset = "0x79B3D8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1930198", Offset = "0x1930198", VA = "0x1930198", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B410", Offset = "0x79B410")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x193020C", Offset = "0x193020C", VA = "0x193020C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B448", Offset = "0x79B448")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1930254", Offset = "0x1930254", VA = "0x1930254")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B480", Offset = "0x79B480")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x193029C", Offset = "0x193029C", VA = "0x193029C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x19302A4", Offset = "0x19302A4", VA = "0x19302A4")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7943A8", Offset = "0x7943A8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7943A8", Offset = "0x7943A8")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1930308", Offset = "0x1930308", VA = "0x1930308", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B4B8", Offset = "0x79B4B8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1930350", Offset = "0x1930350", VA = "0x1930350", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B4F0", Offset = "0x79B4F0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1930398", Offset = "0x1930398", VA = "0x1930398")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B528", Offset = "0x79B528")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x19303E0", Offset = "0x19303E0", VA = "0x19303E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B560", Offset = "0x79B560")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1930428", Offset = "0x1930428", VA = "0x1930428", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1930430", Offset = "0x1930430", VA = "0x1930430")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x794408", Offset = "0x794408")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x794408", Offset = "0x794408")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1930494", Offset = "0x1930494", VA = "0x1930494", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B598", Offset = "0x79B598")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x19304DC", Offset = "0x19304DC", VA = "0x19304DC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B5D0", Offset = "0x79B5D0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1930524", Offset = "0x1930524", VA = "0x1930524")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B608", Offset = "0x79B608")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x193056C", Offset = "0x193056C", VA = "0x193056C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B640", Offset = "0x79B640")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x19305B4", Offset = "0x19305B4", VA = "0x19305B4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x19305BC", Offset = "0x19305BC", VA = "0x19305BC")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x794468", Offset = "0x794468")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x794468", Offset = "0x794468")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x19370B4", Offset = "0x19370B4", VA = "0x19370B4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B678", Offset = "0x79B678")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x19370FC", Offset = "0x19370FC", VA = "0x19370FC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B6B0", Offset = "0x79B6B0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1937144", Offset = "0x1937144", VA = "0x1937144")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B6E8", Offset = "0x79B6E8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x193718C", Offset = "0x193718C", VA = "0x193718C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B720", Offset = "0x79B720")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x19371D4", Offset = "0x19371D4", VA = "0x19371D4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x19371DC", Offset = "0x19371DC", VA = "0x19371DC")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7944C8", Offset = "0x7944C8")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x2000084")]
		public class References
		{
			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform chest;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform neck;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform leftShoulder;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Transform rightShoulder;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Transform leftThigh;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Transform leftCalf;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Transform leftFoot;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Transform leftToes;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public Transform rightThigh;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Transform rightCalf;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Transform rightFoot;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public Transform rightToes;

			[Token(Token = "0x1700006F")]
			public bool isFilled
			{
				[Token(Token = "0x60004BB")]
				[Address(RVA = "0x1C90ABC", Offset = "0x1C90ABC", VA = "0x1C90ABC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000070")]
			public bool isEmpty
			{
				[Token(Token = "0x60004BC")]
				[Address(RVA = "0x1C90E14", Offset = "0x1C90E14", VA = "0x1C90E14")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x1C90674", Offset = "0x1C90674", VA = "0x1C90674")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x1C9128C", Offset = "0x1C9128C", VA = "0x1C9128C")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x1C91628", Offset = "0x1C91628", VA = "0x1C91628")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x795D2C", Offset = "0x795D2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795D2C", Offset = "0x795D2C")]
		public References references;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795DA8", Offset = "0x795DA8")]
		public IKSolverVR solver;

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1938608", Offset = "0x1938608", VA = "0x1938608", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B758", Offset = "0x79B758")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x193867C", Offset = "0x193867C", VA = "0x193867C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B790", Offset = "0x79B790")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x19386F0", Offset = "0x19386F0", VA = "0x19386F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B7C8", Offset = "0x79B7C8")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1938738", Offset = "0x1938738", VA = "0x1938738")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B800", Offset = "0x79B800")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1938764", Offset = "0x1938764", VA = "0x1938764")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B838", Offset = "0x79B838")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x193878C", Offset = "0x193878C", VA = "0x193878C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1938794", Offset = "0x1938794", VA = "0x1938794", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1938814", Offset = "0x1938814", VA = "0x1938814")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003D")]
	public class FABRIKChain
	{
		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x795DE0", Offset = "0x795DE0")]
		public float pull;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x795DF8", Offset = "0x795DF8")]
		public float pin;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1970BAC", Offset = "0x1970BAC", VA = "0x1970BAC")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1970C7C", Offset = "0x1970C7C", VA = "0x1970C7C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1970C9C", Offset = "0x1970C9C", VA = "0x1970C9C")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x1970F10", Offset = "0x1970F10", VA = "0x1970F10")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1970D70", Offset = "0x1970D70", VA = "0x1970D70")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1971008", Offset = "0x1971008", VA = "0x1971008")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x19711F8", Offset = "0x19711F8", VA = "0x19711F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x197165C", Offset = "0x197165C", VA = "0x197165C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x1971818", Offset = "0x1971818", VA = "0x1971818")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x1971924", Offset = "0x1971924", VA = "0x1971924")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000085")]
		public class BendBone
		{
			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797FB4", Offset = "0x797FB4")]
			public Transform transform;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797FEC", Offset = "0x797FEC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x797FEC", Offset = "0x797FEC")]
			public float weight;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x1AB9008", Offset = "0x1AB9008", VA = "0x1AB9008")]
			public BendBone()
			{
			}

			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x1AB9044", Offset = "0x1AB9044", VA = "0x1AB9044")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x1AB909C", Offset = "0x1AB909C", VA = "0x1AB909C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x1AB90D4", Offset = "0x1AB90D4", VA = "0x1AB90D4")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795E10", Offset = "0x795E10")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x795E48", Offset = "0x795E48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795E48", Offset = "0x795E48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x795E48", Offset = "0x795E48")]
		public float positionWeight;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795EC0", Offset = "0x795EC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x795EC0", Offset = "0x795EC0")]
		public float bodyWeight;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795F14", Offset = "0x795F14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x795F14", Offset = "0x795F14")]
		public float thighWeight;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795F68", Offset = "0x795F68")]
		public bool handsPullBody;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x795FA0", Offset = "0x795FA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x795FA0", Offset = "0x795FA0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x795FA0", Offset = "0x795FA0")]
		public float rotationWeight;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796018", Offset = "0x796018")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x796018", Offset = "0x796018")]
		public float bodyClampWeight;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79606C", Offset = "0x79606C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x79606C", Offset = "0x79606C")]
		public float headClampWeight;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7960C0", Offset = "0x7960C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7960C0", Offset = "0x7960C0")]
		public float bendWeight;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796114", Offset = "0x796114")]
		public BendBone[] bendBones;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x79614C", Offset = "0x79614C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79614C", Offset = "0x79614C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x79614C", Offset = "0x79614C")]
		public float CCDWeight;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7961C4", Offset = "0x7961C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7961C4", Offset = "0x7961C4")]
		public float roll;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796218", Offset = "0x796218")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x796218", Offset = "0x796218")]
		public float damper;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796270", Offset = "0x796270")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7962A8", Offset = "0x7962A8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7962A8", Offset = "0x7962A8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7962A8", Offset = "0x7962A8")]
		public float postStretchWeight;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796320", Offset = "0x796320")]
		public float maxStretch;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796358", Offset = "0x796358")]
		public float stretchDamper;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796390", Offset = "0x796390")]
		public bool fixHead;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7963C8", Offset = "0x7963C8")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x796400", Offset = "0x796400")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x796438", Offset = "0x796438")]
		public float chestDirectionWeight;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x197192C", Offset = "0x197192C", VA = "0x197192C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1971C60", Offset = "0x1971C60", VA = "0x1971C60")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1972100", Offset = "0x1972100", VA = "0x1972100")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x19724CC", Offset = "0x19724CC", VA = "0x19724CC")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1972C58", Offset = "0x1972C58", VA = "0x1972C58")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1972F38", Offset = "0x1972F38", VA = "0x1972F38")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x197323C", Offset = "0x197323C", VA = "0x197323C")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1973A10", Offset = "0x1973A10", VA = "0x1973A10")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1972A3C", Offset = "0x1972A3C", VA = "0x1972A3C")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1973BD8", Offset = "0x1973BD8", VA = "0x1973BD8")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1973928", Offset = "0x1973928", VA = "0x1973928")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x197385C", Offset = "0x197385C", VA = "0x197385C")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1973E5C", Offset = "0x1973E5C", VA = "0x1973E5C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x197412C", Offset = "0x197412C", VA = "0x197412C")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000086")]
		public class ChildConstraint
		{
			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x798060", Offset = "0x798060")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x798070", Offset = "0x798070")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x17000071")]
			public float nominalDistance
			{
				[Token(Token = "0x60004C3")]
				[Address(RVA = "0x1AB90FC", Offset = "0x1AB90FC", VA = "0x1AB90FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C5B0", Offset = "0x79C5B0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60004C4")]
				[Address(RVA = "0x1AB9104", Offset = "0x1AB9104", VA = "0x1AB9104")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C5C0", Offset = "0x79C5C0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000072")]
			public bool isRigid
			{
				[Token(Token = "0x60004C5")]
				[Address(RVA = "0x1AB910C", Offset = "0x1AB910C", VA = "0x1AB910C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C5D0", Offset = "0x79C5D0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60004C6")]
				[Address(RVA = "0x1AB9114", Offset = "0x1AB9114", VA = "0x1AB9114")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C5E0", Offset = "0x79C5E0")]
				private set
				{
				}
			}

			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x1AB9120", Offset = "0x1AB9120", VA = "0x1AB9120")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x1AB916C", Offset = "0x1AB916C", VA = "0x1AB916C")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x1AB91C4", Offset = "0x1AB91C4", VA = "0x1AB91C4")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x1AB9368", Offset = "0x1AB9368", VA = "0x1AB9368")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000087")]
		public enum Smoothing
		{
			[Token(Token = "0x4000410")]
			None,
			[Token(Token = "0x4000411")]
			Exponential,
			[Token(Token = "0x4000412")]
			Cubic
		}

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x796450", Offset = "0x796450")]
		public float pin;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x796468", Offset = "0x796468")]
		public float pull;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x796480", Offset = "0x796480")]
		public float push;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x796498", Offset = "0x796498")]
		public float pushParent;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7964B0", Offset = "0x7964B0")]
		public float reach;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x40001D9")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x19742A8", Offset = "0x19742A8", VA = "0x19742A8")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1974394", Offset = "0x1974394", VA = "0x1974394")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x19744C0", Offset = "0x19744C0", VA = "0x19744C0")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x19745EC", Offset = "0x19745EC", VA = "0x19745EC")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x19746C4", Offset = "0x19746C4", VA = "0x19746C4")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x19747DC", Offset = "0x19747DC", VA = "0x19747DC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1974E58", Offset = "0x1974E58", VA = "0x1974E58")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x197496C", Offset = "0x197496C", VA = "0x197496C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1975248", Offset = "0x1975248", VA = "0x1975248")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x19754A8", Offset = "0x19754A8", VA = "0x19754A8")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1975714", Offset = "0x1975714", VA = "0x1975714")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1975AB8", Offset = "0x1975AB8", VA = "0x1975AB8")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1975F4C", Offset = "0x1975F4C", VA = "0x1975F4C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1976170", Offset = "0x1976170", VA = "0x1976170")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1975EDC", Offset = "0x1975EDC", VA = "0x1975EDC")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1975944", Offset = "0x1975944", VA = "0x1975944")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1975E60", Offset = "0x1975E60", VA = "0x1975E60")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1976258", Offset = "0x1976258", VA = "0x1976258")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1975D80", Offset = "0x1975D80", VA = "0x1975D80")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1976058", Offset = "0x1976058", VA = "0x1976058")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000041")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7964C8", Offset = "0x7964C8")]
		public float weight;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7964E0", Offset = "0x7964E0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000022")]
		public bool initiated
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x1A56C14", Offset = "0x1A56C14", VA = "0x1A56C14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B870", Offset = "0x79B870")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x1A56C1C", Offset = "0x1A56C1C", VA = "0x1A56C1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B880", Offset = "0x79B880")]
			private set
			{
			}
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1A56A2C", Offset = "0x1A56A2C", VA = "0x1A56A2C")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1A56C28", Offset = "0x1A56C28", VA = "0x1A56C28")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1A56C68", Offset = "0x1A56C68", VA = "0x1A56C68")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1A56CC8", Offset = "0x1A56CC8", VA = "0x1A56CC8")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1A56CD4", Offset = "0x1A56CD4", VA = "0x1A56CD4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1A56FE0", Offset = "0x1A56FE0", VA = "0x1A56FE0")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1A571C8", Offset = "0x1A571C8", VA = "0x1A571C8")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1A57514", Offset = "0x1A57514", VA = "0x1A57514")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1A56E90", Offset = "0x1A56E90", VA = "0x1A56E90")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1A56F38", Offset = "0x1A56F38", VA = "0x1A56F38")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000042")]
	public class IKEffector
	{
		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7964F0", Offset = "0x7964F0")]
		public float positionWeight;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x796508", Offset = "0x796508")]
		public float rotationWeight;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x796520", Offset = "0x796520")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x796530", Offset = "0x796530")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000023")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x1A579B0", Offset = "0x1A579B0", VA = "0x1A579B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B890", Offset = "0x79B890")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x1A579B8", Offset = "0x1A579B8", VA = "0x1A579B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B8A0", Offset = "0x79B8A0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1A57948", Offset = "0x1A57948", VA = "0x1A57948")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1A579C4", Offset = "0x1A579C4", VA = "0x1A579C4")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1A57A54", Offset = "0x1A57A54", VA = "0x1A57A54")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1A57B68", Offset = "0x1A57B68", VA = "0x1A57B68")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1A57C98", Offset = "0x1A57C98", VA = "0x1A57C98")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1A57FB4", Offset = "0x1A57FB4", VA = "0x1A57FB4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1A58248", Offset = "0x1A58248", VA = "0x1A58248")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1A5831C", Offset = "0x1A5831C", VA = "0x1A5831C")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1A583C4", Offset = "0x1A583C4", VA = "0x1A583C4")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1A58900", Offset = "0x1A58900", VA = "0x1A58900")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1A5892C", Offset = "0x1A5892C", VA = "0x1A5892C")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1A58A8C", Offset = "0x1A58A8C", VA = "0x1A58A8C")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1A58D18", Offset = "0x1A58D18", VA = "0x1A58D18")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000088")]
		public class BoneMap
		{
			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000073")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60004CC")]
				[Address(RVA = "0x1ABC0A8", Offset = "0x1ABC0A8", VA = "0x1ABC0A8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000074")]
			public bool isNodeBone
			{
				[Token(Token = "0x60004CF")]
				[Address(RVA = "0x1ABC184", Offset = "0x1ABC184", VA = "0x1ABC184")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000075")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60004E3")]
				[Address(RVA = "0x1ABC528", Offset = "0x1ABC528", VA = "0x1ABC528")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x1ABC07C", Offset = "0x1ABC07C", VA = "0x1ABC07C")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x1ABC0E4", Offset = "0x1ABC0E4", VA = "0x1ABC0E4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x1ABC134", Offset = "0x1ABC134", VA = "0x1ABC134")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x1ABC194", Offset = "0x1ABC194", VA = "0x1ABC194")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x1ABC21C", Offset = "0x1ABC21C", VA = "0x1ABC21C")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x1ABC224", Offset = "0x1ABC224", VA = "0x1ABC224")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x1ABC2FC", Offset = "0x1ABC2FC", VA = "0x1ABC2FC")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x1ABC374", Offset = "0x1ABC374", VA = "0x1ABC374")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x1ABC40C", Offset = "0x1ABC40C", VA = "0x1ABC40C")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x1ABC668", Offset = "0x1ABC668", VA = "0x1ABC668")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x1ABC6A0", Offset = "0x1ABC6A0", VA = "0x1ABC6A0")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x1ABC6D8", Offset = "0x1ABC6D8", VA = "0x1ABC6D8")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x1ABC700", Offset = "0x1ABC700", VA = "0x1ABC700")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x1ABC7EC", Offset = "0x1ABC7EC", VA = "0x1ABC7EC")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x1ABC978", Offset = "0x1ABC978", VA = "0x1ABC978")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x1ABC9A8", Offset = "0x1ABC9A8", VA = "0x1ABC9A8")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x1ABCA70", Offset = "0x1ABCA70", VA = "0x1ABCA70")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x1ABCAE0", Offset = "0x1ABCAE0", VA = "0x1ABCAE0")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x1ABCC30", Offset = "0x1ABCC30", VA = "0x1ABCC30")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x1ABCD80", Offset = "0x1ABCD80", VA = "0x1ABCD80")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x1ABCE00", Offset = "0x1ABCE00", VA = "0x1ABCE00")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x1ABC868", Offset = "0x1ABC868", VA = "0x1ABC868")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x1ABCF38", Offset = "0x1ABCF38", VA = "0x1ABCF38")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1A591CC", Offset = "0x1A591CC", VA = "0x1A591CC", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1A591D4", Offset = "0x1A591D4", VA = "0x1A591D4", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1A591D8", Offset = "0x1A591D8", VA = "0x1A591D8")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1A5931C", Offset = "0x1A5931C", VA = "0x1A5931C")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1A5938C", Offset = "0x1A5938C", VA = "0x1A5938C")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x796548", Offset = "0x796548")]
		public float maintainRotationWeight;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1A59394", Offset = "0x1A59394", VA = "0x1A59394", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1A5943C", Offset = "0x1A5943C", VA = "0x1A5943C")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1A594A8", Offset = "0x1A594A8", VA = "0x1A594A8")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1A59528", Offset = "0x1A59528", VA = "0x1A59528")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1A59544", Offset = "0x1A59544", VA = "0x1A59544")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1A59564", Offset = "0x1A59564", VA = "0x1A59564", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1A595EC", Offset = "0x1A595EC", VA = "0x1A595EC")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1A59608", Offset = "0x1A59608", VA = "0x1A59608")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000089")]
		public enum BoneMapType
		{
			[Token(Token = "0x400042A")]
			Parent,
			[Token(Token = "0x400042B")]
			Bone1,
			[Token(Token = "0x400042C")]
			Bone2,
			[Token(Token = "0x400042D")]
			Bone3
		}

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x796560", Offset = "0x796560")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x796578", Offset = "0x796578")]
		public float weight;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1A59630", Offset = "0x1A59630", VA = "0x1A59630", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1A596B4", Offset = "0x1A596B4", VA = "0x1A596B4")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1A59790", Offset = "0x1A59790", VA = "0x1A59790")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1A599B4", Offset = "0x1A599B4", VA = "0x1A599B4")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1A59A70", Offset = "0x1A59A70", VA = "0x1A59A70")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1A59B58", Offset = "0x1A59B58", VA = "0x1A59B58")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1A59B64", Offset = "0x1A59B64", VA = "0x1A59B64")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1A59C18", Offset = "0x1A59C18", VA = "0x1A59C18")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1A59CDC", Offset = "0x1A59CDC", VA = "0x1A59CDC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1A59F1C", Offset = "0x1A59F1C", VA = "0x1A59F1C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1A59F90", Offset = "0x1A59F90", VA = "0x1A59F90")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x796590", Offset = "0x796590")]
		public int iterations;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7965A8", Offset = "0x7965A8")]
		public float twistWeight;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1A5A110", Offset = "0x1A5A110", VA = "0x1A5A110", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1A5A474", Offset = "0x1A5A474", VA = "0x1A5A474")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1A5A558", Offset = "0x1A5A558", VA = "0x1A5A558")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1A5A670", Offset = "0x1A5A670", VA = "0x1A5A670")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1A5A680", Offset = "0x1A5A680", VA = "0x1A5A680")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1A5A6EC", Offset = "0x1A5A6EC", VA = "0x1A5A6EC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1A5A770", Offset = "0x1A5A770", VA = "0x1A5A770", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1A5AD48", Offset = "0x1A5AD48", VA = "0x1A5AD48")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1A5AD80", Offset = "0x1A5AD80", VA = "0x1A5AD80")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1A5B004", Offset = "0x1A5B004", VA = "0x1A5B004")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1A5B30C", Offset = "0x1A5B30C", VA = "0x1A5B30C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1A5B3F8", Offset = "0x1A5B3F8", VA = "0x1A5B3F8")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1A5B4C0", Offset = "0x1A5B4C0", VA = "0x1A5B4C0")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x200008A")]
		public class Point
		{
			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x798080", Offset = "0x798080")]
			public float weight;

			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x1ABDA44", Offset = "0x1ABDA44", VA = "0x1ABDA44")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x1ABDA94", Offset = "0x1ABDA94", VA = "0x1ABDA94")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x1ABDB34", Offset = "0x1ABDB34", VA = "0x1ABDB34")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x1ABDB6C", Offset = "0x1ABDB6C", VA = "0x1ABDB6C")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x1ABDBA4", Offset = "0x1ABDBA4", VA = "0x1ABDBA4")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x1ABDBF4", Offset = "0x1ABDBF4", VA = "0x1ABDBF4")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x1ABD624", Offset = "0x1ABD624", VA = "0x1ABD624")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008B")]
		public class Bone : Point
		{
			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x17000076")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x60004EC")]
				[Address(RVA = "0x1ABCF54", Offset = "0x1ABCF54", VA = "0x1ABCF54")]
				get
				{
					return null;
				}
				[Token(Token = "0x60004ED")]
				[Address(RVA = "0x1ABD050", Offset = "0x1ABD050", VA = "0x1ABD050")]
				set
				{
				}
			}

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x1ABD0D4", Offset = "0x1ABD0D4", VA = "0x1ABD0D4")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x1ABD284", Offset = "0x1ABD284", VA = "0x1ABD284")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x1ABD458", Offset = "0x1ABD458", VA = "0x1ABD458")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x1ABD5B8", Offset = "0x1ABD5B8", VA = "0x1ABD5B8")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x1ABD5E0", Offset = "0x1ABD5E0", VA = "0x1ABD5E0")]
			public Bone()
			{
			}

			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x1ABD660", Offset = "0x1ABD660", VA = "0x1ABD660")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x1ABD6B0", Offset = "0x1ABD6B0", VA = "0x1ABD6B0")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008C")]
		public class Node : Point
		{
			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x1ABD9E0", Offset = "0x1ABD9E0", VA = "0x1ABD9E0")]
			public Node()
			{
			}

			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x1ABD9E4", Offset = "0x1ABD9E4", VA = "0x1ABD9E4")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x1ABDA0C", Offset = "0x1ABDA0C", VA = "0x1ABDA0C")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x200008D")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x200008E")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7965D0", Offset = "0x7965D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7965D0", Offset = "0x7965D0")]
		public float IKPositionWeight;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x796624", Offset = "0x796624")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000024")]
		public bool initiated
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x1A5B7F8", Offset = "0x1A5B7F8", VA = "0x1A5B7F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B8B0", Offset = "0x79B8B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x1A5B800", Offset = "0x1A5B800", VA = "0x1A5B800")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B8C0", Offset = "0x79B8C0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1A5B728", Offset = "0x1A5B728", VA = "0x1A5B728")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000268")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1A4CBCC", Offset = "0x1A4CBCC", VA = "0x1A4CBCC")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1A4D0F8", Offset = "0x1A4D0F8", VA = "0x1A4D0F8")]
		public void Update()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1A5B7A0", Offset = "0x1A5B7A0", VA = "0x1A5B7A0", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1A5B7AC", Offset = "0x1A5B7AC", VA = "0x1A5B7AC")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1A5B7B8", Offset = "0x1A5B7B8", VA = "0x1A5B7B8")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1A5B7C0", Offset = "0x1A5B7C0", VA = "0x1A5B7C0")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1A5B7F0", Offset = "0x1A5B7F0", VA = "0x1A5B7F0")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000272")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000273")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000274")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000275")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x6000276")]
		protected abstract void OnInitiate();

		[Token(Token = "0x6000277")]
		protected abstract void OnUpdate();

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1A5B80C", Offset = "0x1A5B80C", VA = "0x1A5B80C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1A5B824", Offset = "0x1A5B824", VA = "0x1A5B824")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1A5B95C", Offset = "0x1A5B95C", VA = "0x1A5B95C")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1A5BA04", Offset = "0x1A5BA04", VA = "0x1A5BA04")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1A5BC8C", Offset = "0x1A5BC8C", VA = "0x1A5BC8C")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x79666C", Offset = "0x79666C")]
		public float poleWeight;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x796684", Offset = "0x796684")]
		public float clampWeight;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x79669C", Offset = "0x79669C")]
		public int clampSmoothing;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000025")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x1A5BD20", Offset = "0x1A5BD20", VA = "0x1A5BD20")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000026")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x1A5BD5C", Offset = "0x1A5BD5C", VA = "0x1A5BD5C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000027")]
		protected override int minBones
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x1A5C7EC", Offset = "0x1A5C7EC", VA = "0x1A5C7EC", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000028")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x1A5CBD0", Offset = "0x1A5CBD0", VA = "0x1A5CBD0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1A5BCA4", Offset = "0x1A5BCA4", VA = "0x1A5BCA4")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1A5BD98", Offset = "0x1A5BD98", VA = "0x1A5BD98", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1A5BFB8", Offset = "0x1A5BFB8", VA = "0x1A5BFB8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1A5C738", Offset = "0x1A5C738", VA = "0x1A5C738")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1A5C4C8", Offset = "0x1A5C4C8", VA = "0x1A5C4C8")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1A5C7F4", Offset = "0x1A5C7F4", VA = "0x1A5C7F4")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1A5CC44", Offset = "0x1A5CC44", VA = "0x1A5CC44")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000049")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x1A5CC98", Offset = "0x1A5CC98", VA = "0x1A5CC98")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1A5CD48", Offset = "0x1A5CD48", VA = "0x1A5CD48", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1A5CDCC", Offset = "0x1A5CDCC", VA = "0x1A5CDCC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1A5CFFC", Offset = "0x1A5CFFC", VA = "0x1A5CFFC")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1A5D5D8", Offset = "0x1A5D5D8", VA = "0x1A5D5D8")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004A")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000029")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x1A7721C", Offset = "0x1A7721C", VA = "0x1A7721C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1A75B10", Offset = "0x1A75B10", VA = "0x1A75B10")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x1A760D0", Offset = "0x1A760D0", VA = "0x1A760D0")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1A7620C", Offset = "0x1A7620C", VA = "0x1A7620C", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1A762A0", Offset = "0x1A762A0", VA = "0x1A762A0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1A76BF0", Offset = "0x1A76BF0", VA = "0x1A76BF0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1A77224", Offset = "0x1A77224", VA = "0x1A77224")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1A75BE8", Offset = "0x1A75BE8", VA = "0x1A75BE8")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1A761B8", Offset = "0x1A761B8", VA = "0x1A761B8")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1A771C0", Offset = "0x1A771C0", VA = "0x1A771C0")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1A75F44", Offset = "0x1A75F44", VA = "0x1A75F44")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1A77874", Offset = "0x1A77874", VA = "0x1A77874")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1A778E8", Offset = "0x1A778E8", VA = "0x1A778E8")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x1A779B0", Offset = "0x1A779B0", VA = "0x1A779B0")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1A77A60", Offset = "0x1A77A60", VA = "0x1A77A60")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1A769A0", Offset = "0x1A769A0", VA = "0x1A769A0")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1A76AC8", Offset = "0x1A76AC8", VA = "0x1A76AC8")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1A77B64", Offset = "0x1A77B64", VA = "0x1A77B64")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1A77444", Offset = "0x1A77444", VA = "0x1A77444")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1A761A8", Offset = "0x1A761A8", VA = "0x1A761A8")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1A780F4", Offset = "0x1A780F4", VA = "0x1A780F4")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1A77CA8", Offset = "0x1A77CA8", VA = "0x1A77CA8")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1A772A0", Offset = "0x1A772A0", VA = "0x1A772A0")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1A77380", Offset = "0x1A77380", VA = "0x1A77380")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1A781C0", Offset = "0x1A781C0", VA = "0x1A781C0")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7966B4", Offset = "0x7966B4")]
		public float rootPin;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1A782A8", Offset = "0x1A782A8", VA = "0x1A782A8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1A788E8", Offset = "0x1A788E8", VA = "0x1A788E8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1A78980", Offset = "0x1A78980", VA = "0x1A78980", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1A78A20", Offset = "0x1A78A20", VA = "0x1A78A20", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x1A78B1C", Offset = "0x1A78B1C", VA = "0x1A78B1C")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1A78BB8", Offset = "0x1A78BB8", VA = "0x1A78BB8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1A78FE8", Offset = "0x1A78FE8", VA = "0x1A78FE8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1A791E0", Offset = "0x1A791E0", VA = "0x1A791E0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1A79094", Offset = "0x1A79094", VA = "0x1A79094")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1A78DA4", Offset = "0x1A78DA4", VA = "0x1A78DA4")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1A79278", Offset = "0x1A79278", VA = "0x1A79278")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7966CC", Offset = "0x7966CC")]
		public int iterations;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1A792DC", Offset = "0x1A792DC", VA = "0x1A792DC")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1A793CC", Offset = "0x1A793CC", VA = "0x1A793CC")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1A79428", Offset = "0x1A79428", VA = "0x1A79428")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1A79558", Offset = "0x1A79558", VA = "0x1A79558")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1A795B4", Offset = "0x1A795B4", VA = "0x1A795B4")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1A79634", Offset = "0x1A79634", VA = "0x1A79634", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1A797B8", Offset = "0x1A797B8", VA = "0x1A797B8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1A79928", Offset = "0x1A79928", VA = "0x1A79928", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1A79B34", Offset = "0x1A79B34", VA = "0x1A79B34", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1A79C0C", Offset = "0x1A79C0C", VA = "0x1A79C0C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1A79CF8", Offset = "0x1A79CF8", VA = "0x1A79CF8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1A79E6C", Offset = "0x1A79E6C", VA = "0x1A79E6C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1A79FC4", Offset = "0x1A79FC4", VA = "0x1A79FC4", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1A7A210", Offset = "0x1A7A210", VA = "0x1A7A210", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1A7A4EC", Offset = "0x1A7A4EC", VA = "0x1A7A4EC", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1A7A530", Offset = "0x1A7A530", VA = "0x1A7A530", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1A7A620", Offset = "0x1A7A620", VA = "0x1A7A620")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x4000256")]
		Body,
		[Token(Token = "0x4000257")]
		LeftShoulder,
		[Token(Token = "0x4000258")]
		RightShoulder,
		[Token(Token = "0x4000259")]
		LeftThigh,
		[Token(Token = "0x400025A")]
		RightThigh,
		[Token(Token = "0x400025B")]
		LeftHand,
		[Token(Token = "0x400025C")]
		RightHand,
		[Token(Token = "0x400025D")]
		LeftFoot,
		[Token(Token = "0x400025E")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x4000260")]
		LeftArm,
		[Token(Token = "0x4000261")]
		RightArm,
		[Token(Token = "0x4000262")]
		LeftLeg,
		[Token(Token = "0x4000263")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7966E4", Offset = "0x7966E4")]
		public float spineStiffness;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7966FC", Offset = "0x7966FC")]
		public float pullBodyVertical;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x796714", Offset = "0x796714")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79672C", Offset = "0x79672C")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700002A")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x1A7A724", Offset = "0x1A7A724", VA = "0x1A7A724")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x1A7A86C", Offset = "0x1A7A86C", VA = "0x1A7A86C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x1A7A874", Offset = "0x1A7A874", VA = "0x1A7A874")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x1A7A87C", Offset = "0x1A7A87C", VA = "0x1A7A87C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x1A7A884", Offset = "0x1A7A884", VA = "0x1A7A884")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x1A7A88C", Offset = "0x1A7A88C", VA = "0x1A7A88C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x1A7A894", Offset = "0x1A7A894", VA = "0x1A7A894")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x1A7A89C", Offset = "0x1A7A89C", VA = "0x1A7A89C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x1A7A8A4", Offset = "0x1A7A8A4", VA = "0x1A7A8A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x1A7A8AC", Offset = "0x1A7A8AC", VA = "0x1A7A8AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x1A7A8E4", Offset = "0x1A7A8E4", VA = "0x1A7A8E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x1A7A91C", Offset = "0x1A7A91C", VA = "0x1A7A91C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x1A7A954", Offset = "0x1A7A954", VA = "0x1A7A954")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x1A7A98C", Offset = "0x1A7A98C", VA = "0x1A7A98C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x1A7A9C0", Offset = "0x1A7A9C0", VA = "0x1A7A9C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x1A7A9F8", Offset = "0x1A7A9F8", VA = "0x1A7A9F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x1A7AA30", Offset = "0x1A7AA30", VA = "0x1A7AA30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x1A7AA68", Offset = "0x1A7AA68", VA = "0x1A7AA68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x1A7C930", Offset = "0x1A7C930", VA = "0x1A7C930")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B8D0", Offset = "0x79B8D0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x1A7C93C", Offset = "0x1A7C93C", VA = "0x1A7C93C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B8E0", Offset = "0x79B8E0")]
			private set
			{
			}
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1A7AA9C", Offset = "0x1A7AA9C", VA = "0x1A7AA9C")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1A7ABA8", Offset = "0x1A7ABA8", VA = "0x1A7ABA8")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1A7AAF0", Offset = "0x1A7AAF0", VA = "0x1A7AAF0")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1A7AC34", Offset = "0x1A7AC34", VA = "0x1A7AC34")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1A7A72C", Offset = "0x1A7A72C", VA = "0x1A7A72C")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1A7AD04", Offset = "0x1A7AD04", VA = "0x1A7AD04")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1A7ADBC", Offset = "0x1A7ADBC", VA = "0x1A7ADBC")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1A7AE70", Offset = "0x1A7AE70", VA = "0x1A7AE70")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1A7AF24", Offset = "0x1A7AF24", VA = "0x1A7AF24")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1A7AF2C", Offset = "0x1A7AF2C", VA = "0x1A7AF2C")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1A7AF60", Offset = "0x1A7AF60", VA = "0x1A7AF60")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1A7B028", Offset = "0x1A7B028", VA = "0x1A7B028", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1A7B1CC", Offset = "0x1A7B1CC", VA = "0x1A7B1CC")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1A7C3AC", Offset = "0x1A7C3AC", VA = "0x1A7C3AC")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1A7C7C0", Offset = "0x1A7C7C0", VA = "0x1A7C7C0")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1A7C820", Offset = "0x1A7C820", VA = "0x1A7C820")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1A7C648", Offset = "0x1A7C648", VA = "0x1A7C648")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1A7C704", Offset = "0x1A7C704", VA = "0x1A7C704")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1A7C948", Offset = "0x1A7C948", VA = "0x1A7C948")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1A7CA20", Offset = "0x1A7CA20", VA = "0x1A7CA20", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1A7CB1C", Offset = "0x1A7CB1C", VA = "0x1A7CB1C")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1A7CC44", Offset = "0x1A7CC44", VA = "0x1A7CC44")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1A7CD88", Offset = "0x1A7CD88", VA = "0x1A7CD88")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1A7CEB8", Offset = "0x1A7CEB8", VA = "0x1A7CEB8", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1A7D0F8", Offset = "0x1A7D0F8", VA = "0x1A7D0F8", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1A7D17C", Offset = "0x1A7D17C", VA = "0x1A7D17C")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x1700003D")]
		protected virtual int minBones
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x1A7D9E8", Offset = "0x1A7D9E8", VA = "0x1A7D9E8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003E")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x1A7D9F0", Offset = "0x1A7D9F0", VA = "0x1A7D9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x1A7D9F8", Offset = "0x1A7D9F8", VA = "0x1A7D9F8", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x1A7DA08", Offset = "0x1A7DA08", VA = "0x1A7DA08", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000041")]
		protected float positionOffset
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x1A7716C", Offset = "0x1A7716C", VA = "0x1A7716C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1A7D188", Offset = "0x1A7D188", VA = "0x1A7D188")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1A7D324", Offset = "0x1A7D324", VA = "0x1A7D324")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1A7D45C", Offset = "0x1A7D45C", VA = "0x1A7D45C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1A7D4C8", Offset = "0x1A7D4C8", VA = "0x1A7D4C8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1A7D548", Offset = "0x1A7D548", VA = "0x1A7D548", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1A7D8F0", Offset = "0x1A7D8F0", VA = "0x1A7D8F0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1A7D8F8", Offset = "0x1A7D8F8", VA = "0x1A7D8F8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1A7DA00", Offset = "0x1A7DA00", VA = "0x1A7DA00", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1A7DA04", Offset = "0x1A7DA04", VA = "0x1A7DA04", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1A76528", Offset = "0x1A76528", VA = "0x1A76528")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1A76E54", Offset = "0x1A76E54", VA = "0x1A76E54")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1A7DAD0", Offset = "0x1A7DAD0", VA = "0x1A7DAD0")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1A7823C", Offset = "0x1A7823C", VA = "0x1A7823C")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000051")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x79673C", Offset = "0x79673C")]
		public float IKRotationWeight;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1A7DCC4", Offset = "0x1A7DCC4", VA = "0x1A7DCC4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x1A7E064", Offset = "0x1A7E064", VA = "0x1A7E064")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x1A7E0D4", Offset = "0x1A7E0D4", VA = "0x1A7E0D4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1A7E22C", Offset = "0x1A7E22C", VA = "0x1A7E22C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1A7E3C0", Offset = "0x1A7E3C0", VA = "0x1A7E3C0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x1A7E41C", Offset = "0x1A7E41C", VA = "0x1A7E41C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1A7E48C", Offset = "0x1A7E48C", VA = "0x1A7E48C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1A7E7F4", Offset = "0x1A7E7F4", VA = "0x1A7E7F4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1A7E820", Offset = "0x1A7E820", VA = "0x1A7E820")]
		private void Solve()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1A7E4F0", Offset = "0x1A7E4F0", VA = "0x1A7E4F0")]
		private void Read()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1A7E8B0", Offset = "0x1A7E8B0", VA = "0x1A7E8B0")]
		private void Write()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1A7E9C8", Offset = "0x1A7E9C8", VA = "0x1A7E9C8")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x200008F")]
		public enum BendModifier
		{
			[Token(Token = "0x400043E")]
			Animation,
			[Token(Token = "0x400043F")]
			Target,
			[Token(Token = "0x4000440")]
			Parent,
			[Token(Token = "0x4000441")]
			Arm,
			[Token(Token = "0x4000442")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x2000090")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x6000500")]
			[Address(RVA = "0x1ABDE98", Offset = "0x1ABDE98", VA = "0x1ABDE98")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x796754", Offset = "0x796754")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x79676C", Offset = "0x79676C")]
		public float bendModifierWeight;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000042")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x1A7FC44", Offset = "0x1A7FC44", VA = "0x1A7FC44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1A7EB20", Offset = "0x1A7EB20", VA = "0x1A7EB20")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1A7EB70", Offset = "0x1A7EB70", VA = "0x1A7EB70")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1A7EBBC", Offset = "0x1A7EBBC", VA = "0x1A7EBBC", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1A7F090", Offset = "0x1A7F090", VA = "0x1A7F090", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1A7F9D8", Offset = "0x1A7F9D8", VA = "0x1A7F9D8", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1A7FA84", Offset = "0x1A7FA84", VA = "0x1A7FA84")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1A7FBC0", Offset = "0x1A7FBC0", VA = "0x1A7FBC0")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1A7EEB8", Offset = "0x1A7EEB8", VA = "0x1A7EEB8")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1A7F174", Offset = "0x1A7F174", VA = "0x1A7F174")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000091")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x17000077")]
			public Vector3 forward
			{
				[Token(Token = "0x6000505")]
				[Address(RVA = "0x1ABE124", Offset = "0x1ABE124", VA = "0x1ABE124")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000501")]
			[Address(RVA = "0x1ABDEF8", Offset = "0x1ABDEF8", VA = "0x1ABDEF8")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000502")]
			[Address(RVA = "0x1ABDEFC", Offset = "0x1ABDEFC", VA = "0x1ABDEFC")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000503")]
			[Address(RVA = "0x1ABDF24", Offset = "0x1ABDF24", VA = "0x1ABDF24")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000504")]
			[Address(RVA = "0x1ABE01C", Offset = "0x1ABE01C", VA = "0x1ABE01C")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x796784", Offset = "0x796784")]
		public float bodyWeight;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x79679C", Offset = "0x79679C")]
		public float headWeight;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7967B4", Offset = "0x7967B4")]
		public float eyesWeight;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7967CC", Offset = "0x7967CC")]
		public float clampWeight;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7967E4", Offset = "0x7967E4")]
		public float clampWeightHead;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7967FC", Offset = "0x7967FC")]
		public float clampWeightEyes;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x796814", Offset = "0x796814")]
		public int clampSmoothing;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] headForwards;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x17000043")]
		private bool spineIsValid
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x1A803E4", Offset = "0x1A803E4", VA = "0x1A803E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x1A805B4", Offset = "0x1A805B4", VA = "0x1A805B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		private bool headIsValid
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x1A804C4", Offset = "0x1A804C4", VA = "0x1A804C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		private bool headIsEmpty
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x1A805D8", Offset = "0x1A805D8", VA = "0x1A805D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		private bool eyesIsValid
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x1A804D4", Offset = "0x1A804D4", VA = "0x1A804D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x1A80650", Offset = "0x1A80650", VA = "0x1A80650")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1A7FC60", Offset = "0x1A7FC60", VA = "0x1A7FC60")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1A7FC90", Offset = "0x1A7FC90", VA = "0x1A7FC90")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1A7FCE8", Offset = "0x1A7FCE8", VA = "0x1A7FCE8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1A7FD64", Offset = "0x1A7FD64", VA = "0x1A7FD64")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1A7FDFC", Offset = "0x1A7FDFC", VA = "0x1A7FDFC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1A7FEBC", Offset = "0x1A7FEBC", VA = "0x1A7FEBC")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1A7FFB8", Offset = "0x1A7FFB8", VA = "0x1A7FFB8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1A800E4", Offset = "0x1A800E4", VA = "0x1A800E4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1A80224", Offset = "0x1A80224", VA = "0x1A80224", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1A80674", Offset = "0x1A80674", VA = "0x1A80674", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1A808B4", Offset = "0x1A808B4", VA = "0x1A808B4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1A80A50", Offset = "0x1A80A50", VA = "0x1A80A50")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1A80C80", Offset = "0x1A80C80", VA = "0x1A80C80", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1A80F54", Offset = "0x1A80F54", VA = "0x1A80F54", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1A81024", Offset = "0x1A81024", VA = "0x1A81024")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1A811C4", Offset = "0x1A811C4", VA = "0x1A811C4")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1A813E8", Offset = "0x1A813E8", VA = "0x1A813E8")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1A81600", Offset = "0x1A81600", VA = "0x1A81600")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1A80AFC", Offset = "0x1A80AFC", VA = "0x1A80AFC")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1A81870", Offset = "0x1A81870", VA = "0x1A81870")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000092")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000506")]
			[Address(RVA = "0x1ABE160", Offset = "0x1ABE160", VA = "0x1ABE160")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000507")]
			[Address(RVA = "0x1ABE25C", Offset = "0x1ABE25C", VA = "0x1ABE25C")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000508")]
			[Address(RVA = "0x1ABE28C", Offset = "0x1ABE28C", VA = "0x1ABE28C")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000509")]
			[Address(RVA = "0x1ABE2C8", Offset = "0x1ABE2C8", VA = "0x1ABE2C8")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x79682C", Offset = "0x79682C")]
		public float IKRotationWeight;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1A81A7C", Offset = "0x1A81A7C", VA = "0x1A81A7C")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1A81BD8", Offset = "0x1A81BD8", VA = "0x1A81BD8")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1A81D1C", Offset = "0x1A81D1C", VA = "0x1A81D1C")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1A81D28", Offset = "0x1A81D28", VA = "0x1A81D28")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1A81D58", Offset = "0x1A81D58", VA = "0x1A81D58")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1A81D64", Offset = "0x1A81D64", VA = "0x1A81D64")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1A81D6C", Offset = "0x1A81D6C", VA = "0x1A81D6C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1A81E6C", Offset = "0x1A81E6C", VA = "0x1A81E6C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1A81F88", Offset = "0x1A81F88", VA = "0x1A81F88", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1A81FD4", Offset = "0x1A81FD4", VA = "0x1A81FD4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1A82034", Offset = "0x1A82034", VA = "0x1A82034", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1A823FC", Offset = "0x1A823FC", VA = "0x1A823FC")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1A82454", Offset = "0x1A82454", VA = "0x1A82454")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1A82810", Offset = "0x1A82810", VA = "0x1A82810")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1A82978", Offset = "0x1A82978", VA = "0x1A82978", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1A82AE0", Offset = "0x1A82AE0", VA = "0x1A82AE0")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1A82A54", Offset = "0x1A82A54", VA = "0x1A82A54")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1A82BE4", Offset = "0x1A82BE4", VA = "0x1A82BE4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1A833A8", Offset = "0x1A833A8", VA = "0x1A833A8", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1A833AC", Offset = "0x1A833AC", VA = "0x1A833AC", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1A833B0", Offset = "0x1A833B0", VA = "0x1A833B0", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1A831D0", Offset = "0x1A831D0", VA = "0x1A831D0")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1A7FAF4", Offset = "0x1A7FAF4", VA = "0x1A7FAF4")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000093")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x20000BD")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x400058D")]
				YawPitch,
				[Token(Token = "0x400058E")]
				FromTo
			}

			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798098", Offset = "0x798098")]
			public Transform target;

			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7980D0", Offset = "0x7980D0")]
			public Transform bendGoal;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798108", Offset = "0x798108")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x798108", Offset = "0x798108")]
			public float positionWeight;

			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79815C", Offset = "0x79815C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x79815C", Offset = "0x79815C")]
			public float rotationWeight;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7981B0", Offset = "0x7981B0")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7981E8", Offset = "0x7981E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7981E8", Offset = "0x7981E8")]
			public float shoulderRotationWeight;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79823C", Offset = "0x79823C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x79823C", Offset = "0x79823C")]
			public float bendGoalWeight;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798290", Offset = "0x798290")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x798290", Offset = "0x798290")]
			public float swivelOffset;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7982EC", Offset = "0x7982EC")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798324", Offset = "0x798324")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79835C", Offset = "0x79835C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x79835C", Offset = "0x79835C")]
			public float armLengthMlp;

			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7983B4", Offset = "0x7983B4")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79842C", Offset = "0x79842C")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79843C", Offset = "0x79843C")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000461")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x4000462")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000078")]
			public Vector3 position
			{
				[Token(Token = "0x600050A")]
				[Address(RVA = "0x1ABE2CC", Offset = "0x1ABE2CC", VA = "0x1ABE2CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C5F0", Offset = "0x79C5F0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600050B")]
				[Address(RVA = "0x1ABE2D8", Offset = "0x1ABE2D8", VA = "0x1ABE2D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C600", Offset = "0x79C600")]
				private set
				{
				}
			}

			[Token(Token = "0x17000079")]
			public Quaternion rotation
			{
				[Token(Token = "0x600050C")]
				[Address(RVA = "0x1ABE2E4", Offset = "0x1ABE2E4", VA = "0x1ABE2E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C610", Offset = "0x79C610")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600050D")]
				[Address(RVA = "0x1ABE2F0", Offset = "0x1ABE2F0", VA = "0x1ABE2F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C620", Offset = "0x79C620")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007A")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600050E")]
				[Address(RVA = "0x1ABE2FC", Offset = "0x1ABE2FC", VA = "0x1ABE2FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600050F")]
				[Address(RVA = "0x1ABE330", Offset = "0x1ABE330", VA = "0x1ABE330")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000510")]
				[Address(RVA = "0x1ABE368", Offset = "0x1ABE368", VA = "0x1ABE368")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000511")]
				[Address(RVA = "0x1ABE3A0", Offset = "0x1ABE3A0", VA = "0x1ABE3A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000512")]
			[Address(RVA = "0x1ABE3D8", Offset = "0x1ABE3D8", VA = "0x1ABE3D8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000513")]
			[Address(RVA = "0x1ABEB94", Offset = "0x1ABEB94", VA = "0x1ABEB94", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000514")]
			[Address(RVA = "0x1ABED50", Offset = "0x1ABED50", VA = "0x1ABED50", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000515")]
			[Address(RVA = "0x1ABED74", Offset = "0x1ABED74", VA = "0x1ABED74")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000516")]
			[Address(RVA = "0x1ABF014", Offset = "0x1ABF014", VA = "0x1ABF014")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000517")]
			[Address(RVA = "0x1AC08CC", Offset = "0x1AC08CC", VA = "0x1AC08CC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000518")]
			[Address(RVA = "0x1AC08F8", Offset = "0x1AC08F8", VA = "0x1AC08F8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000519")]
			[Address(RVA = "0x1ABFDCC", Offset = "0x1ABFDCC", VA = "0x1ABFDCC")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600051A")]
			[Address(RVA = "0x1ABFF84", Offset = "0x1ABFF84", VA = "0x1ABFF84")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600051B")]
			[Address(RVA = "0x1AC0B18", Offset = "0x1AC0B18", VA = "0x1AC0B18")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600051C")]
			[Address(RVA = "0x1AC0C3C", Offset = "0x1AC0C3C", VA = "0x1AC0C3C")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000094")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79844C", Offset = "0x79844C")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79845C", Offset = "0x79845C")]
			private float <mag>k__BackingField;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x1700007E")]
			public float sqrMag
			{
				[Token(Token = "0x6000522")]
				[Address(RVA = "0x1AC0D54", Offset = "0x1AC0D54", VA = "0x1AC0D54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C630", Offset = "0x79C630")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000523")]
				[Address(RVA = "0x1AC0D5C", Offset = "0x1AC0D5C", VA = "0x1AC0D5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C640", Offset = "0x79C640")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007F")]
			public float mag
			{
				[Token(Token = "0x6000524")]
				[Address(RVA = "0x1AC0D64", Offset = "0x1AC0D64", VA = "0x1AC0D64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C650", Offset = "0x79C650")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000525")]
				[Address(RVA = "0x1AC0D6C", Offset = "0x1AC0D6C", VA = "0x1AC0D6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C660", Offset = "0x79C660")]
				private set
				{
				}
			}

			[Token(Token = "0x600051D")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index);

			[Token(Token = "0x600051E")]
			public abstract void PreSolve();

			[Token(Token = "0x600051F")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000520")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x6000521")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000526")]
			[Address(RVA = "0x1AC0D74", Offset = "0x1AC0D74", VA = "0x1AC0D74")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000527")]
			[Address(RVA = "0x1AC1028", Offset = "0x1AC1028", VA = "0x1AC1028")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000528")]
			[Address(RVA = "0x1AC10BC", Offset = "0x1AC10BC", VA = "0x1AC10BC")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000529")]
			[Address(RVA = "0x1AC128C", Offset = "0x1AC128C", VA = "0x1AC128C")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600052A")]
			[Address(RVA = "0x1AC12E0", Offset = "0x1AC12E0", VA = "0x1AC12E0")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x600052B")]
			[Address(RVA = "0x1AC078C", Offset = "0x1AC078C", VA = "0x1AC078C")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600052C")]
			[Address(RVA = "0x1AC1418", Offset = "0x1AC1418", VA = "0x1AC1418")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600052D")]
			[Address(RVA = "0x1AC1558", Offset = "0x1AC1558", VA = "0x1AC1558")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600052E")]
			[Address(RVA = "0x1AC0CE0", Offset = "0x1AC0CE0", VA = "0x1AC0CE0")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000095")]
		public class Footstep
		{
			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79847C", Offset = "0x79847C")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x17000080")]
			public bool isStepping
			{
				[Token(Token = "0x600052F")]
				[Address(RVA = "0x1AC1580", Offset = "0x1AC1580", VA = "0x1AC1580")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000081")]
			public float stepProgress
			{
				[Token(Token = "0x6000530")]
				[Address(RVA = "0x1AC1594", Offset = "0x1AC1594", VA = "0x1AC1594")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C670", Offset = "0x79C670")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000531")]
				[Address(RVA = "0x1AC159C", Offset = "0x1AC159C", VA = "0x1AC159C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C680", Offset = "0x79C680")]
				private set
				{
				}
			}

			[Token(Token = "0x6000532")]
			[Address(RVA = "0x1AC15A4", Offset = "0x1AC15A4", VA = "0x1AC15A4")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000533")]
			[Address(RVA = "0x1AC1698", Offset = "0x1AC1698", VA = "0x1AC1698")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000534")]
			[Address(RVA = "0x1AC1718", Offset = "0x1AC1718", VA = "0x1AC1718")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000535")]
			[Address(RVA = "0x1AC1794", Offset = "0x1AC1794", VA = "0x1AC1794")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000536")]
			[Address(RVA = "0x1AC1908", Offset = "0x1AC1908", VA = "0x1AC1908")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0x1AC1A60", Offset = "0x1AC1A60", VA = "0x1AC1A60")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000096")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79848C", Offset = "0x79848C")]
			public Transform target;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7984C4", Offset = "0x7984C4")]
			public Transform bendGoal;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7984FC", Offset = "0x7984FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7984FC", Offset = "0x7984FC")]
			public float positionWeight;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798550", Offset = "0x798550")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x798550", Offset = "0x798550")]
			public float rotationWeight;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7985A4", Offset = "0x7985A4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7985A4", Offset = "0x7985A4")]
			public float bendGoalWeight;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7985F8", Offset = "0x7985F8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7985F8", Offset = "0x7985F8")]
			public float swivelOffset;

			[NonSerialized]
			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7986B4", Offset = "0x7986B4")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7986C4", Offset = "0x7986C4")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7986D4", Offset = "0x7986D4")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7986E4", Offset = "0x7986E4")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Vector3 footPosition;

			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Quaternion footRotation;

			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 bendNormal;

			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x17000082")]
			public Vector3 position
			{
				[Token(Token = "0x6000538")]
				[Address(RVA = "0x1AC1B9C", Offset = "0x1AC1B9C", VA = "0x1AC1B9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C690", Offset = "0x79C690")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000539")]
				[Address(RVA = "0x1AC1BA8", Offset = "0x1AC1BA8", VA = "0x1AC1BA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C6A0", Offset = "0x79C6A0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000083")]
			public Quaternion rotation
			{
				[Token(Token = "0x600053A")]
				[Address(RVA = "0x1AC1BB4", Offset = "0x1AC1BB4", VA = "0x1AC1BB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C6B0", Offset = "0x79C6B0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600053B")]
				[Address(RVA = "0x1AC1BC0", Offset = "0x1AC1BC0", VA = "0x1AC1BC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C6C0", Offset = "0x79C6C0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000084")]
			public bool hasToes
			{
				[Token(Token = "0x600053C")]
				[Address(RVA = "0x1AC1BCC", Offset = "0x1AC1BCC", VA = "0x1AC1BCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C6D0", Offset = "0x79C6D0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600053D")]
				[Address(RVA = "0x1AC1BD4", Offset = "0x1AC1BD4", VA = "0x1AC1BD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C6E0", Offset = "0x79C6E0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000085")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600053E")]
				[Address(RVA = "0x1AC1BE0", Offset = "0x1AC1BE0", VA = "0x1AC1BE0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000086")]
			private VirtualBone calf
			{
				[Token(Token = "0x600053F")]
				[Address(RVA = "0x1AC1C14", Offset = "0x1AC1C14", VA = "0x1AC1C14")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000540")]
				[Address(RVA = "0x1AC1C4C", Offset = "0x1AC1C4C", VA = "0x1AC1C4C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000088")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000541")]
				[Address(RVA = "0x1AC1C84", Offset = "0x1AC1C84", VA = "0x1AC1C84")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000089")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000542")]
				[Address(RVA = "0x1AC1CBC", Offset = "0x1AC1CBC", VA = "0x1AC1CBC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000543")]
				[Address(RVA = "0x1AC1CFC", Offset = "0x1AC1CFC", VA = "0x1AC1CFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C6F0", Offset = "0x79C6F0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000544")]
				[Address(RVA = "0x1AC1D08", Offset = "0x1AC1D08", VA = "0x1AC1D08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C700", Offset = "0x79C700")]
				private set
				{
				}
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0x1AC1D14", Offset = "0x1AC1D14", VA = "0x1AC1D14", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0x1AC21C4", Offset = "0x1AC21C4", VA = "0x1AC21C4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000547")]
			[Address(RVA = "0x1AC263C", Offset = "0x1AC263C", VA = "0x1AC263C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000548")]
			[Address(RVA = "0x1AC25EC", Offset = "0x1AC25EC", VA = "0x1AC25EC")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000549")]
			[Address(RVA = "0x1AC248C", Offset = "0x1AC248C", VA = "0x1AC248C")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x600054A")]
			[Address(RVA = "0x1AC2A10", Offset = "0x1AC2A10", VA = "0x1AC2A10")]
			public void Solve()
			{
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0x1AC2C74", Offset = "0x1AC2C74", VA = "0x1AC2C74", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0x1AC2D7C", Offset = "0x1AC2D7C", VA = "0x1AC2D7C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x1AC2DC8", Offset = "0x1AC2DC8", VA = "0x1AC2DC8")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000097")]
		public class Locomotion
		{
			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7986F4", Offset = "0x7986F4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7986F4", Offset = "0x7986F4")]
			public float weight;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798748", Offset = "0x798748")]
			public float footDistance;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798780", Offset = "0x798780")]
			public float stepThreshold;

			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7987B8", Offset = "0x7987B8")]
			public float angleThreshold;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7987F0", Offset = "0x7987F0")]
			public float comAngleMlp;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798828", Offset = "0x798828")]
			public float maxVelocity;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798860", Offset = "0x798860")]
			public float velocityFactor;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798898", Offset = "0x798898")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x798898", Offset = "0x798898")]
			public float maxLegStretch;

			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7988F0", Offset = "0x7988F0")]
			public float rootSpeed;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798928", Offset = "0x798928")]
			public float stepSpeed;

			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798960", Offset = "0x798960")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798998", Offset = "0x798998")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7989D0", Offset = "0x7989D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7989D0", Offset = "0x7989D0")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798A28", Offset = "0x798A28")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798A60", Offset = "0x798A60")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798A98", Offset = "0x798A98")]
			public Vector3 offset;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798B10", Offset = "0x798B10")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798B48", Offset = "0x798B48")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x798B80", Offset = "0x798B80")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x1700008B")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x600054E")]
				[Address(RVA = "0x1AC2E30", Offset = "0x1AC2E30", VA = "0x1AC2E30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C710", Offset = "0x79C710")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600054F")]
				[Address(RVA = "0x1AC2E3C", Offset = "0x1AC2E3C", VA = "0x1AC2E3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C720", Offset = "0x79C720")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008C")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000555")]
				[Address(RVA = "0x1AC48C0", Offset = "0x1AC48C0", VA = "0x1AC48C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008D")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000556")]
				[Address(RVA = "0x1AC4900", Offset = "0x1AC4900", VA = "0x1AC4900")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008E")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000557")]
				[Address(RVA = "0x1AC4944", Offset = "0x1AC4944", VA = "0x1AC4944")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x1700008F")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000558")]
				[Address(RVA = "0x1AC4984", Offset = "0x1AC4984", VA = "0x1AC4984")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000550")]
			[Address(RVA = "0x1AC2E48", Offset = "0x1AC2E48", VA = "0x1AC2E48")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0x1AC30E8", Offset = "0x1AC30E8", VA = "0x1AC30E8")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000552")]
			[Address(RVA = "0x1AC32B8", Offset = "0x1AC32B8", VA = "0x1AC32B8")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0x1AC3500", Offset = "0x1AC3500", VA = "0x1AC3500")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000554")]
			[Address(RVA = "0x1AC35C4", Offset = "0x1AC35C4", VA = "0x1AC35C4")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000559")]
			[Address(RVA = "0x1AC4638", Offset = "0x1AC4638", VA = "0x1AC4638")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600055A")]
			[Address(RVA = "0x1AC4770", Offset = "0x1AC4770", VA = "0x1AC4770")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600055B")]
			[Address(RVA = "0x1AC47F4", Offset = "0x1AC47F4", VA = "0x1AC47F4")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x600055C")]
			[Address(RVA = "0x1AC49C8", Offset = "0x1AC49C8", VA = "0x1AC49C8")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000098")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798B90", Offset = "0x798B90")]
			public Transform headTarget;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798BC8", Offset = "0x798BC8")]
			public Transform pelvisTarget;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798C00", Offset = "0x798C00")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x798C00", Offset = "0x798C00")]
			public float positionWeight;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798C54", Offset = "0x798C54")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x798C54", Offset = "0x798C54")]
			public float rotationWeight;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798CA8", Offset = "0x798CA8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x798CA8", Offset = "0x798CA8")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798CFC", Offset = "0x798CFC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x798CFC", Offset = "0x798CFC")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798D50", Offset = "0x798D50")]
			public Transform chestGoal;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798D88", Offset = "0x798D88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x798D88", Offset = "0x798D88")]
			public float chestGoalWeight;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798DDC", Offset = "0x798DDC")]
			public float minHeadHeight;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798E14", Offset = "0x798E14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x798E14", Offset = "0x798E14")]
			public float bodyPosStiffness;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798E68", Offset = "0x798E68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x798E68", Offset = "0x798E68")]
			public float bodyRotStiffness;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798EBC", Offset = "0x798EBC")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x798EBC", Offset = "0x798EBC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x798EBC", Offset = "0x798EBC")]
			public float neckStiffness;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798F34", Offset = "0x798F34")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x798F34", Offset = "0x798F34")]
			public float rotateChestByHands;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798F88", Offset = "0x798F88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x798F88", Offset = "0x798F88")]
			public float chestClampWeight;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x798FDC", Offset = "0x798FDC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x798FDC", Offset = "0x798FDC")]
			public float headClampWeight;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799030", Offset = "0x799030")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799068", Offset = "0x799068")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x799068", Offset = "0x799068")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7990BC", Offset = "0x7990BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7990BC", Offset = "0x7990BC")]
			public float maxRootAngle;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public bool useFabrikPass;

			[NonSerialized]
			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7991F4", Offset = "0x7991F4")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			private Quaternion headRotation;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private int pelvisIndex;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
			private int spineIndex;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private int chestIndex;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private int neckIndex;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private int headIndex;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
			private float length;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private bool hasChest;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F1")]
			private bool hasNeck;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private float headHeight;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private float sizeMlp;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private Vector3 chestForward;

			[Token(Token = "0x17000090")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x600055D")]
				[Address(RVA = "0x1AC45B8", Offset = "0x1AC45B8", VA = "0x1AC45B8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000091")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600055E")]
				[Address(RVA = "0x1AC4AB4", Offset = "0x1AC4AB4", VA = "0x1AC4AB4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			public VirtualBone chest
			{
				[Token(Token = "0x600055F")]
				[Address(RVA = "0x1AC4AF4", Offset = "0x1AC4AF4", VA = "0x1AC4AF4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000093")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000560")]
				[Address(RVA = "0x1AC4B48", Offset = "0x1AC4B48", VA = "0x1AC4B48")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000094")]
			public VirtualBone head
			{
				[Token(Token = "0x6000561")]
				[Address(RVA = "0x1AC45F8", Offset = "0x1AC45F8", VA = "0x1AC45F8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000562")]
				[Address(RVA = "0x1AC4B88", Offset = "0x1AC4B88", VA = "0x1AC4B88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C730", Offset = "0x79C730")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000563")]
				[Address(RVA = "0x1AC4B9C", Offset = "0x1AC4B9C", VA = "0x1AC4B9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C740", Offset = "0x79C740")]
				private set
				{
				}
			}

			[Token(Token = "0x17000096")]
			public Vector3 ChestFwd
			{
				[Token(Token = "0x6000564")]
				[Address(RVA = "0x1AC4BB0", Offset = "0x1AC4BB0", VA = "0x1AC4BB0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000565")]
			[Address(RVA = "0x1AC4C0C", Offset = "0x1AC4C0C", VA = "0x1AC4C0C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000566")]
			[Address(RVA = "0x1AC55CC", Offset = "0x1AC55CC", VA = "0x1AC55CC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000567")]
			[Address(RVA = "0x1AC579C", Offset = "0x1AC579C", VA = "0x1AC579C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000568")]
			[Address(RVA = "0x1AC5B08", Offset = "0x1AC5B08", VA = "0x1AC5B08")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000569")]
			[Address(RVA = "0x1AC5FCC", Offset = "0x1AC5FCC", VA = "0x1AC5FCC")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x600056A")]
			[Address(RVA = "0x1AC66B0", Offset = "0x1AC66B0", VA = "0x1AC66B0")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x600056B")]
			[Address(RVA = "0x1AC6CF4", Offset = "0x1AC6CF4", VA = "0x1AC6CF4")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x600056C")]
			[Address(RVA = "0x1AC72C4", Offset = "0x1AC72C4", VA = "0x1AC72C4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600056D")]
			[Address(RVA = "0x1AC74A0", Offset = "0x1AC74A0", VA = "0x1AC74A0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0x1AC5D34", Offset = "0x1AC5D34", VA = "0x1AC5D34")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0x1AC6A30", Offset = "0x1AC6A30", VA = "0x1AC6A30")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0x1AC6380", Offset = "0x1AC6380", VA = "0x1AC6380")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0x1AC7538", Offset = "0x1AC7538", VA = "0x1AC7538")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000572")]
			[Address(RVA = "0x1AC6B20", Offset = "0x1AC6B20", VA = "0x1AC6B20")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000573")]
			[Address(RVA = "0x1AC6840", Offset = "0x1AC6840", VA = "0x1AC6840")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000574")]
			[Address(RVA = "0x1AC7724", Offset = "0x1AC7724", VA = "0x1AC7724")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000099")]
		public enum PositionOffset
		{
			[Token(Token = "0x40004DD")]
			Pelvis,
			[Token(Token = "0x40004DE")]
			Chest,
			[Token(Token = "0x40004DF")]
			Head,
			[Token(Token = "0x40004E0")]
			LeftHand,
			[Token(Token = "0x40004E1")]
			RightHand,
			[Token(Token = "0x40004E2")]
			LeftFoot,
			[Token(Token = "0x40004E3")]
			RightFoot,
			[Token(Token = "0x40004E4")]
			LeftHeel,
			[Token(Token = "0x40004E5")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x200009A")]
		public enum RotationOffset
		{
			[Token(Token = "0x40004E7")]
			Pelvis,
			[Token(Token = "0x40004E8")]
			Chest,
			[Token(Token = "0x40004E9")]
			Head
		}

		[Serializable]
		[Token(Token = "0x200009B")]
		public class VirtualBone
		{
			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000575")]
			[Address(RVA = "0x1ABEAF8", Offset = "0x1ABEAF8", VA = "0x1ABEAF8")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000576")]
			[Address(RVA = "0x1ABEB74", Offset = "0x1ABEB74", VA = "0x1ABEB74")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000577")]
			[Address(RVA = "0x1AC7884", Offset = "0x1AC7884", VA = "0x1AC7884")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000578")]
			[Address(RVA = "0x1AC0E38", Offset = "0x1AC0E38", VA = "0x1AC0E38")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000579")]
			[Address(RVA = "0x1AC1164", Offset = "0x1AC1164", VA = "0x1AC1164")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600057A")]
			[Address(RVA = "0x1AC7A08", Offset = "0x1AC7A08", VA = "0x1AC7A08")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600057B")]
			[Address(RVA = "0x1ABFE48", Offset = "0x1ABFE48", VA = "0x1ABFE48")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x600057C")]
			[Address(RVA = "0x1AC7B68", Offset = "0x1AC7B68", VA = "0x1AC7B68")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600057D")]
			[Address(RVA = "0x1AC0388", Offset = "0x1AC0388", VA = "0x1AC0388")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x600057E")]
			[Address(RVA = "0x1AC7C20", Offset = "0x1AC7C20", VA = "0x1AC7C20")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600057F")]
			[Address(RVA = "0x1AC6F7C", Offset = "0x1AC6F7C", VA = "0x1AC6F7C")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000580")]
			[Address(RVA = "0x1AC7D88", Offset = "0x1AC7D88", VA = "0x1AC7D88")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000581")]
			[Address(RVA = "0x1AC7DF8", Offset = "0x1AC7DF8", VA = "0x1AC7DF8")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796844", Offset = "0x796844")]
		public bool plantFeet;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79687C", Offset = "0x79687C")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79688C", Offset = "0x79688C")]
		public Spine spine;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7968C4", Offset = "0x7968C4")]
		public Arm leftArm;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7968FC", Offset = "0x7968FC")]
		public Arm rightArm;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796934", Offset = "0x796934")]
		public Leg leftLeg;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79696C", Offset = "0x79696C")]
		public Leg rightLeg;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7969A4", Offset = "0x7969A4")]
		public Locomotion locomotion;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Leg[] legs;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Arm[] arms;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 headPosition;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastOffset;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 debugPos1;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 debugPos2;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos3;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000049")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x1A86808", Offset = "0x1A86808", VA = "0x1A86808")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B8F0", Offset = "0x79B8F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x1A86810", Offset = "0x1A86810", VA = "0x1A86810")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B900", Offset = "0x79B900")]
			private set
			{
			}
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1A833B4", Offset = "0x1A833B4", VA = "0x1A833B4")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1A837D0", Offset = "0x1A837D0", VA = "0x1A837D0")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1A8367C", Offset = "0x1A8367C", VA = "0x1A8367C")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1A83F28", Offset = "0x1A83F28", VA = "0x1A83F28")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1A8406C", Offset = "0x1A8406C", VA = "0x1A8406C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1A8409C", Offset = "0x1A8409C", VA = "0x1A8409C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1A8414C", Offset = "0x1A8414C", VA = "0x1A8414C")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1A84234", Offset = "0x1A84234", VA = "0x1A84234")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1A84950", Offset = "0x1A84950", VA = "0x1A84950", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1A84AC0", Offset = "0x1A84AC0", VA = "0x1A84AC0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1A84C58", Offset = "0x1A84C58", VA = "0x1A84C58", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1A84CD4", Offset = "0x1A84CD4", VA = "0x1A84CD4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1A84D50", Offset = "0x1A84D50", VA = "0x1A84D50", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1A84F28", Offset = "0x1A84F28", VA = "0x1A84F28")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1A839FC", Offset = "0x1A839FC", VA = "0x1A839FC")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1A83AEC", Offset = "0x1A83AEC", VA = "0x1A83AEC")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1A83E08", Offset = "0x1A83E08", VA = "0x1A83E08")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1A84314", Offset = "0x1A84314", VA = "0x1A84314")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1A850E8", Offset = "0x1A850E8", VA = "0x1A850E8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1A85120", Offset = "0x1A85120", VA = "0x1A85120", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1A86104", Offset = "0x1A86104", VA = "0x1A86104")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1A84478", Offset = "0x1A84478", VA = "0x1A84478")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1A85180", Offset = "0x1A85180", VA = "0x1A85180")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1A862E8", Offset = "0x1A862E8", VA = "0x1A862E8")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1A86330", Offset = "0x1A86330", VA = "0x1A86330")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1A85FBC", Offset = "0x1A85FBC", VA = "0x1A85FBC")]
		private void Write()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1A86374", Offset = "0x1A86374", VA = "0x1A86374")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1A86818", Offset = "0x1A86818", VA = "0x1A86818")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7969DC", Offset = "0x7969DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7969DC", Offset = "0x7969DC")]
		public float weight;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796A30", Offset = "0x796A30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x796A30", Offset = "0x796A30")]
		public float parentChildCrossfade;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796A84", Offset = "0x796A84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x796A84", Offset = "0x796A84")]
		public float twistAngleOffset;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 twistAxis;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 axis;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform parent;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform child;

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x1937240", Offset = "0x1937240", VA = "0x1937240")]
		public void Relax()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x193755C", Offset = "0x193755C", VA = "0x193755C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x19378C4", Offset = "0x19378C4", VA = "0x19378C4")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1937948", Offset = "0x1937948", VA = "0x1937948")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x19379CC", Offset = "0x19379CC", VA = "0x19379CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1937AE4", Offset = "0x1937AE4", VA = "0x1937AE4")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class InteractionEffector
	{
		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x796AE0", Offset = "0x796AE0")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x796AF0", Offset = "0x796AF0")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x796B00", Offset = "0x796B00")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x1700004A")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x1927598", Offset = "0x1927598", VA = "0x1927598")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B910", Offset = "0x79B910")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x19275A0", Offset = "0x19275A0", VA = "0x19275A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B920", Offset = "0x79B920")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public bool isPaused
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x19275A8", Offset = "0x19275A8", VA = "0x19275A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B930", Offset = "0x79B930")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x19275B0", Offset = "0x19275B0", VA = "0x19275B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B940", Offset = "0x79B940")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x19275BC", Offset = "0x19275BC", VA = "0x19275BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B950", Offset = "0x79B950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x19275C4", Offset = "0x19275C4", VA = "0x19275C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B960", Offset = "0x79B960")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public bool inInteraction
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x19275CC", Offset = "0x19275CC", VA = "0x19275CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		public float progress
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x192996C", Offset = "0x192996C", VA = "0x192996C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1927638", Offset = "0x1927638", VA = "0x1927638")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x19276C4", Offset = "0x19276C4", VA = "0x19276C4")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1927764", Offset = "0x1927764", VA = "0x1927764")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x19278A4", Offset = "0x19278A4", VA = "0x19278A4")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1927B7C", Offset = "0x1927B7C", VA = "0x1927B7C")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1927C38", Offset = "0x1927C38", VA = "0x1927C38")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1927C90", Offset = "0x1927C90", VA = "0x1927C90")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1928668", Offset = "0x1928668", VA = "0x1928668")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x19290C4", Offset = "0x19290C4", VA = "0x19290C4")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1929308", Offset = "0x1929308", VA = "0x1929308")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1929818", Offset = "0x1929818", VA = "0x1929818")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1929ACC", Offset = "0x1929ACC", VA = "0x1929ACC")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class InteractionLookAt
	{
		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796B10", Offset = "0x796B10")]
		public LookAtIK ik;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796B48", Offset = "0x796B48")]
		public float lerpSpeed;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796B80", Offset = "0x796B80")]
		public float weightSpeed;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1929CBC", Offset = "0x1929CBC", VA = "0x1929CBC")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1929DD8", Offset = "0x1929DD8", VA = "0x1929DD8")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1929E7C", Offset = "0x1929E7C", VA = "0x1929E7C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x192A4B4", Offset = "0x192A4B4", VA = "0x192A4B4")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x192A5A8", Offset = "0x192A5A8", VA = "0x192A5A8")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x192A670", Offset = "0x192A670", VA = "0x192A670")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x794500", Offset = "0x794500")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x794500", Offset = "0x794500")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200009C")]
		public class InteractionEvent
		{
			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799204", Offset = "0x799204")]
			public float time;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79923C", Offset = "0x79923C")]
			public bool pause;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799274", Offset = "0x799274")]
			public bool pickUp;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7992AC", Offset = "0x7992AC")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7992E4", Offset = "0x7992E4")]
			public Message[] messages;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79931C", Offset = "0x79931C")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000582")]
			[Address(RVA = "0x1AC85A4", Offset = "0x1AC85A4", VA = "0x1AC85A4")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0x1AC8778", Offset = "0x1AC8778", VA = "0x1AC8778")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009D")]
		public class Message
		{
			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799354", Offset = "0x799354")]
			public string function;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79938C", Offset = "0x79938C")]
			public GameObject recipient;

			[Token(Token = "0x40004F9")]
			private const string empty = "";

			[Token(Token = "0x6000584")]
			[Address(RVA = "0x1AC8674", Offset = "0x1AC8674", VA = "0x1AC8674")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000585")]
			[Address(RVA = "0x1AC8780", Offset = "0x1AC8780", VA = "0x1AC8780")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009E")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7993C4", Offset = "0x7993C4")]
			public Animator animator;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7993FC", Offset = "0x7993FC")]
			public Animation animation;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799434", Offset = "0x799434")]
			public string animationState;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79946C", Offset = "0x79946C")]
			public float crossfadeTime;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7994A4", Offset = "0x7994A4")]
			public int layer;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7994DC", Offset = "0x7994DC")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000500")]
			private const string empty = "";

			[Token(Token = "0x6000586")]
			[Address(RVA = "0x1AC8310", Offset = "0x1AC8310", VA = "0x1AC8310")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000587")]
			[Address(RVA = "0x1AC8400", Offset = "0x1AC8400", VA = "0x1AC8400")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000588")]
			[Address(RVA = "0x1AC84B4", Offset = "0x1AC84B4", VA = "0x1AC84B4")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000589")]
			[Address(RVA = "0x1AC8590", Offset = "0x1AC8590", VA = "0x1AC8590")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009F")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20000BE")]
			public enum Type
			{
				[Token(Token = "0x4000590")]
				PositionWeight,
				[Token(Token = "0x4000591")]
				RotationWeight,
				[Token(Token = "0x4000592")]
				PositionOffsetX,
				[Token(Token = "0x4000593")]
				PositionOffsetY,
				[Token(Token = "0x4000594")]
				PositionOffsetZ,
				[Token(Token = "0x4000595")]
				Pull,
				[Token(Token = "0x4000596")]
				Reach,
				[Token(Token = "0x4000597")]
				RotateBoneWeight,
				[Token(Token = "0x4000598")]
				Push,
				[Token(Token = "0x4000599")]
				PushParent,
				[Token(Token = "0x400059A")]
				PoserWeight
			}

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799514", Offset = "0x799514")]
			public Type type;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79954C", Offset = "0x79954C")]
			public AnimationCurve curve;

			[Token(Token = "0x600058A")]
			[Address(RVA = "0x1C8E08C", Offset = "0x1C8E08C", VA = "0x1C8E08C")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600058B")]
			[Address(RVA = "0x1C8E0B8", Offset = "0x1C8E0B8", VA = "0x1C8E0B8")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A0")]
		public class Multiplier
		{
			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799584", Offset = "0x799584")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7995BC", Offset = "0x7995BC")]
			public float multiplier;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7995F4", Offset = "0x7995F4")]
			public WeightCurve.Type result;

			[Token(Token = "0x600058C")]
			[Address(RVA = "0x1C8E050", Offset = "0x1C8E050", VA = "0x1C8E050")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600058D")]
			[Address(RVA = "0x1C8E0A8", Offset = "0x1C8E0A8", VA = "0x1C8E0A8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796BC8", Offset = "0x796BC8")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796C00", Offset = "0x796C00")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796C38", Offset = "0x796C38")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x796C70", Offset = "0x796C70")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x796C80", Offset = "0x796C80")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700004F")]
		public float length
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x192A834", Offset = "0x192A834", VA = "0x192A834")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79BAC0", Offset = "0x79BAC0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x192A83C", Offset = "0x192A83C", VA = "0x192A83C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79BAD0", Offset = "0x79BAD0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x192A844", Offset = "0x192A844", VA = "0x192A844")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79BAE0", Offset = "0x79BAE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x192A84C", Offset = "0x192A84C", VA = "0x192A84C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79BAF0", Offset = "0x79BAF0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x192AA14", Offset = "0x192AA14", VA = "0x192AA14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public Transform targetsRoot
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x19299A8", Offset = "0x19299A8", VA = "0x19299A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x192A684", Offset = "0x192A684", VA = "0x192A684")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B970", Offset = "0x79B970")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x192A6CC", Offset = "0x192A6CC", VA = "0x192A6CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B9A8", Offset = "0x79B9A8")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x192A714", Offset = "0x192A714", VA = "0x192A714")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79B9E0", Offset = "0x79B9E0")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x192A75C", Offset = "0x192A75C", VA = "0x192A75C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BA18", Offset = "0x79BA18")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x192A7A4", Offset = "0x192A7A4", VA = "0x192A7A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BA50", Offset = "0x79BA50")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x192A7EC", Offset = "0x192A7EC", VA = "0x192A7EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BA88", Offset = "0x79BA88")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x192A854", Offset = "0x192A854", VA = "0x192A854")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x192AAA0", Offset = "0x192AAA0", VA = "0x192AAA0")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x19281E4", Offset = "0x19281E4", VA = "0x19281E4")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x192AC2C", Offset = "0x192AC2C", VA = "0x192AC2C")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1928090", Offset = "0x1928090", VA = "0x1928090")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x19281DC", Offset = "0x19281DC", VA = "0x19281DC")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1928C70", Offset = "0x1928C70", VA = "0x1928C70")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1929538", Offset = "0x1929538", VA = "0x1929538")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x192B1BC", Offset = "0x192B1BC", VA = "0x192B1BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x192AD14", Offset = "0x192AD14", VA = "0x192AD14")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x192AC34", Offset = "0x192AC34", VA = "0x192AC34")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x192B154", Offset = "0x192B154", VA = "0x192B154")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x192B1C0", Offset = "0x192B1C0", VA = "0x192B1C0")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x192B228", Offset = "0x192B228", VA = "0x192B228")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BB00", Offset = "0x79BB00")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x192B270", Offset = "0x192B270", VA = "0x192B270")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BB38", Offset = "0x79BB38")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x192B2B8", Offset = "0x192B2B8", VA = "0x192B2B8")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x794560", Offset = "0x794560")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x794560", Offset = "0x794560")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000A1")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000A2")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796C90", Offset = "0x796C90")]
		public string targetTag;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796CC8", Offset = "0x796CC8")]
		public float fadeInTime;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796D00", Offset = "0x796D00")]
		public float speed;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796D38", Offset = "0x796D38")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x796D70", Offset = "0x796D70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796D70", Offset = "0x796D70")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x796D70", Offset = "0x796D70")]
		public Collider characterCollider;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796DF4", Offset = "0x796DF4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x796DF4", Offset = "0x796DF4")]
		public Transform FPSCamera;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796E54", Offset = "0x796E54")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796E8C", Offset = "0x796E8C")]
		public float camRaycastDistance;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x796EC4", Offset = "0x796EC4")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x796ED4", Offset = "0x796ED4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796ED4", Offset = "0x796ED4")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796F34", Offset = "0x796F34")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x17000053")]
		public bool inInteraction
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x192B4C4", Offset = "0x192B4C4", VA = "0x192B4C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x192D164", Offset = "0x192D164", VA = "0x192D164")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x192D16C", Offset = "0x192D16C", VA = "0x192D16C")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x192D174", Offset = "0x192D174", VA = "0x192D174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79BCC0", Offset = "0x79BCC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x192D17C", Offset = "0x192D17C", VA = "0x192D17C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79BCD0", Offset = "0x79BCD0")]
			private set
			{
			}
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x192B314", Offset = "0x192B314", VA = "0x192B314")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BB70", Offset = "0x79BB70")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x192B35C", Offset = "0x192B35C", VA = "0x192B35C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BBA8", Offset = "0x79BBA8")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x192B3A4", Offset = "0x192B3A4", VA = "0x192B3A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BBE0", Offset = "0x79BBE0")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x192B3EC", Offset = "0x192B3EC", VA = "0x192B3EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BC18", Offset = "0x79BC18")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x192B434", Offset = "0x192B434", VA = "0x192B434")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BC50", Offset = "0x79BC50")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x192B47C", Offset = "0x192B47C", VA = "0x192B47C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BC88", Offset = "0x79BC88")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x192B664", Offset = "0x192B664", VA = "0x192B664")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x192B730", Offset = "0x192B730", VA = "0x192B730")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x192B7FC", Offset = "0x192B7FC", VA = "0x192B7FC")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x192B8A8", Offset = "0x192B8A8", VA = "0x192B8A8")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x192B9A0", Offset = "0x192B9A0", VA = "0x192B9A0")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x192BAB8", Offset = "0x192BAB8", VA = "0x192BAB8")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x192BB48", Offset = "0x192BB48", VA = "0x192BB48")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x192BBD8", Offset = "0x192BBD8", VA = "0x192BBD8")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x192BC68", Offset = "0x192BC68", VA = "0x192BC68")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x192BCDC", Offset = "0x192BCDC", VA = "0x192BCDC")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x192BD50", Offset = "0x192BD50", VA = "0x192BD50")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x192BDB8", Offset = "0x192BDB8", VA = "0x192BDB8")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x192BE44", Offset = "0x192BE44", VA = "0x192BE44")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x192BEF8", Offset = "0x192BEF8", VA = "0x192BEF8")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x192BFDC", Offset = "0x192BFDC", VA = "0x192BFDC")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x192C2B0", Offset = "0x192C2B0", VA = "0x192C2B0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x192C490", Offset = "0x192C490", VA = "0x192C490")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x192C724", Offset = "0x192C724", VA = "0x192C724")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x192C9FC", Offset = "0x192C9FC", VA = "0x192C9FC")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x192CA40", Offset = "0x192CA40", VA = "0x192CA40")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x192CAB8", Offset = "0x192CAB8", VA = "0x192CAB8")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x192CBD4", Offset = "0x192CBD4", VA = "0x192CBD4")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x192CD78", Offset = "0x192CD78", VA = "0x192CD78")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x192D01C", Offset = "0x192D01C", VA = "0x192D01C")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x192C838", Offset = "0x192C838", VA = "0x192C838")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x192D184", Offset = "0x192D184", VA = "0x192D184", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x192D8EC", Offset = "0x192D8EC", VA = "0x192D8EC")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x192D90C", Offset = "0x192D90C", VA = "0x192D90C")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x192D928", Offset = "0x192D928", VA = "0x192D928")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x192D944", Offset = "0x192D944", VA = "0x192D944")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x192D9A4", Offset = "0x192D9A4", VA = "0x192D9A4")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x192DAE0", Offset = "0x192DAE0", VA = "0x192DAE0")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x192DBF0", Offset = "0x192DBF0", VA = "0x192DBF0")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x192DF8C", Offset = "0x192DF8C", VA = "0x192DF8C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x192E08C", Offset = "0x192E08C", VA = "0x192E08C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x192E31C", Offset = "0x192E31C", VA = "0x192E31C")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x192D650", Offset = "0x192D650", VA = "0x192D650")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x192E458", Offset = "0x192E458", VA = "0x192E458")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x192E580", Offset = "0x192E580", VA = "0x192E580")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x192E638", Offset = "0x192E638", VA = "0x192E638")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x192E730", Offset = "0x192E730", VA = "0x192E730")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x192E748", Offset = "0x192E748", VA = "0x192E748")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x192B570", Offset = "0x192B570", VA = "0x192B570")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x192C184", Offset = "0x192C184", VA = "0x192C184")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x192EAB0", Offset = "0x192EAB0", VA = "0x192EAB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BCE0", Offset = "0x79BCE0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x192EAF8", Offset = "0x192EAF8", VA = "0x192EAF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BD18", Offset = "0x79BD18")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x192EB40", Offset = "0x192EB40", VA = "0x192EB40")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7945C0", Offset = "0x7945C0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7945C0", Offset = "0x7945C0")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A3")]
		public class Multiplier
		{
			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79962C", Offset = "0x79962C")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799664", Offset = "0x799664")]
			public float multiplier;

			[Token(Token = "0x6000596")]
			[Address(RVA = "0x1C8E724", Offset = "0x1C8E724", VA = "0x1C8E724")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796F6C", Offset = "0x796F6C")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796FA4", Offset = "0x796FA4")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796FDC", Offset = "0x796FDC")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797014", Offset = "0x797014")]
		public Transform pivot;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79704C", Offset = "0x79704C")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797084", Offset = "0x797084")]
		public float twistWeight;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7970BC", Offset = "0x7970BC")]
		public float swingWeight;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7970F4", Offset = "0x7970F4")]
		public bool rotateOnce;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x192EEE4", Offset = "0x192EEE4", VA = "0x192EEE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BD50", Offset = "0x79BD50")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x192EF2C", Offset = "0x192EF2C", VA = "0x192EF2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BD88", Offset = "0x79BD88")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x192EF74", Offset = "0x192EF74", VA = "0x192EF74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BDC0", Offset = "0x79BDC0")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x192EFBC", Offset = "0x192EFBC", VA = "0x192EFBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BDF8", Offset = "0x79BDF8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x192F004", Offset = "0x192F004", VA = "0x192F004")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BE30", Offset = "0x79BE30")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x192F04C", Offset = "0x192F04C", VA = "0x192F04C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BE68", Offset = "0x79BE68")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x192ACA4", Offset = "0x192ACA4", VA = "0x192ACA4")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1929A34", Offset = "0x1929A34", VA = "0x1929A34")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1928298", Offset = "0x1928298", VA = "0x1928298")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x192F174", Offset = "0x192F174", VA = "0x192F174")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BEA0", Offset = "0x79BEA0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x192F1BC", Offset = "0x192F1BC", VA = "0x192F1BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BED8", Offset = "0x79BED8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x192F204", Offset = "0x192F204", VA = "0x192F204")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x794620", Offset = "0x794620")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x794620", Offset = "0x794620")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A4")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79969C", Offset = "0x79969C")]
			public bool use;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7996D4", Offset = "0x7996D4")]
			public Vector2 offset;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79970C", Offset = "0x79970C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x79970C", Offset = "0x79970C")]
			public float angleOffset;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799768", Offset = "0x799768")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x799768", Offset = "0x799768")]
			public float maxAngle;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7997C0", Offset = "0x7997C0")]
			public float radius;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7997F8", Offset = "0x7997F8")]
			public bool orbit;

			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799830", Offset = "0x799830")]
			public bool fixYAxis;

			[Token(Token = "0x17000097")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000597")]
				[Address(RVA = "0x1C8EA94", Offset = "0x1C8EA94", VA = "0x1C8EA94")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000098")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000598")]
				[Address(RVA = "0x1C8EAA0", Offset = "0x1C8EAA0", VA = "0x1C8EAA0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000599")]
			[Address(RVA = "0x1C8EB28", Offset = "0x1C8EB28", VA = "0x1C8EB28")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0x1C8EF6C", Offset = "0x1C8EF6C", VA = "0x1C8EF6C")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A5")]
		public class CameraPosition
		{
			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799868", Offset = "0x799868")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7998A0", Offset = "0x7998A0")]
			public Vector3 direction;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7998D8", Offset = "0x7998D8")]
			public float maxDistance;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799910", Offset = "0x799910")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x799910", Offset = "0x799910")]
			public float maxAngle;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799968", Offset = "0x799968")]
			public bool fixYAxis;

			[Token(Token = "0x600059B")]
			[Address(RVA = "0x1C8E72C", Offset = "0x1C8E72C", VA = "0x1C8E72C")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600059C")]
			[Address(RVA = "0x1C8E820", Offset = "0x1C8E820", VA = "0x1C8E820")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600059D")]
			[Address(RVA = "0x1C8EA48", Offset = "0x1C8EA48", VA = "0x1C8EA48")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A6")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20000BF")]
			public class Interaction
			{
				[Token(Token = "0x400059B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A500", Offset = "0x79A500")]
				public InteractionObject interactionObject;

				[Token(Token = "0x400059C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A538", Offset = "0x79A538")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000603")]
				[Address(RVA = "0x1C91E00", Offset = "0x1C91E00", VA = "0x1C91E00")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799A10", Offset = "0x799A10")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799A48", Offset = "0x799A48")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799A80", Offset = "0x799A80")]
			public Interaction[] interactions;

			[Token(Token = "0x600059E")]
			[Address(RVA = "0x1C8EF80", Offset = "0x1C8EF80", VA = "0x1C8EF80")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x600059F")]
			[Address(RVA = "0x1C8F034", Offset = "0x1C8F034", VA = "0x1C8F034")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79712C", Offset = "0x79712C")]
		public Range[] ranges;

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x192F24C", Offset = "0x192F24C", VA = "0x192F24C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BF10", Offset = "0x79BF10")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x192F294", Offset = "0x192F294", VA = "0x192F294")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BF48", Offset = "0x79BF48")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x192F2DC", Offset = "0x192F2DC", VA = "0x192F2DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BF80", Offset = "0x79BF80")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x192F324", Offset = "0x192F324", VA = "0x192F324")]
		private void Start()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x192DDBC", Offset = "0x192DDBC", VA = "0x192DDBC")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x192F328", Offset = "0x192F328", VA = "0x192F328")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000A7")]
		public class Map
		{
			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x1AB9580", Offset = "0x1AB9580", VA = "0x1AB9580")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x1AB95BC", Offset = "0x1AB95BC", VA = "0x1AB95BC")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x1AB960C", Offset = "0x1AB960C", VA = "0x1AB960C")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x1AB9658", Offset = "0x1AB9658", VA = "0x1AB9658")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1A4E228", Offset = "0x1A4E228", VA = "0x1A4E228", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79BFB8", Offset = "0x79BFB8")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1A4E5A4", Offset = "0x1A4E5A4", VA = "0x1A4E5A4", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1A4E5A8", Offset = "0x1A4E5A8", VA = "0x1A4E5A8", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1A4E6B0", Offset = "0x1A4E6B0", VA = "0x1A4E6B0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1A4E538", Offset = "0x1A4E538", VA = "0x1A4E538")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1A4E498", Offset = "0x1A4E498", VA = "0x1A4E498")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1A4E71C", Offset = "0x1A4E71C", VA = "0x1A4E71C")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _poseRoot;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] children;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1A54C04", Offset = "0x1A54C04", VA = "0x1A54C04", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1A54CD0", Offset = "0x1A54CD0", VA = "0x1A54CD0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1A54E8C", Offset = "0x1A54E8C", VA = "0x1A54E8C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1A54F88", Offset = "0x1A54F88", VA = "0x1A54F88", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1A54D28", Offset = "0x1A54D28", VA = "0x1A54D28")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1A552E8", Offset = "0x1A552E8", VA = "0x1A552E8")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x797164", Offset = "0x797164")]
		public float weight;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x79717C", Offset = "0x79717C")]
		public float localRotationWeight;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x797194", Offset = "0x797194")]
		public float localPositionWeight;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60003FC")]
		public abstract void AutoMapping();

		[Token(Token = "0x60003FD")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60003FE")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60003FF")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1930D38", Offset = "0x1930D38", VA = "0x1930D38", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1930D8C", Offset = "0x1930D8C", VA = "0x1930D8C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1930DC8", Offset = "0x1930DC8", VA = "0x1930DC8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1930DE0", Offset = "0x1930DE0", VA = "0x1930DE0")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x794680", Offset = "0x794680")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000A8")]
		public class Rigidbone
		{
			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x1C8FC94", Offset = "0x1C8FC94", VA = "0x1C8FC94")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x1C8FE04", Offset = "0x1C8FE04", VA = "0x1C8FE04")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x1C8FEE4", Offset = "0x1C8FEE4", VA = "0x1C8FEE4")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000A9")]
		public class Child
		{
			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x1C8FAA4", Offset = "0x1C8FAA4", VA = "0x1C8FAA4")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x1C8FB04", Offset = "0x1C8FB04", VA = "0x1C8FB04")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x1C8FC44", Offset = "0x1C8FC44", VA = "0x1C8FC44")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x794870", Offset = "0x794870")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x17000099")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005AD")]
				[Address(RVA = "0x1C8FA54", Offset = "0x1C8FA54", VA = "0x1C8FA54", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005AF")]
				[Address(RVA = "0x1C8FA9C", Offset = "0x1C8FA9C", VA = "0x1C8FA9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x1C8F838", Offset = "0x1C8F838", VA = "0x1C8F838")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x1C8F864", Offset = "0x1C8F864", VA = "0x1C8F864", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x1C8F868", Offset = "0x1C8F868", VA = "0x1C8F868", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x1C8FA5C", Offset = "0x1C8FA5C", VA = "0x1C8FA5C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7971AC", Offset = "0x7971AC")]
		public IK ik;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7971E4", Offset = "0x7971E4")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79721C", Offset = "0x79721C")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797254", Offset = "0x797254")]
		public float applyVelocity;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79728C", Offset = "0x79728C")]
		public float applyAngularVelocity;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000056")]
		private bool isRagdoll
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x19315F8", Offset = "0x19315F8", VA = "0x19315F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		private bool ikUsed
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x1931F80", Offset = "0x1931F80", VA = "0x1931F80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x19315C0", Offset = "0x19315C0", VA = "0x19315C0")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1931670", Offset = "0x1931670", VA = "0x1931670")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x19317A0", Offset = "0x19317A0", VA = "0x19317A0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1931734", Offset = "0x1931734", VA = "0x1931734")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x79BFF0", Offset = "0x79BFF0")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1931BBC", Offset = "0x1931BBC", VA = "0x1931BBC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1931E08", Offset = "0x1931E08", VA = "0x1931E08")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1931EC4", Offset = "0x1931EC4", VA = "0x1931EC4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1932100", Offset = "0x1932100", VA = "0x1932100")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1931F44", Offset = "0x1931F44", VA = "0x1931F44")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x19320BC", Offset = "0x19320BC", VA = "0x19320BC")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x19321A0", Offset = "0x19321A0", VA = "0x19321A0")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1932134", Offset = "0x1932134", VA = "0x1932134")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x19316C8", Offset = "0x19316C8", VA = "0x19316C8")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1931E48", Offset = "0x1931E48", VA = "0x1931E48")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x19323CC", Offset = "0x19323CC", VA = "0x19323CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x19324E4", Offset = "0x19324E4", VA = "0x19324E4")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000058")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x19336BC", Offset = "0x19336BC", VA = "0x19336BC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000059")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x19336C8", Offset = "0x19336C8", VA = "0x19336C8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x19333E0", Offset = "0x19333E0", VA = "0x19333E0")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1933424", Offset = "0x1933424", VA = "0x1933424")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1933614", Offset = "0x1933614", VA = "0x1933614")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1933684", Offset = "0x1933684", VA = "0x1933684")]
		public void Disable()
		{
		}

		[Token(Token = "0x600041C")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x193353C", Offset = "0x193353C", VA = "0x193353C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x19336E4", Offset = "0x19336E4", VA = "0x19336E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x19336E8", Offset = "0x19336E8", VA = "0x19336E8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1933718", Offset = "0x1933718", VA = "0x1933718")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1933794", Offset = "0x1933794", VA = "0x1933794")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1933928", Offset = "0x1933928", VA = "0x1933928")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1933998", Offset = "0x1933998", VA = "0x1933998")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7946E0", Offset = "0x7946E0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7946E0", Offset = "0x7946E0")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7972D4", Offset = "0x7972D4")]
		public float limit;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7972F0", Offset = "0x7972F0")]
		public float twistLimit;

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x19339CC", Offset = "0x19339CC", VA = "0x19339CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79C050", Offset = "0x79C050")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1933A14", Offset = "0x1933A14", VA = "0x1933A14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79C088", Offset = "0x79C088")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1933A5C", Offset = "0x1933A5C", VA = "0x1933A5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79C0C0", Offset = "0x79C0C0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1933AA4", Offset = "0x1933AA4", VA = "0x1933AA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79C0F8", Offset = "0x79C0F8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1933AEC", Offset = "0x1933AEC", VA = "0x1933AEC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1933B30", Offset = "0x1933B30", VA = "0x1933B30")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1933CF0", Offset = "0x1933CF0", VA = "0x1933CF0")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x794740", Offset = "0x794740")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x794740", Offset = "0x794740")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1933D30", Offset = "0x1933D30", VA = "0x1933D30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79C130", Offset = "0x79C130")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1933D78", Offset = "0x1933D78", VA = "0x1933D78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79C168", Offset = "0x79C168")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1933DC0", Offset = "0x1933DC0", VA = "0x1933DC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79C1A0", Offset = "0x79C1A0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1933E08", Offset = "0x1933E08", VA = "0x1933E08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79C1D8", Offset = "0x79C1D8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1933E50", Offset = "0x1933E50", VA = "0x1933E50", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1933E78", Offset = "0x1933E78", VA = "0x1933E78")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1934074", Offset = "0x1934074", VA = "0x1934074")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7947A0", Offset = "0x7947A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7947A0", Offset = "0x7947A0")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000AB")]
		public class ReachCone
		{
			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x1700009B")]
			public Vector3 o
			{
				[Token(Token = "0x60005B0")]
				[Address(RVA = "0x1C902EC", Offset = "0x1C902EC", VA = "0x1C902EC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009C")]
			public Vector3 a
			{
				[Token(Token = "0x60005B1")]
				[Address(RVA = "0x1C90324", Offset = "0x1C90324", VA = "0x1C90324")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009D")]
			public Vector3 b
			{
				[Token(Token = "0x60005B2")]
				[Address(RVA = "0x1C90360", Offset = "0x1C90360", VA = "0x1C90360")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009E")]
			public Vector3 c
			{
				[Token(Token = "0x60005B3")]
				[Address(RVA = "0x1C9039C", Offset = "0x1C9039C", VA = "0x1C9039C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009F")]
			public bool isValid
			{
				[Token(Token = "0x60005B5")]
				[Address(RVA = "0x1C90514", Offset = "0x1C90514", VA = "0x1C90514")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x1C903D8", Offset = "0x1C903D8", VA = "0x1C903D8")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x1C90524", Offset = "0x1C90524", VA = "0x1C90524")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AC")]
		public class LimitPoint
		{
			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x1C902B0", Offset = "0x1C902B0", VA = "0x1C902B0")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x79731C", Offset = "0x79731C")]
		public float twistLimit;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x797338", Offset = "0x797338")]
		public int smoothIterations;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x19340CC", Offset = "0x19340CC", VA = "0x19340CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79C210", Offset = "0x79C210")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1934114", Offset = "0x1934114", VA = "0x1934114")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79C248", Offset = "0x79C248")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x193415C", Offset = "0x193415C", VA = "0x193415C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79C280", Offset = "0x79C280")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x19341A4", Offset = "0x19341A4", VA = "0x19341A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79C2B8", Offset = "0x79C2B8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x19341EC", Offset = "0x19341EC", VA = "0x19341EC")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1934688", Offset = "0x1934688", VA = "0x1934688", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x193471C", Offset = "0x193471C", VA = "0x193471C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1934C40", Offset = "0x1934C40", VA = "0x1934C40")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1934284", Offset = "0x1934284", VA = "0x1934284")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1934FC0", Offset = "0x1934FC0", VA = "0x1934FC0")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x19353CC", Offset = "0x19353CC", VA = "0x19353CC")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1935410", Offset = "0x1935410", VA = "0x1935410")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1935470", Offset = "0x1935470", VA = "0x1935470")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x19349D4", Offset = "0x19349D4", VA = "0x19349D4")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x19354DC", Offset = "0x19354DC", VA = "0x19354DC")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x19355B8", Offset = "0x19355B8", VA = "0x19355B8")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x794800", Offset = "0x794800")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x794800", Offset = "0x794800")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7973F8", Offset = "0x7973F8")]
		public float twistLimit;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x193562C", Offset = "0x193562C", VA = "0x193562C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79C2F0", Offset = "0x79C2F0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1935674", Offset = "0x1935674", VA = "0x1935674")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79C328", Offset = "0x79C328")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x19356BC", Offset = "0x19356BC", VA = "0x19356BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79C360", Offset = "0x79C360")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1935704", Offset = "0x1935704", VA = "0x1935704")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x79C398", Offset = "0x79C398")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x193574C", Offset = "0x193574C", VA = "0x193574C")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1935768", Offset = "0x1935768", VA = "0x1935768", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x19357AC", Offset = "0x19357AC", VA = "0x19357AC")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x19359D0", Offset = "0x19359D0", VA = "0x19359D0")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79744C", Offset = "0x79744C")]
		public AimIK ik;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797484", Offset = "0x797484")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x797484", Offset = "0x797484")]
		public float weight;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7974D8", Offset = "0x7974D8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7974D8", Offset = "0x7974D8")]
		public Transform target;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797538", Offset = "0x797538")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797570", Offset = "0x797570")]
		public float weightSmoothTime;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7975A8", Offset = "0x7975A8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7975A8", Offset = "0x7975A8")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797608", Offset = "0x797608")]
		public float maxRadiansDelta;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797640", Offset = "0x797640")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797678", Offset = "0x797678")]
		public float slerpSpeed;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7976B0", Offset = "0x7976B0")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7976E8", Offset = "0x7976E8")]
		public float minDistance;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797720", Offset = "0x797720")]
		public Vector3 offset;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x797758", Offset = "0x797758")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797758", Offset = "0x797758")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x797758", Offset = "0x797758")]
		public float maxRootAngle;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7977D4", Offset = "0x7977D4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7977D4", Offset = "0x7977D4")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797834", Offset = "0x797834")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform lastTarget;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float switchWeight;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float switchWeightV;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float weightV;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 dir;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x1700005A")]
		private Vector3 pivot
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x1963284", Offset = "0x1963284", VA = "0x1963284")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x19631FC", Offset = "0x19631FC", VA = "0x19631FC")]
		private void Start()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1963314", Offset = "0x1963314", VA = "0x1963314")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1963850", Offset = "0x1963850", VA = "0x1963850")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x196393C", Offset = "0x196393C", VA = "0x196393C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1963B34", Offset = "0x1963B34", VA = "0x1963B34")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000AD")]
		public class Pose
		{
			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x1AB8A70", Offset = "0x1AB8A70", VA = "0x1AB8A70")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x1AB8BFC", Offset = "0x1AB8BFC", VA = "0x1AB8BFC")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x1AB8C04", Offset = "0x1AB8C04", VA = "0x1AB8C04")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1963D88", Offset = "0x1963D88", VA = "0x1963D88")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1963E68", Offset = "0x1963E68", VA = "0x1963E68")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1963ED4", Offset = "0x1963ED4", VA = "0x1963ED4")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000AE")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000C0")]
			public class EffectorLink
			{
				[Token(Token = "0x400059D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A570", Offset = "0x79A570")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400059E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A5A8", Offset = "0x79A5A8")]
				public float weight;

				[Token(Token = "0x6000604")]
				[Address(RVA = "0x1C919E4", Offset = "0x1C919E4", VA = "0x1C919E4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799AB8", Offset = "0x799AB8")]
			public Transform transform;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799AF0", Offset = "0x799AF0")]
			public Transform relativeTo;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799B28", Offset = "0x799B28")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799B60", Offset = "0x799B60")]
			public float verticalWeight;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799B98", Offset = "0x799B98")]
			public float horizontalWeight;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799BD0", Offset = "0x799BD0")]
			public float speed;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x1AB8C20", Offset = "0x1AB8C20", VA = "0x1AB8C20")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x1AB8F4C", Offset = "0x1AB8F4C", VA = "0x1AB8F4C")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x1AB8F5C", Offset = "0x1AB8F5C", VA = "0x1AB8F5C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79786C", Offset = "0x79786C")]
		public Body[] bodies;

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1963F38", Offset = "0x1963F38", VA = "0x1963F38", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1964084", Offset = "0x1964084", VA = "0x1964084")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7978A4", Offset = "0x7978A4")]
		public float tiltSpeed;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7978DC", Offset = "0x7978DC")]
		public float tiltSensitivity;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797914", Offset = "0x797914")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79794C", Offset = "0x79794C")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x196C234", Offset = "0x196C234", VA = "0x196C234", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x196C27C", Offset = "0x196C27C", VA = "0x196C27C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x196C434", Offset = "0x196C434", VA = "0x196C434")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000AF")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799C08", Offset = "0x799C08")]
			public string name;

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799C40", Offset = "0x799C40")]
			public Collider collider;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799C78", Offset = "0x799C78")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x799CC4", Offset = "0x799CC4")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x799CD4", Offset = "0x799CD4")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x799CE4", Offset = "0x799CE4")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x799CF4", Offset = "0x799CF4")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A0")]
			public bool inProgress
			{
				[Token(Token = "0x60005BE")]
				[Address(RVA = "0x1ABAD48", Offset = "0x1ABAD48", VA = "0x1ABAD48")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A1")]
			protected float crossFader
			{
				[Token(Token = "0x60005BF")]
				[Address(RVA = "0x1ABAD5C", Offset = "0x1ABAD5C", VA = "0x1ABAD5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C7A0", Offset = "0x79C7A0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005C0")]
				[Address(RVA = "0x1ABAD64", Offset = "0x1ABAD64", VA = "0x1ABAD64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C7B0", Offset = "0x79C7B0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			protected float timer
			{
				[Token(Token = "0x60005C1")]
				[Address(RVA = "0x1ABAD6C", Offset = "0x1ABAD6C", VA = "0x1ABAD6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C7C0", Offset = "0x79C7C0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005C2")]
				[Address(RVA = "0x1ABAD74", Offset = "0x1ABAD74", VA = "0x1ABAD74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C7D0", Offset = "0x79C7D0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A3")]
			protected Vector3 force
			{
				[Token(Token = "0x60005C3")]
				[Address(RVA = "0x1ABAD7C", Offset = "0x1ABAD7C", VA = "0x1ABAD7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C7E0", Offset = "0x79C7E0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005C4")]
				[Address(RVA = "0x1ABAD88", Offset = "0x1ABAD88", VA = "0x1ABAD88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C7F0", Offset = "0x79C7F0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A4")]
			protected Vector3 point
			{
				[Token(Token = "0x60005C5")]
				[Address(RVA = "0x1ABAD94", Offset = "0x1ABAD94", VA = "0x1ABAD94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C800", Offset = "0x79C800")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005C6")]
				[Address(RVA = "0x1ABADA0", Offset = "0x1ABADA0", VA = "0x1ABADA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C810", Offset = "0x79C810")]
				private set
				{
				}
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x1ABADAC", Offset = "0x1ABADAC", VA = "0x1ABADAC")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x1ABAEE0", Offset = "0x1ABAEE0", VA = "0x1ABAEE0")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005C9")]
			protected abstract float GetLength();

			[Token(Token = "0x60005CA")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60005CB")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x1ABAFB4", Offset = "0x1ABAFB4", VA = "0x1ABAFB4")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B0")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000C1")]
			public class EffectorLink
			{
				[Token(Token = "0x400059F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A5E0", Offset = "0x79A5E0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005A0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A618", Offset = "0x79A618")]
				public float weight;

				[Token(Token = "0x40005A1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40005A2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000605")]
				[Address(RVA = "0x1C91B54", Offset = "0x1C91B54", VA = "0x1C91B54")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000606")]
				[Address(RVA = "0x1C91C04", Offset = "0x1C91C04", VA = "0x1C91C04")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000607")]
				[Address(RVA = "0x1C91C18", Offset = "0x1C91C18", VA = "0x1C91C18")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799D04", Offset = "0x799D04")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799D3C", Offset = "0x799D3C")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799D74", Offset = "0x799D74")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x1ABB2E0", Offset = "0x1ABB2E0", VA = "0x1ABB2E0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x1ABB410", Offset = "0x1ABB410", VA = "0x1ABB410", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x1ABB47C", Offset = "0x1ABB47C", VA = "0x1ABB47C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x1ABB5E4", Offset = "0x1ABB5E4", VA = "0x1ABB5E4")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B1")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000C2")]
			public class BoneLink
			{
				[Token(Token = "0x40005A3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A650", Offset = "0x79A650")]
				public Transform bone;

				[Token(Token = "0x40005A4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A688", Offset = "0x79A688")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x79A688", Offset = "0x79A688")]
				public float weight;

				[Token(Token = "0x40005A5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x40005A6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000608")]
				[Address(RVA = "0x1C919EC", Offset = "0x1C919EC", VA = "0x1C919EC")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000609")]
				[Address(RVA = "0x1C91B04", Offset = "0x1C91B04", VA = "0x1C91B04")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600060A")]
				[Address(RVA = "0x1C91B10", Offset = "0x1C91B10", VA = "0x1C91B10")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799DAC", Offset = "0x799DAC")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799DE4", Offset = "0x799DE4")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x1ABAFC8", Offset = "0x1ABAFC8", VA = "0x1ABAFC8", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x1ABB06C", Offset = "0x1ABB06C", VA = "0x1ABB06C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x1ABB0D8", Offset = "0x1ABB0D8", VA = "0x1ABB0D8", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x1ABB2CC", Offset = "0x1ABB2CC", VA = "0x1ABB2CC")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797984", Offset = "0x797984")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7979BC", Offset = "0x7979BC")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700005B")]
		public bool inProgress
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x1A56188", Offset = "0x1A56188", VA = "0x1A56188")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1A56258", Offset = "0x1A56258", VA = "0x1A56258", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1A56334", Offset = "0x1A56334", VA = "0x1A56334")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1A56590", Offset = "0x1A56590", VA = "0x1A56590")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000B2")]
		public abstract class Offset
		{
			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799E1C", Offset = "0x799E1C")]
			public string name;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799E54", Offset = "0x799E54")]
			public Collider collider;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799E8C", Offset = "0x799E8C")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x799ED8", Offset = "0x799ED8")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x799EE8", Offset = "0x799EE8")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x799EF8", Offset = "0x799EF8")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x799F08", Offset = "0x799F08")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A5")]
			protected float crossFader
			{
				[Token(Token = "0x60005D5")]
				[Address(RVA = "0x1ABB5F8", Offset = "0x1ABB5F8", VA = "0x1ABB5F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C820", Offset = "0x79C820")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005D6")]
				[Address(RVA = "0x1ABB600", Offset = "0x1ABB600", VA = "0x1ABB600")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C830", Offset = "0x79C830")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			protected float timer
			{
				[Token(Token = "0x60005D7")]
				[Address(RVA = "0x1ABB608", Offset = "0x1ABB608", VA = "0x1ABB608")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C840", Offset = "0x79C840")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005D8")]
				[Address(RVA = "0x1ABB610", Offset = "0x1ABB610", VA = "0x1ABB610")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C850", Offset = "0x79C850")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			protected Vector3 force
			{
				[Token(Token = "0x60005D9")]
				[Address(RVA = "0x1ABB618", Offset = "0x1ABB618", VA = "0x1ABB618")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C860", Offset = "0x79C860")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005DA")]
				[Address(RVA = "0x1ABB624", Offset = "0x1ABB624", VA = "0x1ABB624")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C870", Offset = "0x79C870")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A8")]
			protected Vector3 point
			{
				[Token(Token = "0x60005DB")]
				[Address(RVA = "0x1ABB630", Offset = "0x1ABB630", VA = "0x1ABB630")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C880", Offset = "0x79C880")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005DC")]
				[Address(RVA = "0x1ABB63C", Offset = "0x1ABB63C", VA = "0x1ABB63C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79C890", Offset = "0x79C890")]
				private set
				{
				}
			}

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x1ABB648", Offset = "0x1ABB648", VA = "0x1ABB648")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x1ABB790", Offset = "0x1ABB790", VA = "0x1ABB790")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60005DF")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x60005E0")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60005E1")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x1ABB878", Offset = "0x1ABB878", VA = "0x1ABB878")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B3")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000C3")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x40005A7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A6DC", Offset = "0x79A6DC")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x40005A8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A714", Offset = "0x79A714")]
				public float weight;

				[Token(Token = "0x40005A9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40005AA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600060B")]
				[Address(RVA = "0x1C91C20", Offset = "0x1C91C20", VA = "0x1C91C20")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600060C")]
				[Address(RVA = "0x1C91CB0", Offset = "0x1C91CB0", VA = "0x1C91CB0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600060D")]
				[Address(RVA = "0x1C91CC4", Offset = "0x1C91CC4", VA = "0x1C91CC4")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799F18", Offset = "0x799F18")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799F50", Offset = "0x799F50")]
			public int upDirCurveIndex;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799F88", Offset = "0x799F88")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x1ABB88C", Offset = "0x1ABB88C", VA = "0x1ABB88C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x1ABBA3C", Offset = "0x1ABBA3C", VA = "0x1ABBA3C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x1ABBAA8", Offset = "0x1ABBAA8", VA = "0x1ABBAA8", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x1ABBC48", Offset = "0x1ABBC48", VA = "0x1ABBC48")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B4")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000C4")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x40005AB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A74C", Offset = "0x79A74C")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x40005AC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A784", Offset = "0x79A784")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x79A784", Offset = "0x79A784")]
				public float weight;

				[Token(Token = "0x40005AD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x40005AE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x600060E")]
				[Address(RVA = "0x1C91CCC", Offset = "0x1C91CCC", VA = "0x1C91CCC")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600060F")]
				[Address(RVA = "0x1C91DA8", Offset = "0x1C91DA8", VA = "0x1C91DA8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000610")]
				[Address(RVA = "0x1C91DB4", Offset = "0x1C91DB4", VA = "0x1C91DB4")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799FC0", Offset = "0x799FC0")]
			public int curveIndex;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x799FF8", Offset = "0x799FF8")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x1ABBC64", Offset = "0x1ABBC64", VA = "0x1ABBC64", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x1ABBD48", Offset = "0x1ABBD48", VA = "0x1ABBD48", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x1ABBDB4", Offset = "0x1ABBDB4", VA = "0x1ABBDB4", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x1ABC068", Offset = "0x1ABC068", VA = "0x1ABC068")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7979F4", Offset = "0x7979F4")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797A2C", Offset = "0x797A2C")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1A56598", Offset = "0x1A56598", VA = "0x1A56598", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1A5666C", Offset = "0x1A5666C", VA = "0x1A5666C")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1A568D0", Offset = "0x1A568D0", VA = "0x1A568D0")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000B5")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000C5")]
			public class EffectorLink
			{
				[Token(Token = "0x40005AF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A7D8", Offset = "0x79A7D8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005B0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A810", Offset = "0x79A810")]
				public float weight;

				[Token(Token = "0x6000611")]
				[Address(RVA = "0x1C91DF8", Offset = "0x1C91DF8", VA = "0x1C91DF8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A030", Offset = "0x79A030")]
			public Transform transform;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A068", Offset = "0x79A068")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A0A0", Offset = "0x79A0A0")]
			public float speed;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A0D8", Offset = "0x79A0D8")]
			public float acceleration;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A110", Offset = "0x79A110")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x79A110", Offset = "0x79A110")]
			public float matchVelocity;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A164", Offset = "0x79A164")]
			public float gravity;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x1AC7F80", Offset = "0x1AC7F80", VA = "0x1AC7F80")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x1AC8038", Offset = "0x1AC8038", VA = "0x1AC8038")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x1AC82F4", Offset = "0x1AC82F4", VA = "0x1AC82F4")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797A64", Offset = "0x797A64")]
		public Body[] bodies;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797A9C", Offset = "0x797A9C")]
		public OffsetLimits[] limits;

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1927354", Offset = "0x1927354", VA = "0x1927354")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x19273D0", Offset = "0x19273D0", VA = "0x19273D0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1927578", Offset = "0x1927578", VA = "0x1927578")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B6")]
		public class OffsetLimits
		{
			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A19C", Offset = "0x79A19C")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A1D4", Offset = "0x79A1D4")]
			public float spring;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A20C", Offset = "0x79A20C")]
			public bool x;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A244", Offset = "0x79A244")]
			public bool y;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A27C", Offset = "0x79A27C")]
			public bool z;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A2B4", Offset = "0x79A2B4")]
			public float minX;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A2EC", Offset = "0x79A2EC")]
			public float maxX;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A324", Offset = "0x79A324")]
			public float minY;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A35C", Offset = "0x79A35C")]
			public float maxY;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A394", Offset = "0x79A394")]
			public float minZ;

			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A3CC", Offset = "0x79A3CC")]
			public float maxZ;

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x1C8F214", Offset = "0x1C8F214", VA = "0x1C8F214")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x1C8F36C", Offset = "0x1C8F36C", VA = "0x1C8F36C")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x1C8F3E4", Offset = "0x1C8F3E4", VA = "0x1C8F3E4")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x1C8F43C", Offset = "0x1C8F43C", VA = "0x1C8F43C")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x794880", Offset = "0x794880")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000A9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005F5")]
				[Address(RVA = "0x1C8F1C4", Offset = "0x1C8F1C4", VA = "0x1C8F1C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005F7")]
				[Address(RVA = "0x1C8F20C", Offset = "0x1C8F20C", VA = "0x1C8F20C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x1C8F044", Offset = "0x1C8F044", VA = "0x1C8F044")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x1C8F070", Offset = "0x1C8F070", VA = "0x1C8F070", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x1C8F074", Offset = "0x1C8F074", VA = "0x1C8F074", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x1C8F1CC", Offset = "0x1C8F1CC", VA = "0x1C8F1CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797AD4", Offset = "0x797AD4")]
		public float weight;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797B0C", Offset = "0x797B0C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x1700005C")]
		protected float deltaTime
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x192748C", Offset = "0x192748C", VA = "0x192748C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000463")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1930620", Offset = "0x1930620", VA = "0x1930620", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x193064C", Offset = "0x193064C", VA = "0x193064C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x79C3D0", Offset = "0x79C3D0")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x19306B8", Offset = "0x19306B8", VA = "0x19306B8")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x19274B8", Offset = "0x19274B8", VA = "0x19274B8")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1930794", Offset = "0x1930794", VA = "0x1930794", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1927588", Offset = "0x1927588", VA = "0x1927588")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x794890", Offset = "0x794890")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000AB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005FB")]
				[Address(RVA = "0x1C8F5C4", Offset = "0x1C8F5C4", VA = "0x1C8F5C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005FD")]
				[Address(RVA = "0x1C8F60C", Offset = "0x1C8F60C", VA = "0x1C8F60C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x1C8F444", Offset = "0x1C8F444", VA = "0x1C8F444")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x1C8F470", Offset = "0x1C8F470", VA = "0x1C8F470", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x1C8F474", Offset = "0x1C8F474", VA = "0x1C8F474", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x1C8F5CC", Offset = "0x1C8F5CC", VA = "0x1C8F5CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797B44", Offset = "0x797B44")]
		public float weight;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797B7C", Offset = "0x797B7C")]
		public VRIK ik;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x1700005D")]
		protected float deltaTime
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x19308A0", Offset = "0x19308A0", VA = "0x19308A0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600046B")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x19308CC", Offset = "0x19308CC", VA = "0x19308CC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x19308F8", Offset = "0x19308F8", VA = "0x19308F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x79C430", Offset = "0x79C430")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1930964", Offset = "0x1930964", VA = "0x1930964")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1930A40", Offset = "0x1930A40", VA = "0x1930A40", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1930B4C", Offset = "0x1930B4C", VA = "0x1930B4C")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B9")]
		public class EffectorLink
		{
			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x1C8F614", Offset = "0x1C8F614", VA = "0x1C8F614")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x1C8F830", Offset = "0x1C8F830", VA = "0x1C8F830")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1930B5C", Offset = "0x1930B5C", VA = "0x1930B5C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1930C20", Offset = "0x1930C20", VA = "0x1930C20")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1930CDC", Offset = "0x1930CDC", VA = "0x1930CDC")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000BA")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000C6")]
			public class EffectorLink
			{
				[Token(Token = "0x40005B1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A848", Offset = "0x79A848")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005B2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A880", Offset = "0x79A880")]
				public float weight;

				[Token(Token = "0x6000612")]
				[Address(RVA = "0x1C91E08", Offset = "0x1C91E08", VA = "0x1C91E08")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A404", Offset = "0x79A404")]
			public Vector3 offset;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A43C", Offset = "0x79A43C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x79A43C", Offset = "0x79A43C")]
			public float additivity;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A490", Offset = "0x79A490")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79A4C8", Offset = "0x79A4C8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x1C90088", Offset = "0x1C90088", VA = "0x1C90088")]
			public void Start()
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x1C900D8", Offset = "0x1C900D8", VA = "0x1C900D8")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x1C9029C", Offset = "0x1C9029C", VA = "0x1C9029C")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BB")]
		public enum Handedness
		{
			[Token(Token = "0x400058A")]
			Right,
			[Token(Token = "0x400058B")]
			Left
		}

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797BB4", Offset = "0x797BB4")]
		public AimIK aimIK;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797BEC", Offset = "0x797BEC")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797C24", Offset = "0x797C24")]
		public Handedness handedness;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797C5C", Offset = "0x797C5C")]
		public bool twoHanded;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797C94", Offset = "0x797C94")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797CCC", Offset = "0x797CCC")]
		public float magnitudeRandom;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797D04", Offset = "0x797D04")]
		public Vector3 rotationRandom;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797D3C", Offset = "0x797D3C")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797D74", Offset = "0x797D74")]
		public float blendTime;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x797DAC", Offset = "0x797DAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797DAC", Offset = "0x797DAC")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x1700005E")]
		public bool isFinished
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x19325D0", Offset = "0x19325D0", VA = "0x19325D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x1933048", Offset = "0x1933048", VA = "0x1933048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x1933088", Offset = "0x1933088", VA = "0x1933088")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		private Transform primaryHand
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x1933008", Offset = "0x1933008", VA = "0x1933008")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		private Transform secondaryHand
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x1933028", Offset = "0x1933028", VA = "0x1933028")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1932600", Offset = "0x1932600", VA = "0x1932600")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x193262C", Offset = "0x193262C", VA = "0x193262C")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1932774", Offset = "0x1932774", VA = "0x1932774", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x19330C8", Offset = "0x19330C8", VA = "0x19330C8")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x193317C", Offset = "0x193317C", VA = "0x193317C")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x19331B8", Offset = "0x19331B8", VA = "0x19331B8", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1933370", Offset = "0x1933370", VA = "0x1933370")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797E0C", Offset = "0x797E0C")]
		public float weight;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x797E44", Offset = "0x797E44")]
		public float offset;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1935A0C", Offset = "0x1935A0C", VA = "0x1935A0C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1935AF4", Offset = "0x1935AF4", VA = "0x1935AF4")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1935BDC", Offset = "0x1935BDC", VA = "0x1935BDC")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1935F30", Offset = "0x1935F30", VA = "0x1935F30")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1935F68", Offset = "0x1935F68", VA = "0x1935F68")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1936074", Offset = "0x1936074", VA = "0x1936074")]
		public ShoulderRotator()
		{
		}
	}
}
