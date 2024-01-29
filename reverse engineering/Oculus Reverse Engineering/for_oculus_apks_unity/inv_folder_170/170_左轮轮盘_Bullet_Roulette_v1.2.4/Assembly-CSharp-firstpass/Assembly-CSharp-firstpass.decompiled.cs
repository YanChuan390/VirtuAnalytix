using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using Unity.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Experimental.Animations;
using UnityEngine.Playables;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RootMotion
{
	[Token(Token = "0x2000002")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B4")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000573")]
			Update,
			[Token(Token = "0x4000574")]
			FixedUpdate,
			[Token(Token = "0x4000575")]
			LateUpdate,
			[Token(Token = "0x4000576")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F6CF0", Offset = "0x7F6CF0")]
		public bool smoothFollow;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F6D28", Offset = "0x7F6D28")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F6D60", Offset = "0x7F6D60")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F6D98", Offset = "0x7F6D98")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F6DD0", Offset = "0x7F6DD0")]
		public float blockedOffset;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6DE8", Offset = "0x7F6DE8")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6DF8", Offset = "0x7F6DF8")]
		private float <y>k__BackingField;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6E08", Offset = "0x7F6E08")]
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
			[Address(RVA = "0x100C9D0", Offset = "0x100C9D0", VA = "0x100C9D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF200", Offset = "0x7FF200")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x100C9D8", Offset = "0x100C9D8", VA = "0x100C9D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF210", Offset = "0x7FF210")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float y
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x100C9E0", Offset = "0x100C9E0", VA = "0x100C9E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF220", Offset = "0x7FF220")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x100C9E8", Offset = "0x100C9E8", VA = "0x100C9E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF230", Offset = "0x7FF230")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public float distanceTarget
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x100C9F0", Offset = "0x100C9F0", VA = "0x100C9F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF240", Offset = "0x7FF240")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x100C9F8", Offset = "0x100C9F8", VA = "0x100C9F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF250", Offset = "0x7FF250")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		private float zoomAdd
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x100D4FC", Offset = "0x100D4FC", VA = "0x100D4FC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x100CA00", Offset = "0x100CA00", VA = "0x100CA00", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x100CB3C", Offset = "0x100CB3C", VA = "0x100CB3C", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x100CBA0", Offset = "0x100CBA0", VA = "0x100CBA0", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x100CC08", Offset = "0x100CC08", VA = "0x100CC08", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x100CC6C", Offset = "0x100CC6C", VA = "0x100CC6C")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x100CB78", Offset = "0x100CB78", VA = "0x100CB78")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x100CDF4", Offset = "0x100CDF4", VA = "0x100CDF4")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x100D44C", Offset = "0x100D44C", VA = "0x100D44C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x100D570", Offset = "0x100D570", VA = "0x100D570")]
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
		[Address(RVA = "0x100D688", Offset = "0x100D688", VA = "0x100D688")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x100D6C8", Offset = "0x100D6C8", VA = "0x100D6C8")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x100D8A4", Offset = "0x100D8A4", VA = "0x100D8A4")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x100D954", Offset = "0x100D954", VA = "0x100D954")]
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
		[Address(RVA = "0x1003F3C", Offset = "0x1003F3C", VA = "0x1003F3C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1003FFC", Offset = "0x1003FFC", VA = "0x1003FFC")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x10040A8", Offset = "0x10040A8", VA = "0x10040A8")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1004290", Offset = "0x1004290", VA = "0x1004290")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x10041C4", Offset = "0x10041C4", VA = "0x10041C4")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x10043AC", Offset = "0x10043AC", VA = "0x10043AC")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x10045F4", Offset = "0x10045F4", VA = "0x10045F4")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000006")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x20000B5")]
		public class LimbOrientation
		{
			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x10048BC", Offset = "0x10048BC", VA = "0x10048BC")]
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
			[Address(RVA = "0x1004648", Offset = "0x1004648", VA = "0x1004648")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x1004938", Offset = "0x1004938", VA = "0x1004938")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x10045FC", Offset = "0x10045FC", VA = "0x10045FC")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x20000B6")]
		public enum BoneType
		{
			[Token(Token = "0x400057B")]
			Unassigned,
			[Token(Token = "0x400057C")]
			Spine,
			[Token(Token = "0x400057D")]
			Head,
			[Token(Token = "0x400057E")]
			Arm,
			[Token(Token = "0x400057F")]
			Leg,
			[Token(Token = "0x4000580")]
			Tail,
			[Token(Token = "0x4000581")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x20000B7")]
		public enum BoneSide
		{
			[Token(Token = "0x4000583")]
			Center,
			[Token(Token = "0x4000584")]
			Left,
			[Token(Token = "0x4000585")]
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
		[Address(RVA = "0x1004BAC", Offset = "0x1004BAC", VA = "0x1004BAC")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1004EF0", Offset = "0x1004EF0", VA = "0x1004EF0")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1005184", Offset = "0x1005184", VA = "0x1005184")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1005208", Offset = "0x1005208", VA = "0x1005208")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x10052BC", Offset = "0x10052BC", VA = "0x10052BC")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1004DA0", Offset = "0x1004DA0", VA = "0x1004DA0")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x10050E4", Offset = "0x10050E4", VA = "0x10050E4")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1005B10", Offset = "0x1005B10", VA = "0x1005B10")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1005928", Offset = "0x1005928", VA = "0x1005928")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1005A1C", Offset = "0x1005A1C", VA = "0x1005A1C")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x10054F0", Offset = "0x10054F0", VA = "0x10054F0")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x10055A4", Offset = "0x10055A4", VA = "0x10055A4")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1005658", Offset = "0x1005658", VA = "0x1005658")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x100570C", Offset = "0x100570C", VA = "0x100570C")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x10057C0", Offset = "0x10057C0", VA = "0x10057C0")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1005874", Offset = "0x1005874", VA = "0x1005874")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1005D8C", Offset = "0x1005D8C", VA = "0x1005D8C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x10053FC", Offset = "0x10053FC", VA = "0x10053FC")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1005CF4", Offset = "0x1005CF4", VA = "0x1005CF4")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1005DFC", Offset = "0x1005DFC", VA = "0x1005DFC")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1005ED0", Offset = "0x1005ED0", VA = "0x1005ED0")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1005C60", Offset = "0x1005C60", VA = "0x1005C60")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1005BA0", Offset = "0x1005BA0", VA = "0x1005BA0")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000008")]
	public class BipedReferences
	{
		[Token(Token = "0x20000B8")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x17000072")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60005B7")]
				[Address(RVA = "0x100C9C8", Offset = "0x100C9C8", VA = "0x100C9C8")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x8C6FE4", Offset = "0x8C6FE4", VA = "0x8C6FE4")]
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
			[Address(RVA = "0x10089B4", Offset = "0x10089B4", VA = "0x10089B4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public bool isEmpty
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x1008DB8", Offset = "0x1008DB8", VA = "0x1008DB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1008DC8", Offset = "0x1008DC8", VA = "0x1008DC8", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x100920C", Offset = "0x100920C", VA = "0x100920C", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1009654", Offset = "0x1009654", VA = "0x1009654")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1009E9C", Offset = "0x1009E9C", VA = "0x1009E9C")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x10098D8", Offset = "0x10098D8", VA = "0x10098D8")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x100A980", Offset = "0x100A980", VA = "0x100A980")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x100AA78", Offset = "0x100AA78", VA = "0x100AA78")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x100B0A8", Offset = "0x100B0A8", VA = "0x100B0A8")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x100AE78", Offset = "0x100AE78", VA = "0x100AE78")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x100ACC0", Offset = "0x100ACC0", VA = "0x100ACC0")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x100AB50", Offset = "0x100AB50", VA = "0x100AB50")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x100AF90", Offset = "0x100AF90", VA = "0x100AF90")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x100B1B4", Offset = "0x100B1B4", VA = "0x100B1B4")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x100C058", Offset = "0x100C058", VA = "0x100C058")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x100B944", Offset = "0x100B944", VA = "0x100B944")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x100C410", Offset = "0x100C410", VA = "0x100C410")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x100BE04", Offset = "0x100BE04", VA = "0x100BE04")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x100C418", Offset = "0x100C418", VA = "0x100C418")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x100C420", Offset = "0x100C420", VA = "0x100C420")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x100C62C", Offset = "0x100C62C", VA = "0x100C62C")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x100C890", Offset = "0x100C890", VA = "0x100C890")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1009868", Offset = "0x1009868", VA = "0x1009868")]
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
		[Address(RVA = "0x100D970", Offset = "0x100D970", VA = "0x100D970")]
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
		[Address(RVA = "0x100D978", Offset = "0x100D978", VA = "0x100D978")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x100DA38", Offset = "0x100DA38", VA = "0x100DA38")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class Hierarchy
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1B280F8", Offset = "0x1B280F8", VA = "0x1B280F8")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1B2832C", Offset = "0x1B2832C", VA = "0x1B2832C")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1B281A8", Offset = "0x1B281A8", VA = "0x1B281A8")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1B28478", Offset = "0x1B28478", VA = "0x1B28478")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1B285A0", Offset = "0x1B285A0", VA = "0x1B285A0")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1B288F0", Offset = "0x1B288F0", VA = "0x1B288F0")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1B28A34", Offset = "0x1B28A34", VA = "0x1B28A34")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1B28BE0", Offset = "0x1B28BE0", VA = "0x1B28BE0")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1B28FC8", Offset = "0x1B28FC8", VA = "0x1B28FC8")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1B28D94", Offset = "0x1B28D94", VA = "0x1B28D94")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1B29178", Offset = "0x1B29178", VA = "0x1B29178")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1B29180", Offset = "0x1B29180", VA = "0x1B29180")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1B291F0", Offset = "0x1B291F0", VA = "0x1B291F0")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public enum InterpolationMode
	{
		[Token(Token = "0x400005C")]
		None,
		[Token(Token = "0x400005D")]
		InOutCubic,
		[Token(Token = "0x400005E")]
		InOutQuintic,
		[Token(Token = "0x400005F")]
		InOutSine,
		[Token(Token = "0x4000060")]
		InQuintic,
		[Token(Token = "0x4000061")]
		InQuartic,
		[Token(Token = "0x4000062")]
		InCubic,
		[Token(Token = "0x4000063")]
		InQuadratic,
		[Token(Token = "0x4000064")]
		InElastic,
		[Token(Token = "0x4000065")]
		InElasticSmall,
		[Token(Token = "0x4000066")]
		InElasticBig,
		[Token(Token = "0x4000067")]
		InSine,
		[Token(Token = "0x4000068")]
		InBack,
		[Token(Token = "0x4000069")]
		OutQuintic,
		[Token(Token = "0x400006A")]
		OutQuartic,
		[Token(Token = "0x400006B")]
		OutCubic,
		[Token(Token = "0x400006C")]
		OutInCubic,
		[Token(Token = "0x400006D")]
		OutInQuartic,
		[Token(Token = "0x400006E")]
		OutElastic,
		[Token(Token = "0x400006F")]
		OutElasticSmall,
		[Token(Token = "0x4000070")]
		OutElasticBig,
		[Token(Token = "0x4000071")]
		OutSine,
		[Token(Token = "0x4000072")]
		OutBack,
		[Token(Token = "0x4000073")]
		OutBackCubic,
		[Token(Token = "0x4000074")]
		OutBackQuartic,
		[Token(Token = "0x4000075")]
		BackInCubic,
		[Token(Token = "0x4000076")]
		BackInQuartic
	}
	[Token(Token = "0x200000E")]
	public class Interp
	{
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1B29260", Offset = "0x1B29260", VA = "0x1B29260")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1B29CD0", Offset = "0x1B29CD0", VA = "0x1B29CD0")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1B29DD8", Offset = "0x1B29DD8", VA = "0x1B29DD8")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1B295D0", Offset = "0x1B295D0", VA = "0x1B295D0")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1B295DC", Offset = "0x1B295DC", VA = "0x1B295DC")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1B29604", Offset = "0x1B29604", VA = "0x1B29604")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1B29640", Offset = "0x1B29640", VA = "0x1B29640")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1B29658", Offset = "0x1B29658", VA = "0x1B29658")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1B2966C", Offset = "0x1B2966C", VA = "0x1B2966C")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1B29680", Offset = "0x1B29680", VA = "0x1B29680")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1B29690", Offset = "0x1B29690", VA = "0x1B29690")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1B296D8", Offset = "0x1B296D8", VA = "0x1B296D8")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1B29710", Offset = "0x1B29710", VA = "0x1B29710")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1B29738", Offset = "0x1B29738", VA = "0x1B29738")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1B29ED4", Offset = "0x1B29ED4", VA = "0x1B29ED4")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1B2976C", Offset = "0x1B2976C", VA = "0x1B2976C")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1B29794", Offset = "0x1B29794", VA = "0x1B29794")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1B297C4", Offset = "0x1B297C4", VA = "0x1B297C4")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1B297F8", Offset = "0x1B297F8", VA = "0x1B297F8")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1B2983C", Offset = "0x1B2983C", VA = "0x1B2983C")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1B298A0", Offset = "0x1B298A0", VA = "0x1B298A0")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1B29904", Offset = "0x1B29904", VA = "0x1B29904")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1B29958", Offset = "0x1B29958", VA = "0x1B29958")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1B299AC", Offset = "0x1B299AC", VA = "0x1B299AC")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1B29A44", Offset = "0x1B29A44", VA = "0x1B29A44")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1B29AD8", Offset = "0x1B29AD8", VA = "0x1B29AD8")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1B29F08", Offset = "0x1B29F08", VA = "0x1B29F08")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1B29B7C", Offset = "0x1B29B7C", VA = "0x1B29B7C")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1B29C60", Offset = "0x1B29C60", VA = "0x1B29C60")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1B29C90", Offset = "0x1B29C90", VA = "0x1B29C90")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1B29FF0", Offset = "0x1B29FF0", VA = "0x1B29FF0")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1B29FF8", Offset = "0x1B29FF8", VA = "0x1B29FF8")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1B2A068", Offset = "0x1B2A068", VA = "0x1B2A068")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000010")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1B2A0D8", Offset = "0x1B2A0D8", VA = "0x1B2A0D8")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1B2A134", Offset = "0x1B2A134", VA = "0x1B2A134")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1B2A20C", Offset = "0x1B2A20C", VA = "0x1B2A20C")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1B2A14C", Offset = "0x1B2A14C", VA = "0x1B2A14C")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1B2A224", Offset = "0x1B2A224", VA = "0x1B2A224")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1B2A2D4", Offset = "0x1B2A2D4", VA = "0x1B2A2D4")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1B2A300", Offset = "0x1B2A300", VA = "0x1B2A300")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1B2A350", Offset = "0x1B2A350", VA = "0x1B2A350")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1B2A3BC", Offset = "0x1B2A3BC", VA = "0x1B2A3BC")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1B2A4BC", Offset = "0x1B2A4BC", VA = "0x1B2A4BC")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1B2A5A0", Offset = "0x1B2A5A0", VA = "0x1B2A5A0")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1B2A600", Offset = "0x1B2A600", VA = "0x1B2A600")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000011")]
	public static class QuaTools
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1B2A630", Offset = "0x1B2A630", VA = "0x1B2A630")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1B2A77C", Offset = "0x1B2A77C", VA = "0x1B2A77C")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1B2A8C8", Offset = "0x1B2A8C8", VA = "0x1B2A8C8")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1B2A9DC", Offset = "0x1B2A9DC", VA = "0x1B2A9DC")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1B2AAF0", Offset = "0x1B2AAF0", VA = "0x1B2AAF0")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1B2AC7C", Offset = "0x1B2AC7C", VA = "0x1B2AC7C")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1B2AD4C", Offset = "0x1B2AD4C", VA = "0x1B2AD4C")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1B2AEA0", Offset = "0x1B2AEA0", VA = "0x1B2AEA0")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1B2B124", Offset = "0x1B2B124", VA = "0x1B2B124")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1B2B338", Offset = "0x1B2B338", VA = "0x1B2B338")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1B2B4B8", Offset = "0x1B2B4B8", VA = "0x1B2B4B8")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000012")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000009")]
		public static T instance
		{
			[Token(Token = "0x6000097")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000098")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000099")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F6E28", Offset = "0x7F6E28")]
		public bool fixTransforms;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000A")]
		private bool animatePhysics
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x1B2B760", Offset = "0x1B2B760", VA = "0x1B2B760")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool isAnimated
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x1B2BAB4", Offset = "0x1B2BAB4", VA = "0x1B2BAB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1B2B628", Offset = "0x1B2B628", VA = "0x1B2B628")]
		public void Disable()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1B2B6C0", Offset = "0x1B2B6C0", VA = "0x1B2B6C0", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1B2B6C4", Offset = "0x1B2B6C4", VA = "0x1B2B6C4", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1B2B6C8", Offset = "0x1B2B6C8", VA = "0x1B2B6C8", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1B2B6CC", Offset = "0x1B2B6CC", VA = "0x1B2B6CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1B2B75C", Offset = "0x1B2B75C", VA = "0x1B2B75C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1B2B704", Offset = "0x1B2B704", VA = "0x1B2B704")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1B2BA64", Offset = "0x1B2BA64", VA = "0x1B2BA64")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1B2B864", Offset = "0x1B2B864", VA = "0x1B2B864")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1B2BB70", Offset = "0x1B2BB70", VA = "0x1B2BB70")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1B2BBCC", Offset = "0x1B2BBCC", VA = "0x1B2BBCC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1B2BC2C", Offset = "0x1B2BC2C", VA = "0x1B2BC2C")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1B2BC74", Offset = "0x1B2BC74", VA = "0x1B2BC74")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1B2BC84", Offset = "0x1B2BC84", VA = "0x1B2BC84")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1B2BD44", Offset = "0x1B2BD44", VA = "0x1B2BD44")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1B2BE04", Offset = "0x1B2BE04", VA = "0x1B2BE04")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1B2BEC4", Offset = "0x1B2BEC4", VA = "0x1B2BEC4")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public static class V3Tools
	{
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1B2BECC", Offset = "0x1B2BECC", VA = "0x1B2BECC")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1B2BFC4", Offset = "0x1B2BFC4", VA = "0x1B2BFC4")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1B2C0BC", Offset = "0x1B2C0BC", VA = "0x1B2C0BC")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1B2C1B4", Offset = "0x1B2C1B4", VA = "0x1B2C1B4")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1B2C2B4", Offset = "0x1B2C2B4", VA = "0x1B2C2B4")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1B2C4F0", Offset = "0x1B2C4F0", VA = "0x1B2C4F0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1B2C740", Offset = "0x1B2C740", VA = "0x1B2C740")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1B2C950", Offset = "0x1B2C950", VA = "0x1B2C950")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000016")]
	public static class Warning
	{
		[Token(Token = "0x20000B9")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1B2CB2C", Offset = "0x1B2CB2C", VA = "0x1B2CB2C")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1B2D2F8", Offset = "0x1B2D2F8", VA = "0x1B2D2F8")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F5CA0", Offset = "0x7F5CA0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F5CA0", Offset = "0x7F5CA0")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xF9534C", Offset = "0xF9534C", VA = "0xF9534C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF2D0", Offset = "0x7FF2D0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xF95398", Offset = "0xF95398", VA = "0xF95398")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF308", Offset = "0x7FF308")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xF953E4", Offset = "0xF953E4", VA = "0xF953E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF340", Offset = "0x7FF340")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xF95430", Offset = "0xF95430", VA = "0xF95430")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF378", Offset = "0x7FF378")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xF9547C", Offset = "0xF9547C", VA = "0xF9547C")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xF9554C", Offset = "0xF9554C", VA = "0xF9554C")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xF9557C", Offset = "0xF9557C", VA = "0xF9557C")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xF955BC", Offset = "0xF955BC", VA = "0xF955BC")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xF955FC", Offset = "0xF955FC", VA = "0xF955FC")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xF95654", Offset = "0xF95654", VA = "0xF95654")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xF956B4", Offset = "0xF956B4", VA = "0xF956B4")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xF956E8", Offset = "0xF956E8", VA = "0xF956E8")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xF95718", Offset = "0xF95718", VA = "0xF95718")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xF957B0", Offset = "0xF957B0", VA = "0xF957B0")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xF95818", Offset = "0xF95818", VA = "0xF95818")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xF95880", Offset = "0xF95880", VA = "0xF95880")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xF954AC", Offset = "0xF954AC", VA = "0xF954AC")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xF958D0", Offset = "0xF958D0", VA = "0xF958D0")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xF958DC", Offset = "0xF958DC", VA = "0xF958DC")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xF958E8", Offset = "0xF958E8", VA = "0xF958E8")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xF95D34", Offset = "0xF95D34", VA = "0xF95D34", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xF95E2C", Offset = "0xF95E2C", VA = "0xF95E2C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xF96370", Offset = "0xF96370", VA = "0xF96370", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xF96A40", Offset = "0xF96A40", VA = "0xF96A40")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xF96A74", Offset = "0xF96A74", VA = "0xF96A74")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700000C")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xF95B7C", Offset = "0xF95B7C", VA = "0xF95B7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0xF96C40", Offset = "0xF96C40", VA = "0xF96C40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xF960B4", Offset = "0xF960B4", VA = "0xF960B4")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xF96AF8", Offset = "0xF96AF8", VA = "0xF96AF8")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	public abstract class Constraint
	{
		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700000E")]
		public bool isValid
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xF9A48C", Offset = "0xF9A48C", VA = "0xF9A48C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000D6")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xF9A4FC", Offset = "0xF9A4FC", VA = "0xF9A4FC")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001A")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xF9A504", Offset = "0xF9A504", VA = "0xF9A504", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xF9A638", Offset = "0xF9A638", VA = "0xF9A638")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xF9A640", Offset = "0xF9A640", VA = "0xF9A640")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001B")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x1700000F")]
		private bool positionChanged
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0xF9A898", Offset = "0xF9A898", VA = "0xF9A898")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xF9A66C", Offset = "0xF9A66C", VA = "0xF9A66C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xF9A95C", Offset = "0xF9A95C", VA = "0xF9A95C")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xF9A964", Offset = "0xF9A964", VA = "0xF9A964")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001C")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xF9A990", Offset = "0xF9A990", VA = "0xF9A990", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xF9AAE8", Offset = "0xF9AAE8", VA = "0xF9AAE8")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xF9AAF0", Offset = "0xF9AAF0", VA = "0xF9AAF0")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001D")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000010")]
		private bool rotationChanged
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0xF9AD5C", Offset = "0xF9AD5C", VA = "0xF9AD5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xF9AB1C", Offset = "0xF9AB1C", VA = "0xF9AB1C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xF9AE34", Offset = "0xF9AE34", VA = "0xF9AE34")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xF9AE3C", Offset = "0xF9AE3C", VA = "0xF9AE3C")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001E")]
	public class Constraints
	{
		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F6E60", Offset = "0x7F6E60")]
		public float positionWeight;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F6E78", Offset = "0x7F6E78")]
		public float rotationWeight;

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xF9AE68", Offset = "0xF9AE68", VA = "0xF9AE68")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xF962F8", Offset = "0xF962F8", VA = "0xF962F8")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xF9660C", Offset = "0xF9660C", VA = "0xF9660C")]
		public void Update()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xF96EDC", Offset = "0xF96EDC", VA = "0xF96EDC")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001F")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x20000BA")]
		public enum DOF
		{
			[Token(Token = "0x4000589")]
			One,
			[Token(Token = "0x400058A")]
			Three
		}

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F6E90", Offset = "0x7F6E90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F6E90", Offset = "0x7F6E90")]
		public float weight;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F6EE4", Offset = "0x7F6EE4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F6EE4", Offset = "0x7F6EE4")]
		public float rotationWeight;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F6F38", Offset = "0x7F6F38")]
		public DOF rotationDOF;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F6F70", Offset = "0x7F6F70")]
		public Transform bone1;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F6FA8", Offset = "0x7F6FA8")]
		public Transform bone2;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F6FE0", Offset = "0x7F6FE0")]
		public Transform bone3;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7018", Offset = "0x7F7018")]
		public Transform tip;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7050", Offset = "0x7F7050")]
		public Transform target;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F7088", Offset = "0x7F7088")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x17000011")]
		public bool initiated
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0xFA5308", Offset = "0xFA5308", VA = "0xFA5308")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF3B0", Offset = "0x7FF3B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0xFA5310", Offset = "0xFA5310", VA = "0xFA5310")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF3C0", Offset = "0x7FF3C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0xFA531C", Offset = "0xFA531C", VA = "0xFA531C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0xFA534C", Offset = "0xFA534C", VA = "0xFA534C")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0xFA5398", Offset = "0xFA5398", VA = "0xFA5398")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0xFA53C8", Offset = "0xFA53C8", VA = "0xFA53C8")]
			set
			{
			}
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xFA5418", Offset = "0xFA5418", VA = "0xFA5418")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xFA5518", Offset = "0xFA5518", VA = "0xFA5518")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xFA5A24", Offset = "0xFA5A24", VA = "0xFA5A24")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xFA5B54", Offset = "0xFA5B54", VA = "0xFA5B54")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xFA5C3C", Offset = "0xFA5C3C", VA = "0xFA5C3C")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xFA6134", Offset = "0xFA6134", VA = "0xFA6134")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7098", Offset = "0x7F7098")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F7098", Offset = "0x7F7098")]
		public float weight;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F70EC", Offset = "0x7F70EC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000014")]
		public bool initiated
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0xFA6144", Offset = "0xFA6144", VA = "0xFA6144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF3D0", Offset = "0x7FF3D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0xFA614C", Offset = "0xFA614C", VA = "0xFA614C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF3E0", Offset = "0x7FF3E0")]
			private set
			{
			}
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xFA6158", Offset = "0xFA6158", VA = "0xFA6158")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xFA61EC", Offset = "0xFA61EC", VA = "0xFA61EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF3F0", Offset = "0x7FF3F0")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xFA6638", Offset = "0xFA6638", VA = "0xFA6638")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xFA684C", Offset = "0xFA684C", VA = "0xFA684C")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xFA64EC", Offset = "0xFA64EC", VA = "0xFA64EC")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xFA6A44", Offset = "0xFA6A44", VA = "0xFA6A44", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xFA6B4C", Offset = "0xFA6B4C", VA = "0xFA6B4C")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xFA6BE0", Offset = "0xFA6BE0", VA = "0xFA6BE0")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xFA6C6C", Offset = "0xFA6C6C", VA = "0xFA6C6C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xFA6CEC", Offset = "0xFA6CEC", VA = "0xFA6CEC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xFA6CF0", Offset = "0xFA6CF0", VA = "0xFA6CF0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xFA6D04", Offset = "0xFA6D04", VA = "0xFA6D04")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x20000BB")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F70FC", Offset = "0x7F70FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F70FC", Offset = "0x7F70FC")]
		public float weight;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7150", Offset = "0x7F7150")]
		public Grounding solver;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F7188", Offset = "0x7F7188")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000015")]
		public bool initiated
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0xFA80BC", Offset = "0xFA80BC", VA = "0xFA80BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF428", Offset = "0x7FF428")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000106")]
			[Address(RVA = "0xFA80C4", Offset = "0xFA80C4", VA = "0xFA80C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF438", Offset = "0x7FF438")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000104")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xFA80D0", Offset = "0xFA80D0", VA = "0xFA80D0")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xFA8444", Offset = "0xFA8444", VA = "0xFA8444")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xFA8260", Offset = "0xFA8260", VA = "0xFA8260")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xFA8478", Offset = "0xFA8478", VA = "0xFA8478")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010B")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600010C")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xFA86FC", Offset = "0xFA86FC", VA = "0xFA86FC")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F5D00", Offset = "0x7F5D00")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F5D00", Offset = "0x7F5D00")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7198", Offset = "0x7F7198")]
		public BipedIK ik;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F71D0", Offset = "0x7F71D0")]
		public float spineBend;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7208", Offset = "0x7F7208")]
		public float spineSpeed;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xFA8BBC", Offset = "0xFA8BBC", VA = "0xFA8BBC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF448", Offset = "0x7FF448")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xFA8C08", Offset = "0xFA8C08", VA = "0xFA8C08", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF480", Offset = "0x7FF480")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xFA8C54", Offset = "0xFA8C54", VA = "0xFA8C54", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xFA8CE0", Offset = "0xFA8CE0", VA = "0xFA8CE0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xFA8DE0", Offset = "0xFA8DE0", VA = "0xFA8DE0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xFA8E94", Offset = "0xFA8E94", VA = "0xFA8E94")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xFA9328", Offset = "0xFA9328", VA = "0xFA9328")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xFA93B4", Offset = "0xFA93B4", VA = "0xFA93B4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xFA9B18", Offset = "0xFA9B18", VA = "0xFA9B18")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xFA9C88", Offset = "0xFA9C88", VA = "0xFA9C88")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xFA9F00", Offset = "0xFA9F00", VA = "0xFA9F00")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xFAA154", Offset = "0xFAA154", VA = "0xFAA154")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F5D60", Offset = "0x7F5D60")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F5D60", Offset = "0x7F5D60")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000BC")]
		public class SpineEffector
		{
			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBC8C", Offset = "0x7FBC8C")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBCC4", Offset = "0x7FBCC4")]
			public float horizontalWeight;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBCFC", Offset = "0x7FBCFC")]
			public float verticalWeight;

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x154CF28", Offset = "0x154CF28", VA = "0x154CF28")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x154CF38", Offset = "0x154CF38", VA = "0x154CF38")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7240", Offset = "0x7F7240")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7278", Offset = "0x7F7278")]
		public float spineBend;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F72B0", Offset = "0x7F72B0")]
		public float spineSpeed;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xFAA1D4", Offset = "0xFAA1D4", VA = "0xFAA1D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF4B8", Offset = "0x7FF4B8")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xFAA220", Offset = "0xFAA220", VA = "0xFAA220", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF4F0", Offset = "0x7FF4F0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xFAA26C", Offset = "0xFAA26C", VA = "0xFAA26C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF528", Offset = "0x7FF528")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xFAA2B8", Offset = "0xFAA2B8", VA = "0xFAA2B8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xFAA344", Offset = "0xFAA344", VA = "0xFAA344")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xFAA3F4", Offset = "0xFAA3F4", VA = "0xFAA3F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xFAA7E8", Offset = "0xFAA7E8", VA = "0xFAA7E8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xFAA7F4", Offset = "0xFAA7F4", VA = "0xFAA7F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xFAA4B0", Offset = "0xFAA4B0", VA = "0xFAA4B0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xFAA800", Offset = "0xFAA800", VA = "0xFAA800")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xFAAE44", Offset = "0xFAAE44", VA = "0xFAAE44")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xFAB08C", Offset = "0xFAB08C", VA = "0xFAB08C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xFAB1C4", Offset = "0xFAB1C4", VA = "0xFAB1C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xFAB32C", Offset = "0xFAB32C", VA = "0xFAB32C")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F5DC0", Offset = "0x7F5DC0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F5DC0", Offset = "0x7F5DC0")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F72E8", Offset = "0x7F72E8")]
		public Transform pelvis;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7320", Offset = "0x7F7320")]
		public Transform characterRoot;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7358", Offset = "0x7F7358")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F7358", Offset = "0x7F7358")]
		public float rootRotationWeight;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F73AC", Offset = "0x7F73AC")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F73E4", Offset = "0x7F73E4")]
		public float maxRootRotationAngle;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x154CF80", Offset = "0x154CF80", VA = "0x154CF80", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF560", Offset = "0x7FF560")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x154CFCC", Offset = "0x154CFCC", VA = "0x154CFCC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF598", Offset = "0x7FF598")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x154D018", Offset = "0x154D018", VA = "0x154D018", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x154D0EC", Offset = "0x154D0EC", VA = "0x154D0EC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x154D2D8", Offset = "0x154D2D8", VA = "0x154D2D8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x154D42C", Offset = "0x154D42C", VA = "0x154D42C")]
		private void Update()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x154DC80", Offset = "0x154DC80", VA = "0x154DC80")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x154E5E8", Offset = "0x154E5E8", VA = "0x154E5E8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x154EB70", Offset = "0x154EB70", VA = "0x154EB70")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x154F0D8", Offset = "0x154F0D8", VA = "0x154F0D8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x154F350", Offset = "0x154F350", VA = "0x154F350")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x154F5F0", Offset = "0x154F5F0", VA = "0x154F5F0")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F5E20", Offset = "0x7F5E20")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F5E20", Offset = "0x7F5E20")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x20000BD")]
		public struct Foot
		{
			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x8D6DC0", Offset = "0x8D6DC0", VA = "0x8D6DC0")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F741C", Offset = "0x7F741C")]
		public Grounding forelegSolver;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7454", Offset = "0x7F7454")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F7454", Offset = "0x7F7454")]
		public float rootRotationWeight;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F74A8", Offset = "0x7F74A8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F74A8", Offset = "0x7F74A8")]
		public float minRootRotation;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7500", Offset = "0x7F7500")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F7500", Offset = "0x7F7500")]
		public float maxRootRotation;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7558", Offset = "0x7F7558")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7590", Offset = "0x7F7590")]
		public float maxLegOffset;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F75C8", Offset = "0x7F75C8")]
		public float maxForeLegOffset;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7600", Offset = "0x7F7600")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F7600", Offset = "0x7F7600")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7654", Offset = "0x7F7654")]
		public Transform characterRoot;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F768C", Offset = "0x7F768C")]
		public Transform pelvis;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F76C4", Offset = "0x7F76C4")]
		public Transform lastSpineBone;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F76FC", Offset = "0x7F76FC")]
		public Transform head;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x154F674", Offset = "0x154F674", VA = "0x154F674", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF5D0", Offset = "0x7FF5D0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x154F6C0", Offset = "0x154F6C0", VA = "0x154F6C0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF608", Offset = "0x7FF608")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x154F70C", Offset = "0x154F70C", VA = "0x154F70C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x154F754", Offset = "0x154F754", VA = "0x154F754")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x154F890", Offset = "0x154F890", VA = "0x154F890")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x154FA34", Offset = "0x154FA34", VA = "0x154FA34")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x154FB18", Offset = "0x154FB18", VA = "0x154FB18")]
		private void Update()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x154FBD8", Offset = "0x154FBD8", VA = "0x154FBD8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x154FFE8", Offset = "0x154FFE8", VA = "0x154FFE8")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x15504E4", Offset = "0x15504E4", VA = "0x15504E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1550630", Offset = "0x1550630", VA = "0x1550630")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1550B94", Offset = "0x1550B94", VA = "0x1550B94")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x15515BC", Offset = "0x15515BC", VA = "0x15515BC")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1551928", Offset = "0x1551928", VA = "0x1551928")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1551AC4", Offset = "0x1551AC4", VA = "0x1551AC4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1551EBC", Offset = "0x1551EBC", VA = "0x1551EBC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1551F04", Offset = "0x1551F04", VA = "0x1551F04")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1552194", Offset = "0x1552194", VA = "0x1552194")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F5E80", Offset = "0x7F5E80")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7744", Offset = "0x7F7744")]
		public VRIK ik;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x155230C", Offset = "0x155230C", VA = "0x155230C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF640", Offset = "0x7FF640")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1552310", Offset = "0x1552310", VA = "0x1552310", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF678", Offset = "0x7FF678")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1552314", Offset = "0x1552314", VA = "0x1552314", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF6B0", Offset = "0x7FF6B0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1552318", Offset = "0x1552318", VA = "0x1552318", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1552344", Offset = "0x1552344", VA = "0x1552344")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x15523F0", Offset = "0x15523F0", VA = "0x15523F0")]
		private void Update()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x15524AC", Offset = "0x15524AC", VA = "0x15524AC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1552800", Offset = "0x1552800", VA = "0x1552800")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1552BD8", Offset = "0x1552BD8", VA = "0x1552BD8")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1552D14", Offset = "0x1552D14", VA = "0x1552D14")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1553044", Offset = "0x1553044", VA = "0x1553044")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x155317C", Offset = "0x155317C", VA = "0x155317C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x15533B8", Offset = "0x15533B8", VA = "0x15533B8")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000027")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x20000BE")]
		public enum Quality
		{
			[Token(Token = "0x4000593")]
			Fastest,
			[Token(Token = "0x4000594")]
			Simple,
			[Token(Token = "0x4000595")]
			Best
		}

		[Token(Token = "0x20000BF")]
		public class Leg
		{
			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FBD34", Offset = "0x7FBD34")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FBD44", Offset = "0x7FBD44")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FBD54", Offset = "0x7FBD54")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FBD64", Offset = "0x7FBD64")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FBD74", Offset = "0x7FBD74")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FBD84", Offset = "0x7FBD84")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FBD94", Offset = "0x7FBD94")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x17000073")]
			public bool isGrounded
			{
				[Token(Token = "0x60005C3")]
				[Address(RVA = "0x15545E8", Offset = "0x15545E8", VA = "0x15545E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801178", Offset = "0x801178")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005C4")]
				[Address(RVA = "0x1554EC0", Offset = "0x1554EC0", VA = "0x1554EC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801188", Offset = "0x801188")]
				private set
				{
				}
			}

			[Token(Token = "0x17000074")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60005C5")]
				[Address(RVA = "0x154F0CC", Offset = "0x154F0CC", VA = "0x154F0CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801198", Offset = "0x801198")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005C6")]
				[Address(RVA = "0x1554ECC", Offset = "0x1554ECC", VA = "0x1554ECC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8011A8", Offset = "0x8011A8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000075")]
			public bool initiated
			{
				[Token(Token = "0x60005C7")]
				[Address(RVA = "0x1554ED8", Offset = "0x1554ED8", VA = "0x1554ED8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8011B8", Offset = "0x8011B8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005C8")]
				[Address(RVA = "0x1554EE0", Offset = "0x1554EE0", VA = "0x1554EE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8011C8", Offset = "0x8011C8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public float heightFromGround
			{
				[Token(Token = "0x60005C9")]
				[Address(RVA = "0x1554EEC", Offset = "0x1554EEC", VA = "0x1554EEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8011D8", Offset = "0x8011D8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005CA")]
				[Address(RVA = "0x1554EF4", Offset = "0x1554EF4", VA = "0x1554EF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8011E8", Offset = "0x8011E8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000077")]
			public Vector3 velocity
			{
				[Token(Token = "0x60005CB")]
				[Address(RVA = "0x1554EFC", Offset = "0x1554EFC", VA = "0x1554EFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8011F8", Offset = "0x8011F8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005CC")]
				[Address(RVA = "0x1554F08", Offset = "0x1554F08", VA = "0x1554F08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801208", Offset = "0x801208")]
				private set
				{
				}
			}

			[Token(Token = "0x17000078")]
			public Transform transform
			{
				[Token(Token = "0x60005CD")]
				[Address(RVA = "0x1551ABC", Offset = "0x1551ABC", VA = "0x1551ABC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801218", Offset = "0x801218")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005CE")]
				[Address(RVA = "0x1554F14", Offset = "0x1554F14", VA = "0x1554F14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801228", Offset = "0x801228")]
				private set
				{
				}
			}

			[Token(Token = "0x17000079")]
			public float IKOffset
			{
				[Token(Token = "0x60005CF")]
				[Address(RVA = "0x15545E0", Offset = "0x15545E0", VA = "0x15545E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801238", Offset = "0x801238")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005D0")]
				[Address(RVA = "0x1554F1C", Offset = "0x1554F1C", VA = "0x1554F1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801248", Offset = "0x801248")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007A")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60005D5")]
				[Address(RVA = "0x1555BA0", Offset = "0x1555BA0", VA = "0x1555BA0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700007B")]
			private float rootYOffset
			{
				[Token(Token = "0x60005DE")]
				[Address(RVA = "0x1555F24", Offset = "0x1555F24", VA = "0x1555F24")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x1553AE4", Offset = "0x1553AE4", VA = "0x1553AE4")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x1554F24", Offset = "0x1554F24", VA = "0x1554F24")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x15549A0", Offset = "0x15549A0", VA = "0x15549A0")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x1553BF4", Offset = "0x1553BF4", VA = "0x1553BF4")]
			public void Process()
			{
			}

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x15556A4", Offset = "0x15556A4", VA = "0x15556A4")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x1554F78", Offset = "0x1554F78", VA = "0x1554F78")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x1555D64", Offset = "0x1555D64", VA = "0x1555D64")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x1555328", Offset = "0x1555328", VA = "0x1555328")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x1555430", Offset = "0x1555430", VA = "0x1555430")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x1555E74", Offset = "0x1555E74", VA = "0x1555E74")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x1555C50", Offset = "0x1555C50", VA = "0x1555C50")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x1556090", Offset = "0x1556090", VA = "0x1556090")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x1553A34", Offset = "0x1553A34", VA = "0x1553A34")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x20000C0")]
		public class Pelvis
		{
			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FBDA4", Offset = "0x7FBDA4")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FBDB4", Offset = "0x7FBDB4")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x1700007C")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60005E0")]
				[Address(RVA = "0x154F0C0", Offset = "0x154F0C0", VA = "0x154F0C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801258", Offset = "0x801258")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005E1")]
				[Address(RVA = "0x1556208", Offset = "0x1556208", VA = "0x1556208")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801268", Offset = "0x801268")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007D")]
			public float heightOffset
			{
				[Token(Token = "0x60005E2")]
				[Address(RVA = "0x1551920", Offset = "0x1551920", VA = "0x1551920")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801278", Offset = "0x801278")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005E3")]
				[Address(RVA = "0x1556214", Offset = "0x1556214", VA = "0x1556214")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801288", Offset = "0x801288")]
				private set
				{
				}
			}

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x1553BCC", Offset = "0x1553BCC", VA = "0x1553BCC")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x15548D4", Offset = "0x15548D4", VA = "0x15548D4")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x155621C", Offset = "0x155621C", VA = "0x155621C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x15545F0", Offset = "0x15545F0", VA = "0x15545F0")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x1553ADC", Offset = "0x1553ADC", VA = "0x1553ADC")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F777C", Offset = "0x7F777C")]
		public LayerMask layers;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F77B4", Offset = "0x7F77B4")]
		public float maxStep;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F77EC", Offset = "0x7F77EC")]
		public float heightOffset;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7824", Offset = "0x7F7824")]
		public float footSpeed;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F785C", Offset = "0x7F785C")]
		public float footRadius;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7894", Offset = "0x7F7894")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F78E0", Offset = "0x7F78E0")]
		public float prediction;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7918", Offset = "0x7F7918")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F7918", Offset = "0x7F7918")]
		public float footRotationWeight;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F796C", Offset = "0x7F796C")]
		public float footRotationSpeed;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F79A4", Offset = "0x7F79A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F79A4", Offset = "0x7F79A4")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F79FC", Offset = "0x7F79FC")]
		public bool rotateSolver;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7A34", Offset = "0x7F7A34")]
		public float pelvisSpeed;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7A6C", Offset = "0x7F7A6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F7A6C", Offset = "0x7F7A6C")]
		public float pelvisDamper;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7AC0", Offset = "0x7F7AC0")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7AF8", Offset = "0x7F7AF8")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7B30", Offset = "0x7F7B30")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7B68", Offset = "0x7F7B68")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7BA0", Offset = "0x7F7BA0")]
		public Quality quality;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F7BD8", Offset = "0x7F7BD8")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F7BE8", Offset = "0x7F7BE8")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F7BF8", Offset = "0x7F7BF8")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F7C08", Offset = "0x7F7C08")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F7C18", Offset = "0x7F7C18")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000016")]
		public Leg[] legs
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x154E5E0", Offset = "0x154E5E0", VA = "0x154E5E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF6E8", Offset = "0x7FF6E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x1553418", Offset = "0x1553418", VA = "0x1553418")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF6F8", Offset = "0x7FF6F8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x154F0B8", Offset = "0x154F0B8", VA = "0x154F0B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF708", Offset = "0x7FF708")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1553420", Offset = "0x1553420", VA = "0x1553420")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF718", Offset = "0x7FF718")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public bool isGrounded
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x1553428", Offset = "0x1553428", VA = "0x1553428")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF728", Offset = "0x7FF728")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x1553430", Offset = "0x1553430", VA = "0x1553430")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF738", Offset = "0x7FF738")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public Transform root
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x1551918", Offset = "0x1551918", VA = "0x1551918")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF748", Offset = "0x7FF748")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x155343C", Offset = "0x155343C", VA = "0x155343C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF758", Offset = "0x7FF758")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x1550B78", Offset = "0x1550B78", VA = "0x1550B78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF768", Offset = "0x7FF768")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x1553444", Offset = "0x1553444", VA = "0x1553444")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF778", Offset = "0x7FF778")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool rootGrounded
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x1553464", Offset = "0x1553464", VA = "0x1553464")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001C")]
		public Vector3 up
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x15538C4", Offset = "0x15538C4", VA = "0x15538C4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700001D")]
		private bool useRootRotation
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x1554A68", Offset = "0x1554A68", VA = "0x1554A68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x15534BC", Offset = "0x15534BC", VA = "0x15534BC")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1553958", Offset = "0x1553958", VA = "0x1553958")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x154E2DC", Offset = "0x154E2DC", VA = "0x154E2DC")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x154E8D0", Offset = "0x154E8D0", VA = "0x154E8D0")]
		public void Update()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x154DA0C", Offset = "0x154DA0C", VA = "0x154DA0C")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x154D044", Offset = "0x154D044", VA = "0x154D044")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1553BDC", Offset = "0x1553BDC", VA = "0x1553BDC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1554B40", Offset = "0x1554B40", VA = "0x1554B40")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1554CB0", Offset = "0x1554CB0", VA = "0x1554CB0")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1554DBC", Offset = "0x1554DBC", VA = "0x1554DBC")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x15522B4", Offset = "0x15522B4", VA = "0x15522B4")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F5EB8", Offset = "0x7F5EB8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F5EB8", Offset = "0x7F5EB8")]
	public class AimIK : IK
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xF900AC", Offset = "0xF900AC", VA = "0xF900AC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF788", Offset = "0x7FF788")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xF900F8", Offset = "0xF900F8", VA = "0xF900F8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF7C0", Offset = "0x7FF7C0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xF90144", Offset = "0xF90144", VA = "0xF90144")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF7F8", Offset = "0x7FF7F8")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xF90190", Offset = "0xF90190", VA = "0xF90190")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF830", Offset = "0x7FF830")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xF901DC", Offset = "0xF901DC", VA = "0xF901DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF868", Offset = "0x7FF868")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xF90228", Offset = "0xF90228", VA = "0xF90228", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xF90230", Offset = "0xF90230", VA = "0xF90230")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F5F18", Offset = "0x7F5F18")]
	public class ArmIK : IK
	{
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xF9516C", Offset = "0xF9516C", VA = "0xF9516C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF8A0", Offset = "0x7FF8A0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xF951D8", Offset = "0xF951D8", VA = "0xF951D8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF8D8", Offset = "0x7FF8D8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xF95244", Offset = "0xF95244", VA = "0xF95244")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF910", Offset = "0x7FF910")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xF95290", Offset = "0xF95290", VA = "0xF95290")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF948", Offset = "0x7FF948")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xF952DC", Offset = "0xF952DC", VA = "0xF952DC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xF952E4", Offset = "0xF952E4", VA = "0xF952E4")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F5F50", Offset = "0x7F5F50")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F5F50", Offset = "0x7F5F50")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xF971B8", Offset = "0xF971B8", VA = "0xF971B8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF980", Offset = "0x7FF980")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xF97204", Offset = "0xF97204", VA = "0xF97204", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF9B8", Offset = "0x7FF9B8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xF97250", Offset = "0xF97250", VA = "0xF97250")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FF9F0", Offset = "0x7FF9F0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xF9729C", Offset = "0xF9729C", VA = "0xF9729C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFA28", Offset = "0x7FFA28")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xF972E8", Offset = "0xF972E8", VA = "0xF972E8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xF972F0", Offset = "0xF972F0", VA = "0xF972F0")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F5FB0", Offset = "0x7F5FB0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F5FB0", Offset = "0x7F5FB0")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xF9AED8", Offset = "0xF9AED8", VA = "0xF9AED8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFA60", Offset = "0x7FFA60")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xF9AF24", Offset = "0xF9AF24", VA = "0xF9AF24", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFA98", Offset = "0x7FFA98")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xF9AF70", Offset = "0xF9AF70", VA = "0xF9AF70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFAD0", Offset = "0x7FFAD0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xF9AFBC", Offset = "0xF9AFBC", VA = "0xF9AFBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFB08", Offset = "0x7FFB08")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xF9B008", Offset = "0xF9B008", VA = "0xF9B008", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xF9B010", Offset = "0xF9B010", VA = "0xF9B010")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F6010", Offset = "0x7F6010")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F6010", Offset = "0x7F6010")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xF9B974", Offset = "0xF9B974", VA = "0xF9B974", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFB40", Offset = "0x7FFB40")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xF9B9C0", Offset = "0xF9B9C0", VA = "0xF9B9C0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFB78", Offset = "0x7FFB78")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xF9BA0C", Offset = "0xF9BA0C", VA = "0xF9BA0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFBB0", Offset = "0x7FFBB0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xF9BA58", Offset = "0xF9BA58", VA = "0xF9BA58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFBE8", Offset = "0x7FFBE8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xF9BAA4", Offset = "0xF9BAA4", VA = "0xF9BAA4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xF9BAAC", Offset = "0xF9BAAC", VA = "0xF9BAAC")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F6070", Offset = "0x7F6070")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F6070", Offset = "0x7F6070")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xFA6D6C", Offset = "0xFA6D6C", VA = "0xFA6D6C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFC20", Offset = "0x7FFC20")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xFA6DB8", Offset = "0xFA6DB8", VA = "0xFA6DB8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFC58", Offset = "0x7FFC58")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xFA6E04", Offset = "0xFA6E04", VA = "0xFA6E04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFC90", Offset = "0x7FFC90")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xFA6E50", Offset = "0xFA6E50", VA = "0xFA6E50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFCC8", Offset = "0x7FFCC8")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xFA6E9C", Offset = "0xFA6E9C", VA = "0xFA6E9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFD00", Offset = "0x7FFD00")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xFA6EE8", Offset = "0xFA6EE8", VA = "0xFA6EE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFD38", Offset = "0x7FFD38")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xFA6F34", Offset = "0xFA6F34", VA = "0xFA6F34")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xFA6F80", Offset = "0xFA6F80", VA = "0xFA6F80", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xFA6F88", Offset = "0xFA6F88", VA = "0xFA6F88")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xFA71AC", Offset = "0xFA71AC", VA = "0xFA71AC")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xFA759C", Offset = "0xFA759C", VA = "0xFA759C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFD70", Offset = "0x7FFD70")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xFA75DC", Offset = "0xFA75DC", VA = "0xFA75DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFDA8", Offset = "0x7FFDA8")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xFA76F0", Offset = "0xFA76F0", VA = "0xFA76F0")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000197")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1559634", Offset = "0x1559634", VA = "0x1559634", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1559738", Offset = "0x1559738", VA = "0x1559738", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1559904", Offset = "0x1559904", VA = "0x1559904", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600019B")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600019C")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1559974", Offset = "0x1559974", VA = "0x1559974")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7C28", Offset = "0x7F7C28")]
		public IK[] IKComponents;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7C60", Offset = "0x7F7C60")]
		public Animator animator;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700001E")]
		private bool animatePhysics
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x155D150", Offset = "0x155D150", VA = "0x155D150")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x155D1F4", Offset = "0x155D1F4", VA = "0x155D1F4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x155D294", Offset = "0x155D294", VA = "0x155D294")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x155D3CC", Offset = "0x155D3CC", VA = "0x155D3CC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x155D408", Offset = "0x155D408", VA = "0x155D408")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x155D2C8", Offset = "0x155D2C8", VA = "0x155D2C8")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x155D4D0", Offset = "0x155D4D0", VA = "0x155D4D0")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F60D0", Offset = "0x7F60D0")]
	public class LegIK : IK
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x10B2700", Offset = "0x10B2700", VA = "0x10B2700", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFDE0", Offset = "0x7FFDE0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x10B276C", Offset = "0x10B276C", VA = "0x10B276C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFE18", Offset = "0x7FFE18")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x10B27D8", Offset = "0x10B27D8", VA = "0x10B27D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFE50", Offset = "0x7FFE50")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x10B2824", Offset = "0x10B2824", VA = "0x10B2824")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFE88", Offset = "0x7FFE88")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x10B2870", Offset = "0x10B2870", VA = "0x10B2870", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x10B2878", Offset = "0x10B2878", VA = "0x10B2878")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F6108", Offset = "0x7F6108")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F6108", Offset = "0x7F6108")]
	public class LimbIK : IK
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x10B28E0", Offset = "0x10B28E0", VA = "0x10B28E0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFEC0", Offset = "0x7FFEC0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x10B292C", Offset = "0x10B292C", VA = "0x10B292C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFEF8", Offset = "0x7FFEF8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x10B2978", Offset = "0x10B2978", VA = "0x10B2978")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFF30", Offset = "0x7FFF30")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x10B29C4", Offset = "0x10B29C4", VA = "0x10B29C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFF68", Offset = "0x7FFF68")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x10B2A10", Offset = "0x10B2A10", VA = "0x10B2A10", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x10B2A18", Offset = "0x10B2A18", VA = "0x10B2A18")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F6168", Offset = "0x7F6168")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F6168", Offset = "0x7F6168")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x10B3B34", Offset = "0x10B3B34", VA = "0x10B3B34", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFFA0", Offset = "0x7FFFA0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x10B3B80", Offset = "0x10B3B80", VA = "0x10B3B80", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7FFFD8", Offset = "0x7FFFD8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x10B3BCC", Offset = "0x10B3BCC", VA = "0x10B3BCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800010", Offset = "0x800010")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x10B3C18", Offset = "0x10B3C18", VA = "0x10B3C18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800048", Offset = "0x800048")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x10B3C64", Offset = "0x10B3C64", VA = "0x10B3C64", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x10B3C6C", Offset = "0x10B3C6C", VA = "0x10B3C6C")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F61C8", Offset = "0x7F61C8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F61C8", Offset = "0x7F61C8")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x10BE404", Offset = "0x10BE404", VA = "0x10BE404", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800080", Offset = "0x800080")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x10BE450", Offset = "0x10BE450", VA = "0x10BE450", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8000B8", Offset = "0x8000B8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x10BE49C", Offset = "0x10BE49C", VA = "0x10BE49C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8000F0", Offset = "0x8000F0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x10BE4E8", Offset = "0x10BE4E8", VA = "0x10BE4E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800128", Offset = "0x800128")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x10BE534", Offset = "0x10BE534", VA = "0x10BE534", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x10BE53C", Offset = "0x10BE53C", VA = "0x10BE53C")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F6228", Offset = "0x7F6228")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x20000C1")]
		public class References
		{
			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBDC4", Offset = "0x7FBDC4")]
			public Transform chest;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBDFC", Offset = "0x7FBDFC")]
			public Transform neck;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBE34", Offset = "0x7FBE34")]
			public Transform leftShoulder;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBE6C", Offset = "0x7FBE6C")]
			public Transform rightShoulder;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBEA4", Offset = "0x7FBEA4")]
			public Transform leftThigh;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBEDC", Offset = "0x7FBEDC")]
			public Transform leftCalf;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBF14", Offset = "0x7FBF14")]
			public Transform leftFoot;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBF4C", Offset = "0x7FBF4C")]
			public Transform leftToes;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBF84", Offset = "0x7FBF84")]
			public Transform rightThigh;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBFBC", Offset = "0x7FBFBC")]
			public Transform rightCalf;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBFF4", Offset = "0x7FBFF4")]
			public Transform rightFoot;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC02C", Offset = "0x7FC02C")]
			public Transform rightToes;

			[Token(Token = "0x1700007E")]
			public bool isFilled
			{
				[Token(Token = "0x60005EA")]
				[Address(RVA = "0x10BFE8C", Offset = "0x10BFE8C", VA = "0x10BFE8C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700007F")]
			public bool isEmpty
			{
				[Token(Token = "0x60005EB")]
				[Address(RVA = "0x10BFA10", Offset = "0x10BFA10", VA = "0x10BFA10")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x10C0530", Offset = "0x10C0530", VA = "0x10C0530")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x10BF3B8", Offset = "0x10BF3B8", VA = "0x10BF3B8")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x10C0528", Offset = "0x10C0528", VA = "0x10C0528")]
			public References()
			{
			}
		}

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x7F7C98", Offset = "0x7F7C98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7C98", Offset = "0x7F7C98")]
		public References references;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7D14", Offset = "0x7F7D14")]
		public IKSolverVR solver;

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x10BF26C", Offset = "0x10BF26C", VA = "0x10BF26C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800160", Offset = "0x800160")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x10BF2D8", Offset = "0x10BF2D8", VA = "0x10BF2D8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800198", Offset = "0x800198")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x10BF344", Offset = "0x10BF344", VA = "0x10BF344")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8001D0", Offset = "0x8001D0")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x10BF390", Offset = "0x10BF390", VA = "0x10BF390")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800208", Offset = "0x800208")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x10BF934", Offset = "0x10BF934", VA = "0x10BF934")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800240", Offset = "0x800240")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x10BF96C", Offset = "0x10BF96C", VA = "0x10BF96C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x10BF974", Offset = "0x10BF974", VA = "0x10BF974", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x10C0310", Offset = "0x10C0310", VA = "0x10C0310", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x10C04A0", Offset = "0x10C04A0", VA = "0x10C04A0")]
		public VRIK()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7F6260", Offset = "0x7F6260")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F6260", Offset = "0x7F6260")]
	public class AimIKJ : MonoBehaviour
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7D4C", Offset = "0x7F7D4C")]
		public Transform target;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7D84", Offset = "0x7F7D84")]
		public Transform poleTarget;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7DBC", Offset = "0x7F7DBC")]
		public Transform aimTransform;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7F7DF4", Offset = "0x7F7DF4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7DF4", Offset = "0x7F7DF4")]
		public float axisX;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7E44", Offset = "0x7F7E44")]
		public float axisY;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7E7C", Offset = "0x7F7E7C")]
		public float axisZ;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7F7EB4", Offset = "0x7F7EB4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7EB4", Offset = "0x7F7EB4")]
		public float poleAxisX;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7F04", Offset = "0x7F7F04")]
		public float poleAxisY;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7F3C", Offset = "0x7F7F3C")]
		public float poleAxisZ;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7F7F74", Offset = "0x7F7F74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7F74", Offset = "0x7F7F74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F7F74", Offset = "0x7F7F74")]
		public float weight;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F7FDC", Offset = "0x7F7FDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F7FDC", Offset = "0x7F7FDC")]
		public float poleWeight;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8030", Offset = "0x7F8030")]
		public float tolerance;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8068", Offset = "0x7F8068")]
		public int maxIterations;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F80A0", Offset = "0x7F80A0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F80A0", Offset = "0x7F80A0")]
		public float clampWeight;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F80F4", Offset = "0x7F80F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F80F4", Offset = "0x7F80F4")]
		public int clampSmoothing;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8148", Offset = "0x7F8148")]
		public bool useRotationLimits;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8180", Offset = "0x7F8180")]
		public bool XY;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7F81B8", Offset = "0x7F81B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F81B8", Offset = "0x7F81B8")]
		public Transform[] bones;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F8208", Offset = "0x7F8208")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private PlayableGraph graph;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AnimationScriptPlayable IKPlayable;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AimIKJob job;

		[Token(Token = "0x1700001F")]
		public bool initiated
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0xF90298", Offset = "0xF90298", VA = "0xF90298")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800278", Offset = "0x800278")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0xF902A0", Offset = "0xF902A0", VA = "0xF902A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800288", Offset = "0x800288")]
			private set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public Vector3 axis
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xF902AC", Offset = "0xF902AC", VA = "0xF902AC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0xF902E8", Offset = "0xF902E8", VA = "0xF902E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public Vector3 poleAxis
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xF902F4", Offset = "0xF902F4", VA = "0xF902F4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0xF90330", Offset = "0xF90330", VA = "0xF90330")]
			set
			{
			}
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xF9033C", Offset = "0xF9033C", VA = "0xF9033C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xF914F4", Offset = "0xF914F4", VA = "0xF914F4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xF918E0", Offset = "0xF918E0", VA = "0xF918E0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xF919E0", Offset = "0xF919E0", VA = "0xF919E0")]
		public AimIKJ()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public struct AimIKJob : IAnimationJob
	{
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TransformSceneHandle _target;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public TransformSceneHandle _poleTarget;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TransformStreamHandle _transform;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PropertySceneHandle _IKPositionWeight;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public PropertySceneHandle _poleWeight;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public PropertySceneHandle _axisX;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public PropertySceneHandle _axisY;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public PropertySceneHandle _axisZ;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public PropertySceneHandle _poleAxisX;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public PropertySceneHandle _poleAxisY;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public PropertySceneHandle _poleAxisZ;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public PropertySceneHandle _clampWeight;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public PropertySceneHandle _clampSmoothing;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public PropertySceneHandle _maxIterations;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public PropertySceneHandle _tolerance;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public PropertySceneHandle _XY;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public PropertySceneHandle _useRotationLimits;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private NativeArray<TransformStreamHandle> bones;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private NativeArray<PropertySceneHandle> boneWeights;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 lastLocalDirection;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float step;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private NativeArray<Vector3> limitAxisArray;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private NativeArray<int> hingeFlags;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private NativeArray<PropertySceneHandle> hingeMinArray;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private NativeArray<PropertySceneHandle> hingeMaxArray;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private NativeArray<Quaternion> hingeLastRotations;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private NativeArray<float> hingeLastAngles;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private NativeArray<int> angleFlags;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private NativeArray<Vector3> angleSecondaryAxisArray;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private NativeArray<PropertySceneHandle> angleLimitArray;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private NativeArray<PropertySceneHandle> angleTwistLimitArray;

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x8C6548", Offset = "0x8C6548", VA = "0x8C6548")]
		public void Setup(Animator animator, Transform[] bones, Transform target, Transform poleTarget, Transform aimTransform)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x8C6550", Offset = "0x8C6550", VA = "0x8C6550")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x8C6558", Offset = "0x8C6558", VA = "0x8C6558")]
		private void DisposeRotationLimits()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x8C6560", Offset = "0x8C6560", VA = "0x8C6560", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x8C6564", Offset = "0x8C6564", VA = "0x8C6564", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x8C65A8", Offset = "0x8C65A8", VA = "0x8C65A8")]
		private void Update(AnimationStream s)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x8C65EC", Offset = "0x8C65EC", VA = "0x8C65EC")]
		private void RotateToTarget(AnimationStream s, Vector3 targetPosition, Vector3 polePosition, int i, float weight, float poleWeight, bool XY, bool useRotationLimits, Vector3 axis, Vector3 poleAxis)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x8C6658", Offset = "0x8C6658", VA = "0x8C6658")]
		public float GetAngle(AnimationStream s, Vector3 axis, Vector3 IKPosition)
		{
			return default(float);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x8C669C", Offset = "0x8C669C", VA = "0x8C669C")]
		private Vector3 GetClampedIKPosition(AnimationStream s, float clampWeight, int clampSmoothing, Vector3 IKPosition, Vector3 transformPosition, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x8C66B0", Offset = "0x8C66B0", VA = "0x8C66B0")]
		private Vector3 GetLocalDirection(AnimationStream s, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x8C66F4", Offset = "0x8C66F4", VA = "0x8C66F4")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x8C66FC", Offset = "0x8C66FC", VA = "0x8C66FC")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7F62E8", Offset = "0x7F62E8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F62E8", Offset = "0x7F62E8")]
	public class CCDIKJ : MonoBehaviour
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8218", Offset = "0x7F8218")]
		public Transform target;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8250", Offset = "0x7F8250")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8250", Offset = "0x7F8250")]
		public float weight;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F82A4", Offset = "0x7F82A4")]
		public float tolerance;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F82DC", Offset = "0x7F82DC")]
		public int maxIterations;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8314", Offset = "0x7F8314")]
		public bool useRotationLimits;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F834C", Offset = "0x7F834C")]
		public bool XY;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8384", Offset = "0x7F8384")]
		public Transform[] bones;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F83BC", Offset = "0x7F83BC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator animator;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PlayableGraph graph;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AnimationScriptPlayable IKPlayable;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CCDIKJob job;

		[Token(Token = "0x17000022")]
		public bool initiated
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0xF97358", Offset = "0xF97358", VA = "0xF97358")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800298", Offset = "0x800298")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xF97360", Offset = "0xF97360", VA = "0xF97360")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8002A8", Offset = "0x8002A8")]
			private set
			{
			}
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xF9736C", Offset = "0xF9736C", VA = "0xF9736C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xF97D3C", Offset = "0xF97D3C", VA = "0xF97D3C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xF97ED8", Offset = "0xF97ED8", VA = "0xF97ED8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xF97FEC", Offset = "0xF97FEC", VA = "0xF97FEC")]
		public CCDIKJ()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public struct CCDIKJob : IAnimationJob
	{
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TransformSceneHandle _target;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PropertySceneHandle _IKPositionWeight;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PropertySceneHandle _maxIterations;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PropertySceneHandle _tolerance;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PropertySceneHandle _XY;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PropertySceneHandle _useRotationLimits;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private NativeArray<TransformStreamHandle> bones;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private NativeArray<PropertySceneHandle> boneWeights;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NativeArray<float> boneSqrMags;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float chainSqrMag;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 lastLocalDirection;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private NativeArray<Vector3> limitAxisArray;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private NativeArray<int> hingeFlags;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private NativeArray<PropertySceneHandle> hingeMinArray;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private NativeArray<PropertySceneHandle> hingeMaxArray;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private NativeArray<Quaternion> hingeLastRotations;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private NativeArray<float> hingeLastAngles;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private NativeArray<int> angleFlags;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private NativeArray<Vector3> angleSecondaryAxisArray;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private NativeArray<PropertySceneHandle> angleLimitArray;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private NativeArray<PropertySceneHandle> angleTwistLimitArray;

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x8C6750", Offset = "0x8C6750", VA = "0x8C6750")]
		public void Setup(Animator animator, Transform[] bones, Transform target)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x8C6758", Offset = "0x8C6758", VA = "0x8C6758")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x8C6760", Offset = "0x8C6760", VA = "0x8C6760")]
		private void DisposeRotationLimits()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x8C6768", Offset = "0x8C6768", VA = "0x8C6768", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x8C676C", Offset = "0x8C676C", VA = "0x8C676C", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x8C67B0", Offset = "0x8C67B0", VA = "0x8C67B0")]
		private void Update(AnimationStream s)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x8C67F4", Offset = "0x8C67F4", VA = "0x8C67F4")]
		private void Read(AnimationStream s)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x8C6838", Offset = "0x8C6838", VA = "0x8C6838")]
		private void Solve(AnimationStream s, Vector3 targetPosition, bool XY, float weight, int it, bool useRotationLimits)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x8C6884", Offset = "0x8C6884", VA = "0x8C6884")]
		private Vector3 GetLocalDirection(AnimationStream s)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x8C68C8", Offset = "0x8C68C8", VA = "0x8C68C8")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x8C68D0", Offset = "0x8C68D0", VA = "0x8C68D0")]
		private Vector3 GetSingularityOffset(AnimationStream s, Vector3 IKPosition, bool useRotationLimits)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x8C6918", Offset = "0x8C6918", VA = "0x8C6918")]
		private bool SingularityDetected(AnimationStream s, Vector3 IKPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x8C6960", Offset = "0x8C6960", VA = "0x8C6960")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class IKJBoneParams : MonoBehaviour
	{
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F83CC", Offset = "0x7F83CC")]
		public float weight;

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x155D4D8", Offset = "0x155D4D8", VA = "0x155D4D8")]
		public IKJBoneParams()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public static class RotationLimitUtilities
	{
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x10BD11C", Offset = "0x10BD11C", VA = "0x10BD11C")]
		public static Quaternion LimitHinge(Quaternion rotation, float min, float max, bool useLimits, Vector3 axis, ref Quaternion lastRotation, ref float lastAngle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x10BD43C", Offset = "0x10BD43C", VA = "0x10BD43C")]
		public static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x10BD520", Offset = "0x10BD520", VA = "0x10BD520")]
		public static Quaternion LimitAngle(Quaternion rotation, Vector3 axis, Vector3 secondaryAxis, float limit, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x10BD588", Offset = "0x10BD588", VA = "0x10BD588")]
		public static Quaternion LimitSwing(Quaternion rotation, Vector3 axis, float limit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x10BD7BC", Offset = "0x10BD7BC", VA = "0x10BD7BC")]
		public static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x200003B")]
	public class FABRIKChain
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F83E4", Offset = "0x7F83E4")]
		public float pull;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F83FC", Offset = "0x7F83FC")]
		public float pin;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xF9B078", Offset = "0xF9B078", VA = "0xF9B078")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xF9B150", Offset = "0xF9B150", VA = "0xF9B150")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xF9B184", Offset = "0xF9B184", VA = "0xF9B184")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xF9B704", Offset = "0xF9B704", VA = "0xF9B704")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xF9B30C", Offset = "0xF9B30C", VA = "0xF9B30C")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xF9B90C", Offset = "0xF9B90C", VA = "0xF9B90C")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xF9BB14", Offset = "0xF9BB14", VA = "0xF9BB14")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xF9C284", Offset = "0xF9C284", VA = "0xF9C284")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xF9C558", Offset = "0xF9C558", VA = "0xF9C558")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xF9C6B8", Offset = "0xF9C6B8", VA = "0xF9C6B8")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C2")]
		public class BendBone
		{
			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC064", Offset = "0x7FC064")]
			public Transform transform;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC09C", Offset = "0x7FC09C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FC09C", Offset = "0x7FC09C")]
			public float weight;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0xFA0A9C", Offset = "0xFA0A9C", VA = "0xFA0A9C")]
			public BendBone()
			{
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0xFA0B1C", Offset = "0xFA0B1C", VA = "0xFA0B1C")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0xF9D340", Offset = "0xF9D340", VA = "0xF9D340")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0xF9D98C", Offset = "0xF9D98C", VA = "0xF9D98C")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8414", Offset = "0x7F8414")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7F844C", Offset = "0x7F844C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F844C", Offset = "0x7F844C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F844C", Offset = "0x7F844C")]
		public float positionWeight;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F84C4", Offset = "0x7F84C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F84C4", Offset = "0x7F84C4")]
		public float bodyWeight;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8518", Offset = "0x7F8518")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8518", Offset = "0x7F8518")]
		public float thighWeight;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F856C", Offset = "0x7F856C")]
		public bool handsPullBody;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7F85A4", Offset = "0x7F85A4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F85A4", Offset = "0x7F85A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F85A4", Offset = "0x7F85A4")]
		public float rotationWeight;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F861C", Offset = "0x7F861C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F861C", Offset = "0x7F861C")]
		public float bodyClampWeight;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8670", Offset = "0x7F8670")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8670", Offset = "0x7F8670")]
		public float headClampWeight;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F86C4", Offset = "0x7F86C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F86C4", Offset = "0x7F86C4")]
		public float bendWeight;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8718", Offset = "0x7F8718")]
		public BendBone[] bendBones;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7F8750", Offset = "0x7F8750")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8750", Offset = "0x7F8750")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8750", Offset = "0x7F8750")]
		public float CCDWeight;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F87C8", Offset = "0x7F87C8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F87C8", Offset = "0x7F87C8")]
		public float roll;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F881C", Offset = "0x7F881C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F881C", Offset = "0x7F881C")]
		public float damper;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8874", Offset = "0x7F8874")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7F88AC", Offset = "0x7F88AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F88AC", Offset = "0x7F88AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F88AC", Offset = "0x7F88AC")]
		public float postStretchWeight;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8924", Offset = "0x7F8924")]
		public float maxStretch;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F895C", Offset = "0x7F895C")]
		public float stretchDamper;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8994", Offset = "0x7F8994")]
		public bool fixHead;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F89CC", Offset = "0x7F89CC")]
		public Transform[] stretchBones;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7F8A04", Offset = "0x7F8A04")]
		public Vector3 chestDirection;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8A3C", Offset = "0x7F8A3C")]
		public float chestDirectionWeight;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xF9C6C0", Offset = "0xF9C6C0", VA = "0xF9C6C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xF9CC48", Offset = "0xF9CC48", VA = "0xF9CC48")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xF9D380", Offset = "0xF9D380", VA = "0xF9D380")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xF9D9E4", Offset = "0xF9D9E4", VA = "0xF9D9E4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xF9E698", Offset = "0xF9E698", VA = "0xF9E698")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xF9EB08", Offset = "0xF9EB08", VA = "0xF9EB08")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xF9EFE8", Offset = "0xF9EFE8", VA = "0xF9EFE8")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xF9FD30", Offset = "0xF9FD30", VA = "0xF9FD30")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xF9E30C", Offset = "0xF9E30C", VA = "0xF9E30C")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xFA0018", Offset = "0xFA0018", VA = "0xFA0018")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xF9FBB0", Offset = "0xF9FBB0", VA = "0xF9FBB0")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xF9FA14", Offset = "0xF9FA14", VA = "0xF9FA14")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xFA047C", Offset = "0xFA047C", VA = "0xFA047C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xFA091C", Offset = "0xFA091C", VA = "0xFA091C")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003E")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x20000C3")]
		public class ChildConstraint
		{
			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC110", Offset = "0x7FC110")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC120", Offset = "0x7FC120")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x17000080")]
			public float nominalDistance
			{
				[Token(Token = "0x60005F2")]
				[Address(RVA = "0xFA5298", Offset = "0xFA5298", VA = "0xFA5298")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801298", Offset = "0x801298")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005F3")]
				[Address(RVA = "0xFA52A0", Offset = "0xFA52A0", VA = "0xFA52A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8012A8", Offset = "0x8012A8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000081")]
			public bool isRigid
			{
				[Token(Token = "0x60005F4")]
				[Address(RVA = "0xFA52A8", Offset = "0xFA52A8", VA = "0xFA52A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8012B8", Offset = "0x8012B8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005F5")]
				[Address(RVA = "0xFA52B0", Offset = "0xFA52B0", VA = "0xFA52B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8012C8", Offset = "0x8012C8")]
				private set
				{
				}
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0xFA52BC", Offset = "0xFA52BC", VA = "0xFA52BC")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0xFA1D24", Offset = "0xFA1D24", VA = "0xFA1D24")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0xFA26A8", Offset = "0xFA26A8", VA = "0xFA26A8")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0xFA4E4C", Offset = "0xFA4E4C", VA = "0xFA4E4C")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C4")]
		public enum Smoothing
		{
			[Token(Token = "0x40005D2")]
			None,
			[Token(Token = "0x40005D3")]
			Exponential,
			[Token(Token = "0x40005D4")]
			Cubic
		}

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8A54", Offset = "0x7F8A54")]
		public float pin;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8A6C", Offset = "0x7F8A6C")]
		public float pull;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8A84", Offset = "0x7F8A84")]
		public float push;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8A9C", Offset = "0x7F8A9C")]
		public float pushParent;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8AB4", Offset = "0x7F8AB4")]
		public float reach;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x40001CC")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xFA0BC0", Offset = "0xFA0BC0", VA = "0xFA0BC0")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xFA0C8C", Offset = "0xFA0C8C", VA = "0xFA0C8C")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xFA0D98", Offset = "0xFA0D98", VA = "0xFA0D98")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xFA0EE8", Offset = "0xFA0EE8", VA = "0xFA0EE8")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xFA0FE8", Offset = "0xFA0FE8", VA = "0xFA0FE8")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xFA1108", Offset = "0xFA1108", VA = "0xFA1108")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xFA1D9C", Offset = "0xFA1D9C", VA = "0xFA1D9C")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xFA139C", Offset = "0xFA139C", VA = "0xFA139C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xFA2988", Offset = "0xFA2988", VA = "0xFA2988")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xFA2E60", Offset = "0xFA2E60", VA = "0xFA2E60")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xFA3390", Offset = "0xFA3390", VA = "0xFA3390")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xFA3AA4", Offset = "0xFA3AA4", VA = "0xFA3AA4")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xFA4594", Offset = "0xFA4594", VA = "0xFA4594")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xFA4A44", Offset = "0xFA4A44", VA = "0xFA4A44")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xFA448C", Offset = "0xFA448C", VA = "0xFA448C")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xFA388C", Offset = "0xFA388C", VA = "0xFA388C")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xFA43E4", Offset = "0xFA43E4", VA = "0xFA43E4")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xFA4C68", Offset = "0xFA4C68", VA = "0xFA4C68")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xFA419C", Offset = "0xFA419C", VA = "0xFA419C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xFA47B8", Offset = "0xFA47B8", VA = "0xFA47B8")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003F")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8ACC", Offset = "0x7F8ACC")]
		public float weight;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F8AE4", Offset = "0x7F8AE4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000023")]
		public bool initiated
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x1559B5C", Offset = "0x1559B5C", VA = "0x1559B5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8002B8", Offset = "0x8002B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x1559B64", Offset = "0x1559B64", VA = "0x1559B64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8002C8", Offset = "0x8002C8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x155997C", Offset = "0x155997C", VA = "0x155997C")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1559B70", Offset = "0x1559B70", VA = "0x1559B70")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1559BF4", Offset = "0x1559BF4", VA = "0x1559BF4")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1559CA0", Offset = "0x1559CA0", VA = "0x1559CA0")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1559CAC", Offset = "0x1559CAC", VA = "0x1559CAC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x155A28C", Offset = "0x155A28C", VA = "0x155A28C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x155A4C4", Offset = "0x155A4C4", VA = "0x155A4C4")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x155AA3C", Offset = "0x155AA3C", VA = "0x155AA3C")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1559FEC", Offset = "0x1559FEC", VA = "0x1559FEC")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x155A13C", Offset = "0x155A13C", VA = "0x155A13C")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	public class IKEffector
	{
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8AF4", Offset = "0x7F8AF4")]
		public float positionWeight;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8B0C", Offset = "0x7F8B0C")]
		public float rotationWeight;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F8B24", Offset = "0x7F8B24")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8B34", Offset = "0x7F8B34")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000024")]
		public bool isEndEffector
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x155B164", Offset = "0x155B164", VA = "0x155B164")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8002D8", Offset = "0x8002D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x155B16C", Offset = "0x155B16C", VA = "0x155B16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8002E8", Offset = "0x8002E8")]
			private set
			{
			}
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x155B0B4", Offset = "0x155B0B4", VA = "0x155B0B4")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x155B178", Offset = "0x155B178", VA = "0x155B178")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x155B260", Offset = "0x155B260", VA = "0x155B260")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x155B39C", Offset = "0x155B39C", VA = "0x155B39C")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x155B4F4", Offset = "0x155B4F4", VA = "0x155B4F4")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x155B84C", Offset = "0x155B84C", VA = "0x155B84C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x155BBFC", Offset = "0x155BBFC", VA = "0x155BBFC")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x155BDD8", Offset = "0x155BDD8", VA = "0x155BDD8")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x155BE98", Offset = "0x155BE98", VA = "0x155BE98")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x155C69C", Offset = "0x155C69C", VA = "0x155C69C")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x155C70C", Offset = "0x155C70C", VA = "0x155C70C")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x155C978", Offset = "0x155C978", VA = "0x155C978")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x155CDE8", Offset = "0x155CDE8", VA = "0x155CDE8")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000041")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000C5")]
		public class BoneMap
		{
			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000082")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60005FB")]
				[Address(RVA = "0x155D790", Offset = "0x155D790", VA = "0x155D790")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000083")]
			public bool isNodeBone
			{
				[Token(Token = "0x60005FE")]
				[Address(RVA = "0x155D958", Offset = "0x155D958", VA = "0x155D958")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000084")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000612")]
				[Address(RVA = "0x155E010", Offset = "0x155E010", VA = "0x155E010")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x155D73C", Offset = "0x155D73C", VA = "0x155D73C")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x155D864", Offset = "0x155D864", VA = "0x155D864")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x155D8C8", Offset = "0x155D8C8", VA = "0x155D8C8")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x155D968", Offset = "0x155D968", VA = "0x155D968")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x155DA6C", Offset = "0x155DA6C", VA = "0x155DA6C")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x155DA74", Offset = "0x155DA74", VA = "0x155DA74")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x155DC2C", Offset = "0x155DC2C", VA = "0x155DC2C")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x155DD40", Offset = "0x155DD40", VA = "0x155DD40")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x155DE40", Offset = "0x155DE40", VA = "0x155DE40")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x155E284", Offset = "0x155E284", VA = "0x155E284")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0x155E2C4", Offset = "0x155E2C4", VA = "0x155E2C4")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x155E304", Offset = "0x155E304", VA = "0x155E304")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000608")]
			[Address(RVA = "0x155E358", Offset = "0x155E358", VA = "0x155E358")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x155E4CC", Offset = "0x155E4CC", VA = "0x155E4CC")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x155E88C", Offset = "0x155E88C", VA = "0x155E88C")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x155E8E8", Offset = "0x155E8E8", VA = "0x155E8E8")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x155EAB8", Offset = "0x155EAB8", VA = "0x155EAB8")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x155EB30", Offset = "0x155EB30", VA = "0x155EB30")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x155EDCC", Offset = "0x155EDCC", VA = "0x155EDCC")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x155F04C", Offset = "0x155F04C", VA = "0x155F04C")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000610")]
			[Address(RVA = "0x155F194", Offset = "0x155F194", VA = "0x155F194")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x155E630", Offset = "0x155E630", VA = "0x155E630")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x155F3B4", Offset = "0x155F3B4", VA = "0x155F3B4")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x155D4E8", Offset = "0x155D4E8", VA = "0x155D4E8", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x155D4F0", Offset = "0x155D4F0", VA = "0x155D4F0", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x155D4F4", Offset = "0x155D4F4", VA = "0x155D4F4")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x155D62C", Offset = "0x155D62C", VA = "0x155D62C")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x155D734", Offset = "0x155D734", VA = "0x155D734")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000042")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8B4C", Offset = "0x7F8B4C")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x155F3CC", Offset = "0x155F3CC", VA = "0x155F3CC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x155F46C", Offset = "0x155F46C", VA = "0x155F46C")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x155F4F0", Offset = "0x155F4F0", VA = "0x155F4F0")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x155F588", Offset = "0x155F588", VA = "0x155F588")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x155F5B4", Offset = "0x155F5B4", VA = "0x155F5B4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x155F5E4", Offset = "0x155F5E4", VA = "0x155F5E4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x155F690", Offset = "0x155F690", VA = "0x155F690")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x155F6BC", Offset = "0x155F6BC", VA = "0x155F6BC")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000C6")]
		public enum BoneMapType
		{
			[Token(Token = "0x40005EC")]
			Parent,
			[Token(Token = "0x40005ED")]
			Bone1,
			[Token(Token = "0x40005EE")]
			Bone2,
			[Token(Token = "0x40005EF")]
			Bone3
		}

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8B64", Offset = "0x7F8B64")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8B7C", Offset = "0x7F8B7C")]
		public float weight;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x155F6FC", Offset = "0x155F6FC", VA = "0x155F6FC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x155F780", Offset = "0x155F780", VA = "0x155F780")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x155F854", Offset = "0x155F854", VA = "0x155F854")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x155FC24", Offset = "0x155FC24", VA = "0x155FC24")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x155FD24", Offset = "0x155FD24", VA = "0x155FD24")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x155FE50", Offset = "0x155FE50", VA = "0x155FE50")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x155FE5C", Offset = "0x155FE5C", VA = "0x155FE5C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x155FF30", Offset = "0x155FF30", VA = "0x155FF30")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1560014", Offset = "0x1560014", VA = "0x1560014", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1560330", Offset = "0x1560330", VA = "0x1560330")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1560408", Offset = "0x1560408", VA = "0x1560408")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8B94", Offset = "0x7F8B94")]
		public int iterations;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8BAC", Offset = "0x7F8BAC")]
		public float twistWeight;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1560638", Offset = "0x1560638", VA = "0x1560638", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x156095C", Offset = "0x156095C", VA = "0x156095C")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1560A78", Offset = "0x1560A78", VA = "0x1560A78")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1560BC8", Offset = "0x1560BC8", VA = "0x1560BC8")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1560BD8", Offset = "0x1560BD8", VA = "0x1560BD8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1560C70", Offset = "0x1560C70", VA = "0x1560C70")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1560D40", Offset = "0x1560D40", VA = "0x1560D40", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1561764", Offset = "0x1561764", VA = "0x1561764")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x15617B0", Offset = "0x15617B0", VA = "0x15617B0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1561C94", Offset = "0x1561C94", VA = "0x1561C94")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x15622D8", Offset = "0x15622D8", VA = "0x15622D8")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1562534", Offset = "0x1562534", VA = "0x1562534")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1562748", Offset = "0x1562748", VA = "0x1562748")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000C7")]
		public class Point
		{
			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FC130", Offset = "0x7FC130")]
			public float weight;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x1564DF4", Offset = "0x1564DF4", VA = "0x1564DF4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x1564E58", Offset = "0x1564E58", VA = "0x1564E58")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x1565028", Offset = "0x1565028", VA = "0x1565028")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x1565068", Offset = "0x1565068", VA = "0x1565068")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000618")]
			[Address(RVA = "0x15650A8", Offset = "0x15650A8", VA = "0x15650A8")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000619")]
			[Address(RVA = "0x156510C", Offset = "0x156510C", VA = "0x156510C")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600061A")]
			[Address(RVA = "0x15646E8", Offset = "0x15646E8", VA = "0x15646E8")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C8")]
		public class Bone : Point
		{
			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x17000085")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600061B")]
				[Address(RVA = "0x1563ADC", Offset = "0x1563ADC", VA = "0x1563ADC")]
				get
				{
					return null;
				}
				[Token(Token = "0x600061C")]
				[Address(RVA = "0x1563BD8", Offset = "0x1563BD8", VA = "0x1563BD8")]
				set
				{
				}
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0x1563C60", Offset = "0x1563C60", VA = "0x1563C60")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600061E")]
			[Address(RVA = "0x1563F68", Offset = "0x1563F68", VA = "0x1563F68")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600061F")]
			[Address(RVA = "0x1564360", Offset = "0x1564360", VA = "0x1564360")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0x1564610", Offset = "0x1564610", VA = "0x1564610")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000621")]
			[Address(RVA = "0x1564664", Offset = "0x1564664", VA = "0x1564664")]
			public Bone()
			{
			}

			[Token(Token = "0x6000622")]
			[Address(RVA = "0x1564768", Offset = "0x1564768", VA = "0x1564768")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x1564800", Offset = "0x1564800", VA = "0x1564800")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C9")]
		public class Node : Point
		{
			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000624")]
			[Address(RVA = "0x1564D90", Offset = "0x1564D90", VA = "0x1564D90")]
			public Node()
			{
			}

			[Token(Token = "0x6000625")]
			[Address(RVA = "0x1564D94", Offset = "0x1564D94", VA = "0x1564D94")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000626")]
			[Address(RVA = "0x1564DBC", Offset = "0x1564DBC", VA = "0x1564DBC")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000CA")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000CB")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8BD4", Offset = "0x7F8BD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8BD4", Offset = "0x7F8BD4")]
		public float IKPositionWeight;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F8C28", Offset = "0x7F8C28")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000025")]
		public bool initiated
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x15523E8", Offset = "0x15523E8", VA = "0x15523E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8002F8", Offset = "0x8002F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x15630D8", Offset = "0x15630D8", VA = "0x15630D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800308", Offset = "0x800308")]
			private set
			{
			}
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1562C5C", Offset = "0x1562C5C", VA = "0x1562C5C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000262")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x15597B8", Offset = "0x15597B8", VA = "0x15597B8")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x15596D0", Offset = "0x15596D0", VA = "0x15596D0")]
		public void Update()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x15630E4", Offset = "0x15630E4", VA = "0x15630E4", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x15630F0", Offset = "0x15630F0", VA = "0x15630F0")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x15630FC", Offset = "0x15630FC", VA = "0x15630FC")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1563104", Offset = "0x1563104", VA = "0x1563104")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1557F38", Offset = "0x1557F38", VA = "0x1557F38")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x600026D")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x600026E")]
		public abstract void FixTransforms();

		[Token(Token = "0x600026F")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x6000270")]
		protected abstract void OnInitiate();

		[Token(Token = "0x6000271")]
		protected abstract void OnUpdate();

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1563188", Offset = "0x1563188", VA = "0x1563188")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x15631A0", Offset = "0x15631A0", VA = "0x15631A0")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x156331C", Offset = "0x156331C", VA = "0x156331C")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x15633F0", Offset = "0x15633F0", VA = "0x15633F0")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1563AC4", Offset = "0x1563AC4", VA = "0x1563AC4")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8C70", Offset = "0x7F8C70")]
		public float poleWeight;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8C88", Offset = "0x7F8C88")]
		public float clampWeight;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8CA0", Offset = "0x7F8CA0")]
		public int clampSmoothing;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000026")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x15652B8", Offset = "0x15652B8", VA = "0x15652B8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000027")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x156538C", Offset = "0x156538C", VA = "0x156538C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000028")]
		protected override int minBones
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x1566378", Offset = "0x1566378", VA = "0x1566378", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000029")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x1566A08", Offset = "0x1566A08", VA = "0x1566A08", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x15651B0", Offset = "0x15651B0", VA = "0x15651B0")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1565460", Offset = "0x1565460", VA = "0x1565460", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1565768", Offset = "0x1565768", VA = "0x1565768", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x156619C", Offset = "0x156619C", VA = "0x156619C")]
		private void Solve()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1565D74", Offset = "0x1565D74", VA = "0x1565D74")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1566380", Offset = "0x1566380", VA = "0x1566380")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1566B10", Offset = "0x1566B10", VA = "0x1566B10")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8CB8", Offset = "0x7F8CB8")]
		public float IKRotationWeight;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1566BA8", Offset = "0x1566BA8", VA = "0x1566BA8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1567040", Offset = "0x1567040", VA = "0x1567040")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1567100", Offset = "0x1567100", VA = "0x1567100", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x15672EC", Offset = "0x15672EC", VA = "0x15672EC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x15674A8", Offset = "0x15674A8", VA = "0x15674A8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1567520", Offset = "0x1567520", VA = "0x1567520", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x15675AC", Offset = "0x15675AC", VA = "0x15675AC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1567C34", Offset = "0x1567C34", VA = "0x1567C34", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1567C60", Offset = "0x1567C60", VA = "0x1567C60")]
		private void Solve()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1567634", Offset = "0x1567634", VA = "0x1567634")]
		private void Read()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1567D08", Offset = "0x1567D08", VA = "0x1567D08")]
		private void Write()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1568008", Offset = "0x1568008", VA = "0x1568008")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x1568158", Offset = "0x1568158", VA = "0x1568158")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x15682B0", Offset = "0x15682B0", VA = "0x15682B0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1568364", Offset = "0x1568364", VA = "0x1568364", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x15686BC", Offset = "0x15686BC", VA = "0x15686BC")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1569188", Offset = "0x1569188", VA = "0x1569188")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000049")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x1700002A")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x156AB90", Offset = "0x156AB90", VA = "0x156AB90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1569190", Offset = "0x1569190", VA = "0x1569190")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1569DA8", Offset = "0x1569DA8", VA = "0x1569DA8")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1569EE0", Offset = "0x1569EE0", VA = "0x1569EE0", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1569F84", Offset = "0x1569F84", VA = "0x1569F84", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x156A7E0", Offset = "0x156A7E0", VA = "0x156A7E0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x156AB98", Offset = "0x156AB98", VA = "0x156AB98")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x1569264", Offset = "0x1569264", VA = "0x1569264")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1569E8C", Offset = "0x1569E8C", VA = "0x1569E8C")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x156AB18", Offset = "0x156AB18", VA = "0x156AB18")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x15699FC", Offset = "0x15699FC", VA = "0x15699FC")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x156B84C", Offset = "0x156B84C", VA = "0x156B84C")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x156B974", Offset = "0x156B974", VA = "0x156B974")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x156BB0C", Offset = "0x156BB0C", VA = "0x156BB0C")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x156BCA4", Offset = "0x156BCA4", VA = "0x156BCA4")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x156A448", Offset = "0x156A448", VA = "0x156A448")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x156A614", Offset = "0x156A614", VA = "0x156A614")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x156BF44", Offset = "0x156BF44", VA = "0x156BF44")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x156B06C", Offset = "0x156B06C", VA = "0x156B06C")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1569E7C", Offset = "0x1569E7C", VA = "0x1569E7C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x156CA4C", Offset = "0x156CA4C", VA = "0x156CA4C")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x156C13C", Offset = "0x156C13C", VA = "0x156C13C")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x156ACB0", Offset = "0x156ACB0", VA = "0x156ACB0")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x156AE90", Offset = "0x156AE90", VA = "0x156AE90")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x156CC64", Offset = "0x156CC64", VA = "0x156CC64")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004A")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8CD0", Offset = "0x7F8CD0")]
		public float rootPin;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x156CCDC", Offset = "0x156CCDC", VA = "0x156CCDC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x156DC38", Offset = "0x156DC38", VA = "0x156DC38", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x156DD1C", Offset = "0x156DD1C", VA = "0x156DD1C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x156DE24", Offset = "0x156DE24", VA = "0x156DE24", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x156DF90", Offset = "0x156DF90", VA = "0x156DF90")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x156E0E8", Offset = "0x156E0E8", VA = "0x156E0E8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x156E840", Offset = "0x156E840", VA = "0x156E840", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x156EACC", Offset = "0x156EACC", VA = "0x156EACC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x156E914", Offset = "0x156E914", VA = "0x156E914")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x156E41C", Offset = "0x156E41C", VA = "0x156E41C")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x156EBA4", Offset = "0x156EBA4", VA = "0x156EBA4")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8CE8", Offset = "0x7F8CE8")]
		public int iterations;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1489114", Offset = "0x1489114", VA = "0x1489114")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1489248", Offset = "0x1489248", VA = "0x1489248")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x14892B4", Offset = "0x14892B4", VA = "0x14892B4")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1489468", Offset = "0x1489468", VA = "0x1489468")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x148950C", Offset = "0x148950C", VA = "0x148950C")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x14895B0", Offset = "0x14895B0", VA = "0x14895B0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1489810", Offset = "0x1489810", VA = "0x1489810", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1489A38", Offset = "0x1489A38", VA = "0x1489A38", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1489CE0", Offset = "0x1489CE0", VA = "0x1489CE0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1489E2C", Offset = "0x1489E2C", VA = "0x1489E2C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1489F90", Offset = "0x1489F90", VA = "0x1489F90", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x148A194", Offset = "0x148A194", VA = "0x148A194", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x148A3DC", Offset = "0x148A3DC", VA = "0x148A3DC", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x148A834", Offset = "0x148A834", VA = "0x148A834", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x148AE24", Offset = "0x148AE24", VA = "0x148AE24", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x148AE88", Offset = "0x148AE88", VA = "0x148AE88", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x148AFF4", Offset = "0x148AFF4", VA = "0x148AFF4")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x4000255")]
		Body,
		[Token(Token = "0x4000256")]
		LeftShoulder,
		[Token(Token = "0x4000257")]
		RightShoulder,
		[Token(Token = "0x4000258")]
		LeftThigh,
		[Token(Token = "0x4000259")]
		RightThigh,
		[Token(Token = "0x400025A")]
		LeftHand,
		[Token(Token = "0x400025B")]
		RightHand,
		[Token(Token = "0x400025C")]
		LeftFoot,
		[Token(Token = "0x400025D")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x400025F")]
		LeftArm,
		[Token(Token = "0x4000260")]
		RightArm,
		[Token(Token = "0x4000261")]
		LeftLeg,
		[Token(Token = "0x4000262")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8D00", Offset = "0x7F8D00")]
		public float spineStiffness;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8D18", Offset = "0x7F8D18")]
		public float pullBodyVertical;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8D30", Offset = "0x7F8D30")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F8D48", Offset = "0x7F8D48")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700002B")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x148B0CC", Offset = "0x148B0CC", VA = "0x148B0CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x148B2E4", Offset = "0x148B2E4", VA = "0x148B2E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x148B2EC", Offset = "0x148B2EC", VA = "0x148B2EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x148B2F4", Offset = "0x148B2F4", VA = "0x148B2F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x148B2FC", Offset = "0x148B2FC", VA = "0x148B2FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x148B304", Offset = "0x148B304", VA = "0x148B304")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x148B30C", Offset = "0x148B30C", VA = "0x148B30C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x148B314", Offset = "0x148B314", VA = "0x148B314")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x148B31C", Offset = "0x148B31C", VA = "0x148B31C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x148B324", Offset = "0x148B324", VA = "0x148B324")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x148B36C", Offset = "0x148B36C", VA = "0x148B36C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x148B3B4", Offset = "0x148B3B4", VA = "0x148B3B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x148B3FC", Offset = "0x148B3FC", VA = "0x148B3FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x148B444", Offset = "0x148B444", VA = "0x148B444")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x148B488", Offset = "0x148B488", VA = "0x148B488")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x148B4D0", Offset = "0x148B4D0", VA = "0x148B4D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x148B518", Offset = "0x148B518", VA = "0x148B518")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x148B560", Offset = "0x148B560", VA = "0x148B560")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x148E584", Offset = "0x148E584", VA = "0x148E584")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800318", Offset = "0x800318")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x148E590", Offset = "0x148E590", VA = "0x148E590")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800328", Offset = "0x800328")]
			private set
			{
			}
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x148B5A4", Offset = "0x148B5A4", VA = "0x148B5A4")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x148B71C", Offset = "0x148B71C", VA = "0x148B71C")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x148B60C", Offset = "0x148B60C", VA = "0x148B60C")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x148B80C", Offset = "0x148B80C", VA = "0x148B80C")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x148B0D4", Offset = "0x148B0D4", VA = "0x148B0D4")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x148B94C", Offset = "0x148B94C", VA = "0x148B94C")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x148BA5C", Offset = "0x148BA5C", VA = "0x148BA5C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x148BB68", Offset = "0x148BB68", VA = "0x148BB68")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x148BC74", Offset = "0x148BC74", VA = "0x148BC74")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x148BC7C", Offset = "0x148BC7C", VA = "0x148BC7C")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x148BCC0", Offset = "0x148BCC0", VA = "0x148BCC0")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x148BDE4", Offset = "0x148BDE4", VA = "0x148BDE4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x148C0B0", Offset = "0x148C0B0", VA = "0x148C0B0")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x148DCE4", Offset = "0x148DCE4", VA = "0x148DCE4")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x148E27C", Offset = "0x148E27C", VA = "0x148E27C")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x148E33C", Offset = "0x148E33C", VA = "0x148E33C")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x148E0AC", Offset = "0x148E0AC", VA = "0x148E0AC")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x148E194", Offset = "0x148E194", VA = "0x148E194")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x148E59C", Offset = "0x148E59C", VA = "0x148E59C")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x148E674", Offset = "0x148E674", VA = "0x148E674", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x148E870", Offset = "0x148E870", VA = "0x148E870")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x148EA30", Offset = "0x148EA30", VA = "0x148EA30")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x148EC38", Offset = "0x148EC38", VA = "0x148EC38")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x148EEAC", Offset = "0x148EEAC", VA = "0x148EEAC", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x148F3C4", Offset = "0x148F3C4", VA = "0x148F3C4", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x148F500", Offset = "0x148F500", VA = "0x148F500")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x1700003E")]
		protected virtual int minBones
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x148FF98", Offset = "0x148FF98", VA = "0x148FF98", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x148FFA0", Offset = "0x148FFA0", VA = "0x148FFA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x148FFA8", Offset = "0x148FFA8", VA = "0x148FFA8", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000041")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x14907F0", Offset = "0x14907F0", VA = "0x14907F0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000042")]
		protected float positionOffset
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x14909D0", Offset = "0x14909D0", VA = "0x14909D0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x148F50C", Offset = "0x148F50C", VA = "0x148F50C")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x148F724", Offset = "0x148F724", VA = "0x148F724")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x148F8F0", Offset = "0x148F8F0", VA = "0x148F8F0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x148F98C", Offset = "0x148F98C", VA = "0x148F98C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x148FA40", Offset = "0x148FA40", VA = "0x148FA40", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x148FE5C", Offset = "0x148FE5C", VA = "0x148FE5C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x148FE64", Offset = "0x148FE64", VA = "0x148FE64", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x148FFB0", Offset = "0x148FFB0", VA = "0x148FFB0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x148FFB4", Offset = "0x148FFB4", VA = "0x148FFB4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x148FFB8", Offset = "0x148FFB8", VA = "0x148FFB8")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1490A94", Offset = "0x1490A94", VA = "0x1490A94")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1490F64", Offset = "0x1490F64", VA = "0x1490F64")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x14912DC", Offset = "0x14912DC", VA = "0x14912DC")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8D58", Offset = "0x7F8D58")]
		public float IKRotationWeight;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x149134C", Offset = "0x149134C", VA = "0x149134C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x14917E4", Offset = "0x14917E4", VA = "0x14917E4")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x14918AC", Offset = "0x14918AC", VA = "0x14918AC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1491A98", Offset = "0x1491A98", VA = "0x1491A98", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1491C54", Offset = "0x1491C54", VA = "0x1491C54", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1491CDC", Offset = "0x1491CDC", VA = "0x1491CDC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1491D7C", Offset = "0x1491D7C", VA = "0x1491D7C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1492404", Offset = "0x1492404", VA = "0x1492404", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1492430", Offset = "0x1492430", VA = "0x1492430")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1491E04", Offset = "0x1491E04", VA = "0x1491E04")]
		private void Read()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1492568", Offset = "0x1492568", VA = "0x1492568")]
		private void Write()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1493014", Offset = "0x1493014", VA = "0x1493014")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000051")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20000CC")]
		public enum BendModifier
		{
			[Token(Token = "0x4000600")]
			Animation,
			[Token(Token = "0x4000601")]
			Target,
			[Token(Token = "0x4000602")]
			Parent,
			[Token(Token = "0x4000603")]
			Arm,
			[Token(Token = "0x4000604")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20000CD")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x8CFD48", Offset = "0x8CFD48", VA = "0x8CFD48")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8D70", Offset = "0x7F8D70")]
		public float maintainRotationWeight;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8D88", Offset = "0x7F8D88")]
		public float bendModifierWeight;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000043")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x1494C80", Offset = "0x1494C80", VA = "0x1494C80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x149325C", Offset = "0x149325C", VA = "0x149325C")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x14932C0", Offset = "0x14932C0", VA = "0x14932C0")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x14933E8", Offset = "0x14933E8", VA = "0x14933E8", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1493B6C", Offset = "0x1493B6C", VA = "0x1493B6C", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x14948D0", Offset = "0x14948D0", VA = "0x14948D0", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1494A74", Offset = "0x1494A74", VA = "0x1494A74")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1494BF8", Offset = "0x1494BF8", VA = "0x1494BF8")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1493828", Offset = "0x1493828", VA = "0x1493828")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1493CA8", Offset = "0x1493CA8", VA = "0x1493CA8")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000CE")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x17000086")]
			public Vector3 forward
			{
				[Token(Token = "0x6000634")]
				[Address(RVA = "0x1497204", Offset = "0x1497204", VA = "0x1497204")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x1497A58", Offset = "0x1497A58", VA = "0x1497A58")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x149626C", Offset = "0x149626C", VA = "0x149626C")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x14966B0", Offset = "0x14966B0", VA = "0x14966B0")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x14976C8", Offset = "0x14976C8", VA = "0x14976C8")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8DA0", Offset = "0x7F8DA0")]
		public float bodyWeight;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8DB8", Offset = "0x7F8DB8")]
		public float headWeight;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8DD0", Offset = "0x7F8DD0")]
		public float eyesWeight;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8DE8", Offset = "0x7F8DE8")]
		public float clampWeight;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8E00", Offset = "0x7F8E00")]
		public float clampWeightHead;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8E18", Offset = "0x7F8E18")]
		public float clampWeightEyes;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8E30", Offset = "0x7F8E30")]
		public int clampSmoothing;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] headForwards;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x17000044")]
		private bool spineIsValid
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x1495740", Offset = "0x1495740", VA = "0x1495740")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x14959E0", Offset = "0x14959E0", VA = "0x14959E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		private bool headIsValid
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x1495888", Offset = "0x1495888", VA = "0x1495888")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		private bool headIsEmpty
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x1495A14", Offset = "0x1495A14", VA = "0x1495A14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		private bool eyesIsValid
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x1495898", Offset = "0x1495898", VA = "0x1495898")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000049")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x1495A94", Offset = "0x1495A94", VA = "0x1495A94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1494CFC", Offset = "0x1494CFC", VA = "0x1494CFC")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1494D80", Offset = "0x1494D80", VA = "0x1494D80")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1494E2C", Offset = "0x1494E2C", VA = "0x1494E2C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1494EF4", Offset = "0x1494EF4", VA = "0x1494EF4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1494FE0", Offset = "0x1494FE0", VA = "0x1494FE0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x14950EC", Offset = "0x14950EC", VA = "0x14950EC")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1495234", Offset = "0x1495234", VA = "0x1495234", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x14953D4", Offset = "0x14953D4", VA = "0x14953D4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1495590", Offset = "0x1495590", VA = "0x1495590", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1495AC8", Offset = "0x1495AC8", VA = "0x1495AC8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1495DD8", Offset = "0x1495DD8", VA = "0x1495DD8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1495F98", Offset = "0x1495F98", VA = "0x1495F98")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1496298", Offset = "0x1496298", VA = "0x1496298", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x14967FC", Offset = "0x14967FC", VA = "0x14967FC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1496908", Offset = "0x1496908", VA = "0x1496908")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1496C04", Offset = "0x1496C04", VA = "0x1496C04")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1496F00", Offset = "0x1496F00", VA = "0x1496F00")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x14972D8", Offset = "0x14972D8", VA = "0x14972D8")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x149604C", Offset = "0x149604C", VA = "0x149604C")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1497860", Offset = "0x1497860", VA = "0x1497860")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000CF")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000635")]
			[Address(RVA = "0x149947C", Offset = "0x149947C", VA = "0x149947C")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0x149A308", Offset = "0x149A308", VA = "0x149A308")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0x1493314", Offset = "0x1493314", VA = "0x1493314")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0x149A3D0", Offset = "0x149A3D0", VA = "0x149A3D0")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F8E48", Offset = "0x7F8E48")]
		public float IKRotationWeight;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1497A60", Offset = "0x1497A60", VA = "0x1497A60")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1497C84", Offset = "0x1497C84", VA = "0x1497C84")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1497E8C", Offset = "0x1497E8C", VA = "0x1497E8C")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1497E98", Offset = "0x1497E98", VA = "0x1497E98")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1497F1C", Offset = "0x1497F1C", VA = "0x1497F1C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1497F28", Offset = "0x1497F28", VA = "0x1497F28")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1497F30", Offset = "0x1497F30", VA = "0x1497F30", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1498084", Offset = "0x1498084", VA = "0x1498084", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x14981B8", Offset = "0x14981B8", VA = "0x14981B8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1498224", Offset = "0x1498224", VA = "0x1498224", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x14982A8", Offset = "0x14982A8", VA = "0x14982A8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1498798", Offset = "0x1498798", VA = "0x1498798")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1498828", Offset = "0x1498828", VA = "0x1498828")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1498EB4", Offset = "0x1498EB4", VA = "0x1498EB4")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x14990CC", Offset = "0x14990CC", VA = "0x14990CC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1499340", Offset = "0x1499340", VA = "0x1499340")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1499228", Offset = "0x1499228", VA = "0x1499228")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x149963C", Offset = "0x149963C", VA = "0x149963C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x149A3C4", Offset = "0x149A3C4", VA = "0x149A3C4", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x149A3C8", Offset = "0x149A3C8", VA = "0x149A3C8", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x149A3CC", Offset = "0x149A3CC", VA = "0x149A3CC", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1499FD0", Offset = "0x1499FD0", VA = "0x1499FD0")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1494AE8", Offset = "0x1494AE8", VA = "0x1494AE8")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000D0")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000110")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x40007DE")]
				YawPitch,
				[Token(Token = "0x40007DF")]
				FromTo
			}

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC148", Offset = "0x7FC148")]
			public Transform target;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC180", Offset = "0x7FC180")]
			public Transform bendGoal;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC1B8", Offset = "0x7FC1B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FC1B8", Offset = "0x7FC1B8")]
			public float positionWeight;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC20C", Offset = "0x7FC20C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FC20C", Offset = "0x7FC20C")]
			public float rotationWeight;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC260", Offset = "0x7FC260")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC298", Offset = "0x7FC298")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FC298", Offset = "0x7FC298")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC2EC", Offset = "0x7FC2EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FC2EC", Offset = "0x7FC2EC")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC340", Offset = "0x7FC340")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FC340", Offset = "0x7FC340")]
			public float bendGoalWeight;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC394", Offset = "0x7FC394")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FC394", Offset = "0x7FC394")]
			public float swivelOffset;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC3F0", Offset = "0x7FC3F0")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC428", Offset = "0x7FC428")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC460", Offset = "0x7FC460")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FC460", Offset = "0x7FC460")]
			public float armLengthMlp;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC4B8", Offset = "0x7FC4B8")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC530", Offset = "0x7FC530")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC540", Offset = "0x7FC540")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000624")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x4000625")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000087")]
			public Vector3 position
			{
				[Token(Token = "0x6000639")]
				[Address(RVA = "0x14A4358", Offset = "0x14A4358", VA = "0x14A4358")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8012D8", Offset = "0x8012D8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600063A")]
				[Address(RVA = "0x14A4364", Offset = "0x14A4364", VA = "0x14A4364")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8012E8", Offset = "0x8012E8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000088")]
			public Quaternion rotation
			{
				[Token(Token = "0x600063B")]
				[Address(RVA = "0x14A4370", Offset = "0x14A4370", VA = "0x14A4370")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8012F8", Offset = "0x8012F8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600063C")]
				[Address(RVA = "0x14A437C", Offset = "0x14A437C", VA = "0x14A437C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801308", Offset = "0x801308")]
				private set
				{
				}
			}

			[Token(Token = "0x17000089")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600063D")]
				[Address(RVA = "0x14A4388", Offset = "0x14A4388", VA = "0x14A4388")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600063E")]
				[Address(RVA = "0x14A43CC", Offset = "0x14A43CC", VA = "0x14A43CC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600063F")]
				[Address(RVA = "0x14A441C", Offset = "0x14A441C", VA = "0x14A441C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008C")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000640")]
				[Address(RVA = "0x14A4478", Offset = "0x14A4478", VA = "0x14A4478")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x14A44D4", Offset = "0x14A44D4", VA = "0x14A44D4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x14A4F0C", Offset = "0x14A4F0C", VA = "0x14A4F0C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x14A5154", Offset = "0x14A5154", VA = "0x14A5154", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x14A5200", Offset = "0x14A5200", VA = "0x14A5200")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x14A2204", Offset = "0x14A2204", VA = "0x14A2204")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x14A6010", Offset = "0x14A6010", VA = "0x14A6010", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x14A6080", Offset = "0x14A6080", VA = "0x14A6080", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x14A56E8", Offset = "0x14A56E8", VA = "0x14A56E8")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0x14A57C8", Offset = "0x14A57C8", VA = "0x14A57C8")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0x14A63CC", Offset = "0x14A63CC", VA = "0x14A63CC")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0x14A4148", Offset = "0x14A4148", VA = "0x14A4148")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D1")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC550", Offset = "0x7FC550")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC560", Offset = "0x7FC560")]
			private float <mag>k__BackingField;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x1700008D")]
			public float sqrMag
			{
				[Token(Token = "0x6000651")]
				[Address(RVA = "0x14A65BC", Offset = "0x14A65BC", VA = "0x14A65BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801318", Offset = "0x801318")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000652")]
				[Address(RVA = "0x14A65C4", Offset = "0x14A65C4", VA = "0x14A65C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801328", Offset = "0x801328")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008E")]
			public float mag
			{
				[Token(Token = "0x6000653")]
				[Address(RVA = "0x14A57C0", Offset = "0x14A57C0", VA = "0x14A57C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801338", Offset = "0x801338")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000654")]
				[Address(RVA = "0x14A65CC", Offset = "0x14A65CC", VA = "0x14A65CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801348", Offset = "0x801348")]
				private set
				{
				}
			}

			[Token(Token = "0x600064C")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x600064D")]
			public abstract void PreSolve();

			[Token(Token = "0x600064E")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x600064F")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x6000650")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x1492EC8", Offset = "0x1492EC8", VA = "0x1492EC8")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x14A65D4", Offset = "0x14A65D4", VA = "0x14A65D4")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x14A676C", Offset = "0x14A676C", VA = "0x14A676C")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x14A686C", Offset = "0x14A686C", VA = "0x14A686C")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x14A1FA0", Offset = "0x14A1FA0", VA = "0x14A1FA0")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x14A5DF4", Offset = "0x14A5DF4", VA = "0x14A5DF4")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x14A68C0", Offset = "0x14A68C0", VA = "0x14A68C0")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x14A6A60", Offset = "0x14A6A60", VA = "0x14A6A60")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x14A6524", Offset = "0x14A6524", VA = "0x14A6524")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D2")]
		public class Footstep
		{
			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC580", Offset = "0x7FC580")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x1700008F")]
			public bool isStepping
			{
				[Token(Token = "0x600065E")]
				[Address(RVA = "0x14A6A88", Offset = "0x14A6A88", VA = "0x14A6A88")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000090")]
			public float stepProgress
			{
				[Token(Token = "0x600065F")]
				[Address(RVA = "0x14A6A9C", Offset = "0x14A6A9C", VA = "0x14A6A9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801358", Offset = "0x801358")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000660")]
				[Address(RVA = "0x14A6AA4", Offset = "0x14A6AA4", VA = "0x14A6AA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801368", Offset = "0x801368")]
				private set
				{
				}
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x14A6AAC", Offset = "0x14A6AAC", VA = "0x14A6AAC")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0x14A6C40", Offset = "0x14A6C40", VA = "0x14A6C40")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x14A6C88", Offset = "0x14A6C88", VA = "0x14A6C88")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0x14A6D94", Offset = "0x14A6D94", VA = "0x14A6D94")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x14A6F6C", Offset = "0x14A6F6C", VA = "0x14A6F6C")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x14A7158", Offset = "0x14A7158", VA = "0x14A7158")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D3")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC590", Offset = "0x7FC590")]
			public Transform target;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC5C8", Offset = "0x7FC5C8")]
			public Transform bendGoal;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC600", Offset = "0x7FC600")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FC600", Offset = "0x7FC600")]
			public float positionWeight;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC654", Offset = "0x7FC654")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FC654", Offset = "0x7FC654")]
			public float rotationWeight;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC6A8", Offset = "0x7FC6A8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FC6A8", Offset = "0x7FC6A8")]
			public float bendGoalWeight;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC6FC", Offset = "0x7FC6FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FC6FC", Offset = "0x7FC6FC")]
			public float swivelOffset;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC758", Offset = "0x7FC758")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FC758", Offset = "0x7FC758")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC7AC", Offset = "0x7FC7AC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FC7AC", Offset = "0x7FC7AC")]
			public float legLengthMlp;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC804", Offset = "0x7FC804")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC89C", Offset = "0x7FC89C")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC8AC", Offset = "0x7FC8AC")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC8BC", Offset = "0x7FC8BC")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC8CC", Offset = "0x7FC8CC")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 footPosition;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Quaternion footRotation;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 bendNormal;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x17000091")]
			public Vector3 position
			{
				[Token(Token = "0x6000667")]
				[Address(RVA = "0x14A1E1C", Offset = "0x14A1E1C", VA = "0x14A1E1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801378", Offset = "0x801378")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000668")]
				[Address(RVA = "0x14A7378", Offset = "0x14A7378", VA = "0x14A7378")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801388", Offset = "0x801388")]
				private set
				{
				}
			}

			[Token(Token = "0x17000092")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000669")]
				[Address(RVA = "0x14A7384", Offset = "0x14A7384", VA = "0x14A7384")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801398", Offset = "0x801398")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600066A")]
				[Address(RVA = "0x14A7390", Offset = "0x14A7390", VA = "0x14A7390")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8013A8", Offset = "0x8013A8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000093")]
			public bool hasToes
			{
				[Token(Token = "0x600066B")]
				[Address(RVA = "0x14A739C", Offset = "0x14A739C", VA = "0x14A739C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8013B8", Offset = "0x8013B8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600066C")]
				[Address(RVA = "0x14A73A4", Offset = "0x14A73A4", VA = "0x14A73A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8013C8", Offset = "0x8013C8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000094")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600066D")]
				[Address(RVA = "0x14A73B0", Offset = "0x14A73B0", VA = "0x14A73B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			private VirtualBone calf
			{
				[Token(Token = "0x600066E")]
				[Address(RVA = "0x14A73F4", Offset = "0x14A73F4", VA = "0x14A73F4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000096")]
			private VirtualBone foot
			{
				[Token(Token = "0x600066F")]
				[Address(RVA = "0x14A743C", Offset = "0x14A743C", VA = "0x14A743C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000097")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000670")]
				[Address(RVA = "0x14A7484", Offset = "0x14A7484", VA = "0x14A7484")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000098")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000671")]
				[Address(RVA = "0x14A1DC0", Offset = "0x14A1DC0", VA = "0x14A1DC0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000672")]
				[Address(RVA = "0x14A74CC", Offset = "0x14A74CC", VA = "0x14A74CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8013D8", Offset = "0x8013D8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000673")]
				[Address(RVA = "0x14A74D8", Offset = "0x14A74D8", VA = "0x14A74D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8013E8", Offset = "0x8013E8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x14A74E4", Offset = "0x14A74E4", VA = "0x14A74E4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x14A7CFC", Offset = "0x14A7CFC", VA = "0x14A7CFC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x14A8590", Offset = "0x14A8590", VA = "0x14A8590", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x14A848C", Offset = "0x14A848C", VA = "0x14A848C")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x14A8254", Offset = "0x14A8254", VA = "0x14A8254")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x1492868", Offset = "0x1492868", VA = "0x1492868")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x14A8BA8", Offset = "0x14A8BA8", VA = "0x14A8BA8")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x14A918C", Offset = "0x14A918C", VA = "0x14A918C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x14A94D4", Offset = "0x14A94D4", VA = "0x14A94D4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x1493168", Offset = "0x1493168", VA = "0x1493168")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D4")]
		public class Locomotion
		{
			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC8DC", Offset = "0x7FC8DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FC8DC", Offset = "0x7FC8DC")]
			public float weight;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC930", Offset = "0x7FC930")]
			public float footDistance;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC968", Offset = "0x7FC968")]
			public float stepThreshold;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC9A0", Offset = "0x7FC9A0")]
			public float angleThreshold;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC9D8", Offset = "0x7FC9D8")]
			public float comAngleMlp;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCA10", Offset = "0x7FCA10")]
			public float maxVelocity;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCA48", Offset = "0x7FCA48")]
			public float velocityFactor;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCA80", Offset = "0x7FCA80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FCA80", Offset = "0x7FCA80")]
			public float maxLegStretch;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCAD8", Offset = "0x7FCAD8")]
			public float rootSpeed;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCB10", Offset = "0x7FCB10")]
			public float stepSpeed;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCB48", Offset = "0x7FCB48")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCB80", Offset = "0x7FCB80")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCBB8", Offset = "0x7FCBB8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FCBB8", Offset = "0x7FCBB8")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCC10", Offset = "0x7FCC10")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCC48", Offset = "0x7FCC48")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCC80", Offset = "0x7FCC80")]
			public Vector3 offset;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCCF8", Offset = "0x7FCCF8")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCD30", Offset = "0x7FCD30")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FCD68", Offset = "0x7FCD68")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x1700009A")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x600067E")]
				[Address(RVA = "0x14A9584", Offset = "0x14A9584", VA = "0x14A9584")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8013F8", Offset = "0x8013F8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600067F")]
				[Address(RVA = "0x14A9590", Offset = "0x14A9590", VA = "0x14A9590")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801408", Offset = "0x801408")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009B")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000685")]
				[Address(RVA = "0x14A9A04", Offset = "0x14A9A04", VA = "0x14A9A04")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009C")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000686")]
				[Address(RVA = "0x14A9A5C", Offset = "0x14A9A5C", VA = "0x14A9A5C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009D")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000687")]
				[Address(RVA = "0x14A9AB8", Offset = "0x14A9AB8", VA = "0x14A9AB8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x1700009E")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000688")]
				[Address(RVA = "0x14A9B10", Offset = "0x14A9B10", VA = "0x14A9B10")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x149F880", Offset = "0x149F880", VA = "0x149F880")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x149CB6C", Offset = "0x149CB6C", VA = "0x149CB6C")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x149BCB4", Offset = "0x149BCB4", VA = "0x149BCB4")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x149BAF8", Offset = "0x149BAF8", VA = "0x149BAF8")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000684")]
			[Address(RVA = "0x14A024C", Offset = "0x14A024C", VA = "0x14A024C")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x14A95EC", Offset = "0x14A95EC", VA = "0x14A95EC")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x14A9790", Offset = "0x14A9790", VA = "0x14A9790")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x14A9838", Offset = "0x14A9838", VA = "0x14A9838")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0x14A4270", Offset = "0x14A4270", VA = "0x14A4270")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D5")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCD78", Offset = "0x7FCD78")]
			public Transform headTarget;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCDB0", Offset = "0x7FCDB0")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCDE8", Offset = "0x7FCDE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FCDE8", Offset = "0x7FCDE8")]
			public float positionWeight;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCE3C", Offset = "0x7FCE3C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FCE3C", Offset = "0x7FCE3C")]
			public float rotationWeight;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCE90", Offset = "0x7FCE90")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FCE90", Offset = "0x7FCE90")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCEE4", Offset = "0x7FCEE4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FCEE4", Offset = "0x7FCEE4")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCF38", Offset = "0x7FCF38")]
			public Transform chestGoal;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCF70", Offset = "0x7FCF70")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FCF70", Offset = "0x7FCF70")]
			public float chestGoalWeight;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCFC4", Offset = "0x7FCFC4")]
			public float minHeadHeight;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCFFC", Offset = "0x7FCFFC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FCFFC", Offset = "0x7FCFFC")]
			public float bodyPosStiffness;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD050", Offset = "0x7FD050")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FD050", Offset = "0x7FD050")]
			public float bodyRotStiffness;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD0A4", Offset = "0x7FD0A4")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7FD0A4", Offset = "0x7FD0A4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FD0A4", Offset = "0x7FD0A4")]
			public float neckStiffness;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD11C", Offset = "0x7FD11C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FD11C", Offset = "0x7FD11C")]
			public float rotateChestByHands;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD170", Offset = "0x7FD170")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FD170", Offset = "0x7FD170")]
			public float chestClampWeight;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD1C4", Offset = "0x7FD1C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FD1C4", Offset = "0x7FD1C4")]
			public float headClampWeight;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD218", Offset = "0x7FD218")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD250", Offset = "0x7FD250")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FD250", Offset = "0x7FD250")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD2A4", Offset = "0x7FD2A4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FD2A4", Offset = "0x7FD2A4")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FD3DC", Offset = "0x7FD3DC")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private Quaternion headRotation;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private int pelvisIndex;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int spineIndex;

			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int chestIndex;

			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int neckIndex;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int headIndex;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private float length;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private bool hasChest;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20D")]
			private bool hasNeck;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20E")]
			private bool hasLegs;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private float headHeight;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float sizeMlp;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private Vector3 chestForward;

			[Token(Token = "0x1700009F")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x600068D")]
				[Address(RVA = "0x149CF2C", Offset = "0x149CF2C", VA = "0x149CF2C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A0")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600068E")]
				[Address(RVA = "0x14A9B6C", Offset = "0x14A9B6C", VA = "0x14A9B6C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A1")]
			public VirtualBone chest
			{
				[Token(Token = "0x600068F")]
				[Address(RVA = "0x14A219C", Offset = "0x14A219C", VA = "0x14A219C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A2")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000690")]
				[Address(RVA = "0x14A9BBC", Offset = "0x14A9BBC", VA = "0x14A9BBC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			public VirtualBone head
			{
				[Token(Token = "0x6000691")]
				[Address(RVA = "0x14A959C", Offset = "0x14A959C", VA = "0x14A959C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A4")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000692")]
				[Address(RVA = "0x14A9C0C", Offset = "0x14A9C0C", VA = "0x14A9C0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801418", Offset = "0x801418")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000693")]
				[Address(RVA = "0x14A9C20", Offset = "0x14A9C20", VA = "0x14A9C20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801428", Offset = "0x801428")]
				private set
				{
				}
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x14A9C34", Offset = "0x14A9C34", VA = "0x14A9C34", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x14AAA04", Offset = "0x14AAA04", VA = "0x14AAA04", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x14AAC64", Offset = "0x14AAC64", VA = "0x14AAC64", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x14AB224", Offset = "0x14AB224", VA = "0x14AB224")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0x149FC68", Offset = "0x149FC68", VA = "0x149FC68")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x14ABC28", Offset = "0x14ABC28", VA = "0x14ABC28")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x14AC3D8", Offset = "0x14AC3D8", VA = "0x14AC3D8")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x14AC778", Offset = "0x14AC778", VA = "0x14AC778", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x14ACAF4", Offset = "0x14ACAF4", VA = "0x14ACAF4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x14AB458", Offset = "0x14AB458", VA = "0x14AB458")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x14A1E28", Offset = "0x14A1E28", VA = "0x14A1E28")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x14AB810", Offset = "0x14AB810", VA = "0x14AB810")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x14ACBEC", Offset = "0x14ACBEC", VA = "0x14ACBEC")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x14AC134", Offset = "0x14AC134", VA = "0x14AC134")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x14ABE3C", Offset = "0x14ABE3C", VA = "0x14ABE3C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x14A3F7C", Offset = "0x14A3F7C", VA = "0x14A3F7C")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D6")]
		public enum PositionOffset
		{
			[Token(Token = "0x40006A8")]
			Pelvis,
			[Token(Token = "0x40006A9")]
			Chest,
			[Token(Token = "0x40006AA")]
			Head,
			[Token(Token = "0x40006AB")]
			LeftHand,
			[Token(Token = "0x40006AC")]
			RightHand,
			[Token(Token = "0x40006AD")]
			LeftFoot,
			[Token(Token = "0x40006AE")]
			RightFoot,
			[Token(Token = "0x40006AF")]
			LeftHeel,
			[Token(Token = "0x40006B0")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000D7")]
		public enum RotationOffset
		{
			[Token(Token = "0x40006B2")]
			Pelvis,
			[Token(Token = "0x40006B3")]
			Chest,
			[Token(Token = "0x40006B4")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000D8")]
		public class VirtualBone
		{
			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x10A30C8", Offset = "0x10A30C8", VA = "0x10A30C8")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x10A3144", Offset = "0x10A3144", VA = "0x10A3144")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x10A3164", Offset = "0x10A3164", VA = "0x10A3164")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x10A34A0", Offset = "0x10A34A0", VA = "0x10A34A0")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x10A39E4", Offset = "0x10A39E4", VA = "0x10A39E4")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x10A3C70", Offset = "0x10A3C70", VA = "0x10A3C70")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x10A3F78", Offset = "0x10A3F78", VA = "0x10A3F78")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x10A4288", Offset = "0x10A4288", VA = "0x10A4288")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x10A4388", Offset = "0x10A4388", VA = "0x10A4388")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x10A4AAC", Offset = "0x10A4AAC", VA = "0x10A4AAC")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x10A4CC4", Offset = "0x10A4CC4", VA = "0x10A4CC4")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x10A5324", Offset = "0x10A5324", VA = "0x10A5324")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x10A542C", Offset = "0x10A542C", VA = "0x10A542C")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8E60", Offset = "0x7F8E60")]
		public bool plantFeet;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F8E98", Offset = "0x7F8E98")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8EA8", Offset = "0x7F8EA8")]
		public Spine spine;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8EE0", Offset = "0x7F8EE0")]
		public Arm leftArm;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8F18", Offset = "0x7F8F18")]
		public Arm rightArm;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8F50", Offset = "0x7F8F50")]
		public Leg leftLeg;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8F88", Offset = "0x7F8F88")]
		public Leg rightLeg;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8FC0", Offset = "0x7F8FC0")]
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

		[Token(Token = "0x1700004A")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x149CB64", Offset = "0x149CB64", VA = "0x149CB64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800338", Offset = "0x800338")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x149F878", Offset = "0x149F878", VA = "0x149F878")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800348", Offset = "0x800348")]
			private set
			{
			}
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x149A3D8", Offset = "0x149A3D8", VA = "0x149A3D8")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x149A958", Offset = "0x149A958", VA = "0x149A958")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x149A774", Offset = "0x149A774", VA = "0x149A774")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x149B55C", Offset = "0x149B55C", VA = "0x149B55C")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x149B6F8", Offset = "0x149B6F8", VA = "0x149B6F8")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x149B79C", Offset = "0x149B79C", VA = "0x149B79C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x149B944", Offset = "0x149B944", VA = "0x149B944")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x149C098", Offset = "0x149C098", VA = "0x149C098")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x149CF7C", Offset = "0x149CF7C", VA = "0x149CF7C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x149D1B0", Offset = "0x149D1B0", VA = "0x149D1B0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x149D41C", Offset = "0x149D41C", VA = "0x149D41C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x149D490", Offset = "0x149D490", VA = "0x149D490", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x149D504", Offset = "0x149D504", VA = "0x149D504", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x149D734", Offset = "0x149D734", VA = "0x149D734")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x149AD18", Offset = "0x149AD18", VA = "0x149AD18")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x149AF08", Offset = "0x149AF08", VA = "0x149AF08")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x149B3E4", Offset = "0x149B3E4", VA = "0x149B3E4")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x149C254", Offset = "0x149C254", VA = "0x149C254")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x149DA78", Offset = "0x149DA78", VA = "0x149DA78", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x149DAC0", Offset = "0x149DAC0", VA = "0x149DAC0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x149F3C8", Offset = "0x149F3C8", VA = "0x149F3C8")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x149C478", Offset = "0x149C478", VA = "0x149C478")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x149DB3C", Offset = "0x149DB3C", VA = "0x149DB3C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x149F7C4", Offset = "0x149F7C4", VA = "0x149F7C4")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x149F820", Offset = "0x149F820", VA = "0x149F820")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x149F1EC", Offset = "0x149F1EC", VA = "0x149F1EC")]
		private void Write()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x14A36D4", Offset = "0x14A36D4", VA = "0x14A36D4")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x14A3DD4", Offset = "0x14A3DD4", VA = "0x14A3DD4")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F8FF8", Offset = "0x7F8FF8")]
		public Transform parent;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9030", Offset = "0x7F9030")]
		public Transform child;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9068", Offset = "0x7F9068")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F9068", Offset = "0x7F9068")]
		public float weight;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F90BC", Offset = "0x7F90BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F90BC", Offset = "0x7F90BC")]
		public float parentChildCrossfade;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9110", Offset = "0x7F9110")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F9110", Offset = "0x7F9110")]
		public float twistAngleOffset;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x10BE5A4", Offset = "0x10BE5A4", VA = "0x10BE5A4")]
		public void Relax()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x10BE9E8", Offset = "0x10BE9E8", VA = "0x10BE9E8")]
		private void Start()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x10BEF5C", Offset = "0x10BEF5C", VA = "0x10BEF5C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x10BEFE4", Offset = "0x10BEFE4", VA = "0x10BEFE4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x10BF06C", Offset = "0x10BF06C", VA = "0x10BF06C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x10BF1D8", Offset = "0x10BF1D8", VA = "0x10BF1D8")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public class InteractionEffector
	{
		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F916C", Offset = "0x7F916C")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F917C", Offset = "0x7F917C")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F918C", Offset = "0x7F918C")]
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

		[Token(Token = "0x1700004B")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x10A5E5C", Offset = "0x10A5E5C", VA = "0x10A5E5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800358", Offset = "0x800358")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x10A5E64", Offset = "0x10A5E64", VA = "0x10A5E64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800368", Offset = "0x800368")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public bool isPaused
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x10A5E6C", Offset = "0x10A5E6C", VA = "0x10A5E6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800378", Offset = "0x800378")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x10A5E74", Offset = "0x10A5E74", VA = "0x10A5E74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800388", Offset = "0x800388")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x10A5E80", Offset = "0x10A5E80", VA = "0x10A5E80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800398", Offset = "0x800398")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x10A5E88", Offset = "0x10A5E88", VA = "0x10A5E88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8003A8", Offset = "0x8003A8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public bool inInteraction
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x10A5E90", Offset = "0x10A5E90", VA = "0x10A5E90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		public float progress
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x10A9874", Offset = "0x10A9874", VA = "0x10A9874")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x10A5F00", Offset = "0x10A5F00", VA = "0x10A5F00")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x10A5F84", Offset = "0x10A5F84", VA = "0x10A5F84")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x10A6060", Offset = "0x10A6060", VA = "0x10A6060")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x10A6294", Offset = "0x10A6294", VA = "0x10A6294")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x10A67FC", Offset = "0x10A67FC", VA = "0x10A67FC")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x10A6E20", Offset = "0x10A6E20", VA = "0x10A6E20")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x10A6EAC", Offset = "0x10A6EAC", VA = "0x10A6EAC")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x10A7CC8", Offset = "0x10A7CC8", VA = "0x10A7CC8")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x10A8C28", Offset = "0x10A8C28", VA = "0x10A8C28")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x10A90EC", Offset = "0x10A90EC", VA = "0x10A90EC")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x10A96D4", Offset = "0x10A96D4", VA = "0x10A96D4")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x10A9FC8", Offset = "0x10A9FC8", VA = "0x10A9FC8")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class InteractionLookAt
	{
		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F919C", Offset = "0x7F919C")]
		public LookAtIK ik;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F91D4", Offset = "0x7F91D4")]
		public float lerpSpeed;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F920C", Offset = "0x7F920C")]
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

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x10AA330", Offset = "0x10AA330", VA = "0x10AA330")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x10AA53C", Offset = "0x10AA53C", VA = "0x10AA53C")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x10AA604", Offset = "0x10AA604", VA = "0x10AA604")]
		public void Update()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x10AA8C0", Offset = "0x10AA8C0", VA = "0x10AA8C0")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x10AAA54", Offset = "0x10AAA54", VA = "0x10AAA54")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x10AAB78", Offset = "0x10AAB78", VA = "0x10AAB78")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F6370", Offset = "0x7F6370")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F6370", Offset = "0x7F6370")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D9")]
		public class InteractionEvent
		{
			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD3EC", Offset = "0x7FD3EC")]
			public float time;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD424", Offset = "0x7FD424")]
			public bool pause;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD45C", Offset = "0x7FD45C")]
			public bool pickUp;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD494", Offset = "0x7FD494")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD4CC", Offset = "0x7FD4CC")]
			public Message[] messages;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD504", Offset = "0x7FD504")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x10A98B0", Offset = "0x10A98B0", VA = "0x10A98B0")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x10AC390", Offset = "0x10AC390", VA = "0x10AC390")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DA")]
		public class Message
		{
			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD53C", Offset = "0x7FD53C")]
			public string function;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD574", Offset = "0x7FD574")]
			public GameObject recipient;

			[Token(Token = "0x40006C4")]
			private const string empty = "";

			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x10AC294", Offset = "0x10AC294", VA = "0x10AC294")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x10AC398", Offset = "0x10AC398", VA = "0x10AC398")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DB")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD5AC", Offset = "0x7FD5AC")]
			public Animator animator;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD5E4", Offset = "0x7FD5E4")]
			public Animation animation;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD61C", Offset = "0x7FD61C")]
			public string animationState;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD654", Offset = "0x7FD654")]
			public float crossfadeTime;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD68C", Offset = "0x7FD68C")]
			public int layer;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD6C4", Offset = "0x7FD6C4")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40006CB")]
			private const string empty = "";

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x10ABF70", Offset = "0x10ABF70", VA = "0x10ABF70")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x10AC06C", Offset = "0x10AC06C", VA = "0x10AC06C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x10AC154", Offset = "0x10AC154", VA = "0x10AC154")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x10AC280", Offset = "0x10AC280", VA = "0x10AC280")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DC")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x2000111")]
			public enum Type
			{
				[Token(Token = "0x40007E1")]
				PositionWeight,
				[Token(Token = "0x40007E2")]
				RotationWeight,
				[Token(Token = "0x40007E3")]
				PositionOffsetX,
				[Token(Token = "0x40007E4")]
				PositionOffsetY,
				[Token(Token = "0x40007E5")]
				PositionOffsetZ,
				[Token(Token = "0x40007E6")]
				Pull,
				[Token(Token = "0x40007E7")]
				Reach,
				[Token(Token = "0x40007E8")]
				RotateBoneWeight,
				[Token(Token = "0x40007E9")]
				Push,
				[Token(Token = "0x40007EA")]
				PushParent,
				[Token(Token = "0x40007EB")]
				PoserWeight
			}

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD6FC", Offset = "0x7FD6FC")]
			public Type type;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD734", Offset = "0x7FD734")]
			public AnimationCurve curve;

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x10AB4D4", Offset = "0x10AB4D4", VA = "0x10AB4D4")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x10AC3B0", Offset = "0x10AC3B0", VA = "0x10AC3B0")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DD")]
		public class Multiplier
		{
			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD76C", Offset = "0x7FD76C")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD7A4", Offset = "0x7FD7A4")]
			public float multiplier;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD7DC", Offset = "0x7FD7DC")]
			public WeightCurve.Type result;

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x10ABD78", Offset = "0x10ABD78", VA = "0x10ABD78")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x10AC3A0", Offset = "0x10AC3A0", VA = "0x10AC3A0")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9254", Offset = "0x7F9254")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F928C", Offset = "0x7F928C")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F92C4", Offset = "0x7F92C4")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F92FC", Offset = "0x7F92FC")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F930C", Offset = "0x7F930C")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000050")]
		public float length
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x10A76AC", Offset = "0x10A76AC", VA = "0x10A76AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800508", Offset = "0x800508")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x10AAD54", Offset = "0x10AAD54", VA = "0x10AAD54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800518", Offset = "0x800518")]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x10AAD5C", Offset = "0x10AAD5C", VA = "0x10AAD5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800528", Offset = "0x800528")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x10AAD64", Offset = "0x10AAD64", VA = "0x10AAD64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800538", Offset = "0x800538")]
			private set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x10AB07C", Offset = "0x10AB07C", VA = "0x10AB07C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x10A9E6C", Offset = "0x10A9E6C", VA = "0x10A9E6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x10AAB8C", Offset = "0x10AAB8C", VA = "0x10AAB8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8003B8", Offset = "0x8003B8")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x10AABD8", Offset = "0x10AABD8", VA = "0x10AABD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8003F0", Offset = "0x8003F0")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x10AAC24", Offset = "0x10AAC24", VA = "0x10AAC24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800428", Offset = "0x800428")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x10AAC70", Offset = "0x10AAC70", VA = "0x10AAC70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800460", Offset = "0x800460")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x10AACBC", Offset = "0x10AACBC", VA = "0x10AACBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800498", Offset = "0x800498")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x10AAD08", Offset = "0x10AAD08", VA = "0x10AAD08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8004D0", Offset = "0x8004D0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x10AAD6C", Offset = "0x10AAD6C", VA = "0x10AAD6C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x10AB10C", Offset = "0x10AB10C", VA = "0x10AB10C")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x10A75AC", Offset = "0x10A75AC", VA = "0x10A75AC")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x10AB2D8", Offset = "0x10AB2D8", VA = "0x10AB2D8")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x10A73CC", Offset = "0x10A73CC", VA = "0x10A73CC")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x10A75A4", Offset = "0x10A75A4", VA = "0x10A75A4")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x10A85B8", Offset = "0x10A85B8", VA = "0x10A85B8")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x10A93AC", Offset = "0x10A93AC", VA = "0x10A93AC")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x10ABDC4", Offset = "0x10ABDC4", VA = "0x10ABDC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x10AB514", Offset = "0x10AB514", VA = "0x10AB514")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x10AB2E0", Offset = "0x10AB2E0", VA = "0x10AB2E0")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x10ABCC8", Offset = "0x10ABCC8", VA = "0x10ABCC8")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x10ABDC8", Offset = "0x10ABDC8", VA = "0x10ABDC8")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x10ABE78", Offset = "0x10ABE78", VA = "0x10ABE78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800548", Offset = "0x800548")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x10ABEC4", Offset = "0x10ABEC4", VA = "0x10ABEC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800580", Offset = "0x800580")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x10ABF10", Offset = "0x10ABF10", VA = "0x10ABF10")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F63D0", Offset = "0x7F63D0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F63D0", Offset = "0x7F63D0")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000DE")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000DF")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F931C", Offset = "0x7F931C")]
		public string targetTag;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9354", Offset = "0x7F9354")]
		public float fadeInTime;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F938C", Offset = "0x7F938C")]
		public float speed;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F93C4", Offset = "0x7F93C4")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F93FC", Offset = "0x7F93FC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F93FC", Offset = "0x7F93FC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7F93FC", Offset = "0x7F93FC")]
		public Collider characterCollider;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9480", Offset = "0x7F9480")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7F9480", Offset = "0x7F9480")]
		public Transform FPSCamera;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F94E0", Offset = "0x7F94E0")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9518", Offset = "0x7F9518")]
		public float camRaycastDistance;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F9550", Offset = "0x7F9550")]
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
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7F9560", Offset = "0x7F9560")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9560", Offset = "0x7F9560")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F95C0", Offset = "0x7F95C0")]
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

		[Token(Token = "0x17000054")]
		public bool inInteraction
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x10AC580", Offset = "0x10AC580", VA = "0x10AC580")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x10A6058", Offset = "0x10A6058", VA = "0x10A6058")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x10AEEFC", Offset = "0x10AEEFC", VA = "0x10AEEFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x10ADA6C", Offset = "0x10ADA6C", VA = "0x10ADA6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800708", Offset = "0x800708")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x10AEF04", Offset = "0x10AEF04", VA = "0x10AEF04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800718", Offset = "0x800718")]
			private set
			{
			}
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x10AC3B8", Offset = "0x10AC3B8", VA = "0x10AC3B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8005B8", Offset = "0x8005B8")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x10AC404", Offset = "0x10AC404", VA = "0x10AC404")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8005F0", Offset = "0x8005F0")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x10AC450", Offset = "0x10AC450", VA = "0x10AC450")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800628", Offset = "0x800628")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x10AC49C", Offset = "0x10AC49C", VA = "0x10AC49C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800660", Offset = "0x800660")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x10AC4E8", Offset = "0x10AC4E8", VA = "0x10AC4E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800698", Offset = "0x800698")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x10AC534", Offset = "0x10AC534", VA = "0x10AC534")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8006D0", Offset = "0x8006D0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x10AC760", Offset = "0x10AC760", VA = "0x10AC760")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x10AC8B8", Offset = "0x10AC8B8", VA = "0x10AC8B8")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x10ACA10", Offset = "0x10ACA10", VA = "0x10ACA10")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x10ACB0C", Offset = "0x10ACB0C", VA = "0x10ACB0C")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x10ACC8C", Offset = "0x10ACC8C", VA = "0x10ACC8C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x10ACE30", Offset = "0x10ACE30", VA = "0x10ACE30")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x10ACF40", Offset = "0x10ACF40", VA = "0x10ACF40")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x10AD050", Offset = "0x10AD050", VA = "0x10AD050")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x10AD160", Offset = "0x10AD160", VA = "0x10AD160")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x10AD204", Offset = "0x10AD204", VA = "0x10AD204")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x10AD2A8", Offset = "0x10AD2A8", VA = "0x10AD2A8")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x10AD340", Offset = "0x10AD340", VA = "0x10AD340")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x10AD440", Offset = "0x10AD440", VA = "0x10AD440")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x10AD568", Offset = "0x10AD568", VA = "0x10AD568")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x10AD698", Offset = "0x10AD698", VA = "0x10AD698")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x10ADA74", Offset = "0x10ADA74", VA = "0x10ADA74")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x10ADD24", Offset = "0x10ADD24", VA = "0x10ADD24")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x10AE0E4", Offset = "0x10AE0E4", VA = "0x10AE0E4")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x10AE488", Offset = "0x10AE488", VA = "0x10AE488")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x10AE4E4", Offset = "0x10AE4E4", VA = "0x10AE4E4")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x10AE5DC", Offset = "0x10AE5DC", VA = "0x10AE5DC")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x10AE754", Offset = "0x10AE754", VA = "0x10AE754")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x10AE90C", Offset = "0x10AE90C", VA = "0x10AE90C")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x10AEDA4", Offset = "0x10AEDA4", VA = "0x10AEDA4")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x10AE21C", Offset = "0x10AE21C", VA = "0x10AE21C")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x10AEF0C", Offset = "0x10AEF0C", VA = "0x10AEF0C")]
		private void Start()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x10AF884", Offset = "0x10AF884", VA = "0x10AF884")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x10AF8B4", Offset = "0x10AF8B4", VA = "0x10AF8B4")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x10AF8E0", Offset = "0x10AF8E0", VA = "0x10AF8E0")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x10AF90C", Offset = "0x10AF90C", VA = "0x10AF90C")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x10AF990", Offset = "0x10AF990", VA = "0x10AF990")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x10AFAC8", Offset = "0x10AFAC8", VA = "0x10AFAC8")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x10AFBD4", Offset = "0x10AFBD4", VA = "0x10AFBD4")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x10AFFA8", Offset = "0x10AFFA8", VA = "0x10AFFA8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x10B0094", Offset = "0x10B0094", VA = "0x10B0094")]
		private void Update()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x10B035C", Offset = "0x10B035C", VA = "0x10B035C")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x10AF5C4", Offset = "0x10AF5C4", VA = "0x10AF5C4")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x10B04B0", Offset = "0x10B04B0", VA = "0x10B04B0")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x10B0644", Offset = "0x10B0644", VA = "0x10B0644")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x10B06F4", Offset = "0x10B06F4", VA = "0x10B06F4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x10B081C", Offset = "0x10B081C", VA = "0x10B081C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x10B0848", Offset = "0x10B0848", VA = "0x10B0848")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x10AC67C", Offset = "0x10AC67C", VA = "0x10AC67C")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x10AD93C", Offset = "0x10AD93C", VA = "0x10AD93C")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x10B0DB0", Offset = "0x10B0DB0", VA = "0x10B0DB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800728", Offset = "0x800728")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x10B0DFC", Offset = "0x10B0DFC", VA = "0x10B0DFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800760", Offset = "0x800760")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x10B0E48", Offset = "0x10B0E48", VA = "0x10B0E48")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F6430", Offset = "0x7F6430")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F6430", Offset = "0x7F6430")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E0")]
		public class Multiplier
		{
			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD814", Offset = "0x7FD814")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD84C", Offset = "0x7FD84C")]
			public float multiplier;

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x10B16F8", Offset = "0x10B16F8", VA = "0x10B16F8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F95F8", Offset = "0x7F95F8")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9630", Offset = "0x7F9630")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9668", Offset = "0x7F9668")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F96A0", Offset = "0x7F96A0")]
		public Transform pivot;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F96D8", Offset = "0x7F96D8")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9710", Offset = "0x7F9710")]
		public float twistWeight;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9748", Offset = "0x7F9748")]
		public float swingWeight;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9780", Offset = "0x7F9780")]
		public bool rotateOnce;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x10B140C", Offset = "0x10B140C", VA = "0x10B140C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800798", Offset = "0x800798")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x10B1458", Offset = "0x10B1458", VA = "0x10B1458")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8007D0", Offset = "0x8007D0")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x10B14A4", Offset = "0x10B14A4", VA = "0x10B14A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800808", Offset = "0x800808")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x10B14F0", Offset = "0x10B14F0", VA = "0x10B14F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800840", Offset = "0x800840")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x10B153C", Offset = "0x10B153C", VA = "0x10B153C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800878", Offset = "0x800878")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x10B1588", Offset = "0x10B1588", VA = "0x10B1588")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8008B0", Offset = "0x8008B0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x10AB3D4", Offset = "0x10AB3D4", VA = "0x10AB3D4")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x10A9EFC", Offset = "0x10A9EFC", VA = "0x10A9EFC")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x10A76B4", Offset = "0x10A76B4", VA = "0x10A76B4")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x10B15D4", Offset = "0x10B15D4", VA = "0x10B15D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8008E8", Offset = "0x8008E8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x10B1620", Offset = "0x10B1620", VA = "0x10B1620")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800920", Offset = "0x800920")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x10B166C", Offset = "0x10B166C", VA = "0x10B166C")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F6490", Offset = "0x7F6490")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F6490", Offset = "0x7F6490")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E1")]
		public class CharacterPosition
		{
			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD884", Offset = "0x7FD884")]
			public bool use;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD8BC", Offset = "0x7FD8BC")]
			public Vector2 offset;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD8F4", Offset = "0x7FD8F4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FD8F4", Offset = "0x7FD8F4")]
			public float angleOffset;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD950", Offset = "0x7FD950")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FD950", Offset = "0x7FD950")]
			public float maxAngle;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD9A8", Offset = "0x7FD9A8")]
			public float radius;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD9E0", Offset = "0x7FD9E0")]
			public bool orbit;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDA18", Offset = "0x7FDA18")]
			public bool fixYAxis;

			[Token(Token = "0x170000A5")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60006C6")]
				[Address(RVA = "0x10B1ECC", Offset = "0x10B1ECC", VA = "0x10B1ECC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A6")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60006C7")]
				[Address(RVA = "0x10B1F08", Offset = "0x10B1F08", VA = "0x10B1F08")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x10B2000", Offset = "0x10B2000", VA = "0x10B2000")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x10B26D4", Offset = "0x10B26D4", VA = "0x10B26D4")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E2")]
		public class CameraPosition
		{
			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDA50", Offset = "0x7FDA50")]
			public Collider lookAtTarget;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDA88", Offset = "0x7FDA88")]
			public Vector3 direction;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDAC0", Offset = "0x7FDAC0")]
			public float maxDistance;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDAF8", Offset = "0x7FDAF8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FDAF8", Offset = "0x7FDAF8")]
			public float maxAngle;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDB50", Offset = "0x7FDB50")]
			public bool fixYAxis;

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x10B1988", Offset = "0x10B1988", VA = "0x10B1988")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x10B1B5C", Offset = "0x10B1B5C", VA = "0x10B1B5C")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x10B1E40", Offset = "0x10B1E40", VA = "0x10B1E40")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E3")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x2000112")]
			public class Interaction
			{
				[Token(Token = "0x40007EC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEDD8", Offset = "0x7FEDD8")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40007ED")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEE10", Offset = "0x7FEE10")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x600076E")]
				[Address(RVA = "0x10B26F8", Offset = "0x10B26F8", VA = "0x10B26F8")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDBF8", Offset = "0x7FDBF8")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDC30", Offset = "0x7FDC30")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDC68", Offset = "0x7FDC68")]
			public Interaction[] interactions;

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x10B17E8", Offset = "0x10B17E8", VA = "0x10B17E8")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x10B26E8", Offset = "0x10B26E8", VA = "0x10B26E8")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F97B8", Offset = "0x7F97B8")]
		public Range[] ranges;

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x10B1700", Offset = "0x10B1700", VA = "0x10B1700")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800958", Offset = "0x800958")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x10B174C", Offset = "0x10B174C", VA = "0x10B174C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800990", Offset = "0x800990")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x10B1798", Offset = "0x10B1798", VA = "0x10B1798")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8009C8", Offset = "0x8009C8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x10B17E4", Offset = "0x10B17E4", VA = "0x10B17E4")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x10AFDBC", Offset = "0x10AFDBC", VA = "0x10AFDBC")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x10B1928", Offset = "0x10B1928", VA = "0x10B1928")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000E4")]
		public class Map
		{
			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0xFA7B08", Offset = "0xFA7B08", VA = "0xFA7B08")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0xFA8050", Offset = "0xFA8050", VA = "0xFA8050")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0xFA7FC4", Offset = "0xFA7FC4", VA = "0xFA7FC4")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0xFA7D18", Offset = "0xFA7D18", VA = "0xFA7D18")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xFA7778", Offset = "0xFA7778", VA = "0xFA7778", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800A00", Offset = "0x800A00")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xFA7BDC", Offset = "0xFA7BDC", VA = "0xFA7BDC", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xFA7BE0", Offset = "0xFA7BE0", VA = "0xFA7BE0", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xFA7F2C", Offset = "0xFA7F2C", VA = "0xFA7F2C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xFA7B44", Offset = "0xFA7B44", VA = "0xFA7B44")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xFA7A40", Offset = "0xFA7A40", VA = "0xFA7A40")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xFA80B4", Offset = "0xFA80B4", VA = "0xFA80B4")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1556298", Offset = "0x1556298", VA = "0x1556298", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1556354", Offset = "0x1556354", VA = "0x1556354", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x15565B4", Offset = "0x15565B4", VA = "0x15565B4", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1556744", Offset = "0x1556744", VA = "0x1556744", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x15563B0", Offset = "0x15563B0", VA = "0x15563B0")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1556C68", Offset = "0x1556C68", VA = "0x1556C68")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F97F0", Offset = "0x7F97F0")]
		public float weight;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F9808", Offset = "0x7F9808")]
		public float localRotationWeight;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F9820", Offset = "0x7F9820")]
		public float localPositionWeight;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000402")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x10B5918", Offset = "0x10B5918", VA = "0x10B5918")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x6000404")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000405")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000406")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x10B5924", Offset = "0x10B5924", VA = "0x10B5924", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x10B5978", Offset = "0x10B5978", VA = "0x10B5978", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x10B59B4", Offset = "0x10B59B4", VA = "0x10B59B4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x10B59CC", Offset = "0x10B59CC", VA = "0x10B59CC")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7F64F0", Offset = "0x7F64F0")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000E5")]
		public class Rigidbone
		{
			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x10B60A4", Offset = "0x10B60A4", VA = "0x10B60A4")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x10B70B8", Offset = "0x10B70B8", VA = "0x10B70B8")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x10B6E00", Offset = "0x10B6E00", VA = "0x10B6E00")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000E6")]
		public class Child
		{
			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x10B623C", Offset = "0x10B623C", VA = "0x10B623C")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x10B7294", Offset = "0x10B7294", VA = "0x10B7294")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x10B7230", Offset = "0x10B7230", VA = "0x10B7230")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6C70", Offset = "0x7F6C70")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000A7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006DC")]
				[Address(RVA = "0x10B7A2C", Offset = "0x10B7A2C", VA = "0x10B7A2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006DE")]
				[Address(RVA = "0x10B7A9C", Offset = "0x10B7A9C", VA = "0x10B7A9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x10B62AC", Offset = "0x10B62AC", VA = "0x10B62AC")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x10B7704", Offset = "0x10B7704", VA = "0x10B7704", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x10B7708", Offset = "0x10B7708", VA = "0x10B7708", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x10B7A34", Offset = "0x10B7A34", VA = "0x10B7A34", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9838", Offset = "0x7F9838")]
		public IK ik;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9870", Offset = "0x7F9870")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F98A8", Offset = "0x7F98A8")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F98E0", Offset = "0x7F98E0")]
		public float applyVelocity;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9918", Offset = "0x7F9918")]
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

		[Token(Token = "0x17000057")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x10B5A14", Offset = "0x10B5A14", VA = "0x10B5A14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		private bool ikUsed
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x10B6814", Offset = "0x10B6814", VA = "0x10B6814")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x10B59DC", Offset = "0x10B59DC", VA = "0x10B59DC")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x10B5AB4", Offset = "0x10B5AB4", VA = "0x10B5AB4")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x10B5C00", Offset = "0x10B5C00", VA = "0x10B5C00")]
		public void Start()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x10B5B8C", Offset = "0x10B5B8C", VA = "0x10B5B8C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x800A38", Offset = "0x800A38")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x10B62D8", Offset = "0x10B62D8", VA = "0x10B62D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x10B6674", Offset = "0x10B6674", VA = "0x10B6674")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x10B6744", Offset = "0x10B6744", VA = "0x10B6744")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x10B69D8", Offset = "0x10B69D8", VA = "0x10B69D8")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x10B67D8", Offset = "0x10B67D8", VA = "0x10B67D8")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x10B6994", Offset = "0x10B6994", VA = "0x10B6994")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x10B6A8C", Offset = "0x10B6A8C", VA = "0x10B6A8C")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x10B6A0C", Offset = "0x10B6A0C", VA = "0x10B6A0C")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x10B5B0C", Offset = "0x10B5B0C", VA = "0x10B5B0C")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x10B66B4", Offset = "0x10B66B4", VA = "0x10B66B4")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x10B74CC", Offset = "0x10B74CC", VA = "0x10B74CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x10B7638", Offset = "0x10B7638", VA = "0x10B7638")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x2000060")]
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

		[Token(Token = "0x17000059")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x10B9724", Offset = "0x10B9724", VA = "0x10B9724")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700005A")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x10B9760", Offset = "0x10B9760", VA = "0x10B9760")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x10B9360", Offset = "0x10B9360", VA = "0x10B9360")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x10B93AC", Offset = "0x10B93AC", VA = "0x10B93AC")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x10B963C", Offset = "0x10B963C", VA = "0x10B963C")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x10B96EC", Offset = "0x10B96EC", VA = "0x10B96EC")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000423")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x10B954C", Offset = "0x10B954C", VA = "0x10B954C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x10B9830", Offset = "0x10B9830", VA = "0x10B9830")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x10B9834", Offset = "0x10B9834", VA = "0x10B9834")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x10B9868", Offset = "0x10B9868", VA = "0x10B9868")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x10B994C", Offset = "0x10B994C", VA = "0x10B994C")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x10B9BCC", Offset = "0x10B9BCC", VA = "0x10B9BCC")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x10B9C88", Offset = "0x10B9C88", VA = "0x10B9C88")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F6554", Offset = "0x7F6554")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F6554", Offset = "0x7F6554")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F9960", Offset = "0x7F9960")]
		public float limit;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F997C", Offset = "0x7F997C")]
		public float twistLimit;

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x10B9D00", Offset = "0x10B9D00", VA = "0x10B9D00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800A9C", Offset = "0x800A9C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x10B9D4C", Offset = "0x10B9D4C", VA = "0x10B9D4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800AD4", Offset = "0x800AD4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x10B9D98", Offset = "0x10B9D98", VA = "0x10B9D98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800B0C", Offset = "0x800B0C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x10B9DE4", Offset = "0x10B9DE4", VA = "0x10B9DE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800B44", Offset = "0x800B44")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x10B9E30", Offset = "0x10B9E30", VA = "0x10B9E30", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x10B9EE8", Offset = "0x10B9EE8", VA = "0x10B9EE8")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x10BA130", Offset = "0x10BA130", VA = "0x10BA130")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F65B4", Offset = "0x7F65B4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F65B4", Offset = "0x7F65B4")]
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

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x10BA140", Offset = "0x10BA140", VA = "0x10BA140")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800B7C", Offset = "0x800B7C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x10BA18C", Offset = "0x10BA18C", VA = "0x10BA18C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800BB4", Offset = "0x800BB4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x10BA1D8", Offset = "0x10BA1D8", VA = "0x10BA1D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800BEC", Offset = "0x800BEC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x10BA224", Offset = "0x10BA224", VA = "0x10BA224")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800C24", Offset = "0x800C24")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x10BA270", Offset = "0x10BA270", VA = "0x10BA270", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x10BA298", Offset = "0x10BA298", VA = "0x10BA298")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x10BA598", Offset = "0x10BA598", VA = "0x10BA598")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F6614", Offset = "0x7F6614")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F6614", Offset = "0x7F6614")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000E8")]
		public class ReachCone
		{
			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000A9")]
			public Vector3 o
			{
				[Token(Token = "0x60006DF")]
				[Address(RVA = "0x10BCA8C", Offset = "0x10BCA8C", VA = "0x10BCA8C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AA")]
			public Vector3 a
			{
				[Token(Token = "0x60006E0")]
				[Address(RVA = "0x10BCAD4", Offset = "0x10BCAD4", VA = "0x10BCAD4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AB")]
			public Vector3 b
			{
				[Token(Token = "0x60006E1")]
				[Address(RVA = "0x10BCB20", Offset = "0x10BCB20", VA = "0x10BCB20")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AC")]
			public Vector3 c
			{
				[Token(Token = "0x60006E2")]
				[Address(RVA = "0x10BCB6C", Offset = "0x10BCB6C", VA = "0x10BCB6C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AD")]
			public bool isValid
			{
				[Token(Token = "0x60006E4")]
				[Address(RVA = "0x10BB9C8", Offset = "0x10BB9C8", VA = "0x10BB9C8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x10BC170", Offset = "0x10BC170", VA = "0x10BC170")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x10BC320", Offset = "0x10BC320", VA = "0x10BC320")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E9")]
		public class LimitPoint
		{
			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x10BB9D8", Offset = "0x10BB9D8", VA = "0x10BB9D8")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F99A8", Offset = "0x7F99A8")]
		public float twistLimit;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F99C4", Offset = "0x7F99C4")]
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

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x10BA620", Offset = "0x10BA620", VA = "0x10BA620")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800C5C", Offset = "0x800C5C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x10BA66C", Offset = "0x10BA66C", VA = "0x10BA66C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800C94", Offset = "0x800C94")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x10BA6B8", Offset = "0x10BA6B8", VA = "0x10BA6B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800CCC", Offset = "0x800CCC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x10BA704", Offset = "0x10BA704", VA = "0x10BA704")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800D04", Offset = "0x800D04")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x10BA750", Offset = "0x10BA750", VA = "0x10BA750")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x10BAD8C", Offset = "0x10BAD8C", VA = "0x10BAD8C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x10BAE88", Offset = "0x10BAE88", VA = "0x10BAE88")]
		private void Start()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x10BB554", Offset = "0x10BB554", VA = "0x10BB554")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x10BA7F4", Offset = "0x10BA7F4", VA = "0x10BA7F4")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x10BBA5C", Offset = "0x10BBA5C", VA = "0x10BBA5C")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x10BC4E0", Offset = "0x10BC4E0", VA = "0x10BC4E0")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x10BC524", Offset = "0x10BC524", VA = "0x10BC524")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x10BC66C", Offset = "0x10BC66C", VA = "0x10BC66C")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x10BB1E8", Offset = "0x10BB1E8", VA = "0x10BB1E8")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x10BC7FC", Offset = "0x10BC7FC", VA = "0x10BC7FC")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x10BCA28", Offset = "0x10BCA28", VA = "0x10BCA28")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7F6674", Offset = "0x7F6674")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7F6674", Offset = "0x7F6674")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F9A84", Offset = "0x7F9A84")]
		public float twistLimit;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x10BCBB8", Offset = "0x10BCBB8", VA = "0x10BCBB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800D3C", Offset = "0x800D3C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x10BCC04", Offset = "0x10BCC04", VA = "0x10BCC04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800D74", Offset = "0x800D74")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x10BCC50", Offset = "0x10BCC50", VA = "0x10BCC50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800DAC", Offset = "0x800DAC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x10BCC9C", Offset = "0x10BCC9C", VA = "0x10BCC9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x800DE4", Offset = "0x800DE4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x10BCCE8", Offset = "0x10BCCE8", VA = "0x10BCCE8")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x10BCD20", Offset = "0x10BCD20", VA = "0x10BCD20", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x10BCDD8", Offset = "0x10BCDD8", VA = "0x10BCDD8")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x10BD110", Offset = "0x10BD110", VA = "0x10BD110")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6C80", Offset = "0x7F6C80")]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x170000AE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006EA")]
				[Address(RVA = "0xF90034", Offset = "0xF90034", VA = "0xF90034", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006EC")]
				[Address(RVA = "0xF900A4", Offset = "0xF900A4", VA = "0xF900A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0xF8FDC0", Offset = "0xF8FDC0", VA = "0xF8FDC0")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0xF8FEB8", Offset = "0xF8FEB8", VA = "0xF8FEB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0xF8FEBC", Offset = "0xF8FEBC", VA = "0xF8FEBC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0xF9003C", Offset = "0xF9003C", VA = "0xF9003C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9AD8", Offset = "0x7F9AD8")]
		public AimIK ik;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9B10", Offset = "0x7F9B10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F9B10", Offset = "0x7F9B10")]
		public float weight;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F9B64", Offset = "0x7F9B64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9B64", Offset = "0x7F9B64")]
		public Transform target;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9BC4", Offset = "0x7F9BC4")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9BFC", Offset = "0x7F9BFC")]
		public float weightSmoothTime;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F9C34", Offset = "0x7F9C34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9C34", Offset = "0x7F9C34")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9C94", Offset = "0x7F9C94")]
		public float maxRadiansDelta;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9CCC", Offset = "0x7F9CCC")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9D04", Offset = "0x7F9D04")]
		public float slerpSpeed;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9D3C", Offset = "0x7F9D3C")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9D74", Offset = "0x7F9D74")]
		public float minDistance;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9DAC", Offset = "0x7F9DAC")]
		public Vector3 offset;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F9DE4", Offset = "0x7F9DE4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9DE4", Offset = "0x7F9DE4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F9DE4", Offset = "0x7F9DE4")]
		public float maxRootAngle;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9E60", Offset = "0x7F9E60")]
		public bool turnToTarget;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9E98", Offset = "0x7F9E98")]
		public float turnToTargetTime;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F9ED0", Offset = "0x7F9ED0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9ED0", Offset = "0x7F9ED0")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9F30", Offset = "0x7F9F30")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x1700005B")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000453")]
			[Address(RVA = "0xF8ED00", Offset = "0xF8ED00", VA = "0xF8ED00")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xF8EBD0", Offset = "0xF8EBD0", VA = "0xF8EBD0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xF8EE78", Offset = "0xF8EE78", VA = "0xF8EE78")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xF8F77C", Offset = "0xF8F77C", VA = "0xF8F77C")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xF8F948", Offset = "0xF8F948", VA = "0xF8F948")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xF8FD4C", Offset = "0xF8FD4C", VA = "0xF8FD4C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x800E1C", Offset = "0x800E1C")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xF8FDEC", Offset = "0xF8FDEC", VA = "0xF8FDEC")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000EB")]
		public class Pose
		{
			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0xF94664", Offset = "0xF94664", VA = "0xF94664")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0xF949F8", Offset = "0xF949F8", VA = "0xF949F8")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0xF94A68", Offset = "0xF94A68", VA = "0xF94A68")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xF94504", Offset = "0xF94504", VA = "0xF94504")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xF94900", Offset = "0xF94900", VA = "0xF94900")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xF94A00", Offset = "0xF94A00", VA = "0xF94A00")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000EC")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000113")]
			public class EffectorLink
			{
				[Token(Token = "0x40007EE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEE48", Offset = "0x7FEE48")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40007EF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEE80", Offset = "0x7FEE80")]
				public float weight;

				[Token(Token = "0x600076F")]
				[Address(RVA = "0xF95164", Offset = "0xF95164", VA = "0xF95164")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDCA0", Offset = "0x7FDCA0")]
			public Transform transform;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDCD8", Offset = "0x7FDCD8")]
			public Transform relativeTo;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDD10", Offset = "0x7FDD10")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDD48", Offset = "0x7FDD48")]
			public float verticalWeight;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDD80", Offset = "0x7FDD80")]
			public float horizontalWeight;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDDB8", Offset = "0x7FDDB8")]
			public float speed;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0xF94BE4", Offset = "0xF94BE4", VA = "0xF94BE4")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0xF9513C", Offset = "0xF9513C", VA = "0xF9513C")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0xF9514C", Offset = "0xF9514C", VA = "0xF9514C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9F68", Offset = "0x7F9F68")]
		public Body[] bodies;

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xF94A84", Offset = "0xF94A84", VA = "0xF94A84", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xF95134", Offset = "0xF95134", VA = "0xF95134")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9FA0", Offset = "0x7F9FA0")]
		public float tiltSpeed;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F9FD8", Offset = "0x7F9FD8")]
		public float tiltSensitivity;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA010", Offset = "0x7FA010")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA048", Offset = "0x7FA048")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xF96EE4", Offset = "0xF96EE4", VA = "0xF96EE4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xF96F34", Offset = "0xF96F34", VA = "0xF96F34", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xF971A0", Offset = "0xF971A0", VA = "0xF971A0")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000ED")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDDF0", Offset = "0x7FDDF0")]
			public string name;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDE28", Offset = "0x7FDE28")]
			public Collider collider;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDE60", Offset = "0x7FDE60")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FDEAC", Offset = "0x7FDEAC")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FDEBC", Offset = "0x7FDEBC")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FDECC", Offset = "0x7FDECC")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FDEDC", Offset = "0x7FDEDC")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000B0")]
			public bool inProgress
			{
				[Token(Token = "0x60006F3")]
				[Address(RVA = "0x1556D6C", Offset = "0x1556D6C", VA = "0x1556D6C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000B1")]
			protected float crossFader
			{
				[Token(Token = "0x60006F4")]
				[Address(RVA = "0x15573A4", Offset = "0x15573A4", VA = "0x15573A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8014D8", Offset = "0x8014D8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006F5")]
				[Address(RVA = "0x15573AC", Offset = "0x15573AC", VA = "0x15573AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8014E8", Offset = "0x8014E8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B2")]
			protected float timer
			{
				[Token(Token = "0x60006F6")]
				[Address(RVA = "0x155739C", Offset = "0x155739C", VA = "0x155739C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8014F8", Offset = "0x8014F8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006F7")]
				[Address(RVA = "0x15573B4", Offset = "0x15573B4", VA = "0x15573B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801508", Offset = "0x801508")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B3")]
			protected Vector3 force
			{
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0x15573BC", Offset = "0x15573BC", VA = "0x15573BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801518", Offset = "0x801518")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006F9")]
				[Address(RVA = "0x15573C8", Offset = "0x15573C8", VA = "0x15573C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801528", Offset = "0x801528")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B4")]
			protected Vector3 point
			{
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0x15573D4", Offset = "0x15573D4", VA = "0x15573D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801538", Offset = "0x801538")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006FB")]
				[Address(RVA = "0x15573E0", Offset = "0x15573E0", VA = "0x15573E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801548", Offset = "0x801548")]
				private set
				{
				}
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x1557268", Offset = "0x1557268", VA = "0x1557268")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x1556EB4", Offset = "0x1556EB4", VA = "0x1556EB4")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006FE")]
			protected abstract float GetLength();

			[Token(Token = "0x60006FF")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000700")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x15573EC", Offset = "0x15573EC", VA = "0x15573EC")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EE")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000114")]
			public class EffectorLink
			{
				[Token(Token = "0x40007F0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEEB8", Offset = "0x7FEEB8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40007F1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEEF0", Offset = "0x7FEEF0")]
				public float weight;

				[Token(Token = "0x40007F2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40007F3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000770")]
				[Address(RVA = "0x1557F40", Offset = "0x1557F40", VA = "0x1557F40")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000771")]
				[Address(RVA = "0x1557CDC", Offset = "0x1557CDC", VA = "0x1557CDC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000772")]
				[Address(RVA = "0x15580A0", Offset = "0x15580A0", VA = "0x15580A0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDEEC", Offset = "0x7FDEEC")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDF24", Offset = "0x7FDF24")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDF5C", Offset = "0x7FDF5C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x1557A54", Offset = "0x1557A54", VA = "0x1557A54", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x1557C54", Offset = "0x1557C54", VA = "0x1557C54", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x1557CF0", Offset = "0x1557CF0", VA = "0x1557CF0", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x155808C", Offset = "0x155808C", VA = "0x155808C")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EF")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000115")]
			public class BoneLink
			{
				[Token(Token = "0x40007F4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEF28", Offset = "0x7FEF28")]
				public Transform bone;

				[Token(Token = "0x40007F5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEF60", Offset = "0x7FEF60")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FEF60", Offset = "0x7FEF60")]
				public float weight;

				[Token(Token = "0x40007F6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x40007F7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000773")]
				[Address(RVA = "0x155782C", Offset = "0x155782C", VA = "0x155782C")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000774")]
				[Address(RVA = "0x155756C", Offset = "0x155756C", VA = "0x155756C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000775")]
				[Address(RVA = "0x15579CC", Offset = "0x15579CC", VA = "0x15579CC")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDF94", Offset = "0x7FDF94")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDFCC", Offset = "0x7FDFCC")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x1557400", Offset = "0x1557400", VA = "0x1557400", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x15574DC", Offset = "0x15574DC", VA = "0x15574DC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000708")]
			[Address(RVA = "0x1557588", Offset = "0x1557588", VA = "0x1557588", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x15579B8", Offset = "0x15579B8", VA = "0x15579B8")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA080", Offset = "0x7FA080")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA0B8", Offset = "0x7FA0B8")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700005C")]
		public bool inProgress
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x1556C70", Offset = "0x1556C70", VA = "0x1556C70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1556D80", Offset = "0x1556D80", VA = "0x1556D80", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1557000", Offset = "0x1557000", VA = "0x1557000")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1557394", Offset = "0x1557394", VA = "0x1557394")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000F0")]
		public abstract class Offset
		{
			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE004", Offset = "0x7FE004")]
			public string name;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE03C", Offset = "0x7FE03C")]
			public Collider collider;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE074", Offset = "0x7FE074")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FE0C0", Offset = "0x7FE0C0")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FE0D0", Offset = "0x7FE0D0")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FE0E0", Offset = "0x7FE0E0")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FE0F0", Offset = "0x7FE0F0")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000B5")]
			protected float crossFader
			{
				[Token(Token = "0x600070A")]
				[Address(RVA = "0x15586D8", Offset = "0x15586D8", VA = "0x15586D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801558", Offset = "0x801558")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600070B")]
				[Address(RVA = "0x15586E0", Offset = "0x15586E0", VA = "0x15586E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801568", Offset = "0x801568")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B6")]
			protected float timer
			{
				[Token(Token = "0x600070C")]
				[Address(RVA = "0x15586E8", Offset = "0x15586E8", VA = "0x15586E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801578", Offset = "0x801578")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600070D")]
				[Address(RVA = "0x15586F0", Offset = "0x15586F0", VA = "0x15586F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801588", Offset = "0x801588")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B7")]
			protected Vector3 force
			{
				[Token(Token = "0x600070E")]
				[Address(RVA = "0x15586F8", Offset = "0x15586F8", VA = "0x15586F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801598", Offset = "0x801598")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600070F")]
				[Address(RVA = "0x1558704", Offset = "0x1558704", VA = "0x1558704")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8015A8", Offset = "0x8015A8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B8")]
			protected Vector3 point
			{
				[Token(Token = "0x6000710")]
				[Address(RVA = "0x1558710", Offset = "0x1558710", VA = "0x1558710")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8015B8", Offset = "0x8015B8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000711")]
				[Address(RVA = "0x155871C", Offset = "0x155871C", VA = "0x155871C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8015C8", Offset = "0x8015C8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x1558590", Offset = "0x1558590", VA = "0x1558590")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x15581CC", Offset = "0x15581CC", VA = "0x15581CC")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000714")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000715")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000716")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000717")]
			[Address(RVA = "0x1558728", Offset = "0x1558728", VA = "0x1558728")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F1")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000116")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x40007F8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEFB4", Offset = "0x7FEFB4")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x40007F9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEFEC", Offset = "0x7FEFEC")]
				public float weight;

				[Token(Token = "0x40007FA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40007FB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000776")]
				[Address(RVA = "0x1558D68", Offset = "0x1558D68", VA = "0x1558D68")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000777")]
				[Address(RVA = "0x1558AAC", Offset = "0x1558AAC", VA = "0x1558AAC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000778")]
				[Address(RVA = "0x1558EB8", Offset = "0x1558EB8", VA = "0x1558EB8")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE100", Offset = "0x7FE100")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE138", Offset = "0x7FE138")]
			public int upDirCurveIndex;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE170", Offset = "0x7FE170")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000718")]
			[Address(RVA = "0x155873C", Offset = "0x155873C", VA = "0x155873C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000719")]
			[Address(RVA = "0x1558A24", Offset = "0x1558A24", VA = "0x1558A24", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600071A")]
			[Address(RVA = "0x1558AC0", Offset = "0x1558AC0", VA = "0x1558AC0", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x1558E9C", Offset = "0x1558E9C", VA = "0x1558E9C")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F2")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000117")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x40007FC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FF024", Offset = "0x7FF024")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x40007FD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FF05C", Offset = "0x7FF05C")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FF05C", Offset = "0x7FF05C")]
				public float weight;

				[Token(Token = "0x40007FE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x40007FF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000779")]
				[Address(RVA = "0x1559434", Offset = "0x1559434", VA = "0x1559434")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600077A")]
				[Address(RVA = "0x15590B4", Offset = "0x15590B4", VA = "0x15590B4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600077B")]
				[Address(RVA = "0x15595AC", Offset = "0x15595AC", VA = "0x15595AC")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE1A8", Offset = "0x7FE1A8")]
			public int curveIndex;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE1E0", Offset = "0x7FE1E0")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x1558EC0", Offset = "0x1558EC0", VA = "0x1558EC0", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x1559024", Offset = "0x1559024", VA = "0x1559024", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600071E")]
			[Address(RVA = "0x15590D0", Offset = "0x15590D0", VA = "0x15590D0", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0x1559598", Offset = "0x1559598", VA = "0x1559598")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA0F0", Offset = "0x7FA0F0")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA128", Offset = "0x7FA128")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x15580A8", Offset = "0x15580A8", VA = "0x15580A8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1558320", Offset = "0x1558320", VA = "0x1558320")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x15586D0", Offset = "0x15586D0", VA = "0x15586D0")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000F3")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000118")]
			public class EffectorLink
			{
				[Token(Token = "0x4000800")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FF0B0", Offset = "0x7FF0B0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000801")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FF0E8", Offset = "0x7FF0E8")]
				public float weight;

				[Token(Token = "0x600077C")]
				[Address(RVA = "0x10A5E54", Offset = "0x10A5E54", VA = "0x10A5E54")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE218", Offset = "0x7FE218")]
			public Transform transform;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE250", Offset = "0x7FE250")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE288", Offset = "0x7FE288")]
			public float speed;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE2C0", Offset = "0x7FE2C0")]
			public float acceleration;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE2F8", Offset = "0x7FE2F8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FE2F8", Offset = "0x7FE2F8")]
			public float matchVelocity;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE34C", Offset = "0x7FE34C")]
			public float gravity;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000720")]
			[Address(RVA = "0x10A5778", Offset = "0x10A5778", VA = "0x10A5778")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000721")]
			[Address(RVA = "0x10A5964", Offset = "0x10A5964", VA = "0x10A5964")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x10A5E38", Offset = "0x10A5E38", VA = "0x10A5E38")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA160", Offset = "0x7FA160")]
		public Body[] bodies;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA198", Offset = "0x7FA198")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x10A56E8", Offset = "0x10A56E8", VA = "0x10A56E8")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x10A5868", Offset = "0x10A5868", VA = "0x10A5868", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x10A5E18", Offset = "0x10A5E18", VA = "0x10A5E18")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FA1D0", Offset = "0x7FA1D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA1D0", Offset = "0x7FA1D0")]
		public Transform target;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FA230", Offset = "0x7FA230")]
		public float weight;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA248", Offset = "0x7FA248")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA280", Offset = "0x7FA280")]
		public float weightSmoothTime;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FA2B8", Offset = "0x7FA2B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA2B8", Offset = "0x7FA2B8")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA318", Offset = "0x7FA318")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA350", Offset = "0x7FA350")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA388", Offset = "0x7FA388")]
		public float slerpSpeed;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA3C0", Offset = "0x7FA3C0")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA3F8", Offset = "0x7FA3F8")]
		public float minDistance;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FA430", Offset = "0x7FA430")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA430", Offset = "0x7FA430")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FA430", Offset = "0x7FA430")]
		public float maxRootAngle;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x1700005D")]
		private Vector3 pivot
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x10B2B8C", Offset = "0x10B2B8C", VA = "0x10B2B8C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x10B2A80", Offset = "0x10B2A80", VA = "0x10B2A80")]
		private void Start()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x10B2D04", Offset = "0x10B2D04", VA = "0x10B2D04")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x10B350C", Offset = "0x10B350C", VA = "0x10B350C")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x10B36D8", Offset = "0x10B36D8", VA = "0x10B36D8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x10B3A88", Offset = "0x10B3A88", VA = "0x10B3A88")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F4")]
		public class OffsetLimits
		{
			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE384", Offset = "0x7FE384")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE3BC", Offset = "0x7FE3BC")]
			public float spring;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE3F4", Offset = "0x7FE3F4")]
			public bool x;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE42C", Offset = "0x7FE42C")]
			public bool y;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE464", Offset = "0x7FE464")]
			public bool z;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE49C", Offset = "0x7FE49C")]
			public float minX;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE4D4", Offset = "0x7FE4D4")]
			public float maxX;

			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE50C", Offset = "0x7FE50C")]
			public float minY;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE544", Offset = "0x7FE544")]
			public float maxY;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE57C", Offset = "0x7FE57C")]
			public float minZ;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE5B4", Offset = "0x7FE5B4")]
			public float maxZ;

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x10B3EAC", Offset = "0x10B3EAC", VA = "0x10B3EAC")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000724")]
			[Address(RVA = "0x10B44B8", Offset = "0x10B44B8", VA = "0x10B44B8")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x10B44E8", Offset = "0x10B44E8", VA = "0x10B44E8")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000726")]
			[Address(RVA = "0x10B45C0", Offset = "0x10B45C0", VA = "0x10B45C0")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6C90", Offset = "0x7F6C90")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600072A")]
				[Address(RVA = "0x10B4440", Offset = "0x10B4440", VA = "0x10B4440", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600072C")]
				[Address(RVA = "0x10B44B0", Offset = "0x10B44B0", VA = "0x10B44B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000727")]
			[Address(RVA = "0x10B3D74", Offset = "0x10B3D74", VA = "0x10B3D74")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x10B4290", Offset = "0x10B4290", VA = "0x10B4290", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0x10B4294", Offset = "0x10B4294", VA = "0x10B4294", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x10B4448", Offset = "0x10B4448", VA = "0x10B4448", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA4AC", Offset = "0x7FA4AC")]
		public float weight;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA4E4", Offset = "0x7FA4E4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x1700005E")]
		protected float deltaTime
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x10A5938", Offset = "0x10A5938", VA = "0x10A5938")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000471")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x10B3CD4", Offset = "0x10B3CD4", VA = "0x10B3CD4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x10B3D00", Offset = "0x10B3D00", VA = "0x10B3D00")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x800E80", Offset = "0x800E80")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x10B3DA0", Offset = "0x10B3DA0", VA = "0x10B3DA0")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x10A5D2C", Offset = "0x10A5D2C", VA = "0x10A5D2C")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x10B4130", Offset = "0x10B4130", VA = "0x10B4130", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x10A5E28", Offset = "0x10A5E28", VA = "0x10A5E28")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6CA0", Offset = "0x7F6CA0")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000BB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000730")]
				[Address(RVA = "0x10B4AEC", Offset = "0x10B4AEC", VA = "0x10B4AEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000732")]
				[Address(RVA = "0x10B4B5C", Offset = "0x10B4B5C", VA = "0x10B4B5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600072D")]
			[Address(RVA = "0x10B4694", Offset = "0x10B4694", VA = "0x10B4694")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x10B493C", Offset = "0x10B493C", VA = "0x10B493C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600072F")]
			[Address(RVA = "0x10B4940", Offset = "0x10B4940", VA = "0x10B4940", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000731")]
			[Address(RVA = "0x10B4AF4", Offset = "0x10B4AF4", VA = "0x10B4AF4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA51C", Offset = "0x7FA51C")]
		public float weight;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA554", Offset = "0x7FA554")]
		public VRIK ik;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x1700005F")]
		protected float deltaTime
		{
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x10B45C8", Offset = "0x10B45C8", VA = "0x10B45C8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000479")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x10B45F4", Offset = "0x10B45F4", VA = "0x10B45F4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x10B4620", Offset = "0x10B4620", VA = "0x10B4620")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x800EE4", Offset = "0x800EE4")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x10B46C0", Offset = "0x10B46C0", VA = "0x10B46C0")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x10B47CC", Offset = "0x10B47CC", VA = "0x10B47CC", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x10B492C", Offset = "0x10B492C", VA = "0x10B492C")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F7")]
		public class EffectorLink
		{
			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000733")]
			[Address(RVA = "0x10B4C7C", Offset = "0x10B4C7C", VA = "0x10B4C7C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x10B51B8", Offset = "0x10B51B8", VA = "0x10B51B8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x10B4B64", Offset = "0x10B4B64", VA = "0x10B4B64")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x10B5070", Offset = "0x10B5070", VA = "0x10B5070")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x10B5158", Offset = "0x10B5158", VA = "0x10B5158")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000F8")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x2000119")]
			public class EffectorLink
			{
				[Token(Token = "0x4000802")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FF120", Offset = "0x7FF120")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000803")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FF158", Offset = "0x7FF158")]
				public float weight;

				[Token(Token = "0x600077D")]
				[Address(RVA = "0x10B5910", Offset = "0x10B5910", VA = "0x10B5910")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE5EC", Offset = "0x7FE5EC")]
			public Transform[] raycastFrom;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE624", Offset = "0x7FE624")]
			public Transform raycastTo;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE65C", Offset = "0x7FE65C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FE65C", Offset = "0x7FE65C")]
			public float raycastRadius;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE6B0", Offset = "0x7FE6B0")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE6E8", Offset = "0x7FE6E8")]
			public float smoothTimeIn;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE720", Offset = "0x7FE720")]
			public float smoothTimeOut;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE758", Offset = "0x7FE758")]
			public LayerMask layers;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x6000735")]
			[Address(RVA = "0x10B5274", Offset = "0x10B5274", VA = "0x10B5274")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x10B549C", Offset = "0x10B549C", VA = "0x10B549C")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x10B5680", Offset = "0x10B5680", VA = "0x10B5680")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000738")]
			[Address(RVA = "0x10B58F4", Offset = "0x10B58F4", VA = "0x10B58F4")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA58C", Offset = "0x7FA58C")]
		public Avoider[] avoiders;

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x10B51C0", Offset = "0x10B51C0", VA = "0x10B51C0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x10B548C", Offset = "0x10B548C", VA = "0x10B548C")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000F9")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x200011A")]
			public class EffectorLink
			{
				[Token(Token = "0x4000804")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FF190", Offset = "0x7FF190")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000805")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FF1C8", Offset = "0x7FF1C8")]
				public float weight;

				[Token(Token = "0x600077E")]
				[Address(RVA = "0x10B9358", Offset = "0x10B9358", VA = "0x10B9358")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE790", Offset = "0x7FE790")]
			public Vector3 offset;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE7C8", Offset = "0x7FE7C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FE7C8", Offset = "0x7FE7C8")]
			public float additivity;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE81C", Offset = "0x7FE81C")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE854", Offset = "0x7FE854")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000739")]
			[Address(RVA = "0x10B7D08", Offset = "0x10B7D08", VA = "0x10B7D08")]
			public void Start()
			{
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0x10B8A78", Offset = "0x10B8A78", VA = "0x10B8A78")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0x10B9340", Offset = "0x10B9340", VA = "0x10B9340")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FA")]
		public enum Handedness
		{
			[Token(Token = "0x4000762")]
			Right,
			[Token(Token = "0x4000763")]
			Left
		}

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA5C4", Offset = "0x7FA5C4")]
		public AimIK aimIK;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA5FC", Offset = "0x7FA5FC")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA634", Offset = "0x7FA634")]
		public Handedness handedness;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA66C", Offset = "0x7FA66C")]
		public bool twoHanded;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA6A4", Offset = "0x7FA6A4")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA6DC", Offset = "0x7FA6DC")]
		public float magnitudeRandom;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA714", Offset = "0x7FA714")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA74C", Offset = "0x7FA74C")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA784", Offset = "0x7FA784")]
		public float blendTime;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7FA7BC", Offset = "0x7FA7BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA7BC", Offset = "0x7FA7BC")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x17000060")]
		public bool isFinished
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x10B7AA4", Offset = "0x10B7AA4", VA = "0x10B7AA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000061")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x10B8D60", Offset = "0x10B8D60", VA = "0x10B8D60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x10B8DC0", Offset = "0x10B8DC0", VA = "0x10B8DC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		private Transform primaryHand
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x10B8D08", Offset = "0x10B8D08", VA = "0x10B8D08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		private Transform secondaryHand
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x10B8D34", Offset = "0x10B8D34", VA = "0x10B8D34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x10B7AD4", Offset = "0x10B7AD4", VA = "0x10B7AD4")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x10B7B00", Offset = "0x10B7B00", VA = "0x10B7B00")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x10B7DB8", Offset = "0x10B7DB8", VA = "0x10B7DB8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x10B8E20", Offset = "0x10B8E20", VA = "0x10B8E20")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x10B8FBC", Offset = "0x10B8FBC", VA = "0x10B8FBC")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x10B9018", Offset = "0x10B9018", VA = "0x10B9018", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x10B928C", Offset = "0x10B928C", VA = "0x10B928C")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA81C", Offset = "0x7FA81C")]
		public float weight;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA854", Offset = "0x7FA854")]
		public float offset;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x10BDA3C", Offset = "0x10BDA3C", VA = "0x10BDA3C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x10BDB78", Offset = "0x10BDB78", VA = "0x10BDB78")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x10BDC90", Offset = "0x10BDC90", VA = "0x10BDC90")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x10BE228", Offset = "0x10BE228", VA = "0x10BE228")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x10BE28C", Offset = "0x10BE28C", VA = "0x10BE28C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x10BE3EC", Offset = "0x10BE3EC", VA = "0x10BE3EC")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000FB")]
		public class Settings
		{
			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE88C", Offset = "0x7FE88C")]
			public float scaleMlp;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE8C4", Offset = "0x7FE8C4")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE8FC", Offset = "0x7FE8FC")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE934", Offset = "0x7FE934")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE96C", Offset = "0x7FE96C")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE9A4", Offset = "0x7FE9A4")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FE9DC", Offset = "0x7FE9DC")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEA14", Offset = "0x7FEA14")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEA4C", Offset = "0x7FEA4C")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7FEA84", Offset = "0x7FEA84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEA84", Offset = "0x7FEA84")]
			public Vector3 headOffset;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEAD4", Offset = "0x7FEAD4")]
			public Vector3 handOffset;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEB0C", Offset = "0x7FEB0C")]
			public float footForwardOffset;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEB44", Offset = "0x7FEB44")]
			public float footInwardOffset;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEB7C", Offset = "0x7FEB7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FEB7C", Offset = "0x7FEB7C")]
			public float footHeadingOffset;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FEBD8", Offset = "0x7FEBD8")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FEBF0", Offset = "0x7FEBF0")]
			public float pelvisRotationWeight;

			[Token(Token = "0x600073C")]
			[Address(RVA = "0x1B271F8", Offset = "0x1B271F8", VA = "0x1B271F8")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FC")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x200011B")]
			public class Target
			{
				[Token(Token = "0x4000806")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x4000807")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x4000808")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x600077F")]
				[Address(RVA = "0x1B2706C", Offset = "0x1B2706C", VA = "0x1B2706C")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000780")]
				[Address(RVA = "0x1B27154", Offset = "0x1B27154", VA = "0x1B27154")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x600073D")]
			[Address(RVA = "0x1B27064", Offset = "0x1B27064", VA = "0x1B27064")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x10C0C28", Offset = "0x10C0C28", VA = "0x10C0C28")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x10C0E20", Offset = "0x10C0E20", VA = "0x10C0E20")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x10C2928", Offset = "0x10C2928", VA = "0x10C2928")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x10C3290", Offset = "0x10C3290", VA = "0x10C3290")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x10C3FEC", Offset = "0x10C3FEC", VA = "0x10C3FEC")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FA88C", Offset = "0x7FA88C")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x17000065")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x1B272F0", Offset = "0x1B272F0", VA = "0x1B272F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800F48", Offset = "0x800F48")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x1B272FC", Offset = "0x1B272FC", VA = "0x1B272FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800F58", Offset = "0x800F58")]
			private set
			{
			}
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1B27308", Offset = "0x1B27308", VA = "0x1B27308")]
		private void Awake()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1B2744C", Offset = "0x1B2744C", VA = "0x1B2744C")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1B276F0", Offset = "0x1B276F0", VA = "0x1B276F0")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1B278C0", Offset = "0x1B278C0", VA = "0x1B278C0")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1B27F90", Offset = "0x1B27F90", VA = "0x1B27F90")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1B280F0", Offset = "0x1B280F0", VA = "0x1B280F0")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000075")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x100DA6C", Offset = "0x100DA6C", VA = "0x100DA6C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x100DB68", Offset = "0x100DB68", VA = "0x100DB68")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA89C", Offset = "0x7FA89C")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x100DB70", Offset = "0x100DB70", VA = "0x100DB70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x100DCFC", Offset = "0x100DCFC", VA = "0x100DCFC")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA8D4", Offset = "0x7FA8D4")]
		public AimPoser aimPoser;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA90C", Offset = "0x7FA90C")]
		public AimIK aim;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA944", Offset = "0x7FA944")]
		public LookAtIK lookAt;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA97C", Offset = "0x7FA97C")]
		public Animator animator;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA9B4", Offset = "0x7FA9B4")]
		public float crossfadeTime;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FA9EC", Offset = "0x7FA9EC")]
		public float minAimDistance;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1023A18", Offset = "0x1023A18", VA = "0x1023A18")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1023A70", Offset = "0x1023A70", VA = "0x1023A70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1023BF8", Offset = "0x1023BF8", VA = "0x1023BF8")]
		private void Pose()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1023EB0", Offset = "0x1023EB0", VA = "0x1023EB0")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x102411C", Offset = "0x102411C", VA = "0x102411C")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1024210", Offset = "0x1024210", VA = "0x1024210")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xF8AAA4", Offset = "0xF8AAA4", VA = "0xF8AAA4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xF8AD6C", Offset = "0xF8AD6C", VA = "0xF8AD6C")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xF8AFC4", Offset = "0xF8AFC4", VA = "0xF8AFC4")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7FAA24", Offset = "0x7FAA24")]
		public Animator animator;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7FAA5C", Offset = "0x7FAA5C")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FAA94", Offset = "0x7FAA94")]
		public float lookAtWeight;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FAAAC", Offset = "0x7FAAAC")]
		public float lookAtBodyWeight;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FAAC4", Offset = "0x7FAAC4")]
		public float lookAtHeadWeight;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FAADC", Offset = "0x7FAADC")]
		public float lookAtEyesWeight;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FAAF4", Offset = "0x7FAAF4")]
		public float lookAtClampWeight;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FAB0C", Offset = "0x7FAB0C")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FAB24", Offset = "0x7FAB24")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7FAB3C", Offset = "0x7FAB3C")]
		public Transform footTargetBiped;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FAB74", Offset = "0x7FAB74")]
		public float footPositionWeight;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FAB8C", Offset = "0x7FAB8C")]
		public float footRotationWeight;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7FABA4", Offset = "0x7FABA4")]
		public Transform handTargetBiped;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FABDC", Offset = "0x7FABDC")]
		public float handPositionWeight;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FABF4", Offset = "0x7FABF4")]
		public float handRotationWeight;

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x100FFF0", Offset = "0x100FFF0", VA = "0x100FFF0")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x10108AC", Offset = "0x10108AC", VA = "0x10108AC")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x101C2AC", Offset = "0x101C2AC", VA = "0x101C2AC")]
		private void Update()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x101CE84", Offset = "0x101CE84", VA = "0x101CE84")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x101CB08", Offset = "0x101CB08", VA = "0x101CB08")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x101D080", Offset = "0x101D080", VA = "0x101D080")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x17000066")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x101D0AC", Offset = "0x101D0AC", VA = "0x101D0AC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x101D14C", Offset = "0x101D14C", VA = "0x101D14C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x101D480", Offset = "0x101D480", VA = "0x101D480")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000FD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6CB0", Offset = "0x7F6CB0")]
		private sealed class <Step>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000BD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000741")]
				[Address(RVA = "0x101E448", Offset = "0x101E448", VA = "0x101E448", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000743")]
				[Address(RVA = "0x101E4B8", Offset = "0x101E4B8", VA = "0x101E4B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600073E")]
			[Address(RVA = "0x101E00C", Offset = "0x101E00C", VA = "0x101E00C")]
			[DebuggerHidden]
			public <Step>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x600073F")]
			[Address(RVA = "0x101E068", Offset = "0x101E068", VA = "0x101E068", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0x101E06C", Offset = "0x101E06C", VA = "0x101E06C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000742")]
			[Address(RVA = "0x101E450", Offset = "0x101E450", VA = "0x101E450", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ParticleSystem sand;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IK ik;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float stepProgress;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lastStepTime;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit hit;

		[Token(Token = "0x17000067")]
		public bool isStepping
		{
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x101D494", Offset = "0x101D494", VA = "0x101D494")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		public Vector3 position
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x101D030", Offset = "0x101D030", VA = "0x101D030")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x101D4A8", Offset = "0x101D4A8", VA = "0x101D4A8")]
			set
			{
			}
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x101D51C", Offset = "0x101D51C", VA = "0x101D51C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x101D574", Offset = "0x101D574", VA = "0x101D574")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x101D79C", Offset = "0x101D79C", VA = "0x101D79C")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x101DC60", Offset = "0x101DC60", VA = "0x101DC60")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x101DDA4", Offset = "0x101DDA4", VA = "0x101DDA4")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x101DCD0", Offset = "0x101DCD0", VA = "0x101DCD0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x800F68", Offset = "0x800F68")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x101E038", Offset = "0x101E038", VA = "0x101E038")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x101E4C0", Offset = "0x101E4C0", VA = "0x101E4C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x101E5B8", Offset = "0x101E5B8", VA = "0x101E5B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x101E88C", Offset = "0x101E88C", VA = "0x101E88C")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FE")]
		public struct Warp
		{
			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEC08", Offset = "0x7FEC08")]
			public int animationLayer;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEC40", Offset = "0x7FEC40")]
			public string animationState;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FEC78", Offset = "0x7FEC78")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FECB0", Offset = "0x7FECB0")]
			public Transform warpFrom;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FECE8", Offset = "0x7FECE8")]
			public Transform warpTo;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FED20", Offset = "0x7FED20")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000FF")]
		public enum EffectorMode
		{
			[Token(Token = "0x400078C")]
			PositionOffset,
			[Token(Token = "0x400078D")]
			Position
		}

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FAC0C", Offset = "0x7FAC0C")]
		public Animator animator;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FAC44", Offset = "0x7FAC44")]
		public EffectorMode effectorMode;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7FAC7C", Offset = "0x7FAC7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FAC7C", Offset = "0x7FAC7C")]
		public Warp[] warps;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x100DD74", Offset = "0x100DD74", VA = "0x100DD74", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x100DDA0", Offset = "0x100DDA0", VA = "0x100DDA0")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x100E00C", Offset = "0x100E00C", VA = "0x100E00C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x100E530", Offset = "0x100E530", VA = "0x100E530")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x100E5F8", Offset = "0x100E5F8", VA = "0x100E5F8")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7F66D4", Offset = "0x7F66D4")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x100E600", Offset = "0x100E600", VA = "0x100E600", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x100E658", Offset = "0x100E658", VA = "0x100E658")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x100E8D4", Offset = "0x100E8D4", VA = "0x100E8D4", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x100EB98", Offset = "0x100EB98", VA = "0x100EB98")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7F6738", Offset = "0x7F6738")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7F6738", Offset = "0x7F6738")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FACCC", Offset = "0x7FACCC")]
		public float headLookWeight;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x100EBAC", Offset = "0x100EBAC", VA = "0x100EBAC", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x100EE1C", Offset = "0x100EE1C", VA = "0x100EE1C", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x100EE90", Offset = "0x100EE90", VA = "0x100EE90")]
		private void Read()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x100F080", Offset = "0x100F080", VA = "0x100F080")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x100F104", Offset = "0x100F104", VA = "0x100F104")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x100F8C0", Offset = "0x100F8C0", VA = "0x100F8C0")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x100F604", Offset = "0x100F604", VA = "0x100F604")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x100FCA0", Offset = "0x100FCA0", VA = "0x100FCA0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x100FE00", Offset = "0x100FE00", VA = "0x100FE00")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7F67C4", Offset = "0x7F67C4")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1011C84", Offset = "0x1011C84", VA = "0x1011C84", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1011CE4", Offset = "0x1011CE4", VA = "0x1011CE4", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x101202C", Offset = "0x101202C", VA = "0x101202C")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x10121F4", Offset = "0x10121F4", VA = "0x10121F4")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7F6828", Offset = "0x7F6828")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CameraController cam;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x17000069")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x1013204", Offset = "0x1013204", VA = "0x1013204")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006A")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x10132A4", Offset = "0x10132A4", VA = "0x10132A4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1012F00", Offset = "0x1012F00", VA = "0x1012F00")]
		private void Start()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1012F74", Offset = "0x1012F74", VA = "0x1012F74")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1013344", Offset = "0x1013344", VA = "0x1013344")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FACF4", Offset = "0x7FACF4")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1015F20", Offset = "0x1015F20", VA = "0x1015F20", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1016680", Offset = "0x1016680", VA = "0x1016680")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1016688", Offset = "0x1016688", VA = "0x1016688")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1016744", Offset = "0x1016744", VA = "0x1016744")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1016DA8", Offset = "0x1016DA8", VA = "0x1016DA8")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1016EC0", Offset = "0x1016EC0", VA = "0x1016EC0")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000100")]
		public class Limb
		{
			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x6000744")]
			[Address(RVA = "0x1017138", Offset = "0x1017138", VA = "0x1017138")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x10172AC", Offset = "0x10172AC", VA = "0x10172AC")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1016F48", Offset = "0x1016F48", VA = "0x1016F48")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x10171FC", Offset = "0x10171FC", VA = "0x10171FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1017298", Offset = "0x1017298", VA = "0x1017298")]
		private void Update()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x101729C", Offset = "0x101729C", VA = "0x101729C")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x10172BC", Offset = "0x10172BC", VA = "0x10172BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1017328", Offset = "0x1017328", VA = "0x1017328")]
		private void Update()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1017448", Offset = "0x1017448", VA = "0x1017448")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FAD0C", Offset = "0x7FAD0C")]
		public Transform target;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FAD44", Offset = "0x7FAD44")]
		public Transform pin;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FAD7C", Offset = "0x7FAD7C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FADB4", Offset = "0x7FADB4")]
		public AimIK aim;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FADEC", Offset = "0x7FADEC")]
		public float weight;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FAE24", Offset = "0x7FAE24")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FAE5C", Offset = "0x7FAE5C")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1017450", Offset = "0x1017450", VA = "0x1017450")]
		private void Start()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x10174A8", Offset = "0x10174A8", VA = "0x10174A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1017734", Offset = "0x1017734", VA = "0x1017734")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x101773C", Offset = "0x101773C", VA = "0x101773C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1017864", Offset = "0x1017864", VA = "0x1017864")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x101793C", Offset = "0x101793C", VA = "0x101793C")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1017F5C", Offset = "0x1017F5C", VA = "0x1017F5C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x10180BC", Offset = "0x10180BC", VA = "0x10180BC")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FAE94", Offset = "0x7FAE94")]
		public float aimWeight;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FAEAC", Offset = "0x7FAEAC")]
		public float sightWeight;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FAEC4", Offset = "0x7FAEC4")]
		public float maxAngle;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform gunTarget;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AimIK gunAim;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Recoil recoil;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FAF50", Offset = "0x7FAF50")]
		private float cameraRecoilWeight;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool updateFrame;

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x10180C4", Offset = "0x10180C4", VA = "0x10180C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1018284", Offset = "0x1018284", VA = "0x1018284")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1018290", Offset = "0x1018290", VA = "0x1018290")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x101870C", Offset = "0x101870C", VA = "0x101870C")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1018A38", Offset = "0x1018A38", VA = "0x1018A38")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x10183DC", Offset = "0x10183DC", VA = "0x10183DC")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x101984C", Offset = "0x101984C", VA = "0x101984C")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7F688C", Offset = "0x7F688C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7F688C", Offset = "0x7F688C")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FAF90", Offset = "0x7FAF90")]
		public float walkSpeed;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x101986C", Offset = "0x101986C", VA = "0x101986C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x10198DC", Offset = "0x10198DC", VA = "0x10198DC")]
		private void Update()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1019A44", Offset = "0x1019A44", VA = "0x1019A44")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1019AF4", Offset = "0x1019AF4", VA = "0x1019AF4")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReaction hitReaction;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1019CDC", Offset = "0x1019CDC", VA = "0x1019CDC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1019EE8", Offset = "0x1019EE8", VA = "0x1019EE8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1019FB8", Offset = "0x1019FB8", VA = "0x1019FB8")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x101A2B4", Offset = "0x101A2B4", VA = "0x101A2B4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x101A4C4", Offset = "0x101A4C4", VA = "0x101A4C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x101AA40", Offset = "0x101AA40", VA = "0x101AA40")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x101AA50", Offset = "0x101AA50", VA = "0x101AA50")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x101AB2C", Offset = "0x101AB2C", VA = "0x101AB2C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x101AD00", Offset = "0x101AD00", VA = "0x101AD00")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x101AD08", Offset = "0x101AD08", VA = "0x101AD08")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x101B158", Offset = "0x101B158", VA = "0x101B158")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7F6918", Offset = "0x7F6918")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FAFC8", Offset = "0x7FAFC8")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB014", Offset = "0x7FB014")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x101B160", Offset = "0x101B160", VA = "0x101B160")]
		private void Awake()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x101B1B8", Offset = "0x101B1B8", VA = "0x101B1B8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x101B460", Offset = "0x101B460", VA = "0x101B460")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000101")]
		public class Partner
		{
			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000BF")]
			private Transform neck
			{
				[Token(Token = "0x6000748")]
				[Address(RVA = "0x101C1BC", Offset = "0x101C1BC", VA = "0x101C1BC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0x101B4B0", Offset = "0x101B4B0", VA = "0x101B4B0")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0x101B570", Offset = "0x101B570", VA = "0x101B570")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0x101BF68", Offset = "0x101BF68", VA = "0x101BF68")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0x101C298", Offset = "0x101C298", VA = "0x101C298")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x101B468", Offset = "0x101B468", VA = "0x101B468")]
		private void Start()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x101B4E4", Offset = "0x101B4E4", VA = "0x101B4E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x101BF58", Offset = "0x101BF58", VA = "0x101BF58")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000102")]
		public enum Mode
		{
			[Token(Token = "0x400079D")]
			Position,
			[Token(Token = "0x400079E")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x2000103")]
		public class Absorber
		{
			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FED58", Offset = "0x7FED58")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FED90", Offset = "0x7FED90")]
			public float weight;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x600074B")]
			[Address(RVA = "0x101EAA4", Offset = "0x101EAA4", VA = "0x101EAA4")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0x101ED50", Offset = "0x101ED50", VA = "0x101ED50")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x600074D")]
			[Address(RVA = "0x101EDB0", Offset = "0x101EDB0", VA = "0x101EDB0")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0x101EFBC", Offset = "0x101EFBC", VA = "0x101EFBC")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0x101F2A0", Offset = "0x101F2A0", VA = "0x101F2A0")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB060", Offset = "0x7FB060")]
		public Mode mode;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB098", Offset = "0x7FB098")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB0D0", Offset = "0x7FB0D0")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB108", Offset = "0x7FB108")]
		public float falloffSpeed;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x101E894", Offset = "0x101E894", VA = "0x101E894", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x101E9D0", Offset = "0x101E9D0", VA = "0x101E9D0")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x101EBD0", Offset = "0x101EBD0", VA = "0x101EBD0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x101EEFC", Offset = "0x101EEFC", VA = "0x101EEFC")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x101F124", Offset = "0x101F124", VA = "0x101F124", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x101F290", Offset = "0x101F290", VA = "0x101F290")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x101F320", Offset = "0x101F320", VA = "0x101F320")]
		private void Start()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x101F3AC", Offset = "0x101F3AC", VA = "0x101F3AC")]
		private void Update()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x101F480", Offset = "0x101F480", VA = "0x101F480")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x101F664", Offset = "0x101F664", VA = "0x101F664")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000104")]
		public class EffectorLink
		{
			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000750")]
			[Address(RVA = "0x102064C", Offset = "0x102064C", VA = "0x102064C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1020204", Offset = "0x1020204", VA = "0x1020204", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1020390", Offset = "0x1020390", VA = "0x1020390", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1020644", Offset = "0x1020644", VA = "0x1020644")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7F697C", Offset = "0x7F697C")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB140", Offset = "0x7FB140")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FB140", Offset = "0x7FB140")]
		public float weight;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB194", Offset = "0x7FB194")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB1CC", Offset = "0x7FB1CC")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB218", Offset = "0x7FB218")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform leftHandTarget;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform rightHandTarget;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform leftFootTarget;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform headTarget;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x102065C", Offset = "0x102065C", VA = "0x102065C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1020A84", Offset = "0x1020A84", VA = "0x1020A84")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1021480", Offset = "0x1021480", VA = "0x1021480")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x1700006B")]
		private bool holding
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x1021690", Offset = "0x1021690", VA = "0x1021690")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1021508", Offset = "0x1021508", VA = "0x1021508")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000523")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x10216C4", Offset = "0x10216C4", VA = "0x10216C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1021954", Offset = "0x1021954", VA = "0x1021954")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1021B30", Offset = "0x1021B30", VA = "0x1021B30")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1021C64", Offset = "0x1021C64", VA = "0x1021C64")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1021DC8", Offset = "0x1021DC8", VA = "0x1021DC8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1022054", Offset = "0x1022054", VA = "0x1022054")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x102231C", Offset = "0x102231C", VA = "0x102231C")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1022330", Offset = "0x1022330", VA = "0x1022330", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x10225CC", Offset = "0x10225CC", VA = "0x10225CC")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x10225E0", Offset = "0x10225E0", VA = "0x10225E0", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1022838", Offset = "0x1022838", VA = "0x1022838")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x102315C", Offset = "0x102315C", VA = "0x102315C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x10231C0", Offset = "0x10231C0", VA = "0x10231C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x10233F8", Offset = "0x10233F8", VA = "0x10233F8")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7F69E0", Offset = "0x7F69E0")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1023400", Offset = "0x1023400", VA = "0x1023400")]
		private void Start()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1023458", Offset = "0x1023458", VA = "0x1023458")]
		private void Update()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x10234CC", Offset = "0x10234CC", VA = "0x10234CC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1023530", Offset = "0x1023530", VA = "0x1023530")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6CC0", Offset = "0x7F6CC0")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000C0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000754")]
				[Address(RVA = "0x10239A0", Offset = "0x10239A0", VA = "0x10239A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000756")]
				[Address(RVA = "0x1023A10", Offset = "0x1023A10", VA = "0x1023A10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0x10236F8", Offset = "0x10236F8", VA = "0x10236F8")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000752")]
			[Address(RVA = "0x1023734", Offset = "0x1023734", VA = "0x1023734", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000753")]
			[Address(RVA = "0x1023738", Offset = "0x1023738", VA = "0x1023738", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000755")]
			[Address(RVA = "0x10239A8", Offset = "0x10239A8", VA = "0x10239A8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1023540", Offset = "0x1023540", VA = "0x1023540")]
		private void Start()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1023618", Offset = "0x1023618", VA = "0x1023618")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1023660", Offset = "0x1023660", VA = "0x1023660")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x800FCC", Offset = "0x800FCC")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1023724", Offset = "0x1023724", VA = "0x1023724")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7F6A44", Offset = "0x7F6A44")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6CD0", Offset = "0x7F6CD0")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000C2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600075A")]
				[Address(RVA = "0xF8AA2C", Offset = "0xF8AA2C", VA = "0xF8AA2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600075C")]
				[Address(RVA = "0xF8AA9C", Offset = "0xF8AA9C", VA = "0xF8AA9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000757")]
			[Address(RVA = "0xF8A850", Offset = "0xF8A850", VA = "0xF8A850")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0xF8A884", Offset = "0xF8A884", VA = "0xF8A884", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0xF8A888", Offset = "0xF8A888", VA = "0xF8A888", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0xF8AA34", Offset = "0xF8AA34", VA = "0xF8AA34", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xF8A718", Offset = "0xF8A718", VA = "0xF8A718")]
		private void Start()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xF8A7DC", Offset = "0xF8A7DC", VA = "0xF8A7DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x801030", Offset = "0x801030")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xF8A87C", Offset = "0xF8A87C", VA = "0xF8A87C")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000107")]
		public class EffectorLink
		{
			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x600075D")]
			[Address(RVA = "0xF8B0CC", Offset = "0xF8B0CC", VA = "0xF8B0CC")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0xF8C22C", Offset = "0xF8C22C", VA = "0xF8C22C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0xF8B604", Offset = "0xF8B604", VA = "0xF8B604")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0xF8C31C", Offset = "0xF8C31C", VA = "0xF8C31C")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000761")]
			[Address(RVA = "0xF8C504", Offset = "0xF8C504", VA = "0xF8C504")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0xF8C5A0", Offset = "0xF8C5A0", VA = "0xF8C5A0")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0xF8C638", Offset = "0xF8C638", VA = "0xF8C638")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0xF8BF94", Offset = "0xF8BF94", VA = "0xF8BF94")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000765")]
			[Address(RVA = "0xF8C6D0", Offset = "0xF8C6D0", VA = "0xF8C6D0")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xF8B038", Offset = "0xF8B038", VA = "0xF8B038")]
		private void Start()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xF8B564", Offset = "0xF8B564", VA = "0xF8B564")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xF8BE98", Offset = "0xF8BE98", VA = "0xF8BE98")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xF8C224", Offset = "0xF8C224", VA = "0xF8C224")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB304", Offset = "0x7FB304")]
		public Transform to;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB33C", Offset = "0x7FB33C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FB33C", Offset = "0x7FB33C")]
		public float transferMotion;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xF8C710", Offset = "0xF8C710", VA = "0xF8C710")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xF8C754", Offset = "0xF8C754", VA = "0xF8C754")]
		private void Update()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xF8C8EC", Offset = "0xF8C8EC", VA = "0xF8C8EC")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB390", Offset = "0x7FB390")]
		public Transform leftHandTarget;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xF8CB18", Offset = "0xF8CB18", VA = "0xF8CB18")]
		private void Start()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xF8CD78", Offset = "0xF8CD78", VA = "0xF8CD78")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xF8D148", Offset = "0xF8D148", VA = "0xF8D148")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xF8D2C0", Offset = "0xF8D2C0", VA = "0xF8D2C0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xF8D420", Offset = "0xF8D420", VA = "0xF8D420")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xF8D85C", Offset = "0xF8D85C", VA = "0xF8D85C", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xF8DD20", Offset = "0xF8DD20", VA = "0xF8DD20")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xF8DEE4", Offset = "0xF8DEE4", VA = "0xF8DEE4")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1019B04", Offset = "0x1019B04", VA = "0x1019B04")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1019C24", Offset = "0x1019C24", VA = "0x1019C24")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1019CD4", Offset = "0x1019CD4", VA = "0x1019CD4")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6CE0", Offset = "0x7F6CE0")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000C4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000769")]
				[Address(RVA = "0x10230E4", Offset = "0x10230E4", VA = "0x10230E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600076B")]
				[Address(RVA = "0x1023154", Offset = "0x1023154", VA = "0x1023154", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0x1022C80", Offset = "0x1022C80", VA = "0x1022C80")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000767")]
			[Address(RVA = "0x1022EEC", Offset = "0x1022EEC", VA = "0x1022EEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0x1022EF0", Offset = "0x1022EF0", VA = "0x1022EF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0x10230EC", Offset = "0x10230EC", VA = "0x10230EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x102284C", Offset = "0x102284C", VA = "0x102284C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x10229F0", Offset = "0x10229F0", VA = "0x10229F0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x102297C", Offset = "0x102297C", VA = "0x102297C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x801094", Offset = "0x801094")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1022CAC", Offset = "0x1022CAC", VA = "0x1022CAC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1022DC0", Offset = "0x1022DC0", VA = "0x1022DC0")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1022ED0", Offset = "0x1022ED0", VA = "0x1022ED0")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FB3F8", Offset = "0x7FB3F8")]
		public float weight;

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x100FE60", Offset = "0x100FE60", VA = "0x100FE60")]
		private void Start()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x100FECC", Offset = "0x100FECC", VA = "0x100FECC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x100FFE0", Offset = "0x100FFE0", VA = "0x100FFE0")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000109")]
		public class Part
		{
			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x600076C")]
			[Address(RVA = "0xF8C994", Offset = "0xF8C994", VA = "0xF8C994")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x600076D")]
			[Address(RVA = "0xF8CB10", Offset = "0xF8CB10", VA = "0xF8CB10")]
			public Part()
			{
			}
		}

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xF8C900", Offset = "0xF8C900", VA = "0xF8C900")]
		private void Update()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xF8CB08", Offset = "0xF8CB08", VA = "0xF8CB08")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReactionVRIK hitReaction;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1019FC8", Offset = "0x1019FC8", VA = "0x1019FC8")]
		private void Update()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x101A1D4", Offset = "0x101A1D4", VA = "0x101A1D4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x101A2A4", Offset = "0x101A2A4", VA = "0x101A2A4")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB430", Offset = "0x7FB430")]
		public VRIK ik;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB468", Offset = "0x7FB468")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB4A0", Offset = "0x7FB4A0")]
		public Transform headTracker;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB4D8", Offset = "0x7FB4D8")]
		public Transform bodyTracker;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB510", Offset = "0x7FB510")]
		public Transform leftHandTracker;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB548", Offset = "0x7FB548")]
		public Transform rightHandTracker;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB580", Offset = "0x7FB580")]
		public Transform leftFootTracker;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB5B8", Offset = "0x7FB5B8")]
		public Transform rightFootTracker;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FB5F0", Offset = "0x7FB5F0")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xF8DF08", Offset = "0xF8DF08", VA = "0xF8DF08")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xF8E074", Offset = "0xF8E074", VA = "0xF8E074")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xF8E0DC", Offset = "0xF8E0DC", VA = "0xF8E0DC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xF8E14C", Offset = "0xF8E14C", VA = "0xF8E14C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xF8E3BC", Offset = "0xF8E3BC", VA = "0xF8E3BC")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xF8E434", Offset = "0xF8E434", VA = "0xF8E434")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xF8EB50", Offset = "0xF8EB50", VA = "0xF8EB50")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x1700006C")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x1010900", Offset = "0x1010900", VA = "0x1010900", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x10108CC", Offset = "0x10108CC", VA = "0x10108CC", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1010908", Offset = "0x1010908", VA = "0x1010908")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x10109D4", Offset = "0x10109D4", VA = "0x10109D4", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1010CBC", Offset = "0x1010CBC", VA = "0x1010CBC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1010FDC", Offset = "0x1010FDC", VA = "0x1010FDC", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1010CCC", Offset = "0x1010CCC", VA = "0x1010CCC")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1010FEC", Offset = "0x1010FEC", VA = "0x1010FEC")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7F6AA8", Offset = "0x7F6AA8")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1011004", Offset = "0x1011004", VA = "0x1011004", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1011064", Offset = "0x1011064", VA = "0x1011064", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x10111B0", Offset = "0x10111B0", VA = "0x10111B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1011384", Offset = "0x1011384", VA = "0x1011384")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7F6B0C", Offset = "0x7F6B0C")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FB688", Offset = "0x7FB688")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x4000501")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000502")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x1700006D")]
		public override bool animationGrounded
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x1011458", Offset = "0x1011458", VA = "0x1011458", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x101139C", Offset = "0x101139C", VA = "0x101139C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1011428", Offset = "0x1011428", VA = "0x1011428", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x101155C", Offset = "0x101155C", VA = "0x101155C", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1011A7C", Offset = "0x1011A7C", VA = "0x1011A7C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1011C60", Offset = "0x1011C60", VA = "0x1011C60")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7F6B70", Offset = "0x7F6B70")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7F6B70", Offset = "0x7F6B70")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FB6CC", Offset = "0x7FB6CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB6CC", Offset = "0x7FB6CC")]
		public Transform gravityTarget;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB72C", Offset = "0x7FB72C")]
		[SerializeField]
		protected float gravityMultiplier;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x400050E")]
		protected const float half = 0.5f;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x6000577")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1012218", Offset = "0x1012218", VA = "0x1012218")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x10123B0", Offset = "0x10123B0", VA = "0x10123B0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x101259C", Offset = "0x101259C", VA = "0x101259C", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1012858", Offset = "0x1012858", VA = "0x1012858")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1012924", Offset = "0x1012924", VA = "0x1012924")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1012B6C", Offset = "0x1012B6C", VA = "0x1012B6C")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1012D6C", Offset = "0x1012D6C", VA = "0x1012D6C")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1012DA4", Offset = "0x1012DA4", VA = "0x1012DA4")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1012DDC", Offset = "0x1012DDC", VA = "0x1012DDC")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1012EE0", Offset = "0x1012EE0", VA = "0x1012EE0")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x200010A")]
		public enum MoveMode
		{
			[Token(Token = "0x40007C8")]
			Directional,
			[Token(Token = "0x40007C9")]
			Strafe
		}

		[Token(Token = "0x200010B")]
		public struct AnimState
		{
			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FB7C8", Offset = "0x7FB7C8")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FB800", Offset = "0x7FB800")]
		public MoveMode moveMode;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FB838", Offset = "0x7FB838")]
		public bool lookInCameraDirection;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FB870", Offset = "0x7FB870")]
		public float airSpeed;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airControl;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float jumpPower;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FB8A8", Offset = "0x7FB8A8")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float wallRunMaxLength;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FB8F4", Offset = "0x7FB8F4")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FB92C", Offset = "0x7FB92C")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AnimState animState;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		protected Vector3 moveDirection;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private bool fixedFrame;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private float wallRunEndTime;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Vector3 gravity;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private float velocityY;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool doubleJumped;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		private bool jumpReleased;

		[Token(Token = "0x1700006E")]
		public bool onGround
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x101334C", Offset = "0x101334C", VA = "0x101334C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8010F8", Offset = "0x8010F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x1013354", Offset = "0x1013354", VA = "0x1013354")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801108", Offset = "0x801108")]
			private set
			{
			}
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1013360", Offset = "0x1013360", VA = "0x1013360", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x10134F8", Offset = "0x10134F8", VA = "0x10134F8")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x101359C", Offset = "0x101359C", VA = "0x101359C", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x10136D8", Offset = "0x10136D8", VA = "0x10136D8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x101484C", Offset = "0x101484C", VA = "0x101484C", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1014C1C", Offset = "0x1014C1C", VA = "0x1014C1C", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1013E34", Offset = "0x1013E34", VA = "0x1013E34")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1014D3C", Offset = "0x1014D3C", VA = "0x1014D3C")]
		private void WallRun()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x10153E8", Offset = "0x10153E8", VA = "0x10153E8")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x101492C", Offset = "0x101492C", VA = "0x101492C")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x101548C", Offset = "0x101548C", VA = "0x101548C", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x10159D0", Offset = "0x10159D0", VA = "0x10159D0")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x1015BCC", Offset = "0x1015BCC", VA = "0x1015BCC", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x10143C4", Offset = "0x10143C4", VA = "0x10143C4")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1015DF8", Offset = "0x1015DF8", VA = "0x1015DF8")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7F6BFC", Offset = "0x7F6BFC")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010C")]
		public enum RotationMode
		{
			[Token(Token = "0x40007D2")]
			Smooth,
			[Token(Token = "0x40007D3")]
			Linear
		}

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB93C", Offset = "0x7FB93C")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB988", Offset = "0x7FB988")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FB9D4", Offset = "0x7FB9D4")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBA20", Offset = "0x7FBA20")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBA6C", Offset = "0x7FBA6C")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBAB8", Offset = "0x7FBAB8")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FBB04", Offset = "0x7FBB04")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x1700006F")]
		public bool isGrounded
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x1016DA0", Offset = "0x1016DA0", VA = "0x1016DA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801118", Offset = "0x801118")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x1024228", Offset = "0x1024228", VA = "0x1024228")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801128", Offset = "0x801128")]
			private set
			{
			}
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1024234", Offset = "0x1024234", VA = "0x1024234")]
		private void Start()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x10242C0", Offset = "0x10242C0", VA = "0x10242C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1024A78", Offset = "0x1024A78", VA = "0x1024A78")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x102431C", Offset = "0x102431C", VA = "0x102431C")]
		private void Rotate()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1024778", Offset = "0x1024778", VA = "0x1024778")]
		private void Move()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1024AC8", Offset = "0x1024AC8", VA = "0x1024AC8")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1024BC0", Offset = "0x1024BC0", VA = "0x1024BC0")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1024C60", Offset = "0x1024C60", VA = "0x1024C60")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xF8D428", Offset = "0xF8D428", VA = "0xF8D428", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xF8D4B4", Offset = "0xF8D4B4", VA = "0xF8D4B4", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xF8D7D8", Offset = "0xF8D7D8", VA = "0xF8D7D8")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xF8D830", Offset = "0xF8D830", VA = "0xF8D830")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x200010D")]
		public struct State
		{
			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xF8D474", Offset = "0xF8D474", VA = "0xF8D474", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xF8D990", Offset = "0xF8D990", VA = "0xF8D990", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xF8D84C", Offset = "0xF8D84C", VA = "0xF8D84C")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x100FE1C", Offset = "0x100FE1C", VA = "0x100FE1C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x100FE58", Offset = "0x100FE58", VA = "0x100FE58")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xF8A600", Offset = "0xF8A600", VA = "0xF8A600")]
		private void Update()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xF8A634", Offset = "0xF8A634", VA = "0xF8A634")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xF8A704", Offset = "0xF8A704", VA = "0xF8A704")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B2")]
	public class Navigator
	{
		[Token(Token = "0x200010E")]
		public enum State
		{
			[Token(Token = "0x40007DA")]
			Idle,
			[Token(Token = "0x40007DB")]
			Seeking,
			[Token(Token = "0x40007DC")]
			OnPath
		}

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBB54", Offset = "0x7FBB54")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBB8C", Offset = "0x7FBB8C")]
		public float cornerRadius;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBBC4", Offset = "0x7FBBC4")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBBFC", Offset = "0x7FBBFC")]
		public float maxSampleDistance;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FBC34", Offset = "0x7FBC34")]
		public float nextPathInterval;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FBC6C", Offset = "0x7FBC6C")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FBC7C", Offset = "0x7FBC7C")]
		private State <state>k__BackingField;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x17000070")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x101F678", Offset = "0x101F678", VA = "0x101F678")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801138", Offset = "0x801138")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x101F684", Offset = "0x101F684", VA = "0x101F684")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801148", Offset = "0x801148")]
			private set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public State state
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x101F690", Offset = "0x101F690", VA = "0x101F690")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801158", Offset = "0x801158")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x101F698", Offset = "0x101F698", VA = "0x101F698")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801168", Offset = "0x801168")]
			private set
			{
			}
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x101F6A0", Offset = "0x101F6A0", VA = "0x101F6A0")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x101F774", Offset = "0x101F774", VA = "0x101F774")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x101FD30", Offset = "0x101FD30", VA = "0x101FD30")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x101FDA0", Offset = "0x101FDA0", VA = "0x101FDA0")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x101FBF8", Offset = "0x101FBF8", VA = "0x101FBF8")]
		private void Stop()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x101FC6C", Offset = "0x101FC6C", VA = "0x101FC6C")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x101FF08", Offset = "0x101FF08", VA = "0x101FF08")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1020198", Offset = "0x1020198", VA = "0x1020198")]
		public Navigator()
		{
		}
	}
}
