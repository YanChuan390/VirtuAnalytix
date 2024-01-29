using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RootMotion
{
	[Token(Token = "0x2000002")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000AA")]
		public enum UpdateMode
		{
			[Token(Token = "0x40004E2")]
			Update,
			[Token(Token = "0x40004E3")]
			FixedUpdate,
			[Token(Token = "0x40004E4")]
			LateUpdate,
			[Token(Token = "0x40004E5")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform target;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform rotationSpace;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool lockCursor;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2BA75C", Offset = "0x2BA75C")]
		public bool smoothFollow;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float followSpeed;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2BA790", Offset = "0x2BA790")]
		public float rotationSensitivity;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float yMinLimit;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float yMaxLimit;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool rotateAlways;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public bool rotateOnRightButton;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2BA7C4", Offset = "0x2BA7C4")]
		public float distance;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float minDistance;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float maxDistance;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float zoomSpeed;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float zoomSensitivity;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2BA7FC", Offset = "0x2BA7FC")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float blockingRadius;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BA834", Offset = "0x2BA834")]
		public float blockedOffset;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BA84C", Offset = "0x2BA84C")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BA85C", Offset = "0x2BA85C")]
		private float <y>k__BackingField;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BA86C", Offset = "0x2BA86C")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 targetDistance;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 position;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion rotation;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 smoothPosition;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Camera cam;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool fixedFrame;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Quaternion r;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 lastUp;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blockedDistance;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float blockedDistanceV;

		[Token(Token = "0x17000001")]
		public float x
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0xBE15E0", Offset = "0xBE15E0", VA = "0xBE15E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C2EF0", Offset = "0x2C2EF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0xBE15E8", Offset = "0xBE15E8", VA = "0xBE15E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C2F00", Offset = "0x2C2F00")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float y
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0xBE15F0", Offset = "0xBE15F0", VA = "0xBE15F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C2F10", Offset = "0x2C2F10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0xBE15F8", Offset = "0xBE15F8", VA = "0xBE15F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C2F20", Offset = "0x2C2F20")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public float distanceTarget
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0xBE1600", Offset = "0xBE1600", VA = "0xBE1600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C2F30", Offset = "0x2C2F30")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0xBE1608", Offset = "0xBE1608", VA = "0xBE1608")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C2F40", Offset = "0x2C2F40")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		private float zoomAdd
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0xBE23B4", Offset = "0xBE23B4", VA = "0xBE23B4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xBE1610", Offset = "0xBE1610", VA = "0xBE1610", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xBE17C0", Offset = "0xBE17C0", VA = "0xBE17C0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xBE1814", Offset = "0xBE1814", VA = "0xBE1814", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xBE1870", Offset = "0xBE1870", VA = "0xBE1870", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xBE18D4", Offset = "0xBE18D4", VA = "0xBE18D4")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xBE17F0", Offset = "0xBE17F0", VA = "0xBE17F0")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xBE1AC0", Offset = "0xBE1AC0", VA = "0xBE1AC0")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xBE22E8", Offset = "0xBE22E8", VA = "0xBE22E8")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xBE2448", Offset = "0xBE2448", VA = "0xBE2448")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000003")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float rotationSensitivity;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float yMinLimit;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float yMaxLimit;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float x;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float y;

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xBE25C8", Offset = "0xBE25C8", VA = "0xBE25C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xBE2618", Offset = "0xBE2618", VA = "0xBE2618")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xBE280C", Offset = "0xBE280C", VA = "0xBE280C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xBE28D8", Offset = "0xBE28D8", VA = "0xBE28D8")]
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
		[Address(RVA = "0xBD6A5C", Offset = "0xBD6A5C", VA = "0xBD6A5C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xBD6B5C", Offset = "0xBD6B5C", VA = "0xBD6B5C")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xBD6C38", Offset = "0xBD6C38", VA = "0xBD6C38")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xBD6E84", Offset = "0xBD6E84", VA = "0xBD6E84")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xBD6D94", Offset = "0xBD6D94", VA = "0xBD6D94")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xBD6FE0", Offset = "0xBD6FE0", VA = "0xBD6FE0")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xBD7334", Offset = "0xBD7334", VA = "0xBD7334")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000006")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x20000AB")]
		public class LimbOrientation
		{
			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x600056F")]
			[Address(RVA = "0xBD75C8", Offset = "0xBD75C8", VA = "0xBD75C8")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000005")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0xBD7374", Offset = "0xBD7374", VA = "0xBD7374")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0xBD7620", Offset = "0xBD7620", VA = "0xBD7620")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xBD733C", Offset = "0xBD733C", VA = "0xBD733C")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x20000AC")]
		public enum BoneType
		{
			[Token(Token = "0x40004EA")]
			Unassigned,
			[Token(Token = "0x40004EB")]
			Spine,
			[Token(Token = "0x40004EC")]
			Head,
			[Token(Token = "0x40004ED")]
			Arm,
			[Token(Token = "0x40004EE")]
			Leg,
			[Token(Token = "0x40004EF")]
			Tail,
			[Token(Token = "0x40004F0")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x20000AD")]
		public enum BoneSide
		{
			[Token(Token = "0x40004F2")]
			Center,
			[Token(Token = "0x40004F3")]
			Left,
			[Token(Token = "0x40004F4")]
			Right
		}

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static string[] typeRight;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeSpine;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static string[] typeHead;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeArm;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static string[] typeLeg;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeTail;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static string[] typeEye;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeExclude;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static string[] pelvis;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] hand;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static string[] foot;

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xBD7874", Offset = "0xBD7874", VA = "0xBD7874")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xBD7C74", Offset = "0xBD7C74", VA = "0xBD7C74")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xBD7F60", Offset = "0xBD7F60", VA = "0xBD7F60")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xBD7FF8", Offset = "0xBD7FF8", VA = "0xBD7FF8")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xBD80AC", Offset = "0xBD80AC", VA = "0xBD80AC")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xBD7A98", Offset = "0xBD7A98", VA = "0xBD7A98")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xBD7E98", Offset = "0xBD7E98", VA = "0xBD7E98")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xBD8B8C", Offset = "0xBD8B8C", VA = "0xBD8B8C")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xBD88FC", Offset = "0xBD88FC", VA = "0xBD88FC")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xBD8A44", Offset = "0xBD8A44", VA = "0xBD8A44")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xBD832C", Offset = "0xBD832C", VA = "0xBD832C")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xBD8424", Offset = "0xBD8424", VA = "0xBD8424")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xBD851C", Offset = "0xBD851C", VA = "0xBD851C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xBD8614", Offset = "0xBD8614", VA = "0xBD8614")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xBD870C", Offset = "0xBD870C", VA = "0xBD870C")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xBD8804", Offset = "0xBD8804", VA = "0xBD8804")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xBD8E30", Offset = "0xBD8E30", VA = "0xBD8E30")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xBD8208", Offset = "0xBD8208", VA = "0xBD8208")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xBD8DA4", Offset = "0xBD8DA4", VA = "0xBD8DA4")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xBD8EC8", Offset = "0xBD8EC8", VA = "0xBD8EC8")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xBD8FA8", Offset = "0xBD8FA8", VA = "0xBD8FA8")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xBD8CFC", Offset = "0xBD8CFC", VA = "0xBD8CFC")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xBD8C28", Offset = "0xBD8C28", VA = "0xBD8C28")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000008")]
	public class BipedReferences
	{
		[Token(Token = "0x20000AE")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x17000069")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000571")]
				[Address(RVA = "0xBE15D8", Offset = "0xBE15D8", VA = "0xBE15D8")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0x3DD3FC", Offset = "0x3DD3FC", VA = "0x3DD3FC")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform root;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform pelvis;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform leftThigh;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform leftCalf;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftFoot;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Transform rightThigh;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightCalf;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Transform rightFoot;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftUpperArm;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Transform leftForearm;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHand;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightForearm;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Transform rightHand;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform head;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Transform[] spine;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform[] eyes;

		[Token(Token = "0x17000007")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0xBDC880", Offset = "0xBDC880", VA = "0xBDC880", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public bool isEmpty
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0xBDCE2C", Offset = "0xBDCE2C", VA = "0xBDCE2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xBDCE40", Offset = "0xBDCE40", VA = "0xBDCE40", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xBDD444", Offset = "0xBDD444", VA = "0xBDD444", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xBDDA18", Offset = "0xBDDA18", VA = "0xBDDA18")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xBDE3A0", Offset = "0xBDE3A0", VA = "0xBDE3A0")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xBDDD00", Offset = "0xBDDD00", VA = "0xBDDD00")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xBDF108", Offset = "0xBDF108", VA = "0xBDF108")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xBDF22C", Offset = "0xBDF22C", VA = "0xBDF22C")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xBDF944", Offset = "0xBDF944", VA = "0xBDF944")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xBDF6BC", Offset = "0xBDF6BC", VA = "0xBDF6BC")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xBDF488", Offset = "0xBDF488", VA = "0xBDF488")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xBDF314", Offset = "0xBDF314", VA = "0xBDF314")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xBDF808", Offset = "0xBDF808", VA = "0xBDF808")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xBDFA78", Offset = "0xBDFA78", VA = "0xBDFA78")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xBE0B78", Offset = "0xBE0B78", VA = "0xBE0B78")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xBE0374", Offset = "0xBE0374", VA = "0xBE0374")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xBE0FA4", Offset = "0xBE0FA4", VA = "0xBE0FA4")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xBE08C0", Offset = "0xBE08C0", VA = "0xBE08C0")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xBE0FAC", Offset = "0xBE0FAC", VA = "0xBE0FAC")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xBE0FB4", Offset = "0xBE0FB4", VA = "0xBE0FB4")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xBE11DC", Offset = "0xBE11DC", VA = "0xBE11DC")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xBE1484", Offset = "0xBE1484", VA = "0xBE1484")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xBDDC7C", Offset = "0xBDDC7C", VA = "0xBDDC7C")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[Multiline]
		public string text;

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xBE2904", Offset = "0xBE2904", VA = "0xBE2904")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string text;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color color;

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xBE290C", Offset = "0xBE290C", VA = "0xBE290C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xBE29F4", Offset = "0xBE29F4", VA = "0xBE29F4")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class Hierarchy
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1340E3C", Offset = "0x1340E3C", VA = "0x1340E3C")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x13410C8", Offset = "0x13410C8", VA = "0x13410C8")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1340ED4", Offset = "0x1340ED4", VA = "0x1340ED4")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1341228", Offset = "0x1341228", VA = "0x1341228")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1341388", Offset = "0x1341388", VA = "0x1341388")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1341704", Offset = "0x1341704", VA = "0x1341704")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1341884", Offset = "0x1341884", VA = "0x1341884")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1341AB0", Offset = "0x1341AB0", VA = "0x1341AB0")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1341F40", Offset = "0x1341F40", VA = "0x1341F40")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1341C98", Offset = "0x1341C98", VA = "0x1341C98")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1342164", Offset = "0x1342164", VA = "0x1342164")]
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
		[Address(RVA = "0x134216C", Offset = "0x134216C", VA = "0x134216C")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1342E10", Offset = "0x1342E10", VA = "0x1342E10")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1342F30", Offset = "0x1342F30", VA = "0x1342F30")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1342530", Offset = "0x1342530", VA = "0x1342530")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x134254C", Offset = "0x134254C", VA = "0x134254C")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1342584", Offset = "0x1342584", VA = "0x1342584")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x13425D0", Offset = "0x13425D0", VA = "0x13425D0")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x13425F8", Offset = "0x13425F8", VA = "0x13425F8")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x134261C", Offset = "0x134261C", VA = "0x134261C")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1342640", Offset = "0x1342640", VA = "0x1342640")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1342660", Offset = "0x1342660", VA = "0x1342660")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x13426B8", Offset = "0x13426B8", VA = "0x13426B8")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1342700", Offset = "0x1342700", VA = "0x1342700")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1342738", Offset = "0x1342738", VA = "0x1342738")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1343050", Offset = "0x1343050", VA = "0x1343050")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x134277C", Offset = "0x134277C", VA = "0x134277C")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x13427B4", Offset = "0x13427B4", VA = "0x13427B4")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x13427F4", Offset = "0x13427F4", VA = "0x13427F4")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1342838", Offset = "0x1342838", VA = "0x1342838")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x134288C", Offset = "0x134288C", VA = "0x134288C")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1342900", Offset = "0x1342900", VA = "0x1342900")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1342974", Offset = "0x1342974", VA = "0x1342974")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x13429D8", Offset = "0x13429D8", VA = "0x13429D8")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1342A3C", Offset = "0x1342A3C", VA = "0x1342A3C")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1342AF4", Offset = "0x1342AF4", VA = "0x1342AF4")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1342BA8", Offset = "0x1342BA8", VA = "0x1342BA8")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1343094", Offset = "0x1343094", VA = "0x1343094")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1342C6C", Offset = "0x1342C6C", VA = "0x1342C6C")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1342D80", Offset = "0x1342D80", VA = "0x1342D80")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1342DC0", Offset = "0x1342DC0", VA = "0x1342DC0")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x13431AC", Offset = "0x13431AC", VA = "0x13431AC")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string name;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string color;

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x13431B4", Offset = "0x13431B4", VA = "0x13431B4")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1343230", Offset = "0x1343230", VA = "0x1343230")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200000F")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x13432AC", Offset = "0x13432AC", VA = "0x13432AC")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x13432F4", Offset = "0x13432F4", VA = "0x13432F4")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1343398", Offset = "0x1343398", VA = "0x1343398")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x13432F8", Offset = "0x13432F8", VA = "0x13432F8")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x134339C", Offset = "0x134339C", VA = "0x134339C")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x134342C", Offset = "0x134342C", VA = "0x134342C")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x134344C", Offset = "0x134344C", VA = "0x134344C")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1343484", Offset = "0x1343484", VA = "0x1343484")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x13434D4", Offset = "0x13434D4", VA = "0x13434D4")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x13435EC", Offset = "0x13435EC", VA = "0x13435EC")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x13436E4", Offset = "0x13436E4", VA = "0x13436E4")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1343758", Offset = "0x1343758", VA = "0x1343758")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000010")]
	public static class QuaTools
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x134377C", Offset = "0x134377C", VA = "0x134377C")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x13438AC", Offset = "0x13438AC", VA = "0x13438AC")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x13439DC", Offset = "0x13439DC", VA = "0x13439DC")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1343B20", Offset = "0x1343B20", VA = "0x1343B20")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x132D558", Offset = "0x132D558", VA = "0x132D558")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1343C64", Offset = "0x1343C64", VA = "0x1343C64")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1333570", Offset = "0x1333570", VA = "0x1333570")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1343D64", Offset = "0x1343D64", VA = "0x1343D64")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x13440B4", Offset = "0x13440B4", VA = "0x13440B4")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1344344", Offset = "0x1344344", VA = "0x1344344")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x133F5A8", Offset = "0x133F5A8", VA = "0x133F5A8")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BA88C", Offset = "0x2BA88C")]
		public bool fixTransforms;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Animator animator;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Animation legacy;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool updateFrame;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool componentInitiated;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000A")]
		private bool animatePhysics
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x1344654", Offset = "0x1344654", VA = "0x1344654")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool isAnimated
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x1344A6C", Offset = "0x1344A6C", VA = "0x1344A6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1344514", Offset = "0x1344514", VA = "0x1344514")]
		public void Disable()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x13445C8", Offset = "0x13445C8", VA = "0x13445C8", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x13445CC", Offset = "0x13445CC", VA = "0x13445CC", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x13445D0", Offset = "0x13445D0", VA = "0x13445D0", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x13445D4", Offset = "0x13445D4", VA = "0x13445D4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1344650", Offset = "0x1344650", VA = "0x1344650")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x13445FC", Offset = "0x13445FC", VA = "0x13445FC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1344A1C", Offset = "0x1344A1C", VA = "0x1344A1C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x134478C", Offset = "0x134478C", VA = "0x134478C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1344B44", Offset = "0x1344B44", VA = "0x1344B44")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1344BA0", Offset = "0x1344BA0", VA = "0x1344BA0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1344C00", Offset = "0x1344C00", VA = "0x1344C00")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x13310FC", Offset = "0x13310FC", VA = "0x13310FC")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public GameObject target;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1344C3C", Offset = "0x1344C3C", VA = "0x1344C3C")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1344D18", Offset = "0x1344D18", VA = "0x1344D18")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1344DF4", Offset = "0x1344DF4", VA = "0x1344DF4")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1344ED0", Offset = "0x1344ED0", VA = "0x1344ED0")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public static class V3Tools
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1344ED8", Offset = "0x1344ED8", VA = "0x1344ED8")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1344FEC", Offset = "0x1344FEC", VA = "0x1344FEC")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1345100", Offset = "0x1345100", VA = "0x1345100")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x134522C", Offset = "0x134522C", VA = "0x134522C")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x134538C", Offset = "0x134538C", VA = "0x134538C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1345644", Offset = "0x1345644", VA = "0x1345644")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x13458F0", Offset = "0x13458F0", VA = "0x13458F0")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1345B08", Offset = "0x1345B08", VA = "0x1345B08")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000015")]
	public static class Warning
	{
		[Token(Token = "0x20000AF")]
		public delegate void Logger(string message);

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1345D24", Offset = "0x1345D24", VA = "0x1345D24")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x132DC18", Offset = "0x132DC18", VA = "0x132DC18")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000016")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform pelvisTarget;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform leftFootTarget;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform rightFootTarget;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 pelvisTargetRight;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private VRIK ik;

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1340524", Offset = "0x1340524", VA = "0x1340524")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1340234", Offset = "0x1340234", VA = "0x1340234")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x13406A0", Offset = "0x13406A0", VA = "0x13406A0")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1340C8C", Offset = "0x1340C8C", VA = "0x1340C8C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1340E34", Offset = "0x1340E34", VA = "0x1340E34")]
		public VRIKRootController()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B931C", Offset = "0x2B931C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B931C", Offset = "0x2B931C")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public BipedReferences references;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xD0A450", Offset = "0xD0A450", VA = "0xD0A450")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C2FC0", Offset = "0x2C2FC0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xD0A4B0", Offset = "0xD0A4B0", VA = "0xD0A4B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C2FF4", Offset = "0x2C2FF4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xD0A510", Offset = "0xD0A510", VA = "0xD0A510")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3028", Offset = "0x2C3028")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xD0A570", Offset = "0xD0A570", VA = "0xD0A570")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C305C", Offset = "0x2C305C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xD0A5D0", Offset = "0xD0A5D0", VA = "0xD0A5D0")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xD0A6A8", Offset = "0xD0A6A8", VA = "0xD0A6A8")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xD0A6D8", Offset = "0xD0A6D8", VA = "0xD0A6D8")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xD0A710", Offset = "0xD0A710", VA = "0xD0A710")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xD0A748", Offset = "0xD0A748", VA = "0xD0A748")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xD0A79C", Offset = "0xD0A79C", VA = "0xD0A79C")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xD0A7F8", Offset = "0xD0A7F8", VA = "0xD0A7F8")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xD0A840", Offset = "0xD0A840", VA = "0xD0A840")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xD0A880", Offset = "0xD0A880", VA = "0xD0A880")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xD0A90C", Offset = "0xD0A90C", VA = "0xD0A90C")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xD0A970", Offset = "0xD0A970", VA = "0xD0A970")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xD0A9D4", Offset = "0xD0A9D4", VA = "0xD0A9D4")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xD0A600", Offset = "0xD0A600", VA = "0xD0A600")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xD0AA1C", Offset = "0xD0AA1C", VA = "0xD0AA1C")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xD0AA2C", Offset = "0xD0AA2C", VA = "0xD0AA2C")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xD0AA3C", Offset = "0xD0AA3C", VA = "0xD0AA3C")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xD0AF1C", Offset = "0xD0AF1C", VA = "0xD0AF1C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xD0B028", Offset = "0xD0B028", VA = "0xD0B028", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xD0B5FC", Offset = "0xD0B5FC", VA = "0xD0B5FC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xD0BD88", Offset = "0xD0BD88", VA = "0xD0BD88")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xD0BDB4", Offset = "0xD0BDB4", VA = "0xD0BDB4")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverAim aim;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Constraints pelvis;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700000C")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0xD0AD34", Offset = "0xD0AD34", VA = "0xD0AD34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xD0BFB4", Offset = "0xD0BFB4", VA = "0xD0BFB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xD0B300", Offset = "0xD0B300", VA = "0xD0B300")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xD0BE50", Offset = "0xD0BE50", VA = "0xD0BE50")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform transform;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float weight;

		[Token(Token = "0x1700000E")]
		public bool isValid
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0xD0C7F8", Offset = "0xD0C7F8", VA = "0xD0C7F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000D9")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xD0C884", Offset = "0xD0C884", VA = "0xD0C884")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001A")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xD0C88C", Offset = "0xD0C88C", VA = "0xD0C88C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xD0C9B8", Offset = "0xD0C9B8", VA = "0xD0C9B8")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xD0C9C0", Offset = "0xD0C9C0", VA = "0xD0C9C0")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001B")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 offset;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x1700000F")]
		private bool positionChanged
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xD0CC74", Offset = "0xD0CC74", VA = "0xD0CC74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xD0C9E0", Offset = "0xD0C9E0", VA = "0xD0C9E0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xD0CD40", Offset = "0xD0CD40", VA = "0xD0CD40")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xD0CD48", Offset = "0xD0CD48", VA = "0xD0CD48")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001C")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Quaternion rotation;

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xD0CD68", Offset = "0xD0CD68", VA = "0xD0CD68", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xD0CEA4", Offset = "0xD0CEA4", VA = "0xD0CEA4")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xD0CEAC", Offset = "0xD0CEAC", VA = "0xD0CEAC")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001D")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Quaternion offset;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool initiated;

		[Token(Token = "0x17000010")]
		private bool rotationChanged
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0xD0D164", Offset = "0xD0D164", VA = "0xD0D164")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xD0CECC", Offset = "0xD0CECC", VA = "0xD0CECC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xD0D238", Offset = "0xD0D238", VA = "0xD0D238")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xD0D240", Offset = "0xD0D240", VA = "0xD0D240")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001E")]
	public class Constraints
	{
		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform transform;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform target;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 positionOffset;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BA8C0", Offset = "0x2BA8C0")]
		public float positionWeight;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 rotation;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BA8D8", Offset = "0x2BA8D8")]
		public float rotationWeight;

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xD0D260", Offset = "0xD0D260", VA = "0xD0D260")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xD0B580", Offset = "0xD0B580", VA = "0xD0B580")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xD0B8E8", Offset = "0xD0B8E8", VA = "0xD0B8E8")]
		public void Update()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xD0C298", Offset = "0xD0C298", VA = "0xD0C298")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001F")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x20000B0")]
		public enum DOF
		{
			[Token(Token = "0x40004F8")]
			One,
			[Token(Token = "0x40004F9")]
			Three
		}

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BA8F0", Offset = "0x2BA8F0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BA8F0", Offset = "0x2BA8F0")]
		public float weight;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BA958", Offset = "0x2BA958")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BA958", Offset = "0x2BA958")]
		public float rotationWeight;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BA9A8", Offset = "0x2BA9A8")]
		public DOF rotationDOF;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BA9DC", Offset = "0x2BA9DC")]
		public Transform bone1;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BAA28", Offset = "0x2BAA28")]
		public Transform bone2;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BAA74", Offset = "0x2BAA74")]
		public Transform bone3;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BAAA8", Offset = "0x2BAAA8")]
		public Transform tip;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BAADC", Offset = "0x2BAADC")]
		public Transform target;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BAB10", Offset = "0x2BAB10")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private IKSolverLimb solver;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 bone1Axis;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 tipAxis;

		[Token(Token = "0x17000011")]
		public bool initiated
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0xD19314", Offset = "0xD19314", VA = "0xD19314")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3090", Offset = "0x2C3090")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0xD1931C", Offset = "0xD1931C", VA = "0xD1931C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C30A0", Offset = "0x2C30A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0xD19324", Offset = "0xD19324", VA = "0xD19324")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0xD19358", Offset = "0xD19358", VA = "0xD19358")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0xD19390", Offset = "0xD19390", VA = "0xD19390")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0xD193C0", Offset = "0xD193C0", VA = "0xD193C0")]
			set
			{
			}
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xD19400", Offset = "0xD19400", VA = "0xD19400")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xD19548", Offset = "0xD19548", VA = "0xD19548")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xD19B68", Offset = "0xD19B68", VA = "0xD19B68")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xD19CA8", Offset = "0xD19CA8", VA = "0xD19CA8")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xD1A268", Offset = "0xD1A268", VA = "0xD1A268")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BAB20", Offset = "0x2BAB20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BAB20", Offset = "0x2BAB20")]
		public float weight;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Finger[] fingers;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BAB8C", Offset = "0x2BAB8C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000014")]
		public bool initiated
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0xD1A27C", Offset = "0xD1A27C", VA = "0xD1A27C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C30B0", Offset = "0x2C30B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0xD1A284", Offset = "0xD1A284", VA = "0xD1A284")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C30C0", Offset = "0x2C30C0")]
			private set
			{
			}
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xD1A28C", Offset = "0xD1A28C", VA = "0xD1A28C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xD1A314", Offset = "0xD1A314", VA = "0xD1A314")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C30D0", Offset = "0x2C30D0")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xD1A7C0", Offset = "0xD1A7C0", VA = "0xD1A7C0")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xD1AA00", Offset = "0xD1AA00", VA = "0xD1AA00")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xD1A66C", Offset = "0xD1A66C", VA = "0xD1A66C")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xD1ABF8", Offset = "0xD1ABF8", VA = "0xD1ABF8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xD1ACF4", Offset = "0xD1ACF4", VA = "0xD1ACF4")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xD1AD88", Offset = "0xD1AD88", VA = "0xD1AD88")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xD1ADF8", Offset = "0xD1ADF8", VA = "0xD1ADF8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xD1ADFC", Offset = "0xD1ADFC", VA = "0xD1ADFC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xD1AE00", Offset = "0xD1AE00", VA = "0xD1AE00")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x20000B1")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BAB9C", Offset = "0x2BAB9C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BAB9C", Offset = "0x2BAB9C")]
		public float weight;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BABEC", Offset = "0x2BABEC")]
		public Grounding solver;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected bool initiated;

		[Token(Token = "0x6000105")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xD1C3E4", Offset = "0xD1C3E4", VA = "0xD1C3E4")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xD1C7AC", Offset = "0xD1C7AC", VA = "0xD1C7AC")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xD1C594", Offset = "0xD1C594", VA = "0xD1C594")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xD1C7D8", Offset = "0xD1C7D8", VA = "0xD1C7D8")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010A")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600010B")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xD1CAC8", Offset = "0xD1CAC8", VA = "0xD1CAC8")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B93CC", Offset = "0x2B93CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B93CC", Offset = "0x2B93CC")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BAC50", Offset = "0x2BAC50")]
		public BipedIK ik;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BAC94", Offset = "0x2BAC94")]
		public float spineBend;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BACC8", Offset = "0x2BACC8")]
		public float spineSpeed;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Transform[] feet;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 spineOffset;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float lastWeight;

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xD1D0B0", Offset = "0xD1D0B0", VA = "0xD1D0B0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3108", Offset = "0x2C3108")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xD1D110", Offset = "0xD1D110", VA = "0xD1D110", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C313C", Offset = "0x2C313C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xD1D170", Offset = "0xD1D170", VA = "0xD1D170", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xD1D2C8", Offset = "0xD1D2C8", VA = "0xD1D2C8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xD1D3FC", Offset = "0xD1D3FC", VA = "0xD1D3FC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xD1D4D4", Offset = "0xD1D4D4", VA = "0xD1D4D4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xD1DD8C", Offset = "0xD1DD8C", VA = "0xD1DD8C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xD1DE30", Offset = "0xD1DE30", VA = "0xD1DE30")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xD1E998", Offset = "0xD1E998", VA = "0xD1E998")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xD1EBBC", Offset = "0xD1EBBC", VA = "0xD1EBBC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xD1EE78", Offset = "0xD1EE78", VA = "0xD1EE78")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xD1F158", Offset = "0xD1F158", VA = "0xD1F158")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B9458", Offset = "0x2B9458")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B9458", Offset = "0x2B9458")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000B2")]
		public class SpineEffector
		{
			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BF608", Offset = "0x2BF608")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BF650", Offset = "0x2BF650")]
			public float horizontalWeight;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BF6B4", Offset = "0x2BF6B4")]
			public float verticalWeight;

			[Token(Token = "0x600057A")]
			[Address(RVA = "0xD206CC", Offset = "0xD206CC", VA = "0xD206CC")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600057B")]
			[Address(RVA = "0xD206DC", Offset = "0xD206DC", VA = "0xD206DC")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BACFC", Offset = "0x2BACFC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BAD4C", Offset = "0x2BAD4C")]
		public float spineBend;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BAD80", Offset = "0x2BAD80")]
		public float spineSpeed;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public SpineEffector[] spine;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform[] feet;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 spineOffset;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool firstSolve;

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xD1F1FC", Offset = "0xD1F1FC", VA = "0xD1F1FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3170", Offset = "0x2C3170")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xD1F25C", Offset = "0xD1F25C", VA = "0xD1F25C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C31A4", Offset = "0x2C31A4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xD1F2BC", Offset = "0xD1F2BC", VA = "0xD1F2BC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C31D8", Offset = "0x2C31D8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xD1F31C", Offset = "0xD1F31C", VA = "0xD1F31C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xD1F3D0", Offset = "0xD1F3D0", VA = "0xD1F3D0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xD1F49C", Offset = "0xD1F49C", VA = "0xD1F49C")]
		private void Update()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xD1F954", Offset = "0xD1F954", VA = "0xD1F954")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xD1F960", Offset = "0xD1F960", VA = "0xD1F960")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xD1F57C", Offset = "0xD1F57C", VA = "0xD1F57C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xD1F96C", Offset = "0xD1F96C", VA = "0xD1F96C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xD20080", Offset = "0xD20080", VA = "0xD20080")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xD202F0", Offset = "0xD202F0", VA = "0xD202F0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xD20478", Offset = "0xD20478", VA = "0xD20478")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xD2062C", Offset = "0xD2062C", VA = "0xD2062C")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B94F0", Offset = "0x2B94F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B94F0", Offset = "0x2B94F0")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IK[] legs;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BADB4", Offset = "0x2BADB4")]
		public Transform pelvis;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BAE18", Offset = "0x2BAE18")]
		public Transform characterRoot;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BAE4C", Offset = "0x2BAE4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BAE4C", Offset = "0x2BAE4C")]
		public float rootRotationWeight;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BAE9C", Offset = "0x2BAE9C")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BAED0", Offset = "0x2BAED0")]
		public float maxRootRotationAngle;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform[] feet;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int solvedFeet;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool solved;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float lastWeight;

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xD20718", Offset = "0xD20718", VA = "0xD20718", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C320C", Offset = "0x2C320C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xD20778", Offset = "0xD20778", VA = "0xD20778", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3240", Offset = "0x2C3240")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xD207D8", Offset = "0xD207D8", VA = "0xD207D8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xD20800", Offset = "0xD20800", VA = "0xD20800")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xD20A6C", Offset = "0xD20A6C", VA = "0xD20A6C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xD20BE0", Offset = "0xD20BE0", VA = "0xD20BE0")]
		private void Update()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xD213DC", Offset = "0xD213DC", VA = "0xD213DC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xD21AD8", Offset = "0xD21AD8", VA = "0xD21AD8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xD21DE4", Offset = "0xD21DE4", VA = "0xD21DE4")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xD223CC", Offset = "0xD223CC", VA = "0xD223CC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xD2267C", Offset = "0xD2267C", VA = "0xD2267C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xD229B4", Offset = "0xD229B4", VA = "0xD229B4")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B9578", Offset = "0x2B9578")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B9578", Offset = "0x2B9578")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x20000B3")]
		public struct Foot
		{
			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Transform transform;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Quaternion rotation;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Grounding.Leg leg;

			[Token(Token = "0x600057C")]
			[Address(RVA = "0x3E0598", Offset = "0x3E0598", VA = "0x3E0598")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BAF30", Offset = "0x2BAF30")]
		public Grounding forelegSolver;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BAF84", Offset = "0x2BAF84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BAF84", Offset = "0x2BAF84")]
		public float rootRotationWeight;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BAFD4", Offset = "0x2BAFD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BAFD4", Offset = "0x2BAFD4")]
		public float minRootRotation;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB028", Offset = "0x2BB028")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BB028", Offset = "0x2BB028")]
		public float maxRootRotation;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB07C", Offset = "0x2BB07C")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB0B0", Offset = "0x2BB0B0")]
		public float maxLegOffset;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB114", Offset = "0x2BB114")]
		public float maxForeLegOffset;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB17C", Offset = "0x2BB17C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BB17C", Offset = "0x2BB17C")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB1CC", Offset = "0x2BB1CC")]
		public Transform characterRoot;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB200", Offset = "0x2BB200")]
		public Transform pelvis;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB234", Offset = "0x2BB234")]
		public Transform lastSpineBone;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB268", Offset = "0x2BB268")]
		public Transform head;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public IK[] legs;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public IK[] forelegs;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Foot[] feet;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int solvedFeet;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool solved;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float angle;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Transform forefeetRoot;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion headRotation;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float lastWeight;

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xD22A58", Offset = "0xD22A58", VA = "0xD22A58", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3274", Offset = "0x2C3274")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xD22AB8", Offset = "0xD22AB8", VA = "0xD22AB8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C32A8", Offset = "0x2C32A8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xD22B18", Offset = "0xD22B18", VA = "0xD22B18", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xD22B60", Offset = "0xD22B60", VA = "0xD22B60")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xD22CEC", Offset = "0xD22CEC", VA = "0xD22CEC")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xD22EE4", Offset = "0xD22EE4", VA = "0xD22EE4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xD22FBC", Offset = "0xD22FBC", VA = "0xD22FBC")]
		private void Update()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xD2309C", Offset = "0xD2309C", VA = "0xD2309C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xD2350C", Offset = "0xD2350C", VA = "0xD2350C")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xD23AF4", Offset = "0xD23AF4", VA = "0xD23AF4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xD23C4C", Offset = "0xD23C4C", VA = "0xD23C4C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xD24124", Offset = "0xD24124", VA = "0xD24124")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xD24C18", Offset = "0xD24C18", VA = "0xD24C18")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xD24FE0", Offset = "0xD24FE0", VA = "0xD24FE0")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xD2518C", Offset = "0xD2518C", VA = "0xD2518C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xD25614", Offset = "0xD25614", VA = "0xD25614")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xD25648", Offset = "0xD25648", VA = "0xD25648")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xD25970", Offset = "0xD25970", VA = "0xD25970")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B9608", Offset = "0x2B9608")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB2E4", Offset = "0x2BB2E4")]
		public VRIK ik;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Transform[] feet;

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xD25AE8", Offset = "0xD25AE8", VA = "0xD25AE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C32DC", Offset = "0x2C32DC")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xD25AEC", Offset = "0xD25AEC", VA = "0xD25AEC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3310", Offset = "0x2C3310")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xD25AF0", Offset = "0xD25AF0", VA = "0xD25AF0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3344", Offset = "0x2C3344")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xD25AF4", Offset = "0xD25AF4", VA = "0xD25AF4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xD25B1C", Offset = "0xD25B1C", VA = "0xD25B1C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xD25BE8", Offset = "0xD25BE8", VA = "0xD25BE8")]
		private void Update()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xD25CC0", Offset = "0xD25CC0", VA = "0xD25CC0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xD260BC", Offset = "0xD260BC", VA = "0xD260BC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xD264F4", Offset = "0xD264F4", VA = "0xD264F4")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xD26640", Offset = "0xD26640", VA = "0xD26640")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xD269B8", Offset = "0xD269B8", VA = "0xD269B8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xD26B40", Offset = "0xD26B40", VA = "0xD26B40")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xD26DF8", Offset = "0xD26DF8", VA = "0xD26DF8")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000027")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x20000B4")]
		public enum Quality
		{
			[Token(Token = "0x4000502")]
			Fastest,
			[Token(Token = "0x4000503")]
			Simple,
			[Token(Token = "0x4000504")]
			Best
		}

		[Token(Token = "0x20000B5")]
		public class Leg
		{
			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF704", Offset = "0x2BF704")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF714", Offset = "0x2BF714")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF724", Offset = "0x2BF724")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF734", Offset = "0x2BF734")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF744", Offset = "0x2BF744")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF754", Offset = "0x2BF754")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF764", Offset = "0x2BF764")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool invertFootCenter;

			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Grounding grounding;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float deltaTime;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Quaternion r;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private RaycastHit heelHit;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private Vector3 up;

			[Token(Token = "0x1700006A")]
			public bool isGrounded
			{
				[Token(Token = "0x600057D")]
				[Address(RVA = "0xD284F4", Offset = "0xD284F4", VA = "0xD284F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4BD8", Offset = "0x2C4BD8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600057E")]
				[Address(RVA = "0xD28AFC", Offset = "0xD28AFC", VA = "0xD28AFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4BE8", Offset = "0x2C4BE8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006B")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x600057F")]
				[Address(RVA = "0xD1CAA8", Offset = "0xD1CAA8", VA = "0xD1CAA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4BF8", Offset = "0x2C4BF8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000580")]
				[Address(RVA = "0xD28B04", Offset = "0xD28B04", VA = "0xD28B04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4C08", Offset = "0x2C4C08")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006C")]
			public bool initiated
			{
				[Token(Token = "0x6000581")]
				[Address(RVA = "0xD28B10", Offset = "0xD28B10", VA = "0xD28B10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4C18", Offset = "0x2C4C18")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000582")]
				[Address(RVA = "0xD28B18", Offset = "0xD28B18", VA = "0xD28B18")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4C28", Offset = "0x2C4C28")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public float heightFromGround
			{
				[Token(Token = "0x6000583")]
				[Address(RVA = "0xD28B20", Offset = "0xD28B20", VA = "0xD28B20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4C38", Offset = "0x2C4C38")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000584")]
				[Address(RVA = "0xD28B28", Offset = "0xD28B28", VA = "0xD28B28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4C48", Offset = "0x2C4C48")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000585")]
				[Address(RVA = "0xD28B30", Offset = "0xD28B30", VA = "0xD28B30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4C58", Offset = "0x2C4C58")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000586")]
				[Address(RVA = "0xD28B44", Offset = "0xD28B44", VA = "0xD28B44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4C68", Offset = "0x2C4C68")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public Transform transform
			{
				[Token(Token = "0x6000587")]
				[Address(RVA = "0xD1CABC", Offset = "0xD1CABC", VA = "0xD1CABC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4C78", Offset = "0x2C4C78")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000588")]
				[Address(RVA = "0xD28B50", Offset = "0xD28B50", VA = "0xD28B50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4C88", Offset = "0x2C4C88")]
				private set
				{
				}
			}

			[Token(Token = "0x17000070")]
			public float IKOffset
			{
				[Token(Token = "0x6000589")]
				[Address(RVA = "0xD284EC", Offset = "0xD284EC", VA = "0xD284EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4C98", Offset = "0x2C4C98")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600058A")]
				[Address(RVA = "0xD28B58", Offset = "0xD28B58", VA = "0xD28B58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4CA8", Offset = "0x2C4CA8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000071")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x600058F")]
				[Address(RVA = "0xD29730", Offset = "0xD29730", VA = "0xD29730")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000072")]
			private float rootYOffset
			{
				[Token(Token = "0x6000598")]
				[Address(RVA = "0xD29B2C", Offset = "0xD29B2C", VA = "0xD29B2C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600058B")]
			[Address(RVA = "0xD27620", Offset = "0xD27620", VA = "0xD27620")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x600058C")]
			[Address(RVA = "0xD28B60", Offset = "0xD28B60", VA = "0xD28B60")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600058D")]
			[Address(RVA = "0xD284FC", Offset = "0xD284FC", VA = "0xD284FC")]
			public void Reset()
			{
			}

			[Token(Token = "0x600058E")]
			[Address(RVA = "0xD27778", Offset = "0xD27778", VA = "0xD27778")]
			public void Process()
			{
			}

			[Token(Token = "0x6000590")]
			[Address(RVA = "0xD29268", Offset = "0xD29268", VA = "0xD29268")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000591")]
			[Address(RVA = "0xD28BC0", Offset = "0xD28BC0", VA = "0xD28BC0")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000592")]
			[Address(RVA = "0xD29948", Offset = "0xD29948", VA = "0xD29948")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000593")]
			[Address(RVA = "0xD28EC4", Offset = "0xD28EC4", VA = "0xD28EC4")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000594")]
			[Address(RVA = "0xD28FC4", Offset = "0xD28FC4", VA = "0xD28FC4")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000595")]
			[Address(RVA = "0xD29A98", Offset = "0xD29A98", VA = "0xD29A98")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000596")]
			[Address(RVA = "0xD29804", Offset = "0xD29804", VA = "0xD29804")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000597")]
			[Address(RVA = "0xD29CB4", Offset = "0xD29CB4", VA = "0xD29CB4")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000599")]
			[Address(RVA = "0xD27530", Offset = "0xD27530", VA = "0xD27530")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x20000B6")]
		public class Pelvis
		{
			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF774", Offset = "0x2BF774")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF784", Offset = "0x2BF784")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Grounding grounding;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float damperF;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private bool initiated;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float lastTime;

			[Token(Token = "0x17000073")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x600059A")]
				[Address(RVA = "0x115CA20", Offset = "0x115CA20", VA = "0x115CA20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4CB8", Offset = "0x2C4CB8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600059B")]
				[Address(RVA = "0x115CA34", Offset = "0x115CA34", VA = "0x115CA34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4CC8", Offset = "0x2C4CC8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000074")]
			public float heightOffset
			{
				[Token(Token = "0x600059C")]
				[Address(RVA = "0x115CA40", Offset = "0x115CA40", VA = "0x115CA40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4CD8", Offset = "0x2C4CD8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600059D")]
				[Address(RVA = "0x115CA48", Offset = "0x115CA48", VA = "0x115CA48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4CE8", Offset = "0x2C4CE8")]
				private set
				{
				}
			}

			[Token(Token = "0x600059E")]
			[Address(RVA = "0x115CA50", Offset = "0x115CA50", VA = "0x115CA50")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x600059F")]
			[Address(RVA = "0x115CB00", Offset = "0x115CB00", VA = "0x115CB00")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x115CA60", Offset = "0x115CA60", VA = "0x115CA60")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x115CC1C", Offset = "0x115CC1C", VA = "0x115CC1C")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x115CF94", Offset = "0x115CF94", VA = "0x115CF94")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB330", Offset = "0x2BB330")]
		public LayerMask layers;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB364", Offset = "0x2BB364")]
		public float maxStep;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB398", Offset = "0x2BB398")]
		public float heightOffset;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB3E4", Offset = "0x2BB3E4")]
		public float footSpeed;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB438", Offset = "0x2BB438")]
		public float footRadius;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB46C", Offset = "0x2BB46C")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB4E4", Offset = "0x2BB4E4")]
		public float prediction;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB54C", Offset = "0x2BB54C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BB54C", Offset = "0x2BB54C")]
		public float footRotationWeight;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB5D0", Offset = "0x2BB5D0")]
		public float footRotationSpeed;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB634", Offset = "0x2BB634")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BB634", Offset = "0x2BB634")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB688", Offset = "0x2BB688")]
		public bool rotateSolver;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB6BC", Offset = "0x2BB6BC")]
		public float pelvisSpeed;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB714", Offset = "0x2BB714")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BB714", Offset = "0x2BB714")]
		public float pelvisDamper;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB79C", Offset = "0x2BB79C")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB800", Offset = "0x2BB800")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB834", Offset = "0x2BB834")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB868", Offset = "0x2BB868")]
		public Quality quality;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BB89C", Offset = "0x2BB89C")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BB8AC", Offset = "0x2BB8AC")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BB8BC", Offset = "0x2BB8BC")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BB8CC", Offset = "0x2BB8CC")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BB8DC", Offset = "0x2BB8DC")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool initiated;

		[Token(Token = "0x17000015")]
		public Leg[] legs
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0xD1C58C", Offset = "0xD1C58C", VA = "0xD1C58C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3378", Offset = "0x2C3378")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0xD26E68", Offset = "0xD26E68", VA = "0xD26E68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3388", Offset = "0x2C3388")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0xD1E990", Offset = "0xD1E990", VA = "0xD1E990")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3398", Offset = "0x2C3398")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0xD26E70", Offset = "0xD26E70", VA = "0xD26E70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C33A8", Offset = "0x2C33A8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public bool isGrounded
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0xD26E78", Offset = "0xD26E78", VA = "0xD26E78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C33B8", Offset = "0x2C33B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0xD26E80", Offset = "0xD26E80", VA = "0xD26E80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C33C8", Offset = "0x2C33C8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public Transform root
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0xD1CAA0", Offset = "0xD1CAA0", VA = "0xD1CAA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C33D8", Offset = "0x2C33D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0xD26E88", Offset = "0xD26E88", VA = "0xD26E88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C33E8", Offset = "0x2C33E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0xD24104", Offset = "0xD24104", VA = "0xD24104")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C33F8", Offset = "0x2C33F8")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0xD26E90", Offset = "0xD26E90", VA = "0xD26E90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3408", Offset = "0x2C3408")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public bool rootGrounded
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0xD26EE8", Offset = "0xD26EE8", VA = "0xD26EE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		public Vector3 up
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0xD1EAFC", Offset = "0xD1EAFC", VA = "0xD1EAFC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700001C")]
		private bool useRootRotation
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0xD28618", Offset = "0xD28618", VA = "0xD28618")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xD26F44", Offset = "0xD26F44", VA = "0xD26F44")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xD27428", Offset = "0xD27428", VA = "0xD27428")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xD1DA3C", Offset = "0xD1DA3C", VA = "0xD1DA3C")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xD1E6BC", Offset = "0xD1E6BC", VA = "0xD1E6BC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xD210EC", Offset = "0xD210EC", VA = "0xD210EC")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xD1D224", Offset = "0xD1D224", VA = "0xD1D224")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xD27760", Offset = "0xD27760", VA = "0xD27760")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xD28700", Offset = "0xD28700", VA = "0xD28700")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xD28884", Offset = "0xD28884", VA = "0xD28884")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xD289C0", Offset = "0xD289C0", VA = "0xD289C0")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xD1CBB8", Offset = "0xD1CBB8", VA = "0xD1CBB8")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B9668", Offset = "0x2B9668")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B9668", Offset = "0x2B9668")]
	public class AimIK : IK
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverAim solver;

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xD0930C", Offset = "0xD0930C", VA = "0xD0930C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3418", Offset = "0x2C3418")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xD0936C", Offset = "0xD0936C", VA = "0xD0936C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C344C", Offset = "0x2C344C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xD093CC", Offset = "0xD093CC", VA = "0xD093CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3480", Offset = "0x2C3480")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xD0942C", Offset = "0xD0942C", VA = "0xD0942C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C34B4", Offset = "0x2C34B4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xD0948C", Offset = "0xD0948C", VA = "0xD0948C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C34E8", Offset = "0x2C34E8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xD094EC", Offset = "0xD094EC", VA = "0xD094EC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xD094F4", Offset = "0xD094F4", VA = "0xD094F4")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B96E8", Offset = "0x2B96E8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B96E8", Offset = "0x2B96E8")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xD0C5F4", Offset = "0xD0C5F4", VA = "0xD0C5F4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C351C", Offset = "0x2C351C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xD0C654", Offset = "0xD0C654", VA = "0xD0C654", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3550", Offset = "0x2C3550")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xD0C6B4", Offset = "0xD0C6B4", VA = "0xD0C6B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3584", Offset = "0x2C3584")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xD0C714", Offset = "0xD0C714", VA = "0xD0C714")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C35B8", Offset = "0x2C35B8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xD0C774", Offset = "0xD0C774", VA = "0xD0C774", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xD0C77C", Offset = "0xD0C77C", VA = "0xD0C77C")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B9798", Offset = "0x2B9798")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B9798", Offset = "0x2B9798")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xD0D2EC", Offset = "0xD0D2EC", VA = "0xD0D2EC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C35EC", Offset = "0x2C35EC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xD0D34C", Offset = "0xD0D34C", VA = "0xD0D34C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3620", Offset = "0x2C3620")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xD0D3AC", Offset = "0xD0D3AC", VA = "0xD0D3AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3654", Offset = "0x2C3654")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xD0D40C", Offset = "0xD0D40C", VA = "0xD0D40C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3688", Offset = "0x2C3688")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xD0D46C", Offset = "0xD0D46C", VA = "0xD0D46C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xD0D474", Offset = "0xD0D474", VA = "0xD0D474")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B9848", Offset = "0x2B9848")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B9848", Offset = "0x2B9848")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xD0DF38", Offset = "0xD0DF38", VA = "0xD0DF38", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C36BC", Offset = "0x2C36BC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xD0DF98", Offset = "0xD0DF98", VA = "0xD0DF98", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C36F0", Offset = "0x2C36F0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xD0DFF8", Offset = "0xD0DFF8", VA = "0xD0DFF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3724", Offset = "0x2C3724")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xD0E058", Offset = "0xD0E058", VA = "0xD0E058")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3758", Offset = "0x2C3758")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xD0E0B8", Offset = "0xD0E0B8", VA = "0xD0E0B8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xD0E0C0", Offset = "0xD0E0C0", VA = "0xD0E0C0")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B98FC", Offset = "0x2B98FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B98FC", Offset = "0x2B98FC")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public BipedReferences references;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xD1AE7C", Offset = "0xD1AE7C", VA = "0xD1AE7C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C378C", Offset = "0x2C378C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xD1AEDC", Offset = "0xD1AEDC", VA = "0xD1AEDC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C37C0", Offset = "0x2C37C0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xD1AF3C", Offset = "0xD1AF3C", VA = "0xD1AF3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C37F4", Offset = "0x2C37F4")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xD1AF9C", Offset = "0xD1AF9C", VA = "0xD1AF9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3838", Offset = "0x2C3838")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xD1AFFC", Offset = "0xD1AFFC", VA = "0xD1AFFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3880", Offset = "0x2C3880")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xD1B05C", Offset = "0xD1B05C", VA = "0xD1B05C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C38B4", Offset = "0x2C38B4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xD1B0BC", Offset = "0xD1B0BC", VA = "0xD1B0BC")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xD1B0FC", Offset = "0xD1B0FC", VA = "0xD1B0FC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xD1B104", Offset = "0xD1B104", VA = "0xD1B104")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xD1B3A8", Offset = "0xD1B3A8", VA = "0xD1B3A8")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xD1B834", Offset = "0xD1B834", VA = "0xD1B834")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C38E8", Offset = "0x2C38E8")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xD1B86C", Offset = "0xD1B86C", VA = "0xD1B86C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3920", Offset = "0x2C3920")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xD1B994", Offset = "0xD1B994", VA = "0xD1B994")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000190")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1160B00", Offset = "0x1160B00", VA = "0x1160B00", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1160C28", Offset = "0x1160C28", VA = "0x1160C28", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1160E48", Offset = "0x1160E48", VA = "0x1160E48", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000194")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000195")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1160EC8", Offset = "0x1160EC8", VA = "0x1160EC8")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB8EC", Offset = "0x2BB8EC")]
		public IK[] IKComponents;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB920", Offset = "0x2BB920")]
		public Animator animator;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool fixedFrame;

		[Token(Token = "0x1700001D")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x11654C4", Offset = "0x11654C4", VA = "0x11654C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x116558C", Offset = "0x116558C", VA = "0x116558C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1165620", Offset = "0x1165620", VA = "0x1165620")]
		private void Update()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1165754", Offset = "0x1165754", VA = "0x1165754")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1165784", Offset = "0x1165784", VA = "0x1165784")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1165644", Offset = "0x1165644", VA = "0x1165644")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1165854", Offset = "0x1165854", VA = "0x1165854")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B9988", Offset = "0x2B9988")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverLeg solver;

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x132F078", Offset = "0x132F078", VA = "0x132F078", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3954", Offset = "0x2C3954")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x132F104", Offset = "0x132F104", VA = "0x132F104", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3988", Offset = "0x2C3988")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x132F190", Offset = "0x132F190", VA = "0x132F190")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C39BC", Offset = "0x2C39BC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x132F1F0", Offset = "0x132F1F0", VA = "0x132F1F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C39F0", Offset = "0x2C39F0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x132F250", Offset = "0x132F250", VA = "0x132F250", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x132F258", Offset = "0x132F258", VA = "0x132F258")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B99DC", Offset = "0x2B99DC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B99DC", Offset = "0x2B99DC")]
	public class LimbIK : IK
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverLimb solver;

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x132F2D4", Offset = "0x132F2D4", VA = "0x132F2D4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3A24", Offset = "0x2C3A24")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x132F334", Offset = "0x132F334", VA = "0x132F334", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3A58", Offset = "0x2C3A58")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x132F394", Offset = "0x132F394", VA = "0x132F394")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3A8C", Offset = "0x2C3A8C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x132F3F4", Offset = "0x132F3F4", VA = "0x132F3F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3AC0", Offset = "0x2C3AC0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x132F454", Offset = "0x132F454", VA = "0x132F454", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x132F45C", Offset = "0x132F45C", VA = "0x132F45C")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B9A8C", Offset = "0x2B9A8C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B9A8C", Offset = "0x2B9A8C")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x132F4D8", Offset = "0x132F4D8", VA = "0x132F4D8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3AF4", Offset = "0x2C3AF4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x132F538", Offset = "0x132F538", VA = "0x132F538", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3B28", Offset = "0x2C3B28")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x132F598", Offset = "0x132F598", VA = "0x132F598")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3B5C", Offset = "0x2C3B5C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x132F5F8", Offset = "0x132F5F8", VA = "0x132F5F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3B90", Offset = "0x2C3B90")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x132F658", Offset = "0x132F658", VA = "0x132F658", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x132F660", Offset = "0x132F660", VA = "0x132F660")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B9B10", Offset = "0x2B9B10")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B9B10", Offset = "0x2B9B10")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x133AA84", Offset = "0x133AA84", VA = "0x133AA84", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3BC4", Offset = "0x2C3BC4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x133AAE4", Offset = "0x133AAE4", VA = "0x133AAE4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3BF8", Offset = "0x2C3BF8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x133AB44", Offset = "0x133AB44", VA = "0x133AB44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3C2C", Offset = "0x2C3C2C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x133ABA4", Offset = "0x133ABA4", VA = "0x133ABA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3C60", Offset = "0x2C3C60")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x133AC04", Offset = "0x133AC04", VA = "0x133AC04", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x133AC0C", Offset = "0x133AC0C", VA = "0x133AC0C")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B9BC8", Offset = "0x2B9BC8")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x20000B7")]
		public class References
		{
			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform root;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Transform pelvis;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform spine;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Transform chest;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform neck;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Transform head;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform leftShoulder;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Transform leftUpperArm;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform leftForearm;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Transform leftHand;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform rightShoulder;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Transform rightUpperArm;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform rightForearm;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Transform rightHand;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform leftThigh;

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Transform leftCalf;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftFoot;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public Transform leftToes;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform rightThigh;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Transform rightCalf;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform rightFoot;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Transform rightToes;

			[Token(Token = "0x17000075")]
			public bool isFilled
			{
				[Token(Token = "0x60005A4")]
				[Address(RVA = "0x133CAE0", Offset = "0x133CAE0", VA = "0x133CAE0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000076")]
			public bool isEmpty
			{
				[Token(Token = "0x60005A5")]
				[Address(RVA = "0x133C460", Offset = "0x133C460", VA = "0x133C460")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x133D058", Offset = "0x133D058", VA = "0x133D058")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x133BD1C", Offset = "0x133BD1C", VA = "0x133BD1C")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x133D050", Offset = "0x133D050", VA = "0x133D050")]
			public References()
			{
			}
		}

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x2BB954", Offset = "0x2BB954")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB954", Offset = "0x2BB954")]
		public References references;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BB9DC", Offset = "0x2BB9DC")]
		public IKSolverVR solver;

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x133BB84", Offset = "0x133BB84", VA = "0x133BB84", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3C94", Offset = "0x2C3C94")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x133BC10", Offset = "0x133BC10", VA = "0x133BC10", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3CC8", Offset = "0x2C3CC8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x133BC9C", Offset = "0x133BC9C", VA = "0x133BC9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3CFC", Offset = "0x2C3CFC")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x133BCFC", Offset = "0x133BCFC", VA = "0x133BCFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3D48", Offset = "0x2C3D48")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x133C37C", Offset = "0x133C37C", VA = "0x133C37C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3D7C", Offset = "0x2C3D7C")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x133C3B4", Offset = "0x133C3B4", VA = "0x133C3B4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x133C3BC", Offset = "0x133C3BC", VA = "0x133C3BC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x133CFB0", Offset = "0x133CFB0", VA = "0x133CFB0")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000034")]
	public class FABRIKChain
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public FABRIK ik;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BBA1C", Offset = "0x2BBA1C")]
		public float pull;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BBA34", Offset = "0x2BBA34")]
		public float pin;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int[] children;

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xD0D4F0", Offset = "0xD0D4F0", VA = "0xD0D4F0")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xD0D5E4", Offset = "0xD0D5E4", VA = "0xD0D5E4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xD0D614", Offset = "0xD0D614", VA = "0xD0D614")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xD0DCBC", Offset = "0xD0DCBC", VA = "0xD0DCBC")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xD0D7A8", Offset = "0xD0D7A8", VA = "0xD0D7A8")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xD0DEB8", Offset = "0xD0DEB8", VA = "0xD0DEB8")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool initiated;

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xD0E13C", Offset = "0xD0E13C", VA = "0xD0E13C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xD0EA68", Offset = "0xD0EA68", VA = "0xD0EA68")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xD0EDAC", Offset = "0xD0EDAC", VA = "0xD0EDAC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xD0EF54", Offset = "0xD0EF54", VA = "0xD0EF54")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B8")]
		public class BendBone
		{
			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BF794", Offset = "0x2BF794")]
			public Transform transform;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BF7E0", Offset = "0x2BF7E0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BF7E0", Offset = "0x2BF7E0")]
			public float weight;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xD13FD8", Offset = "0xD13FD8", VA = "0xD13FD8")]
			public BendBone()
			{
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xD1408C", Offset = "0xD1408C", VA = "0xD1408C")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0xD0FE48", Offset = "0xD0FE48", VA = "0xD0FE48")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xD1058C", Offset = "0xD1058C", VA = "0xD1058C")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BBA4C", Offset = "0x2BBA4C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2BBA80", Offset = "0x2BBA80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BBA80", Offset = "0x2BBA80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BBA80", Offset = "0x2BBA80")]
		public float positionWeight;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BBB18", Offset = "0x2BBB18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BBB18", Offset = "0x2BBB18")]
		public float bodyWeight;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BBB94", Offset = "0x2BBB94")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BBB94", Offset = "0x2BBB94")]
		public float thighWeight;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BBC10", Offset = "0x2BBC10")]
		public bool handsPullBody;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2BBC44", Offset = "0x2BBC44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BBC44", Offset = "0x2BBC44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BBC44", Offset = "0x2BBC44")]
		public float rotationWeight;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BBCE8", Offset = "0x2BBCE8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BBCE8", Offset = "0x2BBCE8")]
		public float bodyClampWeight;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BBD54", Offset = "0x2BBD54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BBD54", Offset = "0x2BBD54")]
		public float headClampWeight;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BBDC0", Offset = "0x2BBDC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BBDC0", Offset = "0x2BBDC0")]
		public float bendWeight;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BBE10", Offset = "0x2BBE10")]
		public BendBone[] bendBones;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2BBE5C", Offset = "0x2BBE5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BBE5C", Offset = "0x2BBE5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BBE5C", Offset = "0x2BBE5C")]
		public float CCDWeight;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BBED0", Offset = "0x2BBED0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BBED0", Offset = "0x2BBED0")]
		public float roll;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BBF50", Offset = "0x2BBF50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BBF50", Offset = "0x2BBF50")]
		public float damper;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BBFB8", Offset = "0x2BBFB8")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2BC024", Offset = "0x2BC024")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BC024", Offset = "0x2BC024")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC024", Offset = "0x2BC024")]
		public float postStretchWeight;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BC0A0", Offset = "0x2BC0A0")]
		public float maxStretch;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BC0E8", Offset = "0x2BC0E8")]
		public float stretchDamper;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BC13C", Offset = "0x2BC13C")]
		public bool fixHead;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BC170", Offset = "0x2BC170")]
		public Transform[] stretchBones;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2BC1A4", Offset = "0x2BC1A4")]
		public Vector3 chestDirection;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC1E0", Offset = "0x2BC1E0")]
		public float chestDirectionWeight;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform[] chestBones;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 offset;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 headToBody;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float shoulderDist;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float leftShoulderDist;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float rightShoulderDist;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion chestRotation;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private int bendBonesCount;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private int ccdBonesCount;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int stretchBonesCount;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int chestBonesCount;

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xD0EF5C", Offset = "0xD0EF5C", VA = "0xD0EF5C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xD0F604", Offset = "0xD0F604", VA = "0xD0F604")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xD0FE98", Offset = "0xD0FE98", VA = "0xD0FE98")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xD105E4", Offset = "0xD105E4", VA = "0xD105E4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xD1144C", Offset = "0xD1144C", VA = "0xD1144C")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xD11968", Offset = "0xD11968", VA = "0xD11968")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xD11F40", Offset = "0xD11F40", VA = "0xD11F40")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xD12FF4", Offset = "0xD12FF4", VA = "0xD12FF4")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xD11074", Offset = "0xD11074", VA = "0xD11074")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xD13308", Offset = "0xD13308", VA = "0xD13308")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xD12E38", Offset = "0xD12E38", VA = "0xD12E38")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xD12C58", Offset = "0xD12C58", VA = "0xD12C58")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xD13860", Offset = "0xD13860", VA = "0xD13860")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xD13E18", Offset = "0xD13E18", VA = "0xD13E18")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000037")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x20000B9")]
		public class ChildConstraint
		{
			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float pushElasticity;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float pullElasticity;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF86C", Offset = "0x2BF86C")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF87C", Offset = "0x2BF87C")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float crossFade;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float inverseCrossFade;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int chain1Index;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int chain2Index;

			[Token(Token = "0x17000077")]
			public float nominalDistance
			{
				[Token(Token = "0x60005AC")]
				[Address(RVA = "0xD192BC", Offset = "0xD192BC", VA = "0xD192BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4CF8", Offset = "0x2C4CF8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005AD")]
				[Address(RVA = "0xD192C4", Offset = "0xD192C4", VA = "0xD192C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4D08", Offset = "0x2C4D08")]
				private set
				{
				}
			}

			[Token(Token = "0x17000078")]
			public bool isRigid
			{
				[Token(Token = "0x60005AE")]
				[Address(RVA = "0xD192CC", Offset = "0xD192CC", VA = "0xD192CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4D18", Offset = "0x2C4D18")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005AF")]
				[Address(RVA = "0xD192D4", Offset = "0xD192D4", VA = "0xD192D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4D28", Offset = "0x2C4D28")]
				private set
				{
				}
			}

			[Token(Token = "0x60005B0")]
			[Address(RVA = "0xD192DC", Offset = "0xD192DC", VA = "0xD192DC")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0xD154F0", Offset = "0xD154F0", VA = "0xD154F0")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0xD15F7C", Offset = "0xD15F7C", VA = "0xD15F7C")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005B3")]
			[Address(RVA = "0xD18DB0", Offset = "0xD18DB0", VA = "0xD18DB0")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BA")]
		public enum Smoothing
		{
			[Token(Token = "0x4000541")]
			None,
			[Token(Token = "0x4000542")]
			Exponential,
			[Token(Token = "0x4000543")]
			Cubic
		}

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC1F8", Offset = "0x2BC1F8")]
		public float pin;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC210", Offset = "0x2BC210")]
		public float pull;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC228", Offset = "0x2BC228")]
		public float push;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC240", Offset = "0x2BC240")]
		public float pushParent;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC25C", Offset = "0x2BC25C")]
		public float reach;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int[] children;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float rootLength;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool initiated;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float length;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float distance;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private IKSolver.Point p;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float reachForce;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float pullParentSum;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] crossFades;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float sqrMag1;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float sqrMag2;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float sqrMagDif;

		[Token(Token = "0x400016F")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xD1415C", Offset = "0xD1415C", VA = "0xD1415C")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xD1424C", Offset = "0xD1424C", VA = "0xD1424C")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xD14374", Offset = "0xD14374", VA = "0xD14374")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xD144D4", Offset = "0xD144D4", VA = "0xD144D4")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xD145E8", Offset = "0xD145E8", VA = "0xD145E8")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xD14730", Offset = "0xD14730", VA = "0xD14730")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xD15560", Offset = "0xD15560", VA = "0xD15560")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xD14A2C", Offset = "0xD14A2C", VA = "0xD14A2C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xD162B4", Offset = "0xD162B4", VA = "0xD162B4")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xD1689C", Offset = "0xD1689C", VA = "0xD1689C")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xD16F20", Offset = "0xD16F20", VA = "0xD16F20")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xD177AC", Offset = "0xD177AC", VA = "0xD177AC")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xD183E8", Offset = "0xD183E8", VA = "0xD183E8")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xD188F4", Offset = "0xD188F4", VA = "0xD188F4")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xD182A8", Offset = "0xD182A8", VA = "0xD182A8")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xD17524", Offset = "0xD17524", VA = "0xD17524")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xD18214", Offset = "0xD18214", VA = "0xD18214")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xD18B2C", Offset = "0xD18B2C", VA = "0xD18B2C")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xD17FC8", Offset = "0xD17FC8", VA = "0xD17FC8")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xD18628", Offset = "0xD18628", VA = "0xD18628")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000038")]
	public class IKConstraintBend
	{
		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform bone1;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform bone2;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone3;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform bendGoal;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 direction;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC274", Offset = "0x2BC274")]
		public float weight;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float clampF;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int chainIndex1;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int nodeIndex1;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int chainIndex2;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int nodeIndex2;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int chainIndex3;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int nodeIndex3;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BC28C", Offset = "0x2BC28C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700001E")]
		public bool initiated
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x11611A4", Offset = "0x11611A4", VA = "0x11611A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3DC0", Offset = "0x2C3DC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x11611AC", Offset = "0x11611AC", VA = "0x11611AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3DD0", Offset = "0x2C3DD0")]
			private set
			{
			}
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1160ED0", Offset = "0x1160ED0", VA = "0x1160ED0")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x11611B4", Offset = "0x11611B4", VA = "0x11611B4")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1161264", Offset = "0x1161264", VA = "0x1161264")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x116132C", Offset = "0x116132C", VA = "0x116132C")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1161338", Offset = "0x1161338", VA = "0x1161338")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1161AB0", Offset = "0x1161AB0", VA = "0x1161AB0")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1161D80", Offset = "0x1161D80", VA = "0x1161D80")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1162414", Offset = "0x1162414", VA = "0x1162414")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1161790", Offset = "0x1161790", VA = "0x1161790")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1161920", Offset = "0x1161920", VA = "0x1161920")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000039")]
	public class IKEffector
	{
		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform bone;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform target;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC29C", Offset = "0x2BC29C")]
		public float positionWeight;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC2B4", Offset = "0x2BC2B4")]
		public float rotationWeight;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 position;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Quaternion rotation;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BC2CC", Offset = "0x2BC2CC")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool effectChildNodes;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC2DC", Offset = "0x2BC2DC")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform[] childBones;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Transform planeBone1;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform planeBone2;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Transform planeBone3;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float posW;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float rotW;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool firstUpdate;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int chainIndex;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int nodeIndex;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int plane1ChainIndex;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int plane1NodeIndex;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int plane2ChainIndex;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int plane2NodeIndex;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int plane3ChainIndex;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private int plane3NodeIndex;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int[] childChainIndexes;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int[] childNodeIndexes;

		[Token(Token = "0x1700001F")]
		public bool isEndEffector
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x1162D70", Offset = "0x1162D70", VA = "0x1162D70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3DE0", Offset = "0x2C3DE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x1162D78", Offset = "0x1162D78", VA = "0x1162D78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3DF0", Offset = "0x2C3DF0")]
			private set
			{
			}
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1162CC4", Offset = "0x1162CC4", VA = "0x1162CC4")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1162D80", Offset = "0x1162D80", VA = "0x1162D80")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1162EA4", Offset = "0x1162EA4", VA = "0x1162EA4")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1163058", Offset = "0x1163058", VA = "0x1163058")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x116321C", Offset = "0x116321C", VA = "0x116321C")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x116372C", Offset = "0x116372C", VA = "0x116372C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x1163B6C", Offset = "0x1163B6C", VA = "0x1163B6C")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1163D54", Offset = "0x1163D54", VA = "0x1163D54")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1163E5C", Offset = "0x1163E5C", VA = "0x1163E5C")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1164800", Offset = "0x1164800", VA = "0x1164800")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1164898", Offset = "0x1164898", VA = "0x1164898")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x1164B68", Offset = "0x1164B68", VA = "0x1164B68")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x1165088", Offset = "0x1165088", VA = "0x1165088")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200003A")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000BB")]
		public class BoneMap
		{
			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int chainIndex;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int nodeIndex;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 planePosition;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 ikPosition;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Quaternion maintainRotation;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public float length;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			public Quaternion animatedRotation;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Transform planeBone1;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Transform planeBone2;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private Transform planeBone3;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private int plane1ChainIndex;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private int plane1NodeIndex;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private int plane2ChainIndex;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private int plane2NodeIndex;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000079")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60005B5")]
				[Address(RVA = "0x1165B54", Offset = "0x1165B54", VA = "0x1165B54")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700007A")]
			public bool isNodeBone
			{
				[Token(Token = "0x60005B8")]
				[Address(RVA = "0x1165D48", Offset = "0x1165D48", VA = "0x1165D48")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700007B")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60005CC")]
				[Address(RVA = "0x1166450", Offset = "0x1166450", VA = "0x1166450")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x1165B08", Offset = "0x1165B08", VA = "0x1165B08")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x1165C2C", Offset = "0x1165C2C", VA = "0x1165C2C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x1165CB0", Offset = "0x1165CB0", VA = "0x1165CB0")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x1165D5C", Offset = "0x1165D5C", VA = "0x1165D5C")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x1165E58", Offset = "0x1165E58", VA = "0x1165E58")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x1165E60", Offset = "0x1165E60", VA = "0x1165E60")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x1166024", Offset = "0x1166024", VA = "0x1166024")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x1166174", Offset = "0x1166174", VA = "0x1166174")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x1166248", Offset = "0x1166248", VA = "0x1166248")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x11666F0", Offset = "0x11666F0", VA = "0x11666F0")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x1166738", Offset = "0x1166738", VA = "0x1166738")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x1166788", Offset = "0x1166788", VA = "0x1166788")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x11667D4", Offset = "0x11667D4", VA = "0x11667D4")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x1166980", Offset = "0x1166980", VA = "0x1166980")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x1166D68", Offset = "0x1166D68", VA = "0x1166D68")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x1166DB4", Offset = "0x1166DB4", VA = "0x1166DB4")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x1166F78", Offset = "0x1166F78", VA = "0x1166F78")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x1166FF0", Offset = "0x1166FF0", VA = "0x1166FF0")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x11672BC", Offset = "0x11672BC", VA = "0x11672BC")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x1167580", Offset = "0x1167580", VA = "0x1167580")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x11676A8", Offset = "0x11676A8", VA = "0x11676A8")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x1166AD4", Offset = "0x1166AD4", VA = "0x1166AD4")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x11678E0", Offset = "0x11678E0", VA = "0x11678E0")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x116585C", Offset = "0x116585C", VA = "0x116585C", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1165864", Offset = "0x1165864", VA = "0x1165864", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1165868", Offset = "0x1165868", VA = "0x1165868")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x11659C0", Offset = "0x11659C0", VA = "0x11659C0")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1165B00", Offset = "0x1165B00", VA = "0x1165B00")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003B")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform bone;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC2F4", Offset = "0x2BC2F4")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private BoneMap boneMap;

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1167918", Offset = "0x1167918", VA = "0x1167918", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x11679D0", Offset = "0x11679D0", VA = "0x11679D0")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1167A74", Offset = "0x1167A74", VA = "0x1167A74")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1167B20", Offset = "0x1167B20", VA = "0x1167B20")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1167B48", Offset = "0x1167B48", VA = "0x1167B48")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1167B74", Offset = "0x1167B74", VA = "0x1167B74", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1167C4C", Offset = "0x1167C4C", VA = "0x1167C4C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1167C74", Offset = "0x1167C74", VA = "0x1167C74")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003C")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000BC")]
		public enum BoneMapType
		{
			[Token(Token = "0x400055B")]
			Parent,
			[Token(Token = "0x400055C")]
			Bone1,
			[Token(Token = "0x400055D")]
			Bone2,
			[Token(Token = "0x400055E")]
			Bone3
		}

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform parentBone;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform bone1;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone2;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform bone3;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC30C", Offset = "0x2BC30C")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC324", Offset = "0x2BC324")]
		public float weight;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMapParent;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private BoneMap boneMap1;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private BoneMap boneMap2;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1167CB4", Offset = "0x1167CB4", VA = "0x1167CB4", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1167D34", Offset = "0x1167D34", VA = "0x1167D34")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1167E24", Offset = "0x1167E24", VA = "0x1167E24")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1168254", Offset = "0x1168254", VA = "0x1168254")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1168394", Offset = "0x1168394", VA = "0x1168394")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x11684F8", Offset = "0x11684F8", VA = "0x11684F8")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x116850C", Offset = "0x116850C", VA = "0x116850C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1168610", Offset = "0x1168610", VA = "0x1168610")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1168724", Offset = "0x1168724", VA = "0x1168724", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1168ADC", Offset = "0x1168ADC", VA = "0x1168ADC")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1168BDC", Offset = "0x1168BDC", VA = "0x1168BDC")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003D")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform[] spineBones;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform leftThighBone;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform rightThighBone;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC33C", Offset = "0x2BC33C")]
		public int iterations;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC358", Offset = "0x2BC358")]
		public float twistWeight;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int rootNodeIndex;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private BoneMap[] spine;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private BoneMap leftThigh;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap rightThigh;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool useFABRIK;

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1168E64", Offset = "0x1168E64", VA = "0x1168E64", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x116925C", Offset = "0x116925C", VA = "0x116925C")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x11693C0", Offset = "0x11693C0", VA = "0x11693C0")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1169554", Offset = "0x1169554", VA = "0x1169554")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x116957C", Offset = "0x116957C", VA = "0x116957C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1169608", Offset = "0x1169608", VA = "0x1169608")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x11696D0", Offset = "0x11696D0", VA = "0x11696D0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x116A1FC", Offset = "0x116A1FC", VA = "0x116A1FC")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x116A240", Offset = "0x116A240", VA = "0x116A240")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x116A754", Offset = "0x116A754", VA = "0x116A754")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x116AE84", Offset = "0x116AE84", VA = "0x116AE84")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x116B0E0", Offset = "0x116B0E0", VA = "0x116B0E0")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x116B314", Offset = "0x116B314", VA = "0x116B314")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003E")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000BD")]
		public class Point
		{
			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BF88C", Offset = "0x2BF88C")]
			public float weight;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x116DDD0", Offset = "0x116DDD0", VA = "0x116DDD0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x116DE54", Offset = "0x116DE54", VA = "0x116DE54")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x116E028", Offset = "0x116E028", VA = "0x116E028")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x116E070", Offset = "0x116E070", VA = "0x116E070")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x116E0B8", Offset = "0x116E0B8", VA = "0x116E0B8")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x116E13C", Offset = "0x116E13C", VA = "0x116E13C")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x116D60C", Offset = "0x116D60C", VA = "0x116D60C")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BE")]
		public class Bone : Point
		{
			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool isLimited;

			[Token(Token = "0x1700007C")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x60005D5")]
				[Address(RVA = "0x116C894", Offset = "0x116C894", VA = "0x116C894")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005D6")]
				[Address(RVA = "0x116C9C0", Offset = "0x116C9C0", VA = "0x116C9C0")]
				set
				{
				}
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x116CA54", Offset = "0x116CA54", VA = "0x116CA54")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x116CD90", Offset = "0x116CD90", VA = "0x116CD90")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x116D24C", Offset = "0x116D24C", VA = "0x116D24C")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x116D4FC", Offset = "0x116D4FC", VA = "0x116D4FC")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x116D548", Offset = "0x116D548", VA = "0x116D548")]
			public Bone()
			{
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x116D6C0", Offset = "0x116D6C0", VA = "0x116D6C0")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x116D78C", Offset = "0x116D78C", VA = "0x116D78C")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BF")]
		public class Node : Point
		{
			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float effectorPositionWeight;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public float effectorRotationWeight;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 offset;

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x116DD8C", Offset = "0x116DD8C", VA = "0x116DD8C")]
			public Node()
			{
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x116DD90", Offset = "0x116DD90", VA = "0x116DD90")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x116DDAC", Offset = "0x116DDAC", VA = "0x116DDAC")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000C0")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000C1")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BC380", Offset = "0x2BC380")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC380", Offset = "0x2BC380")]
		public float IKPositionWeight;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BC3FC", Offset = "0x2BC3FC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		protected bool firstInitiation;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000020")]
		public bool initiated
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x1160BBC", Offset = "0x1160BBC", VA = "0x1160BBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3E00", Offset = "0x2C3E00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x116BD98", Offset = "0x116BD98", VA = "0x116BD98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3E10", Offset = "0x2C3E10")]
			private set
			{
			}
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x116B8CC", Offset = "0x116B8CC", VA = "0x116B8CC")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600022B")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1160CB0", Offset = "0x1160CB0", VA = "0x1160CB0")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1160BC4", Offset = "0x1160BC4", VA = "0x1160BC4")]
		public void Update()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x116BDA0", Offset = "0x116BDA0", VA = "0x116BDA0", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x116BDB4", Offset = "0x116BDB4", VA = "0x116BDB4")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x116BDC0", Offset = "0x116BDC0", VA = "0x116BDC0")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x116BDC8", Offset = "0x116BDC8", VA = "0x116BDC8")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x115EF08", Offset = "0x115EF08", VA = "0x115EF08")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000235")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000236")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000237")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000238")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x6000239")]
		protected abstract void OnInitiate();

		[Token(Token = "0x600023A")]
		protected abstract void OnUpdate();

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x116BE5C", Offset = "0x116BE5C", VA = "0x116BE5C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x116BE74", Offset = "0x116BE74", VA = "0x116BE74")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x116C010", Offset = "0x116C010", VA = "0x116C010")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x116C0D8", Offset = "0x116C0D8", VA = "0x116C0D8")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x116C87C", Offset = "0x116C87C", VA = "0x116C87C")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003F")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform transform;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 axis;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Vector3 poleAxis;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 polePosition;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC43C", Offset = "0x2BC43C")]
		public float poleWeight;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Transform poleTarget;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC454", Offset = "0x2BC454")]
		public float clampWeight;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC46C", Offset = "0x2BC46C")]
		public int clampSmoothing;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float step;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform lastTransform;

		[Token(Token = "0x17000021")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x116E308", Offset = "0x116E308", VA = "0x116E308")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000022")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x116E3E0", Offset = "0x116E3E0", VA = "0x116E3E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000023")]
		protected override int minBones
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x116F6C4", Offset = "0x116F6C4", VA = "0x116F6C4", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000024")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x116FEDC", Offset = "0x116FEDC", VA = "0x116FEDC", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x116E20C", Offset = "0x116E20C", VA = "0x116E20C")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x116E4B8", Offset = "0x116E4B8", VA = "0x116E4B8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x116E83C", Offset = "0x116E83C", VA = "0x116E83C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x116F4DC", Offset = "0x116F4DC", VA = "0x116F4DC")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x116F020", Offset = "0x116F020", VA = "0x116F020")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x116F6CC", Offset = "0x116F6CC", VA = "0x116F6CC")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x116FFE8", Offset = "0x116FFE8", VA = "0x116FFE8")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1170148", Offset = "0x1170148", VA = "0x1170148")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x11702A0", Offset = "0x11702A0", VA = "0x11702A0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1170CB0", Offset = "0x1170CB0", VA = "0x1170CB0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1171710", Offset = "0x1171710", VA = "0x1171710")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1172340", Offset = "0x1172340", VA = "0x1172340")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000041")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool[] limitedBones;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000025")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x1174094", Offset = "0x1174094", VA = "0x1174094", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1172344", Offset = "0x1172344", VA = "0x1172344")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x117305C", Offset = "0x117305C", VA = "0x117305C")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x11731BC", Offset = "0x11731BC", VA = "0x11731BC", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x117328C", Offset = "0x117328C", VA = "0x117328C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1173BDC", Offset = "0x1173BDC", VA = "0x1173BDC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x117409C", Offset = "0x117409C", VA = "0x117409C")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1172418", Offset = "0x1172418", VA = "0x1172418")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1173160", Offset = "0x1173160", VA = "0x1173160")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1174004", Offset = "0x1174004", VA = "0x1174004")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1172C78", Offset = "0x1172C78", VA = "0x1172C78")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1174F74", Offset = "0x1174F74", VA = "0x1174F74")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x11750B8", Offset = "0x11750B8", VA = "0x11750B8")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x117525C", Offset = "0x117525C", VA = "0x117525C")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1175400", Offset = "0x1175400", VA = "0x1175400")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x11737B0", Offset = "0x11737B0", VA = "0x11737B0")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x11739C4", Offset = "0x11739C4", VA = "0x11739C4")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x11756E8", Offset = "0x11756E8", VA = "0x11756E8")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x11745E4", Offset = "0x11745E4", VA = "0x11745E4")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1173130", Offset = "0x1173130", VA = "0x1173130")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x11764AC", Offset = "0x11764AC", VA = "0x11764AC")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1175938", Offset = "0x1175938", VA = "0x1175938")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x11741E8", Offset = "0x11741E8", VA = "0x11741E8")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x11743E4", Offset = "0x11743E4", VA = "0x11743E4")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x11766E4", Offset = "0x11766E4", VA = "0x11766E4")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000042")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int iterations;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC484", Offset = "0x2BC484")]
		public float rootPin;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool[] isRoot;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1176770", Offset = "0x1176770", VA = "0x1176770", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x117796C", Offset = "0x117796C", VA = "0x117796C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1177A64", Offset = "0x1177A64", VA = "0x1177A64", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1177B70", Offset = "0x1177B70", VA = "0x1177B70", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1177CE4", Offset = "0x1177CE4", VA = "0x1177CE4")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1177E2C", Offset = "0x1177E2C", VA = "0x1177E2C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1178678", Offset = "0x1178678", VA = "0x1178678", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1178928", Offset = "0x1178928", VA = "0x1178928", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x117875C", Offset = "0x117875C", VA = "0x117875C")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x11781C4", Offset = "0x11781C4", VA = "0x11781C4")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x11789FC", Offset = "0x11789FC", VA = "0x11789FC")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC49C", Offset = "0x2BC49C")]
		public int iterations;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public FBIKChain[] chain;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public IKEffector[] effectors;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool FABRIKPass;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1178A88", Offset = "0x1178A88", VA = "0x1178A88")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1178BD0", Offset = "0x1178BD0", VA = "0x1178BD0")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1178C30", Offset = "0x1178C30", VA = "0x1178C30")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1162C30", Offset = "0x1162C30", VA = "0x1162C30")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x11616FC", Offset = "0x11616FC", VA = "0x11616FC")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1178E00", Offset = "0x1178E00", VA = "0x1178E00", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1179080", Offset = "0x1179080", VA = "0x1179080", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x11792D4", Offset = "0x11792D4", VA = "0x11792D4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x11795C0", Offset = "0x11795C0", VA = "0x11795C0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x11796F4", Offset = "0x11796F4", VA = "0x11796F4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1179844", Offset = "0x1179844", VA = "0x1179844", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1179A54", Offset = "0x1179A54", VA = "0x1179A54", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1179CC8", Offset = "0x1179CC8", VA = "0x1179CC8", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x117A140", Offset = "0x117A140", VA = "0x117A140", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x117A778", Offset = "0x117A778", VA = "0x117A778", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x117A7E0", Offset = "0x117A7E0", VA = "0x117A7E0", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x117A948", Offset = "0x117A948", VA = "0x117A948")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40001EC")]
		Body,
		[Token(Token = "0x40001ED")]
		LeftShoulder,
		[Token(Token = "0x40001EE")]
		RightShoulder,
		[Token(Token = "0x40001EF")]
		LeftThigh,
		[Token(Token = "0x40001F0")]
		RightThigh,
		[Token(Token = "0x40001F1")]
		LeftHand,
		[Token(Token = "0x40001F2")]
		RightHand,
		[Token(Token = "0x40001F3")]
		LeftFoot,
		[Token(Token = "0x40001F4")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40001F6")]
		LeftArm,
		[Token(Token = "0x40001F7")]
		RightArm,
		[Token(Token = "0x40001F8")]
		LeftLeg,
		[Token(Token = "0x40001F9")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rootNode;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC4B8", Offset = "0x2BC4B8")]
		public float spineStiffness;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC4D0", Offset = "0x2BC4D0")]
		public float pullBodyVertical;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC4EC", Offset = "0x2BC4EC")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BC508", Offset = "0x2BC508")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 offset;

		[Token(Token = "0x17000026")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x117AA4C", Offset = "0x117AA4C", VA = "0x117AA4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x117AA54", Offset = "0x117AA54", VA = "0x117AA54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x117AA5C", Offset = "0x117AA5C", VA = "0x117AA5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x117AA64", Offset = "0x117AA64", VA = "0x117AA64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x117AA6C", Offset = "0x117AA6C", VA = "0x117AA6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x117AA74", Offset = "0x117AA74", VA = "0x117AA74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x117AA7C", Offset = "0x117AA7C", VA = "0x117AA7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x117AA84", Offset = "0x117AA84", VA = "0x117AA84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x117AA8C", Offset = "0x117AA8C", VA = "0x117AA8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x117AA94", Offset = "0x117AA94", VA = "0x117AA94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x117AAD4", Offset = "0x117AAD4", VA = "0x117AAD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x117AB14", Offset = "0x117AB14", VA = "0x117AB14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x117AB54", Offset = "0x117AB54", VA = "0x117AB54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x117AB94", Offset = "0x117AB94", VA = "0x117AB94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x117ABD4", Offset = "0x117ABD4", VA = "0x117ABD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x117AC14", Offset = "0x117AC14", VA = "0x117AC14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x117AC54", Offset = "0x117AC54", VA = "0x117AC54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x117AC94", Offset = "0x117AC94", VA = "0x117AC94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x117E270", Offset = "0x117E270", VA = "0x117E270")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3E20", Offset = "0x2C3E20")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x117E284", Offset = "0x117E284", VA = "0x117E284")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3E30", Offset = "0x2C3E30")]
			private set
			{
			}
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x117ACD4", Offset = "0x117ACD4", VA = "0x117ACD4")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x117AE58", Offset = "0x117AE58", VA = "0x117AE58")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x117AD40", Offset = "0x117AD40", VA = "0x117AD40")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x117AF5C", Offset = "0x117AF5C", VA = "0x117AF5C")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x115F0C8", Offset = "0x115F0C8", VA = "0x115F0C8")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x117B0C0", Offset = "0x117B0C0", VA = "0x117B0C0")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x117B1D8", Offset = "0x117B1D8", VA = "0x117B1D8")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x117B2F0", Offset = "0x117B2F0", VA = "0x117B2F0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x117B41C", Offset = "0x117B41C", VA = "0x117B41C")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x117B424", Offset = "0x117B424", VA = "0x117B424")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x117B464", Offset = "0x117B464", VA = "0x117B464")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x117B590", Offset = "0x117B590", VA = "0x117B590", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x117B8C8", Offset = "0x117B8C8", VA = "0x117B8C8")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x117D890", Offset = "0x117D890", VA = "0x117D890")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x117DF34", Offset = "0x117DF34", VA = "0x117DF34")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x117DFF0", Offset = "0x117DFF0", VA = "0x117DFF0")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x117DD2C", Offset = "0x117DD2C", VA = "0x117DD2C")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x117DE30", Offset = "0x117DE30", VA = "0x117DE30")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x117E290", Offset = "0x117E290", VA = "0x117E290")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x117E374", Offset = "0x117E374", VA = "0x117E374", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x117E5C0", Offset = "0x117E5C0", VA = "0x117E5C0")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x117E7C8", Offset = "0x117E7C8", VA = "0x117E7C8")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x117E9F0", Offset = "0x117E9F0", VA = "0x117E9F0")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x117ECEC", Offset = "0x117ECEC", VA = "0x117ECEC", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x117F2E8", Offset = "0x117F2E8", VA = "0x117F2E8", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x117F438", Offset = "0x117F438", VA = "0x117F438")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform target;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float tolerance;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int maxIterations;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useRotationLimits;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool XY;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Bone[] bones;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected float chainLength;

		[Token(Token = "0x17000039")]
		protected virtual int minBones
		{
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x117FF80", Offset = "0x117FF80", VA = "0x117FF80", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003A")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x117FF88", Offset = "0x117FF88", VA = "0x117FF88", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003B")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x117FF90", Offset = "0x117FF90", VA = "0x117FF90", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x117FFA0", Offset = "0x117FFA0", VA = "0x117FFA0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003D")]
		protected float positionOffset
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x117163C", Offset = "0x117163C", VA = "0x117163C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x117F448", Offset = "0x117F448", VA = "0x117F448")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x117F678", Offset = "0x117F678", VA = "0x117F678")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x117F854", Offset = "0x117F854", VA = "0x117F854", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x117F8E0", Offset = "0x117F8E0", VA = "0x117F8E0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x117F984", Offset = "0x117F984", VA = "0x117F984", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x117FE30", Offset = "0x117FE30", VA = "0x117FE30", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x117FE38", Offset = "0x117FE38", VA = "0x117FE38", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x117FF98", Offset = "0x117FF98", VA = "0x117FF98", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x117FF9C", Offset = "0x117FF9C", VA = "0x117FF9C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1170360", Offset = "0x1170360", VA = "0x1170360")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x11710F0", Offset = "0x11710F0", VA = "0x11710F0")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x11801A8", Offset = "0x11801A8", VA = "0x11801A8")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x11700B8", Offset = "0x11700B8", VA = "0x11700B8")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC518", Offset = "0x2BC518")]
		public float IKRotationWeight;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Quaternion IKRotation;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Point pelvis;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Point thigh;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Point calf;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Point foot;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Point toe;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3[] positions;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] rotations;

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1180584", Offset = "0x1180584", VA = "0x1180584", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1180B24", Offset = "0x1180B24", VA = "0x1180B24")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1180BD4", Offset = "0x1180BD4", VA = "0x1180BD4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1180DF4", Offset = "0x1180DF4", VA = "0x1180DF4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1181034", Offset = "0x1181034", VA = "0x1181034", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x11810B4", Offset = "0x11810B4", VA = "0x11810B4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1181140", Offset = "0x1181140", VA = "0x1181140", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1181860", Offset = "0x1181860", VA = "0x1181860", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1181884", Offset = "0x1181884", VA = "0x1181884")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x11811F4", Offset = "0x11811F4", VA = "0x11811F4")]
		private void Read()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x11819F4", Offset = "0x11819F4", VA = "0x11819F4")]
		private void Write()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1181C54", Offset = "0x1181C54", VA = "0x1181C54")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000049")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20000C2")]
		public enum BendModifier
		{
			[Token(Token = "0x400056F")]
			Animation,
			[Token(Token = "0x4000570")]
			Target,
			[Token(Token = "0x4000571")]
			Parent,
			[Token(Token = "0x4000572")]
			Arm,
			[Token(Token = "0x4000573")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20000C3")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x3E2804", Offset = "0x3E2804", VA = "0x3E2804")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC530", Offset = "0x2BC530")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC548", Offset = "0x2BC548")]
		public float bendModifierWeight;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Transform bendGoal;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion maintainRotation;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x1700003E")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x1183B74", Offset = "0x1183B74", VA = "0x1183B74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1181DE0", Offset = "0x1181DE0", VA = "0x1181DE0")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1181E58", Offset = "0x1181E58", VA = "0x1181E58")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1181EB4", Offset = "0x1181EB4", VA = "0x1181EB4", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1182778", Offset = "0x1182778", VA = "0x1182778", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x11838CC", Offset = "0x11838CC", VA = "0x11838CC", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1183A54", Offset = "0x1183A54", VA = "0x1183A54")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1183AE0", Offset = "0x1183AE0", VA = "0x1183AE0")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1182388", Offset = "0x1182388", VA = "0x1182388")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1182900", Offset = "0x1182900", VA = "0x1182900")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200004A")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000C4")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x1700007D")]
			public Vector3 forward
			{
				[Token(Token = "0x60005EE")]
				[Address(RVA = "0xF4CF08", Offset = "0xF4CF08", VA = "0xF4CF08")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60005EA")]
			[Address(RVA = "0xF4D8B0", Offset = "0xF4D8B0", VA = "0xF4D8B0")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xF4BC70", Offset = "0xF4BC70", VA = "0xF4BC70")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xF4C20C", Offset = "0xF4C20C", VA = "0xF4C20C")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0xF4D4D0", Offset = "0xF4D4D0", VA = "0xF4D4D0")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform target;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public LookAtBone[] spine;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public LookAtBone head;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC560", Offset = "0x2BC560")]
		public float bodyWeight;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC578", Offset = "0x2BC578")]
		public float headWeight;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC590", Offset = "0x2BC590")]
		public float eyesWeight;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC5A8", Offset = "0x2BC5A8")]
		public float clampWeight;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC5C0", Offset = "0x2BC5C0")]
		public float clampWeightHead;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC5D8", Offset = "0x2BC5D8")]
		public float clampWeightEyes;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC5F0", Offset = "0x2BC5F0")]
		public int clampSmoothing;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3[] spineForwards;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3[] headForwards;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] eyeForward;

		[Token(Token = "0x1700003F")]
		private bool spineIsValid
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0xF4B01C", Offset = "0xF4B01C", VA = "0xF4B01C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0xF4B30C", Offset = "0xF4B30C", VA = "0xF4B30C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000041")]
		private bool headIsValid
		{
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0xF4B18C", Offset = "0xF4B18C", VA = "0xF4B18C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		private bool headIsEmpty
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xF4B33C", Offset = "0xF4B33C", VA = "0xF4B33C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		private bool eyesIsValid
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xF4B19C", Offset = "0xF4B19C", VA = "0xF4B19C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0xF4B3DC", Offset = "0xF4B3DC", VA = "0xF4B3DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xF4A4CC", Offset = "0xF4A4CC", VA = "0xF4A4CC")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xF4A560", Offset = "0xF4A560", VA = "0xF4A560")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xF4A610", Offset = "0xF4A610", VA = "0xF4A610")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xF4A6DC", Offset = "0xF4A6DC", VA = "0xF4A6DC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xF4A7D0", Offset = "0xF4A7D0", VA = "0xF4A7D0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xF4A8EC", Offset = "0xF4A8EC", VA = "0xF4A8EC")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xF4AA40", Offset = "0xF4AA40", VA = "0xF4AA40", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xF4AC04", Offset = "0xF4AC04", VA = "0xF4AC04", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xF4ADEC", Offset = "0xF4ADEC", VA = "0xF4ADEC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xF4B40C", Offset = "0xF4B40C", VA = "0xF4B40C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xF4B76C", Offset = "0xF4B76C", VA = "0xF4B76C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xF4B97C", Offset = "0xF4B97C", VA = "0xF4B97C")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xF4BC90", Offset = "0xF4BC90", VA = "0xF4BC90", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xF4C378", Offset = "0xF4C378", VA = "0xF4C378", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xF4C4B8", Offset = "0xF4C4B8", VA = "0xF4C4B8")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xF4C808", Offset = "0xF4C808", VA = "0xF4C808")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xF4CB8C", Offset = "0xF4CB8C", VA = "0xF4CB8C")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xF4CFE0", Offset = "0xF4CFE0", VA = "0xF4CFE0")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xF4BA34", Offset = "0xF4BA34", VA = "0xF4BA34")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xF4D668", Offset = "0xF4D668", VA = "0xF4D668")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000C5")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0xF4F6A8", Offset = "0xF4F6A8", VA = "0xF4F6A8")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0xF5086C", Offset = "0xF5086C", VA = "0xF5086C")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0xF503D0", Offset = "0xF503D0", VA = "0xF503D0")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0xF50ACC", Offset = "0xF50ACC", VA = "0xF50ACC")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform target;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC608", Offset = "0x2BC608")]
		public float IKRotationWeight;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TrigonometricBone bone3;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected bool directHierarchy;

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xF4D8B8", Offset = "0xF4D8B8", VA = "0xF4D8B8")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xF4DB34", Offset = "0xF4DB34", VA = "0xF4DB34")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xF4DD68", Offset = "0xF4DD68", VA = "0xF4DD68")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xF4DD78", Offset = "0xF4DD78", VA = "0xF4DD78")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xF4DE0C", Offset = "0xF4DE0C", VA = "0xF4DE0C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xF4DE1C", Offset = "0xF4DE1C", VA = "0xF4DE1C")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xF4DE24", Offset = "0xF4DE24", VA = "0xF4DE24", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xF4DF9C", Offset = "0xF4DF9C", VA = "0xF4DF9C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xF4E11C", Offset = "0xF4E11C", VA = "0xF4E11C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xF4E18C", Offset = "0xF4E18C", VA = "0xF4E18C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xF4E20C", Offset = "0xF4E20C", VA = "0xF4E20C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xF4E7D4", Offset = "0xF4E7D4", VA = "0xF4E7D4")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xF4E858", Offset = "0xF4E858", VA = "0xF4E858")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xF4EFE0", Offset = "0xF4EFE0", VA = "0xF4EFE0")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xF4F268", Offset = "0xF4F268", VA = "0xF4F268", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xF4F530", Offset = "0xF4F530", VA = "0xF4F530")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xF4F430", Offset = "0xF4F430", VA = "0xF4F430")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xF4F8C8", Offset = "0xF4F8C8", VA = "0xF4F8C8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xF5096C", Offset = "0xF5096C", VA = "0xF5096C", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xF50970", Offset = "0xF50970", VA = "0xF50970", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xF50974", Offset = "0xF50974", VA = "0xF50974", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xF504A8", Offset = "0xF504A8", VA = "0xF504A8")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xF50978", Offset = "0xF50978", VA = "0xF50978")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000C6")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000102")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000722")]
				YawPitch,
				[Token(Token = "0x4000723")]
				FromTo
			}

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BF8A4", Offset = "0x2BF8A4")]
			public Transform target;

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BF8E0", Offset = "0x2BF8E0")]
			public Transform bendGoal;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BF914", Offset = "0x2BF914")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BF914", Offset = "0x2BF914")]
			public float positionWeight;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BF984", Offset = "0x2BF984")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BF984", Offset = "0x2BF984")]
			public float rotationWeight;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BF9F4", Offset = "0x2BF9F4")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BFA54", Offset = "0x2BFA54")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BFA54", Offset = "0x2BFA54")]
			public float shoulderRotationWeight;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BFABC", Offset = "0x2BFABC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BFABC", Offset = "0x2BFABC")]
			public float bendGoalWeight;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BFB0C", Offset = "0x2BFB0C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BFB0C", Offset = "0x2BFB0C")]
			public float swivelOffset;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BFB8C", Offset = "0x2BFB8C")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BFBC0", Offset = "0x2BFBC0")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BFBF4", Offset = "0x2BFBF4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BFBF4", Offset = "0x2BFBF4")]
			public float armLengthMlp;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BFC6C", Offset = "0x2BFC6C")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BFCE0", Offset = "0x2BFCE0")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BFCF0", Offset = "0x2BFCF0")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private bool hasShoulder;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			private Quaternion chestRotation;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
			private Vector3 chestForward;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private Vector3 chestUp;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000592")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x4000593")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x1700007E")]
			public Vector3 position
			{
				[Token(Token = "0x60005F3")]
				[Address(RVA = "0xF5D6F4", Offset = "0xF5D6F4", VA = "0xF5D6F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4D38", Offset = "0x2C4D38")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005F4")]
				[Address(RVA = "0xF5D708", Offset = "0xF5D708", VA = "0xF5D708")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4D48", Offset = "0x2C4D48")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007F")]
			public Quaternion rotation
			{
				[Token(Token = "0x60005F5")]
				[Address(RVA = "0xF5D714", Offset = "0xF5D714", VA = "0xF5D714")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4D58", Offset = "0x2C4D58")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60005F6")]
				[Address(RVA = "0xF5D724", Offset = "0xF5D724", VA = "0xF5D724")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4D68", Offset = "0x2C4D68")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x60005F7")]
				[Address(RVA = "0xF5D734", Offset = "0xF5D734", VA = "0xF5D734")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000081")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0xF5D774", Offset = "0xF5D774", VA = "0xF5D774")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000082")]
			private VirtualBone forearm
			{
				[Token(Token = "0x60005F9")]
				[Address(RVA = "0xF5D7B4", Offset = "0xF5D7B4", VA = "0xF5D7B4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000083")]
			private VirtualBone hand
			{
				[Token(Token = "0x60005FA")]
				[Address(RVA = "0xF5D7F4", Offset = "0xF5D7F4", VA = "0xF5D7F4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0xF5D834", Offset = "0xF5D834", VA = "0xF5D834", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0xF5E554", Offset = "0xF5E554", VA = "0xF5E554", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0xF5E850", Offset = "0xF5E850", VA = "0xF5E850", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xF5E908", Offset = "0xF5E908", VA = "0xF5E908")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0xF5A81C", Offset = "0xF5A81C", VA = "0xF5A81C")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0xF60694", Offset = "0xF60694", VA = "0xF60694", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0xF6072C", Offset = "0xF6072C", VA = "0xF6072C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0xF5EF48", Offset = "0xF5EF48", VA = "0xF5EF48")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0xF5F400", Offset = "0xF5F400", VA = "0xF5F400")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0xF60AD8", Offset = "0xF60AD8", VA = "0xF60AD8")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0xF5D358", Offset = "0xF5D358", VA = "0xF5D358")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C7")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BFD00", Offset = "0x2BFD00")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BFD10", Offset = "0x2BFD10")]
			private float <mag>k__BackingField;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			protected bool initiated;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Quaternion rootRotation;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			protected int index;

			[Token(Token = "0x17000084")]
			public float sqrMag
			{
				[Token(Token = "0x600060B")]
				[Address(RVA = "0xF60D30", Offset = "0xF60D30", VA = "0xF60D30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4D78", Offset = "0x2C4D78")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600060C")]
				[Address(RVA = "0xF60D38", Offset = "0xF60D38", VA = "0xF60D38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4D88", Offset = "0x2C4D88")]
				private set
				{
				}
			}

			[Token(Token = "0x17000085")]
			public float mag
			{
				[Token(Token = "0x600060D")]
				[Address(RVA = "0xF5F048", Offset = "0xF5F048", VA = "0xF5F048")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4D98", Offset = "0x2C4D98")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600060E")]
				[Address(RVA = "0xF60D40", Offset = "0xF60D40", VA = "0xF60D40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4DA8", Offset = "0x2C4DA8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000606")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index);

			[Token(Token = "0x6000607")]
			public abstract void PreSolve();

			[Token(Token = "0x6000608")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000609")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x600060A")]
			public abstract void ResetOffsets();

			[Token(Token = "0x600060F")]
			[Address(RVA = "0xF56E88", Offset = "0xF56E88", VA = "0xF56E88")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000610")]
			[Address(RVA = "0xF61330", Offset = "0xF61330", VA = "0xF61330")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0xF61524", Offset = "0xF61524", VA = "0xF61524")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0xF618FC", Offset = "0xF618FC", VA = "0xF618FC")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0xF5A110", Offset = "0xF5A110", VA = "0xF5A110")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0xF6043C", Offset = "0xF6043C", VA = "0xF6043C")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0xF61930", Offset = "0xF61930", VA = "0xF61930")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0xF61AE4", Offset = "0xF61AE4", VA = "0xF61AE4")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0xF60C60", Offset = "0xF60C60", VA = "0xF60C60")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C8")]
		public class Footstep
		{
			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float stepSpeed;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 position;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion rotation;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool isSupportLeg;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BFD30", Offset = "0x2BFD30")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public Vector3 stepFrom;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 stepTo;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public Quaternion stepFromRot;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Quaternion stepToRot;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private float supportLegW;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private float supportLegWV;

			[Token(Token = "0x17000086")]
			public bool isStepping
			{
				[Token(Token = "0x6000618")]
				[Address(RVA = "0xF61B20", Offset = "0xF61B20", VA = "0xF61B20")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000087")]
			public float stepProgress
			{
				[Token(Token = "0x6000619")]
				[Address(RVA = "0xF61B3C", Offset = "0xF61B3C", VA = "0xF61B3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4DB8", Offset = "0x2C4DB8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600061A")]
				[Address(RVA = "0xF61B44", Offset = "0xF61B44", VA = "0xF61B44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4DC8", Offset = "0x2C4DC8")]
				private set
				{
				}
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0xF61B4C", Offset = "0xF61B4C", VA = "0xF61B4C")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x600061C")]
			[Address(RVA = "0xF61CE8", Offset = "0xF61CE8", VA = "0xF61CE8")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0xF61E84", Offset = "0xF61E84", VA = "0xF61E84")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600061E")]
			[Address(RVA = "0xF61FD4", Offset = "0xF61FD4", VA = "0xF61FD4")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x600061F")]
			[Address(RVA = "0xF621E4", Offset = "0xF621E4", VA = "0xF621E4")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0xF62408", Offset = "0xF62408", VA = "0xF62408")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C9")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BFD40", Offset = "0x2BFD40")]
			public Transform target;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BFD84", Offset = "0x2BFD84")]
			public Transform bendGoal;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BFDB8", Offset = "0x2BFDB8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BFDB8", Offset = "0x2BFDB8")]
			public float positionWeight;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BFE2C", Offset = "0x2BFE2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BFE2C", Offset = "0x2BFE2C")]
			public float rotationWeight;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BFEA0", Offset = "0x2BFEA0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BFEA0", Offset = "0x2BFEA0")]
			public float bendGoalWeight;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BFEF0", Offset = "0x2BFEF0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BFEF0", Offset = "0x2BFEF0")]
			public float swivelOffset;

			[NonSerialized]
			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BFFD0", Offset = "0x2BFFD0")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BFFE0", Offset = "0x2BFFE0")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BFFF0", Offset = "0x2BFFF0")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C0000", Offset = "0x2C0000")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private Vector3 footPosition;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private Quaternion footRotation;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private Vector3 bendNormal;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x17000088")]
			public Vector3 position
			{
				[Token(Token = "0x6000621")]
				[Address(RVA = "0xF59EF8", Offset = "0xF59EF8", VA = "0xF59EF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4DD8", Offset = "0x2C4DD8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000622")]
				[Address(RVA = "0xF626B0", Offset = "0xF626B0", VA = "0xF626B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4DE8", Offset = "0x2C4DE8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000089")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000623")]
				[Address(RVA = "0xF626BC", Offset = "0xF626BC", VA = "0xF626BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4DF8", Offset = "0x2C4DF8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000624")]
				[Address(RVA = "0xF626CC", Offset = "0xF626CC", VA = "0xF626CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4E08", Offset = "0x2C4E08")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008A")]
			public bool hasToes
			{
				[Token(Token = "0x6000625")]
				[Address(RVA = "0xF626DC", Offset = "0xF626DC", VA = "0xF626DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4E18", Offset = "0x2C4E18")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000626")]
				[Address(RVA = "0xF626E4", Offset = "0xF626E4", VA = "0xF626E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4E28", Offset = "0x2C4E28")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008B")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000627")]
				[Address(RVA = "0xF626EC", Offset = "0xF626EC", VA = "0xF626EC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008C")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000628")]
				[Address(RVA = "0xF6272C", Offset = "0xF6272C", VA = "0xF6272C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008D")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000629")]
				[Address(RVA = "0xF6276C", Offset = "0xF6276C", VA = "0xF6276C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			private VirtualBone toes
			{
				[Token(Token = "0x600062A")]
				[Address(RVA = "0xF627AC", Offset = "0xF627AC", VA = "0xF627AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008F")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x600062B")]
				[Address(RVA = "0xF59EA8", Offset = "0xF59EA8", VA = "0xF59EA8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000090")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x600062C")]
				[Address(RVA = "0xF627EC", Offset = "0xF627EC", VA = "0xF627EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4E38", Offset = "0x2C4E38")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600062D")]
				[Address(RVA = "0xF62800", Offset = "0xF62800", VA = "0xF62800")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4E48", Offset = "0x2C4E48")]
				private set
				{
				}
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0xF6280C", Offset = "0xF6280C", VA = "0xF6280C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0xF63024", Offset = "0xF63024", VA = "0xF63024", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0xF63990", Offset = "0xF63990", VA = "0xF63990", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0xF63860", Offset = "0xF63860", VA = "0xF63860")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0xF63584", Offset = "0xF63584", VA = "0xF63584")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0xF5A364", Offset = "0xF5A364", VA = "0xF5A364")]
			public void Solve()
			{
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0xF64158", Offset = "0xF64158", VA = "0xF64158", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000635")]
			[Address(RVA = "0xF64318", Offset = "0xF64318", VA = "0xF64318", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0xF5D4C8", Offset = "0xF5D4C8", VA = "0xF5D4C8")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CA")]
		public class Locomotion
		{
			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0010", Offset = "0x2C0010")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C0010", Offset = "0x2C0010")]
			public float weight;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C008C", Offset = "0x2C008C")]
			public float footDistance;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C00EC", Offset = "0x2C00EC")]
			public float stepThreshold;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0120", Offset = "0x2C0120")]
			public float angleThreshold;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0154", Offset = "0x2C0154")]
			public float comAngleMlp;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0188", Offset = "0x2C0188")]
			public float maxVelocity;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C01BC", Offset = "0x2C01BC")]
			public float velocityFactor;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C021C", Offset = "0x2C021C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C021C", Offset = "0x2C021C")]
			public float maxLegStretch;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0270", Offset = "0x2C0270")]
			public float rootSpeed;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C02A4", Offset = "0x2C02A4")]
			public float stepSpeed;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C02E4", Offset = "0x2C02E4")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C034C", Offset = "0x2C034C")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0380", Offset = "0x2C0380")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C0380", Offset = "0x2C0380")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C03D4", Offset = "0x2C03D4")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0408", Offset = "0x2C0408")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0454", Offset = "0x2C0454")]
			public Vector3 offset;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C04EC", Offset = "0x2C04EC")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0548", Offset = "0x2C0548")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C05A4", Offset = "0x2C05A4")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Footstep[] footsteps;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 comVelocity;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private int leftFootIndex;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private int rightFootIndex;

			[Token(Token = "0x17000091")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000637")]
				[Address(RVA = "0xF64418", Offset = "0xF64418", VA = "0xF64418")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4E58", Offset = "0x2C4E58")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000638")]
				[Address(RVA = "0xF6442C", Offset = "0xF6442C", VA = "0xF6442C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4E68", Offset = "0x2C4E68")]
				private set
				{
				}
			}

			[Token(Token = "0x17000092")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x600063E")]
				[Address(RVA = "0xF6491C", Offset = "0xF6491C", VA = "0xF6491C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000093")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x600063F")]
				[Address(RVA = "0xF64980", Offset = "0xF64980", VA = "0xF64980")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000094")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000640")]
				[Address(RVA = "0xF649E4", Offset = "0xF649E4", VA = "0xF649E4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000095")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000641")]
				[Address(RVA = "0xF64A44", Offset = "0xF64A44", VA = "0xF64A44")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0xF56FB4", Offset = "0xF56FB4", VA = "0xF56FB4")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0xF53A48", Offset = "0xF53A48", VA = "0xF53A48")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0xF52958", Offset = "0xF52958", VA = "0xF52958")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0xF5271C", Offset = "0xF5271C", VA = "0xF5271C")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0xF57BE4", Offset = "0xF57BE4", VA = "0xF57BE4")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0xF64480", Offset = "0xF64480", VA = "0xF64480")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0xF64658", Offset = "0xF64658", VA = "0xF64658")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0xF646F4", Offset = "0xF646F4", VA = "0xF646F4")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0xF5D5C8", Offset = "0xF5D5C8", VA = "0xF5D5C8")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CB")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C05B4", Offset = "0x2C05B4")]
			public Transform headTarget;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C05F4", Offset = "0x2C05F4")]
			public Transform pelvisTarget;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C064C", Offset = "0x2C064C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C064C", Offset = "0x2C064C")]
			public float positionWeight;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C06BC", Offset = "0x2C06BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C06BC", Offset = "0x2C06BC")]
			public float rotationWeight;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C072C", Offset = "0x2C072C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C072C", Offset = "0x2C072C")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C079C", Offset = "0x2C079C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C079C", Offset = "0x2C079C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C080C", Offset = "0x2C080C")]
			public Transform chestGoal;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0840", Offset = "0x2C0840")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C0840", Offset = "0x2C0840")]
			public float chestGoalWeight;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C08B0", Offset = "0x2C08B0")]
			public float minHeadHeight;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0918", Offset = "0x2C0918")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C0918", Offset = "0x2C0918")]
			public float bodyPosStiffness;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0968", Offset = "0x2C0968")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C0968", Offset = "0x2C0968")]
			public float bodyRotStiffness;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C09B8", Offset = "0x2C09B8")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x2C09B8", Offset = "0x2C09B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C09B8", Offset = "0x2C09B8")]
			public float neckStiffness;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0A3C", Offset = "0x2C0A3C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C0A3C", Offset = "0x2C0A3C")]
			public float rotateChestByHands;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0A8C", Offset = "0x2C0A8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C0A8C", Offset = "0x2C0A8C")]
			public float chestClampWeight;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0AEC", Offset = "0x2C0AEC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C0AEC", Offset = "0x2C0AEC")]
			public float headClampWeight;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0B4C", Offset = "0x2C0B4C")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0B80", Offset = "0x2C0B80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C0B80", Offset = "0x2C0B80")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0C04", Offset = "0x2C0C04")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C0C04", Offset = "0x2C0C04")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C0D38", Offset = "0x2C0D38")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			private Quaternion headRotation;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private int pelvisIndex;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private int spineIndex;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
			private int chestIndex;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			private int neckIndex;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private int headIndex;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private float length;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
			private bool hasChest;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
			private bool hasNeck;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private float headHeight;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private float sizeMlp;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
			private Vector3 chestForward;

			[Token(Token = "0x17000096")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000646")]
				[Address(RVA = "0xF53EB8", Offset = "0xF53EB8", VA = "0xF53EB8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000097")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000647")]
				[Address(RVA = "0xF64AA4", Offset = "0xF64AA4", VA = "0xF64AA4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000098")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000648")]
				[Address(RVA = "0xF5A7C8", Offset = "0xF5A7C8", VA = "0xF5A7C8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000099")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000649")]
				[Address(RVA = "0xF64AEC", Offset = "0xF64AEC", VA = "0xF64AEC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009A")]
			public VirtualBone head
			{
				[Token(Token = "0x600064A")]
				[Address(RVA = "0xF64438", Offset = "0xF64438", VA = "0xF64438")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009B")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x600064B")]
				[Address(RVA = "0xF64B34", Offset = "0xF64B34", VA = "0xF64B34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4E78", Offset = "0x2C4E78")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600064C")]
				[Address(RVA = "0xF64B44", Offset = "0xF64B44", VA = "0xF64B44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4E88", Offset = "0x2C4E88")]
				private set
				{
				}
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0xF64B54", Offset = "0xF64B54", VA = "0xF64B54", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0xF65C40", Offset = "0xF65C40", VA = "0xF65C40", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0xF65F30", Offset = "0xF65F30", VA = "0xF65F30", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0xF665EC", Offset = "0xF665EC", VA = "0xF665EC")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0xF57424", Offset = "0xF57424", VA = "0xF57424")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0xF67228", Offset = "0xF67228", VA = "0xF67228")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0xF67BA8", Offset = "0xF67BA8", VA = "0xF67BA8")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0xF687A4", Offset = "0xF687A4", VA = "0xF687A4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0xF68B6C", Offset = "0xF68B6C", VA = "0xF68B6C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0xF66848", Offset = "0xF66848", VA = "0xF66848")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0xF59F0C", Offset = "0xF59F0C", VA = "0xF59F0C")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0xF66D04", Offset = "0xF66D04", VA = "0xF66D04")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0xF68CC4", Offset = "0xF68CC4", VA = "0xF68CC4")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0xF67884", Offset = "0xF67884", VA = "0xF67884")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0xF6752C", Offset = "0xF6752C", VA = "0xF6752C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0xF5D110", Offset = "0xF5D110", VA = "0xF5D110")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CC")]
		public enum PositionOffset
		{
			[Token(Token = "0x400060D")]
			Pelvis,
			[Token(Token = "0x400060E")]
			Chest,
			[Token(Token = "0x400060F")]
			Head,
			[Token(Token = "0x4000610")]
			LeftHand,
			[Token(Token = "0x4000611")]
			RightHand,
			[Token(Token = "0x4000612")]
			LeftFoot,
			[Token(Token = "0x4000613")]
			RightFoot,
			[Token(Token = "0x4000614")]
			LeftHeel,
			[Token(Token = "0x4000615")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000CD")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000617")]
			Pelvis,
			[Token(Token = "0x4000618")]
			Chest,
			[Token(Token = "0x4000619")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000CE")]
		public class VirtualBone
		{
			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 readPosition;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Quaternion readRotation;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 solverPosition;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Quaternion solverRotation;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float length;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float sqrMag;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 axis;

			[Token(Token = "0x600065D")]
			[Address(RVA = "0xF56DC4", Offset = "0xF56DC4", VA = "0xF56DC4")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0xF56E34", Offset = "0xF56E34", VA = "0xF56E34")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0xF69154", Offset = "0xF69154", VA = "0xF69154")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0xF60D48", Offset = "0xF60D48", VA = "0xF60D48")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0xF6162C", Offset = "0xF6162C", VA = "0xF6162C")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0xF69560", Offset = "0xF69560", VA = "0xF69560")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0xF5F050", Offset = "0xF5F050", VA = "0xF5F050")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0xF698D4", Offset = "0xF698D4", VA = "0xF698D4")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0xF5FB84", Offset = "0xF5FB84", VA = "0xF5FB84")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0xF699CC", Offset = "0xF699CC", VA = "0xF699CC")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0xF6804C", Offset = "0xF6804C", VA = "0xF6804C")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0xF69C54", Offset = "0xF69C54", VA = "0xF69C54")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0xF69D94", Offset = "0xF69D94", VA = "0xF69D94")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Transform[] solverTransforms;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool hasChest;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool hasNeck;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private bool hasShoulders;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		private bool hasToes;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 rootV;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 bodyOffset;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int supportLegIndex;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BC620", Offset = "0x2BC620")]
		public bool plantFeet;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BC654", Offset = "0x2BC654")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BC664", Offset = "0x2BC664")]
		public Spine spine;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BC6A4", Offset = "0x2BC6A4")]
		public Arm leftArm;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BC6E8", Offset = "0x2BC6E8")]
		public Arm rightArm;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BC72C", Offset = "0x2BC72C")]
		public Leg leftLeg;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BC770", Offset = "0x2BC770")]
		public Leg rightLeg;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BC7B4", Offset = "0x2BC7B4")]
		public Locomotion locomotion;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Leg[] legs;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Arm[] arms;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headPosition;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 lastOffset;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 debugPos1;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 debugPos2;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private Vector3 debugPos3;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000045")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0xF53A40", Offset = "0xF53A40", VA = "0xF53A40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3E40", Offset = "0x2C3E40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000326")]
			[Address(RVA = "0xF56E2C", Offset = "0xF56E2C", VA = "0xF56E2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3E50", Offset = "0x2C3E50")]
			private set
			{
			}
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xF50AD4", Offset = "0xF50AD4", VA = "0xF50AD4")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xF510CC", Offset = "0xF510CC", VA = "0xF510CC")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xF50E98", Offset = "0xF50E98", VA = "0xF50E98")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xF51E74", Offset = "0xF51E74", VA = "0xF51E74")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xF5229C", Offset = "0xF5229C", VA = "0xF5229C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xF52368", Offset = "0xF52368", VA = "0xF52368")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xF52548", Offset = "0xF52548", VA = "0xF52548")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xF52E80", Offset = "0xF52E80", VA = "0xF52E80")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xF53F00", Offset = "0xF53F00", VA = "0xF53F00", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xF5418C", Offset = "0xF5418C", VA = "0xF5418C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xF54428", Offset = "0xF54428", VA = "0xF54428", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xF544B8", Offset = "0xF544B8", VA = "0xF544B8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xF54548", Offset = "0xF54548", VA = "0xF54548", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xF5482C", Offset = "0xF5482C", VA = "0xF5482C")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xF51524", Offset = "0xF51524", VA = "0xF51524")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xF51758", Offset = "0xF51758", VA = "0xF51758")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xF51CE4", Offset = "0xF51CE4", VA = "0xF51CE4")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xF53058", Offset = "0xF53058", VA = "0xF53058")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xF54C04", Offset = "0xF54C04", VA = "0xF54C04", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xF54C44", Offset = "0xF54C44", VA = "0xF54C44", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xF569F0", Offset = "0xF569F0", VA = "0xF569F0")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xF532CC", Offset = "0xF532CC", VA = "0xF532CC")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xF54CB4", Offset = "0xF54CB4", VA = "0xF54CB4")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xF56D14", Offset = "0xF56D14", VA = "0xF56D14")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xF56D70", Offset = "0xF56D70", VA = "0xF56D70")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xF567F0", Offset = "0xF567F0", VA = "0xF567F0")]
		private void Write()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xF5C644", Offset = "0xF5C644", VA = "0xF5C644")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xF5CF38", Offset = "0xF5CF38", VA = "0xF5CF38")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public IK ik;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BC804", Offset = "0x2BC804")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC804", Offset = "0x2BC804")]
		public float weight;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BC880", Offset = "0x2BC880")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC880", Offset = "0x2BC880")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BC8D0", Offset = "0x2BC8D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BC8D0", Offset = "0x2BC8D0")]
		public float twistAngleOffset;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 axis;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Transform parent;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform child;

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x133AC88", Offset = "0x133AC88", VA = "0x133AC88")]
		public void Relax()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x133B1EC", Offset = "0x133B1EC", VA = "0x133B1EC")]
		private void Start()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x133B7C0", Offset = "0x133B7C0", VA = "0x133B7C0")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x133B85C", Offset = "0x133B85C", VA = "0x133B85C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x133B8F8", Offset = "0x133B8F8", VA = "0x133B8F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x133BAB4", Offset = "0x133BAB4", VA = "0x133BAB4")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BC948", Offset = "0x2BC948")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BC958", Offset = "0x2BC958")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BC968", Offset = "0x2BC968")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Poser poser;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IKEffector effector;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float timer;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float length;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float weight;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float fadeInSpeed;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float defaultPull;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float defaultReach;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float defaultPush;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPushParent;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float resetTimer;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		private bool pullUsed;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		private bool reachUsed;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool pushUsed;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		private bool pushParentUsed;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		private bool pickedUp;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		private bool defaults;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Transform target;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private List<bool> triggered;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool started;

		[Token(Token = "0x17000046")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0xF6A8A4", Offset = "0xF6A8A4", VA = "0xF6A8A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3E60", Offset = "0x2C3E60")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000331")]
			[Address(RVA = "0xF6A8AC", Offset = "0xF6A8AC", VA = "0xF6A8AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3E70", Offset = "0x2C3E70")]
			private set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public bool isPaused
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0xF6A8B4", Offset = "0xF6A8B4", VA = "0xF6A8B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3E80", Offset = "0x2C3E80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000333")]
			[Address(RVA = "0xF6A8BC", Offset = "0xF6A8BC", VA = "0xF6A8BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3E90", Offset = "0x2C3E90")]
			private set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0xF6A8C4", Offset = "0xF6A8C4", VA = "0xF6A8C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3EA0", Offset = "0x2C3EA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000335")]
			[Address(RVA = "0xF6A8CC", Offset = "0xF6A8CC", VA = "0xF6A8CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3EB0", Offset = "0x2C3EB0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public bool inInteraction
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0xF6A8D4", Offset = "0xF6A8D4", VA = "0xF6A8D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004A")]
		public float progress
		{
			[Token(Token = "0x600033F")]
			[Address(RVA = "0xF6E0C4", Offset = "0xF6E0C4", VA = "0xF6E0C4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xF6A960", Offset = "0xF6A960", VA = "0xF6A960")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xF6A9F4", Offset = "0xF6A9F4", VA = "0xF6A9F4")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xF6AAF8", Offset = "0xF6AAF8", VA = "0xF6AAF8")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xF6AD90", Offset = "0xF6AD90", VA = "0xF6AD90")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xF6B44C", Offset = "0xF6B44C", VA = "0xF6B44C")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xF6B65C", Offset = "0xF6B65C", VA = "0xF6B65C")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xF6B6F0", Offset = "0xF6B6F0", VA = "0xF6B6F0")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xF6C028", Offset = "0xF6C028", VA = "0xF6C028")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xF6D268", Offset = "0xF6D268", VA = "0xF6D268")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xF6D7F8", Offset = "0xF6D7F8", VA = "0xF6D7F8")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xF6DEC4", Offset = "0xF6DEC4", VA = "0xF6DEC4")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xF6E2C0", Offset = "0xF6E2C0", VA = "0xF6E2C0")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BC978", Offset = "0x2BC978")]
		public LookAtIK ik;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BC9AC", Offset = "0x2BC9AC")]
		public float lerpSpeed;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCA04", Offset = "0x2BCA04")]
		public float weightSpeed;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform lookAtTarget;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float stopLookTime;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float weight;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xF6E6A8", Offset = "0xF6E6A8", VA = "0xF6E6A8")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xF6E8F4", Offset = "0xF6E8F4", VA = "0xF6E8F4")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xF6E9E8", Offset = "0xF6E9E8", VA = "0xF6E9E8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xF6ED40", Offset = "0xF6ED40", VA = "0xF6ED40")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xF6EF24", Offset = "0xF6EF24", VA = "0xF6EF24")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xF6F088", Offset = "0xF6F088", VA = "0xF6F088")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B9C18", Offset = "0x2B9C18")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B9C18", Offset = "0x2B9C18")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000CF")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0D48", Offset = "0x2C0D48")]
			public float time;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0DA4", Offset = "0x2C0DA4")]
			public bool pause;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0DD8", Offset = "0x2C0DD8")]
			public bool pickUp;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0E0C", Offset = "0x2C0E0C")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0E60", Offset = "0x2C0E60")]
			public Message[] messages;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0ECC", Offset = "0x2C0ECC")]
			public UnityEvent unityEvent;

			[Token(Token = "0x600066A")]
			[Address(RVA = "0xF6E104", Offset = "0xF6E104", VA = "0xF6E104")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0xF70A64", Offset = "0xF70A64", VA = "0xF70A64")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D0")]
		public class Message
		{
			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0F20", Offset = "0x2C0F20")]
			public string function;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0F70", Offset = "0x2C0F70")]
			public GameObject recipient;

			[Token(Token = "0x4000629")]
			private const string empty = "";

			[Token(Token = "0x600066C")]
			[Address(RVA = "0xF70940", Offset = "0xF70940", VA = "0xF70940")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0xF70A6C", Offset = "0xF70A6C", VA = "0xF70A6C")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D1")]
		public class AnimatorEvent
		{
			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C0FB8", Offset = "0x2C0FB8")]
			public Animator animator;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1024", Offset = "0x2C1024")]
			public Animation animation;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1058", Offset = "0x2C1058")]
			public string animationState;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C10A8", Offset = "0x2C10A8")]
			public float crossfadeTime;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C10EC", Offset = "0x2C10EC")]
			public int layer;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1120", Offset = "0x2C1120")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000630")]
			private const string empty = "";

			[Token(Token = "0x600066E")]
			[Address(RVA = "0xF705D8", Offset = "0xF705D8", VA = "0xF705D8")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x600066F")]
			[Address(RVA = "0xF706FC", Offset = "0xF706FC", VA = "0xF706FC")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0xF707E0", Offset = "0xF707E0", VA = "0xF707E0")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000671")]
			[Address(RVA = "0xF7092C", Offset = "0xF7092C", VA = "0xF7092C")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D2")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x2000103")]
			public enum Type
			{
				[Token(Token = "0x4000725")]
				PositionWeight,
				[Token(Token = "0x4000726")]
				RotationWeight,
				[Token(Token = "0x4000727")]
				PositionOffsetX,
				[Token(Token = "0x4000728")]
				PositionOffsetY,
				[Token(Token = "0x4000729")]
				PositionOffsetZ,
				[Token(Token = "0x400072A")]
				Pull,
				[Token(Token = "0x400072B")]
				Reach,
				[Token(Token = "0x400072C")]
				RotateBoneWeight,
				[Token(Token = "0x400072D")]
				Push,
				[Token(Token = "0x400072E")]
				PushParent,
				[Token(Token = "0x400072F")]
				PoserWeight
			}

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1188", Offset = "0x2C1188")]
			public Type type;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C11F0", Offset = "0x2C11F0")]
			public AnimationCurve curve;

			[Token(Token = "0x6000672")]
			[Address(RVA = "0xF6F9D4", Offset = "0xF6F9D4", VA = "0xF6F9D4")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0xF70A84", Offset = "0xF70A84", VA = "0xF70A84")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D3")]
		public class Multiplier
		{
			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1230", Offset = "0x2C1230")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1278", Offset = "0x2C1278")]
			public float multiplier;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C12CC", Offset = "0x2C12CC")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000674")]
			[Address(RVA = "0xF703C0", Offset = "0xF703C0", VA = "0xF703C0")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0xF70A74", Offset = "0xF70A74", VA = "0xF70A74")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCA6C", Offset = "0x2BCA6C")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCAA0", Offset = "0x2BCAA0")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCAD4", Offset = "0x2BCAD4")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BCB08", Offset = "0x2BCB08")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BCB18", Offset = "0x2BCB18")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700004B")]
		public float length
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0xF6C020", Offset = "0xF6C020", VA = "0xF6C020")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C3FF8", Offset = "0x2C3FF8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000351")]
			[Address(RVA = "0xF6F2E4", Offset = "0xF6F2E4", VA = "0xF6F2E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4008", Offset = "0x2C4008")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000352")]
			[Address(RVA = "0xF6F2EC", Offset = "0xF6F2EC", VA = "0xF6F2EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4018", Offset = "0x2C4018")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000353")]
			[Address(RVA = "0xF6F2F4", Offset = "0xF6F2F4", VA = "0xF6F2F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4028", Offset = "0x2C4028")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0xF6F648", Offset = "0xF6F648", VA = "0xF6F648")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public Transform targetsRoot
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0xF6E21C", Offset = "0xF6E21C", VA = "0xF6E21C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xF6F0A4", Offset = "0xF6F0A4", VA = "0xF6F0A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3EC0", Offset = "0x2C3EC0")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xF6F104", Offset = "0xF6F104", VA = "0xF6F104")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3EF4", Offset = "0x2C3EF4")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xF6F164", Offset = "0xF6F164", VA = "0xF6F164")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3F28", Offset = "0x2C3F28")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xF6F1C4", Offset = "0xF6F1C4", VA = "0xF6F1C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3F5C", Offset = "0x2C3F5C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xF6F224", Offset = "0xF6F224", VA = "0xF6F224")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3F90", Offset = "0x2C3F90")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xF6F284", Offset = "0xF6F284", VA = "0xF6F284")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C3FC4", Offset = "0x2C3FC4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xF6F2FC", Offset = "0xF6F2FC", VA = "0xF6F2FC")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xF6F6EC", Offset = "0xF6F6EC", VA = "0xF6F6EC")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xF6BF34", Offset = "0xF6BF34", VA = "0xF6BF34")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xF6F8E4", Offset = "0xF6F8E4", VA = "0xF6F8E4")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xF6BD40", Offset = "0xF6BD40", VA = "0xF6BD40")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xF6BF2C", Offset = "0xF6BF2C", VA = "0xF6BF2C")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xF6CAD0", Offset = "0xF6CAD0", VA = "0xF6CAD0")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xF6DB44", Offset = "0xF6DB44", VA = "0xF6DB44")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xF70404", Offset = "0xF70404", VA = "0xF70404")]
		private void Awake()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xF6FA08", Offset = "0xF6FA08", VA = "0xF6FA08")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xF6F8EC", Offset = "0xF6F8EC", VA = "0xF6F8EC")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xF70324", Offset = "0xF70324", VA = "0xF70324")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xF70408", Offset = "0xF70408", VA = "0xF70408")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xF704A4", Offset = "0xF704A4", VA = "0xF704A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C4038", Offset = "0x2C4038")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xF70504", Offset = "0xF70504", VA = "0xF70504")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C406C", Offset = "0x2C406C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xF70564", Offset = "0xF70564", VA = "0xF70564")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B9C78", Offset = "0x2B9C78")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B9C78", Offset = "0x2B9C78")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000D4")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000D5")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCB28", Offset = "0x2BCB28")]
		public string targetTag;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCB5C", Offset = "0x2BCB5C")]
		public float fadeInTime;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCBB0", Offset = "0x2BCBB0")]
		public float speed;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCC04", Offset = "0x2BCC04")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2BCC38", Offset = "0x2BCC38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCC38", Offset = "0x2BCC38")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x2BCC38", Offset = "0x2BCC38")]
		public Collider characterCollider;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCCC4", Offset = "0x2BCCC4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x2BCCC4", Offset = "0x2BCCC4")]
		public Transform FPSCamera;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCD24", Offset = "0x2BCD24")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCD58", Offset = "0x2BCD58")]
		public float camRaycastDistance;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BCDB0", Offset = "0x2BCDB0")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RaycastHit raycastHit;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x2BCDC0", Offset = "0x2BCDC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCDC0", Offset = "0x2BCDC0")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCE20", Offset = "0x2BCE20")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool initiated;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Collider lastCollider;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Collider c;

		[Token(Token = "0x1700004F")]
		public bool inInteraction
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0xF70CCC", Offset = "0xF70CCC", VA = "0xF70CCC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000050")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0xF6AAF0", Offset = "0xF6AAF0", VA = "0xF6AAF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000387")]
			[Address(RVA = "0xF73974", Offset = "0xF73974", VA = "0xF73974")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0xF72260", Offset = "0xF72260", VA = "0xF72260")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C41D8", Offset = "0x2C41D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000389")]
			[Address(RVA = "0xF7397C", Offset = "0xF7397C", VA = "0xF7397C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C41E8", Offset = "0x2C41E8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xF70A8C", Offset = "0xF70A8C", VA = "0xF70A8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C40A0", Offset = "0x2C40A0")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xF70AEC", Offset = "0xF70AEC", VA = "0xF70AEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C40D4", Offset = "0x2C40D4")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xF70B4C", Offset = "0xF70B4C", VA = "0xF70B4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C4108", Offset = "0x2C4108")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xF70BAC", Offset = "0xF70BAC", VA = "0xF70BAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C413C", Offset = "0x2C413C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xF70C0C", Offset = "0xF70C0C", VA = "0xF70C0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C4170", Offset = "0x2C4170")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xF70C6C", Offset = "0xF70C6C", VA = "0xF70C6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C41A4", Offset = "0x2C41A4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xF70EE8", Offset = "0xF70EE8", VA = "0xF70EE8")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xF71044", Offset = "0xF71044", VA = "0xF71044")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xF7119C", Offset = "0xF7119C", VA = "0xF7119C")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xF712A4", Offset = "0xF712A4", VA = "0xF712A4")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xF71438", Offset = "0xF71438", VA = "0xF71438")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xF715EC", Offset = "0xF715EC", VA = "0xF715EC")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xF716E4", Offset = "0xF716E4", VA = "0xF716E4")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xF717DC", Offset = "0xF717DC", VA = "0xF717DC")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xF718D4", Offset = "0xF718D4", VA = "0xF718D4")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xF71970", Offset = "0xF71970", VA = "0xF71970")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xF71A0C", Offset = "0xF71A0C", VA = "0xF71A0C")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xF71A98", Offset = "0xF71A98", VA = "0xF71A98")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xF71B94", Offset = "0xF71B94", VA = "0xF71B94")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xF71CBC", Offset = "0xF71CBC", VA = "0xF71CBC")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xF71E10", Offset = "0xF71E10", VA = "0xF71E10")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xF72268", Offset = "0xF72268", VA = "0xF72268")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xF72550", Offset = "0xF72550", VA = "0xF72550")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xF72974", Offset = "0xF72974", VA = "0xF72974")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xF72DC0", Offset = "0xF72DC0", VA = "0xF72DC0")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xF72E28", Offset = "0xF72E28", VA = "0xF72E28")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xF72F30", Offset = "0xF72F30", VA = "0xF72F30")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xF730BC", Offset = "0xF730BC", VA = "0xF730BC")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xF732AC", Offset = "0xF732AC", VA = "0xF732AC")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xF737E8", Offset = "0xF737E8", VA = "0xF737E8")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xF72AD8", Offset = "0xF72AD8", VA = "0xF72AD8")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xF73984", Offset = "0xF73984", VA = "0xF73984", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xF74564", Offset = "0xF74564", VA = "0xF74564")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xF7458C", Offset = "0xF7458C", VA = "0xF7458C")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xF745B4", Offset = "0xF745B4", VA = "0xF745B4")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xF745DC", Offset = "0xF745DC", VA = "0xF745DC")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xF74664", Offset = "0xF74664", VA = "0xF74664")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xF747D8", Offset = "0xF747D8", VA = "0xF747D8")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xF74910", Offset = "0xF74910", VA = "0xF74910")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xF74BB0", Offset = "0xF74BB0", VA = "0xF74BB0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xF74CD4", Offset = "0xF74CD4", VA = "0xF74CD4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xF75064", Offset = "0xF75064", VA = "0xF75064")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xF741BC", Offset = "0xF741BC", VA = "0xF741BC")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xF751AC", Offset = "0xF751AC", VA = "0xF751AC")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xF7536C", Offset = "0xF7536C", VA = "0xF7536C")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xF75464", Offset = "0xF75464", VA = "0xF75464")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xF755CC", Offset = "0xF755CC", VA = "0xF755CC")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xF755F4", Offset = "0xF755F4", VA = "0xF755F4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xF70DD4", Offset = "0xF70DD4", VA = "0xF70DD4")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xF720F0", Offset = "0xF720F0", VA = "0xF720F0")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xF75CC4", Offset = "0xF75CC4", VA = "0xF75CC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C41F8", Offset = "0x2C41F8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xF75D24", Offset = "0xF75D24", VA = "0xF75D24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C422C", Offset = "0x2C422C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xF75D84", Offset = "0xF75D84", VA = "0xF75D84")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B9CD8", Offset = "0x2B9CD8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B9CD8", Offset = "0x2B9CD8")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D6")]
		public class Multiplier
		{
			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1330", Offset = "0x2C1330")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1394", Offset = "0x2C1394")]
			public float multiplier;

			[Token(Token = "0x600067E")]
			[Address(RVA = "0x132D8B4", Offset = "0x132D8B4", VA = "0x132D8B4")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCE74", Offset = "0x2BCE74")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCEC0", Offset = "0x2BCEC0")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCEF4", Offset = "0x2BCEF4")]
		public float interactionSpeedMlp;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCF28", Offset = "0x2BCF28")]
		public Transform pivot;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCF5C", Offset = "0x2BCF5C")]
		public Vector3 twistAxis;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCFC4", Offset = "0x2BCFC4")]
		public float twistWeight;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BCFF8", Offset = "0x2BCFF8")]
		public float swingWeight;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD02C", Offset = "0x2BD02C")]
		public bool rotateOnce;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Transform lastPivot;

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x132CAB4", Offset = "0x132CAB4", VA = "0x132CAB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C4260", Offset = "0x2C4260")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x132CB14", Offset = "0x132CB14", VA = "0x132CB14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C4294", Offset = "0x2C4294")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x132CB74", Offset = "0x132CB74", VA = "0x132CB74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C42C8", Offset = "0x2C42C8")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x132CBD4", Offset = "0x132CBD4", VA = "0x132CBD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C42FC", Offset = "0x2C42FC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x132CC34", Offset = "0x132CC34", VA = "0x132CC34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C4330", Offset = "0x2C4330")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x132CC94", Offset = "0x132CC94", VA = "0x132CC94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C4364", Offset = "0x2C4364")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x132CCF4", Offset = "0x132CCF4", VA = "0x132CCF4")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x132CDE4", Offset = "0x132CDE4", VA = "0x132CDE4")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x132CEC0", Offset = "0x132CEC0", VA = "0x132CEC0")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x132D740", Offset = "0x132D740", VA = "0x132D740")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C4398", Offset = "0x2C4398")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x132D7A0", Offset = "0x132D7A0", VA = "0x132D7A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C43CC", Offset = "0x2C43CC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x132D800", Offset = "0x132D800", VA = "0x132D800")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B9D38", Offset = "0x2B9D38")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B9D38", Offset = "0x2B9D38")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D7")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C13E4", Offset = "0x2C13E4")]
			public bool use;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1418", Offset = "0x2C1418")]
			public Vector2 offset;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C144C", Offset = "0x2C144C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C144C", Offset = "0x2C144C")]
			public float angleOffset;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C14D0", Offset = "0x2C14D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C14D0", Offset = "0x2C14D0")]
			public float maxAngle;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1524", Offset = "0x2C1524")]
			public float radius;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1558", Offset = "0x2C1558")]
			public bool orbit;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C158C", Offset = "0x2C158C")]
			public bool fixYAxis;

			[Token(Token = "0x1700009C")]
			public Vector3 offset3D
			{
				[Token(Token = "0x600067F")]
				[Address(RVA = "0x132E5C0", Offset = "0x132E5C0", VA = "0x132E5C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009D")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000680")]
				[Address(RVA = "0x132E5FC", Offset = "0x132E5FC", VA = "0x132E5FC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x132E714", Offset = "0x132E714", VA = "0x132E714")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x132F044", Offset = "0x132F044", VA = "0x132F044")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D8")]
		public class CameraPosition
		{
			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C15C0", Offset = "0x2C15C0")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C15F4", Offset = "0x2C15F4")]
			public Vector3 direction;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1628", Offset = "0x2C1628")]
			public float maxDistance;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1688", Offset = "0x2C1688")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C1688", Offset = "0x2C1688")]
			public float maxAngle;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C16DC", Offset = "0x2C16DC")]
			public bool fixYAxis;

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x132DF1C", Offset = "0x132DF1C", VA = "0x132DF1C")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000684")]
			[Address(RVA = "0x132E158", Offset = "0x132E158", VA = "0x132E158")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000685")]
			[Address(RVA = "0x132E4F0", Offset = "0x132E4F0", VA = "0x132E4F0")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D9")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x2000104")]
			public class Interaction
			{
				[Token(Token = "0x4000730")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2B40", Offset = "0x2C2B40")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000731")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2B94", Offset = "0x2C2B94")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x600071C")]
				[Address(RVA = "0x132F070", Offset = "0x132F070", VA = "0x132F070")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1770", Offset = "0x2C1770")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C17D4", Offset = "0x2C17D4")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C183C", Offset = "0x2C183C")]
			public Interaction[] interactions;

			[Token(Token = "0x6000686")]
			[Address(RVA = "0x132DCFC", Offset = "0x132DCFC", VA = "0x132DCFC")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000687")]
			[Address(RVA = "0x132F060", Offset = "0x132F060", VA = "0x132F060")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD060", Offset = "0x2BD060")]
		public Range[] ranges;

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x132D8BC", Offset = "0x132D8BC", VA = "0x132D8BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C4400", Offset = "0x2C4400")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x132D91C", Offset = "0x132D91C", VA = "0x132D91C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C4434", Offset = "0x2C4434")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x132D97C", Offset = "0x132D97C", VA = "0x132D97C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C4468", Offset = "0x2C4468")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x132D9DC", Offset = "0x132D9DC", VA = "0x132D9DC")]
		private void Start()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x132D9E0", Offset = "0x132D9E0", VA = "0x132D9E0")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x132DEA8", Offset = "0x132DEA8", VA = "0x132DEA8")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000DA")]
		public class Map
		{
			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform bone;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Transform target;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000688")]
			[Address(RVA = "0xD1BE00", Offset = "0xD1BE00", VA = "0xD1BE00")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0xD1C358", Offset = "0xD1C358", VA = "0xD1C358")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0xD1C2D0", Offset = "0xD1C2D0", VA = "0xD1C2D0")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0xD1C024", Offset = "0xD1C024", VA = "0xD1C024")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Map[] maps;

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xD1BA34", Offset = "0xD1BA34", VA = "0xD1BA34", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C449C", Offset = "0x2C449C")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xD1BEBC", Offset = "0xD1BEBC", VA = "0xD1BEBC", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xD1BEC0", Offset = "0xD1BEC0", VA = "0xD1BEC0", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xD1C244", Offset = "0xD1C244", VA = "0xD1C244", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xD1BE30", Offset = "0xD1BE30", VA = "0xD1BE30")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xD1BD4C", Offset = "0xD1BD4C", VA = "0xD1BD4C")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xD1C3DC", Offset = "0xD1C3DC", VA = "0xD1C3DC")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _poseRoot;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Transform[] children;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform[] poseChildren;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x115CF9C", Offset = "0x115CF9C", VA = "0x115CF9C", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x115D084", Offset = "0x115D084", VA = "0x115D084", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x115D340", Offset = "0x115D340", VA = "0x115D340", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x115D4E4", Offset = "0x115D4E4", VA = "0x115D4E4", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x115D0F4", Offset = "0x115D0F4", VA = "0x115D0F4")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x115DA54", Offset = "0x115DA54", VA = "0x115DA54")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Transform poseRoot;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BD094", Offset = "0x2BD094")]
		public float weight;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BD0AC", Offset = "0x2BD0AC")]
		public float localRotationWeight;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BD0C4", Offset = "0x2BD0C4")]
		public float localPositionWeight;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool initiated;

		[Token(Token = "0x60003BF")]
		public abstract void AutoMapping();

		[Token(Token = "0x60003C0")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60003C1")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60003C2")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x133103C", Offset = "0x133103C", VA = "0x133103C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x133108C", Offset = "0x133108C", VA = "0x133108C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x13310C4", Offset = "0x13310C4", VA = "0x13310C4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x13310E0", Offset = "0x13310E0", VA = "0x13310E0")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2B9D98", Offset = "0x2B9D98")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000DB")]
		public class Rigidbone
		{
			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Rigidbody r;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Transform t;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Collider collider;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Joint joint;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody c;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool updateAnchor;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float deltaTime;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public Quaternion lastRotation;

			[Token(Token = "0x600068C")]
			[Address(RVA = "0x13318A0", Offset = "0x13318A0", VA = "0x13318A0")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x1332A20", Offset = "0x1332A20", VA = "0x1332A20")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0x13326F8", Offset = "0x13326F8", VA = "0x13326F8")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000DC")]
		public class Child
		{
			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform t;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 localPosition;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Quaternion localRotation;

			[Token(Token = "0x600068F")]
			[Address(RVA = "0x1331AA4", Offset = "0x1331AA4", VA = "0x1331AA4")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0x1332C60", Offset = "0x1332C60", VA = "0x1332C60")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x1332BDC", Offset = "0x1332BDC", VA = "0x1332BDC")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BA6EC", Offset = "0x2BA6EC")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x1700009E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000695")]
				[Address(RVA = "0x13334D8", Offset = "0x13334D8", VA = "0x13334D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000697")]
				[Address(RVA = "0x1333568", Offset = "0x1333568", VA = "0x1333568", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0x1331B34", Offset = "0x1331B34", VA = "0x1331B34")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x1333158", Offset = "0x1333158", VA = "0x1333158", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x133315C", Offset = "0x133315C", VA = "0x133315C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x13334E0", Offset = "0x13334E0", VA = "0x13334E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD0DC", Offset = "0x2BD0DC")]
		public IK ik;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD110", Offset = "0x2BD110")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD178", Offset = "0x2BD178")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD1E4", Offset = "0x2BD1E4")]
		public float applyVelocity;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD248", Offset = "0x2BD248")]
		public float applyAngularVelocity;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Child[] children;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private IK[] allIKComponents;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool[] fixTransforms;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float ragdollWeight;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float ragdollWeightV;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool fixedFrame;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000052")]
		private bool isRagdoll
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x133113C", Offset = "0x133113C", VA = "0x133113C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		private bool ikUsed
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x13320A0", Offset = "0x13320A0", VA = "0x13320A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x133110C", Offset = "0x133110C", VA = "0x133110C")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x13311E4", Offset = "0x13311E4", VA = "0x13311E4")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1331328", Offset = "0x1331328", VA = "0x1331328")]
		public void Start()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x133129C", Offset = "0x133129C", VA = "0x133129C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2C44D8", Offset = "0x2C44D8")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1331B54", Offset = "0x1331B54", VA = "0x1331B54")]
		private void Update()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1331F28", Offset = "0x1331F28", VA = "0x1331F28")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1331FD8", Offset = "0x1331FD8", VA = "0x1331FD8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x13322AC", Offset = "0x13322AC", VA = "0x13322AC")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x133206C", Offset = "0x133206C", VA = "0x133206C")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1332278", Offset = "0x1332278", VA = "0x1332278")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1332340", Offset = "0x1332340", VA = "0x1332340")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x13322D0", Offset = "0x13322D0", VA = "0x13322D0")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x133122C", Offset = "0x133122C", VA = "0x133122C")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1331F60", Offset = "0x1331F60", VA = "0x1331F60")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1332EAC", Offset = "0x1332EAC", VA = "0x1332EAC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1333068", Offset = "0x1333068", VA = "0x1333068")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 axis;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool initiated;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool applicationQuit;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000054")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x13359DC", Offset = "0x13359DC", VA = "0x13359DC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000055")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x1335A18", Offset = "0x1335A18", VA = "0x1335A18")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1335560", Offset = "0x1335560", VA = "0x1335560")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x13355C0", Offset = "0x13355C0", VA = "0x13355C0")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x13358F8", Offset = "0x13358F8", VA = "0x13358F8")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x13359AC", Offset = "0x13359AC", VA = "0x13359AC")]
		public void Disable()
		{
		}

		[Token(Token = "0x60003DF")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x13357DC", Offset = "0x13357DC", VA = "0x13357DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1335AEC", Offset = "0x1335AEC", VA = "0x1335AEC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1335AF0", Offset = "0x1335AF0", VA = "0x1335AF0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1335B18", Offset = "0x1335B18", VA = "0x1335B18")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1335C30", Offset = "0x1335C30", VA = "0x1335C30")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1335F48", Offset = "0x1335F48", VA = "0x1335F48")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1336044", Offset = "0x1336044", VA = "0x1336044")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B9E10", Offset = "0x2B9E10")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B9E10", Offset = "0x2B9E10")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BD28C", Offset = "0x2BD28C")]
		public float limit;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BD2A8", Offset = "0x2BD2A8")]
		public float twistLimit;

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x13360E8", Offset = "0x13360E8", VA = "0x13360E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C4550", Offset = "0x2C4550")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1336148", Offset = "0x1336148", VA = "0x1336148")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C4584", Offset = "0x2C4584")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x13361A8", Offset = "0x13361A8", VA = "0x13361A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C45B8", Offset = "0x2C45B8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1336208", Offset = "0x1336208", VA = "0x1336208")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C45EC", Offset = "0x2C45EC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1336268", Offset = "0x1336268", VA = "0x1336268", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1336308", Offset = "0x1336308", VA = "0x1336308")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x13365FC", Offset = "0x13365FC", VA = "0x13365FC")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B9EA8", Offset = "0x2B9EA8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B9EA8", Offset = "0x2B9EA8")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool useLimits;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float min;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float max;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Quaternion lastRotation;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1336618", Offset = "0x1336618", VA = "0x1336618")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C4620", Offset = "0x2C4620")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1336678", Offset = "0x1336678", VA = "0x1336678")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C4654", Offset = "0x2C4654")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x13366D8", Offset = "0x13366D8", VA = "0x13366D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C4688", Offset = "0x2C4688")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1336738", Offset = "0x1336738", VA = "0x1336738")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C46BC", Offset = "0x2C46BC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1336798", Offset = "0x1336798", VA = "0x1336798", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x13367E4", Offset = "0x13367E4", VA = "0x13367E4")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1336B8C", Offset = "0x1336B8C", VA = "0x1336B8C")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B9F40", Offset = "0x2B9F40")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B9F40", Offset = "0x2B9F40")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000DE")]
		public class ReachCone
		{
			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float volume;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 S;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 B;

			[Token(Token = "0x170000A0")]
			public Vector3 o
			{
				[Token(Token = "0x6000698")]
				[Address(RVA = "0x13396EC", Offset = "0x13396EC", VA = "0x13396EC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A1")]
			public Vector3 a
			{
				[Token(Token = "0x6000699")]
				[Address(RVA = "0x133973C", Offset = "0x133973C", VA = "0x133973C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A2")]
			public Vector3 b
			{
				[Token(Token = "0x600069A")]
				[Address(RVA = "0x133978C", Offset = "0x133978C", VA = "0x133978C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A3")]
			public Vector3 c
			{
				[Token(Token = "0x600069B")]
				[Address(RVA = "0x13397DC", Offset = "0x13397DC", VA = "0x13397DC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A4")]
			public bool isValid
			{
				[Token(Token = "0x600069D")]
				[Address(RVA = "0x13383B8", Offset = "0x13383B8", VA = "0x13383B8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x1338C80", Offset = "0x1338C80", VA = "0x1338C80")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x1338E74", Offset = "0x1338E74", VA = "0x1338E74")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DF")]
		public class LimitPoint
		{
			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 point;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float tangentWeight;

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x13383D0", Offset = "0x13383D0", VA = "0x13383D0")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BD2D4", Offset = "0x2BD2D4")]
		public float twistLimit;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BD2F0", Offset = "0x2BD2F0")]
		public int smoothIterations;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1336C54", Offset = "0x1336C54", VA = "0x1336C54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C46F0", Offset = "0x2C46F0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1336CB4", Offset = "0x1336CB4", VA = "0x1336CB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C4724", Offset = "0x2C4724")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1336D14", Offset = "0x1336D14", VA = "0x1336D14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C4758", Offset = "0x2C4758")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1336D74", Offset = "0x1336D74", VA = "0x1336D74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C478C", Offset = "0x2C478C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1336DD4", Offset = "0x1336DD4", VA = "0x1336DD4")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x13374F0", Offset = "0x13374F0", VA = "0x13374F0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x13375C8", Offset = "0x13375C8", VA = "0x13375C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1337E4C", Offset = "0x1337E4C", VA = "0x1337E4C")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1336E7C", Offset = "0x1336E7C", VA = "0x1336E7C")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1338478", Offset = "0x1338478", VA = "0x1338478")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x133906C", Offset = "0x133906C", VA = "0x133906C")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x13390B4", Offset = "0x13390B4", VA = "0x13390B4")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x133921C", Offset = "0x133921C", VA = "0x133921C")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x13379E8", Offset = "0x13379E8", VA = "0x13379E8")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x13393C8", Offset = "0x13393C8", VA = "0x13393C8")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1339670", Offset = "0x1339670", VA = "0x1339670")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2B9FA0", Offset = "0x2B9FA0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2B9FA0", Offset = "0x2B9FA0")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BD39C", Offset = "0x2BD39C")]
		public float twistLimit;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x133982C", Offset = "0x133982C", VA = "0x133982C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C47C0", Offset = "0x2C47C0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x133988C", Offset = "0x133988C", VA = "0x133988C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C47F4", Offset = "0x2C47F4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x13398EC", Offset = "0x13398EC", VA = "0x13398EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C4828", Offset = "0x2C4828")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x133994C", Offset = "0x133994C", VA = "0x133994C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C485C", Offset = "0x2C485C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x13399AC", Offset = "0x13399AC", VA = "0x13399AC")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x13399E0", Offset = "0x13399E0", VA = "0x13399E0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1339A80", Offset = "0x1339A80", VA = "0x1339A80")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1339EC4", Offset = "0x1339EC4", VA = "0x1339EC4")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD3E8", Offset = "0x2BD3E8")]
		public AimIK ik;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD41C", Offset = "0x2BD41C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BD41C", Offset = "0x2BD41C")]
		public float weight;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2BD484", Offset = "0x2BD484")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD484", Offset = "0x2BD484")]
		public Transform target;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD4F0", Offset = "0x2BD4F0")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD544", Offset = "0x2BD544")]
		public float weightSmoothTime;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2BD5A4", Offset = "0x2BD5A4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD5A4", Offset = "0x2BD5A4")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD618", Offset = "0x2BD618")]
		public float maxRadiansDelta;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD64C", Offset = "0x2BD64C")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD6B8", Offset = "0x2BD6B8")]
		public float slerpSpeed;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD70C", Offset = "0x2BD70C")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD740", Offset = "0x2BD740")]
		public float minDistance;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD774", Offset = "0x2BD774")]
		public Vector3 offset;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2BD7A8", Offset = "0x2BD7A8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD7A8", Offset = "0x2BD7A8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BD7A8", Offset = "0x2BD7A8")]
		public float maxRootAngle;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2BD82C", Offset = "0x2BD82C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD82C", Offset = "0x2BD82C")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD88C", Offset = "0x2BD88C")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastTarget;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float switchWeight;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float switchWeightV;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float weightV;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 dir;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x17000056")]
		private Vector3 pivot
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0xD07F74", Offset = "0xD07F74", VA = "0xD07F74")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xD07E1C", Offset = "0xD07E1C", VA = "0xD07E1C")]
		private void Start()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xD08108", Offset = "0xD08108", VA = "0xD08108")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xD08C00", Offset = "0xD08C00", VA = "0xD08C00")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xD08E00", Offset = "0xD08E00", VA = "0xD08E00")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xD0920C", Offset = "0xD0920C", VA = "0xD0920C")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E0")]
		public class Pose
		{
			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool visualize;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public string name;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 direction;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float yaw;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float pitch;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float angleBuffer;

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0xD096D0", Offset = "0xD096D0", VA = "0xD096D0")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0xD09B24", Offset = "0xD09B24", VA = "0xD09B24")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0xD09BAC", Offset = "0xD09BAC", VA = "0xD09BAC")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float angleBuffer;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Pose[] poses;

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xD09570", Offset = "0xD09570", VA = "0xD09570")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xD09A48", Offset = "0xD09A48", VA = "0xD09A48")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xD09B2C", Offset = "0xD09B2C", VA = "0xD09B2C")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E1")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000105")]
			public class EffectorLink
			{
				[Token(Token = "0x4000732")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2BE0", Offset = "0x2C2BE0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000733")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2C14", Offset = "0x2C2C14")]
				public float weight;

				[Token(Token = "0x600071D")]
				[Address(RVA = "0xD0A448", Offset = "0xD0A448", VA = "0xD0A448")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C18A4", Offset = "0x2C18A4")]
			public Transform transform;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C18FC", Offset = "0x2C18FC")]
			public Transform relativeTo;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1968", Offset = "0x2C1968")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C199C", Offset = "0x2C199C")]
			public float verticalWeight;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1A04", Offset = "0x2C1A04")]
			public float horizontalWeight;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1A38", Offset = "0x2C1A38")]
			public float speed;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool firstUpdate;

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0xD09D54", Offset = "0xD09D54", VA = "0xD09D54")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0xD0A3F4", Offset = "0xD0A3F4", VA = "0xD0A3F4")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0xD0A428", Offset = "0xD0A428", VA = "0xD0A428")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD8C0", Offset = "0x2BD8C0")]
		public Body[] bodies;

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xD09BD4", Offset = "0xD09BD4", VA = "0xD09BD4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xD0A3EC", Offset = "0xD0A3EC", VA = "0xD0A3EC")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD904", Offset = "0x2BD904")]
		public float tiltSpeed;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD944", Offset = "0x2BD944")]
		public float tiltSensitivity;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD988", Offset = "0x2BD988")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD9BC", Offset = "0x2BD9BC")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float tiltAngle;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xD0C2A0", Offset = "0xD0C2A0", VA = "0xD0C2A0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xD0C2FC", Offset = "0xD0C2FC", VA = "0xD0C2FC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xD0C5D4", Offset = "0xD0C5D4", VA = "0xD0C5D4")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E2")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1A90", Offset = "0x2C1A90")]
			public string name;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1AC4", Offset = "0x2C1AC4")]
			public Collider collider;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1AF8", Offset = "0x2C1AF8")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C1B40", Offset = "0x2C1B40")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C1B50", Offset = "0x2C1B50")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C1B60", Offset = "0x2C1B60")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C1B70", Offset = "0x2C1B70")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float length;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float crossFadeSpeed;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000A5")]
			public bool inProgress
			{
				[Token(Token = "0x60006A6")]
				[Address(RVA = "0x115DB54", Offset = "0x115DB54", VA = "0x115DB54")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A6")]
			protected float crossFader
			{
				[Token(Token = "0x60006A7")]
				[Address(RVA = "0x115E228", Offset = "0x115E228", VA = "0x115E228")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4EE8", Offset = "0x2C4EE8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006A8")]
				[Address(RVA = "0x115E230", Offset = "0x115E230", VA = "0x115E230")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4EF8", Offset = "0x2C4EF8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			protected float timer
			{
				[Token(Token = "0x60006A9")]
				[Address(RVA = "0x115E220", Offset = "0x115E220", VA = "0x115E220")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4F08", Offset = "0x2C4F08")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006AA")]
				[Address(RVA = "0x115E238", Offset = "0x115E238", VA = "0x115E238")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4F18", Offset = "0x2C4F18")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A8")]
			protected Vector3 force
			{
				[Token(Token = "0x60006AB")]
				[Address(RVA = "0x115E240", Offset = "0x115E240", VA = "0x115E240")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4F28", Offset = "0x2C4F28")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006AC")]
				[Address(RVA = "0x115E254", Offset = "0x115E254", VA = "0x115E254")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4F38", Offset = "0x2C4F38")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A9")]
			protected Vector3 point
			{
				[Token(Token = "0x60006AD")]
				[Address(RVA = "0x115E260", Offset = "0x115E260", VA = "0x115E260")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4F48", Offset = "0x2C4F48")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006AE")]
				[Address(RVA = "0x115E274", Offset = "0x115E274", VA = "0x115E274")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4F58", Offset = "0x2C4F58")]
				private set
				{
				}
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x115E0C0", Offset = "0x115E0C0", VA = "0x115E0C0")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x115DC98", Offset = "0x115DC98", VA = "0x115DC98")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006B1")]
			protected abstract float GetLength();

			[Token(Token = "0x60006B2")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60006B3")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x115E280", Offset = "0x115E280", VA = "0x115E280")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E3")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000106")]
			public class EffectorLink
			{
				[Token(Token = "0x4000734")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2C48", Offset = "0x2C2C48")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000735")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2C7C", Offset = "0x2C2C7C")]
				public float weight;

				[Token(Token = "0x4000736")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Vector3 lastValue;

				[Token(Token = "0x4000737")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Vector3 current;

				[Token(Token = "0x600071E")]
				[Address(RVA = "0x115EF10", Offset = "0x115EF10", VA = "0x115EF10")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600071F")]
				[Address(RVA = "0x115EC6C", Offset = "0x115EC6C", VA = "0x115EC6C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000720")]
				[Address(RVA = "0x115F30C", Offset = "0x115F30C", VA = "0x115F30C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1B80", Offset = "0x2C1B80")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1BB4", Offset = "0x2C1BB4")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1BE8", Offset = "0x2C1BE8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x115E9AC", Offset = "0x115E9AC", VA = "0x115E9AC", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x115EBF4", Offset = "0x115EBF4", VA = "0x115EBF4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x115EC80", Offset = "0x115EC80", VA = "0x115EC80", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x115F0B4", Offset = "0x115F0B4", VA = "0x115F0B4")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000107")]
			public class BoneLink
			{
				[Token(Token = "0x4000738")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2CB0", Offset = "0x2C2CB0")]
				public Transform bone;

				[Token(Token = "0x4000739")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2CE4", Offset = "0x2C2CE4")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C2CE4", Offset = "0x2C2CE4")]
				public float weight;

				[Token(Token = "0x400073A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Quaternion lastValue;

				[Token(Token = "0x400073B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private Quaternion current;

				[Token(Token = "0x6000721")]
				[Address(RVA = "0x115E70C", Offset = "0x115E70C", VA = "0x115E70C")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000722")]
				[Address(RVA = "0x115E3F0", Offset = "0x115E3F0", VA = "0x115E3F0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000723")]
				[Address(RVA = "0x115E8E4", Offset = "0x115E8E4", VA = "0x115E8E4")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1C40", Offset = "0x2C1C40")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1C74", Offset = "0x2C1C74")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x115E294", Offset = "0x115E294", VA = "0x115E294", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x115E378", Offset = "0x115E378", VA = "0x115E378", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x115E404", Offset = "0x115E404", VA = "0x115E404", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x115E8D0", Offset = "0x115E8D0", VA = "0x115E8D0")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BD9F0", Offset = "0x2BD9F0")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDA24", Offset = "0x2BDA24")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x17000057")]
		public bool inProgress
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x115DA5C", Offset = "0x115DA5C", VA = "0x115DA5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x115DB70", Offset = "0x115DB70", VA = "0x115DB70", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x115DE04", Offset = "0x115DE04", VA = "0x115DE04")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x115E218", Offset = "0x115E218", VA = "0x115E218")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000E5")]
		public abstract class Offset
		{
			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1CA8", Offset = "0x2C1CA8")]
			public string name;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1CDC", Offset = "0x2C1CDC")]
			public Collider collider;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1D10", Offset = "0x2C1D10")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C1D58", Offset = "0x2C1D58")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C1D68", Offset = "0x2C1D68")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C1D78", Offset = "0x2C1D78")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C1D88", Offset = "0x2C1D88")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float length;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float crossFadeSpeed;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000AA")]
			protected float crossFader
			{
				[Token(Token = "0x60006BD")]
				[Address(RVA = "0x115F9E8", Offset = "0x115F9E8", VA = "0x115F9E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4F68", Offset = "0x2C4F68")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006BE")]
				[Address(RVA = "0x115F9F0", Offset = "0x115F9F0", VA = "0x115F9F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4F78", Offset = "0x2C4F78")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AB")]
			protected float timer
			{
				[Token(Token = "0x60006BF")]
				[Address(RVA = "0x115F9F8", Offset = "0x115F9F8", VA = "0x115F9F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4F88", Offset = "0x2C4F88")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006C0")]
				[Address(RVA = "0x115FA00", Offset = "0x115FA00", VA = "0x115FA00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4F98", Offset = "0x2C4F98")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AC")]
			protected Vector3 force
			{
				[Token(Token = "0x60006C1")]
				[Address(RVA = "0x115FA08", Offset = "0x115FA08", VA = "0x115FA08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4FA8", Offset = "0x2C4FA8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006C2")]
				[Address(RVA = "0x115FA1C", Offset = "0x115FA1C", VA = "0x115FA1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4FB8", Offset = "0x2C4FB8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AD")]
			protected Vector3 point
			{
				[Token(Token = "0x60006C3")]
				[Address(RVA = "0x115FA28", Offset = "0x115FA28", VA = "0x115FA28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4FC8", Offset = "0x2C4FC8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006C4")]
				[Address(RVA = "0x115FA3C", Offset = "0x115FA3C", VA = "0x115FA3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4FD8", Offset = "0x2C4FD8")]
				private set
				{
				}
			}

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x115F880", Offset = "0x115F880", VA = "0x115F880")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x115F434", Offset = "0x115F434", VA = "0x115F434")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60006C7")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x60006C8")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60006C9")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x115FA48", Offset = "0x115FA48", VA = "0x115FA48")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E6")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000108")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x400073C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2D34", Offset = "0x2C2D34")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x400073D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2D68", Offset = "0x2C2D68")]
				public float weight;

				[Token(Token = "0x400073E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Vector3 lastValue;

				[Token(Token = "0x400073F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Vector3 current;

				[Token(Token = "0x6000724")]
				[Address(RVA = "0x1160114", Offset = "0x1160114", VA = "0x1160114")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000725")]
				[Address(RVA = "0x115FE08", Offset = "0x115FE08", VA = "0x115FE08")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000726")]
				[Address(RVA = "0x116029C", Offset = "0x116029C", VA = "0x116029C")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1D98", Offset = "0x2C1D98")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1DCC", Offset = "0x2C1DCC")]
			public int upDirCurveIndex;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1E00", Offset = "0x2C1E00")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x115FA5C", Offset = "0x115FA5C", VA = "0x115FA5C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x115FD90", Offset = "0x115FD90", VA = "0x115FD90", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x115FE1C", Offset = "0x115FE1C", VA = "0x115FE1C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x1160280", Offset = "0x1160280", VA = "0x1160280")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E7")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000109")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000740")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2D9C", Offset = "0x2C2D9C")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000741")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2DD0", Offset = "0x2C2DD0")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C2DD0", Offset = "0x2C2DD0")]
				public float weight;

				[Token(Token = "0x4000742")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Quaternion lastValue;

				[Token(Token = "0x4000743")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private Quaternion current;

				[Token(Token = "0x6000727")]
				[Address(RVA = "0x1160880", Offset = "0x1160880", VA = "0x1160880")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000728")]
				[Address(RVA = "0x1160480", Offset = "0x1160480", VA = "0x1160480")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000729")]
				[Address(RVA = "0x1160A38", Offset = "0x1160A38", VA = "0x1160A38")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1E60", Offset = "0x2C1E60")]
			public int curveIndex;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1E94", Offset = "0x2C1E94")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x11602A4", Offset = "0x11602A4", VA = "0x11602A4", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x1160408", Offset = "0x1160408", VA = "0x1160408", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x1160494", Offset = "0x1160494", VA = "0x1160494", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x1160A24", Offset = "0x1160A24", VA = "0x1160A24")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDA58", Offset = "0x2BDA58")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDA8C", Offset = "0x2BDA8C")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x115F314", Offset = "0x115F314", VA = "0x115F314", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x115F5AC", Offset = "0x115F5AC", VA = "0x115F5AC")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x115F9E0", Offset = "0x115F9E0", VA = "0x115F9E0")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E8")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x200010A")]
			public class EffectorLink
			{
				[Token(Token = "0x4000744")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2E20", Offset = "0x2C2E20")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000745")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2E54", Offset = "0x2C2E54")]
				public float weight;

				[Token(Token = "0x600072A")]
				[Address(RVA = "0xF6A89C", Offset = "0xF6A89C", VA = "0xF6A89C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1EC8", Offset = "0x2C1EC8")]
			public Transform transform;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1F30", Offset = "0x2C1F30")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1F64", Offset = "0x2C1F64")]
			public float speed;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C1FB4", Offset = "0x2C1FB4")]
			public float acceleration;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2018", Offset = "0x2C2018")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C2018", Offset = "0x2C2018")]
			public float matchVelocity;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C207C", Offset = "0x2C207C")]
			public float gravity;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 delta;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Vector3 direction;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 lastPosition;

			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private bool firstUpdate;

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0xF6A140", Offset = "0xF6A140", VA = "0xF6A140")]
			public void Reset()
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0xF6A35C", Offset = "0xF6A35C", VA = "0xF6A35C")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0xF6A874", Offset = "0xF6A874", VA = "0xF6A874")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDAC0", Offset = "0x2BDAC0")]
		public Body[] bodies;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDB00", Offset = "0x2BDB00")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xF6A0C0", Offset = "0xF6A0C0", VA = "0xF6A0C0")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xF6A288", Offset = "0xF6A288", VA = "0xF6A288", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xF6A86C", Offset = "0xF6A86C", VA = "0xF6A86C")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E9")]
		public class OffsetLimits
		{
			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C20C4", Offset = "0x2C20C4")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C211C", Offset = "0x2C211C")]
			public float spring;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2150", Offset = "0x2C2150")]
			public bool x;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2184", Offset = "0x2C2184")]
			public bool y;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C21B8", Offset = "0x2C21B8")]
			public bool z;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C21EC", Offset = "0x2C21EC")]
			public float minX;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2220", Offset = "0x2C2220")]
			public float maxX;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2254", Offset = "0x2C2254")]
			public float minY;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2288", Offset = "0x2C2288")]
			public float maxY;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C22BC", Offset = "0x2C22BC")]
			public float minZ;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C22F0", Offset = "0x2C22F0")]
			public float maxZ;

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x132FA20", Offset = "0x132FA20", VA = "0x132FA20")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x133016C", Offset = "0x133016C", VA = "0x133016C")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x13301C8", Offset = "0x13301C8", VA = "0x13301C8")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x13302CC", Offset = "0x13302CC", VA = "0x13302CC")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BA6FC", Offset = "0x2BA6FC")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000AE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006DD")]
				[Address(RVA = "0x13300D4", Offset = "0x13300D4", VA = "0x13300D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006DF")]
				[Address(RVA = "0x1330164", Offset = "0x1330164", VA = "0x1330164", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x132F7B4", Offset = "0x132F7B4", VA = "0x132F7B4")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x132FED4", Offset = "0x132FED4", VA = "0x132FED4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x132FED8", Offset = "0x132FED8", VA = "0x132FED8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x13300DC", Offset = "0x13300DC", VA = "0x13300DC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDB48", Offset = "0x2BDB48")]
		public float weight;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDB7C", Offset = "0x2BDB7C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected float lastTime;

		[Token(Token = "0x17000058")]
		protected float deltaTime
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x132F6DC", Offset = "0x132F6DC", VA = "0x132F6DC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000426")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x132F704", Offset = "0x132F704", VA = "0x132F704", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x132F728", Offset = "0x132F728", VA = "0x132F728")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2C4890", Offset = "0x2C4890")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x132F7D4", Offset = "0x132F7D4", VA = "0x132F7D4")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x132F91C", Offset = "0x132F91C", VA = "0x132F91C")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x132FD1C", Offset = "0x132FD1C", VA = "0x132FD1C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x132FEC4", Offset = "0x132FEC4", VA = "0x132FEC4")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BA70C", Offset = "0x2BA70C")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000B0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006E3")]
				[Address(RVA = "0x13308CC", Offset = "0x13308CC", VA = "0x13308CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006E5")]
				[Address(RVA = "0x133095C", Offset = "0x133095C", VA = "0x133095C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x13303AC", Offset = "0x13303AC", VA = "0x13303AC")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x13306CC", Offset = "0x13306CC", VA = "0x13306CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x13306D0", Offset = "0x13306D0", VA = "0x13306D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x13308D4", Offset = "0x13308D4", VA = "0x13308D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDBCC", Offset = "0x2BDBCC")]
		public float weight;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDC00", Offset = "0x2BDC00")]
		public VRIK ik;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float lastTime;

		[Token(Token = "0x17000059")]
		protected float deltaTime
		{
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x13302D4", Offset = "0x13302D4", VA = "0x13302D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600042E")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x13302FC", Offset = "0x13302FC", VA = "0x13302FC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1330320", Offset = "0x1330320", VA = "0x1330320")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2C4908", Offset = "0x2C4908")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x13303CC", Offset = "0x13303CC", VA = "0x13303CC")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1330514", Offset = "0x1330514", VA = "0x1330514", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x13306BC", Offset = "0x13306BC", VA = "0x13306BC")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000EC")]
		public class EffectorLink
		{
			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 offset;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 pin;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 pinWeight;

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x1330A5C", Offset = "0x1330A5C", VA = "0x1330A5C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x1331034", Offset = "0x1331034", VA = "0x1331034")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1330964", Offset = "0x1330964", VA = "0x1330964")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1330EFC", Offset = "0x1330EFC", VA = "0x1330EFC")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1330FC0", Offset = "0x1330FC0", VA = "0x1330FC0")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000ED")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x200010B")]
			public class EffectorLink
			{
				[Token(Token = "0x4000746")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2E88", Offset = "0x2C2E88")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000747")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2EBC", Offset = "0x2C2EBC")]
				public float weight;

				[Token(Token = "0x600072B")]
				[Address(RVA = "0x1335558", Offset = "0x1335558", VA = "0x1335558")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2324", Offset = "0x2C2324")]
			public Vector3 offset;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2390", Offset = "0x2C2390")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C2390", Offset = "0x2C2390")]
			public float additivity;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C23E0", Offset = "0x2C23E0")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2434", Offset = "0x2C2434")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x13339C0", Offset = "0x13339C0", VA = "0x13339C0")]
			public void Start()
			{
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x1334B18", Offset = "0x1334B18", VA = "0x1334B18")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x133553C", Offset = "0x133553C", VA = "0x133553C")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EE")]
		public enum Handedness
		{
			[Token(Token = "0x40006BA")]
			Right,
			[Token(Token = "0x40006BB")]
			Left
		}

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDC4C", Offset = "0x2BDC4C")]
		public AimIK aimIK;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDC80", Offset = "0x2BDC80")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDCB4", Offset = "0x2BDCB4")]
		public Handedness handedness;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDD04", Offset = "0x2BDD04")]
		public bool twoHanded;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDD4C", Offset = "0x2BDD4C")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDD80", Offset = "0x2BDD80")]
		public float magnitudeRandom;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDDB4", Offset = "0x2BDDB4")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDE20", Offset = "0x2BDE20")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDE8C", Offset = "0x2BDE8C")]
		public float blendTime;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x2BDEF8", Offset = "0x2BDEF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDEF8", Offset = "0x2BDEF8")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float magnitudeMlp;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float endTime;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion handRotation;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion randomRotation;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float length;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool initiated;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float blendWeight;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float w;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool handRotationsSet;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x1700005A")]
		public bool isFinished
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x13336E0", Offset = "0x13336E0", VA = "0x13336E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x1334EA8", Offset = "0x1334EA8", VA = "0x1334EA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x1334EFC", Offset = "0x1334EFC", VA = "0x1334EFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		private Transform primaryHand
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x1334E58", Offset = "0x1334E58", VA = "0x1334E58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x1334E80", Offset = "0x1334E80", VA = "0x1334E80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1333714", Offset = "0x1333714", VA = "0x1333714")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x133376C", Offset = "0x133376C", VA = "0x133376C")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1333AAC", Offset = "0x1333AAC", VA = "0x1333AAC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1334F50", Offset = "0x1334F50", VA = "0x1334F50")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x13350E0", Offset = "0x13350E0", VA = "0x13350E0")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x133513C", Offset = "0x133513C", VA = "0x133513C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1335444", Offset = "0x1335444", VA = "0x1335444")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDF58", Offset = "0x2BDF58")]
		public float weight;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDFA0", Offset = "0x2BDFA0")]
		public float offset;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool skip;

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1339ED4", Offset = "0x1339ED4", VA = "0x1339ED4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x133A050", Offset = "0x133A050", VA = "0x133A050")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x133A1A4", Offset = "0x133A1A4", VA = "0x133A1A4")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x133A854", Offset = "0x133A854", VA = "0x133A854")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x133A8C0", Offset = "0x133A8C0", VA = "0x133A8C0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x133AA68", Offset = "0x133AA68", VA = "0x133AA68")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000EF")]
		public class Settings
		{
			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2490", Offset = "0x2C2490")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C24E4", Offset = "0x2C24E4")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2534", Offset = "0x2C2534")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2568", Offset = "0x2C2568")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C25D0", Offset = "0x2C25D0")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2604", Offset = "0x2C2604")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2638", Offset = "0x2C2638")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C266C", Offset = "0x2C266C")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x2C26D4", Offset = "0x2C26D4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C26D4", Offset = "0x2C26D4")]
			public Vector3 headOffset;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2724", Offset = "0x2C2724")]
			public Vector3 handOffset;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2758", Offset = "0x2C2758")]
			public float footForwardOffset;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C27C0", Offset = "0x2C27C0")]
			public float footInwardOffset;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2824", Offset = "0x2C2824")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2C2824", Offset = "0x2C2824")]
			public float footHeadingOffset;

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x13403BC", Offset = "0x13403BC", VA = "0x13403BC")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x133D80C", Offset = "0x133D80C", VA = "0x133D80C")]
		public static void Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x133F728", Offset = "0x133F728", VA = "0x133F728")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x200006A")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AimIK aimIK;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform pin;

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xBE2A38", Offset = "0xBE2A38", VA = "0xBE2A38")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xBE2B30", Offset = "0xBE2B30", VA = "0xBE2B30")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AimIK ik;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BDFD4", Offset = "0x2BDFD4")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xBE2B38", Offset = "0xBE2B38", VA = "0xBE2B38")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xBE2CC8", Offset = "0xBE2CC8", VA = "0xBE2CC8")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE008", Offset = "0x2BE008")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE03C", Offset = "0x2BE03C")]
		public AimIK aim;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE070", Offset = "0x2BE070")]
		public LookAtIK lookAt;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE0A4", Offset = "0x2BE0A4")]
		public Animator animator;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE0F8", Offset = "0x2BE0F8")]
		public float crossfadeTime;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE14C", Offset = "0x2BE14C")]
		public float minAimDistance;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xBFB3CC", Offset = "0xBFB3CC", VA = "0xBFB3CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xBFB424", Offset = "0xBFB424", VA = "0xBFB424")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xBFB5F0", Offset = "0xBFB5F0", VA = "0xBFB5F0")]
		private void Pose()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xBFB8CC", Offset = "0xBFB8CC", VA = "0xBFB8CC")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xBFBB7C", Offset = "0xBFBB7C", VA = "0xBFBB7C")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xBFBC8C", Offset = "0xBFBC8C", VA = "0xBFBC8C")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AimIK aimIK;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float min;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float max;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float lerpSpeed;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private RaycastHit hit;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 offset;

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xD03EBC", Offset = "0xD03EBC", VA = "0xD03EBC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xD041E4", Offset = "0xD041E4", VA = "0xD041E4")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xD044A8", Offset = "0xD044A8", VA = "0xD044A8")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2BE1A0", Offset = "0x2BE1A0")]
		public Animator animator;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BipedIK bipedIK;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2BE1D4", Offset = "0x2BE1D4")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BE208", Offset = "0x2BE208")]
		public float lookAtWeight;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BE220", Offset = "0x2BE220")]
		public float lookAtBodyWeight;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BE238", Offset = "0x2BE238")]
		public float lookAtHeadWeight;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BE250", Offset = "0x2BE250")]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BE268", Offset = "0x2BE268")]
		public float lookAtClampWeight;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BE280", Offset = "0x2BE280")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BE298", Offset = "0x2BE298")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2BE2B0", Offset = "0x2BE2B0")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BE2E4", Offset = "0x2BE2E4")]
		public float footPositionWeight;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BE2FC", Offset = "0x2BE2FC")]
		public float footRotationWeight;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2BE314", Offset = "0x2BE314")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BE348", Offset = "0x2BE348")]
		public float handPositionWeight;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BE360", Offset = "0x2BE360")]
		public float handRotationWeight;

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xBE55EC", Offset = "0xBE55EC", VA = "0xBE55EC")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xBE5F38", Offset = "0xBE5F38", VA = "0xBE5F38")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float scale;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform body;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float legRotationWeight;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rootPositionSpeed;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float breatheSpeed;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float breatheMagnitude;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float height;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minHeight;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float raycastHeight;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float raycastDistance;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float sine;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private RaycastHit rootHit;

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xBF38A8", Offset = "0xBF38A8", VA = "0xBF38A8")]
		private void Update()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xBF4644", Offset = "0xBF4644", VA = "0xBF4644")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xBF41F8", Offset = "0xBF41F8", VA = "0xBF41F8")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xBF4888", Offset = "0xBF4888", VA = "0xBF4888")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public MechSpider mechSpider;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform cameraTransform;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float speed;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float turnSpeed;

		[Token(Token = "0x1700005F")]
		public Vector3 inputVector
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0xBF48E8", Offset = "0xBF48E8", VA = "0xBF48E8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xBF4998", Offset = "0xBF4998", VA = "0xBF4998")]
		private void Update()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xBF4D08", Offset = "0xBF4D08", VA = "0xBF4D08")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BA71C", Offset = "0x2BA71C")]
		private sealed class <Step>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000B2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006EF")]
				[Address(RVA = "0xBF5E0C", Offset = "0xBF5E0C", VA = "0xBF5E0C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006F1")]
				[Address(RVA = "0xBF5E9C", Offset = "0xBF5E9C", VA = "0xBF5E9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0xBF596C", Offset = "0xBF596C", VA = "0xBF596C")]
			[DebuggerHidden]
			public <Step>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0xBF59D8", Offset = "0xBF59D8", VA = "0xBF59D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0xBF59DC", Offset = "0xBF59DC", VA = "0xBF59DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0xBF5E14", Offset = "0xBF5E14", VA = "0xBF5E14", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 offset;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minDelay;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float maxOffset;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float stepSpeed;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float footHeight;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float velocityPrediction;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float raycastFocus;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve yOffset;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public ParticleSystem sand;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IK ik;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float stepProgress;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastStepTime;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RaycastHit hit;

		[Token(Token = "0x17000060")]
		public bool isStepping
		{
			[Token(Token = "0x6000461")]
			[Address(RVA = "0xBF4D28", Offset = "0xBF4D28", VA = "0xBF4D28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000061")]
		public Vector3 position
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0xBF4820", Offset = "0xBF4820", VA = "0xBF4820")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000463")]
			[Address(RVA = "0xBF4D44", Offset = "0xBF4D44", VA = "0xBF4D44")]
			set
			{
			}
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xBF4DBC", Offset = "0xBF4DBC", VA = "0xBF4DBC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xBF505C", Offset = "0xBF505C", VA = "0xBF505C")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xBF55B8", Offset = "0xBF55B8", VA = "0xBF55B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xBF5884", Offset = "0xBF5884", VA = "0xBF5884")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2C4980", Offset = "0x2C4980")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xBF5990", Offset = "0xBF5990", VA = "0xBF5990")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ParticleSystem particles;

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xBF5EA4", Offset = "0xBF5EA4", VA = "0xBF5EA4")]
		private void Start()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xBF5FD4", Offset = "0xBF5FD4", VA = "0xBF5FD4")]
		private void Update()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xBF6364", Offset = "0xBF6364", VA = "0xBF6364")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000F1")]
		public struct Warp
		{
			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C28B4", Offset = "0x2C28B4")]
			public int animationLayer;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2910", Offset = "0x2C2910")]
			public string animationState;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2968", Offset = "0x2C2968")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C29D0", Offset = "0x2C29D0")]
			public Transform warpFrom;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2A04", Offset = "0x2C2A04")]
			public Transform warpTo;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2A50", Offset = "0x2C2A50")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000F2")]
		public enum EffectorMode
		{
			[Token(Token = "0x40006D5")]
			PositionOffset,
			[Token(Token = "0x40006D6")]
			Position
		}

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE378", Offset = "0x2BE378")]
		public Animator animator;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE3D0", Offset = "0x2BE3D0")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x2BE404", Offset = "0x2BE404")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE404", Offset = "0x2BE404")]
		public Warp[] warps;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private EffectorMode lastMode;

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xBE2D6C", Offset = "0xBE2D6C", VA = "0xBE2D6C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xBE2D8C", Offset = "0xBE2D8C", VA = "0xBE2D8C")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xBE30A4", Offset = "0xBE30A4", VA = "0xBE30A4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xBE36B0", Offset = "0xBE36B0", VA = "0xBE36B0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xBE3778", Offset = "0xBE3778", VA = "0xBE3778")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2BA000", Offset = "0x2BA000")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float rotateSpeed;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float blendSpeed;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maxAngle;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float moveSpeed;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rootMotionWeight;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Animator animator;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		protected Vector3 moveBlend;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Vector3 moveInput;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected Vector3 velocity;

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xBE3780", Offset = "0xBE3780", VA = "0xBE3780", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xBE37E8", Offset = "0xBE37E8", VA = "0xBE37E8")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xBE3A98", Offset = "0xBE3A98", VA = "0xBE3A98", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xBE3E00", Offset = "0xBE3E00", VA = "0xBE3E00")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2BA078", Offset = "0x2BA078")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2BA078", Offset = "0x2BA078")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BE488", Offset = "0x2BE488")]
		public float headLookWeight;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Recoil recoil;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AimIK aim;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 headLookAxis;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 aimTarget;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xBE3E28", Offset = "0xBE3E28", VA = "0xBE3E28", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xBE40F0", Offset = "0xBE40F0", VA = "0xBE40F0", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xBE4170", Offset = "0xBE4170", VA = "0xBE4170")]
		private void Read()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xBE43AC", Offset = "0xBE43AC", VA = "0xBE43AC")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xBE4428", Offset = "0xBE4428", VA = "0xBE4428")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xBE4D80", Offset = "0xBE4D80", VA = "0xBE4D80")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xBE4AA0", Offset = "0xBE4AA0", VA = "0xBE4AA0")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xBE5218", Offset = "0xBE5218", VA = "0xBE5218")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xBE53C0", Offset = "0xBE53C0", VA = "0xBE53C0")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2BA11C", Offset = "0x2BA11C")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xBE75F0", Offset = "0xBE75F0", VA = "0xBE75F0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xBE7660", Offset = "0xBE7660", VA = "0xBE7660", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xBE79D0", Offset = "0xBE79D0", VA = "0xBE79D0")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xBE7BC0", Offset = "0xBE7BC0", VA = "0xBE7BC0")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2BA194", Offset = "0x2BA194")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private CameraController cam;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x17000062")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0xBE8E64", Offset = "0xBE8E64", VA = "0xBE8E64")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000063")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0xBE8F14", Offset = "0xBE8F14", VA = "0xBE8F14")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xBE8AC0", Offset = "0xBE8AC0", VA = "0xBE8AC0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xBE8B4C", Offset = "0xBE8B4C", VA = "0xBE8B4C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xBE8FC4", Offset = "0xBE8FC4", VA = "0xBE8FC4")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BE4B0", Offset = "0x2BE4B0")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 bodyOffset;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xBEC38C", Offset = "0xBEC38C", VA = "0xBEC38C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xBECE20", Offset = "0xBECE20", VA = "0xBECE20")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public SimpleLocomotion character;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float forceMlp;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float upForce;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weightFalloffSpeed;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public AnimationCurve scale;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float weight;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 defaultScale;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody r;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xBECE28", Offset = "0xBECE28", VA = "0xBECE28")]
		private void Start()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xBECF18", Offset = "0xBECF18", VA = "0xBECF18")]
		private void Update()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xBED6A8", Offset = "0xBED6A8", VA = "0xBED6A8")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xBED7F8", Offset = "0xBED7F8", VA = "0xBED7F8")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F3")]
		public class Limb
		{
			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float mappingWeight;

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0xBEDAF4", Offset = "0xBEDAF4", VA = "0xBEDAF4")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0xBEDC88", Offset = "0xBEDC88", VA = "0xBEDC88")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool disableAfterStart;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Limb leftArm;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Limb rightArm;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Limb leftLeg;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Limb rightLeg;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rootPin;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xBED8AC", Offset = "0xBED8AC", VA = "0xBED8AC")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xBEDBC0", Offset = "0xBEDBC0", VA = "0xBEDBC0")]
		private void Start()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xBEDC74", Offset = "0xBEDC74", VA = "0xBEDC74")]
		private void Update()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xBEDC78", Offset = "0xBEDC78", VA = "0xBEDC78")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float weight;

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xBEDC98", Offset = "0xBEDC98", VA = "0xBEDC98")]
		private void Start()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xBEDD24", Offset = "0xBEDD24", VA = "0xBEDD24")]
		private void Update()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xBEDE74", Offset = "0xBEDE74", VA = "0xBEDE74")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE4C8", Offset = "0x2BE4C8")]
		public Transform target;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE510", Offset = "0x2BE510")]
		public Transform pin;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE544", Offset = "0x2BE544")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE594", Offset = "0x2BE594")]
		public AimIK aim;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE5C8", Offset = "0x2BE5C8")]
		public float weight;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE5FC", Offset = "0x2BE5FC")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE650", Offset = "0x2BE650")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator animator;

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xBEDE7C", Offset = "0xBEDE7C", VA = "0xBEDE7C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xBEDEE4", Offset = "0xBEDEE4", VA = "0xBEDEE4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xBEE1D0", Offset = "0xBEE1D0", VA = "0xBEE1D0")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool leftHanded;

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xBEE1D8", Offset = "0xBEE1D8", VA = "0xBEE1D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xBEE338", Offset = "0xBEE338", VA = "0xBEE338")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xBEE40C", Offset = "0xBEE40C", VA = "0xBEE40C")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xBEEAB8", Offset = "0xBEEAB8", VA = "0xBEEAB8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xBEEC60", Offset = "0xBEEC60", VA = "0xBEEC60")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BE6AC", Offset = "0x2BE6AC")]
		public float aimWeight;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BE6C4", Offset = "0x2BE6C4")]
		public float sightWeight;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BE6DC", Offset = "0x2BE6DC")]
		public float maxAngle;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform gunTarget;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AimIK gunAim;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Recoil recoil;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BE768", Offset = "0x2BE768")]
		private float cameraRecoilWeight;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool updateFrame;

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xBEEC68", Offset = "0xBEEC68", VA = "0xBEEC68")]
		private void Start()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xBEEEA4", Offset = "0xBEEEA4", VA = "0xBEEEA4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xBEEEB0", Offset = "0xBEEEB0", VA = "0xBEEEB0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xBEF388", Offset = "0xBEF388", VA = "0xBEF388")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xBEF628", Offset = "0xBEF628", VA = "0xBEF628")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xBEF008", Offset = "0xBEF008", VA = "0xBEF008")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xBF07A4", Offset = "0xBF07A4", VA = "0xBF07A4")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2BA20C", Offset = "0x2BA20C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2BA20C", Offset = "0x2BA20C")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BE7A0", Offset = "0x2BE7A0")]
		public float walkSpeed;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float sVel;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Animator animator;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xBF07CC", Offset = "0xBF07CC", VA = "0xBF07CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xBF0850", Offset = "0xBF0850", VA = "0xBF0850")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xBF0A00", Offset = "0xBF0A00", VA = "0xBF0A00")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xBF0AE4", Offset = "0xBF0AE4", VA = "0xBF0AE4")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private HitReaction hitReaction;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private string colliderName;

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xBF0CF8", Offset = "0xBF0CF8", VA = "0xBF0CF8")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xBF0F3C", Offset = "0xBF0F3C", VA = "0xBF0F3C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xBF1028", Offset = "0xBF1028", VA = "0xBF1028")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform rightHandTarget;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftHandTarget;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float crossFade;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speed;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xBF1378", Offset = "0xBF1378", VA = "0xBF1378")]
		private void Start()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xBF15F0", Offset = "0xBF15F0", VA = "0xBF15F0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xBF1C10", Offset = "0xBF1C10", VA = "0xBF1C10")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public InteractionSystem character1;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractionSystem character2;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public InteractionObject handShake;

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xBF1C24", Offset = "0xBF1C24", VA = "0xBF1C24")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xBF1D14", Offset = "0xBF1D14", VA = "0xBF1D14")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xBF1F34", Offset = "0xBF1F34", VA = "0xBF1F34")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool interrupt;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public InteractionObject ball;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionObject benchMain;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public InteractionObject benchHands;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionObject button;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public InteractionObject cigarette;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject door;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool isSitting;

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xBF1F3C", Offset = "0xBF1F3C", VA = "0xBF1F3C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xBF2498", Offset = "0xBF2498", VA = "0xBF2498")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2BA2B0", Offset = "0x2BA2B0")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE7D8", Offset = "0x2BE7D8")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE834", Offset = "0x2BE834")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xBF24A0", Offset = "0xBF24A0", VA = "0xBF24A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xBF2508", Offset = "0xBF2508", VA = "0xBF2508")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xBF2808", Offset = "0xBF2808", VA = "0xBF2808")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F4")]
		public class Partner
		{
			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Transform mouth;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform mouthTarget;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float bodyWeightVertical;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float neckRotationWeight;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float headTiltAngle;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000B4")]
			private Transform neck
			{
				[Token(Token = "0x60006F6")]
				[Address(RVA = "0xBF37A4", Offset = "0xBF37A4", VA = "0xBF37A4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0xBF2858", Offset = "0xBF2858", VA = "0xBF2858")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0xBF2908", Offset = "0xBF2908", VA = "0xBF2908")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0xBF3510", Offset = "0xBF3510", VA = "0xBF3510")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0xBF3880", Offset = "0xBF3880", VA = "0xBF3880")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Partner partner1;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Partner partner2;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float weight;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int iterations;

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xBF2810", Offset = "0xBF2810", VA = "0xBF2810")]
		private void Start()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xBF2888", Offset = "0xBF2888", VA = "0xBF2888")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xBF3500", Offset = "0xBF3500", VA = "0xBF3500")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000F5")]
		public enum Mode
		{
			[Token(Token = "0x40006E6")]
			Position,
			[Token(Token = "0x40006E7")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x20000F6")]
		public class Absorber
		{
			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2A9C", Offset = "0x2C2A9C")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2C2AD0", Offset = "0x2C2AD0")]
			public float weight;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector3 position;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion rotation;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private IKEffector e;

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0xBF65A8", Offset = "0xBF65A8", VA = "0xBF65A8")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0xBF68B8", Offset = "0xBF68B8", VA = "0xBF68B8")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0xBF6914", Offset = "0xBF6914", VA = "0xBF6914")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0xBF6B6C", Offset = "0xBF6B6C", VA = "0xBF6B6C")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0xBF6E8C", Offset = "0xBF6E8C", VA = "0xBF6E8C")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE894", Offset = "0x2BE894")]
		public Mode mode;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE8C8", Offset = "0x2BE8C8")]
		public Absorber[] absorbers;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE914", Offset = "0x2BE914")]
		public AnimationCurve falloff;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE948", Offset = "0x2BE948")]
		public float falloffSpeed;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float timer;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float w;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Mode initialMode;

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xBF636C", Offset = "0xBF636C", VA = "0xBF636C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xBF64E0", Offset = "0xBF64E0", VA = "0xBF64E0")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xBF6720", Offset = "0xBF6720", VA = "0xBF6720", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xBF6AAC", Offset = "0xBF6AAC", VA = "0xBF6AAC")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xBF6CC8", Offset = "0xBF6CC8", VA = "0xBF6CC8", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xBF6E7C", Offset = "0xBF6E7C", VA = "0xBF6E7C")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Animator animator;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform cube;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xBF6F40", Offset = "0xBF6F40", VA = "0xBF6F40")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xBF6FF4", Offset = "0xBF6FF4", VA = "0xBF6FF4")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xBF70CC", Offset = "0xBF70CC", VA = "0xBF70CC")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xBF72A8", Offset = "0xBF72A8", VA = "0xBF72A8")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000F7")]
		public class EffectorLink
		{
			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float weightMultiplier;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0xBF77B8", Offset = "0xBF77B8", VA = "0xBF77B8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xBF72BC", Offset = "0xBF72BC", VA = "0xBF72BC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xBF7464", Offset = "0xBF7464", VA = "0xBF7464", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xBF77B0", Offset = "0xBF77B0", VA = "0xBF77B0")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2BA328", Offset = "0x2BA328")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE97C", Offset = "0x2BE97C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BE97C", Offset = "0x2BE97C")]
		public float weight;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BE9E8", Offset = "0x2BE9E8")]
		public float hangingDistanceMlp;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BEA4C", Offset = "0x2BEA4C")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BEA94", Offset = "0x2BEA94")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Transform leftHandTarget;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform rightHandTarget;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Transform leftFootTarget;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Transform headTarget;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float lastWeight;

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xBF77C8", Offset = "0xBF77C8", VA = "0xBF77C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xBF7CB4", Offset = "0xBF7CB4", VA = "0xBF7CB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xBF8818", Offset = "0xBF8818", VA = "0xBF8818")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public InteractionObject obj;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pivot;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Transform holdPoint;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float pickUpTime;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float holdWeight;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float holdWeightVel;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x17000064")]
		private bool holding
		{
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0xBF8AB0", Offset = "0xBF8AB0", VA = "0xBF8AB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xBF88D0", Offset = "0xBF88D0", VA = "0xBF88D0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004C9")]
		protected abstract void RotatePivot();

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xBF8AE0", Offset = "0xBF8AE0", VA = "0xBF8AE0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xBF8E0C", Offset = "0xBF8E0C", VA = "0xBF8E0C")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xBF906C", Offset = "0xBF906C", VA = "0xBF906C")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xBF91A0", Offset = "0xBF91A0", VA = "0xBF91A0")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xBF9350", Offset = "0xBF9350", VA = "0xBF9350")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xBF95D8", Offset = "0xBF95D8", VA = "0xBF95D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xBF994C", Offset = "0xBF994C", VA = "0xBF994C")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xBF9960", Offset = "0xBF9960", VA = "0xBF9960", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xBF9C50", Offset = "0xBF9C50", VA = "0xBF9C50")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xBF9C64", Offset = "0xBF9C64", VA = "0xBF9C64", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xBF9F1C", Offset = "0xBF9F1C", VA = "0xBF9F1C")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Rigidbody pelvis;

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xBFA9B8", Offset = "0xBFA9B8", VA = "0xBFA9B8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xBFAA30", Offset = "0xBFAA30", VA = "0xBFAA30")]
		private void Update()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xBFAC8C", Offset = "0xBFAC8C", VA = "0xBFAC8C")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2BA3A0", Offset = "0x2BA3A0")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float magnitude;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Recoil recoil;

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xBFAC94", Offset = "0xBFAC94", VA = "0xBFAC94")]
		private void Start()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xBFACFC", Offset = "0xBFACFC", VA = "0xBFACFC")]
		private void Update()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xBFAD68", Offset = "0xBFAD68", VA = "0xBFAD68")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xBFADE0", Offset = "0xBFADE0", VA = "0xBFADE0")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BA72C", Offset = "0x2BA72C")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float resetTime;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000B5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000702")]
				[Address(RVA = "0xBFB334", Offset = "0xBFB334", VA = "0xBFB334", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000704")]
				[Address(RVA = "0xBFB3C4", Offset = "0xBFB3C4", VA = "0xBFB3C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0xBFB010", Offset = "0xBFB010", VA = "0xBFB010")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0xBFB040", Offset = "0xBFB040", VA = "0xBFB040", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0xBFB044", Offset = "0xBFB044", VA = "0xBFB044", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0xBFB33C", Offset = "0xBFB33C", VA = "0xBFB33C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float resetDelay;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Transform defaultParent;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xBFADF0", Offset = "0xBFADF0", VA = "0xBFADF0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xBFAF14", Offset = "0xBFAF14", VA = "0xBFAF14")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xBFAF5C", Offset = "0xBFAF5C", VA = "0xBFAF5C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2C49F8", Offset = "0x2C49F8")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xBFB030", Offset = "0xBFB030", VA = "0xBFB030")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2BA418", Offset = "0x2BA418")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x20000F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BA73C", Offset = "0x2BA73C")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000B7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000708")]
				[Address(RVA = "0xD03E24", Offset = "0xD03E24", VA = "0xD03E24", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600070A")]
				[Address(RVA = "0xD03EB4", Offset = "0xD03EB4", VA = "0xD03EB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0xD03C28", Offset = "0xD03C28", VA = "0xD03C28")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000706")]
			[Address(RVA = "0xD03C50", Offset = "0xD03C50", VA = "0xD03C50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0xD03C54", Offset = "0xD03C54", VA = "0xD03C54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0xD03E2C", Offset = "0xD03E2C", VA = "0xD03E2C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Animator animator;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xD03A90", Offset = "0xD03A90", VA = "0xD03A90")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xD03B9C", Offset = "0xD03B9C", VA = "0xD03B9C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2C4A70", Offset = "0x2C4A70")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xD03C48", Offset = "0xD03C48", VA = "0xD03C48")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FA")]
		public class EffectorLink
		{
			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool enabled;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InteractionObject interactionObject;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Transform spherecastFrom;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float spherecastRadius;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float minDistance;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LayerMask touchLayers;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float lerpSpeed;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float minSwitchTime;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float releaseDistance;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool sliding;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float raycastDistance;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private bool inTouch;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private RaycastHit hit;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private bool initiated;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private float nextSwitchTime;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private float speedF;

			[Token(Token = "0x600070B")]
			[Address(RVA = "0xD0459C", Offset = "0xD0459C", VA = "0xD0459C")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0xD059FC", Offset = "0xD059FC", VA = "0xD059FC")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0xD04BC4", Offset = "0xD04BC4", VA = "0xD04BC4")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0xD05AE0", Offset = "0xD05AE0", VA = "0xD05AE0")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0xD05CFC", Offset = "0xD05CFC", VA = "0xD05CFC")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0xD05DA8", Offset = "0xD05DA8", VA = "0xD05DA8")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0xD05E54", Offset = "0xD05E54", VA = "0xD05E54")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0xD056C4", Offset = "0xD056C4", VA = "0xD056C4")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0xD05F00", Offset = "0xD05F00", VA = "0xD05F00")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xD04520", Offset = "0xD04520", VA = "0xD04520")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xD04B30", Offset = "0xD04B30", VA = "0xD04B30")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xD055AC", Offset = "0xD055AC", VA = "0xD055AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xD059F4", Offset = "0xD059F4", VA = "0xD059F4")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BEB7C", Offset = "0x2BEB7C")]
		public Transform to;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BEBD0", Offset = "0x2BEBD0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BEBD0", Offset = "0x2BEBD0")]
		public float transferMotion;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Vector3 lastPosition;

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xD05F48", Offset = "0xD05F48", VA = "0xD05F48")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xD05F98", Offset = "0xD05F98", VA = "0xD05F98")]
		private void Update()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xD06150", Offset = "0xD06150", VA = "0xD06150")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BEC3C", Offset = "0x2BEC3C")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xD06378", Offset = "0xD06378", VA = "0xD06378")]
		private void Start()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xD06668", Offset = "0xD06668", VA = "0xD06668")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xD06B04", Offset = "0xD06B04", VA = "0xD06B04")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xD06CC0", Offset = "0xD06CC0", VA = "0xD06CC0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xD06E68", Offset = "0xD06E68", VA = "0xD06E68")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float enableInputAtProgress;

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xD07144", Offset = "0xD07144", VA = "0xD07144", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xD07738", Offset = "0xD07738", VA = "0xD07738")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xD07928", Offset = "0xD07928", VA = "0xD07928")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public GameObject[] characters;

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xBF0AF4", Offset = "0xBF0AF4", VA = "0xBF0AF4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xBF0C50", Offset = "0xBF0C50", VA = "0xBF0C50")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xBF0CF0", Offset = "0xBF0CF0", VA = "0xBF0CF0")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x20000FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BA74C", Offset = "0x2BA74C")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000717")]
				[Address(RVA = "0xBFA920", Offset = "0xBFA920", VA = "0xBFA920", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000719")]
				[Address(RVA = "0xBFA9B0", Offset = "0xBFA9B0", VA = "0xBFA9B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0xBFA41C", Offset = "0xBFA41C", VA = "0xBFA41C")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0xBFA700", Offset = "0xBFA700", VA = "0xBFA700", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0xBFA704", Offset = "0xBFA704", VA = "0xBFA704", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000718")]
			[Address(RVA = "0xBFA928", Offset = "0xBFA928", VA = "0xBFA928", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float maxAngle;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float switchRotationTime;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float random;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSpeed;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 movePosition;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float moveSpeed;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int characterLayer;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion targetRotation;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 targetPosition;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 velocity;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody r;

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xBF9F30", Offset = "0xBF9F30", VA = "0xBF9F30")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xBFA120", Offset = "0xBFA120", VA = "0xBFA120")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xBFA094", Offset = "0xBFA094", VA = "0xBFA094")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2C4AE8", Offset = "0x2C4AE8")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xBFA43C", Offset = "0xBFA43C", VA = "0xBFA43C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xBFA584", Offset = "0xBFA584", VA = "0xBFA584")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xBFA6C8", Offset = "0xBFA6C8", VA = "0xBFA6C8")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public LimbIK limbIK;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BECCC", Offset = "0x2BECCC")]
		public float weight;

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xBE5434", Offset = "0xBE5434", VA = "0xBE5434")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xBE54C0", Offset = "0xBE54C0", VA = "0xBE54C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xBE55DC", Offset = "0xBE55DC", VA = "0xBE55DC")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FC")]
		public class Part
		{
			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x600071A")]
			[Address(RVA = "0xD061E0", Offset = "0xD061E0", VA = "0xD061E0")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0xD06370", Offset = "0xD06370", VA = "0xD06370")]
			public Part()
			{
			}
		}

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform target;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Part[] parts;

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xD06164", Offset = "0xD06164", VA = "0xD06164")]
		private void Update()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xD06368", Offset = "0xD06368", VA = "0xD06368")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private HitReactionVRIK hitReaction;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private string colliderName;

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xBF1038", Offset = "0xBF1038", VA = "0xBF1038")]
		private void Update()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xBF127C", Offset = "0xBF127C", VA = "0xBF127C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xBF1368", Offset = "0xBF1368", VA = "0xBF1368")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BED04", Offset = "0x2BED04")]
		public VRIK ik;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BED60", Offset = "0x2BED60")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BEDB0", Offset = "0x2BEDB0")]
		public Transform headTracker;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BEDE8", Offset = "0x2BEDE8")]
		public Transform bodyTracker;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BEE1C", Offset = "0x2BEE1C")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BEE50", Offset = "0x2BEE50")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BEE84", Offset = "0x2BEE84")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BEEB8", Offset = "0x2BEEB8")]
		public Transform rightFootTracker;

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xD07988", Offset = "0xD07988", VA = "0xD07988")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xD079B4", Offset = "0xD079B4", VA = "0xD079B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2C4B60", Offset = "0x2C4B60")]
		private void Calibrate()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xD079FC", Offset = "0xD079FC", VA = "0xD079FC")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public VRIK ik;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vector3 lastPosition;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xD07A04", Offset = "0xD07A04", VA = "0xD07A04")]
		private void Start()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xD07A9C", Offset = "0xD07A9C", VA = "0xD07A9C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xD07D70", Offset = "0xD07D70", VA = "0xD07D70")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool smoothFollow;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float smoothFollowSpeed;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected bool animatePhysics;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 localPosition;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion localRotation;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion lastRotation;

		[Token(Token = "0x17000065")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0xBE5F9C", Offset = "0xBE5F9C", VA = "0xBE5F9C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xBE5F5C", Offset = "0xBE5F5C", VA = "0xBE5F5C", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xBE5FA4", Offset = "0xBE5FA4", VA = "0xBE5FA4")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xBE609C", Offset = "0xBE609C", VA = "0xBE609C", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xBE6420", Offset = "0xBE6420", VA = "0xBE6420", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xBE6794", Offset = "0xBE6794", VA = "0xBE6794", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xBE6430", Offset = "0xBE6430", VA = "0xBE6430")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xBE67A4", Offset = "0xBE67A4", VA = "0xBE67A4")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2BA490", Offset = "0x2BA490")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Animator animator;

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xBE67C0", Offset = "0xBE67C0", VA = "0xBE67C0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xBE6830", Offset = "0xBE6830", VA = "0xBE6830", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xBE6988", Offset = "0xBE6988", VA = "0xBE6988")]
		private void Update()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xBE6B98", Offset = "0xBE6B98", VA = "0xBE6B98")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2BA508", Offset = "0x2BA508")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2BEF4C", Offset = "0x2BEF4C")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		protected Animator animator;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 lastForward;

		[Token(Token = "0x400046F")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000470")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float deltaAngle;

		[Token(Token = "0x17000066")]
		public override bool animationGrounded
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0xBE6C9C", Offset = "0xBE6C9C", VA = "0xBE6C9C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xBE6BB4", Offset = "0xBE6BB4", VA = "0xBE6BB4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xBE6C68", Offset = "0xBE6C68", VA = "0xBE6C68", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xBE6DD4", Offset = "0xBE6DD4", VA = "0xBE6DD4", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xBE73A4", Offset = "0xBE73A4", VA = "0xBE73A4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xBE75B0", Offset = "0xBE75B0", VA = "0xBE75B0")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2BA580", Offset = "0x2BA580")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2BA580", Offset = "0x2BA580")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2BEF8C", Offset = "0x2BEF8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BEF8C", Offset = "0x2BEF8C")]
		public Transform gravityTarget;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BEFF4", Offset = "0x2BEFF4")]
		[SerializeField]
		protected float gravityMultiplier;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Rigidbody r;

		[Token(Token = "0x400047C")]
		protected const float half = 0.5f;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected float originalHeight;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 originalCenter;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x600051C")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xBE7C00", Offset = "0xBE7C00", VA = "0xBE7C00")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xBE7DC0", Offset = "0xBE7DC0", VA = "0xBE7DC0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xBE8004", Offset = "0xBE8004", VA = "0xBE8004", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xBE834C", Offset = "0xBE834C", VA = "0xBE834C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xBE8444", Offset = "0xBE8444", VA = "0xBE8444")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xBE86B8", Offset = "0xBE86B8", VA = "0xBE86B8")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xBE88DC", Offset = "0xBE88DC", VA = "0xBE88DC")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xBE8910", Offset = "0xBE8910", VA = "0xBE8910")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xBE8944", Offset = "0xBE8944", VA = "0xBE8944")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xBE8A88", Offset = "0xBE8A88", VA = "0xBE8A88")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x20000FD")]
		public enum MoveMode
		{
			[Token(Token = "0x4000711")]
			Directional,
			[Token(Token = "0x4000712")]
			Strafe
		}

		[Token(Token = "0x20000FE")]
		public struct AnimState
		{
			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;
		}

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2BF08C", Offset = "0x2BF08C")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public CameraController cam;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2BF0C0", Offset = "0x2BF0C0")]
		public MoveMode moveMode;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool smoothPhysics;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float smoothAccelerationTime;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float platformFriction;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float groundStickyEffect;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2BF0F8", Offset = "0x2BF0F8")]
		public bool lookInCameraDirection;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float turnSpeed;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2BF12C", Offset = "0x2BF12C")]
		public float airSpeed;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float airControl;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float jumpPower;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2BF16C", Offset = "0x2BF16C")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float wallRunMaxLength;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2BF1BC", Offset = "0x2BF1BC")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF1F4", Offset = "0x2BF1F4")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public AnimState animState;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected Vector3 moveDirection;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Animator animator;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 normal;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private RaycastHit hit;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private float jumpLeg;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private float jumpEndTime;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float forwardMlp;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private float groundDistance;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float lastAirTime;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private float stickyForce;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 wallNormal;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private float wallRunWeight;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private float lastWallRunWeight;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private bool fixedFrame;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private float wallRunEndTime;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private Vector3 gravity;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float velocityY;

		[Token(Token = "0x17000067")]
		public bool onGround
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0xBE8FCC", Offset = "0xBE8FCC", VA = "0xBE8FCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4B98", Offset = "0x2C4B98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000528")]
			[Address(RVA = "0xBE8FD4", Offset = "0xBE8FD4", VA = "0xBE8FD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4BA8", Offset = "0x2C4BA8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xBE8FDC", Offset = "0xBE8FDC", VA = "0xBE8FDC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xBE91A8", Offset = "0xBE91A8", VA = "0xBE91A8")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xBE923C", Offset = "0xBE923C", VA = "0xBE923C", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xBE9388", Offset = "0xBE9388", VA = "0xBE9388")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xBEA7C4", Offset = "0xBEA7C4", VA = "0xBEA7C4", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xBEAC58", Offset = "0xBEAC58", VA = "0xBEAC58", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xBE9AAC", Offset = "0xBE9AAC", VA = "0xBE9AAC")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xBEADA4", Offset = "0xBEADA4", VA = "0xBEADA4")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xBEB5BC", Offset = "0xBEB5BC", VA = "0xBEB5BC")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xBEA8D0", Offset = "0xBEA8D0", VA = "0xBEA8D0")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xBEB680", Offset = "0xBEB680", VA = "0xBEB680", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xBEBC4C", Offset = "0xBEBC4C", VA = "0xBEBC4C")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xBEBF30", Offset = "0xBEBF30", VA = "0xBEBF30", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xBEA254", Offset = "0xBEA254", VA = "0xBEA254")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xBEC1C8", Offset = "0xBEC1C8", VA = "0xBEC1C8")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2BA624", Offset = "0x2BA624")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FF")]
		public enum RotationMode
		{
			[Token(Token = "0x400071A")]
			Smooth,
			[Token(Token = "0x400071B")]
			Linear
		}

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BF204", Offset = "0x2BF204")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BF26C", Offset = "0x2BF26C")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BF2C8", Offset = "0x2BF2C8")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BF318", Offset = "0x2BF318")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BF360", Offset = "0x2BF360")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BF3BC", Offset = "0x2BF3BC")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF430", Offset = "0x2BF430")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator animator;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float speed;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float angleVel;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float speedVel;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private CharacterController characterController;

		[Token(Token = "0x17000068")]
		public bool isGrounded
		{
			[Token(Token = "0x6000538")]
			[Address(RVA = "0xD02D40", Offset = "0xD02D40", VA = "0xD02D40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4BB8", Offset = "0x2C4BB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000539")]
			[Address(RVA = "0xD02D48", Offset = "0xD02D48", VA = "0xD02D48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C4BC8", Offset = "0x2C4BC8")]
			private set
			{
			}
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xD02D50", Offset = "0xD02D50", VA = "0xD02D50")]
		private void Start()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xD02DF8", Offset = "0xD02DF8", VA = "0xD02DF8")]
		private void Update()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xD0371C", Offset = "0xD0371C", VA = "0xD0371C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xD02E6C", Offset = "0xD02E6C", VA = "0xD02E6C")]
		private void Rotate()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xD033A8", Offset = "0xD033A8", VA = "0xD033A8")]
		private void Move()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xD0376C", Offset = "0xD0376C", VA = "0xD0376C")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xD0389C", Offset = "0xD0389C", VA = "0xD0389C")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xD0394C", Offset = "0xD0394C", VA = "0xD0394C")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform moveTarget;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float stoppingDistance;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stoppingThreshold;

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xD06E70", Offset = "0xD06E70", VA = "0xD06E70", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xD07114", Offset = "0xD07114", VA = "0xD07114")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000100")]
		public struct State
		{
			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool walkByDefault;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public bool canCrouch;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public bool canJump;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public State state;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Transform cam;

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xD0794C", Offset = "0xD0794C", VA = "0xD0794C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xD072D8", Offset = "0xD072D8", VA = "0xD072D8", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xD07134", Offset = "0xD07134", VA = "0xD07134")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x6000547")]
		[Address(RVA = "0xBE53F0", Offset = "0xBE53F0", VA = "0xBE53F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xBE542C", Offset = "0xBE542C", VA = "0xBE542C")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xD03978", Offset = "0xD03978", VA = "0xD03978")]
		private void Update()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xD039A4", Offset = "0xD039A4", VA = "0xD039A4")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xD03A7C", Offset = "0xD03A7C", VA = "0xD03A7C")]
		public SlowMo()
		{
		}
	}
}
namespace IKINEMAClient
{
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2BA69C", Offset = "0x2BA69C")]
	public class IKINEMAVRPN : MonoBehaviour
	{
		[Token(Token = "0x40004CC")]
		public const string Version = "0.5";

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BF480", Offset = "0x2BF480")]
		public string SubjectName;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BF4D8", Offset = "0x2BF4D8")]
		public string ServerHost;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BF530", Offset = "0x2BF530")]
		public bool UpdateScaleFromStream;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2BF590", Offset = "0x2BF590")]
		public bool ApplyVerticalRotation;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2BF5C4", Offset = "0x2BF5C4")]
		public bool IsStreamYUp;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float InputScale;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected StreamCharacter m_client;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_isMetadataRead;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private uint m_rootId;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Transform> m_streamHierarchy;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion ZtoY;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion Vertical180;

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xBD43E8", Offset = "0xBD43E8", VA = "0xBD43E8")]
		public void Start()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xBD44CC", Offset = "0xBD44CC", VA = "0xBD44CC")]
		public void Update()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xBD49FC", Offset = "0xBD49FC", VA = "0xBD49FC")]
		private void ReadMetadata()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xBD44D0", Offset = "0xBD44D0", VA = "0xBD44D0")]
		private void UpdateTransformsFromStream()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xBD4D2C", Offset = "0xBD4D2C", VA = "0xBD4D2C")]
		private Dictionary<string, Transform> ReadGameObjectHierarchy()
		{
			return null;
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xBD5360", Offset = "0xBD5360", VA = "0xBD5360")]
		protected Vector3 ParseVector(ref TransformData inputData)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xBD5448", Offset = "0xBD5448", VA = "0xBD5448")]
		protected Quaternion ParseQuaternion(ref TransformData inputData)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xBD556C", Offset = "0xBD556C", VA = "0xBD556C")]
		public IKINEMAVRPN()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public struct TransformData
	{
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float[] position;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float[] orientation;
	}
	[Token(Token = "0x20000A8")]
	public class StreamCharacter
	{
		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr m_nativeHandle;

		[Token(Token = "0x40004DC")]
		private const string NativeDLL = "IKinemaVRPN_C";

		[Token(Token = "0x40004DD")]
		private const int NativeStringLength = 64;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private IntPtr m_nameBuffer;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr m_transformBuffer;

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xBD445C", Offset = "0xBD445C", VA = "0xBD445C")]
		public static StreamCharacter Connect(string connectionString)
		{
			return null;
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xBD568C", Offset = "0xBD568C", VA = "0xBD568C")]
		private StreamCharacter(string connectionString)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xBD5940", Offset = "0xBD5940", VA = "0xBD5940", Slot = "1")]
		~StreamCharacter()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xBD5234", Offset = "0xBD5234", VA = "0xBD5234")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xBD5244", Offset = "0xBD5244", VA = "0xBD5244")]
		public float GetFigureScale()
		{
			return default(float);
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xBD523C", Offset = "0xBD523C", VA = "0xBD523C")]
		public bool GetFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xBD4D24", Offset = "0xBD4D24", VA = "0xBD4D24")]
		public uint GetBoneCount()
		{
			return default(uint);
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xBD50E4", Offset = "0xBD50E4", VA = "0xBD50E4")]
		public string GetBoneName(uint boneId)
		{
			return null;
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xBD518C", Offset = "0xBD518C", VA = "0xBD518C")]
		public string GetParentBoneName(uint boneId)
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xBD6220", Offset = "0xBD6220", VA = "0xBD6220")]
		public TransformData GetBoneRestLocalTransform(uint boneId)
		{
			return default(TransformData);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xBD524C", Offset = "0xBD524C", VA = "0xBD524C")]
		public TransformData GetBoneLocalTransform(uint boneId)
		{
			return default(TransformData);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xBD6580", Offset = "0xBD6580", VA = "0xBD6580")]
		public uint GetRigidBodyCount()
		{
			return default(uint);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xBD6690", Offset = "0xBD6690", VA = "0xBD6690")]
		public string GetRigidBodyName(uint rigidBodyId)
		{
			return null;
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xBD6858", Offset = "0xBD6858", VA = "0xBD6858")]
		public TransformData GetRigidBodyGlobalTransform(uint rigidBodyId)
		{
			return default(TransformData);
		}

		[PreserveSig]
		[Token(Token = "0x6000562")]
		[Address(RVA = "0xBD5818", Offset = "0xBD5818", VA = "0xBD5818")]
		private static extern IntPtr CharacterCreate(string connectionString);

		[PreserveSig]
		[Token(Token = "0x6000563")]
		[Address(RVA = "0xBD5AB8", Offset = "0xBD5AB8", VA = "0xBD5AB8")]
		private static extern void CharacterDestroy(IntPtr nativeHandle);

		[PreserveSig]
		[Token(Token = "0x6000564")]
		[Address(RVA = "0xBD5BC0", Offset = "0xBD5BC0", VA = "0xBD5BC0")]
		private static extern bool CharacterInitialized(IntPtr nativeHandle);

		[PreserveSig]
		[Token(Token = "0x6000565")]
		[Address(RVA = "0xBD5CD8", Offset = "0xBD5CD8", VA = "0xBD5CD8")]
		private static extern float CharacterFigureScale(IntPtr nativeHandle);

		[PreserveSig]
		[Token(Token = "0x6000566")]
		[Address(RVA = "0xBD5DE8", Offset = "0xBD5DE8", VA = "0xBD5DE8")]
		private static extern bool GetFrame(IntPtr nativeHandle);

		[PreserveSig]
		[Token(Token = "0x6000567")]
		[Address(RVA = "0xBD5EE8", Offset = "0xBD5EE8", VA = "0xBD5EE8")]
		private static extern uint GetBoneCount(IntPtr nativeHandle);

		[PreserveSig]
		[Token(Token = "0x6000568")]
		[Address(RVA = "0xBD5FE8", Offset = "0xBD5FE8", VA = "0xBD5FE8")]
		private static extern void GetBoneName(IntPtr nativeHandle, uint boneId, IntPtr resultBuffer, uint bufferLength);

		[PreserveSig]
		[Token(Token = "0x6000569")]
		[Address(RVA = "0xBD6100", Offset = "0xBD6100", VA = "0xBD6100")]
		private static extern void GetParentBoneName(IntPtr nativeHandle, uint boneId, IntPtr resultBuffer, uint bufferLength);

		[PreserveSig]
		[Token(Token = "0x600056A")]
		[Address(RVA = "0xBD6338", Offset = "0xBD6338", VA = "0xBD6338")]
		private static extern void GetBoneRestLocalTransform(IntPtr nativeHandle, uint boneId, IntPtr resultBuffer);

		[PreserveSig]
		[Token(Token = "0x600056B")]
		[Address(RVA = "0xBD6460", Offset = "0xBD6460", VA = "0xBD6460")]
		private static extern void GetBoneLocalTransform(IntPtr nativeHandle, uint boneId, IntPtr resultBuffer);

		[PreserveSig]
		[Token(Token = "0x600056C")]
		[Address(RVA = "0xBD6588", Offset = "0xBD6588", VA = "0xBD6588")]
		private static extern uint GetRigidBodyCount(IntPtr nativeHandle);

		[PreserveSig]
		[Token(Token = "0x600056D")]
		[Address(RVA = "0xBD6738", Offset = "0xBD6738", VA = "0xBD6738")]
		private static extern void GetRigidBodyName(IntPtr nativeHandle, uint rigidBodyId, IntPtr resultBuffer, uint bufferLength);

		[PreserveSig]
		[Token(Token = "0x600056E")]
		[Address(RVA = "0xBD6970", Offset = "0xBD6970", VA = "0xBD6970")]
		private static extern void GetRigidBodyGlobalTransform(IntPtr nativeHandle, uint rigidBodyId, IntPtr resultBuffer);
	}
}
