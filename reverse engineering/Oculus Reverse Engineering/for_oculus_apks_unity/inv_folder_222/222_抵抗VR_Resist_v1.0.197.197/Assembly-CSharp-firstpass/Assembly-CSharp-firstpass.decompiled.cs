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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x4C4434", Offset = "0x4C4434")]
		public bool smoothFollow;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x4C446C", Offset = "0x4C446C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x4C44A4", Offset = "0x4C44A4")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x4C44DC", Offset = "0x4C44DC")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C4514", Offset = "0x4C4514")]
		public float blockedOffset;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C452C", Offset = "0x4C452C")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C453C", Offset = "0x4C453C")]
		private float <y>k__BackingField;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C454C", Offset = "0x4C454C")]
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
			[Address(RVA = "0xEE7060", Offset = "0xEE7060", VA = "0xEE7060")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA44C", Offset = "0x4CA44C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0xEE7068", Offset = "0xEE7068", VA = "0xEE7068")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA45C", Offset = "0x4CA45C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float y
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0xEE7070", Offset = "0xEE7070", VA = "0xEE7070")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA46C", Offset = "0x4CA46C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0xEE7078", Offset = "0xEE7078", VA = "0xEE7078")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA47C", Offset = "0x4CA47C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public float distanceTarget
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0xEE7080", Offset = "0xEE7080", VA = "0xEE7080")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA48C", Offset = "0x4CA48C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0xEE7088", Offset = "0xEE7088", VA = "0xEE7088")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA49C", Offset = "0x4CA49C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		private float zoomAdd
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0xEE78CC", Offset = "0xEE78CC", VA = "0xEE78CC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xEE7090", Offset = "0xEE7090", VA = "0xEE7090", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xEE7194", Offset = "0xEE7194", VA = "0xEE7194", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xEE71F0", Offset = "0xEE71F0", VA = "0xEE71F0", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xEE7258", Offset = "0xEE7258", VA = "0xEE7258", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xEE72BC", Offset = "0xEE72BC", VA = "0xEE72BC")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xEE71C8", Offset = "0xEE71C8", VA = "0xEE71C8")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xEE743C", Offset = "0xEE743C", VA = "0xEE743C")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xEE789C", Offset = "0xEE789C", VA = "0xEE789C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xEE793C", Offset = "0xEE793C", VA = "0xEE793C")]
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
		[Address(RVA = "0xEE79E0", Offset = "0xEE79E0", VA = "0xEE79E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xEE7A18", Offset = "0xEE7A18", VA = "0xEE7A18")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xEE7BC0", Offset = "0xEE7BC0", VA = "0xEE7BC0")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xEE7BF0", Offset = "0xEE7BF0", VA = "0xEE7BF0")]
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
		[Address(RVA = "0xEDEB5C", Offset = "0xEDEB5C", VA = "0xEDEB5C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xEDEB80", Offset = "0xEDEB80", VA = "0xEDEB80")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xEDEBB8", Offset = "0xEDEBB8", VA = "0xEDEBB8")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xEDECA8", Offset = "0xEDECA8", VA = "0xEDECA8")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xEDEC50", Offset = "0xEDEC50", VA = "0xEDEC50")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xEDED40", Offset = "0xEDED40", VA = "0xEDED40")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xEDEE9C", Offset = "0xEDEE9C", VA = "0xEDEE9C")]
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
			[Address(RVA = "0xFB1634", Offset = "0xFB1634", VA = "0xFB1634")]
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
			[Address(RVA = "0xEE0318", Offset = "0xEE0318", VA = "0xEE0318")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0xEE0584", Offset = "0xEE0584", VA = "0xEE0584")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xEE02CC", Offset = "0xEE02CC", VA = "0xEE02CC")]
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
		[Address(RVA = "0xEE07F0", Offset = "0xEE07F0", VA = "0xEE07F0")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xEE0B0C", Offset = "0xEE0B0C", VA = "0xEE0B0C")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xEE0D78", Offset = "0xEE0D78", VA = "0xEE0D78")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xEE0DF8", Offset = "0xEE0DF8", VA = "0xEE0DF8")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xEE0EA0", Offset = "0xEE0EA0", VA = "0xEE0EA0")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xEE09C0", Offset = "0xEE09C0", VA = "0xEE09C0")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xEE0CDC", Offset = "0xEE0CDC", VA = "0xEE0CDC")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xEE16D0", Offset = "0xEE16D0", VA = "0xEE16D0")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xEE14D8", Offset = "0xEE14D8", VA = "0xEE14D8")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xEE15D4", Offset = "0xEE15D4", VA = "0xEE15D4")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xEE10B8", Offset = "0xEE10B8", VA = "0xEE10B8")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xEE1168", Offset = "0xEE1168", VA = "0xEE1168")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xEE1218", Offset = "0xEE1218", VA = "0xEE1218")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xEE12C8", Offset = "0xEE12C8", VA = "0xEE12C8")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xEE1378", Offset = "0xEE1378", VA = "0xEE1378")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xEE1428", Offset = "0xEE1428", VA = "0xEE1428")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xEE18D8", Offset = "0xEE18D8", VA = "0xEE18D8")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xEE0FD0", Offset = "0xEE0FD0", VA = "0xEE0FD0")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xEE1848", Offset = "0xEE1848", VA = "0xEE1848")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xEE1944", Offset = "0xEE1944", VA = "0xEE1944")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xEE1A18", Offset = "0xEE1A18", VA = "0xEE1A18")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xEE17D0", Offset = "0xEE17D0", VA = "0xEE17D0")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xEE175C", Offset = "0xEE175C", VA = "0xEE175C")]
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
				[Address(RVA = "0xFB16C0", Offset = "0xFB16C0", VA = "0xFB16C0")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0xFB16AC", Offset = "0xFB16AC", VA = "0xFB16AC")]
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
			[Address(RVA = "0xEE3A5C", Offset = "0xEE3A5C", VA = "0xEE3A5C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public bool isEmpty
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0xEE3E44", Offset = "0xEE3E44", VA = "0xEE3E44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xEE3E54", Offset = "0xEE3E54", VA = "0xEE3E54", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xEE427C", Offset = "0xEE427C", VA = "0xEE427C", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xEE46B0", Offset = "0xEE46B0", VA = "0xEE46B0")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xEE4C9C", Offset = "0xEE4C9C", VA = "0xEE4C9C")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xEE48C4", Offset = "0xEE48C4", VA = "0xEE48C4")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xEDF7C0", Offset = "0xEDF7C0", VA = "0xEDF7C0")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xEE549C", Offset = "0xEE549C", VA = "0xEE549C")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xEE59FC", Offset = "0xEE59FC", VA = "0xEE59FC")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xEE57F0", Offset = "0xEE57F0", VA = "0xEE57F0")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xEE566C", Offset = "0xEE566C", VA = "0xEE566C")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xEE553C", Offset = "0xEE553C", VA = "0xEE553C")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xEE58FC", Offset = "0xEE58FC", VA = "0xEE58FC")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xEE5AF4", Offset = "0xEE5AF4", VA = "0xEE5AF4")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xEE6618", Offset = "0xEE6618", VA = "0xEE6618")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xEE60A0", Offset = "0xEE60A0", VA = "0xEE60A0")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xEE68C0", Offset = "0xEE68C0", VA = "0xEE68C0")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xEE640C", Offset = "0xEE640C", VA = "0xEE640C")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xEE68C8", Offset = "0xEE68C8", VA = "0xEE68C8")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xEE68D0", Offset = "0xEE68D0", VA = "0xEE68D0")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xEE6A98", Offset = "0xEE6A98", VA = "0xEE6A98")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xEE6C54", Offset = "0xEE6C54", VA = "0xEE6C54")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xEDFF1C", Offset = "0xEDFF1C", VA = "0xEDFF1C")]
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
		[Address(RVA = "0xEEADB0", Offset = "0xEEADB0", VA = "0xEEADB0")]
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
		[Address(RVA = "0xEEB330", Offset = "0xEEB330", VA = "0xEEB330")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xEEB478", Offset = "0xEEB478", VA = "0xEEB478")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class Hierarchy
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0xF51E98", Offset = "0xF51E98", VA = "0xF51E98")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xF52084", Offset = "0xF52084", VA = "0xF52084")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xF51F30", Offset = "0xF51F30", VA = "0xF51F30")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xF521A4", Offset = "0xF521A4", VA = "0xF521A4")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xF522D0", Offset = "0xF522D0", VA = "0xF522D0")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xF5251C", Offset = "0xF5251C", VA = "0xF5251C")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xF52624", Offset = "0xF52624", VA = "0xF52624")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xF52798", Offset = "0xF52798", VA = "0xF52798")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xF52B74", Offset = "0xF52B74", VA = "0xF52B74")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xF52938", Offset = "0xF52938", VA = "0xF52938")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xF52D28", Offset = "0xF52D28", VA = "0xF52D28")]
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
		[Address(RVA = "0xECF3EC", Offset = "0xECF3EC", VA = "0xECF3EC")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xED4C68", Offset = "0xED4C68", VA = "0xED4C68")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xED4CDC", Offset = "0xED4CDC", VA = "0xED4CDC")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xED46D0", Offset = "0xED46D0", VA = "0xED46D0")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xED46DC", Offset = "0xED46DC", VA = "0xED46DC")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xED4700", Offset = "0xED4700", VA = "0xED4700")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xED473C", Offset = "0xED473C", VA = "0xED473C")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xED4754", Offset = "0xED4754", VA = "0xED4754")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xED4768", Offset = "0xED4768", VA = "0xED4768")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xED477C", Offset = "0xED477C", VA = "0xED477C")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xED478C", Offset = "0xED478C", VA = "0xED478C")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xED47D4", Offset = "0xED47D4", VA = "0xED47D4")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xED480C", Offset = "0xED480C", VA = "0xED480C")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xED4834", Offset = "0xED4834", VA = "0xED4834")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xED4D68", Offset = "0xED4D68", VA = "0xED4D68")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xED4868", Offset = "0xED4868", VA = "0xED4868")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xED4890", Offset = "0xED4890", VA = "0xED4890")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xED48C0", Offset = "0xED48C0", VA = "0xED48C0")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xED48F4", Offset = "0xED48F4", VA = "0xED48F4")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xED4938", Offset = "0xED4938", VA = "0xED4938")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xED499C", Offset = "0xED499C", VA = "0xED499C")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xED4A00", Offset = "0xED4A00", VA = "0xED4A00")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xED4A54", Offset = "0xED4A54", VA = "0xED4A54")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xED4AA8", Offset = "0xED4AA8", VA = "0xED4AA8")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xED4AE4", Offset = "0xED4AE4", VA = "0xED4AE4")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xED4B1C", Offset = "0xED4B1C", VA = "0xED4B1C")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xED4D9C", Offset = "0xED4D9C", VA = "0xED4D9C")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xED4B64", Offset = "0xED4B64", VA = "0xED4B64")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xED4BF8", Offset = "0xED4BF8", VA = "0xED4BF8")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xED4C28", Offset = "0xED4C28", VA = "0xED4C28")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xED4E30", Offset = "0xED4E30", VA = "0xED4E30")]
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
		[Address(RVA = "0xED4E38", Offset = "0xED4E38", VA = "0xED4E38")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xED4EA4", Offset = "0xED4EA4", VA = "0xED4EA4")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200000F")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0xED4F10", Offset = "0xED4F10", VA = "0xED4F10")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xED4F68", Offset = "0xED4F68", VA = "0xED4F68")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xED5034", Offset = "0xED5034", VA = "0xED5034")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xED4F80", Offset = "0xED4F80", VA = "0xED4F80")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xED504C", Offset = "0xED504C", VA = "0xED504C")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xED50F0", Offset = "0xED50F0", VA = "0xED50F0")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xED511C", Offset = "0xED511C", VA = "0xED511C")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xED516C", Offset = "0xED516C", VA = "0xED516C")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xED51D8", Offset = "0xED51D8", VA = "0xED51D8")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xED52EC", Offset = "0xED52EC", VA = "0xED52EC")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xED53E4", Offset = "0xED53E4", VA = "0xED53E4")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xED5440", Offset = "0xED5440", VA = "0xED5440")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000010")]
	public static class QuaTools
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0xED6154", Offset = "0xED6154", VA = "0xED6154")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xED61A4", Offset = "0xED61A4", VA = "0xED61A4")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xED61F4", Offset = "0xED61F4", VA = "0xED61F4")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xED629C", Offset = "0xED629C", VA = "0xED629C")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xED43E0", Offset = "0xED43E0", VA = "0xED43E0")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xED6344", Offset = "0xED6344", VA = "0xED6344")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xED6398", Offset = "0xED6398", VA = "0xED6398")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xED646C", Offset = "0xED646C", VA = "0xED646C")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xED657C", Offset = "0xED657C", VA = "0xED657C")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xED670C", Offset = "0xED670C", VA = "0xED670C")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xED6800", Offset = "0xED6800", VA = "0xED6800")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C456C", Offset = "0x4C456C")]
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
			[Address(RVA = "0xEDBCF4", Offset = "0xEDBCF4", VA = "0xEDBCF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool isAnimated
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0xEDC000", Offset = "0xEDC000", VA = "0xEDC000")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xEDBBB4", Offset = "0xEDBBB4", VA = "0xEDBBB4")]
		public void Disable()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xEDBC54", Offset = "0xEDBC54", VA = "0xEDBC54", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xEDBC58", Offset = "0xEDBC58", VA = "0xEDBC58", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xEDBC5C", Offset = "0xEDBC5C", VA = "0xEDBC5C", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xEDBC60", Offset = "0xEDBC60", VA = "0xEDBC60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xEDBCF0", Offset = "0xEDBCF0", VA = "0xEDBCF0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xEDBC98", Offset = "0xEDBC98", VA = "0xEDBC98")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xEDBFB4", Offset = "0xEDBFB4", VA = "0xEDBFB4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xEDBDE0", Offset = "0xEDBDE0", VA = "0xEDBDE0")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xEDC0B8", Offset = "0xEDC0B8", VA = "0xEDC0B8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xEDC114", Offset = "0xEDC114", VA = "0xEDC114")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xEDC170", Offset = "0xEDC170", VA = "0xEDC170")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xED6144", Offset = "0xED6144", VA = "0xED6144")]
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
		[Address(RVA = "0xEDC1B8", Offset = "0xEDC1B8", VA = "0xEDC1B8")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xEDC278", Offset = "0xEDC278", VA = "0xEDC278")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xEDC338", Offset = "0xEDC338", VA = "0xEDC338")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xEDC3F8", Offset = "0xEDC3F8", VA = "0xEDC3F8")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public static class V3Tools
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xEDD2DC", Offset = "0xEDD2DC", VA = "0xEDD2DC")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xEDD37C", Offset = "0xEDD37C", VA = "0xEDD37C")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xEDD3B8", Offset = "0xEDD3B8", VA = "0xEDD3B8")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xEDD3FC", Offset = "0xEDD3FC", VA = "0xEDD3FC")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xEDD498", Offset = "0xEDD498", VA = "0xEDD498")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xEDD614", Offset = "0xEDD614", VA = "0xEDD614")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xEDD798", Offset = "0xEDD798", VA = "0xEDD798")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xEDD854", Offset = "0xEDD854", VA = "0xEDD854")]
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
		[Address(RVA = "0xEDDBF0", Offset = "0xEDDBF0", VA = "0xEDDBF0")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xECEAA4", Offset = "0xECEAA4", VA = "0xECEAA4")]
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
			[Address(RVA = "0xEE7C30", Offset = "0xEE7C30", VA = "0xEE7C30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xEE7C0C", Offset = "0xEE7C0C", VA = "0xEE7C0C", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xEE7C38", Offset = "0xEE7C38", VA = "0xEE7C38")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xEE7C9C", Offset = "0xEE7C9C", VA = "0xEE7C9C", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xEE7ED4", Offset = "0xEE7ED4", VA = "0xEE7ED4", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xEE80B8", Offset = "0xEE80B8", VA = "0xEE80B8", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xEE7EE4", Offset = "0xEE7EE4", VA = "0xEE7EE4")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xEE80C8", Offset = "0xEE80C8", VA = "0xEE80C8")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4C3958", Offset = "0x4C3958")]
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
		[Address(RVA = "0xEE80E0", Offset = "0xEE80E0", VA = "0xEE80E0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xEE813C", Offset = "0xEE813C", VA = "0xEE813C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xEE81D8", Offset = "0xEE81D8", VA = "0xEE81D8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xEE82F0", Offset = "0xEE82F0", VA = "0xEE82F0")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4C39B8", Offset = "0x4C39B8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C4604", Offset = "0x4C4604")]
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
			[Address(RVA = "0xEE83A4", Offset = "0xEE83A4", VA = "0xEE83A4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xEE8308", Offset = "0xEE8308", VA = "0xEE8308", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xEE8388", Offset = "0xEE8388", VA = "0xEE8388", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xEE849C", Offset = "0xEE849C", VA = "0xEE849C", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xEE881C", Offset = "0xEE881C", VA = "0xEE881C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xEE8924", Offset = "0xEE8924", VA = "0xEE8924")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4C3A18", Offset = "0x4C3A18")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4C3A18", Offset = "0x4C3A18")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x4C4648", Offset = "0x4C4648")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4648", Offset = "0x4C4648")]
		public Transform gravityTarget;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C46A8", Offset = "0x4C46A8")]
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
		[Address(RVA = "0xEE8948", Offset = "0xEE8948", VA = "0xEE8948")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xEE8A78", Offset = "0xEE8A78", VA = "0xEE8A78", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xEE8C30", Offset = "0xEE8C30", VA = "0xEE8C30", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xEE8DE0", Offset = "0xEE8DE0", VA = "0xEE8DE0")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xEE8E44", Offset = "0xEE8E44", VA = "0xEE8E44")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xEE8F64", Offset = "0xEE8F64", VA = "0xEE8F64")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xEE9088", Offset = "0xEE9088", VA = "0xEE9088")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xEE90AC", Offset = "0xEE90AC", VA = "0xEE90AC")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xEE90D0", Offset = "0xEE90D0", VA = "0xEE90D0")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xEE9130", Offset = "0xEE9130", VA = "0xEE9130")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x4C4744", Offset = "0x4C4744")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x4C477C", Offset = "0x4C477C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x4C47B4", Offset = "0x4C47B4")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x4C47EC", Offset = "0x4C47EC")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x4C4824", Offset = "0x4C4824")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x4C4870", Offset = "0x4C4870")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C48A8", Offset = "0x4C48A8")]
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
			[Address(RVA = "0xEE9150", Offset = "0xEE9150", VA = "0xEE9150")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA51C", Offset = "0x4CA51C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0xEE9158", Offset = "0xEE9158", VA = "0xEE9158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA52C", Offset = "0x4CA52C")]
			private set
			{
			}
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xEE9164", Offset = "0xEE9164", VA = "0xEE9164", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xEE92A4", Offset = "0xEE92A4", VA = "0xEE92A4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xEE9334", Offset = "0xEE9334", VA = "0xEE9334", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xEE93B0", Offset = "0xEE93B0", VA = "0xEE93B0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xEE9F38", Offset = "0xEE9F38", VA = "0xEE9F38", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xEEA174", Offset = "0xEEA174", VA = "0xEEA174", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xEE97C8", Offset = "0xEE97C8", VA = "0xEE97C8")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xEEA250", Offset = "0xEEA250", VA = "0xEEA250")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xEEA6F8", Offset = "0xEEA6F8", VA = "0xEEA6F8")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xEE9FC0", Offset = "0xEE9FC0", VA = "0xEE9FC0")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xEEA798", Offset = "0xEEA798", VA = "0xEEA798", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xEEAAD4", Offset = "0xEEAAD4", VA = "0xEEAAD4")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xEEABC4", Offset = "0xEEABC4", VA = "0xEEABC4", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xEE9B90", Offset = "0xEE9B90", VA = "0xEE9B90")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xEEACF8", Offset = "0xEEACF8", VA = "0xEEACF8")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4C3AAC", Offset = "0x4C3AAC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C48B8", Offset = "0x4C48B8")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4904", Offset = "0x4C4904")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4950", Offset = "0x4C4950")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C499C", Offset = "0x4C499C")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C49E8", Offset = "0x4C49E8")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4A34", Offset = "0x4C4A34")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C4A80", Offset = "0x4C4A80")]
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
			[Address(RVA = "0xEDB3D4", Offset = "0xEDB3D4", VA = "0xEDB3D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA53C", Offset = "0x4CA53C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0xEDB3DC", Offset = "0xEDB3DC", VA = "0xEDB3DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA54C", Offset = "0x4CA54C")]
			private set
			{
			}
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xEDB3E8", Offset = "0xEDB3E8", VA = "0xEDB3E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xEDB478", Offset = "0xEDB478", VA = "0xEDB478")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xEDB938", Offset = "0xEDB938", VA = "0xEDB938")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xEDB4CC", Offset = "0xEDB4CC", VA = "0xEDB4CC")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xEDB74C", Offset = "0xEDB74C", VA = "0xEDB74C")]
		private void Move()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xEDB974", Offset = "0xEDB974", VA = "0xEDB974")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xEDBA10", Offset = "0xEDBA10", VA = "0xEDBA10")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xEDBA94", Offset = "0xEDBA94", VA = "0xEDBA94")]
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
		[Address(RVA = "0xEDCE80", Offset = "0xEDCE80", VA = "0xEDCE80", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xEDCFDC", Offset = "0xEDCFDC", VA = "0xEDCFDC")]
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
		[Address(RVA = "0xEDD008", Offset = "0xEDD008", VA = "0xEDD008")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xEDD040", Offset = "0xEDD040", VA = "0xEDD040", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xEDCFF8", Offset = "0xEDCFF8", VA = "0xEDCFF8")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xEDEB18", Offset = "0xEDEB18", VA = "0xEDEB18")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xEDEB54", Offset = "0xEDEB54", VA = "0xEDEB54")]
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
		[Address(RVA = "0xEDBABC", Offset = "0xEDBABC", VA = "0xEDBABC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xEDBAF0", Offset = "0xEDBAF0", VA = "0xEDBAF0")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xEDBBA0", Offset = "0xEDBBA0", VA = "0xEDBBA0")]
		public SlowMoRoot()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C3B0C", Offset = "0x4C3B0C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C3B0C", Offset = "0x4C3B0C")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xEDEEA4", Offset = "0xEDEEA4", VA = "0xEDEEA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CA55C", Offset = "0x4CA55C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xEDEEEC", Offset = "0xEDEEEC", VA = "0xEDEEEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CA594", Offset = "0x4CA594")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xEDEF34", Offset = "0xEDEF34", VA = "0xEDEF34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CA5CC", Offset = "0x4CA5CC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xEDEF7C", Offset = "0xEDEF7C", VA = "0xEDEF7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CA604", Offset = "0x4CA604")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xEDEFC4", Offset = "0xEDEFC4", VA = "0xEDEFC4")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xEDF060", Offset = "0xEDF060", VA = "0xEDF060")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xEDF080", Offset = "0xEDF080", VA = "0xEDF080")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xEDF0B0", Offset = "0xEDF0B0", VA = "0xEDF0B0")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xEDF0E0", Offset = "0xEDF0E0", VA = "0xEDF0E0")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xEDF120", Offset = "0xEDF120", VA = "0xEDF120")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xEDF164", Offset = "0xEDF164", VA = "0xEDF164")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xEDF188", Offset = "0xEDF188", VA = "0xEDF188")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xEDF1AC", Offset = "0xEDF1AC", VA = "0xEDF1AC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xEDF1D4", Offset = "0xEDF1D4", VA = "0xEDF1D4")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xEDF200", Offset = "0xEDF200", VA = "0xEDF200")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xEDF22C", Offset = "0xEDF22C", VA = "0xEDF22C")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xEDEFE4", Offset = "0xEDEFE4", VA = "0xEDEFE4")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xEDF254", Offset = "0xEDF254", VA = "0xEDF254")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xEDF260", Offset = "0xEDF260", VA = "0xEDF260")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xEDF26C", Offset = "0xEDF26C", VA = "0xEDF26C")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xEDF550", Offset = "0xEDF550", VA = "0xEDF550", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xEDF5F8", Offset = "0xEDF5F8", VA = "0xEDF5F8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xEDFA28", Offset = "0xEDFA28", VA = "0xEDFA28", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xEDFE60", Offset = "0xEDFE60", VA = "0xEDFE60")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xEDFE94", Offset = "0xEDFE94", VA = "0xEDFE94")]
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
			[Address(RVA = "0xEDF40C", Offset = "0xEDF40C", VA = "0xEDF40C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0xEE00FC", Offset = "0xEE00FC", VA = "0xEE00FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xEDF8B0", Offset = "0xEDF8B0", VA = "0xEDF8B0")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xEDFF88", Offset = "0xEDFF88", VA = "0xEDFF88")]
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
			[Address(RVA = "0xEEADB8", Offset = "0xEEADB8", VA = "0xEEADB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000116")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xEEAE24", Offset = "0xEEAE24", VA = "0xEEAE24")]
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
		[Address(RVA = "0xEEAE2C", Offset = "0xEEAE2C", VA = "0xEEAE2C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xEEAEEC", Offset = "0xEEAEEC", VA = "0xEEAEEC")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xEEAEF4", Offset = "0xEEAEF4", VA = "0xEEAEF4")]
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
			[Address(RVA = "0xEEB028", Offset = "0xEEB028", VA = "0xEEB028")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xEEAF20", Offset = "0xEEAF20", VA = "0xEEAF20", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xEEB064", Offset = "0xEEB064", VA = "0xEEB064")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xEEB06C", Offset = "0xEEB06C", VA = "0xEEB06C")]
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
		[Address(RVA = "0xEEB098", Offset = "0xEEB098", VA = "0xEEB098", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xEEB118", Offset = "0xEEB118", VA = "0xEEB118")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xEEB120", Offset = "0xEEB120", VA = "0xEEB120")]
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
			[Address(RVA = "0xEEB254", Offset = "0xEEB254", VA = "0xEEB254")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xEEB14C", Offset = "0xEEB14C", VA = "0xEEB14C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xEEB290", Offset = "0xEEB290", VA = "0xEEB290")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xEEB298", Offset = "0xEEB298", VA = "0xEEB298")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C4AD0", Offset = "0x4C4AD0")]
		public float positionWeight;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C4AE8", Offset = "0x4C4AE8")]
		public float rotationWeight;

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xEEB2C4", Offset = "0xEEB2C4", VA = "0xEEB2C4")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xEDF9D4", Offset = "0xEDF9D4", VA = "0xEDF9D4")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xEDFBB0", Offset = "0xEDFBB0", VA = "0xEDFBB0")]
		public void Update()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xEE02C4", Offset = "0xEE02C4", VA = "0xEE02C4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4B00", Offset = "0x4C4B00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C4B00", Offset = "0x4C4B00")]
		public float weight;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4B54", Offset = "0x4C4B54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C4B54", Offset = "0x4C4B54")]
		public float rotationWeight;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4BA8", Offset = "0x4C4BA8")]
		public DOF rotationDOF;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4BE0", Offset = "0x4C4BE0")]
		public Transform bone1;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4C18", Offset = "0x4C4C18")]
		public Transform bone2;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4C50", Offset = "0x4C4C50")]
		public Transform bone3;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4C88", Offset = "0x4C4C88")]
		public Transform tip;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4CC0", Offset = "0x4C4CC0")]
		public Transform target;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C4CF8", Offset = "0x4C4CF8")]
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
			[Address(RVA = "0xF49270", Offset = "0xF49270", VA = "0xF49270")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA63C", Offset = "0x4CA63C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600012B")]
			[Address(RVA = "0xF49278", Offset = "0xF49278", VA = "0xF49278")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA64C", Offset = "0x4CA64C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0xF49284", Offset = "0xF49284", VA = "0xF49284")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0xF492A4", Offset = "0xF492A4", VA = "0xF492A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0xF492C4", Offset = "0xF492C4", VA = "0xF492C4")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0xF492E4", Offset = "0xF492E4", VA = "0xF492E4")]
			set
			{
			}
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xF49304", Offset = "0xF49304", VA = "0xF49304")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xF4940C", Offset = "0xF4940C", VA = "0xF4940C")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xF498E8", Offset = "0xF498E8", VA = "0xF498E8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xF499B4", Offset = "0xF499B4", VA = "0xF499B4")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xF49D10", Offset = "0xF49D10", VA = "0xF49D10")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4D08", Offset = "0x4C4D08")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C4D08", Offset = "0x4C4D08")]
		public float weight;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C4D5C", Offset = "0x4C4D5C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000018")]
		public bool initiated
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0xF49D20", Offset = "0xF49D20", VA = "0xF49D20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA65C", Offset = "0x4CA65C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000136")]
			[Address(RVA = "0xF49D28", Offset = "0xF49D28", VA = "0xF49D28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA66C", Offset = "0x4CA66C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xF49D34", Offset = "0xF49D34", VA = "0xF49D34")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xF49DBC", Offset = "0xF49DBC", VA = "0xF49DBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CA67C", Offset = "0x4CA67C")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xF4A0F4", Offset = "0xF4A0F4", VA = "0xF4A0F4")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xF4A26C", Offset = "0xF4A26C", VA = "0xF4A26C")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xF49FF8", Offset = "0xF49FF8", VA = "0xF49FF8")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xF4A3DC", Offset = "0xF4A3DC", VA = "0xF4A3DC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xF4A49C", Offset = "0xF4A49C", VA = "0xF4A49C")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xF4A520", Offset = "0xF4A520", VA = "0xF4A520")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xF4A588", Offset = "0xF4A588", VA = "0xF4A588", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xF4A58C", Offset = "0xF4A58C", VA = "0xF4A58C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xF4A590", Offset = "0xF4A590", VA = "0xF4A590")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4D6C", Offset = "0x4C4D6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C4D6C", Offset = "0x4C4D6C")]
		public float weight;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4DC0", Offset = "0x4C4DC0")]
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
		[Address(RVA = "0xF4B2CC", Offset = "0xF4B2CC", VA = "0xF4B2CC")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xF4B478", Offset = "0xF4B478", VA = "0xF4B478")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xF4B378", Offset = "0xF4B378", VA = "0xF4B378")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xF4B4AC", Offset = "0xF4B4AC", VA = "0xF4B4AC")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000147")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000148")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xF4B5E8", Offset = "0xF4B5E8", VA = "0xF4B5E8")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C3B6C", Offset = "0x4C3B6C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C3B6C", Offset = "0x4C3B6C")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4DF8", Offset = "0x4C4DF8")]
		public BipedIK ik;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4E30", Offset = "0x4C4E30")]
		public float spineBend;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4E68", Offset = "0x4C4E68")]
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
		[Address(RVA = "0xF4B6E0", Offset = "0xF4B6E0", VA = "0xF4B6E0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CA6B4", Offset = "0x4CA6B4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xF4B728", Offset = "0xF4B728", VA = "0xF4B728", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CA6EC", Offset = "0x4CA6EC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xF4B770", Offset = "0xF4B770", VA = "0xF4B770", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xF4B838", Offset = "0xF4B838", VA = "0xF4B838")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xF4B8E4", Offset = "0xF4B8E4", VA = "0xF4B8E4")]
		private void Update()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xF4B944", Offset = "0xF4B944", VA = "0xF4B944")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xF4BE8C", Offset = "0xF4BE8C", VA = "0xF4BE8C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xF4BEE0", Offset = "0xF4BEE0", VA = "0xF4BEE0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xF4C51C", Offset = "0xF4C51C", VA = "0xF4C51C")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xF4C634", Offset = "0xF4C634", VA = "0xF4C634")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xF4C774", Offset = "0xF4C774", VA = "0xF4C774")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xF4C904", Offset = "0xF4C904", VA = "0xF4C904")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C3BCC", Offset = "0x4C3BCC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C3BCC", Offset = "0x4C3BCC")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x200007F")]
		public class SpineEffector
		{
			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7A10", Offset = "0x4C7A10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7A48", Offset = "0x4C7A48")]
			public float horizontalWeight;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7A80", Offset = "0x4C7A80")]
			public float verticalWeight;

			[Token(Token = "0x6000491")]
			[Address(RVA = "0xFB209C", Offset = "0xFB209C", VA = "0xFB209C")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0xFB20AC", Offset = "0xFB20AC", VA = "0xFB20AC")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4EA0", Offset = "0x4C4EA0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4ED8", Offset = "0x4C4ED8")]
		public float spineBend;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4F10", Offset = "0x4C4F10")]
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
		[Address(RVA = "0xF4C98C", Offset = "0xF4C98C", VA = "0xF4C98C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CA724", Offset = "0x4CA724")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xF4C9D4", Offset = "0xF4C9D4", VA = "0xF4C9D4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CA75C", Offset = "0x4CA75C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xF4CA1C", Offset = "0xF4CA1C", VA = "0xF4CA1C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CA794", Offset = "0x4CA794")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xF4CA64", Offset = "0xF4CA64", VA = "0xF4CA64", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xF4CAA0", Offset = "0xF4CAA0", VA = "0xF4CAA0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xF4CB34", Offset = "0xF4CB34", VA = "0xF4CB34")]
		private void Update()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xF4CDB0", Offset = "0xF4CDB0", VA = "0xF4CDB0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xF4CDBC", Offset = "0xF4CDBC", VA = "0xF4CDBC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xF4CB9C", Offset = "0xF4CB9C", VA = "0xF4CB9C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xF4CDC8", Offset = "0xF4CDC8", VA = "0xF4CDC8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xF4D0E4", Offset = "0xF4D0E4", VA = "0xF4D0E4")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xF4D1F4", Offset = "0xF4D1F4", VA = "0xF4D1F4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xF4D34C", Offset = "0xF4D34C", VA = "0xF4D34C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xF4D460", Offset = "0xF4D460", VA = "0xF4D460")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C3C2C", Offset = "0x4C3C2C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C3C2C", Offset = "0x4C3C2C")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4F48", Offset = "0x4C4F48")]
		public Transform pelvis;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4F80", Offset = "0x4C4F80")]
		public Transform characterRoot;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C4FB8", Offset = "0x4C4FB8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C4FB8", Offset = "0x4C4FB8")]
		public float rootRotationWeight;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C500C", Offset = "0x4C500C")]
		public float rootRotationSpeed;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5044", Offset = "0x4C5044")]
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
		[Address(RVA = "0xF4D4E8", Offset = "0xF4D4E8", VA = "0xF4D4E8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CA7CC", Offset = "0x4CA7CC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xF4D530", Offset = "0xF4D530", VA = "0xF4D530", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CA804", Offset = "0x4CA804")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xF4D578", Offset = "0xF4D578", VA = "0xF4D578", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xF4D590", Offset = "0xF4D590", VA = "0xF4D590")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xF4D7C4", Offset = "0xF4D7C4", VA = "0xF4D7C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xF4D8C0", Offset = "0xF4D8C0", VA = "0xF4D8C0")]
		private void Update()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xF4DD98", Offset = "0xF4DD98", VA = "0xF4DD98")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xF4E178", Offset = "0xF4E178", VA = "0xF4E178")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xF4E304", Offset = "0xF4E304", VA = "0xF4E304")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xF4E608", Offset = "0xF4E608", VA = "0xF4E608")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xF4E74C", Offset = "0xF4E74C", VA = "0xF4E74C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xF4E934", Offset = "0xF4E934", VA = "0xF4E934")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C3C8C", Offset = "0x4C3C8C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C3C8C", Offset = "0x4C3C8C")]
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
			[Address(RVA = "0xFB20F4", Offset = "0xFB20F4", VA = "0xFB20F4")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C507C", Offset = "0x4C507C")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C50B4", Offset = "0x4C50B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C50B4", Offset = "0x4C50B4")]
		public float rootRotationWeight;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5108", Offset = "0x4C5108")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C5108", Offset = "0x4C5108")]
		public float minRootRotation;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5160", Offset = "0x4C5160")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C5160", Offset = "0x4C5160")]
		public float maxRootRotation;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C51B8", Offset = "0x4C51B8")]
		public float rootRotationSpeed;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C51F0", Offset = "0x4C51F0")]
		public float maxLegOffset;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5228", Offset = "0x4C5228")]
		public float maxForeLegOffset;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5260", Offset = "0x4C5260")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C5260", Offset = "0x4C5260")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C52B4", Offset = "0x4C52B4")]
		public Transform characterRoot;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C52EC", Offset = "0x4C52EC")]
		public Transform pelvis;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5324", Offset = "0x4C5324")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C535C", Offset = "0x4C535C")]
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
		[Address(RVA = "0xF4E9BC", Offset = "0xF4E9BC", VA = "0xF4E9BC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CA83C", Offset = "0x4CA83C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xF4EA04", Offset = "0xF4EA04", VA = "0xF4EA04", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CA874", Offset = "0x4CA874")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xF4EA4C", Offset = "0xF4EA4C", VA = "0xF4EA4C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xF4EA80", Offset = "0xF4EA80", VA = "0xF4EA80")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xF4EBAC", Offset = "0xF4EBAC", VA = "0xF4EBAC")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xF4EDB0", Offset = "0xF4EDB0", VA = "0xF4EDB0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xF4EE18", Offset = "0xF4EE18", VA = "0xF4EE18")]
		private void Update()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xF4EE7C", Offset = "0xF4EE7C", VA = "0xF4EE7C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xF4F180", Offset = "0xF4F180", VA = "0xF4F180")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xF4F4C4", Offset = "0xF4F4C4", VA = "0xF4F4C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xF4F5BC", Offset = "0xF4F5BC", VA = "0xF4F5BC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xF4F870", Offset = "0xF4F870", VA = "0xF4F870")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xF4FE8C", Offset = "0xF4FE8C", VA = "0xF4FE8C")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xF5005C", Offset = "0xF5005C", VA = "0xF5005C")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xF50138", Offset = "0xF50138", VA = "0xF50138")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xF50380", Offset = "0xF50380", VA = "0xF50380")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xF503B8", Offset = "0xF503B8", VA = "0xF503B8")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xF50598", Offset = "0xF50598", VA = "0xF50598")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C3CEC", Offset = "0x4C3CEC")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C53A4", Offset = "0x4C53A4")]
		public VRIK ik;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xF5068C", Offset = "0xF5068C", VA = "0xF5068C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CA8AC", Offset = "0x4CA8AC")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xF50690", Offset = "0xF50690", VA = "0xF50690", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CA8E4", Offset = "0x4CA8E4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xF50694", Offset = "0xF50694", VA = "0xF50694", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CA91C", Offset = "0x4CA91C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xF50698", Offset = "0xF50698", VA = "0xF50698", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xF506B0", Offset = "0xF506B0", VA = "0xF506B0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xF50744", Offset = "0xF50744", VA = "0xF50744")]
		private void Update()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xF507A4", Offset = "0xF507A4", VA = "0xF507A4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xF509C4", Offset = "0xF509C4", VA = "0xF509C4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xF50BB4", Offset = "0xF50BB4", VA = "0xF50BB4")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xF50C44", Offset = "0xF50C44", VA = "0xF50C44")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xF50E00", Offset = "0xF50E00", VA = "0xF50E00")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xF50F58", Offset = "0xF50F58", VA = "0xF50F58")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xF510D8", Offset = "0xF510D8", VA = "0xF510D8")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C7AB8", Offset = "0x4C7AB8")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C7AC8", Offset = "0x4C7AC8")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C7AD8", Offset = "0x4C7AD8")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C7AE8", Offset = "0x4C7AE8")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C7AF8", Offset = "0x4C7AF8")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C7B08", Offset = "0x4C7B08")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C7B18", Offset = "0x4C7B18")]
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
				[Address(RVA = "0xFB2134", Offset = "0xFB2134", VA = "0xFB2134")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC024", Offset = "0x4CC024")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000495")]
				[Address(RVA = "0xFB213C", Offset = "0xFB213C", VA = "0xFB213C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC034", Offset = "0x4CC034")]
				private set
				{
				}
			}

			[Token(Token = "0x17000065")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000496")]
				[Address(RVA = "0xFB2148", Offset = "0xFB2148", VA = "0xFB2148")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC044", Offset = "0x4CC044")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000497")]
				[Address(RVA = "0xFB2154", Offset = "0xFB2154", VA = "0xFB2154")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC054", Offset = "0x4CC054")]
				private set
				{
				}
			}

			[Token(Token = "0x17000066")]
			public bool initiated
			{
				[Token(Token = "0x6000498")]
				[Address(RVA = "0xFB2160", Offset = "0xFB2160", VA = "0xFB2160")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC064", Offset = "0x4CC064")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000499")]
				[Address(RVA = "0xFB2168", Offset = "0xFB2168", VA = "0xFB2168")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC074", Offset = "0x4CC074")]
				private set
				{
				}
			}

			[Token(Token = "0x17000067")]
			public float heightFromGround
			{
				[Token(Token = "0x600049A")]
				[Address(RVA = "0xFB2174", Offset = "0xFB2174", VA = "0xFB2174")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC084", Offset = "0x4CC084")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600049B")]
				[Address(RVA = "0xFB217C", Offset = "0xFB217C", VA = "0xFB217C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC094", Offset = "0x4CC094")]
				private set
				{
				}
			}

			[Token(Token = "0x17000068")]
			public Vector3 velocity
			{
				[Token(Token = "0x600049C")]
				[Address(RVA = "0xFB2184", Offset = "0xFB2184", VA = "0xFB2184")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC0A4", Offset = "0x4CC0A4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600049D")]
				[Address(RVA = "0xFB2190", Offset = "0xFB2190", VA = "0xFB2190")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC0B4", Offset = "0x4CC0B4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000069")]
			public Transform transform
			{
				[Token(Token = "0x600049E")]
				[Address(RVA = "0xFB219C", Offset = "0xFB219C", VA = "0xFB219C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC0C4", Offset = "0x4CC0C4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600049F")]
				[Address(RVA = "0xFB21A4", Offset = "0xFB21A4", VA = "0xFB21A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC0D4", Offset = "0x4CC0D4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006A")]
			public float IKOffset
			{
				[Token(Token = "0x60004A0")]
				[Address(RVA = "0xFB21AC", Offset = "0xFB21AC", VA = "0xFB21AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC0E4", Offset = "0x4CC0E4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60004A1")]
				[Address(RVA = "0xFB21B4", Offset = "0xFB21B4", VA = "0xFB21B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC0F4", Offset = "0x4CC0F4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006B")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60004A6")]
				[Address(RVA = "0xFB2E60", Offset = "0xFB2E60", VA = "0xFB2E60")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700006C")]
			private float rootYOffset
			{
				[Token(Token = "0x60004AF")]
				[Address(RVA = "0xFB2FE0", Offset = "0xFB2FE0", VA = "0xFB2FE0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xFB21BC", Offset = "0xFB21BC", VA = "0xFB21BC")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xFB2230", Offset = "0xFB2230", VA = "0xFB2230")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0xFB227C", Offset = "0xFB227C", VA = "0xFB227C")]
			public void Reset()
			{
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0xFB22EC", Offset = "0xFB22EC", VA = "0xFB22EC")]
			public void Process()
			{
			}

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0xFB2C1C", Offset = "0xFB2C1C", VA = "0xFB2C1C")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0xFB28F0", Offset = "0xFB28F0", VA = "0xFB28F0")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60004A9")]
			[Address(RVA = "0xFB2EF4", Offset = "0xFB2EF4", VA = "0xFB2EF4")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0xFB2A58", Offset = "0xFB2A58", VA = "0xFB2A58")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0xFB2AE4", Offset = "0xFB2AE4", VA = "0xFB2AE4")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0xFB2F64", Offset = "0xFB2F64", VA = "0xFB2F64")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0xFB2E88", Offset = "0xFB2E88", VA = "0xFB2E88")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0xFB308C", Offset = "0xFB308C", VA = "0xFB308C")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0xFB3118", Offset = "0xFB3118", VA = "0xFB3118")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000083")]
		public class Pelvis
		{
			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C7B28", Offset = "0x4C7B28")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C7B38", Offset = "0x4C7B38")]
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
				[Address(RVA = "0xFB315C", Offset = "0xFB315C", VA = "0xFB315C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC104", Offset = "0x4CC104")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60004B2")]
				[Address(RVA = "0xFB3168", Offset = "0xFB3168", VA = "0xFB3168")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC114", Offset = "0x4CC114")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			public float heightOffset
			{
				[Token(Token = "0x60004B3")]
				[Address(RVA = "0xFB3174", Offset = "0xFB3174", VA = "0xFB3174")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC124", Offset = "0x4CC124")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60004B4")]
				[Address(RVA = "0xFB317C", Offset = "0xFB317C", VA = "0xFB317C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC134", Offset = "0x4CC134")]
				private set
				{
				}
			}

			[Token(Token = "0x60004B5")]
			[Address(RVA = "0xFB3184", Offset = "0xFB3184", VA = "0xFB3184")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60004B6")]
			[Address(RVA = "0xFB31F4", Offset = "0xFB31F4", VA = "0xFB31F4")]
			public void Reset()
			{
			}

			[Token(Token = "0x60004B7")]
			[Address(RVA = "0xFB3194", Offset = "0xFB3194", VA = "0xFB3194")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60004B8")]
			[Address(RVA = "0xFB3260", Offset = "0xFB3260", VA = "0xFB3260")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60004B9")]
			[Address(RVA = "0xFB3400", Offset = "0xFB3400", VA = "0xFB3400")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C53DC", Offset = "0x4C53DC")]
		public LayerMask layers;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5414", Offset = "0x4C5414")]
		public float maxStep;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C544C", Offset = "0x4C544C")]
		public float heightOffset;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5484", Offset = "0x4C5484")]
		public float footSpeed;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C54BC", Offset = "0x4C54BC")]
		public float footRadius;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C54F4", Offset = "0x4C54F4")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5540", Offset = "0x4C5540")]
		public float prediction;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5578", Offset = "0x4C5578")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C5578", Offset = "0x4C5578")]
		public float footRotationWeight;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C55CC", Offset = "0x4C55CC")]
		public float footRotationSpeed;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5604", Offset = "0x4C5604")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C5604", Offset = "0x4C5604")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C565C", Offset = "0x4C565C")]
		public bool rotateSolver;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5694", Offset = "0x4C5694")]
		public float pelvisSpeed;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C56CC", Offset = "0x4C56CC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C56CC", Offset = "0x4C56CC")]
		public float pelvisDamper;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5720", Offset = "0x4C5720")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5758", Offset = "0x4C5758")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5790", Offset = "0x4C5790")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C57C8", Offset = "0x4C57C8")]
		public Quality quality;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C5800", Offset = "0x4C5800")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C5810", Offset = "0x4C5810")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C5820", Offset = "0x4C5820")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C5830", Offset = "0x4C5830")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C5840", Offset = "0x4C5840")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000019")]
		public Leg[] legs
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0xF51130", Offset = "0xF51130", VA = "0xF51130")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA954", Offset = "0x4CA954")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000190")]
			[Address(RVA = "0xF51138", Offset = "0xF51138", VA = "0xF51138")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA964", Offset = "0x4CA964")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0xF51140", Offset = "0xF51140", VA = "0xF51140")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA974", Offset = "0x4CA974")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000192")]
			[Address(RVA = "0xF51148", Offset = "0xF51148", VA = "0xF51148")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA984", Offset = "0x4CA984")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool isGrounded
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0xF51150", Offset = "0xF51150", VA = "0xF51150")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA994", Offset = "0x4CA994")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000194")]
			[Address(RVA = "0xF51158", Offset = "0xF51158", VA = "0xF51158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA9A4", Offset = "0x4CA9A4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public Transform root
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0xF51164", Offset = "0xF51164", VA = "0xF51164")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA9B4", Offset = "0x4CA9B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000196")]
			[Address(RVA = "0xF5116C", Offset = "0xF5116C", VA = "0xF5116C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA9C4", Offset = "0x4CA9C4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0xF51174", Offset = "0xF51174", VA = "0xF51174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA9D4", Offset = "0x4CA9D4")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x6000198")]
			[Address(RVA = "0xF5118C", Offset = "0xF5118C", VA = "0xF5118C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CA9E4", Offset = "0x4CA9E4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0xF511AC", Offset = "0xF511AC", VA = "0xF511AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public Vector3 up
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0xF4C5F0", Offset = "0xF4C5F0", VA = "0xF4C5F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000020")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0xF51564", Offset = "0xF51564", VA = "0xF51564")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xF51200", Offset = "0xF51200", VA = "0xF51200")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xF51444", Offset = "0xF51444", VA = "0xF51444")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xF4BC04", Offset = "0xF4BC04", VA = "0xF4BC04")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xF4C2D4", Offset = "0xF4C2D4", VA = "0xF4C2D4")]
		public void Update()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xF4DC38", Offset = "0xF4DC38", VA = "0xF4DC38")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xF4B7AC", Offset = "0xF4B7AC", VA = "0xF4B7AC")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xF5154C", Offset = "0xF5154C", VA = "0xF5154C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xF515E4", Offset = "0xF515E4", VA = "0xF515E4")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xF51674", Offset = "0xF51674", VA = "0xF51674")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xF51730", Offset = "0xF51730", VA = "0xF51730")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xF4B698", Offset = "0xF4B698", VA = "0xF4B698")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C3D24", Offset = "0x4C3D24")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C3D24", Offset = "0x4C3D24")]
	public class AimIK : IK
	{
		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xEDE640", Offset = "0xEDE640", VA = "0xEDE640", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CA9F4", Offset = "0x4CA9F4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xEDE688", Offset = "0xEDE688", VA = "0xEDE688", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAA2C", Offset = "0x4CAA2C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xEDE6D0", Offset = "0xEDE6D0", VA = "0xEDE6D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAA64", Offset = "0x4CAA64")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xEDE718", Offset = "0xEDE718", VA = "0xEDE718")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAA9C", Offset = "0x4CAA9C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xEDE760", Offset = "0xEDE760", VA = "0xEDE760")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAAD4", Offset = "0x4CAAD4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xEDE7A8", Offset = "0xEDE7A8", VA = "0xEDE7A8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xEDE7B0", Offset = "0xEDE7B0", VA = "0xEDE7B0")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C3D84", Offset = "0x4C3D84")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C3D84", Offset = "0x4C3D84")]
	public class CCDIK : IK
	{
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xEE6ED4", Offset = "0xEE6ED4", VA = "0xEE6ED4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAB0C", Offset = "0x4CAB0C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xEE6F1C", Offset = "0xEE6F1C", VA = "0xEE6F1C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAB44", Offset = "0x4CAB44")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xEE6F64", Offset = "0xEE6F64", VA = "0xEE6F64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAB7C", Offset = "0x4CAB7C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xEE6FAC", Offset = "0xEE6FAC", VA = "0xEE6FAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CABB4", Offset = "0x4CABB4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xEE6FF4", Offset = "0xEE6FF4", VA = "0xEE6FF4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xEE6FFC", Offset = "0xEE6FFC", VA = "0xEE6FFC")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C3DE4", Offset = "0x4C3DE4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C3DE4", Offset = "0x4C3DE4")]
	public class FABRIK : IK
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xEEB4AC", Offset = "0xEEB4AC", VA = "0xEEB4AC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CABEC", Offset = "0x4CABEC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xEEB4F4", Offset = "0xEEB4F4", VA = "0xEEB4F4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAC24", Offset = "0x4CAC24")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xEEB53C", Offset = "0xEEB53C", VA = "0xEEB53C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAC5C", Offset = "0x4CAC5C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xEEB584", Offset = "0xEEB584", VA = "0xEEB584")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAC94", Offset = "0x4CAC94")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xEEB5CC", Offset = "0xEEB5CC", VA = "0xEEB5CC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xEEB5D4", Offset = "0xEEB5D4", VA = "0xEEB5D4")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C3E44", Offset = "0x4C3E44")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C3E44", Offset = "0x4C3E44")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xEEBAF8", Offset = "0xEEBAF8", VA = "0xEEBAF8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CACCC", Offset = "0x4CACCC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xEEBB40", Offset = "0xEEBB40", VA = "0xEEBB40", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAD04", Offset = "0x4CAD04")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xEEBB88", Offset = "0xEEBB88", VA = "0xEEBB88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAD3C", Offset = "0x4CAD3C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xEEBBD0", Offset = "0xEEBBD0", VA = "0xEEBBD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAD74", Offset = "0x4CAD74")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xEEBC18", Offset = "0xEEBC18", VA = "0xEEBC18", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xEEBC20", Offset = "0xEEBC20", VA = "0xEEBC20")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C3EA4", Offset = "0x4C3EA4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C3EA4", Offset = "0x4C3EA4")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xF4A5F4", Offset = "0xF4A5F4", VA = "0xF4A5F4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CADAC", Offset = "0x4CADAC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xF4A63C", Offset = "0xF4A63C", VA = "0xF4A63C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CADE4", Offset = "0x4CADE4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xF4A684", Offset = "0xF4A684", VA = "0xF4A684")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAE1C", Offset = "0x4CAE1C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xF4A6CC", Offset = "0xF4A6CC", VA = "0xF4A6CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAE54", Offset = "0x4CAE54")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xF4A714", Offset = "0xF4A714", VA = "0xF4A714")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAE8C", Offset = "0x4CAE8C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xF4A75C", Offset = "0xF4A75C", VA = "0xF4A75C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAEC4", Offset = "0x4CAEC4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xF4A7A4", Offset = "0xF4A7A4", VA = "0xF4A7A4")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xF4A7C8", Offset = "0xF4A7C8", VA = "0xF4A7C8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xF4A7D0", Offset = "0xF4A7D0", VA = "0xF4A7D0")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xF4A9AC", Offset = "0xF4A9AC", VA = "0xF4A9AC")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xF4AC40", Offset = "0xF4AC40", VA = "0xF4AC40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAEFC", Offset = "0x4CAEFC")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xF4AC60", Offset = "0xF4AC60", VA = "0xF4AC60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAF34", Offset = "0x4CAF34")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xF4AD38", Offset = "0xF4AD38", VA = "0xF4AD38")]
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
		[Address(RVA = "0xF53480", Offset = "0xF53480", VA = "0xF53480", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xF53504", Offset = "0xF53504", VA = "0xF53504", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xF53574", Offset = "0xF53574", VA = "0xF53574", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60001D1")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60001D2")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xF4ADC8", Offset = "0xF4ADC8", VA = "0xF4ADC8")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5850", Offset = "0x4C5850")]
		public IK[] IKComponents;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5888", Offset = "0x4C5888")]
		public Animator animator;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000021")]
		private bool animatePhysics
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0xF55AE0", Offset = "0xF55AE0", VA = "0xF55AE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xF55B78", Offset = "0xF55B78", VA = "0xF55B78")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xF55BE8", Offset = "0xF55BE8", VA = "0xF55BE8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xF55CA4", Offset = "0xF55CA4", VA = "0xF55CA4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xF55CE0", Offset = "0xF55CE0", VA = "0xF55CE0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xF55C1C", Offset = "0xF55C1C", VA = "0xF55C1C")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xF55D6C", Offset = "0xF55D6C", VA = "0xF55D6C")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C3F04", Offset = "0x4C3F04")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xED5470", Offset = "0xED5470", VA = "0xED5470", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAF6C", Offset = "0x4CAF6C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xED54E4", Offset = "0xED54E4", VA = "0xED54E4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAFA4", Offset = "0x4CAFA4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xED5558", Offset = "0xED5558", VA = "0xED5558")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CAFDC", Offset = "0x4CAFDC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xED55A0", Offset = "0xED55A0", VA = "0xED55A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB014", Offset = "0x4CB014")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xED55E8", Offset = "0xED55E8", VA = "0xED55E8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xED55F0", Offset = "0xED55F0", VA = "0xED55F0")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C3F3C", Offset = "0x4C3F3C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C3F3C", Offset = "0x4C3F3C")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xED5654", Offset = "0xED5654", VA = "0xED5654", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB04C", Offset = "0x4CB04C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xED569C", Offset = "0xED569C", VA = "0xED569C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB084", Offset = "0x4CB084")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xED56E4", Offset = "0xED56E4", VA = "0xED56E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB0BC", Offset = "0x4CB0BC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xED572C", Offset = "0xED572C", VA = "0xED572C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB0F4", Offset = "0x4CB0F4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xED5774", Offset = "0xED5774", VA = "0xED5774", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xED577C", Offset = "0xED577C", VA = "0xED577C")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C3F9C", Offset = "0x4C3F9C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C3F9C", Offset = "0x4C3F9C")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xED57E0", Offset = "0xED57E0", VA = "0xED57E0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB12C", Offset = "0x4CB12C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xED5828", Offset = "0xED5828", VA = "0xED5828", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB164", Offset = "0x4CB164")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xED5870", Offset = "0xED5870", VA = "0xED5870")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB19C", Offset = "0x4CB19C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xED58B8", Offset = "0xED58B8", VA = "0xED58B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB1D4", Offset = "0x4CB1D4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xED5900", Offset = "0xED5900", VA = "0xED5900", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xED5908", Offset = "0xED5908", VA = "0xED5908")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C3FFC", Offset = "0x4C3FFC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C3FFC", Offset = "0x4C3FFC")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xEDC400", Offset = "0xEDC400", VA = "0xEDC400", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB20C", Offset = "0x4CB20C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xEDC448", Offset = "0xEDC448", VA = "0xEDC448", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB244", Offset = "0x4CB244")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xEDC490", Offset = "0xEDC490", VA = "0xEDC490")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB27C", Offset = "0x4CB27C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xEDC4D8", Offset = "0xEDC4D8", VA = "0xEDC4D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB2B4", Offset = "0x4CB2B4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xEDC520", Offset = "0xEDC520", VA = "0xEDC520", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xEDC528", Offset = "0xEDC528", VA = "0xEDC528")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C405C", Offset = "0x4C405C")]
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
				[Address(RVA = "0x10F0074", Offset = "0x10F0074", VA = "0x10F0074")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000070")]
			public bool isEmpty
			{
				[Token(Token = "0x60004BC")]
				[Address(RVA = "0x10F03CC", Offset = "0x10F03CC", VA = "0x10F03CC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x10EFC2C", Offset = "0x10EFC2C", VA = "0x10EFC2C")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x10F0844", Offset = "0x10F0844", VA = "0x10F0844")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x10F0BE0", Offset = "0x10F0BE0", VA = "0x10F0BE0")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x4C58C0", Offset = "0x4C58C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C58C0", Offset = "0x4C58C0")]
		public References references;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C593C", Offset = "0x4C593C")]
		public IKSolverVR solver;

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xEDD954", Offset = "0xEDD954", VA = "0xEDD954", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB2EC", Offset = "0x4CB2EC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xEDD9C8", Offset = "0xEDD9C8", VA = "0xEDD9C8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB324", Offset = "0x4CB324")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xEDDA3C", Offset = "0xEDDA3C", VA = "0xEDDA3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB35C", Offset = "0x4CB35C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xEDDA84", Offset = "0xEDDA84", VA = "0xEDDA84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB394", Offset = "0x4CB394")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xEDDAB0", Offset = "0xEDDAB0", VA = "0xEDDAB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB3CC", Offset = "0x4CB3CC")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xEDDAD8", Offset = "0xEDDAD8", VA = "0xEDDAD8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xEDDAE0", Offset = "0xEDDAE0", VA = "0xEDDAE0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xEDDB60", Offset = "0xEDDB60", VA = "0xEDDB60")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C5974", Offset = "0x4C5974")]
		public float pull;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C598C", Offset = "0x4C598C")]
		public float pin;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xEEB638", Offset = "0xEEB638", VA = "0xEEB638")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xEEB708", Offset = "0xEEB708", VA = "0xEEB708")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xEEB728", Offset = "0xEEB728", VA = "0xEEB728")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xEEB99C", Offset = "0xEEB99C", VA = "0xEEB99C")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xEEB7FC", Offset = "0xEEB7FC", VA = "0xEEB7FC")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xEEBA94", Offset = "0xEEBA94", VA = "0xEEBA94")]
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
		[Address(RVA = "0xEEBC84", Offset = "0xEEBC84", VA = "0xEEBC84")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xEEC0E8", Offset = "0xEEC0E8", VA = "0xEEC0E8")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xEEC2A4", Offset = "0xEEC2A4", VA = "0xEEC2A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xEEC3B0", Offset = "0xEEC3B0", VA = "0xEEC3B0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7B48", Offset = "0x4C7B48")]
			public Transform transform;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7B80", Offset = "0x4C7B80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C7B80", Offset = "0x4C7B80")]
			public float weight;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60004BF")]
			[Address(RVA = "0xFB16C8", Offset = "0xFB16C8", VA = "0xFB16C8")]
			public BendBone()
			{
			}

			[Token(Token = "0x60004C0")]
			[Address(RVA = "0xFB1704", Offset = "0xFB1704", VA = "0xFB1704")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60004C1")]
			[Address(RVA = "0xFB175C", Offset = "0xFB175C", VA = "0xFB175C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60004C2")]
			[Address(RVA = "0xFB1794", Offset = "0xFB1794", VA = "0xFB1794")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C59A4", Offset = "0x4C59A4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x4C59DC", Offset = "0x4C59DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C59DC", Offset = "0x4C59DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C59DC", Offset = "0x4C59DC")]
		public float positionWeight;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5A54", Offset = "0x4C5A54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C5A54", Offset = "0x4C5A54")]
		public float bodyWeight;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5AA8", Offset = "0x4C5AA8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C5AA8", Offset = "0x4C5AA8")]
		public float thighWeight;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5AFC", Offset = "0x4C5AFC")]
		public bool handsPullBody;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x4C5B34", Offset = "0x4C5B34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5B34", Offset = "0x4C5B34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C5B34", Offset = "0x4C5B34")]
		public float rotationWeight;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5BAC", Offset = "0x4C5BAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C5BAC", Offset = "0x4C5BAC")]
		public float bodyClampWeight;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5C00", Offset = "0x4C5C00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C5C00", Offset = "0x4C5C00")]
		public float headClampWeight;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5C54", Offset = "0x4C5C54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C5C54", Offset = "0x4C5C54")]
		public float bendWeight;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5CA8", Offset = "0x4C5CA8")]
		public BendBone[] bendBones;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x4C5CE0", Offset = "0x4C5CE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5CE0", Offset = "0x4C5CE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C5CE0", Offset = "0x4C5CE0")]
		public float CCDWeight;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5D58", Offset = "0x4C5D58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C5D58", Offset = "0x4C5D58")]
		public float roll;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5DAC", Offset = "0x4C5DAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C5DAC", Offset = "0x4C5DAC")]
		public float damper;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5E04", Offset = "0x4C5E04")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x4C5E3C", Offset = "0x4C5E3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5E3C", Offset = "0x4C5E3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C5E3C", Offset = "0x4C5E3C")]
		public float postStretchWeight;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5EB4", Offset = "0x4C5EB4")]
		public float maxStretch;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5EEC", Offset = "0x4C5EEC")]
		public float stretchDamper;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5F24", Offset = "0x4C5F24")]
		public bool fixHead;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C5F5C", Offset = "0x4C5F5C")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x4C5F94", Offset = "0x4C5F94")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C5FCC", Offset = "0x4C5FCC")]
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
		[Address(RVA = "0xEEC3B8", Offset = "0xEEC3B8", VA = "0xEEC3B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xEEC6EC", Offset = "0xEEC6EC", VA = "0xEEC6EC")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xEECB8C", Offset = "0xEECB8C", VA = "0xEECB8C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xEECF58", Offset = "0xEECF58", VA = "0xEECF58")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xEED6E4", Offset = "0xEED6E4", VA = "0xEED6E4")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xEED9C4", Offset = "0xEED9C4", VA = "0xEED9C4")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xEEDCC8", Offset = "0xEEDCC8", VA = "0xEEDCC8")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xEEE49C", Offset = "0xEEE49C", VA = "0xEEE49C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xEED4C8", Offset = "0xEED4C8", VA = "0xEED4C8")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xEEE664", Offset = "0xEEE664", VA = "0xEEE664")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xEEE3B4", Offset = "0xEEE3B4", VA = "0xEEE3B4")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xEEE2E8", Offset = "0xEEE2E8", VA = "0xEEE2E8")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xEEE8E8", Offset = "0xEEE8E8", VA = "0xEEE8E8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xEEEBB8", Offset = "0xEEEBB8", VA = "0xEEEBB8")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C7BF4", Offset = "0x4C7BF4")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C7C04", Offset = "0x4C7C04")]
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
				[Address(RVA = "0xFB17BC", Offset = "0xFB17BC", VA = "0xFB17BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC144", Offset = "0x4CC144")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60004C4")]
				[Address(RVA = "0xFB17C4", Offset = "0xFB17C4", VA = "0xFB17C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC154", Offset = "0x4CC154")]
				private set
				{
				}
			}

			[Token(Token = "0x17000072")]
			public bool isRigid
			{
				[Token(Token = "0x60004C5")]
				[Address(RVA = "0xFB17CC", Offset = "0xFB17CC", VA = "0xFB17CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC164", Offset = "0x4CC164")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60004C6")]
				[Address(RVA = "0xFB17D4", Offset = "0xFB17D4", VA = "0xFB17D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC174", Offset = "0x4CC174")]
				private set
				{
				}
			}

			[Token(Token = "0x60004C7")]
			[Address(RVA = "0xFB17E0", Offset = "0xFB17E0", VA = "0xFB17E0")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60004C8")]
			[Address(RVA = "0xFB182C", Offset = "0xFB182C", VA = "0xFB182C")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60004C9")]
			[Address(RVA = "0xFB1884", Offset = "0xFB1884", VA = "0xFB1884")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60004CA")]
			[Address(RVA = "0xFB1A28", Offset = "0xFB1A28", VA = "0xFB1A28")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C5FE4", Offset = "0x4C5FE4")]
		public float pin;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C5FFC", Offset = "0x4C5FFC")]
		public float pull;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6014", Offset = "0x4C6014")]
		public float push;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C602C", Offset = "0x4C602C")]
		public float pushParent;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6044", Offset = "0x4C6044")]
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
		[Address(RVA = "0xEEED34", Offset = "0xEEED34", VA = "0xEEED34")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xEEEE20", Offset = "0xEEEE20", VA = "0xEEEE20")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xEEEF4C", Offset = "0xEEEF4C", VA = "0xEEEF4C")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xEEF078", Offset = "0xEEF078", VA = "0xEEF078")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xEEF150", Offset = "0xEEF150", VA = "0xEEF150")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xEEF268", Offset = "0xEEF268", VA = "0xEEF268")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xEEF8E4", Offset = "0xEEF8E4", VA = "0xEEF8E4")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xEEF3F8", Offset = "0xEEF3F8", VA = "0xEEF3F8")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xEEFCD4", Offset = "0xEEFCD4", VA = "0xEEFCD4")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xEEFF34", Offset = "0xEEFF34", VA = "0xEEFF34")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xEF01A0", Offset = "0xEF01A0", VA = "0xEF01A0")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xEF0544", Offset = "0xEF0544", VA = "0xEF0544")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xEF09D8", Offset = "0xEF09D8", VA = "0xEF09D8")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xEF0BFC", Offset = "0xEF0BFC", VA = "0xEF0BFC")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xEF0968", Offset = "0xEF0968", VA = "0xEF0968")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xEF03D0", Offset = "0xEF03D0", VA = "0xEF03D0")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xEF08EC", Offset = "0xEF08EC", VA = "0xEF08EC")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xEF0CE4", Offset = "0xEF0CE4", VA = "0xEF0CE4")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xEF080C", Offset = "0xEF080C", VA = "0xEF080C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xEF0AE4", Offset = "0xEF0AE4", VA = "0xEF0AE4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C605C", Offset = "0x4C605C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C6074", Offset = "0x4C6074")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000022")]
		public bool initiated
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0xF537BC", Offset = "0xF537BC", VA = "0xF537BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB404", Offset = "0x4CB404")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000229")]
			[Address(RVA = "0xF537C4", Offset = "0xF537C4", VA = "0xF537C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB414", Offset = "0x4CB414")]
			private set
			{
			}
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xF535D4", Offset = "0xF535D4", VA = "0xF535D4")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xF537D0", Offset = "0xF537D0", VA = "0xF537D0")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xF53810", Offset = "0xF53810", VA = "0xF53810")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xF53870", Offset = "0xF53870", VA = "0xF53870")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xF5387C", Offset = "0xF5387C", VA = "0xF5387C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xF53B88", Offset = "0xF53B88", VA = "0xF53B88")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xF53D70", Offset = "0xF53D70", VA = "0xF53D70")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xF540BC", Offset = "0xF540BC", VA = "0xF540BC")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xF53A38", Offset = "0xF53A38", VA = "0xF53A38")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xF53AE0", Offset = "0xF53AE0", VA = "0xF53AE0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6084", Offset = "0x4C6084")]
		public float positionWeight;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C609C", Offset = "0x4C609C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C60B4", Offset = "0x4C60B4")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C60C4", Offset = "0x4C60C4")]
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
			[Address(RVA = "0xF54558", Offset = "0xF54558", VA = "0xF54558")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB424", Offset = "0x4CB424")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000235")]
			[Address(RVA = "0xF54560", Offset = "0xF54560", VA = "0xF54560")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB434", Offset = "0x4CB434")]
			private set
			{
			}
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xF544F0", Offset = "0xF544F0", VA = "0xF544F0")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xF5456C", Offset = "0xF5456C", VA = "0xF5456C")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xF545FC", Offset = "0xF545FC", VA = "0xF545FC")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xF54710", Offset = "0xF54710", VA = "0xF54710")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xF54840", Offset = "0xF54840", VA = "0xF54840")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xF54B5C", Offset = "0xF54B5C", VA = "0xF54B5C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xF54DF0", Offset = "0xF54DF0", VA = "0xF54DF0")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xF54EC4", Offset = "0xF54EC4", VA = "0xF54EC4")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xF54F6C", Offset = "0xF54F6C", VA = "0xF54F6C")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xF554A8", Offset = "0xF554A8", VA = "0xF554A8")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xF554D4", Offset = "0xF554D4", VA = "0xF554D4")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xF55634", Offset = "0xF55634", VA = "0xF55634")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xF558C0", Offset = "0xF558C0", VA = "0xF558C0")]
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
				[Address(RVA = "0xFB4768", Offset = "0xFB4768", VA = "0xFB4768")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000074")]
			public bool isNodeBone
			{
				[Token(Token = "0x60004CF")]
				[Address(RVA = "0xFB4844", Offset = "0xFB4844", VA = "0xFB4844")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000075")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60004E3")]
				[Address(RVA = "0xFB4BE8", Offset = "0xFB4BE8", VA = "0xFB4BE8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60004CB")]
			[Address(RVA = "0xFB473C", Offset = "0xFB473C", VA = "0xFB473C")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60004CD")]
			[Address(RVA = "0xFB47A4", Offset = "0xFB47A4", VA = "0xFB47A4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0xFB47F4", Offset = "0xFB47F4", VA = "0xFB47F4")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0xFB4854", Offset = "0xFB4854", VA = "0xFB4854")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0xFB48DC", Offset = "0xFB48DC", VA = "0xFB48DC")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0xFB48E4", Offset = "0xFB48E4", VA = "0xFB48E4")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0xFB49BC", Offset = "0xFB49BC", VA = "0xFB49BC")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0xFB4A34", Offset = "0xFB4A34", VA = "0xFB4A34")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xFB4ACC", Offset = "0xFB4ACC", VA = "0xFB4ACC")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0xFB4D28", Offset = "0xFB4D28", VA = "0xFB4D28")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0xFB4D60", Offset = "0xFB4D60", VA = "0xFB4D60")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0xFB4D98", Offset = "0xFB4D98", VA = "0xFB4D98")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0xFB4DC0", Offset = "0xFB4DC0", VA = "0xFB4DC0")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0xFB4EAC", Offset = "0xFB4EAC", VA = "0xFB4EAC")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0xFB5038", Offset = "0xFB5038", VA = "0xFB5038")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0xFB5068", Offset = "0xFB5068", VA = "0xFB5068")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0xFB5130", Offset = "0xFB5130", VA = "0xFB5130")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0xFB51A0", Offset = "0xFB51A0", VA = "0xFB51A0")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0xFB52F0", Offset = "0xFB52F0", VA = "0xFB52F0")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0xFB5440", Offset = "0xFB5440", VA = "0xFB5440")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0xFB54C0", Offset = "0xFB54C0", VA = "0xFB54C0")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0xFB4F28", Offset = "0xFB4F28", VA = "0xFB4F28")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0xFB55F8", Offset = "0xFB55F8", VA = "0xFB55F8")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xF55D74", Offset = "0xF55D74", VA = "0xF55D74", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xF55D7C", Offset = "0xF55D7C", VA = "0xF55D7C", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xF55D80", Offset = "0xF55D80", VA = "0xF55D80")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xF55EC4", Offset = "0xF55EC4", VA = "0xF55EC4")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xF55F34", Offset = "0xF55F34", VA = "0xF55F34")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C60DC", Offset = "0x4C60DC")]
		public float maintainRotationWeight;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xF55F3C", Offset = "0xF55F3C", VA = "0xF55F3C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xF55FE4", Offset = "0xF55FE4", VA = "0xF55FE4")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xF56050", Offset = "0xF56050", VA = "0xF56050")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xF560D0", Offset = "0xF560D0", VA = "0xF560D0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xF560EC", Offset = "0xF560EC", VA = "0xF560EC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xF5610C", Offset = "0xF5610C", VA = "0xF5610C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xF56194", Offset = "0xF56194", VA = "0xF56194")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xF561B0", Offset = "0xF561B0", VA = "0xF561B0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C60F4", Offset = "0x4C60F4")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C610C", Offset = "0x4C610C")]
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
		[Address(RVA = "0xF561D8", Offset = "0xF561D8", VA = "0xF561D8", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xF5625C", Offset = "0xF5625C", VA = "0xF5625C")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xF56338", Offset = "0xF56338", VA = "0xF56338")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xF5655C", Offset = "0xF5655C", VA = "0xF5655C")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xF56618", Offset = "0xF56618", VA = "0xF56618")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xF56700", Offset = "0xF56700", VA = "0xF56700")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xF5670C", Offset = "0xF5670C", VA = "0xF5670C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xF567C0", Offset = "0xF567C0", VA = "0xF567C0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xF56884", Offset = "0xF56884", VA = "0xF56884", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xF56AC4", Offset = "0xF56AC4", VA = "0xF56AC4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xF56B38", Offset = "0xF56B38", VA = "0xF56B38")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6124", Offset = "0x4C6124")]
		public int iterations;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C613C", Offset = "0x4C613C")]
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
		[Address(RVA = "0xF56CB8", Offset = "0xF56CB8", VA = "0xF56CB8", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xF5701C", Offset = "0xF5701C", VA = "0xF5701C")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xF57100", Offset = "0xF57100", VA = "0xF57100")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xF57218", Offset = "0xF57218", VA = "0xF57218")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xF57228", Offset = "0xF57228", VA = "0xF57228")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xF57294", Offset = "0xF57294", VA = "0xF57294")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xF57318", Offset = "0xF57318", VA = "0xF57318", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xF578F0", Offset = "0xF578F0", VA = "0xF578F0")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xF57928", Offset = "0xF57928", VA = "0xF57928")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xF57BAC", Offset = "0xF57BAC", VA = "0xF57BAC")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xF57EB4", Offset = "0xF57EB4", VA = "0xF57EB4")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xF57FA0", Offset = "0xF57FA0", VA = "0xF57FA0")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xF58068", Offset = "0xF58068", VA = "0xF58068")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C7C14", Offset = "0x4C7C14")]
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
			[Address(RVA = "0xFB6104", Offset = "0xFB6104", VA = "0xFB6104")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0xFB6154", Offset = "0xFB6154", VA = "0xFB6154")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0xFB61F4", Offset = "0xFB61F4", VA = "0xFB61F4")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0xFB622C", Offset = "0xFB622C", VA = "0xFB622C")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0xFB6264", Offset = "0xFB6264", VA = "0xFB6264")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0xFB62B4", Offset = "0xFB62B4", VA = "0xFB62B4")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0xFB5CE4", Offset = "0xFB5CE4", VA = "0xFB5CE4")]
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
				[Address(RVA = "0xFB5614", Offset = "0xFB5614", VA = "0xFB5614")]
				get
				{
					return null;
				}
				[Token(Token = "0x60004ED")]
				[Address(RVA = "0xFB5710", Offset = "0xFB5710", VA = "0xFB5710")]
				set
				{
				}
			}

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0xFB5794", Offset = "0xFB5794", VA = "0xFB5794")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0xFB5944", Offset = "0xFB5944", VA = "0xFB5944")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0xFB5B18", Offset = "0xFB5B18", VA = "0xFB5B18")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004F1")]
			[Address(RVA = "0xFB5C78", Offset = "0xFB5C78", VA = "0xFB5C78")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x60004F2")]
			[Address(RVA = "0xFB5CA0", Offset = "0xFB5CA0", VA = "0xFB5CA0")]
			public Bone()
			{
			}

			[Token(Token = "0x60004F3")]
			[Address(RVA = "0xFB5D20", Offset = "0xFB5D20", VA = "0xFB5D20")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x60004F4")]
			[Address(RVA = "0xFB5D70", Offset = "0xFB5D70", VA = "0xFB5D70")]
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
			[Address(RVA = "0xFB60A0", Offset = "0xFB60A0", VA = "0xFB60A0")]
			public Node()
			{
			}

			[Token(Token = "0x60004F6")]
			[Address(RVA = "0xFB60A4", Offset = "0xFB60A4", VA = "0xFB60A4")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x60004F7")]
			[Address(RVA = "0xFB60CC", Offset = "0xFB60CC", VA = "0xFB60CC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6164", Offset = "0x4C6164")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6164", Offset = "0x4C6164")]
		public float IKPositionWeight;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C61B8", Offset = "0x4C61B8")]
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
			[Address(RVA = "0xF583A0", Offset = "0xF583A0", VA = "0xF583A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB444", Offset = "0x4CB444")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000271")]
			[Address(RVA = "0xF583A8", Offset = "0xF583A8", VA = "0xF583A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB454", Offset = "0x4CB454")]
			private set
			{
			}
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xF582D0", Offset = "0xF582D0", VA = "0xF582D0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000268")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xF49774", Offset = "0xF49774", VA = "0xF49774")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xF49CA0", Offset = "0xF49CA0", VA = "0xF49CA0")]
		public void Update()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xF58348", Offset = "0xF58348", VA = "0xF58348", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xF58354", Offset = "0xF58354", VA = "0xF58354")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xF58360", Offset = "0xF58360", VA = "0xF58360")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xF58368", Offset = "0xF58368", VA = "0xF58368")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xF58398", Offset = "0xF58398", VA = "0xF58398")]
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
		[Address(RVA = "0xF583B4", Offset = "0xF583B4", VA = "0xF583B4")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xF583CC", Offset = "0xF583CC", VA = "0xF583CC")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xF58504", Offset = "0xF58504", VA = "0xF58504")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xF585AC", Offset = "0xF585AC", VA = "0xF585AC")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xF58834", Offset = "0xF58834", VA = "0xF58834")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6200", Offset = "0x4C6200")]
		public float poleWeight;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6218", Offset = "0x4C6218")]
		public float clampWeight;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6230", Offset = "0x4C6230")]
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
			[Address(RVA = "0xF588C8", Offset = "0xF588C8", VA = "0xF588C8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000026")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0xF58904", Offset = "0xF58904", VA = "0xF58904")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000027")]
		protected override int minBones
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0xF59394", Offset = "0xF59394", VA = "0xF59394", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000028")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0xF59778", Offset = "0xF59778", VA = "0xF59778", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xF5884C", Offset = "0xF5884C", VA = "0xF5884C")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xF58940", Offset = "0xF58940", VA = "0xF58940", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xF58B60", Offset = "0xF58B60", VA = "0xF58B60", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xF592E0", Offset = "0xF592E0", VA = "0xF592E0")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xF59070", Offset = "0xF59070", VA = "0xF59070")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xF5939C", Offset = "0xF5939C", VA = "0xF5939C")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xF597EC", Offset = "0xF597EC", VA = "0xF597EC")]
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
		[Address(RVA = "0xF59840", Offset = "0xF59840", VA = "0xF59840")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xF598F0", Offset = "0xF598F0", VA = "0xF598F0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xF59974", Offset = "0xF59974", VA = "0xF59974", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xF59BA4", Offset = "0xF59BA4", VA = "0xF59BA4")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xF5A180", Offset = "0xF5A180", VA = "0xF5A180")]
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
			[Address(RVA = "0xF945D4", Offset = "0xF945D4", VA = "0xF945D4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xF92EC8", Offset = "0xF92EC8", VA = "0xF92EC8")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xF93488", Offset = "0xF93488", VA = "0xF93488")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xF935C4", Offset = "0xF935C4", VA = "0xF935C4", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xF93658", Offset = "0xF93658", VA = "0xF93658", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xF93FA8", Offset = "0xF93FA8", VA = "0xF93FA8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xF945DC", Offset = "0xF945DC", VA = "0xF945DC")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xF92FA0", Offset = "0xF92FA0", VA = "0xF92FA0")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xF93570", Offset = "0xF93570", VA = "0xF93570")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xF94578", Offset = "0xF94578", VA = "0xF94578")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xF932FC", Offset = "0xF932FC", VA = "0xF932FC")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xF94C2C", Offset = "0xF94C2C", VA = "0xF94C2C")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xF94CA0", Offset = "0xF94CA0", VA = "0xF94CA0")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xF94D68", Offset = "0xF94D68", VA = "0xF94D68")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xF94E18", Offset = "0xF94E18", VA = "0xF94E18")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xF93D58", Offset = "0xF93D58", VA = "0xF93D58")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xF93E80", Offset = "0xF93E80", VA = "0xF93E80")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xF94F1C", Offset = "0xF94F1C", VA = "0xF94F1C")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xF947FC", Offset = "0xF947FC", VA = "0xF947FC")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xF93560", Offset = "0xF93560", VA = "0xF93560")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xF954AC", Offset = "0xF954AC", VA = "0xF954AC")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xF95060", Offset = "0xF95060", VA = "0xF95060")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xF94658", Offset = "0xF94658", VA = "0xF94658")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xF94738", Offset = "0xF94738", VA = "0xF94738")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xF95578", Offset = "0xF95578", VA = "0xF95578")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6248", Offset = "0x4C6248")]
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
		[Address(RVA = "0xF95660", Offset = "0xF95660", VA = "0xF95660", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xF95CA0", Offset = "0xF95CA0", VA = "0xF95CA0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xF95D38", Offset = "0xF95D38", VA = "0xF95D38", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xF95DD8", Offset = "0xF95DD8", VA = "0xF95DD8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xF95ED4", Offset = "0xF95ED4", VA = "0xF95ED4")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xF95F70", Offset = "0xF95F70", VA = "0xF95F70", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xF963A0", Offset = "0xF963A0", VA = "0xF963A0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xF96598", Offset = "0xF96598", VA = "0xF96598", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xF9644C", Offset = "0xF9644C", VA = "0xF9644C")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xF9615C", Offset = "0xF9615C", VA = "0xF9615C")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xF96630", Offset = "0xF96630", VA = "0xF96630")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6260", Offset = "0x4C6260")]
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
		[Address(RVA = "0xF96694", Offset = "0xF96694", VA = "0xF96694")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xF96784", Offset = "0xF96784", VA = "0xF96784")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xF967E0", Offset = "0xF967E0", VA = "0xF967E0")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xF96910", Offset = "0xF96910", VA = "0xF96910")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xF9696C", Offset = "0xF9696C", VA = "0xF9696C")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xF969EC", Offset = "0xF969EC", VA = "0xF969EC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xF96B70", Offset = "0xF96B70", VA = "0xF96B70", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xF96CE0", Offset = "0xF96CE0", VA = "0xF96CE0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xF96EEC", Offset = "0xF96EEC", VA = "0xF96EEC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xF96FC4", Offset = "0xF96FC4", VA = "0xF96FC4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xF970B0", Offset = "0xF970B0", VA = "0xF970B0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xF97224", Offset = "0xF97224", VA = "0xF97224", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xF9737C", Offset = "0xF9737C", VA = "0xF9737C", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xF975C8", Offset = "0xF975C8", VA = "0xF975C8", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xF978A4", Offset = "0xF978A4", VA = "0xF978A4", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xF978E8", Offset = "0xF978E8", VA = "0xF978E8", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xF979D8", Offset = "0xF979D8", VA = "0xF979D8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6278", Offset = "0x4C6278")]
		public float spineStiffness;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6290", Offset = "0x4C6290")]
		public float pullBodyVertical;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C62A8", Offset = "0x4C62A8")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C62C0", Offset = "0x4C62C0")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700002A")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0xF97ADC", Offset = "0xF97ADC", VA = "0xF97ADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xF97C24", Offset = "0xF97C24", VA = "0xF97C24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0xF97C2C", Offset = "0xF97C2C", VA = "0xF97C2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0xF97C34", Offset = "0xF97C34", VA = "0xF97C34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0xF97C3C", Offset = "0xF97C3C", VA = "0xF97C3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0xF97C44", Offset = "0xF97C44", VA = "0xF97C44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0xF97C4C", Offset = "0xF97C4C", VA = "0xF97C4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0xF97C54", Offset = "0xF97C54", VA = "0xF97C54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0xF97C5C", Offset = "0xF97C5C", VA = "0xF97C5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0xF97C64", Offset = "0xF97C64", VA = "0xF97C64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0xF97C9C", Offset = "0xF97C9C", VA = "0xF97C9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0xF97CD4", Offset = "0xF97CD4", VA = "0xF97CD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0xF97D0C", Offset = "0xF97D0C", VA = "0xF97D0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0xF97D44", Offset = "0xF97D44", VA = "0xF97D44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0xF97D78", Offset = "0xF97D78", VA = "0xF97D78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0xF97DB0", Offset = "0xF97DB0", VA = "0xF97DB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0xF97DE8", Offset = "0xF97DE8", VA = "0xF97DE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0xF97E20", Offset = "0xF97E20", VA = "0xF97E20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0xF99CE8", Offset = "0xF99CE8", VA = "0xF99CE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB464", Offset = "0x4CB464")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0xF99CF4", Offset = "0xF99CF4", VA = "0xF99CF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB474", Offset = "0x4CB474")]
			private set
			{
			}
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xF97E54", Offset = "0xF97E54", VA = "0xF97E54")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xF97F60", Offset = "0xF97F60", VA = "0xF97F60")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xF97EA8", Offset = "0xF97EA8", VA = "0xF97EA8")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xF97FEC", Offset = "0xF97FEC", VA = "0xF97FEC")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xF97AE4", Offset = "0xF97AE4", VA = "0xF97AE4")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xF980BC", Offset = "0xF980BC", VA = "0xF980BC")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xF98174", Offset = "0xF98174", VA = "0xF98174")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xF98228", Offset = "0xF98228", VA = "0xF98228")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xF982DC", Offset = "0xF982DC", VA = "0xF982DC")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xF982E4", Offset = "0xF982E4", VA = "0xF982E4")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xF98318", Offset = "0xF98318", VA = "0xF98318")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xF983E0", Offset = "0xF983E0", VA = "0xF983E0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xF98584", Offset = "0xF98584", VA = "0xF98584")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xF99764", Offset = "0xF99764", VA = "0xF99764")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xF99B78", Offset = "0xF99B78", VA = "0xF99B78")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xF99BD8", Offset = "0xF99BD8", VA = "0xF99BD8")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xF99A00", Offset = "0xF99A00", VA = "0xF99A00")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xF99ABC", Offset = "0xF99ABC", VA = "0xF99ABC")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xF99D00", Offset = "0xF99D00", VA = "0xF99D00")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xF99DD8", Offset = "0xF99DD8", VA = "0xF99DD8", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xF99ED4", Offset = "0xF99ED4", VA = "0xF99ED4")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xF99FFC", Offset = "0xF99FFC", VA = "0xF99FFC")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xF9A140", Offset = "0xF9A140", VA = "0xF9A140")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xF9A270", Offset = "0xF9A270", VA = "0xF9A270", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xF9A4B0", Offset = "0xF9A4B0", VA = "0xF9A4B0", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xF9A534", Offset = "0xF9A534", VA = "0xF9A534")]
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
			[Address(RVA = "0xF9ADA0", Offset = "0xF9ADA0", VA = "0xF9ADA0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003E")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0xF9ADA8", Offset = "0xF9ADA8", VA = "0xF9ADA8", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0xF9ADB0", Offset = "0xF9ADB0", VA = "0xF9ADB0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0xF9ADC0", Offset = "0xF9ADC0", VA = "0xF9ADC0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000041")]
		protected float positionOffset
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0xF94524", Offset = "0xF94524", VA = "0xF94524")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xF9A540", Offset = "0xF9A540", VA = "0xF9A540")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xF9A6DC", Offset = "0xF9A6DC", VA = "0xF9A6DC")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xF9A814", Offset = "0xF9A814", VA = "0xF9A814", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xF9A880", Offset = "0xF9A880", VA = "0xF9A880", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xF9A900", Offset = "0xF9A900", VA = "0xF9A900", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xF9ACA8", Offset = "0xF9ACA8", VA = "0xF9ACA8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xF9ACB0", Offset = "0xF9ACB0", VA = "0xF9ACB0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xF9ADB8", Offset = "0xF9ADB8", VA = "0xF9ADB8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xF9ADBC", Offset = "0xF9ADBC", VA = "0xF9ADBC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xF938E0", Offset = "0xF938E0", VA = "0xF938E0")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xF9420C", Offset = "0xF9420C", VA = "0xF9420C")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xF9AE88", Offset = "0xF9AE88", VA = "0xF9AE88")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xF955F4", Offset = "0xF955F4", VA = "0xF955F4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C62D0", Offset = "0x4C62D0")]
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
		[Address(RVA = "0xF9B07C", Offset = "0xF9B07C", VA = "0xF9B07C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xF9B41C", Offset = "0xF9B41C", VA = "0xF9B41C")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xF9B48C", Offset = "0xF9B48C", VA = "0xF9B48C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xF9B5E4", Offset = "0xF9B5E4", VA = "0xF9B5E4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xF9B778", Offset = "0xF9B778", VA = "0xF9B778", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xF9B7D4", Offset = "0xF9B7D4", VA = "0xF9B7D4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xF9B844", Offset = "0xF9B844", VA = "0xF9B844", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xF9BBAC", Offset = "0xF9BBAC", VA = "0xF9BBAC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xF9BBD8", Offset = "0xF9BBD8", VA = "0xF9BBD8")]
		private void Solve()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xF9B8A8", Offset = "0xF9B8A8", VA = "0xF9B8A8")]
		private void Read()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xF9BC68", Offset = "0xF9BC68", VA = "0xF9BC68")]
		private void Write()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xF9BD80", Offset = "0xF9BD80", VA = "0xF9BD80")]
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
			[Address(RVA = "0xFB6558", Offset = "0xFB6558", VA = "0xFB6558")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C62E8", Offset = "0x4C62E8")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6300", Offset = "0x4C6300")]
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
			[Address(RVA = "0xF9CFFC", Offset = "0xF9CFFC", VA = "0xF9CFFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xF9BED8", Offset = "0xF9BED8", VA = "0xF9BED8")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xF9BF28", Offset = "0xF9BF28", VA = "0xF9BF28")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xF9BF74", Offset = "0xF9BF74", VA = "0xF9BF74", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xF9C448", Offset = "0xF9C448", VA = "0xF9C448", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xF9CD90", Offset = "0xF9CD90", VA = "0xF9CD90", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xF9CE3C", Offset = "0xF9CE3C", VA = "0xF9CE3C")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xF9CF78", Offset = "0xF9CF78", VA = "0xF9CF78")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xF9C270", Offset = "0xF9C270", VA = "0xF9C270")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xF9C52C", Offset = "0xF9C52C", VA = "0xF9C52C")]
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
				[Address(RVA = "0xFB67E4", Offset = "0xFB67E4", VA = "0xFB67E4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000501")]
			[Address(RVA = "0xFB65B8", Offset = "0xFB65B8", VA = "0xFB65B8")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000502")]
			[Address(RVA = "0xFB65BC", Offset = "0xFB65BC", VA = "0xFB65BC")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000503")]
			[Address(RVA = "0xFB65E4", Offset = "0xFB65E4", VA = "0xFB65E4")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000504")]
			[Address(RVA = "0xFB66DC", Offset = "0xFB66DC", VA = "0xFB66DC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6318", Offset = "0x4C6318")]
		public float bodyWeight;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6330", Offset = "0x4C6330")]
		public float headWeight;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6348", Offset = "0x4C6348")]
		public float eyesWeight;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6360", Offset = "0x4C6360")]
		public float clampWeight;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6378", Offset = "0x4C6378")]
		public float clampWeightHead;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6390", Offset = "0x4C6390")]
		public float clampWeightEyes;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C63A8", Offset = "0x4C63A8")]
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
			[Address(RVA = "0xF9D79C", Offset = "0xF9D79C", VA = "0xF9D79C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0xF9D96C", Offset = "0xF9D96C", VA = "0xF9D96C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		private bool headIsValid
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0xF9D87C", Offset = "0xF9D87C", VA = "0xF9D87C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		private bool headIsEmpty
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0xF9D990", Offset = "0xF9D990", VA = "0xF9D990")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		private bool eyesIsValid
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0xF9D88C", Offset = "0xF9D88C", VA = "0xF9D88C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0xF9DA08", Offset = "0xF9DA08", VA = "0xF9DA08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xF9D018", Offset = "0xF9D018", VA = "0xF9D018")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xF9D048", Offset = "0xF9D048", VA = "0xF9D048")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xF9D0A0", Offset = "0xF9D0A0", VA = "0xF9D0A0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xF9D11C", Offset = "0xF9D11C", VA = "0xF9D11C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xF9D1B4", Offset = "0xF9D1B4", VA = "0xF9D1B4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xF9D274", Offset = "0xF9D274", VA = "0xF9D274")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xF9D370", Offset = "0xF9D370", VA = "0xF9D370", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xF9D49C", Offset = "0xF9D49C", VA = "0xF9D49C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xF9D5DC", Offset = "0xF9D5DC", VA = "0xF9D5DC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xF9DA2C", Offset = "0xF9DA2C", VA = "0xF9DA2C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xF9DC6C", Offset = "0xF9DC6C", VA = "0xF9DC6C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xF9DE08", Offset = "0xF9DE08", VA = "0xF9DE08")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xF9E038", Offset = "0xF9E038", VA = "0xF9E038", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xF9E30C", Offset = "0xF9E30C", VA = "0xF9E30C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xF9E3DC", Offset = "0xF9E3DC", VA = "0xF9E3DC")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xF9E57C", Offset = "0xF9E57C", VA = "0xF9E57C")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xF9E7A0", Offset = "0xF9E7A0", VA = "0xF9E7A0")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xF9E9B8", Offset = "0xF9E9B8", VA = "0xF9E9B8")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xF9DEB4", Offset = "0xF9DEB4", VA = "0xF9DEB4")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xF9EC28", Offset = "0xF9EC28", VA = "0xF9EC28")]
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
			[Address(RVA = "0xFB6820", Offset = "0xFB6820", VA = "0xFB6820")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000507")]
			[Address(RVA = "0xFB691C", Offset = "0xFB691C", VA = "0xFB691C")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000508")]
			[Address(RVA = "0xFB694C", Offset = "0xFB694C", VA = "0xFB694C")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000509")]
			[Address(RVA = "0xFB6988", Offset = "0xFB6988", VA = "0xFB6988")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C63C0", Offset = "0x4C63C0")]
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
		[Address(RVA = "0xF9EE34", Offset = "0xF9EE34", VA = "0xF9EE34")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xF9EF90", Offset = "0xF9EF90", VA = "0xF9EF90")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xF9F0D4", Offset = "0xF9F0D4", VA = "0xF9F0D4")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xF9F0E0", Offset = "0xF9F0E0", VA = "0xF9F0E0")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xF9F110", Offset = "0xF9F110", VA = "0xF9F110")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xF9F11C", Offset = "0xF9F11C", VA = "0xF9F11C")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xF9F124", Offset = "0xF9F124", VA = "0xF9F124", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xF9F224", Offset = "0xF9F224", VA = "0xF9F224", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xF9F340", Offset = "0xF9F340", VA = "0xF9F340", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xF9F38C", Offset = "0xF9F38C", VA = "0xF9F38C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xF9F3EC", Offset = "0xF9F3EC", VA = "0xF9F3EC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xF9F7B4", Offset = "0xF9F7B4", VA = "0xF9F7B4")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xF9F80C", Offset = "0xF9F80C", VA = "0xF9F80C")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xF9FBC8", Offset = "0xF9FBC8", VA = "0xF9FBC8")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xF9FD30", Offset = "0xF9FD30", VA = "0xF9FD30", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xF9FE98", Offset = "0xF9FE98", VA = "0xF9FE98")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xF9FE0C", Offset = "0xF9FE0C", VA = "0xF9FE0C")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xF9FF9C", Offset = "0xF9FF9C", VA = "0xF9FF9C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xFA0760", Offset = "0xFA0760", VA = "0xFA0760", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xFA0764", Offset = "0xFA0764", VA = "0xFA0764", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xFA0768", Offset = "0xFA0768", VA = "0xFA0768", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xFA0588", Offset = "0xFA0588", VA = "0xFA0588")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xF9CEAC", Offset = "0xF9CEAC", VA = "0xF9CEAC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7C2C", Offset = "0x4C7C2C")]
			public Transform target;

			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7C64", Offset = "0x4C7C64")]
			public Transform bendGoal;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7C9C", Offset = "0x4C7C9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C7C9C", Offset = "0x4C7C9C")]
			public float positionWeight;

			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7CF0", Offset = "0x4C7CF0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C7CF0", Offset = "0x4C7CF0")]
			public float rotationWeight;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7D44", Offset = "0x4C7D44")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7D7C", Offset = "0x4C7D7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C7D7C", Offset = "0x4C7D7C")]
			public float shoulderRotationWeight;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7DD0", Offset = "0x4C7DD0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C7DD0", Offset = "0x4C7DD0")]
			public float bendGoalWeight;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7E24", Offset = "0x4C7E24")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C7E24", Offset = "0x4C7E24")]
			public float swivelOffset;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7E80", Offset = "0x4C7E80")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7EB8", Offset = "0x4C7EB8")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7EF0", Offset = "0x4C7EF0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C7EF0", Offset = "0x4C7EF0")]
			public float armLengthMlp;

			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7F48", Offset = "0x4C7F48")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C7FC0", Offset = "0x4C7FC0")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C7FD0", Offset = "0x4C7FD0")]
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
				[Address(RVA = "0xFB698C", Offset = "0xFB698C", VA = "0xFB698C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC184", Offset = "0x4CC184")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600050B")]
				[Address(RVA = "0xFB6998", Offset = "0xFB6998", VA = "0xFB6998")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC194", Offset = "0x4CC194")]
				private set
				{
				}
			}

			[Token(Token = "0x17000079")]
			public Quaternion rotation
			{
				[Token(Token = "0x600050C")]
				[Address(RVA = "0xFB69A4", Offset = "0xFB69A4", VA = "0xFB69A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC1A4", Offset = "0x4CC1A4")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600050D")]
				[Address(RVA = "0xFB69B0", Offset = "0xFB69B0", VA = "0xFB69B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC1B4", Offset = "0x4CC1B4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007A")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600050E")]
				[Address(RVA = "0xFB69BC", Offset = "0xFB69BC", VA = "0xFB69BC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600050F")]
				[Address(RVA = "0xFB69F0", Offset = "0xFB69F0", VA = "0xFB69F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000510")]
				[Address(RVA = "0xFB6A28", Offset = "0xFB6A28", VA = "0xFB6A28")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000511")]
				[Address(RVA = "0xFB6A60", Offset = "0xFB6A60", VA = "0xFB6A60")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000512")]
			[Address(RVA = "0xFB6A98", Offset = "0xFB6A98", VA = "0xFB6A98", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000513")]
			[Address(RVA = "0xFB7254", Offset = "0xFB7254", VA = "0xFB7254", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000514")]
			[Address(RVA = "0xFB7410", Offset = "0xFB7410", VA = "0xFB7410", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000515")]
			[Address(RVA = "0xFB7434", Offset = "0xFB7434", VA = "0xFB7434")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000516")]
			[Address(RVA = "0xFB76D4", Offset = "0xFB76D4", VA = "0xFB76D4")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000517")]
			[Address(RVA = "0xFB8F8C", Offset = "0xFB8F8C", VA = "0xFB8F8C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000518")]
			[Address(RVA = "0xFB8FB8", Offset = "0xFB8FB8", VA = "0xFB8FB8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000519")]
			[Address(RVA = "0xFB848C", Offset = "0xFB848C", VA = "0xFB848C")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600051A")]
			[Address(RVA = "0xFB8644", Offset = "0xFB8644", VA = "0xFB8644")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600051B")]
			[Address(RVA = "0xFB91D8", Offset = "0xFB91D8", VA = "0xFB91D8")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600051C")]
			[Address(RVA = "0xFB92FC", Offset = "0xFB92FC", VA = "0xFB92FC")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C7FE0", Offset = "0x4C7FE0")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C7FF0", Offset = "0x4C7FF0")]
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
				[Address(RVA = "0xFB9414", Offset = "0xFB9414", VA = "0xFB9414")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC1C4", Offset = "0x4CC1C4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000523")]
				[Address(RVA = "0xFB941C", Offset = "0xFB941C", VA = "0xFB941C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC1D4", Offset = "0x4CC1D4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007F")]
			public float mag
			{
				[Token(Token = "0x6000524")]
				[Address(RVA = "0xFB9424", Offset = "0xFB9424", VA = "0xFB9424")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC1E4", Offset = "0x4CC1E4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000525")]
				[Address(RVA = "0xFB942C", Offset = "0xFB942C", VA = "0xFB942C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC1F4", Offset = "0x4CC1F4")]
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
			[Address(RVA = "0xFB9434", Offset = "0xFB9434", VA = "0xFB9434")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000527")]
			[Address(RVA = "0xFB96E8", Offset = "0xFB96E8", VA = "0xFB96E8")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000528")]
			[Address(RVA = "0xFB977C", Offset = "0xFB977C", VA = "0xFB977C")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000529")]
			[Address(RVA = "0xFB994C", Offset = "0xFB994C", VA = "0xFB994C")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600052A")]
			[Address(RVA = "0xFB99A0", Offset = "0xFB99A0", VA = "0xFB99A0")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x600052B")]
			[Address(RVA = "0xFB8E4C", Offset = "0xFB8E4C", VA = "0xFB8E4C")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600052C")]
			[Address(RVA = "0xFB9AD8", Offset = "0xFB9AD8", VA = "0xFB9AD8")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600052D")]
			[Address(RVA = "0xFB9C18", Offset = "0xFB9C18", VA = "0xFB9C18")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600052E")]
			[Address(RVA = "0xFB93A0", Offset = "0xFB93A0", VA = "0xFB93A0")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C8010", Offset = "0x4C8010")]
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
				[Address(RVA = "0xFB9C40", Offset = "0xFB9C40", VA = "0xFB9C40")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000081")]
			public float stepProgress
			{
				[Token(Token = "0x6000530")]
				[Address(RVA = "0xFB9C54", Offset = "0xFB9C54", VA = "0xFB9C54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC204", Offset = "0x4CC204")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000531")]
				[Address(RVA = "0xFB9C5C", Offset = "0xFB9C5C", VA = "0xFB9C5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC214", Offset = "0x4CC214")]
				private set
				{
				}
			}

			[Token(Token = "0x6000532")]
			[Address(RVA = "0xFB9C64", Offset = "0xFB9C64", VA = "0xFB9C64")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000533")]
			[Address(RVA = "0xFB9D58", Offset = "0xFB9D58", VA = "0xFB9D58")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000534")]
			[Address(RVA = "0xFB9DD8", Offset = "0xFB9DD8", VA = "0xFB9DD8")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000535")]
			[Address(RVA = "0xFB9E54", Offset = "0xFB9E54", VA = "0xFB9E54")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000536")]
			[Address(RVA = "0xFB9FC8", Offset = "0xFB9FC8", VA = "0xFB9FC8")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0xFBA120", Offset = "0xFBA120", VA = "0xFBA120")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8020", Offset = "0x4C8020")]
			public Transform target;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8058", Offset = "0x4C8058")]
			public Transform bendGoal;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8090", Offset = "0x4C8090")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C8090", Offset = "0x4C8090")]
			public float positionWeight;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C80E4", Offset = "0x4C80E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C80E4", Offset = "0x4C80E4")]
			public float rotationWeight;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8138", Offset = "0x4C8138")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C8138", Offset = "0x4C8138")]
			public float bendGoalWeight;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C818C", Offset = "0x4C818C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C818C", Offset = "0x4C818C")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C8248", Offset = "0x4C8248")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C8258", Offset = "0x4C8258")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C8268", Offset = "0x4C8268")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C8278", Offset = "0x4C8278")]
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
				[Address(RVA = "0xFBA25C", Offset = "0xFBA25C", VA = "0xFBA25C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC224", Offset = "0x4CC224")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000539")]
				[Address(RVA = "0xFBA268", Offset = "0xFBA268", VA = "0xFBA268")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC234", Offset = "0x4CC234")]
				private set
				{
				}
			}

			[Token(Token = "0x17000083")]
			public Quaternion rotation
			{
				[Token(Token = "0x600053A")]
				[Address(RVA = "0xFBA274", Offset = "0xFBA274", VA = "0xFBA274")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC244", Offset = "0x4CC244")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600053B")]
				[Address(RVA = "0xFBA280", Offset = "0xFBA280", VA = "0xFBA280")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC254", Offset = "0x4CC254")]
				private set
				{
				}
			}

			[Token(Token = "0x17000084")]
			public bool hasToes
			{
				[Token(Token = "0x600053C")]
				[Address(RVA = "0xFBA28C", Offset = "0xFBA28C", VA = "0xFBA28C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC264", Offset = "0x4CC264")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600053D")]
				[Address(RVA = "0xFBA294", Offset = "0xFBA294", VA = "0xFBA294")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC274", Offset = "0x4CC274")]
				private set
				{
				}
			}

			[Token(Token = "0x17000085")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600053E")]
				[Address(RVA = "0xFBA2A0", Offset = "0xFBA2A0", VA = "0xFBA2A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000086")]
			private VirtualBone calf
			{
				[Token(Token = "0x600053F")]
				[Address(RVA = "0xFBA2D4", Offset = "0xFBA2D4", VA = "0xFBA2D4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000540")]
				[Address(RVA = "0xFBA30C", Offset = "0xFBA30C", VA = "0xFBA30C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000088")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000541")]
				[Address(RVA = "0xFBA344", Offset = "0xFBA344", VA = "0xFBA344")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000089")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000542")]
				[Address(RVA = "0xFBA37C", Offset = "0xFBA37C", VA = "0xFBA37C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000543")]
				[Address(RVA = "0xFBA3BC", Offset = "0xFBA3BC", VA = "0xFBA3BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC284", Offset = "0x4CC284")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000544")]
				[Address(RVA = "0xFBA3C8", Offset = "0xFBA3C8", VA = "0xFBA3C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC294", Offset = "0x4CC294")]
				private set
				{
				}
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0xFBA3D4", Offset = "0xFBA3D4", VA = "0xFBA3D4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0xFBA884", Offset = "0xFBA884", VA = "0xFBA884", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000547")]
			[Address(RVA = "0xFBACFC", Offset = "0xFBACFC", VA = "0xFBACFC", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000548")]
			[Address(RVA = "0xFBACAC", Offset = "0xFBACAC", VA = "0xFBACAC")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000549")]
			[Address(RVA = "0xFBAB4C", Offset = "0xFBAB4C", VA = "0xFBAB4C")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x600054A")]
			[Address(RVA = "0xFBB0D0", Offset = "0xFBB0D0", VA = "0xFBB0D0")]
			public void Solve()
			{
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0xFBB334", Offset = "0xFBB334", VA = "0xFBB334", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0xFBB43C", Offset = "0xFBB43C", VA = "0xFBB43C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0xFBB488", Offset = "0xFBB488", VA = "0xFBB488")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8288", Offset = "0x4C8288")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C8288", Offset = "0x4C8288")]
			public float weight;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C82DC", Offset = "0x4C82DC")]
			public float footDistance;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8314", Offset = "0x4C8314")]
			public float stepThreshold;

			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C834C", Offset = "0x4C834C")]
			public float angleThreshold;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8384", Offset = "0x4C8384")]
			public float comAngleMlp;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C83BC", Offset = "0x4C83BC")]
			public float maxVelocity;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C83F4", Offset = "0x4C83F4")]
			public float velocityFactor;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C842C", Offset = "0x4C842C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C842C", Offset = "0x4C842C")]
			public float maxLegStretch;

			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8484", Offset = "0x4C8484")]
			public float rootSpeed;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C84BC", Offset = "0x4C84BC")]
			public float stepSpeed;

			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C84F4", Offset = "0x4C84F4")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C852C", Offset = "0x4C852C")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8564", Offset = "0x4C8564")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C8564", Offset = "0x4C8564")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C85BC", Offset = "0x4C85BC")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C85F4", Offset = "0x4C85F4")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C862C", Offset = "0x4C862C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C86A4", Offset = "0x4C86A4")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C86DC", Offset = "0x4C86DC")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C8714", Offset = "0x4C8714")]
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
				[Address(RVA = "0xFBB4F0", Offset = "0xFBB4F0", VA = "0xFBB4F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC2A4", Offset = "0x4CC2A4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600054F")]
				[Address(RVA = "0xFBB4FC", Offset = "0xFBB4FC", VA = "0xFBB4FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC2B4", Offset = "0x4CC2B4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008C")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000555")]
				[Address(RVA = "0xFBCF80", Offset = "0xFBCF80", VA = "0xFBCF80")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008D")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000556")]
				[Address(RVA = "0xFBCFC0", Offset = "0xFBCFC0", VA = "0xFBCFC0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008E")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000557")]
				[Address(RVA = "0xFBD004", Offset = "0xFBD004", VA = "0xFBD004")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x1700008F")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000558")]
				[Address(RVA = "0xFBD044", Offset = "0xFBD044", VA = "0xFBD044")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000550")]
			[Address(RVA = "0xFBB508", Offset = "0xFBB508", VA = "0xFBB508")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0xFBB7A8", Offset = "0xFBB7A8", VA = "0xFBB7A8")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000552")]
			[Address(RVA = "0xFBB978", Offset = "0xFBB978", VA = "0xFBB978")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0xFBBBC0", Offset = "0xFBBBC0", VA = "0xFBBBC0")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000554")]
			[Address(RVA = "0xFBBC84", Offset = "0xFBBC84", VA = "0xFBBC84")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000559")]
			[Address(RVA = "0xFBCCF8", Offset = "0xFBCCF8", VA = "0xFBCCF8")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600055A")]
			[Address(RVA = "0xFBCE30", Offset = "0xFBCE30", VA = "0xFBCE30")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600055B")]
			[Address(RVA = "0xFBCEB4", Offset = "0xFBCEB4", VA = "0xFBCEB4")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x600055C")]
			[Address(RVA = "0xFBD088", Offset = "0xFBD088", VA = "0xFBD088")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8724", Offset = "0x4C8724")]
			public Transform headTarget;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C875C", Offset = "0x4C875C")]
			public Transform pelvisTarget;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8794", Offset = "0x4C8794")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C8794", Offset = "0x4C8794")]
			public float positionWeight;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C87E8", Offset = "0x4C87E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C87E8", Offset = "0x4C87E8")]
			public float rotationWeight;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C883C", Offset = "0x4C883C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C883C", Offset = "0x4C883C")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8890", Offset = "0x4C8890")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C8890", Offset = "0x4C8890")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C88E4", Offset = "0x4C88E4")]
			public Transform chestGoal;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C891C", Offset = "0x4C891C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C891C", Offset = "0x4C891C")]
			public float chestGoalWeight;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8970", Offset = "0x4C8970")]
			public float minHeadHeight;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C89A8", Offset = "0x4C89A8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C89A8", Offset = "0x4C89A8")]
			public float bodyPosStiffness;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C89FC", Offset = "0x4C89FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C89FC", Offset = "0x4C89FC")]
			public float bodyRotStiffness;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8A50", Offset = "0x4C8A50")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x4C8A50", Offset = "0x4C8A50")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C8A50", Offset = "0x4C8A50")]
			public float neckStiffness;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8AC8", Offset = "0x4C8AC8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C8AC8", Offset = "0x4C8AC8")]
			public float rotateChestByHands;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8B1C", Offset = "0x4C8B1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C8B1C", Offset = "0x4C8B1C")]
			public float chestClampWeight;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8B70", Offset = "0x4C8B70")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C8B70", Offset = "0x4C8B70")]
			public float headClampWeight;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8BC4", Offset = "0x4C8BC4")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8BFC", Offset = "0x4C8BFC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C8BFC", Offset = "0x4C8BFC")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8C50", Offset = "0x4C8C50")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C8C50", Offset = "0x4C8C50")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C8D88", Offset = "0x4C8D88")]
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
				[Address(RVA = "0xFBCC78", Offset = "0xFBCC78", VA = "0xFBCC78")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000091")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600055E")]
				[Address(RVA = "0xFBD174", Offset = "0xFBD174", VA = "0xFBD174")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			public VirtualBone chest
			{
				[Token(Token = "0x600055F")]
				[Address(RVA = "0xFBD1B4", Offset = "0xFBD1B4", VA = "0xFBD1B4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000093")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000560")]
				[Address(RVA = "0xFBD208", Offset = "0xFBD208", VA = "0xFBD208")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000094")]
			public VirtualBone head
			{
				[Token(Token = "0x6000561")]
				[Address(RVA = "0xFBCCB8", Offset = "0xFBCCB8", VA = "0xFBCCB8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000562")]
				[Address(RVA = "0xFBD248", Offset = "0xFBD248", VA = "0xFBD248")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC2C4", Offset = "0x4CC2C4")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000563")]
				[Address(RVA = "0xFBD25C", Offset = "0xFBD25C", VA = "0xFBD25C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC2D4", Offset = "0x4CC2D4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000096")]
			public Vector3 ChestFwd
			{
				[Token(Token = "0x6000564")]
				[Address(RVA = "0xFBD270", Offset = "0xFBD270", VA = "0xFBD270")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000565")]
			[Address(RVA = "0xFBD2CC", Offset = "0xFBD2CC", VA = "0xFBD2CC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000566")]
			[Address(RVA = "0xFBDC8C", Offset = "0xFBDC8C", VA = "0xFBDC8C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000567")]
			[Address(RVA = "0xFBDE5C", Offset = "0xFBDE5C", VA = "0xFBDE5C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000568")]
			[Address(RVA = "0xFBE1C8", Offset = "0xFBE1C8", VA = "0xFBE1C8")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000569")]
			[Address(RVA = "0xFBE68C", Offset = "0xFBE68C", VA = "0xFBE68C")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x600056A")]
			[Address(RVA = "0xFBED70", Offset = "0xFBED70", VA = "0xFBED70")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x600056B")]
			[Address(RVA = "0xFBF3B4", Offset = "0xFBF3B4", VA = "0xFBF3B4")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x600056C")]
			[Address(RVA = "0xFBF984", Offset = "0xFBF984", VA = "0xFBF984", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600056D")]
			[Address(RVA = "0xFBFB60", Offset = "0xFBFB60", VA = "0xFBFB60", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0xFBE3F4", Offset = "0xFBE3F4", VA = "0xFBE3F4")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0xFBF0F0", Offset = "0xFBF0F0", VA = "0xFBF0F0")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0xFBEA40", Offset = "0xFBEA40", VA = "0xFBEA40")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0xFBFBF8", Offset = "0xFBFBF8", VA = "0xFBFBF8")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000572")]
			[Address(RVA = "0xFBF1E0", Offset = "0xFBF1E0", VA = "0xFBF1E0")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000573")]
			[Address(RVA = "0xFBEF00", Offset = "0xFBEF00", VA = "0xFBEF00")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000574")]
			[Address(RVA = "0xFBFDE4", Offset = "0xFBFDE4", VA = "0xFBFDE4")]
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
			[Address(RVA = "0xFB71B8", Offset = "0xFB71B8", VA = "0xFB71B8")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000576")]
			[Address(RVA = "0xFB7234", Offset = "0xFB7234", VA = "0xFB7234")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000577")]
			[Address(RVA = "0xFBFF44", Offset = "0xFBFF44", VA = "0xFBFF44")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000578")]
			[Address(RVA = "0xFB94F8", Offset = "0xFB94F8", VA = "0xFB94F8")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000579")]
			[Address(RVA = "0xFB9824", Offset = "0xFB9824", VA = "0xFB9824")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600057A")]
			[Address(RVA = "0xFC00C8", Offset = "0xFC00C8", VA = "0xFC00C8")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600057B")]
			[Address(RVA = "0xFB8508", Offset = "0xFB8508", VA = "0xFB8508")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x600057C")]
			[Address(RVA = "0xFC0228", Offset = "0xFC0228", VA = "0xFC0228")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600057D")]
			[Address(RVA = "0xFB8A48", Offset = "0xFB8A48", VA = "0xFB8A48")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x600057E")]
			[Address(RVA = "0xFC02E0", Offset = "0xFC02E0", VA = "0xFC02E0")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600057F")]
			[Address(RVA = "0xFBF63C", Offset = "0xFBF63C", VA = "0xFBF63C")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000580")]
			[Address(RVA = "0xFC0448", Offset = "0xFC0448", VA = "0xFC0448")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000581")]
			[Address(RVA = "0xFC04B8", Offset = "0xFC04B8", VA = "0xFC04B8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C63D8", Offset = "0x4C63D8")]
		public bool plantFeet;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C6410", Offset = "0x4C6410")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6420", Offset = "0x4C6420")]
		public Spine spine;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6458", Offset = "0x4C6458")]
		public Arm leftArm;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6490", Offset = "0x4C6490")]
		public Arm rightArm;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C64C8", Offset = "0x4C64C8")]
		public Leg leftLeg;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6500", Offset = "0x4C6500")]
		public Leg rightLeg;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6538", Offset = "0x4C6538")]
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
			[Address(RVA = "0xFA3BC0", Offset = "0xFA3BC0", VA = "0xFA3BC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB484", Offset = "0x4CB484")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000363")]
			[Address(RVA = "0xFA3BC8", Offset = "0xFA3BC8", VA = "0xFA3BC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB494", Offset = "0x4CB494")]
			private set
			{
			}
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xFA076C", Offset = "0xFA076C", VA = "0xFA076C")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xFA0B88", Offset = "0xFA0B88", VA = "0xFA0B88")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xFA0A34", Offset = "0xFA0A34", VA = "0xFA0A34")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xFA12E0", Offset = "0xFA12E0", VA = "0xFA12E0")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xFA1424", Offset = "0xFA1424", VA = "0xFA1424")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xFA1454", Offset = "0xFA1454", VA = "0xFA1454")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xFA1504", Offset = "0xFA1504", VA = "0xFA1504")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xFA15EC", Offset = "0xFA15EC", VA = "0xFA15EC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xFA1D08", Offset = "0xFA1D08", VA = "0xFA1D08", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xFA1E78", Offset = "0xFA1E78", VA = "0xFA1E78", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xFA2010", Offset = "0xFA2010", VA = "0xFA2010", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xFA208C", Offset = "0xFA208C", VA = "0xFA208C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xFA2108", Offset = "0xFA2108", VA = "0xFA2108", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xFA22E0", Offset = "0xFA22E0", VA = "0xFA22E0")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xFA0DB4", Offset = "0xFA0DB4", VA = "0xFA0DB4")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xFA0EA4", Offset = "0xFA0EA4", VA = "0xFA0EA4")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xFA11C0", Offset = "0xFA11C0", VA = "0xFA11C0")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xFA16CC", Offset = "0xFA16CC", VA = "0xFA16CC")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xFA24A0", Offset = "0xFA24A0", VA = "0xFA24A0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xFA24D8", Offset = "0xFA24D8", VA = "0xFA24D8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xFA34BC", Offset = "0xFA34BC", VA = "0xFA34BC")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xFA1830", Offset = "0xFA1830", VA = "0xFA1830")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xFA2538", Offset = "0xFA2538", VA = "0xFA2538")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xFA36A0", Offset = "0xFA36A0", VA = "0xFA36A0")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xFA36E8", Offset = "0xFA36E8", VA = "0xFA36E8")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xFA3374", Offset = "0xFA3374", VA = "0xFA3374")]
		private void Write()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xFA372C", Offset = "0xFA372C", VA = "0xFA372C")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xFA3BD0", Offset = "0xFA3BD0", VA = "0xFA3BD0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6570", Offset = "0x4C6570")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6570", Offset = "0x4C6570")]
		public float weight;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C65C4", Offset = "0x4C65C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C65C4", Offset = "0x4C65C4")]
		public float parentChildCrossfade;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6618", Offset = "0x4C6618")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6618", Offset = "0x4C6618")]
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
		[Address(RVA = "0xEDC58C", Offset = "0xEDC58C", VA = "0xEDC58C")]
		public void Relax()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xEDC8A8", Offset = "0xEDC8A8", VA = "0xEDC8A8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xEDCC10", Offset = "0xEDCC10", VA = "0xEDCC10")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xEDCC94", Offset = "0xEDCC94", VA = "0xEDCC94")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xEDCD18", Offset = "0xEDCD18", VA = "0xEDCD18")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xEDCE30", Offset = "0xEDCE30", VA = "0xEDCE30")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C6674", Offset = "0x4C6674")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C6684", Offset = "0x4C6684")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C6694", Offset = "0x4C6694")]
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
			[Address(RVA = "0xECC8E4", Offset = "0xECC8E4", VA = "0xECC8E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB4A4", Offset = "0x4CB4A4")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x600036E")]
			[Address(RVA = "0xECC8EC", Offset = "0xECC8EC", VA = "0xECC8EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB4B4", Offset = "0x4CB4B4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public bool isPaused
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0xECC8F4", Offset = "0xECC8F4", VA = "0xECC8F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB4C4", Offset = "0x4CB4C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000370")]
			[Address(RVA = "0xECC8FC", Offset = "0xECC8FC", VA = "0xECC8FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB4D4", Offset = "0x4CB4D4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0xECC908", Offset = "0xECC908", VA = "0xECC908")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB4E4", Offset = "0x4CB4E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000372")]
			[Address(RVA = "0xECC910", Offset = "0xECC910", VA = "0xECC910")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB4F4", Offset = "0x4CB4F4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public bool inInteraction
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0xECC918", Offset = "0xECC918", VA = "0xECC918")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		public float progress
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0xECECB8", Offset = "0xECECB8", VA = "0xECECB8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xECC984", Offset = "0xECC984", VA = "0xECC984")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xECCA10", Offset = "0xECCA10", VA = "0xECCA10")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xECCAB0", Offset = "0xECCAB0", VA = "0xECCAB0")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xECCBF0", Offset = "0xECCBF0", VA = "0xECCBF0")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xECCEC8", Offset = "0xECCEC8", VA = "0xECCEC8")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xECCF84", Offset = "0xECCF84", VA = "0xECCF84")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xECCFDC", Offset = "0xECCFDC", VA = "0xECCFDC")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xECD9B4", Offset = "0xECD9B4", VA = "0xECD9B4")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xECE410", Offset = "0xECE410", VA = "0xECE410")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xECE654", Offset = "0xECE654", VA = "0xECE654")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xECEB64", Offset = "0xECEB64", VA = "0xECEB64")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xECEE18", Offset = "0xECEE18", VA = "0xECEE18")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C66A4", Offset = "0x4C66A4")]
		public LookAtIK ik;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C66DC", Offset = "0x4C66DC")]
		public float lerpSpeed;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6714", Offset = "0x4C6714")]
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
		[Address(RVA = "0xECF008", Offset = "0xECF008", VA = "0xECF008")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xECF124", Offset = "0xECF124", VA = "0xECF124")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xECF1C8", Offset = "0xECF1C8", VA = "0xECF1C8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xECF800", Offset = "0xECF800", VA = "0xECF800")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xECF8F4", Offset = "0xECF8F4", VA = "0xECF8F4")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xECF9BC", Offset = "0xECF9BC", VA = "0xECF9BC")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C4094", Offset = "0x4C4094")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C4094", Offset = "0x4C4094")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200009C")]
		public class InteractionEvent
		{
			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8D98", Offset = "0x4C8D98")]
			public float time;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8DD0", Offset = "0x4C8DD0")]
			public bool pause;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8E08", Offset = "0x4C8E08")]
			public bool pickUp;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8E40", Offset = "0x4C8E40")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8E78", Offset = "0x4C8E78")]
			public Message[] messages;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8EB0", Offset = "0x4C8EB0")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000582")]
			[Address(RVA = "0xFC0C64", Offset = "0xFC0C64", VA = "0xFC0C64")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0xFC0E38", Offset = "0xFC0E38", VA = "0xFC0E38")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8EE8", Offset = "0x4C8EE8")]
			public string function;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8F20", Offset = "0x4C8F20")]
			public GameObject recipient;

			[Token(Token = "0x40004F9")]
			private const string empty = "";

			[Token(Token = "0x6000584")]
			[Address(RVA = "0xFC0D34", Offset = "0xFC0D34", VA = "0xFC0D34")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000585")]
			[Address(RVA = "0xFC0E40", Offset = "0xFC0E40", VA = "0xFC0E40")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8F58", Offset = "0x4C8F58")]
			public Animator animator;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8F90", Offset = "0x4C8F90")]
			public Animation animation;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C8FC8", Offset = "0x4C8FC8")]
			public string animationState;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9000", Offset = "0x4C9000")]
			public float crossfadeTime;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9038", Offset = "0x4C9038")]
			public int layer;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9070", Offset = "0x4C9070")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000500")]
			private const string empty = "";

			[Token(Token = "0x6000586")]
			[Address(RVA = "0xFC09D0", Offset = "0xFC09D0", VA = "0xFC09D0")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000587")]
			[Address(RVA = "0xFC0AC0", Offset = "0xFC0AC0", VA = "0xFC0AC0")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000588")]
			[Address(RVA = "0xFC0B74", Offset = "0xFC0B74", VA = "0xFC0B74")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000589")]
			[Address(RVA = "0xFC0C50", Offset = "0xFC0C50", VA = "0xFC0C50")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C90A8", Offset = "0x4C90A8")]
			public Type type;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C90E0", Offset = "0x4C90E0")]
			public AnimationCurve curve;

			[Token(Token = "0x600058A")]
			[Address(RVA = "0x10ED644", Offset = "0x10ED644", VA = "0x10ED644")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600058B")]
			[Address(RVA = "0x10ED670", Offset = "0x10ED670", VA = "0x10ED670")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9118", Offset = "0x4C9118")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9150", Offset = "0x4C9150")]
			public float multiplier;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9188", Offset = "0x4C9188")]
			public WeightCurve.Type result;

			[Token(Token = "0x600058C")]
			[Address(RVA = "0x10ED608", Offset = "0x10ED608", VA = "0x10ED608")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600058D")]
			[Address(RVA = "0x10ED660", Offset = "0x10ED660", VA = "0x10ED660")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C675C", Offset = "0x4C675C")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6794", Offset = "0x4C6794")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C67CC", Offset = "0x4C67CC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C6804", Offset = "0x4C6804")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C6814", Offset = "0x4C6814")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700004F")]
		public float length
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0xECFB80", Offset = "0xECFB80", VA = "0xECFB80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB654", Offset = "0x4CB654")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600038E")]
			[Address(RVA = "0xECFB88", Offset = "0xECFB88", VA = "0xECFB88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB664", Offset = "0x4CB664")]
			private set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0xECFB90", Offset = "0xECFB90", VA = "0xECFB90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB674", Offset = "0x4CB674")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000390")]
			[Address(RVA = "0xECFB98", Offset = "0xECFB98", VA = "0xECFB98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB684", Offset = "0x4CB684")]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0xECFD60", Offset = "0xECFD60", VA = "0xECFD60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public Transform targetsRoot
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0xECECF4", Offset = "0xECECF4", VA = "0xECECF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xECF9D0", Offset = "0xECF9D0", VA = "0xECF9D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB504", Offset = "0x4CB504")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xECFA18", Offset = "0xECFA18", VA = "0xECFA18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB53C", Offset = "0x4CB53C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xECFA60", Offset = "0xECFA60", VA = "0xECFA60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB574", Offset = "0x4CB574")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xECFAA8", Offset = "0xECFAA8", VA = "0xECFAA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB5AC", Offset = "0x4CB5AC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xECFAF0", Offset = "0xECFAF0", VA = "0xECFAF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB5E4", Offset = "0x4CB5E4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xECFB38", Offset = "0xECFB38", VA = "0xECFB38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB61C", Offset = "0x4CB61C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xECFBA0", Offset = "0xECFBA0", VA = "0xECFBA0")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xECFDEC", Offset = "0xECFDEC", VA = "0xECFDEC")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xECD530", Offset = "0xECD530", VA = "0xECD530")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xECFF78", Offset = "0xECFF78", VA = "0xECFF78")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xECD3DC", Offset = "0xECD3DC", VA = "0xECD3DC")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xECD528", Offset = "0xECD528", VA = "0xECD528")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xECDFBC", Offset = "0xECDFBC", VA = "0xECDFBC")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xECE884", Offset = "0xECE884", VA = "0xECE884")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xED0508", Offset = "0xED0508", VA = "0xED0508")]
		private void Awake()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xED0060", Offset = "0xED0060", VA = "0xED0060")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xECFF80", Offset = "0xECFF80", VA = "0xECFF80")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xED04A0", Offset = "0xED04A0", VA = "0xED04A0")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xED050C", Offset = "0xED050C", VA = "0xED050C")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xED0574", Offset = "0xED0574", VA = "0xED0574")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB694", Offset = "0x4CB694")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xED05BC", Offset = "0xED05BC", VA = "0xED05BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB6CC", Offset = "0x4CB6CC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xED0604", Offset = "0xED0604", VA = "0xED0604")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C40F4", Offset = "0x4C40F4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C40F4", Offset = "0x4C40F4")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000A1")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000A2")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6824", Offset = "0x4C6824")]
		public string targetTag;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C685C", Offset = "0x4C685C")]
		public float fadeInTime;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6894", Offset = "0x4C6894")]
		public float speed;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C68CC", Offset = "0x4C68CC")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x4C6904", Offset = "0x4C6904")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6904", Offset = "0x4C6904")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x4C6904", Offset = "0x4C6904")]
		public Collider characterCollider;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6988", Offset = "0x4C6988")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x4C6988", Offset = "0x4C6988")]
		public Transform FPSCamera;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C69E8", Offset = "0x4C69E8")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6A20", Offset = "0x4C6A20")]
		public float camRaycastDistance;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C6A58", Offset = "0x4C6A58")]
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
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x4C6A68", Offset = "0x4C6A68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6A68", Offset = "0x4C6A68")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6AC8", Offset = "0x4C6AC8")]
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
			[Address(RVA = "0xED0810", Offset = "0xED0810", VA = "0xED0810")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0xED24B0", Offset = "0xED24B0", VA = "0xED24B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0xED24B8", Offset = "0xED24B8", VA = "0xED24B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0xED24C0", Offset = "0xED24C0", VA = "0xED24C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB854", Offset = "0x4CB854")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0xED24C8", Offset = "0xED24C8", VA = "0xED24C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CB864", Offset = "0x4CB864")]
			private set
			{
			}
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xED0660", Offset = "0xED0660", VA = "0xED0660")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB704", Offset = "0x4CB704")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xED06A8", Offset = "0xED06A8", VA = "0xED06A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB73C", Offset = "0x4CB73C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xED06F0", Offset = "0xED06F0", VA = "0xED06F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB774", Offset = "0x4CB774")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xED0738", Offset = "0xED0738", VA = "0xED0738")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB7AC", Offset = "0x4CB7AC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xED0780", Offset = "0xED0780", VA = "0xED0780")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB7E4", Offset = "0x4CB7E4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xED07C8", Offset = "0xED07C8", VA = "0xED07C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB81C", Offset = "0x4CB81C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xED09B0", Offset = "0xED09B0", VA = "0xED09B0")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xED0A7C", Offset = "0xED0A7C", VA = "0xED0A7C")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xED0B48", Offset = "0xED0B48", VA = "0xED0B48")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xED0BF4", Offset = "0xED0BF4", VA = "0xED0BF4")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xED0CEC", Offset = "0xED0CEC", VA = "0xED0CEC")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xED0E04", Offset = "0xED0E04", VA = "0xED0E04")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xED0E94", Offset = "0xED0E94", VA = "0xED0E94")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xED0F24", Offset = "0xED0F24", VA = "0xED0F24")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xED0FB4", Offset = "0xED0FB4", VA = "0xED0FB4")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xED1028", Offset = "0xED1028", VA = "0xED1028")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xED109C", Offset = "0xED109C", VA = "0xED109C")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xED1104", Offset = "0xED1104", VA = "0xED1104")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xED1190", Offset = "0xED1190", VA = "0xED1190")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xED1244", Offset = "0xED1244", VA = "0xED1244")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xED1328", Offset = "0xED1328", VA = "0xED1328")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xED15FC", Offset = "0xED15FC", VA = "0xED15FC")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xED17DC", Offset = "0xED17DC", VA = "0xED17DC")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xED1A70", Offset = "0xED1A70", VA = "0xED1A70")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xED1D48", Offset = "0xED1D48", VA = "0xED1D48")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xED1D8C", Offset = "0xED1D8C", VA = "0xED1D8C")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xED1E04", Offset = "0xED1E04", VA = "0xED1E04")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xED1F20", Offset = "0xED1F20", VA = "0xED1F20")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xED20C4", Offset = "0xED20C4", VA = "0xED20C4")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xED2368", Offset = "0xED2368", VA = "0xED2368")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xED1B84", Offset = "0xED1B84", VA = "0xED1B84")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xED24D0", Offset = "0xED24D0", VA = "0xED24D0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xED2C38", Offset = "0xED2C38", VA = "0xED2C38")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xED2C58", Offset = "0xED2C58", VA = "0xED2C58")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xED2C74", Offset = "0xED2C74", VA = "0xED2C74")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xED2C90", Offset = "0xED2C90", VA = "0xED2C90")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xED2CF0", Offset = "0xED2CF0", VA = "0xED2CF0")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xED2E2C", Offset = "0xED2E2C", VA = "0xED2E2C")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xED2F3C", Offset = "0xED2F3C", VA = "0xED2F3C")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xED32D8", Offset = "0xED32D8", VA = "0xED32D8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xED33D8", Offset = "0xED33D8", VA = "0xED33D8")]
		private void Update()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xED3668", Offset = "0xED3668", VA = "0xED3668")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xED299C", Offset = "0xED299C", VA = "0xED299C")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xED37A4", Offset = "0xED37A4", VA = "0xED37A4")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xED38CC", Offset = "0xED38CC", VA = "0xED38CC")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xED3984", Offset = "0xED3984", VA = "0xED3984")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xED3A7C", Offset = "0xED3A7C", VA = "0xED3A7C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xED3A94", Offset = "0xED3A94", VA = "0xED3A94")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xED08BC", Offset = "0xED08BC", VA = "0xED08BC")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xED14D0", Offset = "0xED14D0", VA = "0xED14D0")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xED3DFC", Offset = "0xED3DFC", VA = "0xED3DFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB874", Offset = "0x4CB874")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xED3E44", Offset = "0xED3E44", VA = "0xED3E44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB8AC", Offset = "0x4CB8AC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xED3E8C", Offset = "0xED3E8C", VA = "0xED3E8C")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C4154", Offset = "0x4C4154")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C4154", Offset = "0x4C4154")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A3")]
		public class Multiplier
		{
			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C91C0", Offset = "0x4C91C0")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C91F8", Offset = "0x4C91F8")]
			public float multiplier;

			[Token(Token = "0x6000596")]
			[Address(RVA = "0x10EDCDC", Offset = "0x10EDCDC", VA = "0x10EDCDC")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6B00", Offset = "0x4C6B00")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6B38", Offset = "0x4C6B38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6B70", Offset = "0x4C6B70")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6BA8", Offset = "0x4C6BA8")]
		public Transform pivot;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6BE0", Offset = "0x4C6BE0")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6C18", Offset = "0x4C6C18")]
		public float twistWeight;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6C50", Offset = "0x4C6C50")]
		public float swingWeight;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6C88", Offset = "0x4C6C88")]
		public bool rotateOnce;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xED4230", Offset = "0xED4230", VA = "0xED4230")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB8E4", Offset = "0x4CB8E4")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xED4278", Offset = "0xED4278", VA = "0xED4278")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB91C", Offset = "0x4CB91C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xED42C0", Offset = "0xED42C0", VA = "0xED42C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB954", Offset = "0x4CB954")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xED4308", Offset = "0xED4308", VA = "0xED4308")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB98C", Offset = "0x4CB98C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xED4350", Offset = "0xED4350", VA = "0xED4350")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB9C4", Offset = "0x4CB9C4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xED4398", Offset = "0xED4398", VA = "0xED4398")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CB9FC", Offset = "0x4CB9FC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xECFFF0", Offset = "0xECFFF0", VA = "0xECFFF0")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xECED80", Offset = "0xECED80", VA = "0xECED80")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xECD5E4", Offset = "0xECD5E4", VA = "0xECD5E4")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xED44C0", Offset = "0xED44C0", VA = "0xED44C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBA34", Offset = "0x4CBA34")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xED4508", Offset = "0xED4508", VA = "0xED4508")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBA6C", Offset = "0x4CBA6C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xED4550", Offset = "0xED4550", VA = "0xED4550")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C41B4", Offset = "0x4C41B4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C41B4", Offset = "0x4C41B4")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A4")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9230", Offset = "0x4C9230")]
			public bool use;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9268", Offset = "0x4C9268")]
			public Vector2 offset;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C92A0", Offset = "0x4C92A0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C92A0", Offset = "0x4C92A0")]
			public float angleOffset;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C92FC", Offset = "0x4C92FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C92FC", Offset = "0x4C92FC")]
			public float maxAngle;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9354", Offset = "0x4C9354")]
			public float radius;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C938C", Offset = "0x4C938C")]
			public bool orbit;

			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C93C4", Offset = "0x4C93C4")]
			public bool fixYAxis;

			[Token(Token = "0x17000097")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000597")]
				[Address(RVA = "0x10EE04C", Offset = "0x10EE04C", VA = "0x10EE04C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000098")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000598")]
				[Address(RVA = "0x10EE058", Offset = "0x10EE058", VA = "0x10EE058")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000599")]
			[Address(RVA = "0x10EE0E0", Offset = "0x10EE0E0", VA = "0x10EE0E0")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0x10EE524", Offset = "0x10EE524", VA = "0x10EE524")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C93FC", Offset = "0x4C93FC")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9434", Offset = "0x4C9434")]
			public Vector3 direction;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C946C", Offset = "0x4C946C")]
			public float maxDistance;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C94A4", Offset = "0x4C94A4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C94A4", Offset = "0x4C94A4")]
			public float maxAngle;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C94FC", Offset = "0x4C94FC")]
			public bool fixYAxis;

			[Token(Token = "0x600059B")]
			[Address(RVA = "0x10EDCE4", Offset = "0x10EDCE4", VA = "0x10EDCE4")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600059C")]
			[Address(RVA = "0x10EDDD8", Offset = "0x10EDDD8", VA = "0x10EDDD8")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600059D")]
			[Address(RVA = "0x10EE000", Offset = "0x10EE000", VA = "0x10EE000")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4CA094", Offset = "0x4CA094")]
				public InteractionObject interactionObject;

				[Token(Token = "0x400059C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4CA0CC", Offset = "0x4CA0CC")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000603")]
				[Address(RVA = "0x10F13B8", Offset = "0x10F13B8", VA = "0x10F13B8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C95A4", Offset = "0x4C95A4")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C95DC", Offset = "0x4C95DC")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9614", Offset = "0x4C9614")]
			public Interaction[] interactions;

			[Token(Token = "0x600059E")]
			[Address(RVA = "0x10EE538", Offset = "0x10EE538", VA = "0x10EE538")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x600059F")]
			[Address(RVA = "0x10EE5EC", Offset = "0x10EE5EC", VA = "0x10EE5EC")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6CC0", Offset = "0x4C6CC0")]
		public Range[] ranges;

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xED4598", Offset = "0xED4598", VA = "0xED4598")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBAA4", Offset = "0x4CBAA4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xED45E0", Offset = "0xED45E0", VA = "0xED45E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBADC", Offset = "0x4CBADC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xED4628", Offset = "0xED4628", VA = "0xED4628")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBB14", Offset = "0x4CBB14")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xED4670", Offset = "0xED4670", VA = "0xED4670")]
		private void Start()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xED3108", Offset = "0xED3108", VA = "0xED3108")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xED4674", Offset = "0xED4674", VA = "0xED4674")]
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
			[Address(RVA = "0xFB1C40", Offset = "0xFB1C40", VA = "0xFB1C40")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0xFB1C7C", Offset = "0xFB1C7C", VA = "0xFB1C7C")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0xFB1CCC", Offset = "0xFB1CCC", VA = "0xFB1CCC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0xFB1D18", Offset = "0xFB1D18", VA = "0xFB1D18")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xF4ADD0", Offset = "0xF4ADD0", VA = "0xF4ADD0", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBB4C", Offset = "0x4CBB4C")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xF4B14C", Offset = "0xF4B14C", VA = "0xF4B14C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xF4B150", Offset = "0xF4B150", VA = "0xF4B150", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xF4B258", Offset = "0xF4B258", VA = "0xF4B258", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xF4B0E0", Offset = "0xF4B0E0", VA = "0xF4B0E0")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xF4B040", Offset = "0xF4B040", VA = "0xF4B040")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xF4B2C4", Offset = "0xF4B2C4", VA = "0xF4B2C4")]
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
		[Address(RVA = "0xF517AC", Offset = "0xF517AC", VA = "0xF517AC", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xF51878", Offset = "0xF51878", VA = "0xF51878", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xF51A34", Offset = "0xF51A34", VA = "0xF51A34", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xF51B30", Offset = "0xF51B30", VA = "0xF51B30", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xF518D0", Offset = "0xF518D0", VA = "0xF518D0")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xF51E90", Offset = "0xF51E90", VA = "0xF51E90")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6CF8", Offset = "0x4C6CF8")]
		public float weight;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6D10", Offset = "0x4C6D10")]
		public float localRotationWeight;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6D28", Offset = "0x4C6D28")]
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
		[Address(RVA = "0xED6084", Offset = "0xED6084", VA = "0xED6084", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xED60D8", Offset = "0xED60D8", VA = "0xED60D8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xED6114", Offset = "0xED6114", VA = "0xED6114", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xED612C", Offset = "0xED612C", VA = "0xED612C")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4C4214", Offset = "0x4C4214")]
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
			[Address(RVA = "0x10EF24C", Offset = "0x10EF24C", VA = "0x10EF24C")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x10EF3BC", Offset = "0x10EF3BC", VA = "0x10EF3BC")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x10EF49C", Offset = "0x10EF49C", VA = "0x10EF49C")]
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
			[Address(RVA = "0x10EF05C", Offset = "0x10EF05C", VA = "0x10EF05C")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x10EF0BC", Offset = "0x10EF0BC", VA = "0x10EF0BC")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x10EF1FC", Offset = "0x10EF1FC", VA = "0x10EF1FC")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C4404", Offset = "0x4C4404")]
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
				[Address(RVA = "0x10EF00C", Offset = "0x10EF00C", VA = "0x10EF00C", Slot = "4")]
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
				[Address(RVA = "0x10EF054", Offset = "0x10EF054", VA = "0x10EF054", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x10EEDF0", Offset = "0x10EEDF0", VA = "0x10EEDF0")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x10EEE1C", Offset = "0x10EEE1C", VA = "0x10EEE1C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x10EEE20", Offset = "0x10EEE20", VA = "0x10EEE20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x10EF014", Offset = "0x10EF014", VA = "0x10EF014", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6D40", Offset = "0x4C6D40")]
		public IK ik;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6D78", Offset = "0x4C6D78")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6DB0", Offset = "0x4C6DB0")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6DE8", Offset = "0x4C6DE8")]
		public float applyVelocity;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6E20", Offset = "0x4C6E20")]
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
			[Address(RVA = "0xED6944", Offset = "0xED6944", VA = "0xED6944")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		private bool ikUsed
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0xED72CC", Offset = "0xED72CC", VA = "0xED72CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xED690C", Offset = "0xED690C", VA = "0xED690C")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xED69BC", Offset = "0xED69BC", VA = "0xED69BC")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xED6AEC", Offset = "0xED6AEC", VA = "0xED6AEC")]
		public void Start()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xED6A80", Offset = "0xED6A80", VA = "0xED6A80")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4CBB84", Offset = "0x4CBB84")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xED6F08", Offset = "0xED6F08", VA = "0xED6F08")]
		private void Update()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xED7154", Offset = "0xED7154", VA = "0xED7154")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xED7210", Offset = "0xED7210", VA = "0xED7210")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xED744C", Offset = "0xED744C", VA = "0xED744C")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xED7290", Offset = "0xED7290", VA = "0xED7290")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xED7408", Offset = "0xED7408", VA = "0xED7408")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xED74EC", Offset = "0xED74EC", VA = "0xED74EC")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xED7480", Offset = "0xED7480", VA = "0xED7480")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xED6A14", Offset = "0xED6A14", VA = "0xED6A14")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xED7194", Offset = "0xED7194", VA = "0xED7194")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xED7718", Offset = "0xED7718", VA = "0xED7718")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xED7830", Offset = "0xED7830", VA = "0xED7830")]
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
			[Address(RVA = "0xED8A08", Offset = "0xED8A08", VA = "0xED8A08")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000059")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0xED8A14", Offset = "0xED8A14", VA = "0xED8A14")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xED872C", Offset = "0xED872C", VA = "0xED872C")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xED8770", Offset = "0xED8770", VA = "0xED8770")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xED8960", Offset = "0xED8960", VA = "0xED8960")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xED89D0", Offset = "0xED89D0", VA = "0xED89D0")]
		public void Disable()
		{
		}

		[Token(Token = "0x600041C")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xED8888", Offset = "0xED8888", VA = "0xED8888")]
		private void Awake()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xED8A30", Offset = "0xED8A30", VA = "0xED8A30")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xED8A34", Offset = "0xED8A34", VA = "0xED8A34")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xED8A64", Offset = "0xED8A64", VA = "0xED8A64")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xED8AE0", Offset = "0xED8AE0", VA = "0xED8AE0")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xED8C74", Offset = "0xED8C74", VA = "0xED8C74")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xED8CE4", Offset = "0xED8CE4", VA = "0xED8CE4")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C4274", Offset = "0x4C4274")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C4274", Offset = "0x4C4274")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6E68", Offset = "0x4C6E68")]
		public float limit;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6E84", Offset = "0x4C6E84")]
		public float twistLimit;

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xED8D18", Offset = "0xED8D18", VA = "0xED8D18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBBE4", Offset = "0x4CBBE4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xED8D60", Offset = "0xED8D60", VA = "0xED8D60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBC1C", Offset = "0x4CBC1C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xED8DA8", Offset = "0xED8DA8", VA = "0xED8DA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBC54", Offset = "0x4CBC54")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xED8DF0", Offset = "0xED8DF0", VA = "0xED8DF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBC8C", Offset = "0x4CBC8C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xED8E38", Offset = "0xED8E38", VA = "0xED8E38", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xED8E7C", Offset = "0xED8E7C", VA = "0xED8E7C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xED903C", Offset = "0xED903C", VA = "0xED903C")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C42D4", Offset = "0x4C42D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C42D4", Offset = "0x4C42D4")]
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
		[Address(RVA = "0xED907C", Offset = "0xED907C", VA = "0xED907C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBCC4", Offset = "0x4CBCC4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xED90C4", Offset = "0xED90C4", VA = "0xED90C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBCFC", Offset = "0x4CBCFC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xED910C", Offset = "0xED910C", VA = "0xED910C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBD34", Offset = "0x4CBD34")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xED9154", Offset = "0xED9154", VA = "0xED9154")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBD6C", Offset = "0x4CBD6C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xED919C", Offset = "0xED919C", VA = "0xED919C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xED91C4", Offset = "0xED91C4", VA = "0xED91C4")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xED93C0", Offset = "0xED93C0", VA = "0xED93C0")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C4334", Offset = "0x4C4334")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C4334", Offset = "0x4C4334")]
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
				[Address(RVA = "0x10EF8A4", Offset = "0x10EF8A4", VA = "0x10EF8A4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009C")]
			public Vector3 a
			{
				[Token(Token = "0x60005B1")]
				[Address(RVA = "0x10EF8DC", Offset = "0x10EF8DC", VA = "0x10EF8DC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009D")]
			public Vector3 b
			{
				[Token(Token = "0x60005B2")]
				[Address(RVA = "0x10EF918", Offset = "0x10EF918", VA = "0x10EF918")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009E")]
			public Vector3 c
			{
				[Token(Token = "0x60005B3")]
				[Address(RVA = "0x10EF954", Offset = "0x10EF954", VA = "0x10EF954")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009F")]
			public bool isValid
			{
				[Token(Token = "0x60005B5")]
				[Address(RVA = "0x10EFACC", Offset = "0x10EFACC", VA = "0x10EFACC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x10EF990", Offset = "0x10EF990", VA = "0x10EF990")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x10EFADC", Offset = "0x10EFADC", VA = "0x10EFADC")]
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
			[Address(RVA = "0x10EF868", Offset = "0x10EF868", VA = "0x10EF868")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6EB0", Offset = "0x4C6EB0")]
		public float twistLimit;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6ECC", Offset = "0x4C6ECC")]
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
		[Address(RVA = "0xED9418", Offset = "0xED9418", VA = "0xED9418")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBDA4", Offset = "0x4CBDA4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xED9460", Offset = "0xED9460", VA = "0xED9460")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBDDC", Offset = "0x4CBDDC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xED94A8", Offset = "0xED94A8", VA = "0xED94A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBE14", Offset = "0x4CBE14")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xED94F0", Offset = "0xED94F0", VA = "0xED94F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBE4C", Offset = "0x4CBE4C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xED9538", Offset = "0xED9538", VA = "0xED9538")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xED99D4", Offset = "0xED99D4", VA = "0xED99D4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xED9A68", Offset = "0xED9A68", VA = "0xED9A68")]
		private void Start()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xED9F8C", Offset = "0xED9F8C", VA = "0xED9F8C")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xED95D0", Offset = "0xED95D0", VA = "0xED95D0")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xEDA30C", Offset = "0xEDA30C", VA = "0xEDA30C")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xEDA718", Offset = "0xEDA718", VA = "0xEDA718")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xEDA75C", Offset = "0xEDA75C", VA = "0xEDA75C")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xEDA7BC", Offset = "0xEDA7BC", VA = "0xEDA7BC")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xED9D20", Offset = "0xED9D20", VA = "0xED9D20")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xEDA828", Offset = "0xEDA828", VA = "0xEDA828")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xEDA904", Offset = "0xEDA904", VA = "0xEDA904")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4C4394", Offset = "0x4C4394")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4C4394", Offset = "0x4C4394")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C6F8C", Offset = "0x4C6F8C")]
		public float twistLimit;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xEDA978", Offset = "0xEDA978", VA = "0xEDA978")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBE84", Offset = "0x4CBE84")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xEDA9C0", Offset = "0xEDA9C0", VA = "0xEDA9C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBEBC", Offset = "0x4CBEBC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xEDAA08", Offset = "0xEDAA08", VA = "0xEDAA08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBEF4", Offset = "0x4CBEF4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xEDAA50", Offset = "0xEDAA50", VA = "0xEDAA50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x4CBF2C", Offset = "0x4CBF2C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xEDAA98", Offset = "0xEDAA98", VA = "0xEDAA98")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xEDAAB4", Offset = "0xEDAAB4", VA = "0xEDAAB4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xEDAAF8", Offset = "0xEDAAF8", VA = "0xEDAAF8")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xEDAD1C", Offset = "0xEDAD1C", VA = "0xEDAD1C")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C6FE0", Offset = "0x4C6FE0")]
		public AimIK ik;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7018", Offset = "0x4C7018")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C7018", Offset = "0x4C7018")]
		public float weight;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x4C706C", Offset = "0x4C706C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C706C", Offset = "0x4C706C")]
		public Transform target;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C70CC", Offset = "0x4C70CC")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7104", Offset = "0x4C7104")]
		public float weightSmoothTime;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x4C713C", Offset = "0x4C713C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C713C", Offset = "0x4C713C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C719C", Offset = "0x4C719C")]
		public float maxRadiansDelta;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C71D4", Offset = "0x4C71D4")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C720C", Offset = "0x4C720C")]
		public float slerpSpeed;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7244", Offset = "0x4C7244")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C727C", Offset = "0x4C727C")]
		public float minDistance;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C72B4", Offset = "0x4C72B4")]
		public Vector3 offset;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x4C72EC", Offset = "0x4C72EC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C72EC", Offset = "0x4C72EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C72EC", Offset = "0x4C72EC")]
		public float maxRootAngle;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x4C7368", Offset = "0x4C7368")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7368", Offset = "0x4C7368")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C73C8", Offset = "0x4C73C8")]
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
			[Address(RVA = "0xEDDD10", Offset = "0xEDDD10", VA = "0xEDDD10")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xEDDC88", Offset = "0xEDDC88", VA = "0xEDDC88")]
		private void Start()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xEDDDA0", Offset = "0xEDDDA0", VA = "0xEDDDA0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xEDE2DC", Offset = "0xEDE2DC", VA = "0xEDE2DC")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xEDE3C8", Offset = "0xEDE3C8", VA = "0xEDE3C8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xEDE5C0", Offset = "0xEDE5C0", VA = "0xEDE5C0")]
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
			[Address(RVA = "0xFB1130", Offset = "0xFB1130", VA = "0xFB1130")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xFB12BC", Offset = "0xFB12BC", VA = "0xFB12BC")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0xFB12C4", Offset = "0xFB12C4", VA = "0xFB12C4")]
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
		[Address(RVA = "0xEDE814", Offset = "0xEDE814", VA = "0xEDE814")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xEDE8F4", Offset = "0xEDE8F4", VA = "0xEDE8F4")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xEDE960", Offset = "0xEDE960", VA = "0xEDE960")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4CA104", Offset = "0x4CA104")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400059E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4CA13C", Offset = "0x4CA13C")]
				public float weight;

				[Token(Token = "0x6000604")]
				[Address(RVA = "0x10F0F9C", Offset = "0x10F0F9C", VA = "0x10F0F9C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C964C", Offset = "0x4C964C")]
			public Transform transform;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9684", Offset = "0x4C9684")]
			public Transform relativeTo;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C96BC", Offset = "0x4C96BC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C96F4", Offset = "0x4C96F4")]
			public float verticalWeight;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C972C", Offset = "0x4C972C")]
			public float horizontalWeight;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9764", Offset = "0x4C9764")]
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
			[Address(RVA = "0xFB12E0", Offset = "0xFB12E0", VA = "0xFB12E0")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xFB160C", Offset = "0xFB160C", VA = "0xFB160C")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0xFB161C", Offset = "0xFB161C", VA = "0xFB161C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7400", Offset = "0x4C7400")]
		public Body[] bodies;

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xEDE9C4", Offset = "0xEDE9C4", VA = "0xEDE9C4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xEDEB10", Offset = "0xEDEB10", VA = "0xEDEB10")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7438", Offset = "0x4C7438")]
		public float tiltSpeed;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7470", Offset = "0x4C7470")]
		public float tiltSensitivity;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C74A8", Offset = "0x4C74A8")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C74E0", Offset = "0x4C74E0")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xEE6CC0", Offset = "0xEE6CC0", VA = "0xEE6CC0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xEE6D08", Offset = "0xEE6D08", VA = "0xEE6D08", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xEE6EC0", Offset = "0xEE6EC0", VA = "0xEE6EC0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C979C", Offset = "0x4C979C")]
			public string name;

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C97D4", Offset = "0x4C97D4")]
			public Collider collider;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C980C", Offset = "0x4C980C")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C9858", Offset = "0x4C9858")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C9868", Offset = "0x4C9868")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C9878", Offset = "0x4C9878")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C9888", Offset = "0x4C9888")]
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
				[Address(RVA = "0xFB3408", Offset = "0xFB3408", VA = "0xFB3408")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A1")]
			protected float crossFader
			{
				[Token(Token = "0x60005BF")]
				[Address(RVA = "0xFB341C", Offset = "0xFB341C", VA = "0xFB341C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC334", Offset = "0x4CC334")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005C0")]
				[Address(RVA = "0xFB3424", Offset = "0xFB3424", VA = "0xFB3424")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC344", Offset = "0x4CC344")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			protected float timer
			{
				[Token(Token = "0x60005C1")]
				[Address(RVA = "0xFB342C", Offset = "0xFB342C", VA = "0xFB342C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC354", Offset = "0x4CC354")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005C2")]
				[Address(RVA = "0xFB3434", Offset = "0xFB3434", VA = "0xFB3434")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC364", Offset = "0x4CC364")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A3")]
			protected Vector3 force
			{
				[Token(Token = "0x60005C3")]
				[Address(RVA = "0xFB343C", Offset = "0xFB343C", VA = "0xFB343C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC374", Offset = "0x4CC374")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005C4")]
				[Address(RVA = "0xFB3448", Offset = "0xFB3448", VA = "0xFB3448")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC384", Offset = "0x4CC384")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A4")]
			protected Vector3 point
			{
				[Token(Token = "0x60005C5")]
				[Address(RVA = "0xFB3454", Offset = "0xFB3454", VA = "0xFB3454")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC394", Offset = "0x4CC394")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005C6")]
				[Address(RVA = "0xFB3460", Offset = "0xFB3460", VA = "0xFB3460")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC3A4", Offset = "0x4CC3A4")]
				private set
				{
				}
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0xFB346C", Offset = "0xFB346C", VA = "0xFB346C")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0xFB35A0", Offset = "0xFB35A0", VA = "0xFB35A0")]
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
			[Address(RVA = "0xFB3674", Offset = "0xFB3674", VA = "0xFB3674")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4CA174", Offset = "0x4CA174")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005A0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4CA1AC", Offset = "0x4CA1AC")]
				public float weight;

				[Token(Token = "0x40005A1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40005A2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000605")]
				[Address(RVA = "0x10F110C", Offset = "0x10F110C", VA = "0x10F110C")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000606")]
				[Address(RVA = "0x10F11BC", Offset = "0x10F11BC", VA = "0x10F11BC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000607")]
				[Address(RVA = "0x10F11D0", Offset = "0x10F11D0", VA = "0x10F11D0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9898", Offset = "0x4C9898")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C98D0", Offset = "0x4C98D0")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9908", Offset = "0x4C9908")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0xFB39A0", Offset = "0xFB39A0", VA = "0xFB39A0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005CE")]
			[Address(RVA = "0xFB3AD0", Offset = "0xFB3AD0", VA = "0xFB3AD0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0xFB3B3C", Offset = "0xFB3B3C", VA = "0xFB3B3C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0xFB3CA4", Offset = "0xFB3CA4", VA = "0xFB3CA4")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4CA1E4", Offset = "0x4CA1E4")]
				public Transform bone;

				[Token(Token = "0x40005A4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4CA21C", Offset = "0x4CA21C")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4CA21C", Offset = "0x4CA21C")]
				public float weight;

				[Token(Token = "0x40005A5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x40005A6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000608")]
				[Address(RVA = "0x10F0FA4", Offset = "0x10F0FA4", VA = "0x10F0FA4")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000609")]
				[Address(RVA = "0x10F10BC", Offset = "0x10F10BC", VA = "0x10F10BC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600060A")]
				[Address(RVA = "0x10F10C8", Offset = "0x10F10C8", VA = "0x10F10C8")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9940", Offset = "0x4C9940")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9978", Offset = "0x4C9978")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0xFB3688", Offset = "0xFB3688", VA = "0xFB3688", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0xFB372C", Offset = "0xFB372C", VA = "0xFB372C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0xFB3798", Offset = "0xFB3798", VA = "0xFB3798", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0xFB398C", Offset = "0xFB398C", VA = "0xFB398C")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7518", Offset = "0x4C7518")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7550", Offset = "0x4C7550")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700005B")]
		public bool inProgress
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0xF52D30", Offset = "0xF52D30", VA = "0xF52D30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xF52E00", Offset = "0xF52E00", VA = "0xF52E00", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xF52EDC", Offset = "0xF52EDC", VA = "0xF52EDC")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xF53138", Offset = "0xF53138", VA = "0xF53138")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C99B0", Offset = "0x4C99B0")]
			public string name;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C99E8", Offset = "0x4C99E8")]
			public Collider collider;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9A20", Offset = "0x4C9A20")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C9A6C", Offset = "0x4C9A6C")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C9A7C", Offset = "0x4C9A7C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C9A8C", Offset = "0x4C9A8C")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C9A9C", Offset = "0x4C9A9C")]
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
				[Address(RVA = "0xFB3CB8", Offset = "0xFB3CB8", VA = "0xFB3CB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC3B4", Offset = "0x4CC3B4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005D6")]
				[Address(RVA = "0xFB3CC0", Offset = "0xFB3CC0", VA = "0xFB3CC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC3C4", Offset = "0x4CC3C4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			protected float timer
			{
				[Token(Token = "0x60005D7")]
				[Address(RVA = "0xFB3CC8", Offset = "0xFB3CC8", VA = "0xFB3CC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC3D4", Offset = "0x4CC3D4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005D8")]
				[Address(RVA = "0xFB3CD0", Offset = "0xFB3CD0", VA = "0xFB3CD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC3E4", Offset = "0x4CC3E4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			protected Vector3 force
			{
				[Token(Token = "0x60005D9")]
				[Address(RVA = "0xFB3CD8", Offset = "0xFB3CD8", VA = "0xFB3CD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC3F4", Offset = "0x4CC3F4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005DA")]
				[Address(RVA = "0xFB3CE4", Offset = "0xFB3CE4", VA = "0xFB3CE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC404", Offset = "0x4CC404")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A8")]
			protected Vector3 point
			{
				[Token(Token = "0x60005DB")]
				[Address(RVA = "0xFB3CF0", Offset = "0xFB3CF0", VA = "0xFB3CF0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC414", Offset = "0x4CC414")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005DC")]
				[Address(RVA = "0xFB3CFC", Offset = "0xFB3CFC", VA = "0xFB3CFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC424", Offset = "0x4CC424")]
				private set
				{
				}
			}

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0xFB3D08", Offset = "0xFB3D08", VA = "0xFB3D08")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0xFB3E50", Offset = "0xFB3E50", VA = "0xFB3E50")]
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
			[Address(RVA = "0xFB3F38", Offset = "0xFB3F38", VA = "0xFB3F38")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4CA270", Offset = "0x4CA270")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x40005A8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4CA2A8", Offset = "0x4CA2A8")]
				public float weight;

				[Token(Token = "0x40005A9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40005AA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600060B")]
				[Address(RVA = "0x10F11D8", Offset = "0x10F11D8", VA = "0x10F11D8")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600060C")]
				[Address(RVA = "0x10F1268", Offset = "0x10F1268", VA = "0x10F1268")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600060D")]
				[Address(RVA = "0x10F127C", Offset = "0x10F127C", VA = "0x10F127C")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9AAC", Offset = "0x4C9AAC")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9AE4", Offset = "0x4C9AE4")]
			public int upDirCurveIndex;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9B1C", Offset = "0x4C9B1C")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x60005E3")]
			[Address(RVA = "0xFB3F4C", Offset = "0xFB3F4C", VA = "0xFB3F4C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0xFB40FC", Offset = "0xFB40FC", VA = "0xFB40FC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0xFB4168", Offset = "0xFB4168", VA = "0xFB4168", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0xFB4308", Offset = "0xFB4308", VA = "0xFB4308")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4CA2E0", Offset = "0x4CA2E0")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x40005AC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4CA318", Offset = "0x4CA318")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4CA318", Offset = "0x4CA318")]
				public float weight;

				[Token(Token = "0x40005AD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x40005AE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x600060E")]
				[Address(RVA = "0x10F1284", Offset = "0x10F1284", VA = "0x10F1284")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600060F")]
				[Address(RVA = "0x10F1360", Offset = "0x10F1360", VA = "0x10F1360")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000610")]
				[Address(RVA = "0x10F136C", Offset = "0x10F136C", VA = "0x10F136C")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9B54", Offset = "0x4C9B54")]
			public int curveIndex;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9B8C", Offset = "0x4C9B8C")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0xFB4324", Offset = "0xFB4324", VA = "0xFB4324", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0xFB4408", Offset = "0xFB4408", VA = "0xFB4408", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0xFB4474", Offset = "0xFB4474", VA = "0xFB4474", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60005EA")]
			[Address(RVA = "0xFB4728", Offset = "0xFB4728", VA = "0xFB4728")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7588", Offset = "0x4C7588")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C75C0", Offset = "0x4C75C0")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xF53140", Offset = "0xF53140", VA = "0xF53140", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xF53214", Offset = "0xF53214", VA = "0xF53214")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xF53478", Offset = "0xF53478", VA = "0xF53478")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4CA36C", Offset = "0x4CA36C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005B0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4CA3A4", Offset = "0x4CA3A4")]
				public float weight;

				[Token(Token = "0x6000611")]
				[Address(RVA = "0x10F13B0", Offset = "0x10F13B0", VA = "0x10F13B0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9BC4", Offset = "0x4C9BC4")]
			public Transform transform;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9BFC", Offset = "0x4C9BFC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9C34", Offset = "0x4C9C34")]
			public float speed;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9C6C", Offset = "0x4C9C6C")]
			public float acceleration;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9CA4", Offset = "0x4C9CA4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C9CA4", Offset = "0x4C9CA4")]
			public float matchVelocity;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9CF8", Offset = "0x4C9CF8")]
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
			[Address(RVA = "0xFC0640", Offset = "0xFC0640", VA = "0xFC0640")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xFC06F8", Offset = "0xFC06F8", VA = "0xFC06F8")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0xFC09B4", Offset = "0xFC09B4", VA = "0xFC09B4")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C75F8", Offset = "0x4C75F8")]
		public Body[] bodies;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7630", Offset = "0x4C7630")]
		public OffsetLimits[] limits;

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xECC6A0", Offset = "0xECC6A0", VA = "0xECC6A0")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xECC71C", Offset = "0xECC71C", VA = "0xECC71C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xECC8C4", Offset = "0xECC8C4", VA = "0xECC8C4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9D30", Offset = "0x4C9D30")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9D68", Offset = "0x4C9D68")]
			public float spring;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9DA0", Offset = "0x4C9DA0")]
			public bool x;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9DD8", Offset = "0x4C9DD8")]
			public bool y;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9E10", Offset = "0x4C9E10")]
			public bool z;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9E48", Offset = "0x4C9E48")]
			public float minX;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9E80", Offset = "0x4C9E80")]
			public float maxX;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9EB8", Offset = "0x4C9EB8")]
			public float minY;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9EF0", Offset = "0x4C9EF0")]
			public float maxY;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9F28", Offset = "0x4C9F28")]
			public float minZ;

			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9F60", Offset = "0x4C9F60")]
			public float maxZ;

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x10EE7CC", Offset = "0x10EE7CC", VA = "0x10EE7CC")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x10EE924", Offset = "0x10EE924", VA = "0x10EE924")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x10EE99C", Offset = "0x10EE99C", VA = "0x10EE99C")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x10EE9F4", Offset = "0x10EE9F4", VA = "0x10EE9F4")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C4414", Offset = "0x4C4414")]
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
				[Address(RVA = "0x10EE77C", Offset = "0x10EE77C", VA = "0x10EE77C", Slot = "4")]
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
				[Address(RVA = "0x10EE7C4", Offset = "0x10EE7C4", VA = "0x10EE7C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x10EE5FC", Offset = "0x10EE5FC", VA = "0x10EE5FC")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x10EE628", Offset = "0x10EE628", VA = "0x10EE628", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x10EE62C", Offset = "0x10EE62C", VA = "0x10EE62C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x10EE784", Offset = "0x10EE784", VA = "0x10EE784", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7668", Offset = "0x4C7668")]
		public float weight;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C76A0", Offset = "0x4C76A0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x1700005C")]
		protected float deltaTime
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0xECC7D8", Offset = "0xECC7D8", VA = "0xECC7D8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000463")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xED596C", Offset = "0xED596C", VA = "0xED596C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xED5998", Offset = "0xED5998", VA = "0xED5998")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4CBF64", Offset = "0x4CBF64")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xED5A04", Offset = "0xED5A04", VA = "0xED5A04")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xECC804", Offset = "0xECC804", VA = "0xECC804")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xED5AE0", Offset = "0xED5AE0", VA = "0xED5AE0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xECC8D4", Offset = "0xECC8D4", VA = "0xECC8D4")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4C4424", Offset = "0x4C4424")]
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
				[Address(RVA = "0x10EEB7C", Offset = "0x10EEB7C", VA = "0x10EEB7C", Slot = "4")]
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
				[Address(RVA = "0x10EEBC4", Offset = "0x10EEBC4", VA = "0x10EEBC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x10EE9FC", Offset = "0x10EE9FC", VA = "0x10EE9FC")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x10EEA28", Offset = "0x10EEA28", VA = "0x10EEA28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x10EEA2C", Offset = "0x10EEA2C", VA = "0x10EEA2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x10EEB84", Offset = "0x10EEB84", VA = "0x10EEB84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C76D8", Offset = "0x4C76D8")]
		public float weight;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7710", Offset = "0x4C7710")]
		public VRIK ik;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x1700005D")]
		protected float deltaTime
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0xED5BEC", Offset = "0xED5BEC", VA = "0xED5BEC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600046B")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xED5C18", Offset = "0xED5C18", VA = "0xED5C18", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xED5C44", Offset = "0xED5C44", VA = "0xED5C44")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4CBFC4", Offset = "0x4CBFC4")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xED5CB0", Offset = "0xED5CB0", VA = "0xED5CB0")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xED5D8C", Offset = "0xED5D8C", VA = "0xED5D8C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xED5E98", Offset = "0xED5E98", VA = "0xED5E98")]
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
			[Address(RVA = "0x10EEBCC", Offset = "0x10EEBCC", VA = "0x10EEBCC")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x10EEDE8", Offset = "0x10EEDE8", VA = "0x10EEDE8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xED5EA8", Offset = "0xED5EA8", VA = "0xED5EA8")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xED5F6C", Offset = "0xED5F6C", VA = "0xED5F6C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xED6028", Offset = "0xED6028", VA = "0xED6028")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4CA3DC", Offset = "0x4CA3DC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005B2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4CA414", Offset = "0x4CA414")]
				public float weight;

				[Token(Token = "0x6000612")]
				[Address(RVA = "0x10F13C0", Offset = "0x10F13C0", VA = "0x10F13C0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9F98", Offset = "0x4C9F98")]
			public Vector3 offset;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C9FD0", Offset = "0x4C9FD0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4C9FD0", Offset = "0x4C9FD0")]
			public float additivity;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4CA024", Offset = "0x4CA024")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4CA05C", Offset = "0x4CA05C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x10EF640", Offset = "0x10EF640", VA = "0x10EF640")]
			public void Start()
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x10EF690", Offset = "0x10EF690", VA = "0x10EF690")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x10EF854", Offset = "0x10EF854", VA = "0x10EF854")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7748", Offset = "0x4C7748")]
		public AimIK aimIK;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7780", Offset = "0x4C7780")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C77B8", Offset = "0x4C77B8")]
		public Handedness handedness;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C77F0", Offset = "0x4C77F0")]
		public bool twoHanded;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7828", Offset = "0x4C7828")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7860", Offset = "0x4C7860")]
		public float magnitudeRandom;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7898", Offset = "0x4C7898")]
		public Vector3 rotationRandom;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C78D0", Offset = "0x4C78D0")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7908", Offset = "0x4C7908")]
		public float blendTime;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x4C7940", Offset = "0x4C7940")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C7940", Offset = "0x4C7940")]
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
			[Address(RVA = "0xED791C", Offset = "0xED791C", VA = "0xED791C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x600047A")]
			[Address(RVA = "0xED8394", Offset = "0xED8394", VA = "0xED8394")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0xED83D4", Offset = "0xED83D4", VA = "0xED83D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		private Transform primaryHand
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0xED8354", Offset = "0xED8354", VA = "0xED8354")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		private Transform secondaryHand
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0xED8374", Offset = "0xED8374", VA = "0xED8374")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xED794C", Offset = "0xED794C", VA = "0xED794C")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xED7978", Offset = "0xED7978", VA = "0xED7978")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xED7AC0", Offset = "0xED7AC0", VA = "0xED7AC0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xED8414", Offset = "0xED8414", VA = "0xED8414")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xED84C8", Offset = "0xED84C8", VA = "0xED84C8")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xED8504", Offset = "0xED8504", VA = "0xED8504", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xED86BC", Offset = "0xED86BC", VA = "0xED86BC")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C79A0", Offset = "0x4C79A0")]
		public float weight;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4C79D8", Offset = "0x4C79D8")]
		public float offset;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xEDAD58", Offset = "0xEDAD58", VA = "0xEDAD58")]
		private void Start()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xEDAE40", Offset = "0xEDAE40", VA = "0xEDAE40")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xEDAF28", Offset = "0xEDAF28", VA = "0xEDAF28")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xEDB27C", Offset = "0xEDB27C", VA = "0xEDB27C")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xEDB2B4", Offset = "0xEDB2B4", VA = "0xEDB2B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xEDB3C0", Offset = "0xEDB3C0", VA = "0xEDB3C0")]
		public ShoulderRotator()
		{
		}
	}
}
